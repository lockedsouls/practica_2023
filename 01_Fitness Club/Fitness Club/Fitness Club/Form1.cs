using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

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
            DialogResult ans = MessageBox.Show("Do you wish to log in as a Client (Select NO if you wish to log in as an Employee)?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                LoginForm f = new LoginForm(db, false);
                f.Show();
            }else if (ans == DialogResult.No)
            {
                LoginForm f = new LoginForm(db, true);
                f.Show();
            };

            this.WindowState = FormWindowState.Minimized;
        }

        private void regB_Click(object sender, EventArgs e)
        {
            ClientReg f = new ClientReg(db);
            f.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void jobB_Click(object sender, EventArgs e)
        {
            JobApplication f = new JobApplication(this.db);
            f.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutUs f = new AboutUs(this.db);
            f.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}