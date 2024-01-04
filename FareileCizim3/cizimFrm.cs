using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareileCizim3
{
    public partial class cizimFrm : Form
    {
        Graphics g;
        List<Color> colors;
        public cizimFrm()
        {
            InitializeComponent();
            g=this.CreateGraphics();
            colors = new List<Color>();
            colors.Add(Color.Blue);
            colors.Add(Color.Red);
            colors.Add(Color.Black);
            colors.Add(Color.Yellow);
            colors.Add(Color.Orange);
            colors.Add(Color.Purple);
        }

        public void cizgiCiz(Pen pen) 
        {
            Random r = new Random();
            int x1 = r.Next(this.Width);
            int y1= r.Next(this.Height);
            int x2 = r.Next(this.Width);
            int y2 = r.Next(this.Height);
            g.DrawLine(pen,x1, y1, x2, y2);
        }

        public void dortgenCiz(Pen pen)
        {
            Random r = new Random();
            int x1 = r.Next(this.Width);
            int y1 = r.Next(this.Height);
            int x2 = r.Next(this.Width);
            int y2 = r.Next(this.Height);
            g.DrawRectangle(pen,x1,y1,x2,y2);
        }
        public void elipsCiz(Pen pen)
        {
            Random r = new Random();
            int x1 = r.Next(this.Width);
            int y1 = r.Next(this.Height);
            int x2 = r.Next(this.Width);
            int y2 = r.Next(this.Height);
            g.DrawEllipse(pen, x1, y1, x2, y2);
        }

        private void cizimFrm_MouseDown(object sender, MouseEventArgs e)
        {
            Random r = new Random();
          for (int i = 0;i<100;i++)
            {
                Pen p = new Pen(colors[r.Next(colors.Count)], 3);
                int x = r.Next(3);
                if(x==0)
                {
                    cizgiCiz(p);
                }
                if (x == 1)
                {
                    dortgenCiz(p);
                }
                if (x == 2)
                {
                    elipsCiz(p);
                }
            }
        }
    }
}
