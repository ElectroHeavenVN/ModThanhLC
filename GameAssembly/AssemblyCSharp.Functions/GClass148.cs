namespace AssemblyCSharp.Functions
{
	public class GClass148
	{
		public bool bool_0;

		public bool bool_1 = false;

		public bool bool_2 = true;

		public bool bool_3 = true;

		public bool bool_4 = true;

		public int int_0 = -1;

		private static GClass148 gclass148_0;

		public static GClass148 smethod_0()
		{
			return (gclass148_0 != null) ? gclass148_0 : (gclass148_0 = new GClass148());
		}

		public bool method_0(string text)
		{
			switch (text)
			{
			case "/csdb":
				bool_4 = !bool_4;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Use special capsule: " + GClass154.smethod_0().method_6(bool_4)) : ("Sử dụng capsule đặc biệt: " + GClass154.smethod_0().method_6(bool_4)), 0);
				break;
			default:
				if (!GClass154.smethod_0().method_11<int>(text, "/xmp"))
				{
					if (!GClass154.smethod_0().method_10<int>(text, "/nrd", 2))
						return false;
					int[] array = GClass154.smethod_0().method_8<int>(text, "/nrd", 2);
					Class21.smethod_0().int_3 = array[1];
					Class21.smethod_0().method_8(array[0] + 84);
				}
				else if (bool_0)
				{
					Class21.smethod_0().method_9();
					GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
				}
				else
				{
					int int_ = GClass154.smethod_0().method_12<int>(text, "/xmp");
					Class21.smethod_0().method_8(int_);
				}
				break;
			case "/nrd":
				if (bool_0)
				{
					Class21.smethod_0().int_3 = -1;
					Class21.smethod_0().method_9();
				}
				break;
			case "/csb":
				bool_3 = !bool_3;
				GClass149.smethod_1((GClass151.int_0 != 0) ? ("Use normal capsule: " + GClass154.smethod_0().method_6(bool_3)) : ("Sử dụng capsule thường: " + GClass154.smethod_0().method_6(bool_3)), 0);
				break;
			case "/xmp":
				if (bool_0)
				{
					Class21.smethod_0().method_9();
					GClass149.smethod_1((GClass151.int_0 == 0) ? "Đã hủy tự động nextmap" : "Cancel auto nextmap", 0);
				}
				else
					Class21.smethod_0().method_3();
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
					if (!GClass159.smethod_0().bool_4)
					{
						if (bool_0)
						{
							Class21.smethod_0().method_9();
							GClass149.smethod_1((GClass151.int_0 != 0) ? "Cancel auto nextmap" : "Đã hủy tự động nextmap", 0);
						}
						else
							Class21.smethod_0().method_3();
					}
					else
					{
						GClass166.smethod_0().bool_0 = false;
						GClass159.smethod_0().bool_4 = false;
						GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto teleporting: " + GClass154.smethod_0().method_6(GClass159.smethod_0().bool_4)) : ("Tự động teleport: " + GClass154.smethod_0().method_6(GClass159.smethod_0().bool_4)), 0);
					}
					break;
				case 106:
					GClass157.smethod_0().method_18(0);
					break;
				case 107:
					if (GClass20.int_37 == 135 || GClass20.int_37 == 138 || GClass20.int_37 == 136)
					{
						if (GClass20.int_37 != 135)
						{
							if (GClass20.int_37 == 138)
								Class21.smethod_0().method_24(360, 336);
							else if (GClass20.int_37 == 136)
							{
								Class21.smethod_0().method_24(720, 576);
							}
						}
						else
							Class21.smethod_0().method_24(600, 600);
					}
					else
						GClass157.smethod_0().method_18(2);
					break;
				case 108:
					GClass157.smethod_0().method_18(1);
					break;
				}
			}
			else
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
					if (gClass == null)
						continue;
					if (gClass.gclass117_0.short_0 != 193)
					{
						if (gClass.gclass117_0.short_0 == 194)
							GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
					}
					else
						GClass7.smethod_0().method_20(0, 1, -1, gClass.gclass117_0.short_0);
				}
			}
			return true;
		}

		public void method_2()
		{
			if (GClass174.smethod_0().bool_1)
				GClass174.smethod_0().method_3();
			if (bool_0)
				Class21.smethod_0().method_0();
		}

		public void method_3(string text)
		{
			if (bool_0)
			{
				if (text.ToLower().Contains("Không thể chuyển map quá nhanh"))
					Class21.smethod_0().method_1(1000);
				if (text.ToLower().Contains((mResources.language == 0) ? "vui lòng chờ" : "please wait"))
				{
					GClass73.gclass76_0.bool_0 = false;
					GClass73.gclass76_0.method_151();
					GClass73.smethod_1().method_10(99);
				}
				if (text.Equals((mResources.language == 0) ? "Bạn chưa thể đến khu vực này" : "You can not travel to this area") || text.ToLower().Contains((mResources.language == 0) ? "không thể vào khu vực này" : "can not enter this area"))
					Class21.smethod_0().method_9();
				if (text.ToLower().Contains((mResources.language != 0) ? "power must lower than" : "sức mạnh phải dưới"))
					Class21.smethod_0().method_9();
				if (text.ToLower().Contains((mResources.language == 0) ? "yêu cầu sức mạnh lớn hơn" : "require power more than"))
					Class21.smethod_0().method_9();
			}
		}

		public bool method_4(object obj)
		{
			GClass23 gClass = (GClass23)obj;
			if (gClass.bool_0)
			{
				GClass78.smethod_1().bool_2 = false;
				if (gClass.int_3 == 0)
				{
					GClass12.bool_5 = false;
					GClass78.bool_33 = true;
				}
				GClass23.gclass88_0.method_8(gClass);
				return true;
			}
			return false;
		}

		public void method_5(int selected)
		{
			if (!bool_1)
			{
				Class21.smethod_0().method_10();
				GClass7.smethod_0().method_126(selected);
			}
			else
			{
				Class21.smethod_0().method_23();
				int int_ = GClass174.smethod_3(GClass73.gclass76_0.string_4[selected]);
				Class21.smethod_0().method_8(int_);
			}
		}

		public void method_6()
		{
			bool_1 = false;
			if (!bool_2)
			{
				bool_2 = true;
				return;
			}
			GClass73.gclass76_0.method_6();
			GClass73.gclass76_0.method_50();
		}

		public void method_7()
		{
			GClass12.smethod_0().method_9(0);
			GClass7.smethod_0().method_117();
			GClass78.bool_35 = false;
		}
	}
}
