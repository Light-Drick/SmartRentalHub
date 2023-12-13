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
    public partial class AccountForm : Form
    {
        public event EventHandler ShowPersonalDetails;
        public event EventHandler ShowLogInSecurity;
        public AccountForm()
        {
            InitializeComponent();
            PersonalinfoBtn.Click += PersonalinfoBtn_Click_1;
            LogInSecurityBtn.Click += LogInSecurityBtn_Click;
        }
        private void PersonalinfoBtn_Click_1(object sender, EventArgs e)
        {
            // Raise the event when the button is clicked

            ShowPersonalDetails?.Invoke(this, EventArgs.Empty);
        }


        private void AccountForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInSecurityBtn_Click(object sender, EventArgs e)
        {
            // Raise the event when the button is clicked
            ShowLogInSecurity?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
