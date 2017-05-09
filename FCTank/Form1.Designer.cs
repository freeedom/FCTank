namespace FCTank
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMapEdit.SuspendLayout();
            this.panelChose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 624);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
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
            this.panelMapEdit.Location = new System.Drawing.Point(584, 0);
            this.panelMapEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMapEdit.Name = "panelMapEdit";
            this.panelMapEdit.Size = new System.Drawing.Size(219, 632);
            this.panelMapEdit.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 421);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "保存并返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "保存并游戏";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGrass
            // 
            this.btnGrass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrass.Image = global::FCTank.Properties.Resources.grass;
            this.btnGrass.Location = new System.Drawing.Point(26, 238);
            this.btnGrass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrass.Name = "btnGrass";
            this.btnGrass.Size = new System.Drawing.Size(45, 48);
            this.btnGrass.TabIndex = 3;
            this.btnGrass.UseVisualStyleBackColor = true;
            this.btnGrass.Click += new System.EventHandler(this.btnGrass_Click);
            // 
            // btnWater
            // 
            this.btnWater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWater.Image = global::FCTank.Properties.Resources.water;
            this.btnWater.Location = new System.Drawing.Point(26, 169);
            this.btnWater.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(45, 48);
            this.btnWater.TabIndex = 2;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnSteel
            // 
            this.btnSteel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSteel.Image = global::FCTank.Properties.Resources.steel;
            this.btnSteel.Location = new System.Drawing.Point(26, 97);
            this.btnSteel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSteel.Name = "btnSteel";
            this.btnSteel.Size = new System.Drawing.Size(45, 48);
            this.btnSteel.TabIndex = 1;
            this.btnSteel.UseVisualStyleBackColor = true;
            this.btnSteel.Click += new System.EventHandler(this.btnSteel_Click);
            // 
            // btnWall
            // 
            this.btnWall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWall.Image = global::FCTank.Properties.Resources.wall;
            this.btnWall.Location = new System.Drawing.Point(26, 14);
            this.btnWall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(45, 48);
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
            this.panelChose.Location = new System.Drawing.Point(70, 38);
            this.panelChose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChose.Name = "panelChose";
            this.panelChose.Size = new System.Drawing.Size(502, 422);
            this.panelChose.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnGo.Location = new System.Drawing.Point(362, 225);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(104, 45);
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
            this.btnNextStage.Location = new System.Drawing.Point(236, 225);
            this.btnNextStage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextStage.Name = "btnNextStage";
            this.btnNextStage.Size = new System.Drawing.Size(104, 45);
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
            this.btnPrevStage.Location = new System.Drawing.Point(116, 225);
            this.btnPrevStage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevStage.Name = "btnPrevStage";
            this.btnPrevStage.Size = new System.Drawing.Size(104, 45);
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
            this.labelStage.Location = new System.Drawing.Point(373, 133);
            this.labelStage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(50, 49);
            this.labelStage.TabIndex = 1;
            this.labelStage.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(165, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(803, 632);
            this.Controls.Add(this.panelChose);
            this.Controls.Add(this.panelMapEdit);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMapEdit.ResumeLayout(false);
            this.panelChose.ResumeLayout(false);
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
    }
}

