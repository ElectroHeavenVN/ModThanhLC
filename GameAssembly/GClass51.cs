public class GClass51
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6 = 1;

	public int int_7;

	public int int_8;

	public string string_0;

	public string string_1;

	public short short_0;

	public short short_1;

	public short short_2;

	public short short_3 = 1;

	public byte byte_0;

	public long long_0;

	public GClass63 gclass63_0 = new GClass63("vecInfo chientruong");

	public GClass51(int type_PB, short idmapPaint, string nameTeam1, string nameTeam2, int maxPoint, short timeSecond)
	{
		int_0 = type_PB;
		short_0 = idmapPaint;
		string_0 = nameTeam1;
		string_1 = nameTeam2;
		short_1 = timeSecond;
		long_0 = GClass39.long_0;
		int_1 = maxPoint;
		if (int_1 <= 0)
			int_1 = 1;
		int_2 = 0;
		int_3 = 0;
		byte_0 = 0;
		int_4 = 4;
		int_5 = 6;
	}

	public void method_0(int type_PB, short timeSecond)
	{
		int_0 = type_PB;
		short_1 = timeSecond;
		long_0 = GClass39.long_0;
	}

	public void method_1(int type_PB, int pointTeam1, int pointTeam2)
	{
		int_0 = type_PB;
		int_2 = pointTeam1;
		int_3 = pointTeam2;
	}

	public void method_2(int type_PB, int lifeTeam1, int lifeTeam2)
	{
		int_0 = type_PB;
		int_7 = lifeTeam1;
		int_8 = lifeTeam2;
	}
}
