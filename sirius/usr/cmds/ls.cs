using System;
using System.Collections.Generic;
using System.IO;

namespace Sirius.Builtin
{
    public class ls : Command
    {
        public ls (String name) : base (name) { }

        public override String execute (String[] args)
        {
            var filelist = Directory.GetFiles(@"0:\");
            var dirlist = Directory.GetDirectories(@"0:\");

            Console.WriteLine("Files:");
            foreach(var path in filelist)
            {
                Console.WriteLine(path);
            }

            Console.WriteLine("\nDirectories:");
            foreach(var path in dirlist)
            {
                Console.WriteLine(path);
            }
            
            if (dirlist.Length == 0)
            {
                foreach (var file in filelist)
                {
                    var content = File.ReadAllText(file);

                    Console.WriteLine("File name: " + file);
                    Console.WriteLine("File size: " + content.Length);
                    Console.WriteLine("Content: " + content);
                }
            }

            return "";
        }
    }
}