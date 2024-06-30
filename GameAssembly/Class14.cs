using System;
using System.Collections.Generic;
using System.IO;
using ns1;

internal class Class14 : GInterface0
{
	public struct Struct38
	{
		public string string_0;

		public List<int> list_0;

		public Struct38(string string_1, List<int> list_1)
		{
			string_0 = string_1;
			list_0 = list_1;
		}
	}

	private static Class14 class14_0;

	public int int_0 = 100;

	public int int_1;

	public List<int> list_0;

	private int int_2;

	public bool bool_0;

	private bool bool_1;

	private long long_0;

	private long jQoocnKlPy;

	public bool bool_2;

	public bool bool_3 = false;

	public bool bool_4;

	public int int_3 = -1;

	public int int_4;

	public static Class14 smethod_0()
	{
		return (class14_0 != null) ? class14_0 : (class14_0 = new Class14());
	}

	public void method_0()
	{
		try
		{
			if (GClass39.gclass145_0 == GClass153.gclass153_0 || GClass58.bool_33 || GClass65.bool_5 || GClass58.bool_35)
				return;
			if (GClass1.int_37 == 21 + GClass58.smethod_1().int_14 && GClass171.smethod_0().bool_0 && !bool_4)
			{
				for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
				{
					GClass134 gClass = (GClass134)GClass154.gclass63_6.method_3(i);
					if (GClass154.gclass63_6.method_2() != 0)
					{
						if ((gClass.int_8 == GClass58.smethod_1().int_13 || gClass.int_8 == -1) && gClass.gclass118_0.short_0 == 74)
						{
							GClass58.smethod_1().gclass134_0 = gClass;
							GClass166.smethod_0().method_74(GClass58.smethod_1().gclass134_0.int_9);
							bool_4 = true;
							method_1(1000);
							return;
						}
						continue;
					}
					bool_4 = true;
					return;
				}
			}
			if (method_2() || GClass178.smethod_0().bool_1)
				return;
			if (bool_2)
			{
				method_1(int_0);
				bool_2 = false;
				return;
			}
			if (bool_0)
			{
				GClass178.smethod_0().dictionary_0 = null;
				list_0 = null;
				bool_0 = false;
				return;
			}
			if (list_0 == null)
			{
				if (GClass178.smethod_0().dictionary_0 == null)
				{
					GClass178.smethod_0().method_2();
					return;
				}
				list_0 = GClass190.smethod_0().method_0(GClass1.int_37, int_1);
				int_2 = 0;
				if (list_0 == null)
				{
					method_8();
					return;
				}
			}
			if ((GClass1.int_37 == list_0[list_0.Count - 1] || GClass1.int_37 == int_1) && !GClass178.smethod_8())
			{
				if (int_3 != -1 && GClass1.int_39 != int_3)
				{
					method_1(1000);
					if (GClass154.smethod_8().int_63[int_3] < (GClass177.smethod_0().method_5() ? 25 : 15))
						GClass166.smethod_0().method_42(int_3, -1);
				}
				else
				{
					int_3 = ((GClass1.int_39 != int_3 || int_3 == -1) ? int_3 : (-1));
					method_8();
				}
			}
			else if (GClass1.int_37 == list_0[int_2])
			{
				if (GClass178.smethod_8())
				{
					GClass166.smethod_0().method_76();
					bool_0 = true;
					bool_2 = true;
					list_0 = null;
				}
				else if (GClass178.smethod_9())
				{
					method_10(list_0[int_2 + 1]);
					bool_2 = true;
				}
				method_1(600);
			}
			else if (GClass1.int_37 == list_0[int_2 + 1])
			{
				int_2++;
			}
			else
			{
				bool_0 = true;
				list_0 = null;
			}
		}
		catch (Exception ex)
		{
			GClass188.smethod_0("Data/Errors/XmapErrorUpdate.txt", ex.ToString());
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction == 2)
				method_7((int)p);
		}
		else
			method_4((List<int>)p);
	}

	public void method_1(int int_5)
	{
		bool_1 = true;
		long_0 = GClass138.smethod_18();
		jQoocnKlPy = int_5;
	}

	private bool method_2()
	{
		if (bool_1 && GClass138.smethod_18() - long_0 >= jQoocnKlPy)
			bool_1 = false;
		return bool_1;
	}

	public void ivEoIuqQfu()
	{
		GClass39.gclass45_1 = new GClass45();
		GClass39.gclass45_1.method_50();
		GClass178.smethod_0().method_4();
		GClass198.smethod_0().method_1(0);
		GClass39.gclass45_0.int_29 = 3;
		GClass39.gclass45_0.int_41 = GClass178.smethod_0().list_0.Count;
		GClass39.gclass45_0.method_50();
	}

	public void method_3()
	{
		GClass178.smethod_0().method_4();
		GClass63 gClass = new GClass63();
		foreach (GStruct0 item in GClass178.smethod_0().list_0)
		{
			gClass.method_0(new GClass14(item.string_0, smethod_0(), 1, item.list_0));
		}
		GClass39.gclass0_0.method_2(gClass, 0);
	}

	public void method_4(List<int> list_1)
	{
		GClass178.smethod_0().method_4();
		GClass63 gClass = new GClass63();
		foreach (int item in list_1)
		{
			gClass.method_0(new GClass14(method_5(item), smethod_0(), 2, item));
		}
		GClass39.gclass0_0.method_2(gClass, 0);
	}

	public string method_5(int int_5)
	{
		string text = "";
		switch (int_5)
		{
		default:
			if (int_5 != 129)
				goto case 111;
			return (mResources.language == 0) ? "Đại hội võ thuật 23" : "23rd World Martial Arena";
		case 105:
			return (mResources.language == 0) ? "Cánh đồng tuyết" : "Snow Field";
		case 106:
			return (mResources.language == 0) ? "Rừng tuyết" : "Snow Forest";
		case 107:
			return (mResources.language == 0) ? "Núi tuyết" : "Snow Mountain";
		case 108:
			return (mResources.language == 0) ? "Dòng sông băng" : "Frozen River";
		case 109:
			return (mResources.language == 0) ? "Rừng băng" : "Frozen Forest";
		case 110:
			return (mResources.language == 0) ? "Hang băng" : "Frozen Cave";
		case 111:
		case 112:
			return GClass1.string_2[int_5];
		case 113:
			return (mResources.language == 0) ? "Võ đài siêu hạng" : "Super Rank";
		}
	}

	public void method_6(List<int> list_1)
	{
		GClass171.smethod_0().bool_1 = true;
		int count = list_1.Count;
		GClass39.gclass45_0.int_41 = count;
		GClass39.gclass45_0.string_4 = new string[count];
		GClass39.gclass45_0.string_5 = new string[count];
		for (int i = 0; i < count; i++)
		{
			string text = method_5(list_1[i]);
			GClass39.gclass45_0.string_4[i] = list_1[i] + ": " + text;
			GClass39.gclass45_0.string_5[i] = "";
		}
		GClass39.gclass45_0.method_6();
		GClass39.gclass45_0.method_50();
	}

	public void method_7(int int_5)
	{
		if ((int_5 == 153 || (int_5 >= 156 && int_5 <= 159)) && GClass58.smethod_1().gclass21_0 == null)
		{
			GClass154.gclass210_0.method_7((GClass192.int_0 == 0) ? "Mày chưa có bang mà đòi vào à?" : "You don't have clan to enter this place!", 0);
			method_8();
			return;
		}
		if (int_5 >= 92 && int_5 <= 102 && ((GClass1.int_37 <= 102 && GClass1.int_37 >= 92) || GClass1.int_37 == 103))
		{
			if (GClass171.smethod_0().bool_3)
				GClass171.smethod_0().bool_3 = false;
			if (GClass171.smethod_0().bool_4)
				GClass171.smethod_0().bool_4 = false;
		}
		bool_4 = false;
		int_1 = int_5;
		GClass171.smethod_0().bool_0 = true;
	}

	public void method_8()
	{
		if (!GClass171.smethod_0().bool_3)
			GClass171.smethod_0().bool_3 = true;
		if (!GClass171.smethod_0().bool_4)
			GClass171.smethod_0().bool_4 = true;
		GClass171.smethod_0().bool_0 = false;
		bool_0 = false;
		GClass178.smethod_0().dictionary_0 = null;
		list_0 = null;
		bool_4 = false;
	}

	public void method_9()
	{
		GClass171.smethod_0().int_0 = GClass1.int_37;
	}

	private void method_10(int int_5)
	{
		List<GStruct11> list = GClass178.smethod_1(GClass1.int_37);
		if (list != null)
		{
			foreach (GStruct11 item in list)
			{
				if (item.int_0 == int_5)
				{
					method_11(item);
					return;
				}
			}
		}
		GClass154.gclass210_0.method_7("Lỗi tại dữ liệu", 0);
	}

	private void method_11(GStruct11 gstruct11_0)
	{
		switch (gstruct11_0.genum3_0)
		{
		case GEnum3.const_0:
			method_13(gstruct11_0);
			break;
		case GEnum3.const_1:
			method_16(gstruct11_0);
			break;
		case GEnum3.const_2:
			method_17(gstruct11_0);
			break;
		case GEnum3.const_3:
			method_18(gstruct11_0);
			break;
		case GEnum3.const_4:
			method_19(gstruct11_0);
			break;
		case GEnum3.const_5:
			method_12(gstruct11_0);
			break;
		}
	}

	private void method_12(GStruct11 gstruct11_0)
	{
		int num = gstruct11_0.int_1[0];
		if (gstruct11_0.int_0 == 146)
		{
			GClass166.smethod_0().method_20(0, 1, -1, (short)num);
			GClass39.smethod_1().method_10(-5);
		}
		else if (gstruct11_0.int_0 == 176)
		{
			GClass166.smethod_0().method_20(0, 1, -1, (short)num);
			if (GClass39.gclass0_0 != null && GClass39.gclass0_0.bool_0)
				GClass39.smethod_1().method_10(-5);
		}
		else if (gstruct11_0.int_0 == 177)
		{
			GClass166.smethod_0().method_20(0, 1, -1, (short)num);
			if (GClass39.gclass0_0 != null && GClass39.gclass0_0.bool_0)
				GClass39.smethod_1().method_10(-5);
		}
		else
		{
			GClass166.smethod_0().method_20(0, 1, -1, (short)num);
		}
	}

	private void method_13(GStruct11 gstruct11_0)
	{
		GClass48 gClass = GClass178.smethod_5(gstruct11_0.int_0);
		if (GClass1.int_37 == 16 && gstruct11_0.int_0 == 15)
			gClass?.gclass24_0.method_4(1);
		else if (gClass != null)
		{
			int num = GClass178.smethod_6(gClass);
			int num2 = GClass178.smethod_7(gClass);
			if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, num, num2) > 10)
				method_15(num, num2);
			else if (GClass1.smethod_34() != null)
			{
				method_24(gClass);
			}
		}
	}

	public void method_14()
	{
		if (GClass1.int_37 == 27)
		{
			method_10(28);
			bool_2 = true;
			int_4 = 0;
		}
		else if (GClass1.int_37 == 29)
		{
			method_10(28);
			bool_2 = true;
			int_4 = 1;
		}
		else if (int_4 == 0)
		{
			method_10(29);
			bool_2 = true;
		}
		else if (int_4 == 1)
		{
			method_10(27);
			bool_2 = true;
		}
	}

	public void method_15(int int_5, int int_6)
	{
		if (GClass171.smethod_0().bool_0 || (GClass26.smethod_0(GClass58.smethod_1().int_4 - int_5) > 576 && GClass1.smethod_27(int_5, int_6, 2)))
		{
			GClass58.smethod_1().int_4 = int_5;
			GClass58.smethod_1().int_5 = int_6;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = int_5;
			GClass58.smethod_1().int_5 = int_6 + 1;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = int_5;
			GClass58.smethod_1().int_5 = int_6;
			GClass166.smethod_0().method_44();
			return;
		}
		int num = int_5 - GClass58.smethod_1().int_4;
		int num2 = GClass26.smethod_0(num);
		int num3 = ((num > 0) ? 1 : (-1));
		for (int i = 0; i < num2; i++)
		{
			if (!GClass1.smethod_27(GClass58.smethod_1().int_4 + num3 * 48, GClass58.smethod_1().int_5, 2))
			{
				int num4 = 96;
				int num5 = 0;
				while (num5 < 50)
				{
					num4 += 24;
					if (GClass1.smethod_27(GClass58.smethod_1().int_4 + num3 * 48, num4, 2))
					{
						if (num4 % 24 != 0)
							num4 -= num4 % 24;
						if (num4 < GClass58.smethod_1().int_5 || GClass1.smethod_27(GClass58.smethod_1().int_4 + num3 * 48, 0, 4) || GClass1.smethod_27(GClass58.smethod_1().int_4 + num3 * 48, 0, 8))
							GClass58.smethod_1().int_5 = num4;
					}
					else
						num5++;
				}
			}
			GClass58.smethod_1().int_4 += num3 * 48;
			GClass166.smethod_0().method_44();
		}
		GClass58.smethod_1().int_4 += num3 * num2;
		GClass58.smethod_1().int_5 = int_6;
		GClass166.smethod_0().method_44();
	}

	private void method_16(GStruct11 gstruct11_0)
	{
		int num = gstruct11_0.int_1[0];
		if (GClass154.smethod_13((short)num) == null)
		{
			method_14();
			return;
		}
		if ((num >= 30 && num <= 36) || num == 12)
		{
			for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
			{
				if (GClass154.gclass63_10.method_3(i) is GClass59 gClass && gClass.gclass90_0.int_0 == num && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
				{
					GClass58.smethod_1().int_4 = gClass.int_4;
					GClass58.smethod_1().int_5 = gClass.int_5 - 3;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = gClass.int_4;
					GClass58.smethod_1().int_5 = gClass.int_5;
					GClass166.smethod_0().method_44();
					GClass58.smethod_1().int_4 = gClass.int_4;
					GClass58.smethod_1().int_5 = gClass.int_5 - 3;
					GClass166.smethod_0().method_44();
					return;
				}
			}
		}
		if ((!GClass39.gclass0_0.bool_0 && GClass39.gclass0_0 != null) || GClass39.gclass0_0 == null)
		{
			GClass166.smethod_0().method_60(num);
			GClass198.smethod_0().method_0();
		}
		else
		{
			if (GClass39.gclass0_0 == null || !GClass39.gclass0_0.bool_0)
				return;
			int num2 = 0;
			while (true)
			{
				if (num2 >= GClass39.gclass0_0.gclass63_0.method_2())
					return;
				GClass14 gClass2 = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(num2);
				if (File.Exists("Data/QLTK/EventButton.txt") && !string.IsNullOrEmpty(File.ReadAllText("Data/QLTK/EventButton.txt")))
				{
					string caption = File.ReadAllText("Data/QLTK/EventButton.txt").ToLower().Trim()
						.Replace(" ", "");
					if (GClass193.smethod_0().method_1(gClass2.string_0, caption))
					{
						GClass166.smethod_0().method_59((short)num, (sbyte)num2);
						GClass198.smethod_0().method_0();
						return;
					}
				}
				int num3 = num;
				if (num3 <= 44)
				{
					switch (num3)
					{
					default:
						switch (num3)
						{
						default:
						{
							if (num3 != 44)
								break;
							int num6 = gstruct11_0.int_0;
							if (num6 != 48)
							{
								if (num6 != 154)
								{
									if (num6 != 155 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnhànhtinhngụctù" : "gotoprisonplanet"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
								else
								{
									if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnhànhtinhbill" : "gotobeerusplanet"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
							}
							else
							{
								if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnkaio" : "gotokaio"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							return;
						}
						case 21:
						{
							int num8 = gstruct11_0.int_0;
							if (num8 != 5)
							{
								if (num8 != 112 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "võđàisinhtử" : "deathoralivearena"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							else
							{
								if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "vềđảorùa" : "gokame house"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							return;
						}
						case 23:
						{
							int num7 = gstruct11_0.int_0;
							if (num7 != 52)
							{
								if (num7 != 113)
								{
									if (num7 != 129 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đạihộivõthuậtlầnthứ23" : "worldmartialarena23rd"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
								else
								{
									if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "giảisiêuhạng" : "superrank"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
							}
							else
							{
								if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "vềđạihộivõthuật" : "gotomartialartarena"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							return;
						}
						case 30:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 31:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 32:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 33:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 34:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 35:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 36:
							if (!gClass2.string_0.ToLower().Contains((mResources.language == 0) ? "nhà" : "home"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						case 38:
						{
							int num5 = gstruct11_0.int_0;
							if (num5 != 24)
							{
								if (num5 != 102 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "điđếntươnglai" : "gotofuture"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							else
							{
								if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "quayvềquákhứ" : "comebackthepast"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							return;
						}
						case 22:
						case 24:
						case 25:
						case 26:
						case 27:
						case 28:
						case 29:
						case 37:
							break;
						}
						break;
					case 10:
					{
						int num10 = gstruct11_0.int_0;
						if (num10 != 5)
						{
							switch (num10)
							{
							default:
								if (num10 != 84 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "siêuthị" : "tosupermarket"))
									break;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
								return;
							case 24:
								if (GClass1.int_37 == 176)
								{
									if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đồngý" : "accept"))
									{
										GClass166.smethod_0().method_59((short)num, (sbyte)num2);
										GClass198.smethod_0().method_0();
										return;
									}
								}
								else if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếntráiđất" : "toearth"))
								{
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
									return;
								}
								break;
							case 25:
								if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnnamếc" : "tonamek"))
								{
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
									return;
								}
								break;
							case 26:
								if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnxayda" : "tosaiya"))
								{
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
									return;
								}
								break;
							}
						}
						else if (GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đảokame" : "kameisland"))
						{
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
							return;
						}
						goto IL_0add;
					}
					case 12:
					{
						int num9 = gstruct11_0.int_0;
						if (num9 <= 25)
						{
							if (num9 != 19)
							{
								if (num9 != 24)
								{
									if (num9 != 25 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnnamếc" : "tonamek"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
								else
								{
									if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếntráiđất" : "toearth"))
										goto IL_0add;
									GClass166.smethod_0().method_59((short)num, (sbyte)num2);
									GClass198.smethod_0().method_0();
								}
							}
							else
							{
								if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
						}
						else if (num9 != 68)
						{
							if (num9 != 84)
							{
								if (num9 != 109 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếncold" : "gotocold"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							else
							{
								if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "siêuthị" : "tosupermarket"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
						}
						else
						{
							if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()) && !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đếnnappa" : "gotonappa"))
								goto IL_0add;
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
						}
						return;
					}
					case 13:
						if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "nóichuyện" : "talk"))
						{
							int num4 = gstruct11_0.int_0;
							if (num4 != 135)
							{
								if (num4 != 153 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "vềkhuvựcbang" : "returntoclanarea"))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							else if (!GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "khobáudướibiển" : "treasureundersea"))
							{
								if (!gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
									goto IL_0add;
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
							else
							{
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
							}
						}
						else
						{
							GClass166.smethod_0().method_59((short)num, (sbyte)num2);
							GClass198.smethod_0().method_0();
						}
						return;
					case 11:
						break;
					}
				}
				else
				{
					if (num3 == 47)
					{
						if (gstruct11_0.int_0 == 156 && gClass2.string_0.ToLower().StartsWith("ok"))
							break;
						goto IL_0add;
					}
					if (num3 == 52)
					{
						if (gstruct11_0.int_0 != 24 || GClass1.int_37 != 177 || !GClass193.smethod_0().method_1(gClass2.string_0, (mResources.language == 0) ? "đồngý" : "accept"))
							goto IL_0add;
						GClass166.smethod_0().method_59((short)num, (sbyte)num2);
						GClass198.smethod_0().method_0();
						return;
					}
					if (num3 == 67)
					{
						if (gstruct11_0.int_0 == 149)
						{
							if (gClass2.string_0.ToLower().StartsWith("ok"))
							{
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
								return;
							}
							if (gClass2.string_0.ToLower().Contains(mResources.ACCEPT.ToLower()))
							{
								GClass166.smethod_0().method_59((short)num, (sbyte)num2);
								GClass198.smethod_0().method_0();
								return;
							}
						}
						goto IL_0add;
					}
				}
				for (int j = 1; j < gstruct11_0.int_1.Length; j++)
				{
					int num11 = gstruct11_0.int_1[j];
					GClass166.smethod_0().method_59((short)num, (sbyte)num11);
				}
				goto IL_0add;
				IL_0add:
				num2++;
			}
			GClass166.smethod_0().method_59((short)num, (sbyte)num2);
			GClass198.smethod_0().method_0();
		}
	}

	private void method_17(GStruct11 gstruct11_0)
	{
		int num = gstruct11_0.int_1[0];
		int num2 = gstruct11_0.int_1[1];
		int selected = gstruct11_0.int_1[2];
		if (num == 29)
		{
			if (!GClass39.gclass45_0.bool_0)
			{
				if (!GClass39.gclass0_0.bool_0)
				{
					GClass166.smethod_0().method_60(num);
					return;
				}
				for (int i = 0; i < GClass39.gclass0_0.gclass63_0.method_2(); i++)
				{
					GClass14 gClass = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(i);
					if (File.Exists("Data/QLTK/EventButton.txt") && !string.IsNullOrEmpty(File.ReadAllText("Data/QLTK/EventButton.txt")))
					{
						string caption = File.ReadAllText("Data/QLTK/EventButton.txt").ToLower().Trim()
							.Replace(" ", "");
						if (GClass193.smethod_0().method_1(gClass.string_0, caption))
						{
							GClass166.smethod_0().method_59((short)num, (sbyte)i);
							GClass198.smethod_0().method_0();
							return;
						}
					}
					if (GClass193.smethod_0().method_1(gClass.string_0, (mResources.language == 0) ? "thamgia" : "join"))
					{
						GClass166.smethod_0().method_59((short)num, (sbyte)i);
						GClass198.smethod_0().method_0();
						return;
					}
				}
			}
			if (GClass39.gclass45_0.bool_0)
				GClass166.smethod_0().method_126(selected);
			GClass198.smethod_0().method_0();
		}
		else
		{
			GClass166.smethod_0().method_60(num);
			GClass166.smethod_0().method_59((short)num, (sbyte)num2);
			GClass166.smethod_0().method_126(selected);
		}
	}

	private void method_18(GStruct11 gstruct11_0)
	{
		method_23(gstruct11_0.int_1[0], gstruct11_0.int_1[1]);
		GClass166.smethod_0().method_40();
		GClass166.smethod_0().method_114();
	}

	private void method_19(GStruct11 gstruct11_0)
	{
		method_9();
		int selected = gstruct11_0.int_1[0];
		GClass166.smethod_0().method_126(selected);
	}

	public void method_20()
	{
		GClass171.smethod_0().bool_2 = false;
		GClass166.smethod_0().method_20(0, 1, -1, 193);
	}

	public void method_21()
	{
		GClass171.smethod_0().bool_2 = false;
		GClass166.smethod_0().method_20(0, 1, -1, 194);
	}

	public void method_22()
	{
		GClass57.smethod_5();
	}

	public void method_23(int int_5, int int_6)
	{
		GClass58.smethod_1().int_4 = int_5;
		GClass58.smethod_1().int_5 = int_6;
		GClass166.smethod_0().method_44();
		if (!GClass82.smethod_0(4387))
		{
			GClass58.smethod_1().int_4 = int_5;
			GClass58.smethod_1().int_5 = int_6 + 1;
			GClass166.smethod_0().method_44();
			GClass58.smethod_1().int_4 = int_5;
			GClass58.smethod_1().int_5 = int_6;
			GClass166.smethod_0().method_44();
		}
	}

	private void method_24(GClass48 gclass48_0)
	{
		if (gclass48_0.bool_1)
			GClass166.smethod_0().method_114();
		else
			GClass166.smethod_0().method_40();
	}
}
