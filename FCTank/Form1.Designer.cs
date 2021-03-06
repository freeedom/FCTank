﻿namespace FCTank
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMapEdit = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGrass = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnSteel = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.panelChose = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNextStage = new System.Windows.Forms.Button();
            this.btnPrevStage = new System.Windows.Forms.Button();
            this.labelStage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lbTank = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMapEdit.SuspendLayout();
            this.panelChose.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 780);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panelMapEdit
            // 
            this.panelMapEdit.Controls.Add(this.button3);
            this.panelMapEdit.Controls.Add(this.button2);
            this.panelMapEdit.Controls.Add(this.button1);
            this.panelMapEdit.Controls.Add(this.btnGrass);
            this.panelMapEdit.Controls.Add(this.btnWater);
            this.panelMapEdit.Controls.Add(this.btnSteel);
            this.panelMapEdit.Controls.Add(this.btnWall);
            this.panelMapEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMapEdit.Location = new System.Drawing.Point(779, 0);
            this.panelMapEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMapEdit.Name = "panelMapEdit";
            this.panelMapEdit.Size = new System.Drawing.Size(292, 790);
            this.panelMapEdit.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 526);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 471);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存并返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存并游戏";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGrass
            // 
            this.btnGrass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrass.Image = global::FCTank.Properties.Resources.grass;
            this.btnGrass.Location = new System.Drawing.Point(35, 298);
            this.btnGrass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrass.Name = "btnGrass";
            this.btnGrass.Size = new System.Drawing.Size(60, 60);
            this.btnGrass.TabIndex = 3;
            this.btnGrass.UseVisualStyleBackColor = true;
            this.btnGrass.Click += new System.EventHandler(this.btnGrass_Click);
            // 
            // btnWater
            // 
            this.btnWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWater.Image = global::FCTank.Properties.Resources.water;
            this.btnWater.Location = new System.Drawing.Point(35, 211);
            this.btnWater.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(60, 60);
            this.btnWater.TabIndex = 2;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnSteel
            // 
            this.btnSteel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteel.Image = global::FCTank.Properties.Resources.steel;
            this.btnSteel.Location = new System.Drawing.Point(35, 121);
            this.btnSteel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSteel.Name = "btnSteel";
            this.btnSteel.Size = new System.Drawing.Size(60, 60);
            this.btnSteel.TabIndex = 1;
            this.btnSteel.UseVisualStyleBackColor = true;
            this.btnSteel.Click += new System.EventHandler(this.btnSteel_Click);
            // 
            // btnWall
            // 
            this.btnWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWall.Image = global::FCTank.Properties.Resources.wall;
            this.btnWall.Location = new System.Drawing.Point(35, 18);
            this.btnWall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(60, 60);
            this.btnWall.TabIndex = 0;
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // panelChose
            // 
            this.panelChose.Controls.Add(this.btnGo);
            this.panelChose.Controls.Add(this.btnNextStage);
            this.panelChose.Controls.Add(this.btnPrevStage);
            this.panelChose.Controls.Add(this.labelStage);
            this.panelChose.Controls.Add(this.label1);
            this.panelChose.Location = new System.Drawing.Point(93, 48);
            this.panelChose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChose.Name = "panelChose";
            this.panelChose.Size = new System.Drawing.Size(669, 528);
            this.panelChose.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGo.Location = new System.Drawing.Point(483, 281);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(139, 56);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "go";
            this.btnGo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNextStage
            // 
            this.btnNextStage.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNextStage.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNextStage.Location = new System.Drawing.Point(315, 281);
            this.btnNextStage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextStage.Name = "btnNextStage";
            this.btnNextStage.Size = new System.Drawing.Size(139, 56);
            this.btnNextStage.TabIndex = 3;
            this.btnNextStage.Text = "next";
            this.btnNextStage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNextStage.UseVisualStyleBackColor = true;
            this.btnNextStage.Click += new System.EventHandler(this.btnNextStage_Click);
            // 
            // btnPrevStage
            // 
            this.btnPrevStage.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevStage.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrevStage.Location = new System.Drawing.Point(155, 281);
            this.btnPrevStage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevStage.Name = "btnPrevStage";
            this.btnPrevStage.Size = new System.Drawing.Size(139, 56);
            this.btnPrevStage.TabIndex = 2;
            this.btnPrevStage.Text = "prev";
            this.btnPrevStage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrevStage.UseVisualStyleBackColor = true;
            this.btnPrevStage.Click += new System.EventHandler(this.btnPrevStage_Click);
            // 
            // labelStage
            // 
            this.labelStage.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStage.ForeColor = System.Drawing.Color.Yellow;
            this.labelStage.Location = new System.Drawing.Point(497, 166);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(67, 61);
            this.labelStage.TabIndex = 1;
            this.labelStage.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(220, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lbPlayer2);
            this.panelInfo.Controls.Add(this.lbPlayer1);
            this.panelInfo.Controls.Add(this.lbTank);
            this.panelInfo.Location = new System.Drawing.Point(779, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(292, 790);
            this.panelInfo.TabIndex = 3;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            
            // 
            // lbTank
            // 
            this.lbTank.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTank.ForeColor = System.Drawing.Color.Red;
            this.lbTank.Location = new System.Drawing.Point(3, 80);
            this.lbTank.Name = "lbTank";
            this.lbTank.Size = new System.Drawing.Size(289, 53);
            this.lbTank.TabIndex = 0;
            this.lbTank.Text = "label2";
            this.lbTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPlayer1.ForeColor = System.Drawing.Color.Red;
            this.lbPlayer1.Location = new System.Drawing.Point(28, 329);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(239, 53);
            this.lbPlayer1.TabIndex = 1;
            this.lbPlayer1.Text = "label2";
            this.lbPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPlayer2.ForeColor = System.Drawing.Color.Red;
            this.lbPlayer2.Location = new System.Drawing.Point(32, 426);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(239, 53);
            this.lbPlayer2.TabIndex = 2;
            this.lbPlayer2.Text = "label2";
            this.lbPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1071, 790);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelChose);
            this.Controls.Add(this.panelMapEdit);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMapEdit.ResumeLayout(false);
            this.panelChose.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panelMapEdit;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnSteel;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnGrass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelChose;
        private System.Windows.Forms.Button btnPrevStage;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNextStage;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbTank;
    }
}

