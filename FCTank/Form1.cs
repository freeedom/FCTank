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
using FCTank.Properties;
namespace FCTank
{
    public partial class Form1 : Form
    {
        private Point[] threePoints = new Point[] { new Point(250, 395),new Point(250,462),new Point(250,525) };//selectTank显示的位置
        private int position = 0; //控制选择单人，双人，还是地图编辑选项
        private List<Keys> playerKeysDownList;
        private Manager manager;
        private MapManager mapManager;
        private Maps maps;

        private bool isInMapEdit=false;//是否在地图编辑器界面
        private bool isBtnClick=false;//是否正在使用地图编辑器中某个wall
        private wallType type;//正在编辑的wall的类型
        private bool isInMain=true;//是否在主界面
        private bool isInPlay=false;//是否在游戏界面
        private bool isInChose=false;//是否在关卡选择界面

        public Form1()
        {
            InitializeComponent();
        }

        private void initChose()
        {
            isInMain = isInPlay = isInMapEdit = false;
            isInChose = true;
            panelMapEdit.Enabled = false;
            panelMapEdit.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            panelChose.Visible = panelChose.Enabled = true;
            pictureBox1.BorderStyle = BorderStyle.None;
            timer1.Stop();
            timer2.Stop();
          
        }
        private void initMain()
        {
            isInMapEdit = isInPlay =isInChose= false;
            isInMain = true;
            panelMapEdit.Enabled = false;
            panelMapEdit.Visible = false;
            panelChose.Enabled = panelChose.Visible = false;
            pictureBox1.BorderStyle = BorderStyle.None;
            timer1.Stop();
            timer2.Stop();
        }
        private void initMapEdit()
        {
            isInMain = isInPlay =isInChose= false;
            isInMapEdit = true;
            panelMapEdit.Enabled = true; ;
            panelMapEdit.Visible = true; ;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            mapManager = new MapManager();
            timer1.Start();
            timer2.Stop();
        }
        private void initPlay(int stage)
        {
            isInMain = isInMapEdit =isInChose= false;
            isInPlay = true;
            pictureBox1.Enabled = pictureBox1.Visible = true;
            panelChose.Visible = panelChose.Enabled = false;
            panelMapEdit.Enabled = panelMapEdit.Visible = false;
            Manager tempManager = new Manager();
            if(manager!=null&& !manager.Finish)
            {
                tempManager.player1Tank.setLife(manager.player1Tank.getLife());
                tempManager.player1Tank.setAttack(manager.player1Tank.getAttack());
               
            }
            manager = tempManager;
            playerKeysDownList = new List<Keys>();          
            manager.setMap(maps.getWallList(stage));
            timer1.Start();
            timer2.Start();
        }

        //主界面画面
        private void InMain(Graphics g)
        {
            g.DrawImage(Resources.Index, new Point(0, 0));
            g.DrawImage(Resources.select, new Point(317, 400));
            g.DrawImage(Resources.selecttank, threePoints[position]);
            
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
            if(isInPlay)
            {
                drawFuzhu(e.Graphics);
               if(manager!=null) manager.draw(e.Graphics);
            }
            else if(isInMain)
            {
                InMain(e.Graphics);
            }
            else if(isInMapEdit)
            {
                drawFuzhu(e.Graphics);
                mapManager.draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(isInPlay)
            {
                if (e.KeyData == Keys.W || e.KeyData == Keys.A || e.KeyData == Keys.S || e.KeyData == Keys.D)
                {
                    manager.player1Tank.setSpeed(3);
                    if (playerKeysDownList.Contains(Keys.W)) playerKeysDownList.Remove(Keys.W);
                    if (playerKeysDownList.Contains(Keys.A)) playerKeysDownList.Remove(Keys.A);
                    if (playerKeysDownList.Contains(Keys.S)) playerKeysDownList.Remove(Keys.S);
                    if (playerKeysDownList.Contains(Keys.D)) playerKeysDownList.Remove(Keys.D);
                    playerKeysDownList.Add(e.KeyData);
                    if (e.KeyData == Keys.W) manager.player1Tank.setDir(Direction.W);
                    else if (e.KeyData == Keys.A) manager.player1Tank.setDir(Direction.A);
                    else if (e.KeyData == Keys.S) manager.player1Tank.setDir(Direction.S);
                    else if (e.KeyData == Keys.D) manager.player1Tank.setDir(Direction.D);
                }
                if (e.KeyData == Keys.J) manager.player1Tank.fire();
            }
            
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(isInMain)
            {
                if (e.KeyData == Keys.Down) position = (position + 1) % 3;
                else if (e.KeyData == Keys.Up) position = (position - 1 >= 0) ? position - 1 : 2;
                else if(e.KeyData==Keys.Enter)
                {
                    if (position == 0 || position == 1)
                    {
                        initChose();
                    }
                    else
                    {
                        initMapEdit();
                    }
                }
                pictureBox1.Invalidate();
            }
            if(isInPlay)
            {
                if ((e.KeyData == Keys.W || e.KeyData == Keys.A || e.KeyData == Keys.S || e.KeyData == Keys.D) && playerKeysDownList.Contains(e.KeyData))
                {
                    playerKeysDownList.Remove(e.KeyData);
                    manager.player1Tank.setSpeed(0);
                }
            
            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            manager.hit();
            manager.move();
            manager.enemyFire();
            this.Text = manager.player1Tank.getX() + " " + manager.player1Tank.getY();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(1000, 780);
            pictureBox1.Size = new Size(780, 780);
            initMain();
            maps = SerialUtils.reSerial();
            if (maps == null) maps = new Maps();
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            isBtnClick = true;
            type = wallType.wall;
        }

        private void btnSteel_Click(object sender, EventArgs e)
        {
            isBtnClick = true;
            type = wallType.steel;
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            isBtnClick = true;
            type = wallType.water;
        }

        private void btnGrass_Click(object sender, EventArgs e)
        {
            isBtnClick = true;
            type = wallType.grass;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(isInMapEdit&&isBtnClick)
            {
                mapManager.MouseDown(e, type);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isInMapEdit && isBtnClick)
            {
                mapManager.MouseMove(e, type);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isInMapEdit && isBtnClick)
            {
                mapManager.MouseUp(e, type);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isInMapEdit = isInPlay = false;
            isInMain = true;
            initMain();
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialUtils.serial(maps);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maps.addWallList(mapManager.WallList);
            initMain();
            pictureBox1.Invalidate();
        }

        private void btnPrevStage_Click(object sender, EventArgs e)
        {
            int stageIndex = Convert.ToInt32(labelStage.Text);
            stageIndex = stageIndex - 1;
            if (stageIndex == 0) stageIndex = maps.Count;
            labelStage.Text = stageIndex.ToString();
        }

        private void btnNextStage_Click(object sender, EventArgs e)
        {
            int stageIndex = Convert.ToInt32(labelStage.Text);
            stageIndex = (stageIndex % maps.Count) + 1;
            labelStage.Text = stageIndex.ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int stageIndex = Convert.ToInt32(labelStage.Text);
            initPlay(stageIndex-1);
        }

    }
}
