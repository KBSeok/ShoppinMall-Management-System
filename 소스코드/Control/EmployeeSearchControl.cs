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
    public partial class EmployeeSearch : UserControl
    {
        public EmployeeSearch()
        {
            InitializeComponent();
        }

        private void TxbSearchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Name = txbSearchName.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                OnEnterSearchEmpoyeeInfo(Name);
            }
        }

        #region EnterSearchEmpoyeeInfo event things for C# 3.0
        public event EventHandler<EnterSearchEmpoyeeInfoEventArgs> EnterSearchEmpoyeeInfo;

        protected virtual void OnEnterSearchEmpoyeeInfo(EnterSearchEmpoyeeInfoEventArgs e)
        {
            if (EnterSearchEmpoyeeInfo != null)
                EnterSearchEmpoyeeInfo(this, e);
        }

        private EnterSearchEmpoyeeInfoEventArgs OnEnterSearchEmpoyeeInfo(string name)
        {
            EnterSearchEmpoyeeInfoEventArgs args = new EnterSearchEmpoyeeInfoEventArgs(name);
            OnEnterSearchEmpoyeeInfo(args);

            return args;
        }

        private EnterSearchEmpoyeeInfoEventArgs OnEnterSearchEmpoyeeInfoForOut()
        {
            EnterSearchEmpoyeeInfoEventArgs args = new EnterSearchEmpoyeeInfoEventArgs();
            OnEnterSearchEmpoyeeInfo(args);

            return args;
        }

        public class EnterSearchEmpoyeeInfoEventArgs : EventArgs
        {
            public string Name { get; set; }

            public EnterSearchEmpoyeeInfoEventArgs()
            {
            }

            public EnterSearchEmpoyeeInfoEventArgs(string name)
            {
                Name = name;
            }
        }
        #endregion

    }
}

