namespace SchoolAssistant
{
    partial class notificationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notificationForm));
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tickLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.timeIn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tickLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // tickLogoPictureBox
            // 
            this.tickLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tickLogoPictureBox.Image")));
            this.tickLogoPictureBox.Location = new System.Drawing.Point(8, 6);
            this.tickLogoPictureBox.Name = "tickLogoPictureBox";
            this.tickLogoPictureBox.Size = new System.Drawing.Size(26, 26);
            this.tickLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tickLogoPictureBox.TabIndex = 0;
            this.tickLogoPictureBox.TabStop = false;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(40, 9);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(213, 21);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Учителят няма програма!";
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = this;
            this.bunifuDragControl.Vertical = true;
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 20;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // timeOut
            // 
            this.timeOut.Enabled = true;
            this.timeOut.Interval = 2000;
            this.timeOut.Tick += new System.EventHandler(this.timeOut_Tick);
            // 
            // timeIn
            // 
            this.timeIn.Enabled = true;
            this.timeIn.Interval = 20;
            this.timeIn.Tick += new System.EventHandler(this.timeIn_Tick);
            // 
            // notificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(257, 40);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.tickLogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "notificationForm";
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.notificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tickLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private System.Windows.Forms.PictureBox tickLogoPictureBox;
        private System.Windows.Forms.Label textLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer timeOut;
        private System.Windows.Forms.Timer timeIn;
    }
}