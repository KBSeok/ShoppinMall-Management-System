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

namespace MiniProject
{
    public partial class Register_LoginControl : UserControl
    {
        public Register_LoginControl()
        {
            InitializeComponent();
        }

        #region ButtonCloseForm event things for C# 3.0
        public event EventHandler<ButtonCloseFormEventArgs> ButtonCloseForm;

        protected virtual void OnButtonCloseForm(ButtonCloseFormEventArgs e)
        {
            if (ButtonCloseForm != null)
                ButtonCloseForm(this, e);
        }

        private ButtonCloseFormEventArgs OnButtonCloseForm()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }

        /*private ButtonCloseFormEventArgs OnButtonCloseFormForOut()
        {
            ButtonCloseFormEventArgs args = new ButtonCloseFormEventArgs();
            OnButtonCloseForm(args);

            return args;
        }*/

        public class ButtonCloseFormEventArgs : EventArgs
        {


            /*public ButtonCloseFormEventArgs()
            {
            }

            public ButtonCloseFormEventArgs()
            {

            }*/
        }

        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnButtonCloseForm();
        }

        
        private void BtnIdCheck_Click(object sender, EventArgs e)
        {
            using (ShoppingMallEntities context = new ShoppingMallEntities())
            {
                string Id = txbId.Text;
                if (context.Employees.Count(x => x.LoginID == Id) == 1)
                {
                    MessageBox.Show("등록된 아이디입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                if (context.Employees.Count(x => x.LoginID == Id) == 0)
                {
                    MessageBox.Show("등록가능한 아이디입니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txbPW.Text != txbPWCheck.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            else
            {
                int employeeId = Convert.ToInt32(txbNumber.Text);

                Employee employee = DB.Employee.GetByPK(employeeId);

                employee.LoginID = txbId.Text;
                employee.LoginPW = txbPW.Text;

                DB.Employee.Update(employee);
                
            }
            MessageBox.Show("변경이 완료되었습니다.", "알림", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
