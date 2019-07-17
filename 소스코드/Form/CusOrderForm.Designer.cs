namespace MiniProject
{
    partial class CusOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uscProductList = new MiniProject.CustomerOrder();
            this.SuspendLayout();
            // 
            // uscProductList
            // 
            this.uscProductList.Location = new System.Drawing.Point(12, 12);
            this.uscProductList.Name = "uscProductList";
            this.uscProductList.Size = new System.Drawing.Size(776, 426);
            this.uscProductList.TabIndex = 0;
            // 
            // CusOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uscProductList);
            this.Name = "CusOrderForm";
            this.Text = "CusOrder";
            this.Load += new System.EventHandler(this.CusOrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomerOrder uscProductList;
    }
}