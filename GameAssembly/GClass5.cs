public class GClass5
{
	public int int_0;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public GClass151 gclass151_0;

	public GClass5()
	{
	}

	public GClass5(int optionTemplateId, int param)
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
		gclass151_0 = GClass167.smethod_8().gclass151_0[optionTemplateId];
	}

	public string method_0()
	{
		return GClass138.smethod_4(gclass151_0.string_0, "#", int_0 + string.Empty);
	}

	public string method_1()
	{
		return GClass138.smethod_4(gclass151_0.string_0, "+#", string.Empty);
	}

	public string method_2()
	{
		return GClass138.smethod_4(gclass151_0.string_0, "$", string.Empty);
	}
}
