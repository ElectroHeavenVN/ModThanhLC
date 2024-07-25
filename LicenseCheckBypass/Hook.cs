using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HarmonyLib;

namespace LicenseCheckBypass
{
    public static class Hook
    {
        static string licenseKey = "";

        static int Initialize(string arg)
        {
            new Harmony("LicenseCheckBypass").PatchAll();
            licenseKey = DeviceInformation.GenerateLicense("DRAGONBALL237");
            new Thread(ChangeWindowTitle) { IsBackground = true }.Start();
            return 0;
        }

        static void ChangeWindowTitle()
        {
            Process currentProcess = Process.GetCurrentProcess();
            PropertyInfo text = typeof(Form).GetProperty("Text");
            Assembly manager = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(assembly => assembly.GetType("DragonBoyManager.MainController") != null);
            if (manager == null)
                return;
            FieldInfo instance = manager.GetType("DragonBoyManager.MainController").GetField("instance", BindingFlags.Static | BindingFlags.Public);
            object instanceValue;
            do
            {
                instanceValue = instance.GetValue(null);
                Thread.Sleep(250);
            } while (instanceValue == null);
            string windowTitle = (string)text.GetValue(instanceValue);
            while (currentProcess.MainWindowHandle == IntPtr.Zero || !windowTitle.Contains("]"))
            {
                Thread.Sleep(1000);
                windowTitle = (string)text.GetValue(instanceValue);
                currentProcess.Refresh();
            }
            text.SetValue(instance.GetValue(null), windowTitle + " - License check bypassed");
        }

        [HarmonyPatch(typeof(HttpClient), nameof(HttpClient.GetAsync), typeof(string))]
        public class GetAsyncHook
        {
            static bool Prefix(string requestUri, ref Task<HttpResponseMessage> __result)
            {
                if (requestUri != "https://docs.google.com/spreadsheets/d/1ht_P2kqVZgMuAfHEtSMEGOmS1IloohmjoY6Gbp5EvlI/edit#gid=0")
                    return true;
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                httpResponseMessage.Content = new StringContent(licenseKey + "|DBOPROTHANHLC|[Option1:T]-[Option2:T]-[Option3:T]-[Option4:T]|9999-12-31|admin|hoantat|2.0|endkey|");
                __result = Task.FromResult(httpResponseMessage);
                return false;
            }
        }
    }
}
