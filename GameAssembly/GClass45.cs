using System;
using System.Collections.Generic;
using ns1;
using UnityEngine;

public class GClass45 : GInterface0, GInterface5
{
	public class GClass46
	{
		public string string_0;

		public int int_0;

		public bool bool_0;

		public List<GClass43> list_0 = new List<GClass43>();

		public GClass46(string name, int charId)
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

	public static GClass2 gclass2_0;

	public static GClass2 gclass2_1;

	public static GClass2 gclass2_2;

	public GClass141 gclass141_0;

	public GClass63 gclass63_0 = new GClass63();

	public int int_22;

	public int int_23;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;

	public string string_0;

	public GClass7 gclass7_0;

	public static string string_1;

	public static short short_0;

	public static GClass2 gclass2_3;

	public static GClass2 gclass2_4;

	public static GClass2 gclass2_5;

	public static GClass2 gclass2_6;

	public static GClass2 gclass2_7;

	public static GClass2 gclass2_8;

	public static GClass2 gclass2_9;

	public static GClass2 gclass2_10;

	private static GClass2 gclass2_11;

	private static GClass2 gclass2_12;

	private int int_24;

	private int int_25;

	private bool bool_5;

	private int int_26;

	private int int_27;

	private GClass14 gclass14_0 = new GClass14(mResources.SELECT, 0);

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
		(!GClass39.bool_21) ? mResources.turnOnSound : mResources.turnOffSound,
		mResources.increase_vga,
		mResources.analog,
		(GClass76.int_12 <= 1) ? mResources.x2Screen : mResources.x1Screen
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
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		string_12,
		string_15,
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		string_16,
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } },
		new string[1][] { new string[1] { string.Empty } }
	};

	private static sbyte sbyte_0 = 0;

	private static sbyte sbyte_1 = 1;

	private static sbyte sbyte_2 = 2;

	private static sbyte sbyte_3 = 3;

	private static sbyte sbyte_4 = 4;

	private static sbyte sbyte_5 = 5;

	private static sbyte UgAykqYvHY = 6;

	private static sbyte sbyte_6 = 7;

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

	public GClass121 gclass121_0;

	public GClass21 gclass21_0;

	public GClass62 gclass62_0;

	public GClass206 gclass206_0;

	public GClass21[] gclass21_1;

	public GClass63 gclass63_1;

	public GClass63 gclass63_2;

	public GClass63 gclass63_3 = new GClass63();

	public GClass63 gclass63_4 = new GClass63();

	public GClass63 gclass63_5 = new GClass63();

	public GClass63 gclass63_6 = new GClass63();

	public GClass63 gclass63_7 = new GClass63();

	public GClass63 gclass63_8 = new GClass63();

	public GClass63 gclass63_9 = new GClass63();

	public GClass63 gclass63_10 = new GClass63();

	public GClass63 gclass63_11 = new GClass63();

	public GClass14 gclass14_1;

	public static bool bool_6 = false;

	public static int int_55 = 240;

	private int UrRyYhZnVy;

	public string string_18;

	public Dictionary<string, GClass46> dictionary_0 = new Dictionary<string, GClass46>();

	public GClass58 gclass58_0;

	private bool bool_7;

	public int int_56 = -1;

	public int int_57;

	public int int_58;

	public int int_59;

	public int int_60;

	public GClass70 gclass70_0;

	public int int_61;

	public int[] int_62;

	private int int_63;

	public bool bool_8;

	public int int_64;

	private int int_65;

	public int int_66;

	private int int_67;

	private int int_68;

	private bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public const int int_69 = 0;

	public const int int_70 = 1;

	public const int int_71 = 2;

	public const int int_72 = 3;

	public const int int_73 = 4;

	public const int int_74 = 5;

	public const int int_75 = 6;

	public const int int_76 = 7;

	public const int int_77 = 8;

	public const int int_78 = 9;

	public const int int_79 = 10;

	public const int int_80 = 11;

	public const int int_81 = 12;

	public const int int_82 = 13;

	public const int int_83 = 14;

	public const int int_84 = 15;

	public const int int_85 = 16;

	public const int int_86 = 17;

	public const int int_87 = 18;

	public const int int_88 = 19;

	public const int int_89 = 20;

	public const int int_90 = 21;

	public const int int_91 = 22;

	public const int int_92 = 23;

	public const int int_93 = 24;

	public const int int_94 = 25;

	private int int_95;

	private int int_96;

	private int[] int_97 = new int[3];

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private int oTwynfpuwh;

	private int int_98;

	private int int_99 = -1;

	private int int_100 = -1;

	private int int_101 = -1;

	private int int_102 = -1;

	public int int_103 = -1;

	private bool bool_16;

	private int int_104 = -1;

	private int int_105;

	public string[][] string_19 = new string[2][]
	{
		mResources.findClan,
		mResources.createClan
	};

	public string string_20 = string.Empty;

	public string string_21 = string.Empty;

	private bool bool_17;

	private GClass105 gclass105_0;

	private int int_106;

	private int int_107;

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

	private int int_108;

	private int int_109;

	public static long[] long_0 = new long[14]
	{
		50000000L, 250000000L, 1250000000L, 5000000000L, 15000000000L, 30000000000L, 45000000000L, 60000000000L, 75000000000L, 90000000000L,
		110000000000L, 130000000000L, 150000000000L, 170000000000L
	};

	private int[] int_110 = new int[3] { 43520, 14743570, 14155776 };

	public string[] string_24;

	public string[] string_25;

	public static int[] int_111 = new int[3] { 2327248, 8982199, 16713222 };

	public static int[] int_112 = new int[3] { 4583423, 16719103, 16714764 };

	private int int_113;

	private GClass121 gclass121_1;

	private GClass33 gclass33_0;

	private static GClass125 gclass125_0;

	private bool bool_19;

	private int int_114;

	public static string string_26 = string.Empty;

	public int int_115;

	public int int_116;

	public int int_117 = 140;

	public int int_118 = 160;

	public int int_119;

	public int int_120;

	public int int_121;

	public int int_122;

	public int int_123;

	public int int_124;

	public int int_125;

	public int int_126;

	public int int_127;

	public int int_128 = 28;

	public int int_129;

	public int int_130;

	public int int_131 = -1;

	public int int_132;

	public int int_133;

	public int int_134 = 6;

	public int int_135;

	public int int_136;

	public int int_137;

	public int int_138;

	public int int_139;

	private int int_140;

	private int int_141;

	private int int_142;

	private int int_143;

	private int int_144;

	private int int_145;

	private int PuasEdRyOO;

	public static bool bool_20 = true;

	public bool bool_21;

	private int int_146;

	public static GClass63 gclass63_12 = new GClass63(string.Empty);

	public static string[] string_27;

	public bool bool_22;

	private int int_147;

	public GClass58 gclass58_1;

	private bool bool_23;

	private bool bool_24;

	private bool bool_25;

	private int NhGstqZex8;

	public sbyte sbyte_7 = -1;

	public int int_148;

	public int int_149;

	public int int_150;

	private int unxsbEvTty;

	private int int_151;

	private int int_152;

	private int int_153;

	private int int_154;

	private int int_155;

	private int[] int_156;

	private int[] int_157;

	private int[] int_158;

	private int[] int_159;

	private int int_160;

	private int int_161;

	private int int_162;

	private int int_163;

	private int int_164;

	private bool bool_26;

	private bool bool_27 = true;

	private bool bool_28;

	public bool bool_29 = true;

	public short short_1;

	public short short_2;

	public short short_3;

	public short[] short_4;

	public string[][] string_28;

	public static int[] int_165 = new int[3] { 2, 1, 1 };

	public static int int_166 = 1;

	public const sbyte sbyte_8 = 0;

	public const sbyte sbyte_9 = 1;

	public const sbyte sbyte_10 = 2;

	public const sbyte sbyte_11 = 3;

	public const sbyte sbyte_12 = 4;

	public const sbyte sbyte_13 = 5;

	public const sbyte sbyte_14 = 6;

	public const sbyte sbyte_15 = 7;

	public static int[][] int_167 = new int[7][]
	{
		new int[6] { 16777215, 15000805, 13487823, 11711155, 9671828, 7895160 },
		new int[6] { 61952, 58624, 52224, 45824, 39168, 32768 },
		new int[6] { 13500671, 12058853, 10682572, 9371827, 7995545, 6684800 },
		new int[6] { 16744192, 15037184, 13395456, 11753728, 10046464, 8404992 },
		new int[6] { 37119, 33509, 28108, 24499, 21145, 17536 },
		new int[6] { 16776192, 15063040, 12635136, 11776256, 10063872, 8290304 },
		new int[6] { 16711680, 15007744, 13369344, 11730944, 10027008, 8388608 }
	};

	public const int int_168 = 15987701;

	public const int int_169 = 2786816;

	public const int int_170 = 7078041;

	public const int int_171 = 12537346;

	public const int int_172 = 1269146;

	public const int int_173 = 13279744;

	public const int int_174 = 11599872;

	public const int int_175 = 2039326;

	private GClass2 gclass2_13;

	private GClass2 gclass2_14;

	private GClass2 gclass2_15;

	private GClass2 gclass2_16;

	public const int int_176 = 20;

	public const sbyte sbyte_16 = 1;

	public sbyte sbyte_17;

	private bool bool_30;

	public GClass45()
	{
		method_0();
		gclass14_1 = new GClass14(string.Empty, this, 1003, null);
		gclass14_1.gclass2_0 = (GClass173.smethod_0().bool_19 ? GClass173.smethod_0().method_4("X") : GClass39.smethod_43("/mainImage/myTexture2dbtX.png"));
		gclass14_1.bool_3 = true;
		gclass121_0 = null;
	}

	public static void smethod_0()
	{
		gclass2_2 = GClass39.smethod_43("/img/map" + GClass1.sbyte_2 + ".png");
		gclass2_0 = GClass39.smethod_43("/mainImage/myTexture2dbantay.png");
		gclass2_1 = GClass39.smethod_43("/mainImage/myTexture2dbtX.png");
		gclass2_7 = GClass39.smethod_43("/mainImage/myTexture2dimgMoney.png");
		gclass2_9 = GClass39.smethod_43("/mainImage/myTexture2dimgDiamond.png");
		gclass2_10 = GClass39.smethod_43("/mainImage/luongkhoa.png");
		gclass2_11 = GClass39.smethod_43("/mainImage/myTexture2dup.png");
		gclass2_12 = GClass39.smethod_43("/mainImage/myTexture2ddown.png");
		gclass2_3 = GClass39.smethod_43("/mainImage/star.png");
		gclass2_4 = GClass39.smethod_43("/mainImage/starE.png");
		gclass2_5 = GClass39.smethod_43("/mainImage/star8.png");
		gclass2_6 = GClass39.smethod_43("/mainImage/new.png");
		gclass2_8 = GClass39.smethod_43("/mainImage/ticket12.png");
	}

	public void method_0()
	{
		int_26 = GClass39.int_4 + int_17;
		int_27 = GClass39.int_5 + int_18;
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
			if (num < int_52[GClass1.sbyte_2].Length)
			{
				if (GClass1.int_37 == int_52[GClass1.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_53[GClass1.sbyte_2][num];
	}

	public int method_2()
	{
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass1.sbyte_2].Length)
			{
				if (GClass1.int_37 == int_52[GClass1.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_54[GClass1.sbyte_2][num];
	}

	public int method_3()
	{
		if (GClass58.smethod_1().gclass36_0 == null)
			return -1;
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass1.sbyte_2].Length)
			{
				if (GClass154.int_76[GClass58.smethod_1().gclass36_0.int_0] == int_52[GClass1.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_53[GClass1.sbyte_2][num];
	}

	public int method_4()
	{
		if (GClass58.smethod_1().gclass36_0 == null)
			return -1;
		int num = 0;
		while (true)
		{
			if (num < int_52[GClass1.sbyte_2].Length)
			{
				if (GClass154.int_76[GClass58.smethod_1().gclass36_0.int_0] == int_52[GClass1.sbyte_2][num])
					break;
				num++;
				continue;
			}
			return -1;
		}
		return int_54[GClass1.sbyte_2][num];
	}

	public void method_5(int position)
	{
		int_56 = -1;
		int_2 = int_55;
		int_3 = GClass39.int_11;
		int_0 = 0;
		int_1 = 0;
		int_4 = 24;
		UrRyYhZnVy = position;
		if (position != 0)
		{
			if (position == 1)
			{
				int_59 = int_2 - 4;
				int_57 = GClass39.int_10 - int_59;
				int_58 = 80;
				int_60 = int_3 - 96;
				int_0 = int_57 - 2;
				int_15 = -(GClass39.int_10 + int_2);
				int_14 = GClass39.int_10 - int_2;
			}
		}
		else
		{
			int_57 = 2;
			int_58 = 80;
			int_59 = int_2 - 4;
			int_60 = int_3 - 96;
			int_15 = int_59;
			int_14 = 0;
			int_0 = 0;
		}
		int_5 = int_2 / 5 - 1;
		int_29 = 0;
		string_2 = string_17[int_28];
		if (string_2.Length < 5)
			int_5 += 5;
		int_30 = int_57 + int_59 / 2 - string_2.Length * int_5 / 2;
		int_42 = new int[string_2.Length];
		int_13 = new int[string_2.Length];
		for (int i = 0; i < string_2.Length; i++)
		{
			int_42[i] = (GClass39.bool_5 ? (-1) : 0);
		}
		if (int_31[int_28] != -1)
			int_29 = int_31[int_28];
		if (int_29 < 0)
			int_29 = 0;
		if (int_29 > string_2.Length - 1)
			int_29 = string_2.Length - 1;
		gclass105_0 = null;
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
		int_15 = int_59;
		int_14 = 0;
	}

	public void method_8()
	{
		if (!GClass154.smethod_8().method_3() && bool_20)
		{
			if (GClass23.smethod_0(2, 0))
			{
				GClass23.bool_2 = true;
				GClass154.gclass210_0.method_7(mResources.go_to_quest, 0);
			}
			if (GClass23.smethod_0(3, 0))
				GClass23.bool_4 = true;
			int_28 = 4;
			string_2 = string_17[int_28];
			int_30 = int_57 + int_59 / 2 - string_2.Length * int_5 / 2;
			int_14 = 0;
			int_15 = 0;
			method_89();
		}
	}

	public void method_9()
	{
		int_41 = GClass58.smethod_1().gclass79_0.Length;
		method_5(0);
		int_28 = 9;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	public void method_10()
	{
		int_28 = 17;
		method_5(1);
		method_14();
		int_56 = 2;
		int_29 = 0;
	}

	public void method_11()
	{
		int_41 = dictionary_0.Count;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		int_41 = GClass58.smethod_1().gclass121_3[4].Length;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	public void method_15()
	{
		int_28 = 7;
		method_5(1);
		method_88();
		int_29 = 0;
	}

	public void method_16(GClass43 info)
	{
		gclass63_3.method_10(info, 0);
		if (gclass63_3.method_2() > 20)
			gclass63_3.method_7(gclass63_3.method_2() - 1);
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

	public void method_20(GClass14 pm)
	{
		gclass63_4.method_0(pm);
	}

	public void method_21()
	{
		int_4 = 24;
		int_41 = gclass63_4.method_2();
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	public void method_22()
	{
		int_28 = 18;
		method_5(0);
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		method_23();
	}

	public void method_23()
	{
		int_41 = gclass63_10.method_2();
		int_11 = int_41 * int_4 - int_60;
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
		if (int_66 > int_41 - 1)
			int_66 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_24(GClass58 c)
	{
		int_28 = 10;
		method_5(0);
		method_21();
		gclass58_0 = c;
	}

	public void method_25()
	{
		int_28 = 11;
		method_5(0);
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		method_29();
	}

	public void method_26()
	{
		int_28 = 16;
		method_5(0);
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		method_30();
	}

	public void method_27(sbyte t)
	{
		int_28 = 15;
		method_5(0);
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		method_28();
		bool_7 = ((t != 0) ? true : false);
	}

	public void method_28()
	{
		int_41 = gclass63_8.method_2();
		int_11 = int_41 * int_4 - int_60;
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
		if (int_66 > int_41 - 1)
			int_66 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_29()
	{
		int_41 = gclass63_5.method_2();
		int_11 = int_41 * int_4 - int_60;
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
		if (int_66 > int_41 - 1)
			int_66 = int_41 - 1;
		num = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public void method_30()
	{
		int_41 = gclass63_9.method_2();
		int_11 = int_41 * int_4 - int_60;
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
		if (int_66 > int_41 - 1)
			int_66 = int_41 - 1;
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
		int_56 = typeShop;
	}

	public void method_34()
	{
		int_28 = 2;
		if (GClass39.int_10 > 2 * int_55)
			string_11 = new string[1][] { mResources.chestt };
		else
			string_11 = new string[2][]
			{
				mResources.chestt,
				mResources.inventory
			};
		string_17[2] = string_11;
		method_5(0);
		if (int_29 == 0)
			method_86();
		if (int_29 == 1)
			method_88();
		if (GClass39.int_10 > 2 * int_55)
		{
			GClass39.gclass45_1 = new GClass45();
			GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
			GClass39.gclass45_1.method_15();
			GClass39.gclass45_1.method_50();
		}
	}

	public void method_35()
	{
		int_28 = 12;
		if (GClass39.int_10 > 2 * int_55)
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
		if (GClass39.int_10 > 2 * int_55)
		{
			GClass39.gclass45_1 = new GClass45();
			GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
			GClass39.gclass45_1.method_15();
			GClass39.gclass45_1.method_50();
		}
		sbyte_7 = -1;
		bool_29 = true;
	}

	public void method_36()
	{
		int_41 = gclass63_0.method_2() + 1;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		if (GClass39.gclass45_1 != null)
			string_16 = mResources.petMainTab2;
		else
			string_16 = mResources.petMainTab;
		string_17[21] = string_16;
		if (GClass58.smethod_1().int_14 == 1)
			string_22 = new string[6]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion,
				mResources.fusionForever
			};
		else
			string_22 = new string[5]
			{
				mResources.follow,
				mResources.defend,
				mResources.attack,
				mResources.gohome,
				mResources.fusion
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
			if (string_3.Length == 4)
				method_77();
			else
				method_79();
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

	public void method_42(GClass121 item)
	{
		try
		{
			gclass70_0 = new GClass70();
			string empty = string.Empty;
			string text = string.Empty;
			if (item.gclass118_0.sbyte_1 != GClass58.smethod_1().int_14)
			{
				if (item.gclass118_0.sbyte_1 == 0)
					text = text + "\n|7|1|" + mResources.from_earth;
				else if (item.gclass118_0.sbyte_1 == 1)
				{
					text = text + "\n|7|1|" + mResources.from_namec;
				}
				else if (item.gclass118_0.sbyte_1 == 2)
				{
					text = text + "\n|7|1|" + mResources.from_sayda;
				}
			}
			string text2 = string.Empty;
			if (item.gclass20_0 != null)
			{
				for (int i = 0; i < item.gclass20_0.Length; i++)
				{
					if (item.gclass20_0[i].gclass114_0.int_0 == 72)
						text2 = " [+" + item.gclass20_0[i].int_0 + "]";
				}
			}
			bool flag = false;
			if (item.gclass20_0 != null)
			{
				for (int j = 0; j < item.gclass20_0.Length; j++)
				{
					if (item.gclass20_0[j].gclass114_0.int_0 == 41)
					{
						flag = true;
						if (item.gclass20_0[j].int_0 == 1)
							text = text + "|0|1|" + item.gclass118_0.string_0 + text2;
						if (item.gclass20_0[j].int_0 == 2)
							text = text + "|2|1|" + item.gclass118_0.string_0 + text2;
						if (item.gclass20_0[j].int_0 == 3)
							text = text + "|8|1|" + item.gclass118_0.string_0 + text2;
						if (item.gclass20_0[j].int_0 == 4)
							text = text + "|7|1|" + item.gclass118_0.string_0 + text2;
					}
				}
			}
			if (!flag)
				text = text + "|0|1|" + $"[{item.gclass118_0.short_0}] {item.gclass118_0.string_0}{text2}";
			if (item.gclass20_0 != null)
			{
				for (int k = 0; k < item.gclass20_0.Length; k++)
				{
					if (item.gclass20_0[k].gclass114_0.string_0.StartsWith("$") ? true : false)
					{
						empty = item.gclass20_0[k].method_2();
						if (item.gclass20_0[k].int_0 == 1)
							text = text + "\n|1|1|" + empty;
						if (item.gclass20_0[k].int_0 == 0)
							text = text + "\n|0|1|" + empty;
						continue;
					}
					empty = item.gclass20_0[k].method_0();
					if (!empty.Equals(string.Empty) && item.gclass20_0[k].gclass114_0.int_0 != 72)
					{
						if (item.gclass20_0[k].gclass114_0.int_0 == 102)
						{
							gclass70_0.sbyte_0 = (sbyte)item.gclass20_0[k].int_0;
							GClass56.smethod_8("STAR SLOT= " + gclass70_0.sbyte_0);
						}
						else if (item.gclass20_0[k].gclass114_0.int_0 == 107)
						{
							gclass70_0.sbyte_1 = (sbyte)item.gclass20_0[k].int_0;
							GClass56.smethod_8("STAR SLOT= " + gclass70_0.sbyte_1);
						}
						else
						{
							text = text + "\n|1|1|" + empty;
						}
					}
				}
			}
			if (gclass121_0.gclass118_0.int_2 > 1)
			{
				string text3 = mResources.pow_request + ": " + gclass121_0.gclass118_0.int_2;
				if (gclass121_0.gclass118_0.int_2 > GClass58.smethod_1().long_2)
				{
					string text4 = text + "\n|3|1|" + text3;
					text = text4 + "\n|3|1|" + mResources.your_pow + ": " + GClass58.smethod_1().long_2;
				}
				else
					text = text + "\n|6|1|" + text3;
			}
			else
				text += "\n|6|1|";
			gclass121_0.int_43 = method_131(gclass121_0);
			text = string.Concat(text + "\n--", "\n|6|", item.gclass118_0.string_2);
			if (!item.string_2.Equals(string.Empty))
			{
				if (!item.gclass118_0.string_2.Equals(string.Empty))
					text += "\n--";
				text = text + "\n|2|" + item.string_2;
			}
			if (gclass70_0.sbyte_1 > 0)
				text += "\n\n";
			method_43(gclass70_0, text);
			int_61 = item.gclass118_0.short_1;
			int_62 = null;
			gclass58_1 = null;
		}
		catch (Exception ex)
		{
			GClass56.smethod_8("ex " + ex.StackTrace);
		}
	}

	public void method_43(GClass70 cp, string chat)
	{
		cp.bool_3 = false;
		cp.int_0 = 180;
		cp.int_3 = 3 + int_0 - ((int_0 != 0) ? (GClass56.smethod_28(cp.int_0 - int_2) + 8) : 0);
		cp.string_0 = GClass49.gclass49_17.method_15(chat, cp.int_0 - 10);
		cp.int_1 = 10000000;
		cp.gclass59_0 = null;
		cp.int_2 = 7;
		cp.int_5 = 15 - cp.int_2 + cp.string_0.Length * 12 + 10;
		if (cp.int_5 > GClass39.int_11 - 80)
		{
			cp.int_5 = GClass39.int_11 - 80;
			cp.int_8 = cp.string_0.Length * 12 - cp.int_5 + 17;
			if (cp.int_8 < 0)
				cp.int_8 = 0;
			GClass70.int_21 = 0;
			cp.bool_3 = true;
		}
		cp.int_4 = GClass39.gclass0_0.int_2 - cp.int_5;
		while (cp.int_4 < 10)
		{
			cp.int_4++;
			GClass39.gclass0_0.int_2++;
		}
		cp.int_10 = 0;
		cp.int_19 = 10;
	}

	public void method_44(GClass70 cp, string[] chat)
	{
		cp.int_0 = 160;
		cp.int_3 = 3 + int_0;
		cp.string_0 = chat;
		cp.int_1 = 10000000;
		cp.gclass59_0 = null;
		cp.int_2 = 7;
		cp.int_5 = 15 - cp.int_2 + cp.string_0.Length * 12 + 10;
		cp.int_4 = GClass39.gclass0_0.int_2 - cp.int_5;
		cp.int_10 = 0;
		cp.int_19 = 10;
	}

	public void method_45(GClass62 cm)
	{
		gclass70_0 = new GClass70();
		string text = string.Concat("|0|" + cm.string_0, "\n|1|", GClass206.smethod_0(cm.sbyte_1));
		for (int i = 0; i < gclass63_2.method_2(); i++)
		{
			GClass206 gClass = (GClass206)gclass63_2.method_3(i);
			if (cm.int_2 == gClass.int_0)
			{
				string text2 = text;
				text2 = text2 + "\n|5|" + mResources.clan_capsuledonate + ": " + gClass.int_4;
				text2 = text2 + "\n|5|" + mResources.clan_capsuleself + ": " + gClass.int_3;
				text2 = text2 + "\n|4|" + mResources.give_pea + ": " + gClass.int_1 + mResources.time;
				text = text2 + "\n|4|" + mResources.receive_pea + ": " + gClass.int_2 + mResources.time;
				int_62 = new int[3] { gClass.short_0, gClass.short_2, gClass.short_3 };
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
		method_43(gclass70_0, text);
		gclass58_1 = null;
	}

	public void method_46(GClass8 t)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + t.string_0, "\n|1|Top ", t.int_3.ToString()), "\n|1|", t.string_1), "\n|2|", t.string_2);
		gclass70_0 = new GClass70();
		method_43(gclass70_0, chat);
		int_62 = new int[3] { t.int_0, t.short_1, t.short_0 };
		gclass121_0 = null;
		gclass58_1 = null;
	}

	public void method_47(GClass206 m)
	{
		string text = "|0|1|" + m.string_0;
		string text2 = "\n|2|1|";
		if (m.sbyte_0 == 0)
			text2 = "\n|7|1|";
		if (m.sbyte_0 == 1)
			text2 = "\n|1|1|";
		if (m.sbyte_0 == 2)
			text2 = "\n|0|1|";
		string text3 = text + text2 + GClass206.smethod_0(m.sbyte_0);
		text3 = string.Concat(text3 + "\n|2|1|" + mResources.power + ": " + m.string_1, "\n--");
		text3 = text3 + "\n|5|" + mResources.clan_capsuledonate + ": " + m.int_4;
		text3 = text3 + "\n|5|" + mResources.clan_capsuleself + ": " + m.int_3;
		text3 = text3 + "\n|4|" + mResources.give_pea + ": " + m.int_1 + mResources.time;
		text3 = text3 + "\n|4|" + mResources.receive_pea + ": " + m.int_2 + mResources.time;
		text = text3 + "\n|6|" + mResources.join_date + ": " + m.string_2;
		gclass70_0 = new GClass70();
		method_43(gclass70_0, text);
		int_62 = new int[3] { m.short_0, m.short_2, m.short_3 };
		gclass121_0 = null;
		gclass58_1 = null;
	}

	public void method_48(GClass21 cl)
	{
		try
		{
			string text = "|0|" + cl.string_0;
			string[] array = GClass49.gclass49_19.method_15(cl.string_1, int_59 - 60);
			for (int i = 0; i < array.Length; i++)
			{
				text = text + "\n|2|" + array[i];
			}
			string text2 = text + "\n--";
			text2 = text2 + "\n|7|" + mResources.clan_leader + ": " + cl.string_3;
			text2 = text2 + "\n|1|" + mResources.power_point + ": " + cl.string_2;
			text2 = text2 + "\n|4|" + mResources.member + ": " + cl.int_3 + "/" + cl.int_4;
			text2 = text2 + "\n|4|" + mResources.level + ": " + cl.int_6;
			text = text2 + "\n|4|" + mResources.clan_birthday + ": " + GClass95.smethod_6(cl.int_2);
			gclass70_0 = new GClass70();
			method_43(gclass70_0, text);
			int_61 = GClass137.smethod_1((short)cl.int_1).short_0[0];
			gclass121_0 = null;
		}
		catch (Exception ex)
		{
			GClass56.smethod_8("Throw  exception " + ex.StackTrace);
		}
	}

	public void method_49(GClass53 tp, GClass74 skill, GClass74 nextSkill)
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
			text2 = string.Concat(text2 + "\n|2|" + mResources.cap_do + ": " + skill.int_0, "\n|5|", GClass95.smethod_4(tp.string_2, "#", skill.short_1 + string.Empty));
			text2 = text2 + "\n|5|" + mResources.KI_consume + skill.int_5 + ((tp.int_2 != 1) ? string.Empty : "%");
			text = string.Concat(text2 + "\n|5|" + mResources.cooldown + ": " + skill.method_1() + "s", "\n--");
			if (skill.int_0 == tp.int_1)
				text = text + "\n|0|" + mResources.max_level_reach;
			else
			{
				if (!skill.gclass53_0.method_3())
				{
					text2 = text;
					text = text2 + "\n|1|" + mResources.next_level_require + GClass56.smethod_31(nextSkill.long_0) + " " + mResources.potential;
				}
				text = text + "\n|4|" + GClass95.smethod_4(tp.string_2, "#", nextSkill.short_1 + string.Empty);
			}
		}
		else
		{
			string text3 = text + "\n|2|" + mResources.not_learn;
			text3 = string.Concat(text3 + "\n|1|" + mResources.learn_require + GClass56.smethod_31(nextSkill.long_0) + " " + mResources.potential, "\n|4|", GClass95.smethod_4(tp.string_2, "#", nextSkill.short_1 + string.Empty));
			text3 = text3 + "\n|4|" + mResources.KI_consume + nextSkill.int_5 + ((tp.int_2 != 1) ? string.Empty : "%");
			text = text3 + "\n|4|" + mResources.cooldown + ": " + nextSkill.method_1() + "s";
		}
		gclass121_0 = null;
		int_62 = null;
		gclass58_1 = null;
		gclass70_0 = new GClass70();
		method_43(gclass70_0, text);
		int_61 = 0;
	}

	public void method_50()
	{
		if (GClass39.bool_5)
		{
			gclass14_1.int_1 = 156;
			gclass14_1.int_2 = 3;
		}
		else
		{
			gclass14_1.int_1 = GClass39.int_10 - 19;
			gclass14_1.int_2 = GClass39.int_11 - 19;
		}
		gclass14_1.bool_1 = false;
		GClass70.gclass70_0 = null;
		GClass57.smethod_5();
		int_63 = 20;
		bool_0 = true;
		bool_21 = false;
		GClass29.smethod_1().method_33();
		if (method_212())
			GClass58.smethod_1().method_134();
	}

	public void method_51()
	{
		if (gclass7_0 != null && gclass7_0.bool_0)
		{
			if (gclass7_0.gclass14_0 != null && (GClass39.bool_11[12] || GClass145.smethod_1(gclass7_0.gclass14_0)) && gclass7_0.gclass14_0 != null)
				gclass7_0.gclass14_0.method_1();
			if (gclass7_0.gclass14_2 != null && (GClass39.bool_11[13] || GClass145.smethod_1(gclass7_0.gclass14_2)) && gclass7_0.gclass14_2 != null)
				gclass7_0.gclass14_2.method_1();
			if (gclass7_0.gclass14_3 != null && (GClass39.bool_11[(!Main.isPC) ? 5 : 25] || GClass145.smethod_1(gclass7_0.gclass14_3)) && gclass7_0.gclass14_3 != null)
				gclass7_0.gclass14_3.method_1();
			if (gclass7_0.bool_0 && GClass39.int_71 != 0)
			{
				gclass7_0.method_2(GClass39.int_71);
				GClass39.int_71 = 0;
			}
			GClass39.smethod_27();
			GClass39.smethod_26();
		}
	}

	public void method_52()
	{
		if ((gclass7_0 != null && gclass7_0.bool_0) || !GClass39.gclass45_0.bool_29 || GClass57.bool_0)
			return;
		if (gclass141_0 != null && gclass141_0.bool_0)
			gclass141_0.method_8();
		else
		{
			if (bool_21 || !bool_0)
				return;
			if (gclass14_1.method_4())
			{
				gclass14_1.method_1();
				return;
			}
			if (GClass39.bool_11[13])
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
			if (GClass39.bool_11[12] || GClass39.bool_11[(!Main.isPC) ? 5 : 25])
			{
				if (gclass14_0.int_0 > 0)
					perform(gclass14_0.int_0, gclass14_0.object_0);
				else
					oTwynfpuwh = 2;
			}
			if (Equals(GClass39.gclass45_0) && GClass39.gclass45_1 == null && GClass39.bool_16 && !GClass39.smethod_48(int_0, int_1, int_2, int_3) && !bool_13)
			{
				method_151();
				return;
			}
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
					GClass39.smethod_26();
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
				GClass39.smethod_26();
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
				if (int_29 < string_2.Length - ((GClass39.gclass45_1 == null) ? 1 : 0) && int_28 != 17)
					method_72();
				else if (int_56 == 0)
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
			GClass39.smethod_27();
			for (int i = 0; i < GClass39.bool_11.Length; i++)
			{
				GClass39.bool_11[i] = false;
			}
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
			if (Equals(GClass39.gclass45_0))
				method_218();
			if (Equals(GClass39.gclass45_1))
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
		int_41 = ((!isMe) ? (gclass63_7.method_2() + 3) : (gclass63_6.method_2() + 3));
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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

	public void method_62(GClass58 cGD)
	{
		int_28 = 13;
		string_17[int_28] = string_15;
		bool_3 = false;
		bool_1 = false;
		bool_2 = false;
		gclass63_6.method_9();
		gclass63_7.method_9();
		int_22 = 0;
		int_23 = 0;
		if (GClass39.int_10 > 2 * int_55)
		{
			GClass39.gclass45_1 = new GClass45();
			GClass39.gclass45_1.int_28 = 13;
			GClass39.gclass45_1.string_17[int_28] = new string[1][] { mResources.item_receive };
			GClass39.gclass45_1.method_5(1);
			GClass39.gclass45_1.method_61(false);
			GClass39.gclass45_0.string_17[int_28] = new string[2][]
			{
				mResources.inventory,
				mResources.item_give
			};
			GClass39.gclass45_1.method_50();
			GClass39.gclass45_1.gclass58_0 = cGD;
		}
		if (Equals(GClass39.gclass45_0))
			method_5(0);
		if (int_29 == 0)
			method_88();
		if (int_29 == 1)
			method_61(true);
		if (int_29 == 2)
			method_61(false);
		gclass58_0 = cGD;
	}

	private void method_63(GClass76 gclass76_0, bool bool_31)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		GClass63 gClass = ((!bool_31) ? gclass63_7 : gclass63_6);
		int num = 0;
		while (true)
		{
			if (num < int_41)
			{
				int num2 = int_57 + 36;
				int num3 = int_58 + num * int_4;
				int w = int_59 - 36;
				int num4 = int_4 - 1;
				int num5 = int_57;
				int num6 = int_58 + num * int_4;
				int num7 = 34;
				int num8 = int_4 - 1;
				if (num3 - int_8 <= int_58 + int_60 && num3 - int_8 >= int_58 - int_4)
				{
					if (num == int_41 - 1)
					{
						if (bool_31)
						{
							gclass76_0.method_16(15196114);
							gclass76_0.method_15(num5, num3, int_59, num4);
							if (!bool_1)
							{
								if (!bool_2)
									GClass49.gclass49_16.method_6(gclass76_0, mResources.opponent + mResources.not_lock_trade, int_57 + int_59 / 2, num3 + num4 / 2 - 4, GClass49.int_2);
								else
									GClass49.gclass49_16.method_6(gclass76_0, mResources.opponent + mResources.locked_trade, int_57 + int_59 / 2, num3 + num4 / 2 - 4, GClass49.int_2);
							}
							else if (bool_2)
							{
								gclass76_0.method_16(15196114);
								gclass76_0.method_15(num5, num3, int_59, num4);
								gclass76_0.method_31((num != int_66) ? GClass154.gclass2_24 : GClass154.gclass2_25, int_57 + int_59 - 5, num3 + 2, GClass169.int_2);
								((num != int_66) ? GClass49.gclass49_6 : GClass49.gclass49_7).method_6(gclass76_0, mResources.done, int_57 + int_59 - 22, num3 + 7, 2);
								GClass49.gclass49_16.method_6(gclass76_0, mResources.opponent + mResources.locked_trade, int_57 + 5, num3 + num4 / 2 - 4, GClass49.int_0);
							}
							else
							{
								GClass49.gclass49_16.method_6(gclass76_0, mResources.opponent + mResources.not_lock_trade, int_57 + int_59 / 2, num3 + num4 / 2 - 4, GClass49.int_2);
							}
						}
					}
					else if (num == int_41 - 2)
					{
						if (bool_31)
						{
							gclass76_0.method_16(15196114);
							gclass76_0.method_15(num5, num3, int_59, num4);
							if (!bool_3)
							{
								if (!bool_1)
								{
									gclass76_0.method_31((num != int_66) ? GClass154.gclass2_24 : GClass154.gclass2_25, int_57 + int_59 - 5, num3 + 2, GClass169.int_2);
									((num != int_66) ? GClass49.gclass49_6 : GClass49.gclass49_7).method_6(gclass76_0, mResources.mlock, int_57 + int_59 - 22, num3 + 7, 2);
									GClass49.gclass49_16.method_6(gclass76_0, mResources.you + mResources.not_lock_trade, int_57 + 5, num3 + num4 / 2 - 4, GClass49.int_0);
								}
								else
								{
									gclass76_0.method_31((num != int_66) ? GClass154.gclass2_24 : GClass154.gclass2_25, int_57 + int_59 - 5, num3 + 2, GClass169.int_2);
									((num != int_66) ? GClass49.gclass49_6 : GClass49.gclass49_7).method_6(gclass76_0, mResources.CANCEL, int_57 + int_59 - 22, num3 + 7, 2);
									GClass49.gclass49_16.method_6(gclass76_0, mResources.you + mResources.locked_trade, int_57 + 5, num3 + num4 / 2 - 4, GClass49.int_0);
								}
							}
						}
						else if (!bool_2)
						{
							GClass49.gclass49_6.method_6(gclass76_0, mResources.not_lock_trade_upper, int_57 + int_59 / 2, num3 + num4 / 2 - 4, GClass49.int_2);
						}
						else
						{
							GClass49.gclass49_6.method_6(gclass76_0, mResources.locked_trade_upper, int_57 + int_59 / 2, num3 + num4 / 2 - 4, GClass49.int_2);
						}
					}
					else if (num == int_41 - 3)
					{
						if (bool_1)
							gclass76_0.method_16(13748667);
						else
							gclass76_0.method_16((num != int_66) ? 15196114 : 16383818);
						gclass76_0.method_15(num2, num3, w, num4);
						if (bool_1)
							gclass76_0.method_16(13748667);
						else
							gclass76_0.method_16((num != int_66) ? 9993045 : 7300181);
						gclass76_0.method_15(num5, num6, num7, num8);
						gclass76_0.method_31(gclass2_7, num5 + num7 / 2, num6 + num8 / 2, 3);
						GClass49.gclass49_14.method_6(gclass76_0, GClass95.smethod_9((!bool_31) ? int_23 : int_22) + " " + mResources.XU, num2 + 5, num3 + 11, 0);
						GClass49.gclass49_19.method_6(gclass76_0, mResources.money_trade, num2 + 5, num3, 0);
					}
					else
					{
						if (gClass.method_2() == 0)
							break;
						if (bool_1)
							gclass76_0.method_16(13748667);
						else
							gclass76_0.method_16((num != int_66) ? 15196114 : 16383818);
						gclass76_0.method_15(num2, num3, w, num4);
						if (bool_1)
							gclass76_0.method_16(13748667);
						else
							gclass76_0.method_16((num != int_66) ? 9993045 : 9541120);
						GClass121 gClass2 = (GClass121)gClass.method_3(num);
						if (gClass2 != null)
						{
							for (int i = 0; i < gClass2.gclass20_0.Length; i++)
							{
								if (gClass2.gclass20_0[i].gclass114_0.int_0 != 72 || gClass2.gclass20_0[i].int_0 <= 0)
									continue;
								sbyte id = smethod_5(gClass2.gclass20_0[i].int_0);
								if (smethod_4(id) != -1)
								{
									if (bool_1)
										gclass76_0.method_16(13748667);
									else
										gclass76_0.method_16((num != int_66) ? smethod_4(id) : smethod_4(id));
								}
							}
						}
						gclass76_0.method_15(num5, num6, num7, num8);
						if (gClass2 != null)
						{
							string text = string.Empty;
							GClass49 gClass3 = GClass49.gclass49_14;
							if (gClass2.gclass20_0 != null)
							{
								for (int j = 0; j < gClass2.gclass20_0.Length; j++)
								{
									if (gClass2.gclass20_0[j].gclass114_0.int_0 == 72)
										text = " [+" + gClass2.gclass20_0[j].int_0 + "]";
									if (gClass2.gclass20_0[j].gclass114_0.int_0 == 41)
									{
										if (gClass2.gclass20_0[j].int_0 == 1)
											gClass3 = smethod_6(0);
										else if (gClass2.gclass20_0[j].int_0 == 2)
										{
											gClass3 = smethod_6(2);
										}
										else if (gClass2.gclass20_0[j].int_0 == 3)
										{
											gClass3 = smethod_6(8);
										}
										else if (gClass2.gclass20_0[j].int_0 == 4)
										{
											gClass3 = smethod_6(7);
										}
									}
								}
							}
							gClass3.method_6(gclass76_0, gClass2.gclass118_0.string_0 + text, num2 + 5, num3 + 1, 0);
							string text2 = string.Empty;
							string text3 = string.Empty;
							if (gClass2.gclass20_0 != null)
							{
								if (gClass2.gclass20_0.Length != 0 && gClass2.gclass20_0[0] != null)
									text2 += gClass2.gclass20_0[0].method_0();
								GClass49 gClass4 = GClass49.gclass49_18;
								if (gClass2.int_43 < 0 && gClass2.gclass118_0.sbyte_0 != 5)
									gClass4 = GClass49.gclass49_17;
								if (gClass2.gclass20_0.Length > 1)
								{
									for (int k = 1; k < gClass2.gclass20_0.Length; k++)
									{
										if (gClass2.gclass20_0[k] == null || gClass2.gclass20_0[k].gclass114_0.int_0 == 102 || gClass2.gclass20_0[k].gclass114_0.int_0 == 107)
											continue;
										try
										{
											int num9 = k;
											sbyte language = mResources.language;
											if (language != 0)
											{
												if (language != 1)
													continue;
												int num10 = gClass2.gclass20_0[num9].gclass114_0.int_0;
												if (num10 <= 81)
												{
													if (num10 != 50)
													{
														switch (num10)
														{
														case 77:
															text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + " HP";
															break;
														case 80:
															text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP") : ("Heal " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP"));
															break;
														case 81:
															text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI") : ("Heal " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " MP"));
															break;
														case 78:
														case 79:
															break;
														}
													}
													else
														text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " SĐ" : " DMG");
													continue;
												}
												switch (num10)
												{
												case 94:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[2] + ((GClass192.int_0 == 0) ? " Giáp" : " AMR");
													continue;
												case 95:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HM" : " BS");
													continue;
												case 96:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HK" : " MS");
													continue;
												case 97:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " PST" : " CD");
													continue;
												case 101:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " TNSM" : " Power,SP");
													continue;
												case 103:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " KI" : " MP");
													continue;
												case 98:
												case 99:
												case 100:
												case 102:
													continue;
												}
												if (num10 == 108)
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " Né đòn" : " Dodge");
												continue;
											}
											int num11 = gClass2.gclass20_0[num9].gclass114_0.int_0;
											if (num11 <= 81)
											{
												if (num11 != 50)
												{
													switch (num11)
													{
													case 77:
														text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + " HP";
														break;
													case 80:
														text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + "Hồi " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP";
														break;
													case 81:
														text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + "Hồi " + gClass2.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI";
														break;
													case 78:
													case 79:
														break;
													}
												}
												else
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + " SĐ";
												continue;
											}
											switch (num11)
											{
											case 94:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + " Giáp";
												continue;
											case 95:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + " HM";
												continue;
											case 96:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + " HK";
												continue;
											case 97:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[1] + " PST";
												continue;
											case 101:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[0] + " TNSM";
												continue;
											case 103:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split('+')[1] + " KI";
												continue;
											case 98:
											case 99:
											case 100:
											case 102:
												continue;
											}
											if (num11 == 108)
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass2.gclass20_0[num9].method_0().Split(' ')[0] + " Né đòn";
										}
										catch
										{
										}
									}
								}
								gClass4.method_6(gclass76_0, text2, num2 + 5, num3 + 11, GClass49.int_0);
							}
							GClass96.smethod_6(gclass76_0, gClass2.gclass118_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
							GClass49.gclass49_18.method_10(gclass76_0, text3, int_57 + int_59 - 2, int_58 + num * int_4 + 11, GClass49.int_1, GClass49.gclass49_20);
							if (gClass2.gclass20_0 != null)
							{
								for (int l = 0; l < gClass2.gclass20_0.Length; l++)
								{
									method_214(gclass76_0, gClass2.gclass20_0[l].gclass114_0.int_0, gClass2.gclass20_0[l].int_0, num5, num6, num7, num8);
								}
								for (int m = 0; m < gClass2.gclass20_0.Length; m++)
								{
									method_215(gclass76_0, gClass2.gclass20_0[m].gclass114_0.int_0, gClass2.gclass20_0[m].int_0, num5, num6, num7, num8);
								}
								for (int n = 0; n < gClass2.gclass20_0.Length; n++)
								{
									string text4 = string.Empty;
									if (gClass2.gclass20_0[n].int_0 > 0 && gClass2.gclass20_0[n].gclass114_0.int_0 == 107)
										text4 = gClass2.gclass20_0[n].int_0.ToString();
									if (text4 != string.Empty)
									{
										GClass193.smethod_0().method_2(GClass49.gclass49_3, gclass76_0, text4, 160, int_58 + num * int_4, 0, GClass49.gclass49_2);
										gclass76_0.method_33(gclass2_3, 165, int_58 + num * int_4 + 1);
									}
								}
							}
							if (gClass2.int_30 > 1)
								GClass49.gclass49_15.method_6(gclass76_0, string.Empty + gClass2.int_30, num5 + num7, num6 + num8 - GClass49.gclass49_15.method_20(), 1);
						}
					}
				}
				num++;
				continue;
			}
			method_100(gclass76_0);
			break;
		}
	}

	private void method_64()
	{
		if (GClass39.bool_13[(!Main.isPC) ? 2 : 21])
		{
			PuasEdRyOO -= 5;
			int_18 = PuasEdRyOO - (int_58 + int_60 / 2);
			if (PuasEdRyOO < int_58)
				PuasEdRyOO = int_58;
		}
		if (GClass39.bool_13[(!Main.isPC) ? 8 : 22])
		{
			PuasEdRyOO += 5;
			int_18 = PuasEdRyOO - (int_58 + int_60 / 2);
			if (PuasEdRyOO > int_58 + 200)
				PuasEdRyOO = int_58 + 200;
		}
		if (GClass39.bool_13[(!Main.isPC) ? 4 : 23])
		{
			int_145 -= 5;
			int_17 = int_145 - int_59 / 2;
			if (int_145 < 16)
				int_145 = 16;
		}
		if (GClass39.bool_13[(!Main.isPC) ? 6 : 24])
		{
			int_145 += 5;
			int_17 = int_145 - int_59 / 2;
			if (int_145 > 250)
				int_145 = 250;
		}
		if (GClass39.bool_14)
		{
			bool_13 = true;
			if (!bool_5)
			{
				int_24 = int_17;
				int_25 = int_18;
				bool_5 = true;
			}
			int_17 = int_24 + (GClass39.int_4 - GClass39.int_0);
			int_18 = int_25 + (GClass39.int_5 - GClass39.int_1);
		}
		if (GClass39.bool_16)
		{
			bool_5 = false;
			GClass39.int_4 = GClass39.int_0;
			GClass39.int_5 = GClass39.int_1;
			int_26 = GClass39.int_4 + int_17;
			int_27 = GClass39.int_5 + int_18;
		}
		if (GClass39.bool_15)
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
			int_101 = -1;
			if (int_66 == gclass63_0.method_2() && GClass39.bool_15)
			{
				GClass39.bool_15 = false;
				int_101 = 1;
			}
		}
		if (int_29 == 1)
			method_72();
	}

	private void method_66()
	{
		if (GClass39.bool_13[(!Main.isPC) ? 2 : 21])
			int_21 -= 5;
		if (GClass39.bool_13[(!Main.isPC) ? 8 : 22])
			int_21 += 5;
		if (int_21 < 0)
			int_21 = 0;
		int num = int_132 * 12 - (int_60 - 60);
		if (num < 0)
			num = 0;
		if (int_21 > num)
			int_21 = num;
		if (gclass105_0 != null)
		{
			if (!GClass39.bool_5)
				gclass105_0.int_3 = int_21;
			gclass105_0.method_1();
		}
		int num2 = int_57 + int_59 / 2 - 35;
		int num3 = ((GClass39.int_11 <= 300) ? 15 : 20);
		int num4 = int_58 + int_60 - num3 - 15;
		int num5 = GClass39.int_0;
		int num6 = GClass39.int_1;
		int_102 = -1;
		if (bool_20 && !GClass154.smethod_8().method_2() && num5 >= num2 && num5 <= num2 + 70 && num6 >= num4 && num6 <= num4 + 30 && (gclass105_0 == null || !gclass105_0.bool_0))
		{
			int_102 = 1;
			if (GClass39.bool_16)
			{
				GClass29.smethod_1().method_35();
				oTwynfpuwh = 2;
				GClass39.smethod_49();
			}
		}
	}

	private void method_67()
	{
		bool_9 = false;
		if (int_28 != 0 || string_3.Length != 5 || int_29 != 3)
			return;
		bool_9 = false;
		if (int_66 == 0)
		{
			int_32 = new int[string_19.Length];
			for (int i = 0; i < int_32.Length; i++)
			{
				int_32[i] = i;
			}
			if (!bool_12)
				bool_9 = true;
		}
		else if (int_66 != 1 && !bool_10 && int_66 > 0)
		{
			int_32 = new int[1];
			for (int j = 0; j < int_32.Length; j++)
			{
				int_32[j] = j;
			}
			bool_9 = true;
		}
	}

	private void method_68()
	{
		if (int_32 == null)
			return;
		if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
		{
			gclass62_0 = method_110();
			int_67--;
			if (int_66 == 0 && int_67 < 0)
				int_67 = int_32.Length - 1;
			if (int_66 > 1 && bool_11 && gclass62_0.string_2 != null && int_67 < 0)
				int_67 = gclass62_0.string_2.Length - 1;
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 6 : 24])
		{
			gclass62_0 = method_110();
			int_67++;
			if (int_66 == 0 && int_67 > int_32.Length - 1)
				int_67 = 0;
			if (int_66 > 1 && bool_11 && gclass62_0.string_2 != null && int_67 > gclass62_0.string_2.Length - 1)
				int_67 = 0;
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
			if (int_28 != 0 || int_29 != 3 || string_3.Length != 5 || int_66 == -1)
				return;
			int num = 0;
			if (int_66 == 0)
			{
				num = int_57 + int_59 / 2 - string_19.Length * int_5 / 2;
				int_67 = (GClass39.int_0 - num) / int_5;
			}
			else
			{
				gclass62_0 = method_110();
				if (gclass62_0 != null && gclass62_0.string_2 != null)
				{
					num = int_57 + int_59 - 2 - gclass62_0.string_2.Length * 40;
					int_67 = (GClass39.int_0 - num) / 40;
				}
			}
			if (GClass39.int_0 < num)
				int_67 = -1;
		}
		catch (Exception ex)
		{
			GClass56.smethod_8("Throw err " + ex.StackTrace);
		}
	}

	public void method_71(int a)
	{
		bool flag = false;
		if (GClass39.int_6 > int_59)
			return;
		if (int_103 == -1)
			int_103 = int_66;
		if (a > 0)
		{
			int_103 -= a;
			flag = true;
		}
		else if (a < 0)
		{
			int_103 += -a;
			flag = true;
		}
		if (int_103 < 0)
			int_103 = 0;
		if (flag)
		{
			int_7 = int_103 * 12;
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
		if (GClass39.bool_11[(!Main.isPC) ? 2 : 21])
		{
			flag = true;
			int_66--;
			if (int_28 == 24)
			{
				int_66 -= 2;
				if (int_66 < 0)
					int_66 = 0;
			}
			else if (int_66 < 0)
			{
				if (Equals(GClass39.gclass45_0) && int_56 == 2 && int_29 <= 3 && int_37[int_29] > 1)
				{
					GClass57.smethod_1();
					if (int_38[int_29] <= 0)
						GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_37[int_29] - 1, -1);
					else
						GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] - 1, -1);
					return;
				}
				int_66 = int_41 - 1;
				if (bool_9)
					int_66 = -1;
				if (sbyte_17 > 0)
					int_66 = -1;
			}
			int_42[int_29] = int_66;
			int_67 = 0;
			method_67();
		}
		else if (GClass39.bool_11[(!Main.isPC) ? 8 : 22])
		{
			flag = true;
			int_66++;
			if (int_28 == 24)
			{
				int_66 += 2;
				if (int_66 > int_41 - 1)
					int_66 = int_41 - 1;
			}
			else if (int_66 > int_41 - 1)
			{
				if (Equals(GClass39.gclass45_0) && int_56 == 2 && int_29 <= 3 && int_37[int_29] > 1)
				{
					GClass57.smethod_1();
					if (int_38[int_29] >= int_37[int_29] - 1)
						GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, 0, -1);
					else
						GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] + 1, -1);
					return;
				}
				int_66 = 0;
			}
			int_42[int_29] = int_66;
			int_67 = 0;
			method_67();
		}
		if (flag)
		{
			int_7 = int_66 * int_4 - int_60 / 2;
			if (int_7 > int_11)
				int_7 = int_11;
			if (int_7 < 0)
				int_7 = 0;
			int_8 = int_7;
		}
		if (GClass39.bool_14)
		{
			bool_16 = false;
			if (!bool_13 && GClass39.smethod_48(int_57, int_58, int_59, int_60))
			{
				for (int i = 0; i < int_97.Length; i++)
				{
					int_97[0] = GClass39.int_1;
				}
				int_96 = GClass39.int_1;
				bool_13 = true;
				bool_14 = int_98 != 0;
				int_98 = 0;
			}
			else if (bool_13)
			{
				int_95++;
				if (int_95 > 5 && int_96 == GClass39.int_1 && !bool_14)
				{
					int_96 = -1000;
					int_66 = (int_7 + GClass39.int_1 - int_58) / int_4;
					if (int_66 >= int_41)
						int_66 = -1;
					method_70();
				}
				else
					int_103 = -1;
				int num = GClass39.int_1 - int_97[0];
				if (num != 0 && int_66 != -1)
				{
					int_66 = -1;
					int_67 = -1;
				}
				for (int num2 = int_97.Length - 1; num2 > 0; num2--)
				{
					int_97[num2] = int_97[num2 - 1];
				}
				int_97[0] = GClass39.int_1;
				int_7 -= num;
				if (int_7 < 0)
					int_7 = 0;
				if (int_7 > int_11)
					int_7 = int_11;
				if (int_8 < 0 || int_8 > int_11)
					num /= 2;
				int_8 -= num;
				if (int_8 < -(GClass39.int_11 / 3))
					bool_15 = true;
				else
					bool_15 = false;
			}
		}
		if (!GClass39.bool_16 || !bool_13)
			return;
		bool_16 = true;
		int i2 = GClass39.int_1 - int_97[0];
		GClass39.bool_16 = false;
		if (GClass56.smethod_28(i2) < 20 && GClass56.smethod_28(GClass39.int_1 - int_96) < 20 && !bool_14)
		{
			int_98 = 0;
			int_7 = int_8;
			int_96 = -1000;
			int_66 = (int_7 + GClass39.int_1 - int_58) / int_4;
			if (int_66 >= int_41)
				int_66 = -1;
			method_70();
			int_95 = 0;
			oTwynfpuwh = 10;
			GClass29.smethod_1().method_40();
		}
		else if (int_66 != -1 && int_95 > 5)
		{
			int_95 = 0;
			oTwynfpuwh = 1;
		}
		else if (int_66 == -1 && !bool_14)
		{
			if (int_8 < 0)
				int_7 = 0;
			else if (int_8 > int_11)
			{
				int_7 = int_11;
			}
			else
			{
				int num3 = GClass39.int_1 - int_97[0] + (int_97[0] - int_97[1]) + (int_97[1] - int_97[2]);
				int_98 = -((num3 > 10) ? 10 : ((num3 < -10) ? (-10) : 0)) * 100;
			}
		}
		bool_13 = false;
		int_95 = 0;
		GClass39.bool_16 = false;
	}

	public string method_73(string[] str)
	{
		return null;
	}

	private void method_74()
	{
		if ((gclass105_0 != null && gclass105_0.bool_0) || bool_13)
			return;
		int num = int_29;
		if (method_216() && bool_30)
		{
			if (int_66 == -1)
			{
				if (GClass39.bool_11[6])
				{
					int_29++;
					if (int_29 >= string_2.Length)
					{
						if (GClass39.gclass45_1 != null)
						{
							int_29 = string_2.Length - 1;
							GClass39.bool_22 = true;
						}
						else
							int_29 = 0;
					}
					int_66 = int_42[int_29];
					int_31[int_28] = int_29;
				}
				if (GClass39.bool_11[4])
				{
					int_29--;
					if (int_29 < 0)
						int_29 = string_2.Length - 1;
					if (GClass39.bool_22)
						GClass39.bool_22 = false;
					int_66 = int_42[int_29];
					int_31[int_28] = int_29;
				}
			}
			else if (int_66 > 0)
			{
				if (GClass39.bool_11[8])
				{
					if (int_68 == 0)
						int_113++;
					else
						int_113 += 5;
				}
				else if (GClass39.bool_11[2])
				{
					if (int_68 == 0)
						int_113--;
					else
						int_113 -= 5;
				}
				else if (GClass39.bool_11[4])
				{
					if (int_68 == 0)
						int_113 -= 5;
					else
						int_113--;
				}
				else if (GClass39.bool_11[6])
				{
					if (int_68 == 0)
						int_113 += 5;
					else
						int_113++;
				}
			}
			if (int_113 < 0)
				;
			if (int_113 == int_105)
				int_113 = 0;
		}
		else if (!method_219())
		{
			if (GClass39.bool_11[(!Main.isPC) ? 6 : 24])
			{
				if (method_216())
				{
					if (int_66 >= 0)
						method_217();
					else
					{
						int_29++;
						if (int_29 >= string_2.Length)
						{
							if (GClass39.gclass45_1 != null)
							{
								int_29 = string_2.Length - 1;
								GClass39.bool_22 = true;
							}
							else
								int_29 = 0;
						}
						int_66 = int_42[int_29];
						int_31[int_28] = int_29;
					}
				}
				else
				{
					int_29++;
					if (int_29 >= string_2.Length)
					{
						if (GClass39.gclass45_1 != null)
						{
							int_29 = string_2.Length - 1;
							GClass39.bool_22 = true;
						}
						else
							int_29 = 0;
					}
					int_66 = int_42[int_29];
					int_31[int_28] = int_29;
				}
			}
			if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
			{
				int_29--;
				if (int_29 < 0)
					int_29 = string_2.Length - 1;
				if (GClass39.bool_22)
					GClass39.bool_22 = false;
				int_66 = int_42[int_29];
				int_31[int_28] = int_29;
			}
		}
		int_104 = -1;
		for (int i = 0; i < string_2.Length; i++)
		{
			if (!GClass39.smethod_48(int_30 + i * int_5, 52, int_5 - 1, 25))
				continue;
			int_104 = i;
			if (GClass39.bool_16)
			{
				int_29 = i;
				int_31[int_28] = i;
				GClass39.bool_16 = false;
				int_66 = int_42[int_29];
				if (num == int_29 && int_98 == 0)
				{
					int_7 = 0;
					int_66 = (GClass39.bool_5 ? (-1) : 0);
				}
				break;
			}
		}
		if (num == int_29)
			return;
		sbyte_17 = 0;
		GClass29.smethod_1().method_40();
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
					if (string_3.Length > 4)
						method_79();
					else
						method_77();
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
				GClass198.smethod_0().method_3();
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
				if (Equals(GClass39.gclass45_0))
					method_88();
				else if (Equals(GClass39.gclass45_1))
				{
					method_61(false);
				}
			}
			if (int_29 == 1)
				method_61(true);
			if (int_29 == 2)
				method_61(false);
		}
		int_66 = int_42[int_29];
	}

	private void method_75()
	{
		int_41 = string_22.Length;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		GClass29.smethod_1().method_1();
		int_41 = string_6.Length;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		if (bool_10)
		{
			int_41 = ((gclass21_1 != null) ? (gclass21_1.Length + 2) : 2);
			string_20 = mResources.clan_list;
		}
		else if (bool_12)
		{
			string_21 = string.Empty;
			int_41 = ((gclass63_1 != null) ? gclass63_1.method_2() : gclass63_2.method_2()) + 2;
			string_20 = mResources.member + " " + ((gclass21_0 == null) ? GClass58.smethod_1().gclass21_0.string_0 : gclass21_0.string_0);
		}
		else if (bool_11)
		{
			int_41 = GClass62.gclass63_0.method_2() + 2;
			string_20 = mResources.msg;
			string_21 = string.Empty;
		}
		if (GClass58.smethod_1().gclass21_0 == null)
			string_19 = new string[2][]
			{
				mResources.findClan,
				mResources.createClan
			};
		else if (!bool_12)
		{
			if (gclass63_2.method_2() > 1)
				string_19 = new string[3][]
				{
					mResources.chatClan,
					mResources.request_pea2,
					mResources.memberr
				};
			else
				string_19 = new string[1][] { mResources.memberr };
		}
		else if (GClass58.smethod_1().sbyte_17 > 0)
		{
			string_19 = new string[2][]
			{
				mResources.msgg,
				mResources.leaveClan
			};
		}
		else if (gclass63_2.method_2() > 1)
		{
			string_19 = new string[4][]
			{
				mResources.msgg,
				mResources.leaveClan,
				mResources.khau_hieuu,
				mResources.bieu_tuongg
			};
		}
		else
		{
			string_19 = new string[3][]
			{
				mResources.msgg,
				mResources.khau_hieuu,
				mResources.bieu_tuongg
			};
		}
		int_11 = int_41 * int_4 - int_60;
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
		GClass154.bool_59 = false;
		int_4 = 24;
		if (int_42 != null && int_42[3] == 0)
			int_42[3] = -1;
		int_41 = 2;
		if (GClass58.smethod_1().gclass21_0 != null)
		{
			bool_11 = true;
			bool_12 = false;
			bool_10 = false;
		}
		else
		{
			bool_11 = false;
			bool_12 = false;
			bool_10 = true;
		}
		if (GClass58.smethod_1().gclass21_0 != null)
			int_41 = GClass62.gclass63_0.method_2() + 2;
		method_78();
		int_67 = -1;
		if (gclass7_0 == null)
		{
			gclass7_0 = new GClass7();
			gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
			gclass7_0.method_0();
			gclass7_0.ginterface5_0 = GClass39.gclass45_0;
		}
		if (GClass58.smethod_1().gclass21_0 == null)
		{
			string_21 = mResources.findingClan;
			GClass166.smethod_0().method_23(string.Empty);
		}
		int_66 = int_42[int_29];
		if (GClass39.bool_5)
			int_66 = -1;
	}

	public void method_80()
	{
		int_41 = gclass63_3.method_2() + 1;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	public void method_82()
	{
		int_4 = 24;
		if (int_29 == string_2.Length - 1 && GClass39.gclass45_1 == null && int_56 != 2)
			int_41 = GClass58.smethod_1().gclass121_2.Length + GClass58.smethod_1().gclass121_0.Length;
		else
			int_41 = GClass58.smethod_1().gclass121_3[int_29].Length;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_83()
	{
		int_4 = 30;
		int_41 = GClass58.smethod_1().gclass109_0.gclass53_0.Length + 6;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_84()
	{
		int_4 = 24;
		int_41 = string_4.Length;
		int_11 = int_41 * int_4 - int_60;
		int_7 = 0;
		int_8 = 0;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_85()
	{
		int_4 = 24;
		int_41 = GClass154.smethod_8().int_61.Length;
		int_11 = int_41 * int_4 - int_60;
		int_7 = 0;
		int_8 = 0;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_86()
	{
		int_41 = GClass58.smethod_1().gclass121_1.Length;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_87()
	{
		int_4 = 24;
		GClass121[] gclass121_ = GClass58.smethod_2().gclass121_2;
		GClass74[] gclass74_ = GClass58.smethod_2().gclass74_1;
		int_41 = gclass121_.Length + gclass74_.Length;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_88()
	{
		int_41 = GClass58.smethod_1().gclass121_2.Length + GClass58.smethod_1().gclass121_0.Length;
		int_4 = 24;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	private void method_89()
	{
		if (!bool_20)
			return;
		if (GClass1.sbyte_3 != GClass1.sbyte_2)
		{
			GClass56.smethod_8("LOAD TAM HINH");
			gclass2_2 = GClass39.smethod_42("/img/map" + GClass1.sbyte_2 + ".png");
			GClass1.sbyte_3 = GClass1.sbyte_2;
		}
		int_17 = method_1() - int_59 / 2;
		int_18 = method_2() + int_58 - (int_58 + int_60 / 2);
		int_24 = int_17;
		int_25 = int_18;
		int_19 = 250 - int_59;
		int_20 = 220 - int_60;
		if (int_19 < 0)
			int_19 = 0;
		if (int_20 < 0)
			int_20 = 0;
		for (int i = 0; i < int_52[GClass1.sbyte_2].Length; i++)
		{
			if (GClass1.int_37 == int_52[GClass1.sbyte_2][i])
			{
				int_145 = int_53[GClass1.sbyte_2][i] + int_57;
				PuasEdRyOO = int_54[GClass1.sbyte_2][i] + int_58 + 5;
				break;
			}
		}
		int_141 = method_1() + int_57;
		int_142 = method_2() + int_58;
		int_143 = method_3() + int_57;
		int_144 = method_4() + int_58;
		Resources.UnloadUnusedAssets();
		GC.Collect();
	}

	private void method_90()
	{
		int_21 = 0;
	}

	public void method_91()
	{
		if (int_63 > 0)
			int_63--;
		if (bool_16 && Equals(GClass39.gclass45_0) && int_56 == 2 && int_37[int_29] > 1)
		{
			if (int_8 < -50)
			{
				GClass57.smethod_1();
				bool_16 = false;
				if (int_38[int_29] <= 0)
					GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_37[int_29] - 1, -1);
				else
					GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] - 1, -1);
			}
			else if (int_8 > int_11 + 50)
			{
				bool_16 = false;
				GClass57.smethod_1();
				if (int_38[int_29] >= int_37[int_29] - 1)
					GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, 0, -1);
				else
					GClass166.smethod_0().method_130(4, -1, (sbyte)int_29, int_38[int_29] + 1, -1);
			}
		}
		if (int_15 != int_14 && !bool_13)
		{
			int_106 = int_14 - int_15 << 2;
			int_107 += int_106;
			int_15 += int_107 >> 3;
			int_107 &= 15;
		}
		if (GClass26.smethod_0(int_14 - int_15) < 10)
			int_15 = int_14;
		if (bool_21)
		{
			bool_21 = false;
			int_14 = int_59;
		}
		if (int_14 >= int_59 - 10 && int_15 >= int_59 - 10 && UrRyYhZnVy == 0)
		{
			bool_0 = false;
			method_149();
			if (bool_23)
			{
				bool_23 = false;
				if (GClass58.smethod_1().int_25 > 0 && GClass58.smethod_1().int_11 != 14)
				{
					GClass57.smethod_1();
					if (int_28 == 3)
						GClass166.smethod_0().method_42(int_66, -1);
					else if (int_28 == 14)
					{
						GClass171.smethod_0().method_5(int_66);
					}
				}
			}
			if (bool_18)
			{
				bool_18 = false;
				int num = gclass63_4.method_2() - gclass63_11.method_2();
				if (GClass58.smethod_1().gclass58_0 != null)
				{
					if (int_66 - num < 0)
						GClass58.smethod_1().gclass58_0.int_16 = int_66;
					else
						GClass58.smethod_1().gclass58_0.int_16 = short.Parse((string)gclass63_11.method_3(int_66 - num));
				}
				((GClass14)gclass63_4.method_3(int_66)).method_1();
			}
			gclass63_4.method_9();
			gclass58_0 = null;
		}
		if (int_98 != 0 && !bool_13)
		{
			int_7 += int_98 / 100;
			if (int_7 < 0)
				int_7 = 0;
			else if (int_7 > int_11)
			{
				int_7 = int_11;
			}
			else
			{
				int_8 = int_7;
			}
			int_98 = int_98 * 9 / 10;
			if (int_98 < 100 && int_98 > -100)
				int_98 = 0;
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

	public void method_92(GClass76 g)
	{
		if (gclass70_0 == null || gclass70_0.string_0 == null)
			return;
		gclass70_0.paint(g);
		int num = gclass70_0.int_3 + 13;
		int num2 = gclass70_0.int_4 + 11;
		if (int_28 == 15)
		{
			num += 5;
			num2 += 26;
		}
		if (int_28 == 0 && int_29 == 3)
		{
			if (bool_10)
				num -= 5;
			else if (int_62 != null || gclass58_1 != null)
			{
				num = gclass70_0.int_3 + 21;
				num2 = gclass70_0.int_4 + 40;
			}
		}
		if (int_62 != null)
		{
			GClass44 gClass = GClass154.gclass44_0[int_62[0]];
			GClass44 gClass2 = GClass154.gclass44_0[int_62[1]];
			GClass44 gClass3 = GClass154.gclass44_0[int_62[2]];
			GClass96.smethod_6(g, gClass.gclass161_0[GClass58.int_94[0][0][0]].short_0, num + GClass58.int_94[0][0][1] + gClass.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num2 - GClass58.int_94[0][0][2] + gClass.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1, 0, 0);
			GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[0][1][0]].short_0, num + GClass58.int_94[0][1][1] + gClass2.gclass161_0[GClass58.int_94[0][1][0]].sbyte_0, num2 - GClass58.int_94[0][1][2] + gClass2.gclass161_0[GClass58.int_94[0][1][0]].sbyte_1, 0, 0);
			GClass96.smethod_6(g, gClass3.gclass161_0[GClass58.int_94[0][2][0]].short_0, num + GClass58.int_94[0][2][1] + gClass3.gclass161_0[GClass58.int_94[0][2][0]].sbyte_0, num2 - GClass58.int_94[0][2][2] + gClass3.gclass161_0[GClass58.int_94[0][2][0]].sbyte_1, 0, 0);
		}
		else if (gclass58_1 != null)
		{
			gclass58_1.method_96(g, num + 5, num2 + 25, 1, 0, true);
		}
		else if (int_61 != -1)
		{
			GClass96.smethod_6(g, int_61, num, num2, 0, 3);
		}
		if (gclass121_0 != null && gclass121_0.gclass118_0.sbyte_0 != 5)
		{
			if (gclass121_0.int_43 > 0)
			{
				g.method_31(gclass2_11, num - 7, num2 + 13, 3);
				GClass49.gclass49_8.method_6(g, GClass56.smethod_28(gclass121_0.int_43) + string.Empty, num + 1, num2 + 8, 0);
			}
			else if (gclass121_0.int_43 < 0 && gclass121_0.int_43 != -1)
			{
				g.method_31(gclass2_12, num - 7, num2 + 13, 3);
				GClass49.gclass49_1.method_6(g, GClass56.smethod_28(gclass121_0.int_43) + string.Empty, num + 1, num2 + 8, 0);
			}
		}
	}

	public void method_93(GClass76 g)
	{
		g.method_5(int_57, int_58, int_59, int_60);
		g.method_1(0, -int_8);
		g.method_16(0);
		if (int_41 == 0)
			return;
		int num = (int_8 + int_60) / 24 + 1;
		if (num < int_60 / 24 + 1)
			num = int_60 / 24 + 1;
		if (num > int_41)
			num = int_41;
		int num2 = int_8 / 24;
		if (num2 >= num)
			num2 = num - 1;
		if (num2 < 0)
			num2 = 0;
		for (int i = num2; i < num; i++)
		{
			int num3 = int_57;
			int num4 = int_58 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num5 = int_57 + 24;
			int num6 = int_58 + i * int_4;
			int num7 = int_59 - 24;
			int num8 = int_4 - 1;
			g.method_16((i != int_66) ? 15196114 : 16383818);
			g.method_15(num5, num6, num7, num8);
			g.method_16((i != int_66) ? 9993045 : 9541120);
			g.method_15(num3, num4, w, h);
			GClass8 gClass = (GClass8)gclass63_8.method_3(i);
			if (gClass.int_1 != -1)
				GClass96.smethod_6(g, gClass.int_1, num3, num4, 0, 0);
			else
			{
				GClass44 gClass2 = GClass154.gclass44_0[gClass.int_0];
				GClass96.smethod_6(g, gClass2.gclass161_0[GClass58.int_94[0][0][0]].short_0, num3 + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num4 + num8 - 1, 0, GClass76.int_5 | GClass76.int_2);
			}
			g.method_5(int_57, int_58 + int_8, int_59, int_60);
			if (gClass.int_2 != GClass58.smethod_1().int_13)
				GClass49.gclass49_8.method_6(g, gClass.string_0, num5 + 5, num6, 0);
			else
				GClass49.gclass49_1.method_6(g, gClass.string_0, num5 + 5, num6, 0);
			GClass49.gclass49_18.method_6(g, gClass.string_1, num5 + num7 - 5, num6 + 11, 1);
			GClass49.gclass49_14.method_6(g, mResources.rank + ": " + gClass.int_3 + string.Empty, num5 + 5, num6 + 11, 0);
		}
		method_100(g);
	}

	public void method_94(GClass76 g)
	{
		g.method_1(-g.method_3(), -g.method_4() + GClass76.int_24);
		g.method_1(-int_15, 0);
		g.method_1(int_0, int_1);
		if (GClass39.gclass45_0.sbyte_7 != -1)
		{
			if (Equals(GClass39.gclass45_0))
				method_197(g);
			return;
		}
		GClass39.gclass37_0.method_35(int_0, int_1, int_2, int_3, g);
		method_138(g);
		method_122(g);
		method_121(g);
		int num = int_28;
		switch (num)
		{
		default:
			if (num == 100)
				GClass198.smethod_0().method_15(g);
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
				if (string_3.Length == 4)
					method_101(g);
				else
					method_117(g);
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
				if (Equals(GClass39.gclass45_0))
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
			GClass198.smethod_0().method_5(g);
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
		GClass154.smethod_18(g);
		method_92(g);
		if (int_15 == int_14)
			gclass14_1.method_3(g);
		if (gclass141_0 != null && gclass141_0.bool_0)
			gclass141_0.method_6(g);
		g.method_1(-g.method_3(), -g.method_4());
		g.method_1(int_0, int_1);
		g.method_1(-int_15, 0);
	}

	private void method_95(GClass76 gclass76_0)
	{
		try
		{
			if (int_28 == 1 && int_29 == string_2.Length - 1 && GClass39.gclass45_1 == null && int_56 != 2)
			{
				method_120(gclass76_0);
				return;
			}
			gclass76_0.method_16(16711680);
			gclass76_0.method_5(int_57, int_58, int_59, int_60);
			if (int_56 == 2 && Equals(GClass39.gclass45_0))
			{
				if (int_29 <= 3 && GClass39.bool_5)
				{
					if (int_8 < -50)
						GClass39.smethod_47(int_57 + int_59 / 2, int_58 + 30, gclass76_0);
					else if (int_8 < 0)
					{
						GClass49.gclass49_16.method_6(gclass76_0, mResources.getDown, int_57 + int_59 / 2, int_58 + 15, 2);
					}
					else if (int_11 >= 0)
					{
						if (int_8 > int_11 + 50)
							GClass39.smethod_47(int_57 + int_59 / 2, int_58 + int_60 - 30, gclass76_0);
						else if (int_8 > int_11)
						{
							GClass49.gclass49_16.method_6(gclass76_0, mResources.getUp, int_57 + int_59 / 2, int_58 + int_60 - 25, 2);
						}
					}
				}
				if (GClass58.smethod_1().gclass121_3[int_29].Length == 0 && int_28 != 17)
				{
					GClass49.gclass49_16.method_6(gclass76_0, mResources.notYetSell, int_57 + int_59 / 2, int_58 + int_60 / 2 - 10, 2);
					return;
				}
			}
			gclass76_0.method_1(0, -int_8);
			GClass121[] array = GClass58.smethod_1().gclass121_3[int_29];
			if (int_56 == 2 && (int_29 == 4 || int_28 == 17))
			{
				array = GClass58.smethod_1().gclass121_3[4];
				if (array.Length == 0)
				{
					GClass49.gclass49_16.method_6(gclass76_0, mResources.notYetSell, int_57 + int_59 / 2, int_58 + int_60 / 2 - 10, 2);
					return;
				}
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				int num2 = int_57 + 26;
				int num3 = int_58 + i * int_4;
				int num4 = int_59 - 26;
				int h = int_4 - 1;
				int num5 = int_57;
				int num6 = int_58 + i * int_4;
				int num7 = 24;
				int num8 = int_4 - 1;
				if (num3 - int_8 > int_58 + int_60 || num3 - int_8 < int_58 - int_4)
					continue;
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(num2, num3, num4, h);
				gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
				gclass76_0.method_15(num5, num6, num7, num8);
				GClass121 gClass = array[i];
				if (gClass != null)
				{
					string text = string.Empty;
					string text2 = string.Empty;
					GClass49 gClass2 = GClass49.gclass49_14;
					if (gClass.sbyte_33 != 0 && int_56 == 2 && int_29 <= 3 && !Equals(GClass39.gclass45_1))
						gClass2 = GClass49.gclass49_8;
					if (gClass.gclass20_0 != null)
					{
						for (int j = 0; j < gClass.gclass20_0.Length; j++)
						{
							if (GClass1.int_37 == 45)
							{
								if (gClass.gclass118_0.sbyte_0 != 33)
									text = ((!gClass.gclass20_0[j].method_0().StartsWith((mResources.language == 0) ? "HSD" : "Expr")) ? ((GClass192.int_0 == 0) ? " [Vĩnh viễn]" : "[Forever]") : ((GClass192.int_0 == 0) ? (" [" + gClass.gclass20_0[j].method_0().Split(' ')[1] + " ngày]") : (" [" + gClass.gclass20_0[j].method_0().Split(' ')[1] + " day]")));
							}
							else
								text = "";
							if (gClass.gclass20_0[j].gclass114_0.int_0 == 72)
								text2 = " [+" + gClass.gclass20_0[j].int_0 + "]";
							if (gClass.gclass20_0[j].gclass114_0.int_0 == 41)
							{
								if (gClass.gclass20_0[j].int_0 == 1)
									gClass2 = smethod_6(0);
								else if (gClass.gclass20_0[j].int_0 == 2)
								{
									gClass2 = smethod_6(2);
								}
								else if (gClass.gclass20_0[j].int_0 == 3)
								{
									gClass2 = smethod_6(8);
								}
								else if (gClass.gclass20_0[j].int_0 == 4)
								{
									gClass2 = smethod_6(7);
								}
							}
						}
					}
					if (text == " [Vĩnh viễn]")
						gClass2 = GClass49.gclass49_1;
					gClass2.method_6(gclass76_0, gClass.gclass118_0.string_0 + text2 + text, num2 + 5, num3 + 1, 0);
					string text3 = string.Empty;
					if (gClass.gclass20_0 != null && gClass.gclass20_0.Length >= 1)
					{
						if (gClass.gclass20_0[0] != null && gClass.gclass20_0[0].gclass114_0.int_0 != 102 && gClass.gclass20_0[0].gclass114_0.int_0 != 107)
							text3 += gClass.gclass20_0[0].method_0();
						GClass49 gClass3 = GClass49.gclass49_18;
						if (gClass.int_43 < 0 && gClass.gclass118_0.sbyte_0 != 5)
							gClass3 = GClass49.gclass49_17;
						if (int_56 == 2 && gClass.gclass20_0.Length > 1 && gClass.sbyte_32 != -1)
							text3 += string.Empty;
						if (int_56 != 2 || (int_56 == 2 && gClass.sbyte_32 <= 1))
							gClass3.method_6(gclass76_0, text3, num2 + 5, num3 + 11, 0);
					}
					if (gClass.int_39 > 0)
					{
						GClass96.smethod_6(gclass76_0, gClass.short_0, num2 + num4 - 7, num3 + 9, 0, 3);
						GClass49.gclass49_2.method_6(gclass76_0, GClass56.smethod_31(gClass.int_39), num2 + num4 - 15, num3 + 1, GClass49.int_1);
					}
					if (gClass.int_34 != 0 || gClass.int_36 != 0)
					{
						if (int_56 != 2 && gClass.long_0 == 0L)
						{
							if (gClass.int_34 > 0 && gClass.int_36 > 0)
							{
								if (gClass.int_34 > 0)
								{
									gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 7, 3);
									GClass49.gclass49_4.method_6(gclass76_0, GClass56.smethod_31(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
								if (gClass.int_36 > 0)
								{
									gclass76_0.method_31(gclass2_9, num2 + num4 - 7, num3 + 7 + 11, 3);
									GClass49.gclass49_8.method_6(gclass76_0, GClass56.smethod_31(gClass.int_36), num2 + num4 - 15, num3 + 12, GClass49.int_1);
								}
							}
							else
							{
								if (gClass.int_34 > 0)
								{
									gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 7, 3);
									GClass49.gclass49_4.method_6(gclass76_0, GClass56.smethod_31(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
								if (gClass.int_36 > 0)
								{
									gclass76_0.method_31(gclass2_9, num2 + num4 - 7, num3 + 7, 3);
									GClass49.gclass49_8.method_6(gclass76_0, GClass56.smethod_31(gClass.int_36), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
							}
						}
						if (int_56 == 2 && int_29 <= 3 && !Equals(GClass39.gclass45_1))
						{
							if (gClass.int_34 > 0 && gClass.int_36 > 0)
							{
								if (gClass.int_34 > 0)
								{
									gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 7, 3);
									((GClass58.smethod_1().long_6 >= gClass.int_34) ? GClass49.gclass49_4 : GClass49.gclass49_1).method_6(gclass76_0, GClass56.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
								if (gClass.int_36 > 0)
								{
									gclass76_0.method_31(gclass2_9, num2 + num4 - 7, num3 + 7 + 11, 3);
									((GClass58.smethod_1().int_68 >= gClass.int_36) ? GClass49.gclass49_8 : GClass49.gclass49_1).method_6(gclass76_0, GClass56.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 12, GClass49.int_1);
								}
							}
							else
							{
								if (gClass.int_34 > 0)
								{
									gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 7, 3);
									((GClass58.smethod_1().long_6 >= gClass.int_34) ? GClass49.gclass49_4 : GClass49.gclass49_1).method_6(gclass76_0, GClass56.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
								if (gClass.int_36 > 0)
								{
									gclass76_0.method_31(gclass2_9, num2 + num4 - 7, num3 + 7, 3);
									((GClass58.smethod_1().int_68 >= gClass.int_36) ? GClass49.gclass49_8 : GClass49.gclass49_1).method_6(gclass76_0, GClass56.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 1, GClass49.int_1);
								}
								try
								{
									gClass2 = GClass49.gclass49_8;
									if (!GClass58.smethod_1().string_3.Equals(gClass.string_3))
										gClass2 = GClass49.gclass49_8;
									gClass2.method_6(gclass76_0, gClass.string_3, num2 + num4, num3 + 1 + GClass49.gclass49_1.method_20(), GClass49.int_1);
								}
								catch (Exception)
								{
								}
							}
						}
					}
					GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
					if (gClass.int_30 > 1)
						GClass49.gclass49_15.method_6(gclass76_0, string.Empty + gClass.int_30, num5 + num7, num6 + num8 - GClass49.gclass49_15.method_20(), 1);
					if (gClass.bool_4 && GClass39.int_8 % 10 > 5)
						gclass76_0.method_31(gclass2_6, num5 + num7 / 2, num3 + 19, 3);
				}
				if (int_56 != 2 || (!Equals(GClass39.gclass45_1) && int_29 != 4) || gClass.sbyte_32 == 0)
					continue;
				if (gClass.sbyte_32 == 1)
				{
					GClass49.gclass49_19.method_6(gclass76_0, mResources.dangban, num2 + num4 - 5, num3 + 1, GClass49.int_1);
					if (gClass.int_34 != -1)
					{
						gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 19, 3);
						GClass49.gclass49_4.method_6(gclass76_0, GClass56.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 13, GClass49.int_1);
					}
					else if (gClass.int_36 != -1)
					{
						gclass76_0.method_31(gclass2_10, num2 + num4 - 7, num3 + 17, 3);
						GClass49.gclass49_1.method_6(gclass76_0, GClass56.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 11, GClass49.int_1);
					}
				}
				else if (gClass.sbyte_32 == 2)
				{
					GClass49.gclass49_2.method_6(gclass76_0, mResources.daban, num2 + num4 - 5, num3 + 1, GClass49.int_1);
					if (gClass.int_34 != -1)
					{
						gclass76_0.method_31(gclass2_7, num2 + num4 - 7, num3 + 17, 3);
						GClass49.gclass49_4.method_6(gclass76_0, GClass56.smethod_32(gClass.int_34), num2 + num4 - 15, num3 + 11, GClass49.int_1);
					}
					else if (gClass.int_36 != -1)
					{
						gclass76_0.method_31(gclass2_10, num2 + num4 - 7, num3 + 17, 3);
						GClass49.gclass49_1.method_6(gclass76_0, GClass56.smethod_32(gClass.int_36), num2 + num4 - 15, num3 + 11, GClass49.int_1);
					}
				}
			}
			method_100(gclass76_0);
		}
		catch (Exception)
		{
		}
	}

	private void method_96(GClass76 gclass76_0)
	{
	}

	private void method_97(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_22.Length; i++)
		{
			int x = int_57;
			int num = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
			{
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(x, num, w, h);
				GClass49.gclass49_6.method_6(gclass76_0, string_22[i], int_57 + int_59 / 2, num + 6, GClass49.int_2);
			}
		}
		method_100(gclass76_0);
	}

	private void method_98()
	{
	}

	private void method_99(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		GClass121[] gclass121_ = GClass58.smethod_2().gclass121_2;
		GClass74[] gclass74_ = GClass58.smethod_2().gclass74_1;
		for (int i = 0; i < gclass121_.Length + gclass74_.Length; i++)
		{
			bool flag = i < gclass121_.Length;
			int num = i;
			int num2 = i - gclass121_.Length;
			int num3 = int_57 + 36;
			int num4 = int_58 + i * int_4;
			int w = int_59 - 36;
			int h = int_4 - 1;
			int num5 = int_57;
			int num6 = int_58 + i * int_4;
			int num7 = 34;
			int num8 = int_4 - 1;
			if (num4 - int_8 > int_58 + int_60 || num4 - int_8 < int_58 - int_4)
				continue;
			GClass121 gClass = ((!flag) ? null : gclass121_[num]);
			gclass76_0.method_16((i == int_66) ? 16383818 : ((!flag) ? 15723751 : 15196114));
			gclass76_0.method_15(num3, num4, w, h);
			gclass76_0.method_16((i == int_66) ? 9541120 : ((!flag) ? 11837316 : 9993045));
			if (gClass != null)
			{
				for (int j = 0; j < gClass.gclass20_0.Length; j++)
				{
					if (gClass.gclass20_0[j].gclass114_0.int_0 == 72 && gClass.gclass20_0[j].int_0 > 0)
					{
						sbyte id = smethod_5(gClass.gclass20_0[j].int_0);
						if (smethod_4(id) != -1)
							gclass76_0.method_16((i != int_66) ? smethod_4(id) : smethod_4(id));
					}
				}
			}
			gclass76_0.method_15(num5, num6, num7, num8);
			if (gClass != null && gClass.bool_0 && GClass39.gclass45_0.int_28 == 12)
			{
				gclass76_0.method_16((i != int_66) ? 6047789 : 7040779);
				gclass76_0.method_15(num5, num6, num7, num8);
			}
			if (gClass != null)
			{
				string text = string.Empty;
				GClass49 gClass2 = GClass49.gclass49_14;
				if (gClass.gclass20_0 != null)
				{
					for (int k = 0; k < gClass.gclass20_0.Length; k++)
					{
						if (!gClass.gclass20_0[k].method_0().StartsWith("HSD") && gClass.gclass118_0.short_0 == 860)
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, 7);
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 72)
						{
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, gClass.gclass20_0[k].int_0);
							text = " [+" + gClass.gclass20_0[k].int_0 + "]";
						}
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 41)
						{
							if (gClass.gclass20_0[k].int_0 == 1)
								gClass2 = smethod_6(0);
							else if (gClass.gclass20_0[k].int_0 == 2)
							{
								gClass2 = smethod_6(2);
							}
							else if (gClass.gclass20_0[k].int_0 == 3)
							{
								gClass2 = smethod_6(8);
							}
							else if (gClass.gclass20_0[k].int_0 == 4)
							{
								gClass2 = smethod_6(7);
							}
						}
					}
				}
				string text2 = string.Empty;
				string text3 = string.Empty;
				if (gClass.gclass20_0 != null)
				{
					for (int l = 0; l < gClass.gclass20_0.Length; l++)
					{
						text3 = text3 + gClass.gclass20_0[l].gclass114_0.int_0 + "-";
					}
				}
				foreach (GClass183.GStruct2 item in GClass183.smethod_0().list_4)
				{
					if (gClass.gclass118_0.short_0 == item.int_0 && text3 == item.string_0 && gClass.gclass118_0.sbyte_0 == item.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[ĐT1]: " : "[DS1]: ");
						gclass76_0.method_16(16777062);
						gclass76_0.method_15(num3, num4, w, h);
					}
				}
				foreach (GClass183.GStruct5 item2 in GClass183.smethod_0().list_5)
				{
					if (gClass.gclass118_0.short_0 == item2.int_0 && text3 == item2.string_0 && gClass.gclass118_0.sbyte_0 == item2.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[ĐT2]: " : "[DS2]: ");
						gclass76_0.method_16(16777062);
						gclass76_0.method_15(num3, num4, w, h);
					}
				}
				gClass2.method_6(gclass76_0, text2 + gClass.gclass118_0.string_0 + text, num3 + 5, num4 + 1, 0);
				string text4 = string.Empty;
				string text5 = string.Empty;
				if (gClass.gclass20_0 != null)
				{
					if (gClass.gclass20_0.Length != 0 && gClass.gclass20_0[0] != null && gClass.gclass20_0[0].gclass114_0.int_0 != 102 && gClass.gclass20_0[0].gclass114_0.int_0 != 107)
						text4 += gClass.gclass20_0[0].method_0();
					GClass49 gClass3 = GClass49.gclass49_18;
					if (gClass.int_43 < 0 && gClass.gclass118_0.sbyte_0 != 5)
						gClass3 = GClass49.gclass49_17;
					if (gClass.gclass20_0.Length > 1)
					{
						for (int m = 1; m < gClass.gclass20_0.Length; m++)
						{
							if (gClass.gclass20_0[m] != null && gClass.gclass20_0[m].gclass114_0.int_0 != 102 && gClass.gclass20_0[m].gclass114_0.int_0 != 107 && gClass.gclass20_0[m].method_0().StartsWith("Set"))
								text4 = text4 + "," + gClass.gclass20_0[m].method_0();
						}
						for (int n = 1; n < gClass.gclass20_0.Length; n++)
						{
							if (gClass.gclass20_0[n] == null || gClass.method_0())
								continue;
							if ((gClass.gclass118_0.sbyte_0 >= 0 && gClass.gclass118_0.sbyte_0 <= 4) || gClass.gclass118_0.sbyte_0 == 32)
								try
								{
									int num9 = n;
									sbyte language = mResources.language;
									if (language != 0)
									{
										if (language != 1)
											continue;
										int num10 = gClass.gclass20_0[num9].gclass114_0.int_0;
										if (num10 <= 81)
										{
											if (num10 != 50)
											{
												switch (num10)
												{
												case 77:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + " HP";
													break;
												case 80:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP") : ("Heal " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP"));
													break;
												case 81:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI") : ("Heal " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " MP"));
													break;
												case 78:
												case 79:
													break;
												}
											}
											else
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " SĐ" : " DMG");
											continue;
										}
										switch (num10)
										{
										case 94:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[2] + ((GClass192.int_0 == 0) ? " Giáp" : " AMR");
											continue;
										case 95:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HM" : " BS");
											continue;
										case 96:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HK" : " MS");
											continue;
										case 97:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " PST" : " CD");
											continue;
										case 101:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " TNSM" : " Power,SP");
											continue;
										case 103:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " KI" : " MP");
											continue;
										case 98:
										case 99:
										case 100:
										case 102:
											continue;
										}
										if (num10 == 108)
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " Né đòn" : " Dodge");
										continue;
									}
									int num11 = gClass.gclass20_0[num9].gclass114_0.int_0;
									if (num11 <= 81)
									{
										if (num11 != 50)
										{
											switch (num11)
											{
											case 77:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + " HP";
												break;
											case 80:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + "Hồi " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " HP";
												break;
											case 81:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + "Hồi " + gClass.gclass20_0[num9].method_0().Split('+')[1].Split('/')[0] + " KI";
												break;
											case 78:
											case 79:
												break;
											}
										}
										else
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + " SĐ";
										continue;
									}
									switch (num11)
									{
									case 94:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + " Giáp";
										continue;
									case 95:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + " HM";
										continue;
									case 96:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + " HK";
										continue;
									case 97:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[1] + " PST";
										continue;
									case 101:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[0] + " TNSM";
										continue;
									case 103:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split('+')[1] + " KI";
										continue;
									case 98:
									case 99:
									case 100:
									case 102:
										continue;
									}
									if (num11 == 108)
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num9].method_0().Split(' ')[0] + " Né đòn";
								}
								catch (Exception)
								{
								}
							else if (gClass.gclass118_0.sbyte_0 > 4 && gClass.gclass118_0.sbyte_0 != 32)
							{
								text4 = text4 + "," + gClass.gclass20_0[n].method_0();
							}
						}
					}
					gClass3.method_6(gclass76_0, text4, num3 + 5, num4 + 11, GClass49.int_0);
				}
				GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
				GClass49.gclass49_18.method_10(gclass76_0, text5, 170, int_58 + i * int_4 + 11, GClass49.int_1, GClass49.gclass49_20);
				if (gClass.gclass20_0 != null)
				{
					for (int num12 = 0; num12 < gClass.gclass20_0.Length; num12++)
					{
						method_214(gclass76_0, gClass.gclass20_0[num12].gclass114_0.int_0, gClass.gclass20_0[num12].int_0, num5, num6, num7, num8);
					}
					for (int num13 = 0; num13 < gClass.gclass20_0.Length; num13++)
					{
						method_215(gclass76_0, gClass.gclass20_0[num13].gclass114_0.int_0, gClass.gclass20_0[num13].int_0, num5, num6, num7, num8);
					}
					for (int num14 = 0; num14 < gClass.gclass20_0.Length; num14++)
					{
						string text6 = string.Empty;
						if (gClass.gclass20_0[num14].int_0 > 0 && gClass.gclass20_0[num14].gclass114_0.int_0 == 107)
							text6 = gClass.gclass20_0[num14].int_0.ToString();
						if (text6 != string.Empty)
						{
							GClass193.smethod_0().method_2(GClass49.gclass49_3, gclass76_0, text6, 160, int_58 + i * int_4, 0, GClass49.gclass49_2);
							gclass76_0.method_33(gclass2_3, 165, int_58 + i * int_4 + 1);
						}
					}
				}
				if (gClass.int_30 > 1)
					GClass49.gclass49_15.method_6(gclass76_0, string.Empty + gClass.int_30, num5 + num7, num6 + num8 - GClass49.gclass49_15.method_20(), 1);
			}
			else if (!flag)
			{
				GClass74 gClass4 = gclass74_[num2];
				if (gClass4.gclass53_0 != null)
				{
					GClass49.gclass49_18.method_6(gclass76_0, gClass4.gclass53_0.string_0, num3 + 5, num4 + 1, 0);
					GClass49.gclass49_14.method_6(gclass76_0, mResources.level + ": " + gClass4.int_0 + string.Empty, num3 + 5, num4 + 11, 0);
					GClass96.smethod_6(gclass76_0, gClass4.gclass53_0.int_4, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
				}
				else
				{
					GClass49.gclass49_14.method_6(gclass76_0, gClass4.string_0, num3 + 5, num4 + 5, 0);
					GClass96.smethod_6(gclass76_0, GClass154.gclass42_0[98].gclass142_0[0].int_2, num5 + num7 / 2, num6 + num8 / 2, 0, 3);
				}
			}
		}
		method_100(gclass76_0);
	}

	public void method_100(GClass76 g)
	{
		g.method_1(-g.method_3(), -g.method_4());
		if ((int_8 > 24 && int_41 > 0) || (Equals(GClass39.gclass45_0) && int_56 == 2 && int_37[int_29] > 1))
			g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 1, int_57 + int_59 - 12, int_58 + 3, 0);
		if ((int_8 < int_11 && int_41 > 0) || (Equals(GClass39.gclass45_0) && int_56 == 2 && int_37[int_29] > 1))
			g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_57 + int_59 - 12, int_58 + int_60 - 8, 0);
	}

	private void method_101(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_6.Length; i++)
		{
			int num = int_57;
			int num2 = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
				continue;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num, num2, w, h);
			GClass49.gclass49_6.method_6(gclass76_0, string_6[i], int_57 + int_59 / 2, num2 + 6, GClass49.int_2);
			if (!string_6[i].Equals(mResources.gameInfo))
				continue;
			for (int j = 0; j < gclass63_12.method_2(); j++)
			{
				if (!((Class4)gclass63_12.method_3(j)).bool_0)
				{
					if (GClass39.int_8 % 20 > 10)
						gclass76_0.method_31(gclass2_6, num + 10, num2 + 10, 3);
					break;
				}
			}
		}
		method_100(gclass76_0);
	}

	private void method_102(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_27.Length; i++)
		{
			int num = int_58 + i * 15;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
				GClass49.gclass49_6.method_6(gclass76_0, string_27[i], int_57 + 5, num + 6, GClass49.int_0);
		}
		method_100(gclass76_0);
	}

	private void method_103(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < gclass63_12.method_2(); i++)
		{
			Class4 @class = (Class4)gclass63_12.method_3(i);
			int num = int_57;
			int num2 = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num2 - int_8 <= int_58 + int_60 && num2 - int_8 >= int_58 - int_4)
			{
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(num, num2, w, h);
				GClass49.gclass49_6.method_6(gclass76_0, @class.string_0, int_57 + int_59 / 2, num2 + 6, GClass49.int_2);
				if (!@class.bool_0 && GClass39.int_8 % 20 > 10)
					gclass76_0.method_31(gclass2_6, num + 10, num2 + 10, 3);
			}
		}
		method_100(gclass76_0);
	}

	private void method_104(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		int num = GClass58.smethod_1().gclass109_0.gclass53_0.Length;
		for (int i = 0; i < num + 6; i++)
		{
			int num2 = int_57 + 30;
			int num3 = int_58 + i * int_4;
			int num4 = int_59 - 30;
			int h = int_4 - 1;
			int num5 = int_57;
			int num6 = int_58 + i * int_4;
			if (num3 - int_8 > int_58 + int_60 || num3 - int_8 < int_58 - int_4)
				continue;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			if (i == 5)
				gclass76_0.method_16((i != int_66) ? 16765060 : 16776068);
			gclass76_0.method_15(num2, num3, num4, h);
			gclass76_0.method_31(GClass154.gclass2_14, num5, num6, 0);
			if (i == 0)
			{
				GClass96.smethod_6(gclass76_0, 567, num5 + 4, num6 + 4, 0, 0);
				string st = mResources.HP + " " + mResources.root + ": " + GClass95.smethod_9(GClass58.smethod_1().int_155);
				GClass49.gclass49_2.method_6(gclass76_0, st, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_14.method_6(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().int_155 + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass58.smethod_1().sbyte_30, num2 + 5, num3 + 15, 0);
			}
			if (i == 1)
			{
				GClass96.smethod_6(gclass76_0, 569, num5 + 4, num6 + 4, 0, 0);
				string st2 = mResources.KI + " " + mResources.root + ": " + GClass95.smethod_9(GClass58.smethod_1().int_156);
				GClass49.gclass49_2.method_6(gclass76_0, st2, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_14.method_6(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().int_156 + 1000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass58.smethod_1().sbyte_31, num2 + 5, num3 + 15, 0);
			}
			if (i == 2)
			{
				GClass96.smethod_6(gclass76_0, 568, num5 + 4, num6 + 4, 0, 0);
				string st3 = mResources.hit_point + " " + mResources.root + ": " + GClass95.smethod_9(GClass58.smethod_1().int_154);
				GClass49.gclass49_2.method_6(gclass76_0, st3, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_14.method_6(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().int_154 * 100) + " " + mResources.potential + ": " + mResources.increase + " " + GClass58.smethod_1().sbyte_32, num2 + 5, num3 + 15, 0);
			}
			if (i == 3)
			{
				GClass96.smethod_6(gclass76_0, 721, num5 + 4, num6 + 4, 0, 0);
				string st4 = mResources.armor + " " + mResources.root + ": " + GClass95.smethod_9(GClass58.smethod_1().int_157);
				GClass49.gclass49_2.method_6(gclass76_0, st4, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_14.method_6(gclass76_0, GClass95.smethod_9(500000 + GClass58.smethod_1().int_157 * 100000) + " " + mResources.potential + ": " + mResources.increase + " " + GClass58.smethod_1().sbyte_33, num2 + 5, num3 + 15, 0);
			}
			if (i == 4)
			{
				GClass96.smethod_6(gclass76_0, 719, num5 + 4, num6 + 4, 0, 0);
				string st5 = mResources.critical + " " + mResources.root + ": " + GClass58.smethod_1().int_158 + "%";
				long num7 = 50000000L;
				int num8 = GClass58.smethod_1().int_158;
				if (num8 > long_0.Length - 1)
					num8 = long_0.Length - 1;
				num7 = long_0[num8];
				GClass49.gclass49_2.method_6(gclass76_0, st5, num2 + 5, num3 + 3, 0);
				long number = num7;
				GClass49.gclass49_14.method_6(gclass76_0, GClass56.smethod_32(number) + " " + mResources.potential + ": " + mResources.increase + " " + GClass58.smethod_1().sbyte_34, num2 + 5, num3 + 15, 0);
			}
			if (i == 5)
			{
				if (string_1 != null)
				{
					GClass96.smethod_6(gclass76_0, short_0, num5 + 4, num6 + 4, 0, 0);
					string[] array = GClass49.gclass49_11.method_15(string_1, 120);
					for (int j = 0; j < array.Length; j++)
					{
						GClass49.gclass49_14.method_6(gclass76_0, array[j], num2 + 5, num3 + 3 + j * 12, 0);
					}
				}
				else
					GClass49.gclass49_14.method_6(gclass76_0, string.Empty, num2 + 5, num3 + 9, 0);
			}
			if (i < 6)
				continue;
			GClass53 gClass = GClass58.smethod_1().gclass109_0.gclass53_0[i - 6];
			GClass96.smethod_6(gclass76_0, gClass.int_4, num5 + 4, num6 + 4, 0, 0);
			GClass74 gClass2 = GClass58.smethod_1().method_15(gClass);
			if (gClass2 != null)
			{
				GClass49.gclass49_2.method_6(gclass76_0, gClass.string_0, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_18.method_6(gclass76_0, mResources.level + ": " + gClass2.int_0, num2 + num4 - 5, num3 + 3, GClass49.int_1);
				if (gClass2.int_0 == gClass.int_1)
					GClass49.gclass49_14.method_6(gclass76_0, mResources.max_level_reach, num2 + 5, num3 + 15, 0);
				else if (gClass2.gclass53_0.method_3())
				{
					string text = mResources.proficiency + ": ";
					int x = GClass49.gclass49_14.method_18(text) + num2 + 5;
					int num9 = num3 + 15;
					GClass49.gclass49_14.method_6(gclass76_0, text, num2 + 5, num9, 0);
					GClass49.gclass49_14.method_6(gclass76_0, "(" + gClass2.method_0() + ")", num2 + num4 - 5, num9, GClass49.int_1);
					num9 += 4;
					gclass76_0.method_16(7169134);
					gclass76_0.method_15(x, num9, 50, 5);
					int w = gClass2.short_3 * 50 / 1000;
					gclass76_0.method_16(11992374);
					gclass76_0.method_15(x, num9, w, 5);
					if (gClass2.short_3 >= 1000)
						;
				}
				else
				{
					GClass74 gClass3 = gClass.gclass74_0[gClass2.int_0];
					GClass49.gclass49_14.method_6(gclass76_0, mResources.level + " " + (gClass2.int_0 + 1) + " " + mResources.need + " " + GClass56.smethod_32(gClass3.long_0) + " " + mResources.potential, num2 + 5, num3 + 15, 0);
				}
			}
			else
			{
				GClass74 gClass4 = gClass.gclass74_0[0];
				GClass49.gclass49_8.method_6(gclass76_0, gClass.string_0, num2 + 5, num3 + 3, 0);
				GClass49.gclass49_14.method_6(gclass76_0, mResources.need_upper + " " + GClass56.smethod_32(gClass4.long_0) + " " + mResources.potential_to_learn, num2 + 5, num3 + 15, 0);
			}
		}
		method_100(gclass76_0);
	}

	private void method_105(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_4.Length; i++)
		{
			int num = int_58 + i * int_4;
			int h = int_4 - 1;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
			{
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(int_57, num, int_59, h);
				GClass49.gclass49_2.method_6(gclass76_0, string_4[i], 5, num + 1, 0);
				GClass49.gclass49_16.method_6(gclass76_0, string_5[i], 5, num + 11, 0);
			}
		}
		method_100(gclass76_0);
	}

	private void method_106(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		int[] array = GClass154.smethod_8().int_61;
		int[] array2 = GClass154.smethod_8().int_62;
		for (int i = 0; i < array2.Length; i++)
		{
			int num = int_57 + 36;
			int num2 = int_58 + i * int_4;
			int num3 = int_59 - 36;
			int h = int_4 - 1;
			int num4 = int_57;
			int y = int_58 + i * int_4;
			int num5 = 34;
			int h2 = int_4 - 1;
			if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
				continue;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num, num2, num3, h);
			gclass76_0.method_16(int_110[array2[i]]);
			gclass76_0.method_15(num4, y, num5, h2);
			if (array[i] != -1)
			{
				if (array2[i] != 1)
					GClass49.gclass49_15.method_6(gclass76_0, array[i] + string.Empty, num4 + num5 / 2, num2 + 6, GClass49.int_2);
				else
					GClass49.gclass49_16.method_6(gclass76_0, array[i] + string.Empty, num4 + num5 / 2, num2 + 6, GClass49.int_2);
				GClass49.gclass49_14.method_6(gclass76_0, GClass154.smethod_8().int_63[i] + "/" + GClass154.smethod_8().int_64[i], num + 5, num2 + 6, 0);
			}
			if (GClass154.smethod_8().string_1[i] != null)
			{
				GClass49.gclass49_16.method_6(gclass76_0, GClass154.smethod_8().string_1[i] + "(Top " + GClass154.smethod_8().int_65[i] + ")", num + num3 - 2, num2 + 1, GClass49.int_1);
				GClass49.gclass49_16.method_6(gclass76_0, GClass154.smethod_8().string_2[i] + "(Top " + GClass154.smethod_8().int_66[i] + ")", num + num3 - 2, num2 + 11, GClass49.int_1);
			}
		}
		method_100(gclass76_0);
	}

	private void method_107(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		if (int_41 == 0)
			return;
		int num = (int_8 + int_60) / 24 + 1;
		if (num < int_60 / 24 + 1)
			num = int_60 / 24 + 1;
		if (num > int_41)
			num = int_41;
		int num2 = int_8 / 24;
		if (num2 >= num)
			num2 = num - 1;
		if (num2 < 0)
			num2 = 0;
		for (int i = num2; i < num; i++)
		{
			int num3 = int_57;
			int num4 = int_58 + i * int_4;
			int num5 = 24;
			int num6 = int_4 - 1;
			int num7 = int_57 + 24;
			int num8 = int_58 + i * int_4;
			int w = int_59 - 24;
			int h = int_4 - 1;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num7, num8, w, h);
			gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
			gclass76_0.method_15(num3, num4, num5, num6);
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().short_1[int_29][i], num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			string[] array = GClass49.gclass49_16.method_15(GClass58.smethod_1().string_4[int_29][i], 140);
			for (int j = 0; j < array.Length; j++)
			{
				GClass49.gclass49_16.method_6(gclass76_0, array[j], num7 + 5, num8 + 1 + j * 11, 0);
			}
		}
		method_100(gclass76_0);
	}

	private void method_108(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		try
		{
			GClass121[] array = GClass58.smethod_1().gclass121_1;
			int_41 = array.Length;
			for (int i = 0; i < int_41; i++)
			{
				int num = int_57 + 36;
				int num2 = int_58 + i * int_4;
				int w = int_59 - 36;
				int h = int_4 - 1;
				int num3 = int_57;
				int num4 = int_58 + i * int_4;
				int num5 = 34;
				int num6 = int_4 - 1;
				if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
					continue;
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(num, num2, w, h);
				gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
				GClass121 gClass = array[i];
				if (gClass != null)
				{
					for (int j = 0; j < gClass.gclass20_0.Length; j++)
					{
						if (gClass.gclass20_0[j].gclass114_0.int_0 == 72 && gClass.gclass20_0[j].int_0 > 0)
						{
							sbyte id = smethod_5(gClass.gclass20_0[j].int_0);
							if (smethod_4(id) != -1)
								gclass76_0.method_16((i != int_66) ? smethod_4(id) : smethod_4(id));
						}
					}
				}
				gclass76_0.method_15(num3, num4, num5, num6);
				GClass193.smethod_0().method_3(GClass49.gclass49_20, gclass76_0, (i + 1).ToString(), int_57 + 2, int_58 + i * int_4 - 2, 0, GClass49.gclass49_11, "border");
				if (gClass == null)
					continue;
				string text = string.Empty;
				GClass49 gClass2 = GClass49.gclass49_14;
				if (gClass.gclass20_0 != null)
				{
					for (int k = 0; k < gClass.gclass20_0.Length; k++)
					{
						if (!gClass.gclass20_0[k].method_0().StartsWith("HSD") && gClass.gclass118_0.short_0 == 860)
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, 7);
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 72)
						{
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, gClass.gclass20_0[k].int_0);
							text = " [+" + gClass.gclass20_0[k].method_0() + "]";
						}
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 41)
						{
							if (gClass.gclass20_0[k].int_0 == 1)
								gClass2 = smethod_6(0);
							else if (gClass.gclass20_0[k].int_0 == 2)
							{
								gClass2 = smethod_6(2);
							}
							else if (gClass.gclass20_0[k].int_0 == 3)
							{
								gClass2 = smethod_6(8);
							}
							else if (gClass.gclass20_0[k].int_0 == 4)
							{
								gClass2 = smethod_6(7);
							}
						}
						GClass193.smethod_0().method_3(GClass49.gclass49_20, gclass76_0, (i + 1).ToString(), int_57 + 2, int_58 + i * int_4 - 2, 0, GClass49.gclass49_11, "border");
					}
				}
				gClass2.method_6(gclass76_0, gClass.gclass118_0.string_0 + text, num + 5, num2 + 1, 0);
				string text2 = string.Empty;
				string text3 = string.Empty;
				if (gClass.gclass20_0 != null)
				{
					if (gClass.gclass20_0.Length != 0 && gClass.gclass20_0[0] != null)
						text2 += gClass.gclass20_0[0].method_0();
					GClass49 gClass3 = GClass49.gclass49_18;
					if (gClass.int_43 < 0 && gClass.gclass118_0.sbyte_0 != 5)
						gClass3 = GClass49.gclass49_17;
					if (gClass.gclass20_0.Length > 1)
					{
						for (int l = 1; l < gClass.gclass20_0.Length; l++)
						{
							if (gClass.gclass20_0[l] != null && gClass.gclass20_0[l].gclass114_0.int_0 != 102 && gClass.gclass20_0[l].gclass114_0.int_0 != 107 && gClass.gclass20_0[l].method_0().StartsWith("Set"))
								text2 = text2 + "," + gClass.gclass20_0[l].method_0();
						}
						for (int m = 1; m < gClass.gclass20_0.Length; m++)
						{
							if (gClass.gclass20_0[m] == null || gClass.method_0())
								continue;
							if ((gClass.gclass118_0.sbyte_0 >= 0 && gClass.gclass118_0.sbyte_0 <= 4) || gClass.gclass118_0.sbyte_0 == 32)
								try
								{
									int num7 = m;
									sbyte language = mResources.language;
									if (language != 0)
									{
										if (language != 1)
											continue;
										int num8 = gClass.gclass20_0[num7].gclass114_0.int_0;
										if (num8 <= 81)
										{
											if (num8 != 50)
											{
												switch (num8)
												{
												case 77:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + " HP";
													break;
												case 80:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP") : ("Heal " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP"));
													break;
												case 81:
													text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " KI") : ("Heal " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " MP"));
													break;
												case 78:
												case 79:
													break;
												}
											}
											else
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " SĐ" : " DMG");
											continue;
										}
										switch (num8)
										{
										case 94:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[2] + ((GClass192.int_0 == 0) ? " Giáp" : " AMR");
											continue;
										case 95:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HM" : " BS");
											continue;
										case 96:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HK" : " MS");
											continue;
										case 97:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " PST" : " CD");
											continue;
										case 101:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " TNSM" : " Power,SP");
											continue;
										case 103:
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " KI" : " MP");
											continue;
										case 98:
										case 99:
										case 100:
										case 102:
											continue;
										}
										if (num8 == 108)
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " Né đòn" : " Dodge");
										continue;
									}
									int num9 = gClass.gclass20_0[num7].gclass114_0.int_0;
									if (num9 <= 81)
									{
										if (num9 != 50)
										{
											switch (num9)
											{
											case 77:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + " HP";
												break;
											case 80:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + "Hồi " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " HP";
												break;
											case 81:
												text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + "Hồi " + gClass.gclass20_0[num7].method_0().Split('+')[1].Split('/')[0] + " KI";
												break;
											case 78:
											case 79:
												break;
											}
										}
										else
											text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + " SĐ";
										continue;
									}
									switch (num9)
									{
									case 94:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + " Giáp";
										continue;
									case 95:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + " HM";
										continue;
									case 96:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + " HK";
										continue;
									case 97:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[1] + " PST";
										continue;
									case 101:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[0] + " TNSM";
										continue;
									case 103:
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split('+')[1] + " KI";
										continue;
									case 98:
									case 99:
									case 100:
									case 102:
										continue;
									}
									if (num9 == 108)
										text3 = text3 + ((text3 == string.Empty) ? "" : ", ") + gClass.gclass20_0[num7].method_0().Split(' ')[0] + " Né đòn";
								}
								catch (Exception)
								{
								}
							else if (gClass.gclass118_0.sbyte_0 > 4 && gClass.gclass118_0.sbyte_0 != 32)
							{
								text2 = text2 + "," + gClass.gclass20_0[m].method_0();
							}
						}
					}
					gClass3.method_6(gclass76_0, text2, num + 5, num2 + 11, GClass49.int_0);
				}
				GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
				GClass49.gclass49_18.method_10(gclass76_0, text3, int_57 + int_59 - 2, int_58 + i * int_4 + 11, GClass49.int_1, GClass49.gclass49_20);
				if (gClass.gclass20_0 != null)
				{
					for (int n = 0; n < gClass.gclass20_0.Length; n++)
					{
						method_214(gclass76_0, gClass.gclass20_0[n].gclass114_0.int_0, gClass.gclass20_0[n].int_0, num3, num4, num5, num6);
					}
					for (int num10 = 0; num10 < gClass.gclass20_0.Length; num10++)
					{
						method_215(gclass76_0, gClass.gclass20_0[num10].gclass114_0.int_0, gClass.gclass20_0[num10].int_0, num3, num4, num5, num6);
					}
					for (int num11 = 0; num11 < gClass.gclass20_0.Length; num11++)
					{
						string text4 = string.Empty;
						if (gClass.gclass20_0[num11].int_0 > 0 && gClass.gclass20_0[num11].gclass114_0.int_0 == 107)
							text4 = gClass.gclass20_0[num11].int_0.ToString();
						if (text4 != string.Empty)
						{
							GClass193.smethod_0().method_2(GClass49.gclass49_3, gclass76_0, text4, int_57 + int_59 - 17, int_58 + i * int_4, 0, GClass49.gclass49_2);
							gclass76_0.method_33(gclass2_3, int_57 + int_59 - 11, int_58 + i * int_4 + 1);
						}
					}
				}
				if (gClass.int_30 > 1)
					GClass193.smethod_0().method_2(GClass49.gclass49_15, gclass76_0, string.Empty + gClass.int_30, num3 + num5, num4 + num6 - GClass49.gclass49_15.method_20(), 1, GClass49.gclass49_16);
			}
		}
		catch (Exception)
		{
		}
		method_100(gclass76_0);
	}

	public GClass206 method_109()
	{
		if (int_66 < 2)
			return null;
		if (int_66 > ((gclass63_1 == null) ? gclass63_2.method_2() : gclass63_1.method_2()) + 1)
			return null;
		return (gclass63_1 == null) ? ((GClass206)gclass63_2.method_3(int_66 - 2)) : ((GClass206)gclass63_1.method_3(int_66 - 2));
	}

	public GClass62 method_110()
	{
		if (int_66 < 2)
			return null;
		if (int_66 > GClass62.gclass63_0.method_2() + 1)
			return null;
		return (GClass62)GClass62.gclass63_0.method_3(int_66 - 2);
	}

	public GClass21 method_111()
	{
		if (int_66 < 2)
			return null;
		if (int_66 > gclass21_1.Length + 1)
			return null;
		return gclass21_1[int_66 - 2];
	}

	private void method_112(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		if (gclass63_3.method_2() == 0)
			GClass49.gclass49_14.method_6(gclass76_0, mResources.no_msg, int_57 + int_59 / 2, int_58 + int_60 / 2 - GClass49.gclass49_11.method_20() / 2 + 24, 2);
		for (int i = 0; i < int_41; i++)
		{
			int num = int_57;
			int num2 = int_58 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num3 = int_57 + 24;
			int num4 = int_58 + i * int_4;
			int w2 = int_59 - 24;
			int num5 = int_4 - 1;
			if (i == 0)
			{
				gclass76_0.method_16(15196114);
				gclass76_0.method_15(num, num4, int_59, num5);
				gclass76_0.method_31((i != int_66) ? GClass154.gclass2_24 : GClass154.gclass2_25, int_57 + int_59 - 5, num4 + 2, GClass169.int_2);
				((i != int_66) ? GClass49.gclass49_6 : GClass49.gclass49_7).method_6(gclass76_0, (!bool_22) ? mResources.on : mResources.off, int_57 + int_59 - 22, num4 + 7, 2);
				GClass49.gclass49_16.method_6(gclass76_0, (!bool_22) ? mResources.onPlease : mResources.offPlease, int_57 + 5, num4 + num5 / 2 - 4, GClass49.int_0);
				continue;
			}
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num3, num4, w2, num5);
			gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
			gclass76_0.method_15(num, num2, w, h);
			GClass43 gClass = (GClass43)gclass63_3.method_3(i - 1);
			if (gClass.gclass58_0.int_118 != -1)
				GClass96.smethod_6(gclass76_0, gClass.gclass58_0.int_118, num, num2, 0, 0);
			else
			{
				GClass44 gClass2 = GClass154.gclass44_0[gClass.gclass58_0.int_119];
				GClass96.smethod_6(gclass76_0, gClass2.gclass161_0[GClass58.int_94[0][0][0]].short_0, num + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num2 + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1, 0, 0);
			}
			gclass76_0.method_5(int_57, int_58 + int_8, int_59, int_60);
			GClass49 gclass49_ = GClass49.gclass49_6;
			GClass49.gclass49_7.method_6(gclass76_0, gClass.gclass58_0.string_3, num3 + 5, num4, 0);
			if (!gClass.bool_0)
				GClass49.gclass49_18.method_6(gclass76_0, GClass56.smethod_30(gClass.string_0, "|", 0)[2], num3 + 5, num4 + 11, 0);
			else
				GClass49.gclass49_17.method_6(gclass76_0, GClass56.smethod_30(gClass.string_0, "|", 0)[2], num3 + 5, num4 + 11, 0);
			GClass193.smethod_0().method_3(GClass49.gclass49_1, gclass76_0, $"[{gClass.gclass58_0.int_13}]", int_57 + int_59, int_58 + i * int_4, GClass49.int_1, GClass49.gclass49_6, "noborder");
		}
		method_100(gclass76_0);
	}

	private void method_113(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		for (int i = 0; i < int_41; i++)
		{
			int num = int_57 + 26;
			int num2 = int_58 + i * int_4;
			int w = int_59 - 26;
			int h = int_4 - 1;
			int num3 = int_57;
			int num4 = int_58 + i * int_4;
			int num5 = 24;
			int num6 = int_4 - 1;
			if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
				continue;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num, num2, w, h);
			gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
			gclass76_0.method_15(num3, num4, num5, num6);
			GClass121 gClass = (GClass121)gclass63_10.method_3(i);
			if (gClass == null)
				continue;
			GClass49.gclass49_14.method_6(gclass76_0, gClass.gclass118_0.string_0, num + 5, num2 + 1, 0);
			string text = string.Empty;
			if (gClass.gclass20_0 != null && gClass.gclass20_0.Length >= 1)
			{
				if (gClass.gclass20_0[0] != null && gClass.gclass20_0[0].gclass114_0.int_0 != 102 && gClass.gclass20_0[0].gclass114_0.int_0 != 107)
					text += gClass.gclass20_0[0].method_0();
				GClass49.gclass49_18.method_6(gclass76_0, text, num + 5, num2 + 11, 0);
				GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
			}
		}
		method_100(gclass76_0);
	}

	private void method_114(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		if (int_41 == 0)
		{
			GClass49.gclass49_14.method_6(gclass76_0, mResources.no_enemy, int_57 + int_59 / 2, int_58 + int_60 / 2 - GClass49.gclass49_11.method_20() / 2, 2);
			return;
		}
		for (int i = 0; i < int_41; i++)
		{
			int num = int_57;
			int num2 = int_58 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num3 = int_57 + 24;
			int num4 = int_58 + i * int_4;
			int w2 = int_59 - 24;
			int h2 = int_4 - 1;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num3, num4, w2, h2);
			gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
			gclass76_0.method_15(num, num2, w, h);
			GClass43 gClass = (GClass43)gclass63_9.method_3(i);
			if (gClass.gclass58_0.int_118 != -1)
				GClass96.smethod_6(gclass76_0, gClass.gclass58_0.int_118, num, num2, 0, 0);
			else
			{
				GClass44 gClass2 = GClass154.gclass44_0[gClass.gclass58_0.int_119];
				GClass96.smethod_6(gclass76_0, gClass2.gclass161_0[GClass58.int_94[0][0][0]].short_0, num + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num2 + 3 + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1, 0, 0);
			}
			gclass76_0.method_5(int_57, int_58 + int_8, int_59, int_60);
			if (gClass.bool_1)
			{
				GClass49.gclass49_8.method_6(gclass76_0, gClass.gclass58_0.string_3, num3 + 5, num4, 0);
				GClass49.gclass49_18.method_6(gclass76_0, gClass.string_0, num3 + 5, num4 + 11, 0);
			}
			else
			{
				GClass49.gclass49_16.method_6(gclass76_0, gClass.gclass58_0.string_3, num3 + 5, num4, 0);
				GClass49.gclass49_16.method_6(gclass76_0, gClass.string_0, num3 + 5, num4 + 11, 0);
			}
			GClass193.smethod_0().method_3(GClass49.gclass49_1, gclass76_0, $"[{gClass.gclass58_0.int_13}]", int_57 + int_59, int_58 + i * int_4, GClass49.int_1, GClass49.gclass49_6, "noborder");
		}
		method_100(gclass76_0);
	}

	private void method_115(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		if (int_41 == 0)
		{
			GClass49.gclass49_14.method_6(gclass76_0, mResources.no_friend, int_57 + int_59 / 2, int_58 + int_60 / 2 - GClass49.gclass49_11.method_20() / 2, 2);
			return;
		}
		for (int i = 0; i < int_41; i++)
		{
			int num = int_57;
			int num2 = int_58 + i * int_4;
			int w = 24;
			int h = int_4 - 1;
			int num3 = int_57 + 24;
			int num4 = int_58 + i * int_4;
			int w2 = int_59 - 24;
			int h2 = int_4 - 1;
			gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num3, num4, w2, h2);
			gclass76_0.method_16((i != int_66) ? 9993045 : 9541120);
			gclass76_0.method_15(num, num2, w, h);
			GClass43 gClass = (GClass43)gclass63_5.method_3(i);
			if (gClass.gclass58_0.int_118 != -1)
				GClass96.smethod_6(gclass76_0, gClass.gclass58_0.int_118, num, num2, 0, 0);
			else
			{
				GClass44 gClass2 = GClass154.gclass44_0[gClass.gclass58_0.int_119];
				GClass96.smethod_6(gclass76_0, gClass2.gclass161_0[GClass58.int_94[0][0][0]].short_0, num + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num2 + 3 + gClass2.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1, 0, 0);
			}
			gclass76_0.method_5(int_57, int_58 + int_8, int_59, int_60);
			if (gClass.bool_1)
			{
				GClass49.gclass49_8.method_6(gclass76_0, gClass.gclass58_0.string_3, num3 + 5, num4, 0);
				GClass49.gclass49_18.method_6(gclass76_0, gClass.string_0, num3 + 5, num4 + 11, 0);
			}
			else
			{
				GClass49.gclass49_16.method_6(gclass76_0, gClass.gclass58_0.string_3, num3 + 5, num4, 0);
				GClass49.gclass49_16.method_6(gclass76_0, gClass.string_0, num3 + 5, num4 + 11, 0);
			}
			GClass193.smethod_0().method_3(GClass49.gclass49_1, gclass76_0, $"[{gClass.gclass58_0.int_13}]", int_57 + int_59, int_58 + i * int_4, GClass49.int_1, GClass49.gclass49_6, "noborder");
		}
		method_100(gclass76_0);
	}

	public void method_116(GClass76 g)
	{
		g.method_5(int_57, int_58, int_59, int_60);
		g.method_1(0, -int_8);
		for (int i = 0; i < gclass63_4.method_2(); i++)
		{
			int x = int_57;
			int num = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
			{
				GClass14 gClass = (GClass14)gclass63_4.method_3(i);
				g.method_16((i != int_66) ? 15196114 : 16383818);
				g.method_15(x, num, w, h);
				if (gClass.string_2.Equals(string.Empty))
				{
					GClass49.gclass49_6.method_6(g, gClass.string_0, int_57 + int_59 / 2, num + 6, GClass49.int_2);
					continue;
				}
				GClass49.gclass49_6.method_6(g, gClass.string_0, int_57 + int_59 / 2, num + 1, GClass49.int_2);
				GClass49.gclass49_6.method_6(g, gClass.string_2, int_57 + int_59 / 2, num + 11, GClass49.int_2);
			}
		}
		method_100(g);
	}

	private void method_117(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(-int_15, -int_8);
		gclass76_0.method_16(0);
		int num = int_57 + int_59 / 2 - string_19.Length * int_5 / 2;
		if (int_41 == 2)
		{
			GClass49.gclass49_14.method_6(gclass76_0, string_21, int_57 + int_59 / 2, int_58 + 24 + int_60 / 2 - GClass49.gclass49_11.method_20() / 2, 2);
			if (bool_11 && gclass63_2.method_2() == 1)
			{
				for (int i = 0; i < mResources.clanEmpty.Length; i++)
				{
					GClass49.gclass49_6.method_6(gclass76_0, mResources.clanEmpty[i], int_57 + int_59 / 2, int_58 + 24 + int_60 / 2 - mResources.clanEmpty.Length * 12 / 2 + i * 12, GClass49.int_2);
				}
			}
		}
		if (bool_11)
			int_41 = GClass62.gclass63_0.method_2() + 2;
		for (int j = 0; j < int_41; j++)
		{
			int num2 = int_57;
			int num3 = int_58 + j * int_4;
			int num4 = 24;
			int num5 = int_4 - 1;
			int num6 = int_57 + 24;
			int num7 = int_58 + j * int_4;
			int num8 = int_59 - 24;
			int num9 = int_4 - 1;
			if (num7 - int_8 > int_58 + int_60 || num7 - int_8 < int_58 - int_4)
				continue;
			int num10 = j;
			if (num10 != 0)
			{
				if (num10 != 1)
				{
					if (bool_10)
					{
						if (gclass21_1 == null || gclass21_1.Length == 0)
							continue;
						gclass76_0.method_16((j != int_66) ? 15196114 : 16383818);
						gclass76_0.method_15(num6, num7, num8, num9);
						gclass76_0.method_16((j != int_66) ? 9993045 : 9541120);
						gclass76_0.method_15(num2, num3, num4, num5);
						if (GClass137.smethod_2(gclass21_1[j - 2].int_1))
						{
							if (GClass137.smethod_1((short)gclass21_1[j - 2].int_1).short_0 != null)
								GClass96.smethod_6(gclass76_0, GClass137.smethod_1((short)gclass21_1[j - 2].int_1).short_0[0], num2 + num4 / 2, num3 + num5 / 2, 0, GClass169.int_6);
						}
						else
						{
							GClass137 gClass = new GClass137();
							gClass.int_0 = gclass21_1[j - 2].int_1;
							if (!GClass137.smethod_2(gClass.int_0))
								GClass137.smethod_0(gClass);
						}
						string st = ((gclass21_1[j - 2].string_0.Length <= 23) ? gclass21_1[j - 2].string_0 : (gclass21_1[j - 2].string_0.Substring(0, 23) + "..."));
						GClass49.gclass49_7.method_6(gclass76_0, st, num6 + 5, num7, 0);
						gclass76_0.method_5(num6, num7, num8 - 10, num9);
						GClass49.gclass49_18.method_6(gclass76_0, gclass21_1[j - 2].string_1, num6 + 5, num7 + 11, 0);
						gclass76_0.method_5(int_57, int_58 + int_8, int_59, int_60);
						GClass49.gclass49_14.method_6(gclass76_0, gclass21_1[j - 2].int_3 + "/" + gclass21_1[j - 2].int_4, num6 + num8 - 5, num7, GClass49.int_1);
					}
					else if (bool_12)
					{
						gclass76_0.method_16((j != int_66) ? 15196114 : 16383818);
						gclass76_0.method_15(num6, num7, num8, num9);
						gclass76_0.method_16((j != int_66) ? 9993045 : 9541120);
						gclass76_0.method_15(num2, num3, num4, num5);
						GClass206 gClass2 = ((gclass63_1 == null) ? ((GClass206)gclass63_2.method_3(j - 2)) : ((GClass206)gclass63_1.method_3(j - 2)));
						if (gClass2.short_1 != -1)
							GClass96.smethod_6(gclass76_0, gClass2.short_1, num2, num3, 0, 0);
						else
						{
							GClass44 gClass3 = GClass154.gclass44_0[gClass2.short_0];
							GClass96.smethod_6(gclass76_0, gClass3.gclass161_0[GClass58.int_94[0][0][0]].short_0, num2 + gClass3.gclass161_0[GClass58.int_94[0][0][0]].sbyte_0, num3 + 3 + gClass3.gclass161_0[GClass58.int_94[0][0][0]].sbyte_1, 0, 0);
						}
						gclass76_0.method_5(int_57, int_58 + int_8, int_59, int_60);
						GClass49 gClass4 = GClass49.gclass49_6;
						if (gClass2.sbyte_0 == 0)
							gClass4 = GClass49.gclass49_1;
						else if (gClass2.sbyte_0 == 1)
						{
							gClass4 = GClass49.gclass49_8;
						}
						else if (gClass2.sbyte_0 == 2)
						{
							gClass4 = GClass49.gclass49_7;
						}
						gClass4.method_6(gclass76_0, gClass2.string_0, num6 + 5, num7, 0);
						GClass49.gclass49_18.method_6(gclass76_0, mResources.power + ": " + gClass2.string_1, num6 + 5, num7 + 11, 0);
						GClass96.smethod_6(gclass76_0, 7223, num6 + num8 - 7, num7 + 12, 0, 3);
						GClass49.gclass49_18.method_6(gclass76_0, string.Empty + gClass2.int_4, num6 + num8 - 15, num7 + 6, GClass49.int_1);
					}
					else
					{
						if (!bool_11 || GClass62.gclass63_0.method_2() == 0)
							continue;
						GClass62 gClass5 = (GClass62)GClass62.gclass63_0.method_3(j - 2);
						gclass76_0.method_16((j != int_66 || gClass5.string_2 != null) ? 15196114 : 16383818);
						gclass76_0.method_15(num2, num3, num8 + num4, num9);
						gClass5.method_0(gclass76_0, num2, num3);
						if (gClass5.string_2 == null)
							continue;
						int num11 = int_57 + int_59 - 2 - gClass5.string_2.Length * 40;
						for (int k = 0; k < gClass5.string_2.Length; k++)
						{
							if (k == int_67 && j == int_66)
							{
								gclass76_0.method_31(GClass154.gclass2_25, num11 + k * 40 + 20, num7 + num9 / 2, GClass169.int_6);
								GClass49.gclass49_7.method_6(gclass76_0, gClass5.string_2[k], num11 + k * 40 + 20, num7 + 6, GClass49.int_2);
							}
							else
							{
								gclass76_0.method_31(GClass154.gclass2_24, num11 + k * 40 + 20, num7 + num9 / 2, GClass169.int_6);
								GClass49.gclass49_6.method_6(gclass76_0, gClass5.string_2[k], num11 + k * 40 + 20, num7 + 6, GClass49.int_2);
							}
						}
					}
				}
				else
				{
					gclass76_0.method_16((j != int_66) ? 15196114 : 16383818);
					gclass76_0.method_15(int_57, num7, int_59, num9);
					if (string_20 != null)
						GClass49.gclass49_6.method_6(gclass76_0, string_20, int_57 + int_59 / 2, num7 + 6, GClass49.int_2);
				}
				continue;
			}
			for (int l = 0; l < string_19.Length; l++)
			{
				gclass76_0.method_16((l != int_67 || j != int_66) ? 15723751 : 16383818);
				gclass76_0.method_15(num + l * int_5, num7, int_5 - 1, 23);
				for (int m = 0; m < string_19[l].Length; m++)
				{
					GClass49.gclass49_16.method_6(gclass76_0, string_19[l][m], num + l * int_5 + int_5 / 2, int_58 + m * 11, GClass49.int_2);
				}
			}
		}
		method_100(gclass76_0);
	}

	private void method_118(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		gclass76_0.method_16(0);
		if (int_41 == 0)
			GClass49.gclass49_14.method_6(gclass76_0, mResources.no_mission, int_57 + int_59 / 2, int_58 + int_60 / 2 - GClass49.gclass49_11.method_20() / 2, 2);
		else
		{
			if (GClass58.smethod_1().gclass79_0 == null || GClass58.smethod_1().gclass79_0.Length != int_41)
				return;
			for (int i = 0; i < int_41; i++)
			{
				int num = int_57;
				int num2 = int_58 + i * int_4;
				int num3 = int_59;
				int num4 = int_4 - 1;
				GClass79 gClass = GClass58.smethod_1().gclass79_0[i];
				gclass76_0.method_16((i != int_66 || ((gClass.bool_1 || gClass.bool_0) && (!gClass.bool_1 || !gClass.bool_0))) ? 15196114 : 16383818);
				gclass76_0.method_15(num, num2, num3, num4);
				if (gClass == null)
					continue;
				if (!gClass.bool_0)
				{
					GClass49.gclass49_11.method_6(gclass76_0, gClass.string_0, num + 5, num2, 0);
					GClass49.gclass49_19.method_6(gclass76_0, gClass.int_0 + " " + mResources.RUBY, num + num3 - 5, num2, GClass49.int_1);
					GClass49.gclass49_17.method_6(gclass76_0, gClass.string_1, num + 5, num2 + 11, 0);
				}
				else if (gClass.bool_0 && !gClass.bool_1)
				{
					GClass49.gclass49_11.method_6(gclass76_0, gClass.string_0, num + 5, num2, 0);
					GClass49.gclass49_18.method_6(gclass76_0, mResources.reward_mission + gClass.int_0 + " " + mResources.RUBY, num + 5, num2 + 11, 0);
					if (i == int_66)
					{
						GClass49.gclass49_7.method_6(gclass76_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass49.int_2);
						GClass49.gclass49_6.method_6(gclass76_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass49.int_2);
					}
					else
					{
						gclass76_0.method_31(GClass154.gclass2_24, num + num3 - 20, num2 + num4 / 2, GClass169.int_6);
						GClass49.gclass49_6.method_6(gclass76_0, mResources.receive_upper, num + num3 - 20, num2 + 6, GClass49.int_2);
					}
				}
				else if (gClass.bool_0 && gClass.bool_1)
				{
					GClass49.gclass49_19.method_6(gclass76_0, gClass.string_0, num + 5, num2, 0);
					GClass49.gclass49_19.method_6(gclass76_0, gClass.string_1, num + 5, num2 + 11, 0);
				}
			}
			method_100(gclass76_0);
		}
	}

	private void method_119(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		if (gclass63_0.method_2() == 0)
		{
			if (string_24 != null)
			{
				for (int i = 0; i < string_24.Length; i++)
				{
					GClass49.gclass49_6.method_6(gclass76_0, string_24[i], int_57 + int_59 / 2, int_58 + int_60 / 2 - string_24.Length * 14 / 2 + i * 14 + 5, 2);
				}
			}
			return;
		}
		for (int j = 0; j < gclass63_0.method_2() + 1; j++)
		{
			int num = int_57 + 36;
			int num2 = int_58 + j * int_4;
			int w = int_59 - 36;
			int num3 = int_4 - 1;
			int num4 = int_57;
			int num5 = int_58 + j * int_4;
			int num6 = 34;
			int num7 = int_4 - 1;
			if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
				continue;
			if (j == gclass63_0.method_2())
			{
				if (gclass63_0.method_2() > 0)
				{
					if (!GClass39.bool_5 && j == int_66)
					{
						gclass76_0.method_16(16383818);
						gclass76_0.method_15(num4, num2, int_59, num3 + 2);
					}
					if ((j == int_66 && int_101 == 1) || (!GClass39.bool_5 && j == int_66))
					{
						gclass76_0.method_31(GClass154.gclass2_23, int_57 + int_59 / 2, num2 + num3 / 2 + 1, GClass169.int_6);
						GClass49.gclass49_7.method_6(gclass76_0, mResources.UPGRADE, int_57 + int_59 / 2, num2 + num3 / 2 - 4, GClass49.int_2);
					}
					else
					{
						gclass76_0.method_31(GClass154.gclass2_22, int_57 + int_59 / 2, num2 + num3 / 2 + 1, GClass169.int_6);
						GClass49.gclass49_6.method_6(gclass76_0, mResources.UPGRADE, int_57 + int_59 / 2, num2 + num3 / 2 - 4, GClass49.int_2);
					}
				}
				continue;
			}
			gclass76_0.method_16((j != int_66) ? 15196114 : 16383818);
			gclass76_0.method_15(num, num2, w, num3);
			gclass76_0.method_16((j != int_66) ? 9993045 : 9541120);
			GClass121 gClass = (GClass121)gclass63_0.method_3(j);
			if (gClass != null)
			{
				for (int k = 0; k < gClass.gclass20_0.Length; k++)
				{
					if (gClass.gclass20_0[k].gclass114_0.int_0 == 72 && gClass.gclass20_0[k].int_0 > 0)
					{
						sbyte id = smethod_5(gClass.gclass20_0[k].int_0);
						if (smethod_4(id) != -1)
							gclass76_0.method_16((j != int_66) ? smethod_4(id) : smethod_4(id));
					}
				}
			}
			gclass76_0.method_15(num4, num5, num6, num7);
			if (gClass == null)
				continue;
			string text = string.Empty;
			GClass49 gClass2 = GClass49.gclass49_14;
			if (gClass.gclass20_0 != null)
			{
				for (int l = 0; l < gClass.gclass20_0.Length; l++)
				{
					if (gClass.gclass20_0[l].gclass114_0.int_0 == 72)
						text = " [+" + gClass.gclass20_0[l].int_0 + "]";
					if (gClass.gclass20_0[l].gclass114_0.int_0 == 41)
					{
						if (gClass.gclass20_0[l].int_0 == 1)
							gClass2 = smethod_6(0);
						else if (gClass.gclass20_0[l].int_0 == 2)
						{
							gClass2 = smethod_6(2);
						}
						else if (gClass.gclass20_0[l].int_0 == 3)
						{
							gClass2 = smethod_6(8);
						}
						else if (gClass.gclass20_0[l].int_0 == 4)
						{
							gClass2 = smethod_6(7);
						}
					}
				}
			}
			gClass2.method_6(gclass76_0, gClass.gclass118_0.string_0 + text, num + 5, num2 + 1, 0);
			string text2 = string.Empty;
			if (gClass.gclass20_0 != null)
			{
				if (gClass.gclass20_0.Length != 0 && gClass.gclass20_0[0] != null && gClass.gclass20_0[0].gclass114_0.int_0 != 102 && gClass.gclass20_0[0].gclass114_0.int_0 != 107)
					text2 += gClass.gclass20_0[0].method_0();
				GClass49 gClass3 = GClass49.gclass49_18;
				if (gClass.int_43 < 0 && gClass.gclass118_0.sbyte_0 != 5)
					gClass3 = GClass49.gclass49_17;
				if (gClass.gclass20_0.Length > 1)
				{
					for (int m = 1; m < gClass.gclass20_0.Length; m++)
					{
						if (gClass.gclass20_0[m] != null && gClass.gclass20_0[m].gclass114_0.int_0 != 102 && gClass.gclass20_0[m].gclass114_0.int_0 != 107)
							text2 = text2 + "," + gClass.gclass20_0[m].method_0();
					}
				}
				gClass3.method_6(gclass76_0, text2, num + 5, num2 + 11, GClass49.int_0);
			}
			GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num4 + num6 / 2, num5 + num7 / 2, 0, 3);
			if (gClass.gclass20_0 != null)
			{
				for (int n = 0; n < gClass.gclass20_0.Length; n++)
				{
					method_214(gclass76_0, gClass.gclass20_0[n].gclass114_0.int_0, gClass.gclass20_0[n].int_0, num4, num5, num6, num7);
				}
				for (int num8 = 0; num8 < gClass.gclass20_0.Length; num8++)
				{
					method_215(gclass76_0, gClass.gclass20_0[num8].gclass114_0.int_0, gClass.gclass20_0[num8].int_0, num4, num5, num6, num7);
				}
			}
			if (gClass.int_30 > 1)
				GClass49.gclass49_15.method_6(gclass76_0, string.Empty + gClass.int_30, num4 + num6, num5 + num7 - GClass49.gclass49_15.method_20(), 1);
		}
		method_100(gclass76_0);
	}

	private void method_120(GClass76 gclass76_0)
	{
		gclass76_0.method_16(16711680);
		GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
		GClass121[] array = GClass58.smethod_1().gclass121_0;
		int_41 = gclass121_.Length + array.Length;
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		try
		{
			for (int i = 0; i < int_41; i++)
			{
				int num = int_57 + 36;
				int num2 = int_58 + i * int_4;
				int w = int_59 - 36;
				int h = int_4 - 1;
				int num3 = int_57;
				int num4 = int_58 + i * int_4;
				int num5 = 34;
				int num6 = int_4 - 1;
				if (num2 - int_8 > int_58 + int_60 || num2 - int_8 < int_58 - int_4)
					continue;
				gclass76_0.method_16((i == int_66) ? 16383818 : ((i >= gclass121_.Length) ? 15723751 : 15196114));
				gclass76_0.method_15(num, num2, w, h);
				gclass76_0.method_16((i == int_66) ? 9541120 : ((i >= gclass121_.Length) ? 11837316 : 9993045));
				GClass121 gClass = ((i >= gclass121_.Length) ? array[i - gclass121_.Length] : gclass121_[i]);
				if (gClass != null)
				{
					for (int j = 0; j < gClass.gclass20_0.Length; j++)
					{
						if (gClass.gclass20_0[j].gclass114_0.int_0 == 72 && gClass.gclass20_0[j].int_0 > 0)
						{
							byte id = (byte)smethod_5(gClass.gclass20_0[j].int_0);
							if (smethod_4(id) != -1)
								gclass76_0.method_16((i != int_66) ? smethod_4(id) : smethod_4(id));
						}
					}
				}
				gclass76_0.method_15(num3, num4, num5, num6);
				if (gClass != null && gClass.bool_0 && GClass39.gclass45_0.int_28 == 12)
				{
					gclass76_0.method_16((i != int_66) ? 6047789 : 7040779);
					gclass76_0.method_15(num3, num4, num5, num6);
				}
				int num7 = 9;
				if (i > 9)
					GClass193.smethod_0().method_2(GClass49.gclass49_20, gclass76_0, (i - num7).ToString(), int_57 + 2, int_58 + i * int_4 - 2, 0, GClass49.gclass49_11);
				if (gClass == null)
					continue;
				string text = string.Empty;
				GClass49 gClass2 = GClass49.gclass49_14;
				if (gClass.gclass20_0 != null)
				{
					for (int k = 0; k < gClass.gclass20_0.Length; k++)
					{
						if (gClass.gclass118_0.short_0 == 1044 || gClass.gclass118_0.short_0 == 1211 || gClass.gclass118_0.short_0 == 1212)
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, 5);
						if (gClass.gclass118_0.short_0 == 1278 || gClass.gclass118_0.short_0 == 1279 || gClass.gclass118_0.short_0 == 1280)
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, 6);
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 72)
						{
							gClass.method_1(gclass76_0, int_57 + 18, int_58 + i * int_4 + 12, gClass.gclass20_0[k].int_0);
							text = " [+" + gClass.gclass20_0[k].int_0 + "]";
						}
						if (gClass.gclass20_0[k].gclass114_0.int_0 == 41)
						{
							if (gClass.gclass20_0[k].int_0 == 1)
								gClass2 = smethod_6(0);
							else if (gClass.gclass20_0[k].int_0 == 2)
							{
								gClass2 = smethod_6(2);
							}
							else if (gClass.gclass20_0[k].int_0 == 3)
							{
								gClass2 = smethod_6(8);
							}
							else if (gClass.gclass20_0[k].int_0 == 4)
							{
								gClass2 = smethod_6(7);
							}
						}
						if (i > num7)
							GClass193.smethod_0().method_2(GClass49.gclass49_20, gclass76_0, (i - num7).ToString(), int_57 + 2, int_58 + i * int_4 - 2, 0, GClass49.gclass49_11);
					}
				}
				string text2 = string.Empty;
				string text3 = string.Empty;
				if (gClass.gclass20_0 != null)
				{
					for (int l = 0; l < gClass.gclass20_0.Length; l++)
					{
						text3 = text3 + gClass.gclass20_0[l].gclass114_0.int_0 + "-";
					}
				}
				foreach (GClass183.GStruct3 item in GClass183.smethod_0().list_2)
				{
					if (gClass.gclass118_0.short_0 == item.int_0 && text3 == item.string_0 && gClass.gclass118_0.sbyte_0 == item.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[SP1]: " : "[MS1]: ");
						gclass76_0.method_20(13959423, 0.3f);
						gclass76_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass183.GStruct6 item2 in GClass183.smethod_0().list_3)
				{
					if (gClass.gclass118_0.short_0 == item2.int_0 && text3 == item2.string_0 && gClass.gclass118_0.sbyte_0 == item2.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[SP2]: " : "[MS2]: ");
						gclass76_0.method_20(13959423, 0.3f);
						gclass76_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass183.GStruct2 item3 in GClass183.smethod_0().list_4)
				{
					if (gClass.gclass118_0.short_0 == item3.int_0 && text3 == item3.string_0 && gClass.gclass118_0.sbyte_0 == item3.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[ĐT1]: " : "[DS1]: ");
						gclass76_0.method_20(13959423, 0.3f);
						gclass76_0.method_15(num, num2, w, h);
					}
				}
				foreach (GClass183.GStruct5 item4 in GClass183.smethod_0().list_5)
				{
					if (gClass.gclass118_0.short_0 == item4.int_0 && text3 == item4.string_0 && gClass.gclass118_0.sbyte_0 == item4.int_1)
					{
						text2 = ((GClass192.int_0 == 0) ? "[ĐT2]: " : "[DS2]: ");
						gclass76_0.method_20(13959423, 0.3f);
						gclass76_0.method_15(num, num2, w, h);
					}
				}
				gClass2.method_6(gclass76_0, text2 + gClass.gclass118_0.string_0 + text, num + 5, num2 + 1, 0);
				string text4 = string.Empty;
				string text5 = string.Empty;
				if (gClass.gclass20_0 != null)
				{
					if (gClass.gclass20_0.Length != 0 && gClass.gclass20_0[0] != null && gClass.gclass20_0[0].gclass114_0.int_0 != 102 && gClass.gclass20_0[0].gclass114_0.int_0 != 107)
						text4 = ((gClass.gclass118_0.short_0 != 529 && gClass.gclass118_0.short_0 != 530 && gClass.gclass118_0.short_0 != 531 && gClass.gclass118_0.short_0 != 534 && gClass.gclass118_0.short_0 != 535 && gClass.gclass118_0.short_0 != 536) ? (text4 + gClass.gclass20_0[0].method_0()) : ((GClass192.int_0 == 0) ? (gClass.gclass20_0[0].method_0().Split(' ')[3] + " phút") : (gClass.gclass20_0[0].method_0().Split(' ')[3] + " minute")));
					GClass49 gClass3 = GClass49.gclass49_18;
					if (gClass.int_43 < 0 && gClass.gclass118_0.sbyte_0 != 5)
						gClass3 = GClass49.gclass49_17;
					if (gClass.gclass20_0.Length > 1)
					{
						for (int m = 1; m < gClass.gclass20_0.Length; m++)
						{
							if (gClass.gclass20_0[m] != null && gClass.gclass20_0[m].gclass114_0.int_0 != 102 && gClass.gclass20_0[m].gclass114_0.int_0 != 107 && gClass.gclass20_0[m].method_0().StartsWith("Set"))
								text4 = text4 + "," + gClass.gclass20_0[m].method_0();
						}
						for (int n = 1; n < gClass.gclass20_0.Length; n++)
						{
							if (gClass.gclass20_0[n] == null || gClass.method_0())
								continue;
							if ((gClass.gclass118_0.sbyte_0 >= 0 && gClass.gclass118_0.sbyte_0 <= 4) || gClass.gclass118_0.sbyte_0 == 32)
								try
								{
									int num8 = n;
									GClass121 gClass4 = gClass;
									sbyte language = mResources.language;
									if (language != 0)
									{
										if (language != 1)
											continue;
										int num9 = gClass4.gclass20_0[num8].gclass114_0.int_0;
										if (num9 <= 81)
										{
											if (num9 != 50)
											{
												switch (num9)
												{
												case 77:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + " HP";
													break;
												case 80:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP") : ("Heal " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP"));
													break;
												case 81:
													text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + ((GClass192.int_0 == 0) ? ("Hồi " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " KI") : ("Heal " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " MP"));
													break;
												case 78:
												case 79:
													break;
												}
											}
											else
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " SĐ" : " DMG");
											continue;
										}
										switch (num9)
										{
										case 94:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[2] + ((GClass192.int_0 == 0) ? " Giáp" : " AMR");
											continue;
										case 95:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HM" : " BS");
											continue;
										case 96:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " HK" : " MS");
											continue;
										case 97:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + ((GClass192.int_0 == 0) ? " PST" : " CD");
											continue;
										case 101:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " TNSM" : " Power,SP");
											continue;
										case 103:
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + ((GClass192.int_0 == 0) ? " KI" : " MP");
											continue;
										case 98:
										case 99:
										case 100:
										case 102:
											continue;
										}
										if (num9 == 108)
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[0] + ((GClass192.int_0 == 0) ? " Né đòn" : " Dodge");
										continue;
									}
									int num10 = gClass4.gclass20_0[num8].gclass114_0.int_0;
									if (num10 <= 81)
									{
										if (num10 != 50)
										{
											switch (num10)
											{
											case 77:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + " HP";
												break;
											case 80:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + "Hồi " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " HP";
												break;
											case 81:
												text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + "Hồi " + gClass4.gclass20_0[num8].method_0().Split('+')[1].Split('/')[0] + " KI";
												break;
											case 78:
											case 79:
												break;
											}
										}
										else
											text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + " SĐ";
										continue;
									}
									switch (num10)
									{
									case 94:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + " Giáp";
										continue;
									case 95:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + " HM";
										continue;
									case 96:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + " HK";
										continue;
									case 97:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[1] + " PST";
										continue;
									case 101:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[0] + " TNSM";
										continue;
									case 103:
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split('+')[1] + " KI";
										continue;
									case 98:
									case 99:
									case 100:
									case 102:
										continue;
									}
									if (num10 == 108)
										text5 = text5 + ((text5 == string.Empty) ? "" : ", ") + gClass4.gclass20_0[num8].method_0().Split(' ')[0] + " Né đòn";
								}
								catch (Exception)
								{
								}
							else if (gClass.gclass118_0.sbyte_0 > 4 && gClass.gclass118_0.sbyte_0 != 32)
							{
								text4 = text4 + "," + gClass.gclass20_0[n].method_0();
							}
						}
					}
					if (gClass.gclass118_0.short_0 != 460)
						gClass3.method_6(gclass76_0, text4, num + 5, num2 + 11, GClass49.int_0);
					else
						gClass3.method_6(gclass76_0, "Ném cho Văn Khánh", num + 5, num2 + 11, GClass49.int_0);
				}
				GClass96.smethod_6(gclass76_0, gClass.gclass118_0.short_1, num3 + num5 / 2, num4 + num6 / 2, 0, 3);
				GClass49.gclass49_18.method_10(gclass76_0, text5, int_57 + int_59 - 2, int_58 + i * int_4 + 11, GClass49.int_1, GClass49.gclass49_20);
				if (gClass.gclass20_0 != null)
				{
					for (int num11 = 0; num11 < gClass.gclass20_0.Length; num11++)
					{
						method_214(gclass76_0, gClass.gclass20_0[num11].gclass114_0.int_0, gClass.gclass20_0[num11].int_0, num3, num4, num5, num6);
					}
					for (int num12 = 0; num12 < gClass.gclass20_0.Length; num12++)
					{
						method_215(gclass76_0, gClass.gclass20_0[num12].gclass114_0.int_0, gClass.gclass20_0[num12].int_0, num3, num4, num5, num6);
					}
					for (int num13 = 0; num13 < gClass.gclass20_0.Length; num13++)
					{
						int num14 = 0;
						int num15 = 0;
						int num16 = 0;
						if (gClass.gclass20_0[num13].int_0 > 0)
						{
							if (gClass.gclass20_0[num13].gclass114_0.int_0 == 107)
								num15 = gClass.gclass20_0[num13].int_0;
							if (num14 > num15)
								num16 = num14;
							else if (num14 < num15)
							{
								num16 = num15;
							}
							else if (num14 == num15)
							{
								num16 = num14;
							}
						}
						if (num16 > 0)
						{
							GClass193.smethod_0().method_2(GClass49.gclass49_3, gclass76_0, num16.ToString(), int_57 + int_59 - 17, int_58 + i * int_4, 0, GClass49.gclass49_2);
							gclass76_0.method_33(gclass2_3, int_57 + int_59 - 11, int_58 + i * int_4 + 1);
						}
					}
				}
				if (gClass.int_30 > 1)
					GClass49.gclass49_15.method_6(gclass76_0, string.Empty + gClass.int_30, num3 + num5, num4 + num6 - GClass49.gclass49_15.method_20(), 1);
			}
		}
		catch (Exception)
		{
		}
		method_100(gclass76_0);
	}

	private void method_121(GClass76 gclass76_0)
	{
		if (int_28 == 23 || int_28 == 24)
		{
			for (int i = 0; i < GClass198.smethod_0().string_0.Length; i++)
			{
				gclass76_0.method_16((i != int_29) ? 16773296 : 6805896);
				GClass24.smethod_4(gclass76_0, int_30 + i * int_5, 52, int_5 - 1, 25, (i == int_29) ? 1 : 0, true);
				if (i == int_104)
					gclass76_0.method_31(GClass134.gclass2_0, int_30 + i * int_5 + int_5 / 2, 62, 3);
				GClass49 gClass = ((i != int_29) ? GClass49.gclass49_16 : GClass49.gclass49_14);
				if (!GClass198.smethod_0().string_0[i][1].Equals(string.Empty))
				{
					gClass.method_6(gclass76_0, GClass198.smethod_0().string_0[i][0], int_30 + i * int_5 + int_5 / 2, 53, GClass49.int_2);
					gClass.method_6(gclass76_0, GClass198.smethod_0().string_0[i][1], int_30 + i * int_5 + int_5 / 2, 64, GClass49.int_2);
				}
				else
					gClass.method_6(gclass76_0, GClass198.smethod_0().string_0[i][0], int_30 + i * int_5 + int_5 / 2, 59, GClass49.int_2);
				if (int_28 == 0 && GClass198.smethod_0().string_0.Length == 5 && GClass154.bool_59 && GClass39.int_8 % 4 == 0)
					gclass76_0.method_31(GClass134.gclass2_0, int_30 + 3 * int_5 + int_5 / 2, 77, GClass76.int_5 | GClass76.int_0);
			}
		}
		if (int_28 == 100)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, "Thông tin boss", int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 20)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.account, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 22)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.autoFunction, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 19)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.option, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 18)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.change_flag, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 13 && Equals(GClass39.gclass45_1))
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.item_receive2, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 12 && GClass39.gclass45_1 != null)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.UPGRADE, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 11)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.friend, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 16)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.enemy, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 15)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, string_0, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 2 && GClass39.gclass45_1 != null)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.chest, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 9)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.achievement_mission, int_57 + int_59 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 3)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.select_zone, int_30 + int_5 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 14)
		{
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			GClass49.gclass49_6.method_6(gclass76_0, mResources.select_map, int_30 + int_5 / 2, 59, GClass49.int_2);
			return;
		}
		if (int_28 == 4)
		{
			GClass49.gclass49_6.method_6(gclass76_0, mResources.map, int_30 + int_5 / 2, 59, GClass49.int_2);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			return;
		}
		if (int_28 == 7)
		{
			GClass49.gclass49_6.method_6(gclass76_0, mResources.trangbi, int_30 + int_5 / 2, 59, GClass49.int_2);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			return;
		}
		if (int_28 == 17)
		{
			GClass49.gclass49_6.method_6(gclass76_0, mResources.kigui, int_30 + int_5 / 2, 59, GClass49.int_2);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			return;
		}
		if (int_28 == 8)
		{
			GClass49.gclass49_6.method_6(gclass76_0, mResources.msg, int_30 + int_5 / 2, 59, GClass49.int_2);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			return;
		}
		if (int_28 == 10)
		{
			GClass49.gclass49_6.method_6(gclass76_0, mResources.wat_do_u_want, int_30 + int_5 / 2, 59, GClass49.int_2);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, 78, int_2 - 2, 1);
			return;
		}
		if (int_29 == 3 && string_3.Length != 4)
			gclass76_0.method_1(-int_15, 0);
		for (int j = 0; j < string_2.Length; j++)
		{
			gclass76_0.method_16((j != int_29) ? 16773296 : 6805896);
			GClass24.smethod_4(gclass76_0, int_30 + j * int_5, 52, int_5 - 1, 25, (j == int_29) ? 1 : 0, true);
			if (j == int_104)
				gclass76_0.method_31(GClass134.gclass2_0, int_30 + j * int_5 + int_5 / 2, 62, 3);
			GClass49 gClass2 = ((j != int_29) ? GClass49.gclass49_16 : GClass49.gclass49_14);
			if (!string_2[j][1].Equals(string.Empty))
			{
				gClass2.method_6(gclass76_0, string_2[j][0], int_30 + j * int_5 + int_5 / 2, 53, GClass49.int_2);
				gClass2.method_6(gclass76_0, string_2[j][1], int_30 + j * int_5 + int_5 / 2, 64, GClass49.int_2);
			}
			else
				gClass2.method_6(gclass76_0, string_2[j][0], int_30 + j * int_5 + int_5 / 2, 59, GClass49.int_2);
			if (int_28 == 0 && string_2.Length == 5 && GClass154.bool_59 && GClass39.int_8 % 4 == 0)
				gclass76_0.method_31(GClass134.gclass2_0, int_30 + 3 * int_5 + int_5 / 2, 77, GClass76.int_5 | GClass76.int_0);
		}
		gclass76_0.method_16(13524492);
		gclass76_0.method_15(1, 78, int_2 - 2, 1);
	}

	private void method_122(GClass76 gclass76_0)
	{
		if (int_28 != 13 || (int_29 != 2 && !Equals(GClass39.gclass45_1)))
		{
			gclass76_0.method_5(0, 0, GClass39.int_10, GClass39.int_11);
			gclass76_0.method_16(11837316);
			gclass76_0.method_15(int_0 + 1, int_3 - 15, int_2 - 2, 14);
			gclass76_0.method_16(13524492);
			gclass76_0.method_15(int_0 + 1, int_3 - 15, int_2 - 2, 1);
			gclass76_0.method_31(gclass2_7, int_0 + 11, int_3 - 7, 3);
			gclass76_0.method_31(gclass2_9, int_0 + 75, int_3 - 8, 3);
			GClass49.gclass49_15.method_10(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().long_6) + string.Empty, int_0 + 24, int_3 - 13, GClass49.int_0, GClass49.gclass49_16);
			GClass49.gclass49_15.method_10(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().int_68) + string.Empty, int_0 + 85, int_3 - 13, GClass49.int_0, GClass49.gclass49_16);
			gclass76_0.method_31(gclass2_10, int_0 + 130, int_3 - 8, 3);
			GClass49.gclass49_15.method_10(gclass76_0, GClass95.smethod_9(GClass58.smethod_1().int_69) + string.Empty, int_0 + 140, int_3 - 13, GClass49.int_0, GClass49.gclass49_16);
		}
	}

	private void method_123(GClass76 gclass76_0)
	{
		if (GClass58.smethod_1().gclass21_0 == null)
		{
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), 25, 50, 0, 33);
			GClass49.gclass49_3.method_6(gclass76_0, mResources.not_join_clan, (int_59 - 50) / 2 + 50, 20, GClass49.int_2);
		}
		else if (!bool_12)
		{
			GClass21 gClass = GClass58.smethod_1().gclass21_0;
			if (gClass != null)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), 25, 50, 0, 33);
				GClass49.gclass49_3.method_10(gclass76_0, gClass.string_0, 60, 4, GClass49.int_0, GClass49.gclass49_6);
				GClass49.gclass49_15.method_10(gclass76_0, mResources.achievement_point + ": " + gClass.string_2, 60, 16, GClass49.int_0, GClass49.gclass49_16);
				GClass49.gclass49_15.method_10(gclass76_0, mResources.clan_point + ": " + gClass.int_7, 60, 27, GClass49.int_0, GClass49.gclass49_16);
				GClass49.gclass49_15.method_10(gclass76_0, mResources.level + ": " + gClass.int_6, 60, 38, GClass49.int_0, GClass49.gclass49_16);
				GClass164.smethod_1(gclass76_0, gClass.string_1, 60, 38, int_59 - 70, int_4, GClass49.gclass49_15);
			}
		}
		else
		{
			GClass21 gClass2 = ((gclass21_0 == null) ? GClass58.smethod_1().gclass21_0 : gclass21_0);
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), 25, 50, 0, 33);
			GClass49.gclass49_3.method_10(gclass76_0, gClass2.string_0, 60, 4, GClass49.int_0, GClass49.gclass49_6);
			GClass49.gclass49_15.method_10(gclass76_0, mResources.member + ": " + gClass2.int_3 + "/" + gClass2.int_4, 60, 16, GClass49.int_0, GClass49.gclass49_16);
			GClass49.gclass49_15.method_10(gclass76_0, mResources.clan_leader + ": " + gClass2.string_3, 60, 27, GClass49.int_0, GClass49.gclass49_16);
			GClass164.smethod_1(gclass76_0, gClass2.string_1, 60, 38, int_59 - 70, int_4, GClass49.gclass49_15);
		}
	}

	private void method_124(GClass76 gclass76_0)
	{
		GClass49.gclass49_3.method_10(gclass76_0, "Dragon Ball Pro " + GClass113.string_2, 60, 4, GClass49.int_0, GClass49.gclass49_6);
		GClass49.gclass49_15.method_10(gclass76_0, (GClass192.int_0 == 0) ? ("Phiên bản hiện tại: " + GClass192.string_1) : ("Current version: " + GClass192.string_1), 60, 16, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, (GClass192.int_0 == 0) ? "Phiên bản được tạo bởi" : "This mod created by", 60, 27, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, "Lê Chí Thanh [thanhlc.com]", 60, 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_125(GClass76 gclass76_0)
	{
		GClass49.gclass49_15.method_10(gclass76_0, mResources.select_item, 60, 4, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.lock_trade, 60, 16, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.wait_opp_lock_trade, 60, 27, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.press_done, 60, 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_126(GClass76 gclass76_0)
	{
		method_128(gclass76_0, GClass58.smethod_1());
	}

	private void method_127(GClass76 gclass76_0)
	{
		GClass49.gclass49_15.method_10(gclass76_0, mResources.power + ": " + GClass95.smethod_9(GClass58.smethod_2().long_2), int_0 + 60, 4, GClass49.int_0, GClass49.gclass49_16);
		if (GClass58.smethod_2().long_2 > 0L)
			GClass49.gclass49_15.method_10(gclass76_0, (!GClass58.smethod_2().bool_10) ? GClass58.smethod_2().string_6 : GClass58.smethod_2().method_6(), int_0 + 60, 16, GClass49.int_0, GClass49.gclass49_16);
		if (GClass58.smethod_2().int_20 > 0)
			GClass49.gclass49_15.method_10(gclass76_0, mResources.hit_point + ": " + GClass58.smethod_2().int_20, int_0 + 60, 27, GClass49.int_0, GClass49.gclass49_16);
		if (GClass58.smethod_2().short_24 > 0)
		{
			GClass49.gclass49_15.method_10(gclass76_0, mResources.vitality, int_0 + 60, 38, GClass49.int_0, GClass49.gclass49_16);
			gclass76_0.method_31(GClass154.gclass2_34, int_0 + 100, 41, 0);
			gclass76_0.method_5(w: GClass58.smethod_2().int_77 * GClass76.smethod_0(GClass154.gclass2_31) / GClass58.smethod_2().short_24, x: 100, y: int_0 + 41, h: 20);
			gclass76_0.method_31(GClass154.gclass2_31, int_0 + 100, 41, 0);
		}
		gclass76_0.method_5(0, 0, GClass39.int_10, GClass39.int_11);
	}

	private void method_128(GClass76 gclass76_0, GClass58 gclass58_2)
	{
		GClass49.gclass49_3.method_10(gclass76_0, ((GClass154.sbyte_13 == 1) ? "       " : string.Empty) + gclass58_2.string_3, int_0 + 60, 4, GClass49.int_0, GClass49.gclass49_6);
		if (GClass154.sbyte_13 == 1)
			GClass96.smethod_6(gclass76_0, 5427, int_0 + 55, 4, 0, 0);
		if (gclass58_2.short_24 > 0)
		{
			GClass49.gclass49_15.method_10(gclass76_0, mResources.vitality, int_0 + 60, 16, GClass49.int_0, GClass49.gclass49_16);
			gclass76_0.method_31(GClass154.gclass2_34, int_0 + 95, 19, 0);
			gclass76_0.method_5(w: gclass58_2.int_77 * GClass76.smethod_0(GClass154.gclass2_31) / gclass58_2.short_24, x: 95, y: int_0 + 19, h: 20);
			gclass76_0.method_31(GClass154.gclass2_31, int_0 + 95, 19, 0);
		}
		gclass76_0.method_5(0, 0, GClass39.int_10, GClass39.int_11);
		if (gclass58_2.long_2 > 0L)
			GClass49.gclass49_15.method_10(gclass76_0, (!gclass58_2.bool_10) ? gclass58_2.string_6 : gclass58_2.method_6(), int_0 + 60, 27, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.power + ": " + GClass95.smethod_9(gclass58_2.long_2), int_0 + 60, 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_129(GClass76 gclass76_0, GClass58 gclass58_2, int int_177, int int_178)
	{
		GClass49.gclass49_3.method_10(gclass76_0, ((GClass154.sbyte_13 == 1) ? "       " : string.Empty) + gclass58_2.string_3, int_177 + 60, int_178 + 4, GClass49.int_0, GClass49.gclass49_6);
		if (GClass154.sbyte_13 == 1)
			GClass96.smethod_6(gclass76_0, 5427, int_177 + 55, int_178 + 4, 0, 0);
		if (gclass58_2.short_24 > 0)
		{
			GClass49.gclass49_15.method_10(gclass76_0, mResources.vitality, int_177 + 60, int_178 + 16, GClass49.int_0, GClass49.gclass49_16);
			gclass76_0.method_31(GClass154.gclass2_34, int_177 + 95, int_178 + 19, 0);
			_ = gclass58_2.int_77 * GClass76.smethod_0(GClass154.gclass2_31) / gclass58_2.short_24;
			gclass76_0.method_31(GClass154.gclass2_31, int_177 + 95, int_178 + 19, 0);
		}
		if (gclass58_2.long_2 > 0L)
			GClass49.gclass49_15.method_10(gclass76_0, (!gclass58_2.bool_10) ? gclass58_2.string_6 : gclass58_2.method_6(), int_177 + 60, int_178 + 27, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.power + ": " + GClass95.smethod_9(gclass58_2.long_2), int_177 + 60, int_178 + 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_130(GClass76 gclass76_0)
	{
		GClass49.gclass49_3.method_10(gclass76_0, mResources.zone + " " + GClass1.int_39, 60, 4, GClass49.int_0, GClass49.gclass49_6);
		GClass49.gclass49_15.method_10(gclass76_0, GClass1.string_1, 60, 16, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_3.method_6(gclass76_0, GClass1.int_39 + string.Empty, 25, 27, GClass49.int_2);
	}

	public int method_131(GClass121 item)
	{
		if (item == null)
			return -1;
		if (item.method_11())
		{
			if (item.gclass20_0 == null)
				return -1;
			GClass20 gClass = item.gclass20_0[0];
			if (gClass.gclass114_0.int_0 == 22)
			{
				gClass.gclass114_0 = GClass154.smethod_8().gclass114_0[6];
				gClass.int_0 *= 1000;
			}
			if (gClass.gclass114_0.int_0 == 23)
			{
				gClass.gclass114_0 = GClass154.smethod_8().gclass114_0[7];
				gClass.int_0 *= 1000;
			}
			GClass121 gClass2 = null;
			for (int i = 0; i < GClass58.smethod_1().gclass121_2.Length; i++)
			{
				GClass121 gClass3 = GClass58.smethod_1().gclass121_2[i];
				if (gClass.gclass114_0.int_0 == 22)
				{
					gClass.gclass114_0 = GClass154.smethod_8().gclass114_0[6];
					gClass.int_0 *= 1000;
				}
				if (gClass.gclass114_0.int_0 == 23)
				{
					gClass.gclass114_0 = GClass154.smethod_8().gclass114_0[7];
					gClass.int_0 *= 1000;
				}
				if (gClass3 != null && gClass3.gclass20_0 != null && gClass3.gclass118_0.sbyte_0 == item.gclass118_0.sbyte_0)
				{
					gClass2 = gClass3;
					break;
				}
			}
			if (gClass2 == null)
			{
				bool_19 = true;
				return gClass.int_0;
			}
			int num = 0;
			num = ((gClass2 == null || gClass2.gclass20_0 == null) ? gClass.int_0 : (gClass.int_0 - gClass2.gclass20_0[0].int_0));
			if (num < 0)
				bool_19 = false;
			else
				bool_19 = true;
			return num;
		}
		return 0;
	}

	private void method_132(GClass76 gclass76_0)
	{
		GClass49.gclass49_3.method_6(gclass76_0, mResources.MENUGENDER[GClass1.sbyte_2], 60, 4, GClass49.int_0);
		string text = string.Empty;
		if (GClass1.int_37 >= 135 && GClass1.int_37 <= 138)
			text = " " + mResources.tang + GClass1.int_39;
		GClass49.gclass49_15.method_6(gclass76_0, GClass1.string_1 + text, 60, 16, GClass49.int_0);
		GClass49.gclass49_3.method_6(gclass76_0, mResources.quest_place + ": ", 60, 27, GClass49.int_0);
		if (GClass154.smethod_27() >= 0 && GClass154.smethod_27() <= GClass1.string_2.Length - 1)
			GClass49.gclass49_15.method_6(gclass76_0, GClass1.string_2[GClass154.smethod_27()], 60, 38, GClass49.int_0);
		else
			GClass49.gclass49_15.method_6(gclass76_0, mResources.random, 60, 38, GClass49.int_0);
	}

	private void method_133(GClass76 gclass76_0)
	{
		if (int_29 == string_2.Length - 1 && GClass39.gclass45_1 == null)
			method_126(gclass76_0);
		else if (int_66 < 0)
		{
			if (int_56 != 2)
			{
				GClass49.gclass49_20.method_6(gclass76_0, mResources.say_hello, int_0 + 60, 14, 0);
				GClass49.gclass49_20.method_6(gclass76_0, string_26, int_0 + 60, 26, 0);
				return;
			}
			GClass49.gclass49_20.method_6(gclass76_0, mResources.say_hello, int_0 + 60, 5, 0);
			GClass49.gclass49_20.method_6(gclass76_0, string_26, int_0 + 60, 17, 0);
			GClass49.gclass49_20.method_6(gclass76_0, mResources.page + " " + (int_38[int_29] + 1) + "/" + int_37[int_29], int_0 + 60, 29, 0);
		}
		else
		{
			if (int_29 < 0 || int_29 > GClass58.smethod_1().gclass121_3.Length - 1 || int_66 < 0 || int_66 > GClass58.smethod_1().gclass121_3[int_29].Length - 1)
				return;
			GClass121 gClass = GClass58.smethod_1().gclass121_3[int_29][int_66];
			if (gClass != null)
			{
				if (Equals(GClass39.gclass45_0) && int_29 <= 3 && int_56 == 2)
					GClass49.gclass49_3.method_6(gclass76_0, mResources.page + " " + (int_38[int_29] + 1) + "/" + int_37[int_29], int_0 + 55, 4, 0);
				GClass49.gclass49_3.method_6(gclass76_0, gClass.gclass118_0.string_0, int_0 + 55, 24, 0);
				string st = mResources.pow_request + " " + GClass56.smethod_31(gClass.gclass118_0.int_2);
				if (gClass.gclass118_0.int_2 > GClass58.smethod_1().long_2)
					GClass49.gclass49_15.method_6(gclass76_0, st, int_0 + 55, 35, 0);
				else
					GClass49.gclass49_19.method_6(gclass76_0, st, int_0 + 55, 35, 0);
			}
		}
	}

	private void method_134(GClass76 gclass76_0)
	{
		string st = mResources.used + ": " + int_39 + "/" + GClass58.smethod_1().gclass121_1.Length + " " + mResources.place;
		GClass49.gclass49_3.method_6(gclass76_0, mResources.chest, 60, 4, 0);
		GClass49.gclass49_15.method_6(gclass76_0, st, 60, 16, 0);
	}

	private void method_135(GClass76 gclass76_0)
	{
		GClass49.gclass49_20.method_6(gclass76_0, "Top " + GClass58.smethod_1().int_3, int_0 + 45 + (int_2 - 50) / 2, 2, GClass49.int_2);
		GClass49.gclass49_15.method_6(gclass76_0, mResources.potential_point, int_0 + 45 + (int_2 - 50) / 2, 14, GClass49.int_2);
		GClass49.gclass49_20.method_6(gclass76_0, string.Empty + GClass95.smethod_9(GClass58.smethod_1().long_4), int_0 + ((GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0) + 45 + (int_2 - 50) / 2, 26, GClass49.int_2);
		GClass49.gclass49_15.method_6(gclass76_0, mResources.active_point + ": " + GClass95.smethod_9(GClass58.smethod_1().long_5), int_0 + ((GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0) + 45 + (int_2 - 50) / 2, 38, GClass49.int_2);
	}

	private void method_136(GClass76 gclass76_0)
	{
		GClass49.gclass49_15.method_10(gclass76_0, mResources.HP + ": " + GClass95.smethod_9(GClass58.smethod_1().int_25) + " / " + GClass95.smethod_9(GClass58.smethod_1().int_35), int_0 + 60, 2, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.KI + ": " + GClass95.smethod_9(GClass58.smethod_1().int_24) + " / " + GClass95.smethod_9(GClass58.smethod_1().int_36), int_0 + 60, 14, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.hit_point + ": " + GClass95.smethod_9(GClass58.smethod_1().int_20), int_0 + 60, 26, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.armor + ": " + GClass95.smethod_9(GClass58.smethod_1().int_21) + ", " + mResources.critical + ": " + GClass58.smethod_1().int_22 + "%", int_0 + 60, 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_137(GClass76 gclass76_0, int int_177, int int_178)
	{
		GClass49.gclass49_15.method_10(gclass76_0, mResources.HP + ": " + GClass58.smethod_1().int_25 + " / " + GClass58.smethod_1().int_35, int_177, int_178 + 2, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.KI + ": " + GClass58.smethod_1().int_24 + " / " + GClass58.smethod_1().int_36, int_177, int_178 + 14, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.hit_point + ": " + GClass58.smethod_1().int_20, int_177, int_178 + 26, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.armor + ": " + GClass58.smethod_1().int_21 + ", " + mResources.critical + ": " + GClass58.smethod_1().int_22 + "%", int_177, int_178 + 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_138(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_0 + 1, int_1, int_2 - 2, int_58 - 2);
		gclass76_0.method_16(9993045);
		gclass76_0.method_15(int_0, int_1, int_2 - 2, 50);
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
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_126(gclass76_0);
			}
			if (int_29 == 1)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				if (bool_30)
					method_128(gclass76_0, GClass58.smethod_1());
				else
					method_136(gclass76_0);
			}
			if (int_29 == 2)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_135(gclass76_0);
			}
			if (int_29 == 3)
			{
				if (string_3.Length == 5)
					method_123(gclass76_0);
				else
				{
					GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
					method_124(gclass76_0);
				}
			}
			if (int_29 == 4)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_124(gclass76_0);
			}
			break;
		case 1:
			if (int_29 == string_2.Length - 1 && GClass39.gclass45_1 == null)
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			else if (GClass58.smethod_1().gclass59_0 != null)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().gclass59_0.int_70, int_0 + 25, 50, 0, 33);
			}
			method_133(gclass76_0);
			break;
		case 2:
			if (int_29 == 0)
			{
				GClass96.smethod_6(gclass76_0, 526, int_0 + 25, 50, 0, 33);
				method_134(gclass76_0);
			}
			if (int_29 == 1)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_136(gclass76_0);
			}
			break;
		case 3:
			GClass96.smethod_6(gclass76_0, 561, int_0 + 25, 50, 0, 33);
			method_130(gclass76_0);
			break;
		case 4:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_132(gclass76_0);
			break;
		case 8:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 9:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 10:
			if (gclass58_0 != null)
			{
				GClass96.smethod_6(gclass76_0, gclass58_0.method_7(), int_0 + 25, 50, 0, 33);
				method_128(gclass76_0, gclass58_0);
			}
			break;
		case 12:
			if (int_29 == 0)
			{
				int id = 1410;
				for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
				{
					GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
					if (gClass.gclass90_0.int_0 == int_148)
						id = gClass.int_70;
				}
				GClass96.smethod_6(gclass76_0, id, int_0 + 25, 50, 0, 33);
				method_143(gclass76_0);
			}
			if (int_29 == 1)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_126(gclass76_0);
			}
			break;
		case 13:
			if (int_29 == 0 || int_29 == 1)
			{
				if (Equals(GClass39.gclass45_0))
				{
					GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
					method_125(gclass76_0);
				}
				if (Equals(GClass39.gclass45_1) && gclass58_0 != null)
				{
					GClass96.smethod_6(gclass76_0, gclass58_0.method_7(), int_0 + 25, 50, 0, 33);
					method_128(gclass76_0, gclass58_0);
				}
			}
			if (int_29 == 2 && gclass58_0 != null)
			{
				GClass96.smethod_6(gclass76_0, gclass58_0.method_7(), int_0 + 25, 50, 0, 33);
				method_128(gclass76_0, gclass58_0);
			}
			break;
		case 14:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_132(gclass76_0);
			break;
		case 15:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 7:
		case 17:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 18:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 19:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_124(gclass76_0);
			break;
		case 20:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_124(gclass76_0);
			break;
		case 21:
			if (int_29 == 0)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_2().method_7(), int_0 + 25, 50, 0, 33);
				method_127(gclass76_0);
			}
			if (int_29 == 1)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_2().method_7(), int_0 + 25, 50, 0, 33);
				method_142(gclass76_0);
			}
			if (int_29 == 2)
			{
				GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
				method_136(gclass76_0);
			}
			break;
		case 22:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_124(gclass76_0);
			break;
		case 11:
		case 16:
		case 23:
		case 24:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 25:
			GClass96.smethod_6(gclass76_0, GClass58.smethod_1().method_7(), int_0 + 25, 50, 0, 33);
			method_126(gclass76_0);
			break;
		case 5:
		case 6:
			break;
		}
	}

	private void method_139(GClass76 gclass76_0)
	{
	}

	private void method_140(GClass76 gclass76_0)
	{
	}

	private string method_141(int int_177)
	{
		switch (int_177)
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

	private void method_142(GClass76 gclass76_0)
	{
		GClass49.gclass49_3.method_10(gclass76_0, "HP: " + GClass58.smethod_2().int_25 + "/" + GClass58.smethod_2().int_35, int_0 + 60, 4, GClass49.int_0, GClass49.gclass49_6);
		GClass49.gclass49_3.method_10(gclass76_0, "MP: " + GClass58.smethod_2().int_24 + "/" + GClass58.smethod_2().int_36, int_0 + 60, 16, GClass49.int_0, GClass49.gclass49_6);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.critical + ": " + GClass58.smethod_2().int_22 + "   " + mResources.armor + ": " + GClass58.smethod_2().int_21, int_0 + 60, 27, GClass49.int_0, GClass49.gclass49_16);
		GClass49.gclass49_15.method_10(gclass76_0, mResources.status + ": " + string_22[GClass58.smethod_2().sbyte_15], int_0 + 60, 38, GClass49.int_0, GClass49.gclass49_16);
	}

	private void method_143(GClass76 gclass76_0)
	{
		if (string_25 != null)
		{
			for (int i = 0; i < string_25.Length; i++)
			{
				GClass49.gclass49_20.method_6(gclass76_0, string_25[i], int_0 + 45 + (int_2 - 50) / 2, 5 + i * 14, GClass49.int_2);
			}
		}
	}

	private void method_144(GClass76 gclass76_0)
	{
	}

	public void method_145(GClass76 g)
	{
		g.method_5(int_57, int_58, int_59, int_60);
		g.method_1(-int_17, -int_18);
		g.method_31(gclass2_2, int_57, int_58, 0);
		int num = GClass58.smethod_1().int_119;
		GClass96.smethod_6(g, GClass154.gclass44_0[num].gclass161_0[GClass58.int_94[0][0][0]].short_0, int_141, int_142 + 5, 0, 3);
		int align = GClass49.int_2;
		if (int_141 <= 40)
			align = GClass49.int_0;
		if (int_141 >= 220)
			align = GClass49.int_1;
		GClass49.gclass49_4.method_10(g, GClass1.string_1, int_141, int_142 - 12, align, GClass49.gclass49_16);
		int num2 = -1;
		if (GClass154.smethod_27() != -1)
		{
			for (int i = 0; i < int_52[GClass1.sbyte_2].Length; i++)
			{
				if (int_52[GClass1.sbyte_2][i] != GClass154.smethod_27())
				{
					num2 = 4;
					continue;
				}
				num2 = i;
				break;
			}
			if (GClass39.int_8 % 4 > 0)
				g.method_31(GClass134.gclass2_0, int_57 + int_53[GClass1.sbyte_2][num2], int_58 + int_54[GClass1.sbyte_2][num2], 3);
		}
		if (!GClass39.bool_5)
		{
			g.method_31(gclass2_0, int_145, PuasEdRyOO, GClass169.int_2);
			for (int j = 0; j < int_53[GClass1.sbyte_2].Length; j++)
			{
				int num3 = int_53[GClass1.sbyte_2][j] + int_57;
				int num4 = int_54[GClass1.sbyte_2][j] + int_58;
				if (GClass56.smethod_29(num3 - 15, num4 - 15, 30, 30, int_145, PuasEdRyOO))
				{
					align = GClass49.int_2;
					if (num3 <= 20)
						align = GClass49.int_0;
					if (num3 >= 220)
						align = GClass49.int_1;
					GClass49.gclass49_4.method_10(g, GClass1.string_2[int_52[GClass1.sbyte_2][j]], num3, num4 - 12, align, GClass49.gclass49_16);
					break;
				}
			}
		}
		else if (!bool_5)
		{
			for (int k = 0; k < int_53[GClass1.sbyte_2].Length; k++)
			{
				int num5 = int_53[GClass1.sbyte_2][k] + int_57;
				int num6 = int_54[GClass1.sbyte_2][k] + int_58;
				if (GClass56.smethod_29(num5 - 15, num6 - 15, 30, 30, int_26, int_27))
				{
					align = GClass49.int_2;
					if (num5 <= 30)
						align = GClass49.int_0;
					if (num5 >= 220)
						align = GClass49.int_1;
					g.method_31(gclass2_0, num5, num6, GClass169.int_2);
					GClass49.gclass49_4.method_10(g, GClass1.string_2[int_52[GClass1.sbyte_2][k]], num5, num6 - 12, align, GClass49.gclass49_16);
					break;
				}
			}
		}
		g.method_1(-g.method_3(), -g.method_4());
		if (num2 != -1)
		{
			if (int_53[GClass1.sbyte_2][num2] + int_57 < int_17)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 5, int_57 + 5, int_58 + int_60 / 2 - 4, 0);
			if (int_17 + int_59 < int_53[GClass1.sbyte_2][num2] + int_57)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 6, int_57 + int_59 - 5, int_58 + int_60 / 2 - 4, GClass169.int_2);
			if (int_54[GClass1.sbyte_2][num2] < int_18)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 1, int_57 + int_59 / 2, int_58 + 5, GClass169.int_0);
			if (int_54[GClass1.sbyte_2][num2] > int_18 + int_60)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_57 + int_59 / 2, int_58 + int_60 - 5, GClass169.int_3);
		}
	}

	public void method_146(GClass76 g)
	{
		int num = ((GClass39.int_11 <= 300) ? 15 : 20);
		if (bool_20 && !GClass154.smethod_8().method_2() && !GClass154.smethod_8().method_3())
		{
			g.method_31((int_102 != 1) ? GClass154.gclass2_22 : GClass154.gclass2_23, int_57 + int_59 / 2, int_58 + int_60 - num, 3);
			GClass49.gclass49_6.method_6(g, mResources.map, int_57 + int_59 / 2, int_58 + int_60 - (num + 5), GClass49.int_2);
		}
		int_115 = int_57 + 5;
		int_116 = int_58 + 14;
		int_140 = int_116;
		g.method_5(int_57, int_58, int_59, int_60 - 35);
		if (gclass105_0 != null)
		{
			if (gclass105_0.int_3 > 0)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 1, int_57 + int_59 - 12, int_58 + 3, 0);
			if (gclass105_0.int_3 < gclass105_0.int_13)
				g.method_23(GClass85.gclass2_0, 0, 0, 9, 6, 0, int_57 + int_59 - 12, int_58 + int_60 - 45, 0);
			g.method_1(0, -gclass105_0.int_3);
		}
		int_132 = 0;
		if (int_133 == 0)
		{
			bool flag = false;
			if (GClass58.smethod_1().gclass36_0 != null)
			{
				for (int i = 0; i < GClass58.smethod_1().gclass36_0.string_0.Length; i++)
				{
					GClass49.gclass49_16.method_6(g, GClass58.smethod_1().gclass36_0.string_0[i], int_57 + int_59 / 2, int_140 - 5 + i * 12, GClass49.int_2);
					int_132++;
				}
				int_140 += (GClass58.smethod_1().gclass36_0.string_0.Length - 1) * 12;
				int num2 = 0;
				string empty = string.Empty;
				for (int j = 0; j < GClass58.smethod_1().gclass36_0.string_2.Length; j++)
				{
					if (GClass58.smethod_1().gclass36_0.string_2[j] != null)
					{
						num2 = j;
						empty = "- " + GClass58.smethod_1().gclass36_0.string_2[j];
						if (GClass58.smethod_1().gclass36_0.short_0[j] != -1)
						{
							if (GClass58.smethod_1().gclass36_0.int_0 == j)
							{
								if (GClass58.smethod_1().gclass36_0.short_0[j] != 1)
								{
									string text = empty;
									empty = text + " (" + GClass58.smethod_1().gclass36_0.short_2 + "/" + GClass58.smethod_1().gclass36_0.short_0[j] + ")";
								}
								if (GClass58.smethod_1().gclass36_0.short_2 == GClass58.smethod_1().gclass36_0.short_0[j])
									GClass49.gclass49_11.method_6(g, empty, int_115 + 5, int_140 += 12, 0);
								else
								{
									GClass49 gclass49_ = GClass49.gclass49_16;
									if (!flag)
									{
										flag = true;
										gclass49_ = GClass49.gclass49_18;
										gclass49_.method_6(g, empty, int_115 + 5 + ((gclass49_ == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
									}
									else
										gclass49_.method_6(g, "- ...", int_115 + 5 + ((gclass49_ == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
								}
							}
							else if (GClass58.smethod_1().gclass36_0.int_0 > j)
							{
								if (GClass58.smethod_1().gclass36_0.short_0[j] != 1)
								{
									string text2 = empty;
									empty = text2 + " (" + GClass58.smethod_1().gclass36_0.short_0[j] + "/" + GClass58.smethod_1().gclass36_0.short_0[j] + ")";
								}
								GClass49.gclass49_20.method_6(g, empty, int_115 + 5, int_140 += 12, 0);
							}
							else
							{
								if (GClass58.smethod_1().gclass36_0.short_0[j] != 1)
									empty = empty + " 0/" + GClass58.smethod_1().gclass36_0.short_0[j];
								GClass49 gclass49_2 = GClass49.gclass49_16;
								if (!flag)
								{
									flag = true;
									gclass49_2 = GClass49.gclass49_18;
									gclass49_2.method_6(g, empty, int_115 + 5 + ((gclass49_2 == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
								}
								else
									gclass49_2.method_6(g, "- ...", int_115 + 5 + ((gclass49_2 == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
							}
						}
						else if (GClass58.smethod_1().gclass36_0.int_0 > j)
						{
							GClass49.gclass49_20.method_6(g, empty, int_115 + 5, int_140 += 12, 0);
						}
						else
						{
							GClass49 gclass49_3 = GClass49.gclass49_16;
							if (!flag)
							{
								flag = true;
								gclass49_3 = GClass49.gclass49_18;
								gclass49_3.method_6(g, empty, int_115 + 5 + ((gclass49_3 == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
							}
							else
								gclass49_3.method_6(g, "- ...", int_115 + 5 + ((gclass49_3 == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
						}
						int_132++;
					}
					else if (GClass58.smethod_1().gclass36_0.int_0 <= j)
					{
						empty = "- " + GClass58.smethod_1().gclass36_0.string_2[num2];
						GClass49 gClass = GClass49.gclass49_16;
						if (!flag)
						{
							flag = true;
							gClass = GClass49.gclass49_18;
						}
						gClass.method_6(g, empty, int_115 + 5 + ((gClass == GClass49.gclass49_18 && GClass39.int_8 % 20 > 10) ? (GClass39.int_8 % 4 / 2) : 0), int_140 += 12, 0);
					}
				}
				int_140 += 5;
				for (int k = 0; k < GClass58.smethod_1().gclass36_0.string_1.Length; k++)
				{
					GClass49.gclass49_14.method_6(g, GClass58.smethod_1().gclass36_0.string_1[k], int_115 + 5, int_140 += 12, 0);
					int_132++;
				}
			}
			else
			{
				int num3 = GClass154.smethod_27();
				sbyte b = GClass154.smethod_28();
				string empty2 = string.Empty;
				if (num3 == -3 || b == -3)
					empty2 = mResources.DES_TASK[3];
				else if (GClass58.smethod_1().gclass36_0 == null && GClass58.smethod_1().int_15 == 9 && GClass58.smethod_1().gclass109_0.int_0 == 0)
				{
					empty2 = mResources.TASK_INPUT_CLASS;
				}
				else
				{
					if (b < 0 || num3 < 0)
						return;
					empty2 = mResources.DES_TASK[0] + GClass59.gclass90_1[b].string_0 + mResources.DES_TASK[1] + GClass1.string_2[num3] + mResources.DES_TASK[2];
				}
				string[] array = GClass49.gclass49_20.method_15(empty2, 150);
				for (int l = 0; l < array.Length; l++)
				{
					if (l == 0)
						GClass49.gclass49_20.method_6(g, array[l], int_115 + 5, int_140 = int_116, 0);
					else
						GClass49.gclass49_20.method_6(g, array[l], int_115 + 5, int_140 += 12, 0);
				}
			}
		}
		else if (int_133 == 1)
		{
			int_140 = int_116 - 12;
			for (int m = 0; m < GClass58.smethod_1().gclass63_4.method_2(); m++)
			{
				GClass127 gClass2 = (GClass127)GClass58.smethod_1().gclass63_4.method_3(m);
				GClass49.gclass49_20.method_6(g, gClass2.string_0, int_115 + 5, int_140 += 12, 0);
				if (gClass2.int_1 == gClass2.short_0)
					GClass49.gclass49_20.method_6(g, ((gClass2.int_0 != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + GClass85.gclass204_0[gClass2.int_2].string_0 + " (" + gClass2.int_1 + "/" + gClass2.short_0 + ")", int_115 + 5, int_140 += 12, 0);
				else
					GClass49.gclass49_18.method_6(g, ((gClass2.int_0 != 0) ? mResources.KILLBOSS : mResources.KILL) + " " + GClass85.gclass204_0[gClass2.int_2].string_0 + " (" + gClass2.int_1 + "/" + gClass2.short_0 + ")", int_115 + 5, int_140 += 12, 0);
				int_132 += 3;
				int_138 = int_117 - 25;
				method_148(g, GClass49.gclass49_16, gClass2.string_1, int_115 + 5, int_140 += 12, 0);
				int_140 += 12;
			}
		}
		if (gclass105_0 == null)
		{
			gclass105_0 = new GClass105();
			gclass105_0.method_6(int_132, 12, int_57, int_58, int_59, int_60 - num - 40, true, 1);
		}
	}

	public void method_147(GClass76 g, GClass49 f, string[] arr, string str, int x, int y, int align)
	{
		for (int i = 0; i < arr.Length; i++)
		{
			string text = arr[i];
			if (text.StartsWith("c"))
			{
				if (text.StartsWith("c0"))
				{
					text = text.Substring(2);
					f = GClass49.gclass49_6;
				}
				else if (text.StartsWith("c1"))
				{
					text = text.Substring(2);
					f = GClass49.gclass49_4;
				}
				else if (text.StartsWith("c2"))
				{
					text = text.Substring(2);
					f = GClass49.gclass49_8;
				}
			}
			if (i == 0)
			{
				f.method_6(g, text, x, y, align);
				continue;
			}
			if (i < int_131 + 30 && i > int_131 - 30)
				f.method_6(g, text, x, y += 12, align);
			else
				y += 12;
			int_140 += 12;
			int_132++;
		}
	}

	public void method_148(GClass76 g, GClass49 f, string str, int x, int y, int align)
	{
		int num = ((!GClass39.bool_5 || GClass39.int_10 < 320) ? 10 : 20);
		string[] array = f.method_15(str, int_138 - num);
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0)
			{
				f.method_6(g, array[i], x, y, align);
				continue;
			}
			if (i < int_131 + 15 && i > int_131 - 15)
				f.method_6(g, array[i], x, y += 12, align);
			else
				y += 12;
			int_140 += 12;
			int_132++;
		}
	}

	public void method_149()
	{
		for (int i = 0; i < gclass63_0.method_2(); i++)
		{
			((GClass121)gclass63_0.method_3(i)).bool_0 = false;
		}
		gclass63_0.method_9();
	}

	public void method_150()
	{
		if (int_63 > 0)
		{
			bool_21 = false;
			return;
		}
		if (method_212())
			GClass58.smethod_1().method_136();
		if (gclass7_0 != null && int_28 == 13 && gclass7_0.bool_0)
			gclass7_0 = null;
		if (int_28 == 13 && !bool_3)
			GClass166.smethod_0().method_6(3, -1, -1, -1);
		GClass56.smethod_8("HIDE PANELLLLLLLLLLLLLLLLLLLLLL");
		GClass29.smethod_1().method_34();
		GClass154.bool_72 = true;
		GClass1.sbyte_3 = -1;
		gclass2_2 = null;
		GClass138.smethod_26();
		bool_9 = false;
		bool_21 = true;
		method_149();
		GClass23.smethod_2();
		GClass39.gclass45_1 = null;
		GClass39.smethod_49();
		GClass39.smethod_26();
		int_96 = 0;
		int_95 = 0;
		bool_13 = false;
		bool_0 = false;
		if ((GClass58.smethod_1().int_25 <= 0 || GClass58.smethod_1().int_11 == 14 || GClass58.smethod_1().int_11 == 5) && GClass58.smethod_1().bool_62)
		{
			GClass14 gClass = new GClass14(mResources.DIES[0], 11038, GClass154.smethod_8());
			GClass154.smethod_8().gclass14_1 = gClass;
			GClass58.smethod_1().int_25 = 0;
		}
	}

	public void method_151()
	{
		if (int_63 > 0)
		{
			bool_21 = false;
			return;
		}
		if (method_212())
			GClass58.smethod_1().method_136();
		if (gclass7_0 != null && int_28 == 13 && gclass7_0.bool_0)
			gclass7_0 = null;
		if (int_28 == 13 && !bool_3)
			GClass166.smethod_0().method_6(3, -1, -1, -1);
		if (int_28 == 15)
			GClass166.smethod_0().method_141(-1);
		GClass29.smethod_1().method_34();
		GClass154.bool_72 = true;
		GClass1.sbyte_3 = -1;
		if (gclass2_2 != null)
		{
			gclass2_2.texture2D_0 = null;
			gclass2_2 = null;
		}
		GClass138.smethod_26();
		bool_9 = false;
		if (int_28 != 4)
		{
			if (int_28 == 24)
				method_169();
			else if (int_28 == 23)
			{
				method_40();
			}
			else if (int_28 == 3 || int_28 == 14)
			{
				if (bool_23)
					bool_21 = true;
				else
				{
					method_40();
					int_14 = 0;
					int_15 = 0;
				}
			}
			else if (int_28 == 18 || int_28 == 19 || int_28 == 20 || int_28 == 21)
			{
				method_40();
				int_14 = 0;
				int_15 = 0;
			}
			else if (int_28 == 8 || int_28 == 11 || int_28 == 16)
			{
				method_205();
				int_14 = 0;
				int_15 = 0;
			}
			else
			{
				bool_21 = true;
			}
		}
		else
		{
			method_40();
			int_14 = 0;
			int_15 = 0;
		}
		GClass23.smethod_2();
		GClass39.gclass45_1 = null;
		GClass39.smethod_49();
		GClass39.smethod_26();
		GClass39.bool_22 = false;
		int_96 = 0;
		int_95 = 0;
		bool_13 = false;
		if ((GClass58.smethod_1().int_25 <= 0 || GClass58.smethod_1().int_11 == 14 || GClass58.smethod_1().int_11 == 5) && GClass58.smethod_1().bool_62)
		{
			GClass14 gClass = new GClass14(mResources.DIES[0], 11038, GClass154.smethod_8());
			GClass154.smethod_8().gclass14_1 = gClass;
			GClass58.smethod_1().int_25 = 0;
		}
	}

	public void method_152()
	{
		if (gclass7_0 != null && gclass7_0.bool_0)
		{
			gclass7_0.method_7();
			return;
		}
		if (bool_24)
		{
			NhGstqZex8++;
			if (NhGstqZex8 == 10)
			{
				NhGstqZex8 = 0;
				bool_24 = false;
				gclass7_0.gclass67_0.method_23(string.Empty);
				gclass7_0.string_1 = mResources.kiguiXuchat + " ";
				gclass7_0.gclass67_0.string_7 = mResources.input_money;
				gclass7_0.string_0 = string.Empty;
				gclass7_0.bool_0 = true;
				gclass7_0.gclass67_0.method_28(GClass67.int_12);
				gclass7_0.gclass67_0.method_26(10);
				if (GClass39.bool_5)
					gclass7_0.gclass67_0.method_0();
				if (Main.isWindowsPhone)
					gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
				if (!Main.isPC)
					gclass7_0.method_5(this, string.Empty);
			}
			return;
		}
		if (bool_25)
		{
			NhGstqZex8++;
			if (NhGstqZex8 == 10)
			{
				NhGstqZex8 = 0;
				bool_25 = false;
				gclass7_0.gclass67_0.method_23(string.Empty);
				gclass7_0.string_1 = mResources.kiguiLuongchat + "  ";
				gclass7_0.gclass67_0.string_7 = mResources.input_money;
				gclass7_0.string_0 = string.Empty;
				gclass7_0.bool_0 = true;
				gclass7_0.gclass67_0.method_28(GClass67.int_12);
				gclass7_0.gclass67_0.method_26(10);
				if (GClass39.bool_5)
					gclass7_0.gclass67_0.method_0();
				if (Main.isWindowsPhone)
					gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
				if (!Main.isPC)
					gclass7_0.method_5(this, string.Empty);
			}
			return;
		}
		if (gclass105_0 != null)
			gclass105_0.method_5();
		if (gclass141_0 != null && gclass141_0.bool_0)
		{
			gclass141_0.method_7();
			return;
		}
		method_91();
		if (method_216() && bool_30)
		{
			if (gclass33_0 == null)
			{
				gclass33_0 = new GClass33(205, 0, 0, 3, 10, -1);
				gclass33_0.int_1 = 2;
			}
			if (gclass33_0 != null)
				gclass33_0.method_4();
		}
		if (oTwynfpuwh > 0)
		{
			oTwynfpuwh--;
			if (oTwynfpuwh == 0)
			{
				int_42[int_29] = int_66;
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
					if (Equals(GClass39.gclass45_1) && GClass39.gclass45_0.int_28 == 2)
					{
						method_192();
						return;
					}
					method_165();
					break;
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
					GClass198.smethod_0().method_6();
					break;
				case 25:
					method_153();
					break;
				}
			}
		}
		for (int i = 0; i < GClass62.gclass63_0.method_2(); i++)
		{
			((GClass62)GClass62.gclass63_0.method_3(i)).method_1();
		}
		method_196();
	}

	private void method_153()
	{
	}

	private void method_154()
	{
		if (int_66 != -1)
		{
			int_146 = int_66;
			((Class4)gclass63_12.method_3(int_146)).bool_0 = true;
			GClass120.smethod_9(((Class4)gclass63_12.method_3(int_146)).short_0 + string.Empty, 1);
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
			if (int_66 == -1 || int_66 > GClass58.smethod_2().gclass121_2.Length - 1)
				return;
			GClass63 gClass = new GClass63(string.Empty);
			gclass121_0 = GClass58.smethod_2().gclass121_2[int_66];
			if (gclass121_0 != null)
			{
				gClass.method_0(new GClass14(mResources.MOVEOUT, this, 2006, gclass121_0));
				GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
				method_42(gclass121_0);
			}
			else
				gclass70_0 = null;
		}
		if (int_29 == 1)
			method_157();
		if (int_29 == 2)
			method_165();
	}

	private void method_157()
	{
		if (int_66 == -1)
			return;
		if (int_66 == 5)
		{
			GClass39.smethod_36(mResources.sure_fusion, new GClass14(mResources.YES, 888351), new GClass14(mResources.NO, 2001));
			return;
		}
		GClass166.smethod_0().method_133((sbyte)int_66);
		if (int_66 < 4)
			GClass58.smethod_2().sbyte_15 = (sbyte)int_66;
	}

	private void method_158()
	{
		if (int_66 >= -1)
		{
			if (bool_7)
			{
				GClass166.smethod_0().method_128(string_0, (sbyte)int_66);
				return;
			}
			GClass63 gClass = new GClass63(string.Empty);
			gClass.method_0(new GClass14(mResources.CHAR_ORDER[0], this, 9999, (GClass8)gclass63_8.method_3(int_66)));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_46((GClass8)gclass63_8.method_3(int_66));
		}
	}

	private void method_159()
	{
		method_190();
	}

	private void method_160()
	{
		if (int_29 == 0 && Equals(GClass39.gclass45_0))
		{
			method_165();
			return;
		}
		if ((int_29 == 0 && Equals(GClass39.gclass45_1)) || int_29 == 2)
		{
			if (Equals(GClass39.gclass45_1))
				gclass121_0 = (GClass121)GClass39.gclass45_1.gclass63_7.method_3(int_66);
			else
				gclass121_0 = (GClass121)GClass39.gclass45_0.gclass63_7.method_3(int_66);
			GClass56.smethod_11("toi day select= " + int_66);
			GClass63 gClass = new GClass63();
			gClass.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass121_0));
			if (gclass121_0 != null)
			{
				GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
				method_42(gclass121_0);
			}
			else
				gclass70_0 = null;
		}
		if (int_29 == 1)
		{
			if (int_66 == int_41 - 3)
			{
				if (bool_1)
					return;
				method_174();
			}
			else if (int_66 == int_41 - 2)
			{
				if (!bool_3)
				{
					bool_1 = !bool_1;
					if (bool_1)
						GClass166.smethod_0().method_6(5, -1, -1, -1);
					else
					{
						method_151();
						GClass57.smethod_1();
						GClass166.smethod_0().method_6(3, -1, -1, -1);
					}
				}
				else
					bool_3 = false;
			}
			else if (int_66 == int_41 - 1)
			{
				if (bool_1 && !bool_3 && bool_2)
					GClass39.smethod_36(mResources.do_u_sure_to_trade, new GClass14(mResources.YES, this, 7002, null), new GClass14(mResources.NO, this, 4005, null));
			}
			else
			{
				if (bool_1)
					return;
				gclass121_0 = (GClass121)GClass39.gclass45_0.gclass63_6.method_3(int_66);
				GClass63 gClass2 = new GClass63();
				gClass2.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass121_0));
				if (gclass121_0 != null)
				{
					GClass39.gclass0_0.method_1(gClass2, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_42(gclass121_0);
				}
				else
					gclass70_0 = null;
			}
		}
		if (GClass39.bool_5)
			int_66 = -1;
	}

	private void method_161()
	{
		if (int_29 == 0)
		{
			if (int_66 == -1 || gclass63_0.method_2() == 0)
				return;
			if (int_66 == gclass63_0.method_2())
			{
				int_101 = -1;
				int_66 = (GClass39.bool_5 ? (-1) : 0);
				GClass57.smethod_1();
				GClass166.smethod_0().method_5(1, gclass63_0);
				return;
			}
			if (int_66 > gclass63_0.method_2() - 1)
				return;
			gclass121_0 = (GClass121)GClass39.gclass45_0.gclass63_0.method_3(int_66);
			GClass63 gClass = new GClass63();
			gClass.method_0(new GClass14(mResources.GETOUT, this, 6001, gclass121_0));
			if (gclass121_0 != null)
			{
				GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
				method_42(gclass121_0);
			}
			else
				gclass70_0 = null;
		}
		if (int_29 == 1)
			method_165();
	}

	private void method_162()
	{
		if (int_66 != -1)
		{
			bool_18 = true;
			method_151();
		}
	}

	private void method_163()
	{
		gclass121_0 = null;
		if (int_66 < 0)
			return;
		GClass63 gClass = new GClass63();
		if (int_29 < string_2.Length - ((GClass39.gclass45_1 == null) ? 1 : 0) && int_28 != 17)
		{
			gclass121_0 = GClass58.smethod_1().gclass121_3[int_29][int_66];
			if (gclass121_0 != null)
			{
				if (gclass121_0.bool_3)
				{
					if (gclass121_0.int_39 > 0)
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_39), this, 3005, gclass121_0));
				}
				else if (int_56 == 4)
				{
					gClass.method_0(new GClass14(mResources.receive_upper, this, 30001, gclass121_0));
					gClass.method_0(new GClass14(mResources.DELETE, this, 30002, gclass121_0));
					gClass.method_0(new GClass14(mResources.receive_all, this, 30003, gclass121_0));
				}
				else if (gclass121_0.int_34 == 0 && gclass121_0.int_36 == 0)
				{
					if ((ulong)gclass121_0.long_0 > 0uL)
						gClass.method_0(new GClass14(mResources.learn_with + "\n" + GClass56.smethod_31(gclass121_0.long_0) + " \n" + mResources.potential, this, 3004, gclass121_0));
					else
					{
						gClass.method_0(new GClass14(mResources.receive_upper + "\n" + mResources.free, this, 3000, gclass121_0));
						gClass.method_0(new GClass14("Mua Nhiều", GClass183.smethod_0(), 3, new GClass183.GClass184(gclass121_0.gclass118_0.short_0, -1, true, false)));
					}
				}
				else if (int_56 == 8)
				{
					if (gclass121_0.int_34 > 0)
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_34) + "\n" + mResources.XU, this, 30001, gclass121_0));
					if (gclass121_0.int_36 > 0)
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_36) + "\n" + mResources.LUONG, this, 30002, gclass121_0));
				}
				else if (int_56 != 2)
				{
					if (gclass121_0.int_34 > 0)
					{
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_34) + "\n" + mResources.XU, this, 3000, gclass121_0));
						gClass.method_0(new GClass14("Mua Nhiều\n" + GClass56.smethod_32(gclass121_0.int_34) + " Vàng/1", GClass183.smethod_0(), 3, new GClass183.GClass184(gclass121_0.gclass118_0.short_0, -1, true, false)));
					}
					if (gclass121_0.int_36 > 0)
					{
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_36) + "\n" + mResources.LUONG, this, 3001, gclass121_0));
						gClass.method_0(new GClass14("Mua Nhiều\n" + GClass56.smethod_32(gclass121_0.int_36) + " Ngọc/1", GClass183.smethod_0(), 3, new GClass183.GClass184(gclass121_0.gclass118_0.short_0, -1, false, false)));
					}
				}
				else
				{
					if (gclass121_0.int_34 != -1)
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_34) + "\n" + mResources.XU, this, 10016, gclass121_0));
					if (gclass121_0.int_36 != -1)
						gClass.method_0(new GClass14(mResources.buy_with + "\n" + GClass56.smethod_32(gclass121_0.int_36) + "\n" + mResources.LUONG, this, 10017, gclass121_0));
				}
			}
		}
		else if (int_56 == 0)
		{
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
			_ = GClass58.smethod_1().gclass121_0;
			if (int_66 >= gclass121_.Length)
			{
				sbyte b = (sbyte)(int_66 - gclass121_.Length);
				GClass121 gClass2 = GClass58.smethod_1().gclass121_0[b];
				if (gClass2 != null)
					gclass121_0 = gClass2;
			}
			else
			{
				GClass121 gClass3 = GClass58.smethod_1().gclass121_2[int_66];
				if (gClass3 != null)
					gclass121_0 = gClass3;
			}
			if (gclass121_0 != null)
				gClass.method_0(new GClass14(mResources.SALE, this, 3002, gclass121_0));
		}
		else
		{
			if (int_28 == 17)
				gclass121_0 = GClass58.smethod_1().gclass121_3[4][int_66];
			else
				gclass121_0 = GClass58.smethod_1().gclass121_3[int_29][int_66];
			if (gclass121_0.sbyte_32 == 0)
			{
				if (gclass121_0.method_9(87))
					gClass.method_0(new GClass14(mResources.kiguiLuong, this, 10013, gclass121_0));
				else
					gClass.method_0(new GClass14(mResources.kiguiXu, this, 10012, gclass121_0));
			}
			else if (gclass121_0.sbyte_32 == 1)
			{
				gClass.method_0(new GClass14(mResources.huykigui, this, 10014, gclass121_0));
				gClass.method_0(new GClass14(mResources.upTop, this, 10018, gclass121_0));
			}
			else if (gclass121_0.sbyte_32 == 2)
			{
				gClass.method_0(new GClass14(mResources.nhantien, this, 10015, gclass121_0));
			}
		}
		if (gclass121_0 != null)
		{
			GClass58.smethod_1().method_135(gclass121_0.int_44, gclass121_0.int_45, gclass121_0.int_46, gclass121_0.int_47);
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_42(gclass121_0);
		}
		else
			gclass70_0 = null;
	}

	private void method_164()
	{
		if (int_66 >= 0 && GClass58.smethod_1().gclass79_0[int_66].bool_0 && !GClass58.smethod_1().gclass79_0[int_66].bool_1)
		{
			if (!GClass39.bool_5)
				GClass166.smethod_0().method_14(int_66);
			else if (GClass39.int_0 > int_57 + int_59 - 40)
			{
				GClass166.smethod_0().method_14(int_66);
			}
		}
	}

	private void method_165()
	{
		GClass56.smethod_8("fire inventory");
		if (GClass58.smethod_1().int_11 == 14)
			GClass39.smethod_30(mResources.can_not_do_when_die);
		else
		{
			if (int_66 == -1)
				return;
			gclass121_0 = null;
			GClass63 gClass = new GClass63();
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
			if (int_66 >= gclass121_.Length)
			{
				sbyte b = (sbyte)(int_66 - gclass121_.Length);
				GClass121 gClass2 = GClass58.smethod_1().gclass121_0[b];
				if (gClass2 != null)
				{
					gclass121_0 = gClass2;
					if (GClass39.gclass45_0.int_28 == 12)
						gClass.method_0(new GClass14(mResources.use_for_combine, this, 6000, gclass121_0));
					else if (GClass39.gclass45_0.int_28 == 13)
					{
						gClass.method_0(new GClass14(mResources.use_for_trade, this, 7000, gclass121_0));
					}
					else if (gClass2.method_11())
					{
						gClass.method_0(new GClass14(mResources.USE, this, 2000, gclass121_0));
						if (GClass58.smethod_1().bool_38)
							gClass.method_0(new GClass14(mResources.MOVEFORPET, this, 2005, gclass121_0));
						if (UrRyYhZnVy != 1)
						{
							string text = string.Empty;
							if (gclass121_0.gclass20_0 != null)
							{
								for (int i = 0; i < gclass121_0.gclass20_0.Length; i++)
								{
									text = text + gclass121_0.gclass20_0[i].gclass114_0.int_0 + "-";
								}
							}
							string caption = (GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) ? ((GClass192.int_0 == 0) ? "Xóa khỏi\nSet 1\n[Sư phụ]" : "Remove from\nSet 1\n[Master]") : ((GClass192.int_0 == 0) ? "Thêm vào\nSet 1\n[Sư phụ]" : "Add to\nSet 1\n[Master]"));
							string caption2 = (GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) ? ((GClass192.int_0 == 0) ? "Xóa khỏi\nSet 2\n[Sư phụ]" : "Remove from\nSet 2\n[Master]") : ((GClass192.int_0 == 0) ? "Thêm vào\nSet 2\n[Sư phụ]" : "Add to\nSet 2\n[Master]"));
							string caption3 = (GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) ? ((GClass192.int_0 == 0) ? "Xóa khỏi\nSet 1\n[Đệ tử]" : "Remove from\nSet 1\n[Disciple]") : ((GClass192.int_0 == 0) ? "Thêm vào\nSet 1\n[Đệ tử]" : "Add to\nSet 1\n[Disciple]"));
							string caption4 = (GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) ? ((GClass192.int_0 == 0) ? "Xóa khỏi\nSet 2\n[Đệ tử]" : "Remove from\nSet 2\n[Disciple]") : ((GClass192.int_0 == 0) ? "Thêm vào\nSet 2\n[Đệ tử]" : "Add to\nSet 2\n[Disciple]"));
							bool flag = GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							});
							bool flag2 = !GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							});
							bool flag3 = !GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							});
							bool flag4 = !GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							});
							bool flag5 = !GClass183.smethod_0().list_2.Contains(new GClass183.GStruct3
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_3.Contains(new GClass183.GStruct6
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_4.Contains(new GClass183.GStruct2
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							}) && !GClass183.smethod_0().list_5.Contains(new GClass183.GStruct5
							{
								int_0 = gclass121_0.gclass118_0.short_0,
								string_0 = text,
								int_1 = gclass121_0.gclass118_0.sbyte_0
							});
							if (flag || flag5)
								gClass.method_0(new GClass14(caption, this, 3142, gclass121_0));
							if (flag2 || flag5)
								gClass.method_0(new GClass14(caption2, this, 3143, gclass121_0));
							if (flag3 || flag5)
								gClass.method_0(new GClass14(caption3, this, 3140, gclass121_0));
							if (flag4 || flag5)
								gClass.method_0(new GClass14(caption4, this, 3141, gclass121_0));
						}
					}
					else
					{
						gClass.method_0(new GClass14(mResources.USE, this, 2001, gclass121_0));
						if (UrRyYhZnVy != 1)
						{
							if (gClass2.gclass118_0.sbyte_0 == 29 || gClass2.gclass118_0.short_0 == 521)
								gClass.method_0(new GClass14((!GClass183.smethod_0().list_6.Contains(new GClass183.GStruct4
								{
									int_0 = gClass2.gclass118_0.short_1,
									string_0 = gClass2.gclass118_0.string_0
								})) ? ((mResources.language == 0) ? "Tự động\nsử dụng" : "Auto\nuse item") : ((mResources.language == 0) ? "Dừng\ntự động\nsử dụng" : "Stop auto\nuse item"), this, 3144, gclass121_0));
							if (gClass2.gclass118_0.sbyte_0 == 27 && gClass2.gclass118_0.short_0 != 521)
								gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Sử dụng khi đăng nhập" : "Use when login", this, 3145, gclass121_0));
						}
					}
				}
			}
			else
			{
				GClass121 gClass3 = GClass58.smethod_1().gclass121_2[int_66];
				if (gClass3 != null)
				{
					gclass121_0 = gClass3;
					gClass.method_0(new GClass14(mResources.GETOUT, this, 2002, gclass121_0));
				}
			}
			if (gclass121_0 != null)
			{
				GClass58.smethod_1().method_135(gclass121_0.int_44, gclass121_0.int_45, gclass121_0.int_46, gclass121_0.int_47);
				if (GClass39.gclass45_0.int_28 != 12 && GClass39.gclass45_0.int_28 != 13)
				{
					if (UrRyYhZnVy == 0)
						gClass.method_0(new GClass14(mResources.MOVEOUT, this, 2003, gclass121_0));
					if (UrRyYhZnVy == 1)
						gClass.method_0(new GClass14(mResources.SALE, this, 3002, gclass121_0));
				}
				GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
				method_42(gclass121_0);
			}
			else
				gclass70_0 = null;
		}
	}

	private void method_166()
	{
		method_151();
		if (GClass146.gclass63_0 == null || GClass146.gclass63_0.method_2() == 0)
		{
			GClass166.smethod_0().method_146(0, -1);
			GClass146.smethod_2().switchToMe();
		}
		else
			GClass146.smethod_2().switchToMe();
	}

	private void method_167()
	{
		if (int_66 < 0)
			return;
		if (GClass29.bool_0 && int_66 == string_6.Length - 1)
		{
			GClass166.smethod_0().method_148();
			return;
		}
		if (!GClass58.smethod_1().bool_38)
		{
			switch (int_66)
			{
			case 0:
				method_166();
				break;
			case 1:
				method_151();
				GClass166.smethod_0().method_60(54);
				break;
			case 2:
				GClass198.smethod_0().method_1(0);
				break;
			case 3:
				GClass166.smethod_0().method_131(0, -1);
				GClass57.smethod_1();
				break;
			case 4:
				if (GClass58.smethod_1().int_11 == 14)
				{
					GClass39.smethod_30(mResources.can_not_do_when_die);
					break;
				}
				GClass166.smethod_0().method_58();
				GClass39.gclass45_0.method_41();
				GClass39.gclass45_0.method_50();
				break;
			case 5:
				GClass39.smethod_29();
				if (GClass58.smethod_1().method_143() < 5)
				{
					GClass39.smethod_30(mResources.not_enough_luong_world_channel);
					break;
				}
				if (gclass7_0 == null)
				{
					gclass7_0 = new GClass7();
					gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
					gclass7_0.method_0();
					gclass7_0.ginterface5_0 = GClass39.gclass45_0;
				}
				gclass7_0.string_1 = mResources.world_channel_5_luong;
				gclass7_0.gclass67_0.string_7 = mResources.CHAT;
				gclass7_0.string_0 = string.Empty;
				gclass7_0.bool_0 = true;
				gclass7_0.gclass67_0.bool_0 = true;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
				if (Main.isWindowsPhone)
					gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
				if (!Main.isPC)
					gclass7_0.method_5(this, string.Empty);
				else if (GClass39.bool_5)
				{
					gclass7_0.gclass67_0.method_0();
				}
				break;
			case 6:
				method_205();
				break;
			case 7:
				method_201();
				break;
			case 8:
				GClass39.gclass149_0.method_16();
				break;
			case 9:
				if (GClass39.gclass149_0.bool_12)
					GClass29.smethod_1().method_52();
				break;
			}
			return;
		}
		switch (int_66)
		{
		case 0:
			method_166();
			break;
		case 1:
			GClass166.smethod_0().method_60(54);
			break;
		case 2:
			GClass198.smethod_0().method_1(0);
			break;
		case 3:
			method_170();
			break;
		case 4:
			GClass166.smethod_0().method_131(0, -1);
			GClass57.smethod_1();
			break;
		case 5:
			if (GClass58.smethod_1().int_11 == 14)
			{
				GClass39.smethod_30(mResources.can_not_do_when_die);
				break;
			}
			GClass166.smethod_0().method_58();
			GClass39.gclass45_0.method_41();
			GClass39.gclass45_0.method_50();
			break;
		case 6:
			GClass39.smethod_29();
			if (GClass58.smethod_1().method_143() < 5)
			{
				GClass39.smethod_30(mResources.not_enough_luong_world_channel);
				break;
			}
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = GClass39.gclass45_0;
			}
			gclass7_0.string_1 = mResources.world_channel_5_luong;
			gclass7_0.gclass67_0.string_7 = mResources.CHAT;
			gclass7_0.string_0 = string.Empty;
			gclass7_0.bool_0 = true;
			gclass7_0.gclass67_0.bool_0 = true;
			gclass7_0.gclass67_0.method_28(GClass67.int_11);
			if (Main.isWindowsPhone)
				gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
			if (!Main.isPC)
				gclass7_0.method_5(this, string.Empty);
			else if (GClass39.bool_5)
			{
				gclass7_0.gclass67_0.method_0();
			}
			break;
		case 7:
			method_205();
			break;
		case 8:
			method_201();
			break;
		case 9:
			GClass39.gclass149_0.method_16();
			break;
		case 10:
			if (GClass39.gclass149_0.bool_12)
				GClass29.smethod_1().method_52();
			break;
		}
	}

	private void method_168()
	{
		string src = ((Class4)gclass63_12.method_3(int_146)).string_1;
		string_27 = GClass49.gclass49_16.method_15(src, int_59 - 40);
		int_41 = string_27.Length;
		int_4 = 16;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		int_41 = GClass198.smethod_0().string_0.Length;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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
		GClass166.smethod_0().method_127();
		if (GClass39.int_10 > 2 * int_55)
		{
			GClass39.gclass45_1 = new GClass45();
			GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
			GClass39.gclass45_1.method_15();
			GClass39.gclass45_1.method_50();
			GClass39.gclass45_0.method_39();
			GClass39.gclass45_0.method_50();
		}
		else
		{
			GClass39.gclass45_0.string_17[21] = mResources.petMainTab;
			GClass39.gclass45_0.method_39();
			GClass39.gclass45_0.method_50();
		}
		int_63 = 20;
	}

	private void method_171()
	{
		gclass7_0.string_1 = mResources.input_clan_name;
		gclass7_0.gclass67_0.string_7 = mResources.clan_name;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	private void method_172()
	{
		gclass7_0.string_1 = mResources.chat_clan;
		gclass7_0.gclass67_0.string_7 = mResources.CHAT;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	public void method_173()
	{
		gclass7_0.string_1 = mResources.input_clan_name_to_create;
		gclass7_0.gclass67_0.string_7 = mResources.input_clan_name;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	public void method_174()
	{
		if (gclass7_0 == null)
		{
			gclass7_0 = new GClass7();
			gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
			gclass7_0.method_0();
			gclass7_0.ginterface5_0 = GClass39.gclass45_0;
		}
		gclass7_0.string_1 = mResources.input_money_to_trade;
		gclass7_0.gclass67_0.string_7 = mResources.input_money;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_12);
		gclass7_0.gclass67_0.method_26(10);
		if (GClass39.bool_5)
			gclass7_0.gclass67_0.method_0();
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	public void method_175()
	{
		if (gclass7_0 == null)
		{
			gclass7_0 = new GClass7();
			gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
			gclass7_0.method_0();
			gclass7_0.ginterface5_0 = GClass39.gclass45_0;
		}
		gclass7_0.string_1 = mResources.input_quantity_to_trade;
		gclass7_0.gclass67_0.string_7 = mResources.input_quantity;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_12);
		if (GClass39.bool_5)
			gclass7_0.gclass67_0.method_0();
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	public void method_176()
	{
		gclass7_0.string_1 = mResources.input_clan_slogan;
		gclass7_0.gclass67_0.string_7 = mResources.input_clan_slogan;
		gclass7_0.string_0 = string.Empty;
		gclass7_0.bool_0 = true;
		gclass7_0.gclass67_0.bool_0 = true;
		gclass7_0.gclass67_0.method_28(GClass67.int_11);
		if (Main.isWindowsPhone)
			gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
		if (!Main.isPC)
			gclass7_0.method_5(this, string.Empty);
	}

	public void method_177()
	{
		if (gclass141_0 == null)
			gclass141_0 = new GClass141();
		gclass141_0.string_0 = gclass7_0.gclass67_0.method_21();
		gclass141_0.method_1(false);
		gclass7_0.bool_0 = false;
	}

	private void method_178(GClass43 gclass43_0)
	{
		string text = string.Concat("|0|1|" + gclass43_0.gclass58_0.string_3, "\n");
		string text2 = ((!gclass43_0.bool_1) ? (text + "|3|1|" + mResources.is_offline) : (text + "|4|1|" + mResources.is_online)) + "\n--";
		text = text2 + "\n|5|" + mResources.power + ": " + gclass43_0.string_0;
		gclass70_0 = new GClass70();
		method_43(gclass70_0, text);
		gclass58_1 = gclass43_0.gclass58_0;
		gclass121_0 = null;
	}

	private void method_179()
	{
		if (int_66 >= 0 && gclass63_9.method_2() != 0)
		{
			GClass63 gClass = new GClass63();
			int_147 = int_66;
			gClass.method_0(new GClass14(mResources.REVENGE, this, 10000, (GClass43)gclass63_9.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.DELETE, this, 10001, (GClass43)gclass63_9.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.den, this, 8004, (GClass43)gclass63_9.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.make_friend, this, 8003, (GClass43)gclass63_9.method_3(int_147)));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_178((GClass43)gclass63_9.method_3(int_66));
		}
	}

	private void method_180()
	{
		if (int_66 >= 0 && gclass63_5.method_2() != 0)
		{
			GClass63 gClass = new GClass63();
			int_147 = int_66;
			gClass.method_0(new GClass14(mResources.CHAT, this, 8001, (GClass43)gclass63_5.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.DELETE, this, 8002, (GClass43)gclass63_5.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.den, this, 8004, (GClass43)gclass63_5.method_3(int_147)));
			gClass.method_0(new GClass14("Thêm vào đối tượng dịch chuyển", this, 8008, (GClass43)gclass63_5.method_3(int_147)));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_178((GClass43)gclass63_5.method_3(int_66));
		}
	}

	private void method_181()
	{
		if (int_66 >= 0)
		{
			GClass63 gClass = new GClass63();
			int_147 = int_66;
			gClass.method_0(new GClass14(mResources.change_flag, this, 10030, null));
			gClass.method_0(new GClass14(mResources.BACK, this, 10031, null));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
		}
	}

	private void method_182()
	{
		if (int_66 == 0)
		{
			bool_22 = !bool_22;
			GClass120.smethod_9("viewchat", bool_22 ? 1 : 0);
			if (GClass39.bool_5)
				int_66 = -1;
		}
		else if (int_66 >= 0 && gclass63_3.method_2() != 0)
		{
			GClass63 gClass = new GClass63();
			int_147 = int_66 - 1;
			gClass.method_0(new GClass14(mResources.CHAT, this, 8001, (GClass43)gclass63_3.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.make_friend, this, 8003, (GClass43)gclass63_3.method_3(int_147)));
			gClass.method_0(new GClass14(mResources.den, this, 8004, (GClass43)gclass63_3.method_3(int_147)));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_186((GClass43)gclass63_3.method_3(int_66 - 1));
		}
	}

	private void method_183()
	{
		try
		{
			int_62 = null;
			gclass58_1 = null;
			GClass56.smethod_8("cSelect= " + int_67);
			if (int_66 < 0)
			{
				int_67 = -1;
				return;
			}
			if (GClass58.smethod_1().gclass21_0 == null)
			{
				if (int_66 == 0)
				{
					if (int_67 == 0)
						method_171();
					else if (int_67 == 1)
					{
						GClass57.smethod_1();
						method_173();
						GClass166.smethod_0().method_28(1, -1, null);
					}
				}
				else if (int_66 != -1)
				{
					if (int_66 == 1)
					{
						if (bool_10)
							GClass166.smethod_0().method_23(string.Empty);
						else if (bool_12 && gclass21_0 != null)
						{
							GClass39.smethod_36(mResources.do_u_want_join_clan + gclass21_0.string_0, new GClass14(mResources.YES, this, 4000, gclass21_0), new GClass14(mResources.NO, this, 4005, gclass21_0));
						}
					}
					else if (bool_10)
					{
						gclass21_0 = method_111();
						if (gclass21_0 != null)
						{
							GClass63 gClass = new GClass63();
							gClass.method_0(new GClass14(mResources.request_join_clan, this, 4000, gclass21_0));
							gClass.method_0(new GClass14(mResources.view_clan_member, this, 4001, gclass21_0));
							GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
							method_48(method_111());
						}
					}
					else if (bool_12)
					{
						gclass206_0 = method_109();
						if (gclass206_0 != null)
						{
							GClass63 gClass2 = new GClass63();
							gClass2.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass21_0));
							GClass39.gclass0_0.method_1(gClass2, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
							GClass39.gclass0_0.method_1(gClass2, 0, (int_66 + 1) * int_4 - int_8 + int_58);
							method_47(gclass206_0);
						}
					}
				}
			}
			else if (int_66 == 0)
			{
				if (bool_11)
				{
					if (int_67 == 0)
					{
						if (gclass63_2.method_2() > 1)
							method_172();
						else
						{
							gclass63_1 = null;
							bool_10 = false;
							bool_12 = true;
							bool_11 = false;
							int_41 = gclass63_2.method_2() + 2;
							method_78();
						}
					}
					if (int_67 == 1)
						GClass166.smethod_0().method_19(1, null, -1);
					if (int_67 == 2)
					{
						gclass63_1 = null;
						bool_10 = false;
						bool_12 = true;
						bool_11 = false;
						int_41 = gclass63_2.method_2() + 2;
						method_78();
						method_67();
					}
				}
				else if (bool_12)
				{
					if (int_67 == 0)
					{
						bool_10 = false;
						bool_12 = false;
						bool_11 = true;
						int_41 = GClass62.gclass63_0.method_2() + 2;
						method_78();
					}
					if (int_67 == 1)
					{
						if (gclass63_2.method_2() > 1)
							GClass166.smethod_0().method_26();
						else
							method_176();
					}
					if (int_67 == 2)
					{
						if (gclass63_2.method_2() > 1)
							method_176();
						else
							GClass166.smethod_0().method_28(3, -1, null);
					}
					if (int_67 == 3)
						GClass166.smethod_0().method_28(3, -1, null);
				}
			}
			else if (int_66 == 1)
			{
				if (bool_10)
					GClass166.smethod_0().method_23(string.Empty);
			}
			else if (bool_10)
			{
				gclass21_0 = method_111();
				if (gclass21_0 != null)
				{
					GClass63 gClass3 = new GClass63();
					gClass3.method_0(new GClass14(mResources.view_clan_member, this, 4001, gclass21_0));
					GClass39.gclass0_0.method_1(gClass3, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_48(method_111());
				}
			}
			else if (bool_12)
			{
				GClass56.smethod_8("TOI DAY 1");
				gclass206_0 = method_109();
				if (gclass206_0 != null)
				{
					GClass63 gClass4 = new GClass63();
					GClass56.smethod_8("TOI DAY 2");
					if (gclass63_1 != null)
					{
						gClass4.method_0(new GClass14(mResources.CLOSE, this, 8000, null));
						GClass56.smethod_8("TOI DAY 3");
					}
					else if (gclass63_2 != null)
					{
						GClass56.smethod_8("TOI DAY 4");
						GClass56.smethod_8("my role= " + GClass58.smethod_1().sbyte_17);
						if (GClass58.smethod_1().int_13 == gclass206_0.int_0 || GClass58.smethod_1().sbyte_17 == 2)
							gClass4.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass206_0));
						if (GClass58.smethod_1().sbyte_17 < 2 && GClass58.smethod_1().int_13 != gclass206_0.int_0)
						{
							GClass56.smethod_8("TOI DAY");
							if (gclass206_0.sbyte_0 == 0 || gclass206_0.sbyte_0 == 1)
								gClass4.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass206_0));
							if (gclass206_0.sbyte_0 == 2)
								gClass4.method_0(new GClass14(mResources.create_clan_co_leader, this, 5002, gclass206_0));
							if (GClass58.smethod_1().sbyte_17 == 0)
							{
								gClass4.method_0(new GClass14(mResources.create_clan_leader, this, 5001, gclass206_0));
								if (gclass206_0.sbyte_0 == 1)
									gClass4.method_0(new GClass14(mResources.disable_clan_mastership, this, 5003, gclass206_0));
							}
						}
						if (GClass58.smethod_1().sbyte_17 < gclass206_0.sbyte_0)
							gClass4.method_0(new GClass14(mResources.kick_clan_mem, this, 5004, gclass206_0));
						gClass4.method_0(new GClass14(mResources.den, this, 8005, gclass206_0));
						gClass4.method_0(new GClass14((!GClass195.smethod_0().list_0.Contains(gclass206_0.string_0)) ? ((GClass192.int_0 == 0) ? "Thêm vào\ndanh sách\nnhận đậu" : "Add to\nlist receive\nbean") : ((GClass192.int_0 == 0) ? "Xóa khỏi\ndanh sách\nnhận đậu" : "Remove from\nlist receive\nbean"), this, 8006, gclass206_0));
						gClass4.method_0(new GClass14(mResources.make_friend, this, 8007, gclass206_0));
					}
					GClass39.gclass0_0.method_1(gClass4, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_47(gclass206_0);
				}
			}
			else if (bool_11)
			{
				gclass62_0 = method_110();
				if (gclass62_0 != null)
				{
					if (gclass62_0.int_1 == 0)
					{
						GClass63 gClass5 = new GClass63();
						gClass5.method_0(new GClass14(mResources.CLOSE, this, 8000, gclass62_0));
						GClass39.gclass0_0.method_1(gClass5, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
						method_45(gclass62_0);
					}
					else if (gclass62_0.int_1 == 1)
					{
						if (gclass62_0.int_2 != GClass58.smethod_1().int_13 && int_67 != -1)
							GClass166.smethod_0().method_18(gclass62_0.int_0);
					}
					else if (gclass62_0.int_1 == 2 && gclass62_0.string_2 != null)
					{
						if (int_67 == 0)
							GClass166.smethod_0().method_21(gclass62_0.int_0, 1);
						else if (int_67 == 1)
						{
							GClass166.smethod_0().method_21(gclass62_0.int_0, 0);
						}
					}
				}
			}
			if (GClass39.bool_5)
			{
				int_67 = -1;
				int_66 = -1;
			}
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
				if (string_3.Length == 4)
					method_167();
				else
					method_183();
			}
			if (int_29 == 4)
				method_167();
		}
		catch (Exception ex)
		{
			GClass56.smethod_8("Throw ex " + ex.StackTrace);
		}
	}

	private void method_185()
	{
		if (int_66 < 0)
			return;
		if (GClass58.smethod_1().int_11 == 14)
		{
			GClass39.smethod_30(mResources.can_not_do_when_die);
			return;
		}
		if (int_66 == 0 || int_66 == 1 || int_66 == 2 || int_66 == 3 || int_66 == 4 || int_66 == 5)
		{
			long long_ = GClass58.smethod_1().long_4;
			int num = GClass58.smethod_1().int_155;
			int num2 = GClass58.smethod_1().int_156;
			int num3 = GClass58.smethod_1().int_154;
			int num4 = GClass58.smethod_1().int_157;
			_ = GClass58.smethod_1().int_158;
			int num5 = 1000;
			if (int_66 == 0)
			{
				if (long_ < GClass58.smethod_1().int_155 + num5)
				{
					GClass39.smethod_32(mResources.not_enough_potential_point1 + GClass58.smethod_1().long_4 + mResources.not_enough_potential_point2 + (GClass58.smethod_1().int_155 + num5), false);
					return;
				}
				if (long_ > num && long_ < 10 * (2 * (num + num5) + 180) / 2)
				{
					GClass39.smethod_36(mResources.use_potential_point_for1 + (num + num5) + mResources.use_potential_point_for2 + GClass58.smethod_1().sbyte_30 + mResources.for_HP, new GClass14(mResources.increase_upper, this, 9000, null), new GClass14(mResources.CANCEL, this, 4007, null));
					return;
				}
				if (long_ >= 10 * (2 * (num + num5) + 180) / 2 && long_ < 100 * (2 * (num + num5) + 1980) / 2)
				{
					GClass63 gClass = new GClass63(string.Empty);
					gClass.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass56.smethod_32(num + num5), this, 9000, null));
					gClass.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass56.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
					GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
				if (long_ >= 100 * (2 * (num + num5) + 1980) / 2)
				{
					GClass63 gClass2 = new GClass63(string.Empty);
					gClass2.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass56.smethod_32(num + num5), this, 9000, null));
					gClass2.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass56.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
					gClass2.method_0(new GClass14(mResources.increase_upper + "\n" + 100 * GClass58.smethod_1().sbyte_30 + mResources.HP + "\n-" + GClass56.smethod_32(100 * (2 * (num + num5) + 1980) / 2), this, 9007, null));
					GClass39.gclass0_0.method_1(gClass2, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
			}
			if (int_66 == 1)
			{
				if (GClass58.smethod_1().long_4 < GClass58.smethod_1().int_156 + num5)
				{
					GClass39.smethod_30(mResources.not_enough_potential_point1 + GClass58.smethod_1().long_4 + mResources.not_enough_potential_point2 + (GClass58.smethod_1().int_156 + num5));
					return;
				}
				if (long_ > num2 && long_ < 10 * (2 * (num2 + num5) + 180) / 2)
				{
					GClass39.smethod_36(mResources.use_potential_point_for1 + (num2 + num5) + mResources.use_potential_point_for2 + GClass58.smethod_1().sbyte_31 + mResources.for_KI, new GClass14(mResources.increase_upper, this, 9000, null), new GClass14(mResources.CANCEL, this, 4007, null));
					return;
				}
				if (long_ >= 10 * (2 * (num2 + num5) + 180) / 2 && long_ < 100 * (2 * (num2 + num5) + 1980) / 2)
				{
					GClass63 gClass3 = new GClass63(string.Empty);
					gClass3.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass56.smethod_32(num + num5), this, 9000, null));
					gClass3.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass56.smethod_32(10 * (2 * (num + num5) + 180) / 2), this, 9006, null));
					GClass39.gclass0_0.method_1(gClass3, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
				if (long_ >= 100 * (2 * (num2 + num5) + 1980) / 2)
				{
					GClass63 gClass4 = new GClass63(string.Empty);
					gClass4.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass56.smethod_32(num2 + num5), this, 9000, null));
					gClass4.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass56.smethod_32(10 * (2 * (num2 + num5) + 180) / 2), this, 9006, null));
					gClass4.method_0(new GClass14(mResources.increase_upper + "\n" + 100 * GClass58.smethod_1().sbyte_31 + mResources.KI + "\n-" + GClass56.smethod_32(100 * (2 * (num2 + num5) + 1980) / 2), this, 9007, null));
					GClass39.gclass0_0.method_1(gClass4, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
			}
			if (int_66 == 2)
			{
				if (GClass58.smethod_1().long_4 < GClass58.smethod_1().int_154 * GClass58.smethod_1().short_25)
				{
					GClass39.smethod_30(mResources.not_enough_potential_point1 + GClass58.smethod_1().long_4 + mResources.not_enough_potential_point2 + num3 * 100);
					return;
				}
				if (long_ > num3 && long_ < 10 * (2 * num3 + 9) / 2 * GClass58.smethod_1().short_25)
				{
					GClass39.smethod_36(mResources.use_potential_point_for1 + num3 * 100 + mResources.use_potential_point_for2 + GClass58.smethod_1().sbyte_32 + mResources.for_hit_point, new GClass14(mResources.increase_upper, this, 9000, null), new GClass14(mResources.CANCEL, this, 4007, null));
					return;
				}
				if (long_ >= 10 * (2 * num3 + 9) / 2 * GClass58.smethod_1().short_25 && long_ < 100 * (2 * num3 + 99) / 2 * GClass58.smethod_1().short_25)
				{
					GClass63 gClass5 = new GClass63(string.Empty);
					gClass5.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass56.smethod_32(num3 * 100), this, 9000, null));
					gClass5.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass56.smethod_32(10 * (2 * num3 + 9) / 2 * GClass58.smethod_1().short_25), this, 9006, null));
					GClass39.gclass0_0.method_1(gClass5, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
				if (long_ >= 100 * (2 * num3 + 99) / 2 * GClass58.smethod_1().short_25)
				{
					GClass63 gClass6 = new GClass63(string.Empty);
					gClass6.method_0(new GClass14(mResources.increase_upper + "\n" + GClass58.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass56.smethod_32(num3 * 100), this, 9000, null));
					gClass6.method_0(new GClass14(mResources.increase_upper + "\n" + 10 * GClass58.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass56.smethod_32(10 * (2 * num3 + 9) / 2 * GClass58.smethod_1().short_25), this, 9006, null));
					gClass6.method_0(new GClass14(mResources.increase_upper + "\n" + 100 * GClass58.smethod_1().sbyte_32 + "\n" + mResources.hit_point + "\n-" + GClass56.smethod_32(100 * (2 * num3 + 99) / 2 * GClass58.smethod_1().short_25), this, 9007, null));
					GClass39.gclass0_0.method_1(gClass6, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
					method_187(int_66);
				}
			}
			if (int_66 == 3)
			{
				if (GClass58.smethod_1().long_4 < 50000 + GClass58.smethod_1().int_157 * 1000)
				{
					GClass39.smethod_30(mResources.not_enough_potential_point1 + GClass95.smethod_9(GClass58.smethod_1().long_4) + mResources.not_enough_potential_point2 + GClass95.smethod_9(50000 + GClass58.smethod_1().int_157 * 1000));
					return;
				}
				long number = 2 * (num4 + 5) / 2L * 100000L;
				long number2 = 10L * (2 * (num4 + 5) + 9) / 2L * 100000L;
				long number3 = 100L * (2 * (num4 + 5) + 99) / 2L * 100000L;
				mResources.use_potential_point_for1 = mResources.increase_upper;
				GClass63 gClass7 = new GClass63(string.Empty);
				gClass7.method_0(new GClass14(mResources.use_potential_point_for1 + "\n1 " + mResources.armor + "\n" + GClass56.smethod_32(number), this, 9000, null));
				gClass7.method_0(new GClass14(mResources.use_potential_point_for1 + "\n10 " + mResources.armor + "\n" + GClass56.smethod_32(number2), this, 9006, null));
				gClass7.method_0(new GClass14(mResources.use_potential_point_for1 + "\n100 " + mResources.armor + "\n" + GClass56.smethod_32(number3), this, 9007, null));
				GClass39.gclass0_0.method_1(gClass7, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
				method_187(int_66);
			}
			else if (int_66 == 4)
			{
				long num6 = 50000000L;
				int num7 = GClass58.smethod_1().int_158;
				if (num7 > long_0.Length - 1)
					num7 = long_0.Length - 1;
				num6 = long_0[num7];
				if (GClass58.smethod_1().long_4 < num6)
				{
					GClass39.smethod_30(mResources.not_enough_potential_point1 + GClass56.smethod_32(GClass58.smethod_1().long_4) + mResources.not_enough_potential_point2 + GClass56.smethod_32(num6));
					return;
				}
				GClass39.smethod_36(mResources.use_potential_point_for1 + GClass56.smethod_31(num6) + mResources.use_potential_point_for2 + GClass58.smethod_1().sbyte_34 + mResources.for_crit, new GClass14(mResources.increase_upper, this, 9000, null), new GClass14(mResources.CANCEL, this, 4007, null));
			}
			else if (int_66 == 5)
			{
				GClass166.smethod_0().method_8(0);
			}
			return;
		}
		int num8 = int_66 - 6;
		GClass53 gClass8 = GClass58.smethod_1().gclass109_0.gclass53_0[num8];
		GClass74 gClass9 = GClass58.smethod_1().method_15(gClass8);
		GClass74 gClass10 = null;
		GClass63 gClass11 = new GClass63(string.Empty);
		if (gClass9 != null)
		{
			if (gClass9.int_0 == gClass8.int_1)
			{
				gClass11.method_0(new GClass14(mResources.make_shortcut, this, 9003, gClass9.gclass53_0));
				gClass11.method_0(new GClass14(mResources.CLOSE, 2));
			}
			else
			{
				gClass10 = gClass8.gclass74_0[gClass9.int_0];
				gClass11.method_0(new GClass14(mResources.UPGRADE, this, 9002, gClass10));
				gClass11.method_0(new GClass14(mResources.make_shortcut, this, 9003, gClass9.gclass53_0));
			}
		}
		else
		{
			gClass10 = gClass8.gclass74_0[0];
			gClass11.method_0(new GClass14(mResources.learn, this, 9004, gClass10));
		}
		GClass39.gclass0_0.method_1(gClass11, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
		method_49(gClass8, gClass9, gClass10);
	}

	private void method_186(GClass43 gclass43_0)
	{
		string chat = string.Concat(string.Concat(string.Concat("|0|1|" + gclass43_0.gclass58_0.string_3, "\n"), "\n--"), "\n|5|", GClass56.smethod_30(gclass43_0.string_0, "|", 0)[2]);
		gclass70_0 = new GClass70();
		method_43(gclass70_0, chat);
		gclass58_1 = gclass43_0.gclass58_0;
		gclass121_0 = null;
	}

	private void method_187(int int_177)
	{
		string empty = string.Empty;
		int num = 0;
		if (int_66 == 0)
			num = GClass58.smethod_1().int_155 + 1000;
		if (int_66 == 1)
			num = GClass58.smethod_1().int_156 + 1000;
		if (int_66 == 2)
			num = GClass58.smethod_1().int_154 * GClass58.smethod_1().short_25;
		if (int_66 == 3)
			num = 500000 + GClass58.smethod_1().int_157 * 100000;
		string text = empty;
		empty = text + "|5|2|" + mResources.USE + " " + num + " " + mResources.potential;
		if (int_177 == 0)
			empty = empty + "\n|5|2|" + mResources.to_gain_20hp;
		if (int_177 == 1)
			empty = empty + "\n|5|2|" + mResources.to_gain_20mp;
		if (int_177 == 2)
			empty = empty + "\n|5|2|" + mResources.to_gain_1pow;
		if (int_177 == 3)
			empty = empty + "\n|5|2|" + mResources.to_gain_1pow;
		gclass121_0 = null;
		int_62 = null;
		gclass58_1 = null;
		int_61 = -1;
		gclass70_0 = new GClass70();
		method_43(gclass70_0, empty);
	}

	private void method_188()
	{
	}

	private void method_189()
	{
		if (gclass2_2 != null)
		{
			gclass2_2.texture2D_0 = null;
			gclass2_2 = null;
		}
		GClass1.sbyte_3 = -1;
		GClass138.smethod_26();
		GClass96.smethod_0();
		method_40();
		int_14 = 0;
		int_15 = 0;
	}

	private void method_190()
	{
		if (int_66 != -1)
		{
			GClass56.smethod_8("FIRE ZONE");
			bool_23 = true;
			GClass39.gclass45_0.method_151();
		}
	}

	public void method_191(int recieve, int maxCap)
	{
		gclass70_0.string_0[gclass70_0.string_0.Length - 1] = mResources.received + " " + recieve + "/" + maxCap;
	}

	private void method_192()
	{
		if (int_66 < 0)
			return;
		gclass121_0 = null;
		GClass63 gClass = new GClass63();
		if (int_29 == 0 && !Equals(GClass39.gclass45_1))
		{
			GClass121 gClass2 = GClass58.smethod_1().gclass121_1[int_66];
			if (gClass2 != null)
			{
				if (bool_8)
				{
					gClass.method_0(new GClass14(mResources.GETOUT, this, 1000, gClass2));
					gClass.method_0(new GClass14(mResources.USE, this, 2010, gClass2));
				}
				else if (gClass2.method_11())
				{
					gClass.method_0(new GClass14(mResources.GETOUT, this, 1000, gClass2));
				}
				else
				{
					gClass.method_0(new GClass14(mResources.GETOUT, this, 1000, gClass2));
				}
				gclass121_0 = gClass2;
			}
		}
		if (int_29 == 1 || Equals(GClass39.gclass45_1))
		{
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
			if (int_66 >= gclass121_.Length)
			{
				sbyte b = (sbyte)(int_66 - gclass121_.Length);
				GClass121 gClass3 = GClass58.smethod_1().gclass121_0[b];
				if (gClass3 != null)
				{
					gClass.method_0(new GClass14(mResources.move_to_chest, this, 1001, gClass3));
					if (gClass3.method_11())
						gClass.method_0(new GClass14(mResources.USE, this, 2000, gClass3));
					else
						gClass.method_0(new GClass14(mResources.USE, this, 2001, gClass3));
					gclass121_0 = gClass3;
				}
			}
			else
			{
				GClass121 gClass4 = GClass58.smethod_1().gclass121_2[int_66];
				if (gClass4 != null)
				{
					gClass.method_0(new GClass14(mResources.move_to_chest2, this, 1002, gClass4));
					gclass121_0 = gClass4;
				}
			}
		}
		if (gclass121_0 != null)
		{
			GClass58.smethod_1().method_135(gclass121_0.int_44, gclass121_0.int_45, gclass121_0.int_46, gclass121_0.int_47);
			if (bool_8)
				gClass.method_0(new GClass14(mResources.MOVEOUT, this, 2011, gclass121_0));
			GClass39.gclass0_0.method_1(gClass, int_0, (int_66 + 1) * int_4 - int_8 + int_58);
			method_42(gclass121_0);
		}
		else
			gclass70_0 = null;
	}

	public void method_193(sbyte itemAction, string info, sbyte where, sbyte index)
	{
		GClass39.smethod_29();
		GClass115 gClass = new GClass115();
		gClass.int_2 = itemAction;
		gClass.int_0 = index;
		gClass.int_1 = where;
		GClass39.smethod_36(info, new GClass14(mResources.YES, this, 2004, gClass), new GClass14(mResources.NO, this, 4005, null));
	}

	public void method_194(sbyte type, string info, short id)
	{
		GClass115 gClass = new GClass115();
		gClass.int_2 = type;
		gClass.int_0 = id;
		GClass39.smethod_36(info, new GClass14(mResources.YES, this, 3003, gClass), new GClass14(mResources.NO, this, 4005, null));
	}

	public void perform(int idAction, object p)
	{
		if (idAction == 9999)
		{
			GClass8 gClass = (GClass8)p;
			GClass166.smethod_0().method_141(gClass.int_2);
		}
		if (idAction == 170391)
		{
			GClass120.smethod_13();
			if (GClass76.int_12 > 1)
				GClass120.smethod_9("levelScreenKN", 1);
			else
				GClass120.smethod_9("levelScreenKN", 0);
			GClass113.gclass113_0.method_1();
		}
		if (idAction == 6001)
		{
			GClass121 gClass2 = (GClass121)p;
			gClass2.bool_0 = false;
			GClass39.gclass45_0.gclass63_0.method_8(gClass2);
			if (GClass39.gclass45_0.int_29 == 0)
				GClass39.gclass45_0.method_36();
		}
		if (idAction == 6000)
		{
			GClass121 gClass3 = (GClass121)p;
			for (int i = 0; i < GClass39.gclass45_0.gclass63_0.method_2(); i++)
			{
				if (((GClass121)GClass39.gclass45_0.gclass63_0.method_3(i)).gclass118_0.short_0 == gClass3.gclass118_0.short_0)
				{
					GClass39.smethod_30(mResources.already_has_item);
					return;
				}
			}
			gClass3.bool_0 = true;
			GClass39.gclass45_0.gclass63_0.method_0(gClass3);
			if (GClass39.gclass45_0.int_29 == 0)
				GClass39.gclass45_0.method_36();
		}
		if (idAction == 7000)
		{
			if (bool_1)
			{
				GClass39.smethod_30(mResources.unlock_item_to_trade);
				return;
			}
			GClass121 gClass4 = (GClass121)p;
			for (int j = 0; j < GClass39.gclass45_0.gclass63_6.method_2(); j++)
			{
				if (((GClass121)GClass39.gclass45_0.gclass63_6.method_3(j)).int_29 == gClass4.int_29)
				{
					GClass39.smethod_30(mResources.already_has_item);
					return;
				}
			}
			if (gClass4.int_30 > 1)
			{
				method_175();
				return;
			}
			gClass4.bool_0 = true;
			GClass121 gClass5 = new GClass121();
			gClass5.gclass118_0 = gClass4.gclass118_0;
			gClass5.gclass20_0 = gClass4.gclass20_0;
			gClass5.int_29 = gClass4.int_29;
			GClass39.gclass45_0.gclass63_6.method_0(gClass5);
			GClass166.smethod_0().method_6(2, -1, (sbyte)gClass5.int_29, gClass5.int_30);
		}
		if (idAction == 7001)
		{
			GClass121 gClass6 = (GClass121)p;
			gClass6.bool_0 = false;
			GClass39.gclass45_0.gclass63_6.method_8(gClass6);
			if (GClass39.gclass45_0.int_29 == 1)
				GClass39.gclass45_0.method_61(true);
			GClass166.smethod_0().method_6(4, -1, (sbyte)gClass6.int_29, -1);
		}
		if (idAction == 7002)
		{
			bool_3 = true;
			GClass39.smethod_29();
			GClass166.smethod_0().method_6(7, -1, -1, -1);
			method_151();
		}
		if (idAction == 8003)
		{
			GClass43 gClass7 = (GClass43)p;
			GClass166.smethod_0().method_13(1, gClass7.gclass58_0.int_13);
			if (int_28 == 8)
				;
		}
		if (idAction == 8002)
		{
			GClass43 gClass8 = (GClass43)p;
			GClass166.smethod_0().method_13(2, gClass8.gclass58_0.int_13);
		}
		if (idAction == 8004)
		{
			GClass43 gClass9 = (GClass43)p;
			GClass191.smethod_0().method_23(gClass9.gclass58_0.int_13);
		}
		if (idAction == 8005)
		{
			GClass206 gClass10 = (GClass206)p;
			GClass191.smethod_0().method_23(gClass10.int_0);
		}
		if (idAction == 8006)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass206 gClass11 = (GClass206)p;
			if (GClass195.smethod_0().list_0.Contains(gClass11.string_0))
			{
				GClass195.smethod_0().list_0.Remove(gClass11.string_0);
				GClass188.smethod_1("Đã xóa [" + gClass11.string_0 + "] khỏi danh sách nhận đậu", 0);
			}
			else
			{
				GClass195.smethod_0().list_0.Add(gClass11.string_0);
				GClass188.smethod_1("Đã thêm [" + gClass11.string_0 + "] vào danh sách nhận đậu", 0);
			}
		}
		if (idAction == 8007)
		{
			GClass206 gClass12 = (GClass206)p;
			GClass166.smethod_0().method_13(1, gClass12.int_0);
			if (int_28 == 8)
				;
		}
		if (idAction == 8008)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass43 gClass13 = (GClass43)p;
			GClass191.smethod_0().bool_3 = !GClass191.smethod_0().bool_3;
			GClass191.smethod_0().int_4 = gClass13.gclass58_0.int_13;
			GClass188.smethod_1("Tự động dịch chuyển tới [" + gClass13.gclass58_0.string_3 + "]: " + GClass193.smethod_0().method_6(GClass191.smethod_0().bool_3), 0);
		}
		if (idAction == 3142)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_12(gclass121_0, 1, "suphu");
		}
		if (idAction == 3143)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_12(gclass121_0, 2, "suphu");
		}
		if (idAction == 3140)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_12(gclass121_0, 1, "detu");
		}
		if (idAction == 3141)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_12(gclass121_0, 2, "detu");
		}
		if (idAction == 3144)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_14(gclass121_0);
		}
		if (idAction == 3145)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			GClass183.smethod_0().method_24(gclass121_0);
		}
		if (idAction == 8001)
		{
			GClass56.smethod_8("chat player");
			GClass43 gClass14 = (GClass43)p;
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = GClass39.gclass45_0;
			}
			gclass7_0.string_1 = mResources.chat_player;
			gclass7_0.gclass67_0.string_7 = mResources.chat_with + " " + gClass14.gclass58_0.string_3;
			gclass7_0.string_0 = string.Empty;
			gclass7_0.bool_0 = true;
			gclass7_0.gclass67_0.bool_0 = true;
			gclass7_0.gclass67_0.method_28(GClass67.int_11);
			if (Main.isWindowsPhone)
				gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
			if (!Main.isPC)
				gclass7_0.method_5(this, string.Empty);
		}
		if (idAction == 1000)
			GClass166.smethod_0().method_30(sbyte_0, (sbyte)int_66);
		if (idAction == 1001)
		{
			GClass121[] gclass121_ = GClass58.smethod_1().gclass121_2;
			sbyte id = (sbyte)(int_66 - gclass121_.Length);
			GClass166.smethod_0().method_30(sbyte_1, id);
		}
		if (idAction == 1003)
			method_151();
		if (idAction == 1002)
			GClass166.smethod_0().method_30(sbyte_3, (sbyte)int_66);
		if (idAction == 2011)
			GClass166.smethod_0().method_20(1, 2, (sbyte)int_66, -1);
		if (idAction == 2010)
		{
			GClass166.smethod_0().method_20(0, 2, (sbyte)int_66, -1);
			GClass121 gClass15 = (GClass121)p;
			if (gClass15 != null && (gClass15.gclass118_0.short_0 == 193 || gClass15.gclass118_0.short_0 == 194))
				GClass39.gclass45_0.method_151();
		}
		if (idAction == 2000)
		{
			GClass121[] gclass121_2 = GClass58.smethod_1().gclass121_2;
			sbyte id2 = (sbyte)(int_66 - gclass121_2.Length);
			GClass166.smethod_0().method_30(sbyte_4, id2);
		}
		if (idAction == 2001)
		{
			GClass56.smethod_8("use item");
			GClass121 gClass16 = (GClass121)p;
			bool flag = int_66 < GClass58.smethod_1().gclass121_2.Length;
			sbyte b = 0;
			if (!flag)
				b = (sbyte)(int_66 - GClass58.smethod_1().gclass121_2.Length);
			GClass166.smethod_0().method_20(0, (!flag) ? ((sbyte)1) : ((sbyte)0), (sbyte)((!flag) ? b : int_66), -1);
			if (gClass16.gclass118_0.short_0 == 193 || gClass16.gclass118_0.short_0 == 194)
				GClass39.gclass45_0.method_151();
		}
		if (idAction == 2002)
		{
			GClass166.smethod_0().method_30(sbyte_5, (sbyte)int_66);
			if (int_66 == 5)
			{
				string text = string.Empty;
				if (GClass58.smethod_1().gclass121_2[5].gclass20_0 != null)
				{
					for (int k = 0; k < GClass58.smethod_1().gclass121_2[5].gclass20_0.Length; k++)
					{
						text = text + GClass58.smethod_1().gclass121_2[5].gclass20_0[k].gclass114_0.int_0 + "-";
					}
				}
				foreach (GClass183.GStruct1 item in GClass183.smethod_0().list_1)
				{
					if (item.int_0 == GClass58.smethod_1().gclass121_2[5].gclass118_0.short_0 && item.string_0 == text && item.int_1 == GClass58.smethod_1().gclass121_2[5].gclass118_0.sbyte_0)
						GClass183.smethod_0().list_1.Remove(item);
				}
			}
			if (int_66 == 6)
			{
				string text2 = string.Empty;
				if (GClass58.smethod_1().gclass121_2[6].gclass20_0 != null)
				{
					for (int l = 0; l < GClass58.smethod_1().gclass121_2[6].gclass20_0.Length; l++)
					{
						text2 = text2 + GClass58.smethod_1().gclass121_2[6].gclass20_0[l].gclass114_0.int_0 + "-";
					}
				}
				foreach (GClass183.GStruct7 item2 in GClass183.smethod_0().list_0)
				{
					if (item2.int_0 == GClass58.smethod_1().gclass121_2[6].gclass118_0.short_0 && item2.string_0 == text2 && item2.int_1 == GClass58.smethod_1().gclass121_2[6].gclass118_0.sbyte_0)
						GClass183.smethod_0().list_0.Remove(item2);
				}
			}
		}
		if (idAction == 2003)
		{
			GClass56.smethod_8("remove item");
			bool flag2 = int_66 < GClass58.smethod_1().gclass121_2.Length;
			sbyte b2 = 0;
			if (!flag2)
				b2 = (sbyte)(int_66 - GClass58.smethod_1().gclass121_2.Length);
			GClass166.smethod_0().method_20(1, (!flag2) ? ((sbyte)1) : ((sbyte)0), (sbyte)((!flag2) ? b2 : int_66), -1);
		}
		if (idAction == 2004)
		{
			GClass39.smethod_29();
			GClass115 gClass17 = (GClass115)p;
			sbyte where = (sbyte)gClass17.int_1;
			sbyte index = (sbyte)gClass17.int_0;
			GClass166.smethod_0().method_20((sbyte)((gClass17.int_2 != 0) ? 2 : 3), where, index, -1);
		}
		if (idAction == 2005)
		{
			GClass121[] gclass121_3 = GClass58.smethod_1().gclass121_2;
			sbyte id3 = (sbyte)(int_66 - gclass121_3.Length);
			GClass166.smethod_0().method_30(UgAykqYvHY, id3);
		}
		if (idAction == 2006)
		{
			_ = GClass58.smethod_2().gclass121_2;
			sbyte id4 = (sbyte)int_66;
			GClass166.smethod_0().method_30(sbyte_6, id4);
		}
		if (idAction == 30001)
		{
			GClass56.smethod_8("nhan do");
			GClass166.smethod_0().method_55(0, int_66, 0);
		}
		if (idAction == 30002)
		{
			GClass56.smethod_8("xoa do");
			GClass166.smethod_0().method_55(1, int_66, 0);
		}
		if (idAction == 30003)
		{
			GClass56.smethod_8("nhan tat");
			GClass166.smethod_0().method_55(2, int_66, 0);
		}
		if (idAction == 3000)
		{
			GClass56.smethod_8("mua do");
			GClass121 gClass18 = (GClass121)p;
			GClass166.smethod_0().method_55(0, gClass18.gclass118_0.short_0, 0);
		}
		if (idAction == 3001)
		{
			GClass121 gClass19 = (GClass121)p;
			GClass166.smethod_0().method_55(1, gClass19.gclass118_0.short_0, 0);
		}
		if (idAction == 3002)
		{
			GClass39.smethod_29();
			GClass166.smethod_0().method_54(0, (sbyte)((int_66 > 6) ? 1 : 0), (short)((int_66 >= 10) ? (int_66 - 10) : int_66));
		}
		if (idAction == 3003)
		{
			GClass39.smethod_29();
			GClass115 gClass20 = (GClass115)p;
			GClass166.smethod_0().method_54(1, (sbyte)gClass20.int_2, (short)gClass20.int_0);
		}
		if (idAction == 3004)
		{
			GClass121 gClass21 = (GClass121)p;
			GClass166.smethod_0().method_55(3, gClass21.gclass118_0.short_0, 0);
		}
		if (idAction == 3005)
		{
			GClass56.smethod_8("mua do");
			GClass121 gClass22 = (GClass121)p;
			GClass166.smethod_0().method_55(3, gClass22.gclass118_0.short_0, 0);
		}
		if (idAction == 4000)
		{
			GClass21 gClass23 = (GClass21)p;
			if (gClass23 != null)
			{
				GClass39.smethod_29();
				GClass166.smethod_0().method_19(2, null, gClass23.int_0);
			}
		}
		if (idAction == 4001)
		{
			GClass21 gClass24 = (GClass21)p;
			if (gClass24 != null)
			{
				GClass57.smethod_1();
				string_21 = mResources.PLEASEWAIT;
				GClass166.smethod_0().method_22(gClass24.int_0);
			}
		}
		if (idAction == 4005)
			GClass39.smethod_29();
		if (idAction == 4007)
			GClass39.smethod_29();
		if (idAction == 4006)
		{
			GClass62 gClass25 = (GClass62)p;
			GClass166.smethod_0().method_18(gClass25.int_0);
		}
		if (idAction == 5001)
		{
			GClass206 gClass26 = (GClass206)p;
			GClass166.smethod_0().method_25(gClass26.int_0, 0);
		}
		if (idAction == 5002)
		{
			GClass206 gClass27 = (GClass206)p;
			GClass166.smethod_0().method_25(gClass27.int_0, 1);
		}
		if (idAction == 5003)
		{
			GClass206 gClass28 = (GClass206)p;
			GClass166.smethod_0().method_25(gClass28.int_0, 2);
		}
		if (idAction == 5004)
		{
			GClass206 gClass29 = (GClass206)p;
			GClass166.smethod_0().method_25(gClass29.int_0, -1);
		}
		if (idAction == 9000)
		{
			GClass166.smethod_0().method_124(int_66, 1);
			GClass39.smethod_29();
			GClass57.smethod_1();
		}
		if (idAction == 9006)
		{
			GClass166.smethod_0().method_124(int_66, 10);
			GClass39.smethod_29();
			GClass57.smethod_1();
		}
		if (idAction == 9007)
		{
			GClass166.smethod_0().method_124(int_66, 100);
			GClass39.smethod_29();
			GClass57.smethod_1();
		}
		if (idAction == 9002)
		{
			GClass74 gClass30 = (GClass74)p;
			if (gClass30.gclass53_0.method_3())
				GClass39.smethod_30(mResources.updSkill);
			else
				GClass39.smethod_30(mResources.can_buy_from_Uron1 + gClass30.long_0 + mResources.can_buy_from_Uron2 + gClass30.string_0 + mResources.can_buy_from_Uron3);
		}
		if (idAction == 9003)
		{
			if (GClass39.bool_5 && !Main.isPC)
				GClass154.smethod_8().method_10((GClass53)p);
			else
				GClass154.smethod_8().method_11((GClass53)p);
		}
		if (idAction == 9004)
		{
			GClass74 gClass31 = (GClass74)p;
			if (gClass31.gclass53_0.method_3())
				GClass39.smethod_30(mResources.learnSkill);
			else
				GClass39.smethod_30(mResources.can_buy_from_Uron1 + gClass31.long_0 + mResources.can_buy_from_Uron2 + gClass31.string_0 + mResources.can_buy_from_Uron3);
		}
		if (idAction == 10000)
		{
			GClass43 gClass32 = (GClass43)p;
			GClass166.smethod_0().method_129(1, gClass32.gclass58_0.int_13);
			GClass39.gclass45_0.method_150();
		}
		if (idAction == 10001)
		{
			GClass43 gClass33 = (GClass43)p;
			GClass166.smethod_0().method_129(2, gClass33.gclass58_0.int_13);
			GClass57.smethod_1();
		}
		if (idAction == 10021)
			;
		if (idAction == 10012)
		{
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = ((GClass39.gclass45_1 != null) ? GClass39.gclass45_1 : GClass39.gclass45_0);
			}
			gclass7_0.gclass67_0.method_28(GClass67.int_12);
			gclass7_0.gclass67_0.method_23(string.Empty);
			if (gclass121_0.int_30 == 1)
			{
				gclass7_0.string_1 = mResources.kiguiXuchat;
				gclass7_0.gclass67_0.string_7 = mResources.input_money;
			}
			else
			{
				gclass7_0.string_1 = mResources.input_quantity + " ";
				gclass7_0.gclass67_0.string_7 = mResources.input_quantity;
			}
			gclass7_0.gclass67_0.method_26(10);
			gclass7_0.string_0 = string.Empty;
			gclass7_0.bool_0 = true;
			gclass7_0.gclass67_0.method_28(GClass67.int_12);
			if (GClass39.bool_5)
				gclass7_0.gclass67_0.method_0();
			if (Main.isWindowsPhone)
				gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
			if (!Main.isPC)
				gclass7_0.method_5(this, string.Empty);
		}
		if (idAction == 10013)
		{
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = ((GClass39.gclass45_1 != null) ? GClass39.gclass45_1 : GClass39.gclass45_0);
			}
			gclass7_0.gclass67_0.method_28(GClass67.int_12);
			gclass7_0.gclass67_0.method_23(string.Empty);
			if (gclass121_0.int_30 == 1)
			{
				gclass7_0.string_1 = mResources.kiguiLuongchat;
				gclass7_0.gclass67_0.string_7 = mResources.input_money;
			}
			else
			{
				gclass7_0.string_1 = mResources.input_quantity + "  ";
				gclass7_0.gclass67_0.string_7 = mResources.input_quantity;
			}
			gclass7_0.string_0 = string.Empty;
			gclass7_0.bool_0 = true;
			gclass7_0.gclass67_0.method_28(GClass67.int_12);
			if (GClass39.bool_5)
				gclass7_0.gclass67_0.method_0();
			if (Main.isWindowsPhone)
				gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
			if (!Main.isPC)
				gclass7_0.method_5(this, string.Empty);
		}
		if (idAction == 10014)
		{
			GClass121 gClass34 = (GClass121)p;
			GClass166.smethod_0().method_130(1, gClass34.int_27, -1, -1, -1);
			GClass57.smethod_1();
		}
		if (idAction == 10015)
		{
			GClass121 gClass35 = (GClass121)p;
			GClass166.smethod_0().method_130(2, gClass35.int_27, -1, -1, -1);
			GClass57.smethod_1();
		}
		if (idAction == 10016)
		{
			GClass121 gClass36 = (GClass121)p;
			GClass166.smethod_0().method_130(3, gClass36.int_27, 0, gClass36.int_34, -1);
			GClass57.smethod_1();
		}
		if (idAction == 10017)
		{
			GClass121 gClass37 = (GClass121)p;
			GClass166.smethod_0().method_130(3, gClass37.int_27, 1, gClass37.int_36, -1);
			GClass57.smethod_1();
		}
		if (idAction == 10018)
		{
			GClass121 gClass38 = (GClass121)p;
			GClass166.smethod_0().method_130(5, gClass38.int_27, -1, -1, -1);
			GClass57.smethod_1();
		}
		if (idAction == 10019)
		{
			GClass162.smethod_0().close();
			GClass120.smethod_4("acc", string.Empty);
			GClass120.smethod_4("pass", string.Empty);
			GClass39.gclass149_0.gclass67_1.method_23(string.Empty);
			GClass39.gclass149_0.gclass67_0.method_23(string.Empty);
			GClass39.gclass149_0.bool_12 = false;
			GClass39.gclass149_0.switchToMe();
			GClass39.smethod_29();
			method_151();
		}
		if (idAction == 10020)
			GClass39.smethod_29();
		if (idAction == 10030)
		{
			GClass166.smethod_0().method_131(1, (sbyte)int_66);
			GClass39.gclass45_0.method_150();
		}
		if (idAction == 10031)
			GClass162.smethod_0().close();
		if (idAction == 11000)
		{
			GClass166.smethod_0().method_130(0, gclass121_0.int_27, 1, gclass121_0.int_40, 1);
			GClass39.smethod_29();
		}
		if (idAction == 11001)
		{
			GClass166.smethod_0().method_130(0, gclass121_0.int_27, 1, gclass121_0.int_40, gclass121_0.int_31);
			GClass39.smethod_29();
		}
		if (idAction == 11002)
		{
			gclass7_0.bool_0 = false;
			GClass39.smethod_29();
		}
	}

	public void onChatFromMe(string text, string to)
	{
		if (gclass7_0.gclass67_0.method_21() == null || gclass7_0.gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
		{
			gclass7_0.bool_0 = false;
			return;
		}
		if (gclass7_0.string_1.Equals(mResources.input_clan_name))
		{
			GClass57.smethod_1();
			gclass7_0.bool_0 = false;
			GClass166.smethod_0().method_23(text);
			return;
		}
		if (gclass7_0.string_1.Equals(mResources.chat_clan))
		{
			GClass57.smethod_1();
			gclass7_0.bool_0 = false;
			GClass166.smethod_0().method_19(0, text, -1);
			return;
		}
		if (gclass7_0.string_1.Equals(mResources.input_clan_name_to_create))
		{
			if (gclass7_0.gclass67_0.method_21() == string.Empty)
			{
				GClass154.gclass210_0.method_7(mResources.clan_name_blank, 0);
				return;
			}
			if (gclass141_0 == null)
				gclass141_0 = new GClass141();
			gclass141_0.string_0 = gclass7_0.gclass67_0.method_21();
			gclass141_0.method_1(false);
			gclass7_0.bool_0 = false;
			return;
		}
		if (gclass7_0.string_1.Equals(mResources.input_clan_slogan))
		{
			if (gclass7_0.gclass67_0.method_21() == string.Empty)
			{
				GClass154.gclass210_0.method_7(mResources.clan_slogan_blank, 0);
				return;
			}
			GClass166.smethod_0().method_28(4, (sbyte)GClass58.smethod_1().gclass21_0.int_1, gclass7_0.gclass67_0.method_21());
			gclass7_0.bool_0 = false;
			return;
		}
		if (gclass7_0.string_1.Equals(mResources.input_Inventory_Pass))
			try
			{
				int pass = int.Parse(gclass7_0.gclass67_0.method_21());
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
				method_151();
				if (gclass7_0.gclass67_0.method_21().Length != 6 || gclass7_0.gclass67_0.method_21().Equals(string.Empty))
					GClass39.smethod_30(mResources.input_Inventory_Pass_wrong);
				else
				{
					GClass166.smethod_0().method_132(pass);
					gclass7_0.bool_0 = false;
					gclass7_0.gclass67_0.method_28(GClass67.int_11);
					method_151();
				}
				return;
			}
			catch (Exception)
			{
				GClass39.smethod_30(mResources.ALERT_PRIVATE_PASS_2);
				return;
			}
		if (gclass7_0.string_1.Equals(mResources.world_channel_5_luong))
		{
			if (!gclass7_0.gclass67_0.method_21().Equals(string.Empty))
			{
				GClass166.smethod_0().method_98(gclass7_0.gclass67_0.method_21());
				gclass7_0.bool_0 = false;
				method_151();
			}
		}
		else if (gclass7_0.string_1.Equals(mResources.chat_player))
		{
			gclass7_0.bool_0 = false;
			GClass43 gClass = null;
			if (int_28 == 8)
				gClass = (GClass43)gclass63_3.method_3(int_147);
			else if (int_28 == 11)
			{
				gClass = (GClass43)gclass63_5.method_3(int_147);
			}
			if (gClass.gclass58_0.int_13 != GClass58.smethod_1().int_13)
				GClass166.smethod_0().method_97(text, gClass.gclass58_0.int_13);
		}
		else if (gclass7_0.string_1.Equals(mResources.input_quantity_to_trade))
		{
			int num = 0;
			try
			{
				num = int.Parse(gclass7_0.gclass67_0.method_21());
			}
			catch (Exception)
			{
				GClass39.smethod_30(mResources.input_quantity_wrong);
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
				return;
			}
			if (num <= 0 || num > gclass121_0.int_30)
			{
				GClass39.smethod_30(mResources.input_quantity_wrong);
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
				return;
			}
			gclass121_0.bool_0 = true;
			GClass121 gClass2 = new GClass121();
			gClass2.gclass118_0 = gclass121_0.gclass118_0;
			gClass2.int_30 = num;
			gClass2.int_29 = gclass121_0.int_29;
			gClass2.gclass20_0 = gclass121_0.gclass20_0;
			GClass39.gclass45_0.gclass63_6.method_0(gClass2);
			GClass166.smethod_0().method_6(2, -1, (sbyte)gClass2.int_29, gClass2.int_30);
			gclass7_0.bool_0 = false;
			gclass7_0.gclass67_0.method_28(GClass67.int_11);
		}
		else if (gclass7_0.string_1 == mResources.input_money_to_trade)
		{
			int num2 = 0;
			try
			{
				num2 = int.Parse(gclass7_0.gclass67_0.method_21());
			}
			catch (Exception)
			{
				GClass39.smethod_30(mResources.input_money_wrong);
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
				return;
			}
			if (num2 > GClass58.smethod_1().long_6)
			{
				GClass39.smethod_30(mResources.not_enough_money);
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
			}
			else
			{
				int_22 = num2;
				GClass166.smethod_0().method_6(2, -1, -1, num2);
				gclass7_0.bool_0 = false;
				gclass7_0.gclass67_0.method_28(GClass67.int_11);
			}
		}
		else if (gclass7_0.string_1.Equals(mResources.kiguiXuchat))
		{
			GClass166.smethod_0().method_130(0, gclass121_0.int_27, 0, int.Parse(gclass7_0.gclass67_0.method_21()), 1);
			gclass7_0.bool_0 = false;
		}
		else if (gclass7_0.string_1.Equals(mResources.kiguiXuchat + " "))
		{
			GClass166.smethod_0().method_130(0, gclass121_0.int_27, 0, int.Parse(gclass7_0.gclass67_0.method_21()), gclass121_0.int_31);
			gclass7_0.bool_0 = false;
		}
		else if (gclass7_0.string_1.Equals(mResources.kiguiLuongchat))
		{
			method_213(0);
			gclass7_0.bool_0 = false;
		}
		else if (gclass7_0.string_1.Equals(mResources.kiguiLuongchat + "  "))
		{
			method_213(1);
			gclass7_0.bool_0 = false;
		}
		else if (gclass7_0.string_1.Equals(mResources.input_quantity + " "))
		{
			gclass121_0.int_31 = int.Parse(gclass7_0.gclass67_0.method_21());
			if (gclass121_0.int_31 > gclass121_0.int_30)
			{
				GClass39.smethod_30(mResources.input_quantity_wrong);
				return;
			}
			bool_24 = true;
			gclass7_0.bool_0 = false;
		}
		else if (gclass7_0.string_1.Equals(mResources.input_quantity + "  "))
		{
			gclass121_0.int_31 = int.Parse(gclass7_0.gclass67_0.method_21());
			if (gclass121_0.int_31 > gclass121_0.int_30)
			{
				GClass39.smethod_30(mResources.input_quantity_wrong);
				return;
			}
			bool_25 = true;
			gclass7_0.bool_0 = false;
		}
	}

	public void onCancelChat()
	{
		gclass7_0.gclass67_0.method_28(GClass67.int_11);
	}

	public void method_195(int type)
	{
		int_161 = type;
		unxsbEvTty = 90;
		if (int_161 == 0)
		{
			int_154 = 5;
			int_152 = 90;
			int_151 = 90;
			int_160 = 2;
			for (int i = 0; i < gclass63_0.method_2(); i++)
			{
				GClass121 gClass = (GClass121)gclass63_0.method_3(i);
				if (gClass != null)
				{
					if (gClass.gclass118_0.sbyte_0 == 14)
						short_2 = gClass.gclass118_0.short_1;
					else
						short_1 = gClass.gclass118_0.short_1;
				}
			}
		}
		else if (int_161 == 1)
		{
			int_154 = 2;
			int_152 = 0;
			int_151 = 0;
			int_160 = 1;
			for (int j = 0; j < gclass63_0.method_2(); j++)
			{
				GClass121 gClass2 = (GClass121)gclass63_0.method_3(j);
				if (gClass2 != null)
				{
					if (j == 0)
						short_1 = gClass2.gclass118_0.short_1;
					else
						short_2 = gClass2.gclass118_0.short_1;
				}
			}
		}
		else if (int_161 == 2)
		{
			int_154 = 7;
			int_152 = 25;
			int_151 = 25;
			int_160 = 1;
			for (int k = 0; k < gclass63_0.method_2(); k++)
			{
				GClass121 gClass3 = (GClass121)gclass63_0.method_3(k);
				if (gClass3 != null)
					short_1 = gClass3.gclass118_0.short_1;
			}
		}
		else if (int_161 == 3)
		{
			int_149 = GClass39.int_12;
			int_150 = GClass39.int_13;
			int_154 = 1;
			int_152 = 1;
			int_151 = 1;
			int_160 = 4;
			for (int l = 0; l < gclass63_0.method_2(); l++)
			{
				GClass121 gClass4 = (GClass121)gclass63_0.method_3(l);
				if (gClass4 != null)
					short_1 = gClass4.gclass118_0.short_1;
			}
		}
		else if (int_161 == 4)
		{
			int_154 = gclass63_0.method_2();
			short_4 = new short[int_154];
			int_152 = 25;
			int_151 = 25;
			int_160 = 1;
			for (int m = 0; m < gclass63_0.method_2(); m++)
			{
				GClass121 gClass5 = (GClass121)gclass63_0.method_3(m);
				if (gClass5 != null)
					short_4[m] = gClass5.gclass118_0.short_1;
			}
		}
		int_155 = 1;
		bool_26 = true;
		bool_29 = false;
		bool_27 = false;
		int_153 = 360 / int_154;
		int_156 = new int[int_154];
		int_157 = new int[int_154];
		int_158 = new int[int_154];
		int_159 = new int[int_154];
		method_198();
		bool_28 = true;
		int_162 = 10;
		int_163 = 30;
		int_164 = 10;
		method_200(int_148, mResources.combineSpell);
	}

	private void method_196()
	{
		int_162--;
		if (int_162 < 0)
			int_162 = 0;
		int_163--;
		if (int_163 < 0)
			int_163 = 0;
		if (int_162 != 0)
			return;
		if (!bool_27)
		{
			if (int_160 > 0)
			{
				if (sbyte_7 != -1)
				{
					if (int_161 == 3)
					{
						if (GClass39.int_8 % 10 == 0)
						{
							GClass81.smethod_0(new GClass33(21, int_149 - 10, int_150 + 25, 4, 1, 1));
							int_160--;
						}
					}
					else
					{
						if (GClass39.int_8 % 2 == 0)
						{
							if (bool_26)
							{
								if (int_155 < 40)
									int_155 += 2;
							}
							else if (int_155 > 10)
							{
								int_155 -= 2;
							}
						}
						if (int_163 == 0)
						{
							if (bool_26)
							{
								if (unxsbEvTty > 0)
									unxsbEvTty -= 5;
								else if (GClass39.int_8 % 10 == 0)
								{
									bool_26 = false;
									int_160--;
									int_163 = 5;
									int_164 = 10;
								}
							}
							else if (unxsbEvTty < 90)
							{
								unxsbEvTty += 5;
							}
							else if (GClass39.int_8 % 10 == 0)
							{
								bool_26 = true;
								int_163 = 10;
							}
						}
						int_151 = int_152;
						int_151 -= int_155;
						if (int_151 >= 360)
							int_151 -= 360;
						if (int_151 < 0)
							int_151 = 360 + int_151;
						int_152 = int_151;
						method_198();
					}
				}
			}
			else if (GClass39.int_8 % 20 == 0)
			{
				bool_27 = true;
			}
			if (GClass39.int_8 % 20 == 0)
			{
				if (int_161 != 3)
					GClass72.smethod_0(132, int_149, int_150, 2);
				GClass72.smethod_0(114, int_149, int_150 + 20, 2);
			}
		}
		else
		{
			if (!bool_27)
				return;
			if (sbyte_7 == 1)
			{
				if (int_164 == 10)
					GClass81.smethod_0(new GClass33(22, int_149 - 3, int_150 + 25, 4, 1, 1));
				int_164--;
				if (int_164 < 0)
					int_164 = 0;
				if (unxsbEvTty < 300)
				{
					unxsbEvTty = GClass56.smethod_28(unxsbEvTty + 10);
					if (unxsbEvTty == 20)
						method_200(int_148, mResources.combineFail);
				}
				else if (GClass39.int_8 % 20 == 0)
				{
					if (GClass39.int_10 > 2 * int_55)
					{
						GClass39.gclass45_1 = new GClass45();
						GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
						GClass39.gclass45_1.method_15();
						GClass39.gclass45_1.method_50();
					}
					sbyte_7 = -1;
					bool_29 = true;
					if (int_161 == 4)
						GClass39.gclass45_0.method_150();
				}
				method_198();
			}
			else
			{
				if (sbyte_7 != 0)
					return;
				if (int_164 == 10)
				{
					if (int_161 == 2)
						GClass81.smethod_0(new GClass33(20, int_149 - 3, int_150 + 15, 4, 2, 1));
					else
						GClass81.smethod_0(new GClass33(21, int_149 - 10, int_150 + 25, 4, 1, 1));
					method_200(int_148, mResources.combineSuccess);
					bool_28 = false;
				}
				if (bool_28)
					return;
				int_164--;
				if (int_164 < -50)
				{
					int_164 = -50;
					if (int_161 < 3 && GClass39.int_10 > 2 * int_55)
					{
						GClass39.gclass45_1 = new GClass45();
						GClass39.gclass45_1.string_17[7] = new string[1][] { new string[1] { string.Empty } };
						GClass39.gclass45_1.method_15();
						GClass39.gclass45_1.method_50();
					}
					sbyte_7 = -1;
					bool_29 = true;
					if (int_161 == 4)
						GClass39.gclass45_0.method_150();
				}
			}
		}
	}

	public void method_197(GClass76 g)
	{
		GClass154.smethod_8().method_80(g);
		method_199(g);
		if (GClass39.int_8 % 4 == 0)
			g.method_31(GClass134.gclass2_0, int_149, int_150 + 15, GClass76.int_5 | GClass76.int_0);
		if (int_161 == 0)
		{
			for (int i = 0; i < int_157.Length; i++)
			{
				GClass96.smethod_6(g, short_1, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
				if (bool_28)
					GClass96.smethod_6(g, short_2, int_158[i], int_159[i], 0, GClass76.int_1 | GClass76.int_0);
			}
		}
		else if (int_161 == 1)
		{
			if (!bool_28)
			{
				GClass96.smethod_6(g, short_3, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
				return;
			}
			for (int j = 0; j < int_157.Length; j++)
			{
				GClass96.smethod_6(g, short_1, int_158[0], int_159[0], 0, GClass76.int_1 | GClass76.int_0);
				GClass96.smethod_6(g, short_2, int_158[1], int_159[1], 0, GClass76.int_1 | GClass76.int_0);
			}
		}
		else if (int_161 == 2)
		{
			if (!bool_28)
			{
				GClass96.smethod_6(g, short_3, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
				return;
			}
			for (int k = 0; k < int_157.Length; k++)
			{
				GClass96.smethod_6(g, short_1, int_158[k], int_159[k], 0, GClass76.int_1 | GClass76.int_0);
			}
		}
		else if (int_161 == 3)
		{
			if (!bool_28)
				GClass96.smethod_6(g, short_3, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
			else
				GClass96.smethod_6(g, short_1, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
		}
		else
		{
			if (int_161 != 4)
				return;
			if (!bool_28)
			{
				if (short_3 != -1)
					GClass96.smethod_6(g, short_3, int_149, int_150, 0, GClass76.int_1 | GClass76.int_0);
			}
			else
			{
				for (int l = 0; l < short_4.Length; l++)
				{
					GClass96.smethod_6(g, short_4[l], int_158[l], int_159[l], 0, GClass76.int_1 | GClass76.int_0);
				}
			}
		}
	}

	private void method_198()
	{
		for (int i = 0; i < int_157.Length; i++)
		{
			if (int_151 >= 360)
				int_151 -= 360;
			if (int_151 < 0)
				int_151 = 360 + int_151;
			int_157[i] = GClass56.smethod_28(unxsbEvTty * GClass56.smethod_1(int_151) / 1024);
			int_156[i] = GClass56.smethod_28(unxsbEvTty * GClass56.smethod_2(int_151) / 1024);
			if (int_151 < 90)
			{
				int_158[i] = int_149 + int_156[i];
				int_159[i] = int_150 - int_157[i];
			}
			else if (int_151 >= 90 && int_151 < 180)
			{
				int_158[i] = int_149 - int_156[i];
				int_159[i] = int_150 - int_157[i];
			}
			else if (int_151 >= 180 && int_151 < 270)
			{
				int_158[i] = int_149 - int_156[i];
				int_159[i] = int_150 + int_157[i];
			}
			else
			{
				int_158[i] = int_149 + int_156[i];
				int_159[i] = int_150 + int_157[i];
			}
			int_151 -= int_153;
		}
	}

	public void method_199(GClass76 g)
	{
		g.method_1(-GClass154.int_22, -GClass154.int_23);
		if (int_161 < 3)
		{
			for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
			{
				GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
				if (gClass.gclass90_0.int_0 == int_148)
				{
					gClass.paint(g);
					if (gClass.gclass205_0 != null)
						gClass.gclass205_0.method_1(g, gClass.int_4, gClass.int_5 - gClass.int_58 - GClass39.int_58, gClass.int_12);
				}
			}
		}
		GClass39.smethod_6(g);
		if (GClass39.int_8 % 4 == 0)
		{
			g.method_31(GClass134.gclass2_0, int_149 - 5, int_150 + 15, GClass76.int_5 | GClass76.int_0);
			g.method_31(GClass134.gclass2_0, int_149 + 5, int_150 + 15, GClass76.int_5 | GClass76.int_0);
			g.method_31(GClass134.gclass2_0, int_149, int_150 + 15, GClass76.int_5 | GClass76.int_0);
		}
		for (int j = 0; j < GClass68.gclass63_0.method_2(); j++)
		{
			((GClass68)GClass68.gclass63_0.method_3(j)).paint(g);
		}
	}

	public void method_200(int idNPC, string text)
	{
		if (int_161 >= 3)
			return;
		for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
		{
			GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
			if (gClass.gclass90_0.int_0 == idNPC)
				gClass.method_10(text);
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
		GClass29.smethod_1().method_2();
		int_41 = string_7.Length;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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

	private void method_203(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_7.Length; i++)
		{
			int x = int_57;
			int num = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
			{
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(x, num, w, h);
				GClass49.gclass49_6.method_6(gclass76_0, string_7[i], int_57 + 25, num + 6, GClass49.int_0);
			}
		}
		method_100(gclass76_0);
	}

	private void method_204()
	{
		if (int_66 < 0)
			return;
		switch (int_66)
		{
		case 0:
			GClass29.smethod_1().method_15();
			break;
		case 1:
			GClass29.smethod_1().method_16();
			break;
		case 2:
			GClass29.smethod_1().method_10();
			break;
		case 3:
			if (Main.isPC)
				GClass39.smethod_36(mResources.changeSizeScreen, new GClass14(mResources.YES, this, 170391, null), new GClass14(mResources.NO, this, 4005, null));
			else
				GClass29.smethod_1().method_14();
			break;
		case 4:
			if (Main.isPC)
				GClass39.smethod_36(mResources.changeSizeScreen, new GClass14(mResources.YES, this, 170391, null), new GClass14(mResources.NO, this, 4005, null));
			else
				GClass29.smethod_1().method_13();
			break;
		case 5:
			GClass29.smethod_1().method_13();
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
		if (Main.IphoneVersionApp)
		{
			string_8 = new string[4]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg
			};
			if (GClass154.bool_68)
				string_8 = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.autoFunction
				};
		}
		else
		{
			string_8 = new string[5]
			{
				mResources.inventory_Pass,
				mResources.friend,
				mResources.enemy,
				mResources.msg,
				mResources.charger
			};
			if (GClass154.bool_68)
				string_8 = new string[6]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger,
					mResources.autoFunction
				};
			if ((GClass138.int_0 == 2 || GClass138.int_0 == 7) && mResources.language != 2)
			{
				string_8 = new string[5]
				{
					mResources.inventory_Pass,
					mResources.friend,
					mResources.enemy,
					mResources.msg,
					mResources.charger
				};
				if (GClass154.bool_68)
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
		int_41 = string_8.Length;
		int_4 = 24;
		int_66 = (GClass39.bool_5 ? (-1) : 0);
		int_11 = int_41 * int_4 - int_60;
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

	private void method_207(GClass76 gclass76_0)
	{
		gclass76_0.method_5(int_57, int_58, int_59, int_60);
		gclass76_0.method_1(0, -int_8);
		for (int i = 0; i < string_8.Length; i++)
		{
			int x = int_57;
			int num = int_58 + i * int_4;
			int w = int_59 - 1;
			int h = int_4 - 1;
			if (num - int_8 <= int_58 + int_60 && num - int_8 >= int_58 - int_4)
			{
				gclass76_0.method_16((i != int_66) ? 15196114 : 16383818);
				gclass76_0.method_15(x, num, w, h);
				GClass49.gclass49_6.method_6(gclass76_0, string_8[i], int_57 + int_59 / 2, num + 6, GClass49.int_2);
			}
		}
		method_100(gclass76_0);
	}

	private void method_208()
	{
		if (int_66 < 0)
			return;
		switch (int_66)
		{
		case 0:
			GClass39.smethod_29();
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = GClass39.gclass45_0;
			}
			gclass7_0.gclass67_0.method_23(string.Empty);
			gclass7_0.string_1 = mResources.input_Inventory_Pass;
			gclass7_0.gclass67_0.string_7 = mResources.input_Inventory_Pass;
			gclass7_0.string_0 = string.Empty;
			gclass7_0.bool_0 = true;
			gclass7_0.gclass67_0.bool_0 = true;
			gclass7_0.gclass67_0.method_28(GClass67.int_12);
			if (GClass39.bool_5)
				gclass7_0.gclass67_0.method_0();
			if (!Main.isPC)
				gclass7_0.method_5(this, string.Empty);
			if (Main.isWindowsPhone)
				gclass7_0.gclass67_0.string_9 = gclass7_0.string_1;
			break;
		case 1:
			GClass166.smethod_0().method_13(0, -1);
			GClass57.smethod_1();
			break;
		case 2:
			GClass166.smethod_0().method_129(0, -1);
			GClass57.smethod_1();
			break;
		case 3:
			method_31();
			if (gclass7_0 == null)
			{
				gclass7_0 = new GClass7();
				gclass7_0.gclass67_0.int_1 = GClass39.int_11 - 35 - GClass7.smethod_0().gclass67_0.int_3;
				gclass7_0.method_0();
				gclass7_0.ginterface5_0 = GClass39.gclass45_0;
			}
			break;
		case 4:
			if (mResources.language == 2)
			{
				string url = "http://dragonball.indonaga.com/coda/?username=" + GClass39.gclass149_0.gclass67_0.method_21();
				method_150();
				try
				{
					GClass113.gclass113_0.method_3(url);
					break;
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
					break;
				}
			}
			method_150();
			if (GClass58.smethod_1().gclass36_0.short_1 <= 10)
				GClass39.smethod_30(mResources.finishBomong);
			else
				GClass147.smethod_2().switchToMe();
			break;
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
		int_41 = GClass58.smethod_1().string_4[int_29].Length;
		int_11 = int_41 * int_4 - int_60;
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
		int_66 = (GClass39.bool_5 ? (-1) : 0);
	}

	public bool method_212()
	{
		if (int_28 == 1)
			return true;
		return false;
	}

	private void method_213(int int_177)
	{
		try
		{
			gclass121_0.int_40 = int.Parse(gclass7_0.gclass67_0.method_21());
		}
		catch (Exception)
		{
			GClass39.smethod_30(mResources.input_money_wrong);
			gclass7_0.bool_0 = false;
			return;
		}
		GClass39.smethod_36(cmdYes: new GClass14(mResources.YES, this, (int_177 != 0) ? 11001 : 11000, null), cmdNo: new GClass14(mResources.NO, this, 11002, null), info: mResources.notiRuby);
	}

	public static void smethod_1(int x, int y, int wItem, int hItem, int nline, int cl, GClass76 g)
	{
		try
		{
			int num = ((wItem << 1) + (hItem << 1)) / nline;
			int_166 = int_165.Length;
			if (nline > 4)
				int_166 = 2;
			for (int i = 0; i < nline; i++)
			{
				for (int j = 0; j < int_166; j++)
				{
					int int_ = ((int_165[j] <= 1) ? 1 : ((int_165[j] >> 1) + 1));
					int x2 = x + smethod_2(num * i, GClass39.int_8 - j * 4, wItem, hItem, int_);
					int y2 = y + smethod_3(num * i, GClass39.int_8 - j * 4, wItem, hItem, int_);
					g.method_16(int_167[cl][j]);
					g.method_15(x2, y2, int_165[j], int_165[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static int smethod_2(int int_177, int int_178, int int_179, int int_180, int int_181)
	{
		int num = (int_178 + int_177) % ((int_179 << 1) + (int_180 << 1));
		if (0 <= num && num < int_179)
			return num % int_179;
		if (int_179 <= num && num < int_179 + int_180)
			return int_179 - int_181;
		if (int_179 + int_180 <= num && num < (int_179 << 1) + int_180)
			return int_179 - (num - int_180) % int_179 - int_181;
		return 0;
	}

	private static int smethod_3(int int_177, int int_178, int int_179, int int_180, int int_181)
	{
		int num = (int_178 + int_177) % ((int_179 << 1) + (int_180 << 1));
		if (0 <= num && num < int_179)
			return 0;
		if (int_179 <= num && num < int_179 + int_180)
			return num % int_179;
		if (int_179 + int_180 <= num && num < (int_179 << 1) + int_180)
			return int_180 - int_181;
		return int_180 - (num - (int_179 << 1)) % int_180 - int_181;
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
		if (lv < 0)
			return 0;
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

	public static GClass49 smethod_6(int color)
	{
		GClass49 result = GClass49.gclass49_11;
		switch (color)
		{
		case -1:
			result = GClass49.gclass49_11;
			break;
		case 0:
			result = GClass49.gclass49_6;
			break;
		case 1:
			result = GClass49.gclass49_8;
			break;
		case 2:
			result = GClass49.gclass49_2;
			break;
		case 3:
			result = GClass49.gclass49_17;
			break;
		case 4:
			result = GClass49.gclass49_19;
			break;
		case 5:
			result = GClass49.gclass49_18;
			break;
		case 7:
			result = GClass49.gclass49_1;
			break;
		case 8:
			result = GClass49.gclass49_4;
			break;
		}
		return result;
	}

	public void method_214(GClass76 g, int idOpt, int param, int x, int y, int w, int h)
	{
		switch (idOpt)
		{
		case 34:
			if (gclass2_13 != null)
				g.method_33(gclass2_13, x, y + h - gclass2_13.method_1());
			else
				gclass2_13 = GClass138.smethod_35("/mainImage/o_0.png");
			if (gclass2_14 != null)
				g.method_33(gclass2_14, x, y + h - gclass2_14.method_1());
			else
				gclass2_14 = GClass138.smethod_35("/mainImage/o_1.png");
			break;
		case 35:
			if (gclass2_13 != null)
				g.method_33(gclass2_13, x, y + h - gclass2_13.method_1());
			else
				gclass2_13 = GClass138.smethod_35("/mainImage/o_0.png");
			if (gclass2_15 != null)
				g.method_33(gclass2_15, x, y + h - gclass2_15.method_1());
			else
				gclass2_15 = GClass138.smethod_35("/mainImage/o_2.png");
			break;
		case 36:
			if (gclass2_13 != null)
				g.method_33(gclass2_13, x, y + h - gclass2_13.method_1());
			else
				gclass2_13 = GClass138.smethod_35("/mainImage/o_0.png");
			if (gclass2_16 != null)
				g.method_33(gclass2_16, x, y + h - gclass2_16.method_1());
			else
				gclass2_16 = GClass138.smethod_35("/mainImage/o_3.png");
			break;
		}
	}

	public void method_215(GClass76 g, int idOpt, int param, int x, int y, int w, int h)
	{
		if (idOpt == 102 && param > GClass70.int_15)
			smethod_1(cl: smethod_5(param), x: x, y: y, wItem: w, hItem: h, nline: param - GClass70.int_15, g: g);
	}

	public static GClass49 smethod_7(int id, int type)
	{
		GClass49 result;
		if (type == 0)
		{
			switch (id)
			{
			case 0:
				result = GClass49.gclass49_28;
				break;
			case 1:
				result = GClass49.gclass49_30;
				break;
			default:
				result = GClass49.gclass49_28;
				break;
			case 3:
				result = GClass49.gclass49_31;
				break;
			case 4:
				result = GClass49.gclass49_32;
				break;
			case 5:
				result = GClass49.gclass49_29;
				break;
			case 6:
				result = GClass49.gclass49_27;
				break;
			}
			return result;
		}
		switch (id)
		{
		case 0:
			result = GClass49.gclass49_3;
			break;
		case 1:
			result = GClass49.gclass49_8;
			break;
		default:
			result = GClass49.gclass49_3;
			break;
		case 3:
			result = GClass49.gclass49_38;
			break;
		case 4:
			result = GClass49.gclass49_2;
			break;
		case 5:
			result = GClass49.gclass49_4;
			break;
		case 6:
			result = GClass49.gclass49_1;
			break;
		case 7:
			result = GClass49.gclass49_6;
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
		if (int_66 < 0)
			return;
		if (GClass39.bool_11[(!Main.isPC) ? 4 : 23])
		{
			int_68--;
			if (bool_30)
				int_41 = 5;
			if (int_68 < 0)
			{
				int_68 = 0;
				if (GClass39.bool_22)
				{
					GClass39.bool_22 = false;
					GClass39.gclass45_0.int_66 = 0;
				}
			}
		}
		else
		{
			if (!GClass39.bool_11[(!Main.isPC) ? 6 : 24])
				return;
			int_68++;
			if (bool_30)
				int_41 = 5;
			if (int_68 > sbyte_17 - 1)
			{
				int_68 = sbyte_17 - 1;
				if (GClass39.gclass45_1 != null)
				{
					GClass39.bool_22 = true;
					GClass39.gclass45_1.int_66 = 0;
				}
			}
		}
	}

	private void method_218()
	{
		method_72();
		if (int_66 == 0)
			method_217();
	}

	private bool method_219()
	{
		if (sbyte_17 > 0)
		{
			if (string_2.Length > 1)
			{
				if (int_66 == 0)
					return true;
			}
			else if (int_66 >= 0)
			{
				return true;
			}
		}
		return false;
	}
}
