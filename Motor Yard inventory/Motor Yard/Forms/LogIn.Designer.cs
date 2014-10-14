namespace Motor_Yard
{
    partial class LogIn
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
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Passwd = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Passwd = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_ExitLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(27, 66);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(65, 15);
            this.label_UserName.TabIndex = 0;
            this.label_UserName.Text = "User Name";
            // 
            // label_Passwd
            // 
            this.label_Passwd.AutoSize = true;
            this.label_Passwd.Location = new System.Drawing.Point(27, 112);
            this.label_Passwd.Name = "label_Passwd";
            this.label_Passwd.Size = new System.Drawing.Size(55, 15);
            this.label_Passwd.TabIndex = 1;
            this.label_Passwd.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(115, 60);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(163, 21);
            this.textBox_UserName.TabIndex = 2;
            this.textBox_UserName.Text = "Kamal";
            // 
            // textBox_Passwd
            // 
            this.textBox_Passwd.Location = new System.Drawing.Point(115, 112);
            this.textBox_Passwd.Name = "textBox_Passwd";
            this.textBox_Passwd.PasswordChar = '*';
            this.textBox_Passwd.Size = new System.Drawing.Size(163, 21);
            this.textBox_Passwd.TabIndex = 3;
            this.textBox_Passwd.Text = "123";
            this.textBox_Passwd.TextChanged += new System.EventHandler(this.textBox_Passwd_TextChanged);
            // 
            // button_LogIn
            // 
            this.button_LogIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_LogIn.Location = new System.Drawing.Point(115, 183);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(75, 23);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_ExitLogIn
            // 
            this.button_ExitLogIn.Location = new System.Drawing.Point(203, 183);
            this.button_ExitLogIn.Name = "button_ExitLogIn";
            this.button_ExitLogIn.Size = new System.Drawing.Size(75, 23);
            this.button_ExitLogIn.TabIndex = 5;
            this.button_ExitLogIn.Text = "Exit";
            this.button_ExitLogIn.UseVisualStyleBackColor = true;
            this.button_ExitLogIn.Click += new System.EventHandler(this.button_ExitLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.button_ExitLogIn);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Passwd);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Passwd);
            this.Controls.Add(this.label_UserName);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control System - Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Passwd;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Passwd;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_ExitLogIn;
    }
}

