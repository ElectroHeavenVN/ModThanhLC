using System;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class TabAddProxyforAccount : Form
	{
		public static TabAddProxyforAccount instance;

		public Account currAccount;
		
		public TabAddProxyforAccount(Account currAccount)
		{
			InitializeComponent();
			this.currAccount = currAccount;
		}

		private void TabAddProxyforAccount_Load(object sender, EventArgs e)
		{
			loadLanguage();
			Text = currAccount.Username;
			textBox1.Text = ((currAccount.ProxyInfo != string.Empty) ? currAccount.ProxyInfo : string.Empty);
		}

		public void loadLanguage()
		{
			if (MainController.language == 1)
			{
				groupBox1.Text = "Input Proxy Information";
				label1.Text = "Enter information as:";
				label2.Text = "IP:PORT:USERNAME:PASSWORD";
				button1.Text = "Save";
			}
		}

		public void SaveProxy()
		{
			currAccount.ProxyInfo = textBox1.Text.Trim();
			MainController.instance.REFRESH = true;
			TabData._instance.SaveData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveProxy();
			Close();
		}
	}
}
