using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCircle_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Height = 500;
            this.Width = 500;
        }


        public void PutPixel(Graphics g, int x, int y, Color c)
        {
            Bitmap bm = new Bitmap(1, 1);
            bm.SetPixel(0, 0, c);
            g.DrawImageUnscaled(bm, x, y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int ctx = e.X;   // center X
            int cty = e.Y;   // center Y


            Graphics myGraphics = this.CreateGraphics();

            myGraphics.Clear(Color.White);

            double radius = 100 ;  //半徑

            for (double i = 0.0; i <= 360; i += 0.1)
            {
                double angle = Math.PI * i / 180; // θ 係數


                // 圓半徑為1時 ( x , y ) = ( cosθ , sinθ )

                int x = (int)(ctx + radius * Math.Cos(angle));
                int y = (int)(cty + radius * Math.Sin(angle));

                PutPixel(myGraphics, x, y, Color.Black);

            }

            myGraphics.DrawLine(new Pen(Color.Black), new Point(ctx, 0), new Point(ctx, Height));
            myGraphics.DrawLine(new Pen(Color.Black), new Point(0, cty), new Point(Width, cty));

        }
    }
}
