using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_1204026
{
    [ToolboxBitmap(typeof(VerticalLabel), "P5_Percobaan1_1204026.VerticalLabel.ico")]
   
    public partial class VerticalLabel : Control
    {
        public VerticalLabel()
        {
            InitializeComponent();
        }
        private string labelText;
        [Category("verticalLabel"), Description("Text is displayed in container")]
        public override string Text
        {
            get
            { return labelText; }
            set
            {
                labelText = value;
                Invalidate();
            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float sngControlwidht;
            float sngControlHeight;

            float sngTransformX;
            float sngTransformy;
            Color labelColor = new Color();
            Pen labelBorderPen = new Pen(labelColor, 0);

            SolidBrush labelBackColorBrush = new SolidBrush(labelColor);
            SolidBrush labelForeColorBrush = new SolidBrush(base.ForeColor);

            if (this.DesignMode)
                base.ResizeRedraw = true;
            base.OnPaint(e);
            sngControlwidht = this.Size.Width;
            sngControlHeight = this.Size.Height;

            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, sngControlwidht, sngControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, sngControlwidht, sngControlHeight);

            //set translation
            sngTransformX = 0;
            sngTransformy = sngControlHeight;

            //translete origin
            e.Graphics.TranslateTransform(sngTransformX, sngTransformy);

            //set rotation
            e.Graphics.RotateTransform(270);
            //draw tect control
            e.Graphics.DrawString(labelText, Font,labelForeColorBrush ,0,0);


        }

    }
}
