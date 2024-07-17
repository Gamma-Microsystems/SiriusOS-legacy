using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sirius.UI
{
    public class Task
    {
        public virtual void Run()
        {}

        public virtual void Start()
        {}

        public string Name;
        public WindowData WindowData = new WindowData();
    }

    public class WindowData
    {
        public Rectangle WinPos = new Rectangle { X = 100, Y = 100, Height = 100, Width = 100 };
        public bool MoveAble = true;
    }
}