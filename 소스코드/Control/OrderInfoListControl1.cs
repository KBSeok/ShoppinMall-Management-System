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
using MiniProject.Data;




namespace Miniproject
{
    public partial class OrderInfoListControl1 : UserControl
    {
        
        public OrderInfoListControl1()
        {
            InitializeComponent();
            
        }

        public void SetDataOrder(List<Order_Detail> orderdetail)
        {
            dgvOrderList.DataSource = orderdetail;
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertDeleteControl.orderIdData =
                Convert.ToInt32(dgvOrderList.Rows[dgvOrderList.CurrentCellAddress.Y].
                Cells[0].Value);

            InsertDeleteControl.productIdData =
                Convert.ToInt32(dgvOrderList.Rows[dgvOrderList.CurrentCellAddress.Y].
                Cells[4].Value);

            InsertDeleteControl.updataOrderDetailData =
                dgvOrderList.CurrentRow.DataBoundItem;

            
        }
    }
}
