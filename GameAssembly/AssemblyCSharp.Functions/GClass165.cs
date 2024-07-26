using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using UnityEngine;

namespace AssemblyCSharp.Functions
{
	public class GClass165
	{
		public bool bool_0;

		public bool bool_1 = true;

		private static GClass165 gclass165_0;

		public static GClass165 smethod_0()
		{
			return (gclass165_0 != null) ? gclass165_0 : (gclass165_0 = new GClass165());
		}

		public void method_0()
		{
			if (GClass144.smethod_8().gclass194_0 == null || GClass30.bool_0)
				return;
			int num = (int)GClass203.smethod_18();
			Thread.Sleep(2000);
			GClass144.bool_68 = false;
			GClass144.bool_69 = false;
			string val = Convert.ToBase64String(GClass144.gclass70_44.texture2D_0.EncodeToPNG());
			string text = "";
			GClass144.gclass52_0.method_7("Đang giải mã hình ảnh, bạn chờ chút! ", 0);
			string text2 = (File.Exists("Data/QLTK/tokenCaptcha.ini") ? File.ReadAllText("Data/QLTK/tokenCaptcha.ini") : "");
			if (text2 == "")
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
					GClass144.gclass52_0.method_7("Thử lại sau 3s...", 0);
					new Thread(method_0).Start();
					return;
				}
			GClass144.gclass52_0.method_7("Capcha: " + text, 0);
			int num2 = (int)GClass203.smethod_18() - num;
			if (num2 < 5000)
				Thread.Sleep(5000 - num2);
			if (text.Length >= 4 && text.Length <= 7)
			{
				GClass194 gclass194_ = GClass144.smethod_8().gclass194_0;
				while (GClass144.smethod_8().gclass194_0 != null && GClass144.smethod_8().gclass194_0 == gclass194_)
				{
					GClass144 gClass = GClass144.smethod_8();
					gClass.string_8 = "";
					for (int i = 0; i < text.Length; i++)
					{
						gClass.string_8 += text[i];
						GClass7.smethod_0().method_12(text[i]);
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
