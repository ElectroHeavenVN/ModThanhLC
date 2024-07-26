namespace AssemblyCSharp.Functions
{
	public class GClass163
	{
		private static GClass163 gclass163_0;

		public bool bool_0;

		public int int_0;

		public long long_0;

		public bool bool_1;

		public int int_1;

		public long long_1;

		public bool bool_2;

		public bool bool_3;

		public int int_2;

		public long long_2;

		public bool bool_4;

		public int int_3;

		public long long_3;

		public bool bool_5;

		public int int_4;

		public long long_4;

		public bool bool_6;

		public int int_5;

		public long long_5;

		public bool bool_7;

		public int int_6;

		public long long_6;

		public bool bool_8;

		public bool bool_9;

		public int int_7;

		public long long_7;

		public bool bool_10;

		public int int_8;

		public long long_8;

		public bool bool_11;

		public int int_9;

		public long long_9;

		public bool bool_12;

		public int int_10;

		public long long_10;

		public static GClass163 smethod_0()
		{
			if (gclass163_0 == null)
				gclass163_0 = new GClass163();
			return gclass163_0;
		}

		public void method_0()
		{
			if (int_0 > 0 && GClass203.smethod_18() - long_0 >= 1000L)
			{
				int_0--;
				long_0 = GClass203.smethod_18();
			}
			if (int_1 > 0 && GClass203.smethod_18() - long_1 >= 1000L)
			{
				int_1--;
				if (int_1 == 0)
					bool_2 = false;
				long_1 = GClass203.smethod_18();
			}
			if (int_2 > 0 && GClass203.smethod_18() - long_2 >= 1000L)
			{
				int_2--;
				long_2 = GClass203.smethod_18();
			}
			if (int_3 > 0 && GClass203.smethod_18() - long_3 >= 1000L)
			{
				int_3--;
				long_3 = GClass203.smethod_18();
			}
			if (int_4 > 0 && GClass203.smethod_18() - long_4 >= 1000L)
			{
				int_4--;
				long_4 = GClass203.smethod_18();
			}
			if (int_5 > 0 && GClass203.smethod_18() - long_5 >= 1000L)
			{
				int_5--;
				long_5 = GClass203.smethod_18();
			}
			if (int_6 > 0 && GClass203.smethod_18() - long_6 >= 1000L)
			{
				int_6--;
				if (int_6 == 0)
					bool_8 = false;
				long_6 = GClass203.smethod_18();
			}
			if (int_7 > 0 && GClass203.smethod_18() - long_7 >= 1000L)
			{
				int_7--;
				long_7 = GClass203.smethod_18();
			}
			if (int_8 > 0 && GClass203.smethod_18() - long_8 >= 1000L)
			{
				int_8--;
				long_8 = GClass203.smethod_18();
			}
			if (int_9 > 0 && GClass203.smethod_18() - long_9 >= 1000L)
			{
				int_9--;
				long_9 = GClass203.smethod_18();
			}
			if (int_10 > 0 && GClass203.smethod_18() - long_10 >= 1000L)
			{
				int_10--;
				long_10 = GClass203.smethod_18();
			}
			if (int_3 <= 0)
				bool_4 = false;
		}

		public bool method_1()
		{
			return int_5 + int_6 + int_0 + int_3 + int_7 + int_2 + int_4 + int_1 + int_8 + int_9 + int_10 > 0;
		}
	}
}
