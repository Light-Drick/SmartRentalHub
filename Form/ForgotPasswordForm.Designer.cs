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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.ActCodeTbx = new System.Windows.Forms.TextBox();
            this.EnterPassLabel = new System.Windows.Forms.Label();
            this.EnterNewPassTbx = new System.Windows.Forms.TextBox();
            this.RenterNewPassLabel = new System.Windows.Forms.Label();
            this.ReEnterNewPassTbx = new System.Windows.Forms.TextBox();
            this.ResetPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTbx
            // 
            this.EmailTbx.Location = new System.Drawing.Point(311, 139);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(226, 22);
            this.EmailTbx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(311, 186);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(115, 30);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(38, 35);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(73, 37);
            this.ReturnBtn.TabIndex = 5;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(199, 249);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(104, 16);
            this.CodeLabel.TabIndex = 6;
            this.CodeLabel.Text = "Activation Code:";
            // 
            // ActCodeTbx
            // 
            this.ActCodeTbx.Location = new System.Drawing.Point(311, 243);
            this.ActCodeTbx.Name = "ActCodeTbx";
            this.ActCodeTbx.Size = new System.Drawing.Size(226, 22);
            this.ActCodeTbx.TabIndex = 7;
            // 
            // EnterPassLabel
            // 
            this.EnterPassLabel.AutoSize = true;
            this.EnterPassLabel.Location = new System.Drawing.Point(169, 294);
            this.EnterPassLabel.Name = "EnterPassLabel";
            this.EnterPassLabel.Size = new System.Drawing.Size(134, 16);
            this.EnterPassLabel.TabIndex = 8;
            this.EnterPassLabel.Text = "Enter New Password:";
            // 
            // EnterNewPassTbx
            // 
            this.EnterNewPassTbx.Location = new System.Drawing.Point(311, 291);
            this.EnterNewPassTbx.Name = "EnterNewPassTbx";
            this.EnterNewPassTbx.Size = new System.Drawing.Size(226, 22);
            this.EnterNewPassTbx.TabIndex = 9;
            // 
            // RenterNewPassLabel
            // 
            this.RenterNewPassLabel.AutoSize = true;
            this.RenterNewPassLabel.Location = new System.Drawing.Point(148, 336);
            this.RenterNewPassLabel.Name = "RenterNewPassLabel";
            this.RenterNewPassLabel.Size = new System.Drawing.Size(155, 16);
            this.RenterNewPassLabel.TabIndex = 10;
            this.RenterNewPassLabel.Text = "Re-enter New Password:";
            // 
            // ReEnterNewPassTbx
            // 
            this.ReEnterNewPassTbx.Location = new System.Drawing.Point(311, 333);
            this.ReEnterNewPassTbx.Name = "ReEnterNewPassTbx";
            this.ReEnterNewPassTbx.Size = new System.Drawing.Size(226, 22);
            this.ReEnterNewPassTbx.TabIndex = 11;
            this.ReEnterNewPassTbx.UseSystemPasswordChar = true;
            // 
            // ResetPassBtn
            // 
            this.ResetPassBtn.Location = new System.Drawing.Point(311, 378);
            this.ResetPassBtn.Name = "ResetPassBtn";
            this.ResetPassBtn.Size = new System.Drawing.Size(115, 30);
            this.ResetPassBtn.TabIndex = 12;
            this.ResetPassBtn.Text = "Reset";
            this.ResetPassBtn.UseVisualStyleBackColor = true;
            this.ResetPassBtn.Click += new System.EventHandler(this.ResetPassBtn_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 569);
            this.Controls.Add(this.ResetPassBtn);
            this.Controls.Add(this.ReEnterNewPassTbx);
            this.Controls.Add(this.RenterNewPassLabel);
            this.Controls.Add(this.EnterNewPassTbx);
            this.Controls.Add(this.EnterPassLabel);
            this.Controls.Add(this.ActCodeTbx);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.SubmitBtn);
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
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox ActCodeTbx;
        private System.Windows.Forms.Label EnterPassLabel;
        private System.Windows.Forms.TextBox EnterNewPassTbx;
        private System.Windows.Forms.Label RenterNewPassLabel;
        private System.Windows.Forms.TextBox ReEnterNewPassTbx;
        private System.Windows.Forms.Button ResetPassBtn;
    }
}