namespace ns1
{
	public class GClass40 : GInterface1, GInterface3
	{
		public long long_0;

		public bool bool_0;

		public int int_0 = -1;

		public int int_1 = -1;

		public int int_2 = -1;

		private int int_3;

		private static GClass40 gclass40_0;

		public long long_1;

		public int int_4 = -1;

		public int int_5;

		public int int_6 = 0;

		public static GClass40 smethod_0()
		{
			return (gclass40_0 != null) ? gclass40_0 : (gclass40_0 = new GClass40());
		}

		private void method_0()
		{
			GClass107.smethod_0().string_1 = "Chat";
			GClass107.smethod_0().gclass136_0.string_7 = "chat";
			GClass107.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass107.smethod_0().gclass136_0.method_21() == null || GClass107.smethod_0().gclass136_0.method_21().Equals(string.Empty) || text.Equals(string.Empty) || text == null)
				GClass107.smethod_0().bool_0 = false;
			else if (GClass107.smethod_0().string_1.Equals((GClass62.int_0 != 0) ? "Fill ID of Item, Expr. Example:1222 5" : "Nhập ID của Item, HSD. VD:1222 5"))
			{
				string[] array = GClass107.smethod_0().gclass136_0.method_21().Split(' ');
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
			GClass107.smethod_0().string_1 = text;
			GClass107.smethod_0().gclass136_0.string_7 = mResources.CHAT;
			GClass14.gclass113_0.bool_0 = false;
			GClass107.smethod_0().method_5(smethod_0(), string.Empty);
		}

		public void perform(int idAction, object p)
		{
			if (GClass57.smethod_0().bool_0)
				return;
			switch (idAction)
			{
			case 101901:
				smethod_0().bool_0 = false;
				int_0 = 5000000;
				int_1 = 0;
				int_2 = 0;
				return;
			case 101902:
				smethod_0().bool_0 = false;
				int_0 = 5000000;
				int_1 = 0;
				int_2 = 1;
				return;
			case 101903:
				smethod_0().bool_0 = false;
				int_0 = 4;
				int_1 = 1;
				int_2 = 2;
				return;
			case 101904:
				smethod_0().bool_0 = false;
				int_0 = 4;
				int_1 = 1;
				int_2 = 3;
				return;
			case 101905:
			{
				GClass122 gClass = new GClass122();
				gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Collect\nand use\nsharp" : "Nhận mảnh\nvà sử dụng\nmảnh", this, 102001, null));
				gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Delete Expr\nItem" : "Xóa item\theo HSD", this, 102002, null));
				GClass14.gclass116_0.method_2(gClass, 0);
				return;
			}
			}
			if (idAction != 102001)
			{
				if (idAction == 102002)
					smethod_0().method_1((GClass62.int_0 != 0) ? "Fill ID of Item, Expr. Example:1222 5" : "Nhập ID của Item, HSD. VD:1222 5");
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
			GClass122 gClass = new GClass122();
			gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Auto crack\nNORMAL\ngold spin" : "Auto quay\nvòng quay\nvàng thường", this, 101901, null));
			gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Auto crack\nEvent\ngold spin" : "Auto quay\nvòng quay\nvàng s.kiện", this, 101902, null));
			gClass.method_0(new GClass118((GClass62.int_0 != 0) ? "Auto crack\nNORMAL\ngem spin" : "Auto quay\nvòng quay\nngọc thường", this, 101903, null));
			gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "Auto quay\nvòng quay\nngọc s.kiện" : "Auto crack\nEvent\ngem spin", this, 101904, null));
			gClass.method_0(new GClass118((GClass62.int_0 == 0) ? "|Nhận đồ|\n\n|Xóa đồ|" : "|Receive|\n|Delete|\nItem", this, 101905, null));
			GClass14.gclass116_0.bool_1 = true;
			GClass14.gclass116_0.method_2(gClass, 0);
		}

		public void method_4()
		{
			if (GClass137.int_37 != 45 || (int_1 == -1 && int_0 == -1 && int_2 == -1))
				return;
			if (!bool_0 && GClass14.gclass160_0 != GClass162.gclass162_0)
			{
				if (!GClass14.gclass116_0.bool_0)
				{
					if (GClass77.smethod_18() - long_0 > 1500L)
					{
						GClass2.smethod_0().method_60(19);
						long_0 = GClass77.smethod_18();
					}
					return;
				}
				if (GClass14.gclass116_0.gclass122_0.method_2() > 1)
				{
					for (int i = 0; i < GClass14.gclass116_0.gclass122_0.method_2(); i++)
					{
						GClass118 gClass = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(i);
						if (!gClass.string_0.ToLower().StartsWith("từ chối") && !gClass.string_0.ToLower().StartsWith("refuse"))
						{
							if (!gClass.string_0.ToLower().Contains((mResources.language != 0) ? "lucky ball\nspin" : "quay ngọc\nmay mắn"))
							{
								if (int_2 != 0)
								{
									if (int_2 == 1)
									{
										if (gClass.string_0.ToLower().Contains((mResources.language != 0) ? "spin\ngold\nevent" : "vòng quay\nvàng\nsự kiện"))
										{
											if (GClass77.smethod_18() - long_0 > 1000L)
											{
												GClass2.smethod_0().method_59(19, (sbyte)i);
												bool_0 = true;
												GClass53.smethod_0().method_0();
												long_0 = GClass77.smethod_18();
											}
											return;
										}
									}
									else if (int_2 != 2)
									{
										if (int_2 == 3 && gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nđặc biệt\nsự kiện" : "special\nspin\nevent"))
										{
											if (GClass77.smethod_18() - long_0 > 1000L)
											{
												GClass2.smethod_0().method_59(19, (sbyte)i);
												bool_0 = true;
												GClass53.smethod_0().method_0();
												long_0 = GClass77.smethod_18();
											}
											return;
										}
									}
									else if (gClass.string_0.ToLower().Contains((mResources.language != 0) ? "lucky\nspin" : "vòng quay\nmay mắn"))
									{
										if (GClass77.smethod_18() - long_0 > 1000L)
										{
											GClass2.smethod_0().method_59(19, (sbyte)i);
											bool_0 = true;
											GClass53.smethod_0().method_0();
											long_0 = GClass77.smethod_18();
										}
										return;
									}
								}
								else if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nvàng" : "gold\nspin"))
								{
									if (GClass77.smethod_18() - long_0 > 1000L)
									{
										GClass2.smethod_0().method_59(19, (sbyte)i);
										bool_0 = true;
										GClass53.smethod_0().method_0();
										long_0 = GClass77.smethod_18();
									}
									return;
								}
								continue;
							}
							if (GClass77.smethod_18() - long_0 > 1000L)
							{
								GClass2.smethod_0().method_59(19, (sbyte)i);
								GClass53.smethod_0().method_0();
								long_0 = GClass77.smethod_18();
							}
							return;
						}
						if (GClass77.smethod_18() - long_0 > 1000L)
						{
							GClass2.smethod_0().method_59(19, (sbyte)i);
							GClass53.smethod_0().method_0();
							long_0 = GClass77.smethod_18();
						}
						return;
					}
				}
				if (GClass77.smethod_18() - long_0 > 1000L)
				{
					GClass53.smethod_0().method_0();
					long_0 = GClass77.smethod_18();
				}
			}
			if (!bool_0 || GClass14.gclass160_0 != GClass162.gclass162_0)
				return;
			try
			{
				method_8();
				int num = method_7();
				if (num >= int_0)
				{
					if (int_0 > 0 && GClass77.smethod_18() - long_0 > 200L)
					{
						int num2 = num / int_0 + int_3;
						if (num2 > 7)
							num2 = 7;
						GClass2.smethod_0().method_145(2, (byte)num2);
						long_0 = GClass77.smethod_18();
					}
				}
				else
				{
					bool_0 = false;
					int_0 = -1;
					int_1 = -1;
					int_2 = -1;
					GClass167.smethod_8().switchToMe();
				}
			}
			catch
			{
			}
		}

		public void method_5()
		{
			if (GClass137.int_37 != 45 || int_4 < 0)
				return;
			if (GClass14.gclass113_0 != null && GClass14.gclass113_0.bool_0)
				bool_0 = true;
			if (!bool_0)
			{
				if (!GClass14.gclass116_0.bool_0)
				{
					if (GClass77.smethod_18() - long_0 > 1000L)
					{
						GClass2.smethod_0().method_60(19);
						long_0 = GClass77.smethod_18();
					}
				}
				else
				{
					if (GClass14.gclass116_0.gclass122_0.method_2() <= 1)
						return;
					for (int i = 0; i < GClass14.gclass116_0.gclass122_0.method_2(); i++)
					{
						GClass118 gClass = (GClass118)GClass14.gclass116_0.gclass122_0.method_3(i);
						if (!gClass.string_0.ToLower().StartsWith("từ chối") && !gClass.string_0.ToLower().StartsWith("refuse"))
						{
							if (!gClass.string_0.ToLower().Contains((mResources.language == 0) ? "quay ngọc\nmay mắn" : "lucky ball\nspin"))
							{
								if (gClass.string_0.ToLower().Contains((mResources.language != 0) ? "pending list\ncontains" : "rương phụ\nđang có"))
								{
									if (GClass77.smethod_18() - long_0 > 1000L)
									{
										GClass2.smethod_0().method_59(19, (sbyte)i);
										GClass53.smethod_0().method_0();
										long_0 = GClass77.smethod_18();
										bool_0 = true;
									}
									break;
								}
								continue;
							}
							if (GClass77.smethod_18() - long_0 > 1000L)
							{
								GClass2.smethod_0().method_59(19, (sbyte)i);
								GClass53.smethod_0().method_0();
								long_0 = GClass77.smethod_18();
							}
							break;
						}
						if (GClass77.smethod_18() - long_0 > 1000L)
						{
							GClass2.smethod_0().method_59(19, (sbyte)i);
							GClass53.smethod_0().method_0();
							long_0 = GClass77.smethod_18();
						}
						break;
					}
				}
				return;
			}
			for (int j = 0; j < GClass124.smethod_1().gclass0_3[0].Length; j++)
			{
				GClass0 gClass2 = GClass124.smethod_1().gclass0_3[0][j];
				for (int k = 0; k < GClass124.smethod_1().gclass0_0.Length; k++)
				{
					GClass0 gClass3 = GClass124.smethod_1().gclass0_0[k];
					if (gClass3 != null && gClass3.gclass203_0.sbyte_0 == 33 && gClass3.gclass203_0.short_0 != 956 && gClass3.gclass203_0.short_0 != 1204)
					{
						if (GClass77.smethod_18() - long_0 > 500L)
						{
							GClass2.smethod_0().method_20(0, 1, -1, gClass3.gclass203_0.short_0);
							long_0 = GClass77.smethod_18();
						}
						return;
					}
				}
				if (!GClass167.smethod_8().method_16())
				{
					if (int_4 == 0 && gClass2 != null && gClass2.gclass203_0.sbyte_0 == 33 && GClass77.smethod_18() - long_1 > 500L)
					{
						GClass2.smethod_0().method_55(0, j, 0);
						long_1 = GClass77.smethod_18();
					}
					if (int_4 == 1)
					{
						if (int_6 == 0 || int_5 == 0)
						{
							int_4 = -1;
							int_6 = 0;
							int_5 = 0;
							break;
						}
						if (method_6(int_5, int_6, "lower") <= 0)
						{
							int_4 = -1;
							int_6 = 0;
							int_5 = 0;
							break;
						}
						if (gClass2 != null && gClass2.gclass203_0.sbyte_0 != 33 && gClass2.gclass203_0.short_0 == int_5)
						{
							for (int l = 0; l < gClass2.gclass5_0.Length; l++)
							{
								if (gClass2.gclass5_0[l].gclass151_0.int_0 == 93 && int.Parse(gClass2.gclass5_0[l].method_0().Split(' ')[1]) <= int_6 && GClass77.smethod_18() - long_1 > 500L)
								{
									GClass2.smethod_0().method_55(1, j, 0);
									long_1 = GClass77.smethod_18();
								}
							}
						}
					}
					if (int_4 != 2)
						continue;
					if (int_6 != 0 && int_5 != 0)
					{
						if (method_6(int_5, int_6, "equal") > 0)
						{
							if (gClass2 == null || gClass2.gclass203_0.sbyte_0 == 33 || gClass2.gclass203_0.short_0 != int_5)
								continue;
							for (int m = 0; m < gClass2.gclass5_0.Length; m++)
							{
								if (gClass2.gclass5_0[m].gclass151_0.int_0 == 93 && int.Parse(gClass2.gclass5_0[m].method_0().Split(' ')[1]) == int_6 && GClass77.smethod_18() - long_1 > 500L)
								{
									GClass2.smethod_0().method_55(1, j, 0);
									long_1 = GClass77.smethod_18();
								}
							}
							continue;
						}
						int_4 = -1;
						int_6 = 0;
						int_5 = 0;
						break;
					}
					int_4 = -1;
					int_6 = 0;
					int_5 = 0;
					break;
				}
				bool_0 = false;
				int_4 = -1;
				GClass51.smethod_1("Rương đồ đã đầy!", 1);
				break;
			}
		}

		public int method_6(int id, int expr, string type)
		{
			int num = 0;
			for (int i = 0; i < GClass124.smethod_1().gclass0_3[0].Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_3[0][i];
				if (gClass == null || gClass.gclass203_0.short_0 != id || gClass.gclass5_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass5_0.Length; j++)
				{
					if (gClass.gclass5_0[j].gclass151_0.int_0 == 93 && ((type == "lower") ? (int.Parse(gClass.gclass5_0[j].method_0().Split(' ')[1]) <= expr) : (int.Parse(gClass.gclass5_0[j].method_0().Split(' ')[1]) == expr)))
						num++;
				}
			}
			return num;
		}

		public int method_7()
		{
			return (int)((int_1 != 0) ? GClass124.smethod_1().method_145() : GClass124.smethod_1().long_6);
		}

		private void method_8()
		{
			for (int i = 0; i < GClass124.smethod_1().gclass0_0.Length; i++)
			{
				GClass0 gClass = GClass124.smethod_1().gclass0_0[i];
				if (gClass != null && (gClass.gclass203_0.short_0 == 820 || gClass.gclass203_0.short_0 == 821))
				{
					int_3 = gClass.int_30;
					break;
				}
			}
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
