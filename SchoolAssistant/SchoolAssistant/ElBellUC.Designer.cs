namespace SchoolAssistant
{
    partial class ElBellUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElBellUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.elBellLabel = new System.Windows.Forms.Label();
            this.onButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.offButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comPortsComboBox = new Bunifu.Framework.UI.BunifuDropdown();
            this.elBellMessageLabel = new System.Windows.Forms.Label();
            this.alarmButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.classTimesLabel = new System.Windows.Forms.Label();
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
            // elBellLabel
            // 
            this.elBellLabel.AutoSize = true;
            this.elBellLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.elBellLabel.Location = new System.Drawing.Point(463, 46);
            this.elBellLabel.Name = "elBellLabel";
            this.elBellLabel.Size = new System.Drawing.Size(169, 21);
            this.elBellLabel.TabIndex = 8;
            this.elBellLabel.Text = "Електронен звънцец";
            // 
            // onButton
            // 
            this.onButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.onButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.onButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onButton.BorderRadius = 3;
            this.onButton.ButtonText = "Включи";
            this.onButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onButton.DisabledColor = System.Drawing.Color.Gray;
            this.onButton.Iconcolor = System.Drawing.Color.Transparent;
            this.onButton.Iconimage = null;
            this.onButton.Iconimage_right = null;
            this.onButton.Iconimage_right_Selected = null;
            this.onButton.Iconimage_Selected = null;
            this.onButton.IconMarginLeft = 0;
            this.onButton.IconMarginRight = 0;
            this.onButton.IconRightVisible = true;
            this.onButton.IconRightZoom = 0D;
            this.onButton.IconVisible = true;
            this.onButton.IconZoom = 90D;
            this.onButton.IsTab = false;
            this.onButton.Location = new System.Drawing.Point(387, 70);
            this.onButton.Name = "onButton";
            this.onButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.onButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.onButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.onButton.selected = false;
            this.onButton.Size = new System.Drawing.Size(153, 35);
            this.onButton.TabIndex = 11;
            this.onButton.Text = "Включи";
            this.onButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.onButton.Textcolor = System.Drawing.Color.LightGray;
            this.onButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.offButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.offButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.offButton.BorderRadius = 3;
            this.offButton.ButtonText = "Изключи";
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.DisabledColor = System.Drawing.Color.Gray;
            this.offButton.Iconcolor = System.Drawing.Color.Transparent;
            this.offButton.Iconimage = null;
            this.offButton.Iconimage_right = null;
            this.offButton.Iconimage_right_Selected = null;
            this.offButton.Iconimage_Selected = null;
            this.offButton.IconMarginLeft = 0;
            this.offButton.IconMarginRight = 0;
            this.offButton.IconRightVisible = true;
            this.offButton.IconRightZoom = 0D;
            this.offButton.IconVisible = true;
            this.offButton.IconZoom = 90D;
            this.offButton.IsTab = false;
            this.offButton.Location = new System.Drawing.Point(546, 70);
            this.offButton.Name = "offButton";
            this.offButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.offButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.offButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.offButton.selected = false;
            this.offButton.Size = new System.Drawing.Size(153, 35);
            this.offButton.TabIndex = 12;
            this.offButton.Text = "Изключи";
            this.offButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.offButton.Textcolor = System.Drawing.Color.LightGray;
            this.offButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // comPortsComboBox
            // 
            this.comPortsComboBox.BackColor = System.Drawing.Color.Transparent;
            this.comPortsComboBox.BorderRadius = 3;
            this.comPortsComboBox.DisabledColor = System.Drawing.Color.Gray;
            this.comPortsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comPortsComboBox.ForeColor = System.Drawing.Color.LightGray;
            this.comPortsComboBox.Items = new string[0];
            this.comPortsComboBox.Location = new System.Drawing.Point(387, 111);
            this.comPortsComboBox.Name = "comPortsComboBox";
            this.comPortsComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.comPortsComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.comPortsComboBox.selectedIndex = -1;
            this.comPortsComboBox.Size = new System.Drawing.Size(312, 35);
            this.comPortsComboBox.TabIndex = 13;
            // 
            // elBellMessageLabel
            // 
            this.elBellMessageLabel.AutoSize = true;
            this.elBellMessageLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.elBellMessageLabel.Location = new System.Drawing.Point(383, 149);
            this.elBellMessageLabel.Name = "elBellMessageLabel";
            this.elBellMessageLabel.Size = new System.Drawing.Size(320, 42);
            this.elBellMessageLabel.TabIndex = 14;
            this.elBellMessageLabel.Text = "Електронният звънец е включен на порт\r\nCOM3.";
            // 
            // alarmButton
            // 
            this.alarmButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.alarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.alarmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alarmButton.BorderRadius = 3;
            this.alarmButton.ButtonText = "Аларма";
            this.alarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarmButton.DisabledColor = System.Drawing.Color.Gray;
            this.alarmButton.Iconcolor = System.Drawing.Color.Transparent;
            this.alarmButton.Iconimage = null;
            this.alarmButton.Iconimage_right = null;
            this.alarmButton.Iconimage_right_Selected = null;
            this.alarmButton.Iconimage_Selected = null;
            this.alarmButton.IconMarginLeft = 0;
            this.alarmButton.IconMarginRight = 0;
            this.alarmButton.IconRightVisible = true;
            this.alarmButton.IconRightZoom = 0D;
            this.alarmButton.IconVisible = true;
            this.alarmButton.IconZoom = 90D;
            this.alarmButton.IsTab = false;
            this.alarmButton.Location = new System.Drawing.Point(387, 194);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.alarmButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.alarmButton.OnHoverTextColor = System.Drawing.Color.LightGray;
            this.alarmButton.selected = false;
            this.alarmButton.Size = new System.Drawing.Size(312, 35);
            this.alarmButton.TabIndex = 15;
            this.alarmButton.Text = "Аларма";
            this.alarmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alarmButton.Textcolor = System.Drawing.Color.LightGray;
            this.alarmButton.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmButton.Click += new System.EventHandler(this.alarmButton_Click);
            // 
            // classTimesLabel
            // 
            this.classTimesLabel.AutoSize = true;
            this.classTimesLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classTimesLabel.Location = new System.Drawing.Point(32, 19);
            this.classTimesLabel.Name = "classTimesLabel";
            this.classTimesLabel.Size = new System.Drawing.Size(116, 24);
            this.classTimesLabel.TabIndex = 16;
            this.classTimesLabel.Text = "ClassTimes";
            // 
            // ElBellUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.classTimesLabel);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.elBellMessageLabel);
            this.Controls.Add(this.comPortsComboBox);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.elBellLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ElBellUserControl";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.ElBellUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label elBellLabel;
        private Bunifu.Framework.UI.BunifuFlatButton onButton;
        private Bunifu.Framework.UI.BunifuFlatButton offButton;
        private Bunifu.Framework.UI.BunifuDropdown comPortsComboBox;
        private System.Windows.Forms.Label elBellMessageLabel;
        private Bunifu.Framework.UI.BunifuFlatButton alarmButton;
        private System.Windows.Forms.Label classTimesLabel;
    }
}
