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
using valYOU.Entities;
using valYOU.MNBArfolyamServiceReference;

namespace valYOU
{
    public partial class Arfolyamok : Form
    {
        BindingList<Rate> Rates = new BindingList<Rate>();
        public Arfolyamok()
        {
            InitializeComponent();

            dgwRates.DataSource = Rates;

            string s=WebService();
            XMLload(s);
            RateDiagram();
        }

        private string WebService()
        {
            var MNBservice = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = MNBservice.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            Console.WriteLine(result);

            return result;
        }

        private void XMLload(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new Rate();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childelement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childelement.GetAttribute("curr");

                var unit = decimal.Parse(childelement.GetAttribute("unit"));
                var value = decimal.Parse(childelement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void RateDiagram()
        {
            chartRates.DataSource = Rates;
        }
    }
}
