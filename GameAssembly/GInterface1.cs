public interface GInterface1
{
	void onMessage(GClass110 message);

	void onConnectionFail(bool isMain);

	void onDisconnected(bool isMain);

	void onConnectOK(bool isMain);
}
