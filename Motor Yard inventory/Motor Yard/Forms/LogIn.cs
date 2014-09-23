using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motor_Yard
{
    public partial class LogIn : Form
    {

        public String UserName ;
        public String Passwd;
        public LogIn()
        {
            InitializeComponent();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {

            if (textBox_UserName.Text != "" && textBox_Passwd.Text == "")
            {
                MessageBox.Show("Enter the password !!!" , "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (textBox_UserName.Text == "" && textBox_Passwd.Text != "")
            {

                MessageBox.Show("Enter the username !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox_UserName.Text == "" && textBox_Passwd.Text == "")
            {

                MessageBox.Show("Enter the username and password !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Password pw = new Password();
                DatabaseConnections db = new DatabaseConnections();
                int ret_val = db.Login(textBox_UserName.Text.ToString(), textBox_Passwd.Text.ToString());

                if (ret_val != 0)
                {
                    this.Hide();
                }
            }
        }

        private void button_ExitLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Passwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
