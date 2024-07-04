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
            Console.WriteLine("Welcome to SiriusOS!");
        }
        
        protected override void Run()
        {
            Console.Write("$ ");
            var builtin = Console.ReadLine();
            var OS_VER = "1.0.0 Milestone 1, 0.03";
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
                    break;
                case "poweroff":
                    Cosmos.System.Power.Shutdown();
                    break;
                case "reboot":
                    Cosmos.System.Power.Reboot();
                    break;
            }
        }
    }
}
