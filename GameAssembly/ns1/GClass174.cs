using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using Newtonsoft.Json;

namespace ns1
{
	public class GClass174
	{
		public bool bool_0;

		private static GClass174 wOlbSgackV;

		public static string string_0;

		public bool bool_1 = false;

		public bool bool_2 = false;

		private static byte[] byte_0 = new byte[2048];

		public static Socket socket_0;

		public static GClass174 smethod_0()
		{
			return (wOlbSgackV != null) ? wOlbSgackV : (wOlbSgackV = new GClass174());
		}

		public void method_0(int Port)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				try
				{
					socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket_0.Connect(IPAddress.Loopback, Port);
					socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_3, socket_0);
					if (!bool_2)
					{
						smethod_0().method_2(new vMessage
						{
							cmd = 0,
							data = Encoding.ASCII.GetBytes(string_0)
						});
						bool_2 = true;
					}
					Thread.Sleep(400);
				}
				catch (Exception ex)
				{
					GClass188.smethod_0("Data/Errors/Connect.txt", ex.ToString());
				}
			});
			thread.IsBackground = true;
			thread.Start();
		}

		private void method_1(string string_1)
		{
			if (!bool_0)
				return;
			try
			{
				vMessage vMessage = JsonConvert.DeserializeObject<vMessage>(string_1);
				if (vMessage != null)
					GClass172.smethod_0().method_18(vMessage);
			}
			catch
			{
			}
		}

		public void method_2(object obj)
		{
			string s = JsonConvert.SerializeObject(obj);
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			try
			{
				socket_0.Send(bytes);
			}
			catch (ObjectDisposedException)
			{
			}
		}

		public void method_3(IAsyncResult ar)
		{
			try
			{
				Socket socket = (Socket)ar.AsyncState;
				if (socket.Connected)
				{
					int num = 0;
					try
					{
						num = socket.EndReceive(ar);
					}
					catch
					{
					}
					if (num != 0)
					{
						byte[] array = new byte[num];
						Array.Copy(byte_0, array, num);
						method_1(Encoding.UTF8.GetString(array));
						socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_3, socket_0);
						return;
					}
				}
				GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? "Đã ngắt kết nối" : "Disconnect to game Manager", 0);
				method_0(GClass199.int_0);
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/ReceiveData.txt", ex.ToString());
			}
		}
	}
}
