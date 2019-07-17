namespace MiniProject
{
    partial class Register_LoginControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIdCheck = new System.Windows.Forms.Button();
            this.txbPWCheck = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "사원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdata);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnIdCheck);
            this.groupBox1.Controls.Add(this.txbPWCheck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbPW);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.txbNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdata
            // 
            this.btnUpdata.Location = new System.Drawing.Point(249, 223);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(87, 23);
            this.btnUpdata.TabIndex = 10;
            this.btnUpdata.Text = "변경";
            this.btnUpdata.UseVisualStyleBackColor = true;
            this.btnUpdata.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnIdCheck
            // 
            this.btnIdCheck.Location = new System.Drawing.Point(249, 62);
            this.btnIdCheck.Name = "btnIdCheck";
            this.btnIdCheck.Size = new System.Drawing.Size(87, 23);
            this.btnIdCheck.TabIndex = 8;
            this.btnIdCheck.Text = "중복확인";
            this.btnIdCheck.UseVisualStyleBackColor = true;
            this.btnIdCheck.Click += new System.EventHandler(this.BtnIdCheck_Click);
            // 
            // txbPWCheck
            // 
            this.txbPWCheck.Location = new System.Drawing.Point(93, 160);
            this.txbPWCheck.Name = "txbPWCheck";
            this.txbPWCheck.PasswordChar = '*';
            this.txbPWCheck.Size = new System.Drawing.Size(118, 21);
            this.txbPWCheck.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "비밀번호확인";
            // 
            // txbPW
            // 
            this.txbPW.Location = new System.Drawing.Point(91, 112);
            this.txbPW.Name = "txbPW";
            this.txbPW.PasswordChar = '*';
            this.txbPW.Size = new System.Drawing.Size(118, 21);
            this.txbPW.TabIndex = 5;
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(91, 65);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(118, 21);
            this.txbId.TabIndex = 4;
            // 
            // txbNumber
            // 
            this.txbNumber.Location = new System.Drawing.Point(91, 19);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(118, 21);
            this.txbNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // Register_LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Register_LoginControl";
            this.Size = new System.Drawing.Size(372, 307);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIdCheck;
        private System.Windows.Forms.TextBox txbPWCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPW;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label label3;
    }
}
