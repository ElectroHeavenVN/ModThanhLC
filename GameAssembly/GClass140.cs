using System.Threading;
using UnityEngine;

public class GClass140
{
	public static int int_0;

	public static int int_1;

	public static int int_2;

	private static string string_0;

	private static float float_0;

	public static bool bool_0 = true;

	public static bool bool_1;

	public static bool bool_2;

	public static AudioSource audioSource_0;

	public static AudioSource audioSource_1;

	public static AudioSource audioSource_2;

	public static AudioClip[] audioClip_0;

	public static GameObject[] gameObject_0;

	public static sbyte sbyte_0;

	public static sbyte sbyte_1 = 1;

	public static sbyte sbyte_2 = 2;

	public static sbyte sbyte_3 = 3;

	public static sbyte sbyte_4 = 4;

	public static sbyte sbyte_5 = 5;

	public static sbyte sbyte_6 = 6;

	public static sbyte sbyte_7 = 7;

	public static sbyte sbyte_8 = 8;

	public static sbyte sbyte_9 = 9;

	public static sbyte sbyte_10 = 10;

	public static sbyte sbyte_11 = 11;

	public static sbyte sbyte_12 = 12;

	public static sbyte sbyte_13 = 13;

	public static sbyte sbyte_14 = 14;

	public static sbyte sbyte_15 = 15;

	public static sbyte sbyte_16 = 16;

	public static sbyte sbyte_17 = 17;

	public static sbyte sbyte_18 = 18;

	public static sbyte sbyte_19 = 19;

	public static sbyte sbyte_20 = 20;

	public static sbyte sbyte_21 = 21;

	public static sbyte sbyte_22 = 22;

	public static sbyte sbyte_23 = 23;

	public static sbyte sbyte_24 = 24;

	public static sbyte sbyte_25 = 25;

	public static sbyte sbyte_26 = 26;

	public static sbyte sbyte_27 = 27;

	public static sbyte sbyte_28 = 28;

	public static sbyte sbyte_29 = 29;

	public static sbyte sbyte_30 = 30;

	public static sbyte sbyte_31 = 31;

	public static sbyte sbyte_32 = 32;

	public static sbyte sbyte_33 = 33;

	public static int int_3;

	public static void smethod_0(GClass147.GClass150 ac)
	{
	}

	public static void smethod_1()
	{
		for (int i = 0; i < gameObject_0.Length; i++)
		{
			if (gameObject_0[i] != null)
				gameObject_0[i].GetComponent<AudioSource>().Pause();
		}
	}

	public static bool smethod_2()
	{
		return false;
	}

	public static void smethod_3()
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Audio Player";
		gameObject.transform.position = Vector3.zero;
		gameObject.AddComponent<AudioListener>();
		audioSource_2 = gameObject.AddComponent<AudioSource>();
	}

	public static void smethod_4(int[] musicID, int[] sID)
	{
		if (gameObject_0 == null && audioClip_0 == null)
		{
			smethod_3();
			int_3 = musicID.Length;
			gameObject_0 = new GameObject[musicID.Length + sID.Length];
			audioClip_0 = new AudioClip[musicID.Length + sID.Length];
			for (int i = 0; i < gameObject_0.Length; i++)
			{
				smethod_7((i >= int_3) ? ("/sound/" + (i - int_3)) : ("/music/" + i), i);
			}
		}
	}

	public static void smethod_5(int id, float volume)
	{
		smethod_12(id + int_3, volume);
	}

	public static void smethod_6(int id, float volume)
	{
		smethod_12(id, volume);
	}

	public static void smethod_7(string fileName, int pos)
	{
		smethod_29(pos);
		string empty = string.Empty;
		smethod_23(Main.res + fileName, pos);
	}

	public static void smethod_8()
	{
		for (int i = 0; i < audioClip_0.Length; i++)
		{
			smethod_29(i);
		}
		for (int j = 0; j < int_3; j++)
		{
			smethod_21(j);
		}
	}

	public static void smethod_9()
	{
		for (int i = 0; i < audioClip_0.Length; i++)
		{
			smethod_29(i);
		}
		smethod_21(0);
		smethod_14();
		smethod_17(0);
	}

	public static void smethod_10()
	{
	}

	public static void smethod_11(int x)
	{
		if (GClass14.bool_21)
			smethod_29(x);
	}

	public static void smethod_12(int id, float volume)
	{
		if (!bool_1 && GClass14.bool_21)
			smethod_26(volume, id);
	}

	public static void smethod_13(int id, float volume)
	{
		if (GClass14.bool_21 && !(audioSource_1 == null))
		{
			audioSource_1.GetComponent<AudioSource>().loop = true;
			audioSource_1.GetComponent<AudioSource>().clip = audioClip_0[id];
			audioSource_1.GetComponent<AudioSource>().volume = volume;
			audioSource_1.GetComponent<AudioSource>().Play();
		}
	}

	public static void smethod_14()
	{
		audioSource_1.GetComponent<AudioSource>().Stop();
	}

	public static bool smethod_15()
	{
		if (audioSource_1 == null)
			return false;
		return audioSource_1.GetComponent<AudioSource>().isPlaying;
	}

	public static void smethod_16(int id, float volume, bool isLoop)
	{
		if (GClass14.bool_21 && !(audioSource_2 == null))
		{
			audioSource_0.GetComponent<AudioSource>().loop = isLoop;
			audioSource_0.GetComponent<AudioSource>().clip = audioClip_0[id];
			audioSource_0.GetComponent<AudioSource>().volume = volume;
			audioSource_0.GetComponent<AudioSource>().Play();
		}
	}

	public static void smethod_17(int id)
	{
		audioSource_0.GetComponent<AudioSource>().Stop();
	}

	public static bool smethod_18(int id)
	{
		if (audioSource_0 == null)
			return false;
		return audioSource_0.GetComponent<AudioSource>().isPlaying;
	}

	public static void smethod_19(int type, float vl, bool loop)
	{
		if (!bool_1)
		{
			vl -= 0.3f;
			if (vl <= 0f)
				vl = 0.01f;
			smethod_20(type, vl);
		}
	}

	public static void smethod_20(int id, float volume)
	{
		if (!GClass14.bool_21)
			return;
		if (id != GClass147.int_2)
		{
			if (!(audioSource_2 == null) && !smethod_22(id))
			{
				audioSource_2.GetComponent<AudioSource>().loop = true;
				audioSource_2.GetComponent<AudioSource>().clip = audioClip_0[id];
				audioSource_2.GetComponent<AudioSource>().volume = volume;
				audioSource_2.GetComponent<AudioSource>().Play();
			}
		}
		else
			smethod_12(id, volume + 0.2f);
	}

	public static void smethod_21(int id)
	{
		audioSource_2.GetComponent<AudioSource>().Stop();
	}

	public static bool smethod_22(int id)
	{
		if (!(audioSource_2 == null))
			return audioSource_2.GetComponent<AudioSource>().isPlaying;
		return false;
	}

	public static void smethod_23(string filename, int pos)
	{
		if (!(Thread.CurrentThread.Name == Main.mainThreadName))
			smethod_24(filename, pos);
		else
			smethod_25(filename, pos);
	}

	private static void smethod_24(string string_1, int int_4)
	{
		if (int_0 != 0)
		{
			GClass92.smethod_2("CANNOT LOAD AUDIO " + string_1 + " WHEN LOADING " + string_0);
			return;
		}
		string_0 = string_1;
		int_1 = int_4;
		int_0 = 2;
		int i;
		for (i = 0; i < 100; i++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (i != 100)
			GClass92.smethod_1("Load Audio " + string_1 + " done in " + i * 5 + "ms");
		else
			GClass92.smethod_2("TOO LONG FOR LOAD AUDIO " + string_1);
	}

	private static void smethod_25(string string_1, int int_4)
	{
		audioClip_0[int_4] = (AudioClip)Resources.Load(string_1, typeof(AudioClip));
		GameObject.Find("Main Camera").AddComponent<AudioSource>();
		gameObject_0[int_4] = GameObject.Find("Main Camera");
	}

	public static void smethod_26(float volume, int pos)
	{
		if (Thread.CurrentThread.Name == Main.mainThreadName)
			smethod_28(volume, pos);
		else
			smethod_27(volume, pos);
	}

	public static void smethod_27(float volume, int pos)
	{
		if (int_0 == 0)
		{
			float_0 = volume;
			int_1 = pos;
			int_0 = 3;
			int i;
			for (i = 0; i < 100; i++)
			{
				Thread.Sleep(5);
				if (int_0 == 0)
					break;
			}
			if (i != 100)
				Debug.Log("Start Audio done in " + i * 5 + "ms");
			else
				Debug.LogError("TOO LONG FOR START AUDIO");
		}
		else
			Debug.LogError("CANNOT START AUDIO WHEN STARTING");
	}

	public static void smethod_28(float volume, int pos)
	{
		if (!(gameObject_0[pos] == null))
			gameObject_0[pos].GetComponent<AudioSource>().PlayOneShot(audioClip_0[pos], volume);
	}

	public static void smethod_29(int pos)
	{
		if (!(Thread.CurrentThread.Name == Main.mainThreadName))
			smethod_30(pos);
		else
			smethod_31(pos);
	}

	public static void smethod_30(int pos)
	{
		if (int_0 != 0)
		{
			Debug.LogError("CANNOT STOP AUDIO WHEN STOPPING");
			return;
		}
		int_1 = pos;
		int_0 = 4;
		int i;
		for (i = 0; i < 100; i++)
		{
			Thread.Sleep(5);
			if (int_0 == 0)
				break;
		}
		if (i != 100)
			Debug.Log("Stop Audio done in " + i * 5 + "ms");
		else
			Debug.LogError("TOO LONG FOR STOP AUDIO");
	}

	public static void smethod_31(int pos)
	{
		if (gameObject_0[pos] != null)
			gameObject_0[pos].GetComponent<AudioSource>().Stop();
	}
}
