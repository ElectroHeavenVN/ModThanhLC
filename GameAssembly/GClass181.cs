using AssemblyCSharp.Functions;

public class GClass181 : GInterface6
{
	public short short_0;

	public short short_1;

	public short short_2;

	public short short_3;

	public bool bool_0;

	public bool bool_1;

	public GClass45 gclass45_0;

	public GClass181(short minX, short minY, short maxX, short maxY, bool isEnter, bool isOffline, string name)
	{
		short_0 = minX;
		short_1 = minY;
		short_2 = maxX;
		short_3 = maxY;
		name = GClass50.smethod_15(name);
		bool_0 = isEnter;
		bool_1 = isOffline;
		if (((GClass20.int_37 == 21 || GClass20.int_37 == 22 || GClass20.int_37 == 23) && short_0 >= 0 && short_0 <= 24) || (((GClass20.int_37 == 0 && GClass78.smethod_1().int_14 != 0) || (GClass20.int_37 == 7 && GClass78.smethod_1().int_14 != 1) || (GClass20.int_37 == 14 && GClass78.smethod_1().int_14 != 2)) && isOffline))
			return;
		if (!GClass20.smethod_14() && GClass20.int_37 != 47)
		{
			if (!isEnter && !isOffline)
			{
				gclass45_0 = new GClass45(name, minX, minY - 24);
				gclass45_0.gclass87_0 = new GClass87(null, this, 1, this);
				gclass45_0.bool_0 = true;
				gclass45_0.bool_1 = false;
				GClass45.smethod_2(gclass45_0);
			}
			else
			{
				if (GClass20.smethod_2())
					gclass45_0 = new GClass45(name, minX, minY - 16);
				else
					gclass45_0 = new GClass45(name, minX + (maxX - minX) / 2, minY - ((minY == 0) ? (-32) : 16));
				gclass45_0.gclass87_0 = new GClass87(null, this, 2, this);
				gclass45_0.bool_0 = true;
				gclass45_0.bool_1 = false;
				GClass45.smethod_2(gclass45_0);
			}
			GClass20.gclass88_0.method_0(this);
		}
		else if (minY <= 150 || !GClass20.smethod_14())
		{
			gclass45_0 = new GClass45(name, minX + (maxX - minX) / 2, maxY - ((minX > 100) ? 24 : 48));
			gclass45_0.gclass87_0 = new GClass87(null, this, 1, this);
			gclass45_0.bool_0 = true;
			gclass45_0.bool_1 = false;
			GClass45.smethod_2(gclass45_0);
			GClass20.gclass88_0.method_0(this);
		}
	}

	public void perform(int idAction, object p)
	{
		if (idAction != 1)
		{
			if (idAction != 2)
				return;
			GClass144.smethod_8().int_96 = 0;
			if (GClass78.smethod_1().method_17() == null)
			{
				if (GClass78.smethod_1().method_18() == null)
				{
					int xEnd = (short_0 + short_2) / 2;
					int yEnd = short_3;
					GClass78.smethod_1().gclass29_0 = new GClass29(xEnd, yEnd);
					GClass78.smethod_1().int_12 = ((GClass78.smethod_1().int_4 - GClass78.smethod_1().gclass29_0.int_0 <= 0) ? 1 : (-1));
					GClass78.smethod_1().gclass87_1 = new GClass87(null, this, 2, null);
					return;
				}
				GClass7.smethod_0().method_44();
				GClass7.smethod_0().method_40();
				if (!GClass157.smethod_0().bool_1)
				{
					GClass78.bool_34 = true;
					GClass78.bool_33 = true;
					GClass73.smethod_27();
					GClass73.smethod_26();
				}
			}
			else
			{
				GClass7.smethod_0().method_44();
				GClass130.smethod_1();
				GClass7.smethod_0().method_114();
				GClass78.bool_33 = true;
			}
		}
		else
		{
			int xEnd2 = (short_0 + short_2) / 2;
			int yEnd2 = short_3;
			if (short_3 > short_1 + 24)
				yEnd2 = (short_1 + short_3) / 2;
			GClass144.smethod_8().int_96 = 0;
			GClass78.smethod_1().gclass29_0 = new GClass29(xEnd2, yEnd2);
			GClass78.smethod_1().int_12 = ((GClass78.smethod_1().int_4 - GClass78.smethod_1().gclass29_0.int_0 <= 0) ? 1 : (-1));
			GClass7.smethod_0().method_44();
		}
	}
}
