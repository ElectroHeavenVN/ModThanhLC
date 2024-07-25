using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using HardwareId;

namespace License
{
    internal class DeviceInformation
	{
        public static string GenerateLicense(string DeviceCode)
		{
			string text = DeviceCode + "." + GetCPUInformation() + GetRamInformation() + GetHardwareInformation();
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
					if (physicalAddress.ToString() != string.Empty)
						break;
					num++;
					continue;
				}
				return string.Empty;
			}
			return physicalAddress.ToString();
		}

		public static string GetHardwareInformation()
		{
			return "thanhlc.com" + HWID.getHWID(true, false, true, false);
		}

		public static string GetCPUInformation()
		{
			string result = string.Empty;
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
					result = ((ManagementObject)managementObjectEnumerator.Current).Properties["processorID"].Value.ToString();
			}
			return result;
		}

		public static string GetRamInformation()
		{
			string text = string.Empty;
			foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get())
			{
				object obj = item["PartNumber"];
				object obj2 = item["SerialNumber"];
				object obj3 = item["Capacity"];
				text = text + (string.IsNullOrEmpty(text) ? "" : " ~~ ") + ((obj == null) ? string.Empty : obj.ToString().Trim()) + " - " + ((obj2 == null) ? string.Empty : obj2.ToString().Trim()) + " - " + ((obj3 == null) ? string.Empty : obj3.ToString().Trim());
			}
			return text;
		}

		public static string GetIpv4()
		{
			return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
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
