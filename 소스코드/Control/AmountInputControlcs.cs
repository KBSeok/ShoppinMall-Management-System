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
    public partial class AmountInputControlcs : UserControl
    {
        public AmountInputControlcs()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CustomerOrder.amount = int.Parse(txbAmount.Text);

            OnCloseForm();

        }
        #region CloseForm event things for C# 3.0
        public event EventHandler<CloseFormEventArgs> CloseForm;

        protected virtual void OnCloseForm(CloseFormEventArgs e)
        {
            if (CloseForm != null)
                CloseForm(this, e);
        }

        private CloseFormEventArgs OnCloseForm()
        {
            CloseFormEventArgs args = new CloseFormEventArgs();
            OnCloseForm(args);

            return args;
        }

        /*private CloseFormEventArgs OnCloseFormForOut()
        {
            CloseFormEventArgs args = new CloseFormEventArgs();
            OnCloseForm(args);

            return args;
        }*/

        public class CloseFormEventArgs : EventArgs
        {


            /*public CloseFormEventArgs()
            {
            }

            public CloseFormEventArgs()
            {

            }*/
        }
        #endregion
    }
}
