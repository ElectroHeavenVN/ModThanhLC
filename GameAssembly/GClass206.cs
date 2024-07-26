public class GClass206
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public float float_0;

	public float float_1;

	public float float_2;

	public float float_3;

	public GClass206(int x1, int y1, int x2, int y2, int cl)
	{
		int_0 = x1;
		int_2 = y1;
		int_1 = x2;
		int_3 = y2;
		method_0(cl);
	}

	public void method_0(int rgb)
	{
		int num = rgb & 0xFF;
		int num2 = (rgb >> 8) & 0xFF;
		int num3 = (rgb >> 16) & 0xFF;
		float_1 = (float)num / 256f;
		float_2 = (float)num2 / 256f;
		float_0 = (float)num3 / 256f;
		float_3 = 255f;
	}
}
