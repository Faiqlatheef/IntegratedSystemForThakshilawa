namespace IntegratedSystemThakshilawa
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxStudentAttendace = new System.Windows.Forms.GroupBox();
            this.buttonStudentSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.groupBoxStaffAttendance = new System.Windows.Forms.GroupBox();
            this.buttonStaffSubmit = new System.Windows.Forms.Button();
            this.textBoxStaffID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxStudentAttendace.SuspendLayout();
            this.groupBoxStaffAttendance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Thkshilawa Intergarted System";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(309, 66);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(186, 53);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBoxStudentAttendace
            // 
            this.groupBoxStudentAttendace.Controls.Add(this.buttonStudentSubmit);
            this.groupBoxStudentAttendace.Controls.Add(this.label2);
            this.groupBoxStudentAttendace.Controls.Add(this.textBoxStudentID);
            this.groupBoxStudentAttendace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStudentAttendace.Location = new System.Drawing.Point(32, 152);
            this.groupBoxStudentAttendace.Name = "groupBoxStudentAttendace";
            this.groupBoxStudentAttendace.Size = new System.Drawing.Size(343, 273);
            this.groupBoxStudentAttendace.TabIndex = 7;
            this.groupBoxStudentAttendace.TabStop = false;
            this.groupBoxStudentAttendace.Text = "Student Attendance";
            // 
            // buttonStudentSubmit
            // 
            this.buttonStudentSubmit.Location = new System.Drawing.Point(223, 54);
            this.buttonStudentSubmit.Name = "buttonStudentSubmit";
            this.buttonStudentSubmit.Size = new System.Drawing.Size(111, 35);
            this.buttonStudentSubmit.TabIndex = 2;
            this.buttonStudentSubmit.Text = "Submit";
            this.buttonStudentSubmit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter ID    :";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(88, 58);
            this.textBoxStudentID.Multiline = true;
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(112, 26);
            this.textBoxStudentID.TabIndex = 0;
            // 
            // groupBoxStaffAttendance
            // 
            this.groupBoxStaffAttendance.Controls.Add(this.buttonStaffSubmit);
            this.groupBoxStaffAttendance.Controls.Add(this.textBoxStaffID);
            this.groupBoxStaffAttendance.Controls.Add(this.label3);
            this.groupBoxStaffAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStaffAttendance.Location = new System.Drawing.Point(401, 152);
            this.groupBoxStaffAttendance.Name = "groupBoxStaffAttendance";
            this.groupBoxStaffAttendance.Size = new System.Drawing.Size(365, 273);
            this.groupBoxStaffAttendance.TabIndex = 8;
            this.groupBoxStaffAttendance.TabStop = false;
            this.groupBoxStaffAttendance.Text = "Staff Attendance";
            // 
            // buttonStaffSubmit
            // 
            this.buttonStaffSubmit.Location = new System.Drawing.Point(247, 53);
            this.buttonStaffSubmit.Name = "buttonStaffSubmit";
            this.buttonStaffSubmit.Size = new System.Drawing.Size(107, 36);
            this.buttonStaffSubmit.TabIndex = 2;
            this.buttonStaffSubmit.Text = "Submit";
            this.buttonStaffSubmit.UseVisualStyleBackColor = true;
            // 
            // textBoxStaffID
            // 
            this.textBoxStaffID.Location = new System.Drawing.Point(101, 59);
            this.textBoxStaffID.Multiline = true;
            this.textBoxStaffID.Name = "textBoxStaffID";
            this.textBoxStaffID.Size = new System.Drawing.Size(125, 26);
            this.textBoxStaffID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter ID   :";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxStaffAttendance);
            this.Controls.Add(this.groupBoxStudentAttendace);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Index Page";
            this.groupBoxStudentAttendace.ResumeLayout(false);
            this.groupBoxStudentAttendace.PerformLayout();
            this.groupBoxStaffAttendance.ResumeLayout(false);
            this.groupBoxStaffAttendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxStudentAttendace;
        private System.Windows.Forms.GroupBox groupBoxStaffAttendance;
        private System.Windows.Forms.Button buttonStudentSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button buttonStaffSubmit;
        private System.Windows.Forms.TextBox textBoxStaffID;
        private System.Windows.Forms.Label label3;
    }
}

