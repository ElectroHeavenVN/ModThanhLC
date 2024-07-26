using System.Security.Cryptography;
using System.Text;

namespace License
{
	internal class HashGenerator
	{
		public static string GenerateMD5(string input)
		{
			using (MD5 mD = MD5.Create())
			{
				byte[] array = mD.ComputeHash(Encoding.ASCII.GetBytes(input));
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				return stringBuilder.ToString();
			}
		}
	}
}
