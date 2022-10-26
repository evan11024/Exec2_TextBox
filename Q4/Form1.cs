using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = String.Empty;
		}

		private void caluButton_Click(object sender, EventArgs e)
		{
			int carNum = GetCarNumber();
			int peopleNum = GetPeopleNum();
			int peoplePrice = GetPeoplePrice(peopleNum);
			int carPrice = GetCarPrice(carNum);
			if (peoplePrice < carPrice)
			{
				resultLabel.Text = $"適用人數計價 價格為{peoplePrice}元";
			}
			else if (peoplePrice > carPrice)
			{
				resultLabel.Text = $"適用車輛計價 價格為{carPrice}元";
			}
			else
			{
				resultLabel.Text = $"兩種方案價格同為{carPrice}元";
			}
		}

		private int GetPeoplePrice(int peopleNum)
		{
			int price = peopleNum*60;
			return price;
		}

		private int GetCarPrice(int carNum)
		{
			int price = carNum * 200;
			return price;
		}

		private int GetCarNumber()
		{
			string number = carTextBox.Text;
			bool isInt = int.TryParse(number, out int num);
			if (isInt && num >= 0)
			{
				return num;
			}
			else
			{
				throw new Exception("請輸入不小於零的數字");
			}
		}

		private int GetPeopleNum()
		{
			string number = peopleTextBox.Text;
			bool isInt = int.TryParse(number, out int num);
			if (isInt&&num>=0)
			{
				return num;
			}
			else
			{
				throw new Exception("請輸入不小於零的數字");
			}
			
			
		}
	}
}
