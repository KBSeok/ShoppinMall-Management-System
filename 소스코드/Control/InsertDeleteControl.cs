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
using Miniproject;
using MiniProject;

namespace Miniproject
{
    public partial class InsertDeleteControl : UserControl
    {
        public static int orderIdData;
        public static int productIdData;
        public static object updataOrderDetailData;
        public static string orderNumber;
        public static string cusId;

        public InsertDeleteControl()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            
            Order_Detail order_Detail = 
                updataOrderDetailData as Order_Detail;

            if (order_Detail == null)
                return;

            DialogResult result = MessageBox.Show("변경 하기겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if(result == DialogResult.OK) { 
                DB.Orderdetail.Update(order_Detail);
                OnSearchBottonClicked(orderNumber, cusId);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Order_Detail order_Detail = 
                DB.Orderdetail.GetPK(orderIdData, productIdData);

            DialogResult result = MessageBox.Show("삭제 하시겠습니까?", "알림",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if(result == DialogResult.OK) { 
                DB.Orderdetail.Delete(order_Detail);
                OnSearchBottonClicked(orderNumber, cusId);
            }
        }
        #region SearchBottonClicked event things for C# 3.0
        public event EventHandler<SearchBottonClickedEventArgs> SearchBottonClicked;

        protected virtual void OnSearchBottonClicked(SearchBottonClickedEventArgs e)
        {
            if (SearchBottonClicked != null)
                SearchBottonClicked(this, e);
        }

        private SearchBottonClickedEventArgs OnSearchBottonClicked(string txbOrderNumber, string txbCusId)
        {
            SearchBottonClickedEventArgs args = new SearchBottonClickedEventArgs(txbOrderNumber, txbCusId);
            OnSearchBottonClicked(args);

            return args;
        }

        private SearchBottonClickedEventArgs OnSearchBottonClickedForOut()
        {
            SearchBottonClickedEventArgs args = new SearchBottonClickedEventArgs();
            OnSearchBottonClicked(args);

            return args;
        }

        public class SearchBottonClickedEventArgs : EventArgs
        {
            public string TxbOrderNumber { get; set; }
            public string TxbCusId { get; set; }

            public SearchBottonClickedEventArgs()
            {
            }

            public SearchBottonClickedEventArgs(string txbOrderNumber, string txbCusId)
            {
                TxbOrderNumber = txbOrderNumber;
                TxbCusId = txbCusId;
            }
        }
        #endregion


    }
}
