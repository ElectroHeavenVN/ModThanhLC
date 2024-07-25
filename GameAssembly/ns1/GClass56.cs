using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using UnityEngine;

namespace ns1
{
	public class GClass56
	{
		public bool bool_0;

		public bool bool_1 = true;

		private static GClass56 gclass56_0;

		public static GClass56 smethod_0()
		{
			return (gclass56_0 != null) ? gclass56_0 : (gclass56_0 = new GClass56());
		}

		public void method_0()
		{
			if (GClass167.smethod_8().gclass6_0 == null || GClass3.bool_0)
				return;
			int num = (int)GClass77.smethod_18();
			Thread.Sleep(2000);
			GClass167.bool_68 = false;
			GClass167.bool_69 = false;
			string val = Convert.ToBase64String(GClass167.gclass20_44.texture2D_0.EncodeToPNG());
			string text = "";
			GClass167.gclass130_0.method_7("Đang giải mã hình ảnh, bạn chờ chút! ", 0);
			string text2 = ((!File.Exists("Data/QLTK/tokenCaptcha.ini")) ? string.Empty : File.ReadAllText("Data/QLTK/tokenCaptcha.ini"));
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
					GClass167.gclass130_0.method_7("Thử lại sau 3s...", 0);
					new Thread(method_0).Start();
					return;
				}
			GClass167.gclass130_0.method_7("Capcha: " + text, 0);
			int num2 = (int)GClass77.smethod_18() - num;
			if (num2 < 5000)
				Thread.Sleep(5000 - num2);
			if (text.Length >= 4 && text.Length <= 7)
			{
				GClass6 gclass6_ = GClass167.smethod_8().gclass6_0;
				while (GClass167.smethod_8().gclass6_0 != null && GClass167.smethod_8().gclass6_0 == gclass6_)
				{
					GClass167 gClass = GClass167.smethod_8();
					gClass.string_8 = "";
					for (int i = 0; i < text.Length; i++)
					{
						gClass.string_8 += text[i];
						GClass2.smethod_0().method_12(text[i]);
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
