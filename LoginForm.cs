
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var pwd = txtPassword.Text;
            if (DataStore.VerifyAdminPassword(pwd))
            {
                var main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var curr = txtPassword.Text;
            var np = txtNewPassword.Text;
            if (!DataStore.VerifyAdminPassword(curr))
            {
                MessageBox.Show("Current password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(np))
            {
                MessageBox.Show("Enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataStore.Data.AdminPasswordHash = DataStore.ComputeHash(np);
            DataStore.Save();
            MessageBox.Show("Admin password updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNewPassword.Text = "";
        }
    }
}
