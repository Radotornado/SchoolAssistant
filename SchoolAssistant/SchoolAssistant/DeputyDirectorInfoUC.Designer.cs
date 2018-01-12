namespace SchoolAssistant
{
    partial class DeputyDirectorInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeputyDirectorInfoUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dDirectorSpecialLabel = new System.Windows.Forms.Label();
            this.dDirectorProgramWebBrowser = new System.Windows.Forms.WebBrowser();
            this.dDirectorSipLabel = new System.Windows.Forms.Label();
            this.dDirectorConsultationLabel = new System.Windows.Forms.Label();
            this.dDirectorSubjectLabel = new System.Windows.Forms.Label();
            this.dDirectorNameLabel = new System.Windows.Forms.Label();
            this.okButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.choseDDirectorLabel = new System.Windows.Forms.Label();
            this.dDirectorComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(627, 422);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(105, 105);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 7;
            this.logoPictureBox.TabStop = false;
            // 
            // dDirectorSpecialLabel
            // 
            this.dDirectorSpecialLabel.AutoSize = true;
            this.dDirectorSpecialLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dDirectorSpecialLabel.Location = new System.Drawing.Point(325, 57);
            this.dDirectorSpecialLabel.Name = "dDirectorSpecialLabel";
            this.dDirectorSpecialLabel.Size = new System.Drawing.Size(211, 22);
            this.dDirectorSpecialLabel.TabIndex = 25;
            this.dDirectorSpecialLabel.Text = "Заместник директор";
            // 
            // dDirectorProgramWebBrowser
            // 
            this.dDirectorProgramWebBrowser.Location = new System.Drawing.Point(17, 167);
            this.dDirectorProgramWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.dDirectorProgramWebBrowser.Name = "dDirectorProgramWebBrowser";
            this.dDirectorProgramWebBrowser.Size = new System.Drawing.Size(604, 360);
            this.dDirectorProgramWebBrowser.TabIndex = 24;
            this.dDirectorProgramWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // dDirectorSipLabel
            // 
            this.dDirectorSipLabel.AutoSize = true;
            this.dDirectorSipLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dDirectorSipLabel.Location = new System.Drawing.Point(429, 94);
            this.dDirectorSipLabel.Name = "dDirectorSipLabel";
            this.dDirectorSipLabel.Size = new System.Drawing.Size(125, 22);
            this.dDirectorSipLabel.TabIndex = 23;
            this.dDirectorSipLabel.Text = "Има СИП в: ";
            // 
            // dDirectorConsultationLabel
            // 
            this.dDirectorConsultationLabel.AutoSize = true;
            this.dDirectorConsultationLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.dDirectorConsultationLabel.Location = new System.Drawing.Point(13, 131);
            this.dDirectorConsultationLabel.Name = "dDirectorConsultationLabel";
            this.dDirectorConsultationLabel.Size = new System.Drawing.Size(201, 22);
            this.dDirectorConsultationLabel.TabIndex = 22;
            this.dDirectorConsultationLabel.Text = "Има консултация в: ";
            // 
            // dDirectorSubjectLabel
            // 
            this.dDirectorSubjectLabel.AutoSize = true;
            this.dDirectorSubjectLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dDirectorSubjectLabel.Location = new System.Drawing.Point(13, 94);
            this.dDirectorSubjectLabel.Name = "dDirectorSubjectLabel";
            this.dDirectorSubjectLabel.Size = new System.Drawing.Size(110, 22);
            this.dDirectorSubjectLabel.TabIndex = 21;
            this.dDirectorSubjectLabel.Text = "Учител по: ";
            // 
            // dDirectorNameLabel
            // 
            this.dDirectorNameLabel.AutoSize = true;
            this.dDirectorNameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dDirectorNameLabel.Location = new System.Drawing.Point(12, 55);
            this.dDirectorNameLabel.Name = "dDirectorNameLabel";
            this.dDirectorNameLabel.Size = new System.Drawing.Size(287, 25);
            this.dDirectorNameLabel.TabIndex = 20;
            this.dDirectorNameLabel.Text = "Маргарита Турсунлийска";
            // 
            // okButton
            // 
            this.okButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.BorderRadius = 3;
            this.okButton.ButtonText = "OK";
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DisabledColor = System.Drawing.Color.Gray;
            this.okButton.Iconcolor = System.Drawing.Color.Transparent;
            this.okButton.Iconimage = null;
            this.okButton.Iconimage_right = null;
            this.okButton.Iconimage_right_Selected = null;
            this.okButton.Iconimage_Selected = null;
            this.okButton.IconMarginLeft = 0;
            this.okButton.IconMarginRight = 0;
            this.okButton.IconRightVisible = true;
            this.okButton.IconRightZoom = 0D;
            this.okButton.IconVisible = true;
            this.okButton.IconZoom = 90D;
            this.okButton.IsTab = false;
            this.okButton.Location = new System.Drawing.Point(499, 12);
            this.okButton.Name = "okButton";
            this.okButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.okButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.okButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.okButton.selected = false;
            this.okButton.Size = new System.Drawing.Size(217, 35);
            this.okButton.TabIndex = 19;
            this.okButton.Text = "OK";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okButton.Textcolor = System.Drawing.Color.LightGray;
            this.okButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // choseDDirectorLabel
            // 
            this.choseDDirectorLabel.AutoSize = true;
            this.choseDDirectorLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choseDDirectorLabel.Location = new System.Drawing.Point(12, 18);
            this.choseDDirectorLabel.Name = "choseDDirectorLabel";
            this.choseDDirectorLabel.Size = new System.Drawing.Size(258, 25);
            this.choseDDirectorLabel.TabIndex = 18;
            this.choseDDirectorLabel.Text = "Избери зам.-директор:";
            // 
            // dDirectorComboBox
            // 
            this.dDirectorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.dDirectorComboBox.BorderRadius = 3;
            this.dDirectorComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.dDirectorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dDirectorComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.dDirectorComboBox.Items = new string[0];
            this.dDirectorComboBox.Location = new System.Drawing.Point(276, 12);
            this.dDirectorComboBox.Name = "dDirectorComboBox";
            this.dDirectorComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.dDirectorComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dDirectorComboBox.selectedIndex = -1;
            this.dDirectorComboBox.Size = new System.Drawing.Size(217, 35);
            this.dDirectorComboBox.TabIndex = 17;
            // 
            // DeputyDirectorInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.dDirectorSpecialLabel);
            this.Controls.Add(this.dDirectorProgramWebBrowser);
            this.Controls.Add(this.dDirectorSipLabel);
            this.Controls.Add(this.dDirectorConsultationLabel);
            this.Controls.Add(this.dDirectorSubjectLabel);
            this.Controls.Add(this.dDirectorNameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.choseDDirectorLabel);
            this.Controls.Add(this.dDirectorComboBox);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "DeputyDirectorInfoUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.DeputyDirectorInfoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label dDirectorSpecialLabel;
        private System.Windows.Forms.WebBrowser dDirectorProgramWebBrowser;
        private System.Windows.Forms.Label dDirectorSipLabel;
        private System.Windows.Forms.Label dDirectorConsultationLabel;
        private System.Windows.Forms.Label dDirectorSubjectLabel;
        private System.Windows.Forms.Label dDirectorNameLabel;
        private Bunifu.Framework.UI.BunifuFlatButton okButton;
        private System.Windows.Forms.Label choseDDirectorLabel;
        private Bunifu.Framework.UI.BunifuDropdown dDirectorComboBox;
    }
}
