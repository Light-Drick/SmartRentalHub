namespace SmartRentalHub
{
    partial class AccountForm
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
            this.PersonalinfoBtn = new System.Windows.Forms.Button();
            this.LogInSecurityBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalinfoBtn
            // 
            this.PersonalinfoBtn.Location = new System.Drawing.Point(116, 117);
            this.PersonalinfoBtn.Name = "PersonalinfoBtn";
            this.PersonalinfoBtn.Size = new System.Drawing.Size(164, 74);
            this.PersonalinfoBtn.TabIndex = 0;
            this.PersonalinfoBtn.Text = "Personal Info -- update your personal and contact details";
            this.PersonalinfoBtn.UseVisualStyleBackColor = true;
            this.PersonalinfoBtn.Click += new System.EventHandler(this.PersonalinfoBtn_Click_1);
            // 
            // LogInSecurityBtn
            // 
            this.LogInSecurityBtn.Location = new System.Drawing.Point(335, 117);
            this.LogInSecurityBtn.Name = "LogInSecurityBtn";
            this.LogInSecurityBtn.Size = new System.Drawing.Size(164, 74);
            this.LogInSecurityBtn.TabIndex = 1;
            this.LogInSecurityBtn.Text = "Login And Security -- update your password";
            this.LogInSecurityBtn.UseVisualStyleBackColor = true;
            this.LogInSecurityBtn.Click += new System.EventHandler(this.LogInSecurityBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogInSecurityBtn);
            this.Controls.Add(this.PersonalinfoBtn);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PersonalinfoBtn;
        private System.Windows.Forms.Button LogInSecurityBtn;
        private System.Windows.Forms.Label label1;
    }
}