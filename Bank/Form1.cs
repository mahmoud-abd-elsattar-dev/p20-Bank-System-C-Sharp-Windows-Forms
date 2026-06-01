using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business_Layer;
using Shared;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckAccessRights(clsUsers.enPermissions Permission)
        {
            if(!clsUsers.CheckAccessPermissions(Permission))
            {
                _ShowHomeScreen();
                MessageBox.Show("Access Denied! Contact Your Admin.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void btnClose_Minimize_Click(object sender, EventArgs e)
        {
            switch(((Button)sender).Tag.ToString())
            {
                case "Close":
                    Application.Exit();
                    break;

                case "Minimize":
                    this.WindowState = FormWindowState.Minimized;   
                    break;
            }
        }
        private void _SearchInClientsData()
        {
            DataTable dataTable = clsClients.GetClientsList();
            string SearchValue = txtSearch.Text.Trim();

            if(!string.IsNullOrEmpty(SearchValue))
            {
                dataTable.DefaultView.RowFilter = $"[Acc Num] LIKE '%{SearchValue}%'";
                dgvShowClients.DataSource = dataTable;
                lblClientsCount.Text = dgvShowClients.Rows.Count.ToString() + " Client(s)";
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }
        private void _RefershClientsData()
        {
            dgvShowClients.DataSource = clsClients.GetClientsList();
            lblClientsCount.Text = dgvShowClients.Rows.Count.ToString() + " Client(s)";

        }
        private void _ShowHomeScreen()
        {
            lblScreenTitle.Text = "         Home";
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(pictureBox5);
            pictureBox5.Dock = DockStyle.Fill;
        }
        private void _ShowManageClientsScreen()
        {
            if(!CheckAccessRights(clsUsers.enPermissions.pManageClients))
            {
                return;
            }

            lblScreenTitle.Text = "  Manage Clients";
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(tabManageClients);
            tabManageClients.SelectedTab = tabpShowClients;
            _RefershClientsData();
        }
        private void _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(Form frm)
        {
            lblScreenTitle.Text = frm.Text;
            pnlContainer.Controls.Clear();
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }
        private void _ShowManageUsersScreen()
        {
            if (!CheckAccessRights(clsUsers.enPermissions.pManageUsers))
            {
                return;
            }

            frmManageUsers frmManageUsers = new frmManageUsers();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmManageUsers);
        }
        private void _ShowManageTransactionsScreen()
        {
            if (!CheckAccessRights(clsUsers.enPermissions.pManageTransactions))
            {
                return;
            }

            frmTransactions frmTransactions = new frmTransactions();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmTransactions);
        }
        private void _ShowManageCurrencyExchangeScreen()
        {
            if (!CheckAccessRights(clsUsers.enPermissions.pCurrencyExchange))
            {
                return;
            }

            frmCurrencyExchange frmCurrencyExchange = new frmCurrencyExchange();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmCurrencyExchange);
        }
        private void _Logout()
        {
            clsUsers.CurrentUser = clsUsers.GetEmptyUser();
            frmLogin Login = new frmLogin();
            Login.Show();
            this.Close();
        }
        private void btnMainMenue_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString())
            {
                case "Home":
                    _ShowHomeScreen();
                    break;

                case "ManageClients":
                    _ShowManageClientsScreen();
                    break;

                case "ManageUsers":
                    _ShowManageUsersScreen();
                    break;

                case "Transactions":
                    _ShowManageTransactionsScreen();
                    break;

                case "CurrencyExchange":
                    _ShowManageCurrencyExchangeScreen();
                    break;

                case "Logout":
                    _Logout();
                    break;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _ShowHomeScreen();
            lblCurrentUser.Text = "User : " + clsUsers.CurrentUser.UserName;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchInClientsData();
        }
        private void _ClearAdd()
        {
            txtAddAccNumber.Clear();
            txtAddFirstName.Clear();
            txtAddLastName.Clear();
            txtAddEmail.Clear();
            txtAddPhone.Clear();
            txtAddPinCode.Clear();
            nudAddBalance.Value = 0;
        }
        private void _ClearUpdate()
        {
            txtUpdateAccNumber.Clear();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            txtUpdateEmail.Clear();
            txtUpdatePhone.Clear();
            txtUpdatePinCode.Clear();
            nudUpdateBalance.Value = 0;
            txtUpdateAccNumber.ReadOnly = false;
        }
        private void _ReadUpdateInfo(Client Client1)
        {
            Client1.FirstName = txtUpdateFirstName.Text;
            Client1.LastName = txtUpdateLastName.Text;
            Client1.Email = txtUpdateEmail.Text;
            Client1.Phone = txtUpdatePhone.Text;
            Client1.PinCode = txtUpdatePinCode.Text;
            Client1.AccBalance = nudUpdateBalance.Value;
        }
        private bool _IsVaildAdd(TextBox textBox)
        {
            if ((clsClients.IsExists(textBox.Text)) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Focus();
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    MessageBox.Show($"Acc.Number Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Acc.Number ({textBox.Text}) Is Already Exsits, Choice Anthor One", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private bool _IsVaildUpdate(TextBox textBox)
        {
            if ((!clsClients.IsExists(textBox.Text)) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Focus();
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    MessageBox.Show($"Acc.Number Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Acc.Number ({textBox.Text}) Is Not Exsits, Choice Anthor One", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void _AddNewClient()
        {
            if(!_IsVaildAdd(txtAddAccNumber))
            {
                return;
            }

            Client Client1 = clsClients.GetEmptyClient();
            Client1.AccNumber = txtAddAccNumber.Text;
            Client1.FirstName = txtAddFirstName.Text;
            Client1.LastName = txtAddLastName.Text;
            Client1.Email = txtAddEmail.Text;
            Client1.Phone = txtAddPhone.Text;
            Client1.PinCode = txtAddPinCode.Text;
            Client1.AccBalance = nudAddBalance.Value;

            if (clsClients.AddNewClient(Client1))
            {
                MessageBox.Show("Client with Acc.Number (" + Client1.AccNumber + ") Added Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefershClientsData();
                _ClearAdd();
                tabManageClients.SelectedTab = tabpShowClients;
            }
            else
            {
                MessageBox.Show("Error: Added Client Faild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void _UpdateClient()
        {
            if (MessageBox.Show("Are you sure you want to update this Information ? ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Client Client1 = clsClients.Find(txtUpdateAccNumber.Text);

                if (Client1 != null)
                {
                    _ReadUpdateInfo(Client1);

                    if (clsClients.UpdateClient(Client1))
                    {
                        MessageBox.Show("Client with Acc.Number (" + Client1.AccNumber + ") Updated Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefershClientsData();
                        _ClearUpdate();
                        tabManageClients.SelectedTab = tabpShowClients;
                    }
                    else
                    {
                        MessageBox.Show("Error: Updated Client Faild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Information Is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void _DeleteClient()
        {
            if (MessageBox.Show("Are you sure you want to Delete Client with Acc.Number (" + dgvShowClients.CurrentRow.Cells["Acc Num"].Value.ToString() + ") ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (clsClients.DeleteClient(dgvShowClients.CurrentRow.Cells["Acc Num"].Value.ToString()))
                {
                    MessageBox.Show("Client Deleted Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefershClientsData();
                }
                else
                {
                    MessageBox.Show("Client Deleted Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (tabManageClients.SelectedTab.Text.ToString())
            {
                case "Add Client":
                    _AddNewClient();
                    break;

                case "Update Client":
                    _UpdateClient();
                    break;
            }
        }
        private void tabp_Add_Update_Enter(object sender, EventArgs e)
        {
            _ClearAdd();
            _ClearUpdate();
        }
        private void btnGoBackToShowClients_Click(object sender, EventArgs e)
        {
            tabManageClients.SelectedTab = tabpShowClients; 
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!_IsVaildUpdate(txtUpdateAccNumber))
            {
                return;
            }

            Client Client1 = clsClients.Find(txtUpdateAccNumber.Text);

            if (Client1 != null)
            {
                txtUpdateAccNumber.ReadOnly = true;
                txtUpdateAccNumber.Text = Client1.AccNumber;
                txtUpdateFirstName.Text = Client1.FirstName;
                txtUpdateLastName.Text = Client1.LastName;
                txtUpdateEmail.Text = Client1.Email;
                txtUpdatePhone.Text = Client1.Phone;
                txtUpdatePinCode.Text = Client1.PinCode;
                nudUpdateBalance.Value = Client1.AccBalance;
            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _DeleteClient();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabManageClients.SelectedTab = tabpUpdateClient;
            txtUpdateAccNumber.Text = dgvShowClients.CurrentRow.Cells["Acc Num"].Value.ToString();
            txtUpdateAccNumber.ReadOnly = true;
        }
        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmTransactions);
            frmTransactions.tabTransactions().SelectedIndex = 1;
        }
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmTransactions);
            frmTransactions.tabTransactions().SelectedIndex = 2;
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions frmTransactions = new frmTransactions();
            _Show_ManageUsers_Transactions_CurrencyExchange_Scrrens(frmTransactions);
            frmTransactions.tabTransactions().SelectedIndex = 3;
        }
    }
}
