using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club
{
    public partial class DB__RUD : Form
    {
        SqlConnection db;
        DataTable data_source;

        int row_id = -1;
        int row_index = -1;
        int row_column = -1;
        public DB__RUD(SqlConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void serv_Click(object sender, EventArgs e)
        {
            tableL.Text = "Services";
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns.Add("name");
            data_source.Columns.Add("price");

            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Services", this.db).ExecuteReader();
            while (reader.Read())
            {
                data_source.Rows.Add(reader["id"], reader["name"], reader["price"]);
            }
            reader.Close();
            this.db.Close();
            dataGridView1.DataSource = data_source;
        }

        private void pers_Click(object sender, EventArgs e)
        {
            tableL.Text = "Personal";
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns.Add("username");
            data_source.Columns.Add("password");
            data_source.Columns.Add("cash");
            data_source.Columns.Add("role");

            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Personal", this.db).ExecuteReader();
            while (reader.Read())
            {
                data_source.Rows.Add(reader["id"], reader["username"], reader["password"], reader["cash"], reader["role_id"]);
            }
            reader.Close();
            this.db.Close();
            dataGridView1.DataSource = data_source;
        }

        private void roles_Click(object sender, EventArgs e)
        {
            tableL.Text = "Roles";
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns.Add("role");
            data_source.Columns.Add("salary");
            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Roles", this.db).ExecuteReader();
            while (reader.Read())
            {
                data_source.Rows.Add(reader["id"], reader["role"], reader["salary"]);
            }
            reader.Close();
            this.db.Close();
            dataGridView1.DataSource = data_source;
        }

        private void client_Click(object sender, EventArgs e)
        {
            tableL.Text = "Clients";
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns.Add("username");
            data_source.Columns.Add("password");
            data_source.Columns.Add("cash");
            data_source.Columns.Add("subscription");

            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Clients", this.db).ExecuteReader();
            while (reader.Read())
            {
                data_source.Rows.Add(reader["id"], reader["username"], reader["password"], reader["cash"], reader["subscription"]);
            }
            reader.Close();
            this.db.Close();
            dataGridView1.DataSource = data_source;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            tableL.Text = "Subscriptions";
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns.Add("name");
            data_source.Columns.Add("price");
            data_source.Columns.Add("free_service");
            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Subscriptions", this.db).ExecuteReader();
            while (reader.Read())
            {
                data_source.Rows.Add(reader["id"], reader["name"], reader["price"], reader["free_service"]);
            }
            reader.Close();
            this.db.Close();
            dataGridView1.DataSource = data_source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = $"{tableL.Text} {row_id}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.db.Open();
            new SqlCommand($"delete from {tableL.Text} where id = {row_id}", this.db).ExecuteNonQuery();
            this.db.Close();
            dataGridView1.Rows.RemoveAt(row_index);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = e.RowIndex;
            row_column = e.ColumnIndex;
            row_id = Int32.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
        }
    }
}
