namespace SchoolAssistant
{
    partial class ClassTeacherChangeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTeacherChangeUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.newClassTeacherLabel = new System.Windows.Forms.Label();
            this.oldClassTeacherTextBox = new System.Windows.Forms.TextBox();
            this.oldClassTeacherLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.changeClassTeacherLabel = new System.Windows.Forms.Label();
            this.classNamesComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.newClassTeacherComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.changeClassTeacherButton = new Bunifu.Framework.UI.BunifuFlatButton();
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
            // newClassTeacherLabel
            // 
            this.newClassTeacherLabel.AutoSize = true;
            this.newClassTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.newClassTeacherLabel.Location = new System.Drawing.Point(71, 195);
            this.newClassTeacherLabel.Name = "newClassTeacherLabel";
            this.newClassTeacherLabel.Size = new System.Drawing.Size(122, 22);
            this.newClassTeacherLabel.TabIndex = 63;
            this.newClassTeacherLabel.Text = "Нов класен:";
            // 
            // oldClassTeacherTextBox
            // 
            this.oldClassTeacherTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.oldClassTeacherTextBox.Location = new System.Drawing.Point(75, 161);
            this.oldClassTeacherTextBox.Name = "oldClassTeacherTextBox";
            this.oldClassTeacherTextBox.Size = new System.Drawing.Size(307, 31);
            this.oldClassTeacherTextBox.TabIndex = 62;
            // 
            // oldClassTeacherLabel
            // 
            this.oldClassTeacherLabel.AutoSize = true;
            this.oldClassTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.oldClassTeacherLabel.Location = new System.Drawing.Point(71, 136);
            this.oldClassTeacherLabel.Name = "oldClassTeacherLabel";
            this.oldClassTeacherLabel.Size = new System.Drawing.Size(136, 22);
            this.oldClassTeacherLabel.TabIndex = 61;
            this.oldClassTeacherLabel.Text = "Стар класен:";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.classLabel.Location = new System.Drawing.Point(71, 106);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(61, 22);
            this.classLabel.TabIndex = 60;
            this.classLabel.Text = "Клас:";
            // 
            // changeClassTeacherLabel
            // 
            this.changeClassTeacherLabel.AutoSize = true;
            this.changeClassTeacherLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.changeClassTeacherLabel.Location = new System.Drawing.Point(70, 70);
            this.changeClassTeacherLabel.Name = "changeClassTeacherLabel";
            this.changeClassTeacherLabel.Size = new System.Drawing.Size(312, 25);
            this.changeClassTeacherLabel.TabIndex = 58;
            this.changeClassTeacherLabel.Text = "Смени класен ръководител:";
            // 
            // classNamesComboBox
            // 
            this.classNamesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.classNamesComboBox.BorderRadius = 3;
            this.classNamesComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.classNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classNamesComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.classNamesComboBox.Items = new string[0];
            this.classNamesComboBox.Location = new System.Drawing.Point(138, 98);
            this.classNamesComboBox.Name = "classNamesComboBox";
            this.classNamesComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.classNamesComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.classNamesComboBox.selectedIndex = -1;
            this.classNamesComboBox.Size = new System.Drawing.Size(244, 35);
            this.classNamesComboBox.TabIndex = 67;
            this.classNamesComboBox.onItemSelected += new System.EventHandler(this.classNamesComboBox_onItemSelected);
            // 
            // newClassTeacherComboBox
            // 
            this.newClassTeacherComboBox.BackColor = System.Drawing.Color.Transparent;
            this.newClassTeacherComboBox.BorderRadius = 3;
            this.newClassTeacherComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.newClassTeacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClassTeacherComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.newClassTeacherComboBox.Items = new string[0];
            this.newClassTeacherComboBox.Location = new System.Drawing.Point(75, 220);
            this.newClassTeacherComboBox.Name = "newClassTeacherComboBox";
            this.newClassTeacherComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.newClassTeacherComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.newClassTeacherComboBox.selectedIndex = -1;
            this.newClassTeacherComboBox.Size = new System.Drawing.Size(307, 35);
            this.newClassTeacherComboBox.TabIndex = 68;
            // 
            // changeClassTeacherButton
            // 
            this.changeClassTeacherButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.changeClassTeacherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeClassTeacherButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeClassTeacherButton.BorderRadius = 3;
            this.changeClassTeacherButton.ButtonText = "Смени класния";
            this.changeClassTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeClassTeacherButton.DisabledColor = System.Drawing.Color.Gray;
            this.changeClassTeacherButton.Iconcolor = System.Drawing.Color.Transparent;
            this.changeClassTeacherButton.Iconimage = null;
            this.changeClassTeacherButton.Iconimage_right = null;
            this.changeClassTeacherButton.Iconimage_right_Selected = null;
            this.changeClassTeacherButton.Iconimage_Selected = null;
            this.changeClassTeacherButton.IconMarginLeft = 0;
            this.changeClassTeacherButton.IconMarginRight = 0;
            this.changeClassTeacherButton.IconRightVisible = true;
            this.changeClassTeacherButton.IconRightZoom = 0D;
            this.changeClassTeacherButton.IconVisible = true;
            this.changeClassTeacherButton.IconZoom = 90D;
            this.changeClassTeacherButton.IsTab = false;
            this.changeClassTeacherButton.Location = new System.Drawing.Point(75, 261);
            this.changeClassTeacherButton.Name = "changeClassTeacherButton";
            this.changeClassTeacherButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeClassTeacherButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.changeClassTeacherButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.changeClassTeacherButton.selected = false;
            this.changeClassTeacherButton.Size = new System.Drawing.Size(307, 35);
            this.changeClassTeacherButton.TabIndex = 69;
            this.changeClassTeacherButton.Text = "Смени класния";
            this.changeClassTeacherButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeClassTeacherButton.Textcolor = System.Drawing.Color.LightGray;
            this.changeClassTeacherButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeClassTeacherButton.Click += new System.EventHandler(this.changeClassTeacherButton_Click);
            // 
            // ClassTeacherChangeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.changeClassTeacherButton);
            this.Controls.Add(this.newClassTeacherComboBox);
            this.Controls.Add(this.classNamesComboBox);
            this.Controls.Add(this.newClassTeacherLabel);
            this.Controls.Add(this.oldClassTeacherTextBox);
            this.Controls.Add(this.oldClassTeacherLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.changeClassTeacherLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ClassTeacherChangeUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.ClassTeacherChangeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label newClassTeacherLabel;
        private System.Windows.Forms.TextBox oldClassTeacherTextBox;
        private System.Windows.Forms.Label oldClassTeacherLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label changeClassTeacherLabel;
        private Bunifu.Framework.UI.BunifuDropdown classNamesComboBox;
        private Bunifu.Framework.UI.BunifuDropdown newClassTeacherComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton changeClassTeacherButton;
    }
}
