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
        public static long itemCode;
        public static string client_Id;
        public static int QuantityHand;
        public static string InventoryId;
        public static string CinId;


        public void AddNewStock(long BrandId, string BrandName, long ModelId, string ModelName, long FuelId, string FuelType, long EngineId, long EngineCapacity, long Year, long Yearr, long CatId, string CatName, long PartId, string PartName, long QuantityIn, long UnitPrice)
        {
            string client_Id = GetClientId();
            InventoryId = Convert.ToString(BrandId) + Convert.ToString(ModelId) + Convert.ToString(FuelId) + Convert.ToString(EngineId) + Convert.ToString(Year) + Convert.ToString(CatId) + Convert.ToString(PartId);
            CinId =client_Id.ToString() + InventoryId;

            if (InventoryId.Length == 21)
            {
                try
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO Inventory_Item ([inventory_id],[brand_id],[model_id],[fuel_id],[engine_id],[year_id],[cat_id],[part_id]) VALUES('" + InventoryId + "','" + BrandId + "','" + ModelId + "','" + FuelId + "','" + EngineId + "','" + Year + "','" + CatId + "','" + PartId + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



                try
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO Client_InventoryItem([cin_id],[client_id],[inventory_id],[unit_price],[quantity]) VALUES ('" + CinId + "','" + client_Id + "','" + InventoryId + "','" + UnitPrice + "','" + QuantityIn + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Data Added!");
            }

            else
            {
                MessageBox.Show("Invalid Details\nCheck all the entry and corresponding id numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }


        public int CheckQuantity(string ItemCode)
        {
            CinId = client_Id + ItemCode;
            String load = "select quantity from Client_InventoryItem where cin_id='" + CinId + "' ";
            QuantityHand = -1;
            cmd.CommandText = load;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        QuantityHand = Convert.ToInt16(dr[0].ToString());
                    }
                }

                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return QuantityHand;
        }

        public string CheckPassword (string user_Name, string Password)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO Operator([[Username],[Password]) VALUES ('" + user_Name + "','" + Password + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            return "jbbbb";
        }

        public void UpdateStock(string ItemCode, string QuantityIn)
        {
            CinId =client_Id + ItemCode;
            long NewQuantity;
            NewQuantity = QuantityHand + Convert.ToInt64(QuantityIn);
            cmd.CommandText = "UPDATE Client_InventoryItem SET quantity= '" + NewQuantity + "' WHERE cin_id='" + CinId + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Data Updated!\nItem Code : " + ItemCode + "\nNew Quantity :" + NewQuantity);

        }



        public int Login(String user, String password)
        {
            String load = "select password from User_Password where user_name='" + user + "' ";
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
                    }
                }
                else
                {

                    System.Windows.Forms.MessageBox.Show("Invalid Username & password combination please re-enter!!!", "Error");

                }
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            return outint;
        }
        public void DeleteItem(String itemCode)
        {
            try
            {
                con.Open();
                String del = "Delete from Inventory_Item where inventory_id='" + itemCode + "'";
                cmd.CommandText = del;
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                String del2 = "Delete from Client_InventoryItem where inventory_id='" + itemCode + "'";
                cmd.CommandText = del2;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success!");
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
        }

        public void Clearstock(String itemcode)
        {
            CinId =client_Id + itemcode;
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
                MessageBox.Show(e.Message);
            }


        }


        


        public long GetId(string check, string table)
        {

            if (table == "Brand")

            {
                
                String load = "select brand_id from Brand where brand_name='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "Category")
            {
                String load = "select cat_id from Category where cat_name='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                            
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "Engine")
            {
                String load = "select engine_id from Engine where engine_capacity='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "Fuel")
            {
                String load = "select fuel_id from Fuel where fuel_type='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "Model")
            {
                String load = "select model_id from Model where model_name='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "Year")
            {
                String load = "select year_id from Yearr where year_num='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }

            if (table == "SparePart")
            {
                String load = "select part_id from SparePart where part_name='" + check + "' ";
                cmd.CommandText = load;
                itemCode = 0;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = Convert.ToInt64(dr[0].ToString());
                        }
                    }

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

            }
        

            return itemCode;
        }

<<<<<<< HEAD
        //new Func
        public String getItemDetails_String(String itemCode) {

            String[] ar= new String[7];
            int len = itemCode.Length;
            char[] ch= itemCode.ToCharArray();
            int i=0;
            int j;

            while (i < len) {
                String s = "";
                for (j = 0; j < 3; j++) {

                    s = s + ch[i];
                
                }
                ar[i]=s;
                i = i + j;

                }
            long brandID = Convert.ToInt64(ar[0]);
            long modelID = Convert.ToInt64(ar[1]);
            long yearID = Convert.ToInt64(ar[4]);
            long fuelID = Convert.ToInt64(ar[2]);

            String details = this.getDetails(brandID, "Brand") + this.getDetails(brandID, "Model") + " of " + this.getDetails(brandID, "Year") + " ," + this.getDetails(brandID, "Fuel");

            return details;
        
        
        }
        public String getDetails(long check, String table) {
            String name="";

            if (table == "Brand")
            {

                String load = "select brand_name from Brand where brand_id='" + check + "' ";
                cmd.CommandText = load;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    name = dr.ToString();
                    

                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
                

            }

            if (table == "Model")
            {

                String load = "select brand_name from Brand where brand_id='" + check + "' ";
                cmd.CommandText = load;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    name = dr.ToString();


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


            }

            if (table == "Yearr")
            {

                String load = "select brand_name from Brand where brand_id='" + check + "' ";
                cmd.CommandText = load;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    name = dr.ToString();


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


            }

            if (table == "Fuel")
            {

                String load = "select brand_name from Brand where brand_id='" + check + "' ";
                cmd.CommandText = load;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    name = dr.ToString();


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


            }
            return name;
        
        
=======
        public string GetClientId()
        {
            String load = "select id from passwords";
            cmd.CommandText = load;

            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        client_Id = dr[0].ToString();
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return client_Id;
>>>>>>> d088c93bcd895202baf192f13b29222d96e98460
        }

    }

    
}
