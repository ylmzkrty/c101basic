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

namespace MailandPhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=MailandPhoneBook;Integrated Security=True");

        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Person",cnt);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void clean()
        {
            TxtName.Text = "";
            TxtSurname.Text = "";
            MskPhone.Text = "";
            TxtMail.Text = "";
            TxtName.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         list();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Person (Name,Surname,Phone,Mail) values (@p1,@p2,@p3,@p4)", cnt);
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", MskPhone.Text);
            cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
            cmd.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Person registered in system", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
            clean();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Tbl_Person WHERE Id=" + TxtId.Text, cnt);
            cmd.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Registration deleted","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            list();
            clean();
        
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            MskPhone.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tbl_Person SET Name=@p1,Surname=@p2,Phone=@p3,Mail=@p4 WHERE Id=@p5",cnt);
            cmd.Parameters.AddWithValue("@p1",TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", MskPhone.Text);
            cmd.Parameters.AddWithValue("@p4", TxtMail.Text);
            cmd.Parameters.AddWithValue("@p5", TxtId.Text);
            cmd.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Registration uptaded", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
            clean();
        }
    }
}
