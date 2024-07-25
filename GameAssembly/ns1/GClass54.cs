using System;
using System.Threading;

namespace ns1
{
	public class GClass54
	{
		protected DateTime dateTime_0;

		protected DateTime dateTime_1;

		protected TimeSpan timeSpan_0;

		protected int int_0 = -5;

		protected long long_0;

		public bool bool_0;

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public int int_1 = 0;

		public int int_2 = 0;

		public bool bool_4;

		public int int_3;

		protected long long_1;

		public bool bool_5;

		protected long long_2 = -1L;

		public bool bool_6;

		public bool bool_7;

		protected long long_3;

		private static GClass54 gclass54_0;

		public TimeSpan timeSpan_1 = new TimeSpan(0, 0, 0, 2);

		protected long long_4;

		public int int_4 = -1;

		public string string_0 = string.Empty;

		public bool bool_8;

		protected void method_0()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			timeSpan_0 = dateTime_1 - dateTime;
		}

		public static GClass54 smethod_0()
		{
			return (gclass54_0 != null) ? gclass54_0 : (gclass54_0 = new GClass54());
		}

		public bool method_1(int asciiCode)
		{
			if (asciiCode != 45)
			{
				if (asciiCode != 112)
					return false;
				if (!GClass124.smethod_1().bool_62 && GClass124.smethod_1().gclass60_0.bool_0 && method_5())
				{
					GClass51.smethod_1((GClass62.int_0 == 0) ? ("Tự động phù x7 HP: " + GClass45.smethod_0().method_6(bool_1)) : ("Auto get x7 HP: " + GClass45.smethod_0().method_6(bool_1)), 0);
					new Thread(method_12).Start();
				}
			}
			else if (GClass62.bool_3)
			{
				smethod_0().bool_4 = !smethod_0().bool_4;
				GClass51.smethod_1((GClass62.int_0 != 0) ? ("Auto use Sattelite HP: " + GClass45.smethod_0().method_6(smethod_0().bool_4)) : ("Tự động cắm vệ tinh HP: " + GClass45.smethod_0().method_6(smethod_0().bool_4)), 0);
			}
			else
			{
				GClass51.smethod_1((GClass62.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
			}
			return true;
		}

		public bool method_2(string text)
		{
			if (!GClass45.smethod_0().method_11<int>(text, "/cvs"))
			{
				if (!GClass45.smethod_0().method_10<int>(text, "/cvs", 2))
				{
					if (!(text == "/cvs"))
						return false;
					if (GClass62.bool_3)
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass51.smethod_1((GClass62.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
					}
				}
				else if (GClass62.bool_3)
				{
					int[] array = GClass45.smethod_0().method_8<int>(text, "/cvs", 2);
					int num = array[0];
					int num2 = array[1];
					if (num2 <= 0)
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass51.smethod_1((GClass62.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
					}
					else
					{
						bool_3 = true;
						int_1 = num;
						int_2 = num2;
						GClass51.smethod_1((GClass62.int_0 != 0) ? $"Auto use whistle for [{num}] when HP lower than [{int_2}%] HP" : $"Tự động sử dụng sáo cho [{num}] khi dưới [{int_2}%] HP", 0);
					}
				}
			}
			else if (GClass62.bool_3 && GClass124.smethod_1().gclass124_0 != null)
			{
				if (GClass45.smethod_0().method_12<int>(text, "/cvs") <= 0)
				{
					bool_3 = false;
					int_1 = 0;
					int_2 = 0;
					GClass51.smethod_1((GClass62.int_0 != 0) ? "Turn off auto use whistle" : "Tắt tự động sử dụng sáo", 0);
				}
				else
				{
					bool_3 = true;
					int_1 = GClass124.smethod_1().gclass124_0.int_13;
					int_2 = GClass45.smethod_0().method_12<int>(text, "/cvs");
					GClass51.smethod_1((GClass62.int_0 == 0) ? $"Tự động sử dụng sáo cho [{GClass124.smethod_1().gclass124_0.int_13}] khi dưới [{int_2}%] HP" : $"Auto use whistle for [{GClass124.smethod_1().gclass124_0.int_13}] when HP lower than [{int_2}%] HP", 0);
				}
			}
			return true;
		}

		public void method_3()
		{
			if (method_5())
			{
				method_9();
				if (bool_7 && GClass77.smethod_18() - long_3 > 1000L)
				{
					method_16();
					long_3 = GClass77.smethod_18();
				}
				if (GClass124.smethod_1().int_5 < 30 && !bool_7)
					method_16();
				if (GClass65.smethod_0().bool_3 && GClass124.smethod_1().gclass60_0.bool_0)
					GClass65.smethod_0().bool_3 = false;
				method_11();
			}
			method_0();
			if (GClass62.bool_3)
			{
				method_8();
				method_13();
				method_14();
				method_15();
			}
		}

		public void method_4(GClass193 g)
		{
			if (int_0 < -5)
				return;
			TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0);
			TimeSpan timeSpan2 = new TimeSpan(0, 0, 0, -5);
			if (!(timeSpan_0 > timeSpan))
			{
				if (timeSpan_0 <= timeSpan && timeSpan_0 > timeSpan2)
					GClass104.gclass104_1.method_6(g, (GClass62.int_0 == 0) ? "Có thể nhặt!" : "Can pick up!", GClass14.int_10 / 2, 53, GClass104.int_2);
				if (timeSpan_0 <= timeSpan2)
					int_0 = -5;
			}
			else
				GClass104.gclass104_1.method_6(g, ((GClass62.int_0 == 0) ? "Time nhặt: " : "Time pick up: ") + ((TimeSpan)timeSpan_0).ToString() + $" ({timeSpan_0.TotalSeconds}s)", GClass14.int_10 / 2, 53, GClass104.int_2);
		}

		public bool method_5()
		{
			return GClass137.int_37 >= 85 && GClass137.int_37 <= 91;
		}

		public short method_6()
		{
			if (!method_5())
				return 0;
			return (short)(2400 - GClass137.int_37);
		}

		public void method_7(string s)
		{
			if (method_5())
			{
				if (s.ToLower().StartsWith((mResources.language != 0) ? "can't pick now, wait for" : "chưa thể nhặt lúc này, hãy đợi"))
				{
					smethod_0().int_0 = int.Parse(s.Split(' ')[(mResources.language != 0) ? 5 : 7]) - 1;
					smethod_0().dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
					smethod_0().dateTime_1 = smethod_0().dateTime_0.AddSeconds(int.Parse(s.Split(' ')[(mResources.language == 0) ? 7 : 5]));
					smethod_0().bool_0 = true;
				}
				if (GClass124.smethod_1().gclass60_0.bool_0 && bool_1 && (s.ToLower().StartsWith("being blessed") || s.ToLower().StartsWith("đang được")))
				{
					bool_1 = false;
					bool_2 = true;
				}
			}
			if (bool_6 && s.ToLower().Contains((mResources.language != 0) ? "please wait" : "vui lòng chờ"))
			{
				bool_5 = false;
				GClass14.gclass113_0.bool_0 = false;
				GClass14.gclass113_0.method_151();
				long_2 = -1L;
			}
		}

		protected void method_8()
		{
			if (!bool_3 || int_1 <= 0 || int_2 <= 0 || GClass14.int_8 % 10 != 0)
				return;
			for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
			{
				if (!(GClass167.gclass122_5.method_3(i) is GClass124 gClass) || gClass.int_13 != int_1 || gClass.int_25 >= gClass.int_35 * int_2 / 100)
					continue;
				for (int j = 0; j < GClass167.gclass95_0.Length; j++)
				{
					GClass95 gClass2 = GClass167.gclass95_0[j];
					if (gClass2 != null && gClass2.gclass205_0.sbyte_0 == 21)
					{
						if (gClass2.bool_0)
							return;
						if (GClass124.smethod_1().gclass95_0 != gClass2)
						{
							GClass167.smethod_8().method_62(gClass2, true);
							return;
						}
						GClass167.smethod_8().method_64(gClass2);
					}
				}
			}
		}

		protected void method_9()
		{
			for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
			{
				if (GClass167.gclass122_6.method_3(i) is GClass190 itemMap && method_10(itemMap))
					GClass167.gclass122_6.method_7(i);
			}
		}

		protected bool method_10(GClass190 itemMap)
		{
			return itemMap.gclass203_0.short_0 == 76 || itemMap.gclass203_0.short_0 == 188 || itemMap.gclass203_0.short_0 == 189 || itemMap.gclass203_0.short_0 == 190;
		}

		protected void method_11()
		{
			if (!GClass48.smethod_0().bool_5 || GClass57.smethod_0().bool_0 || !method_5() || GClass124.smethod_1().int_5 < 30 || GClass124.smethod_1().bool_62 || GClass124.smethod_1().int_11 != 1)
				return;
			for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
			{
				GClass190 gClass = (GClass190)GClass167.gclass122_6.method_3(i);
				if (gClass == null || gClass.gclass203_0.short_0 > 378 || gClass.gclass203_0.short_0 < 372)
					continue;
				if (gClass.int_4 < 30)
					break;
				if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_3, gClass.int_4) > 10 && GClass77.smethod_18() - long_0 > 1000L)
				{
					GClass124.smethod_1().int_4 = gClass.int_3;
					GClass124.smethod_1().int_5 = gClass.int_4;
					GClass2.smethod_0().method_44();
					GClass124.smethod_1().int_4 = gClass.int_3;
					GClass124.smethod_1().int_5 = gClass.int_4 + 2;
					GClass2.smethod_0().method_44();
					GClass124.smethod_1().int_4 = gClass.int_3;
					GClass124.smethod_1().int_5 = gClass.int_4;
					GClass2.smethod_0().method_44();
					long_0 = GClass77.smethod_18();
				}
				if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_3, gClass.int_4) < 30 && GClass77.smethod_18() - long_0 > 300L && GClass62.bool_3)
				{
					GClass124.smethod_1().gclass124_0 = null;
					GClass124.smethod_1().gclass6_0 = null;
					GClass124.smethod_1().gclass125_0 = null;
					GClass124.smethod_1().gclass190_0 = gClass;
					GClass167.smethod_8().method_44(gClass);
					GClass2.smethod_0().method_74(gClass.int_9);
					long_0 = GClass77.smethod_18();
				}
				if ((timeSpan_0 <= timeSpan_1 || !bool_0) && GClass14.int_8 % 20 == 0 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_3, gClass.int_4) < 30)
				{
					GClass124.smethod_1().gclass124_0 = null;
					GClass124.smethod_1().gclass6_0 = null;
					GClass124.smethod_1().gclass125_0 = null;
					GClass124.smethod_1().gclass190_0 = gClass;
					if (GClass62.bool_3)
						GClass167.smethod_8().method_44(gClass);
					GClass2.smethod_0().method_74(gClass.int_9);
				}
			}
		}

		public void method_12()
		{
			for (int i = 0; i < GClass167.gclass122_10.method_2(); i++)
			{
				GClass125 gClass = (GClass125)GClass167.gclass122_10.method_3(i);
				if (gClass != null)
				{
					if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
					{
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5;
						GClass2.smethod_0().method_44();
						GClass124.smethod_1().int_4 = gClass.int_4;
						GClass124.smethod_1().int_5 = gClass.int_5 - 3;
						GClass2.smethod_0().method_44();
						Thread.Sleep(200);
					}
					GClass2.smethod_0().method_60(gClass.gclass120_0.int_0);
					Thread.Sleep(150);
					GClass2.smethod_0().method_59((short)gClass.gclass120_0.int_0, 0);
					GClass53.smethod_0().method_0();
					Thread.Sleep(150);
					GClass2.smethod_0().method_59((short)gClass.gclass120_0.int_0, 2);
					GClass53.smethod_0().method_0();
				}
			}
		}

		protected void method_13()
		{
			if (!bool_4 || GClass137.int_37 == 21 + GClass124.smethod_1().int_14)
				return;
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && gClass.gclass203_0.short_0 == 345 && GClass14.int_8 % 10 == 0)
				{
					GClass2.smethod_0().method_20(0, 1, -1, gClass.gclass203_0.short_0);
					GClass49.smethod_0().method_0(100);
					GClass2.smethod_0().method_20(3, 1, -1, gClass.gclass203_0.short_0);
					GClass96.smethod_5();
					GClass14.gclass183_0 = null;
				}
			}
		}

		protected void method_14()
		{
			try
			{
				if (int_3 <= 0)
					return;
				if (!GClass124.smethod_1().bool_62 && (GClass124.smethod_1().gclass95_0 == null || !GClass124.smethod_1().gclass95_0.bool_0 || GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 != 14))
				{
					if (GClass167.smethod_14(int_3) == null)
					{
						if (GClass77.smethod_18() - long_1 >= 500L)
						{
							GClass47.smethod_0().method_24(int_3);
							long_1 = GClass77.smethod_18();
						}
						return;
					}
					if (GClass167.gclass95_0 != null)
					{
						for (int i = 0; i < GClass167.gclass95_0.Length; i++)
						{
							GClass95 gClass = GClass167.gclass95_0[i];
							if (gClass != null)
							{
								if (bool_8 && gClass.gclass205_0.sbyte_0 == 19 && !gClass.bool_0 && GClass124.smethod_1().gclass95_0 != gClass && GClass77.smethod_18() - long_1 < 2500L && GClass167.smethod_14(int_3) != null)
								{
									GClass167.smethod_8().method_62(gClass, true);
									GClass167.smethod_8().method_64(gClass);
									return;
								}
								if (gClass.gclass205_0.sbyte_0 == 14 && GClass167.smethod_14(int_3) != null && GClass124.smethod_1().gclass95_0 != gClass)
								{
									GClass167.smethod_8().method_62(gClass, true);
									GClass14.smethod_27();
									GClass14.smethod_26();
									GClass14.smethod_49();
									return;
								}
							}
						}
					}
					if (long_1 >= 2900L)
					{
						for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
						{
							if (GClass167.gclass122_5.method_3(j) is GClass124 gClass2 && ((int_4 == -1 && gClass2.gclass60_0.bool_0) || (int_4 != -1 && gClass2.int_13 == int_4)) && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 50)
							{
								GClass124.smethod_1().int_4 = gClass2.int_4;
								GClass124.smethod_1().int_5 = gClass2.int_5;
								GClass2.smethod_0().method_44();
								GClass124.smethod_1().int_4 = gClass2.int_4;
								GClass124.smethod_1().int_5 = gClass2.int_5 + 1;
								GClass2.smethod_0().method_44();
								GClass124.smethod_1().int_4 = gClass2.int_4;
								GClass124.smethod_1().int_5 = gClass2.int_5;
								GClass2.smethod_0().method_44();
							}
						}
					}
					if (long_1 > 0L && !GClass124.smethod_1().gclass95_0.bool_0 && !GClass124.smethod_1().bool_47 && GClass77.smethod_18() - long_1 >= 3000L)
					{
						GClass167.smethod_8().method_64(GClass124.smethod_1().gclass95_0);
						long_1 = -1L;
					}
				}
				else
					int_3 = -1;
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/autoTeleportBom.txt", ex.ToString());
			}
		}

		protected void method_15()
		{
			try
			{
				if (GClass124.smethod_1().bool_62 || (GClass124.smethod_1().gclass95_0.bool_0 && GClass124.smethod_1().gclass95_0.gclass205_0.sbyte_0 == 14))
				{
					bool_6 = false;
					long_2 = -1L;
				}
				if (!bool_6)
					return;
				if (GClass167.gclass95_0 != null)
				{
					for (int i = 0; i < GClass167.gclass95_0.Length; i++)
					{
						GClass95 gClass = GClass167.gclass95_0[i];
						if (gClass != null)
						{
							if (bool_8 && gClass.gclass205_0.sbyte_0 == 19 && !gClass.bool_0 && GClass124.smethod_1().gclass95_0 != gClass && GClass77.smethod_18() - long_2 < 2500L && bool_5)
							{
								GClass167.smethod_8().method_62(gClass, true);
								GClass167.smethod_8().method_64(gClass);
								return;
							}
							if (gClass.gclass205_0.sbyte_0 == 14 && bool_5 && GClass124.smethod_1().gclass95_0 != gClass)
							{
								GClass167.smethod_8().method_62(gClass, true);
								GClass14.smethod_27();
								GClass14.smethod_26();
								GClass14.smethod_49();
								return;
							}
						}
					}
				}
				if (!bool_5 && GClass14.int_8 % 10 == 0)
				{
					if (!GClass14.gclass113_0.bool_0)
					{
						GClass14.smethod_1().method_10(99);
						return;
					}
					if (GClass137.string_1 != GClass14.gclass113_0.string_4[0] && GClass14.gclass113_0.bool_0)
					{
						GClass2.smethod_0().method_126(0);
						bool_5 = true;
						return;
					}
				}
				if (GClass124.bool_33 && long_2 < 0L && bool_5)
					long_2 = GClass77.smethod_18();
				if (long_2 >= 2900L)
				{
					for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
					{
						if (GClass167.gclass122_5.method_3(j) is GClass124 gClass2 && ((int_4 == -1 && gClass2.gclass60_0.bool_0) || (int_4 != -1 && gClass2.int_13 == int_4)) && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 50)
						{
							GClass124.smethod_1().int_4 = gClass2.int_4;
							GClass124.smethod_1().int_5 = gClass2.int_5;
							GClass2.smethod_0().method_44();
							GClass124.smethod_1().int_4 = gClass2.int_4;
							GClass124.smethod_1().int_5 = gClass2.int_5 + 1;
							GClass2.smethod_0().method_44();
							GClass124.smethod_1().int_4 = gClass2.int_4;
							GClass124.smethod_1().int_5 = gClass2.int_5;
							GClass2.smethod_0().method_44();
						}
					}
				}
				if (long_2 > 0L && !GClass124.smethod_1().gclass95_0.bool_0 && !GClass124.smethod_1().bool_47 && GClass77.smethod_18() - long_2 >= 3000L)
				{
					GClass167.smethod_8().method_64(GClass124.smethod_1().gclass95_0);
					long_2 = -1L;
				}
			}
			catch (Exception ex)
			{
				GClass51.smethod_0("Data/Errors/autoCapsuleBom.txt", ex.ToString());
			}
		}

		public void method_16()
		{
			if (GClass124.smethod_1().bool_62 || GClass124.smethod_1().gclass60_0.bool_11 || GClass124.smethod_1().gclass60_0.bool_1 || GClass124.smethod_1().gclass60_0.bool_6 || GClass124.smethod_1().gclass60_0.bool_7 || GClass124.smethod_1().gclass60_0.bool_10)
				return;
			for (int i = 0; i < GClass167.gclass122_6.method_2(); i++)
			{
				if (GClass167.gclass122_6.method_3(i) is GClass190 gClass && gClass.gclass203_0.short_0 >= 372 && gClass.gclass203_0.short_0 <= 378 && GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass.int_1, gClass.int_2) > 10)
					GClass47.smethod_0().method_27(gClass);
			}
			for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
			{
				if (GClass167.gclass122_5.method_3(j) is GClass124 gClass2 && gClass2.gclass60_0.bool_0 && gClass2.int_13 != GClass124.smethod_1().int_13)
				{
					if (GClass124.smethod_1().gclass124_0 == null || GClass124.smethod_1().gclass124_0 != gClass2)
					{
						GClass124.smethod_1().gclass190_0 = null;
						GClass124.smethod_1().gclass125_0 = null;
						GClass124.smethod_1().gclass6_0 = null;
						GClass124.smethod_1().gclass124_0 = gClass2;
						break;
					}
					if (GClass191.smethod_24(GClass124.smethod_1().int_4, GClass124.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 10 && GClass124.smethod_1().gclass124_0 == gClass2 && GClass124.smethod_1().gclass124_0 != null)
						GClass47.smethod_0().method_27(gClass2);
				}
			}
		}
	}
}
