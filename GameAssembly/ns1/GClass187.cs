namespace ns1
{
	public class GClass187 : GInterface0, GInterface5
	{
		public long long_0;

		public bool bool_0;

		public int int_0 = -1;

		public int int_1 = -1;

		public int int_2 = -1;

		private int int_3;

		private static GClass187 gclass187_0;

		public long long_1;

		public int int_4 = -1;

		public int int_5;

		public int int_6 = 0;

		public static GClass187 smethod_0()
		{
			return (gclass187_0 != null) ? gclass187_0 : (gclass187_0 = new GClass187());
		}

		private void method_0()
		{
			GClass7.smethod_0().string_1 = "Chat";
			GClass7.smethod_0().gclass67_0.string_7 = "chat";
			GClass7.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass7.smethod_0().gclass67_0.method_21() == null || GClass7.smethod_0().gclass67_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass7.smethod_0().bool_0 = false;
			else if (GClass7.smethod_0().string_1.Equals((GClass192.int_0 == 0) ? "Nhập ID của Item, HSD. VD:1222 5" : "Fill ID of Item, Expr. Example:1222 5"))
			{
				string[] array = GClass7.smethod_0().gclass67_0.method_21().Split(' ');
				int_4 = 1;
				int_5 = int.Parse(array[0]);
				int_6 = int.Parse(array[1]);
				bool_0 = false;
				method_0();
			}
			method_0();
		}

		public void method_1(string text)
		{
			GClass7.smethod_0().string_1 = text;
			GClass7.smethod_0().gclass67_0.string_7 = mResources.CHAT;
			GClass39.gclass45_0.bool_0 = false;
			GClass7.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void perform(int idAction, object p)
		{
			if (GClass171.smethod_0().bool_0)
				return;
			switch (idAction)
			{
			case 101901:
				int_0 = 5000000;
				int_1 = 0;
				int_2 = 0;
				return;
			case 101902:
				int_0 = 5000000;
				int_1 = 0;
				int_2 = 1;
				return;
			case 101903:
				int_0 = 4;
				int_1 = 1;
				int_2 = 2;
				return;
			case 101904:
				int_0 = 4;
				int_1 = 1;
				int_2 = 3;
				return;
			case 101905:
			{
				GClass63 gClass = new GClass63();
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Nhận mảnh\nvà sử dụng\nmảnh" : "Collect\nand use\nsharp", this, 102001, null));
				gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Xóa item\theo HSD" : "Delete Expr\nItem", this, 102002, null));
				GClass39.gclass0_0.method_2(gClass, 0);
				return;
			}
			}
			if (idAction != 102001)
			{
				if (idAction == 102002)
					smethod_0().method_1((GClass192.int_0 == 0) ? "Nhập ID của Item, HSD. VD:1222 5" : "Fill ID of Item, Expr. Example:1222 5");
			}
			else
			{
				int_4 = 0;
				bool_0 = false;
			}
		}

		public void method_2()
		{
			method_4();
			method_5();
		}

		public void method_3()
		{
			GClass63 gClass = new GClass63();
			gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Auto quay\nvòng quay\nvàng thường" : "Auto crack\nNORMAL\ngold spin", this, 101901, null));
			gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Auto quay\nvòng quay\nvàng s.kiện" : "Auto crack\nEvent\ngold spin", this, 101902, null));
			gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Auto quay\nvòng quay\nngọc thường" : "Auto crack\nNORMAL\ngem spin", this, 101903, null));
			gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "Auto quay\nvòng quay\nngọc s.kiện" : "Auto crack\nEvent\ngem spin", this, 101904, null));
			gClass.method_0(new GClass14((GClass192.int_0 == 0) ? "|Nhận đồ|\n\n|Xóa đồ|" : "|Receive|\n|Delete|\nItem", this, 101905, null));
			GClass39.gclass0_0.method_2(gClass, 0);
		}

		public void method_4()
		{
			if (GClass1.int_37 != 45 || (int_1 == -1 && int_0 == -1 && int_2 == -1))
				return;
			if (!bool_0 && GClass39.gclass145_0 != GClass150.gclass150_0)
			{
				if (!GClass39.gclass0_0.bool_0)
				{
					if (GClass138.smethod_18() - long_0 > 1500L)
					{
						GClass166.smethod_0().method_60(19);
						long_0 = GClass138.smethod_18();
					}
					return;
				}
				if (GClass39.gclass0_0.gclass63_0.method_2() > 1)
				{
					for (int i = 0; i < GClass39.gclass0_0.gclass63_0.method_2(); i++)
					{
						GClass14 gClass = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(i);
						if (!gClass.string_0.ToLower().StartsWith("từ chối") && !gClass.string_0.ToLower().StartsWith("refuse"))
						{
							if (!gClass.string_0.ToLower().Contains((mResources.language == 0) ? "quay ngọc\nmay mắn" : "lucky ball\nspin"))
							{
								if (int_2 == 0)
								{
									if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nvàng" : "gold\nspin"))
									{
										if (GClass138.smethod_18() - long_0 > 1000L)
										{
											GClass166.smethod_0().method_59(19, (sbyte)i);
											bool_0 = true;
											GClass198.smethod_0().method_0();
											long_0 = GClass138.smethod_18();
										}
										return;
									}
								}
								else if (int_2 == 1)
								{
									if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nvàng\nsự kiện" : "spin\ngold\nevent"))
									{
										if (GClass138.smethod_18() - long_0 > 1000L)
										{
											GClass166.smethod_0().method_59(19, (sbyte)i);
											bool_0 = true;
											GClass198.smethod_0().method_0();
											long_0 = GClass138.smethod_18();
										}
										return;
									}
								}
								else if (int_2 == 2)
								{
									if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nmay mắn" : "lucky\nspin"))
									{
										if (GClass138.smethod_18() - long_0 > 1000L)
										{
											GClass166.smethod_0().method_59(19, (sbyte)i);
											bool_0 = true;
											GClass198.smethod_0().method_0();
											long_0 = GClass138.smethod_18();
										}
										return;
									}
								}
								else if (int_2 == 3 && gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nđặc biệt\nsự kiện" : "special\nspin\nevent"))
								{
									if (GClass138.smethod_18() - long_0 > 1000L)
									{
										GClass166.smethod_0().method_59(19, (sbyte)i);
										bool_0 = true;
										GClass198.smethod_0().method_0();
										long_0 = GClass138.smethod_18();
									}
									return;
								}
								continue;
							}
							if (GClass138.smethod_18() - long_0 > 1000L)
							{
								GClass166.smethod_0().method_59(19, (sbyte)i);
								GClass198.smethod_0().method_0();
								long_0 = GClass138.smethod_18();
							}
							return;
						}
						if (GClass138.smethod_18() - long_0 > 1000L)
						{
							GClass166.smethod_0().method_59(19, (sbyte)i);
							GClass198.smethod_0().method_0();
							long_0 = GClass138.smethod_18();
						}
						return;
					}
				}
				if (GClass138.smethod_18() - long_0 > 1000L)
				{
					GClass198.smethod_0().method_0();
					long_0 = GClass138.smethod_18();
				}
			}
			if (!bool_0 || GClass39.gclass145_0 != GClass150.gclass150_0)
				return;
			try
			{
				method_8();
				int num = method_7();
				if (num < int_0)
				{
					bool_0 = false;
					int_0 = -1;
					int_1 = -1;
					int_2 = -1;
					GClass154.smethod_8().switchToMe();
				}
				else if (int_0 > 0 && GClass138.smethod_18() - long_0 > 200L)
				{
					int num2 = num / int_0 + int_3;
					if (num2 > 7)
						num2 = 7;
					GClass166.smethod_0().method_145(2, (byte)num2);
					long_0 = GClass138.smethod_18();
				}
			}
			catch
			{
			}
		}

		public void method_5()
		{
			if (GClass1.int_37 != 45 || int_4 < 0)
				return;
			if (!bool_0)
			{
				if (!GClass39.gclass0_0.bool_0)
				{
					if (GClass138.smethod_18() - long_0 > 1000L)
					{
						GClass166.smethod_0().method_60(19);
						long_0 = GClass138.smethod_18();
					}
				}
				else
				{
					if (GClass39.gclass0_0.gclass63_0.method_2() <= 1)
						return;
					for (int i = 0; i < GClass39.gclass0_0.gclass63_0.method_2(); i++)
					{
						GClass14 gClass = (GClass14)GClass39.gclass0_0.gclass63_0.method_3(i);
						if (!gClass.string_0.ToLower().StartsWith("từ chối") && !gClass.string_0.ToLower().StartsWith("refuse"))
						{
							if (!gClass.string_0.ToLower().Contains((mResources.language == 0) ? "quay ngọc\nmay mắn" : "lucky ball\nspin"))
							{
								if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "rương phụ\nđang có" : "pending list\ncontains"))
								{
									if (GClass138.smethod_18() - long_0 > 1000L)
									{
										GClass166.smethod_0().method_59(19, (sbyte)i);
										GClass198.smethod_0().method_0();
										long_0 = GClass138.smethod_18();
										bool_0 = true;
									}
									break;
								}
								continue;
							}
							if (GClass138.smethod_18() - long_0 > 1000L)
							{
								GClass166.smethod_0().method_59(19, (sbyte)i);
								GClass198.smethod_0().method_0();
								long_0 = GClass138.smethod_18();
							}
							break;
						}
						if (GClass138.smethod_18() - long_0 > 1000L)
						{
							GClass166.smethod_0().method_59(19, (sbyte)i);
							GClass198.smethod_0().method_0();
							long_0 = GClass138.smethod_18();
						}
						break;
					}
				}
				return;
			}
			for (int j = 0; j < GClass58.smethod_1().gclass121_3[0].Length; j++)
			{
				GClass121 gClass2 = GClass58.smethod_1().gclass121_3[0][j];
				for (int k = 0; k < GClass58.smethod_1().gclass121_0.Length; k++)
				{
					GClass121 gClass3 = GClass58.smethod_1().gclass121_0[k];
					if (gClass3 != null && gClass3.gclass118_0.sbyte_0 == 33 && gClass3.gclass118_0.short_0 != 956 && gClass3.gclass118_0.short_0 != 1204)
					{
						if (GClass138.smethod_18() - long_0 > 500L)
						{
							GClass166.smethod_0().method_20(0, 1, -1, gClass3.gclass118_0.short_0);
							long_0 = GClass138.smethod_18();
						}
						return;
					}
				}
				if (!GClass154.smethod_8().method_16())
				{
					if (int_4 == 0 && gClass2 != null && gClass2.gclass118_0.sbyte_0 == 33 && GClass138.smethod_18() - long_1 > 500L)
					{
						GClass166.smethod_0().method_55(0, j, 0);
						long_1 = GClass138.smethod_18();
					}
					if (int_4 != 1)
						continue;
					if (int_6 != 0 && int_5 != 0)
					{
						if (method_6(int_5, int_6) > 0)
						{
							if (gClass2 == null || gClass2.gclass118_0.sbyte_0 == 33)
								continue;
							for (int l = 0; l < gClass2.gclass20_0.Length; l++)
							{
								if (gClass2.gclass20_0[l].method_0().Contains((mResources.language == 0) ? $"HSD {int_6} ngày" : $"Expr: {int_6} days") && GClass138.smethod_18() - long_1 > 500L)
								{
									GClass166.smethod_0().method_55(1, j, 0);
									long_1 = GClass138.smethod_18();
								}
							}
							continue;
						}
						int_6 = 0;
						int_5 = 0;
						break;
					}
					int_6 = 0;
					int_5 = 0;
					break;
				}
				bool_0 = false;
				int_4 = -1;
				GClass188.smethod_1("Rương đồ đã đầy!", 1);
				break;
			}
		}

		public int method_6(int id, int expr)
		{
			int num = 0;
			for (int i = 0; i < GClass58.smethod_1().gclass121_3[0].Length; i++)
			{
				GClass121 gClass = GClass58.smethod_1().gclass121_3[0][i];
				if (gClass == null || gClass.gclass118_0.short_0 != id || gClass.gclass20_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass20_0.Length; j++)
				{
					if (gClass.gclass20_0[j].method_0().Contains((mResources.language == 0) ? $"HSD {expr}" : $"Expr: {expr}"))
						num++;
				}
			}
			return num;
		}

		public int method_7()
		{
			return (int)((int_1 == 0) ? GClass58.smethod_1().long_6 : GClass58.smethod_1().method_143());
		}

		private void method_8()
		{
			int num = 0;
			GClass121 gClass;
			while (true)
			{
				if (num < GClass58.smethod_1().gclass121_0.Length)
				{
					gClass = GClass58.smethod_1().gclass121_0[num];
					if (gClass != null && (gClass.gclass118_0.short_0 == 820 || gClass.gclass118_0.short_0 == 821))
						break;
					num++;
					continue;
				}
				return;
			}
			int_3 = gClass.int_30;
		}

		private int method_9()
		{
			method_8();
			int result = 8;
			if (8 > int_3)
				result = int_3;
			return result;
		}
	}
}
