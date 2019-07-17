using MiniProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject
{
    public partial class StockManagementForm : Form
    {
        public StockManagementForm()
        {
            InitializeComponent();
        }

        private void UscSearchProduct_ButtonSearchProduct(object sender, StockSearchControl.ButtonSearchProductEventArgs e)
        {

            var product = DB.Product.SearchInfo(e.Name, e.ParentsName, e.SubName,
                e.Size, e.Color);
            uscProductInfo.SetDataProductData(product);
        }
    }
}
