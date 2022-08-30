using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using drawingApp;

namespace OOP_Csharp_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        mySquare squary;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pencil = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location; 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index==1)
                {
                    px = e.Location;
                    g.DrawLine(pencil, px, py);
                    py =px;
                }
                if (index==2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py =px;
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            index = 1; // if pencil is pressed it activates the 
            // pictureBox1_MouseMove functios and draws line;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
