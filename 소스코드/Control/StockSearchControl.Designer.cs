namespace Miniproject
{
    partial class StockSearchControl
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
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.chbSize = new System.Windows.Forms.CheckBox();
            this.chbColor = new System.Windows.Forms.CheckBox();
            this.chbSubCategory = new System.Windows.Forms.CheckBox();
            this.chbParentsCategory = new System.Windows.Forms.CheckBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cbbSize = new System.Windows.Forms.ComboBox();
            this.cbbLCategory = new System.Windows.Forms.ComboBox();
            this.cbbColor = new System.Windows.Forms.ComboBox();
            this.cbbHCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrderSearch
            // 
            this.gbOrderSearch.Controls.Add(this.btnStockSearch);
            this.gbOrderSearch.Controls.Add(this.chbSize);
            this.gbOrderSearch.Controls.Add(this.chbColor);
            this.gbOrderSearch.Controls.Add(this.chbSubCategory);
            this.gbOrderSearch.Controls.Add(this.chbParentsCategory);
            this.gbOrderSearch.Controls.Add(this.txbName);
            this.gbOrderSearch.Controls.Add(this.cbbSize);
            this.gbOrderSearch.Controls.Add(this.cbbLCategory);
            this.gbOrderSearch.Controls.Add(this.cbbColor);
            this.gbOrderSearch.Controls.Add(this.cbbHCategory);
            this.gbOrderSearch.Controls.Add(this.label1);
            this.gbOrderSearch.Location = new System.Drawing.Point(3, 3);
            this.gbOrderSearch.Name = "gbOrderSearch";
            this.gbOrderSearch.Size = new System.Drawing.Size(689, 160);
            this.gbOrderSearch.TabIndex = 1;
            this.gbOrderSearch.TabStop = false;
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.Location = new System.Drawing.Point(589, 131);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStockSearch.TabIndex = 1;
            this.btnStockSearch.Text = "검색";
            this.btnStockSearch.UseVisualStyleBackColor = true;
            this.btnStockSearch.Click += new System.EventHandler(this.btnStockSearch_Click);
            // 
            // chbSize
            // 
            this.chbSize.AutoSize = true;
            this.chbSize.Checked = true;
            this.chbSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSize.Location = new System.Drawing.Point(441, 90);
            this.chbSize.Name = "chbSize";
            this.chbSize.Size = new System.Drawing.Size(60, 16);
            this.chbSize.TabIndex = 9;
            this.chbSize.Text = "사이즈";
            this.chbSize.UseVisualStyleBackColor = true;
            this.chbSize.CheckedChanged += new System.EventHandler(this.chbSize_CheckedChanged);
            // 
            // chbColor
            // 
            this.chbColor.AutoSize = true;
            this.chbColor.Checked = true;
            this.chbColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbColor.Location = new System.Drawing.Point(195, 89);
            this.chbColor.Name = "chbColor";
            this.chbColor.Size = new System.Drawing.Size(48, 16);
            this.chbColor.TabIndex = 8;
            this.chbColor.Text = "색상";
            this.chbColor.UseVisualStyleBackColor = true;
            this.chbColor.CheckedChanged += new System.EventHandler(this.chbColor_CheckedChanged);
            // 
            // chbSubCategory
            // 
            this.chbSubCategory.AutoSize = true;
            this.chbSubCategory.Checked = true;
            this.chbSubCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSubCategory.Location = new System.Drawing.Point(441, 34);
            this.chbSubCategory.Name = "chbSubCategory";
            this.chbSubCategory.Size = new System.Drawing.Size(96, 16);
            this.chbSubCategory.TabIndex = 7;
            this.chbSubCategory.Text = "하위카테고리";
            this.chbSubCategory.UseVisualStyleBackColor = true;
            this.chbSubCategory.CheckedChanged += new System.EventHandler(this.chbSubCategory_CheckedChanged);
            // 
            // chbParentsCategory
            // 
            this.chbParentsCategory.AutoSize = true;
            this.chbParentsCategory.Checked = true;
            this.chbParentsCategory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbParentsCategory.Location = new System.Drawing.Point(195, 31);
            this.chbParentsCategory.Name = "chbParentsCategory";
            this.chbParentsCategory.Size = new System.Drawing.Size(96, 16);
            this.chbParentsCategory.TabIndex = 6;
            this.chbParentsCategory.Text = "상위카테고리";
            this.chbParentsCategory.UseVisualStyleBackColor = true;
            this.chbParentsCategory.CheckedChanged += new System.EventHandler(this.chbParentsCategory_CheckedChanged);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(68, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 21);
            this.txbName.TabIndex = 5;
            // 
            // cbbSize
            // 
            this.cbbSize.DisplayMember = "Size";
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FormattingEnabled = true;
            this.cbbSize.Location = new System.Drawing.Point(543, 83);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.Size = new System.Drawing.Size(121, 20);
            this.cbbSize.TabIndex = 4;
            this.cbbSize.ValueMember = "Size";
            // 
            // cbbLCategory
            // 
            this.cbbLCategory.DisplayMember = "SubCategoryName";
            this.cbbLCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLCategory.FormattingEnabled = true;
            this.cbbLCategory.Location = new System.Drawing.Point(543, 28);
            this.cbbLCategory.Name = "cbbLCategory";
            this.cbbLCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbLCategory.TabIndex = 3;
            this.cbbLCategory.ValueMember = "SubCategoryName";
            this.cbbLCategory.DropDownClosed += new System.EventHandler(this.cbbLCategory_DropDownClosed);
            // 
            // cbbColor
            // 
            this.cbbColor.DisplayMember = "Color";
            this.cbbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColor.FormattingEnabled = true;
            this.cbbColor.Location = new System.Drawing.Point(296, 83);
            this.cbbColor.Name = "cbbColor";
            this.cbbColor.Size = new System.Drawing.Size(121, 20);
            this.cbbColor.TabIndex = 2;
            this.cbbColor.ValueMember = "Color";
            this.cbbColor.DropDownClosed += new System.EventHandler(this.cbbColor_DropDownClosed);
            // 
            // cbbHCategory
            // 
            this.cbbHCategory.DisplayMember = "ParentsCategoryId";
            this.cbbHCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHCategory.Enabled = false;
            this.cbbHCategory.FormattingEnabled = true;
            this.cbbHCategory.Location = new System.Drawing.Point(296, 28);
            this.cbbHCategory.Name = "cbbHCategory";
            this.cbbHCategory.Size = new System.Drawing.Size(119, 20);
            this.cbbHCategory.TabIndex = 1;
            this.cbbHCategory.ValueMember = "ParentsCategoryId";
            this.cbbHCategory.DropDownClosed += new System.EventHandler(this.cbbHCategory_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명 :";
            // 
            // StockSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOrderSearch);
            this.Name = "StockSearchControl";
            this.Size = new System.Drawing.Size(699, 168);
            this.gbOrderSearch.ResumeLayout(false);
            this.gbOrderSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrderSearch;
        private System.Windows.Forms.Button btnStockSearch;
        private System.Windows.Forms.CheckBox chbSize;
        private System.Windows.Forms.CheckBox chbColor;
        private System.Windows.Forms.CheckBox chbSubCategory;
        private System.Windows.Forms.CheckBox chbParentsCategory;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cbbSize;
        private System.Windows.Forms.ComboBox cbbLCategory;
        private System.Windows.Forms.ComboBox cbbColor;
        private System.Windows.Forms.ComboBox cbbHCategory;
        private System.Windows.Forms.Label label1;
    }
}
