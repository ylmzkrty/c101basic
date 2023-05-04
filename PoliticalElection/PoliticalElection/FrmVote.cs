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
    public partial class FrmVote : Form
    {
        public FrmVote()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=ElectionGrafic;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVore_Click(object sender, EventArgs e)
        {
            cnt.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Election (District,AParty,BParty,CParty,DParty,EParty) values (@p1,@p2,@p3,@p4,@p5,@p6)",cnt);
            cmd.Parameters.AddWithValue("@p1", TxtDistrict.Text);
            cmd.Parameters.AddWithValue("@p2", TxtA.Text);
            cmd.Parameters.AddWithValue("@p3", TxtB.Text);
            cmd.Parameters.AddWithValue("@p4", TxtC.Text);
            cmd.Parameters.AddWithValue("@p5", TxtD.Text);
            cmd.Parameters.AddWithValue("@p6", TxtE.Text);
            cmd.ExecuteNonQuery();
            cnt.Close();
            MessageBox.Show("Vote has been entered.");
        }

        private void BtnGraphics_Click(object sender, EventArgs e)
        {
            FrmGraphic frm = new FrmGraphic();
            frm.Show();
        }
    }
}
