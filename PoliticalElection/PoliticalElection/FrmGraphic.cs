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

namespace PoliticalElection
{
    public partial class FrmGraphic : Form
    {
        public FrmGraphic()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=ElectionGrafic;Integrated Security=True");
        private void LblD_Click(object sender, EventArgs e)
        {

        }

        private void FrmGraphic_Load(object sender, EventArgs e)
        {
            //District Name
            cnt.Open();
            SqlCommand cmd = new SqlCommand("SELECT District FROM Tbl_Election",cnt);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            cnt.Close();
            //Grafiğe toplam sonuçları getirme 
            cnt.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(AParty),SUM(BParty), SUM(CParty), SUM(DParty), SUM(EParty) FROM Tbl_Election", cnt);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partys"].Points.AddXY("A Party", dr2[0]);
                chart1.Series["Partys"].Points.AddXY("B Party", dr2[1]);
                chart1.Series["Partys"].Points.AddXY("C Party", dr2[2]);
                chart1.Series["Partys"].Points.AddXY("D Party", dr2[3]);
                chart1.Series["Partys"].Points.AddXY("E Party", dr2[4]);

            }
            cnt.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("SELECT * From Tbl_Election WHERE District=@p1", cnt);
            cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();
            }
            cnt.Close();
        }
    }
}
