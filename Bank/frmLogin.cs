using Bank_Business_Layer;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        short TrailsLogin = 3;
        private void _Login()
        {
            clsUsers.CurrentUser = clsUsers.Find(txtUserName.Text, txtPassword.Text);

            if(clsUsers.CurrentUser != null)
            {
                clsUsers.LoginUsersLog();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                TrailsLogin--;
                lblTrailsLogin.Text = $"Invaild UserName Or Password! You have {TrailsLogin} Trails to Login.";

                if (TrailsLogin == 0)
                {
                    lblTrailsLogin.Text = "You are Locked After 3 Faild Trails. Contact System Administrators to Unlock your Account.";
                    lblTrailsLogin.ForeColor = Color.Red;
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                    return;
                }

                lblTrailsLogin.Visible = true;
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _Login();
        }
    }
}
