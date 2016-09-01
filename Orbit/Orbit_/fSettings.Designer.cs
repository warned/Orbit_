namespace Orbit_
{
    partial class fSettings
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
            this.cbMousePos = new System.Windows.Forms.CheckBox();
            this.cbPos = new System.Windows.Forms.CheckBox();
            this.cbVel = new System.Windows.Forms.CheckBox();
            this.cbAcc = new System.Windows.Forms.CheckBox();
            this.cbForce = new System.Windows.Forms.CheckBox();
            this.gbPVAF = new System.Windows.Forms.GroupBox();
            this.cbPVAF = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbForceOP = new System.Windows.Forms.CheckBox();
            this.gbPVAF.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMousePos
            // 
            this.cbMousePos.AutoSize = true;
            this.cbMousePos.Location = new System.Drawing.Point(12, 12);
            this.cbMousePos.Name = "cbMousePos";
            this.cbMousePos.Size = new System.Drawing.Size(98, 17);
            this.cbMousePos.TabIndex = 0;
            this.cbMousePos.Text = "Mouse Position";
            this.cbMousePos.UseVisualStyleBackColor = true;
            // 
            // cbPos
            // 
            this.cbPos.AutoSize = true;
            this.cbPos.Location = new System.Drawing.Point(6, 43);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(61, 17);
            this.cbPos.TabIndex = 0;
            this.cbPos.Text = "Postion";
            this.cbPos.UseVisualStyleBackColor = true;
            // 
            // cbVel
            // 
            this.cbVel.AutoSize = true;
            this.cbVel.Location = new System.Drawing.Point(6, 60);
            this.cbVel.Name = "cbVel";
            this.cbVel.Size = new System.Drawing.Size(63, 17);
            this.cbVel.TabIndex = 0;
            this.cbVel.Text = "Velocity";
            this.cbVel.UseVisualStyleBackColor = true;
            // 
            // cbAcc
            // 
            this.cbAcc.AutoSize = true;
            this.cbAcc.Location = new System.Drawing.Point(6, 77);
            this.cbAcc.Name = "cbAcc";
            this.cbAcc.Size = new System.Drawing.Size(85, 17);
            this.cbAcc.TabIndex = 0;
            this.cbAcc.Text = "Acceleration";
            this.cbAcc.UseVisualStyleBackColor = true;
            // 
            // cbForce
            // 
            this.cbForce.AutoSize = true;
            this.cbForce.Location = new System.Drawing.Point(6, 94);
            this.cbForce.Name = "cbForce";
            this.cbForce.Size = new System.Drawing.Size(53, 17);
            this.cbForce.TabIndex = 0;
            this.cbForce.Text = "Force";
            this.cbForce.UseVisualStyleBackColor = true;
            // 
            // gbPVAF
            // 
            this.gbPVAF.Controls.Add(this.cbPVAF);
            this.gbPVAF.Controls.Add(this.cbPos);
            this.gbPVAF.Controls.Add(this.cbForceOP);
            this.gbPVAF.Controls.Add(this.cbForce);
            this.gbPVAF.Controls.Add(this.cbVel);
            this.gbPVAF.Controls.Add(this.cbAcc);
            this.gbPVAF.Location = new System.Drawing.Point(252, 12);
            this.gbPVAF.Name = "gbPVAF";
            this.gbPVAF.Size = new System.Drawing.Size(191, 142);
            this.gbPVAF.TabIndex = 1;
            this.gbPVAF.TabStop = false;
            this.gbPVAF.Text = "gbPVAF";
            // 
            // cbPVAF
            // 
            this.cbPVAF.AutoSize = true;
            this.cbPVAF.Location = new System.Drawing.Point(6, 19);
            this.cbPVAF.Name = "cbPVAF";
            this.cbPVAF.Size = new System.Drawing.Size(67, 17);
            this.cbPVAF.TabIndex = 0;
            this.cbPVAF.Text = "Show All";
            this.cbPVAF.UseVisualStyleBackColor = true;
            this.cbPVAF.CheckedChanged += new System.EventHandler(this.cbPVAF_CheckedChanged);
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(12, 221);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(67, 17);
            this.cbAll.TabIndex = 0;
            this.cbAll.Text = "Show All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbForceOP
            // 
            this.cbForceOP.AutoSize = true;
            this.cbForceOP.Location = new System.Drawing.Point(6, 111);
            this.cbForceOP.Name = "cbForceOP";
            this.cbForceOP.Size = new System.Drawing.Size(71, 17);
            this.cbForceOP.TabIndex = 0;
            this.cbForceOP.Text = "OP Force";
            this.cbForceOP.UseVisualStyleBackColor = true;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 250);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.gbPVAF);
            this.Controls.Add(this.cbMousePos);
            this.Name = "fSettings";
            this.Text = "fSettings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.gbPVAF.ResumeLayout(false);
            this.gbPVAF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbMousePos;
        private System.Windows.Forms.CheckBox cbPos;
        private System.Windows.Forms.CheckBox cbVel;
        private System.Windows.Forms.CheckBox cbAcc;
        private System.Windows.Forms.CheckBox cbForce;
        private System.Windows.Forms.GroupBox gbPVAF;
        private System.Windows.Forms.CheckBox cbPVAF;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbForceOP;
    }
}