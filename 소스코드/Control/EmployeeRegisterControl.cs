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
    public partial class RegisterEmployeeControl : UserControl
    {
        public RegisterEmployeeControl()
        {
            InitializeComponent();
            string[] rank = { "Staff", "Manager", "CEO"};
            cbbLevel.Items.AddRange(rank);
            string[] gender = { "male", "female" };
            cbbGender.Items.AddRange(gender);
        }
        
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                Employee employee = new Employee();

                if (txbNumber.Text == "")
                {
                    MessageBox.Show("다시 입력하세요.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                employee.EmployeeID = Convert.ToInt32(txbNumber.Text);

                
                if (context.Employees.Count(x => x.EmployeeID == employee.EmployeeID) > 0)
                {
                    MessageBox.Show("등록되어 있는 사원번호입니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                employee.Name = txbName.Text;
                employee.rank = cbbLevel.Text;
                employee.Gender = cbbGender.Text;
                employee.BirthDate = txbBirth.Text;
                employee.HireDate = DateTime.Now.ToString("yyyy-mm-dd");
                employee.Address = txbAddress.Text;
                employee.HomePhone = txbNumber.Text;

                DB.Employee.Insert(employee);
            }
        }
    }
}
