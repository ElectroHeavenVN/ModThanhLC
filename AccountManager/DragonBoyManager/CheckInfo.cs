using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using License;

namespace DragonBoyManager
{
	internal class CheckInfo
	{
		public static CheckInfo instance;

		public string Key = "Data/QLTK/key.ini";

		public static string t = string.Empty;

		public static string t1 = string.Empty;

		public static string VERSION;

		public static CheckInfo gI()
		{
            if (instance == null)
                instance = new CheckInfo();
			return instance;
		}

		public bool IsConnectedToInternet()
		{
			try
			{
				Dns.GetHostEntry("www.google.com");
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static string getUsername(string Username)
		{
			string text = HashGenerator.GenerateMD5(Username);
            //A convoluted switch statement that returns the hardcoded real name of the user based on the hash of the username.
            //To protect the privacy of the users, the original switch statement has been replaced with a simple switch statement.
            switch (text)
			{
				default:
					return "ElectroHeavenVN";
			}
            return string.Empty;
		}

		public void GetInformations()
		{
			while (IsConnectedToInternet() && MainController.instance.EnableActive)
			{
				try
				{
					if (!File.Exists(Key))
						continue;
					string licenseKey = DeviceInformation.GenerateLicense("DRAGONBALL237");
                    if (File.ReadAllText(Key) != licenseKey)
						continue;
					string requestUri = StringCipher.Decrypt("zcSZUkCeLrQOBMin6dpcBbs+rtFS5bkHiPAQGs2TMuNm74h0D99a8rgpoTWuKyARkyI0v/4RKLK928A8MZGJ04NElY81xb6hw64kBixuPKSTuwiPUGjikBVFlHSQrDB8AWp1G2nwQYy7ecWU4xqvLmCc8PfGHzpjjIYheE5+Vi/Dv1QuZ6/HeFmgFMQ/Ys9kX0sI6Lgx+iB8cU0O1r9azg==", "thanhlc.com");
					string text2 = new HttpClient().GetAsync(requestUri).Result.Content.ReadAsStringAsync().Result.ToString();
					if (!string.IsNullOrEmpty(text2))
					{
						Match match = Regex.Match(text2, licenseKey + ".*?(?=endkey)");
						if (match != Match.Empty)
						{
							string[] array = match.ToString().Split('|');
							MainController.instance.DayLeft = array[3];
							DateTime now = DateTime.Now;
							int day = now.Day;
							int month = now.Month;
							int year = now.Year;
							string[] array3 = MainController.instance.DayLeft.ToString().Split('-');
							int day2 = int.Parse(array3[2]);
							int month2 = int.Parse(array3[1]);
							int year2 = int.Parse(array3[0]);
							DateTime value = new DateTime(year, month, day);
							if ((int)Math.Ceiling(new DateTime(year2, month2, day2).Subtract(value).TotalDays) < 0)
								Application.Exit();
							else if (array[1] == "DBOPROTHANHLC" && array[5] == "ban")
                            {
                                Process[] processes = Process.GetProcesses();
                                foreach (Process process in processes)
                                {
                                    if (process.MainWindowTitle.StartsWith("LCT ["))
                                    {
                                        process.Kill();
                                        return;
                                    }
                                }
                                Application.Exit();
                            }
                        }
						else
							Application.Exit();
					}
					Thread.Sleep(600000);
				}
				catch { }
			}
		}

		public void GetInformation()
		{
			while (IsConnectedToInternet() && !MainController.instance.EnableActive)
			{
				try
				{
					if (!File.Exists(Key))
						continue;
                    string licenseKey = DeviceInformation.GenerateLicense("DRAGONBALL237");
                    if (File.ReadAllText(Key) != licenseKey)
						continue;
                    string requestUri = StringCipher.Decrypt("zcSZUkCeLrQOBMin6dpcBbs+rtFS5bkHiPAQGs2TMuNm74h0D99a8rgpoTWuKyARkyI0v/4RKLK928A8MZGJ04NElY81xb6hw64kBixuPKSTuwiPUGjikBVFlHSQrDB8AWp1G2nwQYy7ecWU4xqvLmCc8PfGHzpjjIYheE5+Vi/Dv1QuZ6/HeFmgFMQ/Ys9kX0sI6Lgx+iB8cU0O1r9azg==", "thanhlc.com");
                    string text2 = new HttpClient().GetAsync(requestUri).Result.Content.ReadAsStringAsync().Result.ToString();
					if (!string.IsNullOrEmpty(text2))
					{
						Match match = Regex.Match(text2, licenseKey + ".*?(?=endkey)");
						if (match != Match.Empty)
						{
							string[] array = match.ToString().Split('|');
							MainController.instance.DayLeft = array[3];
							DateTime now = DateTime.Now;
							int day = now.Day;
							int month = now.Month;
							int year = now.Year;
							string[] array2 = array[2].Split('-');
							MainController.instance.Options[0] = array2[0][9].ToString();
							MainController.instance.Options[1] = array2[1][9].ToString();
							MainController.instance.Options[2] = array2[2][9].ToString();
							MainController.instance.Options[3] = array2[3][9].ToString();
							MainController.instance.Username = array[4];
							string[] array3 = MainController.instance.DayLeft.ToString().Split('-');
							int day2 = int.Parse(array3[2]);
							int month2 = int.Parse(array3[1]);
							int year2 = int.Parse(array3[0]);
							DateTime value = new DateTime(year, month, day);
							if ((int)Math.Ceiling(new DateTime(year2, month2, day2).Subtract(value).TotalDays) < 0)
								Application.Exit();
							else if (array[5] == "hoantat" && array[1] == "DBOPROTHANHLC")
							{
								VERSION = array[6];
								MainController.instance.EnableActive = true;
								if (MainController.instance.EnableActive)
								{
									MainController.instance.groupBox1.Enabled = true;
									TabData._instance.button4.Enabled = MainController.instance.Options[1].Contains("T");
									TabControl.instance.groupBox5.Enabled = MainController.instance.Options[3].Contains("T");
									MainController.instance.groupBox1.Location = new Point(0, 0);
									MainController.instance.groupBox1.Show();
									MainController.instance.Size = new Size(1018, 515);
									t1 = HashGenerator.GenerateMD5(MainController.instance.Username);
									MainController.instance.Text = "\ud835\udcd3\ud835\udc93\ud835\udc82\ud835\udc88\ud835\udc90\ud835\udc8f \ud835\udcd1\ud835\udc82\ud835\udc8d\ud835\udc8d \ud835\udcdf\ud835\udc93\ud835\udc90 \ud835\udfd0.\ud835\udfd1.\ud835\udfd5 [\ud835\udc95\ud835\udc89\ud835\udc82\ud835\udc8f\ud835\udc89\ud835\udc8d\ud835\udc84.\ud835\udc84\ud835\udc90\ud835\udc8e - \ud835\udc6a\ud835\udc8d\ud835\udc8a\ud835\udc86\ud835\udc8f\ud835\udc95: " + getUsername(MainController.instance.Username) + "]";
									MainController.instance.label5.Text = ((MainController.language == 0) ? ("Phiên bản đang dùng: " + MainController.VERSION) : ("Current version: " + MainController.VERSION));
									MainController.instance.label1.Text = ((MainController.language == 0) ? ("Phiên bản mới nhất: " + VERSION) : ("Newest version: " + VERSION));
									MainController.instance.label3.Text = ((MainController.language == 0) ? ("Người dùng: " + getUsername(MainController.instance.Username)) : ("User: " + getUsername(MainController.instance.Username)));
									MainController.instance.checkBox1.Checked = MainController.instance.Options[1].Contains("T");
									MainController.instance.checkBox2.Checked = MainController.instance.Options[0].Contains("T");
									MainController.instance.checkBox3.Checked = MainController.instance.Options[2].Contains("T");
									MainController.instance.checkBox4.Checked = MainController.instance.Options[3].Contains("T");
									TabControl.instance.groupBox5.Visible = MainController.instance.Options[3].Contains("T");
									TabSetting.instance.checkBox22.Visible = MainController.instance.Options[0].Contains("T");
									TabSetting.instance.groupBox3.Visible = MainController.instance.Options[0].Contains("T");
									if (getUsername(MainController.instance.Username) == string.Empty)
										Application.Exit();
									if (File.ReadAllText(Key) != licenseKey)
										File.WriteAllText(Key, licenseKey);
									if (float.Parse(MainController.VERSION) < float.Parse(VERSION))
									{
										MessageBox.Show((MainController.language == 0) ? ("Phiên bản bạn đang dùng quá cũ [" + MainController.VERSION + "]\nVui lòng update phiên bản mới [" + VERSION + "]") : ("Version of your product is too old! [" + MainController.VERSION + "]\nPlease update new version [" + VERSION + "]"), "Require update !!");
										Application.Exit();
									}
                                    Thread thread = new Thread(gI().GetInformations) { IsBackground = true };
                                    thread.Start();
									t = licenseKey;
								}
							}
						}
						else
							Application.Exit();
					}
					Thread.Sleep(10000);
				}
				catch
				{
				}
			}
		}
	}
}
