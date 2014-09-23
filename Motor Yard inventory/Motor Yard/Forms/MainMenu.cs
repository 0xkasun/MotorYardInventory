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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            lg.Show();
            this.Hide();
        }
    }
}
