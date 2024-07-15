namespace ns0
{
	public class GClass164 : GClass160, GInterface1
	{
		public static GClass164 gclass164_0;

		public GClass136[] gclass136_0;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private string[] string_0;

		private int int_10;

		private int int_11;

		private void method_0(string string_1)
		{
			int_8 = GClass14.int_10 - 20;
			if (int_8 > 320)
				int_8 = 320;
			GClass191.smethod_8("title= " + string_1);
			string_0 = GClass104.gclass104_6.method_15(string_1, int_8 - 20);
			int_6 = (GClass14.int_10 - int_8) / 2;
			gclass136_0 = new GClass136[int_11];
			int_9 = gclass136_0.Length * 35 + (string_0.Length - 1) * 20 + 40;
			int_7 = GClass14.int_11 - int_9 - 40 - (string_0.Length - 1) * 20;
			for (int i = 0; i < gclass136_0.Length; i++)
			{
				gclass136_0[i] = new GClass136();
				gclass136_0[i].string_7 = string.Empty;
				gclass136_0[i].int_0 = int_6 + 10;
				gclass136_0[i].int_1 = int_7 + 35 + (string_0.Length - 1) * 20 + i * 35;
				gclass136_0[i].int_2 = int_8 - 20;
				gclass136_0[i].int_3 = GClass160.int_0 + 2;
				if (GClass14.bool_5)
					gclass136_0[0].bool_0 = false;
				else
					gclass136_0[0].bool_0 = true;
				if (!GClass14.bool_5)
					gclass118_2 = gclass136_0[0].gclass118_0;
			}
			gclass118_0 = new GClass118(mResources.CLOSE, this, 1, null);
			gclass118_1 = new GClass118(mResources.OK, this, 2, null);
			if (GClass14.bool_5)
			{
				gclass118_1.int_1 = GClass14.int_10 / 2 + 18;
				gclass118_0.int_1 = GClass14.int_10 / 2 - 85;
				gclass118_1.int_2 = (gclass118_0.int_2 = int_7 + int_9 + 5);
			}
		}

		public static GClass164 smethod_2()
		{
			if (gclass164_0 == null)
				gclass164_0 = new GClass164();
			return gclass164_0;
		}

		public override void switchToMe()
		{
			int_10 = 0;
			base.switchToMe();
		}

		public void method_1(int type, string title)
		{
			int_11 = type;
			method_0(title);
			switchToMe();
		}

		public override void paint(GClass193 g)
		{
			GClass167.smethod_8().paint(g);
			GClass139.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass104.gclass104_7.method_6(g, string_0[i], GClass14.int_10 / 2, int_7 + 15 + i * 20, GClass104.int_2);
			}
			for (int j = 0; j < gclass136_0.Length; j++)
			{
				gclass136_0[j].method_13(g);
			}
			base.paint(g);
		}

		public override void update()
		{
			GClass167.smethod_8().update();
			for (int i = 0; i < gclass136_0.Length; i++)
			{
				gclass136_0[i].method_17();
			}
		}

		public override void keyPress(int keyCode)
		{
			for (int i = 0; i < gclass136_0.Length; i++)
			{
				if (gclass136_0[i].bool_0)
				{
					gclass136_0[i].method_10(keyCode);
					break;
				}
			}
			base.keyPress(keyCode);
		}

		public override void updateKey()
		{
			if (!GClass14.bool_11[2])
			{
				if (GClass14.bool_11[8])
				{
					int_10++;
					if (int_10 > gclass136_0.Length - 1)
						int_10 = 0;
				}
			}
			else
			{
				int_10--;
				if (int_10 < 0)
					int_10 = gclass136_0.Length - 1;
			}
			if (GClass14.bool_11[2] || GClass14.bool_11[8])
			{
				GClass14.smethod_26();
				for (int i = 0; i < gclass136_0.Length; i++)
				{
					if (int_10 != i)
						gclass136_0[i].bool_0 = false;
					else
					{
						gclass136_0[i].bool_0 = true;
						if (!GClass14.bool_5)
							gclass118_2 = gclass136_0[i].gclass118_0;
					}
					if (GClass14.bool_16 && GClass14.smethod_24(gclass136_0[i].int_0, gclass136_0[i].int_1, gclass136_0[i].int_2, gclass136_0[i].int_3))
					{
						int_10 = i;
						break;
					}
				}
			}
			base.updateKey();
			GClass14.smethod_26();
		}

		public void method_2()
		{
			gclass164_0 = null;
		}

		public void perform(int idAction, object p)
		{
			if (idAction == 1)
			{
				GClass167.gclass167_0.switchToMe();
				method_2();
			}
			if (idAction != 2)
				return;
			for (int i = 0; i < gclass136_0.Length; i++)
			{
				if (gclass136_0[i].method_21() == null || gclass136_0[i].method_21().Equals(string.Empty))
				{
					GClass14.smethod_30(mResources.vuilongnhapduthongtin);
					return;
				}
			}
			GClass2.smethod_0().method_7(gclass136_0);
			GClass167.gclass167_0.switchToMe();
		}
	}
}
