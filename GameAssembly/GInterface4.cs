public interface GInterface4
{
	void onMessage(GClass100 message);

	void onConnectionFail(bool isMain);

	void onDisconnected(bool isMain);

	void onConnectOK(bool isMain);
}
