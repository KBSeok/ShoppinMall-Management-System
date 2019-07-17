using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class SupplierInfoControl : UserControl
    {
        public SupplierInfoControl()
        {
            InitializeComponent();
        }
        
        public void SetSupplierData(List<Supplier> supplier)
        {
            dgvSupplier.DataSource = supplier;
        }
    }
}
