using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using AssemblyCSharp.Functions;
using UnityEngine;

public class Main : MonoBehaviour
{
	public static Main main;

	public static GClass122 g;

	public static GClass187 midlet;

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

	public const sbyte WINDOWSPHONE = 6;

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
		if (started)
			return;
		if (Thread.CurrentThread.Name != "Main")
			Thread.CurrentThread.Name = "Main";
		mainThreadName = Thread.CurrentThread.Name;
		isPC = true;
		started = true;
		if (isPC)
		{
			int_0 = GClass1.smethod_8("levelScreenKN");
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			for (int i = 1; i < commandLineArgs.Length; i += 2)
			{
				string key = commandLineArgs[i].Replace("--", "");
				arguments.Add(key, commandLineArgs[i + 1]);
			}
			Screen.SetResolution(int.Parse(arguments["size"].Split('x')[0]), int.Parse(arguments["size"].Split('x')[1]), false);
			GClass150.int_0 = int.Parse(arguments["ID"]);
			GClass172.smethod_0().method_6();
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
		if (int_4 == 0)
			long_0 = GClass203.smethod_18();
		else if (GClass203.smethod_18() - long_0 > 1000L)
		{
			int_5 = int_4;
			int_4 = 0;
			long_0 = GClass203.smethod_18();
		}
		int_4++;
		method_2();
		GClass14.smethod_5();
		GClass85.smethod_5();
		if (Event.current.type.Equals(EventType.Repaint) && int_2 <= int_1)
		{
			GClass187.gclass73_0.method_20(g);
			if (!GClass73.gclass76_0.bool_0 && GClass167.smethod_0().bool_1)
			{
				string text = $"{Math.Round(1f / Time.smoothDeltaTime * Time.timeScale, 1):0.0}";
				g.method_20(0, 0.8f);
				g.method_15(0, 0, GClass4.gclass4_1.method_17(text) + 2, 12);
				GClass4.gclass4_1.method_6(g, text, 2, 0, 0);
			}
			int_2++;
			g.method_37();
			GClass172.smethod_0().method_1(g);
		}
	}

	public void setsizeChange()
	{
		if (!bool_0)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			Application.runInBackground = true;
			//Application.targetFrameRate = 1000;
			Application.targetFrameRate = Screen.currentResolution.refreshRate;
            base.useGUILayout = false;
			isCompactDevice = detectCompactDevice();
			if (main == null)
				main = this;
			bool_0 = true;
			GClass69.smethod_0();
			if (!isPC)
				IMEI = GetMacAddress();
			else
				IMEI = SystemInfo.deviceUniqueIdentifier;
			isPC = true;
			if (isPC)
				Screen.fullScreen = false;
			if (isWindowsPhone)
				typeClient = 6;
			if (isPC)
				typeClient = 4;
			if (IphoneVersionApp)
				typeClient = 5;
			if (GClass184.genum3_0 == GEnum3.const_9)
				isIpod = true;
			if (GClass184.genum3_0 == GEnum3.const_8)
				isIphone4 = true;
			g = new GClass122();
			midlet = new GClass187();
			GClass20.smethod_0();
			GClass192.smethod_0();
			GClass45.smethod_0();
			GClass144.smethod_2();
			GClass52.smethod_0().method_0();
			GClass76.smethod_0();
			GClass145.smethod_0();
			GClass53.smethod_0();
			GClass109.smethod_1().method_0(GClass20.int_37);
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
			if (physicalAddress.ToString() != "")
				return physicalAddress.ToString();
		}
		return "";
	}

	public void doClearRMS()
	{
		if (isPC && GClass1.smethod_8("lastZoomlevel") != GClass122.int_12)
		{
			GClass1.smethod_13();
			GClass1.smethod_9("lastZoomlevel", GClass122.int_12);
			GClass1.smethod_9("levelScreenKN", int_0);
		}
	}

	public static void closeKeyBoard()
	{
		if (GClass60.bool_1)
		{
			GClass191.gclass60_0.bool_3 = false;
			GClass191.gclass60_0 = null;
		}
	}

	private void FixedUpdate()
	{
		if (GClass167.smethod_0().bool_20)
		{
			if (GClass148.smethod_0().bool_0)
				Thread.Sleep(20);
			else
				Thread.Sleep((!GClass166.smethod_0().bool_0) ? 40 : 15);
		}
		GClass1.smethod_7();
		int_3++;
		if (int_3 >= 10)
		{
			if (int_6 == 0)
				long_1 = GClass203.smethod_18();
			else if (GClass203.smethod_18() - long_1 > 1000L)
			{
				int_7 = int_6;
				int_6 = 0;
				long_1 = GClass203.smethod_18();
			}
			int_6++;
			setsizeChange();
			int_1++;
			GClass105.smethod_1();
			GClass187.gclass73_0.method_2();
			GClass70.smethod_11();
			GClass148.smethod_0().method_2();
			GClass108.smethod_0();
			GClass61.smethod_3();
			Class4.smethod_0();
			f++;
			if (f > 8)
				f = 0;
			if (!isPC)
				;
		}
	}

	private void Update()
	{
	}

	private void method_2()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Input.mousePosition;
			GClass187.gclass73_0.method_17((int)(mousePosition.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition.y) / (float)GClass122.int_12) + GClass122.int_24);
			vector2_0.x = mousePosition.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			isRightClick = false;
		}
		if (Input.GetMouseButton(0))
		{
			Vector3 mousePosition2 = Input.mousePosition;
			GClass187.gclass73_0.method_16((int)(mousePosition2.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition2.y) / (float)GClass122.int_12) + GClass122.int_24);
			vector2_0.x = mousePosition2.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition2.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			isRightClick = false;
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector3 mousePosition3 = Input.mousePosition;
			vector2_0.x = mousePosition3.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition3.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			GClass187.gclass73_0.method_18((int)(mousePosition3.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition3.y) / (float)GClass122.int_12) + GClass122.int_24);
			isRightClick = false;
		}
		if (Input.GetMouseButtonDown(1))
		{
			isRightClick = true;
			Vector3 mousePosition4 = Input.mousePosition;
			GClass187.gclass73_0.method_17((int)(mousePosition4.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition4.y) / (float)GClass122.int_12) + GClass122.int_24);
			vector2_0.x = mousePosition4.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition4.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			if (!GClass73.gclass76_0.bool_0)
				GClass73.smethod_49();
		}
		if (Input.GetMouseButton(1))
		{
			isRightClick = true;
			Vector3 mousePosition5 = Input.mousePosition;
			GClass187.gclass73_0.method_16((int)(mousePosition5.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition5.y) / (float)GClass122.int_12) + GClass122.int_24);
			vector2_0.x = mousePosition5.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition5.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			if (!GClass73.gclass76_0.bool_0)
				GClass73.smethod_49();
		}
		if (Input.GetMouseButtonUp(1))
		{
			isRightClick = true;
			Vector3 mousePosition6 = Input.mousePosition;
			vector2_0.x = mousePosition6.x / (float)GClass122.int_12;
			vector2_0.y = mousePosition6.y / (float)GClass122.int_12 + (float)GClass122.int_24;
			GClass187.gclass73_0.method_18((int)(mousePosition6.x / (float)GClass122.int_12), (int)(((float)Screen.height - mousePosition6.y) / (float)GClass122.int_12) + GClass122.int_24);
			if (!GClass73.gclass76_0.bool_0)
				GClass73.smethod_49();
		}
		if (Input.anyKeyDown && Event.current.type == EventType.KeyDown)
		{
			int num = GClass32.smethod_0(Event.current.keyCode);
			if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && !string.IsNullOrEmpty(GUIUtility.systemCopyBuffer))
			{
				if (Input.GetKeyDown(KeyCode.V))
				{
					string systemCopyBuffer = GUIUtility.systemCopyBuffer;
					if (GClass91.smethod_0().gclass191_0 != null)
						GClass91.smethod_0().gclass191_0.method_23(systemCopyBuffer);
					if (GClass73.gclass76_0.gclass91_0 != null)
						GClass73.gclass76_0.gclass91_0.gclass191_0.method_23(systemCopyBuffer);
				}
				return;
			}
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                KeyCode keyCode2 = Event.current.keyCode;
                switch (keyCode2)
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
                KeyCode keyCode = Event.current.keyCode;
                if (keyCode <= KeyCode.Slash)
                {
                    if (keyCode != KeyCode.Quote)
                    {
                        if (keyCode != KeyCode.Comma)
                        {
                            if (keyCode == KeyCode.Slash)
                                num = 47;
                        }
                        else
                            num = 44;
                    }
                    else
                        num = 39;
                }
                else if (keyCode != KeyCode.Semicolon)
                {
                    if (keyCode != KeyCode.Equals)
                    {
                        switch (keyCode)
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
				GClass187.gclass73_0.method_10(num);
		}
		if (Event.current.type == EventType.KeyUp)
		{
			int num2 = GClass32.smethod_0(Event.current.keyCode);
			if (num2 != 0)
				GClass187.gclass73_0.method_12(num2);
		}
		if (isPC)
		{
			GClass187.gclass73_0.method_15((int)(Input.GetAxis("Mouse ScrollWheel") * 10f));
			float x = Input.mousePosition.x;
			float y = Input.mousePosition.y;
			int x2 = (int)x / GClass122.int_12;
			int y2 = (Screen.height - (int)y) / GClass122.int_12;
			GClass187.gclass73_0.method_14(x2, y2);
		}
	}

	private void OnApplicationQuit()
	{
		Debug.LogWarning("APP QUIT");
		GClass73.bool_10 = false;
		GClass14.smethod_0().close();
		GClass85.smethod_0().close();
		if (isPC)
		{
			if (GClass150.smethod_0().bool_2)
				GClass150.smethod_0().method_2(new vMessage
				{
					cmd = 1,
					data = Encoding.ASCII.GetBytes(GClass150.int_0.ToString())
				});
			Application.Quit();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		isResume = false;
		if (!paused)
			isResume = true;
		else if (GClass73.smethod_3())
		{
			isQuitApp = true;
		}
		if (GClass60.bool_1)
		{
			GClass191.gclass60_0.bool_3 = false;
			GClass191.gclass60_0 = null;
		}
		if (isQuitApp)
			Application.Quit();
	}

	public static void exit()
	{
		if (isPC)
			main.OnApplicationQuit();
		else
			a = 0;
	}

	public static bool detectCompactDevice()
	{
		if (GClass184.genum3_0 != GEnum3.const_1 && GClass184.genum3_0 != GEnum3.const_2 && GClass184.genum3_0 != GEnum3.const_4 && GClass184.genum3_0 != GEnum3.const_5)
			return true;
		return false;
	}

	public static bool checkCanSendSMS()
	{
		if (GClass184.genum3_0 == GEnum3.const_3 || GClass184.genum3_0 == GEnum3.const_8 || GClass184.genum3_0 > GEnum3.const_9)
			return true;
		return false;
	}
}
