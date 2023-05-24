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
    public partial class ClientInterface : Form
    {
        SqlConnection db;
        int user_id = -1;
        public ClientInterface(SqlConnection db, int user_id, string username)
        {
            InitializeComponent();
            this.db = db;
            this.user_id = user_id;

            usernameL.Text = username;
        }

        private void subscriptions_Click(object sender, EventArgs e)
        {
            SubscriptionsInterface f = new SubscriptionsInterface();
            f.Show();
        }
    }
}
