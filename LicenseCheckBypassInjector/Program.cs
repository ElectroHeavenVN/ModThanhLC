using System;
using System.Diagnostics;
using System.Threading;
using ExtremeDumper.Injecting;
using NativeSharp;

namespace LicenseCheckBypassInjector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process process = Process.Start("DragonBoyManager.exe");
            Thread.Sleep(300);
            if (Injector.InjectManaged((uint)process.Id, "Lib\\LicenseCheckBypass.dll", "LicenseCheckBypass.Hook", "Initialize", "aaaa", InjectionClrVersion.V4))
                Console.WriteLine("Injection succeeded.");
            else
                Console.WriteLine("Injection failed.");
            Thread.Sleep(3000);
        }
    }
}
