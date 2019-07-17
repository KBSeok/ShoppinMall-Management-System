using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Register_Login : Form
    {
        public Register_Login()
        {
            InitializeComponent();
        }

        private void register_LoginControl1_ButtonCloseForm(object sender, Register_LoginControl.ButtonCloseFormEventArgs e)
        {
            this.Close();
        }
    }
}
