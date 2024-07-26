using System;

namespace Assets.src.g
{
	public class GClass139 : GClass131, GInterface6
	{
		public GClass191 gclass191_0;

		public GClass191 gclass191_1;

		public GClass191 gclass191_2;

		public GClass191 gclass191_3;

		public GClass191 gclass191_4;

		public GClass191 gclass191_5;

		public GClass191 gclass191_6;

		public GClass191 gclass191_7;

		public GClass191 gclass191_8;

		public static bool bool_0 = false;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		public bool bool_1;

		public bool bool_2;

		private GClass87 gclass87_4;

		private GClass87 gclass87_5;

		private GClass87 gclass87_6;

		private GClass87 gclass87_7;

		private GClass87 gclass87_8;

		private GClass87 gclass87_9;

		public string string_0 = "";

		public string string_1;

		public string string_2;

		private string string_3 = "";

		private string string_4;

		private string string_5;

		public static bool bool_3 = false;

		public static bool bool_4;

		public static bool bool_5;

		public static bool bool_6;

		public static bool bool_7;

		public static bool bool_8;

		public static string string_6;

		public static GClass70 gclass70_0;

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

		private GClass87 gclass87_10;

		private GClass87 gclass87_11;

		private int int_19;

		private int int_20;

		private int int_21;

		private int int_22;

		private int int_23;

		private int int_24;

		private string string_7 = "";

		public bool bool_10;

		private int int_25 = -1;

		public bool bool_11;

		private int int_26 = 2;

		private int int_27;

		private int int_28 = -40;

		private int int_29 = 1;

		public static bool bool_12;

		public GClass139(sbyte haveName)
		{
			int_20 = 130;
			GClass20.int_40 = (sbyte)(GClass203.smethod_18() % 9L);
			if (GClass20.int_40 == 5 || GClass20.int_40 == 6)
				GClass20.int_40 = 4;
			GClass144.smethod_10(true, -1, -1);
			GClass144.int_22 = 100;
			GClass144.int_23 = 200;
			if (GClass73.int_11 > 200)
				int_9 = GClass73.int_13 - 80;
			else
				int_9 = GClass73.int_13 - 65;
			method_14();
			int num = (int_7 = ((GClass73.int_10 >= 200) ? 160 : 140));
			int_18 = GClass73.int_13 - GClass131.int_0 - 5;
			if (GClass73.int_11 <= 160)
				int_18 = 20;
			gclass191_8 = new GClass191();
			gclass191_8.method_28(GClass191.int_12);
			gclass191_8.int_2 = 220;
			gclass191_8.int_3 = GClass131.int_0 + 2;
			gclass191_8.string_7 = "Số điện thoại/ địa chỉ email";
			if (haveName == 1)
				gclass191_8.method_23("01234567890");
			gclass191_0 = new GClass191();
			gclass191_0.int_2 = 220;
			gclass191_0.int_3 = GClass131.int_0 + 2;
			gclass191_0.bool_0 = true;
			gclass191_0.string_7 = "Họ và tên";
			if (haveName == 1)
				gclass191_0.method_23("Nguyễn Văn A");
			gclass191_0.method_28(GClass191.int_11);
			gclass191_1 = new GClass191();
			gclass191_1.method_28(GClass191.int_12);
			gclass191_1.int_2 = 70;
			gclass191_1.int_3 = GClass131.int_0 + 2;
			gclass191_1.string_7 = "Ngày sinh";
			if (haveName == 1)
				gclass191_1.method_23("01");
			gclass191_2 = new GClass191();
			gclass191_2.method_28(GClass191.int_12);
			gclass191_2.int_2 = 70;
			gclass191_2.int_3 = GClass131.int_0 + 2;
			gclass191_2.string_7 = "Tháng sinh";
			if (haveName == 1)
				gclass191_2.method_23("01");
			gclass191_3 = new GClass191();
			gclass191_3.method_28(GClass191.int_12);
			gclass191_3.int_2 = 70;
			gclass191_3.int_3 = GClass131.int_0 + 2;
			gclass191_3.string_7 = "Năm sinh";
			if (haveName == 1)
				gclass191_3.method_23("1990");
			gclass191_4 = new GClass191();
			gclass191_4.method_28(GClass191.int_11);
			gclass191_4.int_2 = 220;
			gclass191_4.int_3 = GClass131.int_0 + 2;
			gclass191_4.string_7 = "Địa chỉ đăng ký thường trú";
			if (haveName == 1)
				gclass191_4.method_23("123 đường số 1, Quận 1, TP.HCM");
			gclass191_5 = new GClass191();
			gclass191_5.method_28(GClass191.int_12);
			gclass191_5.int_2 = 220;
			gclass191_5.int_3 = GClass131.int_0 + 2;
			gclass191_5.string_7 = "Số Chứng minh nhân dân hoặc số hộ chiếu";
			if (haveName == 1)
				gclass191_5.method_23("123456789");
			gclass191_6 = new GClass191();
			gclass191_6.method_28(GClass191.int_12);
			gclass191_6.int_2 = 220;
			gclass191_6.int_3 = GClass131.int_0 + 2;
			gclass191_6.string_7 = "Ngày cấp";
			if (haveName == 1)
				gclass191_6.method_23("01/01/2005");
			gclass191_7 = new GClass191();
			gclass191_7.method_28(GClass191.int_11);
			gclass191_7.int_2 = 220;
			gclass191_7.int_3 = GClass131.int_0 + 2;
			gclass191_7.string_7 = "Nơi cấp";
			if (haveName == 1)
				gclass191_7.method_23("TP.HCM");
			int_18 += 35;
			bool_1 = true;
			int_6 = 0;
			gclass87_4 = new GClass87((GClass73.int_10 <= 200) ? mResources.login2 : mResources.login, GClass73.gclass73_0, 888393, null);
			gclass87_5 = new GClass87(mResources.remember, this, 2001, null);
			gclass87_7 = new GClass87(mResources.register, this, 2002, null);
			gclass87_9 = new GClass87(mResources.CANCEL, this, 10021, null);
			gclass87_0 = (gclass87_8 = new GClass87(mResources.MENU, this, 2003, null));
			if (GClass73.bool_5)
			{
				gclass87_4.int_1 = GClass73.int_10 / 2 - 100;
				gclass87_8.int_1 = GClass73.int_10 / 2 - GClass131.int_2 - 8;
				if (GClass73.int_11 >= 200)
				{
					gclass87_4.int_2 = GClass73.int_11 / 2 - 40;
					gclass87_8.int_2 = int_20 + 110;
				}
				gclass87_9.int_1 = GClass73.int_10 / 2 + 3;
				gclass87_9.int_2 = int_20 + 110;
				gclass87_7.int_1 = GClass73.int_10 / 2 - 84;
				gclass87_7.int_2 = gclass87_8.int_2;
			}
			int_23 = 170;
			int_24 = ((!bool_2) ? 100 : 110);
			int_21 = GClass73.int_12 - int_23 / 2;
			int_22 = gclass191_0.int_1 - 15;
			int num2 = 4;
			int num3 = 184;
			if (184 >= GClass73.int_10)
				num3 = (num2 - 1) * 32 + 23 + 33;
			int_19 = GClass73.int_10 / 2 - num3 / 2;
			int_20 = 5;
			int_12 = ((GClass73.int_10 < 200) ? (gclass191_0.int_1 - 30) : (int_20 - 30));
			gclass191_0.int_0 = int_19 + 10;
			gclass191_0.int_1 = int_20 + 20;
			gclass87_11 = new GClass87(mResources.OK, this, 2008, null);
			gclass87_11.int_1 = 260;
			gclass87_11.int_2 = GClass73.int_11 - 60;
			gclass87_6 = new GClass87("Thoát", this, 1003, null);
			gclass87_6.int_1 = 260;
			gclass87_6.int_2 = GClass73.int_11 - 30;
			if (GClass73.int_10 < 250)
			{
				gclass87_11.int_1 = GClass73.int_10 / 2 - 80;
				gclass87_6.int_1 = GClass73.int_10 / 2 + 10;
				gclass87_6.int_2 = (gclass87_11.int_2 = GClass73.int_11 - 25);
			}
			gclass87_1 = gclass87_11;
			gclass87_0 = gclass87_6;
		}

		public void method_0()
		{
			GClass50.smethod_8("Res switch");
			GClass109.smethod_1().method_51();
			int_6 = 0;
			gclass191_0.bool_0 = true;
			gclass191_1.bool_0 = false;
			if (GClass73.bool_5)
			{
				gclass191_0.bool_0 = false;
				int_6 = -1;
			}
			base.switchToMe();
		}

		protected void method_1()
		{
			GClass88 gClass = new GClass88("vMenu Login");
			gClass.method_0(new GClass87(mResources.registerNewAcc, this, 2004, null));
			if (!bool_11)
				gClass.method_0(new GClass87(mResources.selectServer, this, 1004, null));
			gClass.method_0(new GClass87(mResources.forgetPass, this, 1003, null));
			gClass.method_0(new GClass87(mResources.website, this, 1005, null));
			if (GClass1.smethod_8("lowGraphic") == 1)
				gClass.method_0(new GClass87(mResources.increase_vga, this, 10041, null));
			else
				gClass.method_0(new GClass87(mResources.decrease_vga, this, 10042, null));
			gClass.method_0(new GClass87(mResources.EXIT, GClass73.gclass73_0, 8885, null));
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		protected void method_2()
		{
			if (!gclass191_0.method_21().Equals(""))
			{
				gclass191_0.method_21().ToCharArray();
				if (!gclass191_1.method_21().Equals(""))
				{
					if (gclass191_0.method_21().Length < 5)
					{
						GClass73.smethod_30(mResources.accTooShort);
						return;
					}
					int num = 0;
					string text = null;
					if (mResources.language != 2)
						try
						{
							long.Parse(gclass191_0.method_21());
							if (gclass191_0.method_21().Length < 8 || gclass191_0.method_21().Length > 12 || (!gclass191_0.method_21().StartsWith("0") && !gclass191_0.method_21().StartsWith("84")))
								text = mResources.phoneInvalid;
							num = 1;
						}
						catch (Exception)
						{
							if (gclass191_0.method_21().IndexOf("@") == -1 || gclass191_0.method_21().IndexOf(".") == -1)
								text = mResources.emailInvalid;
							num = 0;
						}
					else
					{
						if (gclass191_0.method_21().IndexOf("@") == -1 || gclass191_0.method_21().IndexOf(".") == -1)
							text = mResources.emailInvalid;
						num = 0;
					}
					if (text != null)
						GClass73.smethod_30(text);
					else
						GClass73.gclass44_0.method_2(mResources.plsCheckAcc + ((num != 1) ? (mResources.email + ": ") : (mResources.phone + ": ")) + gclass191_0.method_21() + "\n" + mResources.password + ": " + gclass191_1.method_21(), new GClass87(mResources.ACCEPT, this, 4000, null), null, new GClass87(mResources.NO, GClass73.gclass73_0, 8882, null));
					GClass73.gclass42_0 = GClass73.gclass44_0;
				}
				else
					GClass73.smethod_30(mResources.passwordBlank);
			}
			else
				GClass73.smethod_30(mResources.userBlank);
		}

		protected void method_3(string user)
		{
		}

		public void method_4()
		{
			if (!string_0.Equals("") || string_0.Equals(""))
				;
			if (!GClass14.bool_1)
			{
				bool_10 = true;
				GClass73.smethod_4();
			}
			GClass73.smethod_33();
		}

		protected void method_5()
		{
			GClass88 gClass = new GClass88("vServer");
			if (bool_3)
				gClass.method_0(new GClass87("Server LOCAL", this, 20004, null));
			gClass.method_0(new GClass87("Server Bokken", this, 20001, null));
			gClass.method_0(new GClass87("Server Shuriken", this, 20002, null));
			gClass.method_0(new GClass87("Server Tessen (mới)", this, 20003, null));
			GClass73.gclass145_0.method_2(gClass, 0);
			if (method_7() != -1 && !GClass73.bool_5)
				GClass73.gclass145_0.int_0 = method_7();
		}

		protected void method_6(int index)
		{
			GClass1.smethod_9("indServer", index);
		}

		protected int method_7()
		{
			return GClass1.smethod_8("indServer");
		}

		public void method_8()
		{
		}

		public void method_9()
		{
		}

		public override void update()
		{
			gclass191_0.method_17();
			gclass191_1.method_17();
			gclass191_2.method_17();
			gclass191_3.method_17();
			gclass191_4.method_17();
			gclass191_5.method_17();
			gclass191_7.method_17();
			gclass191_8.method_17();
			gclass191_6.method_17();
			for (int i = 0; i < GClass93.gclass88_1.method_2(); i++)
			{
				((GClass93)GClass93.gclass88_1.method_3(i)).update();
			}
			if (bool_4 && !bool_5 && !bool_8 && !bool_6 && !bool_7)
			{
				bool_4 = false;
				GClass203.smethod_26();
				GClass7.smethod_0().method_115();
			}
			GClass144.int_22++;
			if (GClass144.int_22 > GClass73.int_10 * 3 + 100)
				GClass144.int_22 = 100;
			if (GClass96.gclass96_0 != null)
				return;
			GClass73.smethod_8("LGU1", 0);
			GClass73.smethod_8("LGU2", 0);
			GClass73.smethod_8("LGU3", 0);
			method_11();
			GClass73.smethod_8("LGU4", 0);
			GClass73.smethod_8("LGU5", 0);
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
			GClass73.smethod_8("LGU6", 0);
			if (int_25 >= 0 && GClass73.int_8 % 100 == 0)
				method_10();
			if (GClass73.bool_5)
			{
				if (!bool_2)
				{
					gclass87_1 = gclass87_11;
					gclass87_0 = gclass87_6;
				}
				else
				{
					gclass87_1 = gclass87_7;
					gclass87_0 = gclass87_9;
				}
			}
			else if (bool_2)
			{
				gclass87_1 = gclass87_7;
				gclass87_0 = gclass87_9;
			}
			else
			{
				gclass87_1 = gclass87_11;
				gclass87_0 = gclass87_6;
			}
		}

		private void method_10()
		{
			int_25++;
			if (int_25 >= mResources.tips.Length)
				int_25 = 0;
			if (GClass73.gclass42_0 == GClass73.gclass44_0 && GClass73.gclass44_0.bool_0)
				GClass73.gclass44_0.method_1(mResources.tips[int_25]);
		}

		public void method_11()
		{
			if (int_9 != int_8)
				int_8 += int_9 - int_8 >> 1;
		}

		public override void keyPress(int keyCode)
		{
			if (gclass191_0.bool_0)
				gclass191_0.method_10(keyCode);
			else if (gclass191_1.bool_0)
			{
				gclass191_1.method_10(keyCode);
			}
			else if (!gclass191_2.bool_0)
			{
				if (!gclass191_3.bool_0)
				{
					if (gclass191_4.bool_0)
						gclass191_4.method_10(keyCode);
					else if (gclass191_5.bool_0)
					{
						gclass191_5.method_10(keyCode);
					}
					else if (!gclass191_7.bool_0)
					{
						if (!gclass191_8.bool_0)
						{
							if (gclass191_6.bool_0)
								gclass191_6.method_10(keyCode);
						}
						else
							gclass191_8.method_10(keyCode);
					}
					else
					{
						gclass191_7.method_10(keyCode);
					}
				}
				else
					gclass191_3.method_10(keyCode);
			}
			else
			{
				gclass191_2.method_10(keyCode);
			}
			base.keyPress(keyCode);
		}

		public override void unLoad()
		{
			base.unLoad();
		}

		public override void paint(GClass122 g)
		{
			GClass73.smethod_8("PLG1", 1);
			GClass73.smethod_18(g);
			GClass73.smethod_8("PLG2", 2);
			int num = gclass191_0.int_1 - 50;
			if (GClass73.int_11 <= 220)
				num += 5;
			if (GClass96.gclass96_0 != null || GClass96.gclass96_1 != null)
				return;
			if (GClass73.gclass42_0 == null)
			{
				int_19 = 5;
				int num2 = 233;
				if (GClass73.int_10 < 260)
					int_19 = (GClass73.int_10 - 240) / 2;
				int_20 = (GClass73.int_11 - num2) / 2;
				if (GClass73.int_10 >= 200)
					_ = 180;
				else
					_ = 160;
				GClass45.smethod_4(g, int_19, int_20, 240, num2, -1, true);
				if (GClass73.int_11 > 160 && gclass70_0 != null)
					g.method_31(gclass70_0, GClass73.int_12, num, 3);
				GClass73.smethod_8("PLG4", 1);
				int num3 = 4;
				if (184 >= GClass73.int_10)
					num3--;
				gclass191_8.int_0 = int_19 + 10;
				gclass191_8.int_1 = int_20 + 15;
				gclass191_0.int_0 = gclass191_8.int_0;
				gclass191_0.int_1 = gclass191_8.int_1 + 30;
				gclass191_1.int_0 = int_19 + 10;
				gclass191_1.int_1 = gclass191_0.int_1 + 30;
				gclass191_2.int_0 = gclass191_1.int_0 + 75;
				gclass191_2.int_1 = gclass191_1.int_1;
				gclass191_3.int_0 = gclass191_2.int_0 + 75;
				gclass191_3.int_1 = gclass191_2.int_1;
				gclass191_4.int_0 = gclass191_0.int_0;
				gclass191_4.int_1 = gclass191_1.int_1 + 30;
				gclass191_5.int_0 = gclass191_0.int_0;
				gclass191_5.int_1 = gclass191_4.int_1 + 30;
				gclass191_6.int_0 = gclass191_0.int_0;
				gclass191_6.int_1 = gclass191_5.int_1 + 30;
				gclass191_7.int_0 = gclass191_0.int_0;
				gclass191_7.int_1 = gclass191_6.int_1 + 30;
				gclass191_0.method_13(g);
				gclass191_1.method_13(g);
				gclass191_2.method_13(g);
				gclass191_3.method_13(g);
				gclass191_4.method_13(g);
				gclass191_5.method_13(g);
				gclass191_6.method_13(g);
				gclass191_7.method_13(g);
				gclass191_8.method_13(g);
				if (GClass73.int_10 < 176)
				{
					GClass4.gclass4_7.method_6(g, mResources.acc + ":", gclass191_0.int_0 - 35, gclass191_0.int_1 + 7, 0);
					GClass4.gclass4_7.method_6(g, mResources.pwd + ":", gclass191_1.int_0 - 35, gclass191_1.int_1 + 7, 0);
					GClass4.gclass4_7.method_6(g, mResources.server + ": " + string_6, GClass73.int_10 / 2, gclass191_1.int_1 + 32, 2);
					if (!bool_2)
						;
				}
			}
			string st = GClass187.string_2;
			g.method_16(GClass73.int_23);
			g.method_15(GClass73.int_10 - 40, 4, 36, 11);
			GClass4.gclass4_16.method_6(g, st, GClass73.int_10 - 22, 4, GClass4.int_2);
			GClass73.smethod_6(g);
			if (GClass73.gclass42_0 == null)
			{
				if (GClass73.int_10 > 250)
				{
					GClass4.gclass4_3.method_10(g, "Dưới 18 tuổi", 260, 10, 0, GClass4.gclass4_6);
					GClass4.gclass4_3.method_10(g, "chỉ có thể chơi", 260, 25, 0, GClass4.gclass4_6);
					GClass4.gclass4_3.method_10(g, "180p 1 ngày", 260, 40, 0, GClass4.gclass4_6);
				}
				else
				{
					GClass4.gclass4_3.method_10(g, "Dưới 18 tuổi chỉ có thể chơi", GClass73.int_10 / 2, 5, 2, GClass4.gclass4_6);
					GClass4.gclass4_3.method_10(g, "180p 1 ngày", GClass73.int_10 / 2, 15, 2, GClass4.gclass4_6);
				}
			}
			base.paint(g);
		}

		private void method_12()
		{
			gclass191_0.bool_0 = false;
			gclass191_1.bool_0 = false;
			gclass191_2.bool_0 = false;
			gclass191_3.bool_0 = false;
			gclass191_4.bool_0 = false;
			gclass191_5.bool_0 = false;
			gclass191_6.bool_0 = false;
			gclass191_7.bool_0 = false;
			gclass191_8.bool_0 = false;
		}

		private void method_13()
		{
			method_12();
			switch (int_6)
			{
			case 0:
				gclass191_0.bool_0 = true;
				break;
			case 1:
				gclass191_1.bool_0 = true;
				break;
			case 2:
				gclass191_2.bool_0 = true;
				break;
			case 3:
				gclass191_3.bool_0 = true;
				break;
			case 4:
				gclass191_4.bool_0 = true;
				break;
			case 5:
				gclass191_5.bool_0 = true;
				break;
			case 6:
				gclass191_6.bool_0 = true;
				break;
			case 7:
				gclass191_7.bool_0 = true;
				break;
			case 8:
				gclass191_8.bool_0 = true;
				break;
			}
		}

		public override void updateKey()
		{
			if (bool_0)
				return;
			if (!GClass73.bool_5)
			{
				if (!gclass191_0.bool_0)
				{
					if (!gclass191_1.bool_0)
					{
						if (gclass191_2.bool_0)
							gclass87_2 = gclass191_2.gclass87_0;
						else if (!gclass191_3.bool_0)
						{
							if (!gclass191_4.bool_0)
							{
								if (!gclass191_5.bool_0)
								{
									if (!gclass191_6.bool_0)
									{
										if (gclass191_7.bool_0)
											gclass87_2 = gclass191_7.gclass87_0;
										else if (gclass191_8.bool_0)
										{
											gclass87_2 = gclass191_8.gclass87_0;
										}
									}
									else
										gclass87_2 = gclass191_6.gclass87_0;
								}
								else
									gclass87_2 = gclass191_5.gclass87_0;
							}
							else
								gclass87_2 = gclass191_4.gclass87_0;
						}
						else
						{
							gclass87_2 = gclass191_3.gclass87_0;
						}
					}
					else
						gclass87_2 = gclass191_1.gclass87_0;
				}
				else
					gclass87_2 = gclass191_0.gclass87_0;
			}
			if (!GClass73.bool_11[21])
			{
				if (GClass73.bool_11[22])
				{
					int_6++;
					if (int_6 > 8)
						int_6 = 0;
					method_13();
				}
			}
			else
			{
				int_6--;
				if (int_6 < 0)
					int_6 = 8;
				method_13();
			}
			if (GClass73.bool_11[21] || GClass73.bool_11[22])
			{
				GClass73.smethod_26();
				if (!bool_11 || bool_2)
				{
					if (int_6 != 1)
					{
						if (int_6 == 0)
						{
							gclass191_0.bool_0 = true;
							gclass191_1.bool_0 = false;
						}
						else
						{
							gclass191_0.bool_0 = false;
							gclass191_1.bool_0 = false;
						}
					}
					else
					{
						gclass191_0.bool_0 = false;
						gclass191_1.bool_0 = true;
					}
				}
			}
			if (!GClass73.bool_5)
			{
				if (bool_2)
				{
					gclass87_1 = gclass87_7;
					gclass87_0 = gclass87_9;
				}
				else
				{
					gclass87_1 = gclass87_11;
					gclass87_0 = gclass87_6;
				}
			}
			else if (!bool_2)
			{
				gclass87_1 = gclass87_11;
				gclass87_0 = gclass87_6;
			}
			else
			{
				gclass87_1 = gclass87_7;
				gclass87_0 = gclass87_9;
			}
			if (GClass73.bool_16)
			{
				if (!GClass73.smethod_24(gclass191_0.int_0, gclass191_0.int_1, gclass191_0.int_2, gclass191_0.int_3))
				{
					if (GClass73.smethod_24(gclass191_1.int_0, gclass191_1.int_1, gclass191_1.int_2, gclass191_1.int_3))
					{
						int_6 = 1;
						method_13();
					}
					else if (GClass73.smethod_24(gclass191_2.int_0, gclass191_2.int_1, gclass191_2.int_2, gclass191_2.int_3))
					{
						int_6 = 2;
						method_13();
					}
					else if (!GClass73.smethod_24(gclass191_3.int_0, gclass191_3.int_1, gclass191_3.int_2, gclass191_3.int_3))
					{
						if (!GClass73.smethod_24(gclass191_4.int_0, gclass191_4.int_1, gclass191_4.int_2, gclass191_4.int_3))
						{
							if (GClass73.smethod_24(gclass191_5.int_0, gclass191_5.int_1, gclass191_5.int_2, gclass191_5.int_3))
							{
								int_6 = 5;
								method_13();
							}
							else if (!GClass73.smethod_24(gclass191_6.int_0, gclass191_6.int_1, gclass191_6.int_2, gclass191_6.int_3))
							{
								if (GClass73.smethod_24(gclass191_7.int_0, gclass191_7.int_1, gclass191_7.int_2, gclass191_7.int_3))
								{
									int_6 = 7;
									method_13();
								}
								else if (GClass73.smethod_24(gclass191_8.int_0, gclass191_8.int_1, gclass191_8.int_2, gclass191_8.int_3))
								{
									int_6 = 8;
									method_13();
								}
							}
							else
							{
								int_6 = 6;
								method_13();
							}
						}
						else
						{
							int_6 = 4;
							method_13();
						}
					}
					else
					{
						int_6 = 3;
						method_13();
					}
				}
				else
				{
					int_6 = 0;
					method_13();
				}
			}
			base.updateKey();
			GClass73.smethod_26();
		}

		public void method_14()
		{
			int_8 = -50;
		}

		public void perform(int idAction, object p)
		{
			if (idAction > 2008)
			{
				if (idAction != 4000)
				{
					if (idAction == 10021)
						method_15();
				}
				else
					method_3(gclass191_0.method_21());
				return;
			}
			switch (idAction)
			{
			case 1000:
				try
				{
					GClass187.gclass187_0.method_3((string)p);
				}
				catch (Exception ex2)
				{
					ex2.StackTrace.ToString();
				}
				GClass73.smethod_29();
				return;
			case 1001:
				GClass73.smethod_29();
				bool_2 = false;
				return;
			case 1003:
				GClass14.smethod_0().close();
				GClass73.gclass134_0.switchToMe();
				return;
			case 1004:
				GClass134.smethod_3();
				GClass73.gclass134_0.switchToMe();
				return;
			case 1005:
				try
				{
					GClass187.gclass187_0.method_3("http://ngocrongonline.com");
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
				if (!bool_1)
					bool_1 = true;
				else
					bool_1 = false;
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
				if (!gclass191_1.method_21().Equals("") && !gclass191_2.method_21().Equals("") && !gclass191_3.method_21().Equals("") && !gclass191_4.method_21().Equals("") && !gclass191_5.method_21().Equals("") && !gclass191_6.method_21().Equals("") && !gclass191_7.method_21().Equals("") && !gclass191_8.method_21().Equals("") && !gclass191_0.method_21().Equals(""))
				{
					GClass73.smethod_30(mResources.PLEASEWAIT);
					GClass7.smethod_0().method_2(gclass191_1.method_21(), gclass191_2.method_21(), gclass191_3.method_21(), gclass191_4.method_21(), gclass191_5.method_21(), gclass191_6.method_21(), gclass191_7.method_21(), gclass191_8.method_21(), gclass191_0.method_21());
				}
				else
					GClass73.smethod_30("Vui lòng điền đầy đủ thông tin");
				break;
			case 2005:
			case 2006:
			case 2007:
				break;
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
			gclass191_1.bool_0 = false;
			gclass191_0.bool_0 = true;
			gclass87_0 = gclass87_8;
		}

		public void method_16()
		{
			GClass73.smethod_29();
			GClass73.smethod_30(mResources.regNote);
			bool_2 = true;
			gclass191_1.bool_0 = false;
			gclass191_0.bool_0 = true;
		}

		public void method_17()
		{
			if (GClass73.gclass133_0.bool_12)
			{
				GClass73.smethod_36(mResources.note, new GClass87(mResources.YES, GClass73.gclass76_0, 10019, null), new GClass87(mResources.NO, GClass73.gclass76_0, 10020, null));
				return;
			}
			GClass73.gclass73_0.method_9(GClass73.gclass133_0);
			GClass14.smethod_0().close();
		}
	}
}
