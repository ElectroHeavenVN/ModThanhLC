public abstract class GClass55
{
	public abstract void paintDefaultBg(GClass76 g);

	public abstract void paintfillDefaultBg(GClass76 g);

	public abstract void repaintCircleBg();

	public abstract void paintSolidBg(GClass76 g);

	public abstract void paintDefaultPopup(GClass76 g, int x, int y, int w, int h);

	public abstract void paintWhitePopup(GClass76 g, int y, int x, int width, int height);

	public abstract void paintDefaultPopupH(GClass76 g, int h);

	public abstract void paintCmdBar(GClass76 g, GClass14 left, GClass14 center, GClass14 right);

	public abstract void paintSelect(GClass76 g, int x, int y, int w, int h);

	public abstract void paintLogo(GClass76 g, int x, int y);

	public abstract void paintHotline(GClass76 g, string num);

	public abstract void paintInputTf(GClass76 g, bool iss, int x, int y, int w, int h, int xText, int yText, string text);

	public abstract void paintTabSoft(GClass76 g);

	public abstract void paintBackMenu(GClass76 g, int x, int y, int w, int h, bool iss);

	public abstract void vmethod_0(GClass76 g, int x, int y, int w, int h, string title, string subTitle, string check);

	public abstract void paintDefaultScrLisst(GClass76 g, string title, string subTitle, string check);

	public abstract void paintCheck(GClass76 g, int x, int y, int index);

	public abstract void paintImgMsg(GClass76 g, int x, int y, int index);

	public abstract void paintTitleBoard(GClass76 g, int roomID);

	public abstract void paintCheckPass(GClass76 g, int x, int y, bool check, bool focus);

	public abstract void paintInputDlg(GClass76 g, int x, int y, int w, int h, string[] str);

	public abstract void paintIconMainMenu(GClass76 g, int x, int y, bool iss, bool issSe, int i, int wStr);

	public abstract void paintLineRoom(GClass76 g, int x, int y, int xTo, int yTo);

	public abstract void paintCellContaint(GClass76 g, int x, int y, int w, int h, bool iss);

	public abstract void paintScroll(GClass76 g, int x, int y, int h);

	public abstract int[] getColorMsg();

	public abstract void paintLogo(GClass76 g);

	public abstract void paintTextLogin(GClass76 g, bool issRes);

	public abstract void paintSellectBoard(GClass76 g, int x, int y, int w, int h);

	public abstract int vmethod_1();

	public abstract string getCard();

	public abstract void paintSellectedShop(GClass76 g, int x, int y, int w, int h);

	public abstract string getUrlUpdateGame();

	public string method_0()
	{
		return "http://wap.teamobi.com/faqs.php?provider=";
	}

	public abstract void doSelect(int focus);
}
