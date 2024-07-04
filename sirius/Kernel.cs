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
            var OS_VER = "1.0.0 Milestone 1, 0.02";
            switch (builtin) {
                default:
                    Console.WriteLine(builtin + ": Is not a valid command");
                    break;
                case "ver":
                    Console.WriteLine(OS_VER);
                    break;
                case "help":
                    Console.WriteLine("ver - display version");
                    break;
            }
        }
    }
}
