using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class pcinf : Command
    {
        public pcinf (String name) : base (name) { }

        public override String execute (String[] args)
        {
            string CPUBRAND = Cosmos.Core.CPU.GetCPUBrandString();
            string CPUVENDOR = Cosmos.Core.CPU.GetCPUVendorName();
            uint RAMSIZE = Cosmos.Core.CPU.GetAmountOfRAM();
            ulong FREERAM = Cosmos.Core.GCImplementation.GetAvailableRAM();
            uint RAMUSED = Cosmos.Core.GCImplementation.GetUsedRAM();
            Console.WriteLine(@"CPU: {0}
                            CPU Vendor: {1}
                            Amount of RAM: {2}
                            Available RAM: {3}
                            Used RAM: {4}",CPUBRAND,CPUVENDOR,RAMSIZE,FREERAM,RAMUSED);
            return "";
        }
    }
}