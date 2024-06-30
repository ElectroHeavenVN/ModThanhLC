using System;

namespace ns0
{
	public class GClass156 : GClass145, GInterface0
	{
		public GClass67 gclass67_0;

		public GClass67 gclass67_1;

		public GClass67 gclass67_2;

		public GClass67 gclass67_3;

		public GClass67 gclass67_4;

		public GClass67 gclass67_5;

		public GClass67 gclass67_6;

		public GClass67 gclass67_7;

		public GClass67 gclass67_8;

		public static bool bool_0 = false;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		public bool bool_1;

		public bool bool_2;

		private GClass14 gclass14_4;

		private GClass14 gclass14_5;

		private GClass14 gclass14_6;

		private GClass14 gclass14_7;

		private GClass14 gclass14_8;

		private GClass14 gclass14_9;

		public string string_0 = string.Empty;

		public string string_1;

		public string string_2;

		private string string_3 = string.Empty;

		private string string_4;

		private string string_5;

		public static bool bool_3 = false;

		public static bool bool_4;

		public static bool bool_5;

		public static bool bool_6;

		public static bool bool_7;

		public static bool bool_8;

		public static string string_6;

		public static GClass2 gclass2_0;

		public int int_10;

		public int int_11;

		public int int_12;

		public int int_13;

		public int int_14;

		public int int_15;

		public int int_16;

		public static int[] int_17 = new int[5] { 0, 8, 2, 6, 9 };

		public static bool bool_9;

		public static short short_0;

		public static long long_0;

		public static long long_1;

		private int int_18;

		private GClass14 gclass14_10;

		private GClass14 gclass14_11;

		private int int_19;

		private int int_20;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private string string_7 = string.Empty;

		public bool bool_10;

		private int int_25 = -1;

		public bool bool_11;

		private int int_26 = 2;

		private int int_27;

		private int int_28 = -40;

		private int int_29 = 1;

		public static bool bool_12;

		public GClass156(sbyte haveName)
		{
			int_20 = 130;
			GClass1.int_40 = (sbyte)(GClass138.smethod_18() % 9L);
			if (GClass1.int_40 == 5 || GClass1.int_40 == 6)
				GClass1.int_40 = 4;
			GClass154.smethod_10(true, -1, -1);
			GClass154.int_22 = 100;
			GClass154.int_23 = 200;
			if (GClass39.int_11 > 200)
				int_9 = GClass39.int_13 - 80;
			else
				int_9 = GClass39.int_13 - 65;
			method_14();
			int num = (int_7 = ((GClass39.int_10 < 200) ? 140 : 160));
			int_18 = GClass39.int_13 - GClass145.int_0 - 5;
			if (GClass39.int_11 <= 160)
				int_18 = 20;
			gclass67_8 = new GClass67();
			gclass67_8.method_28(GClass67.int_12);
			gclass67_8.int_2 = 220;
			gclass67_8.int_3 = GClass145.int_0 + 2;
			gclass67_8.string_7 = "Số điện thoại/ địa chỉ email";
			if (haveName == 1)
				gclass67_8.method_23("01234567890");
			gclass67_0 = new GClass67();
			gclass67_0.int_2 = 220;
			gclass67_0.int_3 = GClass145.int_0 + 2;
			gclass67_0.bool_0 = true;
			gclass67_0.string_7 = "Họ và tên";
			if (haveName == 1)
				gclass67_0.method_23("Nguyễn Văn A");
			gclass67_0.method_28(GClass67.int_11);
			gclass67_1 = new GClass67();
			gclass67_1.method_28(GClass67.int_12);
			gclass67_1.int_2 = 70;
			gclass67_1.int_3 = GClass145.int_0 + 2;
			gclass67_1.string_7 = "Ngày sinh";
			if (haveName == 1)
				gclass67_1.method_23("01");
			gclass67_2 = new GClass67();
			gclass67_2.method_28(GClass67.int_12);
			gclass67_2.int_2 = 70;
			gclass67_2.int_3 = GClass145.int_0 + 2;
			gclass67_2.string_7 = "Tháng sinh";
			if (haveName == 1)
				gclass67_2.method_23("01");
			gclass67_3 = new GClass67();
			gclass67_3.method_28(GClass67.int_12);
			gclass67_3.int_2 = 70;
			gclass67_3.int_3 = GClass145.int_0 + 2;
			gclass67_3.string_7 = "Năm sinh";
			if (haveName == 1)
				gclass67_3.method_23("1990");
			gclass67_4 = new GClass67();
			gclass67_4.method_28(GClass67.int_11);
			gclass67_4.int_2 = 220;
			gclass67_4.int_3 = GClass145.int_0 + 2;
			gclass67_4.string_7 = "Địa chỉ đăng ký thường trú";
			if (haveName == 1)
				gclass67_4.method_23("123 đường số 1, Quận 1, TP.HCM");
			gclass67_5 = new GClass67();
			gclass67_5.method_28(GClass67.int_12);
			gclass67_5.int_2 = 220;
			gclass67_5.int_3 = GClass145.int_0 + 2;
			gclass67_5.string_7 = "Số Chứng minh nhân dân hoặc số hộ chiếu";
			if (haveName == 1)
				gclass67_5.method_23("123456789");
			gclass67_6 = new GClass67();
			gclass67_6.method_28(GClass67.int_12);
			gclass67_6.int_2 = 220;
			gclass67_6.int_3 = GClass145.int_0 + 2;
			gclass67_6.string_7 = "Ngày cấp";
			if (haveName == 1)
				gclass67_6.method_23("01/01/2005");
			gclass67_7 = new GClass67();
			gclass67_7.method_28(GClass67.int_11);
			gclass67_7.int_2 = 220;
			gclass67_7.int_3 = GClass145.int_0 + 2;
			gclass67_7.string_7 = "Nơi cấp";
			if (haveName == 1)
				gclass67_7.method_23("TP.HCM");
			int_18 += 35;
			bool_1 = true;
			int_6 = 0;
			gclass14_4 = new GClass14((GClass39.int_10 <= 200) ? mResources.login2 : mResources.login, GClass39.gclass39_0, 888393, null);
			gclass14_5 = new GClass14(mResources.remember, this, 2001, null);
			gclass14_7 = new GClass14(mResources.register, this, 2002, null);
			gclass14_9 = new GClass14(mResources.CANCEL, this, 10021, null);
			gclass14_0 = (gclass14_8 = new GClass14(mResources.MENU, this, 2003, null));
			if (GClass39.bool_5)
			{
				gclass14_4.int_1 = GClass39.int_10 / 2 - 100;
				gclass14_8.int_1 = GClass39.int_10 / 2 - GClass145.int_2 - 8;
				if (GClass39.int_11 >= 200)
				{
					gclass14_4.int_2 = GClass39.int_11 / 2 - 40;
					gclass14_8.int_2 = int_20 + 110;
				}
				gclass14_9.int_1 = GClass39.int_10 / 2 + 3;
				gclass14_9.int_2 = int_20 + 110;
				gclass14_7.int_1 = GClass39.int_10 / 2 - 84;
				gclass14_7.int_2 = gclass14_8.int_2;
			}
			int_23 = 170;
			int_24 = ((!bool_2) ? 100 : 110);
			int_21 = GClass39.int_12 - int_23 / 2;
			int_22 = gclass67_0.int_1 - 15;
			int num2 = 4;
			int num3 = 184;
			if (184 >= GClass39.int_10)
				num3 = (num2 - 1) * 32 + 23 + 33;
			int_19 = GClass39.int_10 / 2 - num3 / 2;
			int_20 = 5;
			int_12 = ((GClass39.int_10 < 200) ? (gclass67_0.int_1 - 30) : (int_20 - 30));
			gclass67_0.int_0 = int_19 + 10;
			gclass67_0.int_1 = int_20 + 20;
			gclass14_11 = new GClass14(mResources.OK, this, 2008, null);
			gclass14_11.int_1 = 260;
			gclass14_11.int_2 = GClass39.int_11 - 60;
			gclass14_6 = new GClass14("Thoát", this, 1003, null);
			gclass14_6.int_1 = 260;
			gclass14_6.int_2 = GClass39.int_11 - 30;
			if (GClass39.int_10 < 250)
			{
				gclass14_11.int_1 = GClass39.int_10 / 2 - 80;
				gclass14_6.int_1 = GClass39.int_10 / 2 + 10;
				gclass14_6.int_2 = (gclass14_11.int_2 = GClass39.int_11 - 25);
			}
			gclass14_1 = gclass14_11;
			gclass14_0 = gclass14_6;
		}

		public void method_0()
		{
			GClass56.smethod_8("Res switch");
			GClass29.smethod_1().method_51();
			int_6 = 0;
			gclass67_0.bool_0 = true;
			gclass67_1.bool_0 = false;
			if (GClass39.bool_5)
			{
				gclass67_0.bool_0 = false;
				int_6 = -1;
			}
			base.switchToMe();
		}

		protected void method_1()
		{
			GClass63 gClass = new GClass63("vMenu Login");
			gClass.method_0(new GClass14(mResources.registerNewAcc, this, 2004, null));
			if (!bool_11)
				gClass.method_0(new GClass14(mResources.selectServer, this, 1004, null));
			gClass.method_0(new GClass14(mResources.forgetPass, this, 1003, null));
			gClass.method_0(new GClass14(mResources.website, this, 1005, null));
			if (GClass120.smethod_8("lowGraphic") == 1)
				gClass.method_0(new GClass14(mResources.increase_vga, this, 10041, null));
			else
				gClass.method_0(new GClass14(mResources.decrease_vga, this, 10042, null));
			gClass.method_0(new GClass14(mResources.EXIT, GClass39.gclass39_0, 8885, null));
			GClass39.gclass0_0.method_2(gClass, 0);
		}

		protected void method_2()
		{
			if (gclass67_0.method_21().Equals(string.Empty))
			{
				GClass39.smethod_30(mResources.userBlank);
				return;
			}
			gclass67_0.method_21().ToCharArray();
			if (gclass67_1.method_21().Equals(string.Empty))
			{
				GClass39.smethod_30(mResources.passwordBlank);
				return;
			}
			if (gclass67_0.method_21().Length < 5)
			{
				GClass39.smethod_30(mResources.accTooShort);
				return;
			}
			int num = 0;
			string text = null;
			if (mResources.language == 2)
			{
				if (gclass67_0.method_21().IndexOf("@") == -1 || gclass67_0.method_21().IndexOf(".") == -1)
					text = mResources.emailInvalid;
				num = 0;
			}
			else
				try
				{
					long.Parse(gclass67_0.method_21());
					if (gclass67_0.method_21().Length < 8 || gclass67_0.method_21().Length > 12 || (!gclass67_0.method_21().StartsWith("0") && !gclass67_0.method_21().StartsWith("84")))
						text = mResources.phoneInvalid;
					num = 1;
				}
				catch (Exception)
				{
					if (gclass67_0.method_21().IndexOf("@") == -1 || gclass67_0.method_21().IndexOf(".") == -1)
						text = mResources.emailInvalid;
					num = 0;
				}
			if (text != null)
				GClass39.smethod_30(text);
			else
				GClass39.gclass100_0.method_2(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + gclass67_0.method_21() + "\n" + mResources.password + ": " + gclass67_1.method_21(), new GClass14(mResources.ACCEPT, this, 4000, null), null, new GClass14(mResources.NO, GClass39.gclass39_0, 8882, null));
			GClass39.gclass99_0 = GClass39.gclass100_0;
		}

		protected void method_3(string user)
		{
		}

		public void method_4()
		{
			if (!string_0.Equals(string.Empty) || !string_0.Equals(string.Empty))
				;
			if (!GClass162.bool_1)
			{
				bool_10 = true;
				GClass39.smethod_4();
			}
			GClass39.smethod_33();
		}

		protected void method_5()
		{
			GClass63 gClass = new GClass63("vServer");
			if (bool_3)
				gClass.method_0(new GClass14("Server LOCAL", this, 20004, null));
			gClass.method_0(new GClass14("Server Bokken", this, 20001, null));
			gClass.method_0(new GClass14("Server Shuriken", this, 20002, null));
			gClass.method_0(new GClass14("Server Tessen (mới)", this, 20003, null));
			GClass39.gclass0_0.method_2(gClass, 0);
			if (method_7() != -1 && !GClass39.bool_5)
				GClass39.gclass0_0.int_0 = method_7();
		}

		protected void method_6(int index)
		{
			GClass120.smethod_9("indServer", index);
		}

		protected int method_7()
		{
			return GClass120.smethod_8("indServer");
		}

		public void method_8()
		{
		}

		public void method_9()
		{
		}

		public override void update()
		{
			gclass67_0.method_17();
			gclass67_1.method_17();
			gclass67_2.method_17();
			gclass67_3.method_17();
			gclass67_4.method_17();
			gclass67_5.method_17();
			gclass67_7.method_17();
			gclass67_8.method_17();
			gclass67_6.method_17();
			for (int i = 0; i < GClass68.gclass63_1.method_2(); i++)
			{
				((GClass68)GClass68.gclass63_1.method_3(i)).update();
			}
			if (bool_4 && !bool_5 && !bool_8 && !bool_6 && !bool_7)
			{
				bool_4 = false;
				GClass138.smethod_26();
				GClass166.smethod_0().method_115();
			}
			GClass154.int_22++;
			if (GClass154.int_22 > GClass39.int_10 * 3 + 100)
				GClass154.int_22 = 100;
			if (GClass70.gclass70_0 != null)
				return;
			GClass39.smethod_8("LGU1", 0);
			GClass39.smethod_8("LGU2", 0);
			GClass39.smethod_8("LGU3", 0);
			method_11();
			GClass39.smethod_8("LGU4", 0);
			GClass39.smethod_8("LGU5", 0);
			if (int_27 >= 0)
			{
				int_28 += int_29 * int_27;
				int_27 += int_29 * int_26;
				if (int_27 <= 0)
					int_29 *= -1;
				if (int_28 > 0)
				{
					int_29 *= -1;
					int_27 -= 2 * int_26;
				}
			}
			GClass39.smethod_8("LGU6", 0);
			if (int_25 >= 0 && GClass39.int_8 % 100 == 0)
				method_10();
			if (GClass39.bool_5)
			{
				if (bool_2)
				{
					gclass14_1 = gclass14_7;
					gclass14_0 = gclass14_9;
				}
				else
				{
					gclass14_1 = gclass14_11;
					gclass14_0 = gclass14_6;
				}
			}
			else if (bool_2)
			{
				gclass14_1 = gclass14_7;
				gclass14_0 = gclass14_9;
			}
			else
			{
				gclass14_1 = gclass14_11;
				gclass14_0 = gclass14_6;
			}
		}

		private void method_10()
		{
			int_25++;
			if (int_25 >= mResources.tips.Length)
				int_25 = 0;
			if (GClass39.gclass99_0 == GClass39.gclass100_0 && GClass39.gclass100_0.bool_0)
				GClass39.gclass100_0.method_1(mResources.tips[int_25]);
		}

		public void method_11()
		{
			if (int_9 != int_8)
				int_8 += int_9 - int_8 >> 1;
		}

		public override void keyPress(int keyCode)
		{
			if (gclass67_0.bool_0)
				gclass67_0.method_10(keyCode);
			else if (gclass67_1.bool_0)
			{
				gclass67_1.method_10(keyCode);
			}
			else if (gclass67_2.bool_0)
			{
				gclass67_2.method_10(keyCode);
			}
			else if (gclass67_3.bool_0)
			{
				gclass67_3.method_10(keyCode);
			}
			else if (gclass67_4.bool_0)
			{
				gclass67_4.method_10(keyCode);
			}
			else if (gclass67_5.bool_0)
			{
				gclass67_5.method_10(keyCode);
			}
			else if (gclass67_7.bool_0)
			{
				gclass67_7.method_10(keyCode);
			}
			else if (gclass67_8.bool_0)
			{
				gclass67_8.method_10(keyCode);
			}
			else if (gclass67_6.bool_0)
			{
				gclass67_6.method_10(keyCode);
			}
			base.keyPress(keyCode);
		}

		public override void unLoad()
		{
			base.unLoad();
		}

		public override void paint(GClass76 g)
		{
			GClass39.smethod_8("PLG1", 1);
			GClass39.smethod_18(g);
			GClass39.smethod_8("PLG2", 2);
			int num = gclass67_0.int_1 - 50;
			if (GClass39.int_11 <= 220)
				num += 5;
			if (GClass70.gclass70_0 != null || GClass70.gclass70_1 != null)
				return;
			if (GClass39.gclass99_0 == null)
			{
				int_19 = 5;
				int num2 = 233;
				if (GClass39.int_10 < 260)
					int_19 = (GClass39.int_10 - 240) / 2;
				int_20 = (GClass39.int_11 - num2) / 2;
				if (GClass39.int_10 < 200)
					_ = 160;
				else
					_ = 180;
				GClass24.smethod_4(g, int_19, int_20, 240, num2, -1, true);
				if (GClass39.int_11 > 160 && gclass2_0 != null)
					g.method_31(gclass2_0, GClass39.int_12, num, 3);
				GClass39.smethod_8("PLG4", 1);
				int num3 = 4;
				if (184 >= GClass39.int_10)
					num3--;
				gclass67_8.int_0 = int_19 + 10;
				gclass67_8.int_1 = int_20 + 15;
				gclass67_0.int_0 = gclass67_8.int_0;
				gclass67_0.int_1 = gclass67_8.int_1 + 30;
				gclass67_1.int_0 = int_19 + 10;
				gclass67_1.int_1 = gclass67_0.int_1 + 30;
				gclass67_2.int_0 = gclass67_1.int_0 + 75;
				gclass67_2.int_1 = gclass67_1.int_1;
				gclass67_3.int_0 = gclass67_2.int_0 + 75;
				gclass67_3.int_1 = gclass67_2.int_1;
				gclass67_4.int_0 = gclass67_0.int_0;
				gclass67_4.int_1 = gclass67_1.int_1 + 30;
				gclass67_5.int_0 = gclass67_0.int_0;
				gclass67_5.int_1 = gclass67_4.int_1 + 30;
				gclass67_6.int_0 = gclass67_0.int_0;
				gclass67_6.int_1 = gclass67_5.int_1 + 30;
				gclass67_7.int_0 = gclass67_0.int_0;
				gclass67_7.int_1 = gclass67_6.int_1 + 30;
				gclass67_0.method_13(g);
				gclass67_1.method_13(g);
				gclass67_2.method_13(g);
				gclass67_3.method_13(g);
				gclass67_4.method_13(g);
				gclass67_5.method_13(g);
				gclass67_6.method_13(g);
				gclass67_7.method_13(g);
				gclass67_8.method_13(g);
				if (GClass39.int_10 < 176)
				{
					GClass49.gclass49_7.method_6(g, mResources.acc + ":", gclass67_0.int_0 - 35, gclass67_0.int_1 + 7, 0);
					GClass49.gclass49_7.method_6(g, mResources.pwd + ":", gclass67_1.int_0 - 35, gclass67_1.int_1 + 7, 0);
					GClass49.gclass49_7.method_6(g, mResources.server + ": " + string_6, GClass39.int_10 / 2, gclass67_1.int_1 + 32, 2);
					if (!bool_2)
						;
				}
			}
			string st = GClass113.string_2;
			g.method_16(GClass39.int_23);
			g.method_15(GClass39.int_10 - 40, 4, 36, 11);
			GClass49.gclass49_16.method_6(g, st, GClass39.int_10 - 22, 4, GClass49.int_2);
			GClass39.smethod_6(g);
			if (GClass39.gclass99_0 == null)
			{
				if (GClass39.int_10 > 250)
				{
					GClass49.gclass49_3.method_10(g, "Dưới 18 tuổi", 260, 10, 0, GClass49.gclass49_6);
					GClass49.gclass49_3.method_10(g, "chỉ có thể chơi", 260, 25, 0, GClass49.gclass49_6);
					GClass49.gclass49_3.method_10(g, "180p 1 ngày", 260, 40, 0, GClass49.gclass49_6);
				}
				else
				{
					GClass49.gclass49_3.method_10(g, "Dưới 18 tuổi chỉ có thể chơi", GClass39.int_10 / 2, 5, 2, GClass49.gclass49_6);
					GClass49.gclass49_3.method_10(g, "180p 1 ngày", GClass39.int_10 / 2, 15, 2, GClass49.gclass49_6);
				}
			}
			base.paint(g);
		}

		private void method_12()
		{
			gclass67_0.bool_0 = false;
			gclass67_1.bool_0 = false;
			gclass67_2.bool_0 = false;
			gclass67_3.bool_0 = false;
			gclass67_4.bool_0 = false;
			gclass67_5.bool_0 = false;
			gclass67_6.bool_0 = false;
			gclass67_7.bool_0 = false;
			gclass67_8.bool_0 = false;
		}

		private void method_13()
		{
			method_12();
			switch (int_6)
			{
			case 0:
				gclass67_0.bool_0 = true;
				break;
			case 1:
				gclass67_1.bool_0 = true;
				break;
			case 2:
				gclass67_2.bool_0 = true;
				break;
			case 3:
				gclass67_3.bool_0 = true;
				break;
			case 4:
				gclass67_4.bool_0 = true;
				break;
			case 5:
				gclass67_5.bool_0 = true;
				break;
			case 6:
				gclass67_6.bool_0 = true;
				break;
			case 7:
				gclass67_7.bool_0 = true;
				break;
			case 8:
				gclass67_8.bool_0 = true;
				break;
			}
		}

		public override void updateKey()
		{
			if (bool_0)
				return;
			if (!GClass39.bool_5)
			{
				if (gclass67_0.bool_0)
					gclass14_2 = gclass67_0.gclass14_0;
				else if (gclass67_1.bool_0)
				{
					gclass14_2 = gclass67_1.gclass14_0;
				}
				else if (gclass67_2.bool_0)
				{
					gclass14_2 = gclass67_2.gclass14_0;
				}
				else if (gclass67_3.bool_0)
				{
					gclass14_2 = gclass67_3.gclass14_0;
				}
				else if (gclass67_4.bool_0)
				{
					gclass14_2 = gclass67_4.gclass14_0;
				}
				else if (gclass67_5.bool_0)
				{
					gclass14_2 = gclass67_5.gclass14_0;
				}
				else if (gclass67_6.bool_0)
				{
					gclass14_2 = gclass67_6.gclass14_0;
				}
				else if (gclass67_7.bool_0)
				{
					gclass14_2 = gclass67_7.gclass14_0;
				}
				else if (gclass67_8.bool_0)
				{
					gclass14_2 = gclass67_8.gclass14_0;
				}
			}
			if (GClass39.bool_11[21])
			{
				int_6--;
				if (int_6 < 0)
					int_6 = 8;
				method_13();
			}
			else if (GClass39.bool_11[22])
			{
				int_6++;
				if (int_6 > 8)
					int_6 = 0;
				method_13();
			}
			if (GClass39.bool_11[21] || GClass39.bool_11[22])
			{
				GClass39.smethod_26();
				if (!bool_11 || bool_2)
				{
					if (int_6 == 1)
					{
						gclass67_0.bool_0 = false;
						gclass67_1.bool_0 = true;
					}
					else if (int_6 == 0)
					{
						gclass67_0.bool_0 = true;
						gclass67_1.bool_0 = false;
					}
					else
					{
						gclass67_0.bool_0 = false;
						gclass67_1.bool_0 = false;
					}
				}
			}
			if (GClass39.bool_5)
			{
				if (bool_2)
				{
					gclass14_1 = gclass14_7;
					gclass14_0 = gclass14_9;
				}
				else
				{
					gclass14_1 = gclass14_11;
					gclass14_0 = gclass14_6;
				}
			}
			else if (bool_2)
			{
				gclass14_1 = gclass14_7;
				gclass14_0 = gclass14_9;
			}
			else
			{
				gclass14_1 = gclass14_11;
				gclass14_0 = gclass14_6;
			}
			if (GClass39.bool_16)
			{
				if (GClass39.smethod_24(gclass67_0.int_0, gclass67_0.int_1, gclass67_0.int_2, gclass67_0.int_3))
				{
					int_6 = 0;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_1.int_0, gclass67_1.int_1, gclass67_1.int_2, gclass67_1.int_3))
				{
					int_6 = 1;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_2.int_0, gclass67_2.int_1, gclass67_2.int_2, gclass67_2.int_3))
				{
					int_6 = 2;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_3.int_0, gclass67_3.int_1, gclass67_3.int_2, gclass67_3.int_3))
				{
					int_6 = 3;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_4.int_0, gclass67_4.int_1, gclass67_4.int_2, gclass67_4.int_3))
				{
					int_6 = 4;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_5.int_0, gclass67_5.int_1, gclass67_5.int_2, gclass67_5.int_3))
				{
					int_6 = 5;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_6.int_0, gclass67_6.int_1, gclass67_6.int_2, gclass67_6.int_3))
				{
					int_6 = 6;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_7.int_0, gclass67_7.int_1, gclass67_7.int_2, gclass67_7.int_3))
				{
					int_6 = 7;
					method_13();
				}
				else if (GClass39.smethod_24(gclass67_8.int_0, gclass67_8.int_1, gclass67_8.int_2, gclass67_8.int_3))
				{
					int_6 = 8;
					method_13();
				}
			}
			base.updateKey();
			GClass39.smethod_26();
		}

		public void method_14()
		{
			int_8 = -50;
		}

		public void perform(int idAction, object p)
		{
			if (idAction <= 2008)
			{
				switch (idAction)
				{
				case 1000:
					try
					{
						GClass113.gclass113_0.method_3((string)p);
					}
					catch (Exception ex2)
					{
						ex2.StackTrace.ToString();
					}
					GClass39.smethod_29();
					return;
				case 1001:
					GClass39.smethod_29();
					bool_2 = false;
					return;
				case 1003:
					GClass162.smethod_0().close();
					GClass39.gclass152_0.switchToMe();
					return;
				case 1004:
					GClass152.smethod_3();
					GClass39.gclass152_0.switchToMe();
					return;
				case 1005:
					try
					{
						GClass113.gclass113_0.method_3("http://ngocrongonline.com");
						return;
					}
					catch (Exception ex)
					{
						ex.StackTrace.ToString();
						return;
					}
				case 1002:
					return;
				}
				switch (idAction)
				{
				case 2001:
					if (bool_1)
						bool_1 = false;
					else
						bool_1 = true;
					break;
				case 2002:
					method_2();
					break;
				case 2003:
					method_1();
					break;
				case 2004:
					method_16();
					break;
				case 2008:
					if (gclass67_1.method_21().Equals(string.Empty) || gclass67_2.method_21().Equals(string.Empty) || gclass67_3.method_21().Equals(string.Empty) || gclass67_4.method_21().Equals(string.Empty) || gclass67_5.method_21().Equals(string.Empty) || gclass67_6.method_21().Equals(string.Empty) || gclass67_7.method_21().Equals(string.Empty) || gclass67_8.method_21().Equals(string.Empty) || gclass67_0.method_21().Equals(string.Empty))
					{
						GClass39.smethod_30("Vui lòng điền đầy đủ thông tin");
						break;
					}
					GClass39.smethod_30(mResources.PLEASEWAIT);
					GClass166.smethod_0().method_2(gclass67_1.method_21(), gclass67_2.method_21(), gclass67_3.method_21(), gclass67_4.method_21(), gclass67_5.method_21(), gclass67_6.method_21(), gclass67_7.method_21(), gclass67_8.method_21(), gclass67_0.method_21());
					break;
				case 2005:
				case 2006:
				case 2007:
					break;
				}
			}
			else if (idAction != 4000)
			{
				if (idAction == 10021)
					method_15();
			}
			else
			{
				method_3(gclass67_0.method_21());
			}
		}

		public void method_15()
		{
			if (bool_11)
			{
				method_8();
				return;
			}
			bool_2 = false;
			gclass67_1.bool_0 = false;
			gclass67_0.bool_0 = true;
			gclass14_0 = gclass14_8;
		}

		public void method_16()
		{
			GClass39.smethod_29();
			GClass39.smethod_30(mResources.regNote);
			bool_2 = true;
			gclass67_1.bool_0 = false;
			gclass67_0.bool_0 = true;
		}

		public void method_17()
		{
			if (GClass39.gclass149_0.bool_12)
			{
				GClass39.smethod_36(mResources.note, new GClass14(mResources.YES, GClass39.gclass45_0, 10019, null), new GClass14(mResources.NO, GClass39.gclass45_0, 10020, null));
				return;
			}
			GClass39.gclass39_0.method_9(GClass39.gclass149_0);
			GClass162.smethod_0().close();
		}
	}
}
