using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Builtin
{
    public class Shell
    {

        private List<Command> commands;

        public Shell() { 
            this.commands=new List<Command>();
            this.commands.Add(new help("help"));
            this.commands.Add(new pcinf("pcinf"));
            this.commands.Add(new fvfs("fvfs"));
            this.commands.Add(new ver("ver"));
            this.commands.Add(new poweroff("poweroff"));
            this.commands.Add(new reboot("reboot"));
        }

        public String proccesInput(String input)
        {
            String[] split = input.Split(' ');

            String label = split[0];

            List<String> args=new List<string>();

            int ctr = 0;
            foreach (String s in split) {
                if (ctr!=0)
                    args.Add(s);
                ++ctr;
            }

            foreach (Command cmd in this.commands)
            {
                if (cmd.name == label)
                    return cmd.execute(args.ToArray());
            }

            return "Command \""+label+"\" not found";
        }
    }
}