namespace DiagnPcb.Consulta
{
    partial class FrmConsultDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultDate));
            this.PanelQuery = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerA = new System.Windows.Forms.DateTimePicker();
            this.lblA = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.doButton1 = new DiagnPcb.Styles.DOButton();
            this.lblDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultar = new DiagnPcb.Styles.DOButton();
            this.dateTimePickerDe = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportar = new DiagnPcb.Styles.DOButton();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.gBoxValidation = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelQuery.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.gBoxValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelQuery
            // 
            this.PanelQuery.Controls.Add(this.tableLayoutPanel1);
            this.PanelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelQuery.Location = new System.Drawing.Point(0, 0);
            this.PanelQuery.Name = "PanelQuery";
            this.PanelQuery.Size = new System.Drawing.Size(1462, 158);
            this.PanelQuery.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerA, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblA, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDe, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDe, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1462, 158);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dateTimePickerA
            // 
            this.dateTimePickerA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerA.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePickerA.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dateTimePickerA.Location = new System.Drawing.Point(849, 55);
            this.dateTimePickerA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerA.Name = "dateTimePickerA";
            this.dateTimePickerA.Size = new System.Drawing.Size(246, 24);
            this.dateTimePickerA.TabIndex = 33;
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.White;
            this.lblA.Location = new System.Drawing.Point(846, 30);
            this.lblA.Margin = new System.Windows.Forms.Padding(0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(84, 23);
            this.lblA.TabIndex = 32;
            this.lblA.Text = "Date To:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.doButton1);
            this.panel3.Location = new System.Drawing.Point(590, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 63);
            this.panel3.TabIndex = 37;
            // 
            // doButton1
            // 
            this.doButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.doButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.doButton1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.doButton1.BorderRadius = 24;
            this.doButton1.BorderSize = 3;
            this.doButton1.FlatAppearance.BorderSize = 2;
            this.doButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doButton1.ForeColor = System.Drawing.Color.White;
            this.doButton1.Image = global::DiagnPcb.Properties.Resources.producto2;
            this.doButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doButton1.Location = new System.Drawing.Point(13, 5);
            this.doButton1.Name = "doButton1";
            this.doButton1.Size = new System.Drawing.Size(235, 50);
            this.doButton1.TabIndex = 2;
            this.doButton1.Text = "Another";
            this.doButton1.TextColor = System.Drawing.Color.White;
            this.doButton1.UseVisualStyleBackColor = false;
            this.doButton1.Click += new System.EventHandler(this.doButton1_Click);
            // 
            // lblDe
            // 
            this.lblDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.White;
            this.lblDe.Location = new System.Drawing.Point(364, 30);
            this.lblDe.Margin = new System.Windows.Forms.Padding(0);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(85, 23);
            this.lblDe.TabIndex = 30;
            this.lblDe.Text = "Date Of:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Location = new System.Drawing.Point(367, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 63);
            this.panel1.TabIndex = 35;
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
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(2, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(206, 54);
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Consult";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dateTimePickerDe
            // 
            this.dateTimePickerDe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDe.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePickerDe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDe.Location = new System.Drawing.Point(367, 56);
            this.dateTimePickerDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDe.Name = "dateTimePickerDe";
            this.dateTimePickerDe.Size = new System.Drawing.Size(217, 22);
            this.dateTimePickerDe.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Location = new System.Drawing.Point(849, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 63);
            this.panel2.TabIndex = 36;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnExportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnExportar.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnExportar.BorderRadius = 50;
            this.btnExportar.BorderSize = 3;
            this.btnExportar.FlatAppearance.BorderSize = 2;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::DiagnPcb.Properties.Resources.exportar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(3, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(235, 50);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Export";
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.lblVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(0, 928);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1462, 37);
            this.panelVersion.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(9, 5);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(57, 19);
            this.lblVersion.TabIndex = 35;
            this.lblVersion.Text = "4.0.0.4";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.gBoxValidation);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 158);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1462, 770);
            this.panelContenedor.TabIndex = 2;
            // 
            // gBoxValidation
            // 
            this.gBoxValidation.Controls.Add(this.dataGridView1);
            this.gBoxValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBoxValidation.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxValidation.ForeColor = System.Drawing.Color.White;
            this.gBoxValidation.Location = new System.Drawing.Point(0, 0);
            this.gBoxValidation.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Name = "gBoxValidation";
            this.gBoxValidation.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Size = new System.Drawing.Size(1462, 770);
            this.gBoxValidation.TabIndex = 18;
            this.gBoxValidation.TabStop = false;
            this.gBoxValidation.Text = "Diagnostic";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1454, 729);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // FrmConsultDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1462, 965);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelVersion);
            this.Controls.Add(this.PanelQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultDate";
            this.Text = "FrmConsultDate";
            this.PanelQuery.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.gBoxValidation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dateTimePickerA;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox gBoxValidation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Styles.DOButton btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Styles.DOButton btnExportar;
        private System.Windows.Forms.Panel panel3;
        private Styles.DOButton doButton1;
    }
}