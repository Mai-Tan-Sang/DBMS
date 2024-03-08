using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FMenu : Form
    {
        SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.cnnString);
        public FMenu()
        {
            InitializeComponent();
            string sql = "SELECT* FROM Menu";
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, sqlCon);
            dap.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

    }
}
