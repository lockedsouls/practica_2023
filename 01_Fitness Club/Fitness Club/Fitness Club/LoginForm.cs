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
        string table = "";
        public LoginForm(SqlConnection db, bool type)
        {
            InitializeComponent();
            this.db = db;
            //1 empl, 0 client
            this.table = (type) ? "Personal" : "Clients";

            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id = -1;
            string usrm = "";
            db.Open();
            SqlDataReader q = new SqlCommand($"select * from {table} where username = '{username.Text}' and password = '{password.Text}'", db).ExecuteReader();
            if (q.HasRows)
            {
                //open main interface with params
                while (q.Read())
                {
                    user_id = Int32.Parse(q["id"].ToString());
                    usrm = q["username"].ToString();
                }
                q.Close();
                db.Close();

                if (table == "Personal")
                {
                    EmployeePanel f = new EmployeePanel(db, user_id, usrm);
                    f.Show();
                }
                else
                {
                    ClientInterface f = new ClientInterface(db, user_id, usrm);
                    f.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found!", "ERROR");
                db.Close();
            }
        }
    }
}
