using DR.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DR
{
    public partial class chengpassword : Form
    {
        public chengpassword()
        {
            InitializeComponent();
        }

        private void chengpassword_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var usernameBb = "";
            var passwordDb = "";
            using (var dbContext = new dbContext())
            {
                usernameBb = dbContext.login.First().username;
                passwordDb = dbContext.login.First().password;
            }
            if (usernameBb == UserNameText.Text && passwordDb == oldPassword.Text)
            {

                using (var dbContext = new dbContext())
                {
                    var user = dbContext.login.First(u => u.username == usernameBb);
                    user.password = newpassword.Text;
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Password changed successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UserNameText.Text = string.Empty;
            oldPassword.Text = string.Empty;
            newpassword.Text = string.Empty;
        
    }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            options op = new options();
            op.Show();
        }
    }
}
