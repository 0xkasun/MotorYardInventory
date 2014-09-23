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
    public partial class Customers : Form
    {
        public Customers(int index)
        {
            InitializeComponent();

            if (index == 1)
            {
                tabControl_Customers.SelectedTab = tabPage_Ratings_Customers;
                tabPage_Requests_Customers.Enabled = false;
                tabPage_DiscountOffered_Customers.Enabled = false;
            }

            else if (index == 2)
            {
                tabControl_Customers.SelectedTab = tabPage_DiscountOffered_Customers;
                tabPage_Ratings_Customers.Enabled = false;
                tabPage_Requests_Customers.Enabled = false;
            }

            else if (index == 3)
            {
                tabControl_Customers.SelectedTab = tabPage_Requests_Customers;
                tabPage_Ratings_Customers.Enabled = false;
                tabPage_DiscountOffered_Customers.Enabled = false;
            }
        }
    }
}
