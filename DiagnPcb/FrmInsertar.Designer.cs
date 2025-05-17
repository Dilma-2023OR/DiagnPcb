namespace DiagnPcb
{
    partial class FrmInsertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertar));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbNumParte = new DiagnPcb.Styles.DOTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new DiagnPcb.Styles.DOButton();
            this.tbNumSerie = new DiagnPcb.Styles.DOTextBox();
            this.gbDiagnostico = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.docbLinea = new DiagnPcb.Styles.DOComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOperacion = new DiagnPcb.Styles.DOComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUbicacion = new DiagnPcb.Styles.DOComboBox();
            this.cbFalla = new DiagnPcb.Styles.DOComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiagnostico = new DiagnPcb.Styles.DOComboBox();
            this.cbOwner = new DiagnPcb.Styles.DOComboBox();
            this.cbCables = new DiagnPcb.Styles.DOComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMaquina = new DiagnPcb.Styles.DOComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSemana = new DiagnPcb.Styles.DOTextBox();
            this.tbComentarios = new DiagnPcb.Styles.DOTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.panelContenedorDiag = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCargarImagen = new DiagnPcb.Styles.DOButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new DiagnPcb.Styles.DOButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbDiagnostico.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelVersion.SuspendLayout();
            this.panelContenedorDiag.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1480, 128);
            this.tableLayoutPanel2.TabIndex = 18;
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
            this.tbNumParte.Location = new System.Drawing.Point(680, 68);
            this.tbNumParte.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumParte.Multiline = false;
            this.tbNumParte.Name = "tbNumParte";
            this.tbNumParte.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNumParte.PasswordChar = false;
            this.tbNumParte.PlaceholderColor = System.Drawing.Color.LightGray;
            this.tbNumParte.PlaceholderText = "Part Number";
            this.tbNumParte.Size = new System.Drawing.Size(421, 43);
            this.tbNumParte.TabIndex = 43;
            this.tbNumParte.Texts = "Part Number";
            this.tbNumParte.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serial Number:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(676, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Part Number:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnReset.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnReset.BorderRadius = 50;
            this.btnReset.BorderSize = 3;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::DiagnPcb.Properties.Resources.reiniciar;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(1108, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 58);
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
            this.tbNumSerie.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNumSerie.BorderRadius = 15;
            this.tbNumSerie.BorderSize = 2;
            this.tbNumSerie.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumSerie.ForeColor = System.Drawing.Color.White;
            this.tbNumSerie.IsFocused = false;
            this.tbNumSerie.IsPasswordChar = false;
            this.tbNumSerie.IsPlaceholder = true;
            this.tbNumSerie.Location = new System.Drawing.Point(251, 68);
            this.tbNumSerie.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumSerie.Multiline = false;
            this.tbNumSerie.Name = "tbNumSerie";
            this.tbNumSerie.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbNumSerie.PasswordChar = false;
            this.tbNumSerie.PlaceholderColor = System.Drawing.Color.LightGray;
            this.tbNumSerie.PlaceholderText = "Serial Number";
            this.tbNumSerie.Size = new System.Drawing.Size(421, 43);
            this.tbNumSerie.TabIndex = 45;
            this.tbNumSerie.Texts = "Serial Number";
            this.tbNumSerie.UnderlinedStyle = false;
            this.tbNumSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumSerie_KeyDown);
            // 
            // gbDiagnostico
            // 
            this.gbDiagnostico.Controls.Add(this.tableLayoutPanel7);
            this.gbDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDiagnostico.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDiagnostico.ForeColor = System.Drawing.Color.White;
            this.gbDiagnostico.Location = new System.Drawing.Point(87, 125);
            this.gbDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.gbDiagnostico.Name = "gbDiagnostico";
            this.gbDiagnostico.Padding = new System.Windows.Forms.Padding(4);
            this.gbDiagnostico.Size = new System.Drawing.Size(692, 630);
            this.gbDiagnostico.TabIndex = 15;
            this.gbDiagnostico.TabStop = false;
            this.gbDiagnostico.Text = "Diagnostic Entry";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.docbLinea, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.cbOperacion, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel7.Controls.Add(this.cbUbicacion, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.cbFalla, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.cbDiagnostico, 1, 7);
            this.tableLayoutPanel7.Controls.Add(this.cbOwner, 1, 8);
            this.tableLayoutPanel7.Controls.Add(this.cbCables, 1, 9);
            this.tableLayoutPanel7.Controls.Add(this.label16, 0, 10);
            this.tableLayoutPanel7.Controls.Add(this.cbMaquina, 1, 10);
            this.tableLayoutPanel7.Controls.Add(this.label14, 0, 11);
            this.tableLayoutPanel7.Controls.Add(this.tbSemana, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.tbComentarios, 1, 11);
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
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(684, 587);
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
            this.label10.Size = new System.Drawing.Size(128, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Operation:";
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
            this.docbLinea.ListTextColor = System.Drawing.Color.SteelBlue;
            this.docbLinea.Location = new System.Drawing.Point(269, 72);
            this.docbLinea.MinimumSize = new System.Drawing.Size(200, 30);
            this.docbLinea.Name = "docbLinea";
            this.docbLinea.Padding = new System.Windows.Forms.Padding(3);
            this.docbLinea.Size = new System.Drawing.Size(406, 38);
            this.docbLinea.TabIndex = 16;
            this.docbLinea.Texts = "Selected Line...";
            this.docbLinea.OnSelectedIndexChanged += new System.EventHandler(this.cblinea_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "Diagnostic:";
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
            this.label6.Size = new System.Drawing.Size(65, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "Line:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(266, 1);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(282, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "1) Enter the requested data";
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
            "OP 30 - Soldier",
            "OP 40 - Screwed",
            "OP 50 - Leak tester radome",
            "OP 60 - EOL"});
            this.cbOperacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbOperacion.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbOperacion.Location = new System.Drawing.Point(269, 29);
            this.cbOperacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Padding = new System.Windows.Forms.Padding(3);
            this.cbOperacion.Size = new System.Drawing.Size(406, 37);
            this.cbOperacion.TabIndex = 43;
            this.cbOperacion.Texts = "Selected Operation...";
            this.cbOperacion.OnSelectedIndexChanged += new System.EventHandler(this.cbOperacion_SelectedIndexChanged);
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
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Failure date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 126);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(405, 32);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Production Week:";
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
            this.label12.Size = new System.Drawing.Size(125, 31);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ubication:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 354);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 31);
            this.label13.TabIndex = 30;
            this.label13.Text = "Owner:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 396);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Wire:";
            // 
            // cbUbicacion
            // 
            this.cbUbicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUbicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUbicacion.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbUbicacion.BackColor = System.Drawing.Color.SteelBlue;
            this.cbUbicacion.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbUbicacion.BorderSize = 3;
            this.cbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbUbicacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbUbicacion.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbUbicacion.IconColor = System.Drawing.Color.OrangeRed;
            this.cbUbicacion.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbUbicacion.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbUbicacion.Location = new System.Drawing.Point(269, 217);
            this.cbUbicacion.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbUbicacion.Name = "cbUbicacion";
            this.cbUbicacion.Padding = new System.Windows.Forms.Padding(3);
            this.cbUbicacion.Size = new System.Drawing.Size(406, 38);
            this.cbUbicacion.TabIndex = 45;
            this.cbUbicacion.Texts = "Selected Ubication...";
            this.cbUbicacion.OnSelectedIndexChanged += new System.EventHandler(this.cbUbicacion_SelectedIndexChanged);
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
            this.cbFalla.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbFalla.Location = new System.Drawing.Point(269, 265);
            this.cbFalla.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFalla.Name = "cbFalla";
            this.cbFalla.Padding = new System.Windows.Forms.Padding(3);
            this.cbFalla.Size = new System.Drawing.Size(406, 36);
            this.cbFalla.TabIndex = 46;
            this.cbFalla.Texts = "Selected Failure...";
            this.cbFalla.OnSelectedIndexChanged += new System.EventHandler(this.cbFalla_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Failure:";
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDiagnostico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDiagnostico.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbDiagnostico.BackColor = System.Drawing.Color.SteelBlue;
            this.cbDiagnostico.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbDiagnostico.BorderSize = 3;
            this.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbDiagnostico.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbDiagnostico.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbDiagnostico.IconColor = System.Drawing.Color.OrangeRed;
            this.cbDiagnostico.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbDiagnostico.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbDiagnostico.Location = new System.Drawing.Point(269, 307);
            this.cbDiagnostico.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.cbDiagnostico.Size = new System.Drawing.Size(406, 36);
            this.cbDiagnostico.TabIndex = 47;
            this.cbDiagnostico.Texts = "Selected Diagnostic...";
            this.cbDiagnostico.OnSelectedIndexChanged += new System.EventHandler(this.cbDiagnostico_SelectedIndexChanged);
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
            this.cbOwner.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbOwner.Location = new System.Drawing.Point(269, 352);
            this.cbOwner.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Padding = new System.Windows.Forms.Padding(3);
            this.cbOwner.Size = new System.Drawing.Size(406, 36);
            this.cbOwner.TabIndex = 48;
            this.cbOwner.Texts = "Selected Owner...";
            this.cbOwner.OnSelectedIndexChanged += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            // 
            // cbCables
            // 
            this.cbCables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCables.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbCables.BackColor = System.Drawing.Color.SteelBlue;
            this.cbCables.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbCables.BorderSize = 3;
            this.cbCables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbCables.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbCables.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbCables.IconColor = System.Drawing.Color.OrangeRed;
            this.cbCables.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCables.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbCables.Location = new System.Drawing.Point(269, 394);
            this.cbCables.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCables.Name = "cbCables";
            this.cbCables.Padding = new System.Windows.Forms.Padding(3);
            this.cbCables.Size = new System.Drawing.Size(406, 35);
            this.cbCables.TabIndex = 49;
            this.cbCables.Texts = "Selected Wire..";
            this.cbCables.OnSelectedIndexChanged += new System.EventHandler(this.cbCables_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(0, 438);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 31);
            this.label16.TabIndex = 34;
            this.label16.Text = "Robot:";
            // 
            // cbMaquina
            // 
            this.cbMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaquina.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbMaquina.BackColor = System.Drawing.Color.SteelBlue;
            this.cbMaquina.BorderColor = System.Drawing.Color.SteelBlue;
            this.cbMaquina.BorderSize = 3;
            this.cbMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMaquina.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbMaquina.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbMaquina.IconColor = System.Drawing.Color.OrangeRed;
            this.cbMaquina.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbMaquina.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMaquina.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cbMaquina.Location = new System.Drawing.Point(269, 435);
            this.cbMaquina.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMaquina.Name = "cbMaquina";
            this.cbMaquina.Padding = new System.Windows.Forms.Padding(3);
            this.cbMaquina.Size = new System.Drawing.Size(406, 35);
            this.cbMaquina.TabIndex = 50;
            this.cbMaquina.Texts = "Selected Robot..";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 515);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 31);
            this.label14.TabIndex = 32;
            this.label14.Text = "Comments:";
            // 
            // tbSemana
            // 
            this.tbSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbSemana.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbSemana.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbSemana.BorderRadius = 15;
            this.tbSemana.BorderSize = 2;
            this.tbSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemana.ForeColor = System.Drawing.Color.White;
            this.tbSemana.IsFocused = false;
            this.tbSemana.IsPasswordChar = false;
            this.tbSemana.IsPlaceholder = false;
            this.tbSemana.Location = new System.Drawing.Point(270, 176);
            this.tbSemana.Margin = new System.Windows.Forms.Padding(4);
            this.tbSemana.Multiline = false;
            this.tbSemana.Name = "tbSemana";
            this.tbSemana.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbSemana.PasswordChar = false;
            this.tbSemana.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbSemana.PlaceholderText = "";
            this.tbSemana.Size = new System.Drawing.Size(410, 35);
            this.tbSemana.TabIndex = 51;
            this.tbSemana.Texts = "";
            this.tbSemana.UnderlinedStyle = false;
            // 
            // tbComentarios
            // 
            this.tbComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tbComentarios.BorderColor = System.Drawing.Color.SteelBlue;
            this.tbComentarios.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbComentarios.BorderRadius = 15;
            this.tbComentarios.BorderSize = 2;
            this.tbComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComentarios.ForeColor = System.Drawing.Color.White;
            this.tbComentarios.IsFocused = false;
            this.tbComentarios.IsPasswordChar = false;
            this.tbComentarios.IsPlaceholder = false;
            this.tbComentarios.Location = new System.Drawing.Point(270, 479);
            this.tbComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.tbComentarios.Multiline = true;
            this.tbComentarios.Name = "tbComentarios";
            this.tbComentarios.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbComentarios.PasswordChar = false;
            this.tbComentarios.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbComentarios.PlaceholderText = "";
            this.tbComentarios.Size = new System.Drawing.Size(410, 104);
            this.tbComentarios.TabIndex = 52;
            this.tbComentarios.Texts = "";
            this.tbComentarios.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(21, 8);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(72, 23);
            this.lblVersion.TabIndex = 34;
            this.lblVersion.Text = "4.0.0.1";
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.lblVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(0, 972);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1480, 40);
            this.panelVersion.TabIndex = 35;
            // 
            // panelContenedorDiag
            // 
            this.panelContenedorDiag.Controls.Add(this.tableLayoutPanel1);
            this.panelContenedorDiag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorDiag.Location = new System.Drawing.Point(0, 128);
            this.panelContenedorDiag.Name = "panelContenedorDiag";
            this.panelContenedorDiag.Size = new System.Drawing.Size(1480, 844);
            this.panelContenedorDiag.TabIndex = 36;
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.31898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.55297F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1480, 844);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(786, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 632);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53846F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46154F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(786, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(608, 115);
            this.tableLayoutPanel3.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCargarImagen);
            this.panel1.Location = new System.Drawing.Point(85, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 102);
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
            this.btnCargarImagen.Location = new System.Drawing.Point(36, 9);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(165, 85);
            this.btnCargarImagen.TabIndex = 3;
            this.btnCargarImagen.Text = "Photo";
            this.btnCargarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarImagen.TextColor = System.Drawing.Color.White;
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Location = new System.Drawing.Point(326, 2);
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
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 85);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "SAVE";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1480, 1012);
            this.Controls.Add(this.panelContenedorDiag);
            this.Controls.Add(this.panelVersion);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInsertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.FrmInsertar_Load);
            this.SizeChanged += new System.EventHandler(this.FrmInsertar_SizeChanged);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbDiagnostico.ResumeLayout(false);
            this.gbDiagnostico.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelContenedorDiag.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDiagnostico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cblinea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Panel panelContenedorDiag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Styles.DOComboBox docbLinea;
        private Styles.DOComboBox cbOperacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Styles.DOComboBox cbUbicacion;
        private Styles.DOComboBox cbFalla;
        private Styles.DOComboBox cbDiagnostico;
        private Styles.DOComboBox cbOwner;
        private Styles.DOComboBox cbCables;
        private Styles.DOComboBox cbMaquina;
        private Styles.DOTextBox tbSemana;
        private Styles.DOTextBox tbComentarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private Styles.DOButton btnCargarImagen;
        private System.Windows.Forms.Panel panel2;
        private Styles.DOButton btnGuardar;
        private Styles.DOButton btnReset;
        private Styles.DOTextBox tbNumParte;
        private Styles.DOTextBox tbNumSerie;
    }
}