using System;
using System.Collections.Generic;
using System.Linq;

namespace AssemblyCSharp.Functions
{
	public class GClass170
	{
		public bool bool_0;

		private static GClass170 gclass170_0;

		public static List<GClass78> list_0 = new List<GClass78>();

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public bool bool_4;

		public bool bool_5;

		private static short short_0;

		public List<string> list_1 = new List<string>();

		public static GClass170 smethod_0()
		{
			if (gclass170_0 == null)
				gclass170_0 = new GClass170();
			return gclass170_0;
		}

		public void method_0()
		{
			GClass163 gclass163_ = GClass78.smethod_1().gclass163_0;
			if (!gclass163_.bool_9)
			{
				if (bool_4)
				{
					bool_4 = false;
					method_1(new GClass19(722, 0));
				}
			}
			else if (!bool_4)
			{
				bool_4 = true;
				GClass78.gclass88_5.method_0(new GClass19(722, GClass175.smethod_0().method_5(GClass78.smethod_1())));
			}
			if (!gclass163_.bool_7)
			{
				if (bool_2)
					bool_2 = false;
			}
			else if (!bool_2)
			{
				bool_2 = true;
			}
			if (!gclass163_.bool_10)
			{
				if (bool_3)
				{
					bool_3 = false;
					method_1(new GClass19(717, 0));
				}
			}
			else if (!bool_3)
			{
				bool_3 = true;
				GClass78.gclass88_5.method_0(new GClass19(717, GClass78.smethod_1().int_80));
			}
			if (gclass163_.bool_3)
			{
				if (!bool_5)
				{
					bool_5 = true;
					GClass78.gclass88_5.method_0(new GClass19(718, GClass175.smethod_0().method_3(GClass78.smethod_1())));
				}
			}
			else if (bool_5)
			{
				bool_5 = false;
				method_1(new GClass19(718, 0));
			}
			if (gclass163_.bool_0)
			{
				if (!bool_1)
				{
					bool_1 = true;
					short_0 = GClass153.smethod_0().method_7();
					GClass78.gclass88_5.method_0(new GClass19(short_0, 300));
				}
			}
			else if (bool_1)
			{
				bool_1 = false;
				method_1(new GClass19(short_0, 0));
			}
		}

		public void method_1(GClass19 item)
		{
			for (int i = 0; i < GClass78.gclass88_5.method_2(); i++)
			{
				GClass19 gClass = GClass78.gclass88_5.method_3(i) as GClass19;
				if (gClass.short_0 == item.short_0 && gClass.bool_0 == item.bool_0 && gClass.bool_1 == item.bool_1)
				{
					GClass78.gclass88_5.method_7(i);
					break;
				}
			}
		}

		public void method_2()
		{
			method_0();
			for (int num = list_0.Count - 1; num >= 0; num--)
			{
				GClass78 gClass = list_0.ElementAt(num);
				GClass78 gClass2 = GClass144.smethod_14(gClass.int_13);
				if (!gClass.gclass163_0.method_1())
					list_0.RemoveAt(num);
				else if (gClass2 == null)
				{
					gClass.gclass163_0.method_0();
				}
				else
				{
					GClass144.smethod_14(gClass.int_13).gclass163_0 = gClass.gclass163_0;
					list_0[num] = gClass2;
				}
			}
		}

		public bool method_3(int charId)
		{
			foreach (GClass78 item in list_0)
			{
				if (item.int_13 == charId)
					return true;
			}
			return false;
		}

		public void method_4(GClass122 g)
		{
			if (!bool_0)
				return;
			int num = 25;
			list_1.Clear();
			if (GClass78.smethod_1().gclass163_0 != null && GClass78.smethod_1().gclass163_0.method_1())
			{
				if (GClass78.smethod_1().gclass163_0.bool_0)
					list_1.Add((GClass151.int_0 != 0) ? $"Win after: {GClass78.smethod_1().gclass163_0.int_0} s" : $"NRD còn: {GClass78.smethod_1().gclass163_0.int_0} giây");
				if (GClass78.smethod_1().gclass163_0.bool_7)
				{
					for (int i = 0; i < GClass144.gclass88_5.method_2(); i++)
					{
						if (GClass144.gclass88_5.method_3(i) is GClass78 gClass && gClass != GClass78.smethod_1() && gClass.bool_63 && gClass.gclass78_4 == GClass78.smethod_1())
							list_1.Add((GClass151.int_0 == 0) ? $"Bị trói bởi {gClass.string_3}: {GClass78.smethod_1().gclass163_0.int_6} giây" : $"Be holding by {gClass.string_3}: {GClass78.smethod_1().gclass163_0.int_6} s");
					}
				}
			}
			for (int j = 0; j < GClass144.gclass88_5.method_2(); j++)
			{
				GClass78 gClass2 = (GClass78)GClass144.gclass88_5.method_3(j);
				if (gClass2 == null || !gClass2.gclass163_0.bool_0 || (GClass78.smethod_1().gclass78_0 == gClass2 && GClass78.smethod_1().gclass78_0 != null))
					continue;
				list_1.Add(gClass2.string_3 + " [" + GClass65.smethod_9(gClass2.int_25) + "/" + GClass65.smethod_9(gClass2.int_35) + "]");
				List<string> list = list_1;
				object obj;
				if (GClass151.int_0 != 0)
				{
					obj = $"Win after: {gClass2.gclass163_0.int_0}s";
					if (obj == null)
						goto IL_0266;
				}
				else
				{
					obj = $"NRD còn: {gClass2.gclass163_0.int_0}s";
					if (obj == null)
						goto IL_0266;
				}
				goto IL_026c;
				IL_0266:
				obj = "";
				goto IL_026c;
				IL_026c:
				list.Add((string)obj);
			}
			foreach (string item in list_1)
			{
				GClass154.smethod_0().method_1(GClass4.gclass4_4, g, item, GClass73.int_10 / 2, num, GClass4.int_2, GClass4.gclass4_6);
				num += 10;
			}
			if (GClass78.smethod_1().gclass194_0 != null)
				try
				{
					List<string> list2 = new List<string>();
					GClass194 gclass194_ = GClass78.smethod_1().gclass194_0;
					list2.Add(gclass194_.method_16().string_0 + " [" + GClass65.smethod_9(gclass194_.int_6) + "/" + GClass65.smethod_9(gclass194_.int_7) + "]");
					if (gclass194_.gclass163_0.bool_7)
						list2.Add((GClass151.int_0 == 0) ? $"Đang bị trói {gclass194_.gclass163_0.int_6} giây" : $"Being Tied {gclass194_.gclass163_0.int_6} s");
					if (gclass194_.gclass163_0.bool_10)
						list2.Add((GClass151.int_0 != 0) ? $"Being Freeze {gclass194_.gclass163_0.int_8} s" : $"Đang bị TDHS {gclass194_.gclass163_0.int_8} giây");
					if (gclass194_.gclass163_0.bool_6)
						list2.Add((GClass151.int_0 == 0) ? $"Đang bị DCTT {gclass194_.gclass163_0.int_5} giây" : $"Being teleported {gclass194_.gclass163_0.int_5} s");
					if (gclass194_.gclass163_0.bool_1)
						list2.Add((GClass151.int_0 != 0) ? $"Being Hypnotized {gclass194_.gclass163_0.int_1} s" : $"Đang bị Thôi miên {gclass194_.gclass163_0.int_1} giây");
					foreach (string item2 in list2)
					{
						GClass154.smethod_0().method_1(GClass4.gclass4_4, g, item2, GClass73.int_10 / 2, num, GClass4.int_2, GClass4.gclass4_6);
						num += 10;
					}
				}
				catch (Exception ex)
				{
					GClass149.smethod_0("Data/Errors/paintMobInformation.txt", ex.ToString());
				}
			if (GClass78.smethod_1().gclass78_0 != null)
			{
				GClass78 gclass78_ = GClass78.smethod_1().gclass78_0;
				List<string> list3 = new List<string>();
				list3.Add(gclass78_.string_3 + " [" + GClass65.smethod_9(gclass78_.int_25) + "/" + GClass65.smethod_9(gclass78_.int_35) + "]");
				list3.Add($"CharID: {gclass78_.int_13}");
				if (gclass78_.int_56 > 0)
					list3.Add("ClanID: " + gclass78_.int_56);
				if (gclass78_.gclass163_0 != null && gclass78_.gclass163_0.method_1())
				{
					if (gclass78_.gclass163_0.bool_0)
						list3.Add((GClass151.int_0 != 0) ? $"Win after: {gclass78_.gclass163_0.int_0} s" : $"NRD còn: {gclass78_.gclass163_0.int_0} giây");
					if (gclass78_.gclass163_0.bool_5)
						list3.Add((GClass151.int_0 != 0) ? $"Time shield: {gclass78_.gclass163_0.int_4} s" : $"Khiên còn: {gclass78_.gclass163_0.int_4} giây");
					if (gclass78_.gclass163_0.bool_3)
						list3.Add((GClass151.int_0 != 0) ? $"Time monkey: {gclass78_.gclass163_0.int_2} s" : $"Khỉ còn: {gclass78_.gclass163_0.int_2} giây");
					if (gclass78_.gclass163_0.bool_4)
						list3.Add((GClass151.int_0 != 0) ? $"Time whistle: {gclass78_.gclass163_0.int_3} s" : $"Huýt sáo còn: {gclass78_.gclass163_0.int_3} giây");
					if (gclass78_.gclass163_0.bool_9)
						list3.Add((GClass151.int_0 != 0) ? $"Time EggMob: {gclass78_.gclass163_0.int_7} s" : $"Đẻ trứng còn: {gclass78_.gclass163_0.int_7} giây");
					if (gclass78_.gclass163_0.bool_1)
						list3.Add((GClass151.int_0 == 0) ? ((!gclass78_.gclass163_0.bool_2) ? $"Bị thôi miên: {gclass78_.gclass163_0.int_1} giây" : $"Bị bạn thôi miên: {gclass78_.gclass163_0.int_1} giây") : (gclass78_.gclass163_0.bool_2 ? $"Be hypnotized by me: {gclass78_.gclass163_0.int_1} s" : $"Being hypnotized: {gclass78_.gclass163_0.int_1} s"));
					if (gclass78_.gclass163_0.bool_6)
						list3.Add((GClass151.int_0 == 0) ? $"Bị DCTT: {gclass78_.gclass163_0.int_5} giây" : $"Being teleported: {gclass78_.gclass163_0.int_5} s");
					if (gclass78_.gclass163_0.bool_10)
						list3.Add((GClass151.int_0 != 0) ? $"Being Freeze: {gclass78_.gclass163_0.int_8} s" : $"Bị TDHS: {gclass78_.gclass163_0.int_8} giây");
					if (gclass78_.gclass163_0.bool_7)
						list3.Add((GClass151.int_0 == 0) ? ((!gclass78_.gclass163_0.bool_8) ? $"Bị trói: {gclass78_.gclass163_0.int_6} giây" : $"Bị bạn trói: {gclass78_.gclass163_0.int_6} giây") : ((!gclass78_.gclass163_0.bool_8) ? $"Being Holded: {gclass78_.gclass163_0.int_6} s" : $"Be Holded by me: {gclass78_.gclass163_0.int_6} s"));
					if (gclass78_.gclass163_0.bool_11)
						list3.Add((GClass151.int_0 != 0) ? $"Being Stone: {gclass78_.gclass163_0.int_9} s" : $"Bị hóa đá: {gclass78_.gclass163_0.int_9} giây");
					if (gclass78_.gclass163_0.bool_12)
						list3.Add((GClass151.int_0 == 0) ? $"Bị biến Sôcôla: {gclass78_.gclass163_0.int_10} giây" : $"Turned to chocolate: {gclass78_.gclass163_0.int_10} s");
				}
				foreach (string item3 in list3)
				{
					GClass154.smethod_0().method_1((!(item3[0].ToString().Split(' ')[0] != GClass78.smethod_1().string_3)) ? GClass4.gclass4_4 : GClass4.gclass4_1, g, item3, GClass73.int_10 / 2, num, GClass4.int_2, GClass4.gclass4_6);
					num += 10;
				}
			}
			GClass160.smethod_0().int_0 = num;
		}

		public void method_5(GClass63 skill)
		{
			if (GClass78.smethod_1().gclass78_0 != null)
			{
				if (skill.gclass47_0.sbyte_0 == 22)
					GClass78.smethod_1().gclass78_0.gclass163_0.bool_2 = true;
				if (skill.gclass47_0.sbyte_0 == 23)
					GClass78.smethod_1().gclass78_0.gclass163_0.bool_8 = true;
			}
		}
	}
}
