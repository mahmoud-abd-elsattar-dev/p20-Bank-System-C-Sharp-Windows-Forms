using Bank_Business_Layer;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void FrmCurrencyExchange_Load(object sender, EventArgs e)
        {
            _RefreshCurrenciesList();
        }
        private void _RefreshCurrenciesList()
        {
            dgvShowCurrencies.DataSource = clsCurrencies.GetListCurrencies();
            lblCurrenciesCount.Text = dgvShowCurrencies.Rows.Count.ToString() + " Currency(ies)";
        }
        private void _SearchInCurrenciesData()
        {
            DataTable dataTable = clsCurrencies.GetListCurrencies();
            string SearchValue = txtSearch.Text.Trim();
            string Searchby;

            if (rbCode.Checked)
                Searchby = rbCode.Tag.ToString();
            else
                Searchby = rbCountry.Tag.ToString();

            if (!string.IsNullOrEmpty(SearchValue))
            {
                dataTable.DefaultView.RowFilter = $"[{Searchby}] LIKE '%{SearchValue}%'";
                dgvShowCurrencies.DataSource = dataTable;
                lblCurrenciesCount.Text = dgvShowCurrencies.Rows.Count.ToString() + " Currency(ies)";
            }
            else
            {
                dataTable.DefaultView.RowFilter = string.Empty;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _SearchInCurrenciesData();
        }
        private bool _IsVaild(TextBox textBox)
        {
            if ((!clsCurrencies.IsExists(textBox.Text)) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Focus();
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    MessageBox.Show($"Currency Code Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Currency Code ({textBox.Text}) Is Not Exsits, Choice Anthor One", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        private void _PrintCurrencyInfo(Currency Currency1)
        {
            lblCountry.Text = "Country : " + Currency1.CountryName;
            lblCode.Text = "Code : " + Currency1.Code;
            lblName.Text = "Name : " + Currency1.Name;
            lblRate.Text = "Rate (1$) : " + Currency1.ExchangeRateUSD.ToString();
        }
        private void _PrintCurrenciesInfo(Currency CurrencyFrom, Currency CurrencyTo)
        {
            //Currency From Info.
            lblCountryFrom.Text = "Country : " + CurrencyFrom.CountryName;
            lblCodeFrom.Text = "Code : " + CurrencyFrom.Code;
            lblNameFrom.Text = "Name : " + CurrencyFrom.Name;
            lblRatefrom.Text = "Rate (1$) : " + CurrencyFrom.ExchangeRateUSD.ToString();

            //Currency To Info.
            lblCountryTo.Text = "Country : " + CurrencyTo.CountryName;
            lblCodeTo.Text = "Code : " + CurrencyTo.Code;
            lblNameTo.Text = "Name : " + CurrencyTo.Name;
            lblRateTo.Text = "Rate (1$) : " + CurrencyTo.ExchangeRateUSD.ToString();

        }
        private void _ClearUpdateRate()
        {
            txtCurrencyCode.Clear();
            nudNewRate.Value = 0;
            lblCountry.Text = "Country : ";
            lblCode.Text = "Code : ";
            lblName.Text = "Name : ";
            lblRate.Text = "Rate (1$) : ";
        }
        private void _UpdateRate()
        {
            if(!_IsVaild(txtCurrencyCode))
            {
                return;
            }

            Currency Currency1 = clsCurrencies.FindByCode(txtCurrencyCode.Text);
            _PrintCurrencyInfo(Currency1);

            if (nudNewRate.Value > 0)
            {
                if (clsCurrencies.UpdateRate(txtCurrencyCode.Text, (decimal)nudNewRate.Value))
                {
                    MessageBox.Show($"Rate Updated Successfully.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCurrenciesList();
                    _ClearUpdateRate();
                }
                else
                {
                    MessageBox.Show($"Error: Update Rate Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                nudNewRate.Focus();
                MessageBox.Show($"New Rate Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void _CurrencyCalculator()
        {
            if (!_IsVaild(txtConvertFrom))
            {
                return;
            }

            if (!_IsVaild(txtConvertTo))
            {
                return;
            }

            Currency CurrencyFrom = clsCurrencies.FindByCode(txtConvertFrom.Text);
            Currency CurrencyTo = clsCurrencies.FindByCode(txtConvertTo.Text);
            _PrintCurrenciesInfo(CurrencyFrom, CurrencyTo);


            if (nudConvertAmount.Value > 0)
            {
                if (CurrencyTo.Code == "USD" || CurrencyTo.Code == "usd")
                {
                    lblAmountAfterExchange.Text = nudConvertAmount.Value.ToString() + " " + CurrencyFrom.Code + " = " +
                    ((float)nudConvertAmount.Value / (float)CurrencyFrom.ExchangeRateUSD) + " " + CurrencyTo.Code;
                    lblAmountAfterExchange.Visible = true;
                }
                else
                {
                    lblAmountAfterExchange.Text = $"{nudConvertAmount.Value} {CurrencyFrom.Code} = {(float)((nudConvertAmount.Value / CurrencyFrom.ExchangeRateUSD) * CurrencyTo.ExchangeRateUSD)} {CurrencyTo.Code}";
                    lblAmountAfterExchange.Visible = true;
                }
            }
            else
            {
                nudNewRate.Focus();
                MessageBox.Show($"Amount To Exchange Shoud have a Value", "Invaild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            _UpdateRate();
        }
        private void btnConvertcurrencies_Click(object sender, EventArgs e)
        {
            _CurrencyCalculator();
        }
    }
}
