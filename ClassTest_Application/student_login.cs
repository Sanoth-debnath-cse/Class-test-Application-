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
    public partial class student_login : Form
    {
        public static int id = 0;
        String xxx,username;
        string conn = "datasource=localhost;username=root;password=";


        public student_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_register reg = new Student_register();
            this.Hide();
            reg.ShowDialog();
            Close();
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
                string query = "Select * from class_test.student_login where username collate utf8_bin = '" + nameBox.Text + "' and password =  '" + passBox.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    bool check = check_question();
                    if (!check)
                    {
                        MessageBox.Show("Insufficient question in database! Sign in later. ");
                        return;
                    }
                    id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    xxx = dt.Rows[0][5].ToString();
                   // MessageBox.Show(""+xxx);
                   username = dt.Rows[0][1].ToString();

                    Exam_Paper ex1 = new Exam_Paper(xxx,username);
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
        public bool check_question()
        {
            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "Select * from class_test.q_paper where student_id is null limit 5";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 5)
            {
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
