public class GClass117
{
	public short short_0;

	public sbyte sbyte_0;

	public sbyte sbyte_1;

	public string string_0;

	public string[] string_1;

	public string string_2;

	public sbyte sbyte_2;

	public short short_1;

	public short short_2;

	public bool bool_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass117(short templateID, sbyte type, sbyte gender, string name, string description, sbyte level, int strRequire, short iconID, short part, bool isUpToUp)
	{
		short_0 = templateID;
		sbyte_0 = type;
		sbyte_1 = gender;
		string_0 = name;
		string_0 = GClass50.smethod_15(string_0);
		string_2 = description;
		string_2 = GClass50.smethod_15(string_2);
		sbyte_2 = level;
		int_2 = strRequire;
		short_1 = iconID;
		short_2 = part;
		bool_0 = isUpToUp;
	}
}
