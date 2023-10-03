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
    public partial class Prescription : Form
    {
        

        public Prescription()
        {
            InitializeComponent();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            
            using (var DbContext = new dbContext())
            {
               var classDoc = new Prescription1
               {
                   Drug1=drug1.Text,
                   Drug2=drug2.Text,  
                   Drug3=drug3.Text, 
                   Drug4=drug4.Text, 
                   Drug5=drug5.Text,
                   NumberOfDoses1=Convert.ToInt32( numberOfDoses1.Text),
                   NumberOfDoses2=Convert.ToInt32( numberOfDoses2.Text),
                   NumberOfDoses3=Convert.ToInt32( numberOfDoses3.Text),
                   NumberOfDoses4=Convert.ToInt32( numberOfDoses4.Text),
                   NumberOfDoses5=Convert.ToInt32( numberOfDoses5.Text),
                   Manufacturer1=manufacturer1.Text,
                   Manufacturer2=manufacturer2.Text,  
                   Manufacturer3=manufacturer3.Text,
                   Manufacturer4=manufacturer4.Text,
                   Manufacturer5=manufacturer5.Text,
               };
              DbContext.Add( classDoc);
              DbContext.SaveChanges();

          
            };
              
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diagnosis di = new Diagnosis();
            di.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchId = guna2TextBox1.Text; // قيمة البحث المدخلة في TextBox
            using (var dbContext = new dbContext()) // استبدل DbContext بالسياق الخاص بقاعدة البيانات الخاصة بك
            {
                Diag result = dbContext.diagnosis.FirstOrDefault(d => d.Id.ToString() == searchId);

                // إعداد النص في Label 10
                if (result != null)
                {
                    string labelText = $"اسم المرض: {result.TheNameOfTheDisease}{Environment.NewLine}";
                    labelText += $"الملاحظة الأولى: {result.Notes1}{Environment.NewLine}";
                    labelText += $"الملاحظة الثانية: {result.Notes2}{Environment.NewLine}";
                    labelText += $"الملاحظة الثالثة: {result.Notes3}{Environment.NewLine}";
                    label10.Text = labelText;
                }
                else
                {
                    label10.Text = "ID غير موجود";
                }
            }

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
