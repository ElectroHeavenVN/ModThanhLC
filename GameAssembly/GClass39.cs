using System;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class GClass39
{
	public static TcpClient smethod_0(string targetHost, int targetPort, string httpProxyHost, int httpProxyPort, string proxyUserName, string proxyPassword)
	{
		try
		{
			Uri uri = new UriBuilder
			{
				Scheme = Uri.UriSchemeHttp,
				Host = httpProxyHost,
				Port = httpProxyPort
			}.Uri;
			Uri uri2 = new UriBuilder
			{
				Scheme = Uri.UriSchemeHttp,
				Host = targetHost,
				Port = targetPort
			}.Uri;
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(uri.Host, uri.Port);
			socket.Send(Encoding.UTF8.GetBytes(string.Format("CONNECT {0}:{1} HTTP/1.1{2}Proxy-Authorization: Basic {3}{4}{5}", uri2.Host, uri2.Port, Environment.NewLine, Convert.ToBase64String(Encoding.UTF8.GetBytes(proxyUserName + ":" + proxyPassword)), Environment.NewLine, Environment.NewLine)));
			byte[] array = new byte[1024];
			int count = socket.Receive(array);
			Encoding.ASCII.GetString(array, 0, count);
			return new TcpClient
			{
				Client = socket
			};
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			return new TcpClient(targetHost, targetPort);
		}
	}
}
