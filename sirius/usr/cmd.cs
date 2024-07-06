using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Builtin
{
    public class Command
    {
        public readonly String name;
        public Command(String name) { this.name=name; }
        public virtual String execute(String[] args) { return ""; }
    }
}