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
        public String itemName;
        

        public void AddNewStock(string BrandId, string BrandName, string ModelId, string ModelName, string FuelId, string FuelType, string EngineId, string EngineCapacity, string YearId, string Year, string CatId, string CatName, string PartId, string PartName, long QuantityIn, long UnitPrice, string Date)
        {
            client_Id = GetClientId();
            InventoryId = BrandId + ModelId + FuelId + EngineId + YearId + CatId + PartId;
            itemName = getItemDetails_String(InventoryId);
            CinId =client_Id.ToString() + InventoryId;
            int Quantity = CheckQuantity(InventoryId);
            if (InventoryId.Length == 21 && Quantity == -1)
            {
                try
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO Inventory_Item (inventory_id,item_name,brand_id,model_id,fuel_id,engine_id,year_id,cat_id,part_id,date) VALUES('" + InventoryId + "','" + itemName + "','" + BrandId + "','" + ModelId + "','" + FuelId + "','" + EngineId + "','" + YearId + "','" + CatId + "','" + PartId + "','" + Date + "' )";
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
                    cmd.CommandText = "INSERT INTO Client_InventoryItem(cin_id,client_id,inventory_id,item_name,unit_price,quantity) VALUES ('" + CinId + "','" + client_Id + "','" + InventoryId + "','" + itemName + "','" + UnitPrice + "','" + QuantityIn + "')";
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

        public int CheckUserName(string user_name, string password, string email)
        {
            String load = "select user_name from user_password where user_name='" + user_name + "' ";
            //cmd.CommandText = load;
            int outint = 0;

            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                outint++;
                MessageBox.Show("You Can't use this User Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                con.Close();
                con.Open();
                cmd.CommandText = "INSERT INTO user_password(user_name,password,email) VALUES ('" + user_name + "','" + password + "','" + email + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account Created", "Done", MessageBoxButtons.OK);

            }

            con.Close();
            return outint;
        }

        //combo list generation for add_sock  Model_names /part_names //

        public String[] generateComboItems_Model_AddStock(String BrandId)
        {
            con.Open();
            String[] ar = new String[100];
            int i = 0;

            // add else if for all the brands //
            if (BrandId=="100") {
                string load = "select model_name from Model where model_id like '%H%'";
                
                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }
                
                con.Close();

            }else if (BrandId == "101") {
                string load = "select model_name from Model where model_id like '%T%'";
                
                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }
                
                con.Close();

            }
            else if (BrandId == "102")
            {
                string load = "select model_name from Model where model_id like '%N%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (BrandId == "103")
            {
                string load = "select model_name from Model where model_id like '%B%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (BrandId == "104")
            {
                string load = "select model_name from Model where model_id like '%A%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }

            return ar;

        }

        public String[] generateComboItems_part_AddStock(String catId) {

            con.Open();
            String[] ar = new String[100];
            int i = 0;
            if (catId == "c01")
            {
                string load = "select part_name from SparePart where part_id like '%T%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c02")
            {
                string load = "select part_name from SparePart where part_id like '%B%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c03")
            {
                string load = "select part_name from SparePart where part_id like '%E%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c04")
            {
                string load = "select part_name from SparePart where part_id like '%S%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c05")
            {
                string load = "select part_name from SparePart where part_id like '%C%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c06")
            {
                string load = "select part_name from SparePart where part_id like '%L%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c07")
            {
                string load = "select part_name from SparePart where part_id like '%X%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }
            else if (catId == "c08")
            {
                string load = "select part_name from SparePart where part_id like '%F%'";

                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    ar[i] = x;
                    i++;
                }

                con.Close();

            }

            return ar;
        
        }

        // combo list generation for update/delete/clear/transaction forms//

        public String[] generateComboBrand(){
                String[] b = new String[100];
                int i = 0;
                string load = "select distinct brand_name from Inventory_Item natural join Brand";
                con.Open();    
                cmd = con.CreateCommand();
                cmd.CommandText = load;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String x = (dr[0].ToString());
                    b[i] = x;
                    i++;
                }

                con.Close();
                return b;
            }
        public String[] generateComboItems_Model(String brandId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct model_name from Inventory_Item natural join Model where brand_id='"+ brandId + "'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                i++;
            }

            con.Close();
            return b;
            
        }

        public String[] generateComboItems_Fuel(String modelId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct fuel_type from Inventory_Item natural join Fuel where model_id='" + modelId + "'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                i++;
            }

            con.Close();
            return b;

        }

        public String[] generateComboItems_Engine(String fuelId,String modelId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct engine_capacity from Inventory_Item natural join Engine where fuel_id='" + fuelId + "'AND model_id= '" + modelId + "'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                i++;
            }

            con.Close();
            return b;

        }


        public String[] generateComboItems_Year(String engId,String modelId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct year from Inventory_Item natural join Yearr where engine_id='" + engId + "'AND model_id='" + modelId +"'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                i++;
            }

            con.Close();
            return b;

        }

        public String[] generateComboItems_Cat(String yearId, String modelId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct cat_name from Inventory_Item natural join Category where model_id='" + modelId + "'AND year_id='" + yearId + "'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                
                i++;
            }

            con.Close();
            return b;

        }

        public String[] generateComboItems_Part(String catId, String modelId)
        {
            String[] b = new String[100];
            int i = 0;
            string load = "select distinct part_name from Inventory_Item natural join SparePart where cat_id='" + catId + "'AND model_id='" + modelId + "'";
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = load;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String x = (dr[0].ToString());
                b[i] = x;
                i++;
            }

            con.Close();
            return b;

        }
      
        

        
        }

       

    }

    

