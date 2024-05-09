using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IncomeTaxCalculator
{
	public partial class CalculatorMainForm : Form
	{
		private const string LABEL_PLACEHOLDER = "£0";
		private const string SALARY_RANGE_ZERO = "Salary must be greater than zero.";
		private const string SALARY_RANGE_MAX_VALUE = "Salary is greater than the max calculable value.";
		public List<TaxBand> Bands { get; set; }
		public CalculatorMainForm()
		{
			Bands = new List<TaxBand>()
			{
				new TaxBand(0, 5000, 0),
				new TaxBand(5000, 20000, 0.2),
				new TaxBand(20000, 0.4)
			};
			InitializeComponent();
			GrossAnnualNumericUpDown.Maximum = decimal.MaxValue;
			GrossAnnualNumericUpDown.Select(0, 1);
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			double salary = (double)GrossAnnualNumericUpDown.Value;
			if (salary <= 0)
			{
				MessageBox.Show(SALARY_RANGE_ZERO);
				ClearLabels();
				return;
			}
			else if (salary > double.MaxValue)
			{
				MessageBox.Show(SALARY_RANGE_MAX_VALUE);
				ClearLabels();
				return;
			}

			double tax = 0;
			foreach (var band in Bands)
			{
				if (salary > band.LowerLimit && band.Percentage > 0)
					tax +=
						Math.Min(band.UpperLimit - band.LowerLimit, salary - band.LowerLimit)
						* band.Percentage;
			}

			SetLabels(salary, tax);
		}

		private void SetLabels(double salary, double tax)
		{
			double net = salary - tax;
			GrossAnnualLabel.Text = salary.ToString("C");
			GrossMonthlyLabel.Text = (salary / 12).ToString("C");
			NetAnnualLabel.Text = net.ToString("C");
			NetMonthlyLabel.Text = (net / 12).ToString("C");
			AnnualTaxLabel.Text = tax.ToString("C");
			MonthlyTaxLabel.Text = (tax / 12).ToString("C");
		}

		private void ClearLabels()
		{
			GrossAnnualLabel.Text = LABEL_PLACEHOLDER;
			GrossMonthlyLabel.Text = LABEL_PLACEHOLDER;
			NetAnnualLabel.Text = LABEL_PLACEHOLDER;
			NetMonthlyLabel.Text = LABEL_PLACEHOLDER;
			AnnualTaxLabel.Text = LABEL_PLACEHOLDER;
			MonthlyTaxLabel.Text = LABEL_PLACEHOLDER;
		}
	}
	public class TaxBand
	{
		public double LowerLimit { get; set; }
		public double UpperLimit { get; set; }
		public double Percentage { get; set; }
		public TaxBand(double lower, double percentage)
		{
			LowerLimit = lower;
			UpperLimit = double.MaxValue;
			Percentage = percentage;
		}
		public TaxBand(double lower, double upper, double percentage)
		{
			LowerLimit = lower;
			UpperLimit = upper;
			Percentage = percentage;
		}
	}
}
