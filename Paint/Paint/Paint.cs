using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
      
        public Paint()
        {
         
            InitializeComponent();
            this.Width = 450;
            this.Height = 550;
            bm = new Bitmap(pictureBox_big.Width, pictureBox_big.Height);
            g = Graphics.FromImage(bm);
            pictureBox_big.Image = bm;

        }
            
            Bitmap bm;
            ColorDialog cd = new ColorDialog();
            Graphics g;
            Pen p = new Pen(Color.Black, 3);
            Pen erase = new Pen(Color.White, 20);
            Point px, py;
            int x, y, sx, sy, dx, dy;
            bool paint;
            int index;
         
            



        private void pictureBox_big_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            dx = e.X;
            dy = e.Y;
        }

        

        private void pictureBox_big_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p,px,py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
          
            }
            pictureBox_big.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - dx;
            sy = e.Y - dy;
        }



        private void pictureBox_big_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - dx;
            sy = y - dy;
            if (index==3)
            {
                g.DrawEllipse(p, dx, dy, sx, sy);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, dx, dy, sx, sy);
            }
            if (index == 5)
            {
                g.DrawLine(p, dx, dy, x, y);
            }
        }

  

        private void button_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

   

        private void button_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

    

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

      

        private void button_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void button_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void pictureBox_big_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, dx, dy, sx, sy);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, dx, dy, sx, sy);
                }
                if (index == 5)
                {
                    g.DrawLine(p, dx, dy, x, y);
                }

            }
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox_big.Image = bm;
            index = 0;
        }
        private void button_piccolor_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                button_piccolor.BackColor = cd.Color;
                p.Color = cd.Color;

            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox_big.Width, pictureBox_big.Height), bm.PixelFormat);
                btm.Save(sfd.FileName);
            }
        }
    }
}
