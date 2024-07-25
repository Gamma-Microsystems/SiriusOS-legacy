using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;  

namespace sirpe
{
    public class Kernel: Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs;
        string current_directory = @"0:\";

        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("SiriusOS Milestone 3 Setup\n\n");
            Console.WriteLine("Welcome to SiriusOS Milestone 3 setup!");
            Console.WriteLine("\nPress enter to contiune or escape to exit setup");
            try
            {
                while (true)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            Cosmos.System.Power.Shutdown();
                            break;
                        case ConsoleKey.Enter:
                            Agreement();
                            break;
                        default:
                            break;
                    }
                    Cosmos.Core.Memory.Heap.Collect();
                }
            }
            catch
            {
                Console.WriteLine("Fatal: Double fault.");
            }
        }

        public static void Agreement()
        {
            Console.Clear();
            Console.WriteLine("This Product is licensed under SPL 1.2 license\nBy installing this product you agree with this license.\n<https://raw.githubusercontent.com/gamma63/SiriusOS/pc/LICENSE>");
            Console.WriteLine("\n\n\nPress Y to contiune or N to exit setup");
            try
            {
                while (true)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.N:
                            Cosmos.System.Power.Shutdown();
                            break;
                        case ConsoleKey.Y:
                            SelectDisk();
                            break;
                        default:
                            break;
                    }
                    Cosmos.Core.Memory.Heap.Collect();
                }
            }
            catch
            {
                Console.WriteLine("Fatal: Double fault.");
            }
        }

        public static void SelectDisk()
        {
            Console.Clear();
            Console.WriteLine("Select hdd/ssd to install SiriusOS");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING ALL DATA ON HDD/SSD WILL BE FORMATED\nTHERE IS NO WARRANTY FOR THE PROGRAM, TO THE EXTENT PERMITTED BY\nAPPLICABLE LAW.  EXCEPT WHEN OTHERWISE STATED IN WRITING THE COPYRIGHT\nHOLDERS AND/OR OTHER PARTIES PROVIDE THE PROGRAM <<AS IS>> WITHOUT WARRANTY\nOF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING, BUT NOT LIMITED TO,\nTHE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR\nPURPOSE.  THE ENTIRE RISK AS TO THE QUALITY AND PERFORMANCE OF THE PROGRAM\nIS WITH YOU.  SHOULD THE PROGRAM PROVE DEFECTIVE, YOU ASSUME THE COST OF\nALL NECESSARY SERVICING, REPAIR OR CORRECTION.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void UnderConstruction()
        {
            Console.Clear();
            Console.WriteLine("Oops...\nSeems like this part is not yet implemented.\nPress escape to exit.");
            try
            {
                while (true)
                {
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.Escape:
                            Cosmos.System.Power.Shutdown();
                            break;
                        default:
                            break;
                    }
                    Cosmos.Core.Memory.Heap.Collect();
                }
            }
            catch
            {
                Console.WriteLine("Fatal: Double fault.");
            }
        }

        protected override void Run()
        {
        }
    }
}
