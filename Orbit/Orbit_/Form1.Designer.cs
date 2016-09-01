namespace Orbit_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbGalaxy = new System.Windows.Forms.PictureBox();
            this.tmrDraw = new System.Windows.Forms.Timer(this.components);
            this.lblMouseX = new System.Windows.Forms.Label();
            this.lblMouseY = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblVelX = new System.Windows.Forms.Label();
            this.lblVelY = new System.Windows.Forms.Label();
            this.lblAccX = new System.Windows.Forms.Label();
            this.lblAccY = new System.Windows.Forms.Label();
            this.lblForceX = new System.Windows.Forms.Label();
            this.lblForceY = new System.Windows.Forms.Label();
            this.lblTForce = new System.Windows.Forms.Label();
            this.lblTAcc = new System.Windows.Forms.Label();
            this.lblTVel = new System.Windows.Forms.Label();
            this.lblTPos = new System.Windows.Forms.Label();
            this.lblTMousePos = new System.Windows.Forms.Label();
            this.lblVelTotal = new System.Windows.Forms.Label();
            this.lblAccTotal = new System.Windows.Forms.Label();
            this.lblForceTotal = new System.Windows.Forms.Label();
            this.lblFOPX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFOPY = new System.Windows.Forms.Label();
            this.lblFOPT = new System.Windows.Forms.Label();
            this.tmrFlash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGalaxy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGalaxy
            // 
            this.pbGalaxy.Location = new System.Drawing.Point(12, 12);
            this.pbGalaxy.Name = "pbGalaxy";
            this.pbGalaxy.Size = new System.Drawing.Size(268, 212);
            this.pbGalaxy.TabIndex = 0;
            this.pbGalaxy.TabStop = false;
            this.pbGalaxy.Click += new System.EventHandler(this.pbGalaxy_Click);
            // 
            // tmrDraw
            // 
            this.tmrDraw.Interval = 10;
            this.tmrDraw.Tick += new System.EventHandler(this.tmrDraw_Tick);
            // 
            // lblMouseX
            // 
            this.lblMouseX.AutoSize = true;
            this.lblMouseX.BackColor = System.Drawing.Color.Black;
            this.lblMouseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMouseX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblMouseX.Location = new System.Drawing.Point(8, 33);
            this.lblMouseX.Name = "lblMouseX";
            this.lblMouseX.Size = new System.Drawing.Size(35, 24);
            this.lblMouseX.TabIndex = 1;
            this.lblMouseX.Text = "0.0";
            // 
            // lblMouseY
            // 
            this.lblMouseY.AutoSize = true;
            this.lblMouseY.BackColor = System.Drawing.Color.Black;
            this.lblMouseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMouseY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblMouseY.Location = new System.Drawing.Point(8, 57);
            this.lblMouseY.Name = "lblMouseY";
            this.lblMouseY.Size = new System.Drawing.Size(35, 24);
            this.lblMouseY.TabIndex = 1;
            this.lblMouseY.Text = "0.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.BackColor = System.Drawing.Color.Black;
            this.lblPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPosX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblPosX.Location = new System.Drawing.Point(159, 33);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(35, 24);
            this.lblPosX.TabIndex = 1;
            this.lblPosX.Text = "0.0";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.BackColor = System.Drawing.Color.Black;
            this.lblPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPosY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblPosY.Location = new System.Drawing.Point(159, 57);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(35, 24);
            this.lblPosY.TabIndex = 1;
            this.lblPosY.Text = "0.0";
            // 
            // lblVelX
            // 
            this.lblVelX.AutoSize = true;
            this.lblVelX.BackColor = System.Drawing.Color.Black;
            this.lblVelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVelX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblVelX.Location = new System.Drawing.Point(342, 33);
            this.lblVelX.Name = "lblVelX";
            this.lblVelX.Size = new System.Drawing.Size(35, 24);
            this.lblVelX.TabIndex = 1;
            this.lblVelX.Text = "0.0";
            // 
            // lblVelY
            // 
            this.lblVelY.AutoSize = true;
            this.lblVelY.BackColor = System.Drawing.Color.Black;
            this.lblVelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVelY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblVelY.Location = new System.Drawing.Point(342, 57);
            this.lblVelY.Name = "lblVelY";
            this.lblVelY.Size = new System.Drawing.Size(35, 24);
            this.lblVelY.TabIndex = 1;
            this.lblVelY.Text = "0.0";
            // 
            // lblAccX
            // 
            this.lblAccX.AutoSize = true;
            this.lblAccX.BackColor = System.Drawing.Color.Black;
            this.lblAccX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblAccX.Location = new System.Drawing.Point(550, 33);
            this.lblAccX.Name = "lblAccX";
            this.lblAccX.Size = new System.Drawing.Size(35, 24);
            this.lblAccX.TabIndex = 1;
            this.lblAccX.Text = "0.0";
            // 
            // lblAccY
            // 
            this.lblAccY.AutoSize = true;
            this.lblAccY.BackColor = System.Drawing.Color.Black;
            this.lblAccY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblAccY.Location = new System.Drawing.Point(550, 57);
            this.lblAccY.Name = "lblAccY";
            this.lblAccY.Size = new System.Drawing.Size(35, 24);
            this.lblAccY.TabIndex = 1;
            this.lblAccY.Text = "0.0";
            // 
            // lblForceX
            // 
            this.lblForceX.AutoSize = true;
            this.lblForceX.BackColor = System.Drawing.Color.Black;
            this.lblForceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForceX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblForceX.Location = new System.Drawing.Point(773, 33);
            this.lblForceX.Name = "lblForceX";
            this.lblForceX.Size = new System.Drawing.Size(35, 24);
            this.lblForceX.TabIndex = 1;
            this.lblForceX.Text = "0.0";
            // 
            // lblForceY
            // 
            this.lblForceY.AutoSize = true;
            this.lblForceY.BackColor = System.Drawing.Color.Black;
            this.lblForceY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForceY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblForceY.Location = new System.Drawing.Point(773, 57);
            this.lblForceY.Name = "lblForceY";
            this.lblForceY.Size = new System.Drawing.Size(35, 24);
            this.lblForceY.TabIndex = 1;
            this.lblForceY.Text = "0.0";
            // 
            // lblTForce
            // 
            this.lblTForce.AutoSize = true;
            this.lblTForce.BackColor = System.Drawing.Color.Black;
            this.lblTForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTForce.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTForce.Location = new System.Drawing.Point(773, 9);
            this.lblTForce.Name = "lblTForce";
            this.lblTForce.Size = new System.Drawing.Size(60, 24);
            this.lblTForce.TabIndex = 1;
            this.lblTForce.Text = "Force";
            // 
            // lblTAcc
            // 
            this.lblTAcc.AutoSize = true;
            this.lblTAcc.BackColor = System.Drawing.Color.Black;
            this.lblTAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTAcc.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTAcc.Location = new System.Drawing.Point(550, 9);
            this.lblTAcc.Name = "lblTAcc";
            this.lblTAcc.Size = new System.Drawing.Size(43, 24);
            this.lblTAcc.TabIndex = 1;
            this.lblTAcc.Text = "Acc";
            // 
            // lblTVel
            // 
            this.lblTVel.AutoSize = true;
            this.lblTVel.BackColor = System.Drawing.Color.Black;
            this.lblTVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTVel.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTVel.Location = new System.Drawing.Point(342, 9);
            this.lblTVel.Name = "lblTVel";
            this.lblTVel.Size = new System.Drawing.Size(38, 24);
            this.lblTVel.TabIndex = 1;
            this.lblTVel.Text = "Vel";
            // 
            // lblTPos
            // 
            this.lblTPos.AutoSize = true;
            this.lblTPos.BackColor = System.Drawing.Color.Black;
            this.lblTPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTPos.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTPos.Location = new System.Drawing.Point(159, 9);
            this.lblTPos.Name = "lblTPos";
            this.lblTPos.Size = new System.Drawing.Size(42, 24);
            this.lblTPos.TabIndex = 1;
            this.lblTPos.Text = "Pos";
            // 
            // lblTMousePos
            // 
            this.lblTMousePos.AutoSize = true;
            this.lblTMousePos.BackColor = System.Drawing.Color.Black;
            this.lblTMousePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTMousePos.ForeColor = System.Drawing.Color.LightBlue;
            this.lblTMousePos.Location = new System.Drawing.Point(8, 9);
            this.lblTMousePos.Name = "lblTMousePos";
            this.lblTMousePos.Size = new System.Drawing.Size(105, 24);
            this.lblTMousePos.TabIndex = 1;
            this.lblTMousePos.Text = "Mouse Pos";
            // 
            // lblVelTotal
            // 
            this.lblVelTotal.AutoSize = true;
            this.lblVelTotal.BackColor = System.Drawing.Color.Black;
            this.lblVelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVelTotal.ForeColor = System.Drawing.Color.LightBlue;
            this.lblVelTotal.Location = new System.Drawing.Point(342, 81);
            this.lblVelTotal.Name = "lblVelTotal";
            this.lblVelTotal.Size = new System.Drawing.Size(35, 24);
            this.lblVelTotal.TabIndex = 1;
            this.lblVelTotal.Text = "0.0";
            // 
            // lblAccTotal
            // 
            this.lblAccTotal.AutoSize = true;
            this.lblAccTotal.BackColor = System.Drawing.Color.Black;
            this.lblAccTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccTotal.ForeColor = System.Drawing.Color.LightBlue;
            this.lblAccTotal.Location = new System.Drawing.Point(550, 81);
            this.lblAccTotal.Name = "lblAccTotal";
            this.lblAccTotal.Size = new System.Drawing.Size(35, 24);
            this.lblAccTotal.TabIndex = 1;
            this.lblAccTotal.Text = "0.0";
            // 
            // lblForceTotal
            // 
            this.lblForceTotal.AutoSize = true;
            this.lblForceTotal.BackColor = System.Drawing.Color.Black;
            this.lblForceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblForceTotal.ForeColor = System.Drawing.Color.LightBlue;
            this.lblForceTotal.Location = new System.Drawing.Point(773, 81);
            this.lblForceTotal.Name = "lblForceTotal";
            this.lblForceTotal.Size = new System.Drawing.Size(35, 24);
            this.lblForceTotal.TabIndex = 1;
            this.lblForceTotal.Text = "0.0";
            // 
            // lblFOPX
            // 
            this.lblFOPX.AutoSize = true;
            this.lblFOPX.BackColor = System.Drawing.Color.Black;
            this.lblFOPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFOPX.ForeColor = System.Drawing.Color.LightBlue;
            this.lblFOPX.Location = new System.Drawing.Point(954, 36);
            this.lblFOPX.Name = "lblFOPX";
            this.lblFOPX.Size = new System.Drawing.Size(35, 24);
            this.lblFOPX.TabIndex = 1;
            this.lblFOPX.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.LightBlue;
            this.label2.Location = new System.Drawing.Point(954, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "OP";
            // 
            // lblFOPY
            // 
            this.lblFOPY.AutoSize = true;
            this.lblFOPY.BackColor = System.Drawing.Color.Black;
            this.lblFOPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFOPY.ForeColor = System.Drawing.Color.LightBlue;
            this.lblFOPY.Location = new System.Drawing.Point(954, 60);
            this.lblFOPY.Name = "lblFOPY";
            this.lblFOPY.Size = new System.Drawing.Size(35, 24);
            this.lblFOPY.TabIndex = 1;
            this.lblFOPY.Text = "0.0";
            // 
            // lblFOPT
            // 
            this.lblFOPT.AutoSize = true;
            this.lblFOPT.BackColor = System.Drawing.Color.Black;
            this.lblFOPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFOPT.ForeColor = System.Drawing.Color.LightBlue;
            this.lblFOPT.Location = new System.Drawing.Point(954, 84);
            this.lblFOPT.Name = "lblFOPT";
            this.lblFOPT.Size = new System.Drawing.Size(35, 24);
            this.lblFOPT.TabIndex = 1;
            this.lblFOPT.Text = "0.0";
            // 
            // tmrFlash
            // 
            this.tmrFlash.Interval = 200;
            this.tmrFlash.Tick += new System.EventHandler(this.tmrFlash_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 359);
            this.Controls.Add(this.lblFOPT);
            this.Controls.Add(this.lblForceTotal);
            this.Controls.Add(this.lblFOPY);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblForceY);
            this.Controls.Add(this.lblAccTotal);
            this.Controls.Add(this.lblVelTotal);
            this.Controls.Add(this.lblAccY);
            this.Controls.Add(this.lblVelY);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblMouseY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFOPX);
            this.Controls.Add(this.lblTForce);
            this.Controls.Add(this.lblForceX);
            this.Controls.Add(this.lblTAcc);
            this.Controls.Add(this.lblAccX);
            this.Controls.Add(this.lblTVel);
            this.Controls.Add(this.lblVelX);
            this.Controls.Add(this.lblTPos);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.lblTMousePos);
            this.Controls.Add(this.lblMouseX);
            this.Controls.Add(this.pbGalaxy);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbGalaxy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGalaxy;
        private System.Windows.Forms.Timer tmrDraw;
        private System.Windows.Forms.Label lblMouseX;
        private System.Windows.Forms.Label lblMouseY;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblVelX;
        private System.Windows.Forms.Label lblVelY;
        private System.Windows.Forms.Label lblAccX;
        private System.Windows.Forms.Label lblAccY;
        private System.Windows.Forms.Label lblForceX;
        private System.Windows.Forms.Label lblForceY;
        private System.Windows.Forms.Label lblTForce;
        private System.Windows.Forms.Label lblTAcc;
        private System.Windows.Forms.Label lblTVel;
        private System.Windows.Forms.Label lblTPos;
        private System.Windows.Forms.Label lblTMousePos;
        private System.Windows.Forms.Label lblVelTotal;
        private System.Windows.Forms.Label lblAccTotal;
        private System.Windows.Forms.Label lblForceTotal;
        private System.Windows.Forms.Label lblFOPX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFOPY;
        private System.Windows.Forms.Label lblFOPT;
        private System.Windows.Forms.Timer tmrFlash;
    }
}

