using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class TabAddProxyForAccounts : Form
    {
        public static TabAddProxyForAccounts instance;

        public List<Account> accounts = new List<Account>();

        public TabAddProxyForAccounts(List<Account> accounts)
        {
            InitializeComponent();
            this.accounts = accounts;
        }

        private void TabAddProxyForAccounts_Load(object sender, EventArgs e)
        {
            loadLanguage();
            Text = ((MainController.language == 0) ? $"Thêm Proxy cho {accounts.Count} TK" : $"Add proxy for {accounts.Count} TK");
            textBox1.Text = ((accounts[0].ProxyInfo != string.Empty) ? accounts[0].ProxyInfo : string.Empty);
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
            foreach (Account account in accounts)
            {
                account.ProxyInfo = textBox1.Text.Trim();
            }
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
