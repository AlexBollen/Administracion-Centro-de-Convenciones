namespace Administración_Centro_de_Convenciones {
    partial class Servicios {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnListarServicios = new System.Windows.Forms.Button();
            this.btnEliminarAsignacion = new System.Windows.Forms.Button();
            this.btnEditarAsignacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAsignaciones = new System.Windows.Forms.GroupBox();
            this.btnEliminarResServ = new System.Windows.Forms.Button();
            this.btnEditResServ = new System.Windows.Forms.Button();
            this.pbValidation2 = new System.Windows.Forms.PictureBox();
            this.pbValidation1 = new System.Windows.Forms.PictureBox();
            this.btnFinalizarAsignacion = new System.Windows.Forms.Button();
            this.btnReservarServicio = new System.Windows.Forms.Button();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxServicios = new System.Windows.Forms.ListBox();
            this.dataGridViewAsignacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewServicios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.listAsignaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarServicios
            // 
            this.btnListarServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarServicios.Location = new System.Drawing.Point(694, 103);
            this.btnListarServicios.Name = "btnListarServicios";
            this.btnListarServicios.Size = new System.Drawing.Size(107, 35);
            this.btnListarServicios.TabIndex = 13;
            this.btnListarServicios.Text = "Listar";
            this.btnListarServicios.UseVisualStyleBackColor = true;
            this.btnListarServicios.Click += new System.EventHandler(this.btnListarServicios_Click);
            // 
            // btnEliminarAsignacion
            // 
            this.btnEliminarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAsignacion.Location = new System.Drawing.Point(942, 103);
            this.btnEliminarAsignacion.Name = "btnEliminarAsignacion";
            this.btnEliminarAsignacion.Size = new System.Drawing.Size(107, 35);
            this.btnEliminarAsignacion.TabIndex = 12;
            this.btnEliminarAsignacion.Text = "Eliminar";
            this.btnEliminarAsignacion.UseVisualStyleBackColor = true;
            this.btnEliminarAsignacion.Click += new System.EventHandler(this.btnEliminarAsignacion_Click);
            // 
            // btnEditarAsignacion
            // 
            this.btnEditarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarAsignacion.Location = new System.Drawing.Point(818, 103);
            this.btnEditarAsignacion.Name = "btnEditarAsignacion";
            this.btnEditarAsignacion.Size = new System.Drawing.Size(107, 35);
            this.btnEditarAsignacion.TabIndex = 11;
            this.btnEditarAsignacion.Text = "Asignar";
            this.btnEditarAsignacion.UseVisualStyleBackColor = true;
            this.btnEditarAsignacion.Click += new System.EventHandler(this.btnEditarAsignacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Asignación de servicios a eventos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "SERVICIOS";
            // 
            // listAsignaciones
            // 
            this.listAsignaciones.AutoSize = true;
            this.listAsignaciones.Controls.Add(this.btnEliminarResServ);
            this.listAsignaciones.Controls.Add(this.btnEditResServ);
            this.listAsignaciones.Controls.Add(this.pbValidation2);
            this.listAsignaciones.Controls.Add(this.pbValidation1);
            this.listAsignaciones.Controls.Add(this.btnFinalizarAsignacion);
            this.listAsignaciones.Controls.Add(this.btnReservarServicio);
            this.listAsignaciones.Controls.Add(this.txtBoxCantidad);
            this.listAsignaciones.Controls.Add(this.label5);
            this.listAsignaciones.Controls.Add(this.txtBoxDetalle);
            this.listAsignaciones.Controls.Add(this.label4);
            this.listAsignaciones.Controls.Add(this.label3);
            this.listAsignaciones.Controls.Add(this.listBoxServicios);
            this.listAsignaciones.Controls.Add(this.dataGridViewAsignacion);
            this.listAsignaciones.Controls.Add(this.dataGridViewServicios);
            this.listAsignaciones.Controls.Add(this.label6);
            this.listAsignaciones.Location = new System.Drawing.Point(-7, 144);
            this.listAsignaciones.Name = "listAsignaciones";
            this.listAsignaciones.Size = new System.Drawing.Size(1089, 446);
            this.listAsignaciones.TabIndex = 14;
            this.listAsignaciones.TabStop = false;
            // 
            // btnEliminarResServ
            // 
            this.btnEliminarResServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEliminarResServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarResServ.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarResServ.Image")));
            this.btnEliminarResServ.Location = new System.Drawing.Point(998, 317);
            this.btnEliminarResServ.Name = "btnEliminarResServ";
            this.btnEliminarResServ.Size = new System.Drawing.Size(46, 46);
            this.btnEliminarResServ.TabIndex = 54;
            this.btnEliminarResServ.UseVisualStyleBackColor = false;
            this.btnEliminarResServ.Click += new System.EventHandler(this.btnEliminarResServ_Click);
            // 
            // btnEditResServ
            // 
            this.btnEditResServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEditResServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditResServ.Image = ((System.Drawing.Image)(resources.GetObject("btnEditResServ.Image")));
            this.btnEditResServ.Location = new System.Drawing.Point(937, 317);
            this.btnEditResServ.Name = "btnEditResServ";
            this.btnEditResServ.Size = new System.Drawing.Size(46, 46);
            this.btnEditResServ.TabIndex = 53;
            this.btnEditResServ.UseVisualStyleBackColor = false;
            this.btnEditResServ.Click += new System.EventHandler(this.btnEditResServ_Click);
            // 
            // pbValidation2
            // 
            this.pbValidation2.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation2.Image")));
            this.pbValidation2.Location = new System.Drawing.Point(724, 333);
            this.pbValidation2.Name = "pbValidation2";
            this.pbValidation2.Size = new System.Drawing.Size(15, 15);
            this.pbValidation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation2.TabIndex = 52;
            this.pbValidation2.TabStop = false;
            // 
            // pbValidation1
            // 
            this.pbValidation1.Image = ((System.Drawing.Image)(resources.GetObject("pbValidation1.Image")));
            this.pbValidation1.Location = new System.Drawing.Point(724, 264);
            this.pbValidation1.Name = "pbValidation1";
            this.pbValidation1.Size = new System.Drawing.Size(15, 15);
            this.pbValidation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbValidation1.TabIndex = 51;
            this.pbValidation1.TabStop = false;
            // 
            // btnFinalizarAsignacion
            // 
            this.btnFinalizarAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarAsignacion.Location = new System.Drawing.Point(839, 372);
            this.btnFinalizarAsignacion.Name = "btnFinalizarAsignacion";
            this.btnFinalizarAsignacion.Size = new System.Drawing.Size(107, 35);
            this.btnFinalizarAsignacion.TabIndex = 22;
            this.btnFinalizarAsignacion.Text = "Finalizar";
            this.btnFinalizarAsignacion.UseVisualStyleBackColor = true;
            this.btnFinalizarAsignacion.Click += new System.EventHandler(this.btnFinalizarAsignacion_Click);
            // 
            // btnReservarServicio
            // 
            this.btnReservarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservarServicio.Location = new System.Drawing.Point(937, 323);
            this.btnReservarServicio.Name = "btnReservarServicio";
            this.btnReservarServicio.Size = new System.Drawing.Size(107, 35);
            this.btnReservarServicio.TabIndex = 20;
            this.btnReservarServicio.Text = "Reservar";
            this.btnReservarServicio.UseVisualStyleBackColor = true;
            this.btnReservarServicio.Click += new System.EventHandler(this.btnReservarServicio_Click);
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidad.Location = new System.Drawing.Point(745, 326);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(157, 29);
            this.txtBoxCantidad.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(741, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad:";
            // 
            // txtBoxDetalle
            // 
            this.txtBoxDetalle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDetalle.Location = new System.Drawing.Point(745, 257);
            this.txtBoxDetalle.Name = "txtBoxDetalle";
            this.txtBoxDetalle.Size = new System.Drawing.Size(299, 29);
            this.txtBoxDetalle.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(741, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Detalle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(740, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Servicios asignados:";
            // 
            // listBoxServicios
            // 
            this.listBoxServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.listBoxServicios.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxServicios.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxServicios.FormattingEnabled = true;
            this.listBoxServicios.ItemHeight = 23;
            this.listBoxServicios.Location = new System.Drawing.Point(745, 59);
            this.listBoxServicios.Name = "listBoxServicios";
            this.listBoxServicios.Size = new System.Drawing.Size(299, 165);
            this.listBoxServicios.TabIndex = 1;
            this.listBoxServicios.SelectedIndexChanged += new System.EventHandler(this.listBoxServicios_SelectedIndexChanged);
            // 
            // dataGridViewAsignacion
            // 
            this.dataGridViewAsignacion.AllowUserToAddRows = false;
            this.dataGridViewAsignacion.AllowUserToDeleteRows = false;
            this.dataGridViewAsignacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewAsignacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAsignacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAsignacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsignacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAsignacion.ColumnHeadersHeight = 30;
            this.dataGridViewAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAsignacion.EnableHeadersVisualStyles = false;
            this.dataGridViewAsignacion.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewAsignacion.Location = new System.Drawing.Point(22, 19);
            this.dataGridViewAsignacion.Name = "dataGridViewAsignacion";
            this.dataGridViewAsignacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsignacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAsignacion.RowHeadersWidth = 30;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewAsignacion.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewAsignacion.Size = new System.Drawing.Size(690, 400);
            this.dataGridViewAsignacion.TabIndex = 21;
            this.dataGridViewAsignacion.SelectionChanged += new System.EventHandler(this.dataGridViewAsignacion_SelectionChanged);
            // 
            // dataGridViewServicios
            // 
            this.dataGridViewServicios.AllowUserToAddRows = false;
            this.dataGridViewServicios.AllowUserToDeleteRows = false;
            this.dataGridViewServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridViewServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewServicios.ColumnHeadersHeight = 30;
            this.dataGridViewServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewServicios.EnableHeadersVisualStyles = false;
            this.dataGridViewServicios.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewServicios.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewServicios.Name = "dataGridViewServicios";
            this.dataGridViewServicios.ReadOnly = true;
            this.dataGridViewServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewServicios.RowHeadersWidth = 30;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewServicios.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewServicios.Size = new System.Drawing.Size(690, 400);
            this.dataGridViewServicios.TabIndex = 0;
            this.dataGridViewServicios.SelectionChanged += new System.EventHandler(this.dataGridViewServicios_SelectionChanged);
            this.dataGridViewServicios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewServicios_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(744, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Selecciona para editar";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.listAsignaciones);
            this.Controls.Add(this.btnListarServicios);
            this.Controls.Add(this.btnEliminarAsignacion);
            this.Controls.Add(this.btnEditarAsignacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.listAsignaciones.ResumeLayout(false);
            this.listAsignaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarServicios;
        private System.Windows.Forms.Button btnEliminarAsignacion;
        private System.Windows.Forms.Button btnEditarAsignacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox listAsignaciones;
        private System.Windows.Forms.DataGridView dataGridViewServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxServicios;
        private System.Windows.Forms.Button btnReservarServicio;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAsignacion;
        private System.Windows.Forms.Button btnFinalizarAsignacion;
        private System.Windows.Forms.PictureBox pbValidation2;
        private System.Windows.Forms.PictureBox pbValidation1;
        private System.Windows.Forms.Button btnEliminarResServ;
        private System.Windows.Forms.Button btnEditResServ;
        private System.Windows.Forms.Label label6;
    }
}