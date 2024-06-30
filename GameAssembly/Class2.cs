using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

internal static class Class2
{
	internal static string smethod_0(TcpClient tcpClient_0)
	{
		if (tcpClient_0 == null)
			throw new ArgumentNullException("client");
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

	internal static string smethod_1(TcpClient tcpClient_0)
	{
		if (tcpClient_0 == null)
			throw new ArgumentNullException("client");
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
}
