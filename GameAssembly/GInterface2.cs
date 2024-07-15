public interface GInterface2
{
	bool isConnected();

	void setHandler(GInterface4 messageHandler);

	void connect(string host, int port);

	void sendMessage(GClass100 message);

	void close();
}
