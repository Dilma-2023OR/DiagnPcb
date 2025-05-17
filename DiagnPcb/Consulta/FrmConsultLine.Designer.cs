namespace DiagnPcb.Consulta
{
    partial class FrmConsultLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultLine));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbLinea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new DiagnPcb.Styles.DOButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnExportar = new DiagnPcb.Styles.DOButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConsultar = new DiagnPcb.Styles.DOButton();
            this.panelVersion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.gBoxValidation = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelVersion.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.gBoxValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbLinea);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.checkedListBox1);
            this.panel4.Location = new System.Drawing.Point(12, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 263);
            this.panel4.TabIndex = 3;
            // 
            // tbLinea
            // 
            this.tbLinea.BackColor = System.Drawing.SystemColors.Control;
            this.tbLinea.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbLinea.Location = new System.Drawing.Point(11, 50);
            this.tbLinea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLinea.Name = "tbLinea";
            this.tbLinea.Size = new System.Drawing.Size(202, 28);
            this.tbLinea.TabIndex = 27;
            this.tbLinea.Text = "Seleccionar opciones..";
            this.tbLinea.Click += new System.EventHandler(this.tbLinea_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 34);
            this.label3.TabIndex = 26;
            this.label3.Text = "Line:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 82);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 154);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 965);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 341);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 411);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(3, 285);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 123);
            this.panel6.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.button1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.BorderRadius = 50;
            this.button1.BorderSize = 3;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DiagnPcb.Properties.Resources.producto2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(17, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Another";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnExportar);
            this.panel7.Location = new System.Drawing.Point(3, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 135);
            this.panel7.TabIndex = 33;
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
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(17, 25);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(165, 85);
            this.btnExportar.TabIndex = 1;
            this.btnExportar.Text = "Export";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.TextColor = System.Drawing.Color.White;
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnConsultar);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 126);
            this.panel8.TabIndex = 2;
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
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(15, 20);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(165, 85);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consult";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // panelVersion
            // 
            this.panelVersion.Controls.Add(this.lblVersion);
            this.panelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVersion.Location = new System.Drawing.Point(239, 928);
            this.panelVersion.Name = "panelVersion";
            this.panelVersion.Size = new System.Drawing.Size(1223, 37);
            this.panelVersion.TabIndex = 5;
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
            this.lblVersion.Size = new System.Drawing.Size(72, 23);
            this.lblVersion.TabIndex = 35;
            this.lblVersion.Text = "4.0.0.1";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.gBoxValidation);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(239, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1223, 928);
            this.panelContenedor.TabIndex = 6;
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
            this.gBoxValidation.Size = new System.Drawing.Size(1223, 928);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 879);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // FrmConsultLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1462, 965);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelVersion);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultLine";
            this.Text = "FrmConsultLine";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelVersion.ResumeLayout(false);
            this.panelVersion.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.gBoxValidation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbLinea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private Styles.DOButton button1;
        private System.Windows.Forms.Panel panel7;
        private Styles.DOButton btnExportar;
        private System.Windows.Forms.Panel panel8;
        private Styles.DOButton btnConsultar;
        private System.Windows.Forms.Panel panelVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.GroupBox gBoxValidation;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}