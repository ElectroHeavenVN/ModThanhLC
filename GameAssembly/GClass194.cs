using System;

public class GClass194
{
	public GClass20 gclass20_0;

	public GClass99[] gclass99_0;

	public GClass154[] gclass154_0;

	public short[] short_0;

	public short[][] short_1 = new short[16][];

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public GClass99 method_0(sbyte id)
	{
		int num = 0;
		while (true)
		{
			if (num < gclass99_0.Length)
			{
				if (gclass99_0[num].int_0 == id)
					break;
				num++;
				continue;
			}
			return null;
		}
		return gclass99_0[num];
	}

	public short[] method_1()
	{
		return short_0;
	}

	public short[] method_2(int index)
	{
		if (index >= short_1.Length)
			index = 0;
		if (short_1[index] != null)
			return short_1[index];
		return new short[1];
	}

	public void method_3(string patch)
	{
		GClass188 gClass = null;
		try
		{
			gClass = GClass79.smethod_0(patch);
		}
		catch (Exception)
		{
			return;
		}
		method_6(gClass.gclass145_0);
	}

	public void method_4(string patch)
	{
		GClass188 gClass = null;
		try
		{
			gClass = GClass79.smethod_0(patch);
		}
		catch (Exception)
		{
			return;
		}
		method_5(gClass.gclass145_0);
	}

	public void method_5(GClass145 msg)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = msg.method_2();
			GClass191.smethod_8("size IMG==========" + b);
			gclass99_0 = new GClass99[b];
			for (int i = 0; i < b; i++)
			{
				gclass99_0[i] = new GClass99();
				gclass99_0[i].int_0 = msg.method_2();
				gclass99_0[i].int_3 = msg.method_5();
				gclass99_0[i].int_4 = msg.method_5();
				gclass99_0[i].int_5 = msg.method_5();
				gclass99_0[i].int_6 = msg.method_5();
			}
			gclass154_0 = new GClass154[msg.method_6()];
			for (int j = 0; j < gclass154_0.Length; j++)
			{
				gclass154_0[j] = new GClass154();
				sbyte b2 = msg.method_2();
				gclass154_0[j].short_0 = new short[b2];
				gclass154_0[j].short_1 = new short[b2];
				gclass154_0[j].sbyte_0 = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					gclass154_0[j].short_0[k] = msg.method_6();
					gclass154_0[j].short_1[k] = msg.method_6();
					gclass154_0[j].sbyte_0[k] = msg.method_2();
					if (j == 0)
					{
						if (num > gclass154_0[j].short_0[k])
							num = gclass154_0[j].short_0[k];
						if (num2 > gclass154_0[j].short_1[k])
							num2 = gclass154_0[j].short_1[k];
						if (num3 < gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5)
							num3 = gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5;
						if (num4 < gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6)
							num4 = gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6;
						int_2 = num3 - num;
						int_3 = num4 - num2;
					}
				}
			}
			short_0 = new short[msg.method_6()];
			for (int l = 0; l < short_0.Length; l++)
			{
				short_0[l] = msg.method_6();
			}
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
			GClass191.smethod_8("1");
		}
	}

	public void method_6(GClass145 iss)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = iss.method_2();
			gclass99_0 = new GClass99[b];
			for (int i = 0; i < b; i++)
			{
				gclass99_0[i] = new GClass99();
				gclass99_0[i].int_0 = iss.method_2();
				gclass99_0[i].int_3 = iss.method_5();
				gclass99_0[i].int_4 = iss.method_5();
				gclass99_0[i].int_5 = iss.method_5();
				gclass99_0[i].int_6 = iss.method_5();
			}
			short num5 = iss.method_6();
			gclass154_0 = new GClass154[num5];
			for (int j = 0; j < num5; j++)
			{
				gclass154_0[j] = new GClass154();
				sbyte b2 = iss.method_2();
				gclass154_0[j].short_0 = new short[b2];
				gclass154_0[j].short_1 = new short[b2];
				gclass154_0[j].sbyte_0 = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					gclass154_0[j].short_0[k] = iss.method_6();
					gclass154_0[j].short_1[k] = iss.method_6();
					gclass154_0[j].sbyte_0[k] = iss.method_2();
					if (j == 0)
					{
						if (num > gclass154_0[j].short_0[k])
							num = gclass154_0[j].short_0[k];
						if (num2 > gclass154_0[j].short_1[k])
							num2 = gclass154_0[j].short_1[k];
						if (num3 < gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5)
							num3 = gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5;
						if (num4 < gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6)
							num4 = gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6;
						int_2 = num3 - num;
						int_3 = num4 - num2;
					}
				}
			}
			short num6 = 0;
			num6 = iss.method_6();
			short_0 = new short[num6];
			if (int_0 < 201)
			{
				for (int l = 0; l < num6; l++)
				{
					short_0[l] = iss.method_6();
				}
				return;
			}
			short num7 = 0;
			short[] array = new short[num6];
			int num8 = 0;
			string text = string.Empty;
			bool flag = false;
			for (int m = 0; m < num6; m++)
			{
				short num9 = iss.method_6();
				text = text + num9 + ",";
				short_0[m] = num9;
				if (num9 + 500 >= 500)
				{
					array[num8++] = num9;
					flag = true;
					continue;
				}
				num7 = (short)GClass191.smethod_28(num9 + 500);
				short_1[num7] = new short[num8];
				Array.Copy(array, 0, short_1[num7], 0, num8);
				num8 = 0;
			}
			if (flag)
			{
				for (int n = 0; n < 16; n++)
				{
					if (short_1[n] == null)
						short_1[n] = short_1[2];
				}
			}
			else
			{
				short_1[0] = new short[num8];
				Array.Copy(array, 0, short_1[num7], 0, num8);
			}
		}
		catch (Exception ex)
		{
			GClass92.smethod_2("LOI TAI readData cua EffectDAta" + ex.ToString());
		}
	}

	public void method_7(sbyte[] data)
	{
		method_6(new GClass145(data));
	}

	public void method_8(sbyte[] data, sbyte typeread)
	{
		method_10(new GClass145(data), typeread);
	}

	public void method_9(GClass193 g, int f, int x, int y, int trans, int layer)
	{
		if (gclass154_0 == null || gclass154_0.Length == 0)
			return;
		GClass154 gClass = gclass154_0[f];
		for (int i = 0; i < gClass.short_0.Length; i++)
		{
			GClass99 gClass2 = method_0(gClass.sbyte_0[i]);
			try
			{
				switch (trans)
				{
				case -1:
					g.method_23(gclass20_0, gClass2.int_3, gClass2.int_4, gClass2.int_5, gClass2.int_6, 0, x + gClass.short_0[i], y + gClass.short_1[i], 0);
					break;
				case 0:
					g.method_23(gclass20_0, gClass2.int_3, gClass2.int_4, gClass2.int_5, gClass2.int_6, 0, x + gClass.short_0[i], y + gClass.short_1[i] - ((layer < 4 && layer > 0) ? GClass14.int_58 : 0), 0);
					break;
				case 1:
					g.method_23(gclass20_0, gClass2.int_3, gClass2.int_4, gClass2.int_5, gClass2.int_6, 2, x - gClass.short_0[i], y + gClass.short_1[i] - ((layer < 4 && layer > 0) ? GClass14.int_58 : 0), GClass73.int_2);
					break;
				case 2:
					g.method_23(gclass20_0, gClass2.int_3, gClass2.int_4, gClass2.int_5, gClass2.int_6, 7, x - gClass.short_0[i], y + gClass.short_1[i] - ((layer < 4 && layer > 0) ? GClass14.int_58 : 0), GClass73.int_6);
					break;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public void method_10(GClass145 msg, sbyte typeread)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		try
		{
			sbyte b = msg.method_2();
			gclass99_0 = new GClass99[b];
			for (int i = 0; i < b; i++)
			{
				gclass99_0[i] = new GClass99();
				gclass99_0[i].int_0 = msg.method_2();
				if (typeread != 1)
				{
					gclass99_0[i].int_3 = msg.method_6();
					gclass99_0[i].int_4 = msg.method_6();
				}
				else
				{
					gclass99_0[i].int_3 = msg.method_5();
					gclass99_0[i].int_4 = msg.method_5();
				}
				gclass99_0[i].int_5 = msg.method_5();
				gclass99_0[i].int_6 = msg.method_5();
			}
			gclass154_0 = new GClass154[msg.method_6()];
			for (int j = 0; j < gclass154_0.Length; j++)
			{
				gclass154_0[j] = new GClass154();
				sbyte b2 = msg.method_2();
				gclass154_0[j].short_0 = new short[b2];
				gclass154_0[j].short_1 = new short[b2];
				gclass154_0[j].sbyte_0 = new sbyte[b2];
				for (int k = 0; k < b2; k++)
				{
					gclass154_0[j].short_0[k] = msg.method_6();
					gclass154_0[j].short_1[k] = msg.method_6();
					gclass154_0[j].sbyte_0[k] = msg.method_2();
					if (j == 0)
					{
						if (num > gclass154_0[j].short_0[k])
							num = gclass154_0[j].short_0[k];
						if (num2 > gclass154_0[j].short_1[k])
							num2 = gclass154_0[j].short_1[k];
						if (num3 < gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5)
							num3 = gclass154_0[j].short_0[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_5;
						if (num4 < gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6)
							num4 = gclass154_0[j].short_1[k] + gclass99_0[gclass154_0[j].sbyte_0[k]].int_6;
						int_2 = num3 - num;
						int_3 = num4 - num2;
					}
				}
			}
			short_0 = new short[msg.method_6()];
			for (int l = 0; l < short_0.Length; l++)
			{
				short_0[l] = msg.method_6();
			}
		}
		catch (Exception)
		{
		}
	}
}
