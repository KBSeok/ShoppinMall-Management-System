namespace Miniproject
{
    partial class CusOrderInfoForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uscCusOrderInfo = new Miniproject.CustomerOrderListControl();
            this.uscOutputCusInfo = new Miniproject.CustomerInfoControl();
            this.uscSearchCusInfo = new Miniproject.CustomerSearchControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "회원관리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uscCusOrderInfo
            // 
            this.uscCusOrderInfo.Location = new System.Drawing.Point(12, 217);
            this.uscCusOrderInfo.Name = "uscCusOrderInfo";
            this.uscCusOrderInfo.Size = new System.Drawing.Size(744, 226);
            this.uscCusOrderInfo.TabIndex = 3;
            // 
            // uscOutputCusInfo
            // 
            this.uscOutputCusInfo.Location = new System.Drawing.Point(22, 69);
            this.uscOutputCusInfo.Name = "uscOutputCusInfo";
            this.uscOutputCusInfo.Size = new System.Drawing.Size(717, 152);
            this.uscOutputCusInfo.TabIndex = 2;
            this.uscOutputCusInfo.DoubleClickSearchCusOrderInfo += new System.EventHandler<Miniproject.CustomerInfoControl.DoubleClickSearchCusOrderInfoEventArgs>(this.UscOutputCusInfo_DoubleClickSearchCusOrderInfo);
            // 
            // uscSearchCusInfo
            // 
            this.uscSearchCusInfo.Location = new System.Drawing.Point(158, 8);
            this.uscSearchCusInfo.Name = "uscSearchCusInfo";
            this.uscSearchCusInfo.Size = new System.Drawing.Size(579, 66);
            this.uscSearchCusInfo.TabIndex = 0;
            this.uscSearchCusInfo.OnButtonSearchCusInfo += new System.EventHandler<Miniproject.CustomerSearchControl.OnButtonSearchCusInfoEventArgs>(this.customerSearchControl1_OnButtonSearchCusInfo);
            // 
            // CusOrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 448);
            this.Controls.Add(this.uscCusOrderInfo);
            this.Controls.Add(this.uscOutputCusInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uscSearchCusInfo);
            this.Name = "CusOrderInfoForm";
            this.Text = "회원관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerSearchControl uscSearchCusInfo;
        private System.Windows.Forms.Label label1;
        private CustomerInfoControl uscOutputCusInfo;
        private CustomerOrderListControl uscCusOrderInfo;
    }
}

