namespace SmartRentalHub
{
    partial class ForgotPasswordForm
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
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ForgotPasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTbx
            // 
            this.EmailTbx.Location = new System.Drawing.Point(278, 139);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(100, 22);
            this.EmailTbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(278, 167);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(115, 30);
            this.ForgotPasswordBtn.TabIndex = 4;
            this.ForgotPasswordBtn.Text = "forgot password";
            this.ForgotPasswordBtn.UseVisualStyleBackColor = true;
            this.ForgotPasswordBtn.Click += new System.EventHandler(this.ForgotPasswordBtn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 569);
            this.Controls.Add(this.ForgotPasswordBtn);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.label2);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ForgotPasswordBtn;
    }
}