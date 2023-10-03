using DR.model;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DR
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string UserName = "";
            string Password = "";
            using (var DbContext = new dbContext())
            {
                UserName = DbContext.login.FirstOrDefault()?.username?? "";
                Password = DbContext.login.FirstOrDefault()?.password ?? "";
            }
            if (UserName == user.Text && Password == password.Text)
            {
                //MessageBox.Show("Success", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                options op = new options();
                op.Show();

                //Form changpass = new changpass(UserName, Password);
                //changpass.Show();
                user.Text = string.Empty;
                password.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Faild", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}