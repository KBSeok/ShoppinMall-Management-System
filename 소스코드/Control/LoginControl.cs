using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miniproject;
using MiniProject.Data;

namespace MiniProject
{
    public partial class LoginControl : UserControl
    {
        public string Id;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register_Login frm2 = new Register_Login();
            frm2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Id = txbId.Text;
            DB.Employee.LoginOK(txbId.Text, txbPassword.Text);
        }
    }
}
