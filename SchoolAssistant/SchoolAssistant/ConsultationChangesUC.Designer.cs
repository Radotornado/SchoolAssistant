namespace SchoolAssistant
{
    partial class ConsultationChangesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationChangesUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.newConsultationsTB = new System.Windows.Forms.TextBox();
            this.newClassesLabel = new System.Windows.Forms.Label();
            this.oldConsultationsTB = new System.Windows.Forms.TextBox();
            this.oldClassesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.changeConsultationTeacherLabel = new System.Windows.Forms.Label();
            this.teacherNamesComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.changeConsultationButton = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.logoPictureBox.TabIndex = 8;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.WaitOnLoad = true;
            // 
            // newConsultationsTB
            // 
            this.newConsultationsTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.newConsultationsTB.Location = new System.Drawing.Point(75, 221);
            this.newConsultationsTB.Name = "newConsultationsTB";
            this.newConsultationsTB.Size = new System.Drawing.Size(348, 27);
            this.newConsultationsTB.TabIndex = 54;
            // 
            // newClassesLabel
            // 
            this.newClassesLabel.AutoSize = true;
            this.newClassesLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.newClassesLabel.Location = new System.Drawing.Point(71, 197);
            this.newClassesLabel.Name = "newClassesLabel";
            this.newClassesLabel.Size = new System.Drawing.Size(111, 21);
            this.newClassesLabel.TabIndex = 53;
            this.newClassesLabel.Text = "Нови часове:";
            // 
            // oldConsultationsTB
            // 
            this.oldConsultationsTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.oldConsultationsTB.Location = new System.Drawing.Point(75, 167);
            this.oldConsultationsTB.Multiline = true;
            this.oldConsultationsTB.Name = "oldConsultationsTB";
            this.oldConsultationsTB.Size = new System.Drawing.Size(348, 27);
            this.oldConsultationsTB.TabIndex = 52;
            // 
            // oldClassesLabel
            // 
            this.oldClassesLabel.AutoSize = true;
            this.oldClassesLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.oldClassesLabel.Location = new System.Drawing.Point(71, 143);
            this.oldClassesLabel.Name = "oldClassesLabel";
            this.oldClassesLabel.Size = new System.Drawing.Size(124, 21);
            this.oldClassesLabel.TabIndex = 51;
            this.oldClassesLabel.Text = "Стари часове:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameLabel.Location = new System.Drawing.Point(71, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 21);
            this.nameLabel.TabIndex = 50;
            this.nameLabel.Text = "Име:\r\n";
            // 
            // changeConsultationTeacherLabel
            // 
            this.changeConsultationTeacherLabel.AutoSize = true;
            this.changeConsultationTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.changeConsultationTeacherLabel.Location = new System.Drawing.Point(70, 52);
            this.changeConsultationTeacherLabel.Name = "changeConsultationTeacherLabel";
            this.changeConsultationTeacherLabel.Size = new System.Drawing.Size(360, 50);
            this.changeConsultationTeacherLabel.TabIndex = 48;
            this.changeConsultationTeacherLabel.Text = "Смени часовете за консултация\r\nна учител:";
            // 
            // teacherNamesComboBox
            // 
            this.teacherNamesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teacherNamesComboBox.BorderRadius = 3;
            this.teacherNamesComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.teacherNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherNamesComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.teacherNamesComboBox.Items = new string[0];
            this.teacherNamesComboBox.Location = new System.Drawing.Point(127, 105);
            this.teacherNamesComboBox.Name = "teacherNamesComboBox";
            this.teacherNamesComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.teacherNamesComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.teacherNamesComboBox.selectedIndex = -1;
            this.teacherNamesComboBox.Size = new System.Drawing.Size(296, 35);
            this.teacherNamesComboBox.TabIndex = 75;
            this.teacherNamesComboBox.onItemSelected += new System.EventHandler(this.teacherNamesComboBox_onItemSelected);
            // 
            // changeConsultationButton
            // 
            this.changeConsultationButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.changeConsultationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeConsultationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeConsultationButton.BorderRadius = 3;
            this.changeConsultationButton.ButtonText = "Смени часовете";
            this.changeConsultationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeConsultationButton.DisabledColor = System.Drawing.Color.Gray;
            this.changeConsultationButton.Iconcolor = System.Drawing.Color.Transparent;
            this.changeConsultationButton.Iconimage = null;
            this.changeConsultationButton.Iconimage_right = null;
            this.changeConsultationButton.Iconimage_right_Selected = null;
            this.changeConsultationButton.Iconimage_Selected = null;
            this.changeConsultationButton.IconMarginLeft = 0;
            this.changeConsultationButton.IconMarginRight = 0;
            this.changeConsultationButton.IconRightVisible = true;
            this.changeConsultationButton.IconRightZoom = 0D;
            this.changeConsultationButton.IconVisible = true;
            this.changeConsultationButton.IconZoom = 90D;
            this.changeConsultationButton.IsTab = false;
            this.changeConsultationButton.Location = new System.Drawing.Point(75, 254);
            this.changeConsultationButton.Name = "changeConsultationButton";
            this.changeConsultationButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeConsultationButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.changeConsultationButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.changeConsultationButton.selected = false;
            this.changeConsultationButton.Size = new System.Drawing.Size(348, 35);
            this.changeConsultationButton.TabIndex = 74;
            this.changeConsultationButton.Text = "Смени часовете";
            this.changeConsultationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeConsultationButton.Textcolor = System.Drawing.Color.LightGray;
            this.changeConsultationButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeConsultationButton.Click += new System.EventHandler(this.changeConsultationButton_Click);
            // 
            // ConsultationChangesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.teacherNamesComboBox);
            this.Controls.Add(this.changeConsultationButton);
            this.Controls.Add(this.newConsultationsTB);
            this.Controls.Add(this.newClassesLabel);
            this.Controls.Add(this.oldConsultationsTB);
            this.Controls.Add(this.oldClassesLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.changeConsultationTeacherLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ConsultationChangesUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.ConsultationChangesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox newConsultationsTB;
        private System.Windows.Forms.Label newClassesLabel;
        private System.Windows.Forms.TextBox oldConsultationsTB;
        private System.Windows.Forms.Label oldClassesLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label changeConsultationTeacherLabel;
        private Bunifu.Framework.UI.BunifuDropdown teacherNamesComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton changeConsultationButton;
    }
}
