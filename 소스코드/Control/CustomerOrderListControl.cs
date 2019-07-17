using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject;

namespace Miniproject
{
    public partial class CustomerOrderListControl : UserControl
    {
        public CustomerOrderListControl()
        {
            InitializeComponent();
        }
        public void SetDataCusOrderData(List<Order_Detail> oderdetail)
        {
            dgvCusOrderInfo.DataSource = oderdetail;
        }

        
    }
}
