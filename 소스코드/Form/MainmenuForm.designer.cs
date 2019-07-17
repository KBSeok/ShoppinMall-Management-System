namespace Miniproject
{
    partial class MainmenuForm
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
            this.btninventoryM = new System.Windows.Forms.Button();
            this.btnOrderM = new System.Windows.Forms.Button();
            this.btnMemberM = new System.Windows.Forms.Button();
            this.btnStaffM = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btninventoryM
            // 
            this.btninventoryM.Location = new System.Drawing.Point(104, 125);
            this.btninventoryM.Name = "btninventoryM";
            this.btninventoryM.Size = new System.Drawing.Size(218, 65);
            this.btninventoryM.TabIndex = 0;
            this.btninventoryM.Text = "재고관리";
            this.btninventoryM.UseVisualStyleBackColor = true;
            this.btninventoryM.Click += new System.EventHandler(this.btninventoryM_Click);
            // 
            // btnOrderM
            // 
            this.btnOrderM.Location = new System.Drawing.Point(104, 196);
            this.btnOrderM.Name = "btnOrderM";
            this.btnOrderM.Size = new System.Drawing.Size(218, 65);
            this.btnOrderM.TabIndex = 1;
            this.btnOrderM.Text = "주문관리";
            this.btnOrderM.UseVisualStyleBackColor = true;
            this.btnOrderM.Click += new System.EventHandler(this.BtnOrderM_Click);
            // 
            // btnMemberM
            // 
            this.btnMemberM.Location = new System.Drawing.Point(104, 267);
            this.btnMemberM.Name = "btnMemberM";
            this.btnMemberM.Size = new System.Drawing.Size(218, 65);
            this.btnMemberM.TabIndex = 2;
            this.btnMemberM.Text = "회원관리";
            this.btnMemberM.UseVisualStyleBackColor = true;
            this.btnMemberM.Click += new System.EventHandler(this.BtnMemberM_Click);
            // 
            // btnStaffM
            // 
            this.btnStaffM.Location = new System.Drawing.Point(104, 338);
            this.btnStaffM.Name = "btnStaffM";
            this.btnStaffM.Size = new System.Drawing.Size(218, 65);
            this.btnStaffM.TabIndex = 3;
            this.btnStaffM.Text = "직원관리";
            this.btnStaffM.UseVisualStyleBackColor = true;
            this.btnStaffM.Click += new System.EventHandler(this.BtnStaffM_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("굴림", 30F);
            this.lblMenu.Location = new System.Drawing.Point(124, 37);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(181, 40);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "-MENU-";
            // 
            // MainmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 499);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnStaffM);
            this.Controls.Add(this.btnMemberM);
            this.Controls.Add(this.btnOrderM);
            this.Controls.Add(this.btninventoryM);
            this.Name = "MainmenuForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninventoryM;
        private System.Windows.Forms.Button btnOrderM;
        private System.Windows.Forms.Button btnMemberM;
        private System.Windows.Forms.Button btnStaffM;
        private System.Windows.Forms.Label lblMenu;
    }
}