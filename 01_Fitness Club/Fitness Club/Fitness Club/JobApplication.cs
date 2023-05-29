using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club
{
    public partial class JobApplication : Form
    {
        SqlConnection db;
        Dictionary<string, string> rolesList = new Dictionary<string, string>();
        public JobApplication(SqlConnection db)
        {

            InitializeComponent();
            this.db = db;
            password.PasswordChar = '*';
            rpassword.PasswordChar = '*';

            this.db.Open();

            SqlDataReader reader = new SqlCommand("select * from Roles", this.db).ExecuteReader();
            while (reader.Read())
            {
                roles.Items.Add($"{reader["role"]}");
                rolesList.Add(reader["role"].ToString(), $"{reader["salary"]} | {reader["id"]}");
            }
            reader.Close();

            this.db.Close();
            roles.SelectedIndex = 0;
        }

        private void roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.Text = "$" + rolesList[roles.Items[roles.SelectedIndex].ToString()].Substring(0, rolesList[roles.Items[roles.SelectedIndex].ToString()].IndexOf("|"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.db.Open();
            SqlDataReader q = new SqlCommand($"select * from Personal where username = '{username.Text}'", this.db).ExecuteReader();
            string error_msgs = "";
            if (q.HasRows) error_msgs += "User already exists\n";
            this.db.Close();
            if (username.Text.Length < 4) error_msgs += "Username should be longer than 4 characters\n";
            if (password.Text.Length < 6) error_msgs += "Password should be longer than 6 characters\n";
            if (password.Text != rpassword.Text) error_msgs += "Passwords don't match\n";

            if (error_msgs != "") MessageBox.Show(error_msgs, "ERROR");
            else
            {
                if (new Random().Next(0, 101) % 2 == 0)
                {
                    this.db.Open();
                    new SqlCommand($"insert into Personal values('{username.Text}', '{password.Text}', {rolesList[roles.Items[roles.SelectedIndex].ToString()].Substring(rolesList[roles.Items[roles.SelectedIndex].ToString()].IndexOf("|") + 2)}, 0)", this.db).ExecuteNonQuery();
                    if (MessageBox.Show("Account successfully created. Do you wish to log in?", "SUCCESS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int user_id = -1;
                        SqlDataReader reader = new SqlCommand("SELECT TOP 1 * FROM Personal ORDER BY ID DESC", this.db).ExecuteReader();
                        while (reader.Read())
                        {
                            user_id = Int32.Parse(reader["id"].ToString());
                        }
                        this.db.Close();
                        EmployeePanel f = new EmployeePanel(this.db, user_id, username.Text);
                        f.Show();
                        this.Close();
                    }
                    else
                    {
                        this.db.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You do not qualify for this job, try again!");
                    this.Close();
                };
            }
        }
    }
}
