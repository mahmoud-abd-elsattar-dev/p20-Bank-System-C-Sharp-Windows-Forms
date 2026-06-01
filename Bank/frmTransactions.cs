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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            _RefershTotalBalances();
        }
        private void _RefershTotalBalances()
        {
            dgvShowBalances.DataSource = clsTransactions.GetTotalBalances();
            lblTotalBalances.Text = "Total Balances Is : " + clsTransactions.TotalBalances().ToString() + " ($)";
        }
        private void _ClearDeposit()
        {
            txtDepositeAccNumber.Clear();
            nudDepositeAmount.Value = 0;
            lblDepositName.Text = "Name : ";
            lblDepositAccNum.Text = "Acc.Num : ";
            lblDepositEmail.Text = "Email : ";
            lblDepositPhone.Text = "Phone : ";
            lblDepositPinCode.Text = "PinCode : ";
            lblDepositBalance.Text = "Balance : ";
        }
        private void _ClearWithdraw()
        {
            txtWithdrawAccNumber.Clear();
            nudWithdrawAmount.Value = 0;
            lblWithdrawName.Text = "Name : ";
            lblWithdrawAccNum.Text = "Acc.Num : ";
            lblWithdrawEmail.Text = "Email : ";
            lblWithdrawPhone.Text = "Phone : ";
            lblWithdrawPinCode.Text = "PinCode : ";
            lblWithdrawBalance.Text = "Balance : ";
        }
        private void _ClearTransfer()
        {
            txtAccNumberFrom.Clear();
            txtAccNumberTo.Clear();
            nudTransferAmount.Value = 0;
        }
        private void _PrintDepositClientCard(Client Client1)
        {
            lblDepositName.Text = "Name : " + Client1.FirstName + " " + Client1.LastName;
            lblDepositAccNum.Text = "Acc.Num : " + Client1.AccNumber;
            lblDepositEmail.Text = "Email : " + Client1.Email;
            lblDepositPhone.Text = "Phone : " + Client1.Phone;
            lblDepositPinCode.Text = "PinCode : " + Client1.PinCode;
            lblDepositBalance.Text = "Balance : " + Client1.AccBalance.ToString();
        }
        private void _PrintWithdrawClientCard(Client Client1)
        {
            lblWithdrawName.Text = "Name : " + Client1.FirstName + " " + Client1.LastName;
            lblWithdrawAccNum.Text = "Acc.Num : " + Client1.AccNumber;
            lblWithdrawEmail.Text = "Email : " + Client1.Email;
            lblWithdrawPhone.Text = "Phone : " + Client1.Phone;
            lblWithdrawPinCode.Text = "PinCode : " + Client1.PinCode;
            lblWithdrawBalance.Text = "Balance : " + Client1.AccBalance.ToString();
        }
        private bool _IsVaild(TextBox textBox)
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
        private void _Deposite()
        {
            if (!_IsVaild(txtDepositeAccNumber))
            {
                return;
            }

            Client Client1 = clsClients.Find(txtDepositeAccNumber.Text);
            _PrintDepositClientCard(Client1);

            if (nudDepositeAmount.Value > 0)
            {
                if (MessageBox.Show($"Are you sure you want to perform tramsaction ?", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsTransactions.Deposite(txtDepositeAccNumber.Text, (decimal)nudDepositeAmount.Value))
                    {
                        MessageBox.Show($"Deposit Done Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefershTotalBalances();
                        _ClearDeposit();
                        tabManageTransactions.SelectedTab = tabpShowTotalBalances;
                    }
                    else
                    {
                        MessageBox.Show($"Error: Deposit Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                nudDepositeAmount.Focus();
                MessageBox.Show($"Deposite Amount Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _Withdraw()
        {
            if(!_IsVaild(txtWithdrawAccNumber))
            {
                return; 
            }

            Client Client1 = clsClients.Find(txtWithdrawAccNumber.Text);
            _PrintWithdrawClientCard(Client1);

            if (Client1.AccBalance < nudWithdrawAmount.Value)
            {
                MessageBox.Show($"Amount Exceeds The Balance, you can withdraw up to : {Client1.AccBalance}", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudWithdrawAmount.Focus();
                return;
            }


            if (nudWithdrawAmount.Value > 0)
            {
                if (MessageBox.Show($"Are you sure you want to perform tramsaction ?", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsTransactions.Withdraw(txtWithdrawAccNumber.Text, (decimal)nudWithdrawAmount.Value))
                    {
                        MessageBox.Show($"Withdraw Done Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefershTotalBalances();
                        _ClearWithdraw();
                        tabManageTransactions.SelectedTab = tabpShowTotalBalances;
                    }
                    else
                    {
                        MessageBox.Show($"Error: Withdraw Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                nudDepositeAmount.Focus();
                MessageBox.Show($"Withdraw Amount Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _Transfer()
        {
            if (!_IsVaild(txtAccNumberFrom))
            {
                return;
            }

            if (!_IsVaild(txtAccNumberTo))
            {
                return;
            }

            Client ClientFrom = clsClients.Find(txtAccNumberFrom.Text);

            if (ClientFrom.AccBalance < nudTransferAmount.Value)
            {
                MessageBox.Show($"Amount Exceeds The Balance, you can transfer up to : {ClientFrom.AccBalance}", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudTransferAmount.Focus();
                return;
            }

            if (nudTransferAmount.Value > 0)
            {
                if (MessageBox.Show($"Are you sure you want to perform tramsaction ?", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsTransactions.Transfer((decimal)nudTransferAmount.Value, txtAccNumberFrom.Text, txtAccNumberTo.Text))
                    {
                        MessageBox.Show($"Transfer Done Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefershTotalBalances();
                        _ClearTransfer();
                        tabManageTransactions.SelectedTab = tabpShowTotalBalances;
                    }
                    else
                    {
                        MessageBox.Show($"Error: Transfer Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                nudTransferAmount.Focus();
                MessageBox.Show($"Transfer Amount Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void _TransfersLog()
        {
            dgvShowTransfersLog.DataSource = clsTransactions.GetTransferLog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch(tabManageTransactions.SelectedTab.Text)
            {
                case "Deposite":
                    _Deposite();
                    break;

                case "Withdraw":
                    _Withdraw();
                    break;

                case "Transfers":
                    _Transfer();
                    break;

            }
        }
        private void tabpTransfersLog_Enter(object sender, EventArgs e)
        {
            _TransfersLog();
        }
        public TabControl tabTransactions()
        {
            return tabManageTransactions;
        }


    }
}
