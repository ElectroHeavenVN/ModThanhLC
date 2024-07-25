using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DragonBoyManager
{
	public static class SocketServer
	{
		public class vMessage
		{
			[JsonProperty(nameof(cmd))]
			public int cmd;

            [JsonProperty(nameof(data))]
            public byte[] data;
		}

		public class vSocket
		{
			public Socket _Socket { get; set; }

			public string _Name { get; set; }

			public vSocket(Socket socket)
			{
				_Socket = socket;
			}
		}

		public static List<Account> waitingAccounts = new List<Account>();

		public static ManualResetEvent allDone = new ManualResetEvent(false);

		private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

		private static List<vSocket> __ClientSockets { get; set; } = new List<vSocket>();


		public static void StartListening(int port)
		{
			Dns.GetHostEntry(Dns.GetHostName());
			IPAddress any = IPAddress.Any;
			IPEndPoint localEP = new IPEndPoint(any, port);
			Socket socket = new Socket(any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				socket.Bind(localEP);
				socket.Listen(100);
				while (true)
				{
					allDone.Reset();
					socket.BeginAccept(AcceptCallback, socket);
					allDone.WaitOne();
				}
			}
			catch
			{
				Random random = new Random();
				int num = random.Next(1000, 10000);
				if (num == port)
				{
					num = random.Next(1000, 10000);
					return;
				}
				File.WriteAllText(TabData._instance.PortPath, num.ToString());
				MessageBox.Show((MainController.language == 0) ? "Vui lòng mở lại QLTK!" : "Please reopen this application!");
				Application.Exit();
			}
		}

		private static void onMessage(vMessage msg, StateObject state)
		{
			try
			{
                switch (msg.cmd)
                {
                    case 0:
                        state.account = waitingAccounts.Find(acc => acc.ID == int.Parse(Encoding.ASCII.GetString(msg.data)));
                        if (state.account != null)
                        {
                            state.account.workSocket = state.workSocket;
                            state.account.Status = MainController.language == 0 ? "Đã kết nối" : "Connected";
                            MainController.instance.REFRESH = true;
                        }
                        break;
                    case 1:
                    {
                        Account account = TabData._instance.GetAccounts().Find(acc => acc != null && acc.ID == int.Parse(Encoding.ASCII.GetString(msg.data)) && !string.IsNullOrEmpty(acc.Status));
                        if (account != null)
                            account.Status = "";
                        MainController.instance.REFRESH = true;
                        break;
                    }
                    case 3:
                        state.account = waitingAccounts.Find(acc => acc.ID == int.Parse(Encoding.ASCII.GetString(msg.data)));
                        if (state.account != null)
                            state.account.Status = MainController.language == 0 ? "Mất kết nối" : "Disconnected";
                        MainController.instance.REFRESH = true;
                        break;
                    case 2:
                        break;
                }
            }
			catch (Exception ex)
			{
				File.WriteAllText("Data/Errors/SocketOnMessage.txt", ex.Message);
			}
		}

		public static void sendMessage(this Account account, vMessage msg)
		{
			Send(account.workSocket, JsonConvert.SerializeObject(msg));
		}

		public static void AcceptCallback(IAsyncResult ar)
		{
			allDone.Set();
			Socket socket = ((Socket)ar.AsyncState).EndAccept(ar);
			StateObject stateObject = new StateObject
			{
				workSocket = socket
			};
			socket.BeginReceive(stateObject.buffer, 0, 4096, SocketFlags.None, ReadCallback, stateObject);
			Send(socket, new vMessage
			{
				cmd = 0
			});
		}

		public static void ReadCallback(IAsyncResult ar)
		{
			string empty = "";
			StateObject stateObject = (StateObject)ar.AsyncState;
			Socket workSocket = stateObject.workSocket;
			int num = 0;
			try
			{
				num = workSocket.EndReceive(ar);
			}
			catch (Exception)
			{
				goto IL_00a7;
			}
			if (num > 0)
			{
				empty = Encoding.UTF8.GetString(stateObject.buffer, 0, num);
				vMessage vMessage = null;
				try
				{
					vMessage = JsonConvert.DeserializeObject<vMessage>(empty);
				}
				catch (Exception) { }
				if (vMessage != null)
				{
					if (vMessage.cmd == -1)
						goto IL_00a7;
					onMessage(vMessage, stateObject);
				}
				try
				{
					workSocket.BeginReceive(stateObject.buffer, 0, 4096, SocketFlags.None, ReadCallback, stateObject);
					return;
				}
				catch (Exception) { }
			}
			IL_00a7:
			if (stateObject.workSocket != null && stateObject.workSocket.Connected)
			{
				workSocket.Shutdown(SocketShutdown.Both);
				workSocket.Close();
			}
			if (stateObject.account != null)
			{
				waitingAccounts.Remove(stateObject.account);
                stateObject.account.Status = "";
            }
        }

		private static void SendCallback(IAsyncResult ar)
		{
			try
			{
				((Socket)ar.AsyncState).EndSend(ar);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private static void Send(Socket handler, string data)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(data);
			handler.BeginSend(bytes, 0, bytes.Length, SocketFlags.None, SendCallback, handler);
		}

		private static void Send(Socket handler, vMessage msg)
		{
			Send(handler, JsonConvert.SerializeObject(msg));
		}
	}
}
