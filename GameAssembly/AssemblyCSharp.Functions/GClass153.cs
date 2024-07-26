using System;
using System.Threading;

namespace AssemblyCSharp.Functions
{
	public class GClass153
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

		private static GClass153 gclass153_0;

		public TimeSpan timeSpan_1 = new TimeSpan(0, 0, 0, 2);

		public static long long_4;

		protected long long_5;

		public int int_4 = -1;

		public string string_0 = "";

		public bool bool_8;

		public void method_0()
		{
			if (!method_6())
				return;
			for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
			{
				GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
				if (gClass != null)
				{
					if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
					{
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						Thread.Sleep(200);
					}
					GClass7.smethod_0().method_60(gClass.gclass127_0.int_0);
					Thread.Sleep(150);
					GClass7.smethod_0().method_59((short)gClass.gclass127_0.int_0, 0);
					GClass162.smethod_0().method_0();
				}
			}
		}

		protected void method_1()
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
			timeSpan_0 = dateTime_1 - dateTime;
		}

		public static GClass153 smethod_0()
		{
			return (gclass153_0 != null) ? gclass153_0 : (gclass153_0 = new GClass153());
		}

		public bool method_2(int asciiCode)
		{
			if (asciiCode != 45)
			{
				if (asciiCode != 112)
					return false;
				if (!GClass78.smethod_1().bool_62 && GClass78.smethod_1().gclass163_0.bool_0 && method_6())
				{
					GClass149.smethod_1((GClass151.int_0 != 0) ? ("Auto get x7 HP: " + GClass154.smethod_0().method_6(bool_1)) : ("Tự động phù x7 HP: " + GClass154.smethod_0().method_6(bool_1)), 0);
					new Thread(method_13).Start();
				}
			}
			else if (!GClass151.bool_3)
			{
				GClass149.smethod_1((GClass151.int_0 == 0) ? "Liên hệ admin để mở khóa chức năng này!" : "Contact admin to unlock this function!", 1);
			}
			else
			{
				smethod_0().bool_4 = !smethod_0().bool_4;
				GClass149.smethod_1((GClass151.int_0 == 0) ? ("Tự động cắm vệ tinh HP: " + GClass154.smethod_0().method_6(smethod_0().bool_4)) : ("Auto use Sattelite HP: " + GClass154.smethod_0().method_6(smethod_0().bool_4)), 0);
			}
			return true;
		}

		public bool method_3(string text)
		{
			if (!GClass154.smethod_0().method_11<int>(text, "/cvs"))
			{
				if (!GClass154.smethod_0().method_10<int>(text, "/cvs", 2))
				{
					if (!(text == "/cvs"))
						return false;
					if (GClass151.bool_3)
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto use whistle" : "Tắt tự động sử dụng sáo", 0);
					}
				}
				else if (GClass151.bool_3)
				{
					int[] array = GClass154.smethod_0().method_8<int>(text, "/cvs", 2);
					int num = array[0];
					int num2 = array[1];
					if (num2 <= 0)
					{
						bool_3 = false;
						int_1 = 0;
						int_2 = 0;
						GClass149.smethod_1((GClass151.int_0 == 0) ? "Tắt tự động sử dụng sáo" : "Turn off auto use whistle", 0);
					}
					else
					{
						bool_3 = true;
						int_1 = num;
						int_2 = num2;
						GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tự động sử dụng sáo cho [{num}] khi dưới [{int_2}%] HP" : $"Auto use whistle for [{num}] when HP lower than [{int_2}%] HP", 0);
					}
				}
			}
			else if (GClass151.bool_3 && GClass78.smethod_1().gclass78_0 != null)
			{
				if (GClass154.smethod_0().method_12<int>(text, "/cvs") > 0)
				{
					bool_3 = true;
					int_1 = GClass78.smethod_1().gclass78_0.int_13;
					int_2 = GClass154.smethod_0().method_12<int>(text, "/cvs");
					GClass149.smethod_1((GClass151.int_0 == 0) ? $"Tự động sử dụng sáo cho [{GClass78.smethod_1().gclass78_0.int_13}] khi dưới [{int_2}%] HP" : $"Auto use whistle for [{GClass78.smethod_1().gclass78_0.int_13}] when HP lower than [{int_2}%] HP", 0);
				}
				else
				{
					bool_3 = false;
					int_1 = 0;
					int_2 = 0;
					GClass149.smethod_1((GClass151.int_0 != 0) ? "Turn off auto use whistle" : "Tắt tự động sử dụng sáo", 0);
				}
			}
			return true;
		}

		public void method_4()
		{
			if (method_6())
			{
				method_10();
				if (bool_7 && GClass203.smethod_18() - long_3 > 1000L)
				{
					method_18();
					long_3 = GClass203.smethod_18();
				}
				if (GClass78.smethod_1().int_5 < 30 && !bool_7)
					method_18();
				if (GClass168.smethod_0().bool_3 && GClass78.smethod_1().gclass163_0.bool_0)
					GClass168.smethod_0().bool_3 = false;
				method_12();
			}
			method_1();
			if (GClass151.bool_3)
			{
				method_9();
				method_15();
				method_16();
				method_17();
			}
		}

		public void method_5(GClass122 g)
		{
			if (int_0 < -5)
				return;
			TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0);
			TimeSpan timeSpan2 = new TimeSpan(0, 0, 0, -5);
			if (!(timeSpan_0 > timeSpan))
			{
				if (timeSpan_0 <= timeSpan && timeSpan_0 > timeSpan2)
					GClass4.gclass4_1.method_6(g, (GClass151.int_0 != 0) ? "Can pick up!" : "Có thể nhặt!", GClass73.int_10 / 2, 53, GClass4.int_2);
				if (timeSpan_0 <= timeSpan2)
					int_0 = -5;
			}
			else
				GClass4.gclass4_1.method_6(g, ((GClass151.int_0 == 0) ? "Time nhặt: " : "Time pick up: ") + ((TimeSpan)timeSpan_0).ToString() + $" ({timeSpan_0.TotalSeconds}s)", GClass73.int_10 / 2, 53, GClass4.int_2);
		}

		public bool method_6()
		{
			return GClass20.int_37 >= 85 && GClass20.int_37 <= 91;
		}

		public short method_7()
		{
			if (!method_6())
				return 0;
			return (short)(2400 - GClass20.int_37);
		}

		public void method_8(string s)
		{
			if (method_6())
			{
				if (s.ToLower().StartsWith((mResources.language == 0) ? "chưa thể nhặt lúc này, hãy đợi" : "can't pick now, wait for"))
				{
					smethod_0().int_0 = int.Parse(s.Split(' ')[(mResources.language == 0) ? 7 : 5]) - 1;
					smethod_0().dateTime_0 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
					smethod_0().dateTime_1 = smethod_0().dateTime_0.AddSeconds(int.Parse(s.Split(' ')[(mResources.language == 0) ? 7 : 5]));
					smethod_0().bool_0 = true;
				}
				if (GClass78.smethod_1().gclass163_0.bool_0 && bool_1 && (s.ToLower().StartsWith("being blessed") || s.ToLower().StartsWith("đang được")))
				{
					bool_1 = false;
					bool_2 = true;
				}
			}
			if (bool_6 && s.ToLower().Contains((mResources.language == 0) ? "vui lòng chờ" : "please wait"))
			{
				bool_5 = false;
				GClass73.gclass76_0.bool_0 = false;
				GClass73.gclass76_0.method_151();
				long_2 = -1L;
			}
		}

		protected void method_9()
		{
			if (!bool_3 || int_1 <= 0 || int_2 <= 0 || GClass73.int_8 % 10 != 0)
				return;
			for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
			{
				if (!(GClass144.gclass88_5.method_3(i) is GClass78 gClass) || gClass.int_13 != int_1 || gClass.int_25 >= gClass.int_35 * int_2 / 100)
					continue;
				for (int j = 0; j < GClass144.gclass63_0.Length; j++)
				{
					GClass63 gClass2 = GClass144.gclass63_0[j];
					if (gClass2 != null && gClass2.gclass47_0.sbyte_0 == 21)
					{
						if (gClass2.bool_0)
							return;
						if (GClass78.smethod_1().gclass63_0 != gClass2)
						{
							GClass144.smethod_8().method_62(gClass2, true);
							return;
						}
						GClass144.smethod_8().method_64(gClass2);
					}
				}
			}
		}

		protected void method_10()
		{
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				if (GClass144.gclass88_6.method_3(i) is GClass64 itemMap && method_11(itemMap))
					GClass144.gclass88_6.method_7(i);
			}
		}

		protected bool method_11(GClass64 itemMap)
		{
			return itemMap.gclass117_0.short_0 == 76 || itemMap.gclass117_0.short_0 == 188 || itemMap.gclass117_0.short_0 == 189 || itemMap.gclass117_0.short_0 == 190;
		}

		protected void method_12()
		{
			if (!GClass166.smethod_0().bool_5 || GClass148.smethod_0().bool_0 || !method_6() || GClass78.smethod_1().int_5 < 30 || GClass78.smethod_1().bool_62 || GClass78.smethod_1().int_11 != 1)
				return;
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				GClass64 gClass = (GClass64)GClass144.gclass88_6.method_3(i);
				if (gClass == null || gClass.gclass117_0.short_0 > 378 || gClass.gclass117_0.short_0 < 372)
					continue;
				if (gClass.int_4 < 30)
					break;
				if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_3, gClass.int_4) > 10 && GClass203.smethod_18() - long_0 > 1000L)
				{
					GClass78.smethod_1().int_4 = gClass.int_3;
					GClass78.smethod_1().int_5 = gClass.int_4;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass.int_3;
					GClass78.smethod_1().int_5 = gClass.int_4 + 2;
					GClass7.smethod_0().method_44();
					GClass78.smethod_1().int_4 = gClass.int_3;
					GClass78.smethod_1().int_5 = gClass.int_4;
					GClass7.smethod_0().method_44();
					long_0 = GClass203.smethod_18();
				}
				if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_3, gClass.int_4) < 30 && GClass203.smethod_18() - long_0 > 300L && GClass151.bool_3)
				{
					GClass78.smethod_1().gclass78_0 = null;
					GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass79_0 = null;
					GClass78.smethod_1().gclass64_0 = gClass;
					GClass144.smethod_8().method_44(gClass);
					GClass7.smethod_0().method_74(gClass.int_9);
					long_0 = GClass203.smethod_18();
				}
				if ((timeSpan_0 <= timeSpan_1 || !bool_0) && GClass73.int_8 % 10 == 0 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_3, gClass.int_4) < 80)
				{
					GClass78.smethod_1().gclass78_0 = null;
					GClass78.smethod_1().gclass194_0 = null;
					GClass78.smethod_1().gclass79_0 = null;
					GClass78.smethod_1().gclass64_0 = gClass;
					if (GClass151.bool_3)
						GClass144.smethod_8().method_44(gClass);
					GClass7.smethod_0().method_74(gClass.int_9);
				}
			}
		}

		public void method_13()
		{
			for (int i = 0; i < GClass144.gclass88_10.method_2(); i++)
			{
				GClass79 gClass = (GClass79)GClass144.gclass88_10.method_3(i);
				if (gClass != null)
				{
					if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_4, gClass.int_5) > 10)
					{
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5;
						GClass7.smethod_0().method_44();
						GClass78.smethod_1().int_4 = gClass.int_4;
						GClass78.smethod_1().int_5 = gClass.int_5 - 3;
						GClass7.smethod_0().method_44();
						Thread.Sleep(200);
					}
					GClass7.smethod_0().method_60(gClass.gclass127_0.int_0);
					Thread.Sleep(150);
					GClass7.smethod_0().method_59((short)gClass.gclass127_0.int_0, 0);
					GClass162.smethod_0().method_0();
					Thread.Sleep(150);
					GClass7.smethod_0().method_59((short)gClass.gclass127_0.int_0, 2);
					GClass162.smethod_0().method_0();
				}
			}
		}

		public int method_14(int id)
		{
			int num = 0;
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				if (GClass144.gclass88_6.method_3(i) is GClass64 gClass && gClass.gclass117_0.short_0 == id)
					num++;
			}
			return num;
		}

		protected void method_15()
		{
			if (!bool_4 || GClass20.int_37 == 21 + GClass78.smethod_1().int_14)
				return;
			if (GClass203.smethod_18() - long_4 > 4000L)
			{
				GClass144.smethod_8().gclass146_0 = null;
				GClass73.smethod_29();
				long_4 = GClass203.smethod_18();
			}
			if (method_14(342) + method_14(343) + method_14(344) + method_14(345) == 3)
				return;
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (method_14(342) >= 1 || GClass73.int_8 % 10 != 0 || gClass.gclass117_0.short_0 != 342)
				{
					if (method_14(345) < 2 && GClass73.int_8 % 10 == 0 && gClass.gclass117_0.short_0 == 345)
					{
						GClass7.smethod_0().method_20(0, 1, -1, 345);
						GClass7.smethod_0().method_20(3, 1, -1, 345);
						break;
					}
					continue;
				}
				GClass7.smethod_0().method_20(0, 1, -1, 342);
				GClass7.smethod_0().method_20(3, 1, -1, 342);
				break;
			}
		}

		protected void method_16()
		{
			try
			{
				if (int_3 <= 0)
					return;
				if (GClass78.smethod_1().bool_62 || (GClass78.smethod_1().gclass63_0 != null && GClass78.smethod_1().gclass63_0.bool_0 && GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 14))
				{
					int_3 = -1;
					return;
				}
				if (GClass144.smethod_14(int_3) == null)
				{
					if (GClass203.smethod_18() - long_1 >= 500L)
					{
						GClass159.smethod_0().method_24(int_3);
						long_1 = GClass203.smethod_18();
					}
					return;
				}
				if (GClass144.gclass63_0 != null)
				{
					for (int i = 0; i < GClass144.gclass63_0.Length; i++)
					{
						GClass63 gClass = GClass144.gclass63_0[i];
						if (gClass != null)
						{
							if (bool_8 && gClass.gclass47_0.sbyte_0 == 19 && !gClass.bool_0 && GClass78.smethod_1().gclass63_0 != gClass && GClass203.smethod_18() - long_1 < 2500L && GClass144.smethod_14(int_3) != null)
							{
								GClass144.smethod_8().method_62(gClass, true);
								GClass144.smethod_8().method_64(gClass);
								return;
							}
							if (gClass.gclass47_0.sbyte_0 == 14 && GClass144.smethod_14(int_3) != null && GClass78.smethod_1().gclass63_0 != gClass)
							{
								GClass144.smethod_8().method_62(gClass, true);
								GClass73.smethod_27();
								GClass73.smethod_26();
								GClass73.smethod_49();
								return;
							}
						}
					}
				}
				if (long_1 >= 2900L)
				{
					for (int j = 0; j < GClass144.gclass88_5.method_2(); j++)
					{
						if (GClass144.gclass88_5.method_3(j) is GClass78 gClass2 && ((int_4 == -1 && gClass2.gclass163_0.bool_0) || (int_4 != -1 && gClass2.int_13 == int_4)) && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 50)
						{
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5 + 1;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5;
							GClass7.smethod_0().method_44();
						}
					}
				}
				if (long_1 > 0L && !GClass78.smethod_1().gclass63_0.bool_0 && !GClass78.smethod_1().bool_47 && GClass203.smethod_18() - long_1 >= 3000L)
				{
					GClass144.smethod_8().method_64(GClass78.smethod_1().gclass63_0);
					int_3 = -1;
					long_1 = -1L;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoTeleportBom.txt", ex.ToString());
			}
		}

		protected void method_17()
		{
			try
			{
				if (GClass78.smethod_1().bool_62 || (GClass78.smethod_1().gclass63_0.bool_0 && GClass78.smethod_1().gclass63_0.gclass47_0.sbyte_0 == 14))
				{
					bool_6 = false;
					long_2 = -1L;
				}
				if (!bool_6)
					return;
				if (GClass144.gclass63_0 != null)
				{
					for (int i = 0; i < GClass144.gclass63_0.Length; i++)
					{
						GClass63 gClass = GClass144.gclass63_0[i];
						if (gClass != null)
						{
							if (bool_8 && gClass.gclass47_0.sbyte_0 == 19 && !gClass.bool_0 && GClass78.smethod_1().gclass63_0 != gClass && GClass203.smethod_18() - long_2 < 2500L && bool_5)
							{
								GClass144.smethod_8().method_62(gClass, true);
								GClass144.smethod_8().method_64(gClass);
								return;
							}
							if (gClass.gclass47_0.sbyte_0 == 14 && bool_5 && GClass78.smethod_1().gclass63_0 != gClass)
							{
								GClass144.smethod_8().method_62(gClass, true);
								GClass73.smethod_27();
								GClass73.smethod_26();
								GClass73.smethod_49();
								return;
							}
						}
					}
				}
				if (!bool_5 && GClass73.int_8 % 10 == 0)
				{
					if (!GClass73.gclass76_0.bool_0)
					{
						GClass73.smethod_1().method_10(99);
						return;
					}
					if (GClass20.string_1 != GClass73.gclass76_0.string_4[0] && GClass73.gclass76_0.bool_0)
					{
						GClass7.smethod_0().method_126(0);
						bool_5 = true;
						return;
					}
				}
				if (GClass78.bool_33 && long_2 < 0L && bool_5)
					long_2 = GClass203.smethod_18();
				if (long_2 >= 2900L)
				{
					for (int j = 0; j < GClass144.gclass88_5.method_2(); j++)
					{
						if (GClass144.gclass88_5.method_3(j) is GClass78 gClass2 && ((int_4 == -1 && gClass2.gclass163_0.bool_0) || (int_4 != -1 && gClass2.int_13 == int_4)) && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 50)
						{
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5 + 1;
							GClass7.smethod_0().method_44();
							GClass78.smethod_1().int_4 = gClass2.int_4;
							GClass78.smethod_1().int_5 = gClass2.int_5;
							GClass7.smethod_0().method_44();
						}
					}
				}
				if (long_2 > 0L && !GClass78.smethod_1().gclass63_0.bool_0 && !GClass78.smethod_1().bool_47 && GClass203.smethod_18() - long_2 >= 3000L)
				{
					GClass144.smethod_8().method_64(GClass78.smethod_1().gclass63_0);
					bool_6 = false;
					long_2 = -1L;
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/autoCapsuleBom.txt", ex.ToString());
			}
		}

		public void method_18()
		{
			if (GClass78.smethod_1().bool_62 || GClass78.smethod_1().gclass163_0.bool_11 || GClass78.smethod_1().gclass163_0.bool_1 || GClass78.smethod_1().gclass163_0.bool_6 || GClass78.smethod_1().gclass163_0.bool_7 || GClass78.smethod_1().gclass163_0.bool_10)
				return;
			for (int i = 0; i < GClass144.gclass88_6.method_2(); i++)
			{
				if (GClass144.gclass88_6.method_3(i) is GClass64 gClass && gClass.gclass117_0.short_0 >= 372 && gClass.gclass117_0.short_0 <= 378 && GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass.int_1, gClass.int_2) > 10)
					GClass159.smethod_0().method_27(gClass);
			}
			for (int j = 0; j < GClass144.gclass88_5.method_2(); j++)
			{
				if (GClass144.gclass88_5.method_3(j) is GClass78 gClass2 && gClass2.gclass163_0.bool_0 && gClass2.int_13 != GClass78.smethod_1().int_13)
				{
					if (GClass78.smethod_1().gclass78_0 == null || GClass78.smethod_1().gclass78_0 != gClass2)
					{
						GClass78.smethod_1().gclass64_0 = null;
						GClass78.smethod_1().gclass79_0 = null;
						GClass78.smethod_1().gclass194_0 = null;
						GClass78.smethod_1().gclass78_0 = gClass2;
						break;
					}
					if (GClass50.smethod_24(GClass78.smethod_1().int_4, GClass78.smethod_1().int_5, gClass2.int_4, gClass2.int_5) > 10 && GClass78.smethod_1().gclass78_0 == gClass2 && GClass78.smethod_1().gclass78_0 != null)
						GClass159.smethod_0().method_27(gClass2);
				}
			}
		}
	}
}
