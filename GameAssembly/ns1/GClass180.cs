using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns1
{
    public class GClass180 : GInterface3
	{
		private enum Enum0
		{
            None,
            UsernamePassword
        }

		private string string_0;

		private int int_0;

		private string string_1;

		private string string_2;

		private Enum0 enum0_0;

		private TcpClient tcpClient_0;

		private BackgroundWorker backgroundWorker_0;

		private Exception exception_0;

		private bool bool_0;

		public string String_2
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public int Int32_0
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public string String_3 => "SOCKS5";

		public string String_0
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public TcpClient TcpClient_0
		{
			get
			{
				return tcpClient_0;
			}
			set
			{
				tcpClient_0 = value;
			}
		}

		public bool Boolean_0 => backgroundWorker_0 != null && backgroundWorker_0.IsBusy;

		public bool Boolean_1 => bool_0;

		public event EventHandler<GEventArgs0> CreateConnectionAsyncCompleted;

		public GClass180()
		{
		}

		public GClass180(TcpClient tcpClient)
		{
			if (tcpClient == null)
				throw new ArgumentNullException("tcpClient");
			tcpClient_0 = tcpClient;
		}

		public GClass180(string proxyHost)
		{
			if (string.IsNullOrEmpty(proxyHost))
				throw new ArgumentNullException("proxyHost");
			string_0 = proxyHost;
			int_0 = 1080;
		}

		public GClass180(string proxyHost, int proxyPort)
		{
			if (string.IsNullOrEmpty(proxyHost))
				throw new ArgumentNullException("proxyHost");
			if (proxyPort <= 0 || proxyPort > 65535)
				throw new ArgumentOutOfRangeException("proxyPort", "port must be greater than zero and less than 65535");
			string_0 = proxyHost;
			int_0 = proxyPort;
		}

		public GClass180(string proxyHost, string proxyUserName, string proxyPassword)
		{
			if (string.IsNullOrEmpty(proxyHost))
				throw new ArgumentNullException("proxyHost");
			if (proxyUserName == null)
				throw new ArgumentNullException("proxyUserName");
			if (proxyPassword == null)
				throw new ArgumentNullException("proxyPassword");
			string_0 = proxyHost;
			int_0 = 1080;
			string_1 = proxyUserName;
			string_2 = proxyPassword;
		}

		public GClass180(string proxyHost, int proxyPort, string proxyUserName, string proxyPassword)
		{
			if (string.IsNullOrEmpty(proxyHost))
				throw new ArgumentNullException("proxyHost");
			if (proxyPort <= 0 || proxyPort > 65535)
				throw new ArgumentOutOfRangeException("proxyPort", "port must be greater than zero and less than 65535");
			if (proxyUserName == null)
				throw new ArgumentNullException("proxyUserName");
			if (proxyPassword == null)
				throw new ArgumentNullException("proxyPassword");
			string_0 = proxyHost;
			int_0 = proxyPort;
			string_1 = proxyUserName;
			string_2 = proxyPassword;
		}

		public TcpClient CreateConnection(string destinationHost, int destinationPort)
		{
			if (string.IsNullOrEmpty(destinationHost))
				throw new ArgumentNullException("destinationHost");
			if (destinationPort <= 0 || destinationPort > 65535)
				throw new ArgumentOutOfRangeException("destinationPort", "port must be greater than zero and less than 65535");
			try
			{
				if (tcpClient_0 == null)
				{
					if (string.IsNullOrEmpty(string_0))
						throw new GException0("ProxyHost property must contain a value.");
					if (int_0 <= 0 || int_0 > 65535)
						throw new GException0("ProxyPort value must be greater than zero and less than 65535");
					tcpClient_0 = new TcpClient();
					tcpClient_0.Connect(string_0, int_0);
				}
				method_0();
				method_1();
				method_5(1, destinationHost, destinationPort);
				return tcpClient_0;
			}
			catch (Exception ex)
			{
				throw new GException0(innerException: ex, message: string.Format(CultureInfo.InvariantCulture, "Connection to proxy host {0} on port {1} failed.", Class2.smethod_0(tcpClient_0), Class2.smethod_1(tcpClient_0)));
			}
		}

		private void method_0()
		{
			if (string_1 != null && string_2 != null)
				enum0_0 = Enum0.UsernamePassword;
			else
				enum0_0 = Enum0.None;
		}

		private void method_1()
		{
			NetworkStream stream = tcpClient_0.GetStream();
			bool flag = !string.IsNullOrEmpty(string_1) && !string.IsNullOrEmpty(string_2);
			List<byte> list = new List<byte>();
			list.Add(5);
			if (flag)
			{
				list.Add(2);
				list.Add(0);
				list.Add(2);
			}
			else
			{
				list.Add(1);
				list.Add(0);
			}
			stream.Write(list.ToArray(), 0, list.Count);
			byte[] array = new byte[2];
			stream.Read(array, 0, array.Length);
			byte b = array[1];
			if (b == byte.MaxValue)
			{
				tcpClient_0.Close();
				throw new GException0("The proxy destination does not accept the supported proxy client authentication methods.");
			}
			if (b == 2 && enum0_0 == Enum0.None)
			{
				tcpClient_0.Close();
				throw new GException0("The proxy destination requires a username and password for authentication.");
			}
			if (b == 2)
			{
				byte[] array2 = new byte[string_1.Length + string_2.Length + 3];
				array2[0] = 1;
				array2[1] = (byte)string_1.Length;
				Array.Copy(Encoding.ASCII.GetBytes(string_1), 0, array2, 2, string_1.Length);
				array2[string_1.Length + 2] = (byte)string_2.Length;
				Array.Copy(Encoding.ASCII.GetBytes(string_2), 0, array2, string_1.Length + 3, string_2.Length);
				stream.Write(array2, 0, array2.Length);
				byte[] array3 = new byte[2];
				stream.Read(array3, 0, array3.Length);
				if (array3[1] != 0)
				{
					tcpClient_0.Close();
					throw new GException0("Proxy authentification failure!");
				}
			}
		}

		private byte method_2(string string_3)
		{
			IPAddress address = null;
			if (!IPAddress.TryParse(string_3, out address))
				return 3;
			AddressFamily addressFamily = address.AddressFamily;
			if (addressFamily != AddressFamily.InterNetwork)
			{
				if (addressFamily != AddressFamily.InterNetworkV6)
					throw new GException0(string.Format(CultureInfo.InvariantCulture, "The host addess {0} of type '{1}' is not a supported address type.  The supported types are InterNetwork and InterNetworkV6.", string_3, Enum.GetName(typeof(AddressFamily), address.AddressFamily)));
				return 4;
			}
			return 1;
		}

		private byte[] method_3(byte byte_0, string string_3)
		{
			switch (byte_0)
			{
			default:
				return null;
			case 3:
			{
				byte[] array = new byte[string_3.Length + 1];
				array[0] = Convert.ToByte(string_3.Length);
				Encoding.ASCII.GetBytes(string_3).CopyTo(array, 1);
				return array;
			}
			case 1:
			case 4:
				return IPAddress.Parse(string_3).GetAddressBytes();
			}
		}

		private byte[] method_4(int int_1)
		{
			return new byte[2]
			{
				Convert.ToByte(int_1 / 256),
				Convert.ToByte(int_1 % 256)
			};
		}

		private void method_5(byte byte_0, string string_3, int int_1)
		{
			NetworkStream stream = tcpClient_0.GetStream();
			byte b = method_2(string_3);
			byte[] array = method_3(b, string_3);
			byte[] array2 = method_4(int_1);
			byte[] array3 = new byte[4 + array.Length + 2];
			array3[0] = 5;
			array3[1] = byte_0;
			array3[2] = 0;
			array3[3] = b;
			array.CopyTo(array3, 4);
			array2.CopyTo(array3, 4 + array.Length);
			stream.Write(array3, 0, array3.Length);
			byte[] array4 = new byte[255];
			int num = stream.Read(array4, 0, array4.Length);
			byte b2 = array4[1];
			if (num < 2 || b2 != 0)
				method_6(array4, string_3, int_1);
		}

		private void method_6(byte[] byte_0, string string_3, int int_1)
		{
			byte b = byte_0[1];
			byte b2 = byte_0[3];
			string text = "";
			short num = 0;
			switch (b2)
			{
			case 1:
			{
				byte[] array3 = new byte[4];
				for (int k = 0; k < 4; k++)
				{
					array3[k] = byte_0[k + 4];
				}
				text = new IPAddress(array3).ToString();
				num = BitConverter.ToInt16(new byte[2]
				{
					byte_0[9],
					byte_0[8]
				}, 0);
				break;
			}
			case 3:
			{
				int num2 = Convert.ToInt32(byte_0[4]);
				byte[] array2 = new byte[num2];
				for (int j = 0; j < num2; j++)
				{
					array2[j] = byte_0[j + 5];
				}
				text = Encoding.ASCII.GetString(array2);
				num = BitConverter.ToInt16(new byte[2]
				{
					byte_0[6 + num2],
					byte_0[5 + num2]
				}, 0);
				break;
			}
			case 4:
			{
				byte[] array = new byte[16];
				for (int i = 0; i < 16; i++)
				{
					array[i] = byte_0[i + 4];
				}
				text = new IPAddress(array).ToString();
				num = BitConverter.ToInt16(new byte[2]
				{
					byte_0[21],
					byte_0[20]
				}, 0);
				break;
			}
			}
			string text2;
			switch (b)
			{
			default:
				text2 = string.Format(CultureInfo.InvariantCulture, "that an unknown reply with the code value '{0}' was received by the destination", b.ToString(CultureInfo.InvariantCulture));
				break;
			case 1:
				text2 = "a general socks destination failure occurred";
				break;
			case 2:
				text2 = "the connection is not allowed by proxy destination rule set";
				break;
			case 3:
				text2 = "the network was unreachable";
				break;
			case 4:
				text2 = "the host was unreachable";
				break;
			case 5:
				text2 = "the connection was refused by the remote network";
				break;
			case 6:
				text2 = "the time to live (TTL) has expired";
				break;
			case 7:
				text2 = "the command issued by the proxy client is not supported by the proxy destination";
				break;
			case 8:
				text2 = "the address type specified is not supported";
				break;
			}
			throw new GException0(string.Format(CultureInfo.InvariantCulture, "The {0} concerning destination host {1} port number {2}.  The destination reported the host as {3} port {4}.", text2, string_3, int_1, text, num.ToString(CultureInfo.InvariantCulture)));
		}

		public void method_7()
		{
			if (backgroundWorker_0 != null && !backgroundWorker_0.CancellationPending && backgroundWorker_0.IsBusy)
			{
				bool_0 = true;
				backgroundWorker_0.CancelAsync();
			}
		}

		private void method_8()
		{
			exception_0 = null;
			backgroundWorker_0 = null;
			bool_0 = false;
			backgroundWorker_0 = new BackgroundWorker();
		}

		public void CreateConnectionAsync(string destinationHost, int destinationPort)
		{
			if (backgroundWorker_0 != null && backgroundWorker_0.IsBusy)
				throw new InvalidOperationException("The Socks4 object is already busy executing another asynchronous operation.  You can only execute one asychronous method at a time.");
			method_8();
			backgroundWorker_0.WorkerSupportsCancellation = true;
			backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
			backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
			object[] argument = new object[2] { destinationHost, destinationPort };
			backgroundWorker_0.RunWorkerAsync(argument);
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				object[] array = (object[])e.Argument;
				e.Result = CreateConnection((string)array[0], (int)array[1]);
			}
			catch (Exception ex)
			{
				exception_0 = ex;
			}
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (CreateConnectionAsyncCompleted != null)
                CreateConnectionAsyncCompleted(this, new GEventArgs0(exception_0, bool_0, (TcpClient)e.Result));
		}
	}
}
