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

namespace MiniProject
{
    public partial class SupplierListForm : Form
    {
        public SupplierListForm()
        {
            InitializeComponent();
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            uscSearchSupplier.LoadSupplierData();
        }

        private void UscSearchSupplier_ButtonSearchSupplier(object sender, SupplierSearchControl.ButtonSearchSupplierEventArgs e)
        {
            var supplier = DB.Supplier.SearchAll(e.SupplierId);
            uscSupplierList.SetSupplierData(supplier);
        }
    }
}
