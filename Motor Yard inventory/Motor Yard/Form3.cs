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

        
    }
}
