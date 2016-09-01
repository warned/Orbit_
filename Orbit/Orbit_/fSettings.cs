using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbit_
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }
        private void fSettings_Load(object sender, EventArgs e)
        {
            cbPos.Checked = Properties.Settings.Default.bPosition;
            cbVel.Checked = Properties.Settings.Default.bVelocity;
            cbAcc.Checked = Properties.Settings.Default.bAcceleration;
            cbForce.Checked = Properties.Settings.Default.bForce;
            cbMousePos.Checked = Properties.Settings.Default.bMousePos;

            if (cbPos.Checked && cbVel.Checked && cbAcc.Checked && cbForce.Checked)
            {
                cbPVAF.Checked = true;
            }
            if (cbPVAF.Checked && cbMousePos.Checked)
            {
                cbAll.Checked = true;
            }
            
        }
        private void cbPVAF_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb;
            cb = (CheckBox) sender;
            cbPos.Checked = cb.Checked;
            cbVel.Checked = cb.Checked;
            cbAcc.Checked = cb.Checked;
            cbForce.Checked = cb.Checked;
            cbForceOP.Checked = cb.Checked;
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb;
            cb = (CheckBox)sender;

            cbMousePos.Checked = cb.Checked;
            cbPVAF.Checked = cb.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bPosition = cbPos.Checked;
            Properties.Settings.Default.bVelocity = cbVel.Checked;
            Properties.Settings.Default.bAcceleration = cbAcc.Checked;
            Properties.Settings.Default.bForce = cbForce.Checked;
            Properties.Settings.Default.bMousePos = cbMousePos.Checked;
            Properties.Settings.Default.bForceOP = cbForceOP.Checked;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
