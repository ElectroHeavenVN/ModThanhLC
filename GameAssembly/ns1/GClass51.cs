using System.IO;

namespace ns1
{
	public class GClass51
	{
		public static void smethod_0(string path, string message)
		{
			if (File.Exists(path))
			{
				if (!(File.ReadAllText(path) == message))
					File.WriteAllText(path, message);
			}
			else
				File.WriteAllText(path, message);
		}

		public static void smethod_1(string message, int type)
		{
			if (type != 0)
			{
				if (type == 1)
					GClass14.smethod_30(message);
			}
			else
				GClass167.gclass130_0.method_7("[ThanhLc]: " + message, 0);
		}
	}
}
