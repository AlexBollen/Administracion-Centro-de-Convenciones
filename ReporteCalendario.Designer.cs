namespace Administración_Centro_de_Convenciones {
    partial class ReporteCalendario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMesAnterior = new System.Windows.Forms.Button();
            this.btnMesSiguiente = new System.Windows.Forms.Button();
            this.btnAnoSiguiente = new System.Windows.Forms.Button();
            this.btnAnoAnterior = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMesAno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.reportViewer1.Location = new System.Drawing.Point(459, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(608, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 280);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnMesAnterior
            // 
            this.btnMesAnterior.Location = new System.Drawing.Point(178, 101);
            this.btnMesAnterior.Name = "btnMesAnterior";
            this.btnMesAnterior.Size = new System.Drawing.Size(121, 39);
            this.btnMesAnterior.TabIndex = 2;
            this.btnMesAnterior.Text = "Mes Anterior";
            this.btnMesAnterior.UseVisualStyleBackColor = true;
            this.btnMesAnterior.Click += new System.EventHandler(this.btnMesAnterior_Click);
            // 
            // btnMesSiguiente
            // 
            this.btnMesSiguiente.Location = new System.Drawing.Point(325, 101);
            this.btnMesSiguiente.Name = "btnMesSiguiente";
            this.btnMesSiguiente.Size = new System.Drawing.Size(121, 39);
            this.btnMesSiguiente.TabIndex = 3;
            this.btnMesSiguiente.Text = "Mes Siguiente";
            this.btnMesSiguiente.UseVisualStyleBackColor = true;
            this.btnMesSiguiente.Click += new System.EventHandler(this.btnMesSiguiente_Click);
            // 
            // btnAnoSiguiente
            // 
            this.btnAnoSiguiente.Location = new System.Drawing.Point(325, 33);
            this.btnAnoSiguiente.Name = "btnAnoSiguiente";
            this.btnAnoSiguiente.Size = new System.Drawing.Size(121, 39);
            this.btnAnoSiguiente.TabIndex = 5;
            this.btnAnoSiguiente.Text = "Año Siguiente";
            this.btnAnoSiguiente.UseVisualStyleBackColor = true;
            this.btnAnoSiguiente.Click += new System.EventHandler(this.btnAnoSiguiente_Click);
            // 
            // btnAnoAnterior
            // 
            this.btnAnoAnterior.Location = new System.Drawing.Point(178, 33);
            this.btnAnoAnterior.Name = "btnAnoAnterior";
            this.btnAnoAnterior.Size = new System.Drawing.Size(121, 39);
            this.btnAnoAnterior.TabIndex = 4;
            this.btnAnoAnterior.Text = "Año Anterior";
            this.btnAnoAnterior.UseVisualStyleBackColor = true;
            this.btnAnoAnterior.Click += new System.EventHandler(this.btnAnoAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "AÑOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "MESES";
            // 
            // labelMesAno
            // 
            this.labelMesAno.AutoSize = true;
            this.labelMesAno.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.labelMesAno.ForeColor = System.Drawing.Color.White;
            this.labelMesAno.Location = new System.Drawing.Point(173, 174);
            this.labelMesAno.Name = "labelMesAno";
            this.labelMesAno.Size = new System.Drawing.Size(0, 29);
            this.labelMesAno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Actual:";
            // 
            // ReporteCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMesAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnoSiguiente);
            this.Controls.Add(this.btnAnoAnterior);
            this.Controls.Add(this.btnMesSiguiente);
            this.Controls.Add(this.btnMesAnterior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReporteCalendario";
            this.Text = "ReporteCalendario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMesAnterior;
        private System.Windows.Forms.Button btnMesSiguiente;
        private System.Windows.Forms.Button btnAnoSiguiente;
        private System.Windows.Forms.Button btnAnoAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMesAno;
        private System.Windows.Forms.Label label4;
    }
}