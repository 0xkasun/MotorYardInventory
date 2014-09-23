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
            String UserName=textBox_UserName.Text;
            String Passwd = textBox_Passwd.Text;

            if (UserName == Passwd)
            {
                Main_Menu main_menu = new Main_Menu();
                main_menu.Show();
                this.Hide();
            }
        }

        private void button_ExitLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
