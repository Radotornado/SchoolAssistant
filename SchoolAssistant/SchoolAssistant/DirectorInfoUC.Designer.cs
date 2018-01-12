namespace SchoolAssistant
{
    partial class DirectorInfoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorInfoUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.consultationLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.directorProgramWebBrowser = new System.Windows.Forms.WebBrowser();
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
            // consultationLabel
            // 
            this.consultationLabel.AutoSize = true;
            this.consultationLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.consultationLabel.Location = new System.Drawing.Point(289, 76);
            this.consultationLabel.Name = "consultationLabel";
            this.consultationLabel.Size = new System.Drawing.Size(332, 22);
            this.consultationLabel.TabIndex = 18;
            this.consultationLabel.Text = "Има консултация в: сряда 12:40 ч.";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.teacherLabel.Location = new System.Drawing.Point(237, 31);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(384, 22);
            this.teacherLabel.TabIndex = 14;
            this.teacherLabel.Text = "учител по български език и литература";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.emailLabel.Location = new System.Drawing.Point(13, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(272, 22);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "E-mail: mariana@mileva.com";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.phoneLabel.Location = new System.Drawing.Point(13, 76);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(216, 22);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "Телефон: 0893307233";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(12, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(200, 25);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Мариана Милева";
            // 
            // directorProgramWebBrowser
            // 
            this.directorProgramWebBrowser.Location = new System.Drawing.Point(17, 167);
            this.directorProgramWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.directorProgramWebBrowser.Name = "directorProgramWebBrowser";
            this.directorProgramWebBrowser.Size = new System.Drawing.Size(604, 360);
            this.directorProgramWebBrowser.TabIndex = 19;
            this.directorProgramWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // DirectorInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.directorProgramWebBrowser);
            this.Controls.Add(this.consultationLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "DirectorInfoUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.DirectorInfoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label consultationLabel;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.WebBrowser directorProgramWebBrowser;
    }
}
