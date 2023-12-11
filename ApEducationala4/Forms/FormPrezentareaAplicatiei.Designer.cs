namespace ApEducationala4.Forms
{
    partial class FormPrezentareaAplicatiei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrezentareaAplicatiei));
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDescriereAplicatie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btnBack.Location = new System.Drawing.Point(0, 12);
            this.btnBack.MaximumSize = new System.Drawing.Size(56, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(760, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelDescriereAplicatie
            // 
            this.labelDescriereAplicatie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDescriereAplicatie.BackColor = System.Drawing.Color.Transparent;
            this.labelDescriereAplicatie.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescriereAplicatie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelDescriereAplicatie.Location = new System.Drawing.Point(0, 262);
            this.labelDescriereAplicatie.Margin = new System.Windows.Forms.Padding(3);
            this.labelDescriereAplicatie.Name = "labelDescriereAplicatie";
            this.labelDescriereAplicatie.Size = new System.Drawing.Size(760, 188);
            this.labelDescriereAplicatie.TabIndex = 9;
            this.labelDescriereAplicatie.Text = resources.GetString("labelDescriereAplicatie.Text");
            this.labelDescriereAplicatie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPrezentareaAplicatiei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.labelDescriereAplicatie);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormPrezentareaAplicatiei";
            this.Text = "Prezentarea Aplicatiei";
            this.Load += new System.EventHandler(this.FormPrezentareaAplicatiei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDescriereAplicatie;
    }
}