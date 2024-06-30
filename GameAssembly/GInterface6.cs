public interface GInterface6
{
	bool isConnected();

	void setHandler(GInterface1 messageHandler);

	void connect(string host, int port);

	void sendMessage(GClass110 message);

	void close();
}
