namespace DiagnPcb.Registros
{
    partial class FrmRegisterUsers
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPermisos = new DiagnPcb.Styles.DOComboBox();
            this.tbEmployeNumber = new DiagnPcb.Styles.DOTextBox();
            this.tbPosition = new DiagnPcb.Styles.DOTextBox();
            this.tbLastName = new DiagnPcb.Styles.DOTextBox();
            this.tbFirstName = new DiagnPcb.Styles.DOTextBox();
            this.tbPassword = new DiagnPcb.Styles.DOTextBox();
            this.tbLoginName = new DiagnPcb.Styles.DOTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new DiagnPcb.Styles.DOButton();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1110, 89);
            this.tableLayoutPanel3.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.lblVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(0, 790);
            this.panelVersion.Margin = new System.Windows.Forms.Padding(2);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1110, 32);
            this.panelVersion.TabIndex = 37;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(16, 6);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 19);
            this.lblVersion.TabIndex = 34;
            this.lblVersion.Text = "4.0.2.1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1110, 701);
            this.tableLayoutPanel4.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(308, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(493, 483);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users Register";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.6837F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.3163F));
            this.tableLayoutPanel1.Controls.Add(this.cbPermisos, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbEmployeNumber, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPosition, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbLoginName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 282);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbPermisos
            // 
            this.cbPermisos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPermisos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPermisos.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbPermisos.BackColor = System.Drawing.Color.SteelBlue;
            this.cbPermisos.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbPermisos.BorderSize = 3;
            this.cbPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPermisos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbPermisos.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbPermisos.IconColor = System.Drawing.Color.OrangeRed;
            this.cbPermisos.Items.AddRange(new object[] {
            "Administrador",
            "Tecnicos",
            "Enginner",
            "Calidad"});
            this.cbPermisos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPermisos.ListTextColor = System.Drawing.Color.Black;
            this.cbPermisos.Location = new System.Drawing.Point(141, 243);
            this.cbPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.cbPermisos.MinimumSize = new System.Drawing.Size(150, 24);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Padding = new System.Windows.Forms.Padding(2);
            this.cbPermisos.Size = new System.Drawing.Size(202, 31);
            this.cbPermisos.TabIndex = 16;
            this.cbPermisos.Texts = "Selected Permissions...";
            // 
            // tbEmployeNumber
            // 
            this.tbEmployeNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbEmployeNumber.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbEmployeNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEmployeNumber.BorderRadius = 15;
            this.tbEmployeNumber.BorderSize = 2;
            this.tbEmployeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmployeNumber.ForeColor = System.Drawing.Color.White;
            this.tbEmployeNumber.IsFocused = false;
            this.tbEmployeNumber.IsPasswordChar = false;
            this.tbEmployeNumber.IsPlaceholder = false;
            this.tbEmployeNumber.Location = new System.Drawing.Point(143, 199);
            this.tbEmployeNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeNumber.Multiline = false;
            this.tbEmployeNumber.Name = "tbEmployeNumber";
            this.tbEmployeNumber.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbEmployeNumber.PasswordChar = false;
            this.tbEmployeNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbEmployeNumber.PlaceholderText = "";
            this.tbEmployeNumber.Size = new System.Drawing.Size(202, 29);
            this.tbEmployeNumber.TabIndex = 62;
            this.tbEmployeNumber.Texts = "";
            this.tbEmployeNumber.UnderlinedStyle = false;
            // 
            // tbPosition
            // 
            this.tbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbPosition.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbPosition.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPosition.BorderRadius = 15;
            this.tbPosition.BorderSize = 2;
            this.tbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.ForeColor = System.Drawing.Color.White;
            this.tbPosition.IsFocused = false;
            this.tbPosition.IsPasswordChar = false;
            this.tbPosition.IsPlaceholder = false;
            this.tbPosition.Location = new System.Drawing.Point(143, 164);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosition.Multiline = false;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbPosition.PasswordChar = false;
            this.tbPosition.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPosition.PlaceholderText = "";
            this.tbPosition.Size = new System.Drawing.Size(202, 29);
            this.tbPosition.TabIndex = 61;
            this.tbPosition.Texts = "";
            this.tbPosition.UnderlinedStyle = false;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbLastName.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbLastName.BorderRadius = 15;
            this.tbLastName.BorderSize = 2;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.White;
            this.tbLastName.IsFocused = false;
            this.tbLastName.IsPasswordChar = false;
            this.tbLastName.IsPlaceholder = false;
            this.tbLastName.Location = new System.Drawing.Point(143, 126);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Multiline = false;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbLastName.PasswordChar = false;
            this.tbLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLastName.PlaceholderText = "";
            this.tbLastName.Size = new System.Drawing.Size(202, 29);
            this.tbLastName.TabIndex = 60;
            this.tbLastName.Texts = "";
            this.tbLastName.UnderlinedStyle = false;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbFirstName.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbFirstName.BorderRadius = 15;
            this.tbFirstName.BorderSize = 2;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.White;
            this.tbFirstName.IsFocused = false;
            this.tbFirstName.IsPasswordChar = false;
            this.tbFirstName.IsPlaceholder = false;
            this.tbFirstName.Location = new System.Drawing.Point(143, 86);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Multiline = false;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbFirstName.PasswordChar = false;
            this.tbFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbFirstName.PlaceholderText = "";
            this.tbFirstName.Size = new System.Drawing.Size(202, 29);
            this.tbFirstName.TabIndex = 59;
            this.tbFirstName.Texts = "";
            this.tbFirstName.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbPassword.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPassword.BorderRadius = 15;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.IsFocused = false;
            this.tbPassword.IsPasswordChar = false;
            this.tbPassword.IsPlaceholder = false;
            this.tbPassword.Location = new System.Drawing.Point(143, 45);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbPassword.PasswordChar = false;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.Size = new System.Drawing.Size(202, 29);
            this.tbPassword.TabIndex = 58;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            // 
            // tbLoginName
            // 
            this.tbLoginName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbLoginName.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbLoginName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbLoginName.BorderRadius = 15;
            this.tbLoginName.BorderSize = 2;
            this.tbLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginName.ForeColor = System.Drawing.Color.White;
            this.tbLoginName.IsFocused = false;
            this.tbLoginName.IsPasswordChar = false;
            this.tbLoginName.IsPlaceholder = false;
            this.tbLoginName.Location = new System.Drawing.Point(143, 4);
            this.tbLoginName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoginName.Multiline = false;
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.tbLoginName.PasswordChar = false;
            this.tbLoginName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbLoginName.PlaceholderText = "";
            this.tbLoginName.Size = new System.Drawing.Size(202, 29);
            this.tbLoginName.TabIndex = 52;
            this.tbLoginName.Texts = "";
            this.tbLoginName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 40);
            this.label4.TabIndex = 53;
            this.label4.Text = "First Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 38);
            this.label5.TabIndex = 54;
            this.label5.Text = "Last Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 35);
            this.label6.TabIndex = 55;
            this.label6.Text = "Position:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 46);
            this.label7.TabIndex = 56;
            this.label7.Text = "Number Employee:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 41);
            this.label8.TabIndex = 57;
            this.label8.Text = "Permissions:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Location = new System.Drawing.Point(308, 547);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 77);
            this.panel1.TabIndex = 33;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.BorderRadius = 50;
            this.btnConsultar.BorderSize = 3;
            this.btnConsultar.FlatAppearance.BorderSize = 2;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::DiagnPcb.Properties.Resources.guardar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(189, 3);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 69);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "SAVE";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmRegisterUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1110, 822);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.panelVersion);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegisterUsers";
            this.Text = "FrmRegisterUsers";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Styles.DOComboBox cbPermisos;
        private Styles.DOTextBox tbLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Styles.DOButton btnConsultar;
        private Styles.DOTextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Styles.DOTextBox tbPosition;
        private Styles.DOTextBox tbLastName;
        private Styles.DOTextBox tbFirstName;
        private Styles.DOTextBox tbEmployeNumber;
    }
}