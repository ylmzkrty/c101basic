using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ExchangeOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlfile = new XmlDocument();
            xmlfile.Load(today);

            string dollarbuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDollarBuying.Text = dollarbuying;

            string dollarselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDollarSelling.Text = dollarselling;

            string eurobuying = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroBuying.Text = eurobuying;

            string euroselling = xmlfile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSelling.Text = euroselling;

        }

        private void BtnDBuy_Click(object sender, EventArgs e)
        {
            TxtRate.Text = LblDollarBuying.Text;
        }

        private void BtnDSell_Click(object sender, EventArgs e)
        {
            TxtRate.Text = LblDollarSelling.Text;
        }

        private void BtnEBuy_Click(object sender, EventArgs e)
        {
            TxtRate.Text = LblEuroBuying.Text;
        }

        private void BtnESell_Click(object sender, EventArgs e)
        {
            TxtRate.Text = LblEuroSelling.Text;
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            double rate, piece, amount;
            rate = Convert.ToDouble(TxtRate.Text);
            piece = Convert.ToDouble(TxtPiece.Text);
            amount = rate * piece;
            TxtAmount.Text = amount.ToString();
        }


        private void BtnSell_Click(object sender, EventArgs e)
        {
            double rate = Convert.ToDouble(TxtRate.Text);
            int piece = Convert.ToInt32(TxtPiece.Text);
            int amount = Convert.ToInt32(piece / rate);
            TxtAmount.Text = amount.ToString();
            double remainder; 
            remainder = piece % rate;
            TxtReaminder.Text = remainder.ToString();

        }

     
    }
}
