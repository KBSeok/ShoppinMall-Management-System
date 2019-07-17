namespace MiniProject
{
    partial class UPdataDeleteForm
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
            this.insertDeleteControl1 = new Miniproject.InsertDeleteControl();
            this.SuspendLayout();
            // 
            // insertDeleteControl1
            // 
            this.insertDeleteControl1.Location = new System.Drawing.Point(2, 12);
            this.insertDeleteControl1.Name = "insertDeleteControl1";
            this.insertDeleteControl1.Size = new System.Drawing.Size(223, 45);
            this.insertDeleteControl1.TabIndex = 0;
            // 
            // UPdataDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 90);
            this.Controls.Add(this.insertDeleteControl1);
            this.Name = "UPdataDeleteForm";
            this.Text = "삭제 변경 여부";
            this.ResumeLayout(false);

        }

        #endregion

        private Miniproject.InsertDeleteControl insertDeleteControl1;
    }
}