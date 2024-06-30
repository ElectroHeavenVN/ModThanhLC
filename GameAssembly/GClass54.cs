using UnityEngine;

public class GClass54
{
	public string string_0;

	public AudioClip audioClip_0;

	public long long_0;

	public GClass54(string filename)
	{
		audioClip_0 = (AudioClip)Resources.Load(filename);
		string_0 = filename;
	}

	public void method_0()
	{
		Main.main.GetComponent<AudioSource>().PlayOneShot(audioClip_0);
		long_0 = GClass138.smethod_18();
	}

	public bool method_1()
	{
		return false;
	}
}
