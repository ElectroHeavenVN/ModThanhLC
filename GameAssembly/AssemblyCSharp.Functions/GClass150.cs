using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace AssemblyCSharp.Functions
{
	public class GClass150
	{
		[CompilerGenerated]
		private sealed class Class14
		{
			public int int_0;

			public GClass150 gclass150_0;

			internal void method_0()
			{
				try
				{
					socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket_0.Connect(IPAddress.Loopback, int_0);
					socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, gclass150_0.method_3, socket_0);
					if (!gclass150_0.bool_2)
					{
						smethod_0().method_2(new vMessage
						{
							cmd = 0,
							data = Encoding.ASCII.GetBytes(GClass150.int_0.ToString())
						});
						gclass150_0.bool_2 = true;
					}
					Thread.Sleep(400);
				}
				catch (Exception ex)
				{
					GClass149.smethod_0("Data/Errors/Connect.txt", ex.ToString());
				}
			}
		}

		public bool bool_0;

		private static GClass150 gclass150_0;

		public static int int_0;

		public bool bool_1 = false;

		public bool bool_2 = false;

		private static byte[] byte_0 = new byte[2048];

		public static Socket socket_0;

		public static GClass150 smethod_0()
		{
			return (gclass150_0 != null) ? gclass150_0 : (gclass150_0 = new GClass150());
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
							data = Encoding.ASCII.GetBytes(int_0.ToString())
						});
						bool_2 = true;
					}
					Thread.Sleep(400);
				}
				catch (Exception ex)
				{
					GClass149.smethod_0("Data/Errors/Connect.txt", ex.ToString());
				}
			});
			thread.IsBackground = true;
			thread.Start();
		}

		private void method_1(string string_0)
		{
			if (bool_0)
			{
				vMessage vMessage2 = JsonConvert.DeserializeObject<vMessage>(string_0);
				if (vMessage2 != null)
					GClass171.smethod_0().method_23(vMessage2);
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
					byte[] array = new byte[2048];
					int num = 0;
					try
					{
						num = socket.EndReceive(ar);
					}
					catch
					{
					}
					if (num > 0)
					{
						Array.Copy(byte_0, array, num);
						method_1(Encoding.UTF8.GetString(array));
						Array.Clear(byte_0, 0, byte_0.Length);
						Array.Clear(array, 0, array.Length);
						socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_3, socket_0);
						return;
					}
				}
				if (bool_0)
					method_0(GClass172.int_0);
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/ReceiveData.txt", ex.ToString());
			}
		}
	}
}
