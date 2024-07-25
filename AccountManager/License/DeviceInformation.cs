using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using HardwareId;

namespace License
{
    internal class DeviceInformation
	{
        public static string GetRealName(string username)
        {
            string text = HashGenerator.GenerateMD5(username);
            //A convoluted switch statement that returns the hardcoded real name of the user based on the hash of the username.
            //To protect the privacy of the users, the original switch statement has been replaced with a simple switch statement.
            switch (text)
            {
                default:
					//return "ElectroHeavenVN";
					return "9u8Gs0XHgFztuKKRSZfq0Vzt8RaPkpngI/yoyvh77Z0VLJxGetsgmtjLGH15E+sXXqI8a6omMEOIMPNSnoldgGefUm4jdwBcacb7CQEh6ofHRgyBWvwiRhIVod6OQ59l";	//encrypted with MD5 hash of "admin"
            }
            return "";
        }

        public static string GenerateLicense(string deviceCode)
		{
			string text = deviceCode + "." + GetCPUInformation() + GetRamInformation() + GetHardwareInformation();
			if (IsWindowServer())
				text = text + GetMacAddress() + GetIpv4();
			return HashGenerator.GenerateMD5(text);
		}

		public static string GetMacAddress()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			int num = 0;
			PhysicalAddress physicalAddress;
			while (true)
			{
				if (num < allNetworkInterfaces.Length)
				{
					physicalAddress = allNetworkInterfaces[num].GetPhysicalAddress();
					if (physicalAddress.ToString() != "")
						break;
					num++;
					continue;
				}
				return "";
			}
			return physicalAddress.ToString();
		}

		public static string GetHardwareInformation()
		{
			return "thanhlc.com" + HWID.getHWID(true, false, true, false);
		}

		public static string GetCPUInformation()
		{
			string result = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
					result = ((ManagementObject)managementObjectEnumerator.Current).Properties["processorID"].Value.ToString();
			}
			return result;
		}

		public static string GetRamInformation()
		{
			string text = "";
			foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get())
			{
				object obj = item["PartNumber"];
				object obj2 = item["SerialNumber"];
				object obj3 = item["Capacity"];
				text += (string.IsNullOrEmpty(text) ? "" : " ~~ ") + ((obj == null) ? "" : obj.ToString().Trim()) + " - " + ((obj2 == null) ? "" : obj2.ToString().Trim()) + " - " + ((obj3 == null) ? "" : obj3.ToString().Trim());
			}
			return text;
		}

		public static string GetIpv4()
		{
			return Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString();
		}

		public static bool IsWindowServer()
		{
			foreach (ManagementObject item in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get())
			{
				if (item["Caption"].ToString().ToLower().Contains("windows server"))
					return true;
			}
			return false;
		}

		public static string GetDeviceID()
		{
			return HashGenerator.GenerateMD5("ThanhTvPro" + HWID.getHWID(true, false, true, false));
		}

        public static string GetUniqueIdentifier()
        {
            return GetCPUInformation() + "|" + GetRamInformation() + "|" + GetHardwareInformation() + (IsWindowServer() ? GetIpv4() : "");
        }
    }
}
