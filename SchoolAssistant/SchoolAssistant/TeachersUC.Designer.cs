namespace SchoolAssistant
{
    partial class TeachersUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersUC));
            this.okButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.choseTeacherLabel = new System.Windows.Forms.Label();
            this.teachersComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.teacherSubjectLabel = new System.Windows.Forms.Label();
            this.teacherConsultationLabel = new System.Windows.Forms.Label();
            this.teachersSipLabel = new System.Windows.Forms.Label();
            this.teacherProgramWebBrowser = new System.Windows.Forms.WebBrowser();
            this.teacherSpecialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.okButton.Location = new System.Drawing.Point(471, 16);
            this.okButton.Name = "okButton";
            this.okButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.okButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.okButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.okButton.selected = false;
            this.okButton.Size = new System.Drawing.Size(217, 35);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okButton.Textcolor = System.Drawing.Color.LightGray;
            this.okButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // choseTeacherLabel
            // 
            this.choseTeacherLabel.AutoSize = true;
            this.choseTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choseTeacherLabel.Location = new System.Drawing.Point(69, 20);
            this.choseTeacherLabel.Name = "choseTeacherLabel";
            this.choseTeacherLabel.Size = new System.Drawing.Size(173, 25);
            this.choseTeacherLabel.TabIndex = 9;
            this.choseTeacherLabel.Text = "Избери учител:";
            // 
            // teachersComboBox
            // 
            this.teachersComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teachersComboBox.BorderRadius = 3;
            this.teachersComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.teachersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.teachersComboBox.Items = new string[0];
            this.teachersComboBox.Location = new System.Drawing.Point(248, 16);
            this.teachersComboBox.Name = "teachersComboBox";
            this.teachersComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.teachersComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.teachersComboBox.selectedIndex = -1;
            this.teachersComboBox.Size = new System.Drawing.Size(217, 35);
            this.teachersComboBox.TabIndex = 8;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(627, 422);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(105, 105);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.WaitOnLoad = true;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherNameLabel.Location = new System.Drawing.Point(12, 59);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(287, 25);
            this.teacherNameLabel.TabIndex = 11;
            this.teacherNameLabel.Text = "Маргарита Турсунлийска";
            // 
            // teacherSubjectLabel
            // 
            this.teacherSubjectLabel.AutoSize = true;
            this.teacherSubjectLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherSubjectLabel.Location = new System.Drawing.Point(13, 87);
            this.teacherSubjectLabel.Name = "teacherSubjectLabel";
            this.teacherSubjectLabel.Size = new System.Drawing.Size(110, 22);
            this.teacherSubjectLabel.TabIndex = 12;
            this.teacherSubjectLabel.Text = "Учител по: ";
            // 
            // teacherConsultationLabel
            // 
            this.teacherConsultationLabel.AutoSize = true;
            this.teacherConsultationLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.teacherConsultationLabel.Location = new System.Drawing.Point(13, 137);
            this.teacherConsultationLabel.Name = "teacherConsultationLabel";
            this.teacherConsultationLabel.Size = new System.Drawing.Size(201, 22);
            this.teacherConsultationLabel.TabIndex = 13;
            this.teacherConsultationLabel.Text = "Има консултация в: ";
            // 
            // teachersSipLabel
            // 
            this.teachersSipLabel.AutoSize = true;
            this.teachersSipLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersSipLabel.Location = new System.Drawing.Point(410, 87);
            this.teachersSipLabel.Name = "teachersSipLabel";
            this.teachersSipLabel.Size = new System.Drawing.Size(125, 22);
            this.teachersSipLabel.TabIndex = 14;
            this.teachersSipLabel.Text = "Има СИП в: ";
            // 
            // teacherProgramWebBrowser
            // 
            this.teacherProgramWebBrowser.Location = new System.Drawing.Point(17, 167);
            this.teacherProgramWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.teacherProgramWebBrowser.Name = "teacherProgramWebBrowser";
            this.teacherProgramWebBrowser.Size = new System.Drawing.Size(604, 360);
            this.teacherProgramWebBrowser.TabIndex = 15;
            this.teacherProgramWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // teacherSpecialLabel
            // 
            this.teacherSpecialLabel.AutoSize = true;
            this.teacherSpecialLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherSpecialLabel.Location = new System.Drawing.Point(305, 61);
            this.teacherSpecialLabel.Name = "teacherSpecialLabel";
            this.teacherSpecialLabel.Size = new System.Drawing.Size(211, 22);
            this.teacherSpecialLabel.TabIndex = 16;
            this.teacherSpecialLabel.Text = "Заместник директор";
            // 
            // TeachersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.teacherSpecialLabel);
            this.Controls.Add(this.teacherProgramWebBrowser);
            this.Controls.Add(this.teachersSipLabel);
            this.Controls.Add(this.teacherConsultationLabel);
            this.Controls.Add(this.teacherSubjectLabel);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.choseTeacherLabel);
            this.Controls.Add(this.teachersComboBox);
            this.Name = "TeachersUserControl";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.TeachersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton okButton;
        private System.Windows.Forms.Label choseTeacherLabel;
        private Bunifu.Framework.UI.BunifuDropdown teachersComboBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label teacherSubjectLabel;
        private System.Windows.Forms.Label teacherConsultationLabel;
        private System.Windows.Forms.Label teachersSipLabel;
        private System.Windows.Forms.WebBrowser teacherProgramWebBrowser;
        private System.Windows.Forms.Label teacherSpecialLabel;
    }
}
