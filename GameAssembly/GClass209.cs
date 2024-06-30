public class GClass209
{
	public int int_0;

	public string string_0;

	public short short_0;

	public short short_1;

	public short short_2;

	public long long_0;

	public GClass209(int playerID, string name, short head, short body, short leg, long ppoint)
	{
		int_0 = playerID;
		string_0 = name;
		short_0 = head;
		short_1 = body;
		short_2 = leg;
		long_0 = ppoint;
	}

	public string method_0()
	{
		return string_0 + "\n" + mResources.power_point + " " + long_0;
	}
}
