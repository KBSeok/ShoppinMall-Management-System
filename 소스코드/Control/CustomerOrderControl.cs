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
    public partial class CustomerOrder : UserControl
    {
        public static int amount;
        public static object productInfo;
        public CustomerOrder()
        {
            InitializeComponent();
        }

        public void LoadProductData()
        {
            DB.Product.DeliveredProduct();
            dgvProduct.DataSource = DB.Product.GetProductInfo();

        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result =
                MessageBox.Show("주문하시겠습니까?", "알림", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                productInfo = dgvProduct.CurrentRow.DataBoundItem;
                AmountInputForm amountInputForm = new AmountInputForm();
                amountInputForm.ShowDialog();
                
                DB.Order.ProductOrder(amount, dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                Cells[0].Value.ToString(), dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                Cells[2].Value.ToString(), dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                Cells[1].Value.ToString(), productInfo);


                int productId = DB.Product.GetByPK(dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                    Cells[0].Value.ToString(), dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                    Cells[1].Value.ToString(), dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                    Cells[2].Value.ToString());

                int stockAmount = int.Parse(dgvProduct.Rows[dgvProduct.CurrentCellAddress.Y].
                   Cells[4].Value.ToString())- amount;

                if (stockAmount <= 5)
                {
                    DB.ProdutOrders.ProductOrdering(productId);
                }

                dgvProduct.DataSource = DB.Product.GetProductInfo();
            }
        }
    }
}
