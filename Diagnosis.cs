using DR.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace DR
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var DbContext = new dbContext())
            {
                var classDoc = new Diag
                {
                    TheNameOfTheDisease=theNameOfTheDisease.Text,
                    Notes1=notes1.Text,
                    Notes2=notes2.Text,
                    Notes3=notes3.Text,
                };
                DbContext.Add(classDoc);
                DbContext.SaveChanges();
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
            this.Hide();
            Prescription pr = new Prescription();
            pr.Show();
        }

        private void getdata_Click(object sender, EventArgs e)
        {
            using (var dbContext = new dbContext())
            {
                var Diagnosis = dbContext.diagnosis.ToList();
                foreach (var Diag in Diagnosis)
                {
                    int rowindex = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[rowindex].Cells[0].Value = Diag.Id;
                    guna2DataGridView1.Rows[rowindex].Cells[1].Value = Diag.TheNameOfTheDisease;
                    guna2DataGridView1.Rows[rowindex].Cells[2].Value = Diag.Notes1;
                    guna2DataGridView1.Rows[rowindex].Cells[3].Value = Diag.Notes2;
                    guna2DataGridView1.Rows[rowindex].Cells[4].Value = Diag.Notes3;
                }
            }
        }

        private void delet_Click(object sender, EventArgs e)
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

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
