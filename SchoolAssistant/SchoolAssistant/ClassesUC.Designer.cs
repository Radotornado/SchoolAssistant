namespace SchoolAssistant
{
    partial class ClassesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.okButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.choseClassLabel = new System.Windows.Forms.Label();
            this.classesComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.classProgramWebBrowser = new System.Windows.Forms.WebBrowser();
            this.classTeacherLabel = new System.Windows.Forms.Label();
            this.classNameLabel = new System.Windows.Forms.Label();
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
            this.logoPictureBox.TabIndex = 6;
            this.logoPictureBox.TabStop = false;
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
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okButton.Textcolor = System.Drawing.Color.LightGray;
            this.okButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // choseClassLabel
            // 
            this.choseClassLabel.AutoSize = true;
            this.choseClassLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choseClassLabel.Location = new System.Drawing.Point(69, 20);
            this.choseClassLabel.Name = "choseClassLabel";
            this.choseClassLabel.Size = new System.Drawing.Size(150, 25);
            this.choseClassLabel.TabIndex = 12;
            this.choseClassLabel.Text = "Избери клас:";
            // 
            // classesComboBox
            // 
            this.classesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.classesComboBox.BorderRadius = 3;
            this.classesComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.classesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classesComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.classesComboBox.Items = new string[0];
            this.classesComboBox.Location = new System.Drawing.Point(248, 16);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.classesComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.classesComboBox.selectedIndex = -1;
            this.classesComboBox.Size = new System.Drawing.Size(217, 35);
            this.classesComboBox.TabIndex = 11;
            // 
            // classProgramWebBrowser
            // 
            this.classProgramWebBrowser.Location = new System.Drawing.Point(17, 167);
            this.classProgramWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.classProgramWebBrowser.Name = "classProgramWebBrowser";
            this.classProgramWebBrowser.Size = new System.Drawing.Size(604, 360);
            this.classProgramWebBrowser.TabIndex = 16;
            this.classProgramWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // classTeacherLabel
            // 
            this.classTeacherLabel.AutoSize = true;
            this.classTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTeacherLabel.Location = new System.Drawing.Point(13, 129);
            this.classTeacherLabel.Name = "classTeacherLabel";
            this.classTeacherLabel.Size = new System.Drawing.Size(213, 22);
            this.classTeacherLabel.TabIndex = 18;
            this.classTeacherLabel.Text = "Класен ръководител: ";
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classNameLabel.Location = new System.Drawing.Point(12, 90);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(103, 25);
            this.classNameLabel.TabIndex = 17;
            this.classNameLabel.Text = "12В клас";
            // 
            // ClassesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.classTeacherLabel);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.classProgramWebBrowser);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.choseClassLabel);
            this.Controls.Add(this.classesComboBox);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ClassesUserControl";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.ClassesUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private Bunifu.Framework.UI.BunifuFlatButton okButton;
        private System.Windows.Forms.Label choseClassLabel;
        private Bunifu.Framework.UI.BunifuDropdown classesComboBox;
        private System.Windows.Forms.WebBrowser classProgramWebBrowser;
        private System.Windows.Forms.Label classTeacherLabel;
        private System.Windows.Forms.Label classNameLabel;
    }
}
