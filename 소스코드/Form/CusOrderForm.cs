﻿using System;
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
    public partial class CusOrderForm : Form
    {
        public CusOrderForm()
        {
            InitializeComponent();
        }

        private void CusOrderForm_Load(object sender, EventArgs e)
        {
            uscProductList.LoadProductData();
            
        }

        
    }
}
