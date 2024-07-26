using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace AssemblyCSharp.Functions.Proxy
{
	internal static class Class3
	{
		internal static string smethod_0(TcpClient tcpClient_0)
		{
			if (tcpClient_0 != null)
			{
				string result = "";
				try
				{
					result = ((IPEndPoint)tcpClient_0.Client.RemoteEndPoint).Address.ToString();
				}
				catch
				{
				}
				return result;
			}
			throw new ArgumentNullException("client");
		}

		internal static string smethod_1(TcpClient tcpClient_0)
		{
			if (tcpClient_0 != null)
			{
				string result = "";
				try
				{
					result = ((IPEndPoint)tcpClient_0.Client.RemoteEndPoint).Port.ToString(CultureInfo.InvariantCulture);
				}
				catch
				{
				}
				return result;
			}
			throw new ArgumentNullException("client");
		}
	}
}
