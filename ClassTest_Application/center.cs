using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTest_Application
{
    public partial class center : Form
    {
        public center()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            panel_developer.Hide();

        }

        private void student_login_Click(object sender, EventArgs e)
        {
            student_login std = new student_login();
            this.Hide();
            std.ShowDialog();
            this.Show();
        }

        private void center_Load(object sender, EventArgs e)
        {

        }

        private void teacher_center_Click(object sender, EventArgs e)
        {
            Teacher_signup t1 = new Teacher_signup();
            this.Hide();
            t1.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            //lebe12_Click.Text = time.ToLocalTime().ToString();
        }

        private void time(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clock_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void student_center_MouseHover(object sender, EventArgs e)
        {
           // student_center.BackColor = Color.LightBlue;
        }

        private void student_center_MouseLeave(object sender, EventArgs e)
        {
           // student_center.BackColor = Color.White;
        }

        private void developer_Click(object sender, EventArgs e)
        {
            panel_developer.Show();
        }
    }
}
