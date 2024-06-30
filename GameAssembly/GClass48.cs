using ns1;

public class GClass48 : GInterface0
{
	public short short_0;

	public short short_1;

	public short short_2;

	public short short_3;

	public bool bool_0;

	public bool bool_1;

	public GClass24 gclass24_0;

	public GClass48(short minX, short minY, short maxX, short maxY, bool isEnter, bool isOffline, string name)
	{
		short_0 = minX;
		short_1 = minY;
		short_2 = maxX;
		short_3 = maxY;
		name = GClass56.smethod_15(name);
		bool_0 = isEnter;
		bool_1 = isOffline;
		if (((GClass1.int_37 == 21 || GClass1.int_37 == 22 || GClass1.int_37 == 23) && short_0 >= 0 && short_0 <= 24) || (((GClass1.int_37 == 0 && GClass58.smethod_1().int_14 != 0) || (GClass1.int_37 == 7 && GClass58.smethod_1().int_14 != 1) || (GClass1.int_37 == 14 && GClass58.smethod_1().int_14 != 2)) && isOffline))
			return;
		if (GClass1.smethod_14() || GClass1.int_37 == 47)
		{
			if (minY <= 150 || !GClass1.smethod_14())
			{
				gclass24_0 = new GClass24(name, minX + (maxX - minX) / 2, maxY - ((minX <= 100) ? 48 : 24));
				gclass24_0.gclass14_0 = new GClass14(null, this, 1, this);
				gclass24_0.bool_0 = true;
				gclass24_0.bool_1 = false;
				GClass24.smethod_2(gclass24_0);
				GClass1.gclass63_0.method_0(this);
			}
			return;
		}
		if (!isEnter && !isOffline)
		{
			gclass24_0 = new GClass24(name, minX, minY - 24);
			gclass24_0.gclass14_0 = new GClass14(null, this, 1, this);
			gclass24_0.bool_0 = true;
			gclass24_0.bool_1 = false;
			GClass24.smethod_2(gclass24_0);
		}
		else
		{
			if (GClass1.smethod_2())
				gclass24_0 = new GClass24(name, minX, minY - 16);
			else
				gclass24_0 = new GClass24(name, minX + (maxX - minX) / 2, minY - ((minY == 0) ? (-32) : 16));
			gclass24_0.gclass14_0 = new GClass14(null, this, 2, this);
			gclass24_0.bool_0 = true;
			gclass24_0.bool_1 = false;
			GClass24.smethod_2(gclass24_0);
		}
		GClass1.gclass63_0.method_0(this);
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction != 2)
				return;
			GClass154.smethod_8().int_95 = 0;
			if (GClass58.smethod_1().method_16() != null)
			{
				GClass166.smethod_0().method_44();
				GClass57.smethod_1();
				GClass166.smethod_0().method_114();
				GClass58.bool_33 = true;
			}
			else if (GClass58.smethod_1().method_17() != null)
			{
				GClass166.smethod_0().method_44();
				GClass166.smethod_0().method_40();
				if (!GClass175.smethod_0().bool_1)
				{
					GClass58.bool_34 = true;
					GClass58.bool_33 = true;
					GClass39.smethod_27();
					GClass39.smethod_26();
				}
			}
			else
			{
				int xEnd = (short_0 + short_2) / 2;
				int yEnd = short_3;
				GClass58.smethod_1().gclass136_0 = new GClass136(xEnd, yEnd);
				GClass58.smethod_1().int_12 = ((GClass58.smethod_1().int_4 - GClass58.smethod_1().gclass136_0.int_0 <= 0) ? 1 : (-1));
				GClass58.smethod_1().gclass14_1 = new GClass14(null, this, 2, null);
			}
		}
		else
		{
			int xEnd2 = (short_0 + short_2) / 2;
			int yEnd2 = short_3;
			if (short_3 > short_1 + 24)
				yEnd2 = (short_1 + short_3) / 2;
			GClass154.smethod_8().int_95 = 0;
			GClass58.smethod_1().gclass136_0 = new GClass136(xEnd2, yEnd2);
			GClass58.smethod_1().int_12 = ((GClass58.smethod_1().int_4 - GClass58.smethod_1().gclass136_0.int_0 <= 0) ? 1 : (-1));
			GClass166.smethod_0().method_44();
		}
	}
}
