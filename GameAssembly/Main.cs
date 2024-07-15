using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using ns1;
using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main main;

	public static GClass193 g;

	public static GClass206 midlet;

	public static string res = "res";

	public static string mainThreadName;

	public static bool started;

	public static bool isIpod;

	public static bool isIphone4;

	public static bool isPC;

	public static bool isWindowsPhone;

	public static bool isIPhone;

	public static bool IphoneVersionApp;

	public static string IMEI;

	public static int versionIp;

	public static int numberQuit = 1;

	public static int typeClient = 4;

	public const sbyte PC_VERSION = 4;

	public const sbyte IP_APPSTORE = 5;

	public const sbyte sbyte_0 = 6;

	private int int_0;

	public const sbyte IP_JB = 3;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private long long_0;

	private long long_1;

	private bool bool_0;

	public static int waitTick;

	public static int f;

	public static bool isResume;

	public static bool isMiniApp = true;

	public static bool isQuitApp;

	private Vector2 vector2_0 = default(Vector2);

	public static int a = 1;

	public static bool isCompactDevice = true;

	public static Dictionary<string, string> arguments = new Dictionary<string, string>();

	public static bool isRightClick = false;

	private void Start()
	{
		Time.timeScale = 2.5f;
		if (started)
			return;
		if (Thread.CurrentThread.Name != "Main")
			Thread.CurrentThread.Name = "Main";
		mainThreadName = Thread.CurrentThread.Name;
		isPC = true;
		started = true;
		if (isPC)
		{
			int_0 = GClass141.smethod_8("levelScreenKN");
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 1; i < commandLineArgs.Length; i += 2)
			{
				string key = commandLineArgs[i].Replace("--", "");
				arguments.Add(key, commandLineArgs[i + 1]);
			}
			Screen.SetResolution(int.Parse(arguments["size"].Split('x')[0]), int.Parse(arguments["size"].Split('x')[1]), false);
			GClass55.int_0 = int.Parse(arguments["ID"]);
			GClass50.smethod_0().method_6();
		}
	}

	private void method_0()
	{
		base.enabled = true;
	}

	private void method_1(bool bool_1)
	{
		if (!bool_1)
			Time.timeScale = 0f;
		else
			Time.timeScale = 1f;
	}

	private void OnGUI()
	{
		if (int_3 < 10)
			return;
		if (int_4 != 0)
		{
			if (GClass77.smethod_18() - long_0 > 1000L)
			{
				int_5 = int_4;
				int_4 = 0;
				long_0 = GClass77.smethod_18();
			}
		}
		else
			long_0 = GClass77.smethod_18();
		int_4++;
		method_2();
		GClass179.smethod_5();
		GClass32.smethod_5();
		if (Event.current.type.Equals(EventType.Repaint) && int_2 <= int_1)
		{
			GClass206.gclass14_0.method_20(g);
			if (!GClass14.gclass113_0.bool_0 && GClass66.smethod_0().bool_1)
			{
				string text = $"{Math.Round(1f / Time.smoothDeltaTime * Time.timeScale, 1):0.0}";
				g.method_20(0, 0.8f);
				g.method_15(0, 0, GClass104.gclass104_1.method_17(text) + 2, 12);
				GClass104.gclass104_1.method_6(g, text, 2, 0, 0);
			}
			int_2++;
			g.method_37();
			GClass50.smethod_0().method_1(g);
		}
	}

	public void setsizeChange()
	{
		if (!bool_0)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			Application.runInBackground = true;
			Application.targetFrameRate = 1000;
			base.useGUILayout = false;
			isCompactDevice = detectCompactDevice();
			if (main == null)
				main = this;
			bool_0 = true;
			GClass155.smethod_0();
			if (isPC)
				IMEI = SystemInfo.deviceUniqueIdentifier;
			else
				IMEI = GetMacAddress();
			isPC = true;
			if (isPC)
				Screen.fullScreen = false;
			if (isWindowsPhone)
				typeClient = 6;
			if (isPC)
				typeClient = 4;
			if (IphoneVersionApp)
				typeClient = 5;
			if (GClass69.genum3_0 == GEnum3.const_9)
				isIpod = true;
			if (GClass69.genum3_0 == GEnum3.const_8)
				isIphone4 = true;
			g = new GClass193();
			midlet = new GClass206();
			GClass137.smethod_0();
			GClass97.smethod_0();
			GClass139.smethod_0();
			GClass167.smethod_2();
			GClass130.smethod_0().method_0();
			GClass113.smethod_0();
			GClass116.smethod_0();
			GClass75.smethod_0();
			GClass147.smethod_1().method_0(GClass137.int_37);
			g.method_43();
		}
	}

	public static void setBackupIcloud(string path)
	{
	}

	public string GetMacAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		for (int i = 0; i < allNetworkInterfaces.Length; i++)
		{
			PhysicalAddress physicalAddress = allNetworkInterfaces[i].GetPhysicalAddress();
			if (physicalAddress.ToString() != string.Empty)
				return physicalAddress.ToString();
		}
		return string.Empty;
	}

	public void doClearRMS()
	{
		if (isPC && GClass141.smethod_8("lastZoomlevel") != GClass193.int_12)
		{
			GClass141.smethod_13();
			GClass141.smethod_9("lastZoomlevel", GClass193.int_12);
			GClass141.smethod_9("levelScreenKN", int_0);
		}
	}

	public static void closeKeyBoard()
	{
		if (GClass196.bool_1)
		{
			GClass136.gclass196_0.bool_3 = false;
			GClass136.gclass196_0 = null;
		}
	}

	private void FixedUpdate()
	{
		if (GClass66.smethod_0().bool_20)
		{
			if (GClass57.smethod_0().bool_0)
				Thread.Sleep(20);
			else
				Thread.Sleep(GClass48.smethod_0().bool_0 ? 15 : 40);
		}
		GClass141.smethod_7();
		int_3++;
		if (int_3 < 10)
			return;
		if (int_6 != 0)
		{
			if (GClass77.smethod_18() - long_1 > 1000L)
			{
				int_7 = int_6;
				int_6 = 0;
				long_1 = GClass77.smethod_18();
			}
		}
		else
			long_1 = GClass77.smethod_18();
		int_6++;
		setsizeChange();
		int_1++;
		GClass132.smethod_1();
		GClass206.gclass14_0.method_2();
		GClass20.smethod_11();
		GClass57.smethod_0().method_2();
		GClass188.smethod_0();
		GClass208.smethod_3();
		Class18.smethod_0();
		f++;
		if (f > 8)
			f = 0;
		if (!isPC)
			;
	}

	private void Update()
	{
	}

	private void method_2()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Input.mousePosition;
			GClass206.gclass14_0.method_17((int)(mousePosition.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition.y) / (float)GClass193.int_12) + GClass193.int_24);
			vector2_0.x = mousePosition.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition.y / (float)GClass193.int_12 + (float)GClass193.int_24;
			isRightClick = false;
		}
		if (Input.GetMouseButton(0))
		{
			Vector3 mousePosition2 = Input.mousePosition;
			GClass206.gclass14_0.method_16((int)(mousePosition2.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition2.y) / (float)GClass193.int_12) + GClass193.int_24);
			vector2_0.x = mousePosition2.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition2.y / (float)GClass193.int_12 + (float)GClass193.int_24;
			isRightClick = false;
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition3 = Input.mousePosition;
			vector2_0.x = mousePosition3.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition3.y / (float)GClass193.int_12 + (float)GClass193.int_24;
			GClass206.gclass14_0.method_18((int)(mousePosition3.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition3.y) / (float)GClass193.int_12) + GClass193.int_24);
			isRightClick = false;
		}
		if (Input.GetMouseButtonDown(1))
		{
			isRightClick = true;
			Vector3 mousePosition4 = Input.mousePosition;
			GClass206.gclass14_0.method_17((int)(mousePosition4.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition4.y) / (float)GClass193.int_12) + GClass193.int_24);
			vector2_0.x = mousePosition4.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition4.y / (float)GClass193.int_12 + (float)GClass193.int_24;
		}
		if (Input.GetMouseButton(1))
		{
			isRightClick = true;
			Vector3 mousePosition5 = Input.mousePosition;
			GClass206.gclass14_0.method_16((int)(mousePosition5.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition5.y) / (float)GClass193.int_12) + GClass193.int_24);
			vector2_0.x = mousePosition5.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition5.y / (float)GClass193.int_12 + (float)GClass193.int_24;
		}
		if (Input.GetMouseButtonUp(1))
		{
			isRightClick = true;
			Vector3 mousePosition6 = Input.mousePosition;
			vector2_0.x = mousePosition6.x / (float)GClass193.int_12;
			vector2_0.y = mousePosition6.y / (float)GClass193.int_12 + (float)GClass193.int_24;
			GClass206.gclass14_0.method_18((int)(mousePosition6.x / (float)GClass193.int_12), (int)(((float)Screen.height - mousePosition6.y) / (float)GClass193.int_12) + GClass193.int_24);
		}
		if (Input.anyKeyDown && Event.current.type == EventType.KeyDown)
		{
			int num = GClass35.smethod_0(Event.current.keyCode);
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				KeyCode keyCode = Event.current.keyCode;
				switch (keyCode)
				{
				default:
					switch (keyCode)
					{
					case KeyCode.LeftBracket:
						num = 123;
						break;
					case KeyCode.Backslash:
						num = 124;
						break;
					case KeyCode.RightBracket:
						num = 125;
						break;
					case KeyCode.BackQuote:
						num = 126;
						break;
					}
					break;
				case KeyCode.Quote:
					num = 34;
					break;
				case KeyCode.Comma:
					num = 60;
					break;
				case KeyCode.Minus:
					num = 95;
					break;
				case KeyCode.Period:
					num = 62;
					break;
				case KeyCode.Slash:
					num = 63;
					break;
				case KeyCode.Alpha0:
					num = 41;
					break;
				case KeyCode.Alpha1:
					num = 33;
					break;
				case KeyCode.Alpha2:
					num = 64;
					break;
				case KeyCode.Alpha3:
					num = 35;
					break;
				case KeyCode.Alpha4:
					num = 36;
					break;
				case KeyCode.Alpha5:
					num = 37;
					break;
				case KeyCode.Alpha6:
					num = 94;
					break;
				case KeyCode.Alpha7:
					num = 38;
					break;
				case KeyCode.Alpha8:
					num = 42;
					break;
				case KeyCode.Alpha9:
					num = 40;
					break;
				case KeyCode.Semicolon:
					num = 58;
					break;
				case KeyCode.Equals:
					num = 43;
					break;
				case KeyCode.LeftParen:
				case KeyCode.RightParen:
				case KeyCode.Asterisk:
				case KeyCode.Plus:
				case KeyCode.Colon:
				case KeyCode.Less:
					break;
				}
			}
			else
			{
				KeyCode keyCode2 = Event.current.keyCode;
				if (keyCode2 <= KeyCode.Slash)
				{
					if (keyCode2 != KeyCode.Quote)
					{
						if (keyCode2 != KeyCode.Comma)
						{
							if (keyCode2 == KeyCode.Slash)
								num = 47;
						}
						else
							num = 44;
					}
					else
						num = 39;
				}
				else if (keyCode2 != KeyCode.Semicolon)
				{
					if (keyCode2 != KeyCode.Equals)
					{
						switch (keyCode2)
						{
						case KeyCode.LeftBracket:
							num = 91;
							break;
						case KeyCode.Backslash:
							num = 92;
							break;
						case KeyCode.RightBracket:
							num = 93;
							break;
						case KeyCode.BackQuote:
							num = 96;
							break;
						}
					}
					else
						num = 61;
				}
				else
				{
					num = 59;
				}
			}
			if (num != 0)
				GClass206.gclass14_0.method_10(num);
		}
		if (Event.current.type == EventType.KeyUp)
		{
			int num2 = GClass35.smethod_0(Event.current.keyCode);
			if (num2 != 0)
				GClass206.gclass14_0.method_12(num2);
		}
		if (isPC)
		{
			GClass206.gclass14_0.method_15((int)(Input.GetAxis("Mouse ScrollWheel") * 10f));
			float x = Input.mousePosition.x;
			float y = Input.mousePosition.y;
			int x2 = (int)x / GClass193.int_12;
			int y2 = (Screen.height - (int)y) / GClass193.int_12;
			GClass206.gclass14_0.method_14(x2, y2);
		}
	}

	private void OnApplicationQuit()
	{
		Debug.LogWarning("APP QUIT");
		GClass14.bool_10 = false;
		GClass179.smethod_0().close();
		GClass32.smethod_0().close();
		if (isPC)
		{
			if (GClass55.smethod_0().bool_2)
				GClass55.smethod_0().method_2(new vMessage
				{
					cmd = 1,
					data = Encoding.ASCII.GetBytes(GClass55.int_0.ToString())
				});
			Application.Quit();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		isResume = false;
		if (!paused)
			isResume = true;
		else if (GClass14.smethod_3())
		{
			isQuitApp = true;
		}
		if (GClass196.bool_1)
		{
			GClass136.gclass196_0.bool_3 = false;
			GClass136.gclass196_0 = null;
		}
		if (isQuitApp)
			Application.Quit();
	}

	public static void exit()
	{
		if (!isPC)
			a = 0;
		else
			main.OnApplicationQuit();
	}

	public static bool detectCompactDevice()
	{
		if (GClass69.genum3_0 != GEnum3.const_1 && GClass69.genum3_0 != GEnum3.const_2 && GClass69.genum3_0 != GEnum3.const_4 && GClass69.genum3_0 != GEnum3.const_5)
			return true;
		return false;
	}

	public static bool checkCanSendSMS()
	{
		if (GClass69.genum3_0 != GEnum3.const_3 && GClass69.genum3_0 != GEnum3.const_8 && GClass69.genum3_0 <= GEnum3.const_9)
			return false;
		return true;
	}
}