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
    public partial class AmountInputForm : Form
    {
        public AmountInputForm()
        {
            InitializeComponent();
        }

        private void amountInputControlcs1_CloseForm(object sender, AmountInputControlcs.CloseFormEventArgs e)
        {
            this.Close();
        }
    }
}
