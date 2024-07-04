using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace sirius
{
    public class Kernel: Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("\nWelcome to SiriusOS!\n");
        }
        
        protected override void Run()
        {
            Console.Write("$ ");
            var builtin = Console.ReadLine();
            var OS_VER = "1.0.0 Milestone 1, 0.04";
            switch (builtin) {
                default:
                    Console.WriteLine(builtin + ": Is not a valid command");
                    break;
                case "ver":
                    Console.WriteLine(OS_VER);
                    break;
                case "help":
                    Console.WriteLine("ver - display version");
                    Console.WriteLine("poweroff - turn off the computer");
                    Console.WriteLine("reboot - reboot the computer");
                    Console.WriteLine("pcinf - shows the computer information");
                    break;
                case "poweroff":
                    Cosmos.System.Power.Shutdown();
                    break;
                case "reboot":
                    Cosmos.System.Power.Reboot();
                    break;
                case "pcinf":
                    string CPUBRAND = Cosmos.Core.CPU.GetCPUBrandString();
                    string CPUVENDOR = Cosmos.Core.CPU.GetCPUVendorName();
                    uint RAMSIZE = Cosmos.Core.CPU.GetAmountOfRAM();
                    ulong FREERAM = Cosmos.Core.GCImplementation.GetAvailableRAM();
                    uint RAMUSED = Cosmos.Core.GCImplementation.GetUsedRAM();
                    Console.WriteLine(@"CPU: {0}
                                        CPU Vendor: {1}
                                        Amount of RAM: {2}
                                        Available RAM: {3}
                                        Used RAM: {4}",CPUBRAND,CPUVENDOR,RAMSIZE,FREERAM,RAMUSED);
                    break;
            }
        }
    }
}
