using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class cd : Command
    {
        public cd (String name) : base (name) { }

        public override String execute (String[] args)
        {
            //string _curdir = @"0:\";
            //_curdir = Console.ReadLine();
            return "";
        }
    }
}