using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class OrderSearchControl : UserControl
    {
        public OrderSearchControl()
        {
            InitializeComponent();
        }

        private void ChbOrderNumber_CheckedChanged(object sender, EventArgs e)
        {
            txbOrderNumber.Enabled = chbOrderNumber.Checked;
        }

        private void ChbCusId_CheckedChanged(object sender, EventArgs e)
        {
            txbCusId.Enabled = chbCusId.Checked;
        }
        

        private void BtnOrderSearch_Click(object sender, EventArgs e)
        {

            string orderId = txbOrderNumber.Text;
            string cusId = txbCusId.Text;

            OnSearchButtonClicked(orderId,cusId);
        }
        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(string orderId, string cusId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(orderId, cusId);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string OrderId { get; set; }
            public string CusId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(string orderId, string cusId)
            {
                OrderId = orderId;
                CusId = cusId;
            }
        }
        #endregion

    }
}
    