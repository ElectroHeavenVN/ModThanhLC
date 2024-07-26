using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using License;

namespace DragonBoyManager
{
    public partial class MainController : Form
	{
		public struct RECT
		{
			public int left, top, right, bottom;
		}

		public static string VERSION = "2.0";

		public static MainController instance;

		public string Username;

		public string DayLeft;

		public bool EnableActive;

		public string[] Options = new string[4];

		public bool REFRESH;

		public bool isResetScrollBar;

		public bool isSetupConnect;

		public static int language = 0;

		public long TimePlus;

		public MainController()
		{
			InitializeComponent();
			instance = this;
#if DEBUG
            CheckForIllegalCrossThreadCalls = false;
#endif
        }

		private void MainController_Load(object sender, EventArgs e)
		{
			if (!File.Exists(CheckInfo.gI().key))
			{
				MessageBox.Show((language == 0) ? "Vui lòng mở [ThanhLc] Product License.exe và lấy mã kích hoạt nhập lên website thanhlc.com!" : "Contact admin!!");
				Application.Exit();
			}
            Thread thread = new Thread(CheckInfo.gI().GetInformation)
            {
                IsBackground = true
            };
            thread.Start();
			if (!groupBox1.Enabled)
				groupBox1.Hide();
			TabSetting.instance.LoadFunctionSetting();
			TabSetting.instance.LoadGraphicSetting();
			TabSetting.instance.LoadCaptcha();
			loadLanguage();
			TabSetting.instance.loadLanguage();
			TabData._instance.loadLanguage();
			TabControl.instance.loadLanguage();
		}

		private void loadLanguage()
		{
			if (language != 1)
				return;
			try
			{
				tabPage1.Text = "ACCOUNT";
				tabPage2.Text = "CONTROL";
				tabPage3.Text = "SETTING";
				tabPage4.Text = "INFORMATION";
				đăngNhậpToolStripMenuItem.Text = "LOGIN";
				sửaKíchThướcToolStripMenuItem.Text = "EDIT SIZE";
				groupBox2.Text = "Activated Options";
				groupBox3.Text = "Product Informations";
				checkBox4.Text = "OPTION: Black Star D.Ball";
				đăngNhậpToolStripMenuItem.Text = "Login";
				sửaKíchThướcToolStripMenuItem.Text = "Edit Size";
				sửaGhiChúToolStripMenuItem.Text = "Edit Note";
                useProxyToolStripMenuItem.Text = "☑ Use Proxy";
                doNotUseProxyToolStripMenuItem.Text = "❎ Not use Proxy";
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public static async Task ShowAndArrangeWindows(int type)
		{
			List<Account> accounts = TabData._instance.GetAccounts();
			await ShowWindowsAsync(accounts);
			ArrangeWindows(accounts, type);
		}

		public static bool ExistedWindow(Account account, out IntPtr hWnd)
		{
			hWnd = IntPtr.Zero;
			if (account.process == null || account.process.HasExited)
				return false;
			hWnd = account.process.MainWindowHandle;
			return hWnd != IntPtr.Zero;
		}

		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern bool SetWindowText(IntPtr hWnd, string text);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string x, string y);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll")]
		public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

		public static async Task ShowWindowsAsync(List<Account> accounts)
		{
			foreach (Account account in accounts)
			{
				if (ExistedWindow(account, out var hWnd))
				{
					ShowWindowAsync(hWnd, 1);
					SetForegroundWindow(hWnd);
				}
			}
			await Task.Delay(1000);
		}

		public static void ArrangeWindows(List<Account> accounts, int type)
		{
			int num = Screen.PrimaryScreen.Bounds.Width;
			int num2 = Screen.PrimaryScreen.Bounds.Height;
			int num3 = 0;
			int num4 = 0;
			accounts.RemoveAll(x => x.process == null || x.process.HasExited);
			for (int i = 0; i < accounts.Count; i++)
			{
				if (ExistedWindow(accounts[i], out var hWnd) && GetWindowRect(hWnd, out var lpRect))
				{
					int num5 = lpRect.right - lpRect.left;
					int num6 = lpRect.bottom - lpRect.top;
					MoveWindow(hWnd, num3, num4, num5, num6, true);
					num3 += num5 / type;
					if (num3 + num5 / type > num)
					{
						num3 = 0;
						num4 += num6 - 5;
					}
					if (num4 + num6 > num2)
						num4 = 0;
				}
			}
		}

        public async Task OpenAccount(Account account)
        {
            if (account.process != null && !account.process.HasExited)
                return;
            account.process = new Process();
            account.process.StartInfo.FileName = "Dragon ball_237b.exe";
            if (account.isUseProxy && Options[1] == "T")
                account.process.StartInfo.Arguments = $"--ID {account.ID} --username {account.Username.Trim()} --password {account.Password.Trim()} --server {account.Server.ToString().ToLower().Replace(" ", "")} --options {Options[0] + "|" + Options[1] + "|" + Options[2] + "|" + Options[3]} --isUseProxy {account.isUseProxy.ToString()} --proxy {account.ProxyInfo.Trim()} --size {account.SizeScreen.Trim()} --uuid {"username:" + CheckInfo.t1 + "," + CheckInfo.t.Trim()}";
            else
                account.process.StartInfo.Arguments = $"--ID {account.ID} --username {account.Username} --password {account.Password} --server {account.Server.ToString().ToLower().Replace(" ", "")} --options {Options[0] + "|" + Options[1] + "|" + Options[2] + "|" + Options[3]} --isUseProxy {account.isUseProxy.ToString()} --size {account.SizeScreen} --uuid {"username:" + CheckInfo.t1 + "," + CheckInfo.t.Trim()}";
            account.process.Start();
            SocketServer.waitingAccounts.Add(account);
            while (account.process.MainWindowHandle == IntPtr.Zero)
                await Task.Delay(1500);
            SetWindowText(account.process.MainWindowHandle, $"LCT [{account.ID}]");
        }

        public long CurrentTimeMillis()
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return (DateTime.UtcNow.Ticks - dateTime.Ticks) / 10000L;
		}

		private void updateTimer_Tick(object sender, EventArgs e)
		{
			try
			{
				DeleteCrashReportFolder();
				if (!groupBox1.Enabled)
					return;
				if (File.Exists("Data/GameData/fixGameError.ini"))
					textBox1.Text = File.ReadAllText("Data/GameData/fixGameError.ini");
                if (Size != new Size(765, 480))
                {
                    Size = new Size(765, 480);
                    REFRESH = true;
				}
				if (!isResetScrollBar && groupBox1.Enabled)
				{
					TabData._instance.dataGridView1.Columns[2].Visible = true;
					TabData._instance.dataGridView1.Columns[2].Visible = false;
					TabData._instance.dataGridView1.Columns[2].Visible = true;
					if (!isSetupConnect)
					{
                        new Thread(() => SocketServer.StartListening(int.Parse(File.ReadAllText(TabData._instance.PortPath)))) { IsBackground = true }.Start();
                        TabData._instance.LoadData();
						isSetupConnect = true;
					}
					isResetScrollBar = true;
				}
				instance.checkBox1.Checked = instance.Options[1].Contains("T");
				instance.checkBox2.Checked = instance.Options[0].Contains("T");
				instance.checkBox3.Checked = instance.Options[2].Contains("T");
				instance.checkBox4.Checked = instance.Options[3].Contains("T");
				if (instance.checkBox1.Checked)
					instance.checkBox1.ForeColor = Color.Yellow;
				if (instance.checkBox2.Checked)
					instance.checkBox2.ForeColor = Color.Yellow;
				if (instance.checkBox3.Checked)
					instance.checkBox3.ForeColor = Color.Yellow;
				if (instance.checkBox4.Checked)
					instance.checkBox4.ForeColor = Color.Yellow;
				for (int i = 0; i < TabData._instance.dataGridView1.Rows.Count; i++)
				{
					if (TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.BackColor != Color.FromArgb(64, 64, 64))
					{
						TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
						REFRESH = true;
					}
					if (TabData._instance.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains("True") && TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.ForeColor != Color.Yellow)
						TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;
					if (!TabData._instance.dataGridView1.Rows[i].Cells[0].Value.ToString().Contains("True") && TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.ForeColor != Color.White)
						TabData._instance.dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
					if (TabData._instance.dataGridView1.Rows[i].Cells[9].Value != null && !string.IsNullOrEmpty(TabData._instance.dataGridView1.Rows[i].Cells[9].Value.ToString()))
					{
						if ((TabData._instance.dataGridView1.Rows[i].Cells[9].Value.ToString().Contains("Đã kết nối") || TabData._instance.dataGridView1.Rows[i].Cells[9].Value.ToString().Contains("Connected")) && TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor != Color.LimeGreen)
						{
							TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.LimeGreen;
							REFRESH = true;
						}
						if ((TabData._instance.dataGridView1.Rows[i].Cells[9].Value.ToString().Contains("Mất kết nối") || TabData._instance.dataGridView1.Rows[i].Cells[9].Value.ToString().Contains("Disconnected")) && TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor != Color.Tomato)
						{
							TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Tomato;
							REFRESH = true;
						}
					}
					else if (TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor != Color.FromArgb(64, 64, 64))
					{
						TabData._instance.dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.FromArgb(64, 64, 64);
						REFRESH = true;
					}
				}
				if (TabSetting.instance.pictureBox1.BackColor != Color.FromArgb(int.Parse(TabSetting.instance.textBox1.Text.Split(',')[0]), int.Parse(TabSetting.instance.textBox1.Text.Split(',')[1]), int.Parse(TabSetting.instance.textBox1.Text.Split(',')[2])))
					TabSetting.instance.pictureBox1.BackColor = Color.FromArgb(int.Parse(TabSetting.instance.textBox1.Text.Split(',')[0]), int.Parse(TabSetting.instance.textBox1.Text.Split(',')[1]), int.Parse(TabSetting.instance.textBox1.Text.Split(',')[2]));
				if (REFRESH)
				{
					TabData._instance.dataGridView1.Refresh();
					REFRESH = false;
				}
				if (string.IsNullOrEmpty(textBox1.Text) && File.Exists("Data/GameData/fixGameError.ini"))
					File.Delete("Data/GameData/fixGameError.ini");
				TabSetting.instance.checkBox22.Enabled = Options[0].Contains("T");
			}
			catch { }
		}

		public void DeleteCrashReportFolder()
		{
			string[] directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
			foreach (string path in directories)
			{
				if (Path.GetFileName(path).StartsWith(DateTime.Now.Year.ToString()))
					Directory.Delete(path, true);
			}
		}

		private async void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Account account in TabData._instance.GetAccountsSelected())
			{
				if (account != null && (account.process == null || account.process.HasExited))
					await OpenAccount(account);
			}
		}

		private void sửaKíchThướcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SetSize(TabData._instance.GetAccountsSelected()).ShowDialog();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
			đăngNhậpToolStripMenuItem.Text = ((language == 0) ? $"ĐĂNG NHẬP [{TabData._instance.GetAccountsSelected().Count}]" : $"LOGIN [{TabData._instance.GetAccountsSelected().Count}]");
		}

		private void sửaGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SetTitle(TabData._instance.GetAccountsSelected()).ShowDialog();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Enabled && !File.Exists("Data/GameData/fixGameError.ini"))
                File.WriteAllText("Data/GameData/fixGameError.ini", HashGenerator.GenerateMD5(textBox1.Text));
            textBox1.Enabled = false;
        }

        private void toolStripMenuItem_3_Click(object sender, EventArgs e)
        {
            foreach (Account item in TabData._instance.GetAccountsSelected())
            {
                item.isUseProxy = true;
            }
            REFRESH = true;
        }

        private void toolStripMenuItem_4_Click(object sender, EventArgs e)
        {
            foreach (Account item in TabData._instance.GetAccountsSelected())
            {
                item.isUseProxy = false;
            }
            REFRESH = true;
        }
    }
}
