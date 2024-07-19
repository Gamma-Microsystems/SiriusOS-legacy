using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using SimpleFileSystem;

namespace sirpe
{
    public class Kernel: Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
        }
        
        protected override void Run()
        {
        }
    }
}
