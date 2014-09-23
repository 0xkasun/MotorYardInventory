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
    public partial class Reports : Form
    {
        public Reports(int index)
        {
            InitializeComponent();

            if (index == 1)
            {
                tabControl_Reports.SelectedTab = tabPageSales_Reports;
                tabPage_TaxesPayable_Reports.Enabled = false;
                tabPage_TaxesPayable_Reports.Enabled = false;
            }

            else if (index == 2)
            {
                tabControl_Reports.SelectedTab = tabPage_TotalIncome_Reports;
                tabPageSales_Reports.Enabled = false;
                tabPage_TaxesPayable_Reports.Enabled = false;
            }

            else if (index == 3)
            {
                tabControl_Reports.SelectedTab = tabPage_TaxesPayable_Reports;
                tabPageSales_Reports.Enabled = false;
                tabPage_TotalIncome_Reports.Enabled = false;
            }

        }
    }
}
