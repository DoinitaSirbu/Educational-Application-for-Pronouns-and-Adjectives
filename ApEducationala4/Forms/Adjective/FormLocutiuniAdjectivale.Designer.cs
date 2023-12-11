namespace ApEducationala4.Forms
{
    partial class FormLocutiuniAdjectivale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocutiuniAdjectivale));
            this.labelTitluLocAdj = new System.Windows.Forms.Label();
            this.richTextBoxExempluLocAdj = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTextLocAdj = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelLocutiuniAdj = new System.Windows.Forms.Panel();
            this.panelLocutiuniAdj.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitluLocAdj
            // 
            this.labelTitluLocAdj.AutoSize = true;
            this.labelTitluLocAdj.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.labelTitluLocAdj.Location = new System.Drawing.Point(143, 36);
            this.labelTitluLocAdj.Name = "labelTitluLocAdj";
            this.labelTitluLocAdj.Size = new System.Drawing.Size(264, 28);
            this.labelTitluLocAdj.TabIndex = 1;
            this.labelTitluLocAdj.Text = "Locuțiuni Adjectivale";
            // 
            // richTextBoxExempluLocAdj
            // 
            this.richTextBoxExempluLocAdj.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxExempluLocAdj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxExempluLocAdj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxExempluLocAdj.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBoxExempluLocAdj.Location = new System.Drawing.Point(195, 242);
            this.richTextBoxExempluLocAdj.Name = "richTextBoxExempluLocAdj";
            this.richTextBoxExempluLocAdj.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxExempluLocAdj.Size = new System.Drawing.Size(461, 22);
            this.richTextBoxExempluLocAdj.TabIndex = 7;
            this.richTextBoxExempluLocAdj.Text = "Exemple: de bună credință, bătut în cap, cu scaun la cap";
            // 
            // richTextBoxTextLocAdj
            // 
            this.richTextBoxTextLocAdj.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxTextLocAdj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTextLocAdj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxTextLocAdj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richTextBoxTextLocAdj.Location = new System.Drawing.Point(52, 98);
            this.richTextBoxTextLocAdj.Name = "richTextBoxTextLocAdj";
            this.richTextBoxTextLocAdj.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxTextLocAdj.Size = new System.Drawing.Size(711, 111);
            this.richTextBoxTextLocAdj.TabIndex = 8;
            this.richTextBoxTextLocAdj.Text = resources.GetString("richTextBoxTextLocAdj.Text");
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
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.MaximumSize = new System.Drawing.Size(56, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 45);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelLocutiuniAdj
            // 
            this.panelLocutiuniAdj.Controls.Add(this.richTextBoxTextLocAdj);
            this.panelLocutiuniAdj.Controls.Add(this.btnBack);
            this.panelLocutiuniAdj.Controls.Add(this.richTextBoxExempluLocAdj);
            this.panelLocutiuniAdj.Controls.Add(this.labelTitluLocAdj);
            this.panelLocutiuniAdj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLocutiuniAdj.Location = new System.Drawing.Point(0, 0);
            this.panelLocutiuniAdj.Name = "panelLocutiuniAdj";
            this.panelLocutiuniAdj.Size = new System.Drawing.Size(800, 450);
            this.panelLocutiuniAdj.TabIndex = 12;
            // 
            // FormLocutiuniAdjectivale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLocutiuniAdj);
            this.Location = new System.Drawing.Point(52, 29);
            this.Name = "FormLocutiuniAdjectivale";
            this.Text = "FormLocutiuniAdjectivale";
            this.Load += new System.EventHandler(this.FormLocutiuniAdjectivale_Load);
            this.panelLocutiuniAdj.ResumeLayout(false);
            this.panelLocutiuniAdj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitluLocAdj;
        private System.Windows.Forms.RichTextBox richTextBoxExempluLocAdj;
        private System.Windows.Forms.RichTextBox richTextBoxTextLocAdj;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelLocutiuniAdj;
    }
}