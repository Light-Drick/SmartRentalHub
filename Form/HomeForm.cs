using SmartRentalHub.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRentalHub
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
            ProfilePicPanel.Hide();
           
        }

        //form in a form
        #region childform
        private Form currentChildForm;
        void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Hide();
            // Remove the previously added child form

            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            MapPanel.Controls.Add(currentChildForm);
            MapPanel.Tag = currentChildForm;

            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        #endregion

        private void HomeForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new MapForm());
            
        }


        //LOG OUT
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            // Clear user session
            MaintainUsername.Username = null;

            // Redirect to login form
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }

        #region form-in-a-form
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalinfoForm());
        }


        private void MaintenanceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MaintenanceForm());
        }


        private void AddSpaceRentalBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddSpaceForm());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ShowSearchFunction();
            OpenChildForm(new MapForm());
        }

        private void RentASpaceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RentASpaceForm());
        }


        private void FAQBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FaqForm());
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm());
        }

        private AccountForm accountForm;
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            HideSearchFunction();
            HidePopUpPanels();

            //go back to previous child panel form
            if (accountForm == null || accountForm.IsDisposed)
            {
                accountForm = new AccountForm();
            }

            accountForm = new AccountForm();
            accountForm.ShowPersonalDetails += (s1, a1) =>
            {
                var personalDetailsForm = new PersonalinfoForm();

                personalDetailsForm.GoBackToAccountForm += (s2, a2) =>
                {
                    // Go back to the AccountForm when the event is raised
                    OpenChildForm(accountForm);
                };

                // Open the PersonalDetailsForm when the event is raised
                OpenChildForm(personalDetailsForm);
            };

            //for different button/form/log in & security
            // Add this block of code
            accountForm.ShowLogInSecurity += (s1, a1) =>
            {
                var logInSecurityForm = new LogInSecurityFormm();

                logInSecurityForm.GoBackToAccountForm += (s2, a2) =>
                {
                    // Go back to the AccountForm when the event is raised
                    OpenChildForm(accountForm);
                };

                // Open the LogInSecurityForm when the event is raised
                OpenChildForm(logInSecurityForm);
            };

            OpenChildForm(accountForm);
        }

        private void HideSearchFunction()
        {
            SearchBtn.Visible = false;
            
            SearchTbx.Visible = false;
            label1.Visible= false;
        }
        private void ShowSearchFunction()
        {

            SearchBtn.Visible = true;
            
            SearchTbx.Visible = true;
        }
        private void HidePopUpPanels()
        {
            ProfilePicPanel.Visible = false;
            NotificationPanel.Visible = false;
            
        }


        private void MapBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MapForm());
        }

        #endregion


        private void Search()
        {
            //string street == 
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://maps.google.com/maps?q=");




                //webBrowser1.Navigate(queryaddress.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }





        #region -pop-up-panels-

        private void ProfilePicBtn_Click(object sender, EventArgs e)
        {
            if (this.ProfilePicPanel.Visible == false)
            {
                this.ProfilePicPanel.Visible = true;
                this.ProfilePicPanel.BringToFront();
                this.NotificationPanel.Hide();
            }

            else if (this.ProfilePicPanel.Visible == true)
            {
                this.ProfilePicPanel.Visible = false;
                this.ProfilePicPanel.SendToBack();

            }
        }


        private void NotificationBtn_Click(object sender, EventArgs e)
        {
            if (this.NotificationPanel.Visible == false)
            {
                this.NotificationPanel.Visible = true;
                this.NotificationPanel.BringToFront();
                this.ProfilePicPanel.Hide();
            }

            else if (this.NotificationPanel.Visible == true)
            {
                this.NotificationPanel.Visible = false;
                this.NotificationPanel.SendToBack();

            }
        }





        #endregion

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void MySpacesForRentBtn_Click(object sender, EventArgs e)
        {

        }



        /*private void sidebar_Timer_Tick(object sender, EventArgs e)
        {
            if (sideBarexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sideBarexpand = false;
                    sidebar_Timer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sideBarexpand = true;
                    sidebar_Timer.Stop();
                }

            }
        }*/

    }
}
