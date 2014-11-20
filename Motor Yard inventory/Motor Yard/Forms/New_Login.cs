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
    public partial class New_LogIn : Form
    {
        public New_LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_NewLogIn_Click(object sender, EventArgs e)
        {
            string user_name = textBoxUserName_NewLogIn.Text;
            string password = textBoxPassword_NewLogIn.Text;
            string email = textBoxEmail_NewLogIn.Text;

            if (textBoxEmail_NewLogIn.Text != "" && textBoxPassword_NewLogIn.Text != "" && textBoxUserName_NewLogIn.Text != "")
            {
                int check;
                DatabaseConnections db = new DatabaseConnections();
                check = db.CheckUserName(user_name, password, email);

                if (check == 0)
                {
                    Main_Menu main_m = new Main_Menu();
                    main_m.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Can't keep Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void buttonBack_NewLogIn_Click(object sender, EventArgs e)
        {
            Main_Menu main_m = new Main_Menu();
            main_m.Show();
            this.Hide();
        }
    }
}
