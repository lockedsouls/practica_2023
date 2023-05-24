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
using System.Text.RegularExpressions;

namespace Fitness_Club
{
    public partial class ClientReg : Form
    {
        SqlConnection db;
        public ClientReg(SqlConnection db)
        {
            InitializeComponent();
            this.db = db;
            password.PasswordChar = '*';
            rpassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error_msgs = "";
            if (username.Text.Length < 4) error_msgs += "Username should be longer than 4 characters\n";
            if (password.Text.Length < 6) error_msgs += "Password should be longer than 6 characters\n";
            if (password.Text != rpassword.Text) error_msgs += "Passwords don't match\n";
            if (!new Regex("^[0-9]+(.[0-9]+)?$").IsMatch(cash.Text)) error_msgs += "Invalid cash value\n";

            if (error_msgs != "") MessageBox.Show(error_msgs, "ERROR");
            else
            {
                this.db.Open();
                new SqlCommand($"insert into Clients values('{username.Text}', '{password.Text}', null, {cash.Text})", this.db).ExecuteNonQuery();
                if (MessageBox.Show("Account successfully created. Do you wish to log in?", "SUCCESS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlDataReader reader = new SqlCommand("select top 1 * from Clients order by id desc", this.db).ExecuteReader();
                    while (reader.Read())
                    {
                        ClientInterface f = new ClientInterface(this.db, Int32.Parse(reader["id"].ToString()), reader["username"].ToString());
                        f.Show();
                    }

                    reader.Close();
                    this.db.Close();
                    this.Close();
                }
                else
                {
                    this.db.Close();
                    this.Close();
                }
            }
        }
    }
}
