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
    public partial class StockListControl : UserControl
    {
        public StockListControl()
        {
            InitializeComponent();
        }
        public void SetDataProductData(List<Product> product)
        {
            dgvProductList.DataSource = product;
        }
    }
}
