namespace Administración_Centro_de_Convenciones {
    partial class Salones {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListarSalones = new System.Windows.Forms.Button();
            this.btnEliminarSalon = new System.Windows.Forms.Button();
            this.btnEdiicionSalon = new System.Windows.Forms.Button();
            this.btnAgregarSalon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSalon = new System.Windows.Forms.Panel();
            this.pbValidation4 = new System.Windows.Forms.PictureBox();
            this.pbValidation3 = new System.Windows.Forms.PictureBox();
            this.pbValidation2 = new System.Windows.Forms.PictureBox();
            this.pbValidation1 = new System.Windows.Forms.PictureBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.btnEditSalon = new System.Windows.Forms.Button();
            this.btnIngresarSalon = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCapacidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTipos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEstadoSalon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNombreSalon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listSalon = new System.Windows.Forms.Panel();
            this.dataGridViewSalones = new System.Windows.Forms.DataGridView();
            this.addSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation1)).BeginInit();
            this.listSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarSalones
            // 
            this.btnListarSalones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarSalones.Location = new System.Drawing.Point(369, 102);
            this.btnListarSalones.Name = "btnListarSalones";
            this.btnListarSalones.Size = new System.Drawing.Size(107, 35);
            this.btnListarSalones.TabIndex = 18;
            this.btnListarSalones.Text = "Listar";
            this.btnListarSalones.UseVisualStyleBackColor = true;
            this.btnListarSalones.Click += new System.EventHandler(this.btnListarSalones_Click);
            // 
            // btnEliminarSalon
            // 
            this.btnEliminarSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSalon.Location = new System.Drawing.Point(740, 102);
            this.btnEliminarSalon.Name = "btnEliminarSalon";
            this.btnEliminarSalon.Size = new System.Drawing.Size(107, 35);
            this.btnEliminarSalon.TabIndex = 17;
            this.btnEliminarSalon.Text = "Eliminar";
            this.btnEliminarSalon.UseVisualStyleBackColor = true;
            this.btnEliminarSalon.Click += new System.EventHandler(this.btnEliminarSalon_Click);
            // 
            // btnEdiicionSalon
            // 
            this.btnEdiicionSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdiicionSalon.Location = new System.Drawing.Point(615, 102);
            this.btnEdiicionSalon.Name = "btnEdiicionSalon";
            this.btnEdiicionSalon.Size = new System.Drawing.Size(107, 35);
            this.btnEdiicionSalon.TabIndex = 16;
            this.btnEdiicionSalon.Text = "Editar";
            this.btnEdiicionSalon.UseVisualStyleBackColor = true;
            this.btnEdiicionSalon.Click += new System.EventHandler(this.btnEditarSalon_Click);
            // 
            // btnAgregarSalon
            // 
            this.btnAgregarSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarSalon.Location = new System.Drawing.Point(494, 102);
            this.btnAgregarSalon.Name = "btnAgregarSalon";
            this.btnAgregarSalon.Size = new System.Drawing.Size(107, 35);
            this.btnAgregarSalon.TabIndex = 15;
            this.btnAgregarSalon.Text = "Nueva";
            this.btnAgregarSalon.UseVisualStyleBackColor = true;
            this.btnAgregarSalon.Click += new System.EventHandler(this.btnAgregarSalon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Administración de salones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "SALONES";
            // 
            // addSalon
            // 
            this.addSalon.Controls.Add(this.pbValidation4);
            this.addSalon.Controls.Add(this.pbValidation3);
            this.addSalon.Controls.Add(this.pbValidation2);
            this.addSalon.Controls.Add(this.pbValidation1);
            this.addSalon.Controls.Add(this.txtBoxDescripcion);
            this.addSalon.Controls.Add(this.btnEditSalon);
            this.addSalon.Controls.Add(this.btnIngresarSalon);
            this.addSalon.Controls.Add(this.label12);
            this.addSalon.Controls.Add(this.txtBoxCapacidad);
            this.addSalon.Controls.Add(this.label9);
            this.addSalon.Controls.Add(this.comboBoxTipos);
            this.addSalon.Controls.Add(this.label8);
            this.addSalon.Controls.Add(this.comboBoxEstadoSalon);
            this.addSalon.Controls.Add(this.label7);
            this.addSalon.Controls.Add(this.txtBoxNombreSalon);
            this.addSalon.Controls.Add(this.label6);
            this.addSalon.Location = new System.Drawing.Point(-16, 153);
            this.addSalon.Name = "addSalon";
            this.addSalon.Size = new System.Drawing.Size(890, 408);
            this.addSalon.TabIndex = 19;
            this.addSalon.Paint += new System.Windows.Forms.PaintEventHandler(this.addSalon_Paint);
            // 
            // pbValidation4
            // 
            this.pbValidation4.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation4.Image")));
            this.pbValidation4.Location = new System.Drawing.Point(748, 141);
            this.pbValidation4.Name = "pbValidation4";
            this.pbValidation4.Size = new System.Drawing.Size(15, 15);
            this.pbValidation4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation4.TabIndex = 54;
            this.pbValidation4.TabStop = false;
            // 
            // pbValidation3
            // 
            this.pbValidation3.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation3.Image")));
            this.pbValidation3.Location = new System.Drawing.Point(748, 44);
            this.pbValidation3.Name = "pbValidation3";
            this.pbValidation3.Size = new System.Drawing.Size(15, 15);
            this.pbValidation3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation3.TabIndex = 53;
            this.pbValidation3.TabStop = false;
            // 
            // pbValidation2
            // 
            this.pbValidation2.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation2.Image")));
            this.pbValidation2.Location = new System.Drawing.Point(360, 141);
            this.pbValidation2.Name = "pbValidation2";
            this.pbValidation2.Size = new System.Drawing.Size(15, 15);
            this.pbValidation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation2.TabIndex = 52;
            this.pbValidation2.TabStop = false;
            // 
            // pbValidation1
            // 
            this.pbValidation1.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation1.Image")));
            this.pbValidation1.Location = new System.Drawing.Point(360, 44);
            this.pbValidation1.Name = "pbValidation1";
            this.pbValidation1.Size = new System.Drawing.Size(15, 15);
            this.pbValidation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation1.TabIndex = 51;
            this.pbValidation1.TabStop = false;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(40, 234);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(435, 143);
            this.txtBoxDescripcion.TabIndex = 49;
            // 
            // btnEditSalon
            // 
            this.btnEditSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSalon.Location = new System.Drawing.Point(663, 290);
            this.btnEditSalon.Name = "btnEditSalon";
            this.btnEditSalon.Size = new System.Drawing.Size(128, 46);
            this.btnEditSalon.TabIndex = 48;
            this.btnEditSalon.Text = "Editar";
            this.btnEditSalon.UseVisualStyleBackColor = true;
            this.btnEditSalon.Click += new System.EventHandler(this.btnEditSalon_Click);
            // 
            // btnIngresarSalon
            // 
            this.btnIngresarSalon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarSalon.Location = new System.Drawing.Point(663, 290);
            this.btnIngresarSalon.Name = "btnIngresarSalon";
            this.btnIngresarSalon.Size = new System.Drawing.Size(128, 46);
            this.btnIngresarSalon.TabIndex = 47;
            this.btnIngresarSalon.Text = "Crear";
            this.btnIngresarSalon.UseVisualStyleBackColor = true;
            this.btnIngresarSalon.Click += new System.EventHandler(this.btnIngresarSalon_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(36, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 22);
            this.label12.TabIndex = 43;
            this.label12.Text = "Descripción:";
            // 
            // txtBoxCapacidad
            // 
            this.txtBoxCapacidad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCapacidad.Location = new System.Drawing.Point(40, 133);
            this.txtBoxCapacidad.Name = "txtBoxCapacidad";
            this.txtBoxCapacidad.Size = new System.Drawing.Size(314, 29);
            this.txtBoxCapacidad.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(424, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tipo de Salón:";
            // 
            // comboBoxTipos
            // 
            this.comboBoxTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipos.FormattingEnabled = true;
            this.comboBoxTipos.Location = new System.Drawing.Point(428, 135);
            this.comboBoxTipos.Name = "comboBoxTipos";
            this.comboBoxTipos.Size = new System.Drawing.Size(314, 30);
            this.comboBoxTipos.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(36, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Capacidad";
            // 
            // comboBoxEstadoSalon
            // 
            this.comboBoxEstadoSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoSalon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstadoSalon.FormattingEnabled = true;
            this.comboBoxEstadoSalon.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible",
            "En construcción",
            "En remodelación"});
            this.comboBoxEstadoSalon.Location = new System.Drawing.Point(428, 38);
            this.comboBoxEstadoSalon.Name = "comboBoxEstadoSalon";
            this.comboBoxEstadoSalon.Size = new System.Drawing.Size(314, 30);
            this.comboBoxEstadoSalon.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(424, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxNombreSalon
            // 
            this.txtBoxNombreSalon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreSalon.Location = new System.Drawing.Point(40, 37);
            this.txtBoxNombreSalon.Name = "txtBoxNombreSalon";
            this.txtBoxNombreSalon.Size = new System.Drawing.Size(314, 29);
            this.txtBoxNombreSalon.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(36, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre:";
            // 
            // listSalon
            // 
            this.listSalon.Controls.Add(this.dataGridViewSalones);
            this.listSalon.Location = new System.Drawing.Point(-7, 154);
            this.listSalon.Name = "listSalon";
            this.listSalon.Size = new System.Drawing.Size(879, 419);
            this.listSalon.TabIndex = 50;
            // 
            // dataGridViewSalones
            // 
            this.dataGridViewSalones.AllowUserToAddRows = false;
            this.dataGridViewSalones.AllowUserToDeleteRows = false;
            this.dataGridViewSalones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewSalones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSalones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSalones.ColumnHeadersHeight = 30;
            this.dataGridViewSalones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSalones.EnableHeadersVisualStyles = false;
            this.dataGridViewSalones.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSalones.Location = new System.Drawing.Point(21, 8);
            this.dataGridViewSalones.Name = "dataGridViewSalones";
            this.dataGridViewSalones.ReadOnly = true;
            this.dataGridViewSalones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSalones.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSalones.RowHeadersWidth = 30;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSalones.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSalones.Size = new System.Drawing.Size(829, 392);
            this.dataGridViewSalones.TabIndex = 1;
            // 
            // Salones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(859, 573);
            this.Controls.Add(this.listSalon);
            this.Controls.Add(this.btnListarSalones);
            this.Controls.Add(this.btnEliminarSalon);
            this.Controls.Add(this.btnEdiicionSalon);
            this.Controls.Add(this.btnAgregarSalon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addSalon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salones";
            this.Text = "Salones";
            this.Load += new System.EventHandler(this.Salones_Load);
            this.addSalon.ResumeLayout(false);
            this.addSalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation1)).EndInit();
            this.listSalon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarSalones;
        private System.Windows.Forms.Button btnEliminarSalon;
        private System.Windows.Forms.Button btnEdiicionSalon;
        private System.Windows.Forms.Button btnAgregarSalon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addSalon;
        private System.Windows.Forms.Button btnEditSalon;
        private System.Windows.Forms.Button btnIngresarSalon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxCapacidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxEstadoSalon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNombreSalon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Panel listSalon;
        private System.Windows.Forms.DataGridView dataGridViewSalones;
        private System.Windows.Forms.PictureBox pbValidation4;
        private System.Windows.Forms.PictureBox pbValidation3;
        private System.Windows.Forms.PictureBox pbValidation2;
        private System.Windows.Forms.PictureBox pbValidation1;
    }
}