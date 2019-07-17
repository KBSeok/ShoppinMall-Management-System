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
    public partial class SupplierSearchControl : UserControl
    {
        public SupplierSearchControl()
        {
            InitializeComponent();
        }
        public void LoadSupplierData()
        {
            cbbSupplier.DataSource = DB.Supplier.GetAll();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int? SupplierId = (int?)cbbSupplier.SelectedValue;

            OnButtonSearchSupplier(SupplierId);
        }

        #region ButtonSearchSupplier event things for C# 3.0
        public event EventHandler<ButtonSearchSupplierEventArgs> ButtonSearchSupplier;

        protected virtual void OnButtonSearchSupplier(ButtonSearchSupplierEventArgs e)
        {
            if (ButtonSearchSupplier != null)
                ButtonSearchSupplier(this, e);
        }

        private ButtonSearchSupplierEventArgs OnButtonSearchSupplier(int? supplierId)
        {
            ButtonSearchSupplierEventArgs args = new ButtonSearchSupplierEventArgs(supplierId);
            OnButtonSearchSupplier(args);

            return args;
        }

        private ButtonSearchSupplierEventArgs OnButtonSearchSupplierForOut()
        {
            ButtonSearchSupplierEventArgs args = new ButtonSearchSupplierEventArgs();
            OnButtonSearchSupplier(args);

            return args;
        }

        public class ButtonSearchSupplierEventArgs : EventArgs
        {
            public int? SupplierId { get; set; }

            public ButtonSearchSupplierEventArgs()
            {
            }

            public ButtonSearchSupplierEventArgs(int? supplierId)
            {
                SupplierId = supplierId;
            }
        }
        #endregion
    }
}
