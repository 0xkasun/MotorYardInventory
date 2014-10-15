using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Motor_Yard
{
    class DatabaseConnections
    {
        public DatabaseConnections()
        {

            /*string connectionStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            con.ConnectionString = @connectionStr;
            cmd.Connection = con;*/
        String sqlconnection="Server=localhost;DATABASE=motoryard_inventory;UID=root;";
        MySqlConnection con = new MySqlConnection(sqlconnection);
        

        }

        // mysql connections
        static String sqlconnection="Server=localhost;DATABASE=motoryard_inventory;UID=root;";
        MySqlConnection con = new MySqlConnection(sqlconnection);
        MySqlCommand cmd ;
        
        //= new MySqlCommand(sqlconnection);


        //OleDbConnection con = new OleDbConnection();
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader dr;
        MySqlDataReader dr;
        string sql;
        public static string itemCode;
        public static string client_Id;
        public static int QuantityHand;
        public static string InventoryId;
        public static string CinId;
        public static string user_id;
        public static string user_name;



        public void AddNewStock(string BrandId, string BrandName, string ModelId, string ModelName, string FuelId, string FuelType, string EngineId, string EngineCapacity, string YearId, string Year, string CatId, string CatName, string PartId, string PartName, long QuantityIn, long UnitPrice, string Date)
        {
            client_Id = GetClientId();
            InventoryId = BrandId + ModelId + FuelId + EngineId + YearId + CatId + PartId;
            CinId =client_Id.ToString() + InventoryId;
            int Quantity = CheckQuantity(InventoryId);
            if (InventoryId.Length == 21 && Quantity == -1)
            {
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO Inventory_Item (inventory_id,brand_id,model_id,fuel_id,engine_id,year_id,cat_id,part_id,date) VALUES('" + InventoryId + "','" + BrandId + "','" + ModelId + "','" + FuelId + "','" + EngineId + "','" + YearId + "','" + CatId + "','" + PartId + "','" + Date +"' )";
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
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO Client_InventoryItem(cin_id,client_id,inventory_id,unit_price,quantity) VALUES ('" + CinId + "','" + client_Id + "','" + InventoryId + "','" + UnitPrice + "','" + QuantityIn + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Data Added!");
            }

            else if (InventoryId.Length == 21 && Quantity != -1)
            {
                MessageBox.Show("Item already in Database.Check and update Quantity","Check",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Invalid Details\nCheck all the entry and corresponding id numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }


        public int CheckQuantity(string ItemCode)
        {
            client_Id = GetClientId();
            CinId = client_Id + ItemCode;
            String load = "select quantity from Client_InventoryItem where cin_id='" + CinId + "' ";
            QuantityHand = -1;

            try
            {
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandText = load;
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
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Operator([[Username],[Password]) VALUES ('" + user_Name + "','" + Password + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            return "jbbbb";
        }

        public void UpdateStock(string ItemCode, string QuantityIn,string Date)
        {
            client_Id = GetClientId();
            CinId =client_Id + ItemCode;
            long NewQuantity;
            NewQuantity = QuantityHand + Convert.ToInt64(QuantityIn);
            
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Client_InventoryItem SET quantity= '" + NewQuantity + "' WHERE cin_id='" + CinId + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE Inventory_Item SET date= '" + Date + "' WHERE inventory_id='" + ItemCode + "'";
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

            String load = "select password,id from User_Password where user_name='" + user + "' ";
            int outint = 0;
            user_name = user;
            //cmd = con.CreateCommand();
            
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        if (dr[0].ToString() == password)
                        {
                            user_id = dr[1].ToString();
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
                cmd = con.CreateCommand();
                String del = "Delete from Inventory_Item where inventory_id='" + itemCode + "'";
                cmd.CommandText = del;
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd = con.CreateCommand();
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
            client_Id = GetClientId();
            CinId =client_Id + itemcode;
            int quantity = 0;
            sql = "UPDATE Client_InventoryItem SET quantity='" + quantity + "' WHERE cin_id='" + CinId + "' ";
            

            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stock cleared", "Done", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }


        


        public string GetId(string check, string table)
        {

            if (table == "Brand")

            {
                
                String load = "select brand_id from Brand where brand_name='" + check + "' ";
                
                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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

                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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

                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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

                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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
                String load = "select year_id from Yearr where year='" + check + "' ";

                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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

                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();

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
                
                itemCode = "";
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            itemCode = dr[0].ToString();
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


        //new Func
        public String getItemDetails_String(String itemCode) {

            String[] ar= new String[7];
            int len = itemCode.Length;
            char[] ch= itemCode.ToCharArray();
            int i=0;
            int j;
            int p = 0;

            while (i < len) {
                String s = "";
                for (j = 0; j < 3; j++) {

                    s = s + ch[j+i];
                
                }
                
                ar[p]=s;
                i = i + j;
                p++;

                }
            
            String brandID = (ar[0]);
            String modelID = (ar[1]);
            String yearID = (ar[4]);
            String fuelID = (ar[2]);
            String partID = (ar[6]);
           

            String details = getDetails(brandID, "Brand") +"-"+ getDetails(modelID, "Model") + " of " + getDetails(yearID, "Yearr") + " ," + getDetails(fuelID, "Fuel") + " : "+getDetails(partID,"SparePart");

            return details;
        
        
        }
        public String getDetails(String check, String table)
        {
            String name = "";

            if (table == "Brand")
            {
                
                String load = "select brand_name from Brand where brand_id='" + check + "' ";
                
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
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

                String load = "select model_name from Model where model_id='" + check + "' ";
                
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
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

                String load = "select fuel_type from Fuel where fuel_id='" + check + "' ";

                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
                        }
                    }


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


            }

            if (table == "Yearr")
            {

                String load = "select year from Yearr where year_id='" + check + "' ";
                
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
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

                String load = "select part_name from SparePart where part_id='" + check + "' ";

                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
                        }
                    }


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


            }




            
            return name;

        }

        public string GetClientId()
        {
            String load = "select id from password";
            

            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = load;
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

        }

        public void Delete_Clear_Details(string ItemCode, string Description, string Date ,string Table)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Delete_Clear_Details (inventory_id,id,user_name,status,date,description) VALUES('" + ItemCode + "','" + user_id + "','" + user_name + "','" + Table + "','" + Date + "','" + Description + "')";
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
        }

        public String get_unit_price(String itemCode) {

            // add a unit price field to inventory items table
                String name = "";
                String cinId = GetClientId().ToString() + itemCode;
                String load = "select unit_price from Client_InventoryItem where cin_id='" +cinId + "' ";

                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = load;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            name = (dr[0].ToString());
                        }
                    }


                    con.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }


                return name;
        
        
        }



        public void updateItemQuantity(String itemCode,String qty){

            int x = CheckQuantity(itemCode);
            int y = Convert.ToInt32(qty);
            y = x - y;
            String cin_id = GetClientId().ToString() + itemCode;
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "Update Client_InventoryItem set quantity='" + y + "'where cin_id='" + cin_id + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

        }

    }

    
}
