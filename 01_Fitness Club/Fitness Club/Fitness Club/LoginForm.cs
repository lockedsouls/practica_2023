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
    public partial class LoginForm : Form
    {
        SqlConnection db;
        public LoginForm(SqlConnection db)
        {
            InitializeComponent();
            this.db = db;

            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Open();
            SqlDataReader q = new SqlCommand($"select * from Clients where username = '{username.Text}' and password = '{password.Text}'", db).ExecuteReader();
            if (q.HasRows)
            {
                //open main interface with params
                while (q.Read())
                {
                    ClientInterface f = new ClientInterface(db, Int32.Parse(q["id"].ToString()), q["username"].ToString());
                    f.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("User not found!", "ERROR");
            }
            db.Close();
        }
    }
}
