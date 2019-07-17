
using Miniproject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject.Data
{
    class EmployeeData : EntityData<Employee>
    {
        public Employee GetByPK(int employeeId)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.FirstOrDefault(x => x.EmployeeID == employeeId);
            }
        }

        public List<string> GetEmployeeId()
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.Select(x => x.LoginID).ToList();
                
            }
        }

        public List<string> GetEmployeePW()
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                return context.Employees.Select(x => x.LoginPW).ToList();
            }
        }

        public List<Employee> SearchInfo(string Name)
        {
            using(ShoppingMallEntities context = new ShoppingMallEntities())
            {
                var query = from x in context.Employees
                            where x.Name == Name
                            select x;

                return query.ToList();
            }
        }

        public void LoginOK(string Id, string PW)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                if (GetEmployeeId().Contains(Id) == true)
                {
                    if (GetEmployeePW().Contains(PW) == true)
                    {
                        MainmenuForm form1 = new MainmenuForm();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 잘못입력되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    MessageBox.Show("아이디가 잘못되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
