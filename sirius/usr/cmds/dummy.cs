using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class dummy : Command
    {
        public dummy (String name) : base (name) { }

        public override String execute (String[] args)
        {
            return "";
        }
    }
}