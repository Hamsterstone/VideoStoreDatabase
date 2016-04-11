using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStoreDatabase
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            //put the cursor in the password textbox
            txtPassword.Focus();
        }
        //define the password
        private string password = "password";

        // Validate the password.
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                // The password is ok.
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // The password is invalid.
                txtPassword.Clear();
                MessageBox.Show("ACCESS DENIED");
                txtPassword.Focus();
            }
        }
        //allows enter/return/esc to be used rather than having to click the buttons
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                btnEnter.PerformClick();
                
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
