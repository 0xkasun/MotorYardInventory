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
    class DatabaseConnection
    {
        String connectionStr = ConfigurationManager.connectionStrings["Motor_Yard.Properties.Settings.web_inventoryConnectionString"].connectionString;
        con.ConnectionString =@connectionStr;
        cmd.Connecton =con;
    }

    OleDbConnection con =new OldDbConnection();
}
