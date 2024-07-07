using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class clear : Command
    {
        public clear (String name) : base (name) { }

        public override String execute (String[] args)
        {
            Console.Clear();
            return "";
        }
    }
}