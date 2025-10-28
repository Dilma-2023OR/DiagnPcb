namespace DiagnPcb.Registros
{
    partial class FrmScrapRegister
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNumParte = new DiagnPcb.Styles.DOTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new DiagnPcb.Styles.DOButton();
            this.tbNumSerie = new DiagnPcb.Styles.DOTextBox();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelContenedorDiag = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDiagnostico = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.docbLinea = new DiagnPcb.Styles.DOComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFalla = new DiagnPcb.Styles.DOComboBox();
            this.cboQty = new DiagnPcb.Styles.DOTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbOwner = new DiagnPcb.Styles.DOComboBox();
            this.cbOperacion = new DiagnPcb.Styles.DOComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new DiagnPcb.Styles.DOButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new DiagnPcb.Styles.DOButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.panelContenedorDiag.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDiagnostico.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbNumParte, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbNumSerie, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1431, 128);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // tbNumParte
            // 
            this.tbNumParte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbNumParte.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbNumParte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNumParte.BorderRadius = 15;
            this.tbNumParte.BorderSize = 2;
            this.tbNumParte.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumParte.ForeColor = System.Drawing.Color.White;
            this.tbNumParte.IsFocused = false;
            this.tbNumParte.IsPasswordChar = false;
            this.tbNumParte.IsPlaceholder = true;
            this.tbNumParte.Location = new System.Drawing.Point(656, 69);
            this.tbNumParte.Margin = new System.Windows.Forms.Padding(5);
            this.tbNumParte.Multiline = false;
            this.tbNumParte.Name = "tbNumParte";
            this.tbNumParte.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbNumParte.PasswordChar = false;
            this.tbNumParte.PlaceholderColor = System.Drawing.Color.PaleTurquoise;
            this.tbNumParte.PlaceholderText = "Número de Parte";
            this.tbNumParte.Size = new System.Drawing.Size(421, 43);
            this.tbNumParte.TabIndex = 43;
            this.tbNumParte.Texts = "Número de Parte";
            this.tbNumParte.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número de Serial:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(651, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de Parte:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnReset.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.BorderRadius = 47;
            this.btnReset.BorderSize = 3;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::DiagnPcb.Properties.Resources.reiniciar;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(1085, 66);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 58);
            this.btnReset.TabIndex = 44;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbNumSerie
            // 
            this.tbNumSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbNumSerie.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbNumSerie.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbNumSerie.BorderRadius = 15;
            this.tbNumSerie.BorderSize = 2;
            this.tbNumSerie.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumSerie.ForeColor = System.Drawing.Color.White;
            this.tbNumSerie.IsFocused = false;
            this.tbNumSerie.IsPasswordChar = false;
            this.tbNumSerie.IsPlaceholder = true;
            this.tbNumSerie.Location = new System.Drawing.Point(225, 69);
            this.tbNumSerie.Margin = new System.Windows.Forms.Padding(5);
            this.tbNumSerie.Multiline = false;
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbNumSerie.PasswordChar = false;
            this.tbNumSerie.PlaceholderColor = System.Drawing.Color.PaleTurquoise;
            this.tbNumSerie.PlaceholderText = "Número de Serial";
            this.tbNumSerie.Size = new System.Drawing.Size(421, 43);
            this.tbNumSerie.TabIndex = 45;
            this.tbNumSerie.Texts = "Número de Serial";
            this.tbNumSerie.UnderlinedStyle = false;
            this.tbNumSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumSerie_KeyDown);
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.lblVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(0, 973);
            this.panelVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1431, 39);
            this.panelVersion.TabIndex = 36;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(21, 7);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 23);
            this.lblVersion.TabIndex = 34;
            this.lblVersion.Text = "4.0.2.2";
            // 
            // panelContenedorDiag
            // 
            this.panelContenedorDiag.Controls.Add(this.tableLayoutPanel1);
            this.panelContenedorDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDiag.Location = new System.Drawing.Point(0, 128);
            this.panelContenedorDiag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedorDiag.Name = "panelContenedorDiag";
            this.panelContenedorDiag.Size = new System.Drawing.Size(1431, 845);
            this.panelContenedorDiag.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDiagnostico, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1431, 845);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // gbDiagnostico
            // 
            this.gbDiagnostico.AutoSize = true;
            this.gbDiagnostico.Controls.Add(this.tableLayoutPanel7);
            this.gbDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDiagnostico.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiagnostico.ForeColor = System.Drawing.Color.White;
            this.gbDiagnostico.Location = new System.Drawing.Point(66, 146);
            this.gbDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.gbDiagnostico.Name = "gbDiagnostico";
            this.gbDiagnostico.Padding = new System.Windows.Forms.Padding(4);
            this.gbDiagnostico.Size = new System.Drawing.Size(684, 595);
            this.gbDiagnostico.TabIndex = 15;
            this.gbDiagnostico.TabStop = false;
            this.gbDiagnostico.Text = "Entrada de Scrap";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.docbLinea, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.cbFalla, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.cboQty, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.cbOwner, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.cbOperacion, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 39);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 12;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(676, 552);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Operación:";
            // 
            // docbLinea
            // 
            this.docbLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docbLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.docbLinea.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.docbLinea.BackColor = System.Drawing.Color.SteelBlue;
            this.docbLinea.BorderColor = System.Drawing.Color.SteelBlue;
            this.docbLinea.BorderSize = 3;
            this.docbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.docbLinea.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.docbLinea.ForeColor = System.Drawing.Color.AliceBlue;
            this.docbLinea.IconColor = System.Drawing.Color.OrangeRed;
            this.docbLinea.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.docbLinea.ListTextColor = System.Drawing.Color.Black;
            this.docbLinea.Location = new System.Drawing.Point(265, 71);
            this.docbLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docbLinea.MinimumSize = new System.Drawing.Size(200, 30);
            this.docbLinea.Name = "docbLinea";
            this.docbLinea.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docbLinea.Size = new System.Drawing.Size(405, 38);
            this.docbLinea.TabIndex = 16;
            this.docbLinea.Texts = "Selecciona Línea...";
            this.docbLinea.OnSelectedIndexChanged += new System.EventHandler(this.docbLinea_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Línea:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(262, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "1) Ingresa la información requerida";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Día de Scrap:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 126);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(405, 32);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 222);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 31);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Falla:";
            // 
            // cbFalla
            // 
            this.cbFalla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFalla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFalla.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbFalla.BackColor = System.Drawing.Color.SteelBlue;
            this.cbFalla.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbFalla.BorderSize = 3;
            this.cbFalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFalla.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbFalla.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbFalla.IconColor = System.Drawing.Color.OrangeRed;
            this.cbFalla.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbFalla.ListTextColor = System.Drawing.Color.Black;
            this.cbFalla.Location = new System.Drawing.Point(265, 174);
            this.cbFalla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFalla.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFalla.Name = "cbFalla";
            this.cbFalla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFalla.Size = new System.Drawing.Size(405, 38);
            this.cbFalla.TabIndex = 46;
            this.cbFalla.Texts = "Selecciona Falla...";
            this.cbFalla.OnSelectedIndexChanged += new System.EventHandler(this.cbFalla_OnSelectedIndexChanged);
            // 
            // cboQty
            // 
            this.cboQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cboQty.BorderColor = System.Drawing.Color.SteelBlue;
            this.cboQty.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cboQty.BorderRadius = 15;
            this.cboQty.BorderSize = 2;
            this.cboQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQty.ForeColor = System.Drawing.Color.White;
            this.cboQty.IsFocused = false;
            this.cboQty.IsPasswordChar = false;
            this.cboQty.IsPlaceholder = false;
            this.cboQty.Location = new System.Drawing.Point(267, 219);
            this.cboQty.Margin = new System.Windows.Forms.Padding(5);
            this.cboQty.Multiline = false;
            this.cboQty.Name = "cboQty";
            this.cboQty.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.cboQty.PasswordChar = false;
            this.cboQty.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cboQty.PlaceholderText = "";
            this.cboQty.Size = new System.Drawing.Size(209, 35);
            this.cboQty.TabIndex = 54;
            this.cboQty.Texts = "";
            this.cboQty.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 267);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 31);
            this.label13.TabIndex = 55;
            this.label13.Text = "Operador:";
            this.label13.Visible = false;
            // 
            // cbOwner
            // 
            this.cbOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOwner.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbOwner.BackColor = System.Drawing.Color.SteelBlue;
            this.cbOwner.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbOwner.BorderSize = 3;
            this.cbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbOwner.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOwner.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbOwner.IconColor = System.Drawing.Color.OrangeRed;
            this.cbOwner.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbOwner.ListTextColor = System.Drawing.Color.Black;
            this.cbOwner.Location = new System.Drawing.Point(265, 263);
            this.cbOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOwner.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOwner.Size = new System.Drawing.Size(405, 37);
            this.cbOwner.TabIndex = 56;
            this.cbOwner.Texts = "Seleccionar Operador...";
            this.cbOwner.Visible = false;
            this.cbOwner.OnSelectedIndexChanged += new System.EventHandler(this.cbOwner_OnSelectedIndexChanged);
            // 
            // cbOperacion
            // 
            this.cbOperacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOperacion.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbOperacion.BackColor = System.Drawing.Color.SteelBlue;
            this.cbOperacion.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbOperacion.BorderSize = 3;
            this.cbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbOperacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOperacion.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbOperacion.IconColor = System.Drawing.Color.OrangeRed;
            this.cbOperacion.Items.AddRange(new object[] {
            "OP 10 - Chasis",
            "OP 20 - PCBA Tester",
            "OP 30 - Soldado",
            "OP 40 - Atornillado",
            "OP 50 - Leak tester radome",
            "OP 60 - EOL"});
            this.cbOperacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbOperacion.ListTextColor = System.Drawing.Color.Black;
            this.cbOperacion.Location = new System.Drawing.Point(265, 28);
            this.cbOperacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOperacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOperacion.Size = new System.Drawing.Size(405, 38);
            this.cbOperacion.TabIndex = 57;
            this.cbOperacion.Texts = "Selecciona Operación...";
            this.cbOperacion.OnSelectedIndexChanged += new System.EventHandler(this.cbOperacion_OnSelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(757, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(608, 599);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53846F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(757, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(608, 138);
            this.tableLayoutPanel3.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Location = new System.Drawing.Point(75, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 103);
            this.panel1.TabIndex = 42;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCargarImagen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCargarImagen.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCargarImagen.BorderRadius = 50;
            this.btnCargarImagen.BorderSize = 3;
            this.btnCargarImagen.FlatAppearance.BorderSize = 2;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.Color.White;
            this.btnCargarImagen.Image = global::DiagnPcb.Properties.Resources.camara;
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarImagen.Location = new System.Drawing.Point(17, 9);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(165, 85);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "Foto";
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarImagen.TextColor = System.Drawing.Color.White;
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(285, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 102);
            this.panel2.TabIndex = 43;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.BorderRadius = 50;
            this.btnGuardar.BorderSize = 3;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::DiagnPcb.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(36, 9);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 85);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmScrapRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1431, 1012);
            this.Controls.Add(this.panelContenedorDiag);
            this.Controls.Add(this.panelVersion);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScrapRegister";
            this.Text = "Scrap Register";
            this.Load += new System.EventHandler(this.FrmScrapRegister_Load);
            this.SizeChanged += new System.EventHandler(this.FrmScrapRegister_SizeChanged);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelContenedorDiag.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbDiagnostico.ResumeLayout(false);
            this.gbDiagnostico.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Styles.DOTextBox tbNumParte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Styles.DOButton btnReset;
        private Styles.DOTextBox tbNumSerie;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelContenedorDiag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDiagnostico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label10;
        private Styles.DOComboBox docbLinea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private Styles.DOComboBox cbFalla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private Styles.DOButton btnCargarImagen;
        private System.Windows.Forms.Panel panel2;
        private Styles.DOButton btnGuardar;
        private Styles.DOTextBox cboQty;
        private System.Windows.Forms.Label label13;
        private Styles.DOComboBox cbOwner;
        private Styles.DOComboBox cbOperacion;
    }
}