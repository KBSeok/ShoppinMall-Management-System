namespace Miniproject
{
    partial class OrderSearchControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOrderSearch = new System.Windows.Forms.GroupBox();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.txbCusId = new System.Windows.Forms.TextBox();
            this.txbOrderNumber = new System.Windows.Forms.TextBox();
            this.chbCusId = new System.Windows.Forms.CheckBox();
            this.chbOrderNumber = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderSearch
            // 
            this.gbOrderSearch.Controls.Add(this.btnOrderSearch);
            this.gbOrderSearch.Controls.Add(this.txbCusId);
            this.gbOrderSearch.Controls.Add(this.txbOrderNumber);
            this.gbOrderSearch.Controls.Add(this.chbCusId);
            this.gbOrderSearch.Controls.Add(this.chbOrderNumber);
            this.gbOrderSearch.Location = new System.Drawing.Point(10, 30);
            this.gbOrderSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrderSearch.Name = "gbOrderSearch";
            this.gbOrderSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrderSearch.Size = new System.Drawing.Size(653, 84);
            this.gbOrderSearch.TabIndex = 0;
            this.gbOrderSearch.TabStop = false;
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(543, 35);
            this.btnOrderSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(86, 29);
            this.btnOrderSearch.TabIndex = 4;
            this.btnOrderSearch.Text = "검색";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.BtnOrderSearch_Click);
            // 
            // txbCusId
            // 
            this.txbCusId.Enabled = false;
            this.txbCusId.Location = new System.Drawing.Point(377, 38);
            this.txbCusId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCusId.Name = "txbCusId";
            this.txbCusId.Size = new System.Drawing.Size(131, 25);
            this.txbCusId.TabIndex = 3;
            // 
            // txbOrderNumber
            // 
            this.txbOrderNumber.Enabled = false;
            this.txbOrderNumber.Location = new System.Drawing.Point(137, 38);
            this.txbOrderNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbOrderNumber.Name = "txbOrderNumber";
            this.txbOrderNumber.Size = new System.Drawing.Size(134, 25);
            this.txbOrderNumber.TabIndex = 2;
            // 
            // chbCusId
            // 
            this.chbCusId.AutoSize = true;
            this.chbCusId.Location = new System.Drawing.Point(289, 44);
            this.chbCusId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbCusId.Name = "chbCusId";
            this.chbCusId.Size = new System.Drawing.Size(87, 19);
            this.chbCusId.TabIndex = 1;
            this.chbCusId.Text = "고객 ID :";
            this.chbCusId.UseVisualStyleBackColor = true;
            this.chbCusId.Click += new System.EventHandler(this.ChbCusId_CheckedChanged);
            // 
            // chbOrderNumber
            // 
            this.chbOrderNumber.AutoSize = true;
            this.chbOrderNumber.Location = new System.Drawing.Point(31, 45);
            this.chbOrderNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbOrderNumber.Name = "chbOrderNumber";
            this.chbOrderNumber.Size = new System.Drawing.Size(99, 19);
            this.chbOrderNumber.TabIndex = 0;
            this.chbOrderNumber.Text = "주문번호 :";
            this.chbOrderNumber.UseVisualStyleBackColor = true;
            this.chbOrderNumber.Click += new System.EventHandler(this.ChbOrderNumber_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "주문조회";
            // 
            // OrderSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOrderSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderSearchControl";
            this.Size = new System.Drawing.Size(670, 119);
            this.gbOrderSearch.ResumeLayout(false);
            this.gbOrderSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderSearch;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.TextBox txbCusId;
        private System.Windows.Forms.TextBox txbOrderNumber;
        private System.Windows.Forms.CheckBox chbCusId;
        private System.Windows.Forms.CheckBox chbOrderNumber;
        private System.Windows.Forms.Label label1;
    }
}
