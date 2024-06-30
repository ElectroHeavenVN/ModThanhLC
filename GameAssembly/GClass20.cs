public class GClass20
{
	public int int_0;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public GClass114 gclass114_0;

	public GClass20()
	{
	}

	public GClass20(int optionTemplateId, int param)
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
		gclass114_0 = GClass154.smethod_8().gclass114_0[optionTemplateId];
	}

	public string method_0()
	{
		return GClass95.smethod_4(gclass114_0.string_0, "#", int_0 + string.Empty);
	}

	public string method_1()
	{
		return GClass95.smethod_4(gclass114_0.string_0, "+#", string.Empty);
	}

	public string method_2()
	{
		return GClass95.smethod_4(gclass114_0.string_0, "$", string.Empty);
	}
}
