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
using System.Globalization;

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
            button1.Enabled = true;
            button2.Enabled = true;
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns[0].ReadOnly = true;
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
            button1.Enabled = true;
            button2.Enabled = true;
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns[0].ReadOnly = true;
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
            button1.Enabled = true;
            button2.Enabled = true;
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns[0].ReadOnly = true;
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
            button1.Enabled = true;
            button2.Enabled = true;
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns[0].ReadOnly = true;
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
            button1.Enabled = false;
            button2.Enabled = false;
            row_id = -1;
            data_source = new DataTable();
            data_source.Columns.Add("id");
            data_source.Columns[0].ReadOnly = true;
            data_source.Columns.Add("name");
            data_source.Columns[1].ReadOnly = true;
            data_source.Columns.Add("price");
            data_source.Columns[2].ReadOnly = true;
            data_source.Columns.Add("free_service");
            data_source.Columns[3].ReadOnly = true;
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
           try
           {
                this.db.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null) continue;
                    switch (tableL.Text)
                    {
                        case "Personal":
                            {
                                int role_id = Int32.Parse(row.Cells[4].Value.ToString());
                                SqlDataReader reader = new SqlCommand($"select * from Roles where id = {role_id}", this.db).ExecuteReader();

                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Invalid role id");
                                    reader.Close();
                                    break;
                                }
                                reader.Close();

                                new SqlCommand($"update Personal set username = '{row.Cells[1].Value}', password = '{row.Cells[2].Value}', role_id = {role_id} ,cash = {row.Cells[3].Value} where id = {row.Cells[0].Value}", this.db).ExecuteNonQuery();
                                break;
                            }
                        case "Clients":
                            {
                                int sub = Int32.Parse(row.Cells[4].Value.ToString());
                                SqlDataReader reader = new SqlCommand($"select * from Subscriptions where id = {sub}", this.db).ExecuteReader();

                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Invalid subscription id");
                                    reader.Close();
                                    break;
                                }
                                reader.Close();
                                new SqlCommand($"update Clients set username = '{row.Cells[1].Value}', password = '{row.Cells[2].Value}', subscription = {sub}, cash = {row.Cells[3].Value} where id = {row.Cells[0].Value}", this.db).ExecuteNonQuery();
                                break;
                            }
                        case "Roles":
                            {
                                new SqlCommand($"update Roles set role = '{row.Cells[1].Value}', salary = {row.Cells[2].Value} where id = {row.Cells[0].Value}", this.db).ExecuteNonQuery();
                                break;
                            }
                        case "Services":
                            {
                                new SqlCommand($"update Services set name = '{row.Cells[1].Value}', price = {row.Cells[2].Value} where id = {row.Cells[0].Value}", this.db).ExecuteNonQuery();
                                break;
                            }
                        case "Subscriptions":
                            {
                                int ser = Int32.Parse(row.Cells[3].Value.ToString());
                                SqlDataReader reader = new SqlCommand($"select * from Services where id = {ser}", this.db).ExecuteReader();

                                if (!reader.HasRows)
                                {
                                    MessageBox.Show("Invalid service id");
                                    reader.Close();
                                    break;
                                }
                                reader.Close();
                                new SqlCommand($"update Subscriptions set name = '{row.Cells[1].Value}', price = {row.Cells[2].Value}, free_service = {ser} where id = {row.Cells[0].Value}", this.db).ExecuteNonQuery();
                                break;
                            }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.db.Close();
            }
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
        }
    }
}
