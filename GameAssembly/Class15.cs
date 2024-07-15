using System;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using HardwareId;

internal class Class15
{
	public static string smethod_0(object object_0)
	{
		string text = (string)object_0 + "." + smethod_3() + smethod_4() + smethod_2();
		if (smethod_6())
			text = text + smethod_1() + smethod_5();
		return Class14.smethod_0(text);
	}

	public static string smethod_1()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		for (int i = 0; i < allNetworkInterfaces.Length; i++)
		{
			PhysicalAddress physicalAddress = allNetworkInterfaces[i].GetPhysicalAddress();
			if (physicalAddress.ToString() != string.Empty)
				return physicalAddress.ToString();
		}
		return string.Empty;
	}

	public static string smethod_2()
	{
		return "thanhlc.com" + HWID.getHWID(true, false, true, false);
	}

	public static string smethod_3()
	{
		string result = string.Empty;
		using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
		{
			if (managementObjectEnumerator.MoveNext())
				result = ((ManagementObject)managementObjectEnumerator.Current).Properties["processorID"].Value.ToString();
		}
		return result;
	}

	public static string smethod_4()
	{
		string text = string.Empty;
		foreach (ManagementObject item in new ManagementObjectSearcher("select * from Win32_PhysicalMemory").Get())
		{
			object obj = item["PartNumber"];
			object obj2 = item["SerialNumber"];
			object obj3 = item["Capacity"];
			text = text + ((!string.IsNullOrEmpty(text)) ? " ~~ " : "") + ((obj == null) ? string.Empty : obj.ToString().Trim()) + " - " + ((obj2 != null) ? obj2.ToString().Trim() : string.Empty) + " - " + ((obj3 != null) ? obj3.ToString().Trim() : string.Empty);
		}
		return text;
	}

	public static string smethod_5()
	{
		return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
	}

	public static bool smethod_6()
	{
		foreach (ManagementObject item in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get())
		{
			if (item["Caption"].ToString().ToLower().Contains("windows server"))
				return true;
		}
		return false;
	}
}
