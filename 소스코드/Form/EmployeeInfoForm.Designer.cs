namespace Miniproject
{
    partial class EmployeeInfoForm
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
            this.employeeSearch1 = new Miniproject.EmployeeSearch();
            this.uscEmployeeInfo = new Miniproject.EmployeeInfoControl();
            this.registerEmployeeControl1 = new Miniproject.RegisterEmployeeControl();
            this.SuspendLayout();
            // 
            // employeeSearch1
            // 
            this.employeeSearch1.Location = new System.Drawing.Point(454, 212);
            this.employeeSearch1.Name = "employeeSearch1";
            this.employeeSearch1.Size = new System.Drawing.Size(267, 34);
            this.employeeSearch1.TabIndex = 2;
            this.employeeSearch1.EnterSearchEmpoyeeInfo += new System.EventHandler<Miniproject.EmployeeSearch.EnterSearchEmpoyeeInfoEventArgs>(this.EmployeeSearch1_EnterSearchEmpoyeeInfo);
            // 
            // uscEmployeeInfo
            // 
            this.uscEmployeeInfo.Location = new System.Drawing.Point(14, 252);
            this.uscEmployeeInfo.Name = "uscEmployeeInfo";
            this.uscEmployeeInfo.Size = new System.Drawing.Size(760, 169);
            this.uscEmployeeInfo.TabIndex = 1;
            // 
            // registerEmployeeControl1
            // 
            this.registerEmployeeControl1.Location = new System.Drawing.Point(13, 13);
            this.registerEmployeeControl1.Name = "registerEmployeeControl1";
            this.registerEmployeeControl1.Size = new System.Drawing.Size(726, 177);
            this.registerEmployeeControl1.TabIndex = 0;
            // 
            // EmployeeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.employeeSearch1);
            this.Controls.Add(this.uscEmployeeInfo);
            this.Controls.Add(this.registerEmployeeControl1);
            this.Name = "EmployeeInfoForm";
            this.Text = "EmployeeInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private RegisterEmployeeControl registerEmployeeControl1;
        private EmployeeInfoControl uscEmployeeInfo;
        private EmployeeSearch employeeSearch1;
    }
}