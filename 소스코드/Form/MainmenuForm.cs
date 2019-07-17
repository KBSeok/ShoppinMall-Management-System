//using MiniProject.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class MainmenuForm : Form
    {
        public MainmenuForm()
        {
            InitializeComponent();
        }


        private void btninventoryM_Click(object sender, EventArgs e)
        {
            StockManagementForm frm1 = new StockManagementForm();
            frm1.Show();
            
        }

        private void BtnOrderM_Click(object sender, EventArgs e)
        {
            OderListForm frm2 = new OderListForm();
            frm2.Show();
            
        }

        private void BtnMemberM_Click(object sender, EventArgs e)
        {
            CusOrderInfoForm frm3 = new CusOrderInfoForm();
            frm3.Show();
            
        }

        private void BtnStaffM_Click(object sender, EventArgs e)
        {
            EmployeeInfoForm frm4 = new EmployeeInfoForm();
            frm4.Show();
            //EmployeeControl frm4 = new EmployeeControl();
            //frm4.Show();
        }
    }
}
