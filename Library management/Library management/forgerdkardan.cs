using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class ForgerdKardan
    {
        public void SetRoundedButton(Button button, int cornerRadius)
        {
            // Create a new graphics path for the button
            GraphicsPath path = new GraphicsPath();

            // Add rounded corners to the graphics path
            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            // Set the button's region to the graphics path
            button.Region = new Region(path);

            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

    }

}
