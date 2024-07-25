using System;
using ns1;

public class GClass2
{
	private GInterface2 ginterface2_0 = GClass179.smethod_0();

	protected static GClass2 gclass2_0;

	public static long long_0;

	public static long long_1;

	public static long long_2;

	public static long long_3;

	public int int_0;

	public static bool bool_0;

	public static GClass2 smethod_0()
	{
		if (gclass2_0 == null)
			gclass2_0 = new GClass2();
		return gclass2_0;
	}

	public void method_0(int id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)18);
			gClass.method_2().method_11(id);
			ginterface2_0.sendMessage(gClass);
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
		if (GClass77.string_2 == null)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)126);
			gClass.method_2().method_16(GClass77.string_2);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)42);
			gClass.method_2().method_16(day);
			gClass.method_2().method_16(month);
			gClass.method_2().method_16(year);
			gClass.method_2().method_16(address);
			gClass.method_2().method_16(cmnd);
			gClass.method_2().method_16(dayCmnd);
			gClass.method_2().method_16(noiCapCmnd);
			gClass.method_2().method_16(sdt);
			gClass.method_2().method_16(name);
			ginterface2_0.sendMessage(gClass);
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
		if (GClass77.string_2 == null)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)126);
			gClass.method_2().method_16(GClass77.string_2);
			if (GClass32.smethod_0().isConnected() && !GClass32.bool_2)
				ginterface2_0 = GClass32.smethod_0();
			else
				ginterface2_0 = GClass179.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-44));
			gClass.method_2().method_2(status);
			ginterface2_0.sendMessage(gClass);
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

	public void method_5(sbyte action, GClass122 id)
	{
		GClass191.smethod_8("combine");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-81));
			gClass.method_2().method_2(action);
			if (action == 1)
			{
				gClass.method_2().method_3(id.method_2());
				for (int i = 0; i < id.method_2(); i++)
				{
					gClass.method_2().method_3(((GClass0)id.method_3(i)).int_29);
					GClass191.smethod_8("gui id " + ((GClass0)id.method_3(i)).int_29);
				}
			}
			ginterface2_0.sendMessage(gClass);
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
		if (GClass57.smethod_0().bool_0)
			return;
		GClass191.smethod_11("giao dich action = " + action);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-86));
			gClass.method_2().method_2(action);
			if (action == 0 || action == 1)
			{
				GClass191.smethod_11(">>>> len playerID =" + playerID);
				gClass.method_2().method_11(playerID);
			}
			if (action == 2)
			{
				GClass191.smethod_11("gui len index =" + index + " num= " + num);
				gClass.method_2().method_2(index);
				gClass.method_2().method_11(num);
			}
			if (action == 4)
			{
				GClass191.smethod_11(">>>> len index =" + index);
				gClass.method_2().method_2(index);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_7(GClass136[] t)
	{
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8(" gui input ");
			gClass = new GClass100((sbyte)(-125));
			GClass191.smethod_8("byte lent = " + t.Length);
			gClass.method_2().method_3(t.Length);
			for (int i = 0; i < t.Length; i++)
			{
				gClass.method_2().method_16(t[i].method_21());
			}
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)112);
			gClass.method_2().method_2(index);
			ginterface2_0.sendMessage(gClass);
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
		GClass191.smethod_8("gui x= " + x + " y= " + y);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100(0);
			gClass.method_2().method_8(x);
			gClass.method_2().method_8(y);
			ginterface2_0.sendMessage(gClass);
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
		GClass191.smethod_8("gui test1");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100(1);
			ginterface2_0.sendMessage(gClass);
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
		GClass191.smethod_8("cap char c= " + ch);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-85));
			gClass.method_2().method_4(ch);
			ginterface2_0.sendMessage(gClass);
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
		if (GClass57.smethod_0().bool_0)
			return;
		GClass191.smethod_8("add friend");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-80));
			gClass.method_2().method_2(action);
			if (playerId != -1)
				gClass.method_2().method_11(playerId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_14(int index)
	{
		GClass191.smethod_8("get ngoc");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-76));
			gClass.method_2().method_3(index);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_15(int playerID)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-79));
			gClass.method_2().method_11(playerID);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-62));
			gClass.method_2().method_2(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_17(sbyte status)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-45));
			gClass.method_2().method_2(status);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_18(int id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-54));
			gClass.method_2().method_11(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_19(int type, string text, int clanID)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-51));
			gClass.method_2().method_3(type);
			if (type == 0)
				gClass.method_2().method_16(text);
			if (type == 2)
				gClass.method_2().method_11(clanID);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_20(sbyte type, sbyte where, sbyte index, short template)
	{
		bool flag = template == 1540 || template == 1565 || template == 193 || template == 194 || template == 992 || template == 726;
		if (GClass57.smethod_0().bool_0 && !flag)
			return;
		GClass92.smethod_0("USE ITEM! " + type);
		if (GClass124.smethod_1().int_11 == 14)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-43));
			gClass.method_2().method_2(type);
			gClass.method_2().method_2(where);
			gClass.method_2().method_2(index);
			if (index == -1)
				gClass.method_2().method_8(template);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-49));
			gClass.method_2().method_11(id);
			gClass.method_2().method_2(action);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_22(int id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-50));
			gClass.method_2().method_11(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_23(string text)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-47));
			gClass.method_2().method_16(text);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_24(short id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-53));
			gClass.method_2().method_8(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_25(int id, sbyte role)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-56));
			gClass.method_2().method_11(id);
			gClass.method_2().method_2(role);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_26()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-55));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_27(sbyte action, int playerID, int clanID, int code)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-57));
			gClass.method_2().method_2(action);
			if (action == 0)
				gClass.method_2().method_11(playerID);
			if (action == 1 || action == 2)
			{
				gClass.method_2().method_11(clanID);
				gClass.method_2().method_11(code);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_28(sbyte action, sbyte id, string text)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-46));
			gClass.method_2().method_2(action);
			if (action == 2 || action == 4)
			{
				gClass.method_2().method_2(id);
				gClass.method_2().method_16(text);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_29(sbyte gender)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-41));
			gClass.method_2().method_2(gender);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_30(sbyte type, sbyte id)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-40));
			gClass.method_2().method_2(type);
			gClass.method_2().method_2(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_31(int npcTemplateId, int menuId, int optionId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)40);
			gClass.method_2().method_3(npcTemplateId);
			gClass.method_2().method_3(menuId);
			if (optionId >= 0)
				gClass.method_2().method_3(optionId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public GClass100 method_32(sbyte command)
	{
		GClass100 gClass = new GClass100((sbyte)(-29));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public GClass100 method_33(sbyte command)
	{
		GClass100 gClass = new GClass100((sbyte)(-28));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public static GClass100 smethod_1(sbyte command)
	{
		GClass100 gClass = new GClass100((sbyte)(-30));
		gClass.method_2().method_2(command);
		return gClass;
	}

	public void method_34()
	{
		if (GClass141.smethod_8("clienttype") != -1)
			Main.typeClient = GClass141.smethod_8("clienttype");
		try
		{
			GClass100 gClass = method_32(2);
			gClass.method_2().method_3(Main.typeClient);
			gClass.method_2().method_3(GClass193.int_12);
			gClass.method_2().method_13(false);
			gClass.method_2().method_11(GClass14.int_10);
			gClass.method_2().method_11(GClass14.int_11);
			gClass.method_2().method_13(GClass136.bool_4);
			gClass.method_2().method_13(GClass14.bool_5);
			gClass.method_2().method_16(GClass14.smethod_0() + "|" + GClass206.string_2);
			GClass188 gClass2 = GClass79.smethod_0("/info");
			if (gClass2 != null)
			{
				sbyte[] data = new sbyte[gClass2.gclass145_0.sbyte_0.Length];
				gClass2.method_3(ref data);
				if (data != null)
				{
					gClass.method_2().method_9(data.Length);
					gClass.method_2().method_18(data);
					GClass191.smethod_10("write " + data.Length + "|" + GClass206.string_2);
				}
			}
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_35()
	{
		GClass191.smethod_8("SET CLIENT TYPE");
		if (GClass141.smethod_8("clienttype") != -1)
			GClass77.int_0 = GClass141.smethod_8("clienttype");
		try
		{
			GClass191.smethod_8("setType");
			GClass100 gClass = method_32(2);
			gClass.method_2().method_3(GClass77.int_0);
			gClass.method_2().method_3(GClass193.int_12);
			GClass191.smethod_8("gui zoomlevel = " + GClass193.int_12);
			gClass.method_2().method_13(false);
			gClass.method_2().method_11(GClass14.int_10);
			gClass.method_2().method_11(GClass14.int_11);
			gClass.method_2().method_13(GClass136.bool_4);
			gClass.method_2().method_13(GClass14.bool_5);
			gClass.method_2().method_16(GClass14.smethod_0() + "|" + GClass206.string_2);
			GClass188 gClass2 = GClass79.smethod_0("/info");
			if (gClass2 != null)
			{
				sbyte[] data = new sbyte[gClass2.gclass145_0.sbyte_0.Length];
				gClass2.method_3(ref data);
				if (data != null)
				{
					gClass.method_2().method_9(data.Length);
					gClass.method_2().method_18(data);
					GClass191.smethod_10("write " + data.Length + "|" + GClass206.string_2);
				}
			}
			ginterface2_0 = GClass32.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
			gClass.method_4();
		}
		catch (Exception ex)
		{
			ex.StackTrace.ToString();
		}
	}

	public void method_36()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-120));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			long_0 = GClass77.smethod_18();
			gClass.method_4();
		}
	}

	public void method_37()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-121));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception)
		{
		}
		finally
		{
			long_1 = GClass77.smethod_18();
			gClass.method_4();
		}
	}

	public void method_38(string username, string pass, string version, sbyte type)
	{
		try
		{
			GClass100 gClass = method_32(0);
			gClass.method_2().method_16(username);
			gClass.method_2().method_16(pass);
			gClass.method_2().method_16(version);
			gClass.method_2().method_2(type);
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_39(string username, string pass, string usernameAo, string passAo, string version)
	{
		try
		{
			GClass100 gClass = method_32(1);
			gClass.method_2().method_16(username);
			gClass.method_2().method_16(pass);
			if (usernameAo != null && !usernameAo.Equals(string.Empty))
			{
				gClass.method_2().method_16(usernameAo);
				gClass.method_2().method_16("a");
			}
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
	}

	public void method_40()
	{
		if (!GClass61.smethod_0().bool_1)
		{
			GClass100 gClass = new GClass100((sbyte)(-23));
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
	}

	public void method_41(sbyte type)
	{
		GClass100 gClass = new GClass100((sbyte)(-34));
		try
		{
			gClass.method_2().method_2(type);
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception)
		{
		}
	}

	public void method_42(int zoneId, int indexUI)
	{
		if (!GClass61.smethod_0().bool_2)
		{
			GClass100 gClass = new GClass100((sbyte)21);
			try
			{
				gClass.method_2().method_3(zoneId);
				ginterface2_0.sendMessage(gClass);
				gClass.method_4();
			}
			catch (Exception)
			{
			}
		}
	}

	public void method_43(int second)
	{
		GClass100 gClass = new GClass100((sbyte)(-78));
		try
		{
			gClass.method_2().method_11(second);
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception)
		{
		}
	}

	public void method_44()
	{
		int num = GClass124.smethod_1().int_4 - GClass124.smethod_1().int_101;
		int num2 = GClass124.smethod_1().int_5 - GClass124.smethod_1().int_102;
		if (GClass124.bool_33 || (num == 0 && num2 == 0) || GClass93.bool_5 || GClass124.smethod_1().bool_2 || GClass124.smethod_1().int_5 <= 0 || GClass124.smethod_1().bool_71)
			return;
		try
		{
			GClass100 gClass = new GClass100((sbyte)(-7));
			GClass124.smethod_1().int_101 = GClass124.smethod_1().int_4;
			GClass124.smethod_1().int_102 = GClass124.smethod_1().int_5;
			GClass124.smethod_1().int_103 = GClass124.smethod_1().int_12;
			GClass124.smethod_1().int_106 = GClass124.smethod_1().int_11;
			if (GClass137.smethod_26(GClass124.smethod_1().int_4 / GClass137.sbyte_0, GClass124.smethod_1().int_5 / GClass137.sbyte_0) == 0)
			{
				gClass.method_2().method_2(1);
				if (GClass124.smethod_1().bool_8)
				{
					if (!GClass124.smethod_1().bool_25)
						GClass124.smethod_1().int_24 -= GClass124.smethod_1().int_156 / 100 * ((GClass124.smethod_1().sbyte_35 != 1) ? 1 : 2);
					if (GClass124.smethod_1().int_24 < 0)
						GClass124.smethod_1().int_24 = 0;
					GClass167.smethod_8().bool_74 = true;
					GClass167.smethod_8().int_145 = 0;
				}
			}
			else
				gClass.method_2().method_2(0);
			gClass.method_2().method_9(GClass124.smethod_1().int_4);
			if (num2 != 0)
				gClass.method_2().method_9(GClass124.smethod_1().int_5);
			ginterface2_0.sendMessage(gClass);
			GClass167.int_48++;
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass92.smethod_2("LOI CHAR MOVE " + ex.ToString());
		}
	}

	public void method_45(string charname)
	{
		GClass100 gClass = new GClass100((sbyte)(-28));
		try
		{
			gClass.method_2().method_2(1);
			gClass.method_2().method_16(charname);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		ginterface2_0.sendMessage(gClass);
	}

	public void method_46(sbyte sub, int value)
	{
	}

	public void method_47(string name, int gender, int hair)
	{
		GClass100 gClass = new GClass100((sbyte)(-28));
		try
		{
			gClass.method_2().method_2(2);
			gClass.method_2().method_16(name);
			gClass.method_2().method_3(gender);
			gClass.method_2().method_3(hair);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		ginterface2_0.sendMessage(gClass);
	}

	public void method_48(int modTemplateId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)11);
			gClass.method_2().method_3(modTemplateId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_49(int npcTemplateId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(12);
			gClass.method_2().method_3(npcTemplateId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_50(int skillId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(9);
			gClass.method_2().method_9(skillId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_51(int typeUI, int indexUI)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)35);
			gClass.method_2().method_3(typeUI);
			gClass.method_2().method_3(indexUI);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_52(int charId, int indexUI)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)90);
			gClass.method_2().method_11(charId);
			gClass.method_2().method_3(indexUI);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_53(int skillTemplateId, int point)
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(17);
			gClass.method_2().method_9(skillTemplateId);
			gClass.method_2().method_3(point);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_54(sbyte action, sbyte type, short id)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)7);
			gClass.method_2().method_2(action);
			gClass.method_2().method_2(type);
			gClass.method_2().method_8(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_55(sbyte type, int id, int quantity)
	{
		if (GClass57.smethod_0().bool_0)
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)6);
			gClass.method_2().method_2(type);
			gClass.method_2().method_9(id);
			if (quantity > 1)
				gClass.method_2().method_9(quantity);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_56(int skillTemplateId)
	{
		GClass92.smethod_0(GClass124.smethod_1().string_3 + " SELECT SKILL " + skillTemplateId);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)34);
			gClass.method_2().method_9(skillTemplateId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_57(short id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-66));
			gClass.method_2().method_8(id);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_58()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)29);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_59(short npcID, sbyte select)
	{
		GClass191.smethod_8("confirme menu" + select);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)32);
			gClass.method_2().method_8(npcID);
			gClass.method_2().method_2(select);
			ginterface2_0.sendMessage(gClass);
			gClass.method_4();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_60(int npcId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)33);
			gClass.method_2().method_9(npcId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_61(int npcId, int menuId, int optionId)
	{
		GClass92.smethod_0("menuid: " + menuId);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)22);
			gClass.method_2().method_3(npcId);
			gClass.method_2().method_3(menuId);
			gClass.method_2().method_3(optionId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_62(short menuId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)27);
			gClass.method_2().method_8(menuId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_63(short menuId, string str)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)88);
			gClass.method_2().method_8(menuId);
			gClass.method_2().method_16(str);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_64(int typeUI)
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(22);
			gClass.method_2().method_3(typeUI);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_65()
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(19);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_66(int coinOut)
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(21);
			gClass.method_2().method_11(coinOut);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_67(GClass0 item, GClass0[] items, bool isGold)
	{
		GClass14.gclass185_0.method_0();
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)14);
			gClass.method_2().method_13(isGold);
			gClass.method_2().method_3(item.int_29);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
					gClass.method_2().method_3(items[i].int_29);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_68(GClass0[] items)
	{
		GClass14.gclass185_0.method_0();
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)13);
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
					gClass.method_2().method_3(items[i].int_29);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_69(int playerMapId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)37);
			gClass.method_2().method_11(playerMapId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_70()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)50);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_71()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)39);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_72(int coin, GClass0[] items)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)38);
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
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_73(GClass122 vMob, GClass122 vChar, int type)
	{
		try
		{
			GClass191.smethod_8(">>SEND ATTACT  vMob=" + vMob.method_2() + "  vChar=" + vChar.method_2());
			GClass100 gClass = null;
			if (type == 0)
				return;
			if (vMob.method_2() <= 0 || vChar.method_2() <= 0)
			{
				if (vMob.method_2() > 0)
				{
					gClass = new GClass100((sbyte)54);
					for (int i = 0; i < vMob.method_2(); i++)
					{
						GClass6 gClass2 = (GClass6)vMob.method_3(i);
						if (!gClass2.bool_13)
						{
							gClass.method_2().method_3(gClass2.int_25);
							continue;
						}
						gClass.method_2().method_2(-1);
						gClass.method_2().method_11(gClass2.int_25);
					}
				}
				else if (vChar.method_2() > 0)
				{
					gClass = new GClass100((sbyte)(-60));
					for (int j = 0; j < vChar.method_2(); j++)
					{
						GClass124 gClass3 = (GClass124)vChar.method_3(j);
						gClass.method_2().method_11(gClass3.int_13);
					}
				}
			}
			else
			{
				if (type != 1)
				{
					if (type == 2)
						gClass = new GClass100((sbyte)67);
				}
				else
					gClass = new GClass100((sbyte)(-4));
				gClass.method_2().method_3(vMob.method_2());
				for (int k = 0; k < vMob.method_2(); k++)
				{
					GClass6 gClass4 = (GClass6)vMob.method_3(k);
					gClass.method_2().method_3(gClass4.int_25);
				}
				for (int l = 0; l < vChar.method_2(); l++)
				{
					GClass124 gClass5 = (GClass124)vChar.method_3(l);
					if (gClass5 == null)
						gClass.method_2().method_11(-1);
					else
						gClass.method_2().method_11(gClass5.int_13);
				}
			}
			gClass.method_2().method_0((sbyte)GClass124.smethod_1().int_12);
			if (gClass != null)
				ginterface2_0.sendMessage(gClass);
		}
		catch (Exception)
		{
			GClass191.smethod_10(">>err ATTACT  vMob=" + vMob.method_2() + "  vChar=" + vChar.method_2());
		}
	}

	public void method_74(int itemMapId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-20));
			gClass.method_2().method_9(itemMapId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_75(int index)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-18));
			gClass.method_2().method_3(index);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_76()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-15));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_77()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-16));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_78(string text)
	{
		if (GClass57.smethod_0().bool_0 || GClass49.smethod_0().method_2(text))
			return;
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)44);
			gClass.method_2().method_16(text);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_79()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-87));
			if (!GClass32.smethod_0().isConnected() || GClass32.bool_2)
				ginterface2_0 = GClass179.smethod_0();
			else
				ginterface2_0 = GClass32.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_80()
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(6);
			if (!GClass32.smethod_0().isConnected() || GClass32.bool_2)
				ginterface2_0 = GClass179.smethod_0();
			else
				ginterface2_0 = GClass32.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_81()
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(7);
			if (GClass32.smethod_0().isConnected() && !GClass32.bool_2)
				ginterface2_0 = GClass32.smethod_0();
			else
				ginterface2_0 = GClass179.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
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
		GClass100 gClass = null;
		try
		{
			gClass = method_33(8);
			if (!GClass32.smethod_0().isConnected() || GClass32.bool_2)
				ginterface2_0 = GClass179.smethod_0();
			else
				ginterface2_0 = GClass32.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
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
		GClass100 gClass = null;
		try
		{
			gClass = method_33(13);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_84(int charId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)36);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_85(string name)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)53);
			gClass.method_2().method_16(name);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_86(int charId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)76);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_87(int charId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)77);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_88(int charId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)59);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_89(int charId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)62);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_90(string name)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)75);
			gClass.method_2().method_16(name);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_91(sbyte action, sbyte type, int playerId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-59));
			gClass.method_2().method_2(action);
			gClass.method_2().method_2(type);
			gClass.method_2().method_11(playerId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_92(int maptemplateId)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(10);
			gClass.method_2().method_3(maptemplateId);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_93()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)79);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_94(GClass122 chars)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)18);
			gClass.method_2().method_3(chars.method_2());
			for (int i = 0; i < chars.method_2(); i++)
			{
				GClass124 gClass2 = (GClass124)chars.method_3(i);
				gClass.method_2().method_11(gClass2.int_13);
			}
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_95(string str)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)16);
			gClass.method_2().method_16(str);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_96(string str)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)17);
			gClass.method_2().method_16(str);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_97(string text, int id)
	{
		GClass191.smethod_8("chat player text = " + text);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-72));
			gClass.method_2().method_11(id);
			gClass.method_2().method_16(text);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_98(string text)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-71));
			gClass.method_2().method_16(text);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_99(string to, string text)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)91);
			gClass.method_2().method_16(to);
			gClass.method_2().method_16(text);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_100(string NAP, string PIN)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(16);
			gClass.method_2().method_16(NAP);
			gClass.method_2().method_16(PIN);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_101(string key, sbyte[] data)
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(60);
			gClass.method_2().method_16(key);
			gClass.method_2().method_11(data.Length);
			gClass.method_2().method_18(data);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_102(string key)
	{
		GClass92.smethod_0("REQUEST RMS");
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(61);
			gClass.method_2().method_16(key);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_103()
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(17);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_104(string name, int id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(18);
			gClass.method_2().method_11(id);
			gClass.method_2().method_16(name);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_105(int id)
	{
		GClass14.smethod_4();
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("REQUEST ICON " + id);
			gClass = new GClass100((sbyte)(-67));
			gClass.method_2().method_11(id);
			if (!GClass32.smethod_0().isConnected() || GClass32.bool_2)
				ginterface2_0 = GClass179.smethod_0();
			else
				ginterface2_0 = GClass32.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_106(int index1, int index2, int index3)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(33);
			gClass.method_2().method_3(index1);
			gClass.method_2().method_3(index2);
			gClass.method_2().method_3(index3);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_107(string name)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(34);
			gClass.method_2().method_16(name);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_108(int indexItem, int numSplit)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(40);
			gClass.method_2().method_3(indexItem);
			gClass.method_2().method_11(numSplit);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_109(int pass)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(37);
			gClass.method_2().method_11(pass);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_110(int pass)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(41);
			gClass.method_2().method_11(pass);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_111(int passOld, int passNew)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(38);
			gClass.method_2().method_11(passOld);
			gClass.method_2().method_11(passNew);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_112(int pass2)
	{
		GClass100 gClass = null;
		try
		{
			gClass = method_33(39);
			gClass.method_2().method_11(pass2);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_113(short id)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-32));
			gClass.method_2().method_8(id);
			if (GClass32.smethod_0().isConnected() && !GClass32.bool_2)
				ginterface2_0 = GClass32.smethod_0();
			else
				ginterface2_0 = GClass179.smethod_0();
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_114()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-33));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_115()
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-38));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_116(int playerID)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-38));
			gClass.method_2().method_11(playerID);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-39));
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_118(sbyte action)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-35));
			gClass.method_2().method_2(action);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_119(sbyte ID)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-63));
			gClass.method_2().method_2(ID);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_120(sbyte action)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-36));
			gClass.method_2().method_2(action);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_121(sbyte action)
	{
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-37));
			gClass.method_2().method_2(action);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_122(string user)
	{
		GClass191.smethod_8("Login 2");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-101));
			gClass.method_2().method_16(user);
			gClass.method_2().method_3(1);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-34));
			gClass.method_2().method_2(action);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_124(int typePotential, int num)
	{
		GClass100 gClass = null;
		try
		{
			gClass = smethod_1(16);
			gClass.method_2().method_3(typePotential);
			gClass.method_2().method_9(num);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_125(sbyte action, GClass122 vResourceIndex)
	{
		GClass191.smethod_8("request resource action= " + action);
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-74));
			gClass.method_2().method_2(action);
			if (action == 2 && vResourceIndex != null)
			{
				gClass.method_2().method_9(vResourceIndex.method_2());
				for (int i = 0; i < vResourceIndex.method_2(); i++)
				{
					gClass.method_2().method_8(short.Parse((string)vResourceIndex.method_3(i)));
				}
			}
			if (GClass32.smethod_0().isConnected() && !GClass32.bool_2)
				ginterface2_0 = GClass32.smethod_0();
			else
			{
				bool_0 = true;
				ginterface2_0 = GClass179.smethod_0();
			}
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}

	public void method_126(int selected)
	{
		GClass191.smethod_8("request magic tree");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-91));
			gClass.method_2().method_3(selected);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-107));
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-96));
			gClass.method_2().method_16(topName);
			gClass.method_2().method_2(selected);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		GClass191.smethod_8("add enemy");
		try
		{
			gClass = new GClass100((sbyte)(-99));
			gClass.method_2().method_2(b);
			if (b == 1 || b == 2)
				gClass.method_2().method_11(charID);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("ki gui action= " + action);
			gClass = new GClass100((sbyte)(-100));
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
				GClass191.smethod_8("currTab= " + moneyType + " page= " + money);
			}
			if (action == 5)
				gClass.method_2().method_9(itemId);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-103));
			gClass.method_2().method_2(action);
			GClass191.smethod_8("------------service--  " + action + "   " + flagType);
			if (action != 0)
				gClass.method_2().method_2(flagType);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("------------setLockInventory:     " + pass);
			gClass = new GClass100((sbyte)(-104));
			gClass.method_2().method_11(pass);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-108));
			gClass.method_2().method_2(status);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("------------transportNow  ");
			gClass = new GClass100((sbyte)(-105));
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("FUNSION");
			gClass = new GClass100((sbyte)125);
			gClass.method_2().method_2(type);
			ginterface2_0.sendMessage(gClass);
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

	public void method_136(GClass122 vID)
	{
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("IMAGE SOURCE size= " + vID.method_2());
			gClass = new GClass100((sbyte)(-111));
			gClass.method_2().method_9(vID.method_2());
			if (vID.method_2() > 0)
			{
				for (int i = 0; i < vID.method_2(); i++)
				{
					GClass191.smethod_8("gui len str " + ((Class0)vID.method_3(i)).string_0);
					gClass.method_2().method_16(((Class0)vID.method_3(i)).string_0);
				}
			}
			if (GClass32.smethod_0().isConnected() && !GClass32.bool_2)
				ginterface2_0 = GClass32.smethod_0();
			else
			{
				ginterface2_0 = GClass179.smethod_0();
				bool_0 = true;
			}
			ginterface2_0.sendMessage(gClass);
			ginterface2_0 = GClass179.smethod_0();
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-126));
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			GClass191.smethod_8("SERVER DATA");
			gClass = new GClass100((sbyte)(-110));
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
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-113));
			for (int i = 0; i < GClass167.gclass95_1.Length; i++)
			{
				gClass.method_2().method_2(skill[i]);
			}
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-114));
			ginterface2_0.sendMessage(gClass);
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
		GClass191.smethod_8("GUI THACH DAU");
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-118));
			gClass.method_2().method_11(id);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-30));
			gClass.method_2().method_2(63);
			gClass.method_2().method_11(charId);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-30));
			gClass.method_2().method_2(64);
			gClass.method_2().method_11(charId);
			gClass.method_2().method_8(select);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)66);
			gClass.method_2().method_16(nameImg);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = new GClass100((sbyte)(-127));
		try
		{
			gClass.method_2().method_3(type);
			if (soluong > 0)
				gClass.method_2().method_3(soluong);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = new GClass100(sbyte.MaxValue);
		try
		{
			gClass.method_2().method_3(i);
			if (id != -1)
				gClass.method_2().method_9(id);
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = new GClass100((sbyte)24);
		try
		{
			if (action != 1)
				gClass.method_2().method_3((GClass124.smethod_1().short_30 != -1) ? (-1) : 0);
			else
			{
				sbyte[] array = GClass191.smethod_7();
				gClass.method_2().method_3(1);
				gClass.method_2().method_9(array.Length);
				gClass.method_2().method_18(array);
			}
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = new GClass100((sbyte)69);
		try
		{
			ginterface2_0.sendMessage(gClass);
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
		GClass100 gClass = null;
		try
		{
			gClass = new GClass100((sbyte)(-45));
			gClass.method_2().method_0(20);
			gClass.method_2().method_0(idTemplateSkill);
			gClass.method_2().method_9(GClass124.smethod_1().int_4);
			gClass.method_2().method_9(GClass124.smethod_1().int_5);
			gClass.method_2().method_0(dir);
			gClass.method_2().method_8(x);
			gClass.method_2().method_8(y);
			ginterface2_0.sendMessage(gClass);
		}
		catch (Exception ex)
		{
			GClass92.smethod_0(ex.Message + ex.StackTrace);
		}
		finally
		{
			gClass.method_4();
		}
	}
}
