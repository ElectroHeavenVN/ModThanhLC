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

		[JsonProperty(nameof(ID))]
		public int ID { get; set; }

        [JsonProperty(nameof(Username))]
        public string Username { get; set; }

        [JsonProperty(nameof(Password))]
        public string Password { get; set; }

        [JsonProperty(nameof(Server))]
        public string Server { get; set; }

        [JsonProperty(nameof(Note))]
        public string Note { get; set; }

        [JsonProperty(nameof(isUseProxy))]
        public bool isUseProxy { get; set; }

        [JsonProperty(nameof(ProxyInfo))]
        public string ProxyInfo { get; set; }

        [JsonProperty(nameof(SizeScreen))]
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
