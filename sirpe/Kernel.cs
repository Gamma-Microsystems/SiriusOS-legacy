using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace sirpe
{
    public class Kernel: Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs;
        string current_directory = "0:\\";

        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.Clear();
            Console.WriteLine("SiriusOS Milestone 3 Setup\n\n");
            Console.WriteLine("Welcome to SiriusOS Milestone 3 setup!");
        }
        
        protected override void Run()
        {
        }
    }
}
