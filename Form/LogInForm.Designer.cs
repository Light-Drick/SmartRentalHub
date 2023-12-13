namespace SmartRentalHub
{
    partial class LogInForm
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
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordBtn = new System.Windows.Forms.Button();
            this.UsernameTbx = new System.Windows.Forms.TextBox();
            this.PasswordTbx = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(361, 251);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(75, 23);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Log in";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(444, 367);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpBtn.TabIndex = 1;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(416, 428);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(128, 29);
            this.ForgotPasswordBtn.TabIndex = 2;
            this.ForgotPasswordBtn.Text = "Forgot password?";
            this.ForgotPasswordBtn.UseVisualStyleBackColor = true;
            this.ForgotPasswordBtn.Click += new System.EventHandler(this.ForgotPasswordBtn_Click);
            // 
            // UsernameTbx
            // 
            this.UsernameTbx.Location = new System.Drawing.Point(468, 252);
            this.UsernameTbx.Name = "UsernameTbx";
            this.UsernameTbx.Size = new System.Drawing.Size(100, 22);
            this.UsernameTbx.TabIndex = 3;
            this.UsernameTbx.TextChanged += new System.EventHandler(this.UsernameTbx_TextChanged);
            // 
            // PasswordTbx
            // 
            this.PasswordTbx.Location = new System.Drawing.Point(468, 290);
            this.PasswordTbx.Name = "PasswordTbx";
            this.PasswordTbx.PasswordChar = '*';
            this.PasswordTbx.Size = new System.Drawing.Size(100, 22);
            this.PasswordTbx.TabIndex = 4;
            this.PasswordTbx.UseSystemPasswordChar = true;
            this.PasswordTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTbx_KeyPress);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(602, 344);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 559);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PasswordTbx);
            this.Controls.Add(this.UsernameTbx);
            this.Controls.Add(this.ForgotPasswordBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LogInBtn);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button ForgotPasswordBtn;
        private System.Windows.Forms.TextBox UsernameTbx;
        private System.Windows.Forms.TextBox PasswordTbx;
        private System.Windows.Forms.Button ClearBtn;
    }
}

