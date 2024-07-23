using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Sirius.Builtin;

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
            Shell shell = new Sirius.Builtin.Shell();
            Console.Write("$ ");
            var builtin = Console.ReadLine();
            var response = shell.proccesInput(builtin);
            Console.WriteLine(response);
        }
    }
}