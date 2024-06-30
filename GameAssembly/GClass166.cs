using System;
using ns1;

public class GClass166
{
	private GInterface6 ginterface6_0 = GClass162.smethod_0();

	protected static GClass166 gclass166_0;

	public static long long_0;

	public static long long_1;

	public static long long_2;

	public static long long_3;

	public int int_0;

	public static bool bool_0;

	public static GClass166 smethod_0()
	{
		if (gclass166_0 == null)
			gclass166_0 = new GClass166();
		return gclass166_0;
	}

	public void method_0(int id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)18);
			gClass.method_2().method_11(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_1()
	{
		if (GClass138.string_2 == null)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)126);
			gClass.method_2().method_16(GClass138.string_2);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_2(string day, string month, string year, string address, string cmnd, string dayCmnd, string noiCapCmnd, string sdt, string name)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)42);
			gClass.method_2().method_16(day);
			gClass.method_2().method_16(month);
			gClass.method_2().method_16(year);
			gClass.method_2().method_16(address);
			gClass.method_2().method_16(cmnd);
			gClass.method_2().method_16(dayCmnd);
			gClass.method_2().method_16(noiCapCmnd);
			gClass.method_2().method_16(sdt);
			gClass.method_2().method_16(name);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_3()
	{
		if (GClass138.string_2 == null)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)126);
			gClass.method_2().method_16(GClass138.string_2);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_4(sbyte status)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-44));
			gClass.method_2().method_2(status);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_5(sbyte action, GClass63 id)
	{
		GClass56.smethod_8("combine");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-81));
			gClass.method_2().method_2(action);
			if (action == 1)
			{
				gClass.method_2().method_3(id.method_2());
				for (int i = 0; i < id.method_2(); i++)
				{
					gClass.method_2().method_3(((GClass121)id.method_3(i)).int_29);
					GClass56.smethod_8("gui id " + ((GClass121)id.method_3(i)).int_29);
				}
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_6(sbyte action, int playerID, sbyte index, int num)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass56.smethod_11("giao dich action = " + action);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-86));
			gClass.method_2().method_2(action);
			if (action == 0 || action == 1)
			{
				GClass56.smethod_11(">>>> len playerID =" + playerID);
				gClass.method_2().method_11(playerID);
			}
			if (action == 2)
			{
				GClass56.smethod_11("gui len index =" + index + " num= " + num);
				gClass.method_2().method_2(index);
				gClass.method_2().method_11(num);
			}
			if (action == 4)
			{
				GClass56.smethod_11(">>>> len index =" + index);
				gClass.method_2().method_2(index);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_7(GClass67[] t)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8(" gui input ");
			gClass = new GClass110((sbyte)(-125));
			GClass56.smethod_8("byte lent = " + t.Length);
			gClass.method_2().method_3(t.Length);
			for (int i = 0; i < t.Length; i++)
			{
				gClass.method_2().method_16(t[i].method_21());
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_8(sbyte index)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)112);
			gClass.method_2().method_2(index);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_9(short x, short y)
	{
		GClass56.smethod_8("gui x= " + x + " y= " + y);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110(0);
			gClass.method_2().method_8(x);
			gClass.method_2().method_8(y);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_10()
	{
		GClass56.smethod_8("gui test1");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110(1);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_11()
	{
	}

	public void method_12(char ch)
	{
		GClass56.smethod_8("cap char c= " + ch);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-85));
			gClass.method_2().method_4(ch);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_13(sbyte action, int playerId)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass56.smethod_8("add friend");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-80));
			gClass.method_2().method_2(action);
			if (playerId != -1)
				gClass.method_2().method_11(playerId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_14(int index)
	{
		GClass56.smethod_8("get ngoc");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-76));
			gClass.method_2().method_3(index);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_15(int playerID)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-79));
			gClass.method_2().method_11(playerID);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_16(sbyte id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-62));
			gClass.method_2().method_2(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_17(sbyte status)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-45));
			gClass.method_2().method_2(status);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_18(int id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-54));
			gClass.method_2().method_11(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_19(int type, string text, int clanID)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-51));
			gClass.method_2().method_3(type);
			if (type == 0)
				gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			if (type == 2)
				gClass.method_2().method_11(clanID);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_20(sbyte type, sbyte where, sbyte index, short template)
	{
		bool flag = template == 1540 || template == 1565 || template == 193 || template == 194 || template == 992 || template == 726;
		if (GClass171.smethod_0().bool_0 && !flag)
			return;
		GClass5.smethod_0("USE ITEM! " + type);
		if (GClass58.smethod_1().int_11 == 14)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-43));
			gClass.method_2().method_2(type);
			gClass.method_2().method_2(where);
			gClass.method_2().method_2(index);
			if (index == -1)
				gClass.method_2().method_8(template);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_21(int id, sbyte action)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-49));
			gClass.method_2().method_11(id);
			gClass.method_2().method_2(action);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_22(int id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-50));
			gClass.method_2().method_11(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_23(string text)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-47));
			gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_24(short id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-53));
			gClass.method_2().method_8(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_25(int id, sbyte role)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-56));
			gClass.method_2().method_11(id);
			gClass.method_2().method_2(role);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_26()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-55));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_27(sbyte action, int playerID, int clanID, int code)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-57));
			gClass.method_2().method_2(action);
			if (action == 0)
				gClass.method_2().method_11(playerID);
			if (action == 1 || action == 2)
			{
				gClass.method_2().method_11(clanID);
				gClass.method_2().method_11(code);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_28(sbyte action, sbyte id, string text)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-46));
			gClass.method_2().method_2(action);
			if (action == 2 || action == 4)
			{
				gClass.method_2().method_2(id);
				gClass.method_2().method_16(text);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_29(sbyte gender)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-41));
			gClass.method_2().method_2(gender);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_30(sbyte type, sbyte id)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-40));
			gClass.method_2().method_2(type);
			gClass.method_2().method_2(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_31(int npcTemplateId, int menuId, int optionId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)40);
			gClass.method_2().method_3(npcTemplateId);
			gClass.method_2().method_3(menuId);
			if (optionId >= 0)
				gClass.method_2().method_3(optionId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public GClass110 method_32(sbyte command)
	{
		GClass110 gClass = new GClass110((sbyte)(-29));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public GClass110 method_33(sbyte command)
	{
		GClass110 gClass = new GClass110((sbyte)(-28));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public static GClass110 smethod_1(sbyte command)
	{
		GClass110 gClass = new GClass110((sbyte)(-30));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public void method_34()
	{
		if (GClass120.smethod_8("clienttype") != -1)
			Main.typeClient = GClass120.smethod_8("clienttype");
		try
		{
			GClass110 gClass = method_32(2);
			gClass.method_2().method_3(Main.typeClient);
			gClass.method_2().method_3(GClass76.int_12);
			gClass.method_2().method_13(false);
			gClass.method_2().method_11(GClass39.int_10);
			gClass.method_2().method_11(GClass39.int_11);
			gClass.method_2().method_13(GClass67.bool_4);
			gClass.method_2().method_13(GClass39.bool_5);
			gClass.method_2().method_16(GClass39.smethod_0() + "|" + GClass113.string_2);
			GClass11 gClass2 = GClass208.smethod_0("/info");
			if (gClass2 != null)
			{
				sbyte[] data = new sbyte[gClass2.gclass131_0.sbyte_0.Length];
				gClass2.method_3(ref data);
				if (data != null)
				{
					gClass.method_2().method_9(data.Length);
					gClass.method_2().method_18(data);
					GClass56.smethod_10("write " + data.Length + "|" + GClass113.string_2);
				}
			}
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_35()
	{
		GClass56.smethod_8("SET CLIENT TYPE");
		if (GClass120.smethod_8("clienttype") != -1)
			GClass138.int_0 = GClass120.smethod_8("clienttype");
		try
		{
			GClass56.smethod_8("setType");
			GClass110 gClass = method_32(2);
			gClass.method_2().method_3(GClass138.int_0);
			gClass.method_2().method_3(GClass76.int_12);
			GClass56.smethod_8("gui zoomlevel = " + GClass76.int_12);
			gClass.method_2().method_13(false);
			gClass.method_2().method_11(GClass39.int_10);
			gClass.method_2().method_11(GClass39.int_11);
			gClass.method_2().method_13(GClass67.bool_4);
			gClass.method_2().method_13(GClass39.bool_5);
			gClass.method_2().method_16(GClass39.smethod_0() + "|" + GClass113.string_2);
			GClass11 gClass2 = GClass208.smethod_0("/info");
			if (gClass2 != null)
			{
				sbyte[] data = new sbyte[gClass2.gclass131_0.sbyte_0.Length];
				gClass2.method_3(ref data);
				if (data != null)
				{
					gClass.method_2().method_9(data.Length);
					gClass.method_2().method_18(data);
					GClass56.smethod_10("write " + data.Length + "|" + GClass113.string_2);
				}
			}
			ginterface6_0 = GClass143.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}

	public void method_36()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-120));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			long_0 = GClass138.smethod_18();
			gClass.method_4();
		}
	}

	public void method_37()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-121));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			long_1 = GClass138.smethod_18();
			gClass.method_4();
		}
	}

	public void method_38(string username, string pass, string version, sbyte type)
	{
		try
		{
			GClass110 gClass = method_32(0);
			gClass.method_2().method_16(username);
			gClass.method_2().method_16(pass);
			gClass.method_2().method_16(version);
			gClass.method_2().method_2(type);
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_39(string username, string pass, string usernameAo, string passAo, string version)
	{
		try
		{
			GClass110 gClass = method_32(1);
			gClass.method_2().method_16(username);
			gClass.method_2().method_16(pass);
			if (usernameAo != null && !usernameAo.Equals(string.Empty))
			{
				gClass.method_2().method_16(usernameAo);
				gClass.method_2().method_16("a");
			}
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_40()
	{
		if (!GClass175.smethod_0().bool_1)
		{
			GClass110 gClass = new GClass110((sbyte)(-23));
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
	}

	public void method_41(sbyte type)
	{
		GClass110 gClass = new GClass110((sbyte)(-34));
		try
		{
			gClass.method_2().method_2(type);
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception)
		{
		}
	}

	public void method_42(int zoneId, int indexUI)
	{
		if (!GClass175.smethod_0().bool_2)
		{
			GClass110 gClass = new GClass110((sbyte)21);
			try
			{
				gClass.method_2().method_3(zoneId);
				ginterface6_0.sendMessage(gClass);
				gClass.method_4();
			}
			catch (Exception)
			{
			}
		}
	}

	public void method_43(int second)
	{
		GClass110 gClass = new GClass110((sbyte)(-78));
		try
		{
			gClass.method_2().method_11(second);
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception)
		{
		}
	}

	public void method_44()
	{
		int num = GClass58.smethod_1().int_4 - GClass58.smethod_1().int_101;
		int num2 = GClass58.smethod_1().int_5 - GClass58.smethod_1().int_102;
		if (GClass58.bool_33 || (num == 0 && num2 == 0) || GClass65.bool_5 || GClass58.smethod_1().bool_2 || GClass58.smethod_1().int_5 <= 0 || GClass58.smethod_1().bool_71)
			return;
		try
		{
			GClass110 gClass = new GClass110((sbyte)(-7));
			GClass58.smethod_1().int_101 = GClass58.smethod_1().int_4;
			GClass58.smethod_1().int_102 = GClass58.smethod_1().int_5;
			GClass58.smethod_1().int_103 = GClass58.smethod_1().int_12;
			GClass58.smethod_1().int_106 = GClass58.smethod_1().int_11;
			if (GClass1.smethod_25(GClass58.smethod_1().int_4 / GClass1.sbyte_0, GClass58.smethod_1().int_5 / GClass1.sbyte_0) == 0)
			{
				gClass.method_2().method_2(1);
				if (GClass58.smethod_1().bool_8)
				{
					if (!GClass58.smethod_1().bool_25)
						GClass58.smethod_1().int_24 -= GClass58.smethod_1().int_156 / 100 * ((GClass58.smethod_1().sbyte_35 != 1) ? 1 : 2);
					if (GClass58.smethod_1().int_24 < 0)
						GClass58.smethod_1().int_24 = 0;
					GClass154.smethod_8().bool_73 = true;
					GClass154.smethod_8().int_142 = 0;
				}
			}
			else
				gClass.method_2().method_2(0);
			gClass.method_2().method_9(GClass58.smethod_1().int_4);
			if (num2 != 0)
				gClass.method_2().method_9(GClass58.smethod_1().int_5);
			ginterface6_0.sendMessage(gClass);
			GClass154.int_48++;
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass5.smethod_2("LOI CHAR MOVE " + ex.ToString());
		}
	}

	public void method_45(string charname)
	{
		GClass110 gClass = new GClass110((sbyte)(-28));
		try
		{
			gClass.method_2().method_2(1);
			gClass.method_2().method_16(charname);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		ginterface6_0.sendMessage(gClass);
	}

	public void method_46(sbyte sub, int value)
	{
	}

	public void method_47(string name, int gender, int hair)
	{
		GClass110 gClass = new GClass110((sbyte)(-28));
		try
		{
			gClass.method_2().method_2(2);
			gClass.method_2().method_16(name);
			gClass.method_2().method_3(gender);
			gClass.method_2().method_3(hair);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		ginterface6_0.sendMessage(gClass);
	}

	public void method_48(int modTemplateId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)11);
			gClass.method_2().method_3(modTemplateId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_49(int npcTemplateId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(12);
			gClass.method_2().method_3(npcTemplateId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_50(int skillId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(9);
			gClass.method_2().method_9(skillId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_51(int typeUI, int indexUI)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)35);
			gClass.method_2().method_3(typeUI);
			gClass.method_2().method_3(indexUI);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_52(int charId, int indexUI)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)90);
			gClass.method_2().method_11(charId);
			gClass.method_2().method_3(indexUI);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_53(int skillTemplateId, int point)
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(17);
			gClass.method_2().method_9(skillTemplateId);
			gClass.method_2().method_3(point);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_54(sbyte action, sbyte type, short id)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)7);
			gClass.method_2().method_2(action);
			gClass.method_2().method_2(type);
			gClass.method_2().method_8(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_55(sbyte type, int id, int quantity)
	{
		if (GClass171.smethod_0().bool_0)
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)6);
			gClass.method_2().method_2(type);
			gClass.method_2().method_9(id);
			if (quantity > 1)
				gClass.method_2().method_9(quantity);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_56(int skillTemplateId)
	{
		GClass5.smethod_0(GClass58.smethod_1().string_3 + " SELECT SKILL " + skillTemplateId);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)34);
			gClass.method_2().method_9(skillTemplateId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_57(short id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-66));
			gClass.method_2().method_8(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_58()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)29);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_59(short npcID, sbyte select)
	{
		GClass56.smethod_8("confirme menu" + select);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)32);
			gClass.method_2().method_8(npcID);
			gClass.method_2().method_2(select);
			ginterface6_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_60(int npcId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)33);
			gClass.method_2().method_9(npcId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_61(int npcId, int menuId, int optionId)
	{
		GClass5.smethod_0("menuid: " + menuId);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)22);
			gClass.method_2().method_3(npcId);
			gClass.method_2().method_3(menuId);
			gClass.method_2().method_3(optionId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_62(short menuId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)27);
			gClass.method_2().method_8(menuId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_63(short menuId, string str)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)88);
			gClass.method_2().method_8(menuId);
			gClass.method_2().method_16(str);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_64(int typeUI)
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(22);
			gClass.method_2().method_3(typeUI);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_65()
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(19);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_66(int coinOut)
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(21);
			gClass.method_2().method_11(coinOut);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_67(GClass121 item, GClass121[] items, bool isGold)
	{
		GClass39.gclass100_0.method_0();
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)14);
			gClass.method_2().method_13(isGold);
			gClass.method_2().method_3(item.int_29);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
					gClass.method_2().method_3(items[i].int_29);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_68(GClass121[] items)
	{
		GClass39.gclass100_0.method_0();
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)13);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
					gClass.method_2().method_3(items[i].int_29);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_69(int playerMapId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)37);
			gClass.method_2().method_11(playerMapId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_70()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)50);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_71()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)39);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_72(int coin, GClass121[] items)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)38);
			gClass.method_2().method_11(coin);
			int num = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
					num++;
			}
			gClass.method_2().method_3(num);
			for (int j = 0; j < items.Length; j++)
			{
				if (items[j] != null)
					gClass.method_2().method_3(items[j].int_29);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_73(GClass63 vMob, GClass63 vChar, int type)
	{
		try
		{
			GClass56.smethod_8(">>SEND ATTACT  vMob=" + vMob.method_2() + "  vChar=" + vChar.method_2());
			GClass110 gClass = null;
			if (type == 0)
				return;
			if (vMob.method_2() > 0 && vChar.method_2() > 0)
			{
				if (type != 1)
				{
					if (type == 2)
						gClass = new GClass110((sbyte)67);
				}
				else
					gClass = new GClass110((sbyte)(-4));
				gClass.method_2().method_3(vMob.method_2());
				for (int i = 0; i < vMob.method_2(); i++)
				{
					GClass85 gClass2 = (GClass85)vMob.method_3(i);
					gClass.method_2().method_3(gClass2.int_25);
				}
				for (int j = 0; j < vChar.method_2(); j++)
				{
					GClass58 gClass3 = (GClass58)vChar.method_3(j);
					if (gClass3 != null)
						gClass.method_2().method_11(gClass3.int_13);
					else
						gClass.method_2().method_11(-1);
				}
			}
			else if (vMob.method_2() > 0)
			{
				gClass = new GClass110((sbyte)54);
				for (int k = 0; k < vMob.method_2(); k++)
				{
					GClass85 gClass4 = (GClass85)vMob.method_3(k);
					if (!gClass4.bool_13)
					{
						gClass.method_2().method_3(gClass4.int_25);
						continue;
					}
					gClass.method_2().method_2(-1);
					gClass.method_2().method_11(gClass4.int_25);
				}
			}
			else if (vChar.method_2() > 0)
			{
				gClass = new GClass110((sbyte)(-60));
				for (int l = 0; l < vChar.method_2(); l++)
				{
					GClass58 gClass5 = (GClass58)vChar.method_3(l);
					gClass.method_2().method_11(gClass5.int_13);
				}
			}
			gClass.method_2().method_0((sbyte)GClass58.smethod_1().int_12);
			if (gClass != null)
				ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
			GClass56.smethod_10(">>err ATTACT  vMob=" + vMob.method_2() + "  vChar=" + vChar.method_2());
		}
	}

	public void method_74(int itemMapId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-20));
			gClass.method_2().method_9(itemMapId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_75(int index)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-18));
			gClass.method_2().method_3(index);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_76()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-15));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_77()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-16));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_78(string text)
	{
		if (GClass171.smethod_0().bool_0 || GClass172.smethod_0().method_2(text))
			return;
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)44);
			gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_79()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-87));
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_80()
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(6);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_81()
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(7);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_82()
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(8);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_83()
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(13);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_84(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)36);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_85(string name)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)53);
			gClass.method_2().method_16(name);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_86(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)76);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_87(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)77);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_88(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)59);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_89(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)62);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_90(string name)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)75);
			gClass.method_2().method_16(name);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_91(sbyte action, sbyte type, int playerId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-59));
			gClass.method_2().method_2(action);
			gClass.method_2().method_2(type);
			gClass.method_2().method_11(playerId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_92(int maptemplateId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(10);
			gClass.method_2().method_3(maptemplateId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_93()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)79);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_94(GClass63 chars)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)18);
			gClass.method_2().method_3(chars.method_2());
			for (int i = 0; i < chars.method_2(); i++)
			{
				GClass58 gClass2 = (GClass58)chars.method_3(i);
				gClass.method_2().method_11(gClass2.int_13);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_95(string str)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)16);
			gClass.method_2().method_16(str);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_96(string str)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)17);
			gClass.method_2().method_16(str);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_97(string text, int id)
	{
		GClass56.smethod_8("chat player text = " + text);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-72));
			gClass.method_2().method_11(id);
			gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_98(string text)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-71));
			gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_99(string to, string text)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)91);
			gClass.method_2().method_16(to);
			gClass.method_2().method_16(GClass193.GClass194.smethod_0().bool_0 ? GClass193.GClass194.smethod_0().method_0(text) : text);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_100(string NAP, string PIN)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(16);
			gClass.method_2().method_16(NAP);
			gClass.method_2().method_16(PIN);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_101(string key, sbyte[] data)
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(60);
			gClass.method_2().method_16(key);
			gClass.method_2().method_11(data.Length);
			gClass.method_2().method_18(data);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_102(string key)
	{
		GClass5.smethod_0("REQUEST RMS");
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(61);
			gClass.method_2().method_16(key);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_103()
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(17);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_104(string name, int id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(18);
			gClass.method_2().method_11(id);
			gClass.method_2().method_16(name);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_105(int id)
	{
		GClass39.smethod_4();
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("REQUEST ICON " + id);
			gClass = new GClass110((sbyte)(-67));
			gClass.method_2().method_11(id);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_106(int index1, int index2, int index3)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(33);
			gClass.method_2().method_3(index1);
			gClass.method_2().method_3(index2);
			gClass.method_2().method_3(index3);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_107(string name)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(34);
			gClass.method_2().method_16(name);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_108(int indexItem, int numSplit)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(40);
			gClass.method_2().method_3(indexItem);
			gClass.method_2().method_11(numSplit);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_109(int pass)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(37);
			gClass.method_2().method_11(pass);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_110(int pass)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(41);
			gClass.method_2().method_11(pass);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_111(int passOld, int passNew)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(38);
			gClass.method_2().method_11(passOld);
			gClass.method_2().method_11(passNew);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_112(int pass2)
	{
		GClass110 gClass = null;
		try
		{
			gClass = method_33(39);
			gClass.method_2().method_11(pass2);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_113(short id)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-32));
			gClass.method_2().method_8(id);
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
				ginterface6_0 = GClass162.smethod_0();
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_114()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-33));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_115()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-38));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_116(int playerID)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-38));
			gClass.method_2().method_11(playerID);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_117()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-39));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_118(sbyte action)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-35));
			gClass.method_2().method_2(action);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_119(sbyte ID)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-63));
			gClass.method_2().method_2(ID);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_120(sbyte action)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-36));
			gClass.method_2().method_2(action);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_121(sbyte action)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-37));
			gClass.method_2().method_2(action);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_122(string user)
	{
		GClass56.smethod_8("Login 2");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-101));
			gClass.method_2().method_16(user);
			gClass.method_2().method_3(1);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_123(sbyte action)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-34));
			gClass.method_2().method_2(action);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_124(int typePotential, int num)
	{
		GClass110 gClass = null;
		try
		{
			gClass = smethod_1(16);
			gClass.method_2().method_3(typePotential);
			gClass.method_2().method_9(num);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_125(sbyte action, GClass63 vResourceIndex)
	{
		GClass56.smethod_8("request resource action= " + action);
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-74));
			gClass.method_2().method_2(action);
			if (action == 2 && vResourceIndex != null)
			{
				gClass.method_2().method_9(vResourceIndex.method_2());
				for (int i = 0; i < vResourceIndex.method_2(); i++)
				{
					gClass.method_2().method_8(short.Parse((string)vResourceIndex.method_3(i)));
				}
			}
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
			{
				bool_0 = true;
				ginterface6_0 = GClass162.smethod_0();
			}
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_126(int selected)
	{
		GClass56.smethod_8("request magic tree");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-91));
			gClass.method_2().method_3(selected);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_127()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-107));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_128(string topName, sbyte selected)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-96));
			gClass.method_2().method_16(topName);
			gClass.method_2().method_2(selected);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_129(sbyte b, int charID)
	{
		GClass110 gClass = null;
		GClass56.smethod_8("add enemy");
		try
		{
			gClass = new GClass110((sbyte)(-99));
			gClass.method_2().method_2(b);
			if (b == 1 || b == 2)
				gClass.method_2().method_11(charID);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_130(sbyte action, int itemId, sbyte moneyType, int money, int quaintly)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("ki gui action= " + action);
			gClass = new GClass110((sbyte)(-100));
			gClass.method_2().method_2(action);
			if (action == 0)
			{
				gClass.method_2().method_9(itemId);
				gClass.method_2().method_2(moneyType);
				gClass.method_2().method_11(money);
				gClass.method_2().method_11(quaintly);
			}
			if (action == 1 || action == 2)
				gClass.method_2().method_9(itemId);
			if (action == 3)
			{
				gClass.method_2().method_9(itemId);
				gClass.method_2().method_2(moneyType);
				gClass.method_2().method_11(money);
			}
			if (action == 4)
			{
				gClass.method_2().method_2(moneyType);
				gClass.method_2().method_3(money);
				GClass56.smethod_8("currTab= " + moneyType + " page= " + money);
			}
			if (action == 5)
				gClass.method_2().method_9(itemId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_131(sbyte action, sbyte flagType)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-103));
			gClass.method_2().method_2(action);
			GClass56.smethod_8("------------service--  " + action + "   " + flagType);
			if (action != 0)
				gClass.method_2().method_2(flagType);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_132(int pass)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("------------setLockInventory:     " + pass);
			gClass = new GClass110((sbyte)(-104));
			gClass.method_2().method_11(pass);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_133(sbyte status)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-108));
			gClass.method_2().method_2(status);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_134()
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("------------transportNow  ");
			gClass = new GClass110((sbyte)(-105));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_135(sbyte type)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("FUNSION");
			gClass = new GClass110((sbyte)125);
			gClass.method_2().method_2(type);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_136(GClass63 vID)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("IMAGE SOURCE size= " + vID.method_2());
			gClass = new GClass110((sbyte)(-111));
			gClass.method_2().method_9(vID.method_2());
			if (vID.method_2() > 0)
			{
				for (int i = 0; i < vID.method_2(); i++)
				{
					GClass56.smethod_8("gui len str " + ((Class3)vID.method_3(i)).ehhIbedujh);
					gClass.method_2().method_16(((Class3)vID.method_3(i)).ehhIbedujh);
				}
			}
			if (GClass143.smethod_0().isConnected() && !GClass143.bool_2)
				ginterface6_0 = GClass143.smethod_0();
			else
			{
				ginterface6_0 = GClass162.smethod_0();
				bool_0 = true;
			}
			ginterface6_0.sendMessage(gClass);
			ginterface6_0 = GClass162.smethod_0();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_137()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-126));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_138(sbyte action, int id, sbyte[] data)
	{
		GClass110 gClass = null;
		try
		{
			GClass56.smethod_8("SERVER DATA");
			gClass = new GClass110((sbyte)(-110));
			gClass.method_2().method_2(action);
			if (action == 1)
			{
				gClass.method_2().method_11(id);
				if (data != null)
				{
					int num = data.Length;
					gClass.method_2().method_9(num);
					gClass.method_2().method_17(ref data, 0, num);
				}
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_139(sbyte[] skill)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-113));
			for (int i = 0; i < GClass154.gclass74_1.Length; i++)
			{
				gClass.method_2().method_2(skill[i]);
			}
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_140()
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-114));
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_141(int id)
	{
		GClass56.smethod_8("GUI THACH DAU");
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-118));
			gClass.method_2().method_11(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_142(int charId)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-30));
			gClass.method_2().method_2(63);
			gClass.method_2().method_11(charId);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_143(int charId, short select)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-30));
			gClass.method_2().method_2(64);
			gClass.method_2().method_11(charId);
			gClass.method_2().method_8(select);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_144(string nameImg)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)66);
			gClass.method_2().method_16(nameImg);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_145(byte type, byte soluong)
	{
		GClass110 gClass = new GClass110((sbyte)(-127));
		try
		{
			gClass.method_2().method_3(type);
			if (soluong > 0)
				gClass.method_2().method_3(soluong);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_146(int i, int id)
	{
		GClass110 gClass = new GClass110(sbyte.MaxValue);
		try
		{
			gClass.method_2().method_3(i);
			if (id != -1)
				gClass.method_2().method_9(id);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_147(sbyte action)
	{
		GClass110 gClass = new GClass110((sbyte)24);
		try
		{
			if (action == 1)
			{
				sbyte[] array = GClass56.smethod_7();
				gClass.method_2().method_3(1);
				gClass.method_2().method_9(array.Length);
				gClass.method_2().method_18(array);
			}
			else
				gClass.method_2().method_3((GClass58.smethod_1().short_30 != -1) ? (-1) : 0);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_148()
	{
		GClass110 gClass = new GClass110((sbyte)69);
		try
		{
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_149(sbyte idTemplateSkill, sbyte dir, short x, short y)
	{
		GClass110 gClass = null;
		try
		{
			gClass = new GClass110((sbyte)(-45));
			gClass.method_2().method_0(20);
			gClass.method_2().method_0(idTemplateSkill);
			gClass.method_2().method_9(GClass58.smethod_1().int_4);
			gClass.method_2().method_9(GClass58.smethod_1().int_5);
			gClass.method_2().method_0(dir);
			gClass.method_2().method_8(x);
			gClass.method_2().method_8(y);
			ginterface6_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass5.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}
}
