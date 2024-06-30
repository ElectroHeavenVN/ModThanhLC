using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using UnityEngine;

namespace ns1
{
	public class GClass186
	{
		public bool bool_0;

		public bool bool_1 = true;

		private static GClass186 gclass186_0;

		public static GClass186 smethod_0()
		{
			return (gclass186_0 != null) ? gclass186_0 : (gclass186_0 = new GClass186());
		}

		public void method_0()
		{
			if (GClass154.smethod_8().gclass85_0 == null || GClass165.bool_0)
				return;
			int num = (int)GClass138.smethod_18();
			Thread.Sleep(2000);
			GClass154.bool_67 = false;
			GClass154.bool_68 = false;
			string val = Convert.ToBase64String(GClass154.gclass2_44.texture2D_0.EncodeToPNG());
			string text = "";
			GClass154.gclass210_0.method_7("Đang giải mã hình ảnh, bạn chờ chút! ", 0);
			string text2 = (File.Exists("Data/QLTK/tokenCaptcha.ini") ? File.ReadAllText("Data/QLTK/tokenCaptcha.ini") : string.Empty);
			if (text2 == string.Empty)
			{
				bool_0 = false;
				bool_1 = true;
				return;
			}
			using (WebClient webClient = new WebClient())
				try
				{
					NameValueCollection data = new NameValueCollection { { "image", val } };
					text = Encoding.UTF8.GetString(webClient.UploadValues(text2, data));
					text = text.Replace("captcha\":\"", "~").Split('~')[1].Split('"')[0];
				}
				catch
				{
					Thread.Sleep(3000);
					GClass154.gclass210_0.method_7("Thử lại sau 3s...", 0);
					new Thread(method_0).Start();
					return;
				}
			GClass154.gclass210_0.method_7("Captcha: " + text, 0);
			int num2 = (int)GClass138.smethod_18() - num;
			if (num2 < 5000)
				Thread.Sleep(5000 - num2);
			if (text.Length >= 4 && text.Length <= 7)
			{
				GClass85 gclass85_ = GClass154.smethod_8().gclass85_0;
				while (GClass154.smethod_8().gclass85_0 != null && GClass154.smethod_8().gclass85_0 == gclass85_)
				{
					GClass154 gClass = GClass154.smethod_8();
					gClass.string_8 = "";
					for (int i = 0; i < text.Length; i++)
					{
						gClass.string_8 += text[i];
						GClass166.smethod_0().method_12(text[i]);
						Thread.Sleep(UnityEngine.Random.Range(500, 1000));
					}
					Thread.Sleep(1000);
				}
			}
			Thread.Sleep(5000);
			bool_1 = true;
		}
	}
}
