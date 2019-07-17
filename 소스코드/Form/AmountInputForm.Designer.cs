namespace MiniProject
{
    partial class AmountInputForm
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
            this.amountInputControlcs1 = new MiniProject.AmountInputControlcs();
            this.SuspendLayout();
            // 
            // amountInputControlcs1
            // 
            this.amountInputControlcs1.Location = new System.Drawing.Point(12, 23);
            this.amountInputControlcs1.Name = "amountInputControlcs1";
            this.amountInputControlcs1.Size = new System.Drawing.Size(305, 67);
            this.amountInputControlcs1.TabIndex = 0;
            this.amountInputControlcs1.CloseForm += new System.EventHandler<MiniProject.AmountInputControlcs.CloseFormEventArgs>(this.amountInputControlcs1_CloseForm);
            // 
            // AmountInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 113);
            this.Controls.Add(this.amountInputControlcs1);
            this.Name = "AmountInputForm";
            this.Text = "몇개를 주문하시겠습니까?";
            this.ResumeLayout(false);

        }

        #endregion

        private AmountInputControlcs amountInputControlcs1;
    }
}