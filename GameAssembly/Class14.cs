using System.Security.Cryptography;
using System.Text;

internal class Class14
{
	public static string smethod_0(string string_0)
	{
		using (MD5 mD = MD5.Create())
		{
			byte[] array = mD.ComputeHash(Encoding.ASCII.GetBytes(string_0));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}
	}
}
