using System.Collections.Generic;

namespace ns1
{
	public class GClass64
	{
		private static GClass64 gclass64_0;

		public static GClass64 smethod_0()
		{
			return (gclass64_0 != null) ? gclass64_0 : (gclass64_0 = new GClass64());
		}

		public List<int> method_0(int idMapStart, int idMapEnd)
		{
			return method_1(idMapEnd, method_3(idMapStart));
		}

		private List<int> method_1(int int_0, List<int> list_0)
		{
			int num = list_0[list_0.Count - 1];
			if (num == int_0)
				return list_0;
			if (!GClass46.smethod_2(num))
				return null;
			List<List<int>> list = new List<List<int>>();
			foreach (GStruct0 item in GClass46.smethod_1(num))
			{
				List<int> list2 = null;
				if (!list_0.Contains(item.int_0))
					list2 = method_1(int_0, method_4(list_0, item.int_0));
				if (list2 != null)
					list.Add(list2);
			}
			return method_2(list);
		}

		private List<int> method_2(List<List<int>> list_0)
		{
			if (list_0.Count == 0)
				return null;
			List<int> list = list_0[0];
			for (int i = 1; i < list_0.Count; i++)
			{
				if (method_5(list_0[i], list))
					list = list_0[i];
			}
			return list;
		}

		private List<int> method_3(int int_0)
		{
			return new List<int> { int_0 };
		}

		private List<int> method_4(List<int> list_0, int int_0)
		{
			return new List<int>(list_0) { int_0 };
		}

		private bool method_5(List<int> list_0, List<int> list_1)
		{
			bool flag = method_6(list_0);
			bool flag2 = method_6(list_1);
			if (flag && !flag2)
				return false;
			if (!flag && flag2)
				return true;
			if (list_0.Count >= list_1.Count)
				return false;
			return true;
		}

		private bool method_6(List<int> list_0)
		{
			return method_7(list_0);
		}

		private bool method_7(List<int> list_0)
		{
			List<int> list = new List<int> { 27, 28, 29 };
			int num = 1;
			while (true)
			{
				if (num < list_0.Count - 1)
				{
					if (list_0[num] == 102 && list_0[num + 1] == 24 && list.Contains(list_0[num - 1]))
						break;
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
	}
}
