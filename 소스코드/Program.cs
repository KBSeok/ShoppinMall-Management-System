using MiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StockManagementForm());
            //Application.Run(new OderListForm());
            //Application.Run(new EmployeeInfoForm());
            //Application.Run(new Login_Form());
            //Application.Run(new SupplierListForm());
            Application.Run(new CusOrderForm());
        }
    }
}
