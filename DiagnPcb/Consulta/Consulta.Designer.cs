namespace DiagnPcb
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCables = new System.Windows.Forms.ComboBox();
            this.lblCable = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblNumPart = new System.Windows.Forms.Label();
            this.cbUbicaciones = new System.Windows.Forms.ComboBox();
            this.cbSemana = new System.Windows.Forms.ComboBox();
            this.cbNumPart = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbOwner = new System.Windows.Forms.ComboBox();
            this.lblFalla = new System.Windows.Forms.Label();
            this.cbFallas = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.cbDiagnostico = new System.Windows.Forms.ComboBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.gBoxValidation = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.CbHoraA = new System.Windows.Forms.ComboBox();
            this.cbHoraDe = new System.Windows.Forms.ComboBox();
            this.lblHoraDe = new System.Windows.Forms.Label();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.dateTimePickerA = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.dateTimePickerDe = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblHoraA = new System.Windows.Forms.Label();
            this.tableLayoutPanelFechas = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblVersion = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMenuConsulta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gBoxValidation.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanelFechas.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkCyan;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1924, 159);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("72 Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1413, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consult Diagnostic";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCables
            // 
            this.cbCables.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCables.BackColor = System.Drawing.SystemColors.Control;
            this.cbCables.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbCables.FormattingEnabled = true;
            this.cbCables.Location = new System.Drawing.Point(298, 234);
            this.cbCables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCables.Name = "cbCables";
            this.cbCables.Size = new System.Drawing.Size(221, 29);
            this.cbCables.TabIndex = 27;
            this.cbCables.SelectedIndexChanged += new System.EventHandler(this.cbCables_SelectedIndexChanged);
            // 
            // lblCable
            // 
            this.lblCable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCable.AutoSize = true;
            this.lblCable.BackColor = System.Drawing.Color.Transparent;
            this.lblCable.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblCable.ForeColor = System.Drawing.Color.Black;
            this.lblCable.Location = new System.Drawing.Point(295, 180);
            this.lblCable.Margin = new System.Windows.Forms.Padding(0);
            this.lblCable.Name = "lblCable";
            this.lblCable.Size = new System.Drawing.Size(78, 35);
            this.lblCable.TabIndex = 27;
            this.lblCable.Text = "Wire:";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblUbicacion.ForeColor = System.Drawing.Color.Black;
            this.lblUbicacion.Location = new System.Drawing.Point(522, 0);
            this.lblUbicacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(135, 32);
            this.lblUbicacion.TabIndex = 28;
            this.lblUbicacion.Text = "Ubication:";
            // 
            // lblSemana
            // 
            this.lblSemana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblSemana.ForeColor = System.Drawing.Color.Black;
            this.lblSemana.Location = new System.Drawing.Point(0, 180);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(89, 35);
            this.lblSemana.TabIndex = 27;
            this.lblSemana.Text = "Week:";
            // 
            // lblNumPart
            // 
            this.lblNumPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumPart.AutoSize = true;
            this.lblNumPart.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblNumPart.ForeColor = System.Drawing.Color.Black;
            this.lblNumPart.Location = new System.Drawing.Point(0, 0);
            this.lblNumPart.Margin = new System.Windows.Forms.Padding(0);
            this.lblNumPart.Name = "lblNumPart";
            this.lblNumPart.Size = new System.Drawing.Size(175, 32);
            this.lblNumPart.TabIndex = 4;
            this.lblNumPart.Text = "Part Number:";
            // 
            // cbUbicaciones
            // 
            this.cbUbicaciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbUbicaciones.BackColor = System.Drawing.SystemColors.Control;
            this.cbUbicaciones.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbUbicaciones.FormattingEnabled = true;
            this.cbUbicaciones.Location = new System.Drawing.Point(525, 43);
            this.cbUbicaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUbicaciones.Name = "cbUbicaciones";
            this.cbUbicaciones.Size = new System.Drawing.Size(512, 29);
            this.cbUbicaciones.TabIndex = 29;
            this.cbUbicaciones.SelectedIndexChanged += new System.EventHandler(this.cbUbicaciones_SelectedIndexChanged);
            // 
            // cbSemana
            // 
            this.cbSemana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbSemana.BackColor = System.Drawing.SystemColors.Control;
            this.cbSemana.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbSemana.FormattingEnabled = true;
            this.cbSemana.Location = new System.Drawing.Point(3, 234);
            this.cbSemana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSemana.Name = "cbSemana";
            this.cbSemana.Size = new System.Drawing.Size(167, 29);
            this.cbSemana.TabIndex = 26;
            // 
            // cbNumPart
            // 
            this.cbNumPart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbNumPart.BackColor = System.Drawing.SystemColors.Control;
            this.cbNumPart.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbNumPart.FormattingEnabled = true;
            this.cbNumPart.Location = new System.Drawing.Point(3, 43);
            this.cbNumPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNumPart.Name = "cbNumPart";
            this.cbNumPart.Size = new System.Drawing.Size(289, 29);
            this.cbNumPart.TabIndex = 26;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(695, 10);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(143, 38);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Text = "CONSULT";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbOwner
            // 
            this.cbOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOwner.BackColor = System.Drawing.SystemColors.Control;
            this.cbOwner.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOwner.FormattingEnabled = true;
            this.cbOwner.Location = new System.Drawing.Point(3, 138);
            this.cbOwner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOwner.Name = "cbOwner";
            this.cbOwner.Size = new System.Drawing.Size(252, 29);
            this.cbOwner.TabIndex = 25;
            this.cbOwner.SelectedIndexChanged += new System.EventHandler(this.cbOwner_SelectedIndexChanged);
            // 
            // lblFalla
            // 
            this.lblFalla.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFalla.AutoSize = true;
            this.lblFalla.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblFalla.ForeColor = System.Drawing.Color.Black;
            this.lblFalla.Location = new System.Drawing.Point(1040, 88);
            this.lblFalla.Margin = new System.Windows.Forms.Padding(0);
            this.lblFalla.Name = "lblFalla";
            this.lblFalla.Size = new System.Drawing.Size(101, 35);
            this.lblFalla.TabIndex = 4;
            this.lblFalla.Text = "Failure:";
            // 
            // cbFallas
            // 
            this.cbFallas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbFallas.BackColor = System.Drawing.SystemColors.Control;
            this.cbFallas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbFallas.FormattingEnabled = true;
            this.cbFallas.Location = new System.Drawing.Point(1043, 138);
            this.cbFallas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFallas.Name = "cbFallas";
            this.cbFallas.Size = new System.Drawing.Size(383, 29);
            this.cbFallas.TabIndex = 26;
            this.cbFallas.SelectedIndexChanged += new System.EventHandler(this.cbFallas_SelectedIndexChanged);
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblDiagnostico.ForeColor = System.Drawing.Color.Black;
            this.lblDiagnostico.Location = new System.Drawing.Point(522, 88);
            this.lblDiagnostico.Margin = new System.Windows.Forms.Padding(0);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(145, 35);
            this.lblDiagnostico.TabIndex = 27;
            this.lblDiagnostico.Text = "Diagnostic:";
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.cbDiagnostico.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbDiagnostico.FormattingEnabled = true;
            this.cbDiagnostico.Location = new System.Drawing.Point(525, 138);
            this.cbDiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Size = new System.Drawing.Size(512, 29);
            this.cbDiagnostico.TabIndex = 28;
            this.cbDiagnostico.SelectedIndexChanged += new System.EventHandler(this.cbDiagnostico_SelectedIndexChanged);
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblOwner.ForeColor = System.Drawing.Color.Black;
            this.lblOwner.Location = new System.Drawing.Point(0, 88);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(100, 35);
            this.lblOwner.TabIndex = 5;
            this.lblOwner.Text = "Owner:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.89474F));
            this.tableLayoutPanel4.Controls.Add(this.gBoxValidation, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(95, 526);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1929, 543);
            this.tableLayoutPanel4.TabIndex = 31;
            // 
            // gBoxValidation
            // 
            this.gBoxValidation.Controls.Add(this.flowLayoutPanel3);
            this.gBoxValidation.Font = new System.Drawing.Font("72 Black", 20F);
            this.gBoxValidation.ForeColor = System.Drawing.Color.Black;
            this.gBoxValidation.Location = new System.Drawing.Point(4, 4);
            this.gBoxValidation.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Name = "gBoxValidation";
            this.gBoxValidation.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Size = new System.Drawing.Size(1921, 532);
            this.gBoxValidation.TabIndex = 17;
            this.gBoxValidation.TabStop = false;
            this.gBoxValidation.Text = "Diagnostic";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(17, 45);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1808, 481);
            this.flowLayoutPanel3.TabIndex = 35;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1793, 468);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelFechas);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 158);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1929, 352);
            this.flowLayoutPanel1.TabIndex = 32;
            this.flowLayoutPanel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbLinea);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Location = new System.Drawing.Point(1673, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 278);
            this.panel2.TabIndex = 0;
            // 
            // tbLinea
            // 
            this.tbLinea.BackColor = System.Drawing.SystemColors.Control;
            this.tbLinea.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbLinea.Location = new System.Drawing.Point(11, 50);
            this.tbLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.Size = new System.Drawing.Size(239, 28);
            this.tbLinea.TabIndex = 27;
            this.tbLinea.Text = "Seleccionar opciones..";
            this.tbLinea.Click += new System.EventHandler(this.tbLinea_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Line:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 82);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(235, 172);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel5.Controls.Add(this.CbHoraA, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.cbHoraDe, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblHoraDe, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbOperacion, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblOperacion, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePickerA, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblA, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.dateTimePickerDe, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblDe, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbDiagnostico, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblDiagnostico, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbOwner, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblNumPart, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cbNumPart, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbUbicaciones, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblUbicacion, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblOwner, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblFalla, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbFallas, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.cbCables, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.lblCable, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblHoraA, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblSemana, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.cbSemana, 0, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(32, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1635, 278);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // CbHoraA
            // 
            this.CbHoraA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbHoraA.BackColor = System.Drawing.SystemColors.Control;
            this.CbHoraA.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CbHoraA.FormattingEnabled = true;
            this.CbHoraA.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.CbHoraA.Location = new System.Drawing.Point(298, 138);
            this.CbHoraA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbHoraA.Name = "CbHoraA";
            this.CbHoraA.Size = new System.Drawing.Size(167, 29);
            this.CbHoraA.TabIndex = 38;
            // 
            // cbHoraDe
            // 
            this.cbHoraDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbHoraDe.BackColor = System.Drawing.SystemColors.Control;
            this.cbHoraDe.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbHoraDe.FormattingEnabled = true;
            this.cbHoraDe.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.cbHoraDe.Location = new System.Drawing.Point(298, 43);
            this.cbHoraDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHoraDe.Name = "cbHoraDe";
            this.cbHoraDe.Size = new System.Drawing.Size(167, 29);
            this.cbHoraDe.TabIndex = 37;
            // 
            // lblHoraDe
            // 
            this.lblHoraDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoraDe.AutoSize = true;
            this.lblHoraDe.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblHoraDe.ForeColor = System.Drawing.Color.Black;
            this.lblHoraDe.Location = new System.Drawing.Point(295, 0);
            this.lblHoraDe.Margin = new System.Windows.Forms.Padding(0);
            this.lblHoraDe.Name = "lblHoraDe";
            this.lblHoraDe.Size = new System.Drawing.Size(117, 32);
            this.lblHoraDe.TabIndex = 36;
            this.lblHoraDe.Text = "Hour Of:";
            // 
            // cbOperacion
            // 
            this.cbOperacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbOperacion.BackColor = System.Drawing.SystemColors.Control;
            this.cbOperacion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Items.AddRange(new object[] {
            "OP 10 - Chasis",
            "OP 20 - PCBA Tester",
            "OP 30 - Soldier",
            "OP 40 - Screwed",
            "OP 50 - Leak tester radome",
            "OP 60 - EOL"});
            this.cbOperacion.Location = new System.Drawing.Point(1043, 43);
            this.cbOperacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Size = new System.Drawing.Size(383, 29);
            this.cbOperacion.TabIndex = 34;
            // 
            // lblOperacion
            // 
            this.lblOperacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblOperacion.ForeColor = System.Drawing.Color.Black;
            this.lblOperacion.Location = new System.Drawing.Point(1040, 0);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(141, 32);
            this.lblOperacion.TabIndex = 33;
            this.lblOperacion.Text = "Operation:";
            // 
            // dateTimePickerA
            // 
            this.dateTimePickerA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerA.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePickerA.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePickerA.Location = new System.Drawing.Point(1432, 138);
            this.dateTimePickerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerA.Name = "dateTimePickerA";
            this.dateTimePickerA.Size = new System.Drawing.Size(252, 28);
            this.dateTimePickerA.TabIndex = 32;
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(1429, 88);
            this.lblA.Margin = new System.Windows.Forms.Padding(0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(114, 35);
            this.lblA.TabIndex = 31;
            this.lblA.Text = "Date To:";
            // 
            // dateTimePickerDe
            // 
            this.dateTimePickerDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDe.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePickerDe.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePickerDe.Location = new System.Drawing.Point(1432, 43);
            this.dateTimePickerDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDe.Name = "dateTimePickerDe";
            this.dateTimePickerDe.Size = new System.Drawing.Size(252, 28);
            this.dateTimePickerDe.TabIndex = 30;
            // 
            // lblDe
            // 
            this.lblDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblDe.ForeColor = System.Drawing.Color.Black;
            this.lblDe.Location = new System.Drawing.Point(1429, 0);
            this.lblDe.Margin = new System.Windows.Forms.Padding(0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(113, 32);
            this.lblDe.TabIndex = 29;
            this.lblDe.Text = "Date Of:";
            // 
            // lblHoraA
            // 
            this.lblHoraA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoraA.AutoSize = true;
            this.lblHoraA.Font = new System.Drawing.Font("Ebrima", 15F, System.Drawing.FontStyle.Bold);
            this.lblHoraA.ForeColor = System.Drawing.Color.Black;
            this.lblHoraA.Location = new System.Drawing.Point(295, 88);
            this.lblHoraA.Margin = new System.Windows.Forms.Padding(0);
            this.lblHoraA.Name = "lblHoraA";
            this.lblHoraA.Size = new System.Drawing.Size(118, 35);
            this.lblHoraA.TabIndex = 35;
            this.lblHoraA.Text = "Hour To:";
            // 
            // tableLayoutPanelFechas
            // 
            this.tableLayoutPanelFechas.ColumnCount = 6;
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFechas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelFechas.Controls.Add(this.btnExportar, 3, 0);
            this.tableLayoutPanelFechas.Controls.Add(this.btnConsultar, 1, 0);
            this.tableLayoutPanelFechas.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanelFechas.Location = new System.Drawing.Point(32, 284);
            this.tableLayoutPanelFechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelFechas.Name = "tableLayoutPanelFechas";
            this.tableLayoutPanelFechas.RowCount = 1;
            this.tableLayoutPanelFechas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFechas.Size = new System.Drawing.Size(1894, 58);
            this.tableLayoutPanelFechas.TabIndex = 2;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.BackColor = System.Drawing.Color.Green;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(846, 10);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(171, 38);
            this.btnExportar.TabIndex = 30;
            this.btnExportar.TabStop = false;
            this.btnExportar.Text = "EXPORT";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1025, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 41);
            this.button1.TabIndex = 31;
            this.button1.TabStop = false;
            this.button1.Text = "Another Query";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Ebrima", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Location = new System.Drawing.Point(2663, 1241);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(71, 25);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Text = "3.0.1.2";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(95, 1071);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1929, 204);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMenuConsulta);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(505, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 194);
            this.panel1.TabIndex = 0;
            // 
            // cbMenuConsulta
            // 
            this.cbMenuConsulta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbMenuConsulta.FormattingEnabled = true;
            this.cbMenuConsulta.Items.AddRange(new object[] {
            "Date",
            "Date and Hour",
            "Line",
            "Part Number",
            "Failure",
            "Diagnostic",
            "Owner",
            "Wire",
            "Week",
            "Ubication",
            "Operation",
            "Graph date and line",
            "Welded and Bolted"});
            this.cbMenuConsulta.Location = new System.Drawing.Point(23, 48);
            this.cbMenuConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMenuConsulta.Name = "cbMenuConsulta";
            this.cbMenuConsulta.Size = new System.Drawing.Size(349, 31);
            this.cbMenuConsulta.TabIndex = 28;
            this.cbMenuConsulta.Text = "Select options....";
            this.cbMenuConsulta.SelectedIndexChanged += new System.EventHandler(this.cbMenuConsulta_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, -4);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 45);
            this.label7.TabIndex = 26;
            this.label7.Text = "Select Query:";
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gBoxValidation.ResumeLayout(false);
            this.gBoxValidation.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanelFechas.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblNumPart;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.ComboBox cbNumPart;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.ComboBox cbUbicaciones;
        private System.Windows.Forms.ComboBox cbSemana;
        private System.Windows.Forms.Label lblCable;
        private System.Windows.Forms.ComboBox cbCables;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cbOwner;
        private System.Windows.Forms.Label lblFalla;
        private System.Windows.Forms.ComboBox cbFallas;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox gBoxValidation;
        private System.Windows.Forms.ComboBox cbDiagnostico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMenuConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFechas;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dateTimePickerA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblHoraDe;
        private System.Windows.Forms.Label lblHoraA;
        private System.Windows.Forms.ComboBox CbHoraA;
        private System.Windows.Forms.ComboBox cbHoraDe;
    }
}