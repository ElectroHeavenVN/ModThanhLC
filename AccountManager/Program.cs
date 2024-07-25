using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using DragonBoyManager;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
#if DEBUG
        Assembly assembly = Assembly.LoadFrom("Lib\\LicenseCheckBypass.dll");
        assembly.GetType("LicenseCheckBypass.Hook").GetMethod("Initialize", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { "" });
#else
        Thread.Sleep(1000); //Wait for injector to inject the DLL
#endif
        MainController.language = int.Parse(File.ReadAllText("Data/QLTK/language.ini"));
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainController());
    }
}

