using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-B38G05Q;Initial Catalog=fitness_club;Integrated Security=True; TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();

            SqlDataReader input = new SqlCommand("select * from Clients", db).ExecuteReader();
            while (input.Read())
            {
                this.Text += $"{input["username"]}  |  ";
            }
        }
    }
}