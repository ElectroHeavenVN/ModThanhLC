namespace Assets.src.g
{
	public class GClass138 : GClass131, GInterface6
	{
		public static GClass138 gclass138_0;

		public GClass191[] gclass191_0;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private string[] string_0;

		private int int_10;

		private int int_11;

		private void method_0(string string_1)
		{
			int_8 = GClass73.int_10 - 20;
			if (int_8 > 320)
				int_8 = 320;
			GClass50.smethod_8("title= " + string_1);
			string_0 = GClass4.gclass4_6.method_15(string_1, int_8 - 20);
			int_6 = (GClass73.int_10 - int_8) / 2;
			gclass191_0 = new GClass191[int_11];
			int_9 = gclass191_0.Length * 35 + (string_0.Length - 1) * 20 + 40;
			int_7 = GClass73.int_11 - int_9 - 40 - (string_0.Length - 1) * 20;
			for (int i = 0; i < gclass191_0.Length; i++)
			{
				gclass191_0[i] = new GClass191();
				gclass191_0[i].string_7 = "";
				gclass191_0[i].int_0 = int_6 + 10;
				gclass191_0[i].int_1 = int_7 + 35 + (string_0.Length - 1) * 20 + i * 35;
				gclass191_0[i].int_2 = int_8 - 20;
				gclass191_0[i].int_3 = GClass131.int_0 + 2;
				if (GClass73.bool_5)
					gclass191_0[0].bool_0 = false;
				else
					gclass191_0[0].bool_0 = true;
				if (!GClass73.bool_5)
					gclass87_2 = gclass191_0[0].gclass87_0;
			}
			gclass87_0 = new GClass87(mResources.CLOSE, this, 1, null);
			gclass87_1 = new GClass87(mResources.OK, this, 2, null);
			if (GClass73.bool_5)
			{
				gclass87_1.int_1 = GClass73.int_10 / 2 + 18;
				gclass87_0.int_1 = GClass73.int_10 / 2 - 85;
				gclass87_1.int_2 = (gclass87_0.int_2 = int_7 + int_9 + 5);
			}
		}

		public static GClass138 smethod_2()
		{
			if (gclass138_0 == null)
				gclass138_0 = new GClass138();
			return gclass138_0;
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

		public override void paint(GClass122 g)
		{
			GClass144.smethod_8().paint(g);
			GClass45.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass4.gclass4_7.method_6(g, string_0[i], GClass73.int_10 / 2, int_7 + 15 + i * 20, GClass4.int_2);
			}
			for (int j = 0; j < gclass191_0.Length; j++)
			{
				gclass191_0[j].method_13(g);
			}
			base.paint(g);
		}

		public override void update()
		{
			GClass144.smethod_8().update();
			for (int i = 0; i < gclass191_0.Length; i++)
			{
				gclass191_0[i].method_17();
			}
		}

		public override void keyPress(int keyCode)
		{
			for (int i = 0; i < gclass191_0.Length; i++)
			{
				if (gclass191_0[i].bool_0)
				{
					gclass191_0[i].method_10(keyCode);
					break;
				}
			}
			base.keyPress(keyCode);
		}

		public override void updateKey()
		{
			if (GClass73.bool_11[2])
			{
				int_10--;
				if (int_10 < 0)
					int_10 = gclass191_0.Length - 1;
			}
			else if (GClass73.bool_11[8])
			{
				int_10++;
				if (int_10 > gclass191_0.Length - 1)
					int_10 = 0;
			}
			if (GClass73.bool_11[2] || GClass73.bool_11[8])
			{
				GClass73.smethod_26();
				for (int i = 0; i < gclass191_0.Length; i++)
				{
					if (int_10 != i)
						gclass191_0[i].bool_0 = false;
					else
					{
						gclass191_0[i].bool_0 = true;
						if (!GClass73.bool_5)
							gclass87_2 = gclass191_0[i].gclass87_0;
					}
					if (GClass73.bool_16 && GClass73.smethod_24(gclass191_0[i].int_0, gclass191_0[i].int_1, gclass191_0[i].int_2, gclass191_0[i].int_3))
					{
						int_10 = i;
						break;
					}
				}
			}
			base.updateKey();
			GClass73.smethod_26();
		}

		public void method_2()
		{
			gclass138_0 = null;
		}

		public void perform(int idAction, object p)
		{
			if (idAction == 1)
			{
				GClass144.gclass144_0.switchToMe();
				method_2();
			}
			if (idAction != 2)
				return;
			for (int i = 0; i < gclass191_0.Length; i++)
			{
				if (gclass191_0[i].method_21() == null || gclass191_0[i].method_21().Equals(""))
				{
					GClass73.smethod_30(mResources.vuilongnhapduthongtin);
					return;
				}
			}
			GClass7.smethod_0().method_7(gclass191_0);
			GClass144.gclass144_0.switchToMe();
		}
	}
}
