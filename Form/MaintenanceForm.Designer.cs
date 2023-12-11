namespace SmartRentalHub
{
    partial class MaintenanceForm
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
            this.NameOfRenterTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneNumberTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PrioLevelCmbx = new System.Windows.Forms.ComboBox();
            this.DetailsrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitMaintenanceBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OwnerUserNameTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameOfRenterTbx
            // 
            this.NameOfRenterTbx.Location = new System.Drawing.Point(373, 222);
            this.NameOfRenterTbx.Name = "NameOfRenterTbx";
            this.NameOfRenterTbx.Size = new System.Drawing.Size(201, 22);
            this.NameOfRenterTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of Renter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number:";
            // 
            // PhoneNumberTbx
            // 
            this.PhoneNumberTbx.Location = new System.Drawing.Point(373, 250);
            this.PhoneNumberTbx.Name = "PhoneNumberTbx";
            this.PhoneNumberTbx.Size = new System.Drawing.Size(201, 22);
            this.PhoneNumberTbx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Request:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(373, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority Level:";
            // 
            // PrioLevelCmbx
            // 
            this.PrioLevelCmbx.FormattingEnabled = true;
            this.PrioLevelCmbx.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.PrioLevelCmbx.Location = new System.Drawing.Point(373, 306);
            this.PrioLevelCmbx.Name = "PrioLevelCmbx";
            this.PrioLevelCmbx.Size = new System.Drawing.Size(121, 24);
            this.PrioLevelCmbx.TabIndex = 8;
            // 
            // DetailsrichTextBox1
            // 
            this.DetailsrichTextBox1.Location = new System.Drawing.Point(373, 345);
            this.DetailsrichTextBox1.Name = "DetailsrichTextBox1";
            this.DetailsrichTextBox1.Size = new System.Drawing.Size(201, 96);
            this.DetailsrichTextBox1.TabIndex = 9;
            this.DetailsrichTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Write more details:";
            // 
            // SubmitMaintenanceBtn
            // 
            this.SubmitMaintenanceBtn.Location = new System.Drawing.Point(597, 436);
            this.SubmitMaintenanceBtn.Name = "SubmitMaintenanceBtn";
            this.SubmitMaintenanceBtn.Size = new System.Drawing.Size(170, 23);
            this.SubmitMaintenanceBtn.TabIndex = 11;
            this.SubmitMaintenanceBtn.Text = "Submit Maintenance Form";
            this.SubmitMaintenanceBtn.UseVisualStyleBackColor = true;
            this.SubmitMaintenanceBtn.Click += new System.EventHandler(this.SubmitMaintenanceBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "MAINTENANCE FORM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "username of Owner:";
            // 
            // OwnerUserNameTbx
            // 
            this.OwnerUserNameTbx.Location = new System.Drawing.Point(373, 194);
            this.OwnerUserNameTbx.Name = "OwnerUserNameTbx";
            this.OwnerUserNameTbx.Size = new System.Drawing.Size(201, 22);
            this.OwnerUserNameTbx.TabIndex = 13;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 532);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OwnerUserNameTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubmitMaintenanceBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetailsrichTextBox1);
            this.Controls.Add(this.PrioLevelCmbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumberTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOfRenterTbx);
            this.Name = "MaintenanceForm";
            this.Text = "MaintenanceForm";
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfRenterTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneNumberTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PrioLevelCmbx;
        private System.Windows.Forms.RichTextBox DetailsrichTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitMaintenanceBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OwnerUserNameTbx;
    }
}