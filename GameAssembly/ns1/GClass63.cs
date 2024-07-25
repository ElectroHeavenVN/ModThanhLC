using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
	public class GClass63
	{
		public bool bool_0;

		private static GClass63 gclass63_0;

		public static List<GClass124> list_0 = new List<GClass124>();

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public bool bool_4;

		public bool bool_5;

		private static short short_0;

		public List<string> list_1 = new List<string>();

		public static GClass63 smethod_0()
		{
			if (gclass63_0 == null)
				gclass63_0 = new GClass63();
			return gclass63_0;
		}

		public void method_0()
		{
			GClass60 gclass60_ = GClass124.smethod_1().gclass60_0;
			if (!gclass60_.bool_9)
			{
				if (bool_4)
				{
					bool_4 = false;
					method_1(new GClass82(722, 0));
				}
			}
			else if (!bool_4)
			{
				bool_4 = true;
				GClass124.gclass122_5.method_0(new GClass82(722, GClass59.smethod_0().method_5(GClass124.smethod_1())));
			}
			if (!gclass60_.bool_7)
			{
				if (bool_2)
					bool_2 = false;
			}
			else if (!bool_2)
			{
				bool_2 = true;
			}
			if (!gclass60_.bool_10)
			{
				if (bool_3)
				{
					bool_3 = false;
					method_1(new GClass82(717, 0));
				}
			}
			else if (!bool_3)
			{
				bool_3 = true;
				GClass124.gclass122_5.method_0(new GClass82(717, GClass124.smethod_1().int_80));
			}
			if (!gclass60_.bool_3)
			{
				if (bool_5)
				{
					bool_5 = false;
					method_1(new GClass82(718, 0));
				}
			}
			else if (!bool_5)
			{
				bool_5 = true;
				GClass124.gclass122_5.method_0(new GClass82(718, GClass59.smethod_0().method_3(GClass124.smethod_1())));
			}
			if (!gclass60_.bool_0)
			{
				if (bool_1)
				{
					bool_1 = false;
					method_1(new GClass82(short_0, 0));
				}
			}
			else if (!bool_1)
			{
				bool_1 = true;
				short_0 = GClass54.smethod_0().method_6();
				GClass124.gclass122_5.method_0(new GClass82(short_0, 300));
			}
		}

		public void method_1(GClass82 item)
		{
			int num = 0;
			while (true)
			{
				if (num < GClass124.gclass122_5.method_2())
				{
					GClass82 gClass = GClass124.gclass122_5.method_3(num) as GClass82;
					if (gClass.short_0 == item.short_0 && gClass.bool_0 == item.bool_0 && gClass.bool_1 == item.bool_1)
						break;
					num++;
					continue;
				}
				return;
			}
			GClass124.gclass122_5.method_7(num);
		}

		public void method_2()
		{
			method_0();
			for (int num = list_0.Count - 1; num >= 0; num--)
			{
				GClass124 gClass = list_0.ElementAt(num);
				GClass124 gClass2 = GClass167.smethod_14(gClass.int_13);
				if (!gClass.gclass60_0.method_1())
					list_0.RemoveAt(num);
				else if (gClass2 != null)
				{
					GClass167.smethod_14(gClass.int_13).gclass60_0 = gClass.gclass60_0;
					list_0[num] = gClass2;
				}
				else
				{
					gClass.gclass60_0.method_0();
				}
			}
		}

		public bool method_3(int charId)
		{
			foreach (GClass124 item in list_0)
			{
				if (item.int_13 == charId)
					return true;
			}
			return false;
		}

		public void method_4(GClass193 g)
		{
			if (!bool_0)
				return;
			int num = 25;
			list_1.Clear();
			if (GClass124.smethod_1().gclass60_0 != null && GClass124.smethod_1().gclass60_0.method_1())
			{
				if (GClass124.smethod_1().gclass60_0.bool_0)
					list_1.Add((GClass62.int_0 != 0) ? $"Win after: {GClass124.smethod_1().gclass60_0.int_0} s" : $"NRD còn: {GClass124.smethod_1().gclass60_0.int_0} giây");
				if (GClass124.smethod_1().gclass60_0.bool_7)
				{
					for (int i = 0; i < GClass167.gclass122_5.method_2(); i++)
					{
						if (GClass167.gclass122_5.method_3(i) is GClass124 gClass && gClass != GClass124.smethod_1() && gClass.bool_63 && gClass.gclass124_4 == GClass124.smethod_1())
							list_1.Add((GClass62.int_0 == 0) ? $"Bị trói bởi {gClass.string_3}: {GClass124.smethod_1().gclass60_0.int_6} giây" : $"Be holding by {gClass.string_3}: {GClass124.smethod_1().gclass60_0.int_6} s");
					}
				}
			}
			for (int j = 0; j < GClass167.gclass122_5.method_2(); j++)
			{
				GClass124 gClass2 = (GClass124)GClass167.gclass122_5.method_3(j);
				if (gClass2 == null || !gClass2.gclass60_0.bool_0 || (GClass124.smethod_1().gclass124_0 == gClass2 && GClass124.smethod_1().gclass124_0 != null))
					continue;
				list_1.Add(gClass2.string_3 + " [" + GClass138.smethod_9(gClass2.int_25) + "/" + GClass138.smethod_9(gClass2.int_35) + "]");
				List<string> list = list_1;
				object obj;
				if (GClass62.int_0 != 0)
				{
					obj = $"Win after: {gClass2.gclass60_0.int_0}s";
					if (obj == null)
						goto IL_0266;
				}
				else
				{
					obj = $"NRD còn: {gClass2.gclass60_0.int_0}s";
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
				GClass45.smethod_0().method_1(GClass104.gclass104_4, g, item, GClass14.int_10 / 2, num, GClass104.int_2, GClass104.gclass104_6);
				num += 10;
			}
			if (GClass124.smethod_1().gclass6_0 != null)
				try
				{
					List<string> list2 = new List<string>();
					GClass6 gclass6_ = GClass124.smethod_1().gclass6_0;
					list2.Add(gclass6_.method_16().string_0 + " [" + GClass138.smethod_9(gclass6_.int_6) + "/" + GClass138.smethod_9(gclass6_.int_7) + "]");
					if (gclass6_.gclass60_0.bool_7)
						list2.Add((GClass62.int_0 != 0) ? $"Being Tied {gclass6_.gclass60_0.int_6} s" : $"Đang bị trói {gclass6_.gclass60_0.int_6} giây");
					if (gclass6_.gclass60_0.bool_10)
						list2.Add((GClass62.int_0 != 0) ? $"Being Freeze {gclass6_.gclass60_0.int_8} s" : $"Đang bị TDHS {gclass6_.gclass60_0.int_8} giây");
					if (gclass6_.gclass60_0.bool_6)
						list2.Add((GClass62.int_0 == 0) ? $"Đang bị DCTT {gclass6_.gclass60_0.int_5} giây" : $"Being teleported {gclass6_.gclass60_0.int_5} s");
					if (gclass6_.gclass60_0.bool_1)
						list2.Add((GClass62.int_0 != 0) ? $"Being Hypnotized {gclass6_.gclass60_0.int_1} s" : $"Đang bị Thôi miên {gclass6_.gclass60_0.int_1} giây");
					foreach (string item2 in list2)
					{
						GClass45.smethod_0().method_1(GClass104.gclass104_4, g, item2, GClass14.int_10 / 2, num, GClass104.int_2, GClass104.gclass104_6);
						num += 10;
					}
				}
				catch (Exception ex)
				{
					GClass51.smethod_0("Data/Errors/paintMobInformation.txt", ex.ToString());
				}
			if (GClass124.smethod_1().gclass124_0 != null)
			{
				GClass124 gclass124_ = GClass124.smethod_1().gclass124_0;
				List<string> list3 = new List<string>();
				list3.Add(gclass124_.string_3 + " [" + GClass138.smethod_9(gclass124_.int_25) + "/" + GClass138.smethod_9(gclass124_.int_35) + "]");
				list3.Add($"CharID: {gclass124_.int_13}");
				if (gclass124_.int_56 > 0)
					list3.Add("ClanID: " + gclass124_.int_56);
				if (gclass124_.gclass60_0 != null && gclass124_.gclass60_0.method_1())
				{
					if (gclass124_.gclass60_0.bool_0)
						list3.Add((GClass62.int_0 != 0) ? $"Win after: {gclass124_.gclass60_0.int_0} s" : $"NRD còn: {gclass124_.gclass60_0.int_0} giây");
					if (gclass124_.gclass60_0.bool_5)
						list3.Add((GClass62.int_0 == 0) ? $"Khiên còn: {gclass124_.gclass60_0.int_4} giây" : $"Time shield: {gclass124_.gclass60_0.int_4} s");
					if (gclass124_.gclass60_0.bool_3)
						list3.Add((GClass62.int_0 == 0) ? $"Khỉ còn: {gclass124_.gclass60_0.int_2} giây" : $"Time monkey: {gclass124_.gclass60_0.int_2} s");
					if (gclass124_.gclass60_0.bool_4)
						list3.Add((GClass62.int_0 == 0) ? $"Huýt sáo còn: {gclass124_.gclass60_0.int_3} giây" : $"Time whistle: {gclass124_.gclass60_0.int_3} s");
					if (gclass124_.gclass60_0.bool_9)
						list3.Add((GClass62.int_0 != 0) ? $"Time EggMob: {gclass124_.gclass60_0.int_7} s" : $"Đẻ trứng còn: {gclass124_.gclass60_0.int_7} giây");
					if (gclass124_.gclass60_0.bool_1)
						list3.Add((GClass62.int_0 != 0) ? (gclass124_.gclass60_0.bool_2 ? $"Be hypnotized by me: {gclass124_.gclass60_0.int_1} s" : $"Being hypnotized: {gclass124_.gclass60_0.int_1} s") : ((!gclass124_.gclass60_0.bool_2) ? $"Bị thôi miên: {gclass124_.gclass60_0.int_1} giây" : $"Bị bạn thôi miên: {gclass124_.gclass60_0.int_1} giây"));
					if (gclass124_.gclass60_0.bool_6)
						list3.Add((GClass62.int_0 != 0) ? $"Being teleported: {gclass124_.gclass60_0.int_5} s" : $"Bị DCTT: {gclass124_.gclass60_0.int_5} giây");
					if (gclass124_.gclass60_0.bool_10)
						list3.Add((GClass62.int_0 != 0) ? $"Being Freeze: {gclass124_.gclass60_0.int_8} s" : $"Bị TDHS: {gclass124_.gclass60_0.int_8} giây");
					if (gclass124_.gclass60_0.bool_7)
						list3.Add((GClass62.int_0 != 0) ? (gclass124_.gclass60_0.bool_8 ? $"Be Holded by me: {gclass124_.gclass60_0.int_6} s" : $"Being Holded: {gclass124_.gclass60_0.int_6} s") : ((!gclass124_.gclass60_0.bool_8) ? $"Bị trói: {gclass124_.gclass60_0.int_6} giây" : $"Bị bạn trói: {gclass124_.gclass60_0.int_6} giây"));
					if (gclass124_.gclass60_0.bool_11)
						list3.Add((GClass62.int_0 != 0) ? $"Being Stone: {gclass124_.gclass60_0.int_9} s" : $"Bị hóa đá: {gclass124_.gclass60_0.int_9} giây");
					if (gclass124_.gclass60_0.bool_12)
						list3.Add((GClass62.int_0 != 0) ? $"Turned to chocolate: {gclass124_.gclass60_0.int_10} s" : $"Bị biến Sôcôla: {gclass124_.gclass60_0.int_10} giây");
				}
				foreach (string item3 in list3)
				{
					GClass45.smethod_0().method_1((!(item3[0].ToString().Split(' ')[0] != GClass124.smethod_1().string_3)) ? GClass104.gclass104_4 : GClass104.gclass104_1, g, item3, GClass14.int_10 / 2, num, GClass104.int_2, GClass104.gclass104_6);
					num += 10;
				}
			}
			GClass42.smethod_0().int_0 = num;
		}

		public void method_5(GClass95 skill)
		{
			if (GClass124.smethod_1().gclass124_0 != null)
			{
				if (skill.gclass205_0.sbyte_0 == 22)
					GClass124.smethod_1().gclass124_0.gclass60_0.bool_2 = true;
				if (skill.gclass205_0.sbyte_0 == 23)
					GClass124.smethod_1().gclass124_0.gclass60_0.bool_8 = true;
			}
		}
	}
}
