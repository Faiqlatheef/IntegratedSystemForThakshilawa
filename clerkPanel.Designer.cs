namespace IntegratedSystemThakshilawa
{
    partial class clerkPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clerkPanel));
            this.buttonStdRegistration = new System.Windows.Forms.Button();
            this.buttonStdPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStdRegistration
            // 
            this.buttonStdRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStdRegistration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStdRegistration.Location = new System.Drawing.Point(94, 126);
            this.buttonStdRegistration.Name = "buttonStdRegistration";
            this.buttonStdRegistration.Size = new System.Drawing.Size(119, 44);
            this.buttonStdRegistration.TabIndex = 0;
            this.buttonStdRegistration.Text = "Student Registration";
            this.buttonStdRegistration.UseVisualStyleBackColor = false;
            this.buttonStdRegistration.Click += new System.EventHandler(this.buttonStdRegistration_Click);
            // 
            // buttonStdPayment
            // 
            this.buttonStdPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStdPayment.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStdPayment.Location = new System.Drawing.Point(250, 126);
            this.buttonStdPayment.Name = "buttonStdPayment";
            this.buttonStdPayment.Size = new System.Drawing.Size(119, 44);
            this.buttonStdPayment.TabIndex = 1;
            this.buttonStdPayment.Text = "Student Payment";
            this.buttonStdPayment.UseVisualStyleBackColor = false;
            this.buttonStdPayment.Click += new System.EventHandler(this.buttonStdPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Clerk Panel";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(413, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(34, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // clerkPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 307);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStdPayment);
            this.Controls.Add(this.buttonStdRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clerkPanel";
            this.Text = "Front End Clerk Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStdRegistration;
        private System.Windows.Forms.Button buttonStdPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogout;
    }
}