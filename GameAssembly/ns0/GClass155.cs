namespace ns0
{
	public class GClass155 : GClass145, GInterface0
	{
		public static GClass155 gclass155_0;

		public GClass67[] gclass67_0;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private string[] string_0;

		private int int_10;

		private int int_11;

		private void method_0(string string_1)
		{
			int_8 = GClass39.int_10 - 20;
			if (int_8 > 320)
				int_8 = 320;
			GClass56.smethod_8("title= " + string_1);
			string_0 = GClass49.gclass49_6.method_15(string_1, int_8 - 20);
			int_6 = (GClass39.int_10 - int_8) / 2;
			gclass67_0 = new GClass67[int_11];
			int_9 = gclass67_0.Length * 35 + (string_0.Length - 1) * 20 + 40;
			int_7 = GClass39.int_11 - int_9 - 40 - (string_0.Length - 1) * 20;
			for (int i = 0; i < gclass67_0.Length; i++)
			{
				gclass67_0[i] = new GClass67();
				gclass67_0[i].string_7 = string.Empty;
				gclass67_0[i].int_0 = int_6 + 10;
				gclass67_0[i].int_1 = int_7 + 35 + (string_0.Length - 1) * 20 + i * 35;
				gclass67_0[i].int_2 = int_8 - 20;
				gclass67_0[i].int_3 = GClass145.int_0 + 2;
				if (GClass39.bool_5)
					gclass67_0[0].bool_0 = false;
				else
					gclass67_0[0].bool_0 = true;
				if (!GClass39.bool_5)
					gclass14_2 = gclass67_0[0].gclass14_0;
			}
			gclass14_0 = new GClass14(mResources.CLOSE, this, 1, null);
			gclass14_1 = new GClass14(mResources.OK, this, 2, null);
			if (GClass39.bool_5)
			{
				gclass14_1.int_1 = GClass39.int_10 / 2 + 18;
				gclass14_0.int_1 = GClass39.int_10 / 2 - 85;
				gclass14_1.int_2 = (gclass14_0.int_2 = int_7 + int_9 + 5);
			}
		}

		public static GClass155 smethod_2()
		{
			if (gclass155_0 == null)
				gclass155_0 = new GClass155();
			return gclass155_0;
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

		public override void paint(GClass76 g)
		{
			GClass154.smethod_8().paint(g);
			GClass24.smethod_4(g, int_6, int_7, int_8, int_9, -1, true);
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass49.gclass49_7.method_6(g, string_0[i], GClass39.int_10 / 2, int_7 + 15 + i * 20, GClass49.int_2);
			}
			for (int j = 0; j < gclass67_0.Length; j++)
			{
				gclass67_0[j].method_13(g);
			}
			base.paint(g);
		}

		public override void update()
		{
			GClass154.smethod_8().update();
			for (int i = 0; i < gclass67_0.Length; i++)
			{
				gclass67_0[i].method_17();
			}
		}

		public override void keyPress(int keyCode)
		{
			for (int i = 0; i < gclass67_0.Length; i++)
			{
				if (gclass67_0[i].bool_0)
				{
					gclass67_0[i].method_10(keyCode);
					break;
				}
			}
			base.keyPress(keyCode);
		}

		public override void updateKey()
		{
			if (GClass39.bool_11[2])
			{
				int_10--;
				if (int_10 < 0)
					int_10 = gclass67_0.Length - 1;
			}
			else if (GClass39.bool_11[8])
			{
				int_10++;
				if (int_10 > gclass67_0.Length - 1)
					int_10 = 0;
			}
			if (GClass39.bool_11[2] || GClass39.bool_11[8])
			{
				GClass39.smethod_26();
				for (int i = 0; i < gclass67_0.Length; i++)
				{
					if (int_10 == i)
					{
						gclass67_0[i].bool_0 = true;
						if (!GClass39.bool_5)
							gclass14_2 = gclass67_0[i].gclass14_0;
					}
					else
						gclass67_0[i].bool_0 = false;
					if (GClass39.bool_16 && GClass39.smethod_24(gclass67_0[i].int_0, gclass67_0[i].int_1, gclass67_0[i].int_2, gclass67_0[i].int_3))
					{
						int_10 = i;
						break;
					}
				}
			}
			base.updateKey();
			GClass39.smethod_26();
		}

		public void method_2()
		{
			gclass155_0 = null;
		}

		public void perform(int idAction, object p)
		{
			if (idAction == 1)
			{
				GClass154.gclass154_0.switchToMe();
				method_2();
			}
			if (idAction != 2)
				return;
			int num = 0;
			while (true)
			{
				if (num < gclass67_0.Length)
				{
					if (gclass67_0[num].method_21() == null || gclass67_0[num].method_21().Equals(string.Empty))
						break;
					num++;
					continue;
				}
				GClass166.smethod_0().method_7(gclass67_0);
				GClass154.gclass154_0.switchToMe();
				return;
			}
			GClass39.smethod_30(mResources.vuilongnhapduthongtin);
		}
	}
}
