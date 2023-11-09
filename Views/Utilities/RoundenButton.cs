using System.Drawing.Drawing2D;

namespace Views.Utilities
{
    internal class RoundenButton : Button
    {
        private int cornerRadius = 8;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = cornerRadius * 2;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);
        }
    }
}
