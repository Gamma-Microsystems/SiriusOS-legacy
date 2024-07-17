// Close your eyes please
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sirius.UI
{
    public static class wtf
    {
		public static void DrawFullRoundedRectangle(int x, int y, int width, int height, int radius, Color col)
		{
			gmain.cmain.DrawFilledRectangle(col, x + radius, y, width - 2 * radius, height);
			gmain.cmain.DrawFilledRectangle(col, x, y + radius, radius, height - 2 * radius);
			gmain.cmain.DrawFilledRectangle(col, x + width - radius, y + radius, radius, height - 2 * radius);
			gmain.cmain.DrawFilledCircle(col, x + radius, y + radius, radius);
			gmain.cmain.DrawFilledCircle(col, x + width - radius - 1, y + radius, radius);
			gmain.cmain.DrawFilledCircle(col, x + radius, y + height - radius - 1, radius);
			gmain.cmain.DrawFilledCircle(col, x + width - radius - 1, y + height - radius - 1, radius);
		}
		public static void DrawTopRoundedRectangle(int x, int y, int width, int height, int radius, Color col)
		{
			gmain.cmain.DrawFilledRectangle(col, x + radius, y, width - 2 * radius, height);
			gmain.cmain.DrawFilledRectangle(col, x, y + radius, width, height - radius);
			gmain.cmain.DrawFilledCircle(col, x + radius, y + radius, radius);
			gmain.cmain.DrawFilledCircle(col, x + width - radius - 1, y + radius, radius);
		}
    }
}
