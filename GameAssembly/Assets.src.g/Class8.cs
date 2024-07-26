using System;

namespace Assets.src.g
{
	internal class Class8
	{
		public sbyte sbyte_0;

		public string string_0;

		public static GClass88 gclass88_0 = new GClass88();

		public static GClass88 gclass88_1 = new GClass88();

		public Class8(string string_1, sbyte sbyte_1)
		{
			string_0 = string_1;
			sbyte_0 = sbyte_1;
		}

		public static void smethod_0()
		{
			GClass88 vID = new GClass88();
			sbyte[] array = GClass1.smethod_1("ImageSource");
			if (array != null)
			{
				gclass88_1 = new GClass88();
				GClass108 gClass = new GClass108(array);
				if (gClass == null)
					return;
				try
				{
					short num = gClass.method_0();
					string[] array2 = new string[num];
					sbyte[] array3 = new sbyte[num];
					for (int i = 0; i < num; i++)
					{
						array2[i] = gClass.method_6();
						array3[i] = gClass.method_7();
						gclass88_1.method_0(new Class8(array2[i], array3[i]));
					}
					gClass.method_4();
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
				}
				GClass50.smethod_8("vS size= " + gclass88_0.method_2() + " vRMS size= " + gclass88_1.method_2());
				GClass7.smethod_0().method_136(vID);
			}
			else
				GClass7.smethod_0().method_136(vID);
		}

		public static sbyte smethod_1(string string_1)
		{
			int num = 0;
			while (true)
			{
				if (num < gclass88_1.method_2())
				{
					if (string_1.Equals(((Class8)gclass88_1.method_3(num)).string_0))
						break;
					num++;
					continue;
				}
				return -1;
			}
			return ((Class8)gclass88_1.method_3(num)).sbyte_0;
		}

		public static sbyte smethod_2(string string_1)
		{
			for (int i = 0; i < gclass88_0.method_2(); i++)
			{
				if (string_1.Equals(((Class8)gclass88_0.method_3(i)).string_0))
					return ((Class8)gclass88_0.method_3(i)).sbyte_0;
			}
			return -1;
		}

		public static bool smethod_3(string string_1)
		{
			for (int i = 0; i < gclass88_1.method_2(); i++)
			{
				if (string_1.Equals(((Class8)gclass88_1.method_3(i)).string_0))
					return true;
			}
			return false;
		}

		public static void smethod_4()
		{
			GClass46 gClass = new GClass46();
			try
			{
				gClass.method_0((short)gclass88_0.method_2());
				for (int i = 0; i < gclass88_0.method_2(); i++)
				{
					gClass.method_6(((Class8)gclass88_0.method_3(i)).string_0);
					gClass.method_5(((Class8)gclass88_0.method_3(i)).sbyte_0);
				}
				GClass1.smethod_0("ImageSource", gClass.method_3());
				gClass.method_4();
			}
			catch (Exception ex)
			{
				ex.StackTrace.ToString();
			}
		}
	}
}
