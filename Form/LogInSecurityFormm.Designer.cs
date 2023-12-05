namespace SmartRentalHub
{
    partial class LogInSecurityFormm
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
            this.ForgotPasswordBtn = new System.Windows.Forms.Button();
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(385, 260);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(115, 30);
            this.ForgotPasswordBtn.TabIndex = 16;
            this.ForgotPasswordBtn.Text = "forgot password";
            this.ForgotPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // EmailTbx
            // 
            this.EmailTbx.Location = new System.Drawing.Point(385, 232);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(100, 22);
            this.EmailTbx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = ">LogIn & Security";
            // 
            // AccountBtn
            // 
            this.AccountBtn.Location = new System.Drawing.Point(301, 161);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(75, 23);
            this.AccountBtn.TabIndex = 12;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // LogInSecurityFormm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForgotPasswordBtn);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountBtn);
            this.Name = "LogInSecurityFormm";
            this.Text = "LogInSecurityFormm";
            this.Load += new System.EventHandler(this.LogInSecurityFormm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ForgotPasswordBtn;
        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AccountBtn;
    }
}