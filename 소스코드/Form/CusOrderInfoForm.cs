using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniProject.Data;

namespace Miniproject
{
    public partial class CusOrderInfoForm : Form
    {
        public CusOrderInfoForm()
        {
            InitializeComponent();
        }


        private void customerSearchControl1_OnButtonSearchCusInfo(object sender, CustomerSearchControl.OnButtonSearchCusInfoEventArgs e)
        {
            var customers = DB.Customer.SearchInfo(e.Id, e.Grade);
            uscOutputCusInfo.SetDataCustomerData(customers);
           
        }

        private void UscOutputCusInfo_DoubleClickSearchCusOrderInfo(object sender, CustomerInfoControl.DoubleClickSearchCusOrderInfoEventArgs e)
        {
            var orderdetail = DB.Orderdetail.SearchCusProductInfo(e.CustomerName);
            uscCusOrderInfo.SetDataCusOrderData(orderdetail);
        }
    }
}
