namespace Administración_Centro_de_Convenciones {
    partial class Reservas {
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
            this.listReservations = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.GroupBox();
            this.btnListarReservas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtBoxCantidadAsistentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxHoraCulminacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.addReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listReservations
            // 
            this.listReservations.AutoSize = true;
            this.listReservations.Controls.Add(this.dataGridView1);
            this.listReservations.Location = new System.Drawing.Point(-6, 142);
            this.listReservations.Name = "listReservations";
            this.listReservations.Size = new System.Drawing.Size(1089, 446);
            this.listReservations.TabIndex = 0;
            this.listReservations.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESERVAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administración de reservas";
            // 
            // btnAgregarReserva
            // 
            this.btnAgregarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarReserva.Location = new System.Drawing.Point(699, 101);
            this.btnAgregarReserva.Name = "btnAgregarReserva";
            this.btnAgregarReserva.Size = new System.Drawing.Size(107, 35);
            this.btnAgregarReserva.TabIndex = 4;
            this.btnAgregarReserva.Text = "Nueva";
            this.btnAgregarReserva.UseVisualStyleBackColor = true;
            this.btnAgregarReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarReserva.Location = new System.Drawing.Point(821, 101);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(107, 35);
            this.btnEditarReserva.TabIndex = 5;
            this.btnEditarReserva.Text = "Editar";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEliminarReserva
            // 
            this.btnEliminarReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarReserva.Location = new System.Drawing.Point(945, 101);
            this.btnEliminarReserva.Name = "btnEliminarReserva";
            this.btnEliminarReserva.Size = new System.Drawing.Size(107, 35);
            this.btnEliminarReserva.TabIndex = 6;
            this.btnEliminarReserva.Text = "Eliminar";
            this.btnEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // addReservation
            // 
            this.addReservation.AutoSize = true;
            this.addReservation.Controls.Add(this.comboBox1);
            this.addReservation.Controls.Add(this.label12);
            this.addReservation.Controls.Add(this.label11);
            this.addReservation.Controls.Add(this.label10);
            this.addReservation.Controls.Add(this.dateTimePicker2);
            this.addReservation.Controls.Add(this.dateTimePicker1);
            this.addReservation.Controls.Add(this.comboBoxTipoEvento);
            this.addReservation.Controls.Add(this.label9);
            this.addReservation.Controls.Add(this.comboBoxSalon);
            this.addReservation.Controls.Add(this.label8);
            this.addReservation.Controls.Add(this.txtBoxHoraCulminacion);
            this.addReservation.Controls.Add(this.label7);
            this.addReservation.Controls.Add(this.txtBoxHoraInicio);
            this.addReservation.Controls.Add(this.label6);
            this.addReservation.Controls.Add(this.txtBoxCantidadAsistentes);
            this.addReservation.Controls.Add(this.label5);
            this.addReservation.Controls.Add(this.txtBoxDescripcionEvento);
            this.addReservation.Controls.Add(this.txtBoxNombreEvento);
            this.addReservation.Controls.Add(this.label4);
            this.addReservation.Controls.Add(this.label3);
            this.addReservation.Location = new System.Drawing.Point(-6, 142);
            this.addReservation.Name = "addReservation";
            this.addReservation.Size = new System.Drawing.Size(1088, 438);
            this.addReservation.TabIndex = 1;
            this.addReservation.TabStop = false;
            // 
            // btnListarReservas
            // 
            this.btnListarReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarReservas.Location = new System.Drawing.Point(575, 101);
            this.btnListarReservas.Name = "btnListarReservas";
            this.btnListarReservas.Size = new System.Drawing.Size(107, 35);
            this.btnListarReservas.TabIndex = 7;
            this.btnListarReservas.Text = "Listar";
            this.btnListarReservas.UseVisualStyleBackColor = true;
            this.btnListarReservas.Click += new System.EventHandler(this.btnListarReservas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(66, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre del evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(66, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción:";
            // 
            // txtBoxNombreEvento
            // 
            this.txtBoxNombreEvento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreEvento.Location = new System.Drawing.Point(70, 56);
            this.txtBoxNombreEvento.Name = "txtBoxNombreEvento";
            this.txtBoxNombreEvento.Size = new System.Drawing.Size(314, 29);
            this.txtBoxNombreEvento.TabIndex = 10;
            // 
            // txtBoxDescripcionEvento
            // 
            this.txtBoxDescripcionEvento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcionEvento.Location = new System.Drawing.Point(70, 133);
            this.txtBoxDescripcionEvento.Name = "txtBoxDescripcionEvento";
            this.txtBoxDescripcionEvento.Size = new System.Drawing.Size(314, 29);
            this.txtBoxDescripcionEvento.TabIndex = 11;
            // 
            // txtBoxCantidadAsistentes
            // 
            this.txtBoxCantidadAsistentes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidadAsistentes.Location = new System.Drawing.Point(70, 218);
            this.txtBoxCantidadAsistentes.Name = "txtBoxCantidadAsistentes";
            this.txtBoxCantidadAsistentes.Size = new System.Drawing.Size(314, 29);
            this.txtBoxCantidadAsistentes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(66, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Asistentes:";
            // 
            // txtBoxHoraInicio
            // 
            this.txtBoxHoraInicio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoraInicio.Location = new System.Drawing.Point(535, 69);
            this.txtBoxHoraInicio.Name = "txtBoxHoraInicio";
            this.txtBoxHoraInicio.Size = new System.Drawing.Size(186, 29);
            this.txtBoxHoraInicio.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(531, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hora de inicio:";
            // 
            // txtBoxHoraCulminacion
            // 
            this.txtBoxHoraCulminacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoraCulminacion.Location = new System.Drawing.Point(792, 69);
            this.txtBoxHoraCulminacion.Name = "txtBoxHoraCulminacion";
            this.txtBoxHoraCulminacion.Size = new System.Drawing.Size(186, 29);
            this.txtBoxHoraCulminacion.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(788, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora de culminación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(538, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salon:";
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(535, 319);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(443, 30);
            this.comboBoxSalon.TabIndex = 19;
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(70, 298);
            this.comboBoxTipoEvento.Name = "comboBoxTipoEvento";
            this.comboBoxTipoEvento.Size = new System.Drawing.Size(314, 30);
            this.comboBoxTipoEvento.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(73, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo de evento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(443, 29);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(535, 233);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(443, 29);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(531, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha inicio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(531, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fecha culminación:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 30);
            this.comboBox1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(73, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 22);
            this.label12.TabIndex = 26;
            this.label12.Text = "Organizador:";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.addReservation);
            this.Controls.Add(this.btnListarReservas);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.listReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.addReservation.ResumeLayout(false);
            this.addReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listReservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnEliminarReserva;
        private System.Windows.Forms.GroupBox addReservation;
        private System.Windows.Forms.Button btnListarReservas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxTipoEvento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxHoraCulminacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxHoraInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCantidadAsistentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDescripcionEvento;
        private System.Windows.Forms.TextBox txtBoxNombreEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}