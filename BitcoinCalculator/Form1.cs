using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            if(currencySelector.SelectedItem.ToString() == "EUR")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.EUR.rate_float;
                resultLabel.Text = $"{result} Bitcoini {newBitcoinRates.Bpi.EUR.code}";
            } else if(currencySelector.SelectedItem.ToString() == "USD")
              {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.USD.rate_float;
                resultLabel.Text = $"{result} Bitcoini {newBitcoinRates.Bpi.USD.code}";
            } else if(currencySelector.SelectedItem.ToString() == "EEK")
            {
                resultLabel.Visible = true;
                tulemusLabel.Visible = true;
                BitcoinRates newBitcoinRates = getRates();
                float result = float.Parse(bitcoinAmountInput.Text) * (float)newBitcoinRates.Bpi.EUR.rate_float*(float)15.64;
                resultLabel.Text = $"{result} Bitcoini EEK";

            }
        }
        public static BitcoinRates getRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request =  (HttpWebRequest)WebRequest.Create(url);
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
    }
}
