using System.Drawing;

namespace ApEducationala4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.btnAjutorSuport = new FontAwesome.Sharp.IconButton();
            this.btnTeste = new FontAwesome.Sharp.IconButton();
            this.btnMaterialeEducationale = new FontAwesome.Sharp.IconButton();
            this.btnInstruire = new FontAwesome.Sharp.IconButton();
            this.btnPrezentareAplicatie = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.btnMaxPage = new System.Windows.Forms.Button();
            this.btnMinPage = new System.Windows.Forms.Button();
            this.btnClosePage = new System.Windows.Forms.Button();
            this.btnRestorePage = new System.Windows.Forms.Button();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBoxMax = new System.Windows.Forms.PictureBox();
            this.pictureBoxClosePage = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAnimation = new System.Windows.Forms.Label();
            this.pictureBoxGifTocaRoz = new System.Windows.Forms.PictureBox();
            this.labelTitluPrincipal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMeniu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePage)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifTocaRoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 448);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Bună! Haide să învățăm împreună despre pronume și adjective!");
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolTip.IsBalloon = true;
            // 
            // panelMeniu
            // 
            this.panelMeniu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMeniu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.panelMeniu.Controls.Add(this.btnAjutorSuport);
            this.panelMeniu.Controls.Add(this.pictureBox1);
            this.panelMeniu.Controls.Add(this.btnTeste);
            this.panelMeniu.Controls.Add(this.btnMaterialeEducationale);
            this.panelMeniu.Controls.Add(this.btnInstruire);
            this.panelMeniu.Controls.Add(this.btnPrezentareAplicatie);
            this.panelMeniu.Controls.Add(this.panelLogo);
            this.panelMeniu.Location = new System.Drawing.Point(1, 1);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(220, 608);
            this.panelMeniu.TabIndex = 6;
            // 
            // btnAjutorSuport
            // 
            this.btnAjutorSuport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjutorSuport.FlatAppearance.BorderSize = 0;
            this.btnAjutorSuport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjutorSuport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAjutorSuport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAjutorSuport.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnAjutorSuport.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAjutorSuport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjutorSuport.IconSize = 32;
            this.btnAjutorSuport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjutorSuport.Location = new System.Drawing.Point(0, 380);
            this.btnAjutorSuport.Name = "btnAjutorSuport";
            this.btnAjutorSuport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAjutorSuport.Size = new System.Drawing.Size(220, 60);
            this.btnAjutorSuport.TabIndex = 11;
            this.btnAjutorSuport.Text = "Ajutor si suport";
            this.btnAjutorSuport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjutorSuport.UseVisualStyleBackColor = true;
            this.btnAjutorSuport.Click += new System.EventHandler(this.btnAjutorSuport_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeste.FlatAppearance.BorderSize = 0;
            this.btnTeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeste.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTeste.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeste.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnTeste.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTeste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTeste.IconSize = 32;
            this.btnTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeste.Location = new System.Drawing.Point(0, 320);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTeste.Size = new System.Drawing.Size(220, 60);
            this.btnTeste.TabIndex = 10;
            this.btnTeste.Text = "Teste";
            this.btnTeste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnMaterialeEducationale
            // 
            this.btnMaterialeEducationale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterialeEducationale.FlatAppearance.BorderSize = 0;
            this.btnMaterialeEducationale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterialeEducationale.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMaterialeEducationale.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaterialeEducationale.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnMaterialeEducationale.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaterialeEducationale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaterialeEducationale.IconSize = 32;
            this.btnMaterialeEducationale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterialeEducationale.Location = new System.Drawing.Point(0, 260);
            this.btnMaterialeEducationale.Name = "btnMaterialeEducationale";
            this.btnMaterialeEducationale.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMaterialeEducationale.Size = new System.Drawing.Size(220, 60);
            this.btnMaterialeEducationale.TabIndex = 9;
            this.btnMaterialeEducationale.Text = "Materiale Educationale";
            this.btnMaterialeEducationale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterialeEducationale.UseVisualStyleBackColor = true;
            this.btnMaterialeEducationale.Click += new System.EventHandler(this.btnMaterialeEducationale_Click);
            // 
            // btnInstruire
            // 
            this.btnInstruire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstruire.FlatAppearance.BorderSize = 0;
            this.btnInstruire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstruire.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInstruire.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInstruire.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btnInstruire.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInstruire.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInstruire.IconSize = 32;
            this.btnInstruire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstruire.Location = new System.Drawing.Point(0, 200);
            this.btnInstruire.Name = "btnInstruire";
            this.btnInstruire.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInstruire.Size = new System.Drawing.Size(220, 60);
            this.btnInstruire.TabIndex = 8;
            this.btnInstruire.Text = "Instruire";
            this.btnInstruire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstruire.UseVisualStyleBackColor = true;
            this.btnInstruire.Click += new System.EventHandler(this.btnInstruire_Click);
            // 
            // btnPrezentareAplicatie
            // 
            this.btnPrezentareAplicatie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrezentareAplicatie.FlatAppearance.BorderSize = 0;
            this.btnPrezentareAplicatie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrezentareAplicatie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrezentareAplicatie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrezentareAplicatie.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.btnPrezentareAplicatie.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPrezentareAplicatie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrezentareAplicatie.IconSize = 32;
            this.btnPrezentareAplicatie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrezentareAplicatie.Location = new System.Drawing.Point(0, 140);
            this.btnPrezentareAplicatie.Name = "btnPrezentareAplicatie";
            this.btnPrezentareAplicatie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPrezentareAplicatie.Size = new System.Drawing.Size(220, 60);
            this.btnPrezentareAplicatie.TabIndex = 7;
            this.btnPrezentareAplicatie.Text = "Prezentarea Aplicatiei";
            this.btnPrezentareAplicatie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrezentareAplicatie.UseVisualStyleBackColor = true;
            this.btnPrezentareAplicatie.Click += new System.EventHandler(this.btnPrezentareAplicatie_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(219, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 10);
            this.panel1.TabIndex = 8;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(10, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(190, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.panelTitleBar.Controls.Add(this.panelControlBox);
            this.panelTitleBar.Controls.Add(this.lblTitleHome);
            this.panelTitleBar.Controls.Add(this.iconHome);
            this.panelTitleBar.Location = new System.Drawing.Point(220, 1);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(816, 75);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // panelControlBox
            // 
            this.panelControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBox.Controls.Add(this.btnMaxPage);
            this.panelControlBox.Controls.Add(this.btnMinPage);
            this.panelControlBox.Controls.Add(this.btnClosePage);
            this.panelControlBox.Controls.Add(this.btnRestorePage);
            this.panelControlBox.Location = new System.Drawing.Point(638, 0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(178, 40);
            this.panelControlBox.TabIndex = 2;
            // 
            // btnMaxPage
            // 
            this.btnMaxPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaxPage.BackgroundImage")));
            this.btnMaxPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaxPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMaxPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaxPage.Location = new System.Drawing.Point(109, 3);
            this.btnMaxPage.Name = "btnMaxPage";
            this.btnMaxPage.Size = new System.Drawing.Size(30, 30);
            this.btnMaxPage.TabIndex = 9;
            this.btnMaxPage.UseVisualStyleBackColor = true;
            this.btnMaxPage.Click += new System.EventHandler(this.btnMaxPage_Click_1);
            // 
            // btnMinPage
            // 
            this.btnMinPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinPage.BackgroundImage")));
            this.btnMinPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMinPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinPage.Location = new System.Drawing.Point(73, 3);
            this.btnMinPage.Name = "btnMinPage";
            this.btnMinPage.Size = new System.Drawing.Size(30, 30);
            this.btnMinPage.TabIndex = 8;
            this.btnMinPage.UseVisualStyleBackColor = true;
            this.btnMinPage.Click += new System.EventHandler(this.btnMinPage_Click_1);
            // 
            // btnClosePage
            // 
            this.btnClosePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosePage.BackgroundImage")));
            this.btnClosePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClosePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClosePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePage.Location = new System.Drawing.Point(145, 3);
            this.btnClosePage.Name = "btnClosePage";
            this.btnClosePage.Size = new System.Drawing.Size(30, 30);
            this.btnClosePage.TabIndex = 10;
            this.btnClosePage.UseVisualStyleBackColor = true;
            this.btnClosePage.Click += new System.EventHandler(this.btnClosePage_Click);
            // 
            // btnRestorePage
            // 
            this.btnRestorePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestorePage.BackgroundImage")));
            this.btnRestorePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestorePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRestorePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestorePage.Location = new System.Drawing.Point(37, 3);
            this.btnRestorePage.Name = "btnRestorePage";
            this.btnRestorePage.Size = new System.Drawing.Size(30, 30);
            this.btnRestorePage.TabIndex = 7;
            this.btnRestorePage.UseVisualStyleBackColor = true;
            this.btnRestorePage.Visible = false;
            this.btnRestorePage.Click += new System.EventHandler(this.btnRestorePage_Click_1);
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTitleHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleHome.Location = new System.Drawing.Point(56, 26);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(47, 17);
            this.lblTitleHome.TabIndex = 1;
            this.lblTitleHome.Text = "Home";
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.iconHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconHome.IconColor = System.Drawing.Color.Gainsboro;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 43;
            this.iconHome.Location = new System.Drawing.Point(7, 11);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(43, 47);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            // 
            // pictureBoxMax
            // 
            this.pictureBoxMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMax.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMax.Image")));
            this.pictureBoxMax.Location = new System.Drawing.Point(265, 224);
            this.pictureBoxMax.Name = "pictureBoxMax";
            this.pictureBoxMax.Size = new System.Drawing.Size(44, 42);
            this.pictureBoxMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMax.TabIndex = 3;
            this.pictureBoxMax.TabStop = false;
            // 
            // pictureBoxClosePage
            // 
            this.pictureBoxClosePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClosePage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClosePage.Image")));
            this.pictureBoxClosePage.Location = new System.Drawing.Point(315, 224);
            this.pictureBoxClosePage.Name = "pictureBoxClosePage";
            this.pictureBoxClosePage.Size = new System.Drawing.Size(44, 42);
            this.pictureBoxClosePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClosePage.TabIndex = 2;
            this.pictureBoxClosePage.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Controls.Add(this.pictureBoxMax);
            this.panelDesktop.Controls.Add(this.pictureBoxClosePage);
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(816, 509);
            this.panelDesktop.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.labelAnimation);
            this.panel2.Controls.Add(this.pictureBoxGifTocaRoz);
            this.panel2.Controls.Add(this.labelTitluPrincipal);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.MaximumSize = new System.Drawing.Size(816, 999);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 506);
            this.panel2.TabIndex = 5;
            // 
            // labelAnimation
            // 
            this.labelAnimation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAnimation.AutoSize = true;
            this.labelAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.labelAnimation.Font = new System.Drawing.Font("Garamond", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.labelAnimation.Location = new System.Drawing.Point(258, 183);
            this.labelAnimation.Name = "labelAnimation";
            this.labelAnimation.Size = new System.Drawing.Size(322, 132);
            this.labelAnimation.TabIndex = 5;
            this.labelAnimation.Text = "Bine ați venit la \r\naplicația noastră \r\nde învățare a pronumelor\r\n și adjectivelo" +
    "r!";
            this.labelAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxGifTocaRoz
            // 
            this.pictureBoxGifTocaRoz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGifTocaRoz.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGifTocaRoz.Image")));
            this.pictureBoxGifTocaRoz.Location = new System.Drawing.Point(44, 148);
            this.pictureBoxGifTocaRoz.MaximumSize = new System.Drawing.Size(300, 400);
            this.pictureBoxGifTocaRoz.Name = "pictureBoxGifTocaRoz";
            this.pictureBoxGifTocaRoz.Size = new System.Drawing.Size(191, 251);
            this.pictureBoxGifTocaRoz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGifTocaRoz.TabIndex = 4;
            this.pictureBoxGifTocaRoz.TabStop = false;
            // 
            // labelTitluPrincipal
            // 
            this.labelTitluPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitluPrincipal.AutoSize = true;
            this.labelTitluPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.labelTitluPrincipal.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitluPrincipal.ForeColor = System.Drawing.Color.Brown;
            this.labelTitluPrincipal.Location = new System.Drawing.Point(98, 3);
            this.labelTitluPrincipal.Name = "labelTitluPrincipal";
            this.labelTitluPrincipal.Size = new System.Drawing.Size(449, 62);
            this.labelTitluPrincipal.TabIndex = 3;
            this.labelTitluPrincipal.Text = "Aplicație Educațională Pentru\r\n Învățarea Pronumelor Și Adjectivelor";
            this.labelTitluPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(816, 509);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 584);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMeniu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie Educationala";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMeniu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosePage)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGifTocaRoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panelMeniu;
        private FontAwesome.Sharp.IconButton btnPrezentareAplicatie;
        private FontAwesome.Sharp.IconButton btnTeste;
        private FontAwesome.Sharp.IconButton btnMaterialeEducationale;
        private FontAwesome.Sharp.IconButton btnInstruire;
        private FontAwesome.Sharp.IconButton btnAjutorSuport;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitluPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxMax;
        private System.Windows.Forms.PictureBox pictureBoxClosePage;
        private System.Windows.Forms.Panel panelControlBox;
        private System.Windows.Forms.Button btnMaxPage;
        private System.Windows.Forms.Button btnMinPage;
        private System.Windows.Forms.Button btnClosePage;
        private System.Windows.Forms.Button btnRestorePage;
        private System.Windows.Forms.PictureBox pictureBoxGifTocaRoz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAnimation;
    }
}