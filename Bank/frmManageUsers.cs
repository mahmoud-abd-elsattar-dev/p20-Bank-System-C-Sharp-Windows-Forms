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

namespace Bank
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void _ClearAdd()
        {
            txtAddUserName.Clear();
            txtAddFirstName.Clear();
            txtAddLastName.Clear();
            txtAddEmail.Clear();
            txtAddPhone.Clear();
            txtAddPassword.Clear();
            txtAddUserName.Focus();
            rbYesGiveFullAccess.Checked = false;
            rbNoDontGiveFullAccess.Checked = false;
            chkManageClients.Checked = false;
            chkManageUsers.Checked = false;
            chkManageTransactions.Checked = false;
            chkCurrencyExchange.Checked = false;
        }
        private void _ClearUpdate()
        {
            txtUpdateUserName.Clear();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            txtUpdateEmail.Clear();
            txtUpdatePhone.Clear();
            txtUpdatePassword.Clear();
            txtUpdateUserName.Focus();
            rbYesUpdateGiveFullAccess.Checked = false;
            rbNoDontUpdateGiveFullAccess.Checked = false;
            chkUpdateManageClients.Checked = false;
            chkUpdateManageUsers.Checked = false;
            chkUpdateManageTransactions.Checked = false;
            chkUpdateCurrencyExchange.Checked = false;
        }
        private void tabp_Add_Update_Enter(object sender, EventArgs e)
        {
            _ClearAdd();
            _ClearUpdate();
        }
        private void _RefershUsersData()
        {
            dgvShowUsers.DataSource = clsUsers.GetUsersList();
            lblUsersCount.Text = dgvShowUsers.Rows.Count.ToString() + " Users(s)";
        }
        private void _RefershUsersLogData()
        {
            dgvUsersLog.DataSource = clsUsers.GetAllUsersLog();
            lblUsersLogCount.Text = dgvUsersLog.Rows.Count.ToString() + " User Log(s)";
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefershUsersData();
        }
        private void _SearchInUsersData()
        {
            DataTable dataTable = clsUsers.GetUsersList();
            string SearchValue = txtSearch.Text.Trim();

            if(!string.IsNullOrEmpty(SearchValue))
            {
                dataTable.DefaultView.RowFilter = $"[UserName] LIKE '%{SearchValue}%'";
                dgvShowUsers.DataSource = dataTable;
                lblUsersCount.Text = dgvShowUsers.Rows.Count.ToString() + " Users(s)";
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }
        private void _SearchInUsersLogData()
        {
            DataTable dataTable = clsUsers.GetAllUsersLog();
            string SearchValue = txtSearchUsersLog.Text.Trim();

            if (!string.IsNullOrEmpty(SearchValue))
            {
                dataTable.DefaultView.RowFilter = $"[UserName] LIKE '%{SearchValue}%'";
                dgvUsersLog.DataSource = dataTable;
                lblUsersLogCount.Text = dgvUsersLog.Rows.Count.ToString() + " User Log(s)";
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchInUsersData();
        }
        private int _ReadPermissions()
        {
            int Permissions = 0;

            if(rbYesGiveFullAccess.Checked || rbYesUpdateGiveFullAccess.Checked)
            {
                return -1;
            }

            if(chkManageClients.Checked || chkUpdateManageClients.Checked)
            {
                Permissions += (int)clsUsers.enPermissions.pManageClients;
            }

            if(chkManageUsers.Checked || chkUpdateManageUsers.Checked)
            {
                Permissions += (int)clsUsers.enPermissions.pManageUsers;
            }

            if (chkManageTransactions.Checked || chkUpdateManageTransactions.Checked)
            {
                Permissions += (int)clsUsers.enPermissions.pManageTransactions;
            }

            if(chkCurrencyExchange.Checked || chkUpdateCurrencyExchange.Checked)
            {
                Permissions += (int)clsUsers.enPermissions.pCurrencyExchange;
            }

            return Permissions;
        }
        private void ReadUpdateInfo(User User1)
        {
            User1.FirstName = txtUpdateFirstName.Text;
            User1.LastName = txtUpdateLastName.Text;
            User1.Email = txtUpdateEmail.Text;
            User1.Phone = txtUpdatePhone.Text;
            User1.Password = txtUpdatePassword.Text;
            User1.Permissions = _ReadPermissions();
        }
        private void _AddNewUser()
        {
            if (clsUsers.IsExists(txtAddUserName.Text) || string.IsNullOrWhiteSpace(txtAddUserName.Text))
            {
                txtAddUserName.Focus();
                if (string.IsNullOrWhiteSpace(txtAddUserName.Text))
                    MessageBox.Show($"UserName Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"UserName ({txtAddUserName.Text}) Is Already Exsits, Choice Anthor One", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User User1 = clsUsers.GetEmptyUser();
            User1.UserName = txtAddUserName.Text;   
            User1.FirstName = txtAddFirstName.Text;
            User1.LastName = txtAddLastName.Text;
            User1.Email = txtAddEmail.Text;
            User1.Phone = txtAddPhone.Text;
            User1.Password = txtAddPassword.Text;
            User1.Permissions = _ReadPermissions();

            if(clsUsers.AddNewUser(User1))
            {
                MessageBox.Show("User with UserName (" + User1.UserName + ") Added Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefershUsersData();
                _ClearAdd();
                tabManageUsers.SelectedTab = tabpShowUsers;
            }
            else
            {
                MessageBox.Show("Error: Added User Faild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void _UpdateUser()
        {
            if (MessageBox.Show("Are you sure you want to update User Information ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                User User1 = clsUsers.Find(txtUpdateUserName.Text);

                if (User1 != null)
                {
                    ReadUpdateInfo(User1);

                    if (clsUsers.UpdateUser(User1))
                    {
                        MessageBox.Show("User with UserName (" + User1.UserName + ") Updated Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefershUsersData();
                        _ClearUpdate();
                        tabManageUsers.SelectedTab = tabpShowUsers;
                    }
                    else
                    {
                        MessageBox.Show("Error: Updated User Faild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Information Is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void _DeleteUser()
        {
            if (MessageBox.Show("Are you sure you want to Delete User with UserName (" + dgvShowUsers.CurrentRow.Cells["UserName"].Value.ToString() + ") ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser(dgvShowUsers.CurrentRow.Cells["UserName"].Value.ToString()))
                {
                    MessageBox.Show("User Deleted Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefershUsersData();
                }
                else
                {
                    MessageBox.Show("User Deleted Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (tabManageUsers.SelectedTab.Text.ToString())
            {
                case "Add User":
                    _AddNewUser();
                    break;

                case "Update User":
                    _UpdateUser();
                    break;
            }
        }
        private void rbYesGiveFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesGiveFullAccess.Checked)
            {
                chkManageClients.Checked = true;
                chkManageUsers.Checked = true;
                chkManageTransactions.Checked = true;
                chkCurrencyExchange.Checked = true;

                chkManageClients.Enabled = false;
                chkManageUsers.Enabled = false;
                chkManageTransactions.Enabled = false;
                chkCurrencyExchange.Enabled = false;
            }
            else
            {
                chkManageClients.Checked = false;
                chkManageUsers.Checked = false;
                chkManageTransactions.Checked = false;
                chkCurrencyExchange.Checked = false;

                chkManageClients.Enabled = true;
                chkManageUsers.Enabled = true;
                chkManageTransactions.Enabled = true;
                chkCurrencyExchange.Enabled = true;

            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if ((!clsUsers.IsExists(txtUpdateUserName.Text)) || string.IsNullOrWhiteSpace(txtUpdateUserName.Text))
            {
                txtUpdateUserName.Focus();
                if (string.IsNullOrWhiteSpace(txtUpdateUserName.Text))
                    MessageBox.Show($"UserName Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"UserName ({txtUpdateUserName.Text}) Is Not Exsits, Choice Anthor One", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            User User1 = clsUsers.Find(txtUpdateUserName.Text);
            txtUpdateFirstName.Text = User1.FirstName;
            txtUpdateLastName.Text = User1.LastName;
            txtUpdateEmail.Text = User1.Email;
            txtUpdatePhone.Text = User1.Phone;
            txtUpdatePassword.Text = User1.Password;

            if(User1.Permissions == 0)
            {
                return;
            }

            if (User1.Permissions == -1)
            {
                rbYesUpdateGiveFullAccess.Checked = true;
            }
            else
            {
                if ((User1.Permissions & (int)clsUsers.enPermissions.pManageClients) == (int)clsUsers.enPermissions.pManageClients)
                {
                    chkUpdateManageClients.Checked = true;
                }

                if ((User1.Permissions & (int)clsUsers.enPermissions.pManageUsers) == (int)clsUsers.enPermissions.pManageUsers)
                {
                    chkUpdateManageUsers.Checked = true;
                }

                if ((User1.Permissions & (int)clsUsers.enPermissions.pManageTransactions) == (int)clsUsers.enPermissions.pManageTransactions)
                {
                    chkUpdateManageTransactions.Checked = true;
                }

                if ((User1.Permissions & (int)clsUsers.enPermissions.pCurrencyExchange) == (int)clsUsers.enPermissions.pCurrencyExchange)
                {
                    chkUpdateCurrencyExchange.Checked = true;
                }
            }
        }
        private void rbYesUpdateGiveFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesUpdateGiveFullAccess.Checked)
            {
                chkUpdateManageClients.Checked = true;
                chkUpdateManageUsers.Checked = true;
                chkUpdateManageTransactions.Checked = true;
                chkUpdateCurrencyExchange.Checked = true;
                   
                chkUpdateManageClients.Enabled = false;
                chkUpdateManageUsers.Enabled = false;
                chkUpdateManageTransactions.Enabled = false;
                chkUpdateCurrencyExchange.Enabled = false;
            }      
            else   
            {      
                chkUpdateManageClients.Checked = false;
                chkUpdateManageUsers.Checked = false;
                chkUpdateManageTransactions.Checked = false;
                chkUpdateCurrencyExchange.Checked = false;
                  
                chkUpdateManageClients.Enabled = true;
                chkUpdateManageUsers.Enabled = true;
                chkUpdateManageTransactions.Enabled = true;
                chkUpdateCurrencyExchange.Enabled = true;

            }
        }
        private void btnGoBackToShowUsers_Click(object sender, EventArgs e)
        {
            tabManageUsers.SelectedTab = tabpShowUsers;
        }
        private void tabpUsersLog_Enter(object sender, EventArgs e)
        {
            _RefershUsersLogData();
        }
        private void txtSearchUsersLog_TextChanged(object sender, EventArgs e)
        {
            _SearchInUsersLogData();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteUser();
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabManageUsers.SelectedTab = tabpUpdateUser;
            txtUpdateUserName.Text = dgvShowUsers.CurrentRow.Cells["UserName"].Value.ToString();
            txtUpdateUserName.ReadOnly = true;
        }
    }
}
