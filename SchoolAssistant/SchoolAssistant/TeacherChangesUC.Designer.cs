namespace SchoolAssistant
{
    partial class TeacherChangesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherChangesUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.consultationTextBox = new System.Windows.Forms.TextBox();
            this.consultationLabel = new System.Windows.Forms.Label();
            this.removeNameLabel = new System.Windows.Forms.Label();
            this.specialInfoLabel = new System.Windows.Forms.Label();
            this.specialTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addDataLabel = new System.Windows.Forms.Label();
            this.removeTeacherLabel = new System.Windows.Forms.Label();
            this.addTeacherButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.removeTeacherButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teachersComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.teacherNamesComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.changeTeacherProgramFD = new System.Windows.Forms.OpenFileDialog();
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
            this.logoPictureBox.WaitOnLoad = true;
            // 
            // consultationTextBox
            // 
            this.consultationTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.consultationTextBox.Location = new System.Drawing.Point(36, 252);
            this.consultationTextBox.Name = "consultationTextBox";
            this.consultationTextBox.Size = new System.Drawing.Size(248, 27);
            this.consultationTextBox.TabIndex = 67;
            // 
            // consultationLabel
            // 
            this.consultationLabel.AutoSize = true;
            this.consultationLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.consultationLabel.Location = new System.Drawing.Point(32, 228);
            this.consultationLabel.Name = "consultationLabel";
            this.consultationLabel.Size = new System.Drawing.Size(114, 21);
            this.consultationLabel.TabIndex = 66;
            this.consultationLabel.Text = "Консултация:\r\n";
            // 
            // removeNameLabel
            // 
            this.removeNameLabel.AutoSize = true;
            this.removeNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.removeNameLabel.Location = new System.Drawing.Point(378, 46);
            this.removeNameLabel.Name = "removeNameLabel";
            this.removeNameLabel.Size = new System.Drawing.Size(50, 21);
            this.removeNameLabel.TabIndex = 64;
            this.removeNameLabel.Text = "Име:";
            // 
            // specialInfoLabel
            // 
            this.specialInfoLabel.AutoSize = true;
            this.specialInfoLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.specialInfoLabel.Location = new System.Drawing.Point(32, 153);
            this.specialInfoLabel.Name = "specialInfoLabel";
            this.specialInfoLabel.Size = new System.Drawing.Size(239, 42);
            this.specialInfoLabel.TabIndex = 60;
            this.specialInfoLabel.Text = "Допълнителна информация\r\n(не не задължителна)";
            // 
            // specialTextBox
            // 
            this.specialTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.specialTextBox.Location = new System.Drawing.Point(36, 198);
            this.specialTextBox.Name = "specialTextBox";
            this.specialTextBox.Size = new System.Drawing.Size(248, 27);
            this.specialTextBox.TabIndex = 59;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.subjectLabel.Location = new System.Drawing.Point(32, 91);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(85, 21);
            this.subjectLabel.TabIndex = 58;
            this.subjectLabel.Text = "Предмет:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(32, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 21);
            this.nameLabel.TabIndex = 57;
            this.nameLabel.Text = "Име:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nameTextBox.Location = new System.Drawing.Point(83, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 27);
            this.nameTextBox.TabIndex = 56;
            // 
            // addDataLabel
            // 
            this.addDataLabel.AutoSize = true;
            this.addDataLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDataLabel.Location = new System.Drawing.Point(31, 21);
            this.addDataLabel.Name = "addDataLabel";
            this.addDataLabel.Size = new System.Drawing.Size(316, 25);
            this.addDataLabel.TabIndex = 69;
            this.addDataLabel.Text = "Въведи данни за нов учител:";
            // 
            // removeTeacherLabel
            // 
            this.removeTeacherLabel.AutoSize = true;
            this.removeTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeTeacherLabel.Location = new System.Drawing.Point(377, 21);
            this.removeTeacherLabel.Name = "removeTeacherLabel";
            this.removeTeacherLabel.Size = new System.Drawing.Size(205, 25);
            this.removeTeacherLabel.TabIndex = 70;
            this.removeTeacherLabel.Text = "Премахни учител:";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.addTeacherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.addTeacherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTeacherButton.BorderRadius = 3;
            this.addTeacherButton.ButtonText = "Добави учител";
            this.addTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTeacherButton.DisabledColor = System.Drawing.Color.Gray;
            this.addTeacherButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addTeacherButton.Iconimage = null;
            this.addTeacherButton.Iconimage_right = null;
            this.addTeacherButton.Iconimage_right_Selected = null;
            this.addTeacherButton.Iconimage_Selected = null;
            this.addTeacherButton.IconMarginLeft = 0;
            this.addTeacherButton.IconMarginRight = 0;
            this.addTeacherButton.IconRightVisible = true;
            this.addTeacherButton.IconRightZoom = 0D;
            this.addTeacherButton.IconVisible = true;
            this.addTeacherButton.IconZoom = 90D;
            this.addTeacherButton.IsTab = false;
            this.addTeacherButton.Location = new System.Drawing.Point(36, 326);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.addTeacherButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.addTeacherButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.addTeacherButton.selected = false;
            this.addTeacherButton.Size = new System.Drawing.Size(248, 35);
            this.addTeacherButton.TabIndex = 71;
            this.addTeacherButton.Text = "Добави учител";
            this.addTeacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTeacherButton.Textcolor = System.Drawing.Color.LightGray;
            this.addTeacherButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // removeTeacherButton
            // 
            this.removeTeacherButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.removeTeacherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.removeTeacherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeTeacherButton.BorderRadius = 3;
            this.removeTeacherButton.ButtonText = "Премахни учител";
            this.removeTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeTeacherButton.DisabledColor = System.Drawing.Color.Gray;
            this.removeTeacherButton.Iconcolor = System.Drawing.Color.Transparent;
            this.removeTeacherButton.Iconimage = null;
            this.removeTeacherButton.Iconimage_right = null;
            this.removeTeacherButton.Iconimage_right_Selected = null;
            this.removeTeacherButton.Iconimage_Selected = null;
            this.removeTeacherButton.IconMarginLeft = 0;
            this.removeTeacherButton.IconMarginRight = 0;
            this.removeTeacherButton.IconRightVisible = true;
            this.removeTeacherButton.IconRightZoom = 0D;
            this.removeTeacherButton.IconVisible = true;
            this.removeTeacherButton.IconZoom = 90D;
            this.removeTeacherButton.IsTab = false;
            this.removeTeacherButton.Location = new System.Drawing.Point(382, 111);
            this.removeTeacherButton.Name = "removeTeacherButton";
            this.removeTeacherButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.removeTeacherButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.removeTeacherButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.removeTeacherButton.selected = false;
            this.removeTeacherButton.Size = new System.Drawing.Size(200, 35);
            this.removeTeacherButton.TabIndex = 72;
            this.removeTeacherButton.Text = "Премахни учител";
            this.removeTeacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeTeacherButton.Textcolor = System.Drawing.Color.LightGray;
            this.removeTeacherButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeTeacherButton.Click += new System.EventHandler(this.removeTeacherButton_Click);
            // 
            // teachersComboBox
            // 
            this.teachersComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teachersComboBox.BorderRadius = 3;
            this.teachersComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.teachersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachersComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.teachersComboBox.Items = new string[0];
            this.teachersComboBox.Location = new System.Drawing.Point(36, 115);
            this.teachersComboBox.Name = "teachersComboBox";
            this.teachersComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.teachersComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.teachersComboBox.selectedIndex = -1;
            this.teachersComboBox.Size = new System.Drawing.Size(248, 35);
            this.teachersComboBox.TabIndex = 73;
            // 
            // teacherNamesComboBox
            // 
            this.teacherNamesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teacherNamesComboBox.BorderRadius = 3;
            this.teacherNamesComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.teacherNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherNamesComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.teacherNamesComboBox.Items = new string[0];
            this.teacherNamesComboBox.Location = new System.Drawing.Point(382, 70);
            this.teacherNamesComboBox.Name = "teacherNamesComboBox";
            this.teacherNamesComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.teacherNamesComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.teacherNamesComboBox.selectedIndex = -1;
            this.teacherNamesComboBox.Size = new System.Drawing.Size(200, 35);
            this.teacherNamesComboBox.TabIndex = 74;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 3;
            this.bunifuFlatButton1.ButtonText = "Добави файл с програма";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(36, 285);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(248, 35);
            this.bunifuFlatButton1.TabIndex = 75;
            this.bunifuFlatButton1.Text = "Добави файл с програма";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // TeacherChangesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.teacherNamesComboBox);
            this.Controls.Add(this.teachersComboBox);
            this.Controls.Add(this.removeTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.removeTeacherLabel);
            this.Controls.Add(this.addDataLabel);
            this.Controls.Add(this.consultationTextBox);
            this.Controls.Add(this.consultationLabel);
            this.Controls.Add(this.removeNameLabel);
            this.Controls.Add(this.specialInfoLabel);
            this.Controls.Add(this.specialTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "TeacherChangesUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.TeacherChangesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox consultationTextBox;
        private System.Windows.Forms.Label consultationLabel;
        private System.Windows.Forms.Label removeNameLabel;
        private System.Windows.Forms.Label specialInfoLabel;
        private System.Windows.Forms.TextBox specialTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label addDataLabel;
        private System.Windows.Forms.Label removeTeacherLabel;
        private Bunifu.Framework.UI.BunifuFlatButton addTeacherButton;
        private Bunifu.Framework.UI.BunifuFlatButton removeTeacherButton;
        private Bunifu.Framework.UI.BunifuDropdown teachersComboBox;
        private Bunifu.Framework.UI.BunifuDropdown teacherNamesComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.OpenFileDialog changeTeacherProgramFD;
    }
}
