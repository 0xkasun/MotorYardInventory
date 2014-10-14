
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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            total_box.Text = "0";
        }

        private void ToolStripMenuItem_Catalog_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            //this.Hide();
        }

        private void addNewStock_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Control stock_control = new Stock_Control(1);
            stock_control.Show();
        }

        private void updateStock_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Control stock_control = new Stock_Control(2);
            stock_control.Show();
        }

        private void deleteStock_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Control stock_control = new Stock_Control(3);
            stock_control.Show();
        }

        private void clearStock_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Control stock_control = new Stock_Control(4);
            stock_control.Show();
        }

        private void stockStatusTool_StripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Control stock_control = new Stock_Control(5);
            stock_control.Show();
        }

        private void sales_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(1);
            reports.Show();
        }

        private void totalIncome_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(2);
            reports.Show();
        }

        private void taxesPayable_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(3);
            reports.Show();
        }

        private void ratings_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(1);
            customers.Show();
        }

        private void discountOffered_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(2);
            customers.Show();
        }

        private void requests_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers(3);
            customers.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }


        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
}

        private void button6_AddItem_Click(object sender, EventArgs e)
        {
            string brand_name = comboBox_BrandName.Text;
            string model_name = comboBox2_model.Text;
            string fuel_type = comboBox3_fuel.Text;
            string engine_capacity = comboBox4_engine.Text;
            string year = comboBox5_year.Text;
            string cat_name = comboBox6_category.Text;
            string part_name = comboBox7_part.Text;

            string Inventory_ItemCode;

            if (brand_name != "" && model_name != "" && fuel_type != "" && engine_capacity != "" && year != "" && cat_name != "" && part_name != "")
            {
                String[] ar = new String[4];
                DatabaseConnections db = new DatabaseConnections();

                string Brand_id = db.GetId(brand_name, "Brand");
                string Model_id = db.GetId(model_name, "Model");
                string Fuel_id = db.GetId(fuel_type, "Fuel");
                string Engine_Id = db.GetId(engine_capacity, "Engine");
                string Year_id = db.GetId(year, "Yearr");
                string Cat_id = db.GetId(cat_name, "Category");
                string Part_id = db.GetId(part_name, "SparePart");
                Inventory_ItemCode = Brand_id + Model_id + Fuel_id + Engine_Id + Year_id + Cat_id + Part_id;
                ar[0] = Inventory_ItemCode;
                ar[1] = db.getItemDetails_String(Inventory_ItemCode);
                ar[2] = db.get_unit_price("100"+Inventory_ItemCode);
                MessageBox.Show(Inventory_ItemCode);
                long QuantityHand = db.CheckQuantity(Inventory_ItemCode);

                if (QuantityHand >= 0)
                {
                   
                    
                    int quantity = Convert.ToInt16(quantity_box.Text);
                    ar[3] = quantity.ToString();

                    int total = Convert.ToInt16(total_box.Text);
                    int unit_pr = Convert.ToInt16(ar[2]);
                    // to get the sum

                    total = total + unit_pr * quantity;

                    //set total
                    total_box.Text = total.ToString();

                    // things to do :deduct from stock/print bill/record to log/ clear row etc.




                    ListViewItem itm = new ListViewItem(ar);
                    listView1.Items.Add(itm);

                    comboBox_BrandName.Text = null;
                    comboBox2_model.Text = null;
                    comboBox3_fuel.Text = null;
                    comboBox4_engine.Text = null;
                    comboBox5_year.Text = null;
                    comboBox6_category.Text = null;
                    comboBox7_part.Text = null;
                    quantity_box.Text= null;
                }
                else
                {
                    MessageBox.Show("Check all the fiels. Invalid Itemcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Can't keep empty fields", "Warinning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }




     

        
        


        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

           

        }

//}





       

      
    

