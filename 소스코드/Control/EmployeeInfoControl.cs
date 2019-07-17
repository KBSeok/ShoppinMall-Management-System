using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.Data;
using MiniProject;

namespace Miniproject
{
    public partial class EmployeeInfoControl : UserControl
    {
        public EmployeeInfoControl()
        {
            InitializeComponent();
        }

        public void SetDataEmployeeData(List<Employee> employee)
        {
            dgvEmployeeInfo.DataSource = employee;
        }
    }
}
