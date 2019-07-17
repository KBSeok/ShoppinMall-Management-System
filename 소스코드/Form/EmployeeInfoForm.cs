using MiniProject.Data;
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
    public partial class EmployeeInfoForm : Form
    {
        public EmployeeInfoForm()
        {
            InitializeComponent();
        }

        private void EmployeeSearch1_EnterSearchEmpoyeeInfo(object sender, EmployeeSearch.EnterSearchEmpoyeeInfoEventArgs e)
        {
            var emplyees = DB.Employee.SearchInfo(e.Name);
            uscEmployeeInfo.SetDataEmployeeData(emplyees);
        }
    }
}
