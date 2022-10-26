using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void enterButton_Click(object sender, EventArgs e)
		{
			try
			{
				string result = Calculate(Convert.ToInt32(inputTextBox.Text));
				answerLabel.Text = result;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private string Calculate(int value)
		{
			string answer = string.Empty;
			if (value >= 1 && value <= 99)
			{
				answer = "是";
				return answer;
			}
			else
			{
				answer = "否";
				return answer;
			}
		}
	}
}
