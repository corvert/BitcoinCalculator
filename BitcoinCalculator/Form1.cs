using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.LinkLabel;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrency.Text) || (!txtCurrency.Text.ToLower().Equals("eur") && 
                !txtCurrency.Text.ToLower().Equals("eek") && !txtCurrency.Text.ToLower().Equals("usd") &&
                !txtCurrency.Text.ToLower().Equals("jpy") && !txtCurrency.Text.ToLower().Equals("gbp")))
            {
                MessageBox.Show("Palun siseta valuuta, sisestada saab (EUR, USD, EEK, JPY, GBP)", "Sisestus viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(bitcoinAmountInput.Text) || !float.TryParse(bitcoinAmountInput.Text, out float bitcoinAmount))
            {
                MessageBox.Show("Palun siseta BTC kogus", "Sisestus Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCurrency.Text.ToLower().Equals("eur"))
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.EUR.rate_float;
                resultLabel.Text = $"{bitcoinAmountInput.Text} BTC on väärt {result} {newBitcoinRates.Bpi.EUR.code}";
            }
            else if (txtCurrency.Text.ToLower().Equals("usd"))
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.USD.rate_float;
                resultLabel.Text = $"{bitcoinAmountInput.Text} BTC on väärt {result} {newBitcoinRates.Bpi.USD.code}";
            }
            else if (txtCurrency.Text.ToLower().Equals("eek"))
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.EUR.rate_float * (float)15.64;
                resultLabel.Text = $"{bitcoinAmountInput.Text} BTC on väärt {result} EEK";

            }
            else if (txtCurrency.Text.ToLower().Equals("gbp"))
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.GBP.rate_float;
                resultLabel.Text = $"{bitcoinAmountInput.Text} BTC on väärt {result} {newBitcoinRates.Bpi.GBP.code}";

            }
            else if (txtCurrency.Text.ToLower().Equals("jpy"))
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)(newBitcoinRates.Bpi.EUR.rate_float / 0.0063);
                resultLabel.Text = $"{bitcoinAmountInput.Text} BTC on väärt {result} {txtCurrency.Text}";

            }
            String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {

                outputFile.WriteLine(resultLabel.Text);
            }


        }
        public static BitcoinRates getRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var response = request.GetResponse();
            var webStream = response.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);

            }
            return bitcoin;
        }

        private void resultLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
