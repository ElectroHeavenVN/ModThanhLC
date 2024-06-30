using System;
using System.Collections.Generic;
using System.Linq;

namespace ns1
{
	public class GClass185
	{
		public bool bool_0;

		private static GClass185 gclass185_0;

		public List<GClass58> list_0 = new List<GClass58>();

		public bool bool_1;

		public bool bool_2;

		public bool bool_3;

		public bool bool_4;

		public bool bool_5;

		private static short short_0;

		public static GClass185 smethod_0()
		{
			if (gclass185_0 == null)
				gclass185_0 = new GClass185();
			return gclass185_0;
		}

		public void method_0()
		{
			GClass176 gclass176_ = GClass58.smethod_1().gclass176_0;
			if (gclass176_.bool_9)
			{
				if (!bool_4)
				{
					bool_4 = true;
					GClass58.gclass63_5.method_0(new GClass82(722, GClass182.smethod_0().method_5(GClass58.smethod_1())));
				}
			}
			else if (bool_4)
			{
				bool_4 = false;
				method_1(new GClass82(722, 0));
			}
			if (gclass176_.bool_7)
			{
				if (!bool_2)
				{
					bool_2 = true;
					GClass58.gclass63_5.method_0(new GClass82(3779, 35, true));
				}
			}
			else if (bool_2)
			{
				bool_2 = false;
				method_1(new GClass82(3779, 0, true));
			}
			if (gclass176_.bool_10)
			{
				if (!bool_3)
				{
					bool_3 = true;
					GClass58.gclass63_5.method_0(new GClass82(717, GClass58.smethod_1().int_80));
				}
			}
			else if (bool_3)
			{
				bool_3 = false;
				method_1(new GClass82(717, 0));
			}
			if (gclass176_.bool_3)
			{
				if (!bool_5)
				{
					bool_5 = true;
					GClass58.gclass63_5.method_0(new GClass82(718, GClass182.smethod_0().method_3(GClass58.smethod_1())));
				}
			}
			else if (bool_5)
			{
				bool_5 = false;
				method_1(new GClass82(718, 0));
			}
			if (gclass176_.bool_0)
			{
				if (!bool_1)
				{
					bool_1 = true;
					short_0 = GClass177.smethod_0().method_6();
					GClass58.gclass63_5.method_0(new GClass82(short_0, 300));
				}
			}
			else if (bool_1)
			{
				bool_1 = false;
				method_1(new GClass82(short_0, 0));
			}
		}

		public void method_1(GClass82 item)
		{
			int num = 0;
			while (true)
			{
				if (num < GClass58.gclass63_5.method_2())
				{
					GClass82 gClass = GClass58.gclass63_5.method_3(num) as GClass82;
					if (gClass.short_0 == item.short_0 && gClass.bool_0 == item.bool_0 && gClass.bool_1 == item.bool_1)
						break;
					num++;
					continue;
				}
				return;
			}
			GClass58.gclass63_5.method_7(num);
		}

		public void method_2()
		{
			method_0();
			for (int num = list_0.Count - 1; num >= 0; num--)
			{
				GClass58 gClass = list_0.ElementAt(num);
				GClass58 gClass2 = GClass154.smethod_14(gClass.int_13);
				if (!gClass.gclass176_0.method_1())
					list_0.RemoveAt(num);
				else if (gClass2 == null)
				{
					gClass.gclass176_0.method_0();
				}
				else
				{
					GClass154.smethod_14(gClass.int_13).gclass176_0 = gClass.gclass176_0;
					list_0[num] = gClass2;
				}
			}
		}

		public bool method_3(int charId)
		{
			foreach (GClass58 item in list_0)
			{
				if (item.int_13 == charId)
					return true;
			}
			return false;
		}

		public void method_4(GClass76 g)
		{
			if (!bool_0)
				return;
			if (GClass58.smethod_1().gclass85_0 != null)
				try
				{
					List<string> list = new List<string>();
					int num = 63;
					GClass85 gclass85_ = GClass58.smethod_1().gclass85_0;
					list.Add(gclass85_.method_16().string_0 + " [" + GClass95.smethod_9(gclass85_.int_6) + "/" + GClass95.smethod_9(gclass85_.int_7) + "]");
					if (gclass85_.gclass176_0.bool_7)
						list.Add((GClass192.int_0 == 0) ? $"Đang bị trói {gclass85_.gclass176_0.int_6} giây" : $"Being Tied {gclass85_.gclass176_0.int_6} s");
					if (gclass85_.gclass176_0.bool_10)
						list.Add((GClass192.int_0 == 0) ? $"Đang bị TDHS {gclass85_.gclass176_0.int_8} giây" : $"Being Freeze {gclass85_.gclass176_0.int_8} s");
					if (gclass85_.gclass176_0.bool_6)
						list.Add((GClass192.int_0 == 0) ? $"Đang bị DCTT {gclass85_.gclass176_0.int_5} giây" : $"Being teleported {gclass85_.gclass176_0.int_5} s");
					if (gclass85_.gclass176_0.bool_1)
						list.Add((GClass192.int_0 == 0) ? $"Đang bị Thôi miên {gclass85_.gclass176_0.int_1} giây" : $"Being Hypnotized {gclass85_.gclass176_0.int_1} s");
					foreach (string item in list)
					{
						GClass193.smethod_0().method_2(GClass49.gclass49_4, g, item, GClass39.int_10 / 2, num, GClass49.int_2, GClass49.gclass49_6);
						num += 10;
					}
				}
				catch (Exception ex)
				{
					GClass188.smethod_0("Data/Errors/paintMobInformation.txt", ex.ToString());
				}
			if (GClass58.smethod_1().gclass58_0 != null)
			{
				GClass58 gclass58_ = GClass58.smethod_1().gclass58_0;
				List<string> list2 = new List<string>();
				int num2 = 63;
				list2.Add(gclass58_.string_3 + " [" + GClass95.smethod_9(gclass58_.int_25) + "/" + GClass95.smethod_9(gclass58_.int_35) + "]");
				list2.Add("CharID: " + gclass58_.int_13);
				if (gclass58_.int_56 > 0)
					list2.Add("ClanID: " + gclass58_.int_56);
				if (gclass58_.gclass176_0 != null && gclass58_.gclass176_0.method_1())
				{
					if (gclass58_.gclass176_0.bool_0)
						list2.Add((GClass192.int_0 == 0) ? $"NRD còn: {gclass58_.gclass176_0.int_0} giây" : $"Win after: {gclass58_.gclass176_0.int_0} s");
					if (gclass58_.gclass176_0.bool_5)
						list2.Add((GClass192.int_0 == 0) ? $"Khiên còn: {gclass58_.gclass176_0.int_4} giây" : $"Time shield: {gclass58_.gclass176_0.int_4} s");
					if (gclass58_.gclass176_0.bool_3)
						list2.Add((GClass192.int_0 == 0) ? $"Khỉ còn: {gclass58_.gclass176_0.int_2} giây" : $"Time monkey: {gclass58_.gclass176_0.int_2} s");
					if (gclass58_.gclass176_0.bool_4)
						list2.Add((GClass192.int_0 == 0) ? $"Huýt sáo còn: {gclass58_.gclass176_0.int_3} giây" : $"Time whistle: {gclass58_.gclass176_0.int_3} s");
					if (gclass58_.gclass176_0.bool_9)
						list2.Add((GClass192.int_0 == 0) ? $"Đẻ trứng còn: {gclass58_.gclass176_0.int_7} giây" : $"Time EggMob: {gclass58_.gclass176_0.int_7} s");
					if (gclass58_.gclass176_0.bool_1)
						list2.Add((GClass192.int_0 != 0) ? (gclass58_.gclass176_0.bool_2 ? $"Be hypnotized by me: {gclass58_.gclass176_0.int_1} s" : $"Being hypnotized: {gclass58_.gclass176_0.int_1} s") : (gclass58_.gclass176_0.bool_2 ? $"Bị bạn thôi miên: {gclass58_.gclass176_0.int_1} giây" : $"Bị thôi miên: {gclass58_.gclass176_0.int_1} giây"));
					if (gclass58_.gclass176_0.bool_6)
						list2.Add((GClass192.int_0 == 0) ? $"Bị DCTT: {gclass58_.gclass176_0.int_5} giây" : $"Being teleported: {gclass58_.gclass176_0.int_5} s");
					if (gclass58_.gclass176_0.bool_10)
						list2.Add((GClass192.int_0 == 0) ? $"Bị TDHS: {gclass58_.gclass176_0.int_8} giây" : $"Being Freeze: {gclass58_.gclass176_0.int_8} s");
					if (gclass58_.gclass176_0.bool_7)
						list2.Add((GClass192.int_0 != 0) ? (gclass58_.gclass176_0.bool_8 ? $"Be Holded by me: {gclass58_.gclass176_0.int_6} s" : $"Being Holded: {gclass58_.gclass176_0.int_6} s") : (gclass58_.gclass176_0.bool_8 ? $"Bị bạn trói: {gclass58_.gclass176_0.int_6} giây" : $"Bị trói: {gclass58_.gclass176_0.int_6} giây"));
					if (gclass58_.gclass176_0.bool_11)
						list2.Add((GClass192.int_0 == 0) ? $"Bị hóa đá: {gclass58_.gclass176_0.int_9} giây" : $"Being Stone: {gclass58_.gclass176_0.int_9} s");
					if (gclass58_.gclass176_0.bool_12)
						list2.Add((GClass192.int_0 == 0) ? $"Bị biến Sôcôla: {gclass58_.gclass176_0.int_10} giây" : $"Turned to chocolate: {gclass58_.gclass176_0.int_10} s");
				}
				foreach (string item2 in list2)
				{
					GClass193.smethod_0().method_2((item2[0].ToString().Split(' ')[0] != GClass58.smethod_1().string_3) ? GClass49.gclass49_1 : GClass49.gclass49_4, g, item2, GClass39.int_10 / 2, num2, GClass49.int_2, GClass49.gclass49_6);
					num2 += 10;
				}
			}
			List<string> list3 = new List<string>();
			int num3 = 43;
			if (GClass58.smethod_1().gclass176_0 != null && GClass58.smethod_1().gclass176_0.method_1())
			{
				if (GClass58.smethod_1().gclass176_0.bool_0)
					list3.Add((GClass192.int_0 == 0) ? $"NRD còn: {GClass58.smethod_1().gclass176_0.int_0} giây" : $"Win after: {GClass58.smethod_1().gclass176_0.int_0} s");
				if (GClass58.smethod_1().gclass176_0.bool_7)
				{
					for (int i = 0; i < GClass154.gclass63_5.method_2(); i++)
					{
						if (GClass154.gclass63_5.method_3(i) is GClass58 gClass && gClass != GClass58.smethod_1() && gClass.bool_63 && gClass.gclass58_4 == GClass58.smethod_1())
							list3.Add((GClass192.int_0 == 0) ? $"Bị trói bởi {gClass.string_3}: {GClass58.smethod_1().gclass176_0.int_6} giây" : $"Be holding by {gClass.string_3}: {GClass58.smethod_1().gclass176_0.int_6} s");
					}
				}
			}
			foreach (string item3 in list3)
			{
				GClass193.smethod_0().method_2(GClass49.gclass49_4, g, item3, GClass39.int_10 / 2, num3, GClass49.int_2, GClass49.gclass49_6);
				num3 += 10;
			}
		}

		public void method_5(GClass74 skill)
		{
			if (GClass58.smethod_1().gclass58_0 != null)
			{
				if (skill.gclass53_0.sbyte_0 == 22)
					GClass58.smethod_1().gclass58_0.gclass176_0.bool_2 = true;
				if (skill.gclass53_0.sbyte_0 == 23)
					GClass58.smethod_1().gclass58_0.gclass176_0.bool_8 = true;
			}
		}
	}
}
