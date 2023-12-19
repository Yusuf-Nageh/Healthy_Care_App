using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp11
{
    internal class rb:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath P = new GraphicsPath();
            P.AddEllipse(0,0, Width, Height);
            this.Region=new System.Drawing.Region(P);
            base.OnPaint(pevent);
        }
    }
}
