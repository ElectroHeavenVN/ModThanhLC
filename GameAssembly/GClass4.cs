using System;
using System.Collections;
using UnityEngine;

public class GClass4
{
	public static int int_0 = 0;

	public static int int_1 = 1;

	public static int int_2 = 2;

	public static int int_3 = 0;

	public static int int_4 = 1;

	public static int int_5 = 2;

	public static int int_6 = 3;

	public static int int_7 = 4;

	public static int int_8 = 5;

	public static int int_9 = 6;

	public static int int_10 = 7;

	public static int int_11 = 8;

	public static int int_12 = 9;

	public static int int_13 = 10;

	private int int_14;

	private GClass70 gclass70_0;

	private string string_0;

	private int[][] int_15;

	public static int int_16;

	public static int[] int_17 = new int[31]
	{
		0, 16711680, 6520319, 16777215, 16776960, 5449989, 21285, 52224, 7386228, 16771788,
		0, 65535, 21285, 16776960, 5592405, 16742263, 33023, 8701737, 15723503, 7999781,
		16768815, 14961237, 4124899, 4671303, 16096312, 16711680, 16755200, 52224, 16777215, 6520319,
		16096312
	};

	public static GClass4 gclass4_0;

	public static GClass4 gclass4_1;

	public static GClass4 gclass4_2;

	public static GClass4 gclass4_3;

	public static GClass4 gclass4_4;

	public static GClass4 gclass4_5;

	public static GClass4 gclass4_6;

	public static GClass4 gclass4_7;

	public static GClass4 gclass4_8;

	public static GClass4 gclass4_9;

	public static GClass4 gclass4_10;

	public static GClass4 gclass4_11;

	public static GClass4 gclass4_12;

	public static GClass4 gclass4_13;

	public static GClass4 gclass4_14;

	public static GClass4 gclass4_15;

	public static GClass4 gclass4_16;

	public static GClass4 gclass4_17;

	public static GClass4 gclass4_18;

	public static GClass4 gclass4_19;

	public static GClass4 gclass4_20;

	public static GClass4 gclass4_21;

	public static GClass4 gclass4_22;

	public static GClass4 gclass4_23;

	public static GClass4 gclass4_24;

	public static GClass4 gclass4_25;

	public static GClass4 gclass4_26;

	public static GClass4 gclass4_27;

	public static GClass4 gclass4_28;

	public static GClass4 gclass4_29;

	public static GClass4 gclass4_30;

	public static GClass4 gclass4_31;

	public static GClass4 gclass4_32;

	public static GClass4 gclass4_33;

	public static GClass4 gclass4_34;

	public static GClass4 gclass4_35;

	public static GClass4 gclass4_36;

	public static GClass4 gclass4_37;

	public static GClass4 gclass4_38;

	public static GClass4 gclass4_39;

	public static GClass4 gclass4_40;

	public static GClass4 gclass4_41;

	public Font font_0;

	private int int_18;

	private int int_19;

	public Color color_0 = Color.white;

	public Color color_1 = Color.gray;

	public sbyte sbyte_0;

	public int int_20;

	public string string_1 = "áàảãạăắằẳẵặâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ";

	public string string_2 = "\u00b8µ¶·¹\u00a8¾»¼½Æ©ÊÇÈÉËÐÌÎÏÑªÕÒÓÔÖÝ×ØÜÞãßáâä«èåæçé¬íêëìîóïñòô\u00adøõö÷ùýúûüþ®\u00b8µ¶·¹¡¾»¼½Æ¢ÊÇÈÉËÐÌÎÏÑ£ÕÒÓÔÖÝ×ØÜÞãßáâä¤èåæçé¥íêëìîóïñòô¦øõö÷ùýúûüþ§";

	public const string string_3 = " 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW";

	private int int_21;

	private string string_4;

	public GClass4(string strFont, string pathImage, string pathData, int space)
	{
		try
		{
			string_0 = strFont;
			int_14 = space;
			string_4 = pathImage;
			GClass108 gClass = null;
			method_22();
			try
			{
				gClass = GClass200.smethod_0(pathData);
				int_15 = new int[gClass.method_0()][];
				for (int i = 0; i < int_15.Length; i++)
				{
					int_15[i] = new int[4];
					int_15[i][0] = gClass.method_0();
					int_15[i][1] = gClass.method_0();
					int_15[i][2] = gClass.method_0();
					int_15[i][3] = gClass.method_0();
					method_0(int_15[i][3]);
				}
				gClass.method_4();
			}
			catch (Exception)
			{
				try
				{
					gClass.method_4();
				}
				catch (Exception ex)
				{
					ex.StackTrace.ToString();
				}
			}
		}
		catch (Exception ex3)
		{
			ex3.StackTrace.ToString();
		}
	}

	public GClass4(sbyte id)
	{
		string text = "chelthm";
		if ((id <= 0 || id >= 10) && id != 19)
		{
			if (id < 10 || id > 18)
			{
				if (id > 24)
					text = "staccato";
			}
			else
			{
				text = "chelthm";
				int_21 = 2;
			}
		}
		else
		{
			int_21 = 1;
			text = "barmeneb";
		}
		sbyte_0 = id;
		font_0 = (Font)Resources.Load("FontSys/x" + GClass122.int_12 + "/" + text);
		if (id < 25)
		{
			color_0 = method_5(id);
			color_1 = method_5(id);
		}
		else
		{
			color_0 = method_2(id);
			color_1 = method_2(id);
		}
		int_19 = method_18("o");
	}

	public static void smethod_0()
	{
		if (GClass122.int_12 == 1)
		{
			gclass4_1 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_red.png", "/myfont/tahoma_7b", 0);
			gclass4_2 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_blue.png", "/myfont/tahoma_7b", 0);
			gclass4_3 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_white.png", "/myfont/tahoma_7b", 0);
			gclass4_4 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_yellow.png", "/myfont/tahoma_7b", 0);
			gclass4_5 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_yellow.png", "/myfont/tahoma_7b", 0);
			gclass4_6 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_brown.png", "/myfont/tahoma_7b", 0);
			gclass4_7 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_green2.png", "/myfont/tahoma_7b", 0);
			gclass4_8 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_green.png", "/myfont/tahoma_7b", 0);
			gclass4_9 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_focus.png", "/myfont/tahoma_7b", 0);
			gclass4_10 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7b_unfocus.png", "/myfont/tahoma_7b", 0);
			gclass4_11 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7.png", "/myfont/tahoma_7", 0);
			gclass4_12 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_blue1.png", "/myfont/tahoma_7", 0);
			gclass4_14 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_green2.png", "/myfont/tahoma_7", 0);
			gclass4_15 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_yellow.png", "/myfont/tahoma_7", 0);
			gclass4_16 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_grey.png", "/myfont/tahoma_7", 0);
			gclass4_17 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_red.png", "/myfont/tahoma_7", 0);
			gclass4_18 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_blue.png", "/myfont/tahoma_7", 0);
			gclass4_19 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_green.png", "/myfont/tahoma_7", 0);
			gclass4_20 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_7_white.png", "/myfont/tahoma_7", 0);
			gclass4_21 = new GClass4(" 0123456789+-*='_?.,<>/[]{}!@#$%^&*():aáàảãạâấầẩẫậăắằẳẵặbcdđeéèẻẽẹêếềểễệfghiíìỉĩịjklmnoóòỏõọôốồổỗộơớờởỡợpqrstuúùủũụưứừửữựvxyýỳỷỹỵzwAÁÀẢÃẠĂẰẮẲẴẶÂẤẦẨẪẬBCDĐEÉÈẺẼẸÊẾỀỂỄỆFGHIÍÌỈĨỊJKLMNOÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢPQRSTUÚÙỦŨỤƯỨỪỬỮỰVXYÝỲỶỸỴZW", "/myfont/tahoma_8b.png", "/myfont/tahoma_8b", -1);
			gclass4_22 = new GClass4(" 0123456789+-", "/myfont/number_yellow.png", "/myfont/number", 0);
			gclass4_23 = new GClass4(" 0123456789+-", "/myfont/number_red.png", "/myfont/number", 0);
			gclass4_24 = new GClass4(" 0123456789+-", "/myfont/number_green.png", "/myfont/number", 0);
			gclass4_25 = new GClass4(" 0123456789+-", "/myfont/number_gray.png", "/myfont/number", 0);
			gclass4_26 = new GClass4(" 0123456789+-", "/myfont/number_orange.png", "/myfont/number", 0);
			gclass4_27 = gclass4_23;
			gclass4_28 = gclass4_3;
			gclass4_29 = gclass4_22;
			gclass4_30 = gclass4_24;
			gclass4_31 = gclass4_26;
			gclass4_32 = gclass4_12;
			gclass4_34 = gclass4_17;
			gclass4_35 = gclass4_15;
			gclass4_36 = gclass4_19;
			gclass4_37 = gclass4_16;
			gclass4_38 = gclass4_15;
			gclass4_39 = gclass4_7;
			gclass4_40 = gclass4_20;
			gclass4_41 = gclass4_8;
			gclass4_13 = gclass4_12;
			return;
		}
		gclass4_0 = new GClass4(0);
		gclass4_1 = new GClass4(1);
		gclass4_2 = new GClass4(2);
		gclass4_3 = new GClass4(3);
		gclass4_4 = new GClass4(4);
		gclass4_5 = new GClass4(4);
		gclass4_6 = new GClass4(5);
		gclass4_7 = new GClass4(6);
		gclass4_8 = new GClass4(7);
		gclass4_9 = new GClass4(8);
		gclass4_10 = new GClass4(9);
		gclass4_11 = new GClass4(10);
		gclass4_12 = new GClass4(11);
		gclass4_13 = gclass4_12;
		gclass4_14 = new GClass4(12);
		gclass4_15 = new GClass4(13);
		gclass4_16 = new GClass4(14);
		gclass4_17 = new GClass4(15);
		gclass4_18 = new GClass4(16);
		gclass4_19 = new GClass4(17);
		gclass4_20 = new GClass4(18);
		gclass4_21 = new GClass4(19);
		gclass4_22 = new GClass4(20);
		gclass4_23 = new GClass4(21);
		gclass4_24 = new GClass4(22);
		gclass4_25 = new GClass4(23);
		gclass4_26 = new GClass4(24);
		gclass4_27 = new GClass4(25);
		gclass4_29 = new GClass4(26);
		gclass4_30 = new GClass4(27);
		gclass4_28 = new GClass4(28);
		gclass4_32 = new GClass4(29);
		gclass4_31 = new GClass4(30);
		gclass4_33 = new GClass4(31);
		gclass4_34 = gclass4_1;
		gclass4_35 = gclass4_15;
		gclass4_36 = gclass4_19;
		gclass4_37 = gclass4_16;
		gclass4_38 = gclass4_15;
		gclass4_39 = gclass4_7;
		gclass4_40 = gclass4_20;
		gclass4_41 = gclass4_8;
		int_16 = 1;
		if (GClass122.int_12 == 1)
			int_16 = -3;
	}

	public void method_0(int height)
	{
		int_18 = height;
	}

	public Color method_1(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float b = (float)num / 256f;
		float g = (float)num2 / 256f;
		return new Color((float)num3 / 256f, g, b);
	}

	public Color method_2(int id)
	{
		return (new Color[7]
		{
			Color.red,
			Color.yellow,
			Color.green,
			Color.white,
			method_1(40404),
			Color.red,
			Color.black
		})[id - 25];
	}

	public void method_3(int ID)
	{
		color_0 = method_1(int_17[ID]);
		color_1 = method_1(int_17[ID]);
	}

	public void method_4(GClass122 g, string st, int x, int y, int align, sbyte idFont)
	{
		sbyte iD = sbyte_0;
		if (idFont > 0)
			iD = idFont;
		x--;
		if (sbyte_0 > 24)
		{
			Color[] array = new Color[6]
			{
				method_1(6029312),
				method_1(7169025),
				method_1(7680),
				method_1(0),
				method_1(9264),
				method_1(6029312)
			};
			color_0 = array[sbyte_0 - 25];
			color_1 = array[sbyte_0 - 25];
			method_21(g, st, x + 1, y, align);
			method_21(g, st, x - 1, y, align);
			method_21(g, st, x, y - 1, align);
			method_21(g, st, x, y + 1, align);
			method_21(g, st, x + 1, y + 1, align);
			method_21(g, st, x + 1, y - 1, align);
			method_21(g, st, x - 1, y - 1, align);
			method_21(g, st, x - 1, y + 1, align);
			color_0 = method_2(sbyte_0);
			color_1 = method_2(sbyte_0);
		}
		else
			method_3(iD);
		method_21(g, st, x, y - int_21, align);
	}

	public Color method_5(sbyte id)
	{
		return method_1(int_17[id]);
	}

	public void method_6(GClass122 g, string st, int x, int y, int align)
	{
		if (GClass122.int_12 != 1)
		{
			method_4(g, st, x, y, align, 0);
			return;
		}
		int length = st.Length;
		int num = ((align == 0) ? x : ((align == 1) ? (x - method_17(st)) : (x - (method_17(st) >> 1))));
		for (int i = 0; i < length; i++)
		{
			int num2 = string_0.IndexOf(st[i] + "");
			if (num2 == -1)
				num2 = 0;
			if (num2 > -1)
			{
				int x2 = int_15[num2][0];
				int num3 = int_15[num2][1];
				int w = int_15[num2][2];
				int num4 = int_15[num2][3];
				if (num3 + num4 > gclass70_0.texture2D_0.height)
				{
					num3 -= gclass70_0.texture2D_0.height;
					x2 = gclass70_0.texture2D_0.width / 2;
				}
				g.method_23(gclass70_0, x2, num3, w, num4, 0, num, y, 20);
			}
			num += int_15[num2][2] + int_14;
		}
	}

	public void method_7(GClass122 g, string st, int x, int y, int align)
	{
		if (GClass122.int_12 == 1)
			method_6(g, st, x, y, align);
		else
			method_4(g, st, x, y, align, 0);
	}

	public void method_8(GClass122 g, string st, int x, int y, int align, GClass4 font2)
	{
		if (GClass122.int_12 != 1)
			method_9(g, st, x, y, align, font2);
		else
			method_10(g, st, x, y, align, font2);
	}

	public void method_9(GClass122 g, string st, int x, int y, int align, GClass4 font)
	{
		method_4(g, st, x - 1, y - 1, align, font.sbyte_0);
		method_4(g, st, x - 1, y + 1, align, font.sbyte_0);
		method_4(g, st, x + 1, y - 1, align, font.sbyte_0);
		method_4(g, st, x + 1, y + 1, align, font.sbyte_0);
		method_4(g, st, x, y - 1, align, font.sbyte_0);
		method_4(g, st, x, y + 1, align, font.sbyte_0);
		method_4(g, st, x + 1, y, align, font.sbyte_0);
		method_4(g, st, x - 1, y, align, font.sbyte_0);
		method_4(g, st, x, y, align, 0);
	}

	public void method_10(GClass122 g, string st, int x, int y, int align, GClass4 font)
	{
		if (GClass122.int_12 != 1)
		{
			method_4(g, st, x + 1, y, align, font.sbyte_0);
			method_4(g, st, x + 1, y + 1, align, font.sbyte_0);
			method_4(g, st, x, y + 1, align, font.sbyte_0);
			method_4(g, st, x, y, align, 0);
			return;
		}
		int length = st.Length;
		int num = ((align == 0) ? x : ((align == 1) ? (x - method_17(st)) : (x - (method_17(st) >> 1))));
		for (int i = 0; i < length; i++)
		{
			int num2 = string_0.IndexOf(st[i]);
			if (num2 == -1)
				num2 = 0;
			if (num2 > -1)
			{
				int x2 = int_15[num2][0];
				int num3 = int_15[num2][1];
				int w = int_15[num2][2];
				int num4 = int_15[num2][3];
				if (num3 + num4 > gclass70_0.texture2D_0.height)
				{
					num3 -= gclass70_0.texture2D_0.height;
					x2 = gclass70_0.texture2D_0.width / 2;
				}
				if (!GClass73.bool_1 && font != null)
				{
					g.method_23(font.gclass70_0, x2, num3, w, num4, 0, num + 1, y, 20);
					g.method_23(font.gclass70_0, x2, num3, w, num4, 0, num + 1, y + 1, 20);
					g.method_23(font.gclass70_0, x2, num3, w, num4, 0, num, y + 1, 20);
				}
				g.method_23(gclass70_0, x2, num3, w, num4, 0, num, y, 20);
			}
			num += int_15[num2][2] + int_14;
		}
	}

	public GClass88 method_11(string src, int lineWidth)
	{
		GClass88 gClass = new GClass88();
		string text = "";
		for (int i = 0; i < src.Length; i++)
		{
			if (src[i] != '\n' && src[i] != '\b')
			{
				text += src[i];
				if (method_17(text) > lineWidth)
				{
					int num = 0;
					num = text.Length - 1;
					while (num >= 0 && text[num] != ' ')
					{
						num--;
					}
					if (num < 0)
						num = text.Length - 1;
					gClass.method_0(text.Substring(0, num));
					i = i - (text.Length - num) + 1;
					text = "";
				}
				if (i == src.Length - 1 && !text.Trim().Equals(""))
					gClass.method_0(text);
			}
			else
			{
				gClass.method_0(text);
				text = "";
			}
		}
		return gClass;
	}

	public string method_12(string str)
	{
		string text = "";
		bool flag = false;
		for (int i = 0; i < str.Length; i++)
		{
			if (!flag)
			{
				string text2 = str.Substring(i);
				text = (method_16(text2, " ") ? (text + str[i] + "-") : (text + text2));
				flag = true;
			}
			else if (str[i] == ' ')
			{
				flag = false;
			}
		}
		return text;
	}

	public string[] method_13(string src, int lineWidth)
	{
		ArrayList arrayList = method_14(src, lineWidth);
		string[] array = new string[arrayList.Count];
		for (int i = 0; i < arrayList.Count; i++)
		{
			array[i] = (string)arrayList[i];
		}
		return array;
	}

	public ArrayList method_14(string src, int lineWidth)
	{
		ArrayList arrayList = new ArrayList();
		int i = 0;
		int num = 0;
		int length = src.Length;
		if (length >= 5)
		{
			string text = "";
			try
			{
				while (true)
				{
					if (method_19(text) < lineWidth)
					{
						text += src[num];
						num++;
						if (src[num] != '\n')
						{
							if (num < length - 1)
								continue;
							num = length - 1;
						}
					}
					if (num != length - 1 && src[num + 1] != ' ')
					{
						int num2 = num;
						while (src[num + 1] != '\n' && (src[num + 1] != ' ' || src[num] == ' ') && num != i)
						{
							num--;
						}
						if (num == i)
							num = num2;
					}
					string text2 = src.Substring(i, num + 1 - i);
					if (text2[0] == '\n')
						text2 = text2.Substring(1, text2.Length - 1);
					if (text2[text2.Length - 1] == '\n')
						text2 = text2.Substring(0, text2.Length - 1);
					arrayList.Add(text2);
					if (num == length - 1)
						break;
					for (i = num + 1; i != length - 1 && src[i] == ' '; i++)
					{
					}
					if (i != length - 1)
					{
						num = i;
						text = "";
						continue;
					}
					return arrayList;
				}
				return arrayList;
			}
			catch (Exception ex)
			{
				GClass36.smethod_5("EXCEPTION WHEN REAL SPLIT " + src + "\nend=" + num + "\n" + ex.Message + "\n" + ex.StackTrace);
				arrayList.Add(src);
				return arrayList;
			}
		}
		arrayList.Add(src);
		return arrayList;
	}

	public string[] method_15(string src, int lineWidth)
	{
		GClass88 gClass = method_11(src, lineWidth);
		string[] array = new string[gClass.method_2()];
		for (int i = 0; i < gClass.method_2(); i++)
		{
			array[i] = (string)gClass.method_3(i);
		}
		return array;
	}

	public bool method_16(string strSource, string str)
	{
		for (int i = 0; i < strSource.Length; i++)
		{
			if (("" + strSource[i]).Equals(str))
				return true;
		}
		return false;
	}

	public int method_17(string s)
	{
		if (GClass122.int_12 != 1)
			return method_18(s);
		int num = 0;
		for (int i = 0; i < s.Length; i++)
		{
			int num2 = string_0.IndexOf(s[i]);
			if (num2 == -1)
				num2 = 0;
			num += int_15[num2][2] + int_14;
		}
		return num;
	}

	public int method_18(string s)
	{
		try
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle.font = font_0;
			return (int)gUIStyle.CalcSize(new GUIContent(s)).x / GClass122.int_12;
		}
		catch (Exception ex)
		{
			GClass36.smethod_2("GET WIDTH OF " + s + " FAIL.\n" + ex.Message + "\n" + ex.StackTrace);
			return method_19(s);
		}
	}

	public int method_19(string s)
	{
		return s.Length * int_19 / GClass122.int_12;
	}

	public int method_20()
	{
		if (GClass122.int_12 == 1)
			return int_18;
		if (int_18 <= 0)
		{
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle.font = font_0;
			try
			{
				int_18 = (int)gUIStyle.CalcSize(new GUIContent("Adg")).y + 2;
			}
			catch (Exception ex)
			{
				GClass36.smethod_2("FAIL GET HEIGHT " + ex.StackTrace);
				int_18 = 20;
			}
			return int_18 / GClass122.int_12;
		}
		return int_18 / GClass122.int_12;
	}

	public void method_21(GClass122 g, string st, int x0, int y0, int align)
	{
		y0 += int_16;
		GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
		gUIStyle.font = font_0;
		float num = 0f;
		float num2 = 0f;
		switch (align)
		{
		case 0:
			num = x0;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperLeft;
			break;
		case 1:
			num = x0 - GClass73.int_10;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperRight;
			break;
		case 2:
		case 3:
			num = x0 - GClass73.int_10 / 2;
			num2 = y0;
			gUIStyle.alignment = TextAnchor.UpperCenter;
			break;
		}
		gUIStyle.normal.textColor = color_0;
		g.method_19(st, (int)num, (int)num2, gUIStyle);
	}

	public static string[] smethod_1(string _text, string _searchStr)
	{
		int num = 0;
		int num2 = 0;
		int length = _searchStr.Length;
		int num3 = _text.IndexOf(_searchStr, 0);
		while (num3 != -1)
		{
			num3 = _text.IndexOf(_searchStr, num3 + length);
			num++;
		}
		string[] array = new string[num + 1];
		int num4 = _text.IndexOf(_searchStr);
		int num5 = 0;
		int num6 = 0;
		while (num4 != -1)
		{
			array[num6] = _text.Substring(num5, num4 - num5);
			num5 = num4 + length;
			num4 = _text.IndexOf(_searchStr, num5);
			num6++;
		}
		array[num6] = _text.Substring(num5, _text.Length - num5);
		return array;
	}

	public void method_22()
	{
		if (GClass122.int_12 == 1)
			gclass70_0 = GClass73.smethod_43(string_4);
	}

	public void method_23()
	{
	}
}
