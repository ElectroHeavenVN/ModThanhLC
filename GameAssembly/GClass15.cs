using ns1;

public class GClass15 : GInterface1
{
	public short short_0;

	public short short_1;

	public short short_2;

	public short short_3;

	public bool bool_0;

	public bool bool_1;

	public GClass139 gclass139_0;

	public GClass15(short minX, short minY, short maxX, short maxY, bool isEnter, bool isOffline, string name)
	{
		short_0 = minX;
		short_1 = minY;
		short_2 = maxX;
		short_3 = maxY;
		name = GClass191.smethod_15(name);
		bool_0 = isEnter;
		bool_1 = isOffline;
		if (((GClass137.int_37 == 21 || GClass137.int_37 == 22 || GClass137.int_37 == 23) && short_0 >= 0 && short_0 <= 24) || (((GClass137.int_37 == 0 && GClass124.smethod_1().int_14 != 0) || (GClass137.int_37 == 7 && GClass124.smethod_1().int_14 != 1) || (GClass137.int_37 == 14 && GClass124.smethod_1().int_14 != 2)) && isOffline))
			return;
		if (GClass137.smethod_14() || GClass137.int_37 == 47)
		{
			if (minY <= 150 || !GClass137.smethod_14())
			{
				gclass139_0 = new GClass139(name, minX + (maxX - minX) / 2, maxY - ((minX <= 100) ? 48 : 24));
				gclass139_0.gclass118_0 = new GClass118(null, this, 1, this);
				gclass139_0.bool_0 = true;
				gclass139_0.bool_1 = false;
				GClass139.smethod_2(gclass139_0);
				GClass137.gclass122_0.method_0(this);
			}
			return;
		}
		if (!isEnter && !isOffline)
		{
			gclass139_0 = new GClass139(name, minX, minY - 24);
			gclass139_0.gclass118_0 = new GClass118(null, this, 1, this);
			gclass139_0.bool_0 = true;
			gclass139_0.bool_1 = false;
			GClass139.smethod_2(gclass139_0);
		}
		else
		{
			if (GClass137.smethod_2())
				gclass139_0 = new GClass139(name, minX, minY - 16);
			else
				gclass139_0 = new GClass139(name, minX + (maxX - minX) / 2, minY - ((minY != 0) ? 16 : (-32)));
			gclass139_0.gclass118_0 = new GClass118(null, this, 2, this);
			gclass139_0.bool_0 = true;
			gclass139_0.bool_1 = false;
			GClass139.smethod_2(gclass139_0);
		}
		GClass137.gclass122_0.method_0(this);
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction != 2)
				return;
			GClass167.smethod_8().int_96 = 0;
			if (GClass124.smethod_1().method_17() != null)
			{
				GClass2.smethod_0().method_44();
				GClass96.smethod_1();
				GClass2.smethod_0().method_114();
				GClass124.bool_33 = true;
				return;
			}
			if (GClass124.smethod_1().method_18() == null)
			{
				int xEnd = (short_0 + short_2) / 2;
				int yEnd = short_3;
				GClass124.smethod_1().gclass119_0 = new GClass119(xEnd, yEnd);
				GClass124.smethod_1().int_12 = ((GClass124.smethod_1().int_4 - GClass124.smethod_1().gclass119_0.int_0 <= 0) ? 1 : (-1));
				GClass124.smethod_1().gclass118_1 = new GClass118(null, this, 2, null);
				return;
			}
			GClass2.smethod_0().method_44();
			GClass2.smethod_0().method_40();
			if (!GClass61.smethod_0().bool_1)
			{
				GClass124.bool_34 = true;
				GClass124.bool_33 = true;
				GClass14.smethod_27();
				GClass14.smethod_26();
			}
		}
		else
		{
			int xEnd2 = (short_0 + short_2) / 2;
			int yEnd2 = short_3;
			if (short_3 > short_1 + 24)
				yEnd2 = (short_1 + short_3) / 2;
			GClass167.smethod_8().int_96 = 0;
			GClass124.smethod_1().gclass119_0 = new GClass119(xEnd2, yEnd2);
			GClass124.smethod_1().int_12 = ((GClass124.smethod_1().int_4 - GClass124.smethod_1().gclass119_0.int_0 <= 0) ? 1 : (-1));
			GClass2.smethod_0().method_44();
		}
	}
}
