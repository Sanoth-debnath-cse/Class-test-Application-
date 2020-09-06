using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClassTest_Application
{
    public partial class Teacher_signup : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        public Teacher_signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonsignIn_Click(object sender, EventArgs e)
        {
            try
            {


                if (nameBox.Text == "" || passBox.Text == "")
                {
                    MessageBox.Show("Fill Up All The Fields!");
                    return;
                }
                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "Select * from class_test.teacher_login where username collate utf8_bin = '" + nameBox.Text + "' and password =  '" + passBox.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    SetExamPaper ex1 = new SetExamPaper();
                    this.Hide();
                    ex1.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Username/Password not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
