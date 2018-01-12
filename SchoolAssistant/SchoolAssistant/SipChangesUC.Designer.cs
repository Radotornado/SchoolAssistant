namespace SchoolAssistant
{
    partial class SipChangesUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipChangesUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.newClassesTB = new System.Windows.Forms.TextBox();
            this.newClassesLabel = new System.Windows.Forms.Label();
            this.oldClassesTB = new System.Windows.Forms.TextBox();
            this.oldClassesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.changeAddSipLabel = new System.Windows.Forms.Label();
            this.changeSipButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teacherNamesComboBox = new Bunifu.Framework.UI.BunifuDropdown();
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
            // newClassesTB
            // 
            this.newClassesTB.Location = new System.Drawing.Point(75, 215);
            this.newClassesTB.Name = "newClassesTB";
            this.newClassesTB.Size = new System.Drawing.Size(285, 20);
            this.newClassesTB.TabIndex = 53;
            // 
            // newClassesLabel
            // 
            this.newClassesLabel.AutoSize = true;
            this.newClassesLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.newClassesLabel.Location = new System.Drawing.Point(71, 190);
            this.newClassesLabel.Name = "newClassesLabel";
            this.newClassesLabel.Size = new System.Drawing.Size(206, 22);
            this.newClassesLabel.TabIndex = 52;
            this.newClassesLabel.Text = "Нови часове за СИП:";
            // 
            // oldClassesTB
            // 
            this.oldClassesTB.Location = new System.Drawing.Point(75, 154);
            this.oldClassesTB.Multiline = true;
            this.oldClassesTB.Name = "oldClassesTB";
            this.oldClassesTB.Size = new System.Drawing.Size(285, 33);
            this.oldClassesTB.TabIndex = 51;
            // 
            // oldClassesLabel
            // 
            this.oldClassesLabel.AutoSize = true;
            this.oldClassesLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.oldClassesLabel.Location = new System.Drawing.Point(71, 129);
            this.oldClassesLabel.Name = "oldClassesLabel";
            this.oldClassesLabel.Size = new System.Drawing.Size(220, 22);
            this.oldClassesLabel.TabIndex = 50;
            this.oldClassesLabel.Text = "Стари часове за СИП:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameLabel.Location = new System.Drawing.Point(71, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 22);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Име:\r\n";
            // 
            // changeAddSipLabel
            // 
            this.changeAddSipLabel.AutoSize = true;
            this.changeAddSipLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.changeAddSipLabel.Location = new System.Drawing.Point(70, 63);
            this.changeAddSipLabel.Name = "changeAddSipLabel";
            this.changeAddSipLabel.Size = new System.Drawing.Size(267, 25);
            this.changeAddSipLabel.TabIndex = 47;
            this.changeAddSipLabel.Text = "Смени \\ добавете СИП:";
            // 
            // changeSipButton
            // 
            this.changeSipButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.changeSipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeSipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeSipButton.BorderRadius = 3;
            this.changeSipButton.ButtonText = "Смени часовете за СИП";
            this.changeSipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeSipButton.DisabledColor = System.Drawing.Color.Gray;
            this.changeSipButton.Iconcolor = System.Drawing.Color.Transparent;
            this.changeSipButton.Iconimage = null;
            this.changeSipButton.Iconimage_right = null;
            this.changeSipButton.Iconimage_right_Selected = null;
            this.changeSipButton.Iconimage_Selected = null;
            this.changeSipButton.IconMarginLeft = 0;
            this.changeSipButton.IconMarginRight = 0;
            this.changeSipButton.IconRightVisible = true;
            this.changeSipButton.IconRightZoom = 0D;
            this.changeSipButton.IconVisible = true;
            this.changeSipButton.IconZoom = 90D;
            this.changeSipButton.IsTab = false;
            this.changeSipButton.Location = new System.Drawing.Point(75, 241);
            this.changeSipButton.Name = "changeSipButton";
            this.changeSipButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.changeSipButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.changeSipButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.changeSipButton.selected = false;
            this.changeSipButton.Size = new System.Drawing.Size(285, 35);
            this.changeSipButton.TabIndex = 56;
            this.changeSipButton.Text = "Смени часовете за СИП";
            this.changeSipButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changeSipButton.Textcolor = System.Drawing.Color.LightGray;
            this.changeSipButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSipButton.Click += new System.EventHandler(this.changeSipButton_Click);
            // 
            // teacherNamesComboBox
            // 
            this.teacherNamesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.teacherNamesComboBox.BorderRadius = 3;
            this.teacherNamesComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.teacherNamesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherNamesComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.teacherNamesComboBox.Items = new string[0];
            this.teacherNamesComboBox.Location = new System.Drawing.Point(134, 91);
            this.teacherNamesComboBox.Name = "teacherNamesComboBox";
            this.teacherNamesComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.teacherNamesComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.teacherNamesComboBox.selectedIndex = -1;
            this.teacherNamesComboBox.Size = new System.Drawing.Size(226, 35);
            this.teacherNamesComboBox.TabIndex = 55;
            this.teacherNamesComboBox.onItemSelected += new System.EventHandler(this.teacherNamesComboBox_onItemSelected);
            // 
            // SipChangesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.changeSipButton);
            this.Controls.Add(this.teacherNamesComboBox);
            this.Controls.Add(this.newClassesTB);
            this.Controls.Add(this.newClassesLabel);
            this.Controls.Add(this.oldClassesTB);
            this.Controls.Add(this.oldClassesLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.changeAddSipLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "SipChangesUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.SipChangesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox newClassesTB;
        private System.Windows.Forms.Label newClassesLabel;
        private System.Windows.Forms.TextBox oldClassesTB;
        private System.Windows.Forms.Label oldClassesLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label changeAddSipLabel;
        private Bunifu.Framework.UI.BunifuFlatButton changeSipButton;
        private Bunifu.Framework.UI.BunifuDropdown teacherNamesComboBox;
    }
}
