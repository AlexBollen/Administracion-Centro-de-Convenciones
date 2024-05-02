﻿namespace Administración_Centro_de_Convenciones {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listReservations = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnEliminarReserva = new System.Windows.Forms.Button();
            this.addReservation = new System.Windows.Forms.GroupBox();
            this.btnConfirmarEdicion = new System.Windows.Forms.Button();
            this.comboBoxEstadoEvento = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxNombreComercial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.comboBoxOrganizadores = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerFC = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFI = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTipoEvento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxHoraCulminacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCantidadAsistentes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionEvento = new System.Windows.Forms.TextBox();
            this.txtBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListarReservas = new System.Windows.Forms.Button();
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
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
            this.btnEliminarReserva.Click += new System.EventHandler(this.btnEliminarReserva_Click);
            // 
            // addReservation
            // 
            this.addReservation.AutoSize = true;
            this.addReservation.Controls.Add(this.btnConfirmarEdicion);
            this.addReservation.Controls.Add(this.comboBoxEstadoEvento);
            this.addReservation.Controls.Add(this.label15);
            this.addReservation.Controls.Add(this.txtBoxNombreComercial);
            this.addReservation.Controls.Add(this.label14);
            this.addReservation.Controls.Add(this.txtBoxNombreCliente);
            this.addReservation.Controls.Add(this.label13);
            this.addReservation.Controls.Add(this.btnRegistrar);
            this.addReservation.Controls.Add(this.comboBoxOrganizadores);
            this.addReservation.Controls.Add(this.label12);
            this.addReservation.Controls.Add(this.label11);
            this.addReservation.Controls.Add(this.label10);
            this.addReservation.Controls.Add(this.dateTimePickerFC);
            this.addReservation.Controls.Add(this.dateTimePickerFI);
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
            // btnConfirmarEdicion
            // 
            this.btnConfirmarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdicion.Location = new System.Drawing.Point(951, 374);
            this.btnConfirmarEdicion.Name = "btnConfirmarEdicion";
            this.btnConfirmarEdicion.Size = new System.Drawing.Size(107, 35);
            this.btnConfirmarEdicion.TabIndex = 34;
            this.btnConfirmarEdicion.Text = "Registrar";
            this.btnConfirmarEdicion.UseVisualStyleBackColor = true;
            this.btnConfirmarEdicion.Click += new System.EventHandler(this.btnConfirmarEdicion_Click);
            // 
            // comboBoxEstadoEvento
            // 
            this.comboBoxEstadoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoEvento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstadoEvento.FormattingEnabled = true;
            this.comboBoxEstadoEvento.Items.AddRange(new object[] {
            "Programado",
            "En proceso",
            "Finalizado"});
            this.comboBoxEstadoEvento.Location = new System.Drawing.Point(729, 217);
            this.comboBoxEstadoEvento.Name = "comboBoxEstadoEvento";
            this.comboBoxEstadoEvento.Size = new System.Drawing.Size(314, 30);
            this.comboBoxEstadoEvento.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(725, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Estado evento:";
            // 
            // txtBoxNombreComercial
            // 
            this.txtBoxNombreComercial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreComercial.Location = new System.Drawing.Point(374, 376);
            this.txtBoxNombreComercial.Name = "txtBoxNombreComercial";
            this.txtBoxNombreComercial.Size = new System.Drawing.Size(314, 29);
            this.txtBoxNombreComercial.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(370, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 22);
            this.label14.TabIndex = 30;
            this.label14.Text = "Nombre comercial:";
            // 
            // txtBoxNombreCliente
            // 
            this.txtBoxNombreCliente.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreCliente.Location = new System.Drawing.Point(374, 297);
            this.txtBoxNombreCliente.Name = "txtBoxNombreCliente";
            this.txtBoxNombreCliente.Size = new System.Drawing.Size(314, 29);
            this.txtBoxNombreCliente.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(370, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 22);
            this.label13.TabIndex = 28;
            this.label13.Text = "Nombre cliente:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Location = new System.Drawing.Point(951, 375);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 35);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // comboBoxOrganizadores
            // 
            this.comboBoxOrganizadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganizadores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrganizadores.FormattingEnabled = true;
            this.comboBoxOrganizadores.Location = new System.Drawing.Point(25, 375);
            this.comboBoxOrganizadores.Name = "comboBoxOrganizadores";
            this.comboBoxOrganizadores.Size = new System.Drawing.Size(314, 30);
            this.comboBoxOrganizadores.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(28, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 22);
            this.label12.TabIndex = 26;
            this.label12.Text = "Organizador:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(554, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fecha culminación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(66, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fecha inicio:";
            // 
            // dateTimePickerFC
            // 
            this.dateTimePickerFC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFC.Location = new System.Drawing.Point(558, 135);
            this.dateTimePickerFC.Name = "dateTimePickerFC";
            this.dateTimePickerFC.Size = new System.Drawing.Size(443, 29);
            this.dateTimePickerFC.TabIndex = 23;
            // 
            // dateTimePickerFI
            // 
            this.dateTimePickerFI.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFI.Location = new System.Drawing.Point(70, 135);
            this.dateTimePickerFI.Name = "dateTimePickerFI";
            this.dateTimePickerFI.Size = new System.Drawing.Size(443, 29);
            this.dateTimePickerFI.TabIndex = 22;
            // 
            // comboBoxTipoEvento
            // 
            this.comboBoxTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoEvento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoEvento.FormattingEnabled = true;
            this.comboBoxTipoEvento.Location = new System.Drawing.Point(25, 298);
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
            this.label9.Location = new System.Drawing.Point(28, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tipo de evento:";
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(374, 217);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(314, 30);
            this.comboBoxSalon.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(370, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salon:";
            // 
            // txtBoxHoraCulminacion
            // 
            this.txtBoxHoraCulminacion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoraCulminacion.Location = new System.Drawing.Point(872, 54);
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
            this.label7.Location = new System.Drawing.Point(868, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora de culminación:";
            // 
            // txtBoxHoraInicio
            // 
            this.txtBoxHoraInicio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoraInicio.Location = new System.Drawing.Point(663, 54);
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
            this.label6.Location = new System.Drawing.Point(659, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hora de inicio:";
            // 
            // txtBoxCantidadAsistentes
            // 
            this.txtBoxCantidadAsistentes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidadAsistentes.Location = new System.Drawing.Point(431, 54);
            this.txtBoxCantidadAsistentes.Name = "txtBoxCantidadAsistentes";
            this.txtBoxCantidadAsistentes.Size = new System.Drawing.Size(186, 29);
            this.txtBoxCantidadAsistentes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(427, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad Asistentes:";
            // 
            // txtBoxDescripcionEvento
            // 
            this.txtBoxDescripcionEvento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcionEvento.Location = new System.Drawing.Point(25, 218);
            this.txtBoxDescripcionEvento.Name = "txtBoxDescripcionEvento";
            this.txtBoxDescripcionEvento.Size = new System.Drawing.Size(314, 29);
            this.txtBoxDescripcionEvento.TabIndex = 11;
            // 
            // txtBoxNombreEvento
            // 
            this.txtBoxNombreEvento.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreEvento.Location = new System.Drawing.Point(70, 56);
            this.txtBoxNombreEvento.Name = "txtBoxNombreEvento";
            this.txtBoxNombreEvento.Size = new System.Drawing.Size(314, 29);
            this.txtBoxNombreEvento.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(21, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción:";
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
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.btnListarReservas);
            this.Controls.Add(this.btnEliminarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnAgregarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listReservations);
            this.Controls.Add(this.addReservation);
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
        private System.Windows.Forms.ComboBox comboBoxOrganizadores;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerFC;
        private System.Windows.Forms.DateTimePicker dateTimePickerFI;
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
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtBoxNombreComercial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxNombreCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxEstadoEvento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnConfirmarEdicion;
    }
}