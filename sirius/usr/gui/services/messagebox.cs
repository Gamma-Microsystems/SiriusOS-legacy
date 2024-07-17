using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.UI
{
    public class Messagebox : Task
    {
        public override void Run()
        {
            Window.DrawTop();
            int x = WindowData.WinPos.X;
            int y = WindowData.WinPos.Y;
            int width = WindowData.WinPos.Width;
            int height = WindowData.WinPos.Height;
            gmain.cmain.DrawFilledRectangle(gmain.colors.ColorMain, x, y + Window.HeaderSize, width, height-Window.HeaderSize);
        }
    }
}