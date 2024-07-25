using System;
using System.Runtime.Serialization;

[Serializable]
public class GException0 : Exception
{
	public GException0()
	{
	}

	public GException0(string message)
		: base(message)
	{
	}

	public GException0(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected GException0(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
