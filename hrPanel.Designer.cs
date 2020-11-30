namespace IntegratedSystemThakshilawa
{
    partial class hrPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hrPanel));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStdAttendance = new System.Windows.Forms.Button();
            this.btnLecturerAttendance = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(741, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(34, 23);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::IntegratedSystemThakshilawa.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(25, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(38, 24);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(229, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome to HR Panel";
            // 
            // btnStdAttendance
            // 
            this.btnStdAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStdAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdAttendance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStdAttendance.Location = new System.Drawing.Point(147, 187);
            this.btnStdAttendance.Name = "btnStdAttendance";
            this.btnStdAttendance.Size = new System.Drawing.Size(133, 53);
            this.btnStdAttendance.TabIndex = 11;
            this.btnStdAttendance.Text = "Student Attendance";
            this.btnStdAttendance.UseVisualStyleBackColor = false;
            // 
            // btnLecturerAttendance
            // 
            this.btnLecturerAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLecturerAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerAttendance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLecturerAttendance.Location = new System.Drawing.Point(310, 187);
            this.btnLecturerAttendance.Name = "btnLecturerAttendance";
            this.btnLecturerAttendance.Size = new System.Drawing.Size(133, 53);
            this.btnLecturerAttendance.TabIndex = 12;
            this.btnLecturerAttendance.Text = "Lacturer Attendance";
            this.btnLecturerAttendance.UseVisualStyleBackColor = false;
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActivity.Location = new System.Drawing.Point(473, 187);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(133, 53);
            this.btnActivity.TabIndex = 13;
            this.btnActivity.Text = "Activity";
            this.btnActivity.UseVisualStyleBackColor = false;
            // 
            // hrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.btnLecturerAttendance);
            this.Controls.Add(this.btnStdAttendance);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hrPanel";
            this.Text = "HR Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStdAttendance;
        private System.Windows.Forms.Button btnLecturerAttendance;
        private System.Windows.Forms.Button btnActivity;
    }
}