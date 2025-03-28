using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlightsApp.Overrides
{
    public class RoundedLabel : Label
    {
        public int CornerRadius { get; set; } = 20;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            graphicsPath.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
            graphicsPath.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            graphicsPath.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            graphicsPath.CloseAllFigures();

            this.Region = new Region(graphicsPath);

            base.OnPaint(e);
        }
    }
}
