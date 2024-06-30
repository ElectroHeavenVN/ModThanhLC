using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DragonBoyManager;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Thread.Sleep(1000); //Wait for injector to inject the DLL
        MainController.language = int.Parse(File.ReadAllText("Data/QLTK/language.ini"));
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainController());
    }
}

