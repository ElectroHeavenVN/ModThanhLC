namespace ns0
{
	public class GClass25
	{
		public short short_0;

		public GClass209 gclass209_0 = new GClass209();

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;

		public int int_12;

		public int int_13 = -1;

		public int int_14;

		public int int_15;

		private int[] int_16 = new int[4] { 0, 1, 2, 1 };

		private int int_17;

		public GClass25()
		{
			int_1 = GClass191.smethod_19(0, 3);
		}

		public void method_0(int fimg, int[] frameNew, int wimg, int himg)
		{
			if (fimg >= 1)
			{
				int_13 = fimg;
				int_16 = frameNew;
				int_14 = wimg;
				int_15 = himg;
			}
		}

		public void method_1(GClass193 g)
		{
			int w = 32;
			int h = 32;
			int num = ((GClass14.int_8 % 10 > 5) ? 1 : 0);
			if (int_13 > 0)
			{
				w = int_14;
				h = int_15;
				num = 0;
			}
			GClass72.smethod_7(g, short_0, int_1, int_9, int_4 + 3 + num, w, h, (int_0 != 1) ? 2 : 0, GClass73.int_6);
		}

		public void method_2()
		{
			method_4();
			if (GClass14.int_8 % 3 == 0)
			{
				int_1 = int_16[int_17];
				int_17++;
			}
			if (int_17 >= int_16.Length)
				int_17 = 0;
		}

		public void method_3()
		{
			GClass91.smethod_0(60, int_9, int_4 + 3 + ((GClass14.int_8 % 10 > 5) ? 1 : 0), 1);
		}

		public void method_4()
		{
			if (int_4 != int_3)
			{
				int_6 = int_3 - int_4 << 2;
				int_5 += int_6;
				int_4 += int_5 >> 4;
				int_5 &= 15;
			}
			if (int_9 != int_8)
			{
				int_11 = int_8 - int_9 << 2;
				int_10 += int_11;
				int_9 += int_10 >> 4;
				int_10 &= 15;
			}
		}
	}
}
