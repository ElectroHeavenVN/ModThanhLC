public class GClass100
{
	public sbyte sbyte_0;

	private GClass145 gclass145_0;

	private GClass131 gclass131_0;

	public GClass100(int command)
	{
		sbyte_0 = (sbyte)command;
		gclass131_0 = new GClass131();
	}

	public GClass100()
	{
		gclass131_0 = new GClass131();
	}

	public GClass100(sbyte command)
	{
		sbyte_0 = command;
		gclass131_0 = new GClass131();
	}

	public GClass100(sbyte command, sbyte[] data)
	{
		sbyte_0 = command;
		gclass145_0 = new GClass145(data);
	}

	public sbyte[] method_0()
	{
		return gclass131_0.method_19();
	}

	public GClass145 method_1()
	{
		return gclass145_0;
	}

	public GClass131 method_2()
	{
		return gclass131_0;
	}

	public int method_3()
	{
		return gclass145_0.method_8();
	}

	public void method_4()
	{
	}
}
