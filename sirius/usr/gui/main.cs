using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Cosmos.System.Graphics;
using Cosmos.System;
using Cosmos.System.Graphics.Fonts;

namespace Sirius.UI
{
    public static class gmain
    {
        // Change the value of the variables here if you want to use an other screen resolution (1920x1080 or 1280x720 etc.)
        public static int ScrWidth = 1366, ScrHeight = 768;
        public static SVGAIICanvas cmain; // 4K ultra hd
        public static Bitmap bg, cur;
        public static Colors colors = new Colors();
        public static bool Clicked;
        public static Task currentTask;
        public static int MX, MY;
        static int oldX, oldY;
        public static PCScreenFont FontDefault = PCScreenFont.Default;

        public static void refresh()
        {
            MX = (int)MouseManager.X;
            MY = (int)MouseManager.Y;
            cmain.DrawImage(bg, 0, 0);
            gwmmove();
            TaskMGR.Update();
            cmain.DrawImageAlpha(cur, (int)MouseManager.X, (int)MouseManager.Y);
            if(MouseManager.MouseState == MouseState.Left)
                Clicked = true;
            else if(MouseManager.MouseState == MouseState.None && Clicked)
            {
                Clicked = false;
                currentTask = null;
            }
            cmain.Display();
        }

        public static void gwmmove()
        {
            if(currentTask != null)
            {
                currentTask.WindowData.WinPos.X = (int)MouseManager.X - oldX;
                currentTask.WindowData.WinPos.Y = (int)MouseManager.Y - oldY;
            }

            else if(MouseManager.MouseState == MouseState.Left && !Clicked)
            {
                foreach (var task in TaskMGR.tasklist)
                {
                    if(!task.WindowData.MoveAble)
                        continue;
                    if(MX > task.WindowData.Winpos.X && MX < task.WindowData.WinPos.X + task.WindowData.WinPos.Width)
                    {
                        if(MY > task.WindowData.Winpos.Y && MY < task.WindowData.WinPos.Y + Window.TopSize)
                        {
                            currentTask = task;
                            oldX = MX - task.WindowData.WinPos.X;
                            oldY = MY - task.WindowData.WinPos.Y;
                        }              
                    }
                }
            }
        }

        public static void gstart()
        {
            cmain = new SVGAIICanvas(new mode((uint)ScrWidth, (uint)ScrHeight, ColorDepth.ColorDepth32));
            MouseManager.ScreenWidth = (uint)ScrWidth;
            MouseManager.ScreenHeight = (uint)ScrHeight;
            MouseManager.X = (uint)ScrWidth / 2;
            MouseManager.Y = (uint)ScrHeight / 2;
            TaskMGR.Start(new Messagebox { WindowData = new WindowData{ WinPos = new Rectngle(100, 100, 350, 200) }, Name = "Hello World!" });
        }
    }
}