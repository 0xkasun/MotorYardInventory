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
    public partial class Stock_Control : Form
    {
        public Stock_Control(int index)
        {
            InitializeComponent();

            if (index == 1) 
            {
                tabControl1.SelectedTab = tabPageAddNewStock;
                tabPageClearStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 2) 
            {
                tabControl1.SelectedTab = tabPageUpdateStock;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageClearStock.Enabled = false;
            }

            else if (index == 3)
            {
                tabControl1.SelectedTab = tabPageDeleteStock;
                tabPageAddNewStock.Enabled = false;
                tabPageClearStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 4)
            {
                tabControl1.SelectedTab = tabPageClearStock;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageStockStatus.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

            else if (index == 5)
            {
                tabControl1.SelectedTab = tabPageStockStatus;
                tabPageAddNewStock.Enabled = false;
                tabPageDeleteStock.Enabled = false;
                tabPageClearStock.Enabled = false;
                tabPageUpdateStock.Enabled = false;
            }

        }
        long brand_id;
        long cinId;
        long model_id;
        long fuel_id;
        long engine_id;
        long year;
        long cat_id;
        long part_id;
        long quantity_in;
        long unit_price;
        string brand_name;
        string model_name;
        string fuel_type;
        long engine_capacity;
        string cat_name;
        string part_name;


        private void pictureBoxClearButton_Click(object sender, EventArgs e)
        {
            String itemCode = textBox_ItemCode_ClearStock.Text;
            String repeatitemCode = textBox_RepeatItemCode_ClearStock.Text;

            if (itemCode == repeatitemCode)
            {
                DialogResult confirm = MessageBox.Show("ItemCode : " + itemCode + "\nQuantity on Hand : " + 12, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    DatabaseConnections db = new DatabaseConnections();
                    db.Clearstock(itemCode);
                    textBox_RepeatItemCode_ClearStock.Text = "";
                    textBox_ItemCode_ClearStock.Text = "";
                }
            }

            else
            {
                MessageBox.Show("Check Item Code", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxDeleteButton_Click(object sender, EventArgs e)
        {
            String itemCode = textBox_ItemCode_DeleteStock.Text;
            String repeatitemCode = textBox_RepeatItemCode_DeleteStock.Text;

            if (itemCode == repeatitemCode)
            {
                MessageBox.Show("ItemCode : " + itemCode + "\n Item Name : Door ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            else
            {
                MessageBox.Show("Check Item Code", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxUpdateButton_Click(object sender, EventArgs e)
        {
            string itemCode = textBox_ItemCode_UpdateStock.Text;
            string QuantityIn = textBox_QuantityIn_UpdateStock.Text;
            DatabaseConnections db = new DatabaseConnections();
            long QuantityHand = db.CheckQuantity(itemCode);
            string Qh = Convert.ToString(QuantityHand);
            textBox_QuantityOnHand_UpdateStock.Text = Qh;
            if (QuantityHand > 0)
            {
                DialogResult result1 = MessageBox.Show("Item Code : " + itemCode + "\nQuantity In : " + QuantityIn, "Verify Item Code and Quantity In", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == DialogResult.OK)
                {
                    DatabaseConnections db2 = new DatabaseConnections();
                    db2.UpdateStock(itemCode, QuantityIn);
                    textBox_ItemCode_UpdateStock.Text = null;
                    textBox_QuantityIn_UpdateStock.Text = null;
                    textBox_QuantityOnHand_UpdateStock.Text = null;
                }
                if (result1 == DialogResult.Cancel)
                {
                    textBox_ItemCode_UpdateStock.Text = null;
                    textBox_QuantityIn_UpdateStock.Text = null;
                    textBox_QuantityOnHand_UpdateStock.Text = null;
                }
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Check Item code : " + itemCode, "Invalid Item Code", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result2 == DialogResult.Retry)
                {
                    textBox_ItemCode_UpdateStock.Text = null;
                    textBox_QuantityIn_UpdateStock.Text = null;
                    textBox_QuantityOnHand_UpdateStock.Text = null;
                }

                if (result2 == DialogResult.Cancel)
                {
                    Main_Menu main_menu = new Main_Menu();
                    main_menu.Show();
                    this.Hide();
                }
            }
        }

        private void pictureBoxAddButton_Click(object sender, EventArgs e)
        {

            brand_id = Convert.ToInt64(textBoxBrandId_AddStock.Text);
            model_id = Convert.ToInt64(textBoxModelId_AddStock.Text);
            fuel_id = Convert.ToInt64(textBoxFuelId_AddStock.Text);
            engine_id = Convert.ToInt64(textBoxEngineId_AddStock.Text);
            year=Convert.ToInt64(textBoxYear_AddStock.Text);
            cat_id = Convert.ToInt64(textBoxCatId_AddStock.Text);
            part_id = Convert.ToInt64(textBoxPartId_AddStock.Text);
            quantity_in=Convert.ToInt64(textBoxQuantityIn_AddStock.Text);
            unit_price = Convert.ToInt64(textBoxUnitPrice_AddStock.Text);
            brand_name=comboBoxBrandName_AddStock.Text;
            model_name=comboBoxModelName_AddStock.Text;
            fuel_type=comboBoxFuelType_AddStock.Text;
            engine_capacity = Convert.ToInt64(comboBoxEngineCapacity_AddStock.Text);
            cat_name=comboBoxCatName_AddStock.Text;
            part_name=comboBoxPartName_AddStock.Text;


            DatabaseConnections db=new DatabaseConnections();
            db.AddNewStock( brand_id, brand_name, model_id, model_name, fuel_id, fuel_type, engine_id, engine_capacity, year, year,cat_id, cat_name, part_id, part_name, quantity_in,unit_price) ;

            textBoxBrandId_AddStock.Text = null;
            textBoxModelId_AddStock.Text = null;
            textBoxFuelId_AddStock.Text = null;
            textBoxEngineId_AddStock.Text = null;
            textBoxYear_AddStock.Text = null;
            textBoxCatId_AddStock.Text = null;
            textBoxPartId_AddStock.Text = null;
            textBoxQuantityIn_AddStock.Text = null;
            textBoxUnitPrice_AddStock.Text = null;
            comboBoxBrandName_AddStock.Text = null;
            comboBoxModelName_AddStock.Text = null;
            comboBoxFuelType_AddStock.Text = null;
            comboBoxEngineCapacity_AddStock.Text = null;
            comboBoxCatName_AddStock.Text = null;
            comboBoxPartName_AddStock.Text = null;
        }

        private void textBox_QuantityIn_UpdateStock_MouseClick(object sender, MouseEventArgs e)
        {
            string itemCode = textBox_ItemCode_UpdateStock.Text;
            DatabaseConnections db = new DatabaseConnections();
            long QuantityHand = db.CheckQuantity(itemCode);
            string Qh = Convert.ToString(QuantityHand);
            textBox_QuantityOnHand_UpdateStock.Text = Qh;
        }

        private void comboBoxBrandName_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxBrandName_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id1 = db.GetId(check, "Brand");
                string ItemId1 = Convert.ToString(Id1);
                textBoxBrandId_AddStock.Text = ItemId1;
            }

            else
            {
                textBoxBrandId_AddStock.Text = "";
            }
            

        }

        private void comboBoxModelName_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxModelName_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id2 = db.GetId(check, "Model");
                string ItemId2 = Convert.ToString(Id2);
                textBoxModelId_AddStock.Text = ItemId2;
            }

            else
            {
                textBoxModelId_AddStock.Text = "";
            }
        }

        private void comboBoxFuelType_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxFuelType_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id3 = db.GetId(check, "Fuel");
                string ItemId3 = Convert.ToString(Id3);
                textBoxFuelId_AddStock.Text = ItemId3;
            }

            else
            {
                textBoxFuelId_AddStock.Text = "";
            }
        }

        private void comboBoxEngineCapacity_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxEngineCapacity_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id4 = db.GetId(check, "Engine");
                string ItemId4 = Convert.ToString(Id4);
                textBoxEngineId_AddStock.Text = ItemId4;
            }

            else
            {
                textBoxEngineId_AddStock.Text = "";
            }
        }

        private void comboBoxCatName_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxCatName_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id5 = db.GetId(check, "Category");
                string ItemId5 = Convert.ToString(Id5);
                textBoxCatId_AddStock.Text = ItemId5;
            }

            else
            {
                textBoxCatId_AddStock.Text = "";
            }
        }

        private void comboBoxPartName_AddStock_TextChanged(object sender, EventArgs e)
        {
            string check = comboBoxPartName_AddStock.Text;
            if (check != "")
            {
                DatabaseConnections db = new DatabaseConnections();
                long Id6 = db.GetId(check, "SparePart");
                string ItemId6 = Convert.ToString(Id6);
                textBoxPartId_AddStock.Text = ItemId6;
            }

            else
            {
                textBoxPartId_AddStock.Text = "";
            }
        }
    
    }
}
