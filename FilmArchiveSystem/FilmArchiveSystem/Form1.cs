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

namespace FilmArchiveSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         SqlConnection cnt = new SqlConnection (@"Data Source=DESKTOP-53PEC1K;Initial Catalog=FilmArchive;Integrated Security=True");
         public void films()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Film",cnt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }    
        private void Form1_Load(object sender, EventArgs e)
        {
            films();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Film (Name,Category,Link) values (@p1,@p2,@p3)", cnt);
            cmd.Parameters.AddWithValue("@p1", TxtFilmName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtCategory.Text);
            cmd.Parameters.AddWithValue("@p3", TxtLink.Text);
            cmd.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Film added to your list.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            films();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project was coded by Yılmaz Kurtay in 2023","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
