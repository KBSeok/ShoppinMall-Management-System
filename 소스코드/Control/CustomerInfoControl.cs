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
    public partial class CustomerInfoControl : UserControl
    {
        public CustomerInfoControl()
        {
            InitializeComponent();
        }
        public void SetDataCustomerData(List<Customer> customer)
        {
            dgvCusInfo.DataSource = customer;
        }

        #region DoubleClickSearchCusOrderInfo event things for C# 3.0
        public event EventHandler<DoubleClickSearchCusOrderInfoEventArgs> DoubleClickSearchCusOrderInfo;

        protected virtual void OnDoubleClickSearchCusOrderInfo(DoubleClickSearchCusOrderInfoEventArgs e)
        {
            if (DoubleClickSearchCusOrderInfo != null)
                DoubleClickSearchCusOrderInfo(this, e);
        }

        private DoubleClickSearchCusOrderInfoEventArgs OnDoubleClickSearchCusOrderInfo(string customerName)
        {
            DoubleClickSearchCusOrderInfoEventArgs args = new DoubleClickSearchCusOrderInfoEventArgs(customerName);
            OnDoubleClickSearchCusOrderInfo(args);

            return args;
        }

        private DoubleClickSearchCusOrderInfoEventArgs OnDoubleClickSearchCusOrderInfoForOut()
        {
            DoubleClickSearchCusOrderInfoEventArgs args = new DoubleClickSearchCusOrderInfoEventArgs();
            OnDoubleClickSearchCusOrderInfo(args);

            return args;
        }

        public class DoubleClickSearchCusOrderInfoEventArgs : EventArgs
        {
            public string CustomerName { get; set; }

            public DoubleClickSearchCusOrderInfoEventArgs()
            {
            }

            public DoubleClickSearchCusOrderInfoEventArgs(string customerName)
            {
                CustomerName = customerName;
            }
        }
        #endregion

        private void DgvCusInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnDoubleClickSearchCusOrderInfo
                (dgvCusInfo.Rows[dgvCusInfo.CurrentCellAddress.Y].
                Cells[0].Value.ToString());
        }
    }
}
