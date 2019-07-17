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

namespace Miniproject
{
    public partial class StockSearchControl : UserControl
    {
        public StockSearchControl()
        {
            InitializeComponent();
            cbbHCategory.Enabled = false;
            cbbLCategory.Enabled = false;
            cbbColor.Enabled = false;
            cbbSize.Enabled = false;
            chbSubCategory.Enabled = false;
            chbColor.Enabled = false;
            chbSize.Enabled = false;
        }
        public void LoadSubCategoryName()
        {
            SubCategoryData subcategorydata = new SubCategoryData();
            List<string> subnames = subcategorydata.GetSubName(cbbHCategory.Text);
            foreach (var subname in subnames)
                cbbLCategory.Items.Add(subname);
        }

        public void LoadColorName()
        {
            ProductData product = new ProductData();
            List<string> colors = product.GetColor(cbbHCategory.Text, cbbLCategory.Text);
            foreach (var color in colors)
                cbbColor.Items.Add(color);
        }

        public void LoadSizeName()
        {
            ProductData product = new ProductData();
            List<string> sizes = product.GetSize(cbbHCategory.Text, cbbLCategory.Text, cbbColor.Text);
            foreach (var size in sizes)
                cbbSize.Items.Add(size);
        }
        public void LoadParentsCategoryName()
        {
            ParentsCategoryData parentscategorydata = new ParentsCategoryData();
            List<string> parentsnames = parentscategorydata.GetParentsCategoryName();
            foreach (var parentsname in parentsnames)
                cbbHCategory.Items.Add(parentsname);
        }

        private void chbParentsCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbParentsCategory.Checked == true)
            {
                cbbHCategory.Enabled = false;
                cbbLCategory.Enabled = false;
                cbbColor.Enabled = false;
                cbbSize.Enabled = false;

                chbSubCategory.Enabled = false;
                chbColor.Enabled = false;
                chbSize.Enabled = false;
                chbSubCategory.Checked = true;
                chbColor.Checked = true;
                chbSize.Checked = true;

                cbbHCategory.Items.Clear();
                cbbSize.Items.Clear();
                cbbColor.Items.Clear();
                cbbLCategory.Items.Clear();
            }

            else
            {
                cbbHCategory.Enabled = true;
                chbSubCategory.Enabled = true;

                LoadParentsCategoryName();
            }
        }

        private void chbSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSubCategory.Checked == true)
            {
                cbbLCategory.Enabled = false;

                chbColor.Enabled = false;
                chbColor.Checked = true;
                chbSize.Enabled = false;
                chbSize.Checked = true;

                cbbLCategory.Items.Clear();
                cbbSize.Items.Clear();
                cbbColor.Items.Clear();
            }
            else
            {
                cbbLCategory.Enabled = true;
                chbColor.Enabled = true;

                LoadSubCategoryName();
            }
        }

        private void chbColor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbColor.Checked == true)
            {
                cbbColor.Enabled = false;
                cbbSize.Enabled = false;

                chbSize.Checked = false;
                chbSize.Enabled = false;

                cbbSize.Items.Clear();
                cbbColor.Items.Clear();
            }
            else
            {
                cbbColor.Enabled = true;
                cbbSize.Enabled = false;

                chbSize.Checked = true;
                chbSize.Enabled = true;

                LoadColorName();
            }
        }

        private void chbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSize.Checked == true)
            {
                cbbSize.Enabled = false;
                cbbSize.Items.Clear();
            }
            else
            {
                cbbSize.Enabled = true;

                LoadSizeName();
            }
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {
            string Name = txbName.Text;
            string ParentsCategory = cbbHCategory.Text;
            string SubCategory = cbbLCategory.Text;
            string Color = cbbColor.Text;
            string Size = cbbSize.Text;

            OnButtonSearchProduct(Name, ParentsCategory, SubCategory, Size, Color);
        }

        #region ButtonSearchProduct event things for C# 3.0
        public event EventHandler<ButtonSearchProductEventArgs> ButtonSearchProduct;

        protected virtual void OnButtonSearchProduct(ButtonSearchProductEventArgs e)
        {
            if (ButtonSearchProduct != null)
                ButtonSearchProduct(this, e);
        }

        private ButtonSearchProductEventArgs OnButtonSearchProduct(string name, string parentsName, string subName, string size, string color)
        {
            ButtonSearchProductEventArgs args = new ButtonSearchProductEventArgs(name, parentsName, subName, size, color);
            OnButtonSearchProduct(args);

            return args;
        }

        private ButtonSearchProductEventArgs OnButtonSearchProductForOut()
        {
            ButtonSearchProductEventArgs args = new ButtonSearchProductEventArgs();
            OnButtonSearchProduct(args);

            return args;
        }

        public class ButtonSearchProductEventArgs : EventArgs
        {
            public string Name { get; set; }
            public string ParentsName { get; set; }
            public string SubName { get; set; }
            public string Size { get; set; }
            public string Color { get; set; }

            public ButtonSearchProductEventArgs()
            {
            }

            public ButtonSearchProductEventArgs(string name, string parentsName, string subName, string size, string color)
            {
                Name = name;
                ParentsName = parentsName;
                SubName = subName;
                Size = size;
                Color = color;
            }
        }

        #endregion

        private void cbbHCategory_DropDownClosed(object sender, EventArgs e)
        {
            LoadSubCategoryName();
        }

        private void cbbLCategory_DropDownClosed(object sender, EventArgs e)
        {
            LoadColorName();
        }

        private void cbbColor_DropDownClosed(object sender, EventArgs e)
        {
            LoadSizeName();
        }
    }
}
