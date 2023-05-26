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

        DataGridView Clients = new DataGridView();
        DataGridView Personal = new DataGridView();
        DataGridView Roles = new DataGridView();
        DataGridView Services = new DataGridView();
        DataGridView Subscriptions = new DataGridView();

        DataTable clients_src = new DataTable();
        DataTable personal_src = new DataTable();
        DataTable roles_src = new DataTable();
        DataTable services_src = new DataTable();
        DataTable subscriptions_src = new DataTable();

        string selected_table = "";
        int width = 784; int height = 470;
        int x = 14; int y = 40;
        public DB__RUD(SqlConnection db)
        {
            InitializeComponent();
            this.db = db;

            clients_src.Columns.Add("id");
            clients_src.Columns.Add("username");
            clients_src.Columns.Add("password");
            clients_src.Columns.Add("cash");
            clients_src.Columns.Add("subscription");
            Clients.DataSource = clients_src;
            Clients.Size = new Size(width, height);
            Clients.Location = new Point(x, y);

            splitContainer1.Panel2.Controls.Add(Clients);
            tableL.Text = "Clients";
            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Clients", this.db).ExecuteReader();
            while (reader.Read())
            {
                clients_src.Rows.Add(reader["id"], reader["username"], reader["password"], reader["cash"], reader["subscription"]);
            }
            reader.Close();
            this.db.Close();
            selected_table = "Clients";

            personal_src.Columns.Add("id");
            personal_src.Columns.Add("username");
            personal_src.Columns.Add("password");
            personal_src.Columns.Add("cash");
            personal_src.Columns.Add("role");
            Personal.DataSource = personal_src;
            Personal.Size = new Size(width, height);
            Personal.Location = new Point(x, y);

            roles_src.Columns.Add("id");
            roles_src.Columns.Add("role");
            roles_src.Columns.Add("salary");
            Roles.DataSource = roles_src;
            Roles.Size = new Size(width, height);
            Roles.Location = new Point(x, y);

            services_src.Columns.Add("id");
            services_src.Columns.Add("name");
            services_src.Columns.Add("price");
            Services.DataSource = services_src;
            Services.Size = new Size(width, height);
            Services.Location = new Point(x, y);

            subscriptions_src.Columns.Add("id");
            subscriptions_src.Columns.Add("name");
            subscriptions_src.Columns.Add("price");
            subscriptions_src.Columns.Add("free_service");
            Subscriptions.DataSource = subscriptions_src;
            Subscriptions.Size = new Size(width, height);
            Subscriptions.Location = new Point(x, y);
        }

        private void serv_Click(object sender, EventArgs e)
        {
            if (selected_table == "Services") return;
            tableL.Text = "Services";
            removeTable();
            splitContainer1.Panel2.Controls.Add(Services);

            services_src.Rows.Clear();
            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Services", this.db).ExecuteReader();
            while (reader.Read())
            {
                services_src.Rows.Add(reader["id"], reader["name"], reader["price"]);
            }
            reader.Close();
            this.db.Close();
        }

        private void pers_Click(object sender, EventArgs e)
        {
            if (selected_table == "Personal") return;
            tableL.Text = "Personal";
        }

        private void roles_Click(object sender, EventArgs e)
        {
            if (selected_table == "Roles") return;
            tableL.Text = "Roles";
        }

        private void client_Click(object sender, EventArgs e)
        {
            if (selected_table == "Clients") return;
            tableL.Text = "Clients";
            removeTable();
            splitContainer1.Panel2.Controls.Add(Clients);

            clients_src.Rows.Clear();
            this.db.Open();
            SqlDataReader reader = new SqlCommand("select * from Clients", this.db).ExecuteReader();
            while (reader.Read())
            {
                clients_src.Rows.Add(reader["id"], reader["username"], reader["password"], reader["cash"], reader["subscription"]);
            }
            reader.Close();
            this.db.Close();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (selected_table == "Subscriptions") return;
            tableL.Text = "Subscriptions";
        }

        private void removeTable()
        {
            switch (selected_table)
            {
                case "Clients": splitContainer1.Panel2.Controls.Remove(Clients); break;
                case "Personal": splitContainer1.Panel2.Controls.Remove(Personal); break;
                case "Services": splitContainer1.Panel2.Controls.Remove(Services); break;
                case "Subscriptions": splitContainer1.Panel2.Controls.Remove(Subscriptions); break;
                case "Roles": splitContainer1.Panel2.Controls.Remove(Services); break;
            }
        }
    }
}
