namespace SmartRentalHub
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MapBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RoomDetailPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfilePicPanel = new System.Windows.Forms.Panel();
            this.AccountBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FAQBtn = new System.Windows.Forms.Button();
            this.AddSpaceRentalBtn = new System.Windows.Forms.Button();
            this.RentASpaceBtn = new System.Windows.Forms.Button();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.NotificationBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfilePicBtn = new System.Windows.Forms.Button();
            this.SearchTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.RoomDetailPanel.SuspendLayout();
            this.ProfilePicPanel.SuspendLayout();
            this.NotificationPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(7, 274);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(135, 32);
            this.LogOutBtn.TabIndex = 0;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MapBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RoomDetailPanel);
            this.panel1.Controls.Add(this.ProfilePicPanel);
            this.panel1.Controls.Add(this.NotificationPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 564);
            this.panel1.TabIndex = 2;
            // 
            // MapBtn
            // 
            this.MapBtn.Location = new System.Drawing.Point(509, 470);
            this.MapBtn.Name = "MapBtn";
            this.MapBtn.Size = new System.Drawing.Size(135, 32);
            this.MapBtn.TabIndex = 13;
            this.MapBtn.Text = "Show List of Rooms";
            this.MapBtn.UseVisualStyleBackColor = true;
            this.MapBtn.Click += new System.EventHandler(this.MapBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Google map here";
            // 
            // RoomDetailPanel
            // 
            this.RoomDetailPanel.Controls.Add(this.label5);
            this.RoomDetailPanel.Location = new System.Drawing.Point(3, 73);
            this.RoomDetailPanel.Name = "RoomDetailPanel";
            this.RoomDetailPanel.Size = new System.Drawing.Size(421, 479);
            this.RoomDetailPanel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Room details here";
            // 
            // ProfilePicPanel
            // 
            this.ProfilePicPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicPanel.Controls.Add(this.AccountBtn);
            this.ProfilePicPanel.Controls.Add(this.SettingsBtn);
            this.ProfilePicPanel.Controls.Add(this.button1);
            this.ProfilePicPanel.Controls.Add(this.FAQBtn);
            this.ProfilePicPanel.Controls.Add(this.AddSpaceRentalBtn);
            this.ProfilePicPanel.Controls.Add(this.RentASpaceBtn);
            this.ProfilePicPanel.Controls.Add(this.LogOutBtn);
            this.ProfilePicPanel.Location = new System.Drawing.Point(1049, 73);
            this.ProfilePicPanel.Name = "ProfilePicPanel";
            this.ProfilePicPanel.Size = new System.Drawing.Size(147, 311);
            this.ProfilePicPanel.TabIndex = 9;
            // 
            // AccountBtn
            // 
            this.AccountBtn.Location = new System.Drawing.Point(7, 157);
            this.AccountBtn.Name = "AccountBtn";
            this.AccountBtn.Size = new System.Drawing.Size(135, 31);
            this.AccountBtn.TabIndex = 8;
            this.AccountBtn.Text = "Account";
            this.AccountBtn.UseVisualStyleBackColor = true;
            this.AccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(7, 201);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(135, 31);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "My Spaces for rent";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FAQBtn
            // 
            this.FAQBtn.Location = new System.Drawing.Point(7, 238);
            this.FAQBtn.Name = "FAQBtn";
            this.FAQBtn.Size = new System.Drawing.Size(135, 31);
            this.FAQBtn.TabIndex = 2;
            this.FAQBtn.Text = "FAQ Section";
            this.FAQBtn.UseVisualStyleBackColor = true;
            this.FAQBtn.Click += new System.EventHandler(this.FAQBtn_Click);
            // 
            // AddSpaceRentalBtn
            // 
            this.AddSpaceRentalBtn.Location = new System.Drawing.Point(7, 3);
            this.AddSpaceRentalBtn.Name = "AddSpaceRentalBtn";
            this.AddSpaceRentalBtn.Size = new System.Drawing.Size(131, 31);
            this.AddSpaceRentalBtn.TabIndex = 3;
            this.AddSpaceRentalBtn.Text = "Add Space";
            this.AddSpaceRentalBtn.UseVisualStyleBackColor = true;
            this.AddSpaceRentalBtn.Click += new System.EventHandler(this.AddSpaceRentalBtn_Click);
            // 
            // RentASpaceBtn
            // 
            this.RentASpaceBtn.Location = new System.Drawing.Point(7, 40);
            this.RentASpaceBtn.Name = "RentASpaceBtn";
            this.RentASpaceBtn.Size = new System.Drawing.Size(131, 31);
            this.RentASpaceBtn.TabIndex = 4;
            this.RentASpaceBtn.Text = "Rent A Space";
            this.RentASpaceBtn.UseVisualStyleBackColor = true;
            this.RentASpaceBtn.Click += new System.EventHandler(this.RentASpaceBtn_Click);
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotificationPanel.Controls.Add(this.label2);
            this.NotificationPanel.Location = new System.Drawing.Point(779, 69);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(297, 218);
            this.NotificationPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notifications here";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.NotificationBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ProfilePicBtn);
            this.panel2.Controls.Add(this.SearchTbx);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 67);
            this.panel2.TabIndex = 8;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(769, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(98, 31);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // NotificationBtn
            // 
            this.NotificationBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NotificationBtn.BackgroundImage")));
            this.NotificationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NotificationBtn.Location = new System.Drawing.Point(1069, 6);
            this.NotificationBtn.Name = "NotificationBtn";
            this.NotificationBtn.Size = new System.Drawing.Size(62, 57);
            this.NotificationBtn.TabIndex = 11;
            this.NotificationBtn.UseVisualStyleBackColor = true;
            this.NotificationBtn.Click += new System.EventHandler(this.NotificationBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "SMARTRENTAL HUB";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProfilePicBtn
            // 
            this.ProfilePicBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfilePicBtn.BackgroundImage")));
            this.ProfilePicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfilePicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfilePicBtn.Location = new System.Drawing.Point(1137, 7);
            this.ProfilePicBtn.Name = "ProfilePicBtn";
            this.ProfilePicBtn.Size = new System.Drawing.Size(59, 55);
            this.ProfilePicBtn.TabIndex = 10;
            this.ProfilePicBtn.UseVisualStyleBackColor = true;
            this.ProfilePicBtn.Click += new System.EventHandler(this.ProfilePicBtn_Click);
            // 
            // SearchTbx
            // 
            this.SearchTbx.Location = new System.Drawing.Point(431, 23);
            this.SearchTbx.Name = "SearchTbx";
            this.SearchTbx.Size = new System.Drawing.Size(332, 22);
            this.SearchTbx.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 564);
            this.Controls.Add(this.panel1);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RoomDetailPanel.ResumeLayout(false);
            this.RoomDetailPanel.PerformLayout();
            this.ProfilePicPanel.ResumeLayout(false);
            this.NotificationPanel.ResumeLayout(false);
            this.NotificationPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddSpaceRentalBtn;
        private System.Windows.Forms.Button RentASpaceBtn;
        private System.Windows.Forms.TextBox SearchTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ProfilePicPanel;
        private System.Windows.Forms.Button ProfilePicBtn;
        private System.Windows.Forms.Button NotificationBtn;
        private System.Windows.Forms.Panel NotificationPanel;
        private System.Windows.Forms.Button FAQBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel RoomDetailPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AccountBtn;
        private System.Windows.Forms.Button MapBtn;
    }
}