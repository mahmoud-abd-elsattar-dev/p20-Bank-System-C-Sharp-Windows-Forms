namespace Bank
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabManageTransactions = new System.Windows.Forms.TabControl();
            this.tabpShowTotalBalances = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.dgvShowBalances = new System.Windows.Forms.DataGridView();
            this.tabpDeposite = new System.Windows.Forms.TabPage();
            this.urrencyToCard = new System.Windows.Forms.GroupBox();
            this.lblDepositBalance = new System.Windows.Forms.Label();
            this.lblDepositPinCode = new System.Windows.Forms.Label();
            this.lblDepositPhone = new System.Windows.Forms.Label();
            this.lblDepositEmail = new System.Windows.Forms.Label();
            this.lblDepositAccNum = new System.Windows.Forms.Label();
            this.lblDepositName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudDepositeAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepositeAccNumber = new System.Windows.Forms.TextBox();
            this.tabpWithdraw = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWithdrawBalance = new System.Windows.Forms.Label();
            this.lblWithdrawPinCode = new System.Windows.Forms.Label();
            this.lblWithdrawPhone = new System.Windows.Forms.Label();
            this.lblWithdrawEmail = new System.Windows.Forms.Label();
            this.lblWithdrawAccNum = new System.Windows.Forms.Label();
            this.lblWithdrawName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nudWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWithdrawAccNumber = new System.Windows.Forms.TextBox();
            this.tabpTransfers = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccNumberFrom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nudTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.txtAccNumberTo = new System.Windows.Forms.TextBox();
            this.tabpTransfersLog = new System.Windows.Forms.TabPage();
            this.dgvShowTransfersLog = new System.Windows.Forms.DataGridView();
            this.tabManageTransactions.SuspendLayout();
            this.tabpShowTotalBalances.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBalances)).BeginInit();
            this.tabpDeposite.SuspendLayout();
            this.urrencyToCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositeAmount)).BeginInit();
            this.tabpWithdraw.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).BeginInit();
            this.tabpTransfers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).BeginInit();
            this.tabpTransfersLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTransfersLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageTransactions
            // 
            this.tabManageTransactions.Controls.Add(this.tabpShowTotalBalances);
            this.tabManageTransactions.Controls.Add(this.tabpDeposite);
            this.tabManageTransactions.Controls.Add(this.tabpWithdraw);
            this.tabManageTransactions.Controls.Add(this.tabpTransfers);
            this.tabManageTransactions.Controls.Add(this.tabpTransfersLog);
            this.tabManageTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageTransactions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManageTransactions.Location = new System.Drawing.Point(0, 0);
            this.tabManageTransactions.Name = "tabManageTransactions";
            this.tabManageTransactions.SelectedIndex = 0;
            this.tabManageTransactions.Size = new System.Drawing.Size(941, 628);
            this.tabManageTransactions.TabIndex = 1;
            // 
            // tabpShowTotalBalances
            // 
            this.tabpShowTotalBalances.BackColor = System.Drawing.Color.MistyRose;
            this.tabpShowTotalBalances.Controls.Add(this.panel1);
            this.tabpShowTotalBalances.Controls.Add(this.dgvShowBalances);
            this.tabpShowTotalBalances.Location = new System.Drawing.Point(4, 32);
            this.tabpShowTotalBalances.Name = "tabpShowTotalBalances";
            this.tabpShowTotalBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tabpShowTotalBalances.Size = new System.Drawing.Size(933, 592);
            this.tabpShowTotalBalances.TabIndex = 0;
            this.tabpShowTotalBalances.Text = "Show Total Balances";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblTotalBalances);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 93);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalBalances.Location = new System.Drawing.Point(5, 33);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(273, 33);
            this.lblTotalBalances.TabIndex = 0;
            this.lblTotalBalances.Text = "Total Balances Is : ";
            // 
            // dgvShowBalances
            // 
            this.dgvShowBalances.AllowUserToAddRows = false;
            this.dgvShowBalances.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowBalances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowBalances.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvShowBalances.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowBalances.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowBalances.Location = new System.Drawing.Point(3, 170);
            this.dgvShowBalances.Name = "dgvShowBalances";
            this.dgvShowBalances.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowBalances.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowBalances.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowBalances.RowTemplate.Height = 25;
            this.dgvShowBalances.Size = new System.Drawing.Size(927, 419);
            this.dgvShowBalances.TabIndex = 1;
            // 
            // tabpDeposite
            // 
            this.tabpDeposite.BackColor = System.Drawing.Color.MistyRose;
            this.tabpDeposite.Controls.Add(this.urrencyToCard);
            this.tabpDeposite.Controls.Add(this.btnSave);
            this.tabpDeposite.Controls.Add(this.nudDepositeAmount);
            this.tabpDeposite.Controls.Add(this.label2);
            this.tabpDeposite.Controls.Add(this.label1);
            this.tabpDeposite.Controls.Add(this.txtDepositeAccNumber);
            this.tabpDeposite.Location = new System.Drawing.Point(4, 22);
            this.tabpDeposite.Name = "tabpDeposite";
            this.tabpDeposite.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDeposite.Size = new System.Drawing.Size(933, 602);
            this.tabpDeposite.TabIndex = 1;
            this.tabpDeposite.Text = "Deposite";
            // 
            // urrencyToCard
            // 
            this.urrencyToCard.BackColor = System.Drawing.Color.AliceBlue;
            this.urrencyToCard.Controls.Add(this.lblDepositBalance);
            this.urrencyToCard.Controls.Add(this.lblDepositPinCode);
            this.urrencyToCard.Controls.Add(this.lblDepositPhone);
            this.urrencyToCard.Controls.Add(this.lblDepositEmail);
            this.urrencyToCard.Controls.Add(this.lblDepositAccNum);
            this.urrencyToCard.Controls.Add(this.lblDepositName);
            this.urrencyToCard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urrencyToCard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.urrencyToCard.Location = new System.Drawing.Point(487, 121);
            this.urrencyToCard.Name = "urrencyToCard";
            this.urrencyToCard.Size = new System.Drawing.Size(352, 337);
            this.urrencyToCard.TabIndex = 17;
            this.urrencyToCard.TabStop = false;
            this.urrencyToCard.Text = "Client Card";
            // 
            // lblDepositBalance
            // 
            this.lblDepositBalance.AutoSize = true;
            this.lblDepositBalance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositBalance.Location = new System.Drawing.Point(6, 262);
            this.lblDepositBalance.Name = "lblDepositBalance";
            this.lblDepositBalance.Size = new System.Drawing.Size(106, 25);
            this.lblDepositBalance.TabIndex = 5;
            this.lblDepositBalance.Text = "Balance : ";
            // 
            // lblDepositPinCode
            // 
            this.lblDepositPinCode.AutoSize = true;
            this.lblDepositPinCode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositPinCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositPinCode.Location = new System.Drawing.Point(6, 219);
            this.lblDepositPinCode.Name = "lblDepositPinCode";
            this.lblDepositPinCode.Size = new System.Drawing.Size(109, 25);
            this.lblDepositPinCode.TabIndex = 4;
            this.lblDepositPinCode.Text = "PinCode : ";
            // 
            // lblDepositPhone
            // 
            this.lblDepositPhone.AutoSize = true;
            this.lblDepositPhone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositPhone.Location = new System.Drawing.Point(6, 176);
            this.lblDepositPhone.Name = "lblDepositPhone";
            this.lblDepositPhone.Size = new System.Drawing.Size(91, 25);
            this.lblDepositPhone.TabIndex = 3;
            this.lblDepositPhone.Text = "Phone : ";
            // 
            // lblDepositEmail
            // 
            this.lblDepositEmail.AutoSize = true;
            this.lblDepositEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositEmail.Location = new System.Drawing.Point(6, 133);
            this.lblDepositEmail.Name = "lblDepositEmail";
            this.lblDepositEmail.Size = new System.Drawing.Size(84, 25);
            this.lblDepositEmail.TabIndex = 2;
            this.lblDepositEmail.Text = "Email : ";
            // 
            // lblDepositAccNum
            // 
            this.lblDepositAccNum.AutoSize = true;
            this.lblDepositAccNum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAccNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositAccNum.Location = new System.Drawing.Point(6, 90);
            this.lblDepositAccNum.Name = "lblDepositAccNum";
            this.lblDepositAccNum.Size = new System.Drawing.Size(116, 25);
            this.lblDepositAccNum.TabIndex = 1;
            this.lblDepositAccNum.Text = "Acc.Num : ";
            // 
            // lblDepositName
            // 
            this.lblDepositName.AutoSize = true;
            this.lblDepositName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDepositName.Location = new System.Drawing.Point(6, 47);
            this.lblDepositName.Name = "lblDepositName";
            this.lblDepositName.Size = new System.Drawing.Size(87, 25);
            this.lblDepositName.TabIndex = 0;
            this.lblDepositName.Text = "Name : ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(102, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(313, 49);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Deposite";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudDepositeAmount
            // 
            this.nudDepositeAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.nudDepositeAmount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDepositeAmount.Location = new System.Drawing.Point(102, 265);
            this.nudDepositeAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDepositeAmount.Name = "nudDepositeAmount";
            this.nudDepositeAmount.Size = new System.Drawing.Size(313, 40);
            this.nudDepositeAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deposite Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acc.Number";
            // 
            // txtDepositeAccNumber
            // 
            this.txtDepositeAccNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDepositeAccNumber.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositeAccNumber.Location = new System.Drawing.Point(102, 121);
            this.txtDepositeAccNumber.Name = "txtDepositeAccNumber";
            this.txtDepositeAccNumber.Size = new System.Drawing.Size(313, 40);
            this.txtDepositeAccNumber.TabIndex = 0;
            // 
            // tabpWithdraw
            // 
            this.tabpWithdraw.BackColor = System.Drawing.Color.MistyRose;
            this.tabpWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabpWithdraw.Controls.Add(this.groupBox1);
            this.tabpWithdraw.Controls.Add(this.button1);
            this.tabpWithdraw.Controls.Add(this.nudWithdrawAmount);
            this.tabpWithdraw.Controls.Add(this.label3);
            this.tabpWithdraw.Controls.Add(this.label4);
            this.tabpWithdraw.Controls.Add(this.txtWithdrawAccNumber);
            this.tabpWithdraw.Location = new System.Drawing.Point(4, 22);
            this.tabpWithdraw.Name = "tabpWithdraw";
            this.tabpWithdraw.Size = new System.Drawing.Size(933, 602);
            this.tabpWithdraw.TabIndex = 2;
            this.tabpWithdraw.Text = "Withdraw";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblWithdrawBalance);
            this.groupBox1.Controls.Add(this.lblWithdrawPinCode);
            this.groupBox1.Controls.Add(this.lblWithdrawPhone);
            this.groupBox1.Controls.Add(this.lblWithdrawEmail);
            this.groupBox1.Controls.Add(this.lblWithdrawAccNum);
            this.groupBox1.Controls.Add(this.lblWithdrawName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(487, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 337);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Card";
            // 
            // lblWithdrawBalance
            // 
            this.lblWithdrawBalance.AutoSize = true;
            this.lblWithdrawBalance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawBalance.Location = new System.Drawing.Point(6, 262);
            this.lblWithdrawBalance.Name = "lblWithdrawBalance";
            this.lblWithdrawBalance.Size = new System.Drawing.Size(106, 25);
            this.lblWithdrawBalance.TabIndex = 5;
            this.lblWithdrawBalance.Text = "Balance : ";
            // 
            // lblWithdrawPinCode
            // 
            this.lblWithdrawPinCode.AutoSize = true;
            this.lblWithdrawPinCode.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawPinCode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawPinCode.Location = new System.Drawing.Point(6, 219);
            this.lblWithdrawPinCode.Name = "lblWithdrawPinCode";
            this.lblWithdrawPinCode.Size = new System.Drawing.Size(109, 25);
            this.lblWithdrawPinCode.TabIndex = 4;
            this.lblWithdrawPinCode.Text = "PinCode : ";
            // 
            // lblWithdrawPhone
            // 
            this.lblWithdrawPhone.AutoSize = true;
            this.lblWithdrawPhone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawPhone.Location = new System.Drawing.Point(6, 176);
            this.lblWithdrawPhone.Name = "lblWithdrawPhone";
            this.lblWithdrawPhone.Size = new System.Drawing.Size(91, 25);
            this.lblWithdrawPhone.TabIndex = 3;
            this.lblWithdrawPhone.Text = "Phone : ";
            // 
            // lblWithdrawEmail
            // 
            this.lblWithdrawEmail.AutoSize = true;
            this.lblWithdrawEmail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawEmail.Location = new System.Drawing.Point(6, 133);
            this.lblWithdrawEmail.Name = "lblWithdrawEmail";
            this.lblWithdrawEmail.Size = new System.Drawing.Size(84, 25);
            this.lblWithdrawEmail.TabIndex = 2;
            this.lblWithdrawEmail.Text = "Email : ";
            // 
            // lblWithdrawAccNum
            // 
            this.lblWithdrawAccNum.AutoSize = true;
            this.lblWithdrawAccNum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawAccNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawAccNum.Location = new System.Drawing.Point(6, 90);
            this.lblWithdrawAccNum.Name = "lblWithdrawAccNum";
            this.lblWithdrawAccNum.Size = new System.Drawing.Size(116, 25);
            this.lblWithdrawAccNum.TabIndex = 1;
            this.lblWithdrawAccNum.Text = "Acc.Num : ";
            // 
            // lblWithdrawName
            // 
            this.lblWithdrawName.AutoSize = true;
            this.lblWithdrawName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWithdrawName.Location = new System.Drawing.Point(6, 47);
            this.lblWithdrawName.Name = "lblWithdrawName";
            this.lblWithdrawName.Size = new System.Drawing.Size(87, 25);
            this.lblWithdrawName.TabIndex = 0;
            this.lblWithdrawName.Text = "Name : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(88, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudWithdrawAmount
            // 
            this.nudWithdrawAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.nudWithdrawAmount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWithdrawAmount.Location = new System.Drawing.Point(88, 281);
            this.nudWithdrawAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudWithdrawAmount.Name = "nudWithdrawAmount";
            this.nudWithdrawAmount.Size = new System.Drawing.Size(313, 40);
            this.nudWithdrawAmount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Withdraw Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acc.Number";
            // 
            // txtWithdrawAccNumber
            // 
            this.txtWithdrawAccNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtWithdrawAccNumber.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawAccNumber.Location = new System.Drawing.Point(88, 137);
            this.txtWithdrawAccNumber.Name = "txtWithdrawAccNumber";
            this.txtWithdrawAccNumber.Size = new System.Drawing.Size(313, 40);
            this.txtWithdrawAccNumber.TabIndex = 5;
            // 
            // tabpTransfers
            // 
            this.tabpTransfers.BackColor = System.Drawing.Color.MistyRose;
            this.tabpTransfers.Controls.Add(this.label7);
            this.tabpTransfers.Controls.Add(this.txtAccNumberFrom);
            this.tabpTransfers.Controls.Add(this.button2);
            this.tabpTransfers.Controls.Add(this.nudTransferAmount);
            this.tabpTransfers.Controls.Add(this.label5);
            this.tabpTransfers.Controls.Add(this.l);
            this.tabpTransfers.Controls.Add(this.txtAccNumberTo);
            this.tabpTransfers.Location = new System.Drawing.Point(4, 22);
            this.tabpTransfers.Name = "tabpTransfers";
            this.tabpTransfers.Size = new System.Drawing.Size(933, 602);
            this.tabpTransfers.TabIndex = 3;
            this.tabpTransfers.Text = "Transfers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Acc.Number From :";
            // 
            // txtAccNumberFrom
            // 
            this.txtAccNumberFrom.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAccNumberFrom.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumberFrom.Location = new System.Drawing.Point(84, 152);
            this.txtAccNumberFrom.Name = "txtAccNumberFrom";
            this.txtAccNumberFrom.Size = new System.Drawing.Size(313, 40);
            this.txtAccNumberFrom.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(310, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(313, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Transfer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudTransferAmount
            // 
            this.nudTransferAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.nudTransferAmount.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTransferAmount.Location = new System.Drawing.Point(310, 291);
            this.nudTransferAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTransferAmount.Name = "nudTransferAmount";
            this.nudTransferAmount.Size = new System.Drawing.Size(313, 40);
            this.nudTransferAmount.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Transfer Amount";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(523, 124);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(184, 25);
            this.l.TabIndex = 11;
            this.l.Text = "Acc.Number To :";
            // 
            // txtAccNumberTo
            // 
            this.txtAccNumberTo.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAccNumberTo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumberTo.Location = new System.Drawing.Point(523, 152);
            this.txtAccNumberTo.Name = "txtAccNumberTo";
            this.txtAccNumberTo.Size = new System.Drawing.Size(313, 40);
            this.txtAccNumberTo.TabIndex = 10;
            // 
            // tabpTransfersLog
            // 
            this.tabpTransfersLog.BackColor = System.Drawing.Color.MistyRose;
            this.tabpTransfersLog.Controls.Add(this.dgvShowTransfersLog);
            this.tabpTransfersLog.Location = new System.Drawing.Point(4, 22);
            this.tabpTransfersLog.Name = "tabpTransfersLog";
            this.tabpTransfersLog.Size = new System.Drawing.Size(933, 602);
            this.tabpTransfersLog.TabIndex = 4;
            this.tabpTransfersLog.Text = "Transfers Log";
            this.tabpTransfersLog.Enter += new System.EventHandler(this.tabpTransfersLog_Enter);
            // 
            // dgvShowTransfersLog
            // 
            this.dgvShowTransfersLog.AllowUserToAddRows = false;
            this.dgvShowTransfersLog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowTransfersLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowTransfersLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowTransfersLog.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvShowTransfersLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowTransfersLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowTransfersLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowTransfersLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowTransfersLog.Location = new System.Drawing.Point(0, 183);
            this.dgvShowTransfersLog.Name = "dgvShowTransfersLog";
            this.dgvShowTransfersLog.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowTransfersLog.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowTransfersLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowTransfersLog.RowTemplate.Height = 25;
            this.dgvShowTransfersLog.Size = new System.Drawing.Size(933, 419);
            this.dgvShowTransfersLog.TabIndex = 2;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 628);
            this.Controls.Add(this.tabManageTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.Text = "     Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tabManageTransactions.ResumeLayout(false);
            this.tabpShowTotalBalances.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowBalances)).EndInit();
            this.tabpDeposite.ResumeLayout(false);
            this.tabpDeposite.PerformLayout();
            this.urrencyToCard.ResumeLayout(false);
            this.urrencyToCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositeAmount)).EndInit();
            this.tabpWithdraw.ResumeLayout(false);
            this.tabpWithdraw.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).EndInit();
            this.tabpTransfers.ResumeLayout(false);
            this.tabpTransfers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).EndInit();
            this.tabpTransfersLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowTransfersLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageTransactions;
        private System.Windows.Forms.TabPage tabpShowTotalBalances;
        private System.Windows.Forms.TabPage tabpDeposite;
        private System.Windows.Forms.TabPage tabpWithdraw;
        private System.Windows.Forms.TabPage tabpTransfers;
        private System.Windows.Forms.TabPage tabpTransfersLog;
        private System.Windows.Forms.DataGridView dgvShowBalances;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.TextBox txtDepositeAccNumber;
        private System.Windows.Forms.NumericUpDown nudDepositeAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudWithdrawAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWithdrawAccNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccNumberFrom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudTransferAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox txtAccNumberTo;
        private System.Windows.Forms.DataGridView dgvShowTransfersLog;
        private System.Windows.Forms.GroupBox urrencyToCard;
        private System.Windows.Forms.Label lblDepositPhone;
        private System.Windows.Forms.Label lblDepositEmail;
        private System.Windows.Forms.Label lblDepositAccNum;
        private System.Windows.Forms.Label lblDepositName;
        private System.Windows.Forms.Label lblDepositBalance;
        private System.Windows.Forms.Label lblDepositPinCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWithdrawBalance;
        private System.Windows.Forms.Label lblWithdrawPinCode;
        private System.Windows.Forms.Label lblWithdrawPhone;
        private System.Windows.Forms.Label lblWithdrawEmail;
        private System.Windows.Forms.Label lblWithdrawAccNum;
        private System.Windows.Forms.Label lblWithdrawName;
    }
}