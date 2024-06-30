public class GClass110
{
	public sbyte sbyte_0;

	private GClass131 gclass131_0;

	private GClass12 gclass12_0;

	public GClass110(int command)
	{
		sbyte_0 = (sbyte)command;
		gclass12_0 = new GClass12();
	}

	public GClass110()
	{
		gclass12_0 = new GClass12();
	}

	public GClass110(sbyte command)
	{
		sbyte_0 = command;
		gclass12_0 = new GClass12();
	}

	public GClass110(sbyte command, sbyte[] data)
	{
		sbyte_0 = command;
		gclass131_0 = new GClass131(data);
	}

	public sbyte[] method_0()
	{
		return gclass12_0.method_19();
	}

	public GClass131 method_1()
	{
		return gclass131_0;
	}

	public GClass12 method_2()
	{
		return gclass12_0;
	}

	public int method_3()
	{
		return gclass131_0.method_8();
	}

	public void method_4()
	{
	}
}
