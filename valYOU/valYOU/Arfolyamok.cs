﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using valYOU.Entities;
using valYOU.MNBArfolyamServiceReference;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace valYOU
{
    public partial class Arfolyamok : Form
    {
        BindingList<Rate> Rates = new BindingList<Rate>();
        BindingList<string> Currencies = new BindingList<string>();

        public Arfolyamok()
        {
            InitializeComponent();

            CurrencyList();
            DataRefresh();
            ArfolyamokFormazas();
        }

        private void CurrencyList()
        {
            var MNBservice = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody();
            var response = MNBservice.GetCurrencies(request);
            var result = response.GetCurrenciesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement element in xml.DocumentElement.ChildNodes[0])
            {
                var currency = element.InnerText;
                Currencies.Add(currency);
            }

            cbCurrency.DataSource = Currencies;
        }

        private void DataRefresh()
        {
            Rates.Clear();

            string s = WebService();
            XMLload(s);

            dgwRates.DataSource = Rates;
            RateDiagram();

            Calculations();
        }

        private void ArfolyamokFormazas()
        {
            labelRightArrow.Text = "\uE970";
            labelError.Text = "\uE713";
            dtpFrom.Value = new DateTime(2020, 01, 01);
            dtpTo.Value = new DateTime(2020, 01, 31);
            cbCurrency.SelectedItem = "EUR";
            dgwRates.AllowUserToAddRows = false;
        }

        private string WebService()
        {
            var MNBservice = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = cbCurrency.SelectedItem.ToString(),
                startDate = dtpFrom.Value.ToString(),
                endDate = dtpTo.Value.ToString()
            };

            var response = MNBservice.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

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
                if (childelement == null)
                    continue;
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

            var series = chartRates.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 1;
            series.Color = Color.Orange;

            var legend = chartRates.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRates.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void Calculations()
        {
            try
            {
                var values = from DataGridViewRow row in dgwRates.Rows
                             where row.Cells[2].FormattedValue.ToString() != string.Empty
                             select Convert.ToDecimal(row.Cells[2].FormattedValue);

                var minValue = values.Min();
                var avgValue = values.Average();
                var maxValue = values.Max();

                labelMin.Text = Math.Round(minValue, 2).ToString() + " HUF";
                labelAvg.Text = Math.Round(avgValue, 2).ToString() + " HUF";
                labelMax.Text = Math.Round(maxValue, 2).ToString() + " HUF";

                foreach (DataGridViewRow row in dgwRates.Rows)
                {
                    if (Convert.ToDecimal(row.Cells[2].Value) == minValue)
                    {
                        row.DefaultCellStyle.BackColor = Color.Lime;
                    }
                    else if (Convert.ToDecimal(row.Cells[2].Value) == maxValue)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    if (dgwRates.Rows.Count==1 || Convert.ToDecimal(row.Cells[2].Value) == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

            catch (Exception)
            {
                if (dtpFrom.Value > dtpTo.Value)
                    ErrorProv.SetError(labelError, "A kezdő dátum nem lehet a záró dátumnál későbbi időpont!");

                else if (dgwRates.Rows.Count == 0)
                    ErrorProv.SetError(labelError, "Az adott szűrési feltételek mellett nem léteznek adatok!");

                labelMin.Text = "N/A";
                labelAvg.Text = "N/A";
                labelMax.Text = "N/A";
            }
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorProv.Clear();
            DataRefresh();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            ErrorProv.Clear();
            DataRefresh();
        }

        private void Arfolyamok_Load(object sender, EventArgs e)
        {
            Calculations();
        }

        private void btnIntoPNG_Click(object sender, EventArgs e)
        {

        }

        private void btnIntoExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnIntoPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnIntoWord_Click(object sender, EventArgs e)
        {

        }
    }
}
