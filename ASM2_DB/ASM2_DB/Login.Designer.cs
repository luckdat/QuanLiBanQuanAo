namespace ASM2_DB
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnexitLogin = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, -37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(183, 117);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(289, 28);
            this.txtpassword.TabIndex = 5;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(183, 61);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(289, 28);
            this.txtusername.TabIndex = 6;
            // 
            // btnexitLogin
            // 
            this.btnexitLogin.Location = new System.Drawing.Point(538, 213);
            this.btnexitLogin.Name = "btnexitLogin";
            this.btnexitLogin.Size = new System.Drawing.Size(75, 36);
            this.btnexitLogin.TabIndex = 3;
            this.btnexitLogin.Text = "Exit";
            this.btnexitLogin.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(267, 170);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(84, 34);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnexitLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnexitLogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button button1;
    }
}