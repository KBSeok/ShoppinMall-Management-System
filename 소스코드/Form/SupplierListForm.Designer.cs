namespace MiniProject
{
    partial class SupplierListForm
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
            this.uscSupplierList = new MiniProject.SupplierInfoControl();
            this.uscSearchSupplier = new MiniProject.SupplierSearchControl();
            this.SuspendLayout();
            // 
            // uscSupplierList
            // 
            this.uscSupplierList.Location = new System.Drawing.Point(64, 141);
            this.uscSupplierList.Name = "uscSupplierList";
            this.uscSupplierList.Size = new System.Drawing.Size(503, 317);
            this.uscSupplierList.TabIndex = 1;
            // 
            // uscSearchSupplier
            // 
            this.uscSearchSupplier.Location = new System.Drawing.Point(134, 28);
            this.uscSearchSupplier.Name = "uscSearchSupplier";
            this.uscSearchSupplier.Size = new System.Drawing.Size(341, 75);
            this.uscSearchSupplier.TabIndex = 0;
            this.uscSearchSupplier.ButtonSearchSupplier += new System.EventHandler<MiniProject.SupplierSearchControl.ButtonSearchSupplierEventArgs>(this.UscSearchSupplier_ButtonSearchSupplier);
            // 
            // SupplierListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uscSupplierList);
            this.Controls.Add(this.uscSearchSupplier);
            this.Name = "SupplierListForm";
            this.Text = "SupplierListForm";
            this.Load += new System.EventHandler(this.SupplierListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SupplierSearchControl uscSearchSupplier;
        private SupplierInfoControl uscSupplierList;
    }
}