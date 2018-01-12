namespace SchoolAssistant
{
    partial class ShiftRegimeInfoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftRegimeInfoUC));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.shiftRegimeLabel = new System.Windows.Forms.Label();
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
            // shiftRegimeLabel
            // 
            this.shiftRegimeLabel.AutoSize = true;
            this.shiftRegimeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.shiftRegimeLabel.Location = new System.Drawing.Point(74, 64);
            this.shiftRegimeLabel.Name = "shiftRegimeLabel";
            this.shiftRegimeLabel.Size = new System.Drawing.Size(159, 22);
            this.shiftRegimeLabel.TabIndex = 8;
            this.shiftRegimeLabel.Text = "сменен режим";
            // 
            // ShiftRegimeInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.shiftRegimeLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ShiftRegimeInfoUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.ShiftRegimeInfoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label shiftRegimeLabel;
    }
}
