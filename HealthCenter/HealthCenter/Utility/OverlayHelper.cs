using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
   public class OverlayHelper
    {
        public static Form Form { get; set; }

        public OverlayHelper(Form form)
        {
            Form = form;
        }

        public delegate void RenderData();

        public static DialogResult OpenOverLay(Form childform = null)
        {
            if (childform == null)
                throw new Exception("No form presented");

            using (Bitmap bmp = new Bitmap(Form.ClientRectangle.Width, Form.ClientRectangle.Height))
            {

                using (Graphics G = Graphics.FromImage(bmp))
                {

                    G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                    G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                    G.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                    G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;


                    G.CopyFromScreen(Form.PointToScreen(new Point(0, 0)), new Point(0, 0), Form.ClientRectangle.Size);
                    double percent = 0.80;
                    Color darken = Color.FromArgb((int)(255 * percent),
                        ColorTranslator.FromHtml("#212121"));
                    using (Brush brsh = new SolidBrush(darken))
                    {
                        G.FillRectangle(brsh, Form.ClientRectangle);
                    }
                }
                using (Panel p = new Panel())
                {
                    p.Location = new Point(0, 0);
                    p.Size = Form.ClientRectangle.Size;
                    p.BackgroundImage = bmp;

                    Form.Controls.Add(p);
                    p.BringToFront();

                    childform.StartPosition = FormStartPosition.CenterParent;



                    return childform.ShowDialog(Form);

                }
            }


        }
    }
}
