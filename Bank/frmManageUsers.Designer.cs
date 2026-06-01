namespace Bank
{
    partial class frmManageUsers
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabManageUsers = new System.Windows.Forms.TabControl();
            this.tabpShowUsers = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsersCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShowUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refershToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabpAddUser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkManageTransactions = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNoDontGiveFullAccess = new System.Windows.Forms.RadioButton();
            this.rbYesGiveFullAccess = new System.Windows.Forms.RadioButton();
            this.chkManageClients = new System.Windows.Forms.CheckBox();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.tabpUpdateUser = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUpdateCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.chkUpdateManageTransactions = new System.Windows.Forms.CheckBox();
            this.chkUpdateManageUsers = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbNoDontUpdateGiveFullAccess = new System.Windows.Forms.RadioButton();
            this.rbYesUpdateGiveFullAccess = new System.Windows.Forms.RadioButton();
            this.chkUpdateManageClients = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.tabpUsersLog = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.lblUsersLogCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearchUsersLog = new System.Windows.Forms.TextBox();
            this.dgvUsersLog = new System.Windows.Forms.DataGridView();
            this.tabManageUsers.SuspendLayout();
            this.tabpShowUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabpAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpUpdateUser.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabpUsersLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabManageUsers
            // 
            this.tabManageUsers.Controls.Add(this.tabpShowUsers);
            this.tabManageUsers.Controls.Add(this.tabpAddUser);
            this.tabManageUsers.Controls.Add(this.tabpUpdateUser);
            this.tabManageUsers.Controls.Add(this.tabpUsersLog);
            this.tabManageUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageUsers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManageUsers.Location = new System.Drawing.Point(0, 0);
            this.tabManageUsers.Name = "tabManageUsers";
            this.tabManageUsers.SelectedIndex = 0;
            this.tabManageUsers.Size = new System.Drawing.Size(941, 628);
            this.tabManageUsers.TabIndex = 1;
            // 
            // tabpShowUsers
            // 
            this.tabpShowUsers.BackColor = System.Drawing.Color.MistyRose;
            this.tabpShowUsers.Controls.Add(this.label1);
            this.tabpShowUsers.Controls.Add(this.lblUsersCount);
            this.tabpShowUsers.Controls.Add(this.pictureBox1);
            this.tabpShowUsers.Controls.Add(this.txtSearch);
            this.tabpShowUsers.Controls.Add(this.dgvShowUsers);
            this.tabpShowUsers.Location = new System.Drawing.Point(4, 32);
            this.tabpShowUsers.Name = "tabpShowUsers";
            this.tabpShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabpShowUsers.Size = new System.Drawing.Size(933, 592);
            this.tabpShowUsers.TabIndex = 0;
            this.tabpShowUsers.Text = "Show Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserName";
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.AutoSize = true;
            this.lblUsersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsersCount.Location = new System.Drawing.Point(798, 135);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(111, 29);
            this.lblUsersCount.TabIndex = 8;
            this.lblUsersCount.Text = "0 User(s)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Bank.Properties.Resources.search_2911_32;
            this.pictureBox1.Location = new System.Drawing.Point(216, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 33);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvShowUsers
            // 
            this.dgvShowUsers.AllowUserToAddRows = false;
            this.dgvShowUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShowUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowUsers.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvShowUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvShowUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvShowUsers.Location = new System.Drawing.Point(3, 170);
            this.dgvShowUsers.Name = "dgvShowUsers";
            this.dgvShowUsers.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvShowUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowUsers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowUsers.RowTemplate.Height = 25;
            this.dgvShowUsers.Size = new System.Drawing.Size(927, 419);
            this.dgvShowUsers.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refershToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // refershToolStripMenuItem
            // 
            this.refershToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refershToolStripMenuItem.Name = "refershToolStripMenuItem";
            this.refershToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.refershToolStripMenuItem.Text = "Edit ";
            this.refershToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabpAddUser
            // 
            this.tabpAddUser.BackColor = System.Drawing.Color.MistyRose;
            this.tabpAddUser.Controls.Add(this.groupBox1);
            this.tabpAddUser.Controls.Add(this.btnClose2);
            this.tabpAddUser.Controls.Add(this.btnSave);
            this.tabpAddUser.Controls.Add(this.label6);
            this.tabpAddUser.Controls.Add(this.txtAddPassword);
            this.tabpAddUser.Controls.Add(this.label7);
            this.tabpAddUser.Controls.Add(this.txtAddPhone);
            this.tabpAddUser.Controls.Add(this.lable);
            this.tabpAddUser.Controls.Add(this.txtAddUserName);
            this.tabpAddUser.Controls.Add(this.label4);
            this.tabpAddUser.Controls.Add(this.txtAddEmail);
            this.tabpAddUser.Controls.Add(this.label3);
            this.tabpAddUser.Controls.Add(this.txtAddLastName);
            this.tabpAddUser.Controls.Add(this.label2);
            this.tabpAddUser.Controls.Add(this.txtAddFirstName);
            this.tabpAddUser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpAddUser.Location = new System.Drawing.Point(4, 22);
            this.tabpAddUser.Name = "tabpAddUser";
            this.tabpAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAddUser.Size = new System.Drawing.Size(933, 602);
            this.tabpAddUser.TabIndex = 1;
            this.tabpAddUser.Text = "Add User";
            this.tabpAddUser.Enter += new System.EventHandler(this.tabp_Add_Update_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.chkCurrencyExchange);
            this.groupBox1.Controls.Add(this.chkManageTransactions);
            this.groupBox1.Controls.Add(this.chkManageUsers);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkManageClients);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(464, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 368);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // chkCurrencyExchange
            // 
            this.chkCurrencyExchange.AutoSize = true;
            this.chkCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCurrencyExchange.Location = new System.Drawing.Point(12, 302);
            this.chkCurrencyExchange.Name = "chkCurrencyExchange";
            this.chkCurrencyExchange.Size = new System.Drawing.Size(212, 29);
            this.chkCurrencyExchange.TabIndex = 4;
            this.chkCurrencyExchange.Text = "Currency Exchange";
            this.chkCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkManageTransactions
            // 
            this.chkManageTransactions.AutoSize = true;
            this.chkManageTransactions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageTransactions.Location = new System.Drawing.Point(12, 255);
            this.chkManageTransactions.Name = "chkManageTransactions";
            this.chkManageTransactions.Size = new System.Drawing.Size(228, 29);
            this.chkManageTransactions.TabIndex = 3;
            this.chkManageTransactions.Text = "Manage Transactions";
            this.chkManageTransactions.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.Location = new System.Drawing.Point(12, 208);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(162, 29);
            this.chkManageUsers.TabIndex = 2;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNoDontGiveFullAccess);
            this.groupBox2.Controls.Add(this.rbYesGiveFullAccess);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Do you want to Give Full Access ?";
            // 
            // rbNoDontGiveFullAccess
            // 
            this.rbNoDontGiveFullAccess.AutoSize = true;
            this.rbNoDontGiveFullAccess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDontGiveFullAccess.Location = new System.Drawing.Point(92, 42);
            this.rbNoDontGiveFullAccess.Name = "rbNoDontGiveFullAccess";
            this.rbNoDontGiveFullAccess.Size = new System.Drawing.Size(55, 29);
            this.rbNoDontGiveFullAccess.TabIndex = 1;
            this.rbNoDontGiveFullAccess.TabStop = true;
            this.rbNoDontGiveFullAccess.Text = "No";
            this.rbNoDontGiveFullAccess.UseVisualStyleBackColor = true;
            // 
            // rbYesGiveFullAccess
            // 
            this.rbYesGiveFullAccess.AutoSize = true;
            this.rbYesGiveFullAccess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesGiveFullAccess.Location = new System.Drawing.Point(6, 42);
            this.rbYesGiveFullAccess.Name = "rbYesGiveFullAccess";
            this.rbYesGiveFullAccess.Size = new System.Drawing.Size(62, 29);
            this.rbYesGiveFullAccess.TabIndex = 0;
            this.rbYesGiveFullAccess.TabStop = true;
            this.rbYesGiveFullAccess.Text = "Yes";
            this.rbYesGiveFullAccess.UseVisualStyleBackColor = true;
            this.rbYesGiveFullAccess.CheckedChanged += new System.EventHandler(this.rbYesGiveFullAccess_CheckedChanged);
            // 
            // chkManageClients
            // 
            this.chkManageClients.AutoSize = true;
            this.chkManageClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageClients.Location = new System.Drawing.Point(12, 161);
            this.chkManageClients.Name = "chkManageClients";
            this.chkManageClients.Size = new System.Drawing.Size(173, 29);
            this.chkManageClients.TabIndex = 0;
            this.chkManageClients.Text = "Manage Clients";
            this.chkManageClients.UseVisualStyleBackColor = true;
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClose2.FlatAppearance.BorderSize = 2;
            this.btnClose2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose2.Location = new System.Drawing.Point(476, 507);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(165, 53);
            this.btnClose2.TabIndex = 31;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnGoBackToShowUsers_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(687, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 53);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Password";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPassword.Location = new System.Drawing.Point(24, 508);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(331, 36);
            this.txtAddPassword.TabIndex = 27;
            this.txtAddPassword.Tag = "PinCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Phone";
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddPhone.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPhone.Location = new System.Drawing.Point(24, 429);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(331, 36);
            this.txtAddPhone.TabIndex = 26;
            this.txtAddPhone.Tag = "Phone";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.Black;
            this.lable.Location = new System.Drawing.Point(24, 85);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(121, 25);
            this.lable.TabIndex = 32;
            this.lable.Text = "UserName";
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddUserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUserName.Location = new System.Drawing.Point(24, 113);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(331, 36);
            this.txtAddUserName.TabIndex = 20;
            this.txtAddUserName.Tag = "Acc.Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddEmail.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddEmail.Location = new System.Drawing.Point(24, 350);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(331, 36);
            this.txtAddEmail.TabIndex = 24;
            this.txtAddEmail.Tag = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddLastName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLastName.Location = new System.Drawing.Point(24, 271);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(331, 36);
            this.txtAddLastName.TabIndex = 23;
            this.txtAddLastName.Tag = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddFirstName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFirstName.Location = new System.Drawing.Point(24, 192);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(331, 36);
            this.txtAddFirstName.TabIndex = 22;
            this.txtAddFirstName.Tag = "FirstName";
            // 
            // tabpUpdateUser
            // 
            this.tabpUpdateUser.BackColor = System.Drawing.Color.MistyRose;
            this.tabpUpdateUser.Controls.Add(this.btnFind);
            this.tabpUpdateUser.Controls.Add(this.groupBox3);
            this.tabpUpdateUser.Controls.Add(this.button1);
            this.tabpUpdateUser.Controls.Add(this.button2);
            this.tabpUpdateUser.Controls.Add(this.label5);
            this.tabpUpdateUser.Controls.Add(this.txtUpdatePassword);
            this.tabpUpdateUser.Controls.Add(this.label8);
            this.tabpUpdateUser.Controls.Add(this.txtUpdatePhone);
            this.tabpUpdateUser.Controls.Add(this.label9);
            this.tabpUpdateUser.Controls.Add(this.txtUpdateUserName);
            this.tabpUpdateUser.Controls.Add(this.label10);
            this.tabpUpdateUser.Controls.Add(this.txtUpdateEmail);
            this.tabpUpdateUser.Controls.Add(this.label11);
            this.tabpUpdateUser.Controls.Add(this.txtUpdateLastName);
            this.tabpUpdateUser.Controls.Add(this.label12);
            this.tabpUpdateUser.Controls.Add(this.txtUpdateFirstName);
            this.tabpUpdateUser.Location = new System.Drawing.Point(4, 22);
            this.tabpUpdateUser.Name = "tabpUpdateUser";
            this.tabpUpdateUser.Size = new System.Drawing.Size(933, 602);
            this.tabpUpdateUser.TabIndex = 2;
            this.tabpUpdateUser.Text = "Update User";
            this.tabpUpdateUser.Enter += new System.EventHandler(this.tabp_Add_Update_Enter);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFind.FlatAppearance.BorderSize = 2;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(468, 113);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(405, 53);
            this.btnFind.TabIndex = 51;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.chkUpdateCurrencyExchange);
            this.groupBox3.Controls.Add(this.chkUpdateManageTransactions);
            this.groupBox3.Controls.Add(this.chkUpdateManageUsers);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.chkUpdateManageClients);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(468, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 289);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissions";
            // 
            // chkUpdateCurrencyExchange
            // 
            this.chkUpdateCurrencyExchange.AutoSize = true;
            this.chkUpdateCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateCurrencyExchange.Location = new System.Drawing.Point(12, 254);
            this.chkUpdateCurrencyExchange.Name = "chkUpdateCurrencyExchange";
            this.chkUpdateCurrencyExchange.Size = new System.Drawing.Size(212, 29);
            this.chkUpdateCurrencyExchange.TabIndex = 4;
            this.chkUpdateCurrencyExchange.Text = "Currency Exchange";
            this.chkUpdateCurrencyExchange.UseVisualStyleBackColor = true;
            // 
            // chkUpdateManageTransactions
            // 
            this.chkUpdateManageTransactions.AutoSize = true;
            this.chkUpdateManageTransactions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateManageTransactions.Location = new System.Drawing.Point(12, 216);
            this.chkUpdateManageTransactions.Name = "chkUpdateManageTransactions";
            this.chkUpdateManageTransactions.Size = new System.Drawing.Size(228, 29);
            this.chkUpdateManageTransactions.TabIndex = 3;
            this.chkUpdateManageTransactions.Text = "Manage Transactions";
            this.chkUpdateManageTransactions.UseVisualStyleBackColor = true;
            // 
            // chkUpdateManageUsers
            // 
            this.chkUpdateManageUsers.AutoSize = true;
            this.chkUpdateManageUsers.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateManageUsers.Location = new System.Drawing.Point(12, 178);
            this.chkUpdateManageUsers.Name = "chkUpdateManageUsers";
            this.chkUpdateManageUsers.Size = new System.Drawing.Size(162, 29);
            this.chkUpdateManageUsers.TabIndex = 2;
            this.chkUpdateManageUsers.Text = "Manage Users";
            this.chkUpdateManageUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbNoDontUpdateGiveFullAccess);
            this.groupBox4.Controls.Add(this.rbYesUpdateGiveFullAccess);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 78);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Do you want to Give Full Access ?";
            // 
            // rbNoDontUpdateGiveFullAccess
            // 
            this.rbNoDontUpdateGiveFullAccess.AutoSize = true;
            this.rbNoDontUpdateGiveFullAccess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoDontUpdateGiveFullAccess.Location = new System.Drawing.Point(92, 42);
            this.rbNoDontUpdateGiveFullAccess.Name = "rbNoDontUpdateGiveFullAccess";
            this.rbNoDontUpdateGiveFullAccess.Size = new System.Drawing.Size(55, 29);
            this.rbNoDontUpdateGiveFullAccess.TabIndex = 1;
            this.rbNoDontUpdateGiveFullAccess.TabStop = true;
            this.rbNoDontUpdateGiveFullAccess.Text = "No";
            this.rbNoDontUpdateGiveFullAccess.UseVisualStyleBackColor = true;
            // 
            // rbYesUpdateGiveFullAccess
            // 
            this.rbYesUpdateGiveFullAccess.AutoSize = true;
            this.rbYesUpdateGiveFullAccess.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYesUpdateGiveFullAccess.Location = new System.Drawing.Point(6, 42);
            this.rbYesUpdateGiveFullAccess.Name = "rbYesUpdateGiveFullAccess";
            this.rbYesUpdateGiveFullAccess.Size = new System.Drawing.Size(62, 29);
            this.rbYesUpdateGiveFullAccess.TabIndex = 0;
            this.rbYesUpdateGiveFullAccess.TabStop = true;
            this.rbYesUpdateGiveFullAccess.Text = "Yes";
            this.rbYesUpdateGiveFullAccess.UseVisualStyleBackColor = true;
            this.rbYesUpdateGiveFullAccess.CheckedChanged += new System.EventHandler(this.rbYesUpdateGiveFullAccess_CheckedChanged);
            // 
            // chkUpdateManageClients
            // 
            this.chkUpdateManageClients.AutoSize = true;
            this.chkUpdateManageClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateManageClients.Location = new System.Drawing.Point(12, 140);
            this.chkUpdateManageClients.Name = "chkUpdateManageClients";
            this.chkUpdateManageClients.Size = new System.Drawing.Size(173, 29);
            this.chkUpdateManageClients.TabIndex = 0;
            this.chkUpdateManageClients.Text = "Manage Clients";
            this.chkUpdateManageClients.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 53);
            this.button1.TabIndex = 46;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnGoBackToShowUsers_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(708, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 53);
            this.button2.TabIndex = 45;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Password";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdatePassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePassword.Location = new System.Drawing.Point(28, 508);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(331, 36);
            this.txtUpdatePassword.TabIndex = 43;
            this.txtUpdatePassword.Tag = "PinCode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Phone";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdatePhone.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(28, 429);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(331, 36);
            this.txtUpdatePhone.TabIndex = 42;
            this.txtUpdatePhone.Tag = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "UserName";
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdateUserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateUserName.Location = new System.Drawing.Point(28, 113);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(331, 36);
            this.txtUpdateUserName.TabIndex = 36;
            this.txtUpdateUserName.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Email";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdateEmail.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateEmail.Location = new System.Drawing.Point(28, 350);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(331, 36);
            this.txtUpdateEmail.TabIndex = 40;
            this.txtUpdateEmail.Tag = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "Last Name";
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdateLastName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateLastName.Location = new System.Drawing.Point(28, 271);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(331, 36);
            this.txtUpdateLastName.TabIndex = 39;
            this.txtUpdateLastName.Tag = "LastName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 37;
            this.label12.Text = "First Name";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUpdateFirstName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateFirstName.Location = new System.Drawing.Point(28, 192);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(331, 36);
            this.txtUpdateFirstName.TabIndex = 38;
            this.txtUpdateFirstName.Tag = "FirstName";
            // 
            // tabpUsersLog
            // 
            this.tabpUsersLog.BackColor = System.Drawing.Color.MistyRose;
            this.tabpUsersLog.Controls.Add(this.label13);
            this.tabpUsersLog.Controls.Add(this.lblUsersLogCount);
            this.tabpUsersLog.Controls.Add(this.pictureBox2);
            this.tabpUsersLog.Controls.Add(this.txtSearchUsersLog);
            this.tabpUsersLog.Controls.Add(this.dgvUsersLog);
            this.tabpUsersLog.Location = new System.Drawing.Point(4, 22);
            this.tabpUsersLog.Name = "tabpUsersLog";
            this.tabpUsersLog.Size = new System.Drawing.Size(933, 602);
            this.tabpUsersLog.TabIndex = 4;
            this.tabpUsersLog.Text = "Users Log";
            this.tabpUsersLog.Enter += new System.EventHandler(this.tabpUsersLog_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "UserName";
            // 
            // lblUsersLogCount
            // 
            this.lblUsersLogCount.AutoSize = true;
            this.lblUsersLogCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersLogCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUsersLogCount.Location = new System.Drawing.Point(745, 139);
            this.lblUsersLogCount.Name = "lblUsersLogCount";
            this.lblUsersLogCount.Size = new System.Drawing.Size(158, 29);
            this.lblUsersLogCount.TabIndex = 13;
            this.lblUsersLogCount.Text = "0 User Log(s)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Bank.Properties.Resources.search_2911_32;
            this.pictureBox2.Location = new System.Drawing.Point(218, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearchUsersLog
            // 
            this.txtSearchUsersLog.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearchUsersLog.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUsersLog.Location = new System.Drawing.Point(8, 135);
            this.txtSearchUsersLog.Name = "txtSearchUsersLog";
            this.txtSearchUsersLog.Size = new System.Drawing.Size(204, 33);
            this.txtSearchUsersLog.TabIndex = 11;
            this.txtSearchUsersLog.TextChanged += new System.EventHandler(this.txtSearchUsersLog_TextChanged);
            // 
            // dgvUsersLog
            // 
            this.dgvUsersLog.AllowUserToAddRows = false;
            this.dgvUsersLog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUsersLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsersLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsersLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsersLog.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvUsersLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsersLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsersLog.Location = new System.Drawing.Point(0, 183);
            this.dgvUsersLog.Name = "dgvUsersLog";
            this.dgvUsersLog.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvUsersLog.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUsersLog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersLog.RowTemplate.Height = 25;
            this.dgvUsersLog.Size = new System.Drawing.Size(933, 419);
            this.dgvUsersLog.TabIndex = 10;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 628);
            this.Controls.Add(this.tabManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsers";
            this.Text = "    Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.tabManageUsers.ResumeLayout(false);
            this.tabpShowUsers.ResumeLayout(false);
            this.tabpShowUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabpAddUser.ResumeLayout(false);
            this.tabpAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpUpdateUser.ResumeLayout(false);
            this.tabpUpdateUser.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabpUsersLog.ResumeLayout(false);
            this.tabpUsersLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManageUsers;
        private System.Windows.Forms.TabPage tabpShowUsers;
        private System.Windows.Forms.TabPage tabpAddUser;
        private System.Windows.Forms.TabPage tabpUpdateUser;
        private System.Windows.Forms.TabPage tabpUsersLog;
        private System.Windows.Forms.Label lblUsersCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShowUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkManageClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNoDontGiveFullAccess;
        private System.Windows.Forms.RadioButton rbYesGiveFullAccess;
        private System.Windows.Forms.CheckBox chkCurrencyExchange;
        private System.Windows.Forms.CheckBox chkManageTransactions;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUpdateCurrencyExchange;
        private System.Windows.Forms.CheckBox chkUpdateManageTransactions;
        private System.Windows.Forms.CheckBox chkUpdateManageUsers;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbNoDontUpdateGiveFullAccess;
        private System.Windows.Forms.RadioButton rbYesUpdateGiveFullAccess;
        private System.Windows.Forms.CheckBox chkUpdateManageClients;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblUsersLogCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearchUsersLog;
        private System.Windows.Forms.DataGridView dgvUsersLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refershToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}