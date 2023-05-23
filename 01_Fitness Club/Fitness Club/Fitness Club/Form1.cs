using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class Form1 : Form
    {
        public static SqlConnection db = new SqlConnection(@"Data Source=DESKTOP-B38G05Q;Initial Catalog=fitness_club;Integrated Security=True; TrustServerCertificate=True");

        Label title = new Label();
        Label title2 = new Label();
        Button login = new Button();
        Button regis = new Button();
        Button info = new Button();
        public Form1()
        {
            InitializeComponent();

            db.Open();
            if (db.State == System.Data.ConnectionState.Open)
            {
                this.Size = new Size(1000, 700);

                title.Text = "Welcome to ";
                title.Font = new Font("Segoe UI", 20);
                title.AutoSize = true;
                title.Location = new Point(450 - title.Width, 100 - title.Height);

                title2.Text = "Fitness Club!";
                title2.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                title2.ForeColor = Color.Blue;
                title2.AutoSize = true;
                title2.Location = new Point(title.Location.X + title.Width + 57, title.Location.Y);

                this.Controls.AddRange(new[] {title, title2 });
            }
        }
    }
}