using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Sirius.UI;

namespace Sirius.Builtin
{
    public class sUI : Command
    {
        public sUI (String name) : base (name) { }

        public override String execute (String[] args)
        {
            init.gui();
            return "";
        }
    }
}