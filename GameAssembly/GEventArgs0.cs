using System;
using System.ComponentModel;
using System.Net.Sockets;

public class GEventArgs0 : AsyncCompletedEventArgs
{
	private TcpClient tcpClient_0;

	public TcpClient TcpClient_0 => tcpClient_0;

	public GEventArgs0(Exception error, bool cancelled, TcpClient proxyConnection)
		: base(error, cancelled, null)
	{
		tcpClient_0 = proxyConnection;
	}
}
