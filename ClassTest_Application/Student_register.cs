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
    public partial class Student_register : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        public Student_register()
        {
            InitializeComponent();
        }

        private void buttonreg_Click(object sender, EventArgs e)
        {
            if(nameBox.Text == "" || passBox.Text == "" || lnameBox.Text == "" || fnameBox.Text == "" || mailBox.Text == ""){
                MessageBox.Show("empty fields!");
                return;
            }

            try
            {
                MySqlConnection conn2 = new MySqlConnection(conn);
                string query = "insert into class_test.student_login(username,first_name, last_name, password, email) values('" + nameBox.Text + "', '" + fnameBox.Text + "' , '" + lnameBox.Text + "', '" + passBox.Text + "', '" + mailBox.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, conn2);
                MySqlDataReader reader;
                conn2.Open();
                reader = cmd.ExecuteReader();
                MessageBox.Show("Registration Complete!");
                conn2.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
