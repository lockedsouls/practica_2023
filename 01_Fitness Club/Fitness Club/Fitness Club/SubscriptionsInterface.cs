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
    public partial class SubscriptionsInterface : Form
    {
        SqlConnection db;
        int user_id = -1;
        public SubscriptionsInterface(SqlConnection db, int user_id)
        {
            InitializeComponent();
            this.db = db;
            this.user_id = user_id;

            if (this.db.State != System.Data.ConnectionState.Open) this.db.Open();
            SqlDataReader q = new SqlCommand("select * from Subscriptions", db).ExecuteReader();
            while (q.Read())
            {
                switch (q["name"])
                {
                    case "Standart":
                        standart_priceL.Text = q["price"].ToString(); break;
                    case "Gold":
                        gold_priceL.Text = q["price"].ToString(); break;
                    case "Platinum":
                        plat_priceL.Text = q["price"].ToString(); break;
                    case "Diamond":
                        diamond_priceL.Text = q["price"].ToString(); break;
                }
            }
            q.Close();

            q = new SqlCommand($"select * from Clients where id = {this.user_id}", db).ExecuteReader();
            while (q.Read())
            {
                user_cashL.Text = $"${q["cash"]}";
            }
            q.Close();

            SqlDataReader reader =
            new SqlCommand($"select * from Subscriptions where id = (select subscription from Clients where id = {this.user_id})"
            , db).ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    switch (reader["name"])
                    {
                        case "Standart":
                            buy_standart.BackColor = Color.DarkGreen;
                            buy_standart.ForeColor = Color.White;
                            buy_standart.Text = "Purchased";
                            buy_standart.Enabled = false; break;
                        case "Gold":
                            buy_gold.BackColor = Color.DarkGreen;
                            buy_gold.ForeColor = Color.White;
                            buy_gold.Text = "Purchased";
                            buy_gold.Enabled = false; break;
                        case "Platinum":
                            buy_plat.BackColor = Color.DarkGreen;
                            buy_plat.ForeColor = Color.White;
                            buy_plat.Text = "Purchased";
                            buy_plat.Enabled = false; break;
                        case "Diamond":
                            buy_diam.BackColor = Color.DarkGreen;
                            buy_diam.ForeColor = Color.White;
                            buy_diam.Text = "Purchased";
                            buy_diam.Enabled = false; break;
                    }
                }
            }
            reader.Close();
            this.db.Close();
        }

        private void buy_standart_Click(object sender, EventArgs e)
        {
            if (!buy_standart.Enabled) return;
            bool good = false;

            this.db.Open();
            SqlDataReader reader = new SqlCommand($"select * from Clients where id = {this.user_id}", this.db).ExecuteReader();

            while (reader.Read())
            {
                if (
                    float.Parse(reader["cash"].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                    <
                    float.Parse(standart_priceL.Text, CultureInfo.InvariantCulture.NumberFormat))
                        good = false;
                else good = true;
            }

            reader.Close();

            if (good)
            {
                new SqlCommand($"" +
                    $"update Clients set " +
                    $"subscription = (select id from Subscriptions where name = 'Standart'), " +
                    $"cash = cash - (select price from Subscriptions where name = 'Standart') " +
                    $"where id = {this.user_id}"
                    , this.db).ExecuteNonQuery();

                SubscriptionsInterface temp = new SubscriptionsInterface(this.db, this.user_id);
                temp.Show();
                this.Close();
            }
            else MessageBox.Show("You don't have enouch cash, aka, you're BROKE", "INSUFFICIENT FUNDS");

            this.db.Close();
        }

        private void buy_gold_Click(object sender, EventArgs e)
        {
            if (!buy_gold.Enabled) return;
            bool good = false;

            this.db.Open();
            SqlDataReader reader = new SqlCommand($"select * from Clients where id = {this.user_id}", this.db).ExecuteReader();

            while (reader.Read())
            {
                if (
                    float.Parse(reader["cash"].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                    <
                    float.Parse(gold_priceL.Text, CultureInfo.InvariantCulture.NumberFormat))
                    good = false;
                else good = true;
            }

            reader.Close();

            if (good)
            {
                new SqlCommand($"" +
                    $"update Clients set " +
                    $"subscription = (select id from Subscriptions where name = 'Gold'), " +
                    $"cash = cash - (select price from Subscriptions where name = 'Gold') " +
                    $"where id = {this.user_id}"
                    , this.db).ExecuteNonQuery();

                SubscriptionsInterface temp = new SubscriptionsInterface(this.db, this.user_id);
                temp.Show();
                this.Close();
            }
            else MessageBox.Show("You don't have enouch cash, aka, you're BROKE", "INSUFFICIENT FUNDS");

            this.db.Close();
        }

        private void buy_plat_Click(object sender, EventArgs e)
        {
            if (!buy_plat.Enabled) return;
            bool good = false;

            this.db.Open();
            SqlDataReader reader = new SqlCommand($"select * from Clients where id = {this.user_id}", this.db).ExecuteReader();

            while (reader.Read())
            {
                if (
                    float.Parse(reader["cash"].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                    <
                    float.Parse(plat_priceL.Text, CultureInfo.InvariantCulture.NumberFormat))
                    good = false;
                else good = true;
            }

            reader.Close();

            if (good)
            {
                new SqlCommand($"" +
                    $"update Clients set " +
                    $"subscription = (select id from Subscriptions where name = 'Platinum'), " +
                    $"cash = cash - (select price from Subscriptions where name = 'Platinum') " +
                    $"where id = {this.user_id}"
                    , this.db).ExecuteNonQuery();

                SubscriptionsInterface temp = new SubscriptionsInterface(this.db, this.user_id);
                temp.Show();
                this.Close();
            }
            else MessageBox.Show("You don't have enouch cash, aka, you're BROKE", "INSUFFICIENT FUNDS");

            this.db.Close();
        }

        private void buy_diam_Click(object sender, EventArgs e)
        {
            if (!buy_diam.Enabled) return;
            bool good = false;

            this.db.Open();
            SqlDataReader reader = new SqlCommand($"select * from Clients where id = {this.user_id}", this.db).ExecuteReader();

            while (reader.Read())
            {
                if (
                    float.Parse(reader["cash"].ToString(), CultureInfo.InvariantCulture.NumberFormat)
                    <
                    float.Parse(diamond_priceL.Text, CultureInfo.InvariantCulture.NumberFormat))
                    good = false;
                else good = true;
            }

            reader.Close();

            if (good)
            {
                new SqlCommand($"" +
                    $"update Clients set " +
                    $"subscription = (select id from Subscriptions where name = 'Diamond'), " +
                    $"cash = cash - (select price from Subscriptions where name = 'Diamond') " +
                    $"where id = {this.user_id}"
                    , this.db).ExecuteNonQuery();

                SubscriptionsInterface temp = new SubscriptionsInterface(this.db, this.user_id);
                temp.Show();
                this.Close();
            }
            else MessageBox.Show("You don't have enouch cash, aka, you're BROKE", "INSUFFICIENT FUNDS");

            this.db.Close();
        }
    }
}
