using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FCTank.Objects;
namespace FCTank
{
    public partial class Form1 : Form
    {
        bool isdown = false;
        private Manager manager;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(1000, 780);
            pictureBox1.Size = new Size(780, 780);
            this.Text = pictureBox1.Width + " " + pictureBox1.Height;
            manager = new Manager();
        }
        private void drawFuzhu(Graphics g)
        {
            Pen pen=new Pen(Color.White,1);
            for(int i=30;i<=750;i+=30)
            {
                g.DrawLine(pen, new Point(0, i), new Point(780, i));
                g.DrawLine(pen, new Point(i, 0), new Point(i, 780));
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawFuzhu(e.Graphics);
            manager.draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            isdown = true;
            if(e.KeyData == Keys.W||e.KeyData == Keys.A ||e.KeyData == Keys.S||e.KeyData == Keys.D)
            {
                
                manager.player1Tank.setSpeed(10);
                if (e.KeyData == Keys.W) manager.player1Tank.setDir(Direction.W);
                if (e.KeyData == Keys.A) manager.player1Tank.setDir(Direction.A);
                if (e.KeyData == Keys.S) manager.player1Tank.setDir(Direction.S);
                if (e.KeyData == Keys.D) manager.player1Tank.setDir(Direction.D);
            }
            if (e.KeyData == Keys.J) manager.player1Tank.fire();
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            isdown = false;
            manager.player1Tank.setSpeed(0);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            manager.hit();
            manager.move();
            this.Text = manager.player1Tank.getX() + " " + manager.player1Tank.getY();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
    }
}
