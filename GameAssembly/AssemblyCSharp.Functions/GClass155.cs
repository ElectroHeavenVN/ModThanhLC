namespace AssemblyCSharp.Functions
{
	public class GClass155 : GInterface4, GInterface6
	{
		public long long_0;

		public bool bool_0;

		public int int_0 = -1;

		public int int_1 = -1;

		public int int_2 = -1;

		private int int_3;

		private static GClass155 gclass155_0;

		public long long_1;

		public int int_4 = -1;

		public int int_5;

		public int int_6 = 0;

		public static GClass155 smethod_0()
		{
			return (gclass155_0 != null) ? gclass155_0 : (gclass155_0 = new GClass155());
		}

		private void method_0()
		{
			GClass91.smethod_0().string_1 = "Chat";
			GClass91.smethod_0().gclass191_0.string_7 = "chat";
			GClass91.smethod_0().bool_0 = false;
		}

		public void onCancelChat()
		{
		}

		public void onChatFromMe(string text, string to)
		{
			if (GClass91.smethod_0().gclass191_0.method_21() != null && !GClass91.smethod_0().gclass191_0.method_21().Equals("") && !text.Equals("") && text != null)
			{
				if (GClass91.smethod_0().string_1.Equals((GClass151.int_0 != 0) ? "Fill ID of Item, Expr. Example:1222 5" : "Nhập ID của Item, HSD. VD:1222 5"))
				{
					string[] array = GClass91.smethod_0().gclass191_0.method_21().Split(' ');
					int_4 = 1;
					int_5 = int.Parse(array[0]);
					int_6 = int.Parse(array[1]);
					bool_0 = false;
					method_0();
				}
			}
			else
				GClass91.smethod_0().bool_0 = false;
			method_0();
		}

		public void method_1(string text)
		{
			GClass91.smethod_0().string_1 = text;
			GClass91.smethod_0().gclass191_0.string_7 = mResources.CHAT;
			GClass73.gclass76_0.bool_0 = false;
			GClass91.smethod_0().method_5(smethod_0(), "");
		}

		public void perform(int idAction, object p)
		{
			if (GClass148.smethod_0().bool_0 || GClass159.smethod_0().bool_18)
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
				GClass88 gClass = new GClass88();
				gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Nhận mảnh\nvà sử dụng\nmảnh" : "Collect\nand use\nsharp", this, 102001, null));
				gClass.method_0(new GClass87((GClass151.int_0 != 0) ? "Delete Expr\nItem" : "Xóa item\theo HSD", this, 102002, null));
				GClass73.gclass145_0.method_2(gClass, 0);
				return;
			}
			}
			if (idAction != 102001)
			{
				if (idAction == 102002)
					smethod_0().method_1((GClass151.int_0 == 0) ? "Nhập ID của Item, HSD. VD:1222 5" : "Fill ID of Item, Expr. Example:1222 5");
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
			GClass88 gClass = new GClass88();
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Auto quay\nvòng quay\nvàng thường" : "Auto crack\nNORMAL\ngold spin", this, 101901, null));
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Auto quay\nvòng quay\nvàng s.kiện" : "Auto crack\nEvent\ngold spin", this, 101902, null));
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Auto quay\nvòng quay\nngọc thường" : "Auto crack\nNORMAL\ngem spin", this, 101903, null));
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "Auto quay\nvòng quay\nngọc s.kiện" : "Auto crack\nEvent\ngem spin", this, 101904, null));
			gClass.method_0(new GClass87((GClass151.int_0 == 0) ? "|Nhận đồ|\n\n|Xóa đồ|" : "|Receive|\n|Delete|\nItem", this, 101905, null));
			GClass73.gclass145_0.bool_1 = true;
			GClass73.gclass145_0.method_2(gClass, 0);
		}

		public void method_4()
		{
			if (GClass20.int_37 != 45 || (int_1 == -1 && int_0 == -1 && int_2 == -1))
				return;
			if (!bool_0 && GClass73.gclass131_0 != GClass141.gclass141_0)
			{
				if (!GClass73.gclass145_0.bool_0)
				{
					if (GClass203.smethod_18() - long_0 > 1500L)
					{
						GClass7.smethod_0().method_60(19);
						long_0 = GClass203.smethod_18();
					}
					return;
				}
				if (GClass73.gclass145_0.gclass88_0.method_2() > 1)
				{
					for (int i = 0; i < GClass73.gclass145_0.gclass88_0.method_2(); i++)
					{
						GClass87 gClass = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(i);
						if (!gClass.string_0.ToLower().StartsWith("từ chối") && !gClass.string_0.ToLower().StartsWith("refuse"))
						{
							if (!gClass.string_0.ToLower().Contains((mResources.language != 0) ? "lucky ball\nspin" : "quay ngọc\nmay mắn"))
							{
								if (int_2 != 0)
								{
									if (int_2 != 1)
									{
										if (int_2 != 2)
										{
											if (int_2 == 3 && gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nđặc biệt\nsự kiện" : "special\nspin\nevent"))
											{
												if (GClass203.smethod_18() - long_0 > 1000L)
												{
													GClass7.smethod_0().method_59(19, (sbyte)i);
													bool_0 = true;
													GClass162.smethod_0().method_0();
													long_0 = GClass203.smethod_18();
												}
												return;
											}
										}
										else if (gClass.string_0.ToLower().Contains((mResources.language != 0) ? "lucky\nspin" : "vòng quay\nmay mắn"))
										{
											if (GClass203.smethod_18() - long_0 > 1000L)
											{
												GClass7.smethod_0().method_59(19, (sbyte)i);
												bool_0 = true;
												GClass162.smethod_0().method_0();
												long_0 = GClass203.smethod_18();
											}
											return;
										}
									}
									else if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nvàng\nsự kiện" : "spin\ngold\nevent"))
									{
										if (GClass203.smethod_18() - long_0 > 1000L)
										{
											GClass7.smethod_0().method_59(19, (sbyte)i);
											bool_0 = true;
											GClass162.smethod_0().method_0();
											long_0 = GClass203.smethod_18();
										}
										return;
									}
								}
								else if (gClass.string_0.ToLower().Contains((mResources.language == 0) ? "vòng quay\nvàng" : "gold\nspin"))
								{
									if (GClass203.smethod_18() - long_0 > 1000L)
									{
										GClass7.smethod_0().method_59(19, (sbyte)i);
										bool_0 = true;
										GClass162.smethod_0().method_0();
										long_0 = GClass203.smethod_18();
									}
									return;
								}
								continue;
							}
							if (GClass203.smethod_18() - long_0 > 1000L)
							{
								GClass7.smethod_0().method_59(19, (sbyte)i);
								GClass162.smethod_0().method_0();
								long_0 = GClass203.smethod_18();
							}
							return;
						}
						if (GClass203.smethod_18() - long_0 > 1000L)
						{
							GClass7.smethod_0().method_59(19, (sbyte)i);
							GClass162.smethod_0().method_0();
							long_0 = GClass203.smethod_18();
						}
						return;
					}
				}
				if (GClass203.smethod_18() - long_0 > 1000L)
				{
					GClass162.smethod_0().method_0();
					long_0 = GClass203.smethod_18();
				}
			}
			if (!bool_0 || GClass73.gclass131_0 != GClass141.gclass141_0)
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
					GClass144.smethod_8().switchToMe();
				}
				else if (int_0 > 0 && GClass203.smethod_18() - long_0 > 200L)
				{
					int num2 = num / int_0 + int_3;
					if (num2 > 7)
						num2 = 7;
					GClass7.smethod_0().method_145(2, (byte)num2);
					long_0 = GClass203.smethod_18();
				}
			}
			catch
			{
			}
		}

		public void method_5()
		{
			if (GClass20.int_37 != 45 || int_4 < 0)
				return;
			if (GClass73.gclass76_0 != null && GClass73.gclass76_0.bool_0)
				bool_0 = true;
			if (bool_0)
			{
				for (int i = 0; i < GClass78.smethod_1().gclass128_3[0].Length; i++)
				{
					GClass128 gClass = GClass78.smethod_1().gclass128_3[0][i];
					for (int j = 0; j < GClass78.smethod_1().gclass128_0.Length; j++)
					{
						GClass128 gClass2 = GClass78.smethod_1().gclass128_0[j];
						if (gClass2 != null && gClass2.gclass117_0.sbyte_0 == 33 && gClass2.gclass117_0.short_0 != 956 && gClass2.gclass117_0.short_0 != 1204)
						{
							if (GClass203.smethod_18() - long_0 > 500L)
							{
								GClass7.smethod_0().method_20(0, 1, -1, gClass2.gclass117_0.short_0);
								long_0 = GClass203.smethod_18();
							}
							return;
						}
					}
					if (!GClass144.smethod_8().method_16())
					{
						if (int_4 == 0 && gClass != null && gClass.gclass117_0.sbyte_0 == 33 && GClass203.smethod_18() - long_1 > 500L)
						{
							GClass7.smethod_0().method_55(0, i, 0);
							long_1 = GClass203.smethod_18();
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
							if (gClass != null && gClass.gclass117_0.sbyte_0 != 33 && gClass.gclass117_0.short_0 == int_5)
							{
								for (int k = 0; k < gClass.gclass120_0.Length; k++)
								{
									if (gClass.gclass120_0[k].gclass126_0.int_0 == 93 && int.Parse(gClass.gclass120_0[k].method_0().Split(' ')[1]) <= int_6 && GClass203.smethod_18() - long_1 > 500L)
									{
										GClass7.smethod_0().method_55(1, i, 0);
										long_1 = GClass203.smethod_18();
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
								if (gClass == null || gClass.gclass117_0.sbyte_0 == 33 || gClass.gclass117_0.short_0 != int_5)
									continue;
								for (int l = 0; l < gClass.gclass120_0.Length; l++)
								{
									if (gClass.gclass120_0[l].gclass126_0.int_0 == 93 && int.Parse(gClass.gclass120_0[l].method_0().Split(' ')[1]) == int_6 && GClass203.smethod_18() - long_1 > 500L)
									{
										GClass7.smethod_0().method_55(1, i, 0);
										long_1 = GClass203.smethod_18();
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
					GClass149.smethod_1("Rương đồ đã đầy!", 1);
					break;
				}
			}
			else if (GClass73.gclass145_0.bool_0)
			{
				if (GClass73.gclass145_0.gclass88_0.method_2() <= 1)
					return;
				for (int m = 0; m < GClass73.gclass145_0.gclass88_0.method_2(); m++)
				{
					GClass87 gClass3 = (GClass87)GClass73.gclass145_0.gclass88_0.method_3(m);
					if (!gClass3.string_0.ToLower().StartsWith("từ chối") && !gClass3.string_0.ToLower().StartsWith("refuse"))
					{
						if (!gClass3.string_0.ToLower().Contains((mResources.language != 0) ? "lucky ball\nspin" : "quay ngọc\nmay mắn"))
						{
							if (gClass3.string_0.ToLower().Contains((mResources.language != 0) ? "pending list\ncontains" : "rương phụ\nđang có"))
							{
								if (GClass203.smethod_18() - long_0 > 1000L)
								{
									GClass7.smethod_0().method_59(19, (sbyte)m);
									GClass162.smethod_0().method_0();
									long_0 = GClass203.smethod_18();
									bool_0 = true;
								}
								break;
							}
							continue;
						}
						if (GClass203.smethod_18() - long_0 > 1000L)
						{
							GClass7.smethod_0().method_59(19, (sbyte)m);
							GClass162.smethod_0().method_0();
							long_0 = GClass203.smethod_18();
						}
						break;
					}
					if (GClass203.smethod_18() - long_0 > 1000L)
					{
						GClass7.smethod_0().method_59(19, (sbyte)m);
						GClass162.smethod_0().method_0();
						long_0 = GClass203.smethod_18();
					}
					break;
				}
			}
			else if (GClass203.smethod_18() - long_0 > 1000L)
			{
				GClass7.smethod_0().method_60(19);
				long_0 = GClass203.smethod_18();
			}
		}

		public int method_6(int id, int expr, string type)
		{
			int num = 0;
			for (int i = 0; i < GClass78.smethod_1().gclass128_3[0].Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_3[0][i];
				if (gClass == null || gClass.gclass117_0.short_0 != id || gClass.gclass120_0 == null)
					continue;
				for (int j = 0; j < gClass.gclass120_0.Length; j++)
				{
					if (gClass.gclass120_0[j].gclass126_0.int_0 == 93 && ((type == "lower") ? (int.Parse(gClass.gclass120_0[j].method_0().Split(' ')[1]) <= expr) : (int.Parse(gClass.gclass120_0[j].method_0().Split(' ')[1]) == expr)))
						num++;
				}
			}
			return num;
		}

		public int method_7()
		{
			return (int)((int_1 == 0) ? GClass78.smethod_1().long_6 : GClass78.smethod_1().method_145());
		}

		private void method_8()
		{
			for (int i = 0; i < GClass78.smethod_1().gclass128_0.Length; i++)
			{
				GClass128 gClass = GClass78.smethod_1().gclass128_0[i];
				if (gClass != null && (gClass.gclass117_0.short_0 == 820 || gClass.gclass117_0.short_0 == 821))
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
