using System;

namespace ns0
{
	public class GClass89 : GClass85, GInterface4
	{
		public static GClass2 gclass2_2 = GClass39.smethod_43("/mainImage/shadowBig.png");

		public static GClass167 gclass167_0;

		public int int_55;

		public int int_56;

		public bool bool_24;

		public bool bool_25;

		public int int_57;

		public int int_58;

		private bool bool_26;

		private int int_59;

		public bool bool_27 = true;

		private int int_60;

		private int int_61;

		private bool bool_28;

		private int int_62;

		private int int_63;

		private int int_64;

		public int int_65;

		private GClass58 gclass58_2;

		private bool bool_29;

		private bool bool_30;

		private int int_66;

		public bool bool_31;

		private int int_67;

		public bool bool_32 = true;

		private int int_68;

		private GClass58[] gclass58_3;

		private int[] int_69;

		private sbyte sbyte_17;

		public int[] int_70 = new int[12]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1
		};

		public int[] int_71 = new int[17]
		{
			37, 37, 37, 38, 38, 38, 39, 39, 40, 40,
			40, 39, 39, 39, 38, 38, 38
		};

		public int[] int_72 = new int[15]
		{
			1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
			3, 3, 2, 2, 2
		};

		public int[] int_73 = new int[7] { 1, 1, 2, 2, 3, 3, 2 };

		public int[] int_74 = new int[12]
		{
			0, 0, 34, 34, 35, 35, 36, 36, 2, 2,
			1, 1
		};

		public int[] int_75 = new int[23]
		{
			0, 0, 0, 4, 4, 6, 6, 9, 9, 10,
			10, 13, 13, 15, 15, 17, 17, 19, 19, 21,
			21, 23, 23
		};

		public int[] int_76 = new int[24]
		{
			0, 0, 1, 1, 4, 4, 6, 6, 8, 8,
			25, 25, 26, 26, 28, 28, 30, 30, 32, 32,
			2, 2, 1, 1
		};

		public int[] int_77 = new int[20]
		{
			37, 37, 5, 5, 7, 7, 11, 11, 14, 14,
			16, 16, 18, 18, 20, 20, 22, 22, 24, 24
		};

		public int[] int_78 = new int[21]
		{
			37, 37, 37, 38, 38, 5, 5, 7, 7, 11,
			11, 27, 27, 29, 29, 31, 31, 33, 33, 38,
			38
		};

		public int[] int_79 = new int[8] { 8, 8, 9, 9, 10, 10, 12, 12 };

		public int[] int_80 = new int[24]
		{
			0, 0, 1, 1, 4, 4, 6, 6, 8, 8,
			25, 25, 26, 26, 28, 28, 30, 30, 32, 32,
			2, 2, 1, 1
		};

		private bool bool_33;

		private sbyte[] sbyte_18 = new sbyte[2] { -1, 1 };

		public GClass58 gclass58_4;

		public bool bool_34;

		public GClass85 gclass85_1;

		public int int_81;

		public bool bool_35;

		public bool bool_36;

		public GClass89(int id, short px, short py, int templateID, int hp, int maxhp, int s)
		{
			int_16 = (int_8 = px + 20);
			int_17 = (int_9 = py);
			int_25 = id;
			int_6 = hp;
			int_7 = maxhp;
			int_26 = templateID;
			int_49 = 100;
			byte_0 = 6;
			int_48 = int_49;
			method_20();
			if (s == 0)
				method_30();
			if (s == 1)
				method_29();
			if (s == 2)
			{
				method_29();
				bool_24 = true;
			}
			int_12 = 2;
		}

		public void method_29()
		{
			gclass167_0 = null;
			gclass167_0 = new GClass167();
			string patch = "/x" + GClass76.int_12 + "/effectdata/" + 100 + "/data";
			try
			{
				gclass167_0.method_4(patch);
				gclass167_0.gclass2_0 = GClass39.smethod_43("/effectdata/" + 100 + "/img.png");
			}
			catch (Exception)
			{
				GClass166.smethod_0().method_48(int_26);
			}
			int_12 = 2;
			int_20 = gclass167_0.int_2;
			int_21 = gclass167_0.int_3;
		}

		public void method_30()
		{
			gclass167_0 = null;
			gclass167_0 = new GClass167();
			string patch = "/x" + GClass76.int_12 + "/effectdata/" + 101 + "/data";
			try
			{
				gclass167_0.method_4(patch);
				gclass167_0.gclass2_0 = GClass39.smethod_43("/effectdata/" + 101 + "/img.png");
				GClass56.smethod_8("read xong data");
			}
			catch (Exception)
			{
				GClass166.smethod_0().method_48(int_26);
			}
			int_20 = gclass167_0.int_2;
			int_21 = gclass167_0.int_3;
		}

		public override void setBody(short id)
		{
			bool_0 = true;
			short_0 = id;
		}

		public override void clearBody()
		{
			bool_0 = false;
		}

		public static bool smethod_6(string id)
		{
			int num = 0;
			while (true)
			{
				if (num < GClass85.gclass63_2.method_2())
				{
					if (((string)GClass85.gclass63_2.method_3(num)).Equals(id))
						break;
					num++;
					continue;
				}
				return false;
			}
			return true;
		}

		public void method_31(int[] array)
		{
			int_60++;
			if (int_60 > array.Length - 1)
				int_60 = 0;
			int_61 = array[int_60];
		}

		private void method_32()
		{
			int num = GClass1.sbyte_0;
			int_57 = int_8;
			int_59 = 0;
			if (int_58 <= 0 || GClass1.smethod_27(int_57, int_58, 2))
				return;
			if (GClass1.smethod_25(int_57 / num, int_58 / num) == 0)
				bool_26 = true;
			else if (GClass1.smethod_25(int_57 / num, int_58 / num) != 0 && !GClass1.smethod_27(int_57, int_58, 2))
			{
				int_57 = int_8;
				int_58 = int_9;
				bool_26 = false;
			}
			while (bool_26 && int_59 < 10)
			{
				int_59++;
				int_58 += 24;
				if (GClass1.smethod_27(int_57, int_58, 2))
				{
					if (int_58 % 24 != 0)
						int_58 -= int_58 % 24;
					break;
				}
			}
		}

		private void method_33(GClass76 gclass76_0)
		{
			gclass76_0.method_31(gclass2_2, int_57, int_17, 3);
			gclass76_0.method_5(GClass154.int_22, GClass154.int_23 - GClass39.int_58, GClass154.int_6, GClass154.int_7 + 2 * GClass39.int_58);
		}

		public void method_34()
		{
		}

		public override void update()
		{
			if (!method_47())
				return;
			method_32();
			switch (int_12)
			{
			case 0:
			case 1:
				method_35();
				break;
			case 2:
				method_41();
				break;
			case 3:
				method_44();
				break;
			case 4:
				int_24 = 0;
				method_36();
				break;
			case 5:
				int_24 = 0;
				method_45();
				break;
			case 6:
				int_24 = 0;
				int_13++;
				int_9 += int_13;
				if (int_9 >= int_17)
				{
					int_9 = int_17;
					int_13 = 0;
					int_12 = 5;
				}
				break;
			case 7:
				method_40();
				break;
			}
		}

		private void method_35()
		{
			method_31((!bool_24) ? int_70 : int_71);
			if (GClass39.int_8 % 5 == 0)
				GClass71.smethod_0(167, GClass56.smethod_19(int_8 - getW() / 2, int_8 + getW() / 2), GClass56.smethod_19(getY() + getH() / 2, getY() + getH()), 1);
			if (int_8 != int_16 || int_9 != int_17)
			{
				int_8 += (int_16 - int_8) / 4;
				int_9 += (int_17 - int_9) / 4;
			}
		}

		private void method_36()
		{
			if (bool_29)
			{
				int_66++;
				int_9 -= int_66;
				method_31(int_79);
				if (int_9 <= -500)
				{
					bool_29 = false;
					bool_30 = true;
					int_66 = 0;
				}
			}
			if (bool_30)
			{
				int_8 = int_55;
				int_66 += 2;
				int_9 += int_66;
				method_31(int_80);
				if (int_9 > int_17)
				{
					int_9 = int_17;
					bool_30 = false;
					int_66 = 0;
					int_12 = 2;
					GClass154.int_118 = 10;
					bool_33 = true;
				}
			}
		}

		public void method_37()
		{
		}

		public void method_38(GClass58 cFocus)
		{
			bool_32 = true;
			gclass85_1 = null;
			gclass58_0 = cFocus;
			int_13 = 0;
			int_14 = 0;
			int_12 = 3;
			int_60 = 0;
			int_10 = ((cFocus.int_4 > int_8) ? 1 : (-1));
			int num = cFocus.int_4;
			int num2 = cFocus.int_5;
			if (GClass56.smethod_28(num - int_8) < int_20 * 2 && GClass56.smethod_28(num2 - int_9) < int_21 * 2)
			{
				if (int_8 < num)
					int_8 = num - int_20;
				else
					int_8 = num + int_20;
				int_15 = 0;
			}
			else
				int_15 = 1;
		}

		private bool method_39()
		{
			if ((int_26 >= 58 && int_26 <= 65) || int_26 == 67 || int_26 == 68)
				return true;
			return false;
		}

		private void method_40()
		{
		}

		private void method_41()
		{
			method_31((!bool_24) ? int_70 : int_71);
			if (int_8 != int_16 || int_9 != int_17)
			{
				int_8 += (int_16 - int_8) / 4;
				int_9 += (int_17 - int_9) / 4;
			}
		}

		public void method_42()
		{
			int_12 = 4;
			bool_29 = true;
		}

		public void method_43(GClass58[] cAttack, int[] dame, sbyte type)
		{
			gclass58_3 = cAttack;
			int_69 = dame;
			sbyte_17 = type;
			int_60 = 0;
			if (type < 3)
				int_12 = 3;
			if (type == 3)
			{
				bool_29 = true;
				int_12 = 4;
			}
			if (type == 4)
			{
				for (int i = 0; i < gclass58_3.Length; i++)
				{
					gclass58_3[i].method_110(int_69[i], 0, false, false);
				}
			}
			if (type == 7)
				int_12 = 3;
		}

		public void method_44()
		{
			if (sbyte_17 == 7)
			{
				if (int_60 > 8)
					int_60 = 8;
				method_31(int_74);
				if (GClass39.int_8 % 4 == 0)
					GClass71.smethod_0(70, int_8 + ((int_10 != 1) ? (-15) : 15), int_9 - 40, 1);
			}
			if (sbyte_17 == 0)
			{
				if (int_60 == int_74.Length - 1)
					int_12 = 2;
				int_10 = ((int_8 < gclass58_3[0].int_4) ? 1 : (-1));
				method_31(int_74);
				if (int_60 == 8)
				{
					for (int i = 0; i < gclass58_3.Length; i++)
					{
						GClass73.smethod_0(int_8 + ((int_10 != 1) ? (-45) : 45), int_9 - 30, true, int_69[i], 0, gclass58_3[i], 24);
					}
				}
			}
			if (sbyte_17 == 1)
			{
				if (int_60 == ((!bool_24) ? (int_75.Length - 1) : (int_77.Length - 1)))
					int_12 = 2;
				int_10 = ((int_8 < gclass58_3[0].int_4) ? 1 : (-1));
				method_31((!bool_24) ? int_75 : int_77);
				int_8 += (gclass58_3[0].int_4 - int_8) / 4;
				int_9 += (gclass58_3[0].int_5 - int_9) / 4;
				if (int_60 == 18)
				{
					for (int j = 0; j < gclass58_3.Length; j++)
					{
						gclass58_3[j].method_110(int_69[j], 0, false, false);
						GClass71.smethod_0(102, gclass58_3[j].int_4, gclass58_3[j].int_5, 1);
					}
				}
			}
			if (sbyte_17 == 8)
				;
			if (sbyte_17 != 2)
				return;
			if (int_60 == ((!bool_24) ? (int_76.Length - 1) : (int_78.Length - 1)))
				int_12 = 2;
			int_10 = ((int_8 < gclass58_3[0].int_4) ? 1 : (-1));
			method_31((!bool_24) ? int_76 : int_78);
			if (int_60 == 13)
			{
				GClass154.int_118 = 10;
				bool_33 = true;
				for (int k = 0; k < gclass58_3.Length; k++)
				{
					gclass58_3[k].method_110(int_69[k], 0, false, false);
				}
			}
		}

		public void method_45()
		{
		}

		public bool method_46()
		{
			if (int_8 < GClass154.int_22)
				return false;
			if (int_8 > GClass154.int_22 + GClass154.int_6)
				return false;
			if (int_9 < GClass154.int_23)
				return false;
			if (int_9 > GClass154.int_23 + GClass154.int_7 + 30)
				return false;
			if (int_12 == 0)
				return false;
			return true;
		}

		public bool method_47()
		{
			if (int_12 == 0)
				return false;
			return true;
		}

		public bool method_48()
		{
			if (bool_12 || sbyte_14 > 0)
				return true;
			return false;
		}

		public override void paint(GClass76 g)
		{
			if (gclass167_0 == null || bool_19)
				return;
			if (bool_14)
			{
				if (!bool_0)
					gclass167_0.method_9(g, int_61, int_30, int_31, (int_10 != 1) ? 1 : 0, 2);
				else
					GClass96.smethod_6(g, short_0, int_30, int_31, (int_10 != 1) ? 2 : 0, GClass76.int_5 | GClass76.int_0);
				return;
			}
			if (bool_27 && int_12 != 0)
				method_33(g);
			g.method_1(0, GClass39.int_58);
			if (!bool_0)
				gclass167_0.method_9(g, int_61, int_8, int_9 + int_63, (int_10 != 1) ? 1 : 0, 2);
			else
				GClass96.smethod_6(g, short_0, int_8, int_9 + int_63 - 9, (int_10 != 1) ? 2 : 0, GClass76.int_5 | GClass76.int_0);
			g.method_1(0, -GClass39.int_58);
			int num = GClass76.smethod_0(gclass2_1);
			int h = GClass76.smethod_1(gclass2_1);
			int num2 = num;
			int num3 = num;
			int num4 = int_8 - num;
			int y = int_9 - int_21 - 5;
			int num5 = num * 2 * int_50 / 100;
			if (num5 > num2)
			{
				num3 = num5 - num2;
				if (num3 <= 0)
					num3 = 0;
			}
			else
			{
				num2 = num5;
				num3 = 0;
			}
			g.method_31(GClass154.gclass2_37, num4, y, GClass76.int_4 | GClass76.int_2);
			g.method_31(GClass154.gclass2_37, num4 + num, y, GClass76.int_4 | GClass76.int_2);
			g.method_23(gclass2_1, 0, 0, num2, h, 0, num4, y, GClass76.int_4 | GClass76.int_2);
			g.method_23(gclass2_1, 0, 0, num3, h, 0, num4 + num, y, GClass76.int_4 | GClass76.int_2);
			if (bool_33)
			{
				GClass56.smethod_8("type= " + sbyte_17);
				int_67++;
				GClass81.smethod_0(new GClass33((sbyte_17 != 2) ? 22 : 19, int_8 + int_67 * 50, int_9 + 25, 2, 1, -1));
				GClass81.smethod_0(new GClass33((sbyte_17 != 2) ? 22 : 19, int_8 - int_67 * 50, int_9 + 25, 2, 1, -1));
				if (int_67 == 50)
				{
					int_67 = 0;
					bool_33 = false;
				}
			}
		}

		public int method_49()
		{
			return 16711680;
		}

		public void method_50()
		{
			int_6 = 0;
			bool_34 = true;
			int_6 = 0;
			int_12 = 1;
			int_13 = -3;
			int_14 = -int_10;
			int_15 = 0;
		}

		public void method_51(GClass85 mobToAttack)
		{
			gclass85_1 = mobToAttack;
			bool_32 = true;
			gclass58_0 = null;
			int_13 = 0;
			int_14 = 0;
			int_12 = 3;
			int_60 = 0;
			int_10 = ((mobToAttack.int_8 > int_8) ? 1 : (-1));
			int num = mobToAttack.int_8;
			int num2 = mobToAttack.int_9;
			if (GClass56.smethod_28(num - int_8) < int_20 * 2 && GClass56.smethod_28(num2 - int_9) < int_21 * 2)
			{
				if (int_8 < num)
					int_8 = num - int_20;
				else
					int_8 = num + int_20;
				int_15 = 0;
			}
			else
				int_15 = 1;
		}

		public new int getX()
		{
			return int_8;
		}

		public new int getY()
		{
			return (!bool_24) ? (int_9 - 60) : (int_9 - 20);
		}

		public new int getH()
		{
			return 40;
		}

		public new int getW()
		{
			return 60;
		}

		public new void stopMoving()
		{
			if (int_12 == 5)
			{
				int_12 = 2;
				int_15 = 0;
				int_14 = 0;
				int_13 = 0;
				int_81 = 50;
			}
		}

		public new bool isInvisible()
		{
			return int_12 == 0 || int_12 == 1;
		}

		public void method_52()
		{
			if (int_5 != 0)
				int_5 = 0;
		}

		public void method_53()
		{
			bool_35 = false;
		}

		public void method_54()
		{
			bool_36 = false;
		}
	}
}
