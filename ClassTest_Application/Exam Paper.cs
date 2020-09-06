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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace ClassTest_Application
{
    public partial class Exam_Paper : Form
    {
        int count_ans = 0;
        String emailadd;
        String username;
        string conn = "datasource=localhost;username=root;password=";
        string q1ans = "";
        string q2ans = "";
        string q3ans = "";
        string q4ans = "";
        string q5ans = "";
        int q1id = 0, q2id = 0, q3id = 0, q4id = 0, q5id = 0;

        private System.Windows.Forms.Timer tmr;

        public Exam_Paper(String email,String use)
        {
            InitializeComponent();
            emailadd = email;
            username = use;
            connectToDatabase();
            label1.Text = DateTime.Now.ToLongTimeString();
            ans_panel.Hide();
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate
            {
                tmr.Stop();
                MessageBox.Show("Exam time is over!");
                enDOfExam();
                //ans_panel.Show();
               // this.Close();
            };
            tmr.Interval = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;
            tmr.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void connectToDatabase()
        {
            MySqlConnection conn2 = new MySqlConnection(conn);
            string query = "Select * from class_test.q_paper where student_id is null limit 5";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count < 5)
            {
                MessageBox.Show("Insufficient Questions in database");
                return;
            }
            q1id = Convert.ToInt32(dt.Rows[0][0].ToString());
            q2id = Convert.ToInt32(dt.Rows[1][0].ToString());
            q3id = Convert.ToInt32(dt.Rows[2][0].ToString());
            q4id = Convert.ToInt32(dt.Rows[3][0].ToString());
            q5id = Convert.ToInt32(dt.Rows[4][0].ToString());
            q1.Text =    dt.Rows[0][1].ToString();
            Qu1.Text = dt.Rows[0][1].ToString();
            q1op1.Text = dt.Rows[0][2].ToString();
            Q1_op1.Text = dt.Rows[0][2].ToString();
            q1op2.Text = dt.Rows[0][3].ToString();
            q1op3.Text = dt.Rows[0][4].ToString();
            q1op4.Text = dt.Rows[0][5].ToString();
            Q1_op2.Text = dt.Rows[0][3].ToString();
            Q1_op3.Text = dt.Rows[0][4].ToString();
            Q1_op4.Text = dt.Rows[0][5].ToString();


            q1ans = dt.Rows[0][6].ToString();
            Q1_ans.Text = q1ans;

            q2.Text = dt.Rows[1][1].ToString();
            q2op1.Text = dt.Rows[1][2].ToString();
            q2op2.Text = dt.Rows[1][3].ToString();
            q2op3.Text = dt.Rows[1][4].ToString();
            q2op4.Text = dt.Rows[1][5].ToString();
            q2ans = dt.Rows[1][6].ToString();


            Qu2.Text = dt.Rows[1][1].ToString();
            Q2_op1.Text = dt.Rows[1][2].ToString();
            Q2_op2.Text = dt.Rows[1][3].ToString();
            Q2_op3.Text = dt.Rows[1][4].ToString();
            Q2_op4.Text = dt.Rows[1][5].ToString();
          
            Q2_ans.Text = q2ans;



            q3.Text = dt.Rows[2][1].ToString();
            q3op1.Text = dt.Rows[2][2].ToString();
            q3op2.Text = dt.Rows[2][3].ToString();
            q3op3.Text = dt.Rows[2][4].ToString();
            q3op4.Text = dt.Rows[2][5].ToString();
            q3ans = dt.Rows[2][6].ToString();

            Qu3.Text = dt.Rows[2][1].ToString();
            Q3_op1.Text = dt.Rows[2][2].ToString();
            Q3_op2.Text = dt.Rows[2][3].ToString();
            Q3_op3.Text = dt.Rows[2][4].ToString();
            Q3_op4.Text = dt.Rows[2][5].ToString();
          
            Q3_ans.Text = q3ans;


            q4.Text = dt.Rows[3][1].ToString();
            q4op1.Text = dt.Rows[3][2].ToString();
            q4op2.Text = dt.Rows[3][3].ToString();
            q4op3.Text = dt.Rows[3][4].ToString();
            q4op4.Text = dt.Rows[3][5].ToString();
            q4ans = dt.Rows[3][6].ToString();

            Qu4.Text = dt.Rows[3][1].ToString();
            Q4_op1.Text = dt.Rows[3][2].ToString();
            Q4_op2.Text = dt.Rows[3][3].ToString();
            Q4_op3.Text = dt.Rows[3][4].ToString();
            Q4_op4.Text = dt.Rows[3][5].ToString();
           
            Q4_ans.Text = q4ans;


            q5.Text = dt.Rows[4][1].ToString();
            q5op1.Text = dt.Rows[4][2].ToString();
            q5op2.Text = dt.Rows[4][3].ToString();
            q5op3.Text = dt.Rows[4][4].ToString();
            q5op4.Text = dt.Rows[4][5].ToString();
            q5ans = dt.Rows[4][6].ToString();


            Qu5.Text = dt.Rows[4][1].ToString();
            Q5_op1.Text = dt.Rows[4][2].ToString();
            Q5_op2.Text = dt.Rows[4][3].ToString();
            Q5_op3.Text = dt.Rows[4][4].ToString();
            Q5_op4.Text = dt.Rows[4][5].ToString();
            Q5_ans.Text = q5ans;



            //update student in q_paper
            MySqlConnection conn3 = new MySqlConnection(conn);
            string query_update = "UPDATE class_test.q_paper set student_id = "+student_login.id+" where id in ("+q1id+","+q2id+","+q3id+","+q4id+","+q5id+" )  ";
            MySqlCommand cmd2 = new MySqlCommand(query_update, conn3);
            MySqlDataReader reader;
            conn3.Open();
            reader = cmd2.ExecuteReader();
           // MessageBox.Show("Registration Complete!");
            conn3.Close();
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            enDOfExam();

        }

        public void enDOfExam()
        {
            if (q1ans == q1combo.Text)
                count_ans++;
            if (q2ans == q2combo.Text)
                count_ans++;
            if (q3ans == q3combo.Text)
                count_ans++;
            if (q4ans == q4combo.Text)
                count_ans++;
            if (q5ans == q5combo.Text)
                count_ans++;
            MessageBox.Show("You got " + count_ans + " out of 5 !");
            mailsend(emailadd, count_ans);
            MySqlConnection conn3 = new MySqlConnection(conn);
            string query_update = "UPDATE class_test.student_login set marks = " + count_ans + " where id  = " + student_login.id + " ";
            MySqlCommand cmd2 = new MySqlCommand(query_update, conn3);
            MySqlDataReader reader;
            conn3.Open();
            reader = cmd2.ExecuteReader();
            // MessageBox.Show("Registration Complete!");
            conn3.Close();
            ans_panel.Show();
            // this.DialogResult = DialogResult.OK;
        }
        void mailsend(String mail,int mark)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("yourexamresultpstu@gmail.com", "pstucse141602057");
                MailMessage msg = new MailMessage();
                msg.To.Add(mail);
                msg.From = new MailAddress("yourexamresultpstu@gmail.com");
                msg.Subject = "Mark sheet";
                msg.Body = "Dear " + username + ", you have got " + mark + " out of 5. ";
                //   Attachment data = new Attachment(textBox_file.Text);
                //    msg.Attachments.Add(data);

                client.Send(msg);
                MessageBox.Show("Email send Successfully, Cheek your Email");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signout_Click(object sender, EventArgs e)
        {
            student_login logonForm = new student_login();
            this.Hide();
            logonForm.ShowDialog();
             Close();
        }

        private void panel_hide_Click(object sender, EventArgs e)
        {
            student_login logonForm = new student_login();
            this.Hide();
            logonForm.ShowDialog();
            Close();
        }
       

    }
}
