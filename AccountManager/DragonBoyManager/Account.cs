using System.Diagnostics;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace DragonBoyManager
{
	public class Account
	{
		public string ScreenLevel;

		[JsonIgnore]
		public Socket workSocket = null;

		[JsonIgnore]
		public Process process;

		[JsonIgnore]
		public string _status = "";

		[JsonProperty("isLogin")]
		public bool isLogin { get; set; }

		public int ID { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string Server { get; set; }

		public string Note { get; set; }

		public bool isUseProxy { get; set; }

		public string ProxyInfo { get; set; }

		public string SizeScreen { get; set; }

		[JsonIgnore]
		public string status
		{
			get
			{
				return _status;
			}
			set
			{
				setStatus(value);
			}
		}

		public void setStatus(string status)
		{
			_status = status;
		}
	}
}
