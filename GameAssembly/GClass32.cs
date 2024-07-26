using System.Collections;
using UnityEngine;

public class GClass32
{
	private static Hashtable hashtable_0;

	static GClass32()
	{
		hashtable_0 = new Hashtable();
		hashtable_0.Add(KeyCode.A, 97);
		hashtable_0.Add(KeyCode.B, 98);
		hashtable_0.Add(KeyCode.C, 99);
		hashtable_0.Add(KeyCode.D, 100);
		hashtable_0.Add(KeyCode.E, 101);
		hashtable_0.Add(KeyCode.F, 102);
		hashtable_0.Add(KeyCode.G, 103);
		hashtable_0.Add(KeyCode.H, 104);
		hashtable_0.Add(KeyCode.I, 105);
		hashtable_0.Add(KeyCode.J, 106);
		hashtable_0.Add(KeyCode.K, 107);
		hashtable_0.Add(KeyCode.L, 108);
		hashtable_0.Add(KeyCode.M, 109);
		hashtable_0.Add(KeyCode.N, 110);
		hashtable_0.Add(KeyCode.O, 111);
		hashtable_0.Add(KeyCode.P, 112);
		hashtable_0.Add(KeyCode.Q, 113);
		hashtable_0.Add(KeyCode.R, 114);
		hashtable_0.Add(KeyCode.S, 115);
		hashtable_0.Add(KeyCode.T, 116);
		hashtable_0.Add(KeyCode.U, 117);
		hashtable_0.Add(KeyCode.V, 118);
		hashtable_0.Add(KeyCode.W, 119);
		hashtable_0.Add(KeyCode.X, 120);
		hashtable_0.Add(KeyCode.Y, 121);
		hashtable_0.Add(KeyCode.Z, 122);
		hashtable_0.Add(KeyCode.Alpha0, 48);
		hashtable_0.Add(KeyCode.Alpha1, 49);
		hashtable_0.Add(KeyCode.Alpha2, 50);
		hashtable_0.Add(KeyCode.Alpha3, 51);
		hashtable_0.Add(KeyCode.Alpha4, 52);
		hashtable_0.Add(KeyCode.Alpha5, 53);
		hashtable_0.Add(KeyCode.Alpha6, 54);
		hashtable_0.Add(KeyCode.Alpha7, 55);
		hashtable_0.Add(KeyCode.Alpha8, 56);
		hashtable_0.Add(KeyCode.Alpha9, 57);
		hashtable_0.Add(KeyCode.Space, 32);
		hashtable_0.Add(KeyCode.F1, -21);
		hashtable_0.Add(KeyCode.F2, -22);
		hashtable_0.Add(KeyCode.Equals, -25);
		hashtable_0.Add(KeyCode.Minus, 45);
		hashtable_0.Add(KeyCode.F3, -23);
		hashtable_0.Add(KeyCode.UpArrow, -1);
		hashtable_0.Add(KeyCode.DownArrow, -2);
		hashtable_0.Add(KeyCode.LeftArrow, -3);
		hashtable_0.Add(KeyCode.RightArrow, -4);
		hashtable_0.Add(KeyCode.Backspace, -8);
		hashtable_0.Add(KeyCode.Return, -5);
		hashtable_0.Add(KeyCode.Period, 46);
		hashtable_0.Add(KeyCode.At, 64);
		hashtable_0.Add(KeyCode.Tab, -26);
	}

	public static int smethod_0(KeyCode k)
	{
		object obj = hashtable_0[k];
		if (obj == null)
			return 0;
		return (int)obj;
	}
}
