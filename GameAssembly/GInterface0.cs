public interface GInterface0
{
	bool isConnected();

	void setHandler(GInterface3 messageHandler);

	void connect(string host, int port);

	void sendMessage(GClass208 message);

	void close();
}
