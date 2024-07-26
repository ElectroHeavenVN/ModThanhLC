public class GClass120
{
	public int int_0;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public GClass126 gclass126_0;

	public GClass120()
	{
	}

	public GClass120(int optionTemplateId, int param)
	{
		if (optionTemplateId == 22)
		{
			optionTemplateId = 6;
			param *= 1000;
		}
		if (optionTemplateId == 23)
		{
			optionTemplateId = 7;
			param *= 1000;
		}
		int_0 = param;
		gclass126_0 = GClass144.smethod_8().gclass126_0[optionTemplateId];
	}

	public string method_0()
	{
		return GClass65.smethod_4(gclass126_0.string_0, "#", int_0 + "");
	}

	public string method_1()
	{
		return GClass65.smethod_4(gclass126_0.string_0, "+#", "");
	}

	public string method_2()
	{
		return GClass65.smethod_4(gclass126_0.string_0, "$", "");
	}
}
