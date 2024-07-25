using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DragonBoyManager
{
    public partial class AddMoreAccount : Form
    {
        public string _account;

        public string _password;

        public string _server;

        public string _note;

        public string _size;

        public AddMoreAccount(string account, string password, string server, string note, string size)
        {
            InitializeComponent();
            _account = account;
            _password = password;
            _server = server;
            _note = note;
            _size = size;
        }

        private void AddMoreAccount_Load(object sender, EventArgs e)
        {
            loadLanguage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabData._instance.Save((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            TabData._instance.SaveData();
            Close();
        }

        public void loadLanguage()
        {
            if (MainController.language == 1)
            {
                Text = "Add Accounts";
                button1.Text = "Add";
                label2.Text = "To";
                label1.Text = "From";
                groupBox1.Text = "Input X Range: ";
            }
        }
    }
}
