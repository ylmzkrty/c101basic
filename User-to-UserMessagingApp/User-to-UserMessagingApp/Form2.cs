using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace User_to_UserMessagingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string no;
        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=User-to-UserMessagingApp;Integrated Security=True");
    
        void inbox()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Tbl_Message WHERE receiver=" + no ,cnt);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        void sendbox()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM Tbl_Message WHERE sender=" + no, cnt);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNo.Text = no;

            inbox();
            sendbox();

            //Name-Surname

            cnt.Open();
            SqlCommand command = new SqlCommand("SELECT Name,Surname FROM Tbl_Person WHERE no=" + no, cnt);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                LblName.Text = dr[0] + " " + dr[1];
            }
            cnt.Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Tbl_Message (MessageId,Sender,Receiver,Title,MessageContent) values (@p1,@p2,@p3,@p4)",cnt);
            command.Parameters.AddWithValue("@p1",no);
            command.Parameters.AddWithValue("@p2", TxtNo.Text);
            command.Parameters.AddWithValue("@p3", TxtTitle.Text);
            command.Parameters.AddWithValue("@p4", richTextBox1.Text);
            command.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Your message has been delivered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
