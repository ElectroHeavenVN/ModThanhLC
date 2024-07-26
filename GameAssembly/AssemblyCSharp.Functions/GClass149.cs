using System.IO;

namespace AssemblyCSharp.Functions
{
	public class GClass149
	{
		public static void smethod_0(string path, string message)
		{
			if (!File.Exists(path))
				File.WriteAllText(path, message);
			else if (!(File.ReadAllText(path) == message))
			{
				File.WriteAllText(path, message);
			}
		}

		public static void smethod_1(string message, int type)
		{
			if (type != 0)
			{
				if (type == 1)
					GClass73.smethod_30(message);
			}
			else
				GClass144.gclass52_0.method_7("[ThanhLc]: " + message, 0);
		}
	}
}
