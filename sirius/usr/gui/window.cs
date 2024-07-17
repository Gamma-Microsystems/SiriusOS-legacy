using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.UI
{
    public static class Window
    {
        public static int HeaderSize = 30;

        public static void Header(Task task)
        {
            wtf.DrawTopRoundedRectangle(task.WindowData.WinPos.X,task.WindowData.WinPos.Y, task.WindowData.WinPos.Width, task.WindowData.WinPos.Height, HeaderSize, HeaderSize/2, gmain.colors.ColorDark);
            gmain.cmain.DrawString(task.Name, gmain.FontDefault, gmain.colors.ColorText, task.WindowData.WinPos.X + 15, task.WindowData.WinPos.Y + 8);
        }
    }
}