namespace ns1
{
	public class GClass171
	{
		public bool bool_0;

		public bool bool_1 = false;

		public bool bool_2 = true;

		public bool bool_3 = true;

		public bool bool_4 = true;

		public int int_0 = -1;

		private static GClass171 gclass171_0;

		public static GClass171 smethod_0()
		{
			return (gclass171_0 != null) ? gclass171_0 : (gclass171_0 = new GClass171());
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			default:
				if (GClass193.smethod_0().method_10<int>(text, "/xmp"))
				{
					if (bool_0)
					{
						Class14.smethod_0().method_8();
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
					}
					else
					{
						int int_ = GClass193.smethod_0().method_11<int>(text, "/xmp");
						Class14.smethod_0().method_7(int_);
					}
					break;
				}
				if (GClass193.smethod_0().method_9<int>(text, "/nrd", 2))
				{
					int[] array = GClass193.smethod_0().method_8<int>(text, "/nrd", 2);
					Class14.smethod_0().int_3 = array[1];
					Class14.smethod_0().method_7(array[0] + 84);
					break;
				}
				return false;
			case "/nrd":
				if (bool_0)
				{
					Class14.smethod_0().int_3 = -1;
					Class14.smethod_0().method_8();
				}
				break;
			case "/csdb":
				bool_4 = !bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Sử dụng capsule đặc biệt: " + GClass193.smethod_0().method_6(bool_4)) : ("Use special capsule: " + GClass193.smethod_0().method_6(bool_4)), 0);
				break;
			case "/csb":
				bool_3 = !bool_3;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Sử dụng capsule thường: " + GClass193.smethod_0().method_6(bool_3)) : ("Use normal capsule: " + GClass193.smethod_0().method_6(bool_3)), 0);
				break;
			case "/xmp":
				if (bool_0)
				{
					Class14.smethod_0().method_8();
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
				}
				else
					Class14.smethod_0().ivEoIuqQfu();
				break;
			}
			return true;
		}

		public bool method_1(int asciiCode)
		{
			if (asciiCode != 99)
			{
				switch (asciiCode)
				{
				default:
					if (asciiCode != 120)
						return false;
					if (GClass191.smethod_0().bool_3)
					{
						GClass197.smethod_0().bool_0 = false;
						GClass191.smethod_0().bool_3 = false;
						GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động teleport: " + GClass193.smethod_0().method_6(GClass191.smethod_0().bool_3)) : ("Auto teleporting: " + GClass193.smethod_0().method_6(GClass191.smethod_0().bool_3)), 0);
					}
					else if (bool_0)
					{
						Class14.smethod_0().method_8();
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
					}
					else
					{
						Class14.smethod_0().ivEoIuqQfu();
					}
					break;
				case 106:
					GClass175.smethod_0().method_17(0);
					break;
				case 107:
					if (GClass1.int_37 != 135 && GClass1.int_37 != 138 && GClass1.int_37 != 136)
						GClass175.smethod_0().method_17(2);
					else if (GClass1.int_37 == 135)
					{
						Class14.smethod_0().method_23(600, 600);
					}
					else if (GClass1.int_37 == 138)
					{
						Class14.smethod_0().method_23(360, 336);
					}
					else if (GClass1.int_37 == 136)
					{
						Class14.smethod_0().method_23(720, 576);
					}
					break;
				case 108:
					GClass175.smethod_0().method_17(1);
					break;
				}
			}
			else
			{
				for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
				{
					GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
					if (gClass != null)
					{
						if (gClass.gclass118_0.short_0 == 193)
							GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
						else if (gClass.gclass118_0.short_0 == 194)
						{
							GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
						}
					}
				}
			}
			return true;
		}

		public void method_2()
		{
			if (GClass178.smethod_0().bool_1)
				GClass178.smethod_0().method_3();
			if (bool_0)
				Class14.smethod_0().method_0();
		}

		public void method_3(string text)
		{
			if (bool_0)
			{
				if (text.ToLower().Contains("Không thể chuyển map quá nhanh"))
					Class14.smethod_0().method_1(1000);
				if (text.ToLower().Contains((mResources.language == 0) ? "vui lòng chờ" : "please wait"))
				{
					GClass39.gclass45_0.bool_0 = false;
					GClass39.gclass45_0.method_151();
					GClass39.smethod_1().method_10(99);
				}
				if (text.Equals((mResources.language == 0) ? "Bạn chưa thể đến khu vực này" : "You can not travel to this area") || text.ToLower().Contains((mResources.language == 0) ? "không thể vào khu vực này" : "can not enter this area"))
					Class14.smethod_0().method_8();
				if (text.ToLower().Contains((mResources.language == 0) ? "sức mạnh phải dưới" : "power must lower than"))
					Class14.smethod_0().method_8();
				if (text.ToLower().Contains((mResources.language == 0) ? "yêu cầu sức mạnh lớn hơn" : "require power more than"))
					Class14.smethod_0().method_8();
			}
		}

		public bool method_4(object obj)
		{
			GClass202 gClass = (GClass202)obj;
			if (gClass.bool_0)
			{
				GClass58.smethod_1().bool_2 = false;
				if (gClass.int_3 == 0)
				{
					GClass65.bool_5 = false;
					GClass58.bool_33 = true;
				}
				GClass202.gclass63_0.method_8(gClass);
				return true;
			}
			return false;
		}

		public void method_5(int selected)
		{
			if (bool_1)
			{
				Class14.smethod_0().method_22();
				int int_ = GClass178.smethod_3(GClass39.gclass45_0.string_4[selected]);
				Class14.smethod_0().method_7(int_);
			}
			else
			{
				Class14.smethod_0().method_9();
				GClass166.smethod_0().method_126(selected);
			}
		}

		public void method_6()
		{
			bool_1 = false;
			if (bool_2)
			{
				GClass39.gclass45_0.method_6();
				GClass39.gclass45_0.method_50();
			}
			else
				bool_2 = true;
		}

		public void method_7()
		{
			GClass65.smethod_0().method_9(0);
			GClass166.smethod_0().method_117();
			GClass58.bool_35 = false;
		}
	}
}
