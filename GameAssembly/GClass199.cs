using UnityEngine;

public class GClass199
{
	public string string_0;

	public AudioClip audioClip_0;

	public long long_0;

	public GClass199(string filename)
	{
		audioClip_0 = (AudioClip)Resources.Load(filename);
		string_0 = filename;
	}

	public void method_0()
	{
		Main.main.GetComponent<AudioSource>().PlayOneShot(audioClip_0);
		long_0 = GClass203.smethod_18();
	}

	public bool method_1()
	{
		return false;
	}
}
