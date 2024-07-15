using System;
using ns0;
using ns1;

public class GClass6 : GInterface6
{
	public int int_0 = 0;

	public long long_0 = 0L;

	public GClass60 gclass60_0 = new GClass60();

	public const sbyte sbyte_0 = 0;

	public const sbyte sbyte_1 = 1;

	public const sbyte sbyte_2 = 2;

	public const sbyte sbyte_3 = 3;

	public const sbyte sbyte_4 = 4;

	public const sbyte sbyte_5 = 5;

	public static GClass76[] gclass76_0;

	public const sbyte sbyte_6 = 0;

	public const sbyte sbyte_7 = 1;

	public const sbyte sbyte_8 = 2;

	public const sbyte sbyte_9 = 3;

	public const sbyte sbyte_10 = 4;

	public const sbyte sbyte_11 = 5;

	public const sbyte sbyte_12 = 6;

	public const sbyte sbyte_13 = 7;

	public bool bool_0;

	public short short_0;

	public bool bool_1;

	public string string_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_2;

	public int int_4;

	public long long_1;

	public long long_2;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10 = 1;

	public int int_11 = 1;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public int int_22;

	public int int_23;

	public int int_24;

	public int int_25;

	public bool bool_3;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public bool bool_7;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public GClass122 gclass122_0 = new GClass122();

	public bool bool_11;

	public string string_1;

	public int int_26;

	public short short_1;

	public short short_2;

	public GClass124 gclass124_0;

	public int int_27;

	public int int_28;

	public int int_29;

	public sbyte sbyte_14;

	public sbyte sbyte_15;

	public bool bool_12;

	public bool bool_13;

	public static GClass122 gclass122_1 = new GClass122();

	public static GClass122 gclass122_2 = new GClass122();

	public bool bool_14;

	public int int_30;

	public int int_31;

	public int int_32;

	public int int_33;

	private bool bool_15;

	private int int_34;

	public bool bool_16 = true;

	private int int_35;

	private int int_36;

	public static GClass20 gclass20_0 = GClass14.smethod_43("/mainImage/myTexture2dmobHP.png");

	private bool bool_17;

	private int int_37;

	private int int_38;

	private int int_39;

	public int int_40;

	public bool bool_18 = true;

	public int[] int_41 = new int[12]
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
		1, 1
	};

	public int[] int_42 = new int[15]
	{
		1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
		3, 3, 2, 2, 2
	};

	public int[] int_43 = new int[7] { 1, 1, 2, 2, 3, 3, 2 };

	public int[] int_44 = new int[3] { 4, 5, 6 };

	public int[] int_45 = new int[3] { 7, 8, 9 };

	public int[] int_46 = new int[1];

	private int int_47 = 8421504;

	public int int_48 = 24;

	public int int_49 = 24;

	public int int_50 = 100;

	public int int_51 = 100;

	public byte byte_0 = 4;

	public GClass20 gclass20_1;

	private int int_52;

	public bool bool_19;

	private sbyte[] sbyte_16 = new sbyte[2] { -1, 1 };

	public GClass124 gclass124_1;

	public bool bool_20;

	public GClass6 gclass6_0;

	public int int_53;

	public bool bool_21;

	public bool bool_22;

	private int[][] int_54 = new int[6][]
	{
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 },
		new int[8] { 0, 0, 0, 0, 1, 1, 1, 1 }
	};

	private bool bool_23 = true;

	public GClass6()
	{
	}

	public GClass6(int mobId, bool isDisable, bool isDontMove, bool isFire, bool isIce, bool isWind, int templateId, int sys, int hp, sbyte level, int maxp, short pointx, short pointy, sbyte status, sbyte levelBoss)
	{
		bool_5 = isDisable;
		bool_6 = isDontMove;
		bool_7 = isFire;
		bool_8 = isIce;
		bool_9 = isWind;
		int_29 = sys;
		int_25 = mobId;
		int_26 = templateId;
		int_6 = hp;
		sbyte_15 = level;
		int_16 = (int_8 = (short_1 = pointx));
		int_17 = (int_9 = (short_2 = pointy));
		int_12 = status;
		if (templateId != 70)
		{
			method_2();
			method_1();
		}
		if (!smethod_0(templateId + string.Empty))
			gclass122_2.method_0(templateId + string.Empty);
		int_7 = maxp;
		sbyte_14 = levelBoss;
		method_20();
		int_51 = (int)(hp * 100L / int_7);
		bool_10 = false;
		int_32 = pointx;
		int_33 = pointy;
		if (!method_10())
		{
			if (method_11())
			{
				int_41 = new int[12]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
					1, 1
				};
				int_42 = new int[16]
				{
					1, 1, 1, 1, 2, 2, 2, 2, 1, 1,
					1, 1, 3, 3, 3, 3
				};
				int_43 = new int[8] { 1, 1, 2, 2, 1, 1, 3, 3 };
				int_44 = new int[11]
				{
					4, 4, 4, 5, 5, 5, 6, 6, 6, 6,
					6
				};
				int_45 = new int[11]
				{
					7, 7, 7, 8, 8, 8, 9, 9, 9, 9,
					9
				};
			}
			else if (method_9())
			{
				int_41 = new int[12]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
					1, 1
				};
				int_42 = new int[16]
				{
					2, 2, 3, 3, 2, 2, 4, 4, 2, 2,
					3, 3, 2, 2, 4, 4
				};
				int_43 = new int[8] { 2, 2, 3, 3, 2, 2, 4, 4 };
				int_44 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
				int_45 = new int[4] { 5, 12, 13, 14 };
			}
			else
			{
				int_41 = new int[12]
				{
					0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
					1, 1
				};
				int_42 = new int[15]
				{
					1, 1, 1, 1, 2, 2, 2, 2, 3, 3,
					3, 3, 2, 2, 2
				};
				int_43 = new int[7] { 1, 1, 2, 2, 3, 3, 2 };
				int_44 = new int[3] { 4, 5, 6 };
				int_45 = new int[3] { 7, 8, 9 };
			}
		}
		else
		{
			int_41 = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			int_42 = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			int_43 = new int[17]
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 1,
				2, 2, 2, 2, 2, 2, 2
			};
			int_44 = new int[12]
			{
				3, 3, 3, 3, 4, 4, 4, 4, 5, 5,
				5, 5
			};
			int_45 = new int[12]
			{
				3, 3, 3, 3, 4, 4, 4, 4, 5, 5,
				5, 5
			};
		}
	}

	public bool method_0()
	{
		return this is GClass9 || this is GClass8 || this is GClass7 || this is GClass10;
	}

	public void method_1()
	{
		if (gclass76_0[int_26].gclass194_0 != null)
		{
			int_20 = gclass76_0[int_26].gclass194_0.int_2;
			int_21 = gclass76_0[int_26].gclass194_0.int_3;
			return;
		}
		gclass76_0[int_26].gclass194_0 = new GClass194();
		string text = "/Mob/" + int_26;
		if (GClass79.smethod_0(text) != null)
		{
			gclass76_0[int_26].gclass194_0.method_3(text + "/data");
			gclass76_0[int_26].gclass194_0.gclass20_0 = GClass14.smethod_43(text + "/img.png");
		}
		else
			GClass2.smethod_0().method_48(int_26);
		if (gclass122_1.method_2() > 15)
		{
			gclass76_0[int.Parse((string)gclass122_1.method_3(0))].gclass194_0 = null;
			gclass122_1.method_7(0);
		}
		gclass122_1.method_0(int_26 + string.Empty);
	}

	public virtual void setBody(short id)
	{
		bool_0 = true;
		short_0 = id;
	}

	public virtual void clearBody()
	{
		bool_0 = false;
	}

	public static bool smethod_0(string id)
	{
		for (int i = 0; i < gclass122_2.method_2(); i++)
		{
			if (((string)gclass122_2.method_3(i)).Equals(id))
				return true;
		}
		return false;
	}

	public void method_2()
	{
		int num = 0;
		for (int i = 0; i < gclass76_0.Length; i++)
		{
			if (gclass76_0[i].gclass194_0 != null)
				num++;
		}
		if (num < 10)
			return;
		for (int j = 0; j < gclass76_0.Length; j++)
		{
			if (gclass76_0[j].gclass194_0 != null && num > 5)
				gclass76_0[j].gclass194_0 = null;
		}
	}

	public void method_3(int[] array)
	{
		if (int_35 > array.Length - 1)
			int_35 = 0;
		int_36 = array[int_35];
		int_35++;
	}

	private void method_4()
	{
		int num = GClass137.sbyte_0;
		int_32 = int_8;
		int_34 = 0;
		if (int_33 <= 0 || GClass137.smethod_28(int_32, int_33, 2))
			return;
		if (GClass137.smethod_26(int_32 / num, int_33 / num) != 0)
		{
			if (GClass137.smethod_26(int_32 / num, int_33 / num) != 0 && !GClass137.smethod_28(int_32, int_33, 2))
			{
				int_32 = int_8;
				int_33 = int_9;
				bool_15 = false;
			}
		}
		else
			bool_15 = true;
		while (bool_15 && int_34 < 10)
		{
			int_34++;
			int_33 += 24;
			if (GClass137.smethod_28(int_32, int_33, 2))
			{
				if (int_33 % 24 != 0)
					int_33 -= int_33 % 24;
				break;
			}
		}
	}

	private void method_5(GClass193 gclass193_0)
	{
		int num = GClass137.sbyte_0;
		if (!GClass137.smethod_28(int_32 + num / 2, int_33 + 1, 4))
		{
			if (GClass137.smethod_26((int_32 - num / 2) / num, (int_33 + 1) / num) != 0)
			{
				if (GClass137.smethod_26((int_32 + num / 2) / num, (int_33 + 1) / num) == 0)
					gclass193_0.method_5(int_32 / num * num, (int_33 - 30) / num * num, num, 100);
				else if (GClass137.smethod_28(int_32 - num / 2, int_33 + 1, 8))
				{
					gclass193_0.method_5(int_32 / 24 * num, (int_33 - 30) / num * num, num, 100);
				}
			}
			else
				gclass193_0.method_5(int_32 / num * num, (int_33 - 30) / num * num, 100, 100);
		}
		else
			gclass193_0.method_5(int_32 / num * num, (int_33 - 30) / num * num, num, 100);
		gclass193_0.method_31(GClass137.gclass20_10, int_32, int_33, 3);
		gclass193_0.method_5(GClass167.int_22, GClass167.int_23 - GClass14.int_58, GClass167.int_6, GClass167.int_7 + 2 * GClass14.int_58);
	}

	public void method_6()
	{
		if (int_40 == 0 && GClass14.int_8 % 25 == 0)
			GClass91.smethod_2(114, this, 1);
		if (int_40 == 1 && GClass14.int_8 % 4 == 0)
			GClass91.smethod_2(132, this, 1);
		if (int_40 == 2 && GClass14.int_8 % 7 == 0)
			GClass91.smethod_2(131, this, 1);
	}

	public virtual void update()
	{
		GClass48.smethod_0().method_9(this);
		gclass60_0.method_0();
		if (bool_14)
			return;
		if (GClass137.int_37 <= 138 && GClass137.int_37 >= 135)
		{
			for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
			{
				if (GClass167.gclass122_9.method_3(i) is GClass6 gClass && gClass.bool_10 && GClass167.gclass122_9.method_1(gClass))
				{
					if (GClass47.smethod_0().int_3 == gClass.int_25 && GClass47.smethod_0().int_3 != -1)
					{
						GClass47.smethod_0().int_3 = -1;
						GClass47.smethod_0().bool_1 = false;
						GClass167.gclass130_0.method_7("Quái này đã chết! Hủy khóa mục tiêu!", 0);
					}
					GClass167.gclass122_9.method_8(i);
				}
			}
		}
		if (GClass137.int_37 >= 53 && GClass137.int_37 <= 62)
		{
			for (int j = 0; j < GClass167.gclass122_9.method_2(); j++)
			{
				if (GClass167.gclass122_9.method_3(j) is GClass6 gClass2 && gClass2.bool_10 && GClass167.gclass122_9.method_1(gClass2) && gClass2.method_16().sbyte_0 != 22)
					GClass167.gclass122_9.method_8(j);
			}
		}
		method_27();
		if (bool_21)
		{
			if (!gclass60_0.bool_6)
			{
				gclass60_0.bool_6 = true;
				gclass60_0.long_5 = GClass77.smethod_18();
				if (gclass60_0.int_5 <= 0)
					gclass60_0.int_5 = 7;
			}
			if (GClass14.int_8 % 5 == 0)
				GClass91.smethod_0(113, int_8, int_9, 1);
		}
		else
		{
			gclass60_0.bool_6 = false;
			gclass60_0.int_5 = 0;
		}
		if (bool_22)
		{
			if (!gclass60_0.bool_1)
			{
				gclass60_0.bool_1 = true;
				gclass60_0.long_1 = GClass77.smethod_18();
				if (gclass60_0.int_1 <= 0)
					gclass60_0.int_1 = 13;
			}
			if (GClass14.int_8 % 10 == 0)
				GClass98.smethod_0(new GClass85(41, int_8, int_9, 3, 1, 1));
		}
		else
		{
			gclass60_0.bool_1 = false;
			gclass60_0.int_1 = 0;
		}
		if (!GClass14.bool_1 && int_12 != 1 && int_12 != 0 && !GClass14.bool_1 && GClass14.int_8 % (15 + int_25 * 2) == 0)
		{
			for (int k = 0; k < GClass167.gclass122_5.method_2(); k++)
			{
				GClass124 gClass3 = (GClass124)GClass167.gclass122_5.method_3(k);
				if (gClass3 != null && gClass3.bool_46 && gClass3.int_63 == 32)
				{
					GClass124 gClass4 = new GClass124();
					gClass4.int_4 = gClass3.int_4;
					gClass4.int_5 = gClass3.int_5 - gClass3.int_58;
					if (gClass3.int_14 == 0)
						GClass89.smethod_0(int_8 + int_10 * int_20, int_9, method_19(), -100, -100, gClass4, 25);
				}
			}
			if (GClass124.smethod_1().bool_46 && GClass124.smethod_1().int_63 == 32)
			{
				GClass124 gClass5 = new GClass124();
				gClass5.int_4 = GClass124.smethod_1().int_4;
				gClass5.int_5 = GClass124.smethod_1().int_5 - GClass124.smethod_1().int_58;
				if (GClass124.smethod_1().int_14 == 0)
					GClass89.smethod_0(int_8 + int_10 * int_20, int_9, method_19(), -100, -100, gClass5, 25);
			}
		}
		if (int_5 != 0 && GClass14.int_8 % 5 == 0)
			GClass98.smethod_0(new GClass85(int_5, int_8, int_9 + 24, 3, 5, 1));
		if (bool_2)
		{
			gclass60_0.bool_10 = true;
			if (!bool_10)
			{
				gclass60_0.long_8 = GClass77.smethod_18();
				gclass60_0.int_8 = int_4 + 1;
			}
			else
			{
				int_4 = 0;
				gclass60_0.bool_10 = false;
				gclass60_0.int_8 = 0;
			}
			if (GClass14.int_8 % 5 == 0)
				GClass91.smethod_0(113, int_8, int_9, 1);
			long num = GClass77.smethod_18();
			if (num - long_1 >= 1000L)
			{
				int_4--;
				long_1 = num;
				if (int_4 < 0)
				{
					bool_2 = false;
					int_4 = 0;
				}
			}
			if (method_28())
				int_36 = int_46[GClass14.int_8 % int_46.Length];
			else if (!method_10())
			{
				if (method_11())
				{
					if (GClass14.int_8 % 20 > 5)
						int_36 = 11;
					else
						int_36 = 10;
				}
				else if (!method_9())
				{
					if (GClass14.int_8 % 20 > 5)
						int_36 = 11;
					else
						int_36 = 10;
				}
				else if (GClass14.int_8 % 20 > 5)
				{
					int_36 = 1;
				}
				else
				{
					int_36 = 15;
				}
			}
			else
			{
				int_36 = int_44[GClass14.int_8 % int_44.Length];
			}
		}
		else
		{
			gclass60_0.bool_10 = false;
			gclass60_0.int_8 = 0;
		}
		if (!method_18())
			return;
		if (bool_16)
			method_4();
		if (gclass122_0 == null && gclass76_0[int_26].sbyte_1 != 0)
			return;
		if (int_12 != 3 && bool_18)
		{
			if (gclass124_0 == null)
			{
				if (gclass6_0 != null)
					gclass6_0.method_7();
			}
			else
				gclass124_0.method_112(int_27, int_28, false, true);
			bool_18 = false;
		}
		if (sbyte_14 > 0)
			method_6();
		switch (int_12)
		{
		case 1:
			bool_5 = false;
			bool_6 = false;
			bool_7 = false;
			bool_8 = false;
			bool_9 = false;
			int_9 += int_13;
			if (GClass14.int_8 % 2 == 0)
			{
				if (int_14 <= 1)
				{
					if (int_14 < -1)
						int_14++;
				}
				else
					int_14--;
			}
			int_8 += int_14;
			if (!method_28())
			{
				if (!method_10())
				{
					if (!method_11())
					{
						if (method_9())
							int_36 = 15;
						else
							int_36 = 11;
					}
					else
						int_36 = 11;
				}
				else
					int_36 = int_44[GClass14.int_8 % int_44.Length];
			}
			else
				int_36 = int_46[GClass14.int_8 % int_46.Length];
			if (bool_10)
			{
				bool_10 = false;
				if (bool_13)
				{
					for (int l = 0; l < GClass167.gclass122_9.method_2(); l++)
					{
						if (((GClass6)GClass167.gclass122_9.method_3(l)).int_25 == int_25)
							GClass167.gclass122_9.method_7(l);
					}
				}
				int_13 = 0;
				int_14 = 0;
				int_9 = 0;
				int_8 = 0;
				int_6 = method_16().int_0;
				int_12 = 0;
				int_24 = 0;
				break;
			}
			if ((GClass137.smethod_27(int_8, int_9) & 2) != 2)
				int_13++;
			else
			{
				int_13 = ((int_13 > 4) ? (-4) : (-int_13));
				if (int_15 == 0)
					int_15 = 16;
			}
			if (int_15 > 0)
			{
				int_15--;
				if (int_15 == 0)
					bool_10 = true;
			}
			break;
		case 2:
			if (int_5 == 0 && !bool_2 && !bool_21 && !bool_22)
			{
				int_24 = 0;
				method_13();
			}
			break;
		case 3:
			if (int_5 == 0 && !bool_21 && !bool_22 && !bool_2)
				method_14();
			break;
		case 4:
			if (int_5 == 0 && !bool_21 && !bool_22 && !bool_2)
			{
				int_24 = 0;
				int_13++;
				if (int_13 > 40 + int_25 % 5)
				{
					int_9 -= 2;
					int_12 = 5;
					int_13 = 0;
				}
			}
			break;
		case 5:
			if (int_5 != 0 || bool_21 || bool_22)
				break;
			if (!bool_2)
			{
				int_24 = 0;
				method_15();
			}
			else if (gclass76_0[int_26].sbyte_3 == 4)
			{
				int_39++;
				int_37++;
				int_38 += ((!bool_17) ? 1 : (-1));
				if (int_37 == 10)
				{
					int_37 = 0;
					bool_17 = !bool_17;
				}
			}
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
			method_12();
			break;
		}
	}

	public void method_7()
	{
		if (int_6 > 0 && int_12 != 3 && int_12 != 7)
		{
			int_24 = 4;
			int_12 = 7;
			if (method_16().sbyte_3 != 0 && GClass191.smethod_28(int_8 - int_16) < 30)
				int_8 -= 10 * int_10;
		}
	}

	public static GClass7 smethod_1()
	{
		for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
		{
			GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
			if (gClass is GClass7)
				return (GClass7)gClass;
		}
		return null;
	}

	public static GClass8 smethod_2()
	{
		int num = 0;
		GClass6 gClass;
		while (true)
		{
			if (num < GClass167.gclass122_9.method_2())
			{
				gClass = (GClass6)GClass167.gclass122_9.method_3(num);
				if (gClass is GClass8)
					break;
				num++;
				continue;
			}
			return null;
		}
		return (GClass8)gClass;
	}

	public static GClass9 smethod_3()
	{
		int num = 0;
		GClass6 gClass;
		while (true)
		{
			if (num < GClass167.gclass122_9.method_2())
			{
				gClass = (GClass6)GClass167.gclass122_9.method_3(num);
				if (gClass is GClass9)
					break;
				num++;
				continue;
			}
			return null;
		}
		return (GClass9)gClass;
	}

	public static GClass10 smethod_4(sbyte idBoss)
	{
		GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(idBoss);
		if (!(gClass is GClass10))
			return null;
		return (GClass10)gClass;
	}

	public static void smethod_5()
	{
		for (int i = 0; i < GClass167.gclass122_9.method_2(); i++)
		{
			GClass6 gClass = (GClass6)GClass167.gclass122_9.method_3(i);
			if (gClass is GClass7)
			{
				GClass167.gclass122_9.method_8(gClass);
				break;
			}
		}
	}

	public void method_8(GClass124 cFocus)
	{
		bool_18 = true;
		gclass6_0 = null;
		gclass124_0 = cFocus;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_35 = 0;
		int_10 = ((cFocus.int_4 > int_8) ? 1 : (-1));
		int num = cFocus.int_4;
		int num2 = cFocus.int_5;
		if (GClass191.smethod_28(num - int_8) < int_20 * 2 && GClass191.smethod_28(num2 - int_9) < int_21 * 2)
			int_15 = 0;
		else
			int_15 = 1;
	}

	private bool method_9()
	{
		if ((int_26 < 58 || int_26 > 65) && int_26 != 67 && int_26 != 68)
			return false;
		return true;
	}

	private bool method_10()
	{
		return int_26 == 76;
	}

	private bool method_11()
	{
		if (int_26 >= 73 && !method_10())
			return true;
		return false;
	}

	private void method_12()
	{
		if (GClass66.smethod_0().bool_4)
			return;
		if (!bool_18 && GClass14.int_8 % 4 == 0)
		{
			if (!method_28())
			{
				if (method_10())
					int_36 = int_44[GClass14.int_8 % int_44.Length];
				else if (method_11())
				{
					if (int_36 == 10)
						int_36 = 11;
					else
						int_36 = 10;
				}
				else if (method_9())
				{
					if (int_36 != 1)
						int_36 = 1;
					else
						int_36 = 15;
				}
				else if (int_36 != 10)
				{
					int_36 = 10;
				}
				else
				{
					int_36 = 11;
				}
			}
			else
				int_36 = int_46[GClass14.int_8 % int_46.Length];
		}
		int_24--;
		if (int_24 > 0 || (!method_28() && !method_10() && (!method_11() || int_36 != 11) && (!method_9() || int_36 != 15) && (int_26 >= 58 || int_36 != 11)))
		{
			if (gclass76_0[int_26].sbyte_3 != 0 && gclass124_1 != null)
			{
				int num = -gclass124_1.int_12 << 1;
				if (int_8 > int_16 - gclass76_0[int_26].sbyte_1 && int_8 < int_16 + gclass76_0[int_26].sbyte_1)
					int_8 -= num;
			}
			return;
		}
		if ((gclass124_1 != null && bool_20) || int_6 == 0)
		{
			int_12 = 1;
			int_14 = gclass124_1.int_12 << 1;
			int_13 = -3;
			int_15 = 0;
		}
		else
		{
			int_12 = 5;
			if (gclass124_1 != null)
			{
				int_10 = -gclass124_1.int_12;
				if (GClass191.smethod_28(int_8 - gclass124_1.int_4) < 24)
					int_12 = 2;
			}
			int_15 = 0;
			int_14 = 0;
			int_13 = 0;
			int_24 = 0;
		}
		gclass124_1 = null;
	}

	private void method_13()
	{
		if (GClass66.smethod_0().bool_4)
			return;
		method_3(int_41);
		sbyte b = gclass76_0[int_26].sbyte_3;
		if ((uint)b <= 3u)
		{
			int_13++;
			if (int_13 > 10 + int_25 % 10 && (gclass124_0 == null || GClass191.smethod_28(gclass124_0.int_4 - int_8) > 80) && (gclass6_0 == null || GClass191.smethod_28(gclass6_0.int_8 - int_8) > 80))
				int_12 = 5;
		}
		else if ((uint)(b - 4) <= 1u)
		{
			int_13++;
			if (int_13 > int_25 % 3 && (gclass124_0 == null || GClass191.smethod_28(gclass124_0.int_4 - int_8) > 80) && (gclass6_0 == null || GClass191.smethod_28(gclass6_0.int_8 - int_8) > 80))
				int_12 = 5;
		}
		if (gclass124_0 == null || GClass14.int_8 % (10 + int_13 % 20) != 0)
		{
			if (gclass6_0 != null && GClass14.int_8 % (10 + int_13 % 20) == 0)
			{
				if (gclass6_0.int_8 > int_8)
					int_10 = 1;
				else
					int_10 = -1;
			}
		}
		else if (gclass124_0.int_4 > int_8)
		{
			int_10 = 1;
		}
		else
		{
			int_10 = -1;
		}
		if (int_53 > 0)
		{
			int_53--;
			int_12 = 2;
		}
	}

	public void method_14()
	{
		if (GClass66.smethod_0().bool_4)
			return;
		int[] array = ((int_15 != 0) ? int_45 : int_44);
		if (int_35 < array.Length)
		{
			method_3(array);
			if (int_8 >= GClass167.int_22 && int_8 <= GClass167.int_22 + GClass14.int_10 && int_15 == 0 && GClass14.int_8 % 2 == 0)
				GClass147.smethod_1().method_4(false, 0.05f);
		}
		if (int_13 == 0)
		{
			int num = 0;
			int num2 = 0;
			num = ((gclass124_0 == null) ? gclass6_0.int_8 : gclass124_0.int_4);
			num2 = ((gclass124_0 == null) ? gclass6_0.int_9 : gclass124_0.int_5);
			if (!method_11())
			{
				if (int_8 > int_16 + gclass76_0[int_26].sbyte_1)
					int_13 = 1;
				if (int_8 < int_16 - gclass76_0[int_26].sbyte_1)
					int_13 = 1;
			}
			if ((gclass76_0[int_26].sbyte_3 == 4 || gclass76_0[int_26].sbyte_3 == 5) && !bool_6)
				int_9 += (num2 - int_9) / 20;
			int_14++;
			if (int_14 > array.Length - 1 || int_13 == 1)
			{
				int_13 = 1;
				if (int_15 == 0)
				{
					if (gclass124_0 == null)
						gclass6_0.method_7();
					else
						gclass124_0.method_112(int_27, int_28, false, true);
					bool_18 = false;
				}
				else
				{
					if (gclass124_0 == null)
					{
						GClass124 gClass = new GClass124();
						gClass.int_4 = gclass6_0.int_8;
						gClass.int_5 = gclass6_0.int_9;
						gClass.int_13 = -100;
						GClass89.smethod_0(int_8 + int_10 * int_20, int_9, method_19(), int_27, int_28, gClass, method_16().sbyte_4);
					}
					else
						GClass89.smethod_0(int_8 + int_10 * int_20, int_9, method_19(), int_27, int_28, gclass124_0, method_16().sbyte_4);
					bool_18 = false;
				}
			}
			int_10 = ((int_8 < num) ? 1 : (-1));
		}
		else if (int_13 == 1)
		{
			if (gclass76_0[int_26].sbyte_3 == 0 || bool_6 || bool_8 || bool_9)
				;
			if (int_35 == array.Length)
			{
				int_12 = 2;
				int_13 = 0;
				int_14 = 0;
				int_35 = 0;
			}
		}
		if (int_35 == 5 && gclass124_0 != null && gclass124_0.int_13 == GClass124.smethod_1().int_13)
		{
			if (int_26 == 88 && int_15 != 0)
				GClass167.int_120 = 2;
			if (int_26 == 89)
				GClass167.int_120 = 2;
		}
	}

	public void method_15()
	{
		if (GClass66.smethod_0().bool_4)
			return;
		int num = 0;
		try
		{
			if (bool_20)
			{
				int_12 = 1;
				int_14 = gclass124_1.int_12 << 3;
				int_13 = -5;
				int_15 = 0;
			}
			num = 1;
			if (bool_8)
				return;
			if (!bool_6 && !bool_9)
			{
				switch (gclass76_0[int_26].sbyte_3)
				{
				case 0:
					if (!method_10())
						int_36 = 0;
					else
						int_36 = int_41[GClass14.int_8 % int_41.Length];
					num = 2;
					break;
				case 1:
				case 2:
				case 3:
				{
					num = 3;
					sbyte b2 = gclass76_0[int_26].sbyte_2;
					if (b2 != 1)
					{
						if (b2 > 2)
							b2 += (sbyte)(int_25 % 2);
						else if (GClass14.int_8 % 2 == 1)
						{
							b2--;
						}
					}
					else if (GClass14.int_8 % 2 == 1)
					{
						break;
					}
					int_8 += b2 * int_10;
					if (int_8 > int_16 + gclass76_0[int_26].sbyte_1)
						int_10 = -1;
					else if (int_8 < int_16 - gclass76_0[int_26].sbyte_1)
					{
						int_10 = 1;
					}
					if (GClass191.smethod_28(int_8 - GClass124.smethod_1().int_4) < 40 && GClass191.smethod_28(int_8 - int_16) < gclass76_0[int_26].sbyte_1)
					{
						int_10 = ((int_8 <= GClass124.smethod_1().int_4) ? 1 : (-1));
						if (GClass191.smethod_28(int_8 - GClass124.smethod_1().int_4) < 20)
							int_8 -= int_10 * 10;
						int_12 = 2;
						int_53 = 20;
					}
					method_3((int_20 <= 30) ? int_43 : int_42);
					break;
				}
				case 4:
				{
					num = 4;
					sbyte b3 = (sbyte)(gclass76_0[int_26].sbyte_2 + (sbyte)(int_25 % 2));
					int_8 += b3 * int_10;
					if (GClass14.int_8 % 10 > 2)
						int_9 += b3 * int_11;
					b3 += (sbyte)((GClass14.int_8 + int_25) % 2);
					if (int_8 > int_16 + gclass76_0[int_26].sbyte_1)
					{
						int_10 = -1;
						int_12 = 2;
						int_53 = GClass14.int_8 % 20 + 20;
						int_13 = 0;
					}
					else if (int_8 < int_16 - gclass76_0[int_26].sbyte_1)
					{
						int_10 = 1;
						int_12 = 2;
						int_53 = GClass14.int_8 % 20 + 20;
						int_13 = 0;
					}
					if (int_9 <= int_17 + 24)
					{
						if (int_9 < int_17 - (20 + GClass14.int_8 % 10))
							int_11 = 1;
					}
					else
						int_11 = -1;
					method_3(int_42);
					break;
				}
				case 5:
				{
					num = 5;
					sbyte b = (sbyte)(gclass76_0[int_26].sbyte_2 + (sbyte)(int_25 % 2));
					int_8 += b * int_10;
					b += (sbyte)((GClass14.int_8 + int_25) % 2);
					if (GClass14.int_8 % 10 > 2)
						int_9 += b * int_11;
					if (int_8 <= int_16 + gclass76_0[int_26].sbyte_1)
					{
						if (int_8 < int_16 - gclass76_0[int_26].sbyte_1)
						{
							int_10 = 1;
							int_12 = 2;
							int_53 = GClass14.int_8 % 20 + 20;
							int_13 = 0;
						}
					}
					else
					{
						int_10 = -1;
						int_12 = 2;
						int_53 = GClass14.int_8 % 20 + 20;
						int_13 = 0;
					}
					if (int_9 <= int_17 + 24)
					{
						if (int_9 < int_17 - (20 + GClass14.int_8 % 10))
							int_11 = 1;
					}
					else
						int_11 = -1;
					if (GClass137.smethod_28(int_8, int_9, 2))
					{
						if (GClass14.int_8 % 10 > 5)
						{
							int_9 = GClass137.smethod_32(int_9);
							int_12 = 4;
							int_13 = 0;
							int_11 = -1;
						}
						else
							int_11 = -1;
					}
					break;
				}
				}
			}
			else
				method_3(int_41);
		}
		catch (Exception)
		{
			GClass92.smethod_0("lineee: " + num);
		}
	}

	public GClass76 method_16()
	{
		return gclass76_0[int_26];
	}

	public bool method_17()
	{
		if (int_8 < GClass167.int_22)
			return false;
		if (int_8 > GClass167.int_22 + GClass167.int_6)
			return false;
		if (int_9 < GClass167.int_23)
			return false;
		if (int_9 <= GClass167.int_23 + GClass167.int_7 + 30)
		{
			if (gclass76_0[int_26] == null)
				return false;
			if (gclass76_0[int_26].gclass194_0 == null)
				return false;
			if (gclass76_0[int_26].gclass194_0.gclass20_0 != null)
			{
				if (int_12 == 0)
					return false;
				return true;
			}
			return false;
		}
		return false;
	}

	public bool method_18()
	{
		if (gclass76_0[int_26] != null)
		{
			if (gclass76_0[int_26].gclass194_0 != null)
			{
				if (int_12 != 0)
					return true;
				return false;
			}
			return false;
		}
		return false;
	}

	public bool method_19()
	{
		if (bool_12 || sbyte_14 > 0)
			return true;
		return false;
	}

	public void method_20()
	{
		int_48 = (int)(int_6 * 100L / int_7 * int_49) / 100;
		int_50 = (int)(int_6 * 100L / int_7);
		if (int_50 == 100)
			int_51 = int_50;
		if (int_50 >= 100)
			int_51 = int_50;
		int_52 = 0;
		if (int_50 >= 30)
		{
			if (int_50 < 60)
			{
				int_47 = 16744448;
				gclass20_1 = GClass167.gclass20_36;
			}
			else
			{
				int_47 = 11992374;
				gclass20_1 = GClass167.gclass20_38;
			}
		}
		else
		{
			int_47 = 15473700;
			gclass20_1 = GClass167.gclass20_35;
		}
	}

	public virtual void paint(GClass193 g)
	{
		if (GClass66.smethod_0().bool_7 || bool_19)
			return;
		if (bool_14)
		{
			if (bool_0)
				GClass72.smethod_6(g, short_0, int_30, int_31, (int_10 != 1) ? 2 : 0, GClass193.int_5 | GClass193.int_0);
			else
				gclass76_0[int_26].gclass194_0.method_9(g, int_36, int_30, int_31, (int_10 != 1) ? 1 : 0, 2);
			return;
		}
		if (bool_16 && int_12 != 0)
			method_5(g);
		if (!method_17() || (int_12 == 1 && int_15 > 0 && GClass14.int_8 % 3 == 0))
			return;
		g.method_1(0, GClass14.int_58);
		if (!bool_0)
			gclass76_0[int_26].gclass194_0.method_9(g, int_36, int_8, int_9 + int_38, (int_10 != 1) ? 1 : 0, 2);
		else
			GClass72.smethod_6(g, short_0, int_8, int_9 + int_38 - 9, (int_10 != 1) ? 2 : 0, GClass193.int_5 | GClass193.int_0);
		g.method_1(0, -GClass14.int_58);
		if (GClass124.smethod_1().gclass6_0 == null || !GClass124.smethod_1().gclass6_0.Equals(this) || int_12 == 1 || int_6 <= 0 || gclass20_1 == null)
			return;
		int num = GClass193.smethod_0(gclass20_1);
		int h = GClass193.smethod_1(gclass20_1);
		int num2 = num * int_50 / 100;
		int w = num2;
		if (int_51 >= int_50)
		{
			w = num * (int_51 -= ((GClass14.int_8 % 6 <= 3) ? int_52 : int_52++)) / 100;
			if (int_51 <= 0)
				int_51 = 0;
			if (int_51 < int_50)
				int_51 = int_50;
			if (int_52 >= 3)
				int_52 = 3;
		}
		g.method_31(GClass167.gclass20_37, int_8 - (num >> 1), int_9 - int_21 - 5, GClass193.int_4 | GClass193.int_2);
		g.method_16(16777215);
		g.method_15(int_8 - (num >> 1), int_9 - int_21 - 5, w, 2);
		g.method_23(gclass20_1, 0, 0, num2, h, 0, int_8 - (num >> 1), int_9 - int_21 - 5, GClass193.int_4 | GClass193.int_2);
	}

	public int method_21()
	{
		return 16711680;
	}

	public void method_22()
	{
		GClass47.smethod_0().int_20 = 0;
		GClass48.smethod_0().method_8(this);
		int_6 = 0;
		bool_20 = true;
		int_6 = 0;
		int_12 = 1;
		GClass191.smethod_8("MOB DIEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEe");
		int_13 = -3;
		int_14 = -int_10;
		int_15 = 0;
	}

	public void method_23(GClass6 mobToAttack)
	{
		gclass6_0 = mobToAttack;
		bool_18 = true;
		gclass124_0 = null;
		int_13 = 0;
		int_14 = 0;
		int_12 = 3;
		int_35 = 0;
		int_10 = ((mobToAttack.int_8 > int_8) ? 1 : (-1));
		int num = mobToAttack.int_8;
		int num2 = mobToAttack.int_9;
		if (GClass191.smethod_28(num - int_8) < int_20 * 2 && GClass191.smethod_28(num2 - int_9) < int_21 * 2)
		{
			if (int_8 >= num)
				int_8 = num + int_20;
			else
				int_8 = num - int_20;
			int_15 = 0;
		}
		else
			int_15 = 1;
	}

	public int getX()
	{
		return int_8;
	}

	public int getY()
	{
		return int_9;
	}

	public int getH()
	{
		return int_21;
	}

	public int getW()
	{
		return int_20;
	}

	public void stopMoving()
	{
		if (int_12 == 5)
		{
			int_12 = 2;
			int_15 = 0;
			int_14 = 0;
			int_13 = 0;
			int_53 = 50;
		}
	}

	public bool isInvisible()
	{
		return int_12 == 0 || int_12 == 1;
	}

	public void method_24()
	{
		if (int_5 != 0)
			int_5 = 0;
		gclass60_0.bool_7 = false;
		gclass60_0.bool_8 = false;
	}

	public void method_25()
	{
		bool_21 = false;
	}

	public void method_26()
	{
		bool_22 = false;
	}

	public void method_27()
	{
		if (!GClass66.smethod_0().bool_4 && bool_23 && method_28() && gclass76_0[int_26].gclass194_0 != null)
		{
			int_54 = (int[][])GClass93.gclass175_0.method_0(int_26 + string.Empty);
			int_41 = int_54[0];
			int_42 = int_54[1];
			int_43 = int_54[2];
			int_44 = int_54[3];
			int_45 = int_54[4];
			int_46 = int_54[5];
			bool_23 = false;
		}
	}

	private bool method_28()
	{
		if (gclass76_0[int_26].gclass194_0 != null && gclass76_0[int_26].gclass194_0.int_1 == 2)
			return true;
		return false;
	}
}
