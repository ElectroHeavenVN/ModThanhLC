using System.Net.Sockets;

namespace DragonBoyManager
{
	public class StateObject
	{
		public const int BufferSize = 4096;

		public byte[] buffer = new byte[4096];

		public Socket workSocket = null;

		public Account account = null;
	}
}
