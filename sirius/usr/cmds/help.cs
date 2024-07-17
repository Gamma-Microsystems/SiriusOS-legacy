using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class help : Command
    {
        public help (String name) : base (name) { }

        public override String execute (String[] args)
        {
            Console.WriteLine("ver : display version");
            Console.WriteLine("poweroff : turn off the computer");
            Console.WriteLine("reboot : reboot the computer");
            Console.WriteLine("clear : clears the screen");
            Console.WriteLine("fvfs mkdir <PATH> : creates a directory");
            Console.WriteLine("fvfs touch <PATH> : creates a file");
            Console.WriteLine("fvfs rm <PATH> : removes a file");
            Console.WriteLine("fvfs rm -r <PATH> : removes a directory");
            Console.WriteLine("fvfs write <PATH> : simple writer");
            Console.WriteLine("fvfs cat <PATH> : reads a file");
            Console.WriteLine("ls : shows directories and files");
            Console.WriteLine("sUI : starts Sirius UI");
            //Console.WriteLine("cd : changes directory");
            return "";
        }
    }
}