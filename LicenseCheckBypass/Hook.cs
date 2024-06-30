using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DragonBoyManager;
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
            Process currentProcess = Process.GetCurrentProcess();
            while (currentProcess.MainWindowHandle == IntPtr.Zero || !MainController.instance.Text.Contains("]"))
            {
                Thread.Sleep(1000);
                currentProcess.Refresh();
            }
            MainController.instance.Text += " - License check bypassed";
            return 0;
        }

        [HarmonyPatch(typeof(HttpClient), nameof(HttpClient.GetAsync), typeof(string))]
        public class GetAsyncHook
        {
            static bool Prefix(string requestUri, ref Task<HttpResponseMessage> __result)
            {
                if (requestUri != "https://docs.google.com/spreadsheets/d/1ht_P2kqVZgMuAfHEtSMEGOmS1IloohmjoY6Gbp5EvlI/edit#gid=0")
                    return true;
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                httpResponseMessage.Content = new StringContent(licenseKey + "|DBOPROTHANHLC|[Option1:T]-[Option2:T]-[Option3:T]-[Option4:T]|9999-12-31|admin|hoantat|1.8|endkey|");
                __result = Task.FromResult(httpResponseMessage);
                return false;
            }
        }
    }
}
