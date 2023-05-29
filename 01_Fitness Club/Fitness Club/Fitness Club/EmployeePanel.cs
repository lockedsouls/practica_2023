using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club
{
    public partial class EmployeePanel : Form
    {
        SqlConnection db;
        int user_id;
        float salary = 0;
        float amount = 0;
        public EmployeePanel(SqlConnection db, int user_id, string username)
        {
            InitializeComponent();
            button1.MouseLeave += new EventHandler(button1_Leave);
            this.db = db;
            this.user_id = user_id;

            usernameL.Text = username;

            if (this.db.State == ConnectionState.Closed) this.db.Open();
            SqlDataReader reader = new SqlCommand($"select * from Personal where id = {this.user_id}", this.db).ExecuteReader();
            while (reader.Read())
            {
                cash.Text = $"${reader["cash"]}";
            }
            reader.Close();

            reader = new SqlCommand($"select *, (select salary from Roles where id = Personal.role_id) as salary from Personal where Personal.id = {this.user_id}", this.db).ExecuteReader();
            while (reader.Read())
            {
                salary = float.Parse(reader["salary"].ToString(), CultureInfo.InvariantCulture.NumberFormat);
            }

            reader.Close();

            reader = new SqlCommand($"select * from Personal where role_id = (select id from Roles where role = 'Manager') and Personal.id = {this.user_id}", this.db).ExecuteReader();
            if (!reader.HasRows)
            {
                button2.Visible = false;
                button2.Enabled = false;
            }
            reader.Close();
            this.db.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amount = float.Parse(cash.Text.Substring(1), CultureInfo.InvariantCulture.NumberFormat) + salary;
            cash.Text = $"${float.Parse(cash.Text.Substring(1), CultureInfo.InvariantCulture.NumberFormat) + salary}";
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            if (amount == 0) return;
            this.db.Open();

            new SqlCommand($"update Personal set cash={amount} where id={this.user_id}", this.db).ExecuteNonQuery();
            MessageBox.Show($"Due to your hard work, ${amount} were added to your account", "MONEY", MessageBoxButtons.OK, MessageBoxIcon.Information);
            amount = 0;

            this.db.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB__RUD f = new DB__RUD(this.db);
            f.Show();
        }
    }
}
