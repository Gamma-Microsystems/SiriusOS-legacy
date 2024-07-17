using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Sirius.Builtin;
using Sirius.UI;

namespace sirius
{
    public class Kernel: Sys.Kernel
    {   
        private Sys.FileSystem.CosmosVFS fvfs; // Fat/Virtual File System
        public static bool grun;
        int AlzheimerRAM;

        protected override void BeforeRun()
        {
            this.fvfs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.fvfs);
            Console.WriteLine("NOTE: The FS will not work if it is runned on CD/DVD or VM's ISO");
            Console.WriteLine("\nWelcome to SiriusOS!\n");
        }
        
        protected override void Run()
        {
            // TODO: change to switches because yes

            // Are we in GUI?
            if(!grun)
            {
                Shell shell = new Sirius.Builtin.Shell();
                Console.Write("ROOT# ");
                var builtin = Console.ReadLine();
                var response = shell.proccesInput(builtin);
                Console.WriteLine(response);
            }
            else
            {
                gmain.refresh();
            }

            // AlzheimerRAM (Garbage collection) stuff
            if(AlzheimerRAM >= 20)
            {
                Heap.Collect();
                AlzheimerRAM = 0; // That's how mafia works
            }
            else
                AlzheimerRAM++;
        }
    }
}