namespace Bank
{
    partial class frmCurrencyExchange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCurrencyExchange = new System.Windows.Forms.TabControl();
            this.tabpShowCurrencies = new System.Windows.Forms.TabPage();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.lblCurrenciesCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShowCurrencies = new System.Windows.Forms.DataGridView();
            this.tabpUpdateRate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.nudNewRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.tabpCurrencyCalculator = new System.Windows.Forms.TabPage();
            this.lblAmountAfterExchange = new System.Windows.Forms.Label();
            this.gbCurrencyFromCard = new System.Windows.Forms.GroupBox();
            this.lblRatefrom = new System.Windows.Forms.Label();
            this.lblNameFrom = new System.Windows.Forms.Label();
            this.lblCodeFrom = new System.Windows.Forms.Label();
            this.lblCountryFrom = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConvertTo = new System.Windows.Forms.TextBox();
            this.urrencyToCard = new System.Windows.Forms.GroupBox();
            this.lblRateTo = new System.Windows.Forms.Label();
            this.lblNameTo = new System.Windows.Forms.Label();
            this.lblCodeTo = new System.Windows.Forms.Label();
            this.lblCountryTo = new System.Windows.Forms.Label();
            this.btnConvertcurrencies = new System.Windows.Forms.Button();
            this.nudConvertAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConvertFrom = new System.Windows.Forms.TextBox();
            this.tabCurrencyExchange.SuspendLayout();
            this.tabpShowCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCurrencies)).BeginInit();
            this.tabpUpdateRate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).BeginInit();
            this.tabpCurrencyCalculator.SuspendLayout();
            this.gbCurrencyFromCard.SuspendLayout();
            this.urrencyToCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvertAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCurrencyExchange
            // 
            this.tabCurrencyExchange.Controls.Add(this.tabpShowCurrencies);
            this.tabCurrencyExchange.Controls.Add(this.tabpUpdateRate);
            this.tabCurrencyExchange.Controls.Add(this.tabpCurrencyCalculator);
            this.tabCurrencyExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCurrencyExchange.Location = new System.Drawing.Point(0, 0);
            this.tabCurrencyExchange.Name = "tabCurrencyExchange";
            this.tabCurrencyExchange.SelectedIndex = 0;
            this.tabCurrencyExchange.Size = new System.Drawing.Size(941, 628);
            this.tabCurrencyExchange.TabIndex = 2;
            // 
            // tabpShowCurrencies
            // 
            this.tabpShowCurrencies.BackColor = System.Drawing.Color.MistyRose;
            this.tabpShowCurrencies.Controls.Add(this.rbCountry);
            this.tabpShowCurrencies.Controls.Add(this.rbCode);
            this.tabpShowCurrencies.Controls.Add(this.lblCurrenciesCount);
            this.tabpShowCurrencies.Controls.Add(this.pictureBox1);
            this.tabpShowCurrencies.Controls.Add(this.txtSearch);
            this.tabpShowCurrencies.Controls.Add(this.dgvShowCurrencies);
            this.tabpShowCurrencies.Location = new System.Drawing.Point(4, 32);
            this.tabpShowCurrencies.Name = "tabpShowCurrencies";
            this.tabpShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tabpShowCurrencies.Size = new System.Drawing.Size(933, 592);
            this.tabpShowCurrencies.TabIndex = 0;
            this.tabpShowCurrencies.Text = "Show Currencies";
            // 
            // rbCountry
            // 
            this.rbCountry.AutoSize = true;
            this.rbCountry.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountry.Location = new System.Drawing.Point(117, 99);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(93, 27);
            this.rbCountry.TabIndex = 10;
            this.rbCountry.Tag = "CountryName";
            this.rbCountry.Text = "Country";
            this.rbCountry.UseVisualStyleBackColor = true;
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Checked = true;
            this.rbCode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCode.Location = new System.Drawing.Point(8, 99);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(70, 27);
            this.rbCode.TabIndex = 9;
            this.rbCode.TabStop = true;
            this.rbCode.Tag = "Code";
            this.rbCode.Text = "Code";
            this.rbCode.UseVisualStyleBackColor = true;
            // 
            // lblCurrenciesCount
            // 
            this.lblCurrenciesCount.AutoSize = true;
            this.lblCurrenciesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrenciesCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCurrenciesCount.Location = new System.Drawing.Point(717, 136);
            this.lblCurrenciesCount.Name = "lblCurrenciesCount";
            this.lblCurrenciesCount.Size = new System.Drawing.Size(176, 29);
            this.lblCurrenciesCount.TabIndex = 8;
            this.lblCurrenciesCount.Text = "0 Currency(ies)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Bank.Properties.Resources.search_2911_32;
            this.pictureBox1.Location = new System.Drawing.Point(216, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 132);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 33);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvShowCurrencies
            // 
            this.dgvShowCurrencies.AllowUserToAddRows = false;
            this.dgvShowCurrencies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowCurrencies.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvShowCurrencies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowCurrencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowCurrencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowCurrencies.Location = new System.Drawing.Point(3, 170);
            this.dgvShowCurrencies.Name = "dgvShowCurrencies";
            this.dgvShowCurrencies.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowCurrencies.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowCurrencies.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowCurrencies.RowTemplate.Height = 25;
            this.dgvShowCurrencies.Size = new System.Drawing.Size(927, 419);
            this.dgvShowCurrencies.TabIndex = 2;
            // 
            // tabpUpdateRate
            // 
            this.tabpUpdateRate.BackColor = System.Drawing.Color.MistyRose;
            this.tabpUpdateRate.Controls.Add(this.groupBox1);
            this.tabpUpdateRate.Controls.Add(this.btnUpdateRate);
            this.tabpUpdateRate.Controls.Add(this.nudNewRate);
            this.tabpUpdateRate.Controls.Add(this.label2);
            this.tabpUpdateRate.Controls.Add(this.label1);
            this.tabpUpdateRate.Controls.Add(this.txtCurrencyCode);
            this.tabpUpdateRate.Location = new System.Drawing.Point(4, 32);
            this.tabpUpdateRate.Name = "tabpUpdateRate";
            this.tabpUpdateRate.Size = new System.Drawing.Size(933, 592);
            this.tabpUpdateRate.TabIndex = 2;
            this.tabpUpdateRate.Text = "Update Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblRate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(525, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 337);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency Card";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRate.Location = new System.Drawing.Point(16, 258);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(109, 25);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Rate ($) : ";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Location = new System.Drawing.Point(16, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(289, 66);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name : ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCode.Location = new System.Drawing.Point(16, 126);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(80, 25);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code : ";
            // 
            // lblCountry
            // 
            this.lblCountry.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountry.Location = new System.Drawing.Point(16, 60);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(289, 66);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country : ";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.Location = new System.Drawing.Point(123, 421);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(313, 49);
            this.btnUpdateRate.TabIndex = 9;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // nudNewRate
            // 
            this.nudNewRate.BackColor = System.Drawing.Color.AliceBlue;
            this.nudNewRate.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNewRate.Location = new System.Drawing.Point(123, 277);
            this.nudNewRate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNewRate.Name = "nudNewRate";
            this.nudNewRate.Size = new System.Drawing.Size(313, 40);
            this.nudNewRate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Rate ($)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Currency Code";
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCurrencyCode.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyCode.Location = new System.Drawing.Point(123, 133);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(313, 40);
            this.txtCurrencyCode.TabIndex = 5;
            // 
            // tabpCurrencyCalculator
            // 
            this.tabpCurrencyCalculator.BackColor = System.Drawing.Color.MistyRose;
            this.tabpCurrencyCalculator.Controls.Add(this.lblAmountAfterExchange);
            this.tabpCurrencyCalculator.Controls.Add(this.gbCurrencyFromCard);
            this.tabpCurrencyCalculator.Controls.Add(this.label9);
            this.tabpCurrencyCalculator.Controls.Add(this.txtConvertTo);
            this.tabpCurrencyCalculator.Controls.Add(this.urrencyToCard);
            this.tabpCurrencyCalculator.Controls.Add(this.btnConvertcurrencies);
            this.tabpCurrencyCalculator.Controls.Add(this.nudConvertAmount);
            this.tabpCurrencyCalculator.Controls.Add(this.label7);
            this.tabpCurrencyCalculator.Controls.Add(this.label8);
            this.tabpCurrencyCalculator.Controls.Add(this.txtConvertFrom);
            this.tabpCurrencyCalculator.Location = new System.Drawing.Point(4, 32);
            this.tabpCurrencyCalculator.Name = "tabpCurrencyCalculator";
            this.tabpCurrencyCalculator.Size = new System.Drawing.Size(933, 592);
            this.tabpCurrencyCalculator.TabIndex = 3;
            this.tabpCurrencyCalculator.Text = "Currency Calculator";
            // 
            // lblAmountAfterExchange
            // 
            this.lblAmountAfterExchange.AutoSize = true;
            this.lblAmountAfterExchange.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountAfterExchange.Location = new System.Drawing.Point(318, 502);
            this.lblAmountAfterExchange.Name = "lblAmountAfterExchange";
            this.lblAmountAfterExchange.Size = new System.Drawing.Size(334, 33);
            this.lblAmountAfterExchange.TabIndex = 20;
            this.lblAmountAfterExchange.Text = "Amount After Exchange";
            this.lblAmountAfterExchange.Visible = false;
            // 
            // gbCurrencyFromCard
            // 
            this.gbCurrencyFromCard.BackColor = System.Drawing.Color.AliceBlue;
            this.gbCurrencyFromCard.Controls.Add(this.lblRatefrom);
            this.gbCurrencyFromCard.Controls.Add(this.lblNameFrom);
            this.gbCurrencyFromCard.Controls.Add(this.lblCodeFrom);
            this.gbCurrencyFromCard.Controls.Add(this.lblCountryFrom);
            this.gbCurrencyFromCard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCurrencyFromCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gbCurrencyFromCard.Location = new System.Drawing.Point(64, 114);
            this.gbCurrencyFromCard.Name = "gbCurrencyFromCard";
            this.gbCurrencyFromCard.Size = new System.Drawing.Size(311, 253);
            this.gbCurrencyFromCard.TabIndex = 19;
            this.gbCurrencyFromCard.TabStop = false;
            this.gbCurrencyFromCard.Text = "Currency From Card";
            // 
            // lblRatefrom
            // 
            this.lblRatefrom.AutoSize = true;
            this.lblRatefrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatefrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRatefrom.Location = new System.Drawing.Point(6, 210);
            this.lblRatefrom.Name = "lblRatefrom";
            this.lblRatefrom.Size = new System.Drawing.Size(109, 25);
            this.lblRatefrom.TabIndex = 3;
            this.lblRatefrom.Text = "Rate ($) : ";
            // 
            // lblNameFrom
            // 
            this.lblNameFrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNameFrom.Location = new System.Drawing.Point(6, 144);
            this.lblNameFrom.Name = "lblNameFrom";
            this.lblNameFrom.Size = new System.Drawing.Size(289, 66);
            this.lblNameFrom.TabIndex = 2;
            this.lblNameFrom.Text = "Name : ";
            // 
            // lblCodeFrom
            // 
            this.lblCodeFrom.AutoSize = true;
            this.lblCodeFrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCodeFrom.Location = new System.Drawing.Point(6, 86);
            this.lblCodeFrom.Name = "lblCodeFrom";
            this.lblCodeFrom.Size = new System.Drawing.Size(80, 25);
            this.lblCodeFrom.TabIndex = 1;
            this.lblCodeFrom.Text = "Code : ";
            // 
            // lblCountryFrom
            // 
            this.lblCountryFrom.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountryFrom.Location = new System.Drawing.Point(6, 29);
            this.lblCountryFrom.Name = "lblCountryFrom";
            this.lblCountryFrom.Size = new System.Drawing.Size(289, 57);
            this.lblCountryFrom.TabIndex = 0;
            this.lblCountryFrom.Text = "Country : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(526, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Convert To";
            // 
            // txtConvertTo
            // 
            this.txtConvertTo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtConvertTo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertTo.Location = new System.Drawing.Point(526, 57);
            this.txtConvertTo.Name = "txtConvertTo";
            this.txtConvertTo.Size = new System.Drawing.Size(313, 40);
            this.txtConvertTo.TabIndex = 17;
            // 
            // urrencyToCard
            // 
            this.urrencyToCard.BackColor = System.Drawing.Color.AliceBlue;
            this.urrencyToCard.Controls.Add(this.lblRateTo);
            this.urrencyToCard.Controls.Add(this.lblNameTo);
            this.urrencyToCard.Controls.Add(this.lblCodeTo);
            this.urrencyToCard.Controls.Add(this.lblCountryTo);
            this.urrencyToCard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urrencyToCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.urrencyToCard.Location = new System.Drawing.Point(526, 114);
            this.urrencyToCard.Name = "urrencyToCard";
            this.urrencyToCard.Size = new System.Drawing.Size(311, 253);
            this.urrencyToCard.TabIndex = 16;
            this.urrencyToCard.TabStop = false;
            this.urrencyToCard.Text = "Currency To Card";
            // 
            // lblRateTo
            // 
            this.lblRateTo.AutoSize = true;
            this.lblRateTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRateTo.Location = new System.Drawing.Point(6, 210);
            this.lblRateTo.Name = "lblRateTo";
            this.lblRateTo.Size = new System.Drawing.Size(109, 25);
            this.lblRateTo.TabIndex = 3;
            this.lblRateTo.Text = "Rate ($) : ";
            // 
            // lblNameTo
            // 
            this.lblNameTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNameTo.Location = new System.Drawing.Point(6, 144);
            this.lblNameTo.Name = "lblNameTo";
            this.lblNameTo.Size = new System.Drawing.Size(289, 66);
            this.lblNameTo.TabIndex = 2;
            this.lblNameTo.Text = "Name : ";
            // 
            // lblCodeTo
            // 
            this.lblCodeTo.AutoSize = true;
            this.lblCodeTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCodeTo.Location = new System.Drawing.Point(6, 86);
            this.lblCodeTo.Name = "lblCodeTo";
            this.lblCodeTo.Size = new System.Drawing.Size(80, 25);
            this.lblCodeTo.TabIndex = 1;
            this.lblCodeTo.Text = "Code : ";
            // 
            // lblCountryTo
            // 
            this.lblCountryTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCountryTo.Location = new System.Drawing.Point(6, 29);
            this.lblCountryTo.Name = "lblCountryTo";
            this.lblCountryTo.Size = new System.Drawing.Size(289, 57);
            this.lblCountryTo.TabIndex = 0;
            this.lblCountryTo.Text = "Country : ";
            // 
            // btnConvertcurrencies
            // 
            this.btnConvertcurrencies.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConvertcurrencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertcurrencies.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertcurrencies.Location = new System.Drawing.Point(526, 420);
            this.btnConvertcurrencies.Name = "btnConvertcurrencies";
            this.btnConvertcurrencies.Size = new System.Drawing.Size(313, 40);
            this.btnConvertcurrencies.TabIndex = 15;
            this.btnConvertcurrencies.Text = "Convert";
            this.btnConvertcurrencies.UseVisualStyleBackColor = false;
            this.btnConvertcurrencies.Click += new System.EventHandler(this.btnConvertcurrencies_Click);
            // 
            // nudConvertAmount
            // 
            this.nudConvertAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.nudConvertAmount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConvertAmount.Location = new System.Drawing.Point(64, 420);
            this.nudConvertAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudConvertAmount.Name = "nudConvertAmount";
            this.nudConvertAmount.Size = new System.Drawing.Size(313, 40);
            this.nudConvertAmount.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount To Exchange";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Convert From";
            // 
            // txtConvertFrom
            // 
            this.txtConvertFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.txtConvertFrom.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertFrom.Location = new System.Drawing.Point(62, 57);
            this.txtConvertFrom.Name = "txtConvertFrom";
            this.txtConvertFrom.Size = new System.Drawing.Size(313, 40);
            this.txtConvertFrom.TabIndex = 11;
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 628);
            this.Controls.Add(this.tabCurrencyExchange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrencyExchange";
            this.Text = "Currency Exchange";
            this.Load += new System.EventHandler(this.FrmCurrencyExchange_Load);
            this.tabCurrencyExchange.ResumeLayout(false);
            this.tabpShowCurrencies.ResumeLayout(false);
            this.tabpShowCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowCurrencies)).EndInit();
            this.tabpUpdateRate.ResumeLayout(false);
            this.tabpUpdateRate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).EndInit();
            this.tabpCurrencyCalculator.ResumeLayout(false);
            this.tabpCurrencyCalculator.PerformLayout();
            this.gbCurrencyFromCard.ResumeLayout(false);
            this.gbCurrencyFromCard.PerformLayout();
            this.urrencyToCard.ResumeLayout(false);
            this.urrencyToCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConvertAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCurrencyExchange;
        private System.Windows.Forms.TabPage tabpShowCurrencies;
        private System.Windows.Forms.TabPage tabpUpdateRate;
        private System.Windows.Forms.TabPage tabpCurrencyCalculator;
        private System.Windows.Forms.DataGridView dgvShowCurrencies;
        private System.Windows.Forms.Label lblCurrenciesCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbCode;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.NumericUpDown nudNewRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConvertTo;
        private System.Windows.Forms.GroupBox urrencyToCard;
        private System.Windows.Forms.Label lblRateTo;
        private System.Windows.Forms.Label lblNameTo;
        private System.Windows.Forms.Label lblCodeTo;
        private System.Windows.Forms.Label lblCountryTo;
        private System.Windows.Forms.Button btnConvertcurrencies;
        private System.Windows.Forms.NumericUpDown nudConvertAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConvertFrom;
        private System.Windows.Forms.GroupBox gbCurrencyFromCard;
        private System.Windows.Forms.Label lblRatefrom;
        private System.Windows.Forms.Label lblNameFrom;
        private System.Windows.Forms.Label lblCodeFrom;
        private System.Windows.Forms.Label lblCountryFrom;
        private System.Windows.Forms.Label lblAmountAfterExchange;
    }
}