using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.Graphics;

namespace Sirius.UI
{
    public static class init
    {
        public static void gui()
        {
            Kernel.grun = true;
            gmain.bg = new Bitmap(Sirius.etc.bgB);
            gmain.cur = new Bitmap(Sirius.etc.CursorB);
            gstart();
        }
    }
}