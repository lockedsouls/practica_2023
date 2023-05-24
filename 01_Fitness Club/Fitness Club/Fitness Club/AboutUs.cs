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

namespace Fitness_Club
{
    public partial class AboutUs : Form
    {
        SqlConnection db;
        public AboutUs(SqlConnection db)
        {
            InitializeComponent();
            this.db = db;

            this.db.Open();

            SqlDataReader reader = new SqlCommand("select * from Services", this.db).ExecuteReader();
            int counter = 1;
            servicesL.Text = "";
            while (reader.Read())
            {
                servicesL.Text += $"{counter}. {reader["name"]} - ${reader["price"]}\n";
                counter++;
            }
            reader.Close();

            this.db.Close();
        }
    }
}
