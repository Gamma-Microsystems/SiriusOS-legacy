using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class reboot : Command
    {
        public reboot (String name) : base (name) { }

        public override String execute (String[] args)
        {
            Cosmos.System.Power.Reboot();
            return "";
        }
    }
}