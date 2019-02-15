using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MainForm : Form
    {
        private object updateProfileForm;

        public MainForm()
        {
            InitializeComponent();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //private UpdateProfileForm UpdateProfileForm;
        private UpdateProfileForm UpdateProfileForm;

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // UpdateProfileForm updateProfileForm = new UpdateProfileForm();
            if ((UpdateProfileForm == null) || (UpdateProfileForm.IsDisposed))
            {
                UpdateProfileForm = new UpdateProfileForm();

                UpdateProfileForm.MdiParent = this;

            }
             UpdateProfileForm.Show();
        }
    }
}
