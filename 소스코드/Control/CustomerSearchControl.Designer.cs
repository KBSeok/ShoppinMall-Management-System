namespace Miniproject
{
    partial class CustomerSearchControl
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
            this.gbCusSearch = new System.Windows.Forms.GroupBox();
            this.btnCusSearch = new System.Windows.Forms.Button();
            this.chbCusGrade = new System.Windows.Forms.CheckBox();
            this.cbbGrade = new System.Windows.Forms.ComboBox();
            this.chbCusId = new System.Windows.Forms.CheckBox();
            this.txbCusId = new System.Windows.Forms.TextBox();
            this.gbCusSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCusSearch
            // 
            this.gbCusSearch.Controls.Add(this.btnCusSearch);
            this.gbCusSearch.Controls.Add(this.chbCusGrade);
            this.gbCusSearch.Controls.Add(this.cbbGrade);
            this.gbCusSearch.Controls.Add(this.chbCusId);
            this.gbCusSearch.Controls.Add(this.txbCusId);
            this.gbCusSearch.Location = new System.Drawing.Point(8, 3);
            this.gbCusSearch.Name = "gbCusSearch";
            this.gbCusSearch.Size = new System.Drawing.Size(566, 57);
            this.gbCusSearch.TabIndex = 0;
            this.gbCusSearch.TabStop = false;
            // 
            // btnCusSearch
            // 
            this.btnCusSearch.Location = new System.Drawing.Point(485, 20);
            this.btnCusSearch.Name = "btnCusSearch";
            this.btnCusSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCusSearch.TabIndex = 4;
            this.btnCusSearch.Text = "검색";
            this.btnCusSearch.UseVisualStyleBackColor = true;
            this.btnCusSearch.Click += new System.EventHandler(this.btnCusSearch_Click);
            // 
            // chbCusGrade
            // 
            this.chbCusGrade.AutoSize = true;
            this.chbCusGrade.Location = new System.Drawing.Point(256, 24);
            this.chbCusGrade.Name = "chbCusGrade";
            this.chbCusGrade.Size = new System.Drawing.Size(84, 16);
            this.chbCusGrade.TabIndex = 3;
            this.chbCusGrade.Text = "고객등급 : ";
            this.chbCusGrade.UseVisualStyleBackColor = true;
            this.chbCusGrade.CheckedChanged += new System.EventHandler(this.chbCusGrade_CheckedChanged);
            // 
            // cbbGrade
            // 
            this.cbbGrade.DisplayMember = "Grade";
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.Location = new System.Drawing.Point(356, 22);
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.Size = new System.Drawing.Size(107, 20);
            this.cbbGrade.TabIndex = 1;
            this.cbbGrade.ValueMember = "Grade";
            // 
            // chbCusId
            // 
            this.chbCusId.AutoSize = true;
            this.chbCusId.Location = new System.Drawing.Point(6, 24);
            this.chbCusId.Name = "chbCusId";
            this.chbCusId.Size = new System.Drawing.Size(71, 16);
            this.chbCusId.TabIndex = 2;
            this.chbCusId.Text = "회원 ID :";
            this.chbCusId.UseVisualStyleBackColor = true;
            this.chbCusId.CheckedChanged += new System.EventHandler(this.chbCusId_CheckedChanged);
            // 
            // txbCusId
            // 
            this.txbCusId.Location = new System.Drawing.Point(80, 21);
            this.txbCusId.Name = "txbCusId";
            this.txbCusId.Size = new System.Drawing.Size(155, 21);
            this.txbCusId.TabIndex = 0;
            // 
            // CustomerSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCusSearch);
            this.Name = "CustomerSearchControl";
            this.Size = new System.Drawing.Size(579, 66);
            this.gbCusSearch.ResumeLayout(false);
            this.gbCusSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCusSearch;
        private System.Windows.Forms.CheckBox chbCusGrade;
        private System.Windows.Forms.ComboBox cbbGrade;
        private System.Windows.Forms.CheckBox chbCusId;
        private System.Windows.Forms.TextBox txbCusId;
        private System.Windows.Forms.Button btnCusSearch;
    }
}
