namespace Motor_Yard
{
    partial class New_LogIn
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
            this.buttonBack_NewLogIn = new System.Windows.Forms.Button();
            this.buttonLogIn_NewLogIn = new System.Windows.Forms.Button();
            this.textBoxEmail_NewLogIn = new System.Windows.Forms.TextBox();
            this.textBoxPassword_NewLogIn = new System.Windows.Forms.TextBox();
            this.textBoxUserName_NewLogIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack_NewLogIn
            // 
            this.buttonBack_NewLogIn.Location = new System.Drawing.Point(235, 200);
            this.buttonBack_NewLogIn.Name = "buttonBack_NewLogIn";
            this.buttonBack_NewLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonBack_NewLogIn.TabIndex = 15;
            this.buttonBack_NewLogIn.Text = "Back";
            this.buttonBack_NewLogIn.UseVisualStyleBackColor = true;
            this.buttonBack_NewLogIn.Click += new System.EventHandler(this.buttonBack_NewLogIn_Click);
            // 
            // buttonLogIn_NewLogIn
            // 
            this.buttonLogIn_NewLogIn.Location = new System.Drawing.Point(127, 200);
            this.buttonLogIn_NewLogIn.Name = "buttonLogIn_NewLogIn";
            this.buttonLogIn_NewLogIn.Size = new System.Drawing.Size(75, 23);
            this.buttonLogIn_NewLogIn.TabIndex = 14;
            this.buttonLogIn_NewLogIn.Text = "Log In";
            this.buttonLogIn_NewLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn_NewLogIn.Click += new System.EventHandler(this.buttonLogIn_NewLogIn_Click);
            // 
            // textBoxEmail_NewLogIn
            // 
            this.textBoxEmail_NewLogIn.Location = new System.Drawing.Point(127, 141);
            this.textBoxEmail_NewLogIn.Name = "textBoxEmail_NewLogIn";
            this.textBoxEmail_NewLogIn.Size = new System.Drawing.Size(183, 20);
            this.textBoxEmail_NewLogIn.TabIndex = 13;
            // 
            // textBoxPassword_NewLogIn
            // 
            this.textBoxPassword_NewLogIn.Location = new System.Drawing.Point(127, 87);
            this.textBoxPassword_NewLogIn.Name = "textBoxPassword_NewLogIn";
            this.textBoxPassword_NewLogIn.PasswordChar = '*';
            this.textBoxPassword_NewLogIn.Size = new System.Drawing.Size(183, 20);
            this.textBoxPassword_NewLogIn.TabIndex = 12;
            // 
            // textBoxUserName_NewLogIn
            // 
            this.textBoxUserName_NewLogIn.Location = new System.Drawing.Point(127, 38);
            this.textBoxUserName_NewLogIn.Name = "textBoxUserName_NewLogIn";
            this.textBoxUserName_NewLogIn.Size = new System.Drawing.Size(183, 20);
            this.textBoxUserName_NewLogIn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Name";
            // 
            // New_LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 268);
            this.Controls.Add(this.buttonBack_NewLogIn);
            this.Controls.Add(this.buttonLogIn_NewLogIn);
            this.Controls.Add(this.textBoxEmail_NewLogIn);
            this.Controls.Add(this.textBoxPassword_NewLogIn);
            this.Controls.Add(this.textBoxUserName_NewLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_LogIn";
            this.Text = "New Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack_NewLogIn;
        private System.Windows.Forms.Button buttonLogIn_NewLogIn;
        private System.Windows.Forms.TextBox textBoxEmail_NewLogIn;
        private System.Windows.Forms.TextBox textBoxPassword_NewLogIn;
        private System.Windows.Forms.TextBox textBoxUserName_NewLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}