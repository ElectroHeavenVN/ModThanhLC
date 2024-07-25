using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ns1;
using UnityEngine;

public class GClass179 : GInterface2
{
	private class Class21
	{
		public void method_0()
		{
			try
			{
				while (bool_1)
				{
					GClass100 gClass = method_3();
					if (gClass == null)
						break;
					try
					{
						if (gClass.sbyte_0 == -27)
							method_1(gClass);
						else
							smethod_4(gClass);
					}
					catch (Exception)
					{
						GClass92.smethod_0("LOI NHAN  MESS THU 1");
					}
					try
					{
						Thread.Sleep(5);
					}
					catch (Exception)
					{
						GClass92.smethod_0("LOI NHAN  MESS THU 2");
					}
				}
			}
			catch (Exception ex3)
			{
				Debug.Log("error read message!");
				Debug.Log(ex3.Message.ToString());
			}
			if (!bool_1)
				return;
			if (ginterface4_0 != null)
			{
				if (smethod_7() - int_2 <= 500)
					ginterface4_0.onConnectionFail(bool_0);
				else
					ginterface4_0.onDisconnected(bool_0);
			}
			if (tcpClient_0 != null)
				smethod_6();
		}

		private void method_1(GClass100 gclass100_0)
		{
			try
			{
				sbyte b = gclass100_0.method_1().method_0();
				sbyte_0 = new sbyte[b];
				for (int i = 0; i < b; i++)
				{
					sbyte_0[i] = gclass100_0.method_1().method_0();
				}
				for (int j = 0; j < sbyte_0.Length - 1; j++)
				{
					sbyte_0[j + 1] ^= sbyte_0[j];
				}
				bool_3 = true;
				GClass206.string_1 = gclass100_0.method_1().method_14();
				GClass206.int_1 = gclass100_0.method_1().method_8();
				GClass206.bool_0 = ((gclass100_0.method_1().method_2() != 0) ? true : false);
				if (bool_0 && GClass206.bool_0)
					GClass14.smethod_5();
			}
			catch (Exception)
			{
			}
		}

		private GClass100 method_2(sbyte sbyte_0)
		{
			int num = smethod_2(binaryReader_0.ReadSByte()) + 128;
			int num2 = smethod_2(binaryReader_0.ReadSByte()) + 128;
			int num3 = ((smethod_2(binaryReader_0.ReadSByte()) + 128) * 256 + num2) * 256 + num;
			sbyte[] array = new sbyte[num3];
			Buffer.BlockCopy(binaryReader_0.ReadBytes(num3), 0, array, 0, num3);
			int_1 += 5 + num3;
			int num4 = int_1 + int_0;
			string_0 = num4 / 1024 + "." + num4 % 1024 / 102 + "Kb";
			if (bool_3)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = smethod_2(array[i]);
				}
			}
			return new GClass100(sbyte_0, array);
		}

		private GClass100 method_3()
		{
			try
			{
				sbyte b = binaryReader_0.ReadSByte();
				if (bool_3)
					b = smethod_2(b);
				if (b == -32 || b == -66 || b == 11 || b == -67 || b == -74 || b == -87 || b == 66)
					return method_2(b);
				int num;
				if (!bool_3)
					num = (binaryReader_0.ReadSByte() & 0xFF00) | (binaryReader_0.ReadSByte() & 0xFF);
				else
				{
					sbyte b2 = binaryReader_0.ReadSByte();
					sbyte b3 = binaryReader_0.ReadSByte();
					num = ((smethod_2(b2) & 0xFF) << 8) | (smethod_2(b3) & 0xFF);
				}
				sbyte[] array = new sbyte[num];
				Buffer.BlockCopy(binaryReader_0.ReadBytes(num), 0, array, 0, num);
				int_1 += 5 + num;
				int num2 = int_1 + int_0;
				string_0 = num2 / 1024 + "." + num2 % 1024 / 102 + "Kb";
				if (bool_3)
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = smethod_2(array[i]);
					}
				}
				return new GClass100(b, array);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.StackTrace.ToString());
			}
			return null;
		}
	}

	public class GClass180
	{
		public List<GClass100> list_0;

		public GClass180()
		{
			list_0 = new List<GClass100>();
		}

		public void method_0(GClass100 message)
		{
			list_0.Add(message);
		}

		public void method_1()
		{
			while (bool_1)
			{
				try
				{
					if (bool_3)
					{
						while (list_0.Count > 0)
						{
							smethod_1(list_0[0]);
							list_0.RemoveAt(0);
						}
					}
					try
					{
						Thread.Sleep(5);
					}
					catch (Exception ex)
					{
						GClass92.smethod_2(ex.ToString());
					}
				}
				catch (Exception)
				{
					GClass191.smethod_8("error send message! ");
				}
			}
		}
	}

	protected static GClass179 gclass179_0 = new GClass179();

	private static NetworkStream networkStream_0;

	private static BinaryReader binaryReader_0;

	private static BinaryWriter binaryWriter_0;

	public static GInterface4 ginterface4_0;

	public static bool bool_0 = true;

	private static TcpClient tcpClient_0;

	public static bool bool_1;

	public static bool bool_2;

	private static GClass180 gclass180_0 = new GClass180();

	public static Thread thread_0;

	public static Thread thread_1;

	public static Thread thread_2;

	public static int int_0;

	public static int int_1;

	private static bool bool_3;

	public static sbyte[] sbyte_0 = null;

	private static sbyte sbyte_1;

	private static sbyte sbyte_2;

	private static int int_2;

	private long long_0;

	public static string string_0 = string.Empty;

	public static bool bool_4;

	private string string_1;

	private int int_3;

	private long long_1;

	public static int int_4;

	public static GClass122 gclass122_0 = new GClass122();

	public GClass179()
	{
		Debug.Log("init Session_ME");
	}

	public void method_0()
	{
		gclass180_0.list_0.Clear();
	}

	public static GClass179 smethod_0()
	{
		if (gclass179_0 == null)
			gclass179_0 = new GClass179();
		return gclass179_0;
	}

	public bool isConnected()
	{
		return bool_1 && tcpClient_0 != null && binaryReader_0 != null;
	}

	public void setHandler(GInterface4 msgHandler)
	{
		ginterface4_0 = msgHandler;
	}

	public void connect(string host, int port)
	{
		if (!bool_1 && !bool_2 && GClass77.smethod_18() >= long_1)
		{
			long_1 = GClass77.smethod_18() + 50L;
			if (bool_0)
				GClass170.int_22 = -1;
			string_1 = host;
			int_3 = port;
			bool_3 = false;
			close();
			Debug.Log("connecting...!");
			Debug.Log("host: " + host);
			Debug.Log("port: " + port);
			thread_0 = new Thread(method_1);
			thread_0.Start();
		}
	}

	private void method_1()
	{
		bool_4 = false;
		bool_2 = true;
		Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
		bool_1 = true;
		try
		{
			method_2(string_1, int_3);
			ginterface4_0.onConnectOK(bool_0);
		}
		catch (Exception)
		{
			if (ginterface4_0 != null)
			{
				close();
				ginterface4_0.onConnectionFail(bool_0);
			}
		}
	}

	public void method_2(string host, int port)
	{
		if (GClass50.smethod_0().bool_1 && GClass62.bool_1)
		{
			tcpClient_0 = GClass39.smethod_0(host, port, GClass50.string_8, GClass50.smethod_0().int_1, GClass50.string_6, GClass50.string_7);
			networkStream_0 = tcpClient_0.GetStream();
			binaryReader_0 = new BinaryReader(networkStream_0, new UTF8Encoding());
			binaryWriter_0 = new BinaryWriter(networkStream_0, new UTF8Encoding());
			thread_2 = new Thread(gclass180_0.method_1);
			thread_2.Start();
			Class21 @object = new Class21();
			GClass92.smethod_2("new -----");
			thread_1 = new Thread(@object.method_0);
			thread_1.Start();
			int_2 = smethod_7();
			bool_2 = false;
			smethod_1(new GClass100(-27));
		}
		else if (!GClass50.smethod_0().bool_1)
		{
			tcpClient_0 = new TcpClient();
			tcpClient_0.Connect(host, port);
			networkStream_0 = tcpClient_0.GetStream();
			binaryReader_0 = new BinaryReader(networkStream_0, new UTF8Encoding());
			binaryWriter_0 = new BinaryWriter(networkStream_0, new UTF8Encoding());
			thread_2 = new Thread(gclass180_0.method_1);
			thread_2.Start();
			Class21 object2 = new Class21();
			GClass92.smethod_2("new -----");
			thread_1 = new Thread(object2.method_0);
			thread_1.Start();
			int_2 = smethod_7();
			bool_2 = false;
			smethod_1(new GClass100(-27));
		}
	}

	public void sendMessage(GClass100 message)
	{
		int_4++;
		GClass191.smethod_8("SEND MSG: " + message.sbyte_0);
		gclass180_0.method_0(message);
	}

	private static void smethod_1(GClass100 gclass100_0)
	{
		sbyte[] array = gclass100_0.method_0();
		try
		{
			if (!bool_3)
				binaryWriter_0.Write(gclass100_0.sbyte_0);
			else
			{
				sbyte value = smethod_3(gclass100_0.sbyte_0);
				binaryWriter_0.Write(value);
			}
			if (array == null)
			{
				if (!bool_3)
					binaryWriter_0.Write((ushort)0);
				else
				{
					int num = smethod_3(0);
					binaryWriter_0.Write((sbyte)num);
					int num2 = smethod_3(0);
					binaryWriter_0.Write((sbyte)num2);
				}
				int_0 += 5;
			}
			else
			{
				int num3 = array.Length;
				if (bool_3)
				{
					int num4 = smethod_3((sbyte)(num3 >> 8));
					binaryWriter_0.Write((sbyte)num4);
					int num5 = smethod_3((sbyte)(num3 & 0xFF));
					binaryWriter_0.Write((sbyte)num5);
				}
				else
					binaryWriter_0.Write((ushort)num3);
				if (bool_3)
				{
					for (int i = 0; i < array.Length; i++)
					{
						sbyte value2 = smethod_3(array[i]);
						binaryWriter_0.Write(value2);
					}
				}
				int_0 += 5 + array.Length;
			}
			binaryWriter_0.Flush();
		}
		catch (Exception ex)
		{
			Debug.Log(ex.StackTrace);
			binaryWriter_0.Flush();
		}
	}

	public static sbyte smethod_2(sbyte b)
	{
		sbyte result = (sbyte)((sbyte_0[sbyte_1++] & 0xFF) ^ (b & 0xFF));
		if (sbyte_1 >= sbyte_0.Length)
			sbyte_1 %= (sbyte)sbyte_0.Length;
		return result;
	}

	public static sbyte smethod_3(sbyte b)
	{
		sbyte result = (sbyte)((sbyte_0[sbyte_2++] & 0xFF) ^ (b & 0xFF));
		if (sbyte_2 >= sbyte_0.Length)
			sbyte_2 %= (sbyte)sbyte_0.Length;
		return result;
	}

	public static void smethod_4(GClass100 msg)
	{
		if (!(Thread.CurrentThread.Name == Main.mainThreadName))
			gclass122_0.method_0(msg);
		else
			ginterface4_0.onMessage(msg);
	}

	public static void smethod_5()
	{
		while (gclass122_0.method_2() > 0)
		{
			GClass100 gClass = (GClass100)gclass122_0.method_3(0);
			if (!GClass93.bool_5)
			{
				if (gClass != null)
				{
					ginterface4_0.onMessage(gClass);
					gclass122_0.method_7(0);
					continue;
				}
				gclass122_0.method_7(0);
				break;
			}
			break;
		}
	}

	public void close()
	{
		smethod_6();
	}

	private static void smethod_6()
	{
		sbyte_0 = null;
		sbyte_1 = 0;
		sbyte_2 = 0;
		try
		{
			bool_1 = false;
			bool_2 = false;
			if (tcpClient_0 != null)
			{
				tcpClient_0.Close();
				tcpClient_0 = null;
			}
			if (networkStream_0 != null)
			{
				networkStream_0.Close();
				networkStream_0 = null;
			}
			if (binaryWriter_0 != null)
			{
				binaryWriter_0.Close();
				binaryWriter_0 = null;
			}
			if (binaryReader_0 != null)
			{
				binaryReader_0.Close();
				binaryReader_0 = null;
			}
			if (Thread.CurrentThread.Name == Main.mainThreadName)
			{
				if (thread_2 != null)
					thread_2.Abort();
				thread_2 = null;
				if (thread_0 != null)
					thread_0.Abort();
				thread_0 = null;
				if (thread_1 != null)
					thread_1.Abort();
				thread_1 = null;
			}
			else
			{
				thread_2 = null;
				thread_0 = null;
				thread_1 = null;
			}
			if (bool_0)
				GClass170.int_22 = 0;
		}
		catch (Exception)
		{
		}
	}

	public static int smethod_7()
	{
		return Environment.TickCount;
	}

	public static byte smethod_8(sbyte var)
	{
		if (var <= 0)
			return (byte)(var + 256);
		return (byte)var;
	}

	public static byte[] smethod_9(sbyte[] var)
	{
		byte[] array = new byte[var.Length];
		for (int i = 0; i < var.Length; i++)
		{
			if (var[i] <= 0)
				array[i] = (byte)(var[i] + 256);
			else
				array[i] = (byte)var[i];
		}
		return array;
	}

	public bool method_3()
	{
		return true;
	}
}
