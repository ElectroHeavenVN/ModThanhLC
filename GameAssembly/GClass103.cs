public abstract class GClass103
{
	public abstract void paintDefaultBg(GClass193 g);

	public abstract void paintfillDefaultBg(GClass193 g);

	public abstract void repaintCircleBg();

	public abstract void paintSolidBg(GClass193 g);

	public abstract void paintDefaultPopup(GClass193 g, int x, int y, int w, int h);

	public abstract void paintWhitePopup(GClass193 g, int y, int x, int width, int height);

	public abstract void paintDefaultPopupH(GClass193 g, int h);

	public abstract void paintCmdBar(GClass193 g, GClass118 left, GClass118 center, GClass118 right);

	public abstract void paintSelect(GClass193 g, int x, int y, int w, int h);

	public abstract void paintLogo(GClass193 g, int x, int y);

	public abstract void paintHotline(GClass193 g, string num);

	public abstract void paintInputTf(GClass193 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text);

	public abstract void paintTabSoft(GClass193 g);

	public abstract void paintBackMenu(GClass193 g, int x, int y, int w, int h, bool iss);

	public abstract void paintMsgBG(GClass193 g, int x, int y, int w, int h, string title, string subTitle, string check);

	public abstract void paintDefaultScrLisst(GClass193 g, string title, string subTitle, string check);

	public abstract void paintCheck(GClass193 g, int x, int y, int index);

	public abstract void paintImgMsg(GClass193 g, int x, int y, int index);

	public abstract void paintTitleBoard(GClass193 g, int roomID);

	public abstract void paintCheckPass(GClass193 g, int x, int y, bool check, bool focus);

	public abstract void paintInputDlg(GClass193 g, int x, int y, int w, int h, string[] str);

	public abstract void paintIconMainMenu(GClass193 g, int x, int y, bool iss, bool issSe, int i, int wStr);

	public abstract void paintLineRoom(GClass193 g, int x, int y, int xTo, int yTo);

	public abstract void paintCellContaint(GClass193 g, int x, int y, int w, int h, bool iss);

	public abstract void paintScroll(GClass193 g, int x, int y, int h);

	public abstract int[] getColorMsg();

	public abstract void paintLogo(GClass193 g);

	public abstract void paintTextLogin(GClass193 g, bool issRes);

	public abstract void paintSellectBoard(GClass193 g, int x, int y, int w, int h);

	public abstract int issRegissterUsingWAP();

	public abstract string getCard();

	public abstract void paintSellectedShop(GClass193 g, int x, int y, int w, int h);

	public abstract string getUrlUpdateGame();

	public string method_0()
	{
		return "http://wap.teamobi.com/faqs.php?provider=";
	}

	public abstract void doSelect(int focus);
}
