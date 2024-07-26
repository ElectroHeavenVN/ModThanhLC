public interface GInterface3
{
	void onMessage(GClass208 message);

	void onConnectionFail(bool isMain);

	void onDisconnected(bool isMain);

	void onConnectOK(bool isMain);
}
