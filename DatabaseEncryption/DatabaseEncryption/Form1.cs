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


namespace DatabaseEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-53PEC1K;Initial Catalog=DatabaseEncryption;Integrated Security=True");

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            byte[] namestring = ASCIIEncoding.ASCII.GetBytes(name);
            string namepassword = Convert.ToBase64String(namestring);


            string surname = TxtSurname.Text;
            byte[] surnamestring = ASCIIEncoding.ASCII.GetBytes(surname);
            string surnamepassword = Convert.ToBase64String(surnamestring);


            string mail = TxtMail.Text;
            byte[] mailstring = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailpassword = Convert.ToBase64String(mailstring);

            string password = TxtPassword.Text;
            byte[] passwordstring = ASCIIEncoding.ASCII.GetBytes(password);
            string passwordpassword = Convert.ToBase64String(passwordstring);

            string accountno = TxtAccount.Text;
            byte[] accountnostring = ASCIIEncoding.ASCII.GetBytes(accountno);
            string accountnopassword = Convert.ToBase64String(accountnostring);

            cnt.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Tbl_Data (Name,Surname,Mail,Password,AccountNo) values (@p1,@p2,@p3,@p4@,p5)",cnt);
            command.Parameters.AddWithValue("@p1", namepassword);
            command.Parameters.AddWithValue("@p2", surnamepassword);
            command.Parameters.AddWithValue("@p3", mailpassword);
            command.Parameters.AddWithValue("@p4", passwordpassword);
            command.Parameters.AddWithValue("@p5", accountnopassword);
            
  )
 



        }
    }
}
