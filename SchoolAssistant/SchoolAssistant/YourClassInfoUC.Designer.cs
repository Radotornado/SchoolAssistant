namespace SchoolAssistant
{
    partial class YourClassInfoUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourClassInfoUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.yourClassLabel = new System.Windows.Forms.Label();
            this.yourClassDataGridView = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourClassDataGridView)).BeginInit();
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
            // yourClassLabel
            // 
            this.yourClassLabel.AutoSize = true;
            this.yourClassLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.yourClassLabel.Location = new System.Drawing.Point(12, 38);
            this.yourClassLabel.Name = "yourClassLabel";
            this.yourClassLabel.Size = new System.Drawing.Size(640, 25);
            this.yourClassLabel.TabIndex = 9;
            this.yourClassLabel.Text = "Групи по проект \"Твоят час\" за учебната 2017/2018 година";
            // 
            // yourClassDataGridView
            // 
            this.yourClassDataGridView.AllowUserToResizeColumns = false;
            this.yourClassDataGridView.AllowUserToResizeRows = false;
            this.yourClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yourClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Teacher});
            this.yourClassDataGridView.Location = new System.Drawing.Point(17, 167);
            this.yourClassDataGridView.Name = "yourClassDataGridView";
            this.yourClassDataGridView.RowHeadersVisible = false;
            this.yourClassDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.yourClassDataGridView.Size = new System.Drawing.Size(604, 360);
            this.yourClassDataGridView.TabIndex = 8;
            // 
            // Group
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group.DefaultCellStyle = dataGridViewCellStyle3;
            this.Group.Frozen = true;
            this.Group.HeaderText = "Група";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 300;
            // 
            // Teacher
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teacher.DefaultCellStyle = dataGridViewCellStyle4;
            this.Teacher.HeaderText = "Ръководител";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            this.Teacher.Width = 300;
            // 
            // YourClassInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.yourClassLabel);
            this.Controls.Add(this.yourClassDataGridView);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "YourClassInfoUC";
            this.Size = new System.Drawing.Size(741, 535);
            this.Load += new System.EventHandler(this.YourClassInfoUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yourClassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label yourClassLabel;
        private System.Windows.Forms.DataGridView yourClassDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
    }
}
