public class GClass208
{
	public sbyte sbyte_0;

	private GClass100 gclass100_0;

	private GClass185 gclass185_0;

	public GClass208(int command)
	{
		sbyte_0 = (sbyte)command;
		gclass185_0 = new GClass185();
	}

	public GClass208()
	{
		gclass185_0 = new GClass185();
	}

	public GClass208(sbyte command)
	{
		sbyte_0 = command;
		gclass185_0 = new GClass185();
	}

	public GClass208(sbyte command, sbyte[] data)
	{
		sbyte_0 = command;
		gclass100_0 = new GClass100(data);
	}

	public sbyte[] method_0()
	{
		return gclass185_0.method_19();
	}

	public GClass100 method_1()
	{
		return gclass100_0;
	}

	public GClass185 method_2()
	{
		return gclass185_0;
	}

	public int method_3()
	{
		return gclass100_0.method_8();
	}

	public void method_4()
	{
	}
}
