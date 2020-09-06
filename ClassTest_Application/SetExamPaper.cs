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
using System.Data.OleDb;

namespace ClassTest_Application
{
    public partial class SetExamPaper : Form
    {
        string conn = "datasource=localhost;username=root;password=";
        string path = "";
        public SetExamPaper()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

     

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (Q1Box.Text == "" ||Q1_op1Box.Text == "" || Q1_op2Box.Text == "" || Q1_op3Box.Text == "" || Q1_op4Box.Text == "" || Q1_comboBox.Text == "" )
            {
                MessageBox.Show("Fill Up all the Fields!");
                return;
            }
            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "insert into class_test.q_paper(question	,option_a,option_b,option_c,option_d,ans,student_id) values('" + Q1Box.Text + "', '" + Q1_op1Box.Text + "' , '" + Q1_op2Box.Text + "', '" + Q1_op3Box.Text + "', '" + Q1_op4Box.Text + "','" + Q1_comboBox.Text + "',null)";
            MySqlCommand cmd = new MySqlCommand(query, conn2);
            MySqlDataReader reader;
            conn2.Open();
            reader = cmd.ExecuteReader();
            MessageBox.Show("question saved in database!");
            conn2.Close();
            Q1Box.Text = "";
            Q1_op1Box.Text = "";
            Q1_op2Box.Text = "";
            Q1_op3Box.Text = "";
            Q1_op4Box.Text = "";
            Q1_comboBox.SelectedIndex = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SetExamPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.path_textBox.Text = openFileDialog1.FileName;
                path = path_textBox.Text;
            }
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                return;
            }

            // String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; " + " Data Source=" + path + ";" + " Extended Properties='Excel 12.0 Xml;HDR=YES'";
            OleDbConnection xlConn = new OleDbConnection(connectionString);
            xlConn.Open();
            OleDbCommand selectCmd = new OleDbCommand("SELECT * FROM [Sheet1$]", xlConn);
            OleDbDataAdapter xlAdapter = new OleDbDataAdapter();
            xlAdapter.SelectCommand = selectCmd;
            DataSet xlDataset = new DataSet();
            xlAdapter.Fill(xlDataset, "XLData");
            DataTable dt = xlDataset.Tables[0];
           // MessageBox.Show(dt.Columns.Count.ToString());

            foreach (DataRow item in dt.Rows)
            {

                try
                {
                    string query = "insert into class_test.q_paper(question, option_a, option_b, option_c, option_d,ans,student_id ) values('" + item[0].ToString() + "','" + item[1].ToString() + "','" + item[2].ToString() + "','" + item[3].ToString() + "','" + item[4].ToString() + "','" + item[5].ToString() + "',null) ";
                   // MessageBox.Show(query);

                    MySqlConnection conn4 = new MySqlConnection(conn);

                    //   MessageBox.Show(query);

                    MySqlCommand command3 = new MySqlCommand(query, conn4);
                    MySqlDataReader myReader;
                    conn4.Open();
                    myReader = command3.ExecuteReader();
                    // MessageBox.Show("Saved!");

                    while (myReader.Read())
                    {

                    }
                    conn4.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            MessageBox.Show("Saved!");
        }
    }
}
