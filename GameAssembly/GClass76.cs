using System;
using System.Collections.Generic;
using System.IO;
using AssemblyCSharp.Functions;
using Assets.src.g;
using UnityEngine;

public class GClass76 : GInterface4, GInterface6
{
	public class GClass77
	{
		public string string_0;

		public int int_0;

		public bool bool_0;

		public List<GClass16> list_0 = new List<GClass16>();

		public GClass77(string name, int charId)
		{
			string_0 = name;
			int_0 = charId;
			bool_0 = true;
		}
	}

	public bool bool_0;

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

	public int[] int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public static GClass70 gclass70_0;

	public static GClass70 gclass70_1;

	public static GClass70 gclass70_2;

	public GClass84 gclass84_0;

	public GClass88 gclass88_0 = new GClass88();

	public int int_22;

	public int int_23;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public string string_0;

	public GClass91 gclass91_0;

	public static string string_1;

	public static short short_0;

	public static GClass70 gclass70_3;

	public static GClass70 gclass70_4;

	public static GClass70 gclass70_5;

	public static GClass70 gclass70_6;

	public static GClass70 gclass70_7;

	public static GClass70 gclass70_8;

	public static GClass70 gclass70_9;

	public static GClass70 gclass70_10;

	private static GClass70 gclass70_11;

	private static GClass70 gclass70_12;

	private int int_24;

	private int int_25;

	private bool bool_5;

	private int int_26;

	private int int_27;

	private GClass87 gclass87_0 = new GClass87(mResources.SELECT, 0);

	public int int_28;

	public int int_29;

	public int int_30;

	public int[] int_31;

	public string[][] string_2;

	private int[] int_32;

	public int int_33 = 4;

	public int int_34 = 50;

	public int int_35 = 50;

	public string[][] string_3;

	public string[] string_4;

	public string[] string_5;

	public static string[] string_6 = new string[7]
	{
		mResources.gameInfo,
		mResources.change_flag,
		mResources.change_zone,
		mResources.chat_world,
		mResources.account,
		mResources.option,
		mResources.change_account
	};

	public static string[] string_7 = new string[4]
	{
		GClass73.bool_21 ? mResources.turnOffSound : mResources.turnOnSound,
		mResources.increase_vga,
		mResources.analog,
		(GClass122.int_12 > 1) ? mResources.x1Screen : mResources.x2Screen
	};

	public static string[] string_8 = new string[5]
	{
		mResources.inventory_Pass,
		mResources.friend,
		mResources.enemy,
		mResources.msg,
		mResources.charger
	};

	public static string[] string_9 = new string[1] { mResources.useGem };

	public static int int_36 = 0;

	public string[][] string_10;

	public int[] int_37;

	public int[] int_38;

	private static string[][] string_11 = new string[2][]
	{
		mResources.chestt,
		mResources.inventory
	};

	private static string[][] string_12 = new string[2][]
	{
		mResources.combine,
		mResources.inventory
	};

	private static string[][] string_13 = new string[1][] { mResources.zonee };

	private static string[][] string_14 = new string[1][] { mResources.mapp };

	private static string[][] string_15 = new string[3][]
	{
		mResources.inventory,
		mResources.item_give,
		mResources.item_receive
	};

	private static string[][] string_16 = mResources.petMainTab;

	public string[][][] string_17 = new string[27][][]
	{
		null,
		null,
		string_11,
		string_13,
		string_14,
		null,
		null,
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		string_12,
		string_15,
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		string_16,
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } },
		new string[1][] { new string[1] { "" } }
	};

	private static sbyte sbyte_0 = 0;

	private static sbyte sbyte_1 = 1;

	private static sbyte sbyte_2 = 2;

	private static sbyte sbyte_3 = 3;

	private static sbyte sbyte_4 = 4;

	private static sbyte sbyte_5 = 5;

	private static sbyte sbyte_6 = 6;

	private static sbyte sbyte_7 = 7;

	public int int_39;

	public int int_40;

	public int int_41;

	private int[] int_42;

	public static int[] int_43 = new int[16]
	{
		21, 0, 1, 2, 24, 3, 4, 5, 6, 27,
		28, 29, 30, 42, 47, 46
	};

	public static int[] int_44 = new int[16]
	{
		39, 42, 105, 93, 61, 93, 142, 165, 210, 100,
		165, 220, 233, 10, 125, 125
	};

	public static int[] int_45 = new int[16]
	{
		28, 60, 48, 96, 88, 131, 136, 95, 32, 200,
		189, 167, 120, 110, 20, 20
	};

	public static int[] int_46 = new int[14]
	{
		22, 7, 8, 9, 25, 11, 12, 13, 10, 31,
		32, 33, 34, 43
	};

	public static int[] int_47 = new int[14]
	{
		55, 30, 93, 80, 24, 149, 219, 220, 233, 170,
		148, 195, 148, 10
	};

	public static int[] int_48 = new int[14]
	{
		136, 84, 69, 34, 25, 42, 32, 110, 192, 70,
		106, 156, 210, 57
	};

	public static int[] int_49 = new int[14]
	{
		23, 14, 15, 16, 26, 17, 18, 20, 19, 35,
		36, 37, 38, 44
	};

	public static int[] int_50 = new int[14]
	{
		90, 95, 144, 234, 231, 122, 176, 158, 205, 54,
		105, 159, 231, 27
	};

	public static int[] int_51 = new int[14]
	{
		10, 43, 20, 36, 69, 87, 112, 167, 160, 151,
		173, 207, 194, 29
	};

	public static int[][] int_52 = new int[3][] { int_43, int_46, int_49 };

	public static int[][] int_53 = new int[3][] { int_44, int_47, int_50 };

	public static int[][] int_54 = new int[3][] { int_45, int_48, int_51 };

	public GClass128 gclass128_0;

	public GClass106 gclass106_0;

	public GClass189 gclass189_0;

	public GClass38 gclass38_0;

	public GClass106[] gclass106_1;

	public GClass88 gclass88_1;

	public GClass88 gclass88_2;

	public GClass88 gclass88_3 = new GClass88();

	public GClass88 gclass88_4 = new GClass88();

	public GClass88 gclass88_5 = new GClass88();

	public GClass88 gclass88_6 = new GClass88();

	public GClass88 gclass88_7 = new GClass88();

	public GClass88 gclass88_8 = new GClass88();

	public GClass88 gclass88_9 = new GClass88();

	public GClass88 gclass88_10 = new GClass88();

	public GClass88 gclass88_11 = new GClass88();

	public GClass87 gclass87_1;

	public static bool bool_6 = false;

	public static int int_55 = 240;

	private int int_56;

	public string string_18;

	public Dictionary<string, GClass77> dictionary_0 = new Dictionary<string, GClass77>();

	public GClass78 gclass78_0;

	private bool bool_7;

	public int int_57 = -1;

	public int int_58;

	public int int_59;

	public int int_60;

	public int int_61;

	public GClass96 gclass96_0;

	public int int_62;

	public int[] int_63;

	private int int_64;

	public bool bool_8;

	public int int_65;

	private int int_66;

	public int int_67;

	private int int_68;

	private int int_69;

	private bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public const int int_70 = 0;

	public const int int_71 = 1;

	public const int int_72 = 2;

	public const int int_73 = 3;

	public const int int_74 = 4;

	public const int int_75 = 5;

	public const int int_76 = 6;

	public const int int_77 = 7;

	public const int int_78 = 8;

	public const int int_79 = 9;

	public const int int_80 = 10;

	public const int int_81 = 11;

	public const int int_82 = 12;

	public const int int_83 = 13;

	public const int int_84 = 14;

	public const int int_85 = 15;

	public const int int_86 = 16;

	public const int int_87 = 17;

	public const int int_88 = 18;

	public const int int_89 = 19;

	public const int int_90 = 20;

	public const int int_91 = 21;

	public const int int_92 = 22;

	public const int int_93 = 23;

	public const int int_94 = 24;

	public const int int_95 = 25;

	private int int_96;

	private int int_97;

	private int[] int_98 = new int[3];

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private int int_99;

	private int int_100;

	private int int_101 = -1;

	private int int_102 = -1;

	private int int_103 = -1;

	private int int_104 = -1;

	public int int_105 = -1;

	private bool bool_16;

	private int int_106 = -1;

	private int int_107;

	public string[][] string_19 = new string[2][]
	{
		mResources.findClan,
		mResources.createClan
	};

	public string string_20 = "";

	public string string_21 = "";

	private bool bool_17;

	private GClass179 gclass179_0;

	private int int_108;

	private int int_109;

	private bool bool_18;

	private string[] string_22 = new string[6]
	{
		mResources.follow,
		mResources.defend,
		mResources.attack,
		mResources.gohome,
		mResources.fusion,
		mResources.fusionForever
	};

	private static string string_23;

	private int int_110;

	private int int_111;

	public static long[] long_0 = new long[14]
	{
		50000000L, 250000000L, 1250000000L, 5000000000L, 15000000000L, 30000000000L, 45000000000L, 60000000000L, 75000000000L, 90000000000L,
		110000000000L, 130000000000L, 150000000000L, 170000000000L
	};

	private int[] int_112 = new int[3] { 43520, 14743570, 14155776 };

	public string[] string_24;

	public string[] string_25;

	public static int[] int_113 = new int[3] { 2327248, 8982199, 16713222 };

	public static int[] int_114 = new int[3] { 4583423, 16719103, 16714764 };

	private int int_115;

	private GClass128 gclass128_1;

	private GClass81 gclass81_0;

	private static GClass17 gclass17_0;

	private bool bool_19;

	private int int_116;

	public static string string_26 = "";

	public int int_117;

	public int int_118;

	public int int_119 = 140;

	public int int_120 = 160;

	public int int_121;

	public int int_122;

	public int int_123;

	public int int_124;

	public int int_125;

	public int int_126;

	public int int_127;

	public int int_128;

	public int int_129;

	public int int_130 = 28;

	public int int_131;

	public int int_132;

	public int int_133 = -1;

	public int int_134;

	public int int_135;

	public int int_136 = 6;

	public int int_137;

	public int int_138;

	public int int_139;

	public int int_140;

	public int int_141;

	private int int_142;

	private int int_143;

	private int int_144;

	private int int_145;

	private int int_146;

	private int int_147;

	private int int_148;

	public static bool bool_20 = true;

	public bool bool_21;

	private int int_149;

	public static GClass88 gclass88_12 = new GClass88("");

	public static string[] string_27;

	public bool bool_22;

	private int int_150;

	public GClass78 gclass78_1;

	private bool bool_23;

	private bool bool_24;

	private bool bool_25;

	private int int_151;

	public sbyte sbyte_8 = -1;

	public int int_152;

	public int int_153;

	public int int_154;

	private int int_155;

	private int int_156;

	private int int_157;

	private int int_158;

	private int int_159;

	private int int_160;

	private int[] int_161;

	private int[] int_162;

	private int[] int_163;

	private int[] int_164;

	private int int_165;

	private int int_166;

	private int int_167;

	private int int_168;

	private int int_169;

	private bool bool_26;

	private bool bool_27 = true;

	private bool bool_28;

	public bool bool_29 = true;

	public short short_1;

	public short short_2;

	public short short_3;

	public short[] short_4;

	public string[][] string_28;

	public static int[] int_170 = new int[3] { 2, 1, 1 };

	public static int int_171 = 1;

	public const sbyte sbyte_9 = 0;

	public const sbyte sbyte_10 = 1;

	public const sbyte sbyte_11 = 2;

	public const sbyte sbyte_12 = 3;

	public const sbyte sbyte_13 = 4;

	public const sbyte sbyte_14 = 5;

	public const sbyte sbyte_15 = 6;

	public const sbyte sbyte_16 = 7;

	public static int[][] int_172 = new int[7][]
	{
		new int[6] { 16777215, 15000805, 13487823, 11711155, 9671828, 7895160 },
		new int[6] { 61952, 58624, 52224, 45824, 39168, 32768 },
		new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
		new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
		new int[6] { 37119, 33509, 28108, 24499, 21145, 17536 },
		new int[6] { 16776192, 15063040, 12635136, 11776256, 10063872, 8290304 },
		new int[6] { 16711680, 15007744, 13369344, 11730944, 10027008, 8388608 }
	};

	public const int int_173 = 15987701;

	public const int int_174 = 2786816;

	public const int int_175 = 7078041;

	public const int int_176 = 12537346;

	public const int int_177 = 1269146;

	public const int int_178 = 13279744;

	public const int int_179 = 11599872;

	public const int int_180 = 2039326;

	private GClass70 gclass70_13;

	private GClass70 gclass70_14;

	private GClass70 gclass70_15;

	private GClass70 gclass70_16;

	public const int int_181 = 20;

	public const sbyte sbyte_17 = 1;

	public sbyte sbyte_18;

	private bool bool_30;

	public GClass76()
	{
		method_0();
		gclass87_1 = new GClass87("", this, 1003, null);
		gclass87_1.gclass70_0 = ((!GClass167.smethod_0().bool_22) ? GClass73.smethod_43("/mainImage/myTexture2dbtX.png") : GClass167.smethod_0().method_5("X"));
		gclass87_1.bool_3 = true;
		gclass128_0 = null;
	}

	public static void smethod_0()
	{
		gclass70_2 = GClass73.smethod_43("/img/map" + GClass20.sbyte_2 + ".png");
		gclass70_0 = GClass73.smethod_43("/mainImage/myTexture2dbantay.png");
		gclass70_1 = GClass73.smethod_43("/mainImage/myTexture2dbtX.png");
		gclass70_7 = GClass73.smethod_43("/mainImage/myTexture2dimgMoney.png");
		gclass70_9 = GClass73.smethod_43("/mainImage/myTexture2dimgDiamond.png");
		gclass70_10 = GClass73.smethod_43("/mainImage/luongkhoa.png");
		gclass70_11 = GClass73.smethod_43("/mainImage/myTexture2dup.png");
		gclass70_12 = GClass73.smethod_43("/mainImage/myTexture2ddown.png");
		gclass70_3 = GClass73.smethod_43("/mainImage/star.png");
		gclass70_4 = GClass73.smethod_43("/mainImage/starE.png");
		gclass70_5 = GClass73.smethod_43("/mainImage/star8.png");
		gclass70_6 = GClass73.smethod_43("/mainImage/new.png");
		gclass70_8 = GClass73.smethod_43("/mainImage/ticket12.png");
	}

	public void method_0()
	{
		int_26 = GClass73.int_4 + int_17;
		int_27 = GClass73.int_5 + int_18;
		int_31 = new int[string_17.Length];
		for (int i = 0; i < int_31.Length; i++)
		{
			int_31[i] = -1;
		}
	}

	public int method_1()
	{
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass20.sbyte_2].Length)
			{
				if (GClass20.int_37 == int_52[GClass20.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_53[GClass20.sbyte_2][num];
	}

	public int method_2()
	{
		for (int i = 0; i < int_52[GClass20.sbyte_2].Length; i++)
		{
			if (GClass20.int_37 == int_52[GClass20.sbyte_2][i])
				return int_54[GClass20.sbyte_2][i];
		}
		return -1;
	}

	public int method_3()
	{
		if (GClass78.smethod_1().gclass56_0 == null)
			return -1;
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass20.sbyte_2].Length)
			{
				if (GClass144.int_76[GClass78.smethod_1().gclass56_0.int_0] == int_52[GClass20.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_53[GClass20.sbyte_2][num];
	}

	public int method_4()
	{
		if (GClass78.smethod_1().gclass56_0 == null)
			return -1;
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass20.sbyte_2].Length)
			{
				if (GClass144.int_76[GClass78.smethod_1().gclass56_0.int_0] == int_52[GClass20.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_54[GClass20.sbyte_2][num];
	}

	public void method_5(int position)
	{
		int_57 = -1;
		int_2 = int_55;
		int_3 = GClass73.int_11;
		int_0 = 0;
		int_1 = 0;
		int_4 = 24;
		int_56 = position;
		if (position == 0)
		{
			int_58 = 2;
			int_59 = 80;
			int_60 = int_2 - 4;
			int_61 = int_3 - 96;
			int_15 = int_60;
			int_14 = 0;
			int_0 = 0;
		}
		else if (position == 1)
		{
			int_60 = int_2 - 4;
			int_58 = GClass73.int_10 - int_60;
			int_59 = 80;
			int_61 = int_3 - 96;
			int_0 = int_58 - 2;
			int_15 = -(GClass73.int_10 + int_2);
			int_14 = GClass73.int_10 - int_2;
		}
		int_5 = int_2 / 5 - 1;
		int_29 = 0;
		string_2 = string_17[int_28];
		if (string_2.Length < 5)
			int_5 += 5;
		int_30 = int_58 + int_60 / 2 - string_2.Length * int_5 / 2;
		int_42 = new int[string_2.Length];
		int_13 = new int[string_2.Length];
		for (int i = 0; i < string_2.Length; i++)
		{
			int_42[i] = (GClass73.bool_5 ? (-1) : 0);
		}
		if (int_31[int_28] != -1)
			int_29 = int_31[int_28];
		if (int_29 < 0)
			int_29 = 0;
		if (int_29 > string_2.Length - 1)
			int_29 = string_2.Length - 1;
		gclass179_0 = null;
	}

	public void method_6()
	{
		int_28 = 14;
		method_5(0);
		method_84();
		int_14 = 0;
		int_15 = 0;
	}

	public void method_7()
	{
		int_28 = 6;
		int_15 = int_60;
		int_14 = 0;
	}

	public void method_8()
	{
		if (!GClass144.smethod_8().method_3() && bool_20)
		{
			if (GClass31.smethod_0(2, 0))
			{
				GClass31.bool_2 = true;
				GClass144.gclass52_0.method_7(mResources.go_to_quest, 0);
			}
			if (GClass31.smethod_0(3, 0))
				GClass31.bool_4 = true;
			int_28 = 4;
			string_2 = string_17[int_28];
			int_30 = int_58 + int_60 / 2 - string_2.Length * int_5 / 2;
			int_14 = 0;
			int_15 = 0;
			method_89();
		}
	}

	public void method_9()
	{
		int_41 = GClass78.smethod_1().gclass6_0.Length;
		method_5(0);
		int_28 = 9;
		int_11 = int_41 * int_4 - int_61;
		int_8 = (int_7 = int_13[int_29]);
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public void method_10()
	{
		int_28 = 17;
		method_5(1);
		method_14();
		int_57 = 2;
		int_29 = 0;
	}

	public void method_11()
	{
		int_41 = dictionary_0.Count;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	public void method_12()
	{
	}

	public void method_13()
	{
	}

	public void method_14()
	{
		int_4 = 24;
		int_41 = GClass78.smethod_1().gclass128_3[4].Length;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public void method_15()
	{
		int_28 = 7;
		method_5(1);
		method_88();
		int_29 = 0;
	}

	public void method_16(GClass16 info)
	{
		if (info.gclass78_0.int_13 >= 0 || !GClass167.smethod_0().bool_0)
		{
			gclass88_3.method_10(info, 0);
			if (gclass88_3.method_2() > 20)
				gclass88_3.method_7(gclass88_3.method_2() - 1);
		}
	}

	private bool method_17(string string_29)
	{
		return false;
	}

	public bool method_18()
	{
		return false;
	}

	private void method_19(string string_29)
	{
	}

	public void method_20(GClass87 pm)
	{
		gclass88_4.method_0(pm);
	}

	public void method_21()
	{
		int_4 = 24;
		int_41 = gclass88_4.method_2();
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public void method_22()
	{
		int_28 = 18;
		method_5(0);
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		method_23();
	}

	public void method_23()
	{
		int_41 = gclass88_10.method_2();
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		int num;
		if (int_8 < 0)
		{
			num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		if (int_67 > int_41 - 1)
			int_67 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_24(GClass78 c)
	{
		int_28 = 10;
		method_5(0);
		method_21();
		gclass78_0 = c;
	}

	public void method_25()
	{
		int_28 = 11;
		method_5(0);
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		method_29();
	}

	public void method_26()
	{
		int_28 = 16;
		method_5(0);
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		method_30();
	}

	public void method_27(sbyte t)
	{
		int_28 = 15;
		method_5(0);
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		method_28();
		bool_7 = ((t != 0) ? true : false);
	}

	public void method_28()
	{
		int_41 = gclass88_8.method_2();
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		int num;
		if (int_8 < 0)
		{
			num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		if (int_67 > int_41 - 1)
			int_67 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_29()
	{
		int_41 = gclass88_5.method_2();
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		int num;
		if (int_8 < 0)
		{
			num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		if (int_67 > int_41 - 1)
			int_67 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_30()
	{
		int_41 = gclass88_9.method_2();
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		int num;
		if (int_8 < 0)
		{
			num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		if (int_67 > int_41 - 1)
			int_67 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_31()
	{
		int_28 = 8;
		method_5(0);
		method_81();
		int_29 = 0;
	}

	public void method_32()
	{
		int_28 = 8;
		method_5(0);
		method_81();
		int_29 = 0;
	}

	public void method_33(int typeShop)
	{
		int_28 = 1;
		method_5(0);
		method_82();
		int_29 = 0;
		int_57 = typeShop;
	}

	public void method_34()
	{
		int_28 = 2;
		if (GClass73.int_10 <= 2 * int_55)
			string_11 = new string[2][]
			{
				mResources.chestt,
				mResources.inventory
			};
		else
			string_11 = new string[1][] { mResources.chestt };
		string_17[2] = string_11;
		method_5(0);
		if (int_29 == 0)
			method_86();
		if (int_29 == 1)
			method_88();
		if (GClass73.int_10 > 2 * int_55)
		{
			GClass73.gclass76_1 = new GClass76();
			GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
			GClass73.gclass76_1.method_15();
			GClass73.gclass76_1.method_50();
		}
	}

	public void method_35()
	{
		int_28 = 12;
		if (GClass73.int_10 > 2 * int_55)
			string_12 = new string[1][] { mResources.combine };
		else
			string_12 = new string[2][]
			{
				mResources.combine,
				mResources.inventory
			};
		string_17[int_28] = string_12;
		method_5(0);
		if (int_29 == 0)
			method_36();
		if (int_29 == 1)
			method_88();
		if (GClass73.int_10 > 2 * int_55)
		{
			GClass73.gclass76_1 = new GClass76();
			GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
			GClass73.gclass76_1.method_15();
			GClass73.gclass76_1.method_50();
		}
		sbyte_8 = -1;
		bool_29 = true;
	}

	public void method_36()
	{
		int_41 = gclass88_0.method_2() + 1;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 9;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public void method_37()
	{
		int_28 = 22;
		method_5(0);
		method_38();
		int_14 = 0;
		int_15 = 0;
	}

	private void method_38()
	{
		int_41 = string_9.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	public void method_39()
	{
		int_28 = 21;
		if (GClass73.gclass76_1 != null)
			string_16 = mResources.petMainTab2;
		else
			string_16 = mResources.petMainTab;
		string_17[21] = string_16;
		if (GClass78.smethod_1().int_14 != 1)
			string_22 = new string[5]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion
			};
		else
			string_22 = new string[6]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion,
				mResources.fusionForever
			};
		method_5(2);
		if (int_29 == 0)
			method_87();
		if (int_29 == 1)
			method_75();
		if (int_29 == 2)
			method_88();
	}

	public void method_40()
	{
		int_28 = 0;
		method_5(0);
		if (int_29 == 1)
			method_88();
		if (int_29 == 2)
			method_83();
		if (int_29 == 3)
		{
			if (string_3.Length != 4)
				method_79();
			else
				method_77();
		}
		if (int_29 == 4)
			method_77();
	}

	public void method_41()
	{
		int_28 = 3;
		method_5(0);
		method_85();
		int_14 = 0;
		int_15 = 0;
	}

	public void method_42(GClass128 item)
	{
		try
		{
			gclass96_0 = new GClass96();
			string empty = "";
			string text = "";
			if (item.gclass117_0.sbyte_1 != GClass78.smethod_1().int_14)
			{
				if (item.gclass117_0.sbyte_1 != 0)
				{
					if (item.gclass117_0.sbyte_1 == 1)
						text = text + "\n|7|1|" + mResources.from_namec;
					else if (item.gclass117_0.sbyte_1 == 2)
					{
						text = text + "\n|7|1|" + mResources.from_sayda;
					}
				}
				else
					text = text + "\n|7|1|" + mResources.from_earth;
			}
			string text2 = "";
			if (item.gclass120_0 != null)
			{
				for (int i = 0; i < item.gclass120_0.Length; i++)
				{
					if (item.gclass120_0[i].gclass126_0.int_0 == 72)
						text2 = " [+" + item.gclass120_0[i].int_0 + "]";
				}
			}
			bool flag = false;
			if (item.gclass120_0 != null)
			{
				for (int j = 0; j < item.gclass120_0.Length; j++)
				{
					if (item.gclass120_0[j].gclass126_0.int_0 == 41)
					{
						flag = true;
						if (item.gclass120_0[j].int_0 == 1)
							text = text + "|0|1|" + item.gclass117_0.string_0 + text2;
						if (item.gclass120_0[j].int_0 == 2)
							text = text + "|2|1|" + item.gclass117_0.string_0 + text2;
						if (item.gclass120_0[j].int_0 == 3)
							text = text + "|8|1|" + item.gclass117_0.string_0 + text2;
						if (item.gclass120_0[j].int_0 == 4)
							text = text + "|7|1|" + item.gclass117_0.string_0 + text2;
					}
				}
			}
			if (!flag)
				text = text + "|0|1|" + $"[{item.gclass117_0.short_0}] {item.gclass117_0.string_0}{text2}";
			if (item.gclass120_0 != null)
			{
				for (int k = 0; k < item.gclass120_0.Length; k++)
				{
					if (!item.gclass120_0[k].gclass126_0.string_0.StartsWith("$") || 1 == 0)
					{
						empty = item.gclass120_0[k].method_0();
						if (empty.Equals("") || item.gclass120_0[k].gclass126_0.int_0 == 72)
							continue;
						if (item.gclass120_0[k].gclass126_0.int_0 != 102)
						{
							if (item.gclass120_0[k].gclass126_0.int_0 != 107)
							{
								text = text + "\n|1|1|" + empty;
								continue;
							}
							gclass96_0.sbyte_1 = (sbyte)item.gclass120_0[k].int_0;
							GClass50.smethod_8("STAR SLOT= " + gclass96_0.sbyte_1);
						}
						else
						{
							gclass96_0.sbyte_0 = (sbyte)item.gclass120_0[k].int_0;
							GClass50.smethod_8("STAR SLOT= " + gclass96_0.sbyte_0);
						}
					}
					else
					{
						empty = item.gclass120_0[k].method_2();
						if (item.gclass120_0[k].int_0 == 1)
							text = text + "\n|1|1|" + empty;
						if (item.gclass120_0[k].int_0 == 0)
							text = text + "\n|0|1|" + empty;
					}
				}
			}
			if (gclass128_0.gclass117_0.int_2 <= 1)
				text += "\n|6|1|";
			else
			{
				string text3 = mResources.pow_request + ": " + gclass128_0.gclass117_0.int_2;
				if (gclass128_0.gclass117_0.int_2 <= GClass78.smethod_1().long_2)
					text = text + "\n|6|1|" + text3;
				else
				{
					string text4 = text + "\n|3|1|" + text3;
					text = text4 + "\n|3|1|" + mResources.your_pow + ": " + GClass78.smethod_1().long_2;
				}
			}
			gclass128_0.int_43 = method_131(gclass128_0);
			text = string.Concat(text + "\n--", "\n|6|", item.gclass117_0.string_2);
			if (!item.string_2.Equals(""))
			{
				if (!item.gclass117_0.string_2.Equals(""))
					text += "\n--";
				text = text + "\n|2|" + item.string_2;
			}
			if (gclass96_0.sbyte_1 > 0)
				text += "\n\n";
			method_43(gclass96_0, text);
			int_62 = item.gclass117_0.short_1;
			int_63 = null;
			gclass78_1 = null;
		}
		catch (Exception ex)
		{
			GClass50.smethod_8("ex " + ex.StackTrace);
		}
	}

	public void method_43(GClass96 cp, string chat)
	{
		cp.bool_3 = false;
		cp.int_0 = 180;
		cp.int_3 = 3 + int_0 - ((int_0 != 0) ? (GClass50.smethod_28(cp.int_0 - int_2) + 8) : 0);
		cp.string_0 = GClass4.gclass4_17.method_15(chat, cp.int_0 - 10);
		cp.int_1 = 10000000;
		cp.gclass79_0 = null;
		cp.int_2 = 7;
		cp.int_5 = 15 - cp.int_2 + cp.string_0.Length * 12 + 10;
		if (cp.int_5 > GClass73.int_11 - 80)
		{
			cp.int_5 = GClass73.int_11 - 80;
			cp.int_8 = cp.string_0.Length * 12 - cp.int_5 + 17;
			if (cp.int_8 < 0)
				cp.int_8 = 0;
			GClass96.int_21 = 0;
			cp.bool_3 = true;
		}
		cp.int_4 = GClass73.gclass145_0.int_2 - cp.int_5;
		while (cp.int_4 < 10)
		{
			cp.int_4++;
			GClass73.gclass145_0.int_2++;
		}
		cp.int_10 = 0;
		cp.int_19 = 10;
	}

	public void method_44(GClass96 cp, string[] chat)
	{
		cp.int_0 = 160;
		cp.int_3 = 3 + int_0;
		cp.string_0 = chat;
		cp.int_1 = 10000000;
		cp.gclass79_0 = null;
		cp.int_2 = 7;
		cp.int_5 = 15 - cp.int_2 + cp.string_0.Length * 12 + 10;
		cp.int_4 = GClass73.gclass145_0.int_2 - cp.int_5;
		cp.int_10 = 0;
		cp.int_19 = 10;
	}

	public void method_45(GClass189 cm)
	{
		gclass96_0 = new GClass96();
		string text = string.Concat("|0|" + cm.string_0, "\n|1|", GClass38.smethod_0(cm.sbyte_1));
		for (int i = 0; i < gclass88_2.method_2(); i++)
		{
			GClass38 gClass = (GClass38)gclass88_2.method_3(i);
			if (cm.int_2 == gClass.int_0)
			{
				string text2 = text;
				text2 = text2 + "\n|5|" + mResources.clan_capsuledonate + ": " + gClass.int_4;
				text2 = text2 + "\n|5|" + mResources.clan_capsuleself + ": " + gClass.int_3;
				text2 = text2 + "\n|4|" + mResources.give_pea + ": " + gClass.int_1 + mResources.time;
				text = text2 + "\n|4|" + mResources.receive_pea + ": " + gClass.int_2 + mResources.time;
				int_63 = new int[3] { gClass.short_0, gClass.short_2, gClass.short_3 };
				break;
			}
		}
		text += "\n--";
		for (int j = 0; j < cm.string_1.Length; j++)
		{
			text = text + "\n" + cm.string_1[j];
		}
		if (cm.int_1 == 1)
		{
			string text3 = text;
			text = text3 + "\n|6|" + mResources.received + " " + cm.int_5 + "/" + cm.int_6;
		}
		method_43(gclass96_0, text);
		gclass78_1 = null;
	}

	public void method_46(GClass114 t)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + t.string_0, "\n|1|Top ", t.int_3.ToString()), "\n|1|", t.string_1), "\n|2|", t.string_2);
		gclass96_0 = new GClass96();
		method_43(gclass96_0, chat);
		int_63 = new int[3] { t.int_0, t.short_1, t.short_0 };
		gclass128_0 = null;
		gclass78_1 = null;
	}

	public void method_47(GClass38 m)
	{
		string text = "|0|1|" + m.string_0;
		string text2 = "\n|2|1|";
		if (m.sbyte_0 == 0)
			text2 = "\n|7|1|";
		if (m.sbyte_0 == 1)
			text2 = "\n|1|1|";
		if (m.sbyte_0 == 2)
			text2 = "\n|0|1|";
		string text3 = text + text2 + GClass38.smethod_0(m.sbyte_0);
		text3 = string.Concat(text3 + "\n|2|1|" + mResources.power + ": " + m.string_1, "\n--");
		text3 = text3 + "\n|5|" + mResources.clan_capsuledonate + ": " + m.int_4;
		text3 = text3 + "\n|5|" + mResources.clan_capsuleself + ": " + m.int_3;
		text3 = text3 + "\n|4|" + mResources.give_pea + ": " + m.int_1 + mResources.time;
		text3 = text3 + "\n|4|" + mResources.receive_pea + ": " + m.int_2 + mResources.time;
		text = text3 + "\n|6|" + mResources.join_date + ": " + m.string_2;
		gclass96_0 = new GClass96();
		method_43(gclass96_0, text);
		int_63 = new int[3] { m.short_0, m.short_2, m.short_3 };
		gclass128_0 = null;
		gclass78_1 = null;
	}

	public void method_48(GClass106 cl)
	{
		try
		{
			string text = "|0|" + cl.string_0;
			string[] array = GClass4.gclass4_19.method_15(cl.string_1, int_60 - 60);
			for (int i = 0; i < array.Length; i++)
			{
				text = text + "\n|2|" + array[i];
			}
			string text2 = text + "\n--";
			text2 = text2 + "\n|7|" + mResources.clan_leader + ": " + cl.string_3;
			text2 = text2 + "\n|1|" + mResources.power_point + ": " + cl.string_2;
			text2 = text2 + "\n|4|" + mResources.member + ": " + cl.int_3 + "/" + cl.int_4;
			text2 = text2 + "\n|4|" + mResources.level + ": " + cl.int_6;
			text = text2 + "\n|4|" + mResources.clan_birthday + ": " + GClass65.smethod_6(cl.int_2);
			gclass96_0 = new GClass96();
			method_43(gclass96_0, text);
			int_62 = GClass68.smethod_1((short)cl.int_1).short_0[0];
			gclass128_0 = null;
		}
		catch (Exception ex)
		{
			GClass50.smethod_8("Throw  exception " + ex.StackTrace);
		}
	}

	public void method_49(GClass47 tp, GClass63 skill, GClass63 nextSkill)
	{
		string text = "|0|" + tp.string_0 + " [" + tp.sbyte_0 + "]";
		for (int i = 0; i < tp.string_1.Length; i++)
		{
			text = text + "\n|4|" + tp.string_1[i];
		}
		text += "\n--";
		if (skill != null)
		{
			string text2 = text;
			text2 = string.Concat(text2 + "\n|2|" + mResources.cap_do + ": " + skill.int_0, "\n|5|", GClass65.smethod_4(tp.string_2, "#", skill.short_1 + ""));
			text2 = text2 + "\n|5|" + mResources.KI_consume + skill.int_5 + ((tp.int_2 != 1) ? "" : "%");
			text = string.Concat(text2 + "\n|5|" + mResources.cooldown + ": " + skill.method_1() + "s", "\n--");
			if (skill.int_0 != tp.int_1)
			{
				if (!skill.gclass47_0.method_3())
				{
					text2 = text;
					text = text2 + "\n|1|" + mResources.next_level_require + GClass50.smethod_31(nextSkill.long_0) + " " + mResources.potential;
				}
				text = text + "\n|4|" + GClass65.smethod_4(tp.string_2, "#", nextSkill.short_1 + "");
			}
			else
				text = text + "\n|0|" + mResources.max_level_reach;
		}
		else
		{
			string text3 = text + "\n|2|" + mResources.not_learn;
			text3 = string.Concat(text3 + "\n|1|" + mResources.learn_require + GClass50.smethod_31(nextSkill.long_0) + " " + mResources.potential, "\n|4|", GClass65.smethod_4(tp.string_2, "#", nextSkill.short_1 + ""));
			text3 = text3 + "\n|4|" + mResources.KI_consume + nextSkill.int_5 + ((tp.int_2 != 1) ? "" : "%");
			text = text3 + "\n|4|" + mResources.cooldown + ": " + nextSkill.method_1() + "s";
		}
		gclass128_0 = null;
		int_63 = null;
		gclass78_1 = null;
		gclass96_0 = new GClass96();
		method_43(gclass96_0, text);
		int_62 = 0;
	}

	public void method_50()
	{
		if (GClass73.bool_5)
		{
			gclass87_1.int_1 = 156;
			gclass87_1.int_2 = 3;
		}
		else
		{
			gclass87_1.int_1 = GClass73.int_10 - 19;
			gclass87_1.int_2 = GClass73.int_11 - 19;
		}
		gclass87_1.bool_1 = false;
		GClass96.gclass96_0 = null;
		GClass130.smethod_5();
		int_64 = 20;
		bool_0 = true;
		bool_21 = false;
		GClass109.smethod_1().method_33();
		if (method_212())
			GClass78.smethod_1().method_136();
	}

	public void method_51()
	{
		if (gclass91_0 != null && gclass91_0.bool_0)
		{
			if (gclass91_0.gclass87_0 != null && (GClass73.bool_11[12] || GClass131.smethod_1(gclass91_0.gclass87_0)) && gclass91_0.gclass87_0 != null)
				gclass91_0.gclass87_0.method_1();
			if (gclass91_0.gclass87_2 != null && (GClass73.bool_11[13] || GClass131.smethod_1(gclass91_0.gclass87_2)) && gclass91_0.gclass87_2 != null)
				gclass91_0.gclass87_2.method_1();
			if (gclass91_0.gclass87_3 != null && (GClass73.bool_11[(!Main.isPC) ? 5 : 25] || GClass131.smethod_1(gclass91_0.gclass87_3)) && gclass91_0.gclass87_3 != null)
				gclass91_0.gclass87_3.method_1();
			if (gclass91_0.bool_0 && GClass73.int_71 != 0)
			{
				gclass91_0.method_2(GClass73.int_71);
				GClass73.int_71 = 0;
			}
			GClass73.smethod_27();
			GClass73.smethod_26();
		}
	}

	public void method_52()
	{
		if ((gclass91_0 != null && gclass91_0.bool_0) || !GClass73.gclass76_0.bool_29 || GClass130.bool_0)
			return;
		if (gclass84_0 != null && gclass84_0.bool_0)
			gclass84_0.method_8();
		else
		{
			if (bool_21 || !bool_0)
				return;
			if (!gclass87_1.method_4())
			{
				if (GClass73.bool_11[13])
				{
					if (int_28 != 4)
					{
						method_151();
						return;
					}
					method_40();
					int_14 = 0;
					int_15 = 0;
				}
				if (GClass73.bool_11[12] || GClass73.bool_11[Main.isPC ? 25 : 5])
				{
					if (gclass87_0.int_0 > 0)
						perform(gclass87_0.int_0, gclass87_0.object_0);
					else
						int_99 = 2;
				}
				if (!Equals(GClass73.gclass76_0) || GClass73.gclass76_1 != null || !GClass73.bool_16 || GClass73.smethod_48(int_0, int_1, int_2, int_3) || bool_13)
				{
					if (!bool_9)
						method_74();
					int num = int_28;
					switch (num)
					{
					default:
						if (num != 100)
							break;
						goto case 23;
					case 0:
						if (int_29 == 0)
						{
							method_66();
							GClass73.smethod_26();
							return;
						}
						if (int_29 == 1)
							method_218();
						if (int_29 == 2)
							method_59();
						if (int_29 == 3)
						{
							if (string_3.Length == 4)
								method_58();
							else
								method_69();
						}
						if (int_29 == 4)
							method_58();
						break;
					case 2:
						method_218();
						break;
					case 3:
						method_72();
						break;
					case 4:
						method_64();
						GClass73.smethod_26();
						return;
					case 7:
						method_218();
						break;
					case 8:
						method_72();
						break;
					case 9:
						method_72();
						break;
					case 10:
						method_72();
						break;
					case 12:
						method_65();
						break;
					case 13:
						method_57();
						break;
					case 14:
						method_72();
						break;
					case 15:
						method_72();
						break;
					case 11:
					case 16:
						method_72();
						break;
					case 18:
						method_72();
						break;
					case 19:
						method_209();
						break;
					case 20:
						method_209();
						break;
					case 21:
						if (int_29 == 0)
							method_72();
						if (int_29 == 1)
							method_54();
						if (int_29 == 2)
							method_72();
						break;
					case 22:
						method_53();
						break;
					case 23:
					case 24:
						method_72();
						break;
					case 1:
					case 17:
					case 25:
						if (int_29 < string_2.Length - ((GClass73.gclass76_1 == null) ? 1 : 0) && int_28 != 17)
							method_72();
						else if (int_57 == 0)
						{
							method_218();
						}
						else
						{
							method_72();
						}
						break;
					case 5:
					case 6:
						break;
					}
					GClass73.smethod_27();
					for (int i = 0; i < GClass73.bool_11.Length; i++)
					{
						GClass73.bool_11[i] = false;
					}
				}
				else
					method_151();
			}
			else
				gclass87_1.method_1();
		}
	}

	private void method_53()
	{
	}

	private void method_54()
	{
		method_72();
	}

	private void method_55()
	{
	}

	private void method_56()
	{
		method_72();
	}

	private void method_57()
	{
		if (int_29 == 0)
		{
			if (Equals(GClass73.gclass76_0))
				method_218();
			if (Equals(GClass73.gclass76_1))
				method_56();
		}
		if (int_29 == 1 || int_29 == 2)
			method_56();
	}

	private void method_58()
	{
		method_72();
	}

	private void method_59()
	{
		method_72();
	}

	private void method_60()
	{
		method_72();
	}

	public void method_61(bool isMe)
	{
		int_41 = ((!isMe) ? (gclass88_7.method_2() + 3) : (gclass88_6.method_2() + 3));
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	public void method_62(GClass78 cGD)
	{
		int_28 = 13;
		string_17[int_28] = string_15;
		bool_3 = false;
		bool_1 = false;
		bool_2 = false;
		gclass88_6.method_9();
		gclass88_7.method_9();
		int_22 = 0;
		int_23 = 0;
		if (GClass73.int_10 > 2 * int_55)
		{
			GClass73.gclass76_1 = new GClass76();
			GClass73.gclass76_1.int_28 = 13;
			GClass73.gclass76_1.string_17[int_28] = new string[1][] { mResources.item_receive };
			GClass73.gclass76_1.method_5(1);
			GClass73.gclass76_1.method_61(false);
			GClass73.gclass76_0.string_17[int_28] = new string[2][]
			{
				mResources.inventory,
				mResources.item_give
			};
			GClass73.gclass76_1.method_50();
			GClass73.gclass76_1.gclass78_0 = cGD;
		}
		if (Equals(GClass73.gclass76_0))
			method_5(0);
		if (int_29 == 0)
			method_88();
		if (int_29 == 1)
			method_61(true);
		if (int_29 == 2)
			method_61(false);
		gclass78_0 = cGD;
	}

	private void method_63(GClass122 gclass122_0, bool bool_31)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		GClass88 gClass = ((!bool_31) ? gclass88_7 : gclass88_6);
		int num = 0;
		while (true)
		{
			if (num < int_41)
			{
				int num2 = int_58 + 36;
				int num3 = int_59 + num * int_4;
				int w = int_60 - 36;
				int num4 = int_4 - 1;
				int num5 = int_58;
				int num6 = int_59 + num * int_4;
				int num7 = 34;
				int num8 = int_4 - 1;
				if (num3 - int_8 <= int_59 + int_61 && num3 - int_8 >= int_59 - int_4)
				{
					if (num == int_41 - 1)
					{
						if (bool_31)
						{
							gclass122_0.method_16(15196114);
							gclass122_0.method_15(num5, num3, int_60, num4);
							if (bool_1)
							{
								if (bool_2)
								{
									gclass122_0.method_16(15196114);
									gclass122_0.method_15(num5, num3, int_60, num4);
									gclass122_0.method_31((num != int_67) ? GClass144.gclass70_24 : GClass144.gclass70_25, int_58 + int_60 - 5, num3 + 2, GClass188.int_2);
									((num != int_67) ? GClass4.gclass4_6 : GClass4.gclass4_7).method_6(gclass122_0, mResources.done, int_58 + int_60 - 22, num3 + 7, 2);
									GClass4.gclass4_16.method_6(gclass122_0, mResources.opponent + mResources.locked_trade, int_58 + 5, num3 + num4 / 2 - 4, GClass4.int_0);
								}
								else
									GClass4.gclass4_16.method_6(gclass122_0, mResources.opponent + mResources.not_lock_trade, int_58 + int_60 / 2, num3 + num4 / 2 - 4, GClass4.int_2);
							}
							else if (!bool_2)
							{
								GClass4.gclass4_16.method_6(gclass122_0, mResources.opponent + mResources.not_lock_trade, int_58 + int_60 / 2, num3 + num4 / 2 - 4, GClass4.int_2);
							}
							else
							{
								GClass4.gclass4_16.method_6(gclass122_0, mResources.opponent + mResources.locked_trade, int_58 + int_60 / 2, num3 + num4 / 2 - 4, GClass4.int_2);
							}
						}
					}
					else if (num != int_41 - 2)
					{
						if (num == int_41 - 3)
						{
							if (!bool_1)
								gclass122_0.method_16((num != int_67) ? 15196114 : 16383818);
							else
								gclass122_0.method_16(13748667);
							gclass122_0.method_15(num2, num3, w, num4);
							if (!bool_1)
								gclass122_0.method_16((num != int_67) ? 9993045 : 7300181);
							else
								gclass122_0.method_16(13748667);
							gclass122_0.method_15(num5, num6, num7, num8);
							gclass122_0.method_31(gclass70_7, num5 + num7 / 2, num6 + num8 / 2, 3);
							GClass4.gclass4_14.method_6(gclass122_0, GClass65.smethod_9((!bool_31) ? int_23 : int_22) + " " + mResources.XU, num2 + 5, num3 + 11, 0);
							GClass4.gclass4_19.method_6(gclass122_0, mResources.money_trade, num2 + 5, num3, 0);
						}
						else
						{
							if (gClass.method_2() == 0)
								break;
							if (bool_1)
								gclass122_0.method_16(13748667);
							else
								gclass122_0.method_16((num != int_67) ? 15196114 : 16383818);
							gclass122_0.method_15(num2, num3, w, num4);
							if (bool_1)
								gclass122_0.method_16(13748667);
							else
								gclass122_0.method_16((num != int_67) ? 9993045 : 9541120);
							GClass128 gClass2 = (GClass128)gClass.method_3(num);
							if (gClass2 != null)
							{
								for (int i = 0; i < gClass2.gclass120_0.Length; i++)
								{
									if (gClass2.gclass120_0[i].gclass126_0.int_0 != 72 || gClass2.gclass120_0[i].int_0 <= 0)
										continue;
									sbyte id = smethod_5(gClass2.gclass120_0[i].int_0);
									if (smethod_4(id) != -1)
									{
										if (bool_1)
											gclass122_0.method_16(13748667);
										else
											gclass122_0.method_16((num != int_67) ? smethod_4(id) : smethod_4(id));
									}
								}
							}
							gclass122_0.method_15(num5, num6, num7, num8);
							if (gClass2 != null)
							{
								string text = "";
								GClass4 gClass3 = GClass4.gclass4_14;
								if (gClass2.gclass120_0 != null)
								{
									for (int j = 0; j < gClass2.gclass120_0.Length; j++)
									{
										if (gClass2.gclass120_0[j].gclass126_0.int_0 == 72)
										{
											gClass2.method_3(gclass122_0, int_58 + 18, int_59 + num * int_4 + 12, gClass2.gclass120_0[j].int_0);
											text = " [+" + gClass2.gclass120_0[j].int_0 + "]";
										}
										if (gClass2.gclass120_0[j].gclass126_0.int_0 != 41)
											continue;
										if (gClass2.gclass120_0[j].int_0 != 1)
										{
											if (gClass2.gclass120_0[j].int_0 == 2)
												gClass3 = smethod_6(2);
											else if (gClass2.gclass120_0[j].int_0 != 3)
											{
												if (gClass2.gclass120_0[j].int_0 == 4)
													gClass3 = smethod_6(7);
											}
											else
											{
												gClass3 = smethod_6(8);
											}
										}
										else
											gClass3 = smethod_6(0);
									}
								}
								gClass3.method_6(gclass122_0, gClass2.gclass117_0.string_0 + text, num2 + 5, num3 + 1, 0);
								string text2 = "";
								string text3 = "";
								if (gClass2.gclass120_0 != null)
								{
									if (gClass2.gclass120_0.Length != 0 && gClass2.gclass120_0[0] != null)
										text2 += gClass2.gclass120_0[0].method_0();
									GClass4 gClass4 = GClass4.gclass4_18;
									if (gClass2.int_43 < 0 && gClass2.gclass117_0.sbyte_0 != 5)
										gClass4 = GClass4.gclass4_17;
									if (gClass2.gclass120_0.Length > 1)
									{
										for (int k = 1; k < gClass2.gclass120_0.Length; k++)
										{
											if (gClass2.gclass120_0[k] == null || gClass2.gclass120_0[k].gclass126_0.int_0 == 102 || gClass2.gclass120_0[k].gclass126_0.int_0 == 107)
												continue;
											try
											{
												int num9 = k;
												sbyte language = mResources.language;
												if (language == 0)
												{
													int num10 = gClass2.gclass120_0[num9].gclass126_0.int_0;
													if (num10 > 81)
													{
														switch (num10)
														{
														case 94:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + " GST";
															continue;
														case 95:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + " HM";
															continue;
														case 96:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + " HK";
															continue;
														case 97:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + " PST";
															continue;
														case 101:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[0] + " TNSM";
															continue;
														case 103:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + " KI";
															continue;
														case 98:
														case 99:
														case 100:
														case 102:
															continue;
														}
														if (num10 == 108)
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split(' ')[0] + " Né đòn";
														continue;
													}
													if (num10 != 50)
													{
														switch (num10)
														{
														case 77:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + " HP";
															break;
														case 80:
															text3 = text3 + ((text3 == "") ? "" : ", ") + "+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP/30s";
															break;
														case 81:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + "+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI/30s";
															break;
														case 78:
														case 79:
															break;
														}
													}
													else
														text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + " SĐ";
												}
												else
												{
													if (language != 1)
														continue;
													int num11 = gClass2.gclass120_0[num9].gclass126_0.int_0;
													if (num11 > 81)
													{
														switch (num11)
														{
														case 94:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[2] + ((GClass151.int_0 != 0) ? " RDMG" : " GST");
															continue;
														case 95:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HM" : " CHP");
															continue;
														case 96:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HK" : " CKI");
															continue;
														case 97:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 != 0) ? " CDMG" : " PST");
															continue;
														case 101:
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[0] + ((GClass151.int_0 != 0) ? "EXP" : " TNSM");
															continue;
														case 103:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + ((GClass151.int_0 != 0) ? " MP" : " KI");
															continue;
														case 98:
														case 99:
														case 100:
														case 102:
															continue;
														}
														if (num11 == 108)
															text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split(' ')[0] + ((GClass151.int_0 == 0) ? " Né đòn" : " Avoid");
													}
													else if (num11 != 50)
													{
														switch (num11)
														{
														case 77:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + " HP";
															break;
														case 80:
															text3 = text3 + ((!(text3 == "")) ? ", " : "") + ((GClass151.int_0 == 0) ? ("+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP/30s") : ("+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP/30s"));
															break;
														case 81:
															text3 = text3 + ((text3 == "") ? "" : ", ") + ((GClass151.int_0 == 0) ? ("+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI/30s") : ("+" + gClass2.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " MP/30s"));
															break;
														case 78:
														case 79:
															break;
														}
													}
													else
													{
														text3 = text3 + ((text3 == "") ? "" : ", ") + gClass2.gclass120_0[num9].method_0().Split('+')[1] + ((GClass151.int_0 != 0) ? " DMG" : " SĐ");
													}
													continue;
												}
											}
											catch
											{
											}
										}
									}
									gClass4.method_6(gclass122_0, text2, num2 + 5, num3 + 11, GClass4.int_0);
								}
								GClass28.smethod_6(gclass122_0, gClass2.gclass117_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
								GClass4.gclass4_18.method_10(gclass122_0, text3, int_58 + int_60 - 2, int_59 + num * int_4 + 11, GClass4.int_1, GClass4.gclass4_20);
								if (gClass2.gclass120_0 != null)
								{
									for (int l = 0; l < gClass2.gclass120_0.Length; l++)
									{
										method_214(gclass122_0, gClass2.gclass120_0[l].gclass126_0.int_0, gClass2.gclass120_0[l].int_0, num5, num6, num7, num8);
									}
									for (int m = 0; m < gClass2.gclass120_0.Length; m++)
									{
										method_215(gclass122_0, gClass2.gclass120_0[m].gclass126_0.int_0, gClass2.gclass120_0[m].int_0, num5, num6, num7, num8);
									}
									for (int n = 0; n < gClass2.gclass120_0.Length; n++)
									{
										int num12 = 0;
										int num13 = 0;
										int num14 = 0;
										if (gClass2.gclass120_0[n].int_0 > 0)
										{
											if (gClass2.gclass120_0[n].gclass126_0.int_0 == 107)
												num13 = gClass2.gclass120_0[n].int_0;
											if (num12 <= num13)
											{
												if (num12 >= num13)
												{
													if (num12 == num13)
														num14 = num12;
												}
												else
													num14 = num13;
											}
											else
												num14 = num12;
										}
										if (num14 > 0)
										{
											GClass4.gclass4_4.method_10(gclass122_0, num14.ToString(), (!bool_31) ? (int_58 + int_60 - 17) : 160, int_59 + num * int_4, 0, GClass4.gclass4_6);
											gclass122_0.method_33(gclass70_3, (!bool_31) ? (int_58 + int_60 - 11) : 165, int_59 + num * int_4 + 1);
										}
									}
								}
								if (gClass2.int_30 > 1)
									GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass2.int_30, num5 + num7, num6 + num8 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
							}
						}
					}
					else if (bool_31)
					{
						gclass122_0.method_16(15196114);
						gclass122_0.method_15(num5, num3, int_60, num4);
						if (!bool_3)
						{
							if (bool_1)
							{
								gclass122_0.method_31((num != int_67) ? GClass144.gclass70_24 : GClass144.gclass70_25, int_58 + int_60 - 5, num3 + 2, GClass188.int_2);
								((num != int_67) ? GClass4.gclass4_6 : GClass4.gclass4_7).method_6(gclass122_0, mResources.CANCEL, int_58 + int_60 - 22, num3 + 7, 2);
								GClass4.gclass4_16.method_6(gclass122_0, mResources.you + mResources.locked_trade, int_58 + 5, num3 + num4 / 2 - 4, GClass4.int_0);
							}
							else
							{
								gclass122_0.method_31((num != int_67) ? GClass144.gclass70_24 : GClass144.gclass70_25, int_58 + int_60 - 5, num3 + 2, GClass188.int_2);
								((num != int_67) ? GClass4.gclass4_6 : GClass4.gclass4_7).method_6(gclass122_0, mResources.mlock, int_58 + int_60 - 22, num3 + 7, 2);
								GClass4.gclass4_16.method_6(gclass122_0, mResources.you + mResources.not_lock_trade, int_58 + 5, num3 + num4 / 2 - 4, GClass4.int_0);
							}
						}
					}
					else if (bool_2)
					{
						GClass4.gclass4_6.method_6(gclass122_0, mResources.locked_trade_upper, int_58 + int_60 / 2, num3 + num4 / 2 - 4, GClass4.int_2);
					}
					else
					{
						GClass4.gclass4_6.method_6(gclass122_0, mResources.not_lock_trade_upper, int_58 + int_60 / 2, num3 + num4 / 2 - 4, GClass4.int_2);
					}
				}
				num++;
				continue;
			}
			method_100(gclass122_0);
			break;
		}
	}

	private void method_64()
	{
		if (GClass73.bool_13[Main.isPC ? 21 : 2])
		{
			int_148 -= 5;
			int_18 = int_148 - (int_59 + int_61 / 2);
			if (int_148 < int_59)
				int_148 = int_59;
		}
		if (GClass73.bool_13[Main.isPC ? 22 : 8])
		{
			int_148 += 5;
			int_18 = int_148 - (int_59 + int_61 / 2);
			if (int_148 > int_59 + 200)
				int_148 = int_59 + 200;
		}
		if (GClass73.bool_13[(!Main.isPC) ? 4 : 23])
		{
			int_147 -= 5;
			int_17 = int_147 - int_60 / 2;
			if (int_147 < 16)
				int_147 = 16;
		}
		if (GClass73.bool_13[Main.isPC ? 24 : 6])
		{
			int_147 += 5;
			int_17 = int_147 - int_60 / 2;
			if (int_147 > 250)
				int_147 = 250;
		}
		if (GClass73.bool_14)
		{
			bool_13 = true;
			if (!bool_5)
			{
				int_24 = int_17;
				int_25 = int_18;
				bool_5 = true;
			}
			int_17 = int_24 + (GClass73.int_4 - GClass73.int_0);
			int_18 = int_25 + (GClass73.int_5 - GClass73.int_1);
		}
		if (GClass73.bool_16)
		{
			bool_5 = false;
			GClass73.int_4 = GClass73.int_0;
			GClass73.int_5 = GClass73.int_1;
			int_26 = GClass73.int_4 + int_17;
			int_27 = GClass73.int_5 + int_18;
		}
		if (GClass73.bool_15)
			bool_13 = false;
		if (int_17 < 0)
			int_17 = 0;
		if (int_17 > int_19)
			int_17 = int_19;
		if (int_18 < 0)
			int_18 = 0;
		if (int_18 > int_20)
			int_18 = int_20;
	}

	private void method_65()
	{
		if (int_29 == 0)
		{
			method_72();
			int_103 = -1;
			if (int_67 == gclass88_0.method_2() && GClass73.bool_15)
			{
				GClass73.bool_15 = false;
				int_103 = 1;
			}
		}
		if (int_29 == 1)
			method_72();
	}

	private void method_66()
	{
		if (GClass73.bool_13[(!Main.isPC) ? 2 : 21])
			int_21 -= 5;
		if (GClass73.bool_13[(!Main.isPC) ? 8 : 22])
			int_21 += 5;
		if (int_21 < 0)
			int_21 = 0;
		int num = int_134 * 12 - (int_61 - 60);
		if (num < 0)
			num = 0;
		if (int_21 > num)
			int_21 = num;
		if (gclass179_0 != null)
		{
			if (!GClass73.bool_5)
				gclass179_0.int_3 = int_21;
			gclass179_0.method_1();
		}
		int num2 = int_58 + int_60 / 2 - 35;
		int num3 = ((GClass73.int_11 > 300) ? 20 : 15);
		int num4 = int_59 + int_61 - num3 - 15;
		int num5 = GClass73.int_0;
		int num6 = GClass73.int_1;
		int_104 = -1;
		if (bool_20 && !GClass144.smethod_8().method_2() && num5 >= num2 && num5 <= num2 + 70 && num6 >= num4 && num6 <= num4 + 30 && (gclass179_0 == null || !gclass179_0.bool_0))
		{
			int_104 = 1;
			if (GClass73.bool_16)
			{
				GClass109.smethod_1().method_35();
				int_99 = 2;
				GClass73.smethod_49();
			}
		}
	}

	private void method_67()
	{
		bool_9 = false;
		if (int_28 != 0 || string_3.Length != 5 || int_29 != 3)
			return;
		bool_9 = false;
		if (int_67 != 0)
		{
			if (int_67 != 1 && !bool_10 && int_67 > 0)
			{
				int_32 = new int[1];
				for (int i = 0; i < int_32.Length; i++)
				{
					int_32[i] = i;
				}
				bool_9 = true;
			}
		}
		else
		{
			int_32 = new int[string_19.Length];
			for (int j = 0; j < int_32.Length; j++)
			{
				int_32[j] = j;
			}
			if (!bool_12)
				bool_9 = true;
		}
	}

	private void method_68()
	{
		if (int_32 == null)
			return;
		if (!GClass73.bool_11[(!Main.isPC) ? 4 : 23])
		{
			if (GClass73.bool_11[(!Main.isPC) ? 6 : 24])
			{
				gclass189_0 = method_110();
				int_68++;
				if (int_67 == 0 && int_68 > int_32.Length - 1)
					int_68 = 0;
				if (int_67 > 1 && bool_11 && gclass189_0.string_2 != null && int_68 > gclass189_0.string_2.Length - 1)
					int_68 = 0;
			}
		}
		else
		{
			gclass189_0 = method_110();
			int_68--;
			if (int_67 == 0 && int_68 < 0)
				int_68 = int_32.Length - 1;
			if (int_67 > 1 && bool_11 && gclass189_0.string_2 != null && int_68 < 0)
				int_68 = gclass189_0.string_2.Length - 1;
		}
	}

	private void method_69()
	{
		method_72();
		method_68();
	}

	private void method_70()
	{
		try
		{
			if (int_28 != 0 || int_29 != 3 || string_3.Length != 5 || int_67 == -1)
				return;
			int num = 0;
			if (int_67 != 0)
			{
				gclass189_0 = method_110();
				if (gclass189_0 != null && gclass189_0.string_2 != null)
				{
					num = int_58 + int_60 - 2 - gclass189_0.string_2.Length * 40;
					int_68 = (GClass73.int_0 - num) / 40;
				}
			}
			else
			{
				num = int_58 + int_60 / 2 - string_19.Length * int_5 / 2;
				int_68 = (GClass73.int_0 - num) / int_5;
			}
			if (GClass73.int_0 < num)
				int_68 = -1;
		}
		catch (Exception ex)
		{
			GClass50.smethod_8("Throw err " + ex.StackTrace);
		}
	}

	public void method_71(int a)
	{
		bool flag = false;
		if (GClass73.int_6 > int_60)
			return;
		if (int_105 == -1)
			int_105 = int_67;
		if (a > 0)
		{
			int_105 -= a;
			flag = true;
		}
		else if (a < 0)
		{
			int_105 += -a;
			flag = true;
		}
		if (int_105 < 0)
			int_105 = 0;
		if (flag)
		{
			int_7 = int_105 * 12;
			if (int_7 > int_11)
				int_7 = int_11;
			if (int_7 < 0)
				int_7 = 0;
		}
	}

	private void method_72()
	{
		if (int_41 <= 0)
			return;
		bool flag = false;
		if (GClass73.bool_11[(!Main.isPC) ? 2 : 21])
		{
			flag = true;
			int_67--;
			if (int_28 != 24)
			{
				if (int_67 < 0)
				{
					if (Equals(GClass73.gclass76_0) && int_57 == 2 && int_29 <= 3 && int_37[int_29] > 1)
					{
						GClass130.smethod_1();
						if (int_38[int_29] <= 0)
							GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_37[int_29] - 1, -1);
						else
							GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] - 1, -1);
						return;
					}
					int_67 = int_41 - 1;
					if (bool_9)
						int_67 = -1;
					if (sbyte_18 > 0)
						int_67 = -1;
				}
			}
			else
			{
				int_67 -= 2;
				if (int_67 < 0)
					int_67 = 0;
			}
			int_42[int_29] = int_67;
			int_68 = 0;
			method_67();
		}
		else if (GClass73.bool_11[Main.isPC ? 22 : 8])
		{
			flag = true;
			int_67++;
			if (int_28 != 24)
			{
				if (int_67 > int_41 - 1)
				{
					if (Equals(GClass73.gclass76_0) && int_57 == 2 && int_29 <= 3 && int_37[int_29] > 1)
					{
						GClass130.smethod_1();
						if (int_38[int_29] >= int_37[int_29] - 1)
							GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, 0, -1);
						else
							GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] + 1, -1);
						return;
					}
					int_67 = 0;
				}
			}
			else
			{
				int_67 += 2;
				if (int_67 > int_41 - 1)
					int_67 = int_41 - 1;
			}
			int_42[int_29] = int_67;
			int_68 = 0;
			method_67();
		}
		if (flag)
		{
			int_7 = int_67 * int_4 - int_61 / 2;
			if (int_7 > int_11)
				int_7 = int_11;
			if (int_7 < 0)
				int_7 = 0;
			int_8 = int_7;
		}
		if (GClass73.bool_14)
		{
			bool_16 = false;
			if (bool_13 || !GClass73.smethod_48(int_58, int_59, int_60, int_61))
			{
				if (bool_13)
				{
					int_96++;
					if (int_96 > 5 && int_97 == GClass73.int_1 && !bool_14)
					{
						int_97 = -1000;
						int_67 = (int_7 + GClass73.int_1 - int_59) / int_4;
						if (int_67 >= int_41)
							int_67 = -1;
						method_70();
					}
					else
						int_105 = -1;
					int num = GClass73.int_1 - int_98[0];
					if (num != 0 && int_67 != -1)
					{
						int_67 = -1;
						int_68 = -1;
					}
					for (int num2 = int_98.Length - 1; num2 > 0; num2--)
					{
						int_98[num2] = int_98[num2 - 1];
					}
					int_98[0] = GClass73.int_1;
					int_7 -= num;
					if (int_7 < 0)
						int_7 = 0;
					if (int_7 > int_11)
						int_7 = int_11;
					if (int_8 < 0 || int_8 > int_11)
						num /= 2;
					int_8 -= num;
					if (int_8 < -(GClass73.int_11 / 3))
						bool_15 = true;
					else
						bool_15 = false;
				}
			}
			else
			{
				for (int i = 0; i < int_98.Length; i++)
				{
					int_98[0] = GClass73.int_1;
				}
				int_97 = GClass73.int_1;
				bool_13 = true;
				bool_14 = int_100 != 0;
				int_100 = 0;
			}
		}
		if (!GClass73.bool_16 || !bool_13)
			return;
		bool_16 = true;
		int i2 = GClass73.int_1 - int_98[0];
		GClass73.bool_16 = false;
		if (GClass50.smethod_28(i2) < 20 && GClass50.smethod_28(GClass73.int_1 - int_97) < 20 && !bool_14)
		{
			int_100 = 0;
			int_7 = int_8;
			int_97 = -1000;
			int_67 = (int_7 + GClass73.int_1 - int_59) / int_4;
			if (int_67 >= int_41)
				int_67 = -1;
			method_70();
			int_96 = 0;
			int_99 = 10;
			GClass109.smethod_1().method_40();
		}
		else if (int_67 != -1 && int_96 > 5)
		{
			int_96 = 0;
			int_99 = 1;
		}
		else if (int_67 == -1 && !bool_14)
		{
			if (int_8 >= 0)
			{
				if (int_8 <= int_11)
				{
					int num3 = GClass73.int_1 - int_98[0] + (int_98[0] - int_98[1]) + (int_98[1] - int_98[2]);
					int_100 = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
				}
				else
					int_7 = int_11;
			}
			else
				int_7 = 0;
		}
		bool_13 = false;
		int_96 = 0;
		GClass73.bool_16 = false;
	}

	public string method_73(string[] str)
	{
		return null;
	}

	private void method_74()
	{
		if ((gclass179_0 != null && gclass179_0.bool_0) || bool_13)
			return;
		int num = int_29;
		if (method_216() && bool_30)
		{
			if (int_67 != -1)
			{
				if (int_67 > 0)
				{
					if (!GClass73.bool_11[8])
					{
						if (GClass73.bool_11[2])
						{
							if (int_69 != 0)
								int_115 -= 5;
							else
								int_115--;
						}
						else if (GClass73.bool_11[4])
						{
							if (int_69 != 0)
								int_115--;
							else
								int_115 -= 5;
						}
						else if (GClass73.bool_11[6])
						{
							if (int_69 == 0)
								int_115 += 5;
							else
								int_115++;
						}
					}
					else if (int_69 == 0)
					{
						int_115++;
					}
					else
					{
						int_115 += 5;
					}
				}
			}
			else
			{
				if (GClass73.bool_11[6])
				{
					int_29++;
					if (int_29 >= string_2.Length)
					{
						if (GClass73.gclass76_1 == null)
							int_29 = 0;
						else
						{
							int_29 = string_2.Length - 1;
							GClass73.bool_22 = true;
						}
					}
					int_67 = int_42[int_29];
					int_31[int_28] = int_29;
				}
				if (GClass73.bool_11[4])
				{
					int_29--;
					if (int_29 < 0)
						int_29 = string_2.Length - 1;
					if (GClass73.bool_22)
						GClass73.bool_22 = false;
					int_67 = int_42[int_29];
					int_31[int_28] = int_29;
				}
			}
			if (int_115 < 0)
				;
			if (int_115 == int_107)
				int_115 = 0;
		}
		else if (!method_219())
		{
			if (GClass73.bool_11[(!Main.isPC) ? 6 : 24])
			{
				if (!method_216())
				{
					int_29++;
					if (int_29 >= string_2.Length)
					{
						if (GClass73.gclass76_1 == null)
							int_29 = 0;
						else
						{
							int_29 = string_2.Length - 1;
							GClass73.bool_22 = true;
						}
					}
					int_67 = int_42[int_29];
					int_31[int_28] = int_29;
				}
				else if (int_67 < 0)
				{
					int_29++;
					if (int_29 >= string_2.Length)
					{
						if (GClass73.gclass76_1 == null)
							int_29 = 0;
						else
						{
							int_29 = string_2.Length - 1;
							GClass73.bool_22 = true;
						}
					}
					int_67 = int_42[int_29];
					int_31[int_28] = int_29;
				}
				else
				{
					method_217();
				}
			}
			if (GClass73.bool_11[Main.isPC ? 23 : 4])
			{
				int_29--;
				if (int_29 < 0)
					int_29 = string_2.Length - 1;
				if (GClass73.bool_22)
					GClass73.bool_22 = false;
				int_67 = int_42[int_29];
				int_31[int_28] = int_29;
			}
		}
		int_106 = -1;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (!GClass73.smethod_48(int_30 + i * int_5, 52, int_5 - 1, 25))
				continue;
			int_106 = i;
			if (GClass73.bool_16)
			{
				int_29 = i;
				int_31[int_28] = i;
				GClass73.bool_16 = false;
				int_67 = int_42[int_29];
				if (num == int_29 && int_100 == 0)
				{
					int_7 = 0;
					int_67 = (GClass73.bool_5 ? (-1) : 0);
				}
				break;
			}
		}
		if (num == int_29)
			return;
		sbyte_18 = 0;
		GClass109.smethod_1().method_40();
		int num2 = int_28;
		if (num2 <= 12)
		{
			switch (num2)
			{
			default:
				if (num2 == 12)
				{
					if (int_29 == 0)
						method_36();
					if (int_29 == 1)
						method_88();
				}
				break;
			case 0:
				if (int_29 == 0)
					method_90();
				if (int_29 == 1)
					method_88();
				if (int_29 == 2)
					method_83();
				if (int_29 == 3)
				{
					if (string_3.Length <= 4)
						method_77();
					else
						method_79();
				}
				if (int_29 == 4)
					method_77();
				break;
			case 1:
				method_82();
				break;
			case 2:
				if (int_29 == 0)
					method_86();
				if (int_29 == 1)
					method_88();
				break;
			case 3:
				method_85();
				break;
			}
		}
		else if (num2 != 13)
		{
			switch (num2)
			{
			case 21:
				if (int_29 == 0)
					method_87();
				if (int_29 == 1)
					method_75();
				if (int_29 == 2)
					method_88();
				break;
			case 23:
				GClass162.smethod_0().method_3();
				break;
			case 25:
				method_211();
				break;
			}
		}
		else
		{
			if (int_29 == 0)
			{
				if (Equals(GClass73.gclass76_0))
					method_88();
				else if (Equals(GClass73.gclass76_1))
				{
					method_61(false);
				}
			}
			if (int_29 == 1)
				method_61(true);
			if (int_29 == 2)
				method_61(false);
		}
		int_67 = int_42[int_29];
	}

	private void method_75()
	{
		int_41 = string_22.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	private void method_76()
	{
	}

	private void method_77()
	{
		GClass109.smethod_1().method_1();
		int_41 = string_6.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	public void method_78()
	{
		if (!bool_10)
		{
			if (!bool_12)
			{
				if (bool_11)
				{
					int_41 = GClass189.gclass88_0.method_2() + 2;
					string_20 = mResources.msg;
					string_21 = "";
				}
			}
			else
			{
				string_21 = "";
				int_41 = ((gclass88_1 == null) ? gclass88_2.method_2() : gclass88_1.method_2()) + 2;
				string_20 = mResources.member + " " + ((gclass106_0 != null) ? gclass106_0.string_0 : GClass78.smethod_1().gclass106_0.string_0);
			}
		}
		else
		{
			int_41 = ((gclass106_1 == null) ? 2 : (gclass106_1.Length + 2));
			string_20 = mResources.clan_list;
		}
		if (GClass78.smethod_1().gclass106_0 != null)
		{
			if (bool_12)
			{
				if (GClass78.smethod_1().sbyte_17 <= 0)
				{
					if (gclass88_2.method_2() <= 1)
						string_19 = new string[3][]
						{
							mResources.msgg,
							mResources.khau_hieuu,
							mResources.bieu_tuongg
						};
					else
						string_19 = new string[4][]
						{
							mResources.msgg,
							mResources.leaveClan,
							mResources.khau_hieuu,
							mResources.bieu_tuongg
						};
				}
				else
					string_19 = new string[2][]
					{
						mResources.msgg,
						mResources.leaveClan
					};
			}
			else if (gclass88_2.method_2() <= 1)
			{
				string_19 = new string[1][] { mResources.memberr };
			}
			else
			{
				string_19 = new string[3][]
				{
					mResources.chatClan,
					mResources.request_pea2,
					mResources.memberr
				};
			}
		}
		else
			string_19 = new string[2][]
			{
				mResources.findClan,
				mResources.createClan
			};
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	public void method_79()
	{
		GClass144.bool_60 = false;
		int_4 = 24;
		if (int_42 != null && int_42[3] == 0)
			int_42[3] = -1;
		int_41 = 2;
		if (GClass78.smethod_1().gclass106_0 == null)
		{
			bool_11 = false;
			bool_12 = false;
			bool_10 = true;
		}
		else
		{
			bool_11 = true;
			bool_12 = false;
			bool_10 = false;
		}
		if (GClass78.smethod_1().gclass106_0 != null)
			int_41 = GClass189.gclass88_0.method_2() + 2;
		method_78();
		int_68 = -1;
		if (gclass91_0 == null)
		{
			gclass91_0 = new GClass91();
			gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
			gclass91_0.method_0();
			gclass91_0.ginterface4_0 = GClass73.gclass76_0;
		}
		if (GClass78.smethod_1().gclass106_0 == null)
		{
			string_21 = mResources.findingClan;
			GClass7.smethod_0().method_23("");
		}
		int_67 = int_42[int_29];
		if (GClass73.bool_5)
			int_67 = -1;
	}

	public void method_80()
	{
		int_41 = gclass88_3.method_2() + 1;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		int num;
		if (int_8 < 0)
		{
			num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	private void method_81()
	{
		int_4 = 24;
		method_80();
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public void method_82()
	{
		int_4 = 24;
		if (int_29 != string_2.Length - 1 || GClass73.gclass76_1 != null || int_57 == 2)
			int_41 = GClass78.smethod_1().gclass128_3[int_29].Length;
		else
			int_41 = GClass78.smethod_1().gclass128_2.Length + GClass78.smethod_1().gclass128_0.Length;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_83()
	{
		int_4 = 30;
		int_41 = GClass78.smethod_1().gclass176_0.gclass47_0.Length + 6;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = int_11;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_84()
	{
		int_4 = 24;
		int_41 = string_4.Length;
		int_11 = int_41 * int_4 - int_61;
		int_7 = 0;
		int_8 = 0;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_85()
	{
		int_4 = 24;
		int_41 = GClass144.smethod_8().int_61.Length;
		int_11 = int_41 * int_4 - int_61;
		int_7 = 0;
		int_8 = 0;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_86()
	{
		int_41 = GClass78.smethod_1().gclass128_1.Length;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 9;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_87()
	{
		int_4 = 24;
		GClass128[] gclass128_ = GClass78.smethod_2().gclass128_2;
		GClass63[] gclass63_ = GClass78.smethod_2().gclass63_1;
		int_41 = gclass128_.Length + gclass63_.Length;
		int_11 = int_41 * int_4 - int_61;
		int_8 = (int_7 = int_13[int_29]);
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_88()
	{
		int_41 = GClass78.smethod_1().gclass128_2.Length + GClass78.smethod_1().gclass128_0.Length;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_61;
		int_8 = (int_7 = int_13[int_29]);
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	private void method_89()
	{
		if (!bool_20)
			return;
		if (GClass20.sbyte_3 != GClass20.sbyte_2)
		{
			GClass50.smethod_8("LOAD TAM HINH");
			gclass70_2 = GClass73.smethod_42("/img/map" + GClass20.sbyte_2 + ".png");
			GClass20.sbyte_3 = GClass20.sbyte_2;
		}
		int_17 = method_1() - int_60 / 2;
		int_18 = method_2() + int_59 - (int_59 + int_61 / 2);
		int_24 = int_17;
		int_25 = int_18;
		int_19 = 250 - int_60;
		int_20 = 220 - int_61;
		if (int_19 < 0)
			int_19 = 0;
		if (int_20 < 0)
			int_20 = 0;
		for (int i = 0; i < int_52[GClass20.sbyte_2].Length; i++)
		{
			if (GClass20.int_37 == int_52[GClass20.sbyte_2][i])
			{
				int_147 = int_53[GClass20.sbyte_2][i] + int_58;
				int_148 = int_54[GClass20.sbyte_2][i] + int_59 + 5;
				break;
			}
		}
		int_143 = method_1() + int_58;
		int_144 = method_2() + int_59;
		int_145 = method_3() + int_58;
		int_146 = method_4() + int_59;
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	private void method_90()
	{
		int_21 = 0;
	}

	public void method_91()
	{
		if (int_64 > 0)
			int_64--;
		if (bool_16 && Equals(GClass73.gclass76_0) && int_57 == 2 && int_37[int_29] > 1)
		{
			if (int_8 < -50)
			{
				GClass130.smethod_1();
				bool_16 = false;
				if (int_38[int_29] > 0)
					GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] - 1, -1);
				else
					GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_37[int_29] - 1, -1);
			}
			else if (int_8 > int_11 + 50)
			{
				bool_16 = false;
				GClass130.smethod_1();
				if (int_38[int_29] >= int_37[int_29] - 1)
					GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, 0, -1);
				else
					GClass7.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] + 1, -1);
			}
		}
		if (int_15 != int_14 && !bool_13)
		{
			int_108 = int_14 - int_15 << 2;
			int_109 += int_108;
			int_15 += int_109 >> 3;
			int_109 &= 15;
		}
		if (GClass118.smethod_0(int_14 - int_15) < 10)
			int_15 = int_14;
		if (bool_21)
		{
			bool_21 = false;
			int_14 = int_60;
		}
		if (int_14 >= int_60 - 10 && int_15 >= int_60 - 10 && int_56 == 0)
		{
			bool_0 = false;
			method_149();
			if (bool_23)
			{
				bool_23 = false;
				if (GClass78.smethod_1().int_25 > 0 && GClass78.smethod_1().int_11 != 14)
				{
					GClass130.smethod_1();
					if (int_28 != 3)
					{
						if (int_28 == 14)
							GClass148.smethod_0().method_5(int_67);
					}
					else
						GClass7.smethod_0().method_42(int_67, -1);
				}
			}
			if (bool_18)
			{
				bool_18 = false;
				int num = gclass88_4.method_2() - gclass88_11.method_2();
				if (GClass78.smethod_1().gclass78_0 != null)
				{
					if (int_67 - num < 0)
						GClass78.smethod_1().gclass78_0.int_16 = int_67;
					else
						GClass78.smethod_1().gclass78_0.int_16 = short.Parse((string)gclass88_11.method_3(int_67 - num));
				}
				((GClass87)gclass88_4.method_3(int_67)).method_1();
			}
			gclass88_4.method_9();
			gclass78_0 = null;
		}
		if (int_100 != 0 && !bool_13)
		{
			int_7 += int_100 / 100;
			if (int_7 >= 0)
			{
				if (int_7 > int_11)
					int_7 = int_11;
				else
					int_8 = int_7;
			}
			else
				int_7 = 0;
			int_100 = int_100 * 9 / 10;
			if (int_100 < 100 && int_100 > -100)
				int_100 = 0;
		}
		if (int_8 != int_7 && !bool_13)
		{
			int_10 = int_7 - int_8 << 2;
			int_9 += int_10;
			int_8 += int_9 >> 4;
			int_9 &= 15;
		}
		int_13[int_29] = int_8;
	}

	public void method_92(GClass122 g)
	{
		if (gclass96_0 == null || gclass96_0.string_0 == null)
			return;
		gclass96_0.paint(g);
		int num = gclass96_0.int_3 + 13;
		int num2 = gclass96_0.int_4 + 11;
		if (int_28 == 15)
		{
			num += 5;
			num2 += 26;
		}
		if (int_28 == 0 && int_29 == 3)
		{
			if (!bool_10)
			{
				if (int_63 != null || gclass78_1 != null)
				{
					num = gclass96_0.int_3 + 21;
					num2 = gclass96_0.int_4 + 40;
				}
			}
			else
				num -= 5;
		}
		if (int_63 != null)
		{
			GClass116 gClass = GClass144.gclass116_0[int_63[0]];
			GClass116 gClass2 = GClass144.gclass116_0[int_63[1]];
			GClass116 gClass3 = GClass144.gclass116_0[int_63[2]];
			GClass28.smethod_6(g, gClass.gclass66_0[GClass78.int_94[0][0][0]].short_0, num + GClass78.int_94[0][0][1] + gClass.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num2 - GClass78.int_94[0][0][2] + gClass.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1, 0, 0);
			GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[0][1][0]].short_0, num + GClass78.int_94[0][1][1] + gClass2.gclass66_0[GClass78.int_94[0][1][0]].sbyte_0, num2 - GClass78.int_94[0][1][2] + gClass2.gclass66_0[GClass78.int_94[0][1][0]].sbyte_1, 0, 0);
			GClass28.smethod_6(g, gClass3.gclass66_0[GClass78.int_94[0][2][0]].short_0, num + GClass78.int_94[0][2][1] + gClass3.gclass66_0[GClass78.int_94[0][2][0]].sbyte_0, num2 - GClass78.int_94[0][2][2] + gClass3.gclass66_0[GClass78.int_94[0][2][0]].sbyte_1, 0, 0);
		}
		else if (gclass78_1 != null)
		{
			gclass78_1.method_98(g, num + 5, num2 + 25, 1, 0, true);
		}
		else if (int_62 != -1)
		{
			GClass28.smethod_6(g, int_62, num, num2, 0, 3);
		}
		if (gclass128_0 == null || gclass128_0.gclass117_0.sbyte_0 == 5)
			return;
		if (gclass128_0.int_43 <= 0)
		{
			if (gclass128_0.int_43 < 0 && gclass128_0.int_43 != -1)
			{
				g.method_31(gclass70_12, num - 7, num2 + 13, 3);
				GClass4.gclass4_1.method_6(g, GClass50.smethod_28(gclass128_0.int_43) + "", num + 1, num2 + 8, 0);
			}
		}
		else
		{
			g.method_31(gclass70_11, num - 7, num2 + 13, 3);
			GClass4.gclass4_8.method_6(g, GClass50.smethod_28(gclass128_0.int_43) + "", num + 1, num2 + 8, 0);
		}
	}

	public void method_93(GClass122 g)
	{
		g.method_5(int_58, int_59, int_60, int_61);
		g.method_1(0, -int_8);
		g.method_16(0);
		if (int_41 == 0)
			return;
		int num = (int_8 + int_61) / 24 + 1;
		if (num < int_61 / 24 + 1)
			num = int_61 / 24 + 1;
		if (num > int_41)
			num = int_41;
		int num2 = int_8 / 24;
		if (num2 >= num)
			num2 = num - 1;
		if (num2 < 0)
			num2 = 0;
		for (int i = num2; i < num; i++)
		{
			int num3 = int_58;
			int num4 = int_59 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num5 = int_58 + 24;
			int num6 = int_59 + i * int_4;
			int num7 = int_60 - 24;
			int num8 = int_4 - 1;
			g.method_16((i != int_67) ? 15196114 : 16383818);
			g.method_15(num5, num6, num7, num8);
			g.method_16((i != int_67) ? 9993045 : 9541120);
			g.method_15(num3, num4, w, h);
			GClass114 gClass = (GClass114)gclass88_8.method_3(i);
			if (gClass.int_1 == -1)
			{
				GClass116 gClass2 = GClass144.gclass116_0[gClass.int_0];
				GClass28.smethod_6(g, gClass2.gclass66_0[GClass78.int_94[0][0][0]].short_0, num3 + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num4 + num8 - 1, 0, GClass122.int_5 | GClass122.int_2);
			}
			else
				GClass28.smethod_6(g, gClass.int_1, num3, num4, 0, 0);
			g.method_5(int_58, int_59 + int_8, int_60, int_61);
			if (gClass.int_2 == GClass78.smethod_1().int_13)
				GClass4.gclass4_1.method_6(g, gClass.string_0, num5 + 5, num6, 0);
			else
				GClass4.gclass4_8.method_6(g, gClass.string_0, num5 + 5, num6, 0);
			GClass4.gclass4_18.method_6(g, gClass.string_1, num5 + num7 - 5, num6 + 11, 1);
			GClass4.gclass4_14.method_6(g, mResources.rank + ": " + gClass.int_3 + "", num5 + 5, num6 + 11, 0);
		}
		method_100(g);
	}

	public void method_94(GClass122 g)
	{
		g.method_1(-g.method_3(), -g.method_4() + GClass122.int_24);
		g.method_1(-int_15, 0);
		g.method_1(int_0, int_1);
		if (GClass73.gclass76_0.sbyte_8 != -1)
		{
			if (Equals(GClass73.gclass76_0))
				method_197(g);
			return;
		}
		GClass73.gclass192_0.method_35(int_0, int_1, int_2, int_3, g);
		method_138(g);
		method_122(g);
		method_121(g);
		int num = int_28;
		switch (num)
		{
		default:
			if (num == 100)
				GClass162.smethod_0().method_15(g);
			break;
		case 0:
			if (int_29 == 0)
				method_146(g);
			if (int_29 == 1)
				method_120(g);
			if (int_29 == 2)
				method_104(g);
			if (int_29 == 3)
			{
				if (string_3.Length != 4)
					method_117(g);
				else
					method_101(g);
			}
			if (int_29 == 4)
				method_101(g);
			break;
		case 1:
			method_95(g);
			break;
		case 2:
			if (int_29 == 0)
				method_108(g);
			if (int_29 == 1)
				method_120(g);
			break;
		case 3:
			method_106(g);
			break;
		case 4:
			method_145(g);
			break;
		case 7:
			method_120(g);
			break;
		case 8:
			method_112(g);
			break;
		case 9:
			method_118(g);
			break;
		case 10:
			method_116(g);
			break;
		case 11:
			method_115(g);
			break;
		case 12:
			if (int_29 == 0)
				method_119(g);
			if (int_29 == 1)
				method_120(g);
			break;
		case 13:
			if (int_29 == 0)
			{
				if (Equals(GClass73.gclass76_0))
					method_120(g);
				else
					method_63(g, false);
			}
			if (int_29 == 1)
				method_63(g, true);
			if (int_29 == 2)
				method_63(g, false);
			break;
		case 14:
			method_105(g);
			break;
		case 15:
			method_93(g);
			break;
		case 16:
			method_114(g);
			break;
		case 17:
			method_95(g);
			break;
		case 18:
			method_113(g);
			break;
		case 19:
			method_203(g);
			break;
		case 20:
			method_207(g);
			break;
		case 21:
			if (int_29 == 0)
				method_99(g);
			if (int_29 == 1)
				method_97(g);
			if (int_29 == 2)
				method_120(g);
			break;
		case 22:
			method_96(g);
			break;
		case 23:
			GClass162.smethod_0().method_5(g);
			break;
		case 24:
			method_102(g);
			break;
		case 25:
			method_107(g);
			break;
		case 5:
		case 6:
			break;
		}
		GClass144.smethod_18(g);
		method_92(g);
		if (int_15 == int_14)
			gclass87_1.method_3(g);
		if (gclass84_0 != null && gclass84_0.bool_0)
			gclass84_0.method_6(g);
		g.method_1(-g.method_3(), -g.method_4());
		g.method_1(int_0, int_1);
		g.method_1(-int_15, 0);
	}

	private void method_95(GClass122 gclass122_0)
	{
		try
		{
			if (int_28 != 1 || int_29 != string_2.Length - 1 || GClass73.gclass76_1 != null || int_57 == 2)
			{
				gclass122_0.method_16(16711680);
				gclass122_0.method_5(int_58, int_59, int_60, int_61);
				if (int_57 == 2 && Equals(GClass73.gclass76_0))
				{
					if (int_29 <= 3 && GClass73.bool_5)
					{
						if (int_8 >= -50)
						{
							if (int_8 >= 0)
							{
								if (int_11 >= 0)
								{
									if (int_8 > int_11 + 50)
										GClass73.smethod_47(int_58 + int_60 / 2, int_59 + int_61 - 30, gclass122_0);
									else if (int_8 > int_11)
									{
										GClass4.gclass4_16.method_6(gclass122_0, mResources.getUp, int_58 + int_60 / 2, int_59 + int_61 - 25, 2);
									}
								}
							}
							else
								GClass4.gclass4_16.method_6(gclass122_0, mResources.getDown, int_58 + int_60 / 2, int_59 + 15, 2);
						}
						else
							GClass73.smethod_47(int_58 + int_60 / 2, int_59 + 30, gclass122_0);
					}
					if (GClass78.smethod_1().gclass128_3[int_29].Length == 0 && int_28 != 17)
					{
						GClass4.gclass4_16.method_6(gclass122_0, mResources.notYetSell, int_58 + int_60 / 2, int_59 + int_61 / 2 - 10, 2);
						return;
					}
				}
				gclass122_0.method_1(0, -int_8);
				GClass128[] array = GClass78.smethod_1().gclass128_3[int_29];
				if (int_57 == 2 && (int_29 == 4 || int_28 == 17))
				{
					array = GClass78.smethod_1().gclass128_3[4];
					if (array.Length == 0)
					{
						GClass4.gclass4_16.method_6(gclass122_0, mResources.notYetSell, int_58 + int_60 / 2, int_59 + int_61 / 2 - 10, 2);
						return;
					}
				}
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					int num2 = int_58 + 26;
					int num3 = int_59 + i * int_4;
					int num4 = int_60 - 26;
					int h = int_4 - 1;
					int num5 = int_58;
					int num6 = int_59 + i * int_4;
					int num7 = 24;
					int num8 = int_4 - 1;
					if (num3 - int_8 > int_59 + int_61 || num3 - int_8 < int_59 - int_4)
						continue;
					gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
					gclass122_0.method_15(num2, num3, num4, h);
					gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
					gclass122_0.method_15(num5, num6, num7, num8);
					GClass128 gClass = array[i];
					if (gClass != null)
					{
						string text = "";
						string text2 = "";
						GClass4 gClass2 = GClass4.gclass4_14;
						if (gClass.sbyte_33 != 0 && int_57 == 2 && int_29 <= 3 && !Equals(GClass73.gclass76_1))
							gClass2 = GClass4.gclass4_8;
						if (gClass.gclass120_0 != null)
						{
							for (int j = 0; j < gClass.gclass120_0.Length; j++)
							{
								if (GClass20.int_37 == 45)
								{
									if (gClass.gclass117_0.sbyte_0 != 33 && gClass.gclass117_0.short_0 != 1441)
										text = (gClass.gclass120_0[j].method_0().StartsWith((mResources.language == 0) ? "HSD" : "Expr") ? ((GClass151.int_0 != 0) ? (" [" + gClass.gclass120_0[j].method_0().Split(' ')[1] + " day]") : (" [" + gClass.gclass120_0[j].method_0().Split(' ')[1] + " ngày]")) : ((GClass151.int_0 == 0) ? " [Vĩnh viễn]" : "[Forever]"));
								}
								else
									text = "";
								if (gClass.gclass120_0[j].gclass126_0.int_0 == 72)
									text2 = " [+" + gClass.gclass120_0[j].int_0 + "]";
								if (gClass.gclass120_0[j].gclass126_0.int_0 != 41)
									continue;
								if (gClass.gclass120_0[j].int_0 == 1)
									gClass2 = smethod_6(0);
								else if (gClass.gclass120_0[j].int_0 == 2)
								{
									gClass2 = smethod_6(2);
								}
								else if (gClass.gclass120_0[j].int_0 != 3)
								{
									if (gClass.gclass120_0[j].int_0 == 4)
										gClass2 = smethod_6(7);
								}
								else
								{
									gClass2 = smethod_6(8);
								}
							}
						}
						((text == ((GClass151.int_0 != 0) ? "[Forever]" : " [Vĩnh viễn]")) ? GClass4.gclass4_1 : GClass4.gclass4_14).method_6(gclass122_0, text, int_58 + int_60, int_59 + i * int_4, GClass4.int_1);
						gClass2.method_6(gclass122_0, gClass.gclass117_0.string_0 + text2, num2 + 5, num3 + 1, 0);
						string text3 = "";
						if (gClass.gclass120_0 != null && gClass.gclass120_0.Length >= 1)
						{
							if (gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
								text3 += gClass.gclass120_0[0].method_0();
							GClass4 gClass3 = GClass4.gclass4_18;
							if (gClass.int_43 < 0 && gClass.gclass117_0.sbyte_0 != 5)
								gClass3 = GClass4.gclass4_17;
							if (int_57 == 2 && gClass.gclass120_0.Length > 1 && gClass.sbyte_32 != -1)
								text3 += "";
							if (int_57 != 2 || (int_57 == 2 && gClass.sbyte_32 <= 1))
								gClass3.method_6(gclass122_0, text3, num2 + 5, num3 + 11, 0);
						}
						if (gClass.int_39 > 0)
						{
							GClass28.smethod_6(gclass122_0, gClass.short_0, num2 + num4 - 7, num3 + 9, 0, 3);
							GClass4.gclass4_2.method_6(gclass122_0, GClass50.smethod_31(gClass.int_39), num2 + num4 - 15, num3 + 1, GClass4.int_1);
						}
						if (gClass.int_34 != 0 || gClass.int_36 != 0)
						{
							if (int_57 != 2 && gClass.long_0 == 0L)
							{
								if (gClass.int_34 <= 0 || gClass.int_36 <= 0)
								{
									if (gClass.int_34 > 0)
									{
										gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 7, 3);
										GClass4.gclass4_6.method_6(gclass122_0, GClass50.smethod_31(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
									if (gClass.int_36 > 0)
									{
										gclass122_0.method_31(gclass70_9, num2 + num4 - 7, num3 + 7, 3);
										GClass4.gclass4_8.method_6(gclass122_0, GClass50.smethod_31(gClass.int_36), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
								}
								else
								{
									if (gClass.int_34 > 0)
									{
										gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 7, 3);
										GClass4.gclass4_6.method_6(gclass122_0, GClass50.smethod_31(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
									if (gClass.int_36 > 0)
									{
										gclass122_0.method_31(gclass70_9, num2 + num4 - 7, num3 + 7 + 11, 3);
										GClass4.gclass4_8.method_6(gclass122_0, GClass50.smethod_31(gClass.int_36), num2 + num4 - 15, num3 + 12, GClass4.int_1);
									}
								}
							}
							if (int_57 == 2 && int_29 <= 3 && !Equals(GClass73.gclass76_1))
							{
								if (gClass.int_34 <= 0 || gClass.int_36 <= 0)
								{
									if (gClass.int_34 > 0)
									{
										gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 7, 3);
										((GClass78.smethod_1().long_6 >= gClass.int_34) ? GClass4.gclass4_6 : GClass4.gclass4_1).method_6(gclass122_0, GClass50.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
									if (gClass.int_36 > 0)
									{
										gclass122_0.method_31(gclass70_9, num2 + num4 - 7, num3 + 7, 3);
										((GClass78.smethod_1().int_68 >= gClass.int_36) ? GClass4.gclass4_8 : GClass4.gclass4_1).method_6(gclass122_0, GClass50.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
									try
									{
										gClass2 = GClass4.gclass4_8;
										if (!GClass78.smethod_1().string_3.Equals(gClass.string_3))
											gClass2 = GClass4.gclass4_8;
										gClass2.method_6(gclass122_0, gClass.string_3, num2 + num4, num3 + 1 + GClass4.gclass4_1.method_20(), GClass4.int_1);
									}
									catch (Exception)
									{
									}
								}
								else
								{
									if (gClass.int_34 > 0)
									{
										gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 7, 3);
										((GClass78.smethod_1().long_6 >= gClass.int_34) ? GClass4.gclass4_6 : GClass4.gclass4_1).method_6(gclass122_0, GClass50.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass4.int_1);
									}
									if (gClass.int_36 > 0)
									{
										gclass122_0.method_31(gclass70_9, num2 + num4 - 7, num3 + 7 + 11, 3);
										((GClass78.smethod_1().int_68 < gClass.int_36) ? GClass4.gclass4_1 : GClass4.gclass4_8).method_6(gclass122_0, GClass50.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 12, GClass4.int_1);
									}
								}
							}
						}
						GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
						if (gClass.int_30 > 1)
							GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass.int_30, num5 + num7, num6 + num8 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
						if (gClass.bool_4 && GClass73.int_8 % 10 > 5)
							gclass122_0.method_31(gclass70_6, num5 + num7 / 2, num3 + 19, 3);
					}
					if (int_57 != 2 || (!Equals(GClass73.gclass76_1) && int_29 != 4) || gClass.sbyte_32 == 0)
						continue;
					if (gClass.sbyte_32 == 1)
					{
						GClass4.gclass4_19.method_6(gclass122_0, mResources.dangban, num2 + num4 - 5, num3 + 1, GClass4.int_1);
						if (gClass.int_34 != -1)
						{
							gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 19, 3);
							GClass4.gclass4_6.method_6(gclass122_0, GClass50.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 13, GClass4.int_1);
						}
						else if (gClass.int_36 != -1)
						{
							gclass122_0.method_31(gclass70_10, num2 + num4 - 7, num3 + 17, 3);
							GClass4.gclass4_1.method_6(gclass122_0, GClass50.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 11, GClass4.int_1);
						}
					}
					else if (gClass.sbyte_32 == 2)
					{
						GClass4.gclass4_2.method_6(gclass122_0, mResources.daban, num2 + num4 - 5, num3 + 1, GClass4.int_1);
						if (gClass.int_34 != -1)
						{
							gclass122_0.method_31(gclass70_7, num2 + num4 - 7, num3 + 17, 3);
							GClass4.gclass4_6.method_6(gclass122_0, GClass50.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 11, GClass4.int_1);
						}
						else if (gClass.int_36 != -1)
						{
							gclass122_0.method_31(gclass70_10, num2 + num4 - 7, num3 + 17, 3);
							GClass4.gclass4_1.method_6(gclass122_0, GClass50.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 11, GClass4.int_1);
						}
					}
				}
				method_100(gclass122_0);
			}
			else
				method_120(gclass122_0);
		}
		catch (Exception)
		{
		}
	}

	private void method_96(GClass122 gclass122_0)
	{
	}

	private void method_97(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_22.Length; i++)
		{
			int x = int_58;
			int num = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(x, num, w, h);
				GClass4.gclass4_6.method_6(gclass122_0, string_22[i], int_58 + int_60 / 2, num + 6, GClass4.int_2);
			}
		}
		method_100(gclass122_0);
	}

	private void method_98()
	{
	}

	private void method_99(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		GClass128[] gclass128_ = GClass78.smethod_2().gclass128_2;
		GClass63[] gclass63_ = GClass78.smethod_2().gclass63_1;
		for (int i = 0; i < gclass128_.Length + gclass63_.Length; i++)
		{
			bool flag = i < gclass128_.Length;
			int num = i;
			int num2 = i - gclass128_.Length;
			int num3 = int_58 + 36;
			int num4 = int_59 + i * int_4;
			int w = int_60 - 36;
			int h = int_4 - 1;
			int num5 = int_58;
			int num6 = int_59 + i * int_4;
			int num7 = 34;
			int num8 = int_4 - 1;
			if (num4 - int_8 > int_59 + int_61 || num4 - int_8 < int_59 - int_4)
				continue;
			GClass128 gClass = ((!flag) ? null : gclass128_[num]);
			gclass122_0.method_16((i == int_67) ? 16383818 : ((!flag) ? 15723751 : 15196114));
			gclass122_0.method_15(num3, num4, w, h);
			gclass122_0.method_16((i == int_67) ? 9541120 : ((!flag) ? 11837316 : 9993045));
			if (gClass != null)
			{
				for (int j = 0; j < gClass.gclass120_0.Length; j++)
				{
					if (gClass.gclass120_0[j].gclass126_0.int_0 == 72 && gClass.gclass120_0[j].int_0 > 0)
					{
						sbyte id = smethod_5(gClass.gclass120_0[j].int_0);
						if (smethod_4(id) != -1)
							gclass122_0.method_16((i != int_67) ? smethod_4(id) : smethod_4(id));
					}
				}
			}
			gclass122_0.method_15(num5, num6, num7, num8);
			if (gClass != null && gClass.bool_0 && GClass73.gclass76_0.int_28 == 12)
			{
				gclass122_0.method_16((i != int_67) ? 6047789 : 7040779);
				gclass122_0.method_15(num5, num6, num7, num8);
			}
			if (gClass == null)
			{
				if (!flag)
				{
					GClass63 gClass2 = gclass63_[num2];
					if (gClass2.gclass47_0 != null)
					{
						GClass4.gclass4_18.method_6(gclass122_0, gClass2.gclass47_0.string_0, num3 + 5, num4 + 1, 0);
						GClass4.gclass4_14.method_6(gclass122_0, mResources.level + ": " + gClass2.int_0 + "", num3 + 5, num4 + 11, 0);
						GClass28.smethod_6(gclass122_0, gClass2.gclass47_0.int_4, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
					}
					else
					{
						GClass4.gclass4_14.method_6(gclass122_0, gClass2.string_0, num3 + 5, num4 + 5, 0);
						GClass28.smethod_6(gclass122_0, GClass144.gclass124_0[98].gclass209_0[0].int_2, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
					}
				}
				continue;
			}
			string text = "";
			GClass4 gClass3 = GClass4.gclass4_14;
			if (gClass.gclass120_0 != null)
			{
				for (int k = 0; k < gClass.gclass120_0.Length; k++)
				{
					if (gClass.gclass120_0[k].gclass126_0.int_0 == 72)
					{
						gClass.method_3(gclass122_0, int_58 + 18, int_59 + i * int_4 + 12, gClass.gclass120_0[k].int_0);
						text = " [+" + gClass.gclass120_0[k].int_0 + "]";
					}
					if (gClass.gclass120_0[k].gclass126_0.int_0 != 41)
						continue;
					if (gClass.gclass120_0[k].int_0 != 1)
					{
						if (gClass.gclass120_0[k].int_0 != 2)
						{
							if (gClass.gclass120_0[k].int_0 == 3)
								gClass3 = smethod_6(8);
							else if (gClass.gclass120_0[k].int_0 == 4)
							{
								gClass3 = smethod_6(7);
							}
						}
						else
							gClass3 = smethod_6(2);
					}
					else
						gClass3 = smethod_6(0);
				}
			}
			string text2 = "";
			string text3 = "";
			if (gClass.gclass120_0 != null)
			{
				for (int l = 0; l < gClass.gclass120_0.Length; l++)
				{
					text3 = text3 + gClass.gclass120_0[l].gclass126_0.int_0 + "-";
				}
			}
			foreach (GClass160.GStruct5 item in GClass160.smethod_0().list_4)
			{
				if (gClass.gclass117_0.short_0 == item.int_0 && text3 == item.string_0 && gClass.gclass117_0.sbyte_0 == item.int_1)
				{
					text2 = ((GClass151.int_0 == 0) ? "[ĐT1]: " : "[DS1]: ");
					gclass122_0.method_20(13959423, 0.3f);
					gclass122_0.method_15(num3, num4, w, h);
				}
			}
			foreach (GClass160.GStruct8 item2 in GClass160.smethod_0().list_5)
			{
				if (gClass.gclass117_0.short_0 == item2.int_0 && text3 == item2.string_0 && gClass.gclass117_0.sbyte_0 == item2.int_1)
				{
					text2 = ((GClass151.int_0 != 0) ? "[DS2]: " : "[ĐT2]: ");
					gclass122_0.method_20(13959423, 0.3f);
					gclass122_0.method_15(num3, num4, w, h);
				}
			}
			if (string.IsNullOrEmpty(text2))
				gClass3.method_6(gclass122_0, gClass.gclass117_0.string_0 + text, num3 + 5, num4 + 1, 0);
			else
				GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, text2 + gClass.gclass117_0.string_0 + text, num3 + 5, num4 + 1, 0, GClass4.gclass4_11);
			GClass4.gclass4_1.method_6(gclass122_0, gClass.method_2(), int_58 + int_60, int_59 + i * int_4, GClass4.int_1);
			string text4 = "";
			string text5 = "";
			if (gClass.gclass120_0 != null)
			{
				if (gClass.gclass120_0.Length != 0 && gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
					text4 += gClass.gclass120_0[0].method_0();
				GClass4 gClass4 = GClass4.gclass4_18;
				if (gClass.int_43 < 0 && gClass.gclass117_0.sbyte_0 != 5)
					gClass4 = GClass4.gclass4_17;
				if (gClass.gclass120_0.Length > 1)
				{
					for (int m = 1; m < gClass.gclass120_0.Length; m++)
					{
						if (gClass.gclass120_0[m] != null && gClass.gclass120_0[m].gclass126_0.int_0 != 102 && gClass.gclass120_0[m].gclass126_0.int_0 != 107 && gClass.gclass120_0[m].method_0().StartsWith("Set"))
							text4 = text4 + "," + gClass.gclass120_0[m].method_0();
					}
					for (int n = 1; n < gClass.gclass120_0.Length; n++)
					{
						if (gClass.gclass120_0[n] == null || gClass.method_0())
							continue;
						if ((gClass.gclass117_0.sbyte_0 < 0 || gClass.gclass117_0.sbyte_0 > 4) && gClass.gclass117_0.sbyte_0 != 32)
						{
							if (gClass.gclass117_0.sbyte_0 > 4 && gClass.gclass117_0.sbyte_0 != 32)
								text4 = text4 + "," + gClass.gclass120_0[n].method_0();
							continue;
						}
						try
						{
							int num9 = n;
							sbyte language = mResources.language;
							if (language == 0)
							{
								int num10 = gClass.gclass120_0[num9].gclass126_0.int_0;
								if (num10 <= 81)
								{
									if (num10 != 50)
									{
										switch (num10)
										{
										case 77:
											text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split('+')[1] + " HP";
											break;
										case 80:
											text5 = text5 + ((text5 == "") ? "" : ", ") + "+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP/30s";
											break;
										case 81:
											text5 = text5 + ((text5 == "") ? "" : ", ") + "+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI/30s";
											break;
										case 78:
										case 79:
											break;
										}
									}
									else
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split('+')[1] + " SĐ";
									continue;
								}
								switch (num10)
								{
								case 94:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + " GST";
									continue;
								case 95:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + " HM";
									continue;
								case 96:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + " HK";
									continue;
								case 97:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + " PST";
									continue;
								case 101:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split(' ')[0] + " TNSM";
									continue;
								case 103:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split('+')[1] + " KI";
									continue;
								case 98:
								case 99:
								case 100:
								case 102:
									continue;
								}
								if (num10 == 108)
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[0] + " Né đòn";
								continue;
							}
							if (language != 1)
								continue;
							int num11 = gClass.gclass120_0[num9].gclass126_0.int_0;
							if (num11 <= 81)
							{
								if (num11 != 50)
								{
									switch (num11)
									{
									case 77:
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split('+')[1] + " HP";
										break;
									case 80:
										text5 = text5 + ((text5 == "") ? "" : ", ") + ((GClass151.int_0 == 0) ? ("+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP") : ("+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP/30s"));
										break;
									case 81:
										text5 = text5 + ((text5 == "") ? "" : ", ") + ((GClass151.int_0 != 0) ? ("+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " MP/30s") : ("+" + gClass.gclass120_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI"));
										break;
									case 78:
									case 79:
										break;
									}
								}
								else
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split('+')[1] + ((GClass151.int_0 == 0) ? " SĐ" : " DMG");
								continue;
							}
							switch (num11)
							{
							case 94:
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[2] + ((GClass151.int_0 == 0) ? " GST" : " RDMG");
								continue;
							case 95:
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 != 0) ? " CHP" : " HM");
								continue;
							case 96:
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HK" : " CKI");
								continue;
							case 97:
								text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass.gclass120_0[num9].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " PST" : " CDMG");
								continue;
							case 101:
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[0] + ((GClass151.int_0 != 0) ? "EXP" : " TNSM");
								continue;
							case 103:
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split('+')[1] + ((GClass151.int_0 == 0) ? " KI" : " MP");
								continue;
							case 98:
							case 99:
							case 100:
							case 102:
								continue;
							}
							if (num11 == 108)
								text5 = text5 + ((text5 == "") ? "" : ", ") + gClass.gclass120_0[num9].method_0().Split(' ')[0] + ((GClass151.int_0 != 0) ? " Avoid" : " Né đòn");
						}
						catch (Exception)
						{
						}
					}
				}
				gClass4.method_6(gclass122_0, text4, num3 + 5, num4 + 11, GClass4.int_0);
			}
			GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
			GClass4.gclass4_18.method_10(gclass122_0, text5, 170, int_59 + i * int_4 + 11, GClass4.int_1, GClass4.gclass4_20);
			if (gClass.gclass120_0 != null)
			{
				for (int num12 = 0; num12 < gClass.gclass120_0.Length; num12++)
				{
					method_214(gclass122_0, gClass.gclass120_0[num12].gclass126_0.int_0, gClass.gclass120_0[num12].int_0, num5, num6, num7, num8);
				}
				for (int num13 = 0; num13 < gClass.gclass120_0.Length; num13++)
				{
					method_215(gclass122_0, gClass.gclass120_0[num13].gclass126_0.int_0, gClass.gclass120_0[num13].int_0, num5, num6, num7, num8);
				}
				for (int num14 = 0; num14 < gClass.gclass120_0.Length; num14++)
				{
					int num15 = 0;
					int num16 = 0;
					int num17 = 0;
					if (gClass.gclass120_0[num14].int_0 > 0)
					{
						if (gClass.gclass120_0[num14].gclass126_0.int_0 == 107)
							num16 = gClass.gclass120_0[num14].int_0;
						if (num15 > num16)
							num17 = num15;
						else if (num15 < num16)
						{
							num17 = num16;
						}
						else if (num15 == num16)
						{
							num17 = num15;
						}
					}
					if (num17 > 0)
					{
						GClass4.gclass4_4.method_10(gclass122_0, num17.ToString(), 160, int_59 + i * int_4, 0, GClass4.gclass4_6);
						gclass122_0.method_33(gclass70_3, 165, int_59 + i * int_4 + 1);
					}
				}
			}
			if (gClass.int_30 > 1)
				GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass.int_30, num5 + num7, num6 + num8 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
		}
		method_100(gclass122_0);
	}

	public void method_100(GClass122 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		if ((int_8 > 24 && int_41 > 0) || (Equals(GClass73.gclass76_0) && int_57 == 2 && int_37[int_29] > 1))
			g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 1, int_58 + int_60 - 12, int_59 + 3, 0);
		if ((int_8 < int_11 && int_41 > 0) || (Equals(GClass73.gclass76_0) && int_57 == 2 && int_37[int_29] > 1))
			g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_58 + int_60 - 12, int_59 + int_61 - 8, 0);
	}

	private void method_101(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_6.Length; i++)
		{
			int num = int_58;
			int num2 = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
				continue;
			gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
			gclass122_0.method_15(num, num2, w, h);
			if (!(string_6[i] == mResources.gameInfo))
				GClass4.gclass4_6.method_6(gclass122_0, string_6[i], int_58 + int_60 / 2, num2 + 6, GClass4.int_2);
			else
				GClass154.smethod_0().method_1(GClass4.gclass4_4, gclass122_0, string_6[i], int_58 + int_60 / 2, num2 + 6, GClass4.int_2, GClass4.gclass4_6);
			if (!string_6[i].Equals(mResources.gameInfo))
				continue;
			for (int j = 0; j < gclass88_12.method_2(); j++)
			{
				if (!((Class9)gclass88_12.method_3(j)).bool_0)
				{
					if (GClass73.int_8 % 20 > 10)
						gclass122_0.method_31(gclass70_6, num + 10, num2 + 10, 3);
					break;
				}
			}
		}
		method_100(gclass122_0);
	}

	private void method_102(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_27.Length; i++)
		{
			int num = int_59 + i * 15;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
				GClass4.gclass4_6.method_6(gclass122_0, string_27[i], int_58 + 5, num + 6, GClass4.int_0);
		}
		method_100(gclass122_0);
	}

	private void method_103(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < gclass88_12.method_2(); i++)
		{
			Class9 @class = (Class9)gclass88_12.method_3(i);
			int num = int_58;
			int num2 = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num2 - int_8 <= int_59 + int_61 && num2 - int_8 >= int_59 - int_4)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(num, num2, w, h);
				GClass4.gclass4_6.method_6(gclass122_0, @class.string_0, int_58 + int_60 / 2, num2 + 6, GClass4.int_2);
				if (!@class.bool_0 && GClass73.int_8 % 20 > 10)
					gclass122_0.method_31(gclass70_6, num + 10, num2 + 10, 3);
			}
		}
		method_100(gclass122_0);
	}

	private void method_104(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		int num = GClass78.smethod_1().gclass176_0.gclass47_0.Length;
		for (int i = 0; i < num + 6; i++)
		{
			int num2 = int_58 + 30;
			int num3 = int_59 + i * int_4;
			int num4 = int_60 - 30;
			int h = int_4 - 1;
			int num5 = int_58;
			int num6 = int_59 + i * int_4;
			if (num3 - int_8 > int_59 + int_61 || num3 - int_8 < int_59 - int_4)
				continue;
			gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
			if (i == 5)
				gclass122_0.method_16((i != int_67) ? 16765060 : 16776068);
			gclass122_0.method_15(num2, num3, num4, h);
			gclass122_0.method_31(GClass144.gclass70_14, num5, num6, 0);
			if (i == 0)
			{
				GClass28.smethod_6(gclass122_0, 567, num5 + 4, num6 + 4, 0, 0);
				string st = mResources.HP + " " + mResources.root + ": " + GClass65.smethod_9(GClass78.smethod_1().int_155);
				GClass4.gclass4_2.method_6(gclass122_0, st, num2 + 5, num3 + 3, 0);
				GClass4.gclass4_14.method_6(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().int_155 + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass78.smethod_1().sbyte_30, num2 + 5, num3 + 15, 0);
			}
			if (i == 1)
			{
				GClass28.smethod_6(gclass122_0, 569, num5 + 4, num6 + 4, 0, 0);
				string st2 = mResources.KI + " " + mResources.root + ": " + GClass65.smethod_9(GClass78.smethod_1().int_156);
				GClass4.gclass4_2.method_6(gclass122_0, st2, num2 + 5, num3 + 3, 0);
				GClass4.gclass4_14.method_6(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().int_156 + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass78.smethod_1().sbyte_31, num2 + 5, num3 + 15, 0);
			}
			if (i == 2)
			{
				GClass28.smethod_6(gclass122_0, 568, num5 + 4, num6 + 4, 0, 0);
				string st3 = mResources.hit_point + " " + mResources.root + ": " + GClass65.smethod_9(GClass78.smethod_1().int_154);
				GClass4.gclass4_2.method_6(gclass122_0, st3, num2 + 5, num3 + 3, 0);
				GClass4.gclass4_14.method_6(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().int_154 * 100) + " " + mResources.potential + ": " + mResources.increase + " " + GClass78.smethod_1().sbyte_32, num2 + 5, num3 + 15, 0);
			}
			if (i == 3)
			{
				GClass28.smethod_6(gclass122_0, 721, num5 + 4, num6 + 4, 0, 0);
				string st4 = mResources.armor + " " + mResources.root + ": " + GClass65.smethod_9(GClass78.smethod_1().int_157);
				GClass4.gclass4_2.method_6(gclass122_0, st4, num2 + 5, num3 + 3, 0);
				GClass4.gclass4_14.method_6(gclass122_0, GClass65.smethod_9(500000 + GClass78.smethod_1().int_157 * 100000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass78.smethod_1().sbyte_33, num2 + 5, num3 + 15, 0);
			}
			if (i == 4)
			{
				GClass28.smethod_6(gclass122_0, 719, num5 + 4, num6 + 4, 0, 0);
				string st5 = mResources.critical + " " + mResources.root + ": " + GClass78.smethod_1().int_158 + "%";
				long num7 = 50000000L;
				int num8 = GClass78.smethod_1().int_158;
				if (num8 > long_0.Length - 1)
					num8 = long_0.Length - 1;
				num7 = long_0[num8];
				GClass4.gclass4_2.method_6(gclass122_0, st5, num2 + 5, num3 + 3, 0);
				long number = num7;
				GClass4.gclass4_14.method_6(gclass122_0, GClass50.smethod_32(number) + " " + mResources.potential + ": " + mResources.increase + " " + GClass78.smethod_1().sbyte_34, num2 + 5, num3 + 15, 0);
			}
			if (i == 5)
			{
				if (string_1 != null)
				{
					GClass28.smethod_6(gclass122_0, short_0, num5 + 4, num6 + 4, 0, 0);
					string[] array = GClass4.gclass4_11.method_15(string_1, 120);
					for (int j = 0; j < array.Length; j++)
					{
						GClass4.gclass4_14.method_6(gclass122_0, array[j], num2 + 5, num3 + 3 + j * 12, 0);
					}
				}
				else
					GClass4.gclass4_14.method_6(gclass122_0, "", num2 + 5, num3 + 9, 0);
			}
			if (i < 6)
				continue;
			GClass47 gClass = GClass78.smethod_1().gclass176_0.gclass47_0[i - 6];
			GClass28.smethod_6(gclass122_0, gClass.int_4, num5 + 4, num6 + 4, 0, 0);
			GClass63 gClass2 = GClass78.smethod_1().method_16(gClass);
			if (gClass2 == null)
			{
				GClass63 gClass3 = gClass.gclass63_0[0];
				GClass4.gclass4_8.method_6(gclass122_0, gClass.string_0, num2 + 5, num3 + 3, 0);
				GClass4.gclass4_14.method_6(gclass122_0, mResources.need_upper + " " + GClass50.smethod_32(gClass3.long_0) + " " + mResources.potential_to_learn, num2 + 5, num3 + 15, 0);
				continue;
			}
			GClass4.gclass4_2.method_6(gclass122_0, gClass.string_0, num2 + 5, num3 + 3, 0);
			GClass4.gclass4_18.method_6(gclass122_0, mResources.level + ": " + gClass2.int_0, num2 + num4 - 5, num3 + 3, GClass4.int_1);
			if (gClass2.int_0 == gClass.int_1)
				GClass4.gclass4_14.method_6(gclass122_0, mResources.max_level_reach, num2 + 5, num3 + 15, 0);
			else if (gClass2.gclass47_0.method_3())
			{
				string text = mResources.proficiency + ": ";
				int x = GClass4.gclass4_14.method_18(text) + num2 + 5;
				int num9 = num3 + 15;
				GClass4.gclass4_14.method_6(gclass122_0, text, num2 + 5, num9, 0);
				GClass4.gclass4_14.method_6(gclass122_0, "(" + gClass2.method_0() + ")", num2 + num4 - 5, num9, GClass4.int_1);
				num9 += 4;
				gclass122_0.method_16(7169134);
				gclass122_0.method_15(x, num9, 50, 5);
				int w = gClass2.short_3 * 50 / 1000;
				gclass122_0.method_16(11992374);
				gclass122_0.method_15(x, num9, w, 5);
				if (gClass2.short_3 < 1000)
					;
			}
			else
			{
				GClass63 gClass4 = gClass.gclass63_0[gClass2.int_0];
				GClass4.gclass4_14.method_6(gclass122_0, mResources.level + " " + (gClass2.int_0 + 1) + " " + mResources.need + " " + GClass50.smethod_32(gClass4.long_0) + " " + mResources.potential, num2 + 5, num3 + 15, 0);
			}
		}
		method_100(gclass122_0);
	}

	private void method_105(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_4.Length; i++)
		{
			int num = int_59 + i * int_4;
			int h = int_4 - 1;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(int_58, num, int_60, h);
				GClass4.gclass4_2.method_6(gclass122_0, string_4[i], 5, num + 1, 0);
				GClass4.gclass4_16.method_6(gclass122_0, string_5[i], 5, num + 11, 0);
			}
		}
		method_100(gclass122_0);
	}

	private void method_106(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		int[] array = GClass144.smethod_8().int_61;
		int[] array2 = GClass144.smethod_8().int_62;
		for (int i = 0; i < array2.Length; i++)
		{
			int num = int_58 + 36;
			int num2 = int_59 + i * int_4;
			int num3 = int_60 - 36;
			int h = int_4 - 1;
			int num4 = int_58;
			int y = int_59 + i * int_4;
			int num5 = 34;
			int h2 = int_4 - 1;
			if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
				continue;
			gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
			gclass122_0.method_15(num, num2, num3, h);
			gclass122_0.method_16(int_112[array2[i]]);
			gclass122_0.method_15(num4, y, num5, h2);
			if (array[i] != -1)
			{
				if (array2[i] != 1)
					GClass4.gclass4_15.method_6(gclass122_0, array[i] + "", num4 + num5 / 2, num2 + 6, GClass4.int_2);
				else
					GClass4.gclass4_16.method_6(gclass122_0, array[i] + "", num4 + num5 / 2, num2 + 6, GClass4.int_2);
				GClass4.gclass4_14.method_6(gclass122_0, GClass144.smethod_8().int_63[i] + "/" + GClass144.smethod_8().int_64[i], num + 5, num2 + 6, 0);
			}
			if (GClass144.smethod_8().string_1[i] != null)
			{
				GClass4.gclass4_16.method_6(gclass122_0, GClass144.smethod_8().string_1[i] + "(Top " + GClass144.smethod_8().int_65[i] + ")", num + num3 - 2, num2 + 1, GClass4.int_1);
				GClass4.gclass4_16.method_6(gclass122_0, GClass144.smethod_8().string_2[i] + "(Top " + GClass144.smethod_8().int_66[i] + ")", num + num3 - 2, num2 + 11, GClass4.int_1);
			}
		}
		method_100(gclass122_0);
	}

	private void method_107(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		if (int_41 == 0)
			return;
		int num = (int_8 + int_61) / 24 + 1;
		if (num < int_61 / 24 + 1)
			num = int_61 / 24 + 1;
		if (num > int_41)
			num = int_41;
		int num2 = int_8 / 24;
		if (num2 >= num)
			num2 = num - 1;
		if (num2 < 0)
			num2 = 0;
		for (int i = num2; i < num; i++)
		{
			int num3 = int_58;
			int num4 = int_59 + i * int_4;
			int num5 = 24;
			int num6 = int_4 - 1;
			int num7 = int_58 + 24;
			int num8 = int_59 + i * int_4;
			int w = int_60 - 24;
			int h = int_4 - 1;
			gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
			gclass122_0.method_15(num7, num8, w, h);
			gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
			gclass122_0.method_15(num3, num4, num5, num6);
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().short_1[int_29][i], num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			string[] array = GClass4.gclass4_16.method_15(GClass78.smethod_1().string_4[int_29][i], 140);
			for (int j = 0; j < array.Length; j++)
			{
				GClass4.gclass4_16.method_6(gclass122_0, array[j], num7 + 5, num8 + 1 + j * 11, 0);
			}
		}
		method_100(gclass122_0);
	}

	private void method_108(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		try
		{
			GClass128[] array = GClass78.smethod_1().gclass128_1;
			int_41 = array.Length;
			for (int i = 0; i < int_41; i++)
			{
				int num = int_58 + 36;
				int num2 = int_59 + i * int_4;
				int w = int_60 - 36;
				int h = int_4 - 1;
				int num3 = int_58;
				int num4 = int_59 + i * int_4;
				int num5 = 34;
				int num6 = int_4 - 1;
				if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
					continue;
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(num, num2, w, h);
				gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
				GClass128 gClass = array[i];
				if (gClass != null)
				{
					for (int j = 0; j < gClass.gclass120_0.Length; j++)
					{
						if (gClass.gclass120_0[j].gclass126_0.int_0 == 72 && gClass.gclass120_0[j].int_0 > 0)
						{
							sbyte id = smethod_5(gClass.gclass120_0[j].int_0);
							if (smethod_4(id) != -1)
								gclass122_0.method_16((i != int_67) ? smethod_4(id) : smethod_4(id));
						}
					}
				}
				gclass122_0.method_15(num3, num4, num5, num6);
				GClass154.smethod_0().method_2(GClass4.gclass4_20, gclass122_0, (i + 1).ToString(), int_58 + 2, int_59 + i * int_4 - 2, 0, GClass4.gclass4_11, "border");
				if (gClass == null)
					continue;
				string text = "";
				GClass4 gClass2 = GClass4.gclass4_14;
				if (gClass.gclass120_0 != null)
				{
					for (int k = 0; k < gClass.gclass120_0.Length; k++)
					{
						if (gClass.gclass120_0[k].gclass126_0.int_0 == 72 && gClass.gclass117_0.short_0 != 570)
						{
							gClass.method_3(gclass122_0, int_58 + 18, int_59 + i * int_4 + 12, gClass.gclass120_0[k].int_0);
							text = " [+" + gClass.gclass120_0[k].method_0() + "]";
						}
						if (gClass.gclass120_0[k].gclass126_0.int_0 == 41)
						{
							if (gClass.gclass120_0[k].int_0 == 1)
								gClass2 = smethod_6(0);
							else if (gClass.gclass120_0[k].int_0 == 2)
							{
								gClass2 = smethod_6(2);
							}
							else if (gClass.gclass120_0[k].int_0 == 3)
							{
								gClass2 = smethod_6(8);
							}
							else if (gClass.gclass120_0[k].int_0 == 4)
							{
								gClass2 = smethod_6(7);
							}
						}
						GClass154.smethod_0().method_2(GClass4.gclass4_20, gclass122_0, (i + 1).ToString(), int_58 + 2, int_59 + i * int_4 - 2, 0, GClass4.gclass4_11, "border");
					}
				}
				GClass4.gclass4_1.method_6(gclass122_0, gClass.method_2(), int_58 + int_60, int_59 + i * int_4, GClass4.int_1);
				gClass2.method_6(gclass122_0, gClass.gclass117_0.string_0 + text, num + 5, num2 + 1, 0);
				string text2 = "";
				string text3 = "";
				if (gClass.gclass120_0 != null)
				{
					if (gClass.gclass120_0.Length != 0 && gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
						text2 = ((gClass.gclass117_0.short_0 != 529 && gClass.gclass117_0.short_0 != 530 && gClass.gclass117_0.short_0 != 531 && gClass.gclass117_0.short_0 != 534 && gClass.gclass117_0.short_0 != 535 && gClass.gclass117_0.short_0 != 536) ? (text2 + gClass.gclass120_0[0].method_0()) : ((GClass151.int_0 == 0) ? (gClass.gclass120_0[0].method_0().Split(' ')[3] + " phút") : (gClass.gclass120_0[0].method_0().Split(' ')[3] + " minute")));
					GClass4 gClass3 = GClass4.gclass4_18;
					if (gClass.int_43 < 0 && gClass.gclass117_0.sbyte_0 != 5)
						gClass3 = GClass4.gclass4_17;
					if (gClass.gclass120_0.Length > 1)
					{
						for (int l = 1; l < gClass.gclass120_0.Length; l++)
						{
							if (gClass.gclass120_0[l] != null && gClass.gclass120_0[l].gclass126_0.int_0 != 102 && gClass.gclass120_0[l].gclass126_0.int_0 != 107 && gClass.gclass120_0[l].method_0().StartsWith("Set"))
								text2 = text2 + "," + gClass.gclass120_0[l].method_0();
						}
						for (int m = 1; m < gClass.gclass120_0.Length; m++)
						{
							if (gClass.gclass120_0[m] == null || gClass.method_0())
								continue;
							if ((gClass.gclass117_0.sbyte_0 >= 0 && gClass.gclass117_0.sbyte_0 <= 4) || gClass.gclass117_0.sbyte_0 == 32)
								try
								{
									int num7 = m;
									sbyte language = mResources.language;
									if (language == 0)
									{
										int num8 = gClass.gclass120_0[num7].gclass126_0.int_0;
										if (num8 <= 81)
										{
											if (num8 != 50)
											{
												switch (num8)
												{
												case 77:
													text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split('+')[1] + " HP";
													break;
												case 80:
													text3 = text3 + ((!(text3 == "")) ? ", " : "") + "+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP/30s";
													break;
												case 81:
													text3 = text3 + ((text3 == "") ? "" : ", ") + "+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " KI/30s";
													break;
												case 78:
												case 79:
													break;
												}
											}
											else
												text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split('+')[1] + " SĐ";
											continue;
										}
										switch (num8)
										{
										case 94:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + " GST";
											continue;
										case 95:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + " HM";
											continue;
										case 96:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + " HK";
											continue;
										case 97:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + " PST";
											continue;
										case 101:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[0] + " TNSM";
											continue;
										case 103:
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split('+')[1] + " KI";
											continue;
										case 98:
										case 99:
										case 100:
										case 102:
											continue;
										}
										if (num8 == 108)
											text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split(' ')[0] + " Né đòn";
										continue;
									}
									if (language != 1)
										continue;
									int num9 = gClass.gclass120_0[num7].gclass126_0.int_0;
									if (num9 <= 81)
									{
										if (num9 != 50)
										{
											switch (num9)
											{
											case 77:
												text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split('+')[1] + " HP";
												break;
											case 80:
												text3 = text3 + ((text3 == "") ? "" : ", ") + ((GClass151.int_0 == 0) ? ("+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP") : ("+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP/30s"));
												break;
											case 81:
												text3 = text3 + ((!(text3 == "")) ? ", " : "") + ((GClass151.int_0 != 0) ? ("+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " MP/30s") : ("+" + gClass.gclass120_0[num7].method_0().Split('+')[1].Split('/')[0] + " KI"));
												break;
											case 78:
											case 79:
												break;
											}
										}
										else
											text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split('+')[1] + ((GClass151.int_0 == 0) ? " SĐ" : " DMG");
										continue;
									}
									switch (num9)
									{
									case 94:
										text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[2] + ((GClass151.int_0 == 0) ? " GST" : " RDMG");
										continue;
									case 95:
										text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HM" : " CHP");
										continue;
									case 96:
										text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HK" : " CKI");
										continue;
									case 97:
										text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[1] + ((GClass151.int_0 != 0) ? " CDMG" : " PST");
										continue;
									case 101:
										text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split(' ')[0] + ((GClass151.int_0 == 0) ? " TNSM" : "EXP");
										continue;
									case 103:
										text3 = text3 + ((!(text3 == "")) ? ", " : "") + gClass.gclass120_0[num7].method_0().Split('+')[1] + ((GClass151.int_0 != 0) ? " MP" : " KI");
										continue;
									case 98:
									case 99:
									case 100:
									case 102:
										continue;
									}
									if (num9 == 108)
										text3 = text3 + ((text3 == "") ? "" : ", ") + gClass.gclass120_0[num7].method_0().Split(' ')[0] + ((GClass151.int_0 == 0) ? " Né đòn" : " Avoid");
								}
								catch (Exception)
								{
								}
							else if (gClass.gclass117_0.sbyte_0 > 4 && gClass.gclass117_0.sbyte_0 != 32)
							{
								text2 = text2 + "," + gClass.gclass120_0[m].method_0();
							}
						}
					}
					gClass3.method_6(gclass122_0, text2, num + 5, num2 + 11, GClass4.int_0);
				}
				GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
				GClass4.gclass4_18.method_10(gclass122_0, text3, int_58 + int_60 - 2, int_59 + i * int_4 + 11, GClass4.int_1, GClass4.gclass4_20);
				if (gClass.gclass120_0 != null)
				{
					for (int n = 0; n < gClass.gclass120_0.Length; n++)
					{
						method_214(gclass122_0, gClass.gclass120_0[n].gclass126_0.int_0, gClass.gclass120_0[n].int_0, num3, num4, num5, num6);
					}
					for (int num10 = 0; num10 < gClass.gclass120_0.Length; num10++)
					{
						method_215(gclass122_0, gClass.gclass120_0[num10].gclass126_0.int_0, gClass.gclass120_0[num10].int_0, num3, num4, num5, num6);
					}
					for (int num11 = 0; num11 < gClass.gclass120_0.Length; num11++)
					{
						int num12 = 0;
						int num13 = 0;
						int num14 = 0;
						if (gClass.gclass120_0[num11].int_0 > 0)
						{
							if (gClass.gclass120_0[num11].gclass126_0.int_0 == 107)
								num13 = gClass.gclass120_0[num11].int_0;
							if (num12 <= num13)
							{
								if (num12 >= num13)
								{
									if (num12 == num13)
										num14 = num12;
								}
								else
									num14 = num13;
							}
							else
								num14 = num12;
						}
						if (num14 > 0)
						{
							GClass4.gclass4_4.method_10(gclass122_0, num14.ToString(), int_58 + int_60 - 17, int_59 + i * int_4, 0, GClass4.gclass4_6);
							gclass122_0.method_33(gclass70_3, int_58 + int_60 - 11, int_59 + i * int_4 + 1);
						}
					}
				}
				if (gClass.int_30 > 1)
					GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass.int_30, num3 + num5, num4 + num6 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
			}
		}
		catch (Exception)
		{
		}
		method_100(gclass122_0);
	}

	public GClass38 method_109()
	{
		if (int_67 < 2)
			return null;
		if (int_67 <= ((gclass88_1 != null) ? gclass88_1.method_2() : gclass88_2.method_2()) + 1)
			return (gclass88_1 == null) ? ((GClass38)gclass88_2.method_3(int_67 - 2)) : ((GClass38)gclass88_1.method_3(int_67 - 2));
		return null;
	}

	public GClass189 method_110()
	{
		if (int_67 < 2)
			return null;
		if (int_67 > GClass189.gclass88_0.method_2() + 1)
			return null;
		return (GClass189)GClass189.gclass88_0.method_3(int_67 - 2);
	}

	public GClass106 method_111()
	{
		if (int_67 >= 2)
		{
			if (int_67 <= gclass106_1.Length + 1)
				return gclass106_1[int_67 - 2];
			return null;
		}
		return null;
	}

	private void method_112(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		if (gclass88_3.method_2() == 0)
			GClass4.gclass4_14.method_6(gclass122_0, mResources.no_msg, int_58 + int_60 / 2, int_59 + int_61 / 2 - GClass4.gclass4_11.method_20() / 2 + 24, 2);
		for (int i = 0; i < int_41; i++)
		{
			int num = int_58;
			int num2 = int_59 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num3 = int_58 + 24;
			int num4 = int_59 + i * int_4;
			int w2 = int_60 - 24;
			int num5 = int_4 - 1;
			if (i != 0)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(num3, num4, w2, num5);
				gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
				gclass122_0.method_15(num, num2, w, h);
				GClass16 gClass = (GClass16)gclass88_3.method_3(i - 1);
				if (gClass.gclass78_0.int_118 != -1)
					GClass28.smethod_6(gclass122_0, gClass.gclass78_0.int_118, num, num2, 0, 0);
				else
				{
					GClass116 gClass2 = GClass144.gclass116_0[gClass.gclass78_0.int_119];
					GClass28.smethod_6(gclass122_0, gClass2.gclass66_0[GClass78.int_94[0][0][0]].short_0, num + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num2 + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1, 0, 0);
				}
				gclass122_0.method_5(int_58, int_59 + int_8, int_60, int_61);
				GClass4 gclass4_ = GClass4.gclass4_6;
				GClass4.gclass4_7.method_6(gclass122_0, gClass.gclass78_0.string_3, num3 + 5, num4, 0);
				if (gClass.bool_0)
					GClass4.gclass4_17.method_6(gclass122_0, GClass50.smethod_30(gClass.string_0, "|", 0)[2], num3 + 5, num4 + 11, 0);
				else
					GClass4.gclass4_18.method_6(gclass122_0, GClass50.smethod_30(gClass.string_0, "|", 0)[2], num3 + 5, num4 + 11, 0);
				GClass154.smethod_0().method_2(GClass4.gclass4_1, gclass122_0, $"[{gClass.gclass78_0.int_13}]", int_58 + int_60, int_59 + i * int_4, GClass4.int_1, GClass4.gclass4_6, "noborder");
			}
			else
			{
				gclass122_0.method_16(15196114);
				gclass122_0.method_15(num, num4, int_60, num5);
				gclass122_0.method_31((i != int_67) ? GClass144.gclass70_24 : GClass144.gclass70_25, int_58 + int_60 - 5, num4 + 2, GClass188.int_2);
				((i != int_67) ? GClass4.gclass4_6 : GClass4.gclass4_7).method_6(gclass122_0, bool_22 ? mResources.off : mResources.on, int_58 + int_60 - 22, num4 + 7, 2);
				GClass4.gclass4_16.method_6(gclass122_0, bool_22 ? mResources.offPlease : mResources.onPlease, int_58 + 5, num4 + num5 / 2 - 4, GClass4.int_0);
			}
		}
		method_100(gclass122_0);
	}

	private void method_113(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		for (int i = 0; i < int_41; i++)
		{
			int num = int_58 + 26;
			int num2 = int_59 + i * int_4;
			int w = int_60 - 26;
			int h = int_4 - 1;
			int num3 = int_58;
			int num4 = int_59 + i * int_4;
			int num5 = 24;
			int num6 = int_4 - 1;
			if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
				continue;
			gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
			gclass122_0.method_15(num, num2, w, h);
			gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
			gclass122_0.method_15(num3, num4, num5, num6);
			GClass128 gClass = (GClass128)gclass88_10.method_3(i);
			if (gClass == null)
				continue;
			GClass4.gclass4_14.method_6(gclass122_0, gClass.gclass117_0.string_0, num + 5, num2 + 1, 0);
			string text = "";
			if (gClass.gclass120_0 != null && gClass.gclass120_0.Length >= 1)
			{
				if (gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
					text += gClass.gclass120_0[0].method_0();
				GClass4.gclass4_18.method_6(gclass122_0, text, num + 5, num2 + 11, 0);
				GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			}
		}
		method_100(gclass122_0);
	}

	private void method_114(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		if (int_41 != 0)
		{
			for (int i = 0; i < int_41; i++)
			{
				int num = int_58;
				int num2 = int_59 + i * int_4;
				int w = 24;
				int h = int_4 - 1;
				int num3 = int_58 + 24;
				int num4 = int_59 + i * int_4;
				int w2 = int_60 - 24;
				int h2 = int_4 - 1;
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(num3, num4, w2, h2);
				gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
				gclass122_0.method_15(num, num2, w, h);
				GClass16 gClass = (GClass16)gclass88_9.method_3(i);
				if (gClass.gclass78_0.int_118 == -1)
				{
					GClass116 gClass2 = GClass144.gclass116_0[gClass.gclass78_0.int_119];
					GClass28.smethod_6(gclass122_0, gClass2.gclass66_0[GClass78.int_94[0][0][0]].short_0, num + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num2 + 3 + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1, 0, 0);
				}
				else
					GClass28.smethod_6(gclass122_0, gClass.gclass78_0.int_118, num, num2, 0, 0);
				gclass122_0.method_5(int_58, int_59 + int_8, int_60, int_61);
				if (!gClass.bool_1)
				{
					GClass4.gclass4_16.method_6(gclass122_0, gClass.gclass78_0.string_3, num3 + 5, num4, 0);
					GClass4.gclass4_16.method_6(gclass122_0, gClass.string_0, num3 + 5, num4 + 11, 0);
				}
				else
				{
					GClass4.gclass4_8.method_6(gclass122_0, gClass.gclass78_0.string_3, num3 + 5, num4, 0);
					GClass4.gclass4_18.method_6(gclass122_0, gClass.string_0, num3 + 5, num4 + 11, 0);
				}
				GClass154.smethod_0().method_2(GClass4.gclass4_1, gclass122_0, $"[{gClass.gclass78_0.int_13}]", int_58 + int_60, int_59 + i * int_4, GClass4.int_1, GClass4.gclass4_6, "noborder");
			}
			method_100(gclass122_0);
		}
		else
			GClass4.gclass4_14.method_6(gclass122_0, mResources.no_enemy, int_58 + int_60 / 2, int_59 + int_61 / 2 - GClass4.gclass4_11.method_20() / 2, 2);
	}

	private void method_115(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		if (int_41 != 0)
		{
			for (int i = 0; i < int_41; i++)
			{
				int num = int_58;
				int num2 = int_59 + i * int_4;
				int w = 24;
				int h = int_4 - 1;
				int num3 = int_58 + 24;
				int num4 = int_59 + i * int_4;
				int w2 = int_60 - 24;
				int h2 = int_4 - 1;
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(num3, num4, w2, h2);
				gclass122_0.method_16((i != int_67) ? 9993045 : 9541120);
				gclass122_0.method_15(num, num2, w, h);
				GClass16 gClass = (GClass16)gclass88_5.method_3(i);
				if (gClass.gclass78_0.int_118 == -1)
				{
					GClass116 gClass2 = GClass144.gclass116_0[gClass.gclass78_0.int_119];
					GClass28.smethod_6(gclass122_0, gClass2.gclass66_0[GClass78.int_94[0][0][0]].short_0, num + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num2 + 3 + gClass2.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1, 0, 0);
				}
				else
					GClass28.smethod_6(gclass122_0, gClass.gclass78_0.int_118, num, num2, 0, 0);
				gclass122_0.method_5(int_58, int_59 + int_8, int_60, int_61);
				if (!gClass.bool_1)
				{
					GClass4.gclass4_16.method_6(gclass122_0, gClass.gclass78_0.string_3, num3 + 5, num4, 0);
					GClass4.gclass4_16.method_6(gclass122_0, gClass.string_0, num3 + 5, num4 + 11, 0);
				}
				else
				{
					GClass4.gclass4_8.method_6(gclass122_0, gClass.gclass78_0.string_3, num3 + 5, num4, 0);
					GClass4.gclass4_18.method_6(gclass122_0, gClass.string_0, num3 + 5, num4 + 11, 0);
				}
				GClass154.smethod_0().method_2(GClass4.gclass4_1, gclass122_0, $"[{gClass.gclass78_0.int_13}]", int_58 + int_60, int_59 + i * int_4, GClass4.int_1, GClass4.gclass4_6, "noborder");
			}
			method_100(gclass122_0);
		}
		else
			GClass4.gclass4_14.method_6(gclass122_0, mResources.no_friend, int_58 + int_60 / 2, int_59 + int_61 / 2 - GClass4.gclass4_11.method_20() / 2, 2);
	}

	public void method_116(GClass122 g)
	{
		g.method_5(int_58, int_59, int_60, int_61);
		g.method_1(0, -int_8);
		for (int i = 0; i < gclass88_4.method_2(); i++)
		{
			int x = int_58;
			int num = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
			{
				GClass87 gClass = (GClass87)gclass88_4.method_3(i);
				g.method_16((i != int_67) ? 15196114 : 16383818);
				g.method_15(x, num, w, h);
				if (!gClass.string_2.Equals(""))
				{
					GClass4.gclass4_6.method_6(g, gClass.string_0, int_58 + int_60 / 2, num + 1, GClass4.int_2);
					GClass4.gclass4_6.method_6(g, gClass.string_2, int_58 + int_60 / 2, num + 11, GClass4.int_2);
				}
				else
					GClass4.gclass4_6.method_6(g, gClass.string_0, int_58 + int_60 / 2, num + 6, GClass4.int_2);
			}
		}
		method_100(g);
	}

	private void method_117(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(-int_15, -int_8);
		gclass122_0.method_16(0);
		int num = int_58 + int_60 / 2 - string_19.Length * int_5 / 2;
		if (int_41 == 2)
		{
			GClass4.gclass4_14.method_6(gclass122_0, string_21, int_58 + int_60 / 2, int_59 + 24 + int_61 / 2 - GClass4.gclass4_11.method_20() / 2, 2);
			if (bool_11 && gclass88_2.method_2() == 1)
			{
				for (int i = 0; i < mResources.clanEmpty.Length; i++)
				{
					GClass4.gclass4_6.method_6(gclass122_0, mResources.clanEmpty[i], int_58 + int_60 / 2, int_59 + 24 + int_61 / 2 - mResources.clanEmpty.Length * 12 / 2 + i * 12, GClass4.int_2);
				}
			}
		}
		if (bool_11)
			int_41 = GClass189.gclass88_0.method_2() + 2;
		for (int j = 0; j < int_41; j++)
		{
			int num2 = int_58;
			int num3 = int_59 + j * int_4;
			int num4 = 24;
			int num5 = int_4 - 1;
			int num6 = int_58 + 24;
			int num7 = int_59 + j * int_4;
			int num8 = int_60 - 24;
			int num9 = int_4 - 1;
			if (num7 - int_8 > int_59 + int_61 || num7 - int_8 < int_59 - int_4)
				continue;
			int num10 = j;
			if (num10 == 0)
			{
				for (int k = 0; k < string_19.Length; k++)
				{
					gclass122_0.method_16((k != int_68 || j != int_67) ? 15723751 : 16383818);
					gclass122_0.method_15(num + k * int_5, num7, int_5 - 1, 23);
					for (int l = 0; l < string_19[k].Length; l++)
					{
						GClass4.gclass4_16.method_6(gclass122_0, string_19[k][l], num + k * int_5 + int_5 / 2, int_59 + l * 11, GClass4.int_2);
					}
				}
			}
			else if (num10 != 1)
			{
				if (bool_10)
				{
					if (gclass106_1 == null || gclass106_1.Length == 0)
						continue;
					gclass122_0.method_16((j != int_67) ? 15196114 : 16383818);
					gclass122_0.method_15(num6, num7, num8, num9);
					gclass122_0.method_16((j != int_67) ? 9993045 : 9541120);
					gclass122_0.method_15(num2, num3, num4, num5);
					if (!GClass68.smethod_2(gclass106_1[j - 2].int_1))
					{
						GClass68 gClass = new GClass68();
						gClass.int_0 = gclass106_1[j - 2].int_1;
						if (!GClass68.smethod_2(gClass.int_0))
							GClass68.smethod_0(gClass);
					}
					else if (GClass68.smethod_1((short)gclass106_1[j - 2].int_1).short_0 != null)
					{
						GClass28.smethod_6(gclass122_0, GClass68.smethod_1((short)gclass106_1[j - 2].int_1).short_0[0], num2 + num4 / 2, num3 + num5 / 2, 0, GClass188.int_6);
					}
					string st = ((gclass106_1[j - 2].string_0.Length <= 23) ? gclass106_1[j - 2].string_0 : (gclass106_1[j - 2].string_0.Substring(0, 23) + "..."));
					GClass4.gclass4_7.method_6(gclass122_0, st, num6 + 5, num7, 0);
					gclass122_0.method_5(num6, num7, num8 - 10, num9);
					GClass4.gclass4_18.method_6(gclass122_0, gclass106_1[j - 2].string_1, num6 + 5, num7 + 11, 0);
					gclass122_0.method_5(int_58, int_59 + int_8, int_60, int_61);
					GClass4.gclass4_14.method_6(gclass122_0, gclass106_1[j - 2].int_3 + "/" + gclass106_1[j - 2].int_4, num6 + num8 - 5, num7, GClass4.int_1);
				}
				else if (bool_12)
				{
					gclass122_0.method_16((j != int_67) ? 15196114 : 16383818);
					gclass122_0.method_15(num6, num7, num8, num9);
					gclass122_0.method_16((j != int_67) ? 9993045 : 9541120);
					gclass122_0.method_15(num2, num3, num4, num5);
					GClass38 gClass2 = ((gclass88_1 == null) ? ((GClass38)gclass88_2.method_3(j - 2)) : ((GClass38)gclass88_1.method_3(j - 2)));
					if (gClass2.short_1 == -1)
					{
						GClass116 gClass3 = GClass144.gclass116_0[gClass2.short_0];
						GClass28.smethod_6(gclass122_0, gClass3.gclass66_0[GClass78.int_94[0][0][0]].short_0, num2 + gClass3.gclass66_0[GClass78.int_94[0][0][0]].sbyte_0, num3 + 3 + gClass3.gclass66_0[GClass78.int_94[0][0][0]].sbyte_1, 0, 0);
					}
					else
						GClass28.smethod_6(gclass122_0, gClass2.short_1, num2, num3, 0, 0);
					gclass122_0.method_5(int_58, int_59 + int_8, int_60, int_61);
					GClass4 gClass4 = GClass4.gclass4_6;
					if (gClass2.sbyte_0 == 0)
						gClass4 = GClass4.gclass4_1;
					else if (gClass2.sbyte_0 == 1)
					{
						gClass4 = GClass4.gclass4_8;
					}
					else if (gClass2.sbyte_0 == 2)
					{
						gClass4 = GClass4.gclass4_7;
					}
					gClass4.method_6(gclass122_0, gClass2.string_0, num6 + 5, num7, 0);
					GClass4.gclass4_18.method_6(gclass122_0, mResources.power + ": " + gClass2.string_1, num6 + 5, num7 + 11, 0);
					GClass28.smethod_6(gclass122_0, 7223, num6 + num8 - 7, num7 + 12, 0, 3);
					GClass4.gclass4_18.method_6(gclass122_0, "" + gClass2.int_4, num6 + num8 - 15, num7 + 6, GClass4.int_1);
				}
				else
				{
					if (!bool_11 || GClass189.gclass88_0.method_2() == 0)
						continue;
					GClass189 gClass5 = (GClass189)GClass189.gclass88_0.method_3(j - 2);
					gclass122_0.method_16((j != int_67 || gClass5.string_2 != null) ? 15196114 : 16383818);
					gclass122_0.method_15(num2, num3, num8 + num4, num9);
					gClass5.method_0(gclass122_0, num2, num3);
					if (gClass5.string_2 == null)
						continue;
					int num11 = int_58 + int_60 - 2 - gClass5.string_2.Length * 40;
					for (int m = 0; m < gClass5.string_2.Length; m++)
					{
						if (m != int_68 || j != int_67)
						{
							gclass122_0.method_31(GClass144.gclass70_24, num11 + m * 40 + 20, num7 + num9 / 2, GClass188.int_6);
							GClass4.gclass4_6.method_6(gclass122_0, gClass5.string_2[m], num11 + m * 40 + 20, num7 + 6, GClass4.int_2);
						}
						else
						{
							gclass122_0.method_31(GClass144.gclass70_25, num11 + m * 40 + 20, num7 + num9 / 2, GClass188.int_6);
							GClass4.gclass4_7.method_6(gclass122_0, gClass5.string_2[m], num11 + m * 40 + 20, num7 + 6, GClass4.int_2);
						}
					}
				}
			}
			else
			{
				gclass122_0.method_16((j != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(int_58, num7, int_60, num9);
				if (string_20 != null)
					GClass4.gclass4_6.method_6(gclass122_0, string_20, int_58 + int_60 / 2, num7 + 6, GClass4.int_2);
			}
		}
		method_100(gclass122_0);
	}

	private void method_118(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		gclass122_0.method_16(0);
		if (int_41 != 0)
		{
			if (GClass78.smethod_1().gclass6_0 == null || GClass78.smethod_1().gclass6_0.Length != int_41)
				return;
			for (int i = 0; i < int_41; i++)
			{
				int num = int_58;
				int num2 = int_59 + i * int_4;
				int num3 = int_60;
				int num4 = int_4 - 1;
				GClass6 gClass = GClass78.smethod_1().gclass6_0[i];
				gclass122_0.method_16((i != int_67 || ((gClass.bool_1 || gClass.bool_0) && (!gClass.bool_1 || !gClass.bool_0))) ? 15196114 : 16383818);
				gclass122_0.method_15(num, num2, num3, num4);
				if (gClass == null)
					continue;
				if (gClass.bool_0)
				{
					if (gClass.bool_0 && !gClass.bool_1)
					{
						GClass4.gclass4_11.method_6(gclass122_0, gClass.string_0, num + 5, num2, 0);
						GClass4.gclass4_18.method_6(gclass122_0, mResources.reward_mission + gClass.int_0 + " " + mResources.RUBY, num + 5, num2 + 11, 0);
						if (i != int_67)
						{
							gclass122_0.method_31(GClass144.gclass70_24, num + num3 - 20, num2 + num4 / 2, GClass188.int_6);
							GClass4.gclass4_6.method_6(gclass122_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass4.int_2);
						}
						else
						{
							GClass4.gclass4_7.method_6(gclass122_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass4.int_2);
							GClass4.gclass4_6.method_6(gclass122_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass4.int_2);
						}
					}
					else if (gClass.bool_0 && gClass.bool_1)
					{
						GClass4.gclass4_19.method_6(gclass122_0, gClass.string_0, num + 5, num2, 0);
						GClass4.gclass4_19.method_6(gclass122_0, gClass.string_1, num + 5, num2 + 11, 0);
					}
				}
				else
				{
					GClass4.gclass4_11.method_6(gclass122_0, gClass.string_0, num + 5, num2, 0);
					GClass4.gclass4_19.method_6(gclass122_0, gClass.int_0 + " " + mResources.RUBY, num + num3 - 5, num2, GClass4.int_1);
					GClass4.gclass4_17.method_6(gclass122_0, gClass.string_1, num + 5, num2 + 11, 0);
				}
			}
			method_100(gclass122_0);
		}
		else
			GClass4.gclass4_14.method_6(gclass122_0, mResources.no_mission, int_58 + int_60 / 2, int_59 + int_61 / 2 - GClass4.gclass4_11.method_20() / 2, 2);
	}

	private void method_119(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		if (gclass88_0.method_2() == 0)
		{
			if (string_24 != null)
			{
				for (int i = 0; i < string_24.Length; i++)
				{
					GClass4.gclass4_6.method_6(gclass122_0, string_24[i], int_58 + int_60 / 2, int_59 + int_61 / 2 - string_24.Length * 14 / 2 + i * 14 + 5, 2);
				}
			}
			return;
		}
		for (int j = 0; j < gclass88_0.method_2() + 1; j++)
		{
			int num = int_58 + 36;
			int num2 = int_59 + j * int_4;
			int w = int_60 - 36;
			int num3 = int_4 - 1;
			int num4 = int_58;
			int num5 = int_59 + j * int_4;
			int num6 = 34;
			int num7 = int_4 - 1;
			if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
				continue;
			if (j == gclass88_0.method_2())
			{
				if (gclass88_0.method_2() > 0)
				{
					if (!GClass73.bool_5 && j == int_67)
					{
						gclass122_0.method_16(16383818);
						gclass122_0.method_15(num4, num2, int_60, num3 + 2);
					}
					if ((j == int_67 && int_103 == 1) || (!GClass73.bool_5 && j == int_67))
					{
						gclass122_0.method_31(GClass144.gclass70_23, int_58 + int_60 / 2, num2 + num3 / 2 + 1, GClass188.int_6);
						GClass4.gclass4_7.method_6(gclass122_0, mResources.UPGRADE, int_58 + int_60 / 2, num2 + num3 / 2 - 4, GClass4.int_2);
					}
					else
					{
						gclass122_0.method_31(GClass144.gclass70_22, int_58 + int_60 / 2, num2 + num3 / 2 + 1, GClass188.int_6);
						GClass4.gclass4_6.method_6(gclass122_0, mResources.UPGRADE, int_58 + int_60 / 2, num2 + num3 / 2 - 4, GClass4.int_2);
					}
				}
				continue;
			}
			gclass122_0.method_16((j != int_67) ? 15196114 : 16383818);
			gclass122_0.method_15(num, num2, w, num3);
			gclass122_0.method_16((j != int_67) ? 9993045 : 9541120);
			GClass128 gClass = (GClass128)gclass88_0.method_3(j);
			if (gClass != null)
			{
				for (int k = 0; k < gClass.gclass120_0.Length; k++)
				{
					if (gClass.gclass120_0[k].gclass126_0.int_0 == 72 && gClass.gclass120_0[k].int_0 > 0)
					{
						sbyte id = smethod_5(gClass.gclass120_0[k].int_0);
						if (smethod_4(id) != -1)
							gclass122_0.method_16((j != int_67) ? smethod_4(id) : smethod_4(id));
					}
				}
			}
			gclass122_0.method_15(num4, num5, num6, num7);
			if (gClass == null)
				continue;
			string text = "";
			GClass4 gClass2 = GClass4.gclass4_14;
			if (gClass.gclass120_0 != null)
			{
				for (int l = 0; l < gClass.gclass120_0.Length; l++)
				{
					if (gClass.gclass120_0[l].gclass126_0.int_0 == 72)
						text = " [+" + gClass.gclass120_0[l].int_0 + "]";
					if (gClass.gclass120_0[l].gclass126_0.int_0 != 41)
						continue;
					if (gClass.gclass120_0[l].int_0 == 1)
						gClass2 = smethod_6(0);
					else if (gClass.gclass120_0[l].int_0 != 2)
					{
						if (gClass.gclass120_0[l].int_0 != 3)
						{
							if (gClass.gclass120_0[l].int_0 == 4)
								gClass2 = smethod_6(7);
						}
						else
							gClass2 = smethod_6(8);
					}
					else
					{
						gClass2 = smethod_6(2);
					}
				}
			}
			gClass2.method_6(gclass122_0, gClass.gclass117_0.string_0 + text, num + 5, num2 + 1, 0);
			string text2 = "";
			if (gClass.gclass120_0 != null)
			{
				if (gClass.gclass120_0.Length != 0 && gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
					text2 += gClass.gclass120_0[0].method_0();
				GClass4 gClass3 = GClass4.gclass4_18;
				if (gClass.int_43 < 0 && gClass.gclass117_0.sbyte_0 != 5)
					gClass3 = GClass4.gclass4_17;
				if (gClass.gclass120_0.Length > 1)
				{
					for (int m = 1; m < gClass.gclass120_0.Length; m++)
					{
						if (gClass.gclass120_0[m] != null && gClass.gclass120_0[m].gclass126_0.int_0 != 102 && gClass.gclass120_0[m].gclass126_0.int_0 != 107)
							text2 = text2 + "," + gClass.gclass120_0[m].method_0();
					}
				}
				gClass3.method_6(gclass122_0, text2, num + 5, num2 + 11, GClass4.int_0);
			}
			GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
			if (gClass.gclass120_0 != null)
			{
				for (int n = 0; n < gClass.gclass120_0.Length; n++)
				{
					method_214(gclass122_0, gClass.gclass120_0[n].gclass126_0.int_0, gClass.gclass120_0[n].int_0, num4, num5, num6, num7);
				}
				for (int num8 = 0; num8 < gClass.gclass120_0.Length; num8++)
				{
					method_215(gclass122_0, gClass.gclass120_0[num8].gclass126_0.int_0, gClass.gclass120_0[num8].int_0, num4, num5, num6, num7);
				}
			}
			if (gClass.int_30 > 1)
				GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass.int_30, num4 + num6, num5 + num7 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
		}
		method_100(gclass122_0);
	}

	private void method_120(GClass122 gclass122_0)
	{
		gclass122_0.method_16(16711680);
		GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
		GClass128[] array = GClass78.smethod_1().gclass128_0;
		int_41 = gclass128_.Length + array.Length;
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		try
		{
			for (int i = 0; i < int_41; i++)
			{
				int num = int_58 + 36;
				int num2 = int_59 + i * int_4;
				int w = int_60 - 36;
				int h = int_4 - 1;
				int num3 = int_58;
				int num4 = int_59 + i * int_4;
				int num5 = 34;
				int num6 = int_4 - 1;
				if (num2 - int_8 > int_59 + int_61 || num2 - int_8 < int_59 - int_4)
					continue;
				gclass122_0.method_16((i == int_67) ? 16383818 : ((i >= gclass128_.Length) ? 15723751 : 15196114));
				gclass122_0.method_15(num, num2, w, h);
				gclass122_0.method_16((i == int_67) ? 9541120 : ((i >= gclass128_.Length) ? 11837316 : 9993045));
				GClass128 gClass = ((i >= gclass128_.Length) ? array[i - gclass128_.Length] : gclass128_[i]);
				if (gClass != null)
				{
					for (int j = 0; j < gClass.gclass120_0.Length; j++)
					{
						if (gClass.gclass120_0[j].gclass126_0.int_0 == 72 && gClass.gclass120_0[j].int_0 > 0)
						{
							byte id = (byte)smethod_5(gClass.gclass120_0[j].int_0);
							if (smethod_4(id) != -1)
								gclass122_0.method_16((i != int_67) ? smethod_4(id) : smethod_4(id));
						}
					}
				}
				gclass122_0.method_15(num3, num4, num5, num6);
				if (gClass != null && gClass.bool_0 && GClass73.gclass76_0.int_28 == 12)
				{
					gclass122_0.method_16((i != int_67) ? 6047789 : 7040779);
					gclass122_0.method_15(num3, num4, num5, num6);
				}
				int num7 = 9;
				if (i > 9)
					GClass154.smethod_0().method_1(GClass4.gclass4_20, gclass122_0, (i - num7).ToString(), int_58 + 2, int_59 + i * int_4 - 2, 0, GClass4.gclass4_11);
				if (gClass == null)
					continue;
				string text = "";
				GClass4 gClass2 = GClass4.gclass4_14;
				if (gClass.gclass120_0 != null)
				{
					for (int k = 0; k < gClass.gclass120_0.Length; k++)
					{
						if (gClass.gclass117_0.short_0 == 1044 || gClass.gclass117_0.short_0 == 1211 || gClass.gclass117_0.short_0 == 1212)
							gClass.method_3(gclass122_0, int_58 + 18, int_59 + i * int_4 + 12, 5);
						if (gClass.gclass117_0.short_0 == 1278 || gClass.gclass117_0.short_0 == 1279 || gClass.gclass117_0.short_0 == 1280)
							gClass.method_3(gclass122_0, int_58 + 18, int_59 + i * int_4 + 12, 6);
						if (gClass.gclass120_0[k].gclass126_0.int_0 == 72 && gClass.gclass117_0.short_0 != 570)
						{
							gClass.method_3(gclass122_0, int_58 + 18, int_59 + i * int_4 + 12, gClass.gclass120_0[k].int_0);
							text = " [+" + gClass.gclass120_0[k].int_0 + "]";
						}
						if (gClass.gclass120_0[k].gclass126_0.int_0 == 41)
						{
							if (gClass.gclass120_0[k].int_0 == 1)
								gClass2 = smethod_6(0);
							else if (gClass.gclass120_0[k].int_0 == 2)
							{
								gClass2 = smethod_6(2);
							}
							else if (gClass.gclass120_0[k].int_0 != 3)
							{
								if (gClass.gclass120_0[k].int_0 == 4)
									gClass2 = smethod_6(7);
							}
							else
							{
								gClass2 = smethod_6(8);
							}
						}
						if (i > num7)
							GClass154.smethod_0().method_1(GClass4.gclass4_20, gclass122_0, (i - num7).ToString(), int_58 + 2, int_59 + i * int_4 - 2, 0, GClass4.gclass4_11);
					}
				}
				string text2 = "";
				string text3 = "";
				if (gClass.gclass120_0 != null)
				{
					for (int l = 0; l < gClass.gclass120_0.Length; l++)
					{
						text3 = text3 + gClass.gclass120_0[l].gclass126_0.int_0 + "-";
					}
				}
				foreach (GClass160.GStruct6 item in GClass160.smethod_0().list_2)
				{
					if (gClass.gclass117_0.short_0 == item.int_0 && text3 == item.string_0 && gClass.gclass117_0.sbyte_0 == item.int_1)
					{
						text2 = ((GClass151.int_0 != 0) ? "[MS1]: " : "[SP1]: ");
						gclass122_0.method_20(13959423, 0.3f);
						gclass122_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass160.GStruct9 item2 in GClass160.smethod_0().list_3)
				{
					if (gClass.gclass117_0.short_0 == item2.int_0 && text3 == item2.string_0 && gClass.gclass117_0.sbyte_0 == item2.int_1)
					{
						text2 = ((GClass151.int_0 == 0) ? "[SP2]: " : "[MS2]: ");
						gclass122_0.method_20(13959423, 0.3f);
						gclass122_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass160.GStruct5 item3 in GClass160.smethod_0().list_4)
				{
					if (gClass.gclass117_0.short_0 == item3.int_0 && text3 == item3.string_0 && gClass.gclass117_0.sbyte_0 == item3.int_1)
					{
						text2 = ((GClass151.int_0 != 0) ? "[DS1]: " : "[ĐT1]: ");
						gclass122_0.method_20(13959423, 0.3f);
						gclass122_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass160.GStruct8 item4 in GClass160.smethod_0().list_5)
				{
					if (gClass.gclass117_0.short_0 == item4.int_0 && text3 == item4.string_0 && gClass.gclass117_0.sbyte_0 == item4.int_1)
					{
						text2 = ((GClass151.int_0 != 0) ? "[DS2]: " : "[ĐT2]: ");
						gclass122_0.method_20(13959423, 0.3f);
						gclass122_0.method_15(num, num2, w, h);
					}
				}
				if (!string.IsNullOrEmpty(text2))
					GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, text2 + gClass.gclass117_0.string_0 + text, num + 5, num2 + 1, 0, GClass4.gclass4_11);
				else
					gClass2.method_6(gclass122_0, gClass.gclass117_0.string_0 + text, num + 5, num2 + 1, 0);
				GClass4.gclass4_1.method_6(gclass122_0, gClass.method_2(), int_58 + int_60, int_59 + i * int_4, GClass4.int_1);
				string text4 = "";
				string text5 = "";
				if (gClass.gclass120_0 != null)
				{
					if (gClass.gclass120_0.Length != 0 && gClass.gclass120_0[0] != null && gClass.gclass120_0[0].gclass126_0.int_0 != 102 && gClass.gclass120_0[0].gclass126_0.int_0 != 107)
						text4 = ((gClass.gclass117_0.short_0 != 529 && gClass.gclass117_0.short_0 != 530 && gClass.gclass117_0.short_0 != 531 && gClass.gclass117_0.short_0 != 534 && gClass.gclass117_0.short_0 != 535 && gClass.gclass117_0.short_0 != 536) ? (text4 + gClass.gclass120_0[0].method_0()) : ((GClass151.int_0 == 0) ? (gClass.gclass120_0[0].method_0().Split(' ')[3] + " phút") : (gClass.gclass120_0[0].method_0().Split(' ')[3] + " minute")));
					GClass4 gClass3 = GClass4.gclass4_18;
					if (gClass.int_43 < 0 && gClass.gclass117_0.sbyte_0 != 5)
						gClass3 = GClass4.gclass4_17;
					if (gClass.gclass120_0.Length > 1)
					{
						for (int m = 1; m < gClass.gclass120_0.Length; m++)
						{
							if (gClass.gclass120_0[m] != null && gClass.gclass120_0[m].gclass126_0.int_0 != 102 && gClass.gclass120_0[m].gclass126_0.int_0 != 107 && gClass.gclass120_0[m].method_0().StartsWith("Set"))
								text4 = text4 + "," + gClass.gclass120_0[m].method_0();
						}
						for (int n = 1; n < gClass.gclass120_0.Length; n++)
						{
							if (gClass.gclass120_0[n] == null || gClass.method_0())
								continue;
							if ((gClass.gclass117_0.sbyte_0 < 0 || gClass.gclass117_0.sbyte_0 > 4) && gClass.gclass117_0.sbyte_0 != 32)
							{
								if (gClass.gclass117_0.sbyte_0 > 4 && gClass.gclass117_0.sbyte_0 != 32)
									text4 = text4 + "," + gClass.gclass120_0[n].method_0();
								continue;
							}
							try
							{
								int num8 = n;
								GClass128 gClass4 = gClass;
								sbyte language = mResources.language;
								if (language == 0)
								{
									int num9 = gClass4.gclass120_0[num8].gclass126_0.int_0;
									if (num9 <= 81)
									{
										if (num9 != 50)
										{
											switch (num9)
											{
											case 77:
												text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + " HP";
												break;
											case 80:
												text5 = text5 + ((!(text5 == "")) ? ", " : "") + "+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP/30s";
												break;
											case 81:
												text5 = text5 + ((text5 == "") ? "" : ", ") + "+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " KI/30s";
												break;
											case 78:
											case 79:
												break;
											}
										}
										else
											text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + " SĐ";
										continue;
									}
									switch (num9)
									{
									case 94:
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + " GST";
										continue;
									case 95:
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + " HM";
										continue;
									case 96:
										text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + " HK";
										continue;
									case 97:
										text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + " PST";
										continue;
									case 101:
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[0] + " TNSM";
										continue;
									case 103:
										text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + " KI";
										continue;
									case 98:
									case 99:
									case 100:
									case 102:
										continue;
									}
									if (num9 == 108)
										text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[0] + " Né đòn";
									continue;
								}
								if (language != 1)
									continue;
								int num10 = gClass4.gclass120_0[num8].gclass126_0.int_0;
								if (num10 <= 81)
								{
									if (num10 != 50)
									{
										switch (num10)
										{
										case 77:
											text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + " HP";
											break;
										case 80:
											text5 = text5 + ((!(text5 == "")) ? ", " : "") + ((GClass151.int_0 != 0) ? ("+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP/30s") : ("+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP/30s"));
											break;
										case 81:
											text5 = text5 + ((!(text5 == "")) ? ", " : "") + ((GClass151.int_0 == 0) ? ("+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " KI/30s") : ("+" + gClass4.gclass120_0[num8].method_0().Split('+')[1].Split('/')[0] + " MP/30s"));
											break;
										case 78:
										case 79:
											break;
										}
									}
									else
										text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + ((GClass151.int_0 != 0) ? " DMG" : " SĐ");
									continue;
								}
								switch (num10)
								{
								case 94:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[2] + ((GClass151.int_0 == 0) ? " GST" : " RDMG");
									continue;
								case 95:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + ((GClass151.int_0 == 0) ? " HM" : " CHP");
									continue;
								case 96:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + ((GClass151.int_0 != 0) ? " CKI" : " HK");
									continue;
								case 97:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split(' ')[1] + ((GClass151.int_0 != 0) ? " CD" : " PST");
									continue;
								case 101:
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[0] + ((GClass151.int_0 != 0) ? "EXP" : " TNSM");
									continue;
								case 103:
									text5 = text5 + ((text5 == "") ? "" : ", ") + gClass4.gclass120_0[num8].method_0().Split('+')[1] + ((GClass151.int_0 != 0) ? " MP" : " KI");
									continue;
								case 98:
								case 99:
								case 100:
								case 102:
									continue;
								}
								if (num10 == 108)
									text5 = text5 + ((!(text5 == "")) ? ", " : "") + gClass4.gclass120_0[num8].method_0().Split(' ')[0] + ((GClass151.int_0 != 0) ? " Avoid" : " Né đòn");
							}
							catch (Exception)
							{
							}
						}
					}
					if (gClass.gclass117_0.short_0 != 460)
						gClass3.method_6(gclass122_0, text4, num + 5, num2 + 11, GClass4.int_0);
					else
						gClass3.method_6(gclass122_0, "Ném cho Văn Khánh", num + 5, num2 + 11, GClass4.int_0);
				}
				GClass28.smethod_6(gclass122_0, gClass.gclass117_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
				GClass4.gclass4_18.method_10(gclass122_0, text5, int_58 + int_60 - 2, int_59 + i * int_4 + 11, GClass4.int_1, GClass4.gclass4_20);
				if (gClass.gclass120_0 != null)
				{
					for (int num11 = 0; num11 < gClass.gclass120_0.Length; num11++)
					{
						method_214(gclass122_0, gClass.gclass120_0[num11].gclass126_0.int_0, gClass.gclass120_0[num11].int_0, num3, num4, num5, num6);
					}
					for (int num12 = 0; num12 < gClass.gclass120_0.Length; num12++)
					{
						method_215(gclass122_0, gClass.gclass120_0[num12].gclass126_0.int_0, gClass.gclass120_0[num12].int_0, num3, num4, num5, num6);
					}
					for (int num13 = 0; num13 < gClass.gclass120_0.Length; num13++)
					{
						int num14 = 0;
						int num15 = 0;
						int num16 = 0;
						if (gClass.gclass120_0[num13].int_0 > 0)
						{
							if (gClass.gclass120_0[num13].gclass126_0.int_0 == 107)
								num15 = gClass.gclass120_0[num13].int_0;
							if (num14 > num15)
								num16 = num14;
							else if (num14 >= num15)
							{
								if (num14 == num15)
									num16 = num14;
							}
							else
							{
								num16 = num15;
							}
						}
						if (num16 > 0)
						{
							GClass4.gclass4_4.method_10(gclass122_0, num16.ToString(), int_58 + int_60 - 17, int_59 + i * int_4, 0, GClass4.gclass4_6);
							gclass122_0.method_33(gclass70_3, int_58 + int_60 - 11, int_59 + i * int_4 + 1);
						}
					}
				}
				if (gClass.int_30 > 1)
					GClass154.smethod_0().method_1(GClass4.gclass4_15, gclass122_0, "" + gClass.int_30, num3 + num5, num4 + num6 - GClass4.gclass4_15.method_20(), 1, GClass4.gclass4_16);
			}
		}
		catch (Exception)
		{
		}
		method_100(gclass122_0);
	}

	private void method_121(GClass122 gclass122_0)
	{
		if (int_28 == 23 || int_28 == 24)
		{
			for (int i = 0; i < GClass162.smethod_0().string_0.Length; i++)
			{
				gclass122_0.method_16((i != int_29) ? 16773296 : 6805896);
				GClass45.smethod_4(gclass122_0, int_30 + i * int_5, 52, int_5 - 1, 25, (i == int_29) ? 1 : 0, true);
				if (i == int_106)
					gclass122_0.method_31(GClass64.gclass70_0, int_30 + i * int_5 + int_5 / 2, 62, 3);
				GClass4 gClass = ((i != int_29) ? GClass4.gclass4_16 : GClass4.gclass4_14);
				if (GClass162.smethod_0().string_0[i][1].Equals(""))
					gClass.method_6(gclass122_0, GClass162.smethod_0().string_0[i][0], int_30 + i * int_5 + int_5 / 2, 59, GClass4.int_2);
				else
				{
					gClass.method_6(gclass122_0, GClass162.smethod_0().string_0[i][0], int_30 + i * int_5 + int_5 / 2, 53, GClass4.int_2);
					gClass.method_6(gclass122_0, GClass162.smethod_0().string_0[i][1], int_30 + i * int_5 + int_5 / 2, 64, GClass4.int_2);
				}
				if (int_28 == 0 && GClass162.smethod_0().string_0.Length == 5 && GClass144.bool_60 && GClass73.int_8 % 4 == 0)
					gclass122_0.method_31(GClass64.gclass70_0, int_30 + 3 * int_5 + int_5 / 2, 77, GClass122.int_5 | GClass122.int_0);
			}
		}
		if (int_28 == 100)
		{
			gclass122_0.method_16(13524492);
			gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass4.gclass4_6.method_6(gclass122_0, "Thông tin boss", int_58 + int_60 / 2, 59, GClass4.int_2);
		}
		else if (int_28 != 20)
		{
			if (int_28 != 22)
			{
				if (int_28 == 19)
				{
					gclass122_0.method_16(13524492);
					gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
					GClass4.gclass4_6.method_6(gclass122_0, mResources.option, int_58 + int_60 / 2, 59, GClass4.int_2);
				}
				else if (int_28 != 18)
				{
					if (int_28 == 13 && Equals(GClass73.gclass76_1))
					{
						gclass122_0.method_16(13524492);
						gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
						GClass4.gclass4_6.method_6(gclass122_0, mResources.item_receive2, int_58 + int_60 / 2, 59, GClass4.int_2);
					}
					else if (int_28 != 12 || GClass73.gclass76_1 == null)
					{
						if (int_28 != 11)
						{
							if (int_28 != 16)
							{
								if (int_28 == 15)
								{
									gclass122_0.method_16(13524492);
									gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
									GClass4.gclass4_6.method_6(gclass122_0, string_0, int_58 + int_60 / 2, 59, GClass4.int_2);
								}
								else if (int_28 != 2 || GClass73.gclass76_1 == null)
								{
									if (int_28 != 9)
									{
										if (int_28 == 3)
										{
											gclass122_0.method_16(13524492);
											gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
											GClass4.gclass4_6.method_6(gclass122_0, mResources.select_zone, int_30 + int_5 / 2, 59, GClass4.int_2);
										}
										else if (int_28 != 14)
										{
											if (int_28 != 4)
											{
												if (int_28 != 7)
												{
													if (int_28 == 17)
													{
														GClass4.gclass4_6.method_6(gclass122_0, mResources.kigui, int_30 + int_5 / 2, 59, GClass4.int_2);
														gclass122_0.method_16(13524492);
														gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
													}
													else if (int_28 != 8)
													{
														if (int_28 != 10)
														{
															if (int_29 == 3 && string_3.Length != 4)
																gclass122_0.method_1(-int_15, 0);
															for (int j = 0; j < string_2.Length; j++)
															{
																gclass122_0.method_16((j != int_29) ? 16773296 : 6805896);
																GClass45.smethod_4(gclass122_0, int_30 + j * int_5, 52, int_5 - 1, 25, (j == int_29) ? 1 : 0, true);
																if (j == int_106)
																	gclass122_0.method_31(GClass64.gclass70_0, int_30 + j * int_5 + int_5 / 2, 62, 3);
																GClass4 gClass2 = ((j != int_29) ? GClass4.gclass4_16 : GClass4.gclass4_14);
																if (string_2[j][1].Equals(""))
																	gClass2.method_6(gclass122_0, string_2[j][0], int_30 + j * int_5 + int_5 / 2, 59, GClass4.int_2);
																else
																{
																	gClass2.method_6(gclass122_0, string_2[j][0], int_30 + j * int_5 + int_5 / 2, 53, GClass4.int_2);
																	gClass2.method_6(gclass122_0, string_2[j][1], int_30 + j * int_5 + int_5 / 2, 64, GClass4.int_2);
																}
																if (int_28 == 0 && string_2.Length == 5 && GClass144.bool_60 && GClass73.int_8 % 4 == 0)
																	gclass122_0.method_31(GClass64.gclass70_0, int_30 + 3 * int_5 + int_5 / 2, 77, GClass122.int_5 | GClass122.int_0);
															}
															gclass122_0.method_16(13524492);
															gclass122_0.method_15(1, 78, int_2 - 2, 1);
														}
														else
														{
															GClass4.gclass4_6.method_6(gclass122_0, mResources.wat_do_u_want, int_30 + int_5 / 2, 59, GClass4.int_2);
															gclass122_0.method_16(13524492);
															gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
														}
													}
													else
													{
														GClass4.gclass4_6.method_6(gclass122_0, mResources.msg, int_30 + int_5 / 2, 59, GClass4.int_2);
														gclass122_0.method_16(13524492);
														gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
													}
												}
												else
												{
													GClass4.gclass4_6.method_6(gclass122_0, mResources.trangbi, int_30 + int_5 / 2, 59, GClass4.int_2);
													gclass122_0.method_16(13524492);
													gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
												}
											}
											else
											{
												GClass4.gclass4_6.method_6(gclass122_0, mResources.map, int_30 + int_5 / 2, 59, GClass4.int_2);
												gclass122_0.method_16(13524492);
												gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
											}
										}
										else
										{
											gclass122_0.method_16(13524492);
											gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
											GClass4.gclass4_6.method_6(gclass122_0, mResources.select_map, int_30 + int_5 / 2, 59, GClass4.int_2);
										}
									}
									else
									{
										gclass122_0.method_16(13524492);
										gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
										GClass4.gclass4_6.method_6(gclass122_0, mResources.achievement_mission, int_58 + int_60 / 2, 59, GClass4.int_2);
									}
								}
								else
								{
									gclass122_0.method_16(13524492);
									gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
									GClass4.gclass4_6.method_6(gclass122_0, mResources.chest, int_58 + int_60 / 2, 59, GClass4.int_2);
								}
							}
							else
							{
								gclass122_0.method_16(13524492);
								gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
								GClass4.gclass4_6.method_6(gclass122_0, mResources.enemy, int_58 + int_60 / 2, 59, GClass4.int_2);
							}
						}
						else
						{
							gclass122_0.method_16(13524492);
							gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
							GClass4.gclass4_6.method_6(gclass122_0, mResources.friend, int_58 + int_60 / 2, 59, GClass4.int_2);
						}
					}
					else
					{
						gclass122_0.method_16(13524492);
						gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
						GClass4.gclass4_6.method_6(gclass122_0, mResources.UPGRADE, int_58 + int_60 / 2, 59, GClass4.int_2);
					}
				}
				else
				{
					gclass122_0.method_16(13524492);
					gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
					GClass4.gclass4_6.method_6(gclass122_0, mResources.change_flag, int_58 + int_60 / 2, 59, GClass4.int_2);
				}
			}
			else
			{
				gclass122_0.method_16(13524492);
				gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
				GClass4.gclass4_6.method_6(gclass122_0, mResources.autoFunction, int_58 + int_60 / 2, 59, GClass4.int_2);
			}
		}
		else
		{
			gclass122_0.method_16(13524492);
			gclass122_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass4.gclass4_6.method_6(gclass122_0, mResources.account, int_58 + int_60 / 2, 59, GClass4.int_2);
		}
	}

	private void method_122(GClass122 gclass122_0)
	{
		if (int_28 != 13 || (int_29 != 2 && !Equals(GClass73.gclass76_1)))
		{
			gclass122_0.method_5(0, 0, GClass73.int_10, GClass73.int_11);
			gclass122_0.method_16(11837316);
			gclass122_0.method_15(int_0 + 1, int_3 - 15, int_2 - 2, 14);
			gclass122_0.method_16(13524492);
			gclass122_0.method_15(int_0 + 1, int_3 - 15, int_2 - 2, 1);
			gclass122_0.method_31(gclass70_7, int_0 + 11, int_3 - 7, 3);
			gclass122_0.method_31(gclass70_9, int_0 + 75, int_3 - 8, 3);
			GClass4.gclass4_15.method_10(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().long_6) + "", int_0 + 24, int_3 - 13, GClass4.int_0, GClass4.gclass4_16);
			GClass4.gclass4_15.method_10(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().int_68) + "", int_0 + 85, int_3 - 13, GClass4.int_0, GClass4.gclass4_16);
			gclass122_0.method_31(gclass70_10, int_0 + 130, int_3 - 8, 3);
			GClass4.gclass4_15.method_10(gclass122_0, GClass65.smethod_9(GClass78.smethod_1().int_69) + "", int_0 + 140, int_3 - 13, GClass4.int_0, GClass4.gclass4_16);
		}
	}

	private void method_123(GClass122 gclass122_0)
	{
		if (GClass78.smethod_1().gclass106_0 != null)
		{
			if (bool_12)
			{
				GClass106 gClass = ((gclass106_0 != null) ? gclass106_0 : GClass78.smethod_1().gclass106_0);
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), 25, 50, 0, 33);
				GClass4.gclass4_3.method_10(gclass122_0, gClass.string_0, 60, 4, GClass4.int_0, GClass4.gclass4_6);
				GClass4.gclass4_15.method_10(gclass122_0, mResources.member + ": " + gClass.int_3 + "/" + gClass.int_4, 60, 16, GClass4.int_0, GClass4.gclass4_16);
				GClass4.gclass4_15.method_10(gclass122_0, mResources.clan_leader + ": " + gClass.string_3, 60, 27, GClass4.int_0, GClass4.gclass4_16);
				GClass123.smethod_1(gclass122_0, gClass.string_1, 60, 38, int_60 - 70, int_4, GClass4.gclass4_15);
			}
			else
			{
				GClass106 gClass2 = GClass78.smethod_1().gclass106_0;
				if (gClass2 != null)
				{
					GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), 25, 50, 0, 33);
					GClass4.gclass4_3.method_10(gclass122_0, gClass2.string_0, 60, 4, GClass4.int_0, GClass4.gclass4_6);
					GClass4.gclass4_15.method_10(gclass122_0, mResources.achievement_point + ": " + gClass2.string_2, 60, 16, GClass4.int_0, GClass4.gclass4_16);
					GClass4.gclass4_15.method_10(gclass122_0, mResources.clan_point + ": " + gClass2.int_7, 60, 27, GClass4.int_0, GClass4.gclass4_16);
					GClass4.gclass4_15.method_10(gclass122_0, mResources.level + ": " + gClass2.int_6, 60, 38, GClass4.int_0, GClass4.gclass4_16);
					GClass123.smethod_1(gclass122_0, gClass2.string_1, 60, 38, int_60 - 70, int_4, GClass4.gclass4_15);
				}
			}
		}
		else
		{
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), 25, 50, 0, 33);
			GClass4.gclass4_3.method_6(gclass122_0, mResources.not_join_clan, (int_60 - 50) / 2 + 50, 20, GClass4.int_2);
		}
	}

	private void method_124(GClass122 gclass122_0)
	{
		GClass4.gclass4_3.method_10(gclass122_0, "Dragon Ball Pro " + GClass187.string_2, 60, 4, GClass4.int_0, GClass4.gclass4_6);
		GClass4.gclass4_15.method_10(gclass122_0, (GClass151.int_0 != 0) ? ("Current version: " + GClass151.string_2) : ("Phiên bản hiện tại: " + GClass151.string_2), 60, 16, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, (GClass151.int_0 != 0) ? "This mod created by" : "Phiên bản được tạo bởi", 60, 27, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, "Lê Chí Thanh [thanhlc.com]", 60, 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_125(GClass122 gclass122_0)
	{
		GClass4.gclass4_15.method_10(gclass122_0, mResources.select_item, 60, 4, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.lock_trade, 60, 16, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.wait_opp_lock_trade, 60, 27, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.press_done, 60, 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_126(GClass122 gclass122_0)
	{
		method_128(gclass122_0, GClass78.smethod_1());
	}

	private void method_127(GClass122 gclass122_0)
	{
		GClass4.gclass4_15.method_10(gclass122_0, mResources.power + ": " + GClass65.smethod_9(GClass78.smethod_2().long_2), int_0 + 60, 4, GClass4.int_0, GClass4.gclass4_16);
		if (GClass78.smethod_2().long_2 > 0L)
			GClass4.gclass4_15.method_10(gclass122_0, (!GClass78.smethod_2().bool_10) ? GClass78.smethod_2().string_6 : GClass78.smethod_2().method_7(), int_0 + 60, 16, GClass4.int_0, GClass4.gclass4_16);
		if (GClass78.smethod_2().int_20 > 0)
			GClass4.gclass4_15.method_10(gclass122_0, mResources.hit_point + ": " + GClass78.smethod_2().int_20, int_0 + 60, 27, GClass4.int_0, GClass4.gclass4_16);
		if (GClass78.smethod_2().short_24 > 0)
		{
			GClass4.gclass4_15.method_10(gclass122_0, mResources.vitality, int_0 + 60, 38, GClass4.int_0, GClass4.gclass4_16);
			gclass122_0.method_31(GClass144.gclass70_34, int_0 + 100, 41, 0);
			int w = GClass78.smethod_2().int_77 * GClass122.smethod_0(GClass144.gclass70_31) / GClass78.smethod_2().short_24;
			gclass122_0.method_5(100, int_0 + 41, w, 20);
			gclass122_0.method_31(GClass144.gclass70_31, int_0 + 100, 41, 0);
		}
		gclass122_0.method_5(0, 0, GClass73.int_10, GClass73.int_11);
	}

	private void method_128(GClass122 gclass122_0, GClass78 gclass78_2)
	{
		GClass4.gclass4_3.method_10(gclass122_0, ((GClass144.sbyte_13 == 1) ? "       " : "") + gclass78_2.string_3, int_0 + 60, 4, GClass4.int_0, GClass4.gclass4_6);
		if (GClass144.sbyte_13 == 1)
			GClass28.smethod_6(gclass122_0, 5427, int_0 + 55, 4, 0, 0);
		if (gclass78_2.short_24 > 0)
		{
			GClass4.gclass4_15.method_10(gclass122_0, mResources.vitality, int_0 + 60, 16, GClass4.int_0, GClass4.gclass4_16);
			gclass122_0.method_31(GClass144.gclass70_34, int_0 + 95, 19, 0);
			int w = gclass78_2.int_77 * GClass122.smethod_0(GClass144.gclass70_31) / gclass78_2.short_24;
			gclass122_0.method_5(95, int_0 + 19, w, 20);
			gclass122_0.method_31(GClass144.gclass70_31, int_0 + 95, 19, 0);
		}
		gclass122_0.method_5(0, 0, GClass73.int_10, GClass73.int_11);
		if (gclass78_2.long_2 > 0L)
			GClass4.gclass4_15.method_10(gclass122_0, (!gclass78_2.bool_10) ? gclass78_2.string_6 : gclass78_2.method_7(), int_0 + 60, 27, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.power + ": " + GClass65.smethod_9(gclass78_2.long_2), int_0 + 60, 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_129(GClass122 gclass122_0, GClass78 gclass78_2, int int_182, int int_183)
	{
		GClass4.gclass4_3.method_10(gclass122_0, ((GClass144.sbyte_13 == 1) ? "       " : "") + gclass78_2.string_3, int_182 + 60, int_183 + 4, GClass4.int_0, GClass4.gclass4_6);
		if (GClass144.sbyte_13 == 1)
			GClass28.smethod_6(gclass122_0, 5427, int_182 + 55, int_183 + 4, 0, 0);
		if (gclass78_2.short_24 > 0)
		{
			GClass4.gclass4_15.method_10(gclass122_0, mResources.vitality, int_182 + 60, int_183 + 16, GClass4.int_0, GClass4.gclass4_16);
			gclass122_0.method_31(GClass144.gclass70_34, int_182 + 95, int_183 + 19, 0);
			_ = gclass78_2.int_77 * GClass122.smethod_0(GClass144.gclass70_31) / gclass78_2.short_24;
			gclass122_0.method_31(GClass144.gclass70_31, int_182 + 95, int_183 + 19, 0);
		}
		if (gclass78_2.long_2 > 0L)
			GClass4.gclass4_15.method_10(gclass122_0, gclass78_2.bool_10 ? gclass78_2.method_7() : gclass78_2.string_6, int_182 + 60, int_183 + 27, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.power + ": " + GClass65.smethod_9(gclass78_2.long_2), int_182 + 60, int_183 + 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_130(GClass122 gclass122_0)
	{
		GClass4.gclass4_3.method_10(gclass122_0, mResources.zone + " " + GClass20.int_39, 60, 4, GClass4.int_0, GClass4.gclass4_6);
		GClass4.gclass4_15.method_10(gclass122_0, GClass20.string_1, 60, 16, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_3.method_6(gclass122_0, GClass20.int_39 + "", 25, 27, GClass4.int_2);
	}

	public int method_131(GClass128 item)
	{
		if (item != null)
		{
			if (item.method_13())
			{
				if (item.gclass120_0 == null)
					return -1;
				GClass120 gClass = item.gclass120_0[0];
				if (gClass.gclass126_0.int_0 == 22)
				{
					gClass.gclass126_0 = GClass144.smethod_8().gclass126_0[6];
					gClass.int_0 *= 1000;
				}
				if (gClass.gclass126_0.int_0 == 23)
				{
					gClass.gclass126_0 = GClass144.smethod_8().gclass126_0[7];
					gClass.int_0 *= 1000;
				}
				GClass128 gClass2 = null;
				for (int i = 0; i < GClass78.smethod_1().gclass128_2.Length; i++)
				{
					GClass128 gClass3 = GClass78.smethod_1().gclass128_2[i];
					if (gClass.gclass126_0.int_0 == 22)
					{
						gClass.gclass126_0 = GClass144.smethod_8().gclass126_0[6];
						gClass.int_0 *= 1000;
					}
					if (gClass.gclass126_0.int_0 == 23)
					{
						gClass.gclass126_0 = GClass144.smethod_8().gclass126_0[7];
						gClass.int_0 *= 1000;
					}
					if (gClass3 != null && gClass3.gclass120_0 != null && gClass3.gclass117_0.sbyte_0 == item.gclass117_0.sbyte_0)
					{
						gClass2 = gClass3;
						break;
					}
				}
				if (gClass2 != null)
				{
					int num = 0;
					num = ((gClass2 == null || gClass2.gclass120_0 == null) ? gClass.int_0 : (gClass.int_0 - gClass2.gclass120_0[0].int_0));
					if (num >= 0)
						bool_19 = true;
					else
						bool_19 = false;
					return num;
				}
				bool_19 = true;
				return gClass.int_0;
			}
			return 0;
		}
		return -1;
	}

	private void method_132(GClass122 gclass122_0)
	{
		GClass4.gclass4_3.method_6(gclass122_0, mResources.MENUGENDER[GClass20.sbyte_2], 60, 4, GClass4.int_0);
		string text = "";
		if (GClass20.int_37 >= 135 && GClass20.int_37 <= 138)
			text = " " + mResources.tang + GClass20.int_39;
		GClass4.gclass4_15.method_6(gclass122_0, GClass20.string_1 + text, 60, 16, GClass4.int_0);
		GClass4.gclass4_3.method_6(gclass122_0, mResources.quest_place + ": ", 60, 27, GClass4.int_0);
		if (GClass144.smethod_27() < 0 || GClass144.smethod_27() > GClass20.string_2.Length - 1)
			GClass4.gclass4_15.method_6(gclass122_0, mResources.random, 60, 38, GClass4.int_0);
		else
			GClass4.gclass4_15.method_6(gclass122_0, GClass20.string_2[GClass144.smethod_27()], 60, 38, GClass4.int_0);
	}

	private void method_133(GClass122 gclass122_0)
	{
		if (int_29 == string_2.Length - 1 && GClass73.gclass76_1 == null)
			method_126(gclass122_0);
		else if (int_67 < 0)
		{
			if (int_57 != 2)
			{
				GClass4.gclass4_20.method_6(gclass122_0, mResources.say_hello, int_0 + 60, 14, 0);
				GClass4.gclass4_20.method_6(gclass122_0, string_26, int_0 + 60, 26, 0);
				return;
			}
			GClass4.gclass4_20.method_6(gclass122_0, mResources.say_hello, int_0 + 60, 5, 0);
			GClass4.gclass4_20.method_6(gclass122_0, string_26, int_0 + 60, 17, 0);
			GClass4.gclass4_20.method_6(gclass122_0, mResources.page + " " + (int_38[int_29] + 1) + "/" + int_37[int_29], int_0 + 60, 29, 0);
		}
		else
		{
			if (int_29 < 0 || int_29 > GClass78.smethod_1().gclass128_3.Length - 1 || int_67 < 0 || int_67 > GClass78.smethod_1().gclass128_3[int_29].Length - 1)
				return;
			GClass128 gClass = GClass78.smethod_1().gclass128_3[int_29][int_67];
			if (gClass != null)
			{
				if (Equals(GClass73.gclass76_0) && int_29 <= 3 && int_57 == 2)
					GClass4.gclass4_3.method_6(gclass122_0, mResources.page + " " + (int_38[int_29] + 1) + "/" + int_37[int_29], int_0 + 55, 4, 0);
				GClass4.gclass4_3.method_6(gclass122_0, gClass.gclass117_0.string_0, int_0 + 55, 24, 0);
				string st = mResources.pow_request + " " + GClass50.smethod_31(gClass.gclass117_0.int_2);
				if (gClass.gclass117_0.int_2 <= GClass78.smethod_1().long_2)
					GClass4.gclass4_19.method_6(gclass122_0, st, int_0 + 55, 35, 0);
				else
					GClass4.gclass4_15.method_6(gclass122_0, st, int_0 + 55, 35, 0);
			}
		}
	}

	private void method_134(GClass122 gclass122_0)
	{
		string st = mResources.used + ": " + int_39 + "/" + GClass78.smethod_1().gclass128_1.Length + " " + mResources.place;
		GClass4.gclass4_3.method_6(gclass122_0, mResources.chest, 60, 4, 0);
		GClass4.gclass4_15.method_6(gclass122_0, st, 60, 16, 0);
	}

	private void method_135(GClass122 gclass122_0)
	{
		GClass4.gclass4_20.method_6(gclass122_0, (GClass78.smethod_1().int_3 != 1) ? ("Top " + GClass78.smethod_1().int_3) : ((GClass151.int_0 != 0) ? ("Top " + GClass78.smethod_1().int_3) : ".:!:.Thiên hạ đệ nhất.:!:."), int_0 + 45 + (int_2 - 50) / 2, 2, GClass4.int_2);
		GClass4.gclass4_15.method_6(gclass122_0, mResources.potential_point, int_0 + 45 + (int_2 - 50) / 2, 14, GClass4.int_2);
		GClass4.gclass4_20.method_6(gclass122_0, "" + GClass65.smethod_9(GClass78.smethod_1().long_4), int_0 + ((GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0) + 45 + (int_2 - 50) / 2, 26, GClass4.int_2);
		GClass4.gclass4_15.method_6(gclass122_0, mResources.active_point + ": " + GClass65.smethod_9(GClass78.smethod_1().long_5), int_0 + ((GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0) + 45 + (int_2 - 50) / 2, 38, GClass4.int_2);
	}

	private void method_136(GClass122 gclass122_0)
	{
		GClass4.gclass4_15.method_10(gclass122_0, mResources.HP + ": " + GClass65.smethod_9(GClass78.smethod_1().int_25) + " / " + GClass65.smethod_9(GClass78.smethod_1().int_35), int_0 + 60, 2, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.KI + ": " + GClass65.smethod_9(GClass78.smethod_1().int_24) + " / " + GClass65.smethod_9(GClass78.smethod_1().int_36), int_0 + 60, 14, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.hit_point + ": " + GClass65.smethod_9(GClass78.smethod_1().int_20), int_0 + 60, 26, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.armor + ": " + GClass65.smethod_9(GClass78.smethod_1().int_21) + ", " + mResources.critical + ": " + GClass78.smethod_1().int_22 + "%", int_0 + 60, 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_137(GClass122 gclass122_0, int int_182, int int_183)
	{
		GClass4.gclass4_15.method_10(gclass122_0, mResources.HP + ": " + GClass78.smethod_1().int_25 + " / " + GClass78.smethod_1().int_35, int_182, int_183 + 2, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.KI + ": " + GClass78.smethod_1().int_24 + " / " + GClass78.smethod_1().int_36, int_182, int_183 + 14, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.hit_point + ": " + GClass78.smethod_1().int_20, int_182, int_183 + 26, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.armor + ": " + GClass78.smethod_1().int_21 + ", " + mResources.critical + ": " + GClass78.smethod_1().int_22 + "%", int_182, int_183 + 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_138(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_0 + 1, int_1, int_2 - 2, int_59 - 2);
		gclass122_0.method_16(9993045);
		gclass122_0.method_15(int_0, int_1, int_2 - 2, 50);
		int num = int_28;
		switch (num)
		{
		default:
			if (num != 100)
				break;
			goto case 11;
		case 0:
			if (int_29 == 0)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_126(gclass122_0);
			}
			if (int_29 == 1)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				if (bool_30)
					method_128(gclass122_0, GClass78.smethod_1());
				else
					method_136(gclass122_0);
			}
			if (int_29 == 2)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_135(gclass122_0);
			}
			if (int_29 == 3)
			{
				if (string_3.Length != 5)
				{
					GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
					method_124(gclass122_0);
				}
				else
					method_123(gclass122_0);
			}
			if (int_29 == 4)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_124(gclass122_0);
			}
			break;
		case 1:
			if (int_29 != string_2.Length - 1 || GClass73.gclass76_1 != null)
			{
				if (GClass78.smethod_1().gclass79_0 != null)
					GClass28.smethod_6(gclass122_0, GClass78.smethod_1().gclass79_0.int_70, int_0 + 25, 50, 0, 33);
			}
			else
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_133(gclass122_0);
			break;
		case 2:
			if (int_29 == 0)
			{
				GClass28.smethod_6(gclass122_0, 526, int_0 + 25, 50, 0, 33);
				method_134(gclass122_0);
			}
			if (int_29 == 1)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_136(gclass122_0);
			}
			break;
		case 3:
			GClass28.smethod_6(gclass122_0, 561, int_0 + 25, 50, 0, 33);
			method_130(gclass122_0);
			break;
		case 4:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_132(gclass122_0);
			break;
		case 8:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 9:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 10:
			if (gclass78_0 != null)
			{
				GClass28.smethod_6(gclass122_0, gclass78_0.method_8(), int_0 + 25, 50, 0, 33);
				method_128(gclass122_0, gclass78_0);
			}
			break;
		case 12:
			if (int_29 == 0)
			{
				int id = 1410;
				for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
				{
					GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
					if (gClass.gclass127_0.int_0 == int_152)
						id = gClass.int_70;
				}
				GClass28.smethod_6(gclass122_0, id, int_0 + 25, 50, 0, 33);
				method_143(gclass122_0);
			}
			if (int_29 == 1)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_126(gclass122_0);
			}
			break;
		case 13:
			if (int_29 == 0 || int_29 == 1)
			{
				if (Equals(GClass73.gclass76_0))
				{
					GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
					method_125(gclass122_0);
				}
				if (Equals(GClass73.gclass76_1) && gclass78_0 != null)
				{
					GClass28.smethod_6(gclass122_0, gclass78_0.method_8(), int_0 + 25, 50, 0, 33);
					method_128(gclass122_0, gclass78_0);
				}
			}
			if (int_29 == 2 && gclass78_0 != null)
			{
				GClass28.smethod_6(gclass122_0, gclass78_0.method_8(), int_0 + 25, 50, 0, 33);
				method_128(gclass122_0, gclass78_0);
			}
			break;
		case 14:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_132(gclass122_0);
			break;
		case 15:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 7:
		case 17:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 18:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 19:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_124(gclass122_0);
			break;
		case 20:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_124(gclass122_0);
			break;
		case 21:
			if (int_29 == 0)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_2().method_8(), int_0 + 25, 50, 0, 33);
				method_127(gclass122_0);
			}
			if (int_29 == 1)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_2().method_8(), int_0 + 25, 50, 0, 33);
				method_142(gclass122_0);
			}
			if (int_29 == 2)
			{
				GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
				method_136(gclass122_0);
			}
			break;
		case 22:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_124(gclass122_0);
			break;
		case 11:
		case 16:
		case 23:
		case 24:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_124(gclass122_0);
			break;
		case 25:
			GClass28.smethod_6(gclass122_0, GClass78.smethod_1().method_8(), int_0 + 25, 50, 0, 33);
			method_126(gclass122_0);
			break;
		case 5:
		case 6:
			break;
		}
	}

	private void method_139(GClass122 gclass122_0)
	{
	}

	private void method_140(GClass122 gclass122_0)
	{
	}

	private string method_141(int int_182)
	{
		switch (int_182)
		{
		default:
			return "aaa";
		case 0:
			return mResources.follow;
		case 1:
			return mResources.defend;
		case 2:
			return mResources.attack;
		case 3:
			return mResources.gohome;
		}
	}

	private void method_142(GClass122 gclass122_0)
	{
		GClass4.gclass4_3.method_10(gclass122_0, "HP: " + GClass78.smethod_2().int_25 + "/" + GClass78.smethod_2().int_35, int_0 + 60, 4, GClass4.int_0, GClass4.gclass4_6);
		GClass4.gclass4_3.method_10(gclass122_0, "MP: " + GClass78.smethod_2().int_24 + "/" + GClass78.smethod_2().int_36, int_0 + 60, 16, GClass4.int_0, GClass4.gclass4_6);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.critical + ": " + GClass78.smethod_2().int_22 + "   " + mResources.armor + ": " + GClass78.smethod_2().int_21, int_0 + 60, 27, GClass4.int_0, GClass4.gclass4_16);
		GClass4.gclass4_15.method_10(gclass122_0, mResources.status + ": " + string_22[GClass78.smethod_2().sbyte_15], int_0 + 60, 38, GClass4.int_0, GClass4.gclass4_16);
	}

	private void method_143(GClass122 gclass122_0)
	{
		if (string_25 != null)
		{
			for (int i = 0; i < string_25.Length; i++)
			{
				GClass4.gclass4_20.method_6(gclass122_0, string_25[i], int_0 + 45 + (int_2 - 50) / 2, 5 + i * 14, GClass4.int_2);
			}
		}
	}

	private void method_144(GClass122 gclass122_0)
	{
	}

	public void method_145(GClass122 g)
	{
		g.method_5(int_58, int_59, int_60, int_61);
		g.method_1(-int_17, -int_18);
		g.method_31(gclass70_2, int_58, int_59, 0);
		int num = GClass78.smethod_1().int_119;
		GClass28.smethod_6(g, GClass144.gclass116_0[num].gclass66_0[GClass78.int_94[0][0][0]].short_0, int_143, int_144 + 5, 0, 3);
		int align = GClass4.int_2;
		if (int_143 <= 40)
			align = GClass4.int_0;
		if (int_143 >= 220)
			align = GClass4.int_1;
		GClass4.gclass4_4.method_10(g, GClass20.string_1, int_143, int_144 - 12, align, GClass4.gclass4_16);
		int num2 = -1;
		if (GClass144.smethod_27() != -1)
		{
			for (int i = 0; i < int_52[GClass20.sbyte_2].Length; i++)
			{
				if (int_52[GClass20.sbyte_2][i] != GClass144.smethod_27())
				{
					num2 = 4;
					continue;
				}
				num2 = i;
				break;
			}
			if (GClass73.int_8 % 4 > 0)
				g.method_31(GClass64.gclass70_0, int_58 + int_53[GClass20.sbyte_2][num2], int_59 + int_54[GClass20.sbyte_2][num2], 3);
		}
		if (GClass73.bool_5)
		{
			if (!bool_5)
			{
				for (int j = 0; j < int_53[GClass20.sbyte_2].Length; j++)
				{
					int num3 = int_53[GClass20.sbyte_2][j] + int_58;
					int num4 = int_54[GClass20.sbyte_2][j] + int_59;
					if (GClass50.smethod_29(num3 - 15, num4 - 15, 30, 30, int_26, int_27))
					{
						align = GClass4.int_2;
						if (num3 <= 30)
							align = GClass4.int_0;
						if (num3 >= 220)
							align = GClass4.int_1;
						g.method_31(gclass70_0, num3, num4, GClass188.int_2);
						GClass4.gclass4_4.method_10(g, GClass20.string_2[int_52[GClass20.sbyte_2][j]], num3, num4 - 12, align, GClass4.gclass4_16);
						break;
					}
				}
			}
		}
		else
		{
			g.method_31(gclass70_0, int_147, int_148, GClass188.int_2);
			for (int k = 0; k < int_53[GClass20.sbyte_2].Length; k++)
			{
				int num5 = int_53[GClass20.sbyte_2][k] + int_58;
				int num6 = int_54[GClass20.sbyte_2][k] + int_59;
				if (GClass50.smethod_29(num5 - 15, num6 - 15, 30, 30, int_147, int_148))
				{
					align = GClass4.int_2;
					if (num5 <= 20)
						align = GClass4.int_0;
					if (num5 >= 220)
						align = GClass4.int_1;
					GClass4.gclass4_4.method_10(g, GClass20.string_2[int_52[GClass20.sbyte_2][k]], num5, num6 - 12, align, GClass4.gclass4_16);
					break;
				}
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
		if (num2 != -1)
		{
			if (int_53[GClass20.sbyte_2][num2] + int_58 < int_17)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 5, int_58 + 5, int_59 + int_61 / 2 - 4, 0);
			if (int_17 + int_60 < int_53[GClass20.sbyte_2][num2] + int_58)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 6, int_58 + int_60 - 5, int_59 + int_61 / 2 - 4, GClass188.int_2);
			if (int_54[GClass20.sbyte_2][num2] < int_18)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 1, int_58 + int_60 / 2, int_59 + 5, GClass188.int_0);
			if (int_54[GClass20.sbyte_2][num2] > int_18 + int_61)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_58 + int_60 / 2, int_59 + int_61 - 5, GClass188.int_3);
		}
	}

	public void method_146(GClass122 g)
	{
		int num = ((GClass73.int_11 > 300) ? 20 : 15);
		if (bool_20 && !GClass144.smethod_8().method_2() && !GClass144.smethod_8().method_3())
		{
			g.method_31((int_104 != 1) ? GClass144.gclass70_22 : GClass144.gclass70_23, int_58 + int_60 / 2, int_59 + int_61 - num, 3);
			GClass4.gclass4_6.method_6(g, mResources.map, int_58 + int_60 / 2, int_59 + int_61 - (num + 5), GClass4.int_2);
		}
		int_117 = int_58 + 5;
		int_118 = int_59 + 14;
		int_142 = int_118;
		g.method_5(int_58, int_59, int_60, int_61 - 35);
		if (gclass179_0 != null)
		{
			if (gclass179_0.int_3 > 0)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 1, int_58 + int_60 - 12, int_59 + 3, 0);
			if (gclass179_0.int_3 < gclass179_0.int_13)
				g.method_23(GClass194.gclass70_0, 0, 0, 9, 6, 0, int_58 + int_60 - 12, int_59 + int_61 - 45, 0);
			g.method_1(0, -gclass179_0.int_3);
		}
		int_134 = 0;
		if (int_135 != 0)
		{
			if (int_135 == 1)
			{
				int_142 = int_118 - 12;
				for (int i = 0; i < GClass78.smethod_1().gclass88_4.method_2(); i++)
				{
					GClass62 gClass = (GClass62)GClass78.smethod_1().gclass88_4.method_3(i);
					GClass4.gclass4_20.method_6(g, gClass.string_0, int_117 + 5, int_142 += 12, 0);
					if (gClass.int_1 == gClass.short_0)
						GClass4.gclass4_20.method_6(g, ((gClass.int_0 != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + GClass194.gclass177_0[gClass.int_2].string_0 + " (" + gClass.int_1 + "/" + gClass.short_0 + ")", int_117 + 5, int_142 += 12, 0);
					else
						GClass4.gclass4_18.method_6(g, ((gClass.int_0 == 0) ? mResources.KILL : mResources.KILLBOSS) + " " + GClass194.gclass177_0[gClass.int_2].string_0 + " (" + gClass.int_1 + "/" + gClass.short_0 + ")", int_117 + 5, int_142 += 12, 0);
					int_134 += 3;
					int_140 = int_119 - 25;
					method_148(g, GClass4.gclass4_16, gClass.string_1, int_117 + 5, int_142 += 12, 0);
					int_142 += 12;
				}
			}
		}
		else
		{
			bool flag = false;
			if (GClass78.smethod_1().gclass56_0 == null)
			{
				int num2 = GClass144.smethod_27();
				sbyte b = GClass144.smethod_28();
				string empty = "";
				if (num2 == -3 || b == -3)
					empty = mResources.DES_TASK[3];
				else if (GClass78.smethod_1().gclass56_0 == null && GClass78.smethod_1().int_15 == 9 && GClass78.smethod_1().gclass176_0.int_0 == 0)
				{
					empty = mResources.TASK_INPUT_CLASS;
				}
				else
				{
					if (b < 0 || num2 < 0)
						return;
					empty = mResources.DES_TASK[0] + GClass79.gclass127_1[b].string_0 + mResources.DES_TASK[1] + GClass20.string_2[num2] + mResources.DES_TASK[2];
				}
				string[] array = GClass4.gclass4_20.method_15(empty, 150);
				for (int j = 0; j < array.Length; j++)
				{
					if (j == 0)
						GClass4.gclass4_20.method_6(g, array[j], int_117 + 5, int_142 = int_118, 0);
					else
						GClass4.gclass4_20.method_6(g, array[j], int_117 + 5, int_142 += 12, 0);
				}
			}
			else
			{
				for (int k = 0; k < GClass78.smethod_1().gclass56_0.string_0.Length; k++)
				{
					GClass4.gclass4_16.method_6(g, GClass78.smethod_1().gclass56_0.string_0[k], int_58 + int_60 / 2, int_142 - 5 + k * 12, GClass4.int_2);
					int_134++;
				}
				int_142 += (GClass78.smethod_1().gclass56_0.string_0.Length - 1) * 12;
				int num3 = 0;
				string empty2 = "";
				for (int l = 0; l < GClass78.smethod_1().gclass56_0.string_2.Length; l++)
				{
					if (GClass78.smethod_1().gclass56_0.string_2[l] == null)
					{
						if (GClass78.smethod_1().gclass56_0.int_0 <= l)
						{
							empty2 = "- " + GClass78.smethod_1().gclass56_0.string_2[num3];
							GClass4 gClass2 = GClass4.gclass4_16;
							if (!flag)
							{
								flag = true;
								gClass2 = GClass4.gclass4_18;
							}
							gClass2.method_6(g, empty2, int_117 + 5 + ((gClass2 == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
						}
						continue;
					}
					num3 = l;
					empty2 = "- " + GClass78.smethod_1().gclass56_0.string_2[l];
					if (GClass78.smethod_1().gclass56_0.short_0[l] == -1)
					{
						if (GClass78.smethod_1().gclass56_0.int_0 <= l)
						{
							GClass4 gclass4_ = GClass4.gclass4_16;
							if (!flag)
							{
								flag = true;
								gclass4_ = GClass4.gclass4_18;
								gclass4_.method_6(g, empty2, int_117 + 5 + ((gclass4_ == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
							}
							else
								gclass4_.method_6(g, "- ...", int_117 + 5 + ((gclass4_ == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
						}
						else
							GClass4.gclass4_20.method_6(g, empty2, int_117 + 5, int_142 += 12, 0);
					}
					else if (GClass78.smethod_1().gclass56_0.int_0 == l)
					{
						if (GClass78.smethod_1().gclass56_0.short_0[l] != 1)
						{
							string text = empty2;
							empty2 = text + " (" + GClass78.smethod_1().gclass56_0.short_2 + "/" + GClass78.smethod_1().gclass56_0.short_0[l] + ")";
						}
						if (GClass78.smethod_1().gclass56_0.short_2 != GClass78.smethod_1().gclass56_0.short_0[l])
						{
							GClass4 gclass4_2 = GClass4.gclass4_16;
							if (!flag)
							{
								flag = true;
								gclass4_2 = GClass4.gclass4_18;
								gclass4_2.method_6(g, empty2, int_117 + 5 + ((gclass4_2 == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
							}
							else
								gclass4_2.method_6(g, "- ...", int_117 + 5 + ((gclass4_2 == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
						}
						else
							GClass4.gclass4_11.method_6(g, empty2, int_117 + 5, int_142 += 12, 0);
					}
					else if (GClass78.smethod_1().gclass56_0.int_0 > l)
					{
						if (GClass78.smethod_1().gclass56_0.short_0[l] != 1)
						{
							string text2 = empty2;
							empty2 = text2 + " (" + GClass78.smethod_1().gclass56_0.short_0[l] + "/" + GClass78.smethod_1().gclass56_0.short_0[l] + ")";
						}
						GClass4.gclass4_20.method_6(g, empty2, int_117 + 5, int_142 += 12, 0);
					}
					else
					{
						if (GClass78.smethod_1().gclass56_0.short_0[l] != 1)
							empty2 = empty2 + " 0/" + GClass78.smethod_1().gclass56_0.short_0[l];
						GClass4 gclass4_3 = GClass4.gclass4_16;
						if (!flag)
						{
							flag = true;
							gclass4_3 = GClass4.gclass4_18;
							gclass4_3.method_6(g, empty2, int_117 + 5 + ((gclass4_3 == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
						}
						else
							gclass4_3.method_6(g, "- ...", int_117 + 5 + ((gclass4_3 == GClass4.gclass4_18 && GClass73.int_8 % 20 > 10) ? (GClass73.int_8 % 4 / 2) : 0), int_142 += 12, 0);
					}
					int_134++;
				}
				int_142 += 5;
				for (int m = 0; m < GClass78.smethod_1().gclass56_0.string_1.Length; m++)
				{
					GClass4.gclass4_14.method_6(g, GClass78.smethod_1().gclass56_0.string_1[m], int_117 + 5, int_142 += 12, 0);
					int_134++;
				}
			}
		}
		if (gclass179_0 == null)
		{
			gclass179_0 = new GClass179();
			gclass179_0.method_6(int_134, 12, int_58, int_59, int_60, int_61 - num - 40, true, 1);
		}
	}

	public void method_147(GClass122 g, GClass4 f, string[] arr, string str, int x, int y, int align)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			string text = arr[i];
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					f = GClass4.gclass4_6;
				}
				else if (!text.StartsWith("c1"))
				{
					if (text.StartsWith("c2"))
					{
						text = text.Substring(2);
						f = GClass4.gclass4_8;
					}
				}
				else
				{
					text = text.Substring(2);
					f = GClass4.gclass4_4;
				}
			}
			if (i == 0)
			{
				f.method_6(g, text, x, y, align);
				continue;
			}
			if (i < int_133 + 30 && i > int_133 - 30)
				f.method_6(g, text, x, y += 12, align);
			else
				y += 12;
			int_142 += 12;
			int_134++;
		}
	}

	public void method_148(GClass122 g, GClass4 f, string str, int x, int y, int align)
	{
		int num = ((!GClass73.bool_5 || GClass73.int_10 < 320) ? 10 : 20);
		string[] array = f.method_15(str, int_140 - num);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.method_6(g, array[i], x, y, align);
				continue;
			}
			if (i >= int_133 + 15 || i <= int_133 - 15)
				y += 12;
			else
				f.method_6(g, array[i], x, y += 12, align);
			int_142 += 12;
			int_134++;
		}
	}

	public void method_149()
	{
		for (int i = 0; i < gclass88_0.method_2(); i++)
		{
			((GClass128)gclass88_0.method_3(i)).bool_0 = false;
		}
		gclass88_0.method_9();
	}

	public void method_150()
	{
		if (int_64 > 0)
		{
			bool_21 = false;
			return;
		}
		if (method_212())
			GClass78.smethod_1().method_138();
		if (gclass91_0 != null && int_28 == 13 && gclass91_0.bool_0)
			gclass91_0 = null;
		if (int_28 == 13 && !bool_3)
			GClass7.smethod_0().method_6(3, -1, -1, -1);
		GClass50.smethod_8("HIDE PANELLLLLLLLLLLLLLLLLLLLLL");
		GClass109.smethod_1().method_34();
		GClass144.bool_73 = true;
		GClass20.sbyte_3 = -1;
		gclass70_2 = null;
		GClass203.smethod_26();
		bool_9 = false;
		bool_21 = true;
		method_149();
		GClass31.smethod_2();
		GClass73.gclass76_1 = null;
		GClass73.smethod_49();
		GClass73.smethod_26();
		int_97 = 0;
		int_96 = 0;
		bool_13 = false;
		bool_0 = false;
		if ((GClass78.smethod_1().int_25 <= 0 || GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_11 == 5) && GClass78.smethod_1().bool_62)
		{
			GClass87 gClass = new GClass87(mResources.DIES[0], 11038, GClass144.smethod_8());
			GClass144.smethod_8().gclass87_1 = gClass;
			GClass78.smethod_1().int_25 = 0;
		}
	}

	public void method_151()
	{
		if (int_64 <= 0)
		{
			if (method_212())
				GClass78.smethod_1().method_138();
			if (gclass91_0 != null && int_28 == 13 && gclass91_0.bool_0)
				gclass91_0 = null;
			if (int_28 == 13 && !bool_3)
				GClass7.smethod_0().method_6(3, -1, -1, -1);
			if (int_28 == 15)
				GClass7.smethod_0().method_141(-1);
			GClass109.smethod_1().method_34();
			GClass144.bool_73 = true;
			GClass20.sbyte_3 = -1;
			if (gclass70_2 != null)
			{
				gclass70_2.texture2D_0 = null;
				gclass70_2 = null;
			}
			GClass203.smethod_26();
			bool_9 = false;
			if (int_28 == 4)
			{
				method_40();
				int_14 = 0;
				int_15 = 0;
			}
			else if (int_28 == 24)
			{
				method_169();
			}
			else if (int_28 != 23)
			{
				if (int_28 != 3 && int_28 != 14)
				{
					if (int_28 != 18 && int_28 != 19 && int_28 != 20 && int_28 != 21)
					{
						if (int_28 == 8 || int_28 == 11 || int_28 == 16)
						{
							method_205();
							int_14 = 0;
							int_15 = 0;
						}
						else
							bool_21 = true;
					}
					else
					{
						method_40();
						int_14 = 0;
						int_15 = 0;
					}
				}
				else if (bool_23)
				{
					bool_21 = true;
				}
				else
				{
					method_40();
					int_14 = 0;
					int_15 = 0;
				}
			}
			else
			{
				method_40();
			}
			GClass31.smethod_2();
			GClass73.gclass76_1 = null;
			GClass73.smethod_49();
			GClass73.smethod_26();
			GClass73.bool_22 = false;
			int_97 = 0;
			int_96 = 0;
			bool_13 = false;
			if ((GClass78.smethod_1().int_25 <= 0 || GClass78.smethod_1().int_11 == 14 || GClass78.smethod_1().int_11 == 5) && GClass78.smethod_1().bool_62)
			{
				GClass87 gClass = new GClass87(mResources.DIES[0], 11038, GClass144.smethod_8());
				GClass144.smethod_8().gclass87_1 = gClass;
				GClass78.smethod_1().int_25 = 0;
			}
		}
		else
			bool_21 = false;
	}

	public void method_152()
	{
		if (gclass91_0 != null && gclass91_0.bool_0)
		{
			gclass91_0.method_7();
			return;
		}
		if (bool_24)
		{
			int_151++;
			if (int_151 == 10)
			{
				int_151 = 0;
				bool_24 = false;
				gclass91_0.gclass191_0.method_23("");
				gclass91_0.string_1 = mResources.kiguiXuchat + " ";
				gclass91_0.gclass191_0.string_7 = mResources.input_money;
				gclass91_0.string_0 = "";
				gclass91_0.bool_0 = true;
				gclass91_0.gclass191_0.method_28(GClass191.int_12);
				gclass91_0.gclass191_0.method_26(10);
				if (GClass73.bool_5)
					gclass91_0.gclass191_0.method_0();
				if (Main.isWindowsPhone)
					gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
				if (!Main.isPC)
					gclass91_0.method_5(this, "");
			}
			return;
		}
		if (!bool_25)
		{
			if (gclass179_0 != null)
				gclass179_0.method_5();
			if (gclass84_0 != null && gclass84_0.bool_0)
			{
				gclass84_0.method_7();
				return;
			}
			method_91();
			if (method_216() && bool_30)
			{
				if (gclass81_0 == null)
				{
					gclass81_0 = new GClass81(205, 0, 0, 3, 10, -1);
					gclass81_0.int_1 = 2;
				}
				if (gclass81_0 != null)
					gclass81_0.method_4();
			}
			if (int_99 > 0)
			{
				int_99--;
				if (int_99 == 0)
				{
					int_42[int_29] = int_67;
					switch (int_28)
					{
					case 0:
						method_184();
						break;
					case 2:
						method_192();
						break;
					case 3:
						method_190();
						break;
					case 4:
						method_189();
						break;
					case 7:
						if (!Equals(GClass73.gclass76_1) || GClass73.gclass76_0.int_28 != 2)
						{
							method_165();
							break;
						}
						method_192();
						return;
					case 8:
						method_182();
						break;
					case 9:
						method_164();
						break;
					case 10:
						method_162();
						break;
					case 11:
						method_180();
						break;
					case 12:
						method_161();
						break;
					case 13:
						method_160();
						break;
					case 14:
						method_159();
						break;
					case 15:
						method_158();
						break;
					case 16:
						method_179();
						break;
					case 1:
					case 17:
						method_163();
						break;
					case 18:
						method_181();
						break;
					case 19:
						method_204();
						break;
					case 20:
						method_208();
						break;
					case 21:
						method_156();
						break;
					case 22:
						method_155();
						break;
					case 23:
						GClass162.smethod_0().method_6();
						break;
					case 25:
						method_153();
						break;
					}
				}
			}
			for (int i = 0; i < GClass189.gclass88_0.method_2(); i++)
			{
				((GClass189)GClass189.gclass88_0.method_3(i)).method_1();
			}
			method_196();
			return;
		}
		int_151++;
		if (int_151 == 10)
		{
			int_151 = 0;
			bool_25 = false;
			gclass91_0.gclass191_0.method_23("");
			gclass91_0.string_1 = mResources.kiguiLuongchat + "  ";
			gclass91_0.gclass191_0.string_7 = mResources.input_money;
			gclass91_0.string_0 = "";
			gclass91_0.bool_0 = true;
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			gclass91_0.gclass191_0.method_26(10);
			if (GClass73.bool_5)
				gclass91_0.gclass191_0.method_0();
			if (Main.isWindowsPhone)
				gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
			if (!Main.isPC)
				gclass91_0.method_5(this, "");
		}
	}

	private void method_153()
	{
	}

	private void method_154()
	{
		if (int_67 != -1)
		{
			int_149 = int_67;
			((Class9)gclass88_12.method_3(int_149)).bool_0 = true;
			GClass1.smethod_9(((Class9)gclass88_12.method_3(int_149)).short_0 + "", 1);
			method_168();
		}
	}

	private void method_155()
	{
	}

	private void method_156()
	{
		if (int_29 == 0)
		{
			if (int_67 == -1 || int_67 > GClass78.smethod_2().gclass128_2.Length - 1)
				return;
			GClass88 gClass = new GClass88("");
			gclass128_0 = GClass78.smethod_2().gclass128_2[int_67];
			if (gclass128_0 == null)
				gclass96_0 = null;
			else
			{
				if (Main.isRightClick)
				{
					_ = GClass78.smethod_2().gclass128_2;
					sbyte id = (sbyte)int_67;
					GClass7.smethod_0().method_30(sbyte_7, id);
					Main.isRightClick = false;
					return;
				}
				gClass.method_0(new GClass87(mResources.MOVEOUT, this, 2006, gclass128_0));
				GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_42(gclass128_0);
			}
		}
		if (int_29 == 1)
			method_157();
		if (int_29 == 2)
			method_165();
	}

	private void method_157()
	{
		if (int_67 == -1)
			return;
		if (int_67 == 5)
		{
			GClass73.smethod_36(mResources.sure_fusion, new GClass87(mResources.YES, 888351), new GClass87(mResources.NO, 2001));
			return;
		}
		GClass7.smethod_0().method_133((sbyte)int_67);
		if (int_67 < 4)
			GClass78.smethod_2().sbyte_15 = (sbyte)int_67;
	}

	private void method_158()
	{
		if (int_67 >= -1)
		{
			if (!bool_7)
			{
				GClass88 gClass = new GClass88("");
				gClass.method_0(new GClass87(mResources.CHAR_ORDER[0], this, 9999, (GClass114)gclass88_8.method_3(int_67)));
				GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_46((GClass114)gclass88_8.method_3(int_67));
			}
			else
				GClass7.smethod_0().method_128(string_0, (sbyte)int_67);
		}
	}

	private void method_159()
	{
		method_190();
	}

	private void method_160()
	{
		if (int_29 == 0 && Equals(GClass73.gclass76_0))
		{
			method_165();
			return;
		}
		if ((int_29 == 0 && Equals(GClass73.gclass76_1)) || int_29 == 2)
		{
			if (!Equals(GClass73.gclass76_1))
				gclass128_0 = (GClass128)GClass73.gclass76_0.gclass88_7.method_3(int_67);
			else
				gclass128_0 = (GClass128)GClass73.gclass76_1.gclass88_7.method_3(int_67);
			GClass50.smethod_11("toi day select= " + int_67);
			GClass88 gClass = new GClass88();
			gClass.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass128_0));
			if (gclass128_0 != null)
			{
				GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_42(gclass128_0);
			}
			else
				gclass96_0 = null;
		}
		if (int_29 == 1)
		{
			if (int_67 == int_41 - 3)
			{
				if (bool_1)
					return;
				method_174();
			}
			else if (int_67 != int_41 - 2)
			{
				if (int_67 != int_41 - 1)
				{
					if (bool_1)
						return;
					gclass128_0 = (GClass128)GClass73.gclass76_0.gclass88_6.method_3(int_67);
					GClass88 gClass2 = new GClass88();
					gClass2.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass128_0));
					if (gclass128_0 != null)
					{
						GClass73.gclass145_0.method_1(gClass2, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_42(gclass128_0);
					}
					else
						gclass96_0 = null;
				}
				else if (bool_1 && !bool_3 && bool_2)
				{
					GClass73.smethod_36(mResources.do_u_sure_to_trade, new GClass87(mResources.YES, this, 7002, null), new GClass87(mResources.NO, this, 4005, null));
				}
			}
			else if (bool_3)
			{
				bool_3 = false;
			}
			else
			{
				bool_1 = !bool_1;
				if (bool_1)
					GClass7.smethod_0().method_6(5, -1, -1, -1);
				else
				{
					method_151();
					GClass130.smethod_1();
					GClass7.smethod_0().method_6(3, -1, -1, -1);
				}
			}
		}
		if (GClass73.bool_5)
			int_67 = -1;
	}

	private void method_161()
	{
		if (int_29 == 0)
		{
			if (int_67 == -1 || gclass88_0.method_2() == 0)
				return;
			if (int_67 == gclass88_0.method_2())
			{
				int_103 = -1;
				int_67 = (GClass73.bool_5 ? (-1) : 0);
				GClass130.smethod_1();
				GClass7.smethod_0().method_5(1, gclass88_0);
				return;
			}
			if (int_67 > gclass88_0.method_2() - 1)
				return;
			gclass128_0 = (GClass128)GClass73.gclass76_0.gclass88_0.method_3(int_67);
			if (Main.isRightClick)
			{
				gclass128_0.bool_0 = false;
				GClass73.gclass76_0.gclass88_0.method_8(gclass128_0);
				if (GClass73.gclass76_0.int_29 == 0)
					GClass73.gclass76_0.method_36();
				Main.isRightClick = false;
				return;
			}
			GClass88 gClass = new GClass88();
			gClass.method_0(new GClass87(mResources.GETOUT, this, 6001, gclass128_0));
			if (gclass128_0 == null)
				gclass96_0 = null;
			else
			{
				GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_42(gclass128_0);
			}
		}
		if (int_29 == 1)
			method_165();
	}

	private void method_162()
	{
		if (int_67 != -1)
		{
			bool_18 = true;
			method_151();
		}
	}

	private void method_163()
	{
		gclass128_0 = null;
		if (int_67 < 0)
			return;
		GClass88 gClass = new GClass88();
		if (int_29 >= string_2.Length - ((GClass73.gclass76_1 == null) ? 1 : 0) || int_28 == 17)
		{
			if (int_57 == 0)
			{
				GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
				_ = GClass78.smethod_1().gclass128_0;
				if (int_67 >= gclass128_.Length)
				{
					sbyte b = (sbyte)(int_67 - gclass128_.Length);
					GClass128 gClass2 = GClass78.smethod_1().gclass128_0[b];
					if (gClass2 != null)
						gclass128_0 = gClass2;
				}
				else
				{
					GClass128 gClass3 = GClass78.smethod_1().gclass128_2[int_67];
					if (gClass3 != null)
						gclass128_0 = gClass3;
				}
				if (gclass128_0 != null)
					gClass.method_0(new GClass87(mResources.SALE, this, 3002, gclass128_0));
			}
			else
			{
				if (int_28 == 17)
					gclass128_0 = GClass78.smethod_1().gclass128_3[4][int_67];
				else
					gclass128_0 = GClass78.smethod_1().gclass128_3[int_29][int_67];
				if (gclass128_0.sbyte_32 != 0)
				{
					if (gclass128_0.sbyte_32 == 1)
					{
						gClass.method_0(new GClass87(mResources.huykigui, this, 10014, gclass128_0));
						gClass.method_0(new GClass87(mResources.upTop, this, 10018, gclass128_0));
					}
					else if (gclass128_0.sbyte_32 == 2)
					{
						gClass.method_0(new GClass87(mResources.nhantien, this, 10015, gclass128_0));
					}
				}
				else if (!gclass128_0.method_11(87))
				{
					gClass.method_0(new GClass87(mResources.kiguiXu, this, 10012, gclass128_0));
				}
				else
				{
					gClass.method_0(new GClass87(mResources.kiguiLuong, this, 10013, gclass128_0));
				}
			}
		}
		else
		{
			gclass128_0 = GClass78.smethod_1().gclass128_3[int_29][int_67];
			if (gclass128_0 != null)
			{
				if (!gclass128_0.bool_3)
				{
					if (int_57 == 4)
					{
						gClass.method_0(new GClass87(mResources.receive_upper, this, 30001, gclass128_0));
						gClass.method_0(new GClass87(mResources.DELETE, this, 30002, gclass128_0));
						gClass.method_0(new GClass87(mResources.receive_all, this, 30003, gclass128_0));
						for (int i = 0; i < gclass128_0.gclass120_0.Length; i++)
						{
							if (gclass128_0.gclass120_0[i].gclass126_0.int_0 == 93)
								gClass.method_0(new GClass87((GClass151.int_0 == 0) ? ("Xóa hết theo HSD [" + gclass128_0.gclass120_0[i].method_0().Split(' ')[1] + "]") : ("Delete all by Expr [" + gclass128_0.gclass120_0[i].method_0().Split(' ')[1] + "]"), this, 3148, gclass128_0));
						}
					}
					else if (gclass128_0.int_34 == 0 && gclass128_0.int_36 == 0)
					{
						if ((ulong)gclass128_0.long_0 > 0uL)
							gClass.method_0(new GClass87(mResources.learn_with + "\n" + GClass50.smethod_31(gclass128_0.long_0) + " \n" + mResources.potential, this, 3004, gclass128_0));
						else
						{
							gClass.method_0(new GClass87(mResources.receive_upper + "\n" + mResources.free, this, 3000, gclass128_0));
							gClass.method_0(new GClass87("Mua Nhiều", GClass160.smethod_0(), 3, new GClass160.GClass161(gclass128_0.gclass117_0.short_0, -1, true, false)));
						}
					}
					else if (int_57 != 8)
					{
						if (int_57 == 2)
						{
							if (gclass128_0.int_34 != -1)
								gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_34) + "\n" + mResources.XU, this, 10016, gclass128_0));
							if (gclass128_0.int_36 != -1)
								gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_36) + "\n" + mResources.LUONG, this, 10017, gclass128_0));
						}
						else
						{
							if (gclass128_0.int_34 > 0)
							{
								gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_34) + "\n" + mResources.XU, this, 3000, gclass128_0));
								gClass.method_0(new GClass87("Mua Nhiều\n" + GClass50.smethod_32(gclass128_0.int_34) + " Vàng/1", GClass160.smethod_0(), 3, new GClass160.GClass161(gclass128_0.gclass117_0.short_0, -1, true, false)));
							}
							if (gclass128_0.int_36 > 0)
							{
								gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_36) + "\n" + mResources.LUONG, this, 3001, gclass128_0));
								gClass.method_0(new GClass87("Mua Nhiều\n" + GClass50.smethod_32(gclass128_0.int_36) + " Ngọc/1", GClass160.smethod_0(), 3, new GClass160.GClass161(gclass128_0.gclass117_0.short_0, -1, false, false)));
							}
						}
					}
					else
					{
						if (gclass128_0.int_34 > 0)
							gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_34) + "\n" + mResources.XU, this, 30001, gclass128_0));
						if (gclass128_0.int_36 > 0)
							gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_36) + "\n" + mResources.LUONG, this, 30002, gclass128_0));
					}
				}
				else if (gclass128_0.int_39 > 0)
				{
					gClass.method_0(new GClass87(mResources.buy_with + "\n" + GClass50.smethod_32(gclass128_0.int_39), this, 3005, gclass128_0));
				}
			}
		}
		if (gclass128_0 != null)
		{
			GClass78.smethod_1().method_137(gclass128_0.int_44, gclass128_0.int_45, gclass128_0.int_46, gclass128_0.int_47);
			GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
			method_42(gclass128_0);
		}
		else
			gclass96_0 = null;
	}

	private void method_164()
	{
		if (int_67 < 0 || !GClass78.smethod_1().gclass6_0[int_67].bool_0 || GClass78.smethod_1().gclass6_0[int_67].bool_1)
			return;
		if (GClass73.bool_5)
		{
			if (GClass73.int_0 > int_58 + int_60 - 40)
				GClass7.smethod_0().method_14(int_67);
		}
		else
			GClass7.smethod_0().method_14(int_67);
	}

	private void method_165()
	{
		GClass50.smethod_8("fire inventory");
		if (GClass78.smethod_1().int_11 != 14)
		{
			if (int_67 == -1)
				return;
			gclass128_0 = null;
			GClass88 gClass = new GClass88();
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
			if (int_67 >= gclass128_.Length)
			{
				sbyte b = (sbyte)(int_67 - gclass128_.Length);
				GClass128 gClass2 = GClass78.smethod_1().gclass128_0[b];
				if (gClass2 != null)
				{
					gclass128_0 = gClass2;
					if (Main.isRightClick)
					{
						if (GClass73.gclass76_0.int_28 == 13)
						{
							if (bool_1)
							{
								GClass73.smethod_30(mResources.unlock_item_to_trade);
								return;
							}
							int num = 0;
							while (true)
							{
								if (num < GClass73.gclass76_0.gclass88_6.method_2())
								{
									if (((GClass128)GClass73.gclass76_0.gclass88_6.method_3(num)).int_29 == gClass2.int_29)
										break;
									num++;
									continue;
								}
								if (gClass2.int_30 > 1)
								{
									method_175();
									return;
								}
								gClass2.bool_0 = true;
								GClass128 gClass3 = new GClass128();
								gClass3.gclass117_0 = gClass2.gclass117_0;
								gClass3.gclass120_0 = gClass2.gclass120_0;
								gClass3.int_29 = gClass2.int_29;
								GClass73.gclass76_0.gclass88_6.method_0(gClass3);
								GClass7.smethod_0().method_6(2, -1, (sbyte)gClass3.int_29, gClass3.int_30);
								return;
							}
							GClass73.smethod_30(mResources.already_has_item);
							return;
						}
						if (GClass73.gclass76_0.int_28 == 12)
							try
							{
								for (int i = 0; i < GClass73.gclass76_0.gclass88_0.method_2(); i++)
								{
									if (((GClass128)GClass73.gclass76_0.gclass88_0.method_3(i)).gclass117_0.short_0 == gClass2.gclass117_0.short_0)
									{
										GClass73.smethod_30(mResources.already_has_item);
										return;
									}
								}
								gClass2.bool_0 = true;
								GClass73.gclass76_0.gclass88_0.method_0(gClass2);
								if (GClass73.gclass76_0.int_29 == 0)
									GClass73.gclass76_0.method_36();
								return;
							}
							catch (Exception)
							{
								return;
							}
						if (gClass2.gclass117_0.sbyte_0 == 27 || gClass2.gclass117_0.sbyte_0 == 29 || gClass2.gclass117_0.sbyte_0 == 6)
						{
							GClass7.smethod_0().method_20(0, 1, -1, gClass2.gclass117_0.short_0);
							Main.isRightClick = false;
						}
						else
						{
							GClass7.smethod_0().method_30(4, b);
							Main.isRightClick = false;
						}
						return;
					}
					if (GClass73.gclass76_0.int_28 != 12)
					{
						if (GClass73.gclass76_0.int_28 == 13)
							gClass.method_0(new GClass87(mResources.use_for_trade, this, 7000, gclass128_0));
						else if (gClass2.method_13())
						{
							gClass.method_0(new GClass87(mResources.USE, this, 2000, gclass128_0));
							bool flag = gclass128_0.gclass117_0.sbyte_0 == 32;
							if (GClass78.smethod_1().bool_38 && !flag)
								gClass.method_0(new GClass87(mResources.MOVEFORPET, this, 2005, gclass128_0));
							if (int_56 != 1)
							{
								string text = "";
								if (gclass128_0.gclass120_0 != null)
								{
									for (int j = 0; j < gclass128_0.gclass120_0.Length; j++)
									{
										text = text + gclass128_0.gclass120_0[j].gclass126_0.int_0 + "-";
									}
								}
								string caption = ((!GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								})) ? ((GClass151.int_0 == 0) ? "Thêm vào\nSet 1\n[Sư phụ]" : "Add to\nSet 1\n[Master]") : ((GClass151.int_0 != 0) ? "Remove from\nSet 1\n[Master]" : "Xóa khỏi\nSet 1\n[Sư phụ]"));
								string caption2 = (GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) ? ((GClass151.int_0 != 0) ? "Remove from\nSet 2\n[Master]" : "Xóa khỏi\nSet 2\n[Sư phụ]") : ((GClass151.int_0 == 0) ? "Thêm vào\nSet 2\n[Sư phụ]" : "Add to\nSet 2\n[Master]"));
								string caption3 = ((!GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								})) ? ((GClass151.int_0 == 0) ? "Thêm vào\nSet 1\n[Đệ tử]" : "Add to\nSet 1\n[Disciple]") : ((GClass151.int_0 == 0) ? "Xóa khỏi\nSet 1\n[Đệ tử]" : "Remove from\nSet 1\n[Disciple]"));
								string caption4 = (GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) ? ((GClass151.int_0 != 0) ? "Remove from\nSet 2\n[Disciple]" : "Xóa khỏi\nSet 2\n[Đệ tử]") : ((GClass151.int_0 != 0) ? "Add to\nSet 2\n[Disciple]" : "Thêm vào\nSet 2\n[Đệ tử]"));
								bool flag2 = GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag3 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag4 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag5 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag6 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag7 = GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag8 = GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag9 = GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag10 = GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag11 = gclass128_0.gclass117_0.sbyte_0 == 4 || (gclass128_0.gclass117_0.sbyte_0 != 4 && GClass78.smethod_1().int_14 == gclass128_0.gclass117_0.sbyte_1 && gclass128_0.gclass117_0.sbyte_1 != 3) || gclass128_0.gclass117_0.sbyte_1 == 3;
								if ((flag2 || flag6) && !flag7 && flag11)
									gClass.method_0(new GClass87(caption, this, 3142, gclass128_0));
								if ((flag3 || flag6) && !flag8 && flag11)
									gClass.method_0(new GClass87(caption2, this, 3143, gclass128_0));
								if ((flag4 || flag6) && !flag9 && !flag)
									gClass.method_0(new GClass87(caption3, this, 3140, gclass128_0));
								if ((flag5 || flag6) && !flag10 && !flag)
									gClass.method_0(new GClass87(caption4, this, 3141, gclass128_0));
							}
						}
						else
						{
							gClass.method_0(new GClass87(mResources.USE, this, 2001, gclass128_0));
							if (int_56 != 1)
							{
								string text2 = "";
								if (gclass128_0.gclass120_0 != null)
								{
									for (int k = 0; k < gclass128_0.gclass120_0.Length; k++)
									{
										text2 = text2 + gclass128_0.gclass120_0[k].gclass126_0.int_0 + "-";
									}
								}
								string caption5 = ((!GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								})) ? ((GClass151.int_0 == 0) ? "Thêm vào\nSet 1\n[Sư phụ]" : "Add to\nSet 1\n[Master]") : ((GClass151.int_0 != 0) ? "Remove from\nSet 1\n[Master]" : "Xóa khỏi\nSet 1\n[Sư phụ]"));
								string caption6 = (GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) ? ((GClass151.int_0 == 0) ? "Xóa khỏi\nSet 2\n[Sư phụ]" : "Remove from\nSet 2\n[Master]") : ((GClass151.int_0 == 0) ? "Thêm vào\nSet 2\n[Sư phụ]" : "Add to\nSet 2\n[Master]"));
								if (GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}))
								{
									if (GClass151.int_0 == 0)
									{
										_ = "Xóa khỏi\nSet 1\n[Đệ tử]";
									}
									else
									{
										_ = "Remove from\nSet 1\n[Disciple]";
									}
								}
								else if (GClass151.int_0 == 0)
								{
									_ = "Thêm vào\nSet 1\n[Đệ tử]";
								}
								else
								{
									_ = "Add to\nSet 1\n[Disciple]";
								}
								if (GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}))
								{
									if (GClass151.int_0 == 0)
									{
										_ = "Xóa khỏi\nSet 2\n[Đệ tử]";
									}
									else
									{
										_ = "Remove from\nSet 2\n[Disciple]";
									}
								}
								else if (GClass151.int_0 == 0)
								{
									_ = "Thêm vào\nSet 2\n[Đệ tử]";
								}
								else
								{
									_ = "Add to\nSet 2\n[Disciple]";
								}
								bool flag12 = GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag13 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag14 = !GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_4.Contains(new GClass160.GStruct5
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								}) && !GClass160.smethod_0().list_5.Contains(new GClass160.GStruct8
								{
									int_0 = gclass128_0.gclass117_0.short_0,
									string_0 = text2,
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag15 = GClass160.smethod_0().list_2.Contains(new GClass160.GStruct6
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag16 = GClass160.smethod_0().list_3.Contains(new GClass160.GStruct9
								{
									int_1 = gclass128_0.gclass117_0.sbyte_0
								});
								bool flag17 = gclass128_0.gclass117_0.sbyte_0 == 4 || (gclass128_0.gclass117_0.sbyte_0 != 4 && GClass78.smethod_1().int_14 == gclass128_0.gclass117_0.sbyte_1 && gclass128_0.gclass117_0.sbyte_1 != 3) || gclass128_0.gclass117_0.sbyte_1 == 3;
								if (gClass2.gclass117_0.sbyte_0 == 29)
									gClass.method_0(new GClass87(GClass160.smethod_0().list_6.Contains(new GClass160.GStruct7
									{
										int_0 = gClass2.gclass117_0.short_1,
										string_0 = gClass2.gclass117_0.string_0
									}) ? ((mResources.language == 0) ? "Dừng\ntự động\nsử dụng" : "Stop auto\nuse item") : ((mResources.language == 0) ? "Tự động\nsử dụng" : "Auto\nuse item"), this, 3144, gclass128_0));
								if (gClass2.gclass117_0.sbyte_0 == 27 && gClass2.gclass117_0.short_0 != 521 && gClass2.gclass117_0.short_0 != 380 && gClass2.gclass117_0.short_0 != 921 && gClass2.gclass117_0.short_0 != 454 && gClass2.gclass117_0.short_0 != 193 && gClass2.gclass117_0.short_0 != 194)
								{
									if ((flag12 || flag14) && !flag15 && flag17)
										gClass.method_0(new GClass87(caption5, this, 3142, gclass128_0));
									if ((flag13 || flag14) && !flag16 && flag17)
										gClass.method_0(new GClass87(caption6, this, 3143, gclass128_0));
									bool flag18 = File.Exists($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini") && int.Parse(File.ReadAllText($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini")) == gclass128_0.gclass117_0.short_0;
									gClass.method_0(new GClass87((GClass151.int_0 == 0) ? (flag18 ? "Dừng tự dùng khi đăng nhập" : "Tự dùng khi đăng nhập") : (flag18 ? "Stop auto use after login" : "Auto use after login"), this, 3145, gclass128_0));
								}
								if (gClass2.gclass117_0.sbyte_0 == 27 && gClass2.int_30 > 1)
									gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Auto open" : "Tự động mở", this, 3146, gclass128_0));
							}
						}
					}
					else
						gClass.method_0(new GClass87(mResources.use_for_combine, this, 6000, gclass128_0));
				}
			}
			else
			{
				GClass128 gClass4 = GClass78.smethod_1().gclass128_2[int_67];
				if (gClass4 != null)
				{
					if (Main.isRightClick)
					{
						GClass7.smethod_0().method_30(5, (sbyte)int_67);
						Main.isRightClick = false;
						return;
					}
					gclass128_0 = gClass4;
					gClass.method_0(new GClass87(mResources.GETOUT, this, 2002, gclass128_0));
				}
			}
			if (gclass128_0 != null)
			{
				GClass78.smethod_1().method_137(gclass128_0.int_44, gclass128_0.int_45, gclass128_0.int_46, gclass128_0.int_47);
				if (GClass73.gclass76_0.int_28 != 12 && GClass73.gclass76_0.int_28 != 13)
				{
					if (int_56 == 0)
						gClass.method_0(new GClass87(mResources.MOVEOUT, this, 2003, gclass128_0));
					if (int_56 == 1)
						gClass.method_0(new GClass87(mResources.SALE, this, 3002, gclass128_0));
				}
				GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_42(gclass128_0);
			}
			else
				gclass96_0 = null;
		}
		else
			GClass73.smethod_30(mResources.can_not_do_when_die);
	}

	private void method_166()
	{
		method_151();
		if (GClass135.gclass88_0 != null && GClass135.gclass88_0.method_2() != 0)
		{
			GClass135.smethod_2().switchToMe();
			return;
		}
		GClass7.smethod_0().method_146(0, -1);
		GClass135.smethod_2().switchToMe();
	}

	private void method_167()
	{
		if (int_67 < 0)
			return;
		if (!GClass109.bool_0 || int_67 != string_6.Length - 1)
		{
			if (!GClass78.smethod_1().bool_38)
			{
				switch (int_67)
				{
				case 0:
					method_166();
					break;
				case 1:
					method_151();
					GClass7.smethod_0().method_60(54);
					break;
				case 2:
					GClass162.smethod_0().method_1(0);
					break;
				case 3:
					GClass7.smethod_0().method_131(0, -1);
					GClass130.smethod_1();
					break;
				case 4:
					if (GClass78.smethod_1().int_11 == 14)
					{
						GClass73.smethod_30(mResources.can_not_do_when_die);
						break;
					}
					GClass7.smethod_0().method_58();
					GClass73.gclass76_0.method_41();
					GClass73.gclass76_0.method_50();
					break;
				case 5:
					GClass73.smethod_29();
					if (GClass78.smethod_1().method_145() >= 5)
					{
						if (gclass91_0 == null)
						{
							gclass91_0 = new GClass91();
							gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
							gclass91_0.method_0();
							gclass91_0.ginterface4_0 = GClass73.gclass76_0;
						}
						gclass91_0.string_1 = mResources.world_channel_5_luong;
						gclass91_0.gclass191_0.string_7 = mResources.CHAT;
						gclass91_0.string_0 = "";
						gclass91_0.bool_0 = true;
						gclass91_0.gclass191_0.bool_0 = true;
						gclass91_0.gclass191_0.method_28(GClass191.int_11);
						if (Main.isWindowsPhone)
							gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
						if (Main.isPC)
						{
							if (GClass73.bool_5)
								gclass91_0.gclass191_0.method_0();
						}
						else
							gclass91_0.method_5(this, "");
					}
					else
						GClass73.smethod_30(mResources.not_enough_luong_world_channel);
					break;
				case 6:
					method_205();
					break;
				case 7:
					method_201();
					break;
				case 8:
					GClass73.gclass133_0.method_16();
					break;
				case 9:
					if (GClass73.gclass133_0.bool_12)
						GClass109.smethod_1().method_52();
					break;
				}
				return;
			}
			switch (int_67)
			{
			case 0:
				method_166();
				break;
			case 1:
				GClass7.smethod_0().method_60(54);
				break;
			case 2:
				GClass162.smethod_0().method_1(0);
				break;
			case 3:
				method_170();
				break;
			case 4:
				GClass7.smethod_0().method_131(0, -1);
				GClass130.smethod_1();
				break;
			case 5:
				if (GClass78.smethod_1().int_11 != 14)
				{
					GClass7.smethod_0().method_58();
					GClass73.gclass76_0.method_41();
					GClass73.gclass76_0.method_50();
				}
				else
					GClass73.smethod_30(mResources.can_not_do_when_die);
				break;
			case 6:
				GClass73.smethod_29();
				if (GClass78.smethod_1().method_145() >= 5)
				{
					if (gclass91_0 == null)
					{
						gclass91_0 = new GClass91();
						gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
						gclass91_0.method_0();
						gclass91_0.ginterface4_0 = GClass73.gclass76_0;
					}
					gclass91_0.string_1 = mResources.world_channel_5_luong;
					gclass91_0.gclass191_0.string_7 = mResources.CHAT;
					gclass91_0.string_0 = "";
					gclass91_0.bool_0 = true;
					gclass91_0.gclass191_0.bool_0 = true;
					gclass91_0.gclass191_0.method_28(GClass191.int_11);
					if (Main.isWindowsPhone)
						gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
					if (Main.isPC)
					{
						if (GClass73.bool_5)
							gclass91_0.gclass191_0.method_0();
					}
					else
						gclass91_0.method_5(this, "");
				}
				else
					GClass73.smethod_30(mResources.not_enough_luong_world_channel);
				break;
			case 7:
				method_205();
				break;
			case 8:
				method_201();
				break;
			case 9:
				GClass73.gclass133_0.method_16();
				break;
			case 10:
				if (GClass73.gclass133_0.bool_12)
					GClass109.smethod_1().method_52();
				break;
			}
		}
		else
			GClass7.smethod_0().method_148();
	}

	private void method_168()
	{
		string src = ((Class9)gclass88_12.method_3(int_149)).string_1;
		string_27 = GClass4.gclass4_16.method_15(src, int_60 - 40);
		int_41 = string_27.Length;
		int_4 = 16;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_28 = 24;
		method_5(0);
	}

	private void method_169()
	{
		int_41 = GClass162.smethod_0().string_0.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_28 = 23;
		method_5(0);
	}

	private void method_170()
	{
		GClass7.smethod_0().method_127();
		if (GClass73.int_10 <= 2 * int_55)
		{
			GClass73.gclass76_0.string_17[21] = mResources.petMainTab;
			GClass73.gclass76_0.method_39();
			GClass73.gclass76_0.method_50();
		}
		else
		{
			GClass73.gclass76_1 = new GClass76();
			GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
			GClass73.gclass76_1.method_15();
			GClass73.gclass76_1.method_50();
			GClass73.gclass76_0.method_39();
			GClass73.gclass76_0.method_50();
		}
		int_64 = 20;
	}

	private void method_171()
	{
		gclass91_0.string_1 = mResources.input_clan_name;
		gclass91_0.gclass191_0.string_7 = mResources.clan_name;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	private void method_172()
	{
		gclass91_0.gclass191_0.method_23("");
		gclass91_0.string_1 = mResources.chat_clan;
		gclass91_0.gclass191_0.string_7 = mResources.CHAT;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	public void method_173()
	{
		gclass91_0.string_1 = mResources.input_clan_name_to_create;
		gclass91_0.gclass191_0.string_7 = mResources.input_clan_name;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	public void method_174()
	{
		if (gclass91_0 == null)
		{
			gclass91_0 = new GClass91();
			gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
			gclass91_0.method_0();
			gclass91_0.ginterface4_0 = GClass73.gclass76_0;
		}
		gclass91_0.string_1 = mResources.input_money_to_trade;
		gclass91_0.gclass191_0.string_7 = mResources.input_money;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_12);
		gclass91_0.gclass191_0.method_26(9);
		if (GClass73.bool_5)
			gclass91_0.gclass191_0.method_0();
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	public void method_175()
	{
		if (gclass91_0 == null)
		{
			gclass91_0 = new GClass91();
			gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
			gclass91_0.method_0();
			gclass91_0.ginterface4_0 = GClass73.gclass76_0;
		}
		gclass91_0.string_1 = mResources.input_quantity_to_trade;
		gclass91_0.gclass191_0.string_7 = mResources.input_quantity;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_12);
		if (GClass73.bool_5)
			gclass91_0.gclass191_0.method_0();
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	public void method_176()
	{
		gclass91_0.string_1 = mResources.input_clan_slogan;
		gclass91_0.gclass191_0.string_7 = mResources.input_clan_slogan;
		gclass91_0.string_0 = "";
		gclass91_0.bool_0 = true;
		gclass91_0.gclass191_0.bool_0 = true;
		gclass91_0.gclass191_0.method_28(GClass191.int_11);
		if (Main.isWindowsPhone)
			gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
		if (!Main.isPC)
			gclass91_0.method_5(this, "");
	}

	public void method_177()
	{
		if (gclass84_0 == null)
			gclass84_0 = new GClass84();
		gclass84_0.string_0 = gclass91_0.gclass191_0.method_21();
		gclass84_0.method_1(false);
		gclass91_0.bool_0 = false;
	}

	private void method_178(GClass16 gclass16_0)
	{
		string text = string.Concat("|0|1|" + gclass16_0.gclass78_0.string_3, "\n");
		string text2 = ((!gclass16_0.bool_1) ? (text + "|3|1|" + mResources.is_offline) : (text + "|4|1|" + mResources.is_online)) + "\n--";
		text = text2 + "\n|5|" + mResources.power + ": " + gclass16_0.string_0;
		gclass96_0 = new GClass96();
		method_43(gclass96_0, text);
		gclass78_1 = gclass16_0.gclass78_0;
		gclass128_0 = null;
	}

	private void method_179()
	{
		if (int_67 >= 0 && gclass88_9.method_2() != 0)
		{
			GClass88 gClass = new GClass88();
			int_150 = int_67;
			gClass.method_0(new GClass87(mResources.REVENGE, this, 10000, (GClass16)gclass88_9.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.DELETE, this, 10001, (GClass16)gclass88_9.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.den, this, 8004, (GClass16)gclass88_9.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.make_friend, this, 8003, (GClass16)gclass88_9.method_3(int_150)));
			GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
			method_178((GClass16)gclass88_9.method_3(int_67));
		}
	}

	private void method_180()
	{
		if (int_67 < 0 || gclass88_5.method_2() == 0)
			return;
		GClass88 gClass = new GClass88();
		int_150 = int_67;
		if (Main.isRightClick)
		{
			if (((GClass16)gclass88_5.method_3(int_150)).bool_1)
			{
				GClass159.smethod_0().method_24(((GClass16)gclass88_5.method_3(int_150)).gclass78_0.int_13);
				Main.isRightClick = false;
			}
		}
		else
		{
			gClass.method_0(new GClass87(mResources.CHAT, this, 8001, (GClass16)gclass88_5.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.DELETE, this, 8002, (GClass16)gclass88_5.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.den, this, 8004, (GClass16)gclass88_5.method_3(int_150)));
			gClass.method_0(new GClass87("Thêm vào đối tượng dịch chuyển", this, 8008, (GClass16)gclass88_5.method_3(int_150)));
			GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
			method_178((GClass16)gclass88_5.method_3(int_67));
		}
	}

	private void method_181()
	{
		if (int_67 >= 0)
		{
			GClass88 gClass = new GClass88();
			int_150 = int_67;
			gClass.method_0(new GClass87(mResources.change_flag, this, 10030, null));
			gClass.method_0(new GClass87(mResources.BACK, this, 10031, null));
			GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
		}
	}

	private void method_182()
	{
		if (int_67 == 0)
		{
			bool_22 = !bool_22;
			GClass1.smethod_9("viewchat", bool_22 ? 1 : 0);
			if (GClass73.bool_5)
				int_67 = -1;
		}
		else if (int_67 >= 0 && gclass88_3.method_2() != 0)
		{
			GClass88 gClass = new GClass88();
			int_150 = int_67 - 1;
			gClass.method_0(new GClass87(mResources.CHAT, this, 8001, (GClass16)gclass88_3.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.make_friend, this, 8003, (GClass16)gclass88_3.method_3(int_150)));
			gClass.method_0(new GClass87(mResources.den, this, 8004, (GClass16)gclass88_3.method_3(int_150)));
			GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
			method_186((GClass16)gclass88_3.method_3(int_67 - 1));
		}
	}

	private void method_183()
	{
		try
		{
			int_63 = null;
			gclass78_1 = null;
			GClass50.smethod_8("cSelect= " + int_68);
			if (int_67 >= 0)
			{
				if (GClass78.smethod_1().gclass106_0 != null)
				{
					if (int_67 == 0)
					{
						if (!bool_11)
						{
							if (bool_12)
							{
								if (int_68 == 0)
								{
									bool_10 = false;
									bool_12 = false;
									bool_11 = true;
									int_41 = GClass189.gclass88_0.method_2() + 2;
									method_78();
								}
								if (int_68 == 1)
								{
									if (gclass88_2.method_2() <= 1)
										method_176();
									else
										GClass7.smethod_0().method_26();
								}
								if (int_68 == 2)
								{
									if (gclass88_2.method_2() <= 1)
										GClass7.smethod_0().method_28(3, -1, null);
									else
										method_176();
								}
								if (int_68 == 3)
									GClass7.smethod_0().method_28(3, -1, null);
							}
						}
						else
						{
							if (int_68 == 0)
							{
								if (gclass88_2.method_2() > 1)
									method_172();
								else
								{
									gclass88_1 = null;
									bool_10 = false;
									bool_12 = true;
									bool_11 = false;
									int_41 = gclass88_2.method_2() + 2;
									method_78();
								}
							}
							if (int_68 == 1)
								GClass7.smethod_0().method_19(1, null, -1);
							if (int_68 == 2)
							{
								gclass88_1 = null;
								bool_10 = false;
								bool_12 = true;
								bool_11 = false;
								int_41 = gclass88_2.method_2() + 2;
								method_78();
								method_67();
							}
						}
					}
					else if (int_67 != 1)
					{
						if (!bool_10)
						{
							if (bool_12)
							{
								GClass50.smethod_8("TOI DAY 1");
								gclass38_0 = method_109();
								if (gclass38_0 != null)
								{
									GClass88 gClass = new GClass88();
									GClass50.smethod_8("TOI DAY 2");
									if (gclass88_1 != null)
									{
										gClass.method_0(new GClass87(mResources.CLOSE, this, 8000, null));
										GClass50.smethod_8("TOI DAY 3");
									}
									else if (gclass88_2 != null)
									{
										GClass50.smethod_8("TOI DAY 4");
										GClass50.smethod_8("my role= " + GClass78.smethod_1().sbyte_17);
										if (GClass78.smethod_1().int_13 == gclass38_0.int_0 || GClass78.smethod_1().sbyte_17 == 2)
											gClass.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass38_0));
										if (GClass78.smethod_1().sbyte_17 < 2 && GClass78.smethod_1().int_13 != gclass38_0.int_0)
										{
											GClass50.smethod_8("TOI DAY");
											if (gclass38_0.sbyte_0 == 0 || gclass38_0.sbyte_0 == 1)
												gClass.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass38_0));
											if (gclass38_0.sbyte_0 == 2)
												gClass.method_0(new GClass87(mResources.create_clan_co_leader, this, 5002, gclass38_0));
											if (GClass78.smethod_1().sbyte_17 == 0)
											{
												gClass.method_0(new GClass87(mResources.create_clan_leader, this, 5001, gclass38_0));
												if (gclass38_0.sbyte_0 == 1)
													gClass.method_0(new GClass87(mResources.disable_clan_mastership, this, 5003, gclass38_0));
											}
										}
										if (GClass78.smethod_1().sbyte_17 < gclass38_0.sbyte_0)
											gClass.method_0(new GClass87(mResources.kick_clan_mem, this, 5004, gclass38_0));
										if (GClass78.smethod_1().int_13 != gclass38_0.int_0)
										{
											gClass.method_0(new GClass87(mResources.den, this, 8005, gclass38_0));
											gClass.method_0(new GClass87((!GClass168.smethod_0().list_0.Contains(gclass38_0.string_0)) ? ((GClass151.int_0 == 0) ? "Thêm vào\ndanh sách\nnhận đậu" : "Add to\nlist receive\nbean") : ((GClass151.int_0 != 0) ? "Remove from\nlist receive\nbean" : "Xóa khỏi\ndanh sách\nnhận đậu"), this, 8006, gclass38_0));
											gClass.method_0(new GClass87(mResources.make_friend, this, 8007, gclass38_0));
										}
									}
									GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
									method_47(gclass38_0);
								}
							}
							else if (bool_11)
							{
								gclass189_0 = method_110();
								if (gclass189_0 != null)
								{
									if (gclass189_0.int_1 == 0)
									{
										GClass88 gClass2 = new GClass88();
										gClass2.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass189_0));
										GClass73.gclass145_0.method_1(gClass2, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
										method_45(gclass189_0);
									}
									else if (gclass189_0.int_1 == 1)
									{
										if (gclass189_0.int_2 != GClass78.smethod_1().int_13 && int_68 != -1)
											GClass7.smethod_0().method_18(gclass189_0.int_0);
									}
									else if (gclass189_0.int_1 == 2 && gclass189_0.string_2 != null)
									{
										if (int_68 == 0)
											GClass7.smethod_0().method_21(gclass189_0.int_0, 1);
										else if (int_68 == 1)
										{
											GClass7.smethod_0().method_21(gclass189_0.int_0, 0);
										}
									}
								}
							}
						}
						else
						{
							gclass106_0 = method_111();
							if (gclass106_0 != null)
							{
								GClass88 gClass3 = new GClass88();
								gClass3.method_0(new GClass87(mResources.view_clan_member, this, 4001, gclass106_0));
								GClass73.gclass145_0.method_1(gClass3, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
								method_48(method_111());
							}
						}
					}
					else if (bool_10)
					{
						GClass7.smethod_0().method_23("");
					}
				}
				else if (int_67 != 0)
				{
					if (int_67 != -1)
					{
						if (int_67 != 1)
						{
							if (!bool_10)
							{
								if (bool_12)
								{
									gclass38_0 = method_109();
									if (gclass38_0 != null)
									{
										GClass88 gClass4 = new GClass88();
										gClass4.method_0(new GClass87(mResources.CLOSE, this, 8000, gclass106_0));
										GClass73.gclass145_0.method_1(gClass4, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
										GClass73.gclass145_0.method_1(gClass4, 0, (int_67 + 1) * int_4 - int_8 + int_59);
										method_47(gclass38_0);
									}
								}
							}
							else
							{
								gclass106_0 = method_111();
								if (gclass106_0 != null)
								{
									GClass88 gClass5 = new GClass88();
									gClass5.method_0(new GClass87(mResources.request_join_clan, this, 4000, gclass106_0));
									gClass5.method_0(new GClass87(mResources.view_clan_member, this, 4001, gclass106_0));
									GClass73.gclass145_0.method_1(gClass5, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
									method_48(method_111());
								}
							}
						}
						else if (bool_10)
						{
							GClass7.smethod_0().method_23("");
						}
						else if (bool_12 && gclass106_0 != null)
						{
							GClass73.smethod_36(mResources.do_u_want_join_clan + gclass106_0.string_0, new GClass87(mResources.YES, this, 4000, gclass106_0), new GClass87(mResources.NO, this, 4005, gclass106_0));
						}
					}
				}
				else if (int_68 != 0)
				{
					if (int_68 == 1)
					{
						GClass130.smethod_1();
						method_173();
						GClass7.smethod_0().method_28(1, -1, null);
					}
				}
				else
				{
					method_171();
				}
				if (GClass73.bool_5)
				{
					int_68 = -1;
					int_67 = -1;
				}
			}
			else
				int_68 = -1;
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void method_184()
	{
		try
		{
			if (int_29 == 0)
				method_8();
			if (int_29 == 1)
				method_165();
			if (int_29 == 2)
				method_185();
			if (int_29 == 3)
			{
				if (string_3.Length != 4)
					method_183();
				else
					method_167();
			}
			if (int_29 == 4)
				method_167();
		}
		catch (Exception ex)
		{
			GClass50.smethod_8("Throw ex " + ex.StackTrace);
		}
	}

	private void method_185()
	{
		if (int_67 < 0)
			return;
		if (GClass78.smethod_1().int_11 != 14)
		{
			if (int_67 == 0 || int_67 == 1 || int_67 == 2 || int_67 == 3 || int_67 == 4 || int_67 == 5)
			{
				long long_ = GClass78.smethod_1().long_4;
				int num = GClass78.smethod_1().int_155;
				int num2 = GClass78.smethod_1().int_156;
				int num3 = GClass78.smethod_1().int_154;
				int num4 = GClass78.smethod_1().int_157;
				_ = GClass78.smethod_1().int_158;
				int num5 = 1000;
				if (int_67 == 0)
				{
					if (long_ < GClass78.smethod_1().int_155 + num5)
					{
						GClass73.smethod_32(mResources.not_enough_potential_point1 + GClass78.smethod_1().long_4 + mResources.not_enough_potential_point2 + (GClass78.smethod_1().int_155 + num5), false);
						return;
					}
					if (long_ > num && long_ < 10 * (2 * (num + num5) + 180) / 2)
					{
						GClass73.smethod_36(mResources.use_potential_point_for1 + (num + num5) + mResources.use_potential_point_for2 + GClass78.smethod_1().sbyte_30 + mResources.for_HP, new GClass87(mResources.increase_upper, this, 9000, null), new GClass87(mResources.CANCEL, this, 4007, null));
						return;
					}
					if (long_ >= 10 * (2 * (num + num5) + 180) / 2 && long_ < 100 * (2 * (num + num5) + 1980) / 2)
					{
						GClass88 gClass = new GClass88("");
						gClass.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass50.smethod_32(num + num5), this, 9000, null));
						gClass.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass50.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
						GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
					if (long_ >= 100 * (2 * (num + num5) + 1980) / 2)
					{
						GClass88 gClass2 = new GClass88("");
						gClass2.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass50.smethod_32(num + num5), this, 9000, null));
						gClass2.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass50.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
						gClass2.method_0(new GClass87(mResources.increase_upper + "\n" + 100 * GClass78.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass50.smethod_32(100 * (2 * (num + num5) + 1980) / 2), this, 9007, null));
						GClass73.gclass145_0.method_1(gClass2, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
				}
				if (int_67 == 1)
				{
					if (GClass78.smethod_1().long_4 < GClass78.smethod_1().int_156 + num5)
					{
						GClass73.smethod_30(mResources.not_enough_potential_point1 + GClass78.smethod_1().long_4 + mResources.not_enough_potential_point2 + (GClass78.smethod_1().int_156 + num5));
						return;
					}
					if (long_ > num2 && long_ < 10 * (2 * (num2 + num5) + 180) / 2)
					{
						GClass73.smethod_36(mResources.use_potential_point_for1 + (num2 + num5) + mResources.use_potential_point_for2 + GClass78.smethod_1().sbyte_31 + mResources.for_KI, new GClass87(mResources.increase_upper, this, 9000, null), new GClass87(mResources.CANCEL, this, 4007, null));
						return;
					}
					if (long_ >= 10 * (2 * (num2 + num5) + 180) / 2 && long_ < 100 * (2 * (num2 + num5) + 1980) / 2)
					{
						GClass88 gClass3 = new GClass88("");
						gClass3.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass50.smethod_32(num + num5), this, 9000, null));
						gClass3.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass50.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
						GClass73.gclass145_0.method_1(gClass3, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
					if (long_ >= 100 * (2 * (num2 + num5) + 1980) / 2)
					{
						GClass88 gClass4 = new GClass88("");
						gClass4.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass50.smethod_32(num2 + num5), this, 9000, null));
						gClass4.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass50.smethod_32(10 * (2 * (num2 + num5) + 180) / 2), this, 9006, null));
						gClass4.method_0(new GClass87(mResources.increase_upper + "\n" + 100 * GClass78.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass50.smethod_32(100 * (2 * (num2 + num5) + 1980) / 2), this, 9007, null));
						GClass73.gclass145_0.method_1(gClass4, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
				}
				if (int_67 == 2)
				{
					if (GClass78.smethod_1().long_4 < GClass78.smethod_1().int_154 * GClass78.smethod_1().short_25)
					{
						GClass73.smethod_30(mResources.not_enough_potential_point1 + GClass78.smethod_1().long_4 + mResources.not_enough_potential_point2 + num3 * 100);
						return;
					}
					if (long_ > num3 && long_ < 10 * (2 * num3 + 9) / 2 * GClass78.smethod_1().short_25)
					{
						GClass73.smethod_36(mResources.use_potential_point_for1 + num3 * 100 + mResources.use_potential_point_for2 + GClass78.smethod_1().sbyte_32 + mResources.for_hit_point, new GClass87(mResources.increase_upper, this, 9000, null), new GClass87(mResources.CANCEL, this, 4007, null));
						return;
					}
					if (long_ >= 10 * (2 * num3 + 9) / 2 * GClass78.smethod_1().short_25 && long_ < 100 * (2 * num3 + 99) / 2 * GClass78.smethod_1().short_25)
					{
						GClass88 gClass5 = new GClass88("");
						gClass5.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass50.smethod_32(num3 * 100), this, 9000, null));
						gClass5.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass50.smethod_32(10 * (2 * num3 + 9) / 2 * GClass78.smethod_1().short_25), this, 9006, null));
						GClass73.gclass145_0.method_1(gClass5, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
					if (long_ >= 100 * (2 * num3 + 99) / 2 * GClass78.smethod_1().short_25)
					{
						GClass88 gClass6 = new GClass88("");
						gClass6.method_0(new GClass87(mResources.increase_upper + "\n" + GClass78.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass50.smethod_32(num3 * 100), this, 9000, null));
						gClass6.method_0(new GClass87(mResources.increase_upper + "\n" + 10 * GClass78.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass50.smethod_32(10 * (2 * num3 + 9) / 2 * GClass78.smethod_1().short_25), this, 9006, null));
						gClass6.method_0(new GClass87(mResources.increase_upper + "\n" + 100 * GClass78.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass50.smethod_32(100 * (2 * num3 + 99) / 2 * GClass78.smethod_1().short_25), this, 9007, null));
						GClass73.gclass145_0.method_1(gClass6, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
				}
				if (int_67 == 3)
				{
					if (GClass78.smethod_1().long_4 >= 50000 + GClass78.smethod_1().int_157 * 1000)
					{
						long number = 2 * (num4 + 5) / 2L * 100000L;
						long number2 = 10L * (2 * (num4 + 5) + 9) / 2L * 100000L;
						long number3 = 100L * (2 * (num4 + 5) + 99) / 2L * 100000L;
						mResources.use_potential_point_for1 = mResources.increase_upper;
						GClass88 gClass7 = new GClass88("");
						gClass7.method_0(new GClass87(mResources.use_potential_point_for1 + "\n1 " + mResources.armor + "\n" + GClass50.smethod_32(number), this, 9000, null));
						gClass7.method_0(new GClass87(mResources.use_potential_point_for1 + "\n10 " + mResources.armor + "\n" + GClass50.smethod_32(number2), this, 9006, null));
						gClass7.method_0(new GClass87(mResources.use_potential_point_for1 + "\n100 " + mResources.armor + "\n" + GClass50.smethod_32(number3), this, 9007, null));
						GClass73.gclass145_0.method_1(gClass7, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
						method_187(int_67);
					}
					else
						GClass73.smethod_30(mResources.not_enough_potential_point1 + GClass65.smethod_9(GClass78.smethod_1().long_4) + mResources.not_enough_potential_point2 + GClass65.smethod_9(50000 + GClass78.smethod_1().int_157 * 1000));
				}
				else if (int_67 == 4)
				{
					long num6 = 50000000L;
					int num7 = GClass78.smethod_1().int_158;
					if (num7 > long_0.Length - 1)
						num7 = long_0.Length - 1;
					num6 = long_0[num7];
					if (GClass78.smethod_1().long_4 >= num6)
						GClass73.smethod_36(mResources.use_potential_point_for1 + GClass50.smethod_31(num6) + mResources.use_potential_point_for2 + GClass78.smethod_1().sbyte_34 + mResources.for_crit, new GClass87(mResources.increase_upper, this, 9000, null), new GClass87(mResources.CANCEL, this, 4007, null));
					else
						GClass73.smethod_30(mResources.not_enough_potential_point1 + GClass50.smethod_32(GClass78.smethod_1().long_4) + mResources.not_enough_potential_point2 + GClass50.smethod_32(num6));
				}
				else if (int_67 == 5)
				{
					GClass7.smethod_0().method_8(0);
				}
			}
			else
			{
				int num8 = int_67 - 6;
				GClass47 gClass8 = GClass78.smethod_1().gclass176_0.gclass47_0[num8];
				GClass63 gClass9 = GClass78.smethod_1().method_16(gClass8);
				GClass63 gClass10 = null;
				GClass88 gClass11 = new GClass88("");
				if (gClass9 == null)
				{
					gClass10 = gClass8.gclass63_0[0];
					gClass11.method_0(new GClass87(mResources.learn, this, 9004, gClass10));
				}
				else if (gClass9.int_0 == gClass8.int_1)
				{
					gClass11.method_0(new GClass87(mResources.make_shortcut, this, 9003, gClass9.gclass47_0));
					gClass11.method_0(new GClass87(mResources.CLOSE, 2));
				}
				else
				{
					gClass10 = gClass8.gclass63_0[gClass9.int_0];
					gClass11.method_0(new GClass87(mResources.UPGRADE, this, 9002, gClass10));
					gClass11.method_0(new GClass87(mResources.make_shortcut, this, 9003, gClass9.gclass47_0));
				}
				GClass73.gclass145_0.method_1(gClass11, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
				method_49(gClass8, gClass9, gClass10);
			}
		}
		else
			GClass73.smethod_30(mResources.can_not_do_when_die);
	}

	private void method_186(GClass16 gclass16_0)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + gclass16_0.gclass78_0.string_3, "\n"), "\n--"), "\n|5|", GClass50.smethod_30(gclass16_0.string_0, "|", 0)[2]);
		gclass96_0 = new GClass96();
		method_43(gclass96_0, chat);
		gclass78_1 = gclass16_0.gclass78_0;
		gclass128_0 = null;
	}

	private void method_187(int int_182)
	{
		string empty = "";
		int num = 0;
		if (int_67 == 0)
			num = GClass78.smethod_1().int_155 + 1000;
		if (int_67 == 1)
			num = GClass78.smethod_1().int_156 + 1000;
		if (int_67 == 2)
			num = GClass78.smethod_1().int_154 * GClass78.smethod_1().short_25;
		if (int_67 == 3)
			num = 500000 + GClass78.smethod_1().int_157 * 100000;
		string text = empty;
		empty = text + "|5|2|" + mResources.USE + " " + num + " " + mResources.potential;
		if (int_182 == 0)
			empty = empty + "\n|5|2|" + mResources.to_gain_20hp;
		if (int_182 == 1)
			empty = empty + "\n|5|2|" + mResources.to_gain_20mp;
		if (int_182 == 2)
			empty = empty + "\n|5|2|" + mResources.to_gain_1pow;
		if (int_182 == 3)
			empty = empty + "\n|5|2|" + mResources.to_gain_1pow;
		gclass128_0 = null;
		int_63 = null;
		gclass78_1 = null;
		int_62 = -1;
		gclass96_0 = new GClass96();
		method_43(gclass96_0, empty);
	}

	private void method_188()
	{
	}

	private void method_189()
	{
		if (gclass70_2 != null)
		{
			gclass70_2.texture2D_0 = null;
			gclass70_2 = null;
		}
		GClass20.sbyte_3 = -1;
		GClass203.smethod_26();
		GClass28.smethod_0();
		method_40();
		int_14 = 0;
		int_15 = 0;
	}

	private void method_190()
	{
		if (int_67 != -1)
		{
			GClass50.smethod_8("FIRE ZONE");
			bool_23 = true;
			GClass73.gclass76_0.method_151();
		}
	}

	public void method_191(int recieve, int maxCap)
	{
		gclass96_0.string_0[gclass96_0.string_0.Length - 1] = mResources.received + " " + recieve + "/" + maxCap;
	}

	private void method_192()
	{
		if (int_67 < 0)
			return;
		gclass128_0 = null;
		GClass88 gClass = new GClass88();
		if (int_29 == 0 && !Equals(GClass73.gclass76_1))
		{
			GClass128 gClass2 = GClass78.smethod_1().gclass128_1[int_67];
			if (gClass2 != null)
			{
				if (!bool_8)
				{
					if (gClass2.method_13())
					{
						if (Main.isRightClick)
						{
							GClass7.smethod_0().method_30(sbyte_0, (sbyte)int_67);
							Main.isRightClick = false;
							return;
						}
						gClass.method_0(new GClass87(mResources.GETOUT, this, 1000, gClass2));
					}
					else
					{
						if (Main.isRightClick)
						{
							GClass7.smethod_0().method_30(sbyte_0, (sbyte)int_67);
							Main.isRightClick = false;
							return;
						}
						gClass.method_0(new GClass87(mResources.GETOUT, this, 1000, gClass2));
					}
				}
				else
				{
					gClass.method_0(new GClass87(mResources.GETOUT, this, 1000, gClass2));
					gClass.method_0(new GClass87(mResources.USE, this, 2010, gClass2));
				}
				gclass128_0 = gClass2;
			}
		}
		if (int_29 == 1 || Equals(GClass73.gclass76_1))
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
			if (int_67 >= gclass128_.Length)
			{
				sbyte b = (sbyte)(int_67 - gclass128_.Length);
				GClass128 gClass3 = GClass78.smethod_1().gclass128_0[b];
				if (gClass3 != null)
				{
					if (Main.isRightClick)
					{
						sbyte id = (sbyte)(int_67 - gclass128_.Length);
						GClass7.smethod_0().method_30(sbyte_1, id);
						Main.isRightClick = false;
						return;
					}
					gClass.method_0(new GClass87(mResources.move_to_chest, this, 1001, gClass3));
					if (gClass3.method_13())
						gClass.method_0(new GClass87(mResources.USE, this, 2000, gClass3));
					else
						gClass.method_0(new GClass87(mResources.USE, this, 2001, gClass3));
					gclass128_0 = gClass3;
				}
			}
			else
			{
				GClass128 gClass4 = GClass78.smethod_1().gclass128_2[int_67];
				if (gClass4 != null)
				{
					gClass.method_0(new GClass87(mResources.move_to_chest2, this, 1002, gClass4));
					gclass128_0 = gClass4;
				}
			}
		}
		if (gclass128_0 == null)
		{
			gclass96_0 = null;
			return;
		}
		GClass78.smethod_1().method_137(gclass128_0.int_44, gclass128_0.int_45, gclass128_0.int_46, gclass128_0.int_47);
		if (bool_8)
			gClass.method_0(new GClass87(mResources.MOVEOUT, this, 2011, gclass128_0));
		GClass73.gclass145_0.method_1(gClass, int_0, (int_67 + 1) * int_4 - int_8 + int_59);
		method_42(gclass128_0);
	}

	public void method_193(sbyte itemAction, string info, sbyte where, sbyte index)
	{
		GClass73.smethod_29();
		GClass75 gClass = new GClass75();
		gClass.int_2 = itemAction;
		gClass.int_0 = index;
		gClass.int_1 = where;
		GClass73.smethod_36(info, new GClass87(mResources.YES, this, 2004, gClass), new GClass87(mResources.NO, this, 4005, null));
	}

	public void method_194(sbyte type, string info, short id)
	{
		GClass75 gClass = new GClass75();
		gClass.int_2 = type;
		gClass.int_0 = id;
		GClass73.smethod_36(info, new GClass87(mResources.YES, this, 3003, gClass), new GClass87(mResources.NO, this, 4005, null));
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 9999)
		{
			GClass114 gClass = (GClass114)p;
			GClass7.smethod_0().method_141(gClass.int_2);
		}
		if (idAction == 170391)
		{
			GClass1.smethod_13();
			if (GClass122.int_12 <= 1)
				GClass1.smethod_9("levelScreenKN", 0);
			else
				GClass1.smethod_9("levelScreenKN", 1);
			GClass187.gclass187_0.method_1();
		}
		if (idAction == 6001)
		{
			GClass128 gClass2 = (GClass128)p;
			gClass2.bool_0 = false;
			GClass73.gclass76_0.gclass88_0.method_8(gClass2);
			if (GClass73.gclass76_0.int_29 == 0)
				GClass73.gclass76_0.method_36();
		}
		if (idAction == 6000)
		{
			GClass128 gClass3 = (GClass128)p;
			for (int i = 0; i < GClass73.gclass76_0.gclass88_0.method_2(); i++)
			{
				if (((GClass128)GClass73.gclass76_0.gclass88_0.method_3(i)).gclass117_0.short_0 == gClass3.gclass117_0.short_0)
				{
					GClass73.smethod_30(mResources.already_has_item);
					return;
				}
			}
			gClass3.bool_0 = true;
			GClass73.gclass76_0.gclass88_0.method_0(gClass3);
			if (GClass73.gclass76_0.int_29 == 0)
				GClass73.gclass76_0.method_36();
		}
		if (idAction == 7000)
		{
			if (bool_1)
			{
				GClass73.smethod_30(mResources.unlock_item_to_trade);
				return;
			}
			GClass128 gClass4 = (GClass128)p;
			for (int j = 0; j < GClass73.gclass76_0.gclass88_6.method_2(); j++)
			{
				if (((GClass128)GClass73.gclass76_0.gclass88_6.method_3(j)).int_29 == gClass4.int_29)
				{
					GClass73.smethod_30(mResources.already_has_item);
					return;
				}
			}
			if (gClass4.int_30 > 1)
			{
				method_175();
				return;
			}
			gClass4.bool_0 = true;
			GClass128 gClass5 = new GClass128();
			gClass5.gclass117_0 = gClass4.gclass117_0;
			gClass5.gclass120_0 = gClass4.gclass120_0;
			gClass5.int_29 = gClass4.int_29;
			GClass73.gclass76_0.gclass88_6.method_0(gClass5);
			GClass7.smethod_0().method_6(2, -1, (sbyte)gClass5.int_29, gClass5.int_30);
		}
		if (idAction == 7001)
		{
			GClass128 gClass6 = (GClass128)p;
			gClass6.bool_0 = false;
			GClass73.gclass76_0.gclass88_6.method_8(gClass6);
			if (GClass73.gclass76_0.int_29 == 1)
				GClass73.gclass76_0.method_61(true);
			GClass7.smethod_0().method_6(4, -1, (sbyte)gClass6.int_29, -1);
		}
		if (idAction == 7002)
		{
			bool_3 = true;
			GClass73.smethod_29();
			GClass7.smethod_0().method_6(7, -1, -1, -1);
			method_151();
		}
		if (idAction == 8003)
		{
			GClass16 gClass7 = (GClass16)p;
			GClass7.smethod_0().method_13(1, gClass7.gclass78_0.int_13);
			if (int_28 != 8)
				;
		}
		if (idAction == 8002)
		{
			GClass16 gClass8 = (GClass16)p;
			GClass7.smethod_0().method_13(2, gClass8.gclass78_0.int_13);
		}
		if (idAction == 8004)
		{
			GClass16 gClass9 = (GClass16)p;
			GClass159.smethod_0().method_24(gClass9.gclass78_0.int_13);
		}
		if (idAction == 8005)
		{
			GClass38 gClass10 = (GClass38)p;
			GClass159.smethod_0().method_24(gClass10.int_0);
		}
		if (idAction == 8006)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass38 gClass11 = (GClass38)p;
			if (!GClass168.smethod_0().list_0.Contains(gClass11.string_0))
			{
				GClass168.smethod_0().list_0.Add(gClass11.string_0);
				GClass149.smethod_1("Đã thêm [" + gClass11.string_0 + "] vào danh sách nhận đậu", 0);
			}
			else
			{
				GClass168.smethod_0().list_0.Remove(gClass11.string_0);
				GClass149.smethod_1("Đã xóa [" + gClass11.string_0 + "] khỏi danh sách nhận đậu", 0);
			}
		}
		if (idAction == 8007)
		{
			GClass38 gClass12 = (GClass38)p;
			GClass7.smethod_0().method_13(1, gClass12.int_0);
			if (int_28 == 8)
				;
		}
		if (idAction == 8008)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass16 gClass13 = (GClass16)p;
			GClass159.smethod_0().bool_4 = !GClass159.smethod_0().bool_4;
			GClass159.smethod_0().int_4 = gClass13.gclass78_0.int_13;
			GClass149.smethod_1("Tự động dịch chuyển tới [" + gClass13.gclass78_0.string_3 + "]: " + GClass154.smethod_0().method_6(GClass159.smethod_0().bool_4), 0);
		}
		if (idAction == 3142)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().method_16(gclass128_0, 1, "suphu");
		}
		if (idAction == 3148)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass155.smethod_0().int_4 = 2;
			GClass155.smethod_0().int_5 = gclass128_0.gclass117_0.short_0;
			for (int k = 0; k < gclass128_0.gclass120_0.Length; k++)
			{
				if (gclass128_0.gclass120_0[k].gclass126_0.int_0 == 93)
					GClass155.smethod_0().int_6 = int.Parse(gclass128_0.gclass120_0[k].method_0().Split(' ')[1]);
			}
			GClass155.smethod_0().bool_0 = false;
		}
		if (idAction == 3143)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().method_16(gclass128_0, 2, "suphu");
		}
		if (idAction == 3140)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().method_16(gclass128_0, 1, "detu");
		}
		if (idAction == 3141)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().method_16(gclass128_0, 2, "detu");
		}
		if (idAction == 3144)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().method_18(gclass128_0);
		}
		if (idAction == 3145)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			if (!File.Exists($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini") || (File.Exists($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini") && int.Parse(File.ReadAllText($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini")) != gclass128_0.gclass117_0.short_0))
				GClass160.smethod_0().method_26(gclass128_0);
			else
				File.Delete($"Data/GameData/PetData/{GClass78.smethod_1().int_13}.ini");
		}
		if (idAction == 3146)
		{
			if (GClass148.smethod_0().bool_0)
				return;
			GClass160.smethod_0().bool_10 = !GClass160.smethod_0().bool_10;
			GClass160.smethod_0().int_5 = gclass128_0.gclass117_0.short_0;
			GClass159.smethod_0().method_1((GClass151.int_0 != 0) ? "Put time delay use item (ms)" : "Nhập độ trễ sử dụng item (ms)");
		}
		if (idAction == 8001)
		{
			GClass50.smethod_8("chat player");
			GClass16 gClass14 = (GClass16)p;
			if (gclass91_0 == null)
			{
				gclass91_0 = new GClass91();
				gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
				gclass91_0.method_0();
				gclass91_0.ginterface4_0 = GClass73.gclass76_0;
			}
			gclass91_0.string_1 = mResources.chat_player;
			gclass91_0.gclass191_0.string_7 = mResources.chat_with + " " + gClass14.gclass78_0.string_3;
			gclass91_0.string_0 = "";
			gclass91_0.bool_0 = true;
			gclass91_0.gclass191_0.bool_0 = true;
			gclass91_0.gclass191_0.method_28(GClass191.int_11);
			if (Main.isWindowsPhone)
				gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
			if (!Main.isPC)
				gclass91_0.method_5(this, "");
		}
		if (idAction == 1000)
			GClass7.smethod_0().method_30(sbyte_0, (sbyte)int_67);
		if (idAction == 1001)
		{
			GClass128[] gclass128_ = GClass78.smethod_1().gclass128_2;
			sbyte id = (sbyte)(int_67 - gclass128_.Length);
			GClass7.smethod_0().method_30(sbyte_1, id);
		}
		if (idAction == 1003)
			method_151();
		if (idAction == 1002)
			GClass7.smethod_0().method_30(sbyte_3, (sbyte)int_67);
		if (idAction == 2011)
			GClass7.smethod_0().method_20(1, 2, (sbyte)int_67, -1);
		if (idAction == 2010)
		{
			GClass7.smethod_0().method_20(0, 2, (sbyte)int_67, -1);
			GClass128 gClass15 = (GClass128)p;
			if (gClass15 != null && (gClass15.gclass117_0.short_0 == 193 || gClass15.gclass117_0.short_0 == 194))
				GClass73.gclass76_0.method_151();
		}
		if (idAction == 2000)
		{
			GClass128[] gclass128_2 = GClass78.smethod_1().gclass128_2;
			sbyte id2 = (sbyte)(int_67 - gclass128_2.Length);
			GClass7.smethod_0().method_30(sbyte_4, id2);
		}
		if (idAction == 2001)
		{
			GClass50.smethod_8("use item");
			GClass128 gClass16 = (GClass128)p;
			bool flag = int_67 < GClass78.smethod_1().gclass128_2.Length;
			sbyte b = 0;
			if (!flag)
				b = (sbyte)(int_67 - GClass78.smethod_1().gclass128_2.Length);
			GClass7.smethod_0().method_20(0, (!flag) ? ((sbyte)1) : ((sbyte)0), (sbyte)(flag ? int_67 : b), -1);
			if (gClass16.gclass117_0.short_0 == 193 || gClass16.gclass117_0.short_0 == 194)
				GClass73.gclass76_0.method_151();
		}
		if (idAction == 2002)
		{
			GClass7.smethod_0().method_30(sbyte_5, (sbyte)int_67);
			if (int_67 == 5)
			{
				string text = "";
				if (GClass78.smethod_1().gclass128_2[5].gclass120_0 != null)
				{
					for (int l = 0; l < GClass78.smethod_1().gclass128_2[5].gclass120_0.Length; l++)
					{
						text = text + GClass78.smethod_1().gclass128_2[5].gclass120_0[l].gclass126_0.int_0 + "-";
					}
				}
				foreach (GClass160.GStruct11 item in GClass160.smethod_0().list_1)
				{
					if (item.int_0 == GClass78.smethod_1().gclass128_2[5].gclass117_0.short_0 && item.string_0 == text && item.int_1 == GClass78.smethod_1().gclass128_2[5].gclass117_0.sbyte_0)
						GClass160.smethod_0().list_1.Remove(item);
				}
			}
			if (int_67 == 6)
			{
				string text2 = "";
				if (GClass78.smethod_1().gclass128_2[6].gclass120_0 != null)
				{
					for (int m = 0; m < GClass78.smethod_1().gclass128_2[6].gclass120_0.Length; m++)
					{
						text2 = text2 + GClass78.smethod_1().gclass128_2[6].gclass120_0[m].gclass126_0.int_0 + "-";
					}
				}
				foreach (GClass160.GStruct10 item2 in GClass160.smethod_0().list_0)
				{
					if (item2.int_0 == GClass78.smethod_1().gclass128_2[6].gclass117_0.short_0 && item2.string_0 == text2 && item2.int_1 == GClass78.smethod_1().gclass128_2[6].gclass117_0.sbyte_0)
						GClass160.smethod_0().list_0.Remove(item2);
				}
			}
		}
		if (idAction == 2003)
		{
			GClass50.smethod_8("remove item");
			bool flag2 = int_67 < GClass78.smethod_1().gclass128_2.Length;
			sbyte b2 = 0;
			if (!flag2)
				b2 = (sbyte)(int_67 - GClass78.smethod_1().gclass128_2.Length);
			GClass7.smethod_0().method_20(1, (!flag2) ? ((sbyte)1) : ((sbyte)0), (sbyte)(flag2 ? int_67 : b2), -1);
		}
		if (idAction == 2004)
		{
			GClass73.smethod_29();
			GClass75 gClass17 = (GClass75)p;
			sbyte where = (sbyte)gClass17.int_1;
			sbyte index = (sbyte)gClass17.int_0;
			GClass7.smethod_0().method_20((sbyte)((gClass17.int_2 != 0) ? 2 : 3), where, index, -1);
		}
		if (idAction == 2005)
		{
			GClass128[] gclass128_3 = GClass78.smethod_1().gclass128_2;
			sbyte id3 = (sbyte)(int_67 - gclass128_3.Length);
			GClass7.smethod_0().method_30(sbyte_6, id3);
		}
		if (idAction == 2006)
		{
			_ = GClass78.smethod_2().gclass128_2;
			sbyte id4 = (sbyte)int_67;
			GClass7.smethod_0().method_30(sbyte_7, id4);
		}
		if (idAction == 30001)
		{
			GClass50.smethod_8("nhan do");
			GClass7.smethod_0().method_55(0, int_67, 0);
		}
		if (idAction == 30002)
		{
			GClass50.smethod_8("xoa do");
			GClass7.smethod_0().method_55(1, int_67, 0);
		}
		if (idAction == 30003)
		{
			GClass50.smethod_8("nhan tat");
			GClass7.smethod_0().method_55(2, int_67, 0);
		}
		if (idAction == 3000)
		{
			GClass50.smethod_8("mua do");
			GClass128 gClass18 = (GClass128)p;
			GClass7.smethod_0().method_55(0, gClass18.gclass117_0.short_0, 0);
		}
		if (idAction == 3001)
		{
			GClass128 gClass19 = (GClass128)p;
			GClass7.smethod_0().method_55(1, gClass19.gclass117_0.short_0, 0);
		}
		if (idAction == 3002)
		{
			GClass73.smethod_29();
			GClass7.smethod_0().method_54(0, (sbyte)((int_67 > 6) ? 1 : 0), (short)((int_67 >= 10) ? (int_67 - 10) : int_67));
		}
		if (idAction == 3003)
		{
			GClass73.smethod_29();
			GClass75 gClass20 = (GClass75)p;
			GClass7.smethod_0().method_54(1, (sbyte)gClass20.int_2, (short)gClass20.int_0);
		}
		if (idAction == 3004)
		{
			GClass128 gClass21 = (GClass128)p;
			GClass7.smethod_0().method_55(3, gClass21.gclass117_0.short_0, 0);
		}
		if (idAction == 3005)
		{
			GClass50.smethod_8("mua do");
			GClass128 gClass22 = (GClass128)p;
			GClass7.smethod_0().method_55(3, gClass22.gclass117_0.short_0, 0);
		}
		if (idAction == 4000)
		{
			GClass106 gClass23 = (GClass106)p;
			if (gClass23 != null)
			{
				GClass73.smethod_29();
				GClass7.smethod_0().method_19(2, null, gClass23.int_0);
			}
		}
		if (idAction == 4001)
		{
			GClass106 gClass24 = (GClass106)p;
			if (gClass24 != null)
			{
				GClass130.smethod_1();
				string_21 = mResources.PLEASEWAIT;
				GClass7.smethod_0().method_22(gClass24.int_0);
			}
		}
		if (idAction == 4005)
			GClass73.smethod_29();
		if (idAction == 4007)
			GClass73.smethod_29();
		if (idAction == 4006)
		{
			GClass189 gClass25 = (GClass189)p;
			GClass7.smethod_0().method_18(gClass25.int_0);
		}
		if (idAction == 5001)
		{
			GClass38 gClass26 = (GClass38)p;
			GClass7.smethod_0().method_25(gClass26.int_0, 0);
		}
		if (idAction == 5002)
		{
			GClass38 gClass27 = (GClass38)p;
			GClass7.smethod_0().method_25(gClass27.int_0, 1);
		}
		if (idAction == 5003)
		{
			GClass38 gClass28 = (GClass38)p;
			GClass7.smethod_0().method_25(gClass28.int_0, 2);
		}
		if (idAction == 5004)
		{
			GClass38 gClass29 = (GClass38)p;
			GClass7.smethod_0().method_25(gClass29.int_0, -1);
		}
		if (idAction == 9000)
		{
			GClass7.smethod_0().method_124(int_67, 1);
			GClass73.smethod_29();
			GClass130.smethod_1();
		}
		if (idAction == 9006)
		{
			GClass7.smethod_0().method_124(int_67, 10);
			GClass73.smethod_29();
			GClass130.smethod_1();
		}
		if (idAction == 9007)
		{
			GClass7.smethod_0().method_124(int_67, 100);
			GClass73.smethod_29();
			GClass130.smethod_1();
		}
		if (idAction == 9002)
		{
			GClass63 gClass30 = (GClass63)p;
			if (!gClass30.gclass47_0.method_3())
				GClass73.smethod_30(mResources.can_buy_from_Uron1 + gClass30.long_0 + mResources.can_buy_from_Uron2 + gClass30.string_0 + mResources.can_buy_from_Uron3);
			else
				GClass73.smethod_30(mResources.updSkill);
		}
		if (idAction == 9003)
		{
			if (!GClass73.bool_5 || Main.isPC)
				GClass144.smethod_8().method_11((GClass47)p);
			else
				GClass144.smethod_8().method_10((GClass47)p);
		}
		if (idAction == 9004)
		{
			GClass63 gClass31 = (GClass63)p;
			if (!gClass31.gclass47_0.method_3())
				GClass73.smethod_30(mResources.can_buy_from_Uron1 + gClass31.long_0 + mResources.can_buy_from_Uron2 + gClass31.string_0 + mResources.can_buy_from_Uron3);
			else
				GClass73.smethod_30(mResources.learnSkill);
		}
		if (idAction == 10000)
		{
			GClass16 gClass32 = (GClass16)p;
			GClass7.smethod_0().method_129(1, gClass32.gclass78_0.int_13);
			GClass73.gclass76_0.method_150();
		}
		if (idAction == 10001)
		{
			GClass16 gClass33 = (GClass16)p;
			GClass7.smethod_0().method_129(2, gClass33.gclass78_0.int_13);
			GClass130.smethod_1();
		}
		if (idAction == 10021)
			;
		if (idAction == 10012)
		{
			if (gclass91_0 == null)
			{
				gclass91_0 = new GClass91();
				gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
				gclass91_0.method_0();
				gclass91_0.ginterface4_0 = ((GClass73.gclass76_1 == null) ? GClass73.gclass76_0 : GClass73.gclass76_1);
			}
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			gclass91_0.gclass191_0.method_23("");
			if (gclass128_0.int_30 != 1)
			{
				gclass91_0.string_1 = mResources.input_quantity + " ";
				gclass91_0.gclass191_0.string_7 = mResources.input_quantity;
			}
			else
			{
				gclass91_0.string_1 = mResources.kiguiXuchat;
				gclass91_0.gclass191_0.string_7 = mResources.input_money;
			}
			gclass91_0.gclass191_0.method_26(10);
			gclass91_0.string_0 = "";
			gclass91_0.bool_0 = true;
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			if (GClass73.bool_5)
				gclass91_0.gclass191_0.method_0();
			if (Main.isWindowsPhone)
				gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
			if (!Main.isPC)
				gclass91_0.method_5(this, "");
		}
		if (idAction == 10013)
		{
			if (gclass91_0 == null)
			{
				gclass91_0 = new GClass91();
				gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
				gclass91_0.method_0();
				gclass91_0.ginterface4_0 = ((GClass73.gclass76_1 != null) ? GClass73.gclass76_1 : GClass73.gclass76_0);
			}
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			gclass91_0.gclass191_0.method_23("");
			if (gclass128_0.int_30 != 1)
			{
				gclass91_0.string_1 = mResources.input_quantity + "  ";
				gclass91_0.gclass191_0.string_7 = mResources.input_quantity;
			}
			else
			{
				gclass91_0.string_1 = mResources.kiguiLuongchat;
				gclass91_0.gclass191_0.string_7 = mResources.input_money;
			}
			gclass91_0.string_0 = "";
			gclass91_0.bool_0 = true;
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			if (GClass73.bool_5)
				gclass91_0.gclass191_0.method_0();
			if (Main.isWindowsPhone)
				gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
			if (!Main.isPC)
				gclass91_0.method_5(this, "");
		}
		if (idAction == 10014)
		{
			GClass128 gClass34 = (GClass128)p;
			GClass7.smethod_0().method_130(1, gClass34.int_27, -1, -1, -1);
			GClass130.smethod_1();
		}
		if (idAction == 10015)
		{
			GClass128 gClass35 = (GClass128)p;
			GClass7.smethod_0().method_130(2, gClass35.int_27, -1, -1, -1);
			GClass130.smethod_1();
		}
		if (idAction == 10016)
		{
			GClass128 gClass36 = (GClass128)p;
			GClass7.smethod_0().method_130(3, gClass36.int_27, 0, gClass36.int_34, -1);
			GClass130.smethod_1();
		}
		if (idAction == 10017)
		{
			GClass128 gClass37 = (GClass128)p;
			GClass7.smethod_0().method_130(3, gClass37.int_27, 1, gClass37.int_36, -1);
			GClass130.smethod_1();
		}
		if (idAction == 10018)
		{
			GClass128 gClass38 = (GClass128)p;
			GClass7.smethod_0().method_130(5, gClass38.int_27, -1, -1, -1);
			GClass130.smethod_1();
		}
		if (idAction == 10019)
		{
			GClass14.smethod_0().close();
			GClass1.smethod_4("acc", "");
			GClass1.smethod_4("pass", "");
			GClass73.gclass133_0.gclass191_1.method_23("");
			GClass73.gclass133_0.gclass191_0.method_23("");
			GClass73.gclass133_0.bool_12 = false;
			GClass73.gclass133_0.switchToMe();
			GClass73.smethod_29();
			method_151();
		}
		if (idAction == 10020)
			GClass73.smethod_29();
		if (idAction == 10030)
		{
			GClass7.smethod_0().method_131(1, (sbyte)int_67);
			GClass73.gclass76_0.method_150();
		}
		if (idAction == 10031)
			GClass14.smethod_0().close();
		if (idAction == 11000)
		{
			GClass7.smethod_0().method_130(0, gclass128_0.int_27, 1, gclass128_0.int_40, 1);
			GClass73.smethod_29();
		}
		if (idAction == 11001)
		{
			GClass7.smethod_0().method_130(0, gclass128_0.int_27, 1, gclass128_0.int_40, gclass128_0.int_31);
			GClass73.smethod_29();
		}
		if (idAction == 11002)
		{
			gclass91_0.bool_0 = false;
			GClass73.smethod_29();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (gclass91_0.gclass191_0.method_21() != null && !gclass91_0.gclass191_0.method_21().Equals("") && !text.Equals("") && text != null)
		{
			if (!gclass91_0.string_1.Equals(mResources.input_clan_name))
			{
				if (!gclass91_0.string_1.Equals(mResources.chat_clan))
				{
					if (!gclass91_0.string_1.Equals(mResources.input_clan_name_to_create))
					{
						if (gclass91_0.string_1.Equals(mResources.input_clan_slogan))
						{
							if (gclass91_0.gclass191_0.method_21() == "")
							{
								GClass144.gclass52_0.method_7(mResources.clan_slogan_blank, 0);
								return;
							}
							GClass7.smethod_0().method_28(4, (sbyte)GClass78.smethod_1().gclass106_0.int_1, gclass91_0.gclass191_0.method_21());
							gclass91_0.bool_0 = false;
							return;
						}
						if (gclass91_0.string_1.Equals(mResources.input_Inventory_Pass))
							try
							{
								int pass = int.Parse(gclass91_0.gclass191_0.method_21());
								gclass91_0.bool_0 = false;
								gclass91_0.gclass191_0.method_28(GClass191.int_11);
								method_151();
								if (gclass91_0.gclass191_0.method_21().Length == 6 && !gclass91_0.gclass191_0.method_21().Equals(""))
								{
									GClass7.smethod_0().method_132(pass);
									gclass91_0.bool_0 = false;
									gclass91_0.gclass191_0.method_28(GClass191.int_11);
									method_151();
								}
								else
									GClass73.smethod_30(mResources.input_Inventory_Pass_wrong);
								return;
							}
							catch (Exception)
							{
								GClass73.smethod_30(mResources.ALERT_PRIVATE_PASS_2);
								return;
							}
						if (!gclass91_0.string_1.Equals(mResources.world_channel_5_luong))
						{
							if (gclass91_0.string_1.Equals(mResources.chat_player))
							{
								gclass91_0.bool_0 = false;
								GClass16 gClass = null;
								if (int_28 == 8)
									gClass = (GClass16)gclass88_3.method_3(int_150);
								else if (int_28 == 11)
								{
									gClass = (GClass16)gclass88_5.method_3(int_150);
								}
								if (gClass.gclass78_0.int_13 != GClass78.smethod_1().int_13)
									GClass7.smethod_0().method_97(text, gClass.gclass78_0.int_13);
							}
							else if (!gclass91_0.string_1.Equals(mResources.input_quantity_to_trade))
							{
								if (!(gclass91_0.string_1 == mResources.input_money_to_trade))
								{
									if (!gclass91_0.string_1.Equals(mResources.kiguiXuchat))
									{
										if (gclass91_0.string_1.Equals(mResources.kiguiXuchat + " "))
										{
											GClass7.smethod_0().method_130(0, gclass128_0.int_27, 0, int.Parse(gclass91_0.gclass191_0.method_21()), gclass128_0.int_31);
											gclass91_0.bool_0 = false;
										}
										else if (!gclass91_0.string_1.Equals(mResources.kiguiLuongchat))
										{
											if (gclass91_0.string_1.Equals(mResources.kiguiLuongchat + "  "))
											{
												method_213(1);
												gclass91_0.bool_0 = false;
											}
											else if (!gclass91_0.string_1.Equals(mResources.input_quantity + " "))
											{
												if (gclass91_0.string_1.Equals(mResources.input_quantity + "  "))
												{
													gclass128_0.int_31 = int.Parse(gclass91_0.gclass191_0.method_21());
													if (gclass128_0.int_31 <= gclass128_0.int_30)
													{
														bool_25 = true;
														gclass91_0.bool_0 = false;
													}
													else
														GClass73.smethod_30(mResources.input_quantity_wrong);
												}
											}
											else
											{
												gclass128_0.int_31 = int.Parse(gclass91_0.gclass191_0.method_21());
												if (gclass128_0.int_31 > gclass128_0.int_30)
												{
													GClass73.smethod_30(mResources.input_quantity_wrong);
													return;
												}
												bool_24 = true;
												gclass91_0.bool_0 = false;
											}
										}
										else
										{
											method_213(0);
											gclass91_0.bool_0 = false;
										}
									}
									else
									{
										GClass7.smethod_0().method_130(0, gclass128_0.int_27, 0, int.Parse(gclass91_0.gclass191_0.method_21()), 1);
										gclass91_0.bool_0 = false;
									}
								}
								else
								{
									int num = 0;
									try
									{
										num = int.Parse(gclass91_0.gclass191_0.method_21());
									}
									catch (Exception)
									{
										GClass73.smethod_30(mResources.input_money_wrong);
										gclass91_0.bool_0 = false;
										gclass91_0.gclass191_0.method_28(GClass191.int_11);
										return;
									}
									if (num <= GClass78.smethod_1().long_6)
									{
										int_22 = num;
										GClass7.smethod_0().method_6(2, -1, -1, num);
										gclass91_0.bool_0 = false;
										gclass91_0.gclass191_0.method_28(GClass191.int_11);
									}
									else
									{
										GClass73.smethod_30(mResources.not_enough_money);
										gclass91_0.bool_0 = false;
										gclass91_0.gclass191_0.method_28(GClass191.int_11);
									}
								}
							}
							else
							{
								int num2 = 0;
								try
								{
									num2 = int.Parse(gclass91_0.gclass191_0.method_21());
								}
								catch (Exception)
								{
									GClass73.smethod_30(mResources.input_quantity_wrong);
									gclass91_0.bool_0 = false;
									gclass91_0.gclass191_0.method_28(GClass191.int_11);
									return;
								}
								if (num2 > 0 && num2 <= gclass128_0.int_30)
								{
									gclass128_0.bool_0 = true;
									GClass128 gClass2 = new GClass128();
									gClass2.gclass117_0 = gclass128_0.gclass117_0;
									gClass2.int_30 = num2;
									gClass2.int_29 = gclass128_0.int_29;
									gClass2.gclass120_0 = gclass128_0.gclass120_0;
									GClass73.gclass76_0.gclass88_6.method_0(gClass2);
									GClass7.smethod_0().method_6(2, -1, (sbyte)gClass2.int_29, gClass2.int_30);
									gclass91_0.bool_0 = false;
									gclass91_0.gclass191_0.method_28(GClass191.int_11);
								}
								else
								{
									GClass73.smethod_30(mResources.input_quantity_wrong);
									gclass91_0.bool_0 = false;
									gclass91_0.gclass191_0.method_28(GClass191.int_11);
								}
							}
						}
						else if (!gclass91_0.gclass191_0.method_21().Equals(""))
						{
							GClass7.smethod_0().method_98(gclass91_0.gclass191_0.method_21());
							gclass91_0.bool_0 = false;
							method_151();
						}
					}
					else if (!(gclass91_0.gclass191_0.method_21() == ""))
					{
						if (gclass84_0 == null)
							gclass84_0 = new GClass84();
						gclass84_0.string_0 = gclass91_0.gclass191_0.method_21();
						gclass84_0.method_1(false);
						gclass91_0.bool_0 = false;
					}
					else
					{
						GClass144.gclass52_0.method_7(mResources.clan_name_blank, 0);
					}
				}
				else
				{
					GClass130.smethod_1();
					gclass91_0.bool_0 = false;
					GClass7.smethod_0().method_19(0, text, -1);
				}
			}
			else
			{
				GClass130.smethod_1();
				gclass91_0.bool_0 = false;
				GClass7.smethod_0().method_23(text);
			}
		}
		else
			gclass91_0.bool_0 = false;
	}

	public void onCancelChat()
	{
		gclass91_0.gclass191_0.method_28(GClass191.int_11);
	}

	public void method_195(int type)
	{
		int_166 = type;
		int_155 = 90;
		if (int_166 != 0)
		{
			if (int_166 == 1)
			{
				int_159 = 2;
				int_157 = 0;
				int_156 = 0;
				int_165 = 1;
				for (int i = 0; i < gclass88_0.method_2(); i++)
				{
					GClass128 gClass = (GClass128)gclass88_0.method_3(i);
					if (gClass != null)
					{
						if (i == 0)
							short_1 = gClass.gclass117_0.short_1;
						else
							short_2 = gClass.gclass117_0.short_1;
					}
				}
			}
			else if (int_166 != 2)
			{
				if (int_166 != 3)
				{
					if (int_166 == 4)
					{
						int_159 = gclass88_0.method_2();
						short_4 = new short[int_159];
						int_157 = 25;
						int_156 = 25;
						int_165 = 1;
						for (int j = 0; j < gclass88_0.method_2(); j++)
						{
							GClass128 gClass2 = (GClass128)gclass88_0.method_3(j);
							if (gClass2 != null)
								short_4[j] = gClass2.gclass117_0.short_1;
						}
					}
				}
				else
				{
					int_153 = GClass73.int_12;
					int_154 = GClass73.int_13;
					int_159 = 1;
					int_157 = 1;
					int_156 = 1;
					int_165 = 4;
					for (int k = 0; k < gclass88_0.method_2(); k++)
					{
						GClass128 gClass3 = (GClass128)gclass88_0.method_3(k);
						if (gClass3 != null)
							short_1 = gClass3.gclass117_0.short_1;
					}
				}
			}
			else
			{
				int_159 = 7;
				int_157 = 25;
				int_156 = 25;
				int_165 = 1;
				for (int l = 0; l < gclass88_0.method_2(); l++)
				{
					GClass128 gClass4 = (GClass128)gclass88_0.method_3(l);
					if (gClass4 != null)
						short_1 = gClass4.gclass117_0.short_1;
				}
			}
		}
		else
		{
			int_159 = 5;
			int_157 = 90;
			int_156 = 90;
			int_165 = 2;
			for (int m = 0; m < gclass88_0.method_2(); m++)
			{
				GClass128 gClass5 = (GClass128)gclass88_0.method_3(m);
				if (gClass5 != null)
				{
					if (gClass5.gclass117_0.sbyte_0 != 14)
						short_1 = gClass5.gclass117_0.short_1;
					else
						short_2 = gClass5.gclass117_0.short_1;
				}
			}
		}
		int_160 = 1;
		bool_26 = true;
		bool_29 = false;
		bool_27 = false;
		int_158 = 360 / int_159;
		int_161 = new int[int_159];
		int_162 = new int[int_159];
		int_163 = new int[int_159];
		int_164 = new int[int_159];
		method_198();
		bool_28 = true;
		int_167 = 10;
		int_168 = 30;
		int_169 = 10;
		method_200(int_152, mResources.combineSpell);
	}

	private void method_196()
	{
		int_167--;
		if (int_167 < 0)
			int_167 = 0;
		int_168--;
		if (int_168 < 0)
			int_168 = 0;
		if (int_167 != 0)
			return;
		if (bool_27)
		{
			if (!bool_27)
				return;
			if (sbyte_8 == 1)
			{
				if (int_169 == 10)
					GClass57.smethod_0(new GClass81(22, int_153 - 3, int_154 + 25, 4, 1, 1));
				int_169--;
				if (int_169 < 0)
					int_169 = 0;
				if (int_155 >= 300)
				{
					if (GClass73.int_8 % 20 == 0)
					{
						if (GClass73.int_10 > 2 * int_55)
						{
							GClass73.gclass76_1 = new GClass76();
							GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
							GClass73.gclass76_1.method_15();
							GClass73.gclass76_1.method_50();
						}
						sbyte_8 = -1;
						bool_29 = true;
						if (int_166 == 4)
							GClass73.gclass76_0.method_150();
					}
				}
				else
				{
					int_155 = GClass50.smethod_28(int_155 + 10);
					if (int_155 == 20)
						method_200(int_152, mResources.combineFail);
				}
				method_198();
			}
			else
			{
				if (sbyte_8 != 0)
					return;
				if (int_169 == 10)
				{
					if (int_166 != 2)
						GClass57.smethod_0(new GClass81(21, int_153 - 10, int_154 + 25, 4, 1, 1));
					else
						GClass57.smethod_0(new GClass81(20, int_153 - 3, int_154 + 15, 4, 2, 1));
					method_200(int_152, mResources.combineSuccess);
					bool_28 = false;
				}
				if (bool_28)
					return;
				int_169--;
				if (int_169 < -50)
				{
					int_169 = -50;
					if (int_166 < 3 && GClass73.int_10 > 2 * int_55)
					{
						GClass73.gclass76_1 = new GClass76();
						GClass73.gclass76_1.string_17[7] = new string[1][] { new string[1] { "" } };
						GClass73.gclass76_1.method_15();
						GClass73.gclass76_1.method_50();
					}
					sbyte_8 = -1;
					bool_29 = true;
					if (int_166 == 4)
						GClass73.gclass76_0.method_150();
				}
			}
			return;
		}
		if (int_165 <= 0)
		{
			if (GClass73.int_8 % 20 == 0)
				bool_27 = true;
		}
		else if (sbyte_8 != -1)
		{
			if (int_166 == 3)
			{
				if (GClass73.int_8 % 10 == 0)
				{
					GClass57.smethod_0(new GClass81(21, int_153 - 10, int_154 + 25, 4, 1, 1));
					int_165--;
				}
			}
			else
			{
				if (GClass73.int_8 % 2 == 0)
				{
					if (bool_26)
					{
						if (int_160 < 40)
							int_160 += 2;
					}
					else if (int_160 > 10)
					{
						int_160 -= 2;
					}
				}
				if (int_168 == 0)
				{
					if (bool_26)
					{
						if (int_155 <= 0)
						{
							if (GClass73.int_8 % 10 == 0)
							{
								bool_26 = false;
								int_165--;
								int_168 = 5;
								int_169 = 10;
							}
						}
						else
							int_155 -= 5;
					}
					else if (int_155 < 90)
					{
						int_155 += 5;
					}
					else if (GClass73.int_8 % 10 == 0)
					{
						bool_26 = true;
						int_168 = 10;
					}
				}
				int_156 = int_157;
				int_156 -= int_160;
				if (int_156 >= 360)
					int_156 -= 360;
				if (int_156 < 0)
					int_156 = 360 + int_156;
				int_157 = int_156;
				method_198();
			}
		}
		if (GClass73.int_8 % 20 == 0)
		{
			if (int_166 != 3)
				GClass95.smethod_0(132, int_153, int_154, 2);
			GClass95.smethod_0(114, int_153, int_154 + 20, 2);
		}
	}

	public void method_197(GClass122 g)
	{
		GClass144.smethod_8().method_80(g);
		method_199(g);
		if (GClass73.int_8 % 4 == 0)
			g.method_31(GClass64.gclass70_0, int_153, int_154 + 15, GClass122.int_5 | GClass122.int_0);
		if (int_166 == 0)
		{
			for (int i = 0; i < int_162.Length; i++)
			{
				GClass28.smethod_6(g, short_1, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
				if (bool_28)
					GClass28.smethod_6(g, short_2, int_163[i], int_164[i], 0, GClass122.int_1 | GClass122.int_0);
			}
		}
		else if (int_166 == 1)
		{
			if (!bool_28)
			{
				GClass28.smethod_6(g, short_3, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
				return;
			}
			for (int j = 0; j < int_162.Length; j++)
			{
				GClass28.smethod_6(g, short_1, int_163[0], int_164[0], 0, GClass122.int_1 | GClass122.int_0);
				GClass28.smethod_6(g, short_2, int_163[1], int_164[1], 0, GClass122.int_1 | GClass122.int_0);
			}
		}
		else if (int_166 == 2)
		{
			if (bool_28)
			{
				for (int k = 0; k < int_162.Length; k++)
				{
					GClass28.smethod_6(g, short_1, int_163[k], int_164[k], 0, GClass122.int_1 | GClass122.int_0);
				}
			}
			else
				GClass28.smethod_6(g, short_3, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
		}
		else if (int_166 != 3)
		{
			if (int_166 != 4)
				return;
			if (bool_28)
			{
				for (int l = 0; l < short_4.Length; l++)
				{
					GClass28.smethod_6(g, short_4[l], int_163[l], int_164[l], 0, GClass122.int_1 | GClass122.int_0);
				}
			}
			else if (short_3 != -1)
			{
				GClass28.smethod_6(g, short_3, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
			}
		}
		else if (!bool_28)
		{
			GClass28.smethod_6(g, short_3, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
		}
		else
		{
			GClass28.smethod_6(g, short_1, int_153, int_154, 0, GClass122.int_1 | GClass122.int_0);
		}
	}

	private void method_198()
	{
		for (int i = 0; i < int_162.Length; i++)
		{
			if (int_156 >= 360)
				int_156 -= 360;
			if (int_156 < 0)
				int_156 = 360 + int_156;
			int_162[i] = GClass50.smethod_28(int_155 * GClass50.smethod_1(int_156) / 1024);
			int_161[i] = GClass50.smethod_28(int_155 * GClass50.smethod_2(int_156) / 1024);
			if (int_156 >= 90)
			{
				if (int_156 >= 90 && int_156 < 180)
				{
					int_163[i] = int_153 - int_161[i];
					int_164[i] = int_154 - int_162[i];
				}
				else if (int_156 >= 180 && int_156 < 270)
				{
					int_163[i] = int_153 - int_161[i];
					int_164[i] = int_154 + int_162[i];
				}
				else
				{
					int_163[i] = int_153 + int_161[i];
					int_164[i] = int_154 + int_162[i];
				}
			}
			else
			{
				int_163[i] = int_153 + int_161[i];
				int_164[i] = int_154 - int_162[i];
			}
			int_156 -= int_158;
		}
	}

	public void method_199(GClass122 g)
	{
		g.method_1(-GClass144.int_22, -GClass144.int_23);
		if (int_166 < 3)
		{
			for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
			{
				GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
				if (gClass.gclass127_0.int_0 == int_152)
				{
					gClass.paint(g);
					if (gClass.gclass92_0 != null)
						gClass.gclass92_0.method_1(g, gClass.int_4, gClass.int_5 - gClass.int_58 - GClass73.int_58, gClass.int_12);
				}
			}
		}
		GClass73.smethod_6(g);
		if (GClass73.int_8 % 4 == 0)
		{
			g.method_31(GClass64.gclass70_0, int_153 - 5, int_154 + 15, GClass122.int_5 | GClass122.int_0);
			g.method_31(GClass64.gclass70_0, int_153 + 5, int_154 + 15, GClass122.int_5 | GClass122.int_0);
			g.method_31(GClass64.gclass70_0, int_153, int_154 + 15, GClass122.int_5 | GClass122.int_0);
		}
		for (int j = 0; j < GClass93.gclass88_0.method_2(); j++)
		{
			((GClass93)GClass93.gclass88_0.method_3(j)).paint(g);
		}
	}

	public void method_200(int idNPC, string text)
	{
		if (int_166 >= 3)
			return;
		for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
		{
			GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
			if (gClass.gclass127_0.int_0 == idNPC)
				gClass.method_11(text);
		}
	}

	public void method_201()
	{
		int_28 = 19;
		method_5(0);
		method_202();
		int_14 = 0;
		int_15 = 0;
	}

	private void method_202()
	{
		GClass109.smethod_1().method_2();
		int_41 = string_7.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	private void method_203(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_7.Length; i++)
		{
			int x = int_58;
			int num = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(x, num, w, h);
				GClass4.gclass4_6.method_6(gclass122_0, string_7[i], int_58 + 25, num + 6, GClass4.int_0);
			}
		}
		method_100(gclass122_0);
	}

	private void method_204()
	{
		if (int_67 < 0)
			return;
		switch (int_67)
		{
		case 0:
			GClass109.smethod_1().method_15();
			break;
		case 1:
			GClass109.smethod_1().method_16();
			break;
		case 2:
			GClass109.smethod_1().method_10();
			break;
		case 3:
			if (Main.isPC)
				GClass73.smethod_36(mResources.changeSizeScreen, new GClass87(mResources.YES, this, 170391, null), new GClass87(mResources.NO, this, 4005, null));
			else
				GClass109.smethod_1().method_14();
			break;
		case 4:
			if (Main.isPC)
				GClass73.smethod_36(mResources.changeSizeScreen, new GClass87(mResources.YES, this, 170391, null), new GClass87(mResources.NO, this, 4005, null));
			else
				GClass109.smethod_1().method_13();
			break;
		case 5:
			GClass109.smethod_1().method_13();
			break;
		}
	}

	public void method_205()
	{
		int_28 = 20;
		method_5(0);
		method_206();
		int_14 = 0;
		int_15 = 0;
	}

	private void method_206()
	{
		if (!Main.IphoneVersionApp)
		{
			string_8 = new string[5]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg,
				mResources.charger
			};
			if (GClass144.bool_69)
				string_8 = new string[6]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger,
					mResources.autoFunction
				};
			if ((GClass203.int_0 == 2 || GClass203.int_0 == 7) && mResources.language != 2)
			{
				string_8 = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger
				};
				if (GClass144.bool_69)
					string_8 = new string[6]
					{
						mResources.inventory_Pass,
						mResources.friend,
						mResources.enemy,
						mResources.msg,
						mResources.charger,
						mResources.autoFunction
					};
			}
		}
		else
		{
			string_8 = new string[4]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg
			};
			if (GClass144.bool_69)
				string_8 = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.autoFunction
				};
		}
		int_41 = string_8.Length;
		int_4 = 24;
		int_67 = (GClass73.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
	}

	private void method_207(GClass122 gclass122_0)
	{
		gclass122_0.method_5(int_58, int_59, int_60, int_61);
		gclass122_0.method_1(0, -int_8);
		for (int i = 0; i < string_8.Length; i++)
		{
			int x = int_58;
			int num = int_59 + i * int_4;
			int w = int_60 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_59 + int_61 && num - int_8 >= int_59 - int_4)
			{
				gclass122_0.method_16((i != int_67) ? 15196114 : 16383818);
				gclass122_0.method_15(x, num, w, h);
				GClass4.gclass4_6.method_6(gclass122_0, string_8[i], int_58 + int_60 / 2, num + 6, GClass4.int_2);
			}
		}
		method_100(gclass122_0);
	}

	private void method_208()
	{
		if (int_67 < 0)
			return;
		switch (int_67)
		{
		case 0:
			GClass73.smethod_29();
			if (gclass91_0 == null)
			{
				gclass91_0 = new GClass91();
				gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
				gclass91_0.method_0();
				gclass91_0.ginterface4_0 = GClass73.gclass76_0;
			}
			gclass91_0.gclass191_0.method_23("");
			gclass91_0.string_1 = mResources.input_Inventory_Pass;
			gclass91_0.gclass191_0.string_7 = mResources.input_Inventory_Pass;
			gclass91_0.string_0 = "";
			gclass91_0.bool_0 = true;
			gclass91_0.gclass191_0.bool_0 = true;
			gclass91_0.gclass191_0.method_28(GClass191.int_12);
			if (GClass73.bool_5)
				gclass91_0.gclass191_0.method_0();
			if (!Main.isPC)
				gclass91_0.method_5(this, "");
			if (Main.isWindowsPhone)
				gclass91_0.gclass191_0.string_9 = gclass91_0.string_1;
			break;
		case 1:
			GClass7.smethod_0().method_13(0, -1);
			GClass130.smethod_1();
			break;
		case 2:
			GClass7.smethod_0().method_129(0, -1);
			GClass130.smethod_1();
			break;
		case 3:
			method_31();
			if (gclass91_0 == null)
			{
				gclass91_0 = new GClass91();
				gclass91_0.gclass191_0.int_1 = GClass73.int_11 - 35 - GClass91.smethod_0().gclass191_0.int_3;
				gclass91_0.method_0();
				gclass91_0.ginterface4_0 = GClass73.gclass76_0;
			}
			break;
		case 4:
		{
			if (mResources.language != 2)
			{
				method_150();
				if (GClass78.smethod_1().gclass56_0.short_1 <= 10)
					GClass73.smethod_30(mResources.finishBomong);
				else
					GClass143.smethod_2().switchToMe();
				break;
			}
			string url = "http://dragonball.indonaga.com/coda/?username=" + GClass73.gclass133_0.gclass191_0.method_21();
			method_150();
			try
			{
				GClass187.gclass187_0.method_3(url);
				break;
			}
			catch (Exception ex)
			{
				ex.StackTrace.ToString();
				break;
			}
		}
		case 5:
			method_37();
			break;
		}
	}

	private void method_209()
	{
		method_72();
	}

	public void method_210()
	{
		int_28 = 25;
		method_5(0);
		method_211();
		int_29 = 0;
	}

	private void method_211()
	{
		int_4 = 24;
		int_41 = GClass78.smethod_1().string_4[int_29].Length;
		int_11 = int_41 * int_4 - int_61;
		if (int_11 < 0)
			int_11 = 0;
		int_8 = (int_7 = int_13[int_29]);
		if (int_8 < 0)
		{
			int num = 0;
			int_7 = 0;
			int_8 = 0;
		}
		if (int_8 > int_11)
			int_8 = (int_7 = int_11);
		int_67 = (GClass73.bool_5 ? (-1) : 0);
	}

	public bool method_212()
	{
		if (int_28 == 1)
			return true;
		return false;
	}

	private void method_213(int int_182)
	{
		try
		{
			gclass128_0.int_40 = int.Parse(gclass91_0.gclass191_0.method_21());
		}
		catch (Exception)
		{
			GClass73.smethod_30(mResources.input_money_wrong);
			gclass91_0.bool_0 = false;
			return;
		}
		GClass87 cmdYes = new GClass87(mResources.YES, this, (int_182 != 0) ? 11001 : 11000, null);
		GClass87 cmdNo = new GClass87(mResources.NO, this, 11002, null);
		GClass73.smethod_36(mResources.notiRuby, cmdYes, cmdNo);
	}

	public static void smethod_1(int x, int y, int wItem, int hItem, int nline, int cl, GClass122 g)
	{
		try
		{
			int num = ((wItem << 1) + (hItem << 1)) / nline;
			int_171 = int_170.Length;
			if (nline > 4)
				int_171 = 2;
			for (int i = 0; i < nline; i++)
			{
				for (int j = 0; j < int_171; j++)
				{
					int int_ = ((int_170[j] <= 1) ? 1 : ((int_170[j] >> 1) + 1));
					int x2 = x + smethod_2(num * i, GClass73.int_8 - j * 4, wItem, hItem, int_);
					int y2 = y + smethod_3(num * i, GClass73.int_8 - j * 4, wItem, hItem, int_);
					g.method_16(int_172[cl][j]);
					g.method_15(x2, y2, int_170[j], int_170[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static int smethod_2(int int_182, int int_183, int int_184, int int_185, int int_186)
	{
		int num = (int_183 + int_182) % ((int_184 << 1) + (int_185 << 1));
		if (0 <= num && num < int_184)
			return num % int_184;
		if (int_184 > num || num >= int_184 + int_185)
		{
			if (int_184 + int_185 > num || num >= (int_184 << 1) + int_185)
				return 0;
			return int_184 - (num - int_185) % int_184 - int_186;
		}
		return int_184 - int_186;
	}

	private static int smethod_3(int int_182, int int_183, int int_184, int int_185, int int_186)
	{
		int num = (int_183 + int_182) % ((int_184 << 1) + (int_185 << 1));
		if (0 <= num && num < int_184)
			return 0;
		if (int_184 > num || num >= int_184 + int_185)
		{
			if (int_184 + int_185 <= num && num < (int_184 << 1) + int_185)
				return int_185 - int_186;
			return int_185 - (num - (int_184 << 1)) % int_185 - int_186;
		}
		return num % int_184;
	}

	public static int smethod_4(int id)
	{
		switch (id)
		{
		default:
			return -1;
		case 1:
			return 2786816;
		case 2:
			return 7078041;
		case 3:
			return 12537346;
		case 4:
			return 1269146;
		case 5:
			return 13279744;
		case 6:
			return 11599872;
		}
	}

	public static sbyte smethod_5(int lv)
	{
		if (lv >= 0)
		{
			switch (lv)
			{
			default:
				return 6;
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
				return 0;
			case 9:
				return 4;
			case 10:
				return 1;
			case 11:
				return 5;
			case 12:
				return 3;
			case 13:
				return 2;
			}
		}
		return 0;
	}

	public static GClass4 smethod_6(int color)
	{
		GClass4 result = GClass4.gclass4_11;
		switch (color)
		{
		case -1:
			result = GClass4.gclass4_11;
			break;
		case 0:
			result = GClass4.gclass4_6;
			break;
		case 1:
			result = GClass4.gclass4_8;
			break;
		case 2:
			result = GClass4.gclass4_2;
			break;
		case 3:
			result = GClass4.gclass4_17;
			break;
		case 4:
			result = GClass4.gclass4_19;
			break;
		case 5:
			result = GClass4.gclass4_18;
			break;
		case 7:
			result = GClass4.gclass4_1;
			break;
		case 8:
			result = GClass4.gclass4_4;
			break;
		}
		return result;
	}

	public void method_214(GClass122 g, int idOpt, int param, int x, int y, int w, int h)
	{
		switch (idOpt)
		{
		case 34:
			if (gclass70_13 != null)
				g.method_33(gclass70_13, x, y + h - gclass70_13.method_1());
			else
				gclass70_13 = GClass203.smethod_35("/mainImage/o_0.png");
			if (gclass70_14 != null)
				g.method_33(gclass70_14, x, y + h - gclass70_14.method_1());
			else
				gclass70_14 = GClass203.smethod_35("/mainImage/o_1.png");
			break;
		case 35:
			if (gclass70_13 == null)
				gclass70_13 = GClass203.smethod_35("/mainImage/o_0.png");
			else
				g.method_33(gclass70_13, x, y + h - gclass70_13.method_1());
			if (gclass70_15 != null)
				g.method_33(gclass70_15, x, y + h - gclass70_15.method_1());
			else
				gclass70_15 = GClass203.smethod_35("/mainImage/o_2.png");
			break;
		case 36:
			if (gclass70_13 != null)
				g.method_33(gclass70_13, x, y + h - gclass70_13.method_1());
			else
				gclass70_13 = GClass203.smethod_35("/mainImage/o_0.png");
			if (gclass70_16 == null)
				gclass70_16 = GClass203.smethod_35("/mainImage/o_3.png");
			else
				g.method_33(gclass70_16, x, y + h - gclass70_16.method_1());
			break;
		}
	}

	public void method_215(GClass122 g, int idOpt, int param, int x, int y, int w, int h)
	{
		if (idOpt == 102 && param > GClass96.int_15)
		{
			sbyte cl = smethod_5(param);
			smethod_1(x, y, w, h, param - GClass96.int_15, cl, g);
		}
	}

	public static GClass4 smethod_7(int id, int type)
	{
		GClass4 result;
		if (type != 0)
		{
			switch (id)
			{
			case 0:
				result = GClass4.gclass4_3;
				break;
			case 1:
				result = GClass4.gclass4_8;
				break;
			default:
				result = GClass4.gclass4_3;
				break;
			case 3:
				result = GClass4.gclass4_38;
				break;
			case 4:
				result = GClass4.gclass4_2;
				break;
			case 5:
				result = GClass4.gclass4_4;
				break;
			case 6:
				result = GClass4.gclass4_1;
				break;
			case 7:
				result = GClass4.gclass4_6;
				break;
			}
			return result;
		}
		switch (id)
		{
		case 0:
			result = GClass4.gclass4_28;
			break;
		case 1:
			result = GClass4.gclass4_30;
			break;
		default:
			result = GClass4.gclass4_28;
			break;
		case 3:
			result = GClass4.gclass4_31;
			break;
		case 4:
			result = GClass4.gclass4_32;
			break;
		case 5:
			result = GClass4.gclass4_29;
			break;
		case 6:
			result = GClass4.gclass4_27;
			break;
		}
		return result;
	}

	private bool method_216()
	{
		if ((int_28 == 0 && int_29 == 1) || (int_28 == 7 && int_29 == 0))
			return true;
		return false;
	}

	private void method_217()
	{
		if (int_67 < 0)
			return;
		if (!GClass73.bool_11[Main.isPC ? 23 : 4])
		{
			if (!GClass73.bool_11[Main.isPC ? 24 : 6])
				return;
			int_69++;
			if (bool_30)
				int_41 = 5;
			if (int_69 > sbyte_18 - 1)
			{
				int_69 = sbyte_18 - 1;
				if (GClass73.gclass76_1 != null)
				{
					GClass73.bool_22 = true;
					GClass73.gclass76_1.int_67 = 0;
				}
			}
			return;
		}
		int_69--;
		if (bool_30)
			int_41 = 5;
		if (int_69 < 0)
		{
			int_69 = 0;
			if (GClass73.bool_22)
			{
				GClass73.bool_22 = false;
				GClass73.gclass76_0.int_67 = 0;
			}
		}
	}

	private void method_218()
	{
		method_72();
		if (int_67 == 0)
			method_217();
	}

	private bool method_219()
	{
		if (sbyte_18 > 0)
		{
			if (string_2.Length <= 1)
			{
				if (int_67 >= 0)
					return true;
			}
			else if (int_67 == 0)
			{
				return true;
			}
		}
		return false;
	}
}
