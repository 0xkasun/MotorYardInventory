using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace Motor_Yard
{
    class Password
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        public Password()
        {
            //String myconnection = "Server=localhost; Database=motoryard;";
            string connectionStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            cn.ConnectionString = @connectionStr;
            com.Connection = cn;
        }

        public int Login(String user, String password)
        {
            String load = "select password from passwords where username='"+user+"' ";
            int outint=0;
            com.CommandText = load;

            try
            {
                cn.Open();
                dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //System.Windows.Forms.MessageBox.Show(dr[0].ToString());
                        if (dr[0].ToString() == password)
                        {

                            Main_Menu mm = new Main_Menu();
                            mm.Show();
                            outint++;

                        }
                        else { 
                         System.Windows.Forms.MessageBox.Show("Invalid Password!!! please re- enter!!", "Password Error" );
                        }

                            
                      
                        //listBox1.Items.Add(dr[0].ToString());
                        //listBox2.Items.Add(dr[1].ToString());
                    }
                }
                else {

                    System.Windows.Forms.MessageBox.Show("Invalid Username & password combination please re-enter!!!", "Error");

                    //return false;
                }
                cn.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
            return outint;
        }

    }
}
