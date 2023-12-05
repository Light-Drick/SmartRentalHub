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
    public partial class LogInSecurityFormm : Form
    {
        public event EventHandler GoBackToAccountForm;

        public LogInSecurityFormm()
        {
            InitializeComponent();
            AccountBtn.Click += AccountBtn_Click;
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            // Raise the event when the button is clicked
            GoBackToAccountForm?.Invoke(this, EventArgs.Empty);
        }

        private void LogInSecurityFormm_Load(object sender, EventArgs e)
        {

        }
    }
}
