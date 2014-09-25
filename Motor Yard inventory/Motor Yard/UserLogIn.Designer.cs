namespace Motor_Yard
{
    partial class UserLogIn
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
            this.labeluserName_UserLogIn = new System.Windows.Forms.Label();
            this.labelpassword_UserLogIn = new System.Windows.Forms.Label();
            this.buttonlogin_UserLogIn = new System.Windows.Forms.Button();
            this.textBoxuserName_UserLogIn = new System.Windows.Forms.TextBox();
            this.textBoxpassword_UserLogIn = new System.Windows.Forms.TextBox();
            this.labelchangepassword_UserLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeluserName_UserLogIn
            // 
            this.labeluserName_UserLogIn.AutoSize = true;
            this.labeluserName_UserLogIn.Location = new System.Drawing.Point(26, 98);
            this.labeluserName_UserLogIn.Name = "labeluserName_UserLogIn";
            this.labeluserName_UserLogIn.Size = new System.Drawing.Size(62, 15);
            this.labeluserName_UserLogIn.TabIndex = 0;
            this.labeluserName_UserLogIn.Text = "UserName";
            // 
            // labelpassword_UserLogIn
            // 
            this.labelpassword_UserLogIn.AutoSize = true;
            this.labelpassword_UserLogIn.Location = new System.Drawing.Point(26, 133);
            this.labelpassword_UserLogIn.Name = "labelpassword_UserLogIn";
            this.labelpassword_UserLogIn.Size = new System.Drawing.Size(55, 15);
            this.labelpassword_UserLogIn.TabIndex = 1;
            this.labelpassword_UserLogIn.Text = "Password";
            // 
            // buttonlogin_UserLogIn
            // 
            this.buttonlogin_UserLogIn.Location = new System.Drawing.Point(136, 188);
            this.buttonlogin_UserLogIn.Name = "buttonlogin_UserLogIn";
            this.buttonlogin_UserLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin_UserLogIn.TabIndex = 2;
            this.buttonlogin_UserLogIn.Text = "LogIn";
            this.buttonlogin_UserLogIn.UseVisualStyleBackColor = true;
            this.buttonlogin_UserLogIn.Click += new System.EventHandler(this.buttonlogin_UserLogIn_Click);
            // 
            // textBoxuserName_UserLogIn
            // 
            this.textBoxuserName_UserLogIn.Location = new System.Drawing.Point(136, 92);
            this.textBoxuserName_UserLogIn.Name = "textBoxuserName_UserLogIn";
            this.textBoxuserName_UserLogIn.Size = new System.Drawing.Size(155, 21);
            this.textBoxuserName_UserLogIn.TabIndex = 3;
            // 
            // textBoxpassword_UserLogIn
            // 
            this.textBoxpassword_UserLogIn.Location = new System.Drawing.Point(136, 127);
            this.textBoxpassword_UserLogIn.Name = "textBoxpassword_UserLogIn";
            this.textBoxpassword_UserLogIn.Size = new System.Drawing.Size(155, 21);
            this.textBoxpassword_UserLogIn.TabIndex = 4;
            // 
            // labelchangepassword_UserLogIn
            // 
            this.labelchangepassword_UserLogIn.AutoSize = true;
            this.labelchangepassword_UserLogIn.Location = new System.Drawing.Point(133, 227);
            this.labelchangepassword_UserLogIn.Name = "labelchangepassword_UserLogIn";
            this.labelchangepassword_UserLogIn.Size = new System.Drawing.Size(99, 15);
            this.labelchangepassword_UserLogIn.TabIndex = 5;
            this.labelchangepassword_UserLogIn.Text = "Change Password";
            // 
            // UserLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 337);
            this.Controls.Add(this.labelchangepassword_UserLogIn);
            this.Controls.Add(this.textBoxpassword_UserLogIn);
            this.Controls.Add(this.textBoxuserName_UserLogIn);
            this.Controls.Add(this.buttonlogin_UserLogIn);
            this.Controls.Add(this.labelpassword_UserLogIn);
            this.Controls.Add(this.labeluserName_UserLogIn);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeluserName_UserLogIn;
        private System.Windows.Forms.Label labelpassword_UserLogIn;
        private System.Windows.Forms.Button buttonlogin_UserLogIn;
        private System.Windows.Forms.TextBox textBoxuserName_UserLogIn;
        private System.Windows.Forms.TextBox textBoxpassword_UserLogIn;
        private System.Windows.Forms.Label labelchangepassword_UserLogIn;
    }
}