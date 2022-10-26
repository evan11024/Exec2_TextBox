using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			resultLabel.Text = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
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
			if (date < DateTime.Now)
			{
				resultLabel.Text = "yes";
			}
			else
			{
				resultLabel.Text = "NO";
			}
		}

		private DateTime GetDate()
		{
			string value = inputTextbox.Text;
			bool isDate = DateTime.TryParse(value, out DateTime number);
			return isDate ? number : throw new Exception("請輸入日期");
		}
	}
}
