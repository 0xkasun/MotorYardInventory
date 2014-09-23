using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;

namespace Motor_Yard
{
    class DatabaseConnections
    {
        public DatabaseConnections()
        {

            string connectionStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            con.ConnectionString = @connectionStr;
            cmd.Connection = con;
        }

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        string sql;
        public long client_Id;
        long CinId;


        public void AddNewStock(long BrandId, string BrandName, long ModelId, string ModelName, long FuelId, string FuelType, long EngineId, long EngineCapacity, long Year, long Yearr, long CatId, string CatName, long PartId, string PartName, long QuantityIn, long UnitPrice) 
        {
            try{
            
               con.Open();
               string inventoryId = Convert.ToString(BrandId) + Convert.ToString(ModelId) + Convert.ToString(FuelId) + Convert.ToString(EngineId) + Convert.ToString(Year) + Convert.ToString(CatId) + Convert.ToString(PartId);
               long InventoryId = Convert.ToInt64(inventoryId);
               CinId=Convert.ToInt64(client_Id.ToString()+inventoryId);
               cmd.CommandText = "INSERT INTO Inventory_Item ([inventory_id],[brand_id],[model_id],[fuel_id],[engine_id],[year_id],[cat_id],[part_id]) VALUES('" + InventoryId + "','" + BrandId + "','" + ModelId + "','" + FuelId + "','" + EngineId + "','" + Year + "','" + CatId + "','" + PartId + "')";
               cmd.ExecuteNonQuery();
               con.Close();

   

                con.Open();
                
                cmd.CommandText = "INSERT INTO Brand ([brand_id],[brand_name]) VALUES ('" + Convert.ToInt64(BrandId) + "','" + BrandName + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Model([model_id],[model_name]) VALUES ('" + Convert.ToInt64(ModelId) + "','" + ModelName + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Fuel([fuel_id],[fuel_type]) VALUES ('" + Convert.ToInt64(FuelId) + "','" + FuelType + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Engine([engine_id],[engine_capacity]) VALUES ('" + Convert.ToInt64(EngineId) + "','" + Convert.ToInt64(EngineCapacity) + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Yearr([year_id],[year_num]) VALUES ('" + Convert.ToInt64(Year) + "','" + Yearr + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO SparePart([part_id],[part_name],[unit_price]) VALUES ('" + Convert.ToInt64(PartId) + "','" + PartName + "','" + UnitPrice + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Category([cat_id],[cat_name]) VALUES ('" + Convert.ToInt64(CatId) + "','" + CatName + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO Client_InventoryItem([cin_id],[client_id],[inventory_id],[unit_price],[quantity]) VALUES ('" + CinId + "','" + client_Id + "','" + InventoryId + "','" + UnitPrice + "','" + QuantityIn + "')";
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Added!");

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
            }


        
        }
        public int CheckQuantity(string ItemCode)
        {
            CinId=Convert.ToInt64(client_Id.ToString()+ItemCode);
            String load = "select quantity from passwords where cin_id='" + CinId + "' ";
            int outint = -1;
            cmd.CommandText = load;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        outint = Convert.ToInt16(dr[0].ToString());
                    }
                }
                
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return outint;
        }

        public string CheckPassword (string user_Name, string Password)
        {
            con.Open();
            //cmd.CommandText ="SELECT Username,Password FROM Qperator WHERE Username"== user_Name "AND Password"==Password;




            cmd.CommandText = "INSERT INTO Operator([[Username],[Password]) VALUES ('" + user_Name + "','" + Password + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            return "jbbbb";
        }



        public int Login(String user, String password)
        {
            String load = "select password,id from passwords where username='" + user + "' ";
            int outint = 0;
            cmd.CommandText = load;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        client_Id=Convert.ToInt64(dr[1].ToString());
                        System.Windows.Forms.MessageBox.Show("client id: "+client_Id);
                        //System.Windows.Forms.MessageBox.Show(dr[0].ToString());
                        if (dr[0].ToString() == password)
                        {

                            Main_Menu mm = new Main_Menu();
                            mm.Show();
                            outint++;

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Invalid Password!!! please re- enter!!", "Password Error");
                        }



                        //listBox1.Items.Add(dr[0].ToString());
                        //listBox2.Items.Add(dr[1].ToString());
                    }
                }
                else
                {

                    System.Windows.Forms.MessageBox.Show("Invalid Username & password combination please re-enter!!!", "Error");

                    //return false;
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return outint;
        }

        public void Clearstock(String itemcode)
        {
            CinId = Convert.ToInt64((client_Id.ToString()) + itemcode);
            int quantity = 0;
            sql = "UPDATE Client_InventoryItem SET quantity='" + quantity + "' WHERE cin_id='" + CinId + "' ";
            cmd.CommandText = sql;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stock cleared", "Done", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {

                //throw;
                MessageBox.Show(e.Message);

            }


        }

    }

    
}
