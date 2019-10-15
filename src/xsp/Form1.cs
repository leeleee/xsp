using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace xsp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CalcAmount()
        {
            Series series = this.chart1.Series.Add("等额本息金额");
            series.ChartType = SeriesChartType.Line;
            double total = double.Parse(this.txtTotalAmount.Text);
            double rate = double.Parse(this.txtRate.Text) / 100;
            double monthNumber = double.Parse(this.txtMonthCount.Text);

            // 每月还款额=[贷款本金×月利率×（1+月利率）^还款月数]÷[（1+月利率）^还款月数－1]
            // （1+月利率）^还款月数
            // https://zhidao.baidu.com/question/335332925.html
            // https://baijiahao.baidu.com/s?id=1638210424684613966&wfr=spider&for=pc
            double left = total;
            double tmp = Math.Pow(1 + rate, monthNumber);
            double amount = (total * rate * tmp) / (tmp - 1);

            this.lblDEBX.Text = (amount * monthNumber).ToString();
            this.lblDEBXLXZE.Text = (amount * monthNumber - total).ToString();

            List<double> taxAmounts = new List<double>();
            List<double> amountLeft = new List<double>();

            for (int i = 0; i < monthNumber; i++)
            {
                // 每月还款额=[贷款本金×月利率×（1+月利率）^还款月数]÷[（1+月利率）^还款月数－1]
                // （1+月利率）^还款月数
                series.Points.AddXY(i + 1, amount);
                double taxAmount = left * rate;
                taxAmounts.Add(taxAmount);
                amountLeft.Add(amount - taxAmount);
                left -= amount - taxAmount;
            }

            series = this.chart1.Series.Add("等额本息利息");
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < monthNumber; i++)
            {
                series.Points.AddXY(i + 1, taxAmounts[i]);
            }
            series = this.chart1.Series.Add("等额本息本金");
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < monthNumber; i++)
            {
                series.Points.AddXY(i + 1, amountLeft[i]);
            }

            // 本付息金额=（本金/还款月数）+（本金-累计已还本金）×月利率
            series = this.chart1.Series.Add("等额本金金额");
            series.ChartType = SeriesChartType.Line;
            amount = total / monthNumber;
            left = total;
            taxAmounts = new List<double>();
            amountLeft = new List<double>();
            for (int i = 0; i < monthNumber; i++)
            {
                double taxAmount = left * rate;
                series.Points.AddXY(i + 1, amount + taxAmount);
                amountLeft.Add(amount);
                taxAmounts.Add(taxAmount);
                left -= amount;
            }
            series = this.chart1.Series.Add("等额本金利本金");
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < monthNumber; i++)
            {
                series.Points.AddXY(i + 1, amountLeft[i]);
            }
            series = this.chart1.Series.Add("等额本金利利息");
            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < monthNumber; i++)
            {
                series.Points.AddXY(i + 1, taxAmounts[i]);
            }

            this.lblDEBJ.Text = (taxAmounts.Sum() + (amount * monthNumber)).ToString();
            this.lblDEBJLXZE.Text = taxAmounts.Sum().ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.CalcAmount();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.CalcAmount();
        }
    }
}
