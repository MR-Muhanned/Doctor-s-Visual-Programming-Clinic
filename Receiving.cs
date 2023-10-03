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
    public partial class Receiving : Form
    {
        public Receiving()
        {
            InitializeComponent();
        }


        public void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var DbContext = new dbContext())
            {
                var classDoc = new Receiving1
                {
                    NameSick = namesik.Text,
                    Age = int.Parse(age.Text),
                    WhereToLive = whertolive.Text,
                    DateSession = DateTime.Now,
                    TypeOfInspection = typ.Text,
                    Price = int.Parse(price.Text),
                    ChronicDiseases = chronicDiseases.Text,
                };
                DbContext.Receivings.Add(classDoc);
                DbContext.SaveChanges();
            }
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {


            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = guna2DataGridView1.SelectedRows[0].Index; // الحصول على فهرس الصف المحدد

                using (var dbContext = new dbContext())
                {
                    // حذف العنصر من قاعدة البيانات
                    var selectedReceiving = dbContext.Receivings.Find(guna2DataGridView1.Rows[selectedRowIndex].Cells[0].Value);
                    if (selectedReceiving != null)
                    {
                        dbContext.Receivings.Remove(selectedReceiving);
                        dbContext.SaveChanges();
                    }
                }

                guna2DataGridView1.Rows.RemoveAt(selectedRowIndex); // حذف الصف من DataGrid
            }

        }

        private void edet_Click(object sender, EventArgs e)
        {
            using (var dbContext = new dbContext())
            {
                var recordToUpdate = dbContext.Receivings.FirstOrDefault(r => r.NameSick == namesik.Text);

                if (recordToUpdate != null)
                {
                    recordToUpdate.NameSick = namesik.Text;
                    recordToUpdate.Age = int.Parse(age.Text);
                    recordToUpdate.WhereToLive = whertolive.Text;
                    recordToUpdate.DateSession = DateTime.Now;
                    recordToUpdate.TypeOfInspection = typ.Text;
                    recordToUpdate.Price = int.Parse(price.Text);
                    recordToUpdate.ChronicDiseases = chronicDiseases.Text;
                    dbContext.Update(recordToUpdate); // تعديل السجل
                    dbContext.SaveChanges(); // حفظ التغييرات في قاعدة البيانات
                }
            }

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getData_Click(object sender, EventArgs e)
        {
            using (var dbContext = new dbContext())
            {
                var Receivings = dbContext.Receivings.ToList();
                foreach (var Receivings1 in Receivings)
                {
                    int rowindex = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[rowindex].Cells[0].Value = Receivings1.Id;
                    guna2DataGridView1.Rows[rowindex].Cells[1].Value = Receivings1.NameSick;
                    guna2DataGridView1.Rows[rowindex].Cells[2].Value = Receivings1.Age;
                    guna2DataGridView1.Rows[rowindex].Cells[3].Value = Receivings1.WhereToLive;
                    guna2DataGridView1.Rows[rowindex].Cells[4].Value = Receivings1.DateSession;
                    guna2DataGridView1.Rows[rowindex].Cells[5].Value = Receivings1.TypeOfInspection;
                    guna2DataGridView1.Rows[rowindex].Cells[6].Value = Receivings1.Price;
                    guna2DataGridView1.Rows[rowindex].Cells[7].Value = Receivings1.ChronicDiseases;
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
             options op = new options();
            op.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}