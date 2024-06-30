using System;
using System.Threading;

namespace ns1
{
	public class GClass177
	{
		public DateTime dateTime_0;

		public DateTime dateTime_1;

		public TimeSpan timeSpan_0;

		public int int_0 = -5;

		public long long_0;

		public bool bool_0;

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public int int_1 = 0;

		public int int_2 = 0;

		public bool bool_4;

		public int int_3;

		public long long_1;

		public bool bool_5;

		public long long_2 = -1L;

		public bool bool_6;

		public bool bool_7;

		public long long_3;

		private static GClass177 gclass177_0;

		public TimeSpan timeSpan_1 = new TimeSpan(0, 0, 0, 2);

		public void method_0()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			timeSpan_0 = dateTime_1 - dateTime;
		}

		public static GClass177 smethod_0()
		{
			return (gclass177_0 != null) ? gclass177_0 : (gclass177_0 = new GClass177());
		}

		public bool method_1(int asciiCode)
		{
			if (asciiCode != 45)
			{
				if (asciiCode != 112)
					return false;
				if (!GClass58.smethod_1().bool_62 && GClass58.smethod_1().gclass176_0.bool_0 && method_5())
				{
					GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động phù x7 HP: " + GClass193.smethod_0().method_6(bool_1)) : ("Auto get x7 HP: " + GClass193.smethod_0().method_6(bool_1)), 0);
					new Thread(method_13).Start();
				}
			}
			else if (GClass192.bool_3)
			{
				smethod_0().bool_4 = !smethod_0().bool_4;
				GClass188.smethod_1((GClass192.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass193.smethod_0().method_6(smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass193.smethod_0().method_6(smethod_0().bool_4)), 0);
			}
			else
			{
				GClass188.smethod_1((GClass192.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
			}
			return true;
		}

		public bool method_2(string text)
		{
			if (GClass193.smethod_0().method_10<int>(text, "/cvs"))
			{
				if (GClass192.bool_3 && GClass58.smethod_1().gclass58_0 != null)
				{
					if (GClass193.smethod_0().method_11<int>(text, "/cvs") > 0)
					{
						bool_3 = true;
						int_1 = GClass58.smethod_1().gclass58_0.int_13;
						int_2 = GClass193.smethod_0().method_11<int>(text, "/cvs");
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động sử dụng sáo cho [{GClass58.smethod_1().gclass58_0.int_13}] khi dưới [{int_2}%] HP" : $"Auto use whistle for [{GClass58.smethod_1().gclass58_0.int_13}] when HP lower than [{int_2}%] HP", 0);
					}
					else
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
					}
				}
			}
			else if (GClass193.smethod_0().method_9<int>(text, "/cvs", 2))
			{
				if (GClass192.bool_3)
				{
					int[] array = GClass193.smethod_0().method_8<int>(text, "/cvs", 2);
					int num = array[0];
					int num2 = array[1];
					if (num2 > 0)
					{
						bool_3 = true;
						int_1 = num;
						int_2 = num2;
						GClass188.smethod_1((GClass192.int_0 == 0) ? $"Tự động sử dụng sáo cho [{num}] khi dưới [{int_2}%] HP" : $"Auto use whistle for [{num}] when HP lower than [{int_2}%] HP", 0);
					}
					else
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass188.smethod_1((GClass192.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
					}
				}
			}
			else
			{
				if (!(text == "/cvs"))
					return false;
				if (GClass192.bool_3)
				{
					bool_3 = false;
					int_1 = 0;
					int_2 = 0;
					GClass188.smethod_1((GClass192.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
				}
			}
			return true;
		}

		public void method_3()
		{
			if (method_5())
			{
				method_9();
				if (bool_7 && GClass138.smethod_18() - long_3 > 1000L)
				{
					method_17();
					long_3 = GClass138.smethod_18();
				}
				if (GClass58.smethod_1().int_5 < 30 && !bool_7)
					method_17();
				if (GClass195.smethod_0().bool_3 && GClass58.smethod_1().gclass176_0.bool_0)
					GClass195.smethod_0().bool_3 = false;
				if (!GClass195.smethod_0().bool_3 && !GClass58.smethod_1().gclass176_0.bool_0)
					GClass195.smethod_0().bool_3 = true;
				method_12();
			}
			method_0();
			if (GClass192.bool_3)
			{
				method_8();
				method_14();
				method_15();
				method_16();
			}
		}

		public void method_4(GClass76 g)
		{
			if (int_0 < -5)
				return;
			TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0);
			TimeSpan timeSpan2 = new TimeSpan(0, 0, 0, -5);
			if (timeSpan_0 > timeSpan)
			{
				GClass49.gclass49_1.method_6(g, ((GClass192.int_0 == 0) ? "Time nhặt: " : "Time pick up: ") + ((TimeSpan)timeSpan_0).ToString(), GClass39.int_10 / 2, 80, GClass49.int_2);
				return;
			}
			if (timeSpan_0 <= timeSpan && timeSpan_0 > timeSpan2)
				GClass49.gclass49_1.method_6(g, (GClass192.int_0 == 0) ? "Có thể nhặt!" : "Can pick up!", GClass39.int_10 / 2, 80, GClass49.int_2);
			if (timeSpan_0 <= timeSpan2)
				int_0 = -5;
		}

		public bool method_5()
		{
			return GClass1.int_37 >= 85 && GClass1.int_37 <= 91;
		}

		public short method_6()
		{
			if (method_5())
				return (short)(2400 - GClass1.int_37);
			return 0;
		}

		public void method_7(string s)
		{
			if (method_5())
			{
				if (s.ToLower().StartsWith((mResources.language == 0) ? "chưa thể nhặt lúc này, hãy đợi" : "can't pick now, wait for"))
				{
					smethod_0().int_0 = int.Parse(s.Split(' ')[(mResources.language == 0) ? 7 : 5]) - 1;
					smethod_0().dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
					smethod_0().dateTime_1 = smethod_0().dateTime_0.AddSeconds(int.Parse(s.Split(' ')[(mResources.language == 0) ? 7 : 5]));
					smethod_0().bool_0 = true;
				}
				if (GClass58.smethod_1().gclass176_0.bool_0 && bool_1 && (s.ToLower().StartsWith("being blessed") || s.ToLower().StartsWith("đang được")))
				{
					bool_1 = false;
					bool_2 = true;
				}
			}
			if (bool_6 && s.ToLower().Contains((mResources.language == 0) ? "vui lòng chờ" : "please wait"))
			{
				bool_5 = false;
				long_2 = -1L;
			}
		}

		public void method_8()
		{
			if (!bool_3 || int_1 <= 0 || int_2 <= 0 || GClass39.int_8 % 10 != 0)
				return;
			for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
			{
				if (!(GClass154.gclass63_5.method_3(i) is GClass58 gClass) || gClass.int_13 != int_1 || gClass.int_25 >= gClass.int_35 * int_2 / 100)
					continue;
				for (int j = 0; j < GClass154.gclass74_0.Length; j++)
				{
					GClass74 gClass2 = GClass154.gclass74_0[j];
					if (gClass2 != null && gClass2.gclass53_0.sbyte_0 == 21)
					{
						if (gClass2.bool_0)
							return;
						if (GClass58.smethod_1().gclass74_0 != gClass2)
						{
							GClass154.smethod_8().method_62(gClass2, true);
							return;
						}
						GClass154.smethod_8().method_64(gClass2);
					}
				}
			}
		}

		public void method_9()
		{
			for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
			{
				if (GClass154.gclass63_6.method_3(i) is GClass134 itemMap && (method_10(itemMap) || method_11(itemMap)))
					GClass154.gclass63_6.method_7(i);
			}
		}

		public bool method_10(GClass134 itemMap)
		{
			return itemMap.gclass118_0.short_0 == 76 || itemMap.gclass118_0.short_0 == 188 || itemMap.gclass118_0.short_0 == 189 || itemMap.gclass118_0.short_0 == 190;
		}

		public bool method_11(GClass134 itemMap)
		{
			return itemMap.gclass118_0.short_0 >= 342 && itemMap.gclass118_0.short_0 <= 345;
		}

		public void method_12()
		{
			if (!GClass197.smethod_0().bool_5 || !method_5() || GClass58.smethod_1().int_5 < 30 || GClass58.smethod_1().bool_62 || GClass58.smethod_1().int_11 != 1)
				return;
			for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
			{
				GClass134 gClass = (GClass134)GClass154.gclass63_6.method_3(i);
				if (gClass != null && gClass.gclass118_0.short_0 <= 378 && gClass.gclass118_0.short_0 >= 372)
				{
					if (gClass.int_4 < 30)
						break;
					if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_3, gClass.int_4) > 10 && GClass138.smethod_18() - long_0 > 100L)
					{
						GClass58.smethod_1().int_4 = gClass.int_3;
						GClass58.smethod_1().int_5 = gClass.int_4;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_3;
						GClass58.smethod_1().int_5 = gClass.int_4 + 2;
						GClass166.smethod_0().method_44();
						GClass58.smethod_1().int_4 = gClass.int_3;
						GClass58.smethod_1().int_5 = gClass.int_4;
						GClass166.smethod_0().method_44();
						long_0 = GClass138.smethod_18();
					}
					if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_3, gClass.int_4) < 30 && GClass138.smethod_18() - long_0 > 200L)
					{
						GClass58.smethod_1().gclass58_0 = null;
						GClass58.smethod_1().gclass85_0 = null;
						GClass58.smethod_1().gclass59_0 = null;
						GClass58.smethod_1().gclass134_0 = gClass;
						GClass154.smethod_8().method_44(gClass);
						GClass166.smethod_0().method_74(gClass.int_9);
						long_0 = GClass138.smethod_18();
					}
					if ((timeSpan_0 <= timeSpan_1 || !bool_0) && GClass39.int_8 % 10 == 0 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_3, gClass.int_4) < 30)
					{
						GClass58.smethod_1().gclass58_0 = null;
						GClass58.smethod_1().gclass85_0 = null;
						GClass58.smethod_1().gclass59_0 = null;
						GClass58.smethod_1().gclass134_0 = gClass;
						GClass154.smethod_8().method_44(gClass);
						GClass166.smethod_0().method_74(gClass.int_9);
					}
				}
			}
		}

		public void method_13()
		{
			for (int i = 0; i < GClass154.gclass63_10.method_2(); i++)
			{
				GClass59 gClass = (GClass59)GClass154.gclass63_10.method_3(i);
				if (gClass != null)
				{
					if (GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
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
						Thread.Sleep(200);
					}
					GClass166.smethod_0().method_60(gClass.gclass90_0.int_0);
					Thread.Sleep(150);
					GClass166.smethod_0().method_59((short)gClass.gclass90_0.int_0, 0);
					GClass198.smethod_0().method_0();
					Thread.Sleep(150);
					GClass166.smethod_0().method_59((short)gClass.gclass90_0.int_0, 2);
					GClass198.smethod_0().method_0();
				}
			}
		}

		public void method_14()
		{
			if (!bool_4 || GClass1.int_37 == 21 + GClass58.smethod_1().int_14)
				return;
			for (int i = 0; i < GClass58.smethod_1().gclass121_0.Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_0[i];
				if (gClass != null && gClass.gclass118_0.short_0 == 345 && GClass39.int_8 % 10 == 0)
				{
					GClass166.smethod_0().method_20(0, 1, -1, gClass.gclass118_0.short_0);
					GClass172.smethod_0().method_0(100);
					GClass166.smethod_0().method_20(3, 1, -1, gClass.gclass118_0.short_0);
					GClass57.smethod_5();
					GClass39.gclass99_0 = null;
				}
			}
		}

		public void method_15()
		{
			try
			{
				if (GClass58.smethod_1().bool_62 || (GClass58.smethod_1().gclass74_0 != null && GClass58.smethod_1().gclass74_0.bool_0 && GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 14))
					int_3 = -1;
				else
				{
					if (int_3 <= 0)
						return;
					if (GClass154.smethod_14(int_3) == null && GClass138.smethod_18() - long_1 >= 500L)
					{
						GClass191.smethod_0().method_23(int_3);
						long_1 = GClass138.smethod_18();
						return;
					}
					int num = 0;
					GClass74 gClass;
					while (true)
					{
						if (num >= GClass154.gclass74_0.Length)
							return;
						gClass = GClass154.gclass74_0[num];
						if (gClass.gclass53_0.sbyte_0 == 14 && gClass != null)
						{
							if (GClass58.smethod_1().gclass74_0 != gClass && GClass138.smethod_18() - long_1 >= 3000L)
								break;
							if (!gClass.bool_0 && !GClass58.smethod_1().bool_47 && GClass138.smethod_18() - long_1 >= 3000L)
							{
								GClass154.smethod_8().method_64(gClass);
								long_1 = GClass138.smethod_18();
							}
						}
						num++;
					}
					GClass154.smethod_8().method_62(gClass, true);
				}
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoTeleportBom.txt", ex.ToString());
			}
		}

		public void method_16()
		{
			try
			{
				if (GClass58.smethod_1().bool_62 || (GClass58.smethod_1().gclass74_0.bool_0 && GClass58.smethod_1().gclass74_0.gclass53_0.sbyte_0 == 14))
				{
					bool_6 = false;
					long_2 = -1L;
				}
				if (!bool_6)
					return;
				if (!bool_5 && GClass39.int_8 % 10 == 0)
				{
					if (!GClass39.gclass45_0.bool_0)
					{
						GClass39.smethod_1().method_10(99);
						return;
					}
					if (GClass1.string_1 != GClass39.gclass45_0.string_4[0] && GClass39.gclass45_0.bool_0)
					{
						GClass166.smethod_0().method_126(0);
						bool_5 = true;
						return;
					}
				}
				if (GClass58.bool_33 && long_2 < 0L && bool_5)
					long_2 = GClass138.smethod_18();
				if (long_2 <= 0L)
					return;
				int num = 0;
				GClass74 gClass;
				while (true)
				{
					if (num >= GClass154.gclass74_0.Length)
						return;
					gClass = GClass154.gclass74_0[num];
					if (gClass != null && gClass.gclass53_0.sbyte_0 == 14)
					{
						if (GClass58.smethod_1().gclass74_0 != gClass && GClass138.smethod_18() - long_2 > 3000L)
							break;
						if (!gClass.bool_0 && !GClass58.smethod_1().bool_47 && GClass138.smethod_18() - long_2 > 3000L)
						{
							GClass154.smethod_8().method_64(gClass);
							long_2 = -1L;
						}
					}
					num++;
				}
				GClass154.smethod_8().method_62(gClass, true);
				GClass39.smethod_27();
				GClass39.smethod_26();
				GClass39.smethod_49();
			}
			catch (Exception ex)
			{
				GClass188.smethod_0("Data/Errors/autoCapsuleBom.txt", ex.ToString());
			}
		}

		public void method_17()
		{
			if (GClass58.smethod_1().bool_62 || GClass58.smethod_1().gclass176_0.bool_11 || GClass58.smethod_1().gclass176_0.bool_1 || GClass58.smethod_1().gclass176_0.bool_6 || GClass58.smethod_1().gclass176_0.bool_7 || GClass58.smethod_1().gclass176_0.bool_10)
				return;
			for (int i = 0; i < GClass154.gclass63_6.method_2(); i++)
			{
				if (GClass154.gclass63_6.method_3(i) is GClass134 gClass && gClass.gclass118_0.short_0 >= 372 && gClass.gclass118_0.short_0 <= 378 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass.int_1, gClass.int_2) > 10)
					GClass191.smethod_0().method_26(gClass);
			}
			for (int j = 0; j < GClass154.gclass63_5.method_2(); j++)
			{
				if (GClass154.gclass63_5.method_3(j) is GClass58 gClass2 && gClass2.gclass176_0.bool_0 && gClass2.int_13 != GClass58.smethod_1().int_13 && GClass56.smethod_24(GClass58.smethod_1().int_4, GClass58.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 10)
					GClass191.smethod_0().method_26(gClass2);
			}
		}
	}
}
