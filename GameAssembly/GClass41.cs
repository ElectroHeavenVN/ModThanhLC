public abstract class GClass41
{
	public abstract void paintDefaultBg(GClass122 g);

	public abstract void paintfillDefaultBg(GClass122 g);

	public abstract void repaintCircleBg();

	public abstract void paintSolidBg(GClass122 g);

	public abstract void paintDefaultPopup(GClass122 g, int x, int y, int w, int h);

	public abstract void paintWhitePopup(GClass122 g, int y, int x, int width, int height);

	public abstract void paintDefaultPopupH(GClass122 g, int h);

	public abstract void paintCmdBar(GClass122 g, GClass87 left, GClass87 center, GClass87 right);

	public abstract void paintSelect(GClass122 g, int x, int y, int w, int h);

	public abstract void paintLogo(GClass122 g, int x, int y);

	public abstract void paintHotline(GClass122 g, string num);

	public abstract void paintInputTf(GClass122 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text);

	public abstract void paintTabSoft(GClass122 g);

	public abstract void paintBackMenu(GClass122 g, int x, int y, int w, int h, bool iss);

	public abstract void paintMsgBG(GClass122 g, int x, int y, int w, int h, string title, string subTitle, string check);

	public abstract void paintDefaultScrLisst(GClass122 g, string title, string subTitle, string check);

	public abstract void paintCheck(GClass122 g, int x, int y, int index);

	public abstract void paintImgMsg(GClass122 g, int x, int y, int index);

	public abstract void paintTitleBoard(GClass122 g, int roomID);

	public abstract void paintCheckPass(GClass122 g, int x, int y, bool check, bool focus);

	public abstract void paintInputDlg(GClass122 g, int x, int y, int w, int h, string[] str);

	public abstract void paintIconMainMenu(GClass122 g, int x, int y, bool iss, bool issSe, int i, int wStr);

	public abstract void paintLineRoom(GClass122 g, int x, int y, int xTo, int yTo);

	public abstract void paintCellContaint(GClass122 g, int x, int y, int w, int h, bool iss);

	public abstract void paintScroll(GClass122 g, int x, int y, int h);

	public abstract int[] getColorMsg();

	public abstract void paintLogo(GClass122 g);

	public abstract void paintTextLogin(GClass122 g, bool issRes);

	public abstract void paintSellectBoard(GClass122 g, int x, int y, int w, int h);

	public abstract int issRegissterUsingWAP();

	public abstract string getCard();

	public abstract void paintSellectedShop(GClass122 g, int x, int y, int w, int h);

	public abstract string getUrlUpdateGame();

	public string method_0()
	{
		return "http://wap.teamobi.com/faqs.php?provider=";
	}

	public abstract void doSelect(int focus);
}
