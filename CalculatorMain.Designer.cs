namespace IncomeTaxCalculator
{
	partial class CalculatorMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.MonthlyTaxLabel = new System.Windows.Forms.Label();
			this.AnnualTaxLabel = new System.Windows.Forms.Label();
			this.NetMonthlyLabel = new System.Windows.Forms.Label();
			this.NetAnnualLabel = new System.Windows.Forms.Label();
			this.GrossMonthlyLabel = new System.Windows.Forms.Label();
			this.GrossAnnualLabel = new System.Windows.Forms.Label();
			this.GrossAnnualNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GrossAnnualNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gross Annual Salary:";
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(231, 11);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(75, 23);
			this.CalculateButton.TabIndex = 2;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(15, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(291, 2);
			this.label2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Right;
			this.label3.Location = new System.Drawing.Point(37, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Gross Annual Salary:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Right;
			this.label4.Location = new System.Drawing.Point(33, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Gross Monthly Salary:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Right;
			this.label5.Location = new System.Drawing.Point(47, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Net Annual Salary:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Right;
			this.label6.Location = new System.Drawing.Point(43, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Net Monthly Salary:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Right;
			this.label7.Location = new System.Drawing.Point(54, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 20);
			this.label7.TabIndex = 8;
			this.label7.Text = "Annual Tax Paid:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Right;
			this.label8.Location = new System.Drawing.Point(50, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(92, 20);
			this.label8.TabIndex = 9;
			this.label8.Text = "Monthly Tax Paid:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.MonthlyTaxLabel, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.AnnualTaxLabel, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.NetMonthlyLabel, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.NetAnnualLabel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.GrossMonthlyLabel, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.GrossAnnualLabel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 47);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 120);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// MonthlyTaxLabel
			// 
			this.MonthlyTaxLabel.AutoSize = true;
			this.MonthlyTaxLabel.Location = new System.Drawing.Point(148, 100);
			this.MonthlyTaxLabel.Name = "MonthlyTaxLabel";
			this.MonthlyTaxLabel.Size = new System.Drawing.Size(19, 13);
			this.MonthlyTaxLabel.TabIndex = 15;
			this.MonthlyTaxLabel.Text = "£0";
			// 
			// AnnualTaxLabel
			// 
			this.AnnualTaxLabel.AutoSize = true;
			this.AnnualTaxLabel.Location = new System.Drawing.Point(148, 80);
			this.AnnualTaxLabel.Name = "AnnualTaxLabel";
			this.AnnualTaxLabel.Size = new System.Drawing.Size(19, 13);
			this.AnnualTaxLabel.TabIndex = 14;
			this.AnnualTaxLabel.Text = "£0";
			// 
			// NetMonthlyLabel
			// 
			this.NetMonthlyLabel.AutoSize = true;
			this.NetMonthlyLabel.Location = new System.Drawing.Point(148, 60);
			this.NetMonthlyLabel.Name = "NetMonthlyLabel";
			this.NetMonthlyLabel.Size = new System.Drawing.Size(19, 13);
			this.NetMonthlyLabel.TabIndex = 13;
			this.NetMonthlyLabel.Text = "£0";
			// 
			// NetAnnualLabel
			// 
			this.NetAnnualLabel.AutoSize = true;
			this.NetAnnualLabel.Location = new System.Drawing.Point(148, 40);
			this.NetAnnualLabel.Name = "NetAnnualLabel";
			this.NetAnnualLabel.Size = new System.Drawing.Size(19, 13);
			this.NetAnnualLabel.TabIndex = 12;
			this.NetAnnualLabel.Text = "£0";
			// 
			// GrossMonthlyLabel
			// 
			this.GrossMonthlyLabel.AutoSize = true;
			this.GrossMonthlyLabel.Location = new System.Drawing.Point(148, 20);
			this.GrossMonthlyLabel.Name = "GrossMonthlyLabel";
			this.GrossMonthlyLabel.Size = new System.Drawing.Size(19, 13);
			this.GrossMonthlyLabel.TabIndex = 11;
			this.GrossMonthlyLabel.Text = "£0";
			// 
			// GrossAnnualLabel
			// 
			this.GrossAnnualLabel.AutoSize = true;
			this.GrossAnnualLabel.Location = new System.Drawing.Point(148, 0);
			this.GrossAnnualLabel.Name = "GrossAnnualLabel";
			this.GrossAnnualLabel.Size = new System.Drawing.Size(19, 13);
			this.GrossAnnualLabel.TabIndex = 10;
			this.GrossAnnualLabel.Text = "£0";
			// 
			// GrossAnnualNumericUpDown
			// 
			this.GrossAnnualNumericUpDown.Location = new System.Drawing.Point(123, 13);
			this.GrossAnnualNumericUpDown.Name = "GrossAnnualNumericUpDown";
			this.GrossAnnualNumericUpDown.Size = new System.Drawing.Size(102, 20);
			this.GrossAnnualNumericUpDown.TabIndex = 1;
			// 
			// CalculatorMainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(322, 170);
			this.Controls.Add(this.GrossAnnualNumericUpDown);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.label1);
			this.Name = "CalculatorMainForm";
			this.Text = "Income Tax Calculator";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GrossAnnualNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label MonthlyTaxLabel;
		private System.Windows.Forms.Label AnnualTaxLabel;
		private System.Windows.Forms.Label NetMonthlyLabel;
		private System.Windows.Forms.Label NetAnnualLabel;
		private System.Windows.Forms.Label GrossMonthlyLabel;
		private System.Windows.Forms.Label GrossAnnualLabel;
		private System.Windows.Forms.NumericUpDown GrossAnnualNumericUpDown;
	}
}

