using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class SetSize : Form
	{
		public List<Account> accounts = new List<Account>();

		public SetSize(List<Account> accounts)
		{
			InitializeComponent();
			this.accounts = accounts;
		}

		private void SetSize_Load(object sender, EventArgs e)
		{
			Text = "Sửa KT " + accounts.Count + " TK";
			textBox1.Text = accounts[0].SizeScreen.Split('x')[0];
			textBox2.Text = accounts[0].SizeScreen.Split('x')[1];
			loadLanguage();
		}

		public void loadLanguage()
		{
			if (MainController.language == 1)
			{
				groupBox1.Text = "Edit size";
				button1.Text = "Save";
				label2.Text = "Height";
				label1.Text = "Weight";
			}
		}

		public void SaveSize()
		{
			foreach (Account account in accounts)
			{
				account.SizeScreen = textBox1.Text + "x" + textBox2.Text;
			}
			MainController.instance.REFRESH = true;
			TabData._instance.SaveData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveSize();
			Close();
		}
	}
}
