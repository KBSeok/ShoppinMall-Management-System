namespace MiniProject
{
    partial class Register_Login
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
            this.register_LoginControl1 = new MiniProject.Register_LoginControl();
            this.SuspendLayout();
            // 
            // register_LoginControl1
            // 
            this.register_LoginControl1.Location = new System.Drawing.Point(12, 12);
            this.register_LoginControl1.Name = "register_LoginControl1";
            this.register_LoginControl1.Size = new System.Drawing.Size(372, 307);
            this.register_LoginControl1.TabIndex = 0;
            this.register_LoginControl1.ButtonCloseForm += new System.EventHandler<MiniProject.Register_LoginControl.ButtonCloseFormEventArgs>(this.register_LoginControl1_ButtonCloseForm);
            // 
            // Register_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 318);
            this.Controls.Add(this.register_LoginControl1);
            this.Name = "Register_Login";
            this.Text = "Register_Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Register_LoginControl register_LoginControl1;
    }
}