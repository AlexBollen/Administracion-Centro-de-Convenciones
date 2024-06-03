namespace Administración_Centro_de_Convenciones {
    partial class ReportesOrganizador {
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(80, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "Escriba el apellido:";
            // 
            // txtBoxNombreEvento
            // 
            this.txtBoxNombreEvento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreEvento.Location = new System.Drawing.Point(318, 63);
            this.txtBoxNombreEvento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNombreEvento.Name = "txtBoxNombreEvento";
            this.txtBoxNombreEvento.Size = new System.Drawing.Size(301, 35);
            this.txtBoxNombreEvento.TabIndex = 42;
            this.txtBoxNombreEvento.TextChanged += new System.EventHandler(this.txtBoxNombreEvento_TextChanged);
            // 
            // ReportesOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtBoxNombreEvento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportesOrganizador";
            this.Text = "ReportesOrganizador";
            this.Load += new System.EventHandler(this.ReportesOrganizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxNombreEvento;
    }
}