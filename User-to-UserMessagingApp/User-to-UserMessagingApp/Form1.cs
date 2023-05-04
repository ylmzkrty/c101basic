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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=User-to-UserMessagingApp;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
    }

        private void button1_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_Person WHERE No=@p1 AND Password=@p2", cnt);
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.no = maskedTextBox1.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnt.Close();
        }
    }
    }
