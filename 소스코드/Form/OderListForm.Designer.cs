namespace Miniproject
{
    partial class OderListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uscOrderList = new Miniproject.OrderInfoListControl1();
            this.insertDeleteControl1 = new Miniproject.InsertDeleteControl();
            this.orderSearchControl1 = new Miniproject.OrderSearchControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문관리";
            // 
            // uscOrderList
            // 
            this.uscOrderList.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.uscOrderList.Location = new System.Drawing.Point(54, 107);
            this.uscOrderList.Name = "uscOrderList";
            this.uscOrderList.Size = new System.Drawing.Size(654, 307);
            this.uscOrderList.TabIndex = 4;
            // 
            // insertDeleteControl1
            // 
            this.insertDeleteControl1.Location = new System.Drawing.Point(555, 408);
            this.insertDeleteControl1.Name = "insertDeleteControl1";
            this.insertDeleteControl1.Size = new System.Drawing.Size(227, 42);
            this.insertDeleteControl1.TabIndex = 3;
            this.insertDeleteControl1.SearchBottonClicked += new System.EventHandler<Miniproject.InsertDeleteControl.SearchBottonClickedEventArgs>(this.InsertDeleteControl1_SearchBottonClicked);
            // 
            // orderSearchControl1
            // 
            this.orderSearchControl1.Location = new System.Drawing.Point(113, 13);
            this.orderSearchControl1.Name = "orderSearchControl1";
            this.orderSearchControl1.Size = new System.Drawing.Size(586, 95);
            this.orderSearchControl1.TabIndex = 5;
            this.orderSearchControl1.SearchButtonClicked += new System.EventHandler<Miniproject.OrderSearchControl.SearchButtonClickedEventArgs>(this.orderSearchControl1_SearchButtonClicked);
            // 
            // OderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.orderSearchControl1);
            this.Controls.Add(this.uscOrderList);
            this.Controls.Add(this.insertDeleteControl1);
            this.Controls.Add(this.label1);
            this.Name = "OderListForm";
            this.Text = "OderListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private InsertDeleteControl insertDeleteControl1;
        private OrderInfoListControl1 uscOrderList;
        private OrderSearchControl orderSearchControl1;
    }
}