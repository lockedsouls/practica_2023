using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class Form1 : Form
    {
        SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-B38G05Q;Initial Catalog=fitness_club;Integrated Security=True; TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm(db);
            f.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void regB_Click(object sender, EventArgs e)
        {

        }

        private void jobB_Click(object sender, EventArgs e)
        {

        }
    }
}