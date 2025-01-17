﻿namespace Administración_Centro_de_Convenciones {
    partial class MenuPrincipal {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.reportsMenu = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnOrganizers = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnActivities = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSpaces = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.labelUserData = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.reportsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.titleBar.Controls.Add(this.labelUserData);
            this.titleBar.Controls.Add(this.btnMinimize);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1284, 38);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1204, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1247, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuBar.Controls.Add(this.btnLogout);
            this.menuBar.Controls.Add(this.reportsMenu);
            this.menuBar.Controls.Add(this.panel4);
            this.menuBar.Controls.Add(this.btnReports);
            this.menuBar.Controls.Add(this.panel3);
            this.menuBar.Controls.Add(this.btnSettings);
            this.menuBar.Controls.Add(this.panel2);
            this.menuBar.Controls.Add(this.panel1);
            this.menuBar.Controls.Add(this.btnServices);
            this.menuBar.Controls.Add(this.btnReservation);
            this.menuBar.Controls.Add(this.label2);
            this.menuBar.Controls.Add(this.label1);
            this.menuBar.Controls.Add(this.pictureBox1);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBar.Location = new System.Drawing.Point(0, 38);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(220, 573);
            this.menuBar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(3, 532);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 38);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 12;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // reportsMenu
            // 
            this.reportsMenu.Controls.Add(this.panel9);
            this.reportsMenu.Controls.Add(this.btnCalendar);
            this.reportsMenu.Controls.Add(this.panel8);
            this.reportsMenu.Controls.Add(this.btnOrganizers);
            this.reportsMenu.Controls.Add(this.panel7);
            this.reportsMenu.Controls.Add(this.btnActivities);
            this.reportsMenu.Controls.Add(this.panel6);
            this.reportsMenu.Controls.Add(this.btnSpaces);
            this.reportsMenu.Location = new System.Drawing.Point(37, 395);
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(183, 131);
            this.reportsMenu.TabIndex = 11;
            this.reportsMenu.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(3, 102);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 28);
            this.panel9.TabIndex = 14;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(13, 102);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(170, 28);
            this.btnCalendar.TabIndex = 13;
            this.btnCalendar.Text = "Calendario";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(3, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 28);
            this.panel8.TabIndex = 12;
            // 
            // btnOrganizers
            // 
            this.btnOrganizers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnOrganizers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrganizers.FlatAppearance.BorderSize = 0;
            this.btnOrganizers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnOrganizers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganizers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizers.ForeColor = System.Drawing.Color.White;
            this.btnOrganizers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganizers.Location = new System.Drawing.Point(13, 68);
            this.btnOrganizers.Name = "btnOrganizers";
            this.btnOrganizers.Size = new System.Drawing.Size(170, 28);
            this.btnOrganizers.TabIndex = 11;
            this.btnOrganizers.Text = "Organizador";
            this.btnOrganizers.UseVisualStyleBackColor = false;
            this.btnOrganizers.Click += new System.EventHandler(this.btnOrganizers_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(3, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 28);
            this.panel7.TabIndex = 10;
            // 
            // btnActivities
            // 
            this.btnActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActivities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivities.FlatAppearance.BorderSize = 0;
            this.btnActivities.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivities.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivities.ForeColor = System.Drawing.Color.White;
            this.btnActivities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivities.Location = new System.Drawing.Point(13, 34);
            this.btnActivities.Name = "btnActivities";
            this.btnActivities.Size = new System.Drawing.Size(170, 28);
            this.btnActivities.TabIndex = 9;
            this.btnActivities.Text = "Actividades";
            this.btnActivities.UseVisualStyleBackColor = false;
            this.btnActivities.Click += new System.EventHandler(this.btnActivities_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 28);
            this.panel6.TabIndex = 8;
            // 
            // btnSpaces
            // 
            this.btnSpaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSpaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpaces.FlatAppearance.BorderSize = 0;
            this.btnSpaces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSpaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpaces.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpaces.ForeColor = System.Drawing.Color.White;
            this.btnSpaces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpaces.Location = new System.Drawing.Point(13, 0);
            this.btnSpaces.Name = "btnSpaces";
            this.btnSpaces.Size = new System.Drawing.Size(170, 28);
            this.btnSpaces.TabIndex = 7;
            this.btnSpaces.Text = "Espacios";
            this.btnSpaces.UseVisualStyleBackColor = false;
            this.btnSpaces.Click += new System.EventHandler(this.btnSpaces_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 10;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(10, 357);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 32);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reportes";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_MouseLeave);
            this.btnReports.MouseHover += new System.EventHandler(this.btnReports_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 8;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(10, 285);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(210, 32);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Configuración";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 32);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 32);
            this.panel1.TabIndex = 4;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Image = ((System.Drawing.Image)(resources.GetObject("btnServices.Image")));
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(10, 213);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(210, 32);
            this.btnServices.TabIndex = 5;
            this.btnServices.Text = "Servicios";
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(10, 141);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(210, 32);
            this.btnReservation.TabIndex = 3;
            this.btnReservation.Text = "Reservas";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convenciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Centro\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(220, 38);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1064, 573);
            this.controlPanel.TabIndex = 2;
            // 
            // labelUserData
            // 
            this.labelUserData.AutoSize = true;
            this.labelUserData.BackColor = System.Drawing.Color.Transparent;
            this.labelUserData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelUserData.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserData.ForeColor = System.Drawing.Color.White;
            this.labelUserData.Location = new System.Drawing.Point(5, 7);
            this.labelUserData.Name = "labelUserData";
            this.labelUserData.Size = new System.Drawing.Size(84, 25);
            this.labelUserData.TabIndex = 13;
            this.labelUserData.Text = "Usuario:";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.reportsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Panel reportsMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnOrganizers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnActivities;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSpaces;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label labelUserData;
    }
}