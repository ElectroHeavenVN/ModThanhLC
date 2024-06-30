using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using License;
using Newtonsoft.Json;

namespace DragonBoyManager
{
    public partial class TabData : UserControl
    {
        public static TabData _instance;

        public bool isAutoOpenAccount;

        public string DataAccountPath = "Data/QLTK/dataAccount.json";

        public string PortPath = "Data/QLTK/Port.ini";

        public string KeyPath = "Data/QLTK/Key.ini";

        public List<Account> GetAccountsSelected()
        {
            List<DataGridViewRow> list = dataGridView1.SelectedRows.Cast<DataGridViewRow>().ToList();
            List<Account> list2 = new List<Account>();
            foreach (DataGridViewRow item in list)
            {
                list2.Add(item.DataBoundItem as Account);
            }
            return list2;
        }

        public List<Account> GetAccounts()
        {
            return dataAccount.Cast<Account>().ToList();
        }

        public Account getAccount(int index)
        {
            if (index == -1)
                return dataAccount.Current as Account;
            return dataAccount[index] as Account;
        }

        public TabData()
        {
            InitializeComponent();
            _instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa điền tài khoản !" : "Username has not been filled in!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa điền mật khẩu !" : "Password has not been filled in!");
                return;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa chọn máy chủ !" : "Server is Empty!");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show((MainController.language == 0) ? "Chưa điền ghi chú !" : "Note is empty now!");
                return;
            }
            if (checkBox1.Checked)
            {
                new AddMoreAccount(textBox1.Text, textBox2.Text, comboBox1.Text, textBox3.Text, textBox4.Text + "x" + textBox5.Text).ShowDialog();
                return;
            }
            dataAccount.Add(new Account
            {
                ID = dataAccount.Count,
                Username = textBox1.Text.Trim().ToLower(),
                Password = textBox2.Text.Trim().ToLower(),
                Server = comboBox1.SelectedItem.ToString(),
                Note = textBox3.Text,
                SizeScreen = ((textBox4.Text == string.Empty || textBox5.Text == string.Empty) ? "1024x600" : (textBox4.Text + "x" + textBox5.Text)),
                ScreenLevel = ((textBox4.Text == string.Empty || textBox5.Text == string.Empty) ? "Lớn" : ((int.Parse(textBox4.Text) * int.Parse(textBox5.Text) < 450000) ? "Nhỏ" : "Lớn"))
            });
            SaveData();
        }

        private bool checkInput()
        {
            return !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox3.Text);
        }

        public void Save(int to, int up)
        {
            string[] array = textBox1.Text.Split('X');
            for (int i = to; i <= up; i++)
            {
                string text = array[0] + i + array[1];
                dataAccount.Add(new Account
                {
                    ID = dataAccount.Count,
                    Username = text.Trim().ToLower(),
                    Password = textBox2.Text.Trim().ToLower(),
                    Server = comboBox1.SelectedItem.ToString(),
                    Note = textBox3.Text,
                    SizeScreen = ((textBox4.Text == string.Empty || textBox5.Text == string.Empty) ? "1024x600" : (textBox4.Text + "x" + textBox5.Text)),
                    ScreenLevel = ((textBox4.Text == string.Empty || textBox5.Text == string.Empty) ? "Lớn" : ((int.Parse(textBox4.Text) * int.Parse(textBox5.Text) < 450000) ? "Nhỏ" : "Lớn"))
                });
            }
        }

        public void SaveData()
        {
            File.WriteAllText(DataAccountPath, StringCipher.Encrypt(JsonConvert.SerializeObject(dataAccount), MainController.instance.Username + DeviceInformation.GetDeviceID()));
        }

        public void LoadData()
        {
            dataAccount.Clear();
            if (!File.Exists(DataAccountPath) || !(MainController.instance.Username != string.Empty))
                return;
            try
            {
                Account[] array = JsonConvert.DeserializeObject<Account[]>(StringCipher.Decrypt(File.ReadAllText(DataAccountPath), MainController.instance.Username + DeviceInformation.GetDeviceID()));
                foreach (Account value in array)
                {
                    dataAccount.Add(value);
                }
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                int index = dataGridView1.CurrentRow.Index;
                DataGridViewCellCollection cells = dataGridView1.Rows[index].Cells;
                cells[1].Value = index;
                cells[2].Value = textBox1.Text.Trim().ToLower();
                cells[3].Value = textBox2.Text.Trim().ToLower();
                cells[4].Value = comboBox1.SelectedItem;
                cells[5].Value = textBox3.Text;
                cells[8].Value = ((textBox4.Text == string.Empty || textBox5.Text == string.Empty) ? "1024x600" : (textBox4.Text + "x" + textBox5.Text));
                SaveData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Account item in GetAccountsSelected())
            {
                if (item != null)
                {
                    dataAccount.Remove(item);
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = i;
                    }
                    continue;
                }
                return;
            }
            SaveData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<IntPtr> list = new List<IntPtr>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                IntPtr intPtr = MainController.FindWindow(null, "LCT [" + dataGridView1.Rows[i].Cells[1].Value?.ToString() + "]");
                if (intPtr != IntPtr.Zero)
                    list.Add(intPtr);
            }
            foreach (IntPtr item in list)
            {
                MainController.ShowWindowAsync(item, 6);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await MainController.ShowAndArrangeWindows(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.StartsWith("LCT ["))
                    process.Kill();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Account item in GetAccountsSelected())
            {
                item.isLogin = true;
            }
            dataGridView1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Account item in GetAccountsSelected())
            {
                item.isLogin = false;
            }
            dataGridView1.Refresh();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            List<Account> accounts = GetAccountsSelected();
            if (accounts.Count > 1)
            {
                foreach (Account account in accounts)
                {
                    if (account != null && (account.process == null || account.process.HasExited))
                        await MainController.instance.openAccount(account);
                }
            }
            if (accounts.Count == 1 && accounts[0] != null && (accounts[0].process == null || accounts[0].process.HasExited))
                await MainController.instance.openAccount(accounts[0]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            isAutoOpenAccount = !isAutoOpenAccount;
            button11.Text = ((MainController.language == 0) ? ("Auto mở game: [" + (isAutoOpenAccount ? "Bật" : "Tắt") + "]") : ("Auto open game: [" + (isAutoOpenAccount ? "On" : "Off") + "]"));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = checkBox2.Checked;
            if (checkBox2.Checked)
                textBox2.PasswordChar = '*';
            else
                textBox2.PasswordChar = '\0';
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    textBox1.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString() != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString() : string.Empty);
                    textBox2.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString() : string.Empty);
                    comboBox1.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString() : string.Empty);
                    textBox3.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString() != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString() : string.Empty);
                    textBox4.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString().Split('x')[0] != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString().Split('x')[0] : string.Empty);
                    textBox5.Text = ((dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString().Split('x')[1] != string.Empty) ? dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value.ToString().Split('x')[1] : string.Empty);
                    if (MainController.FindWindow(null, $"LCT [{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value}]") != IntPtr.Zero)
                    {
                        MainController.SetForegroundWindow(MainController.FindWindow(null, $"LCT [{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value}]"));
                        MainController.ShowWindowAsync(MainController.FindWindow(null, $"LCT [{dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value}]"), 1);
                    }
                    MainController.instance.REFRESH = true;
                }
            }
            catch
            {
            }
        }

        private void TabData_Load(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        public void loadLanguage()
        {
            if (MainController.language == 1)
            {
                usernameDataGridViewTextBoxColumn.HeaderText = "Username";
                noteDataGridViewTextBoxColumn.HeaderText = "Note";
                ProxyInfo.HeaderText = "Information";
                statusDataGridViewTextBoxColumn.HeaderText = "Status";
                sizeScreenDataGridViewTextBoxColumn.HeaderText = "Size";
                groupBox1.Text = "Account information";
                checkBox3.Text = "HideUs";
                label6.Text = "Height";
                label5.Text = "Weight";
                label4.Text = "Note";
                label3.Text = "Server";
                checkBox2.Text = "HidePass";
                checkBox1.Text = "Add List account";
                label2.Text = "Password";
                label1.Text = "Username";
                groupBox2.Text = "Interact with account";
                button11.Text = "Auto open game";
                button8.Text = "Login";
                button7.Text = "Close";
                button5.Text = "Sort";
                button6.Text = "Minimize";
                button4.Text = "Add Proxy";
                button3.Text = "Delete";
                button2.Text = "Edit";
                button1.Text = "Add";
            }
        }

        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (Account account in GetAccountsSelected())
            {
                if (account != null && (account.process == null || account.process.HasExited))
                    await MainController.instance.openAccount(account);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Account> accountsSelected = GetAccountsSelected();
            if (accountsSelected.Count == 1)
                new TabAddProxyforAccount(accountsSelected[0]).ShowDialog();
            else if (accountsSelected.Count > 1)
            {
                Predicate<Account> predicate = default(Predicate<Account>);
                new TabAddProxyForAccounts(accountsSelected.FindAll(predicate ?? (predicate = (Account x) => x != null))).ShowDialog();
            }
        }

        private async void update_Tick(object sender, EventArgs e)
        {
            if (_instance.isAutoOpenAccount)
            {
                Predicate<Account> predicate = default(Predicate<Account>);
                Account acc = _instance.GetAccounts().Find(predicate ?? ((Predicate<Account>)((Account x) => x != null && x.isLogin && (x.process == null || x.process.HasExited))));
                if (acc != null)
                    await MainController.instance.openAccount(acc);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns[2].Visible = !checkBox3.Checked;
            textBox1.UseSystemPasswordChar = checkBox3.Checked;
            if (checkBox3.Checked)
                textBox1.PasswordChar = '*';
            else
                textBox1.PasswordChar = '\0';
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
