namespace IntegratedSystemThakshilawa
{
    partial class RegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            this.comboBoxUserType = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxUserType
            // 
            this.comboBoxUserType.FormattingEnabled = true;
            this.comboBoxUserType.ItemHeight = 13;
            this.comboBoxUserType.Items.AddRange(new object[] {
            "admin",
            "clerk",
            "owner",
            "manager",
            "cafeteria",
            "lacturer",
            "hr"});
            this.comboBoxUserType.Location = new System.Drawing.Point(225, 261);
            this.comboBoxUserType.Name = "comboBoxUserType";
            this.comboBoxUserType.Size = new System.Drawing.Size(198, 21);
            this.comboBoxUserType.TabIndex = 5;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(225, 142);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "User Type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name :";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Teal;
            this.buttonReset.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(222, 343);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(201, 37);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(222, 299);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(201, 37);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "SignIn";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textUsername
            // 
            this.textUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textUsername.Location = new System.Drawing.Point(225, 55);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(201, 26);
            this.textUsername.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(225, 208);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Location = new System.Drawing.Point(225, 109);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email : ";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(225, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(201, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone No : ";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 402);
            this.Controls.Add(this.comboBoxUserType);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterUser";
            this.Text = "Register User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserType;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}