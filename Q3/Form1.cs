using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = String.Empty;
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			DateTime date;
			

			try
			{
				date = GetDate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			int yearsOld = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(date.Year);

			if (date.AddYears(13) >= DateTime.Now)
			{
				resultLabel.Text = "未滿13歲";
			}
			else
			{
				resultLabel.Text = "已滿13歲";
			}
		}
		private DateTime GetDate()
		{
			string value = inputTextBox.Text;
			bool isDate = DateTime.TryParse(value, out DateTime number);
			return isDate ? number : throw new Exception("請輸入日期");
		}
	}

}
