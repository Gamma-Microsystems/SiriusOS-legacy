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
            Console.WriteLine("This Product is licensed under GNU General Public License 3.\nBy installing this product you agree with this license.\n<https://raw.githubusercontent.com/gamma63/SiriusOS/pc/LICENSE>");
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
                            UnderConstruction();
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
