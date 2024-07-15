using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ns1;

internal class Class7
{
	private static readonly Class7 class7_0 = new Class7();

	internal int int_0;

	internal bool bool_0;

	internal int int_1;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	private string string_0 = string.Empty;

	private List<string[]> list_0;

	private List<string[]> list_1 = new List<string[]>
	{
		(GClass62.int_0 != 0) ? new string[2] { "/tbb", "Turn off/on show list boss appear information" } : new string[2] { "/tbb", "Bật/Tắt hiển thị d/s thông báo BOSS" },
		(GClass62.int_0 == 0) ? new string[2] { "/cobj", "Bật/Tắt tự động chuyển mục tiêu" } : new string[2] { "/cobj", "Turn off/on auto change object" },
		(GClass62.int_0 == 0) ? new string[2] { "/dsb", "Bật/Tắt tự động đồ sát BOSS" } : new string[2] { "/dsb", "Turn off/on auto murdering BOSS" },
		(GClass62.int_0 != 0) ? new string[2] { "/abdkbX", "Turn off/on auto open TreasureUnderSea LvlX" } : new string[2] { "/abdkbX", "Bật/Tắt tự động mở BDKB level X" },
		(GClass62.int_0 == 0) ? new string[2] { "/abfX Y", "Bật/Tắt tự động ăn đậu khi HP,KI < X%, Y%" } : new string[2] { "/abfX Y", "Turn off/on auto use bean if HP,KI < X%, Y%" },
		(GClass62.int_0 == 0) ? new string[2] { "/addboss", "Thêm/Xóa Boss đang Focus vào d/s đồ sát BOSS" } : new string[2] { "/addboss", "Add/Remove Boss focus to list BOSS murdering" },
		(GClass62.int_0 == 0) ? new string[2] { "/listbossclr", "Xóa sạch danh sách BOSS đồ sát" } : new string[2] { "/listbossclr", "Clear list BOSS murdering" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsbskill", "Add/Remove Skill focus to list BOSS Skill murdering" } : new string[2] { "/dsbskill", "Thêm/Xóa Skill đang Focus vào d/s skill đồ sát" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsnskill", "Add/Remove Skill focus to list Char Skill murdering" } : new string[2] { "/dsnskill", "Thêm/Xóa Skill đang Focus vào d/s skill đồ sát người" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsqskillX", "Add/Remove Skill ID X to list Mob Skill murdering" } : new string[2] { "/dsqskillX", "Thêm/Xóa Skill ID X vào d/s skill đồ sát quái" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsbskillclr", "Clear list BOSS Skill murdering" } : new string[2] { "/dsbskillclr", "Xóa sạch danh sách Skill đồ sát BOSS" },
		(GClass62.int_0 == 0) ? new string[2] { "/dsbig", "Thêm/Xóa Boss đang Focus vào d/s ko đồ sát BOSS" } : new string[2] { "/dsbig", "Add/Remove Boss focus to list BOSS not murdering" },
		(GClass62.int_0 == 0) ? new string[2] { "/dsn", "Bật/Tắt tự động đồ sát người" } : new string[2] { "/dsn", "Turn on/off auto murdering character" },
		(GClass62.int_0 == 0) ? new string[2] { "/xmpX", "Auto nextmap tới map id X" } : new string[2] { "/xmpX", "Auto move to map ID X" },
		(GClass62.int_0 != 0) ? new string[2] { "/autobuytdlt", "Turn on/off auto buy Auto Train" } : new string[2] { "/autobuytdlt", "Bật/Tắt tự động mua TĐLT" },
		(GClass62.int_0 == 0) ? new string[2] { "/autobuykt", "Bật/Tắt tự động mua khẩu trang" } : new string[2] { "/autobuykt", "Turn on/off auto buy mask" },
		(GClass62.int_0 == 0) ? new string[2] { "/addchar", "Thêm/Xóa người đang Focus vào d/s đồ sát người" } : new string[2] { "/addchar", "Add/Remove char focus to list Char murdering" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsnig", "Add/Remove char focus to List Char not-murdering" } : new string[2] { "/dsnig", "Thêm/Xóa người đang Focus vào d/s ko đồ sát người" },
		(GClass62.int_0 != 0) ? new string[2] { "/addcharX", "Add/Remove char have ID X to list Char murdering" } : new string[2] { "/addcharX", "Thêm/Xóa người id X vào d/s đồ sát người" },
		(GClass62.int_0 == 0) ? new string[2] { "/dsnigX", "Thêm/Xóa người id X vào d/s ko đồ sát người" } : new string[2] { "/dsnigX", "Add/Remove char have ID X to list Char not-murdering" },
		(GClass62.int_0 != 0) ? new string[2] { "/addclan", "Add/Remove clan of char focus to list Clan murdering" } : new string[2] { "/addclan", "Thêm/Xóa bang của người đang Focus vào d/s đồ sát người theo bang" },
		(GClass62.int_0 == 0) ? new string[2] { "/blockitemX", "Thêm/Xóa item id X vào d/s không nhặt vp theo ID" } : new string[2] { "/blockitemX", "Add/Remove item id X to list do not pick item by ID" },
		(GClass62.int_0 == 0) ? new string[2] { "/blockitemtX", "Thêm/Xóa item type X vào d/s không nhặt vp theo Type" } : new string[2] { "/blockitemtX", "Add/Remove item type X to list do not pick item by type" },
		(GClass62.int_0 != 0) ? new string[2] { "/addclanX", "Add/Remove clan ID X to list Clan murdering" } : new string[2] { "/addclanX", "Thêm/Xóa bang id X vào d/s đồ sát người theo bang" },
		(GClass62.int_0 != 0) ? new string[2] { "/kmt", "Turn on/off auto lock object [char/mob/boss]" } : new string[2] { "/kmt", "Bật/Tắt tự động khóa mục tiêu người/quái/boss" },
		(GClass62.int_0 == 0) ? new string[2] { "/kmtX", "Bật/Tắt khóa mục tiêu người có id là X" } : new string[2] { "/kmtX", "Turn on/off lock object have id X" },
		(GClass62.int_0 != 0) ? new string[2] { "/pem1hit", "Turn on/off attack mob to 1 HP" } : new string[2] { "/pem1hit", "Bật/Tắt đánh quái 1 hit còn 1 HP" },
		(GClass62.int_0 != 0) ? new string[2] { "/bosshpX", "Only attack boss HP < X HP [X = 0 -> Attack all]" } : new string[2] { "/bosshpX", "Chỉ đánh BOSS dưới X HP [X = 0 -> Đánh tất cả]" },
		(GClass62.int_0 != 0) ? new string[2] { "/charhpX", "Only attack char HP < X HP [X = 0 -> Attack all]" } : new string[2] { "/charhpX", "Chỉ đánh người dưới X HP [X = 0 -> Đánh tất cả]" },
		(GClass62.int_0 != 0) ? new string[2] { "/rspeedX", "Change run speed to X" } : new string[2] { "/rspeedX", "Chỉnh tốc độ chạy thành X" },
		(GClass62.int_0 == 0) ? new string[2] { "/gspeedX", "Chỉnh tốc độ game thành X" } : new string[2] { "/gspeedX", "Change game speed to X" },
		(GClass62.int_0 == 0) ? new string[2] { "/afriend", "Kết bạn với đối tượng đang focus" } : new string[2] { "/afriend", "Add friend with char focus" },
		(GClass62.int_0 != 0) ? new string[2] { "/afriendX", "Add friend with object have ID X" } : new string[2] { "/afriendX", "Kết bạn với đối tượng có ID là X" },
		(GClass62.int_0 != 0) ? new string[2] { "/teleX", "Turn on/off auto teleport to char ID X [X = -1 => Off]" } : new string[2] { "/teleX", "Bật/Tắt tự động teleport dí mục tiêu [X = -1 => Tắt]" },
		(GClass62.int_0 == 0) ? new string[2] { "/psq", "Bật/Tắt chỉ đánh siêu quái" } : new string[2] { "/psq", "Turn on/off only attack super mob" },
		(GClass62.int_0 == 0) ? new string[2] { "/getitem", "Vẽ ra file Danh sách item hiện có trong game" } : new string[2] { "/getitem", "Write List item ID in game" },
		(GClass62.int_0 != 0) ? new string[2] { "/rX", "Move to right X unit" } : new string[2] { "/rX", "Dịch tọa độ sang phải X đơn vị" },
		(GClass62.int_0 != 0) ? new string[2] { "/lX", "Move to left X unit" } : new string[2] { "/lX", "Dịch tọa độ sang trái X đơn vị" },
		(GClass62.int_0 == 0) ? new string[2] { "/uX", "Dịch tọa độ lên trên X đơn vị" } : new string[2] { "/uX", "Move up X unit" },
		(GClass62.int_0 != 0) ? new string[2] { "/dX", "Move down X unit" } : new string[2] { "/dX", "Dịch tọa độ xuống dưới X đơn vị" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsq", "Turn on/off auto murdering mob" } : new string[2] { "/dsq", "Bật/Tắt tự động đồ sát quái" },
		(GClass62.int_0 == 0) ? new string[2] { "/nsq", "Bật/Tắt đồ sát né siêu quái" } : new string[2] { "/nsq", "Turn on/off not-murdering super mob" },
		(GClass62.int_0 != 0) ? new string[2] { "/additem", "Add/Remove item focus to list pick item by ID" } : new string[2] { "/additem", "Thêm/Xóa item đang Focus vào d/s nhặt item theo ID" },
		(GClass62.int_0 == 0) ? new string[2] { "/additemX", "Thêm/Xóa item ID X vào d/s nhặt item theo ID" } : new string[2] { "/additemX", "Add/Remove item id X to list pick item by ID" },
		(GClass62.int_0 != 0) ? new string[2] { "/addmob", "Add/Remove mob at location focus to list murdering by location" } : new string[2] { "/addmob", "Thêm/Xóa quái ở vị trí đang Focus vào d/s đánh quái theo vị trí" },
		(GClass62.int_0 != 0) ? new string[2] { "/addmobX", "Add/Remove mob at location X to list murdering by location" } : new string[2] { "/addmobX", "Thêm/Xóa quái ở vị trí X vào d/s đánh quái theo vị trí" },
		(GClass62.int_0 == 0) ? new string[2] { "/additemt", "Thêm/Xóa loại item đang Focuus vào d/s nhặt item theo loại" } : new string[2] { "/additemt", "Add/Remove type item focus to list pick item by type" },
		(GClass62.int_0 == 0) ? new string[2] { "/additemtX", "Thêm/Xóa loại item type X vào d/s nhặt item theo loại" } : new string[2] { "/additemtX", "Add/Remove type item X to list pick item by type" },
		(GClass62.int_0 != 0) ? new string[2] { "/addmobt", "Add/Remove type mob focus to list murdering mob by type" } : new string[2] { "/addmobt", "Thêm/Xóa loại quái đang Focuus vào d/s đánh quái theo loại" },
		(GClass62.int_0 == 0) ? new string[2] { "/addmobtX", "Thêm/Xóa loại quái type X vào d/s đánh quái theo loại" } : new string[2] { "/addmobtX", "Add/Remove type mob X to list murdering mob by type" },
		(GClass62.int_0 != 0) ? new string[2] { "/anhat", "Turn on/off auto pick item" } : new string[2] { "/anhat", "Bật/Tắt tự động nhặt Item" },
		(GClass62.int_0 != 0) ? new string[2] { "/itemme", "Turn on/off only pick my item" } : new string[2] { "/itemme", "Bật/Tắt chỉ nhặt vật phẩm của bản thân" },
		(GClass62.int_0 != 0) ? new string[2] { "/dsnv", "Turn on/off show list character in map" } : new string[2] { "/dsnv", "Bật/Tắt hiển thị d/s nhân vật trong map" },
		(GClass62.int_0 != 0) ? new string[2] { "/oinf", "Turn on/off show object details" } : new string[2] { "/oinf", "Bật/Tắt hiển thị thông tin đối tượng đang Focus" },
		(GClass62.int_0 != 0) ? new string[2] { "/autoskillX", "Turn on/off auto use skill after X ms (X = 0 -> Off)" } : new string[2] { "/autoskillX", "Bật/Tắt tự động dùng chiêu sau X ms (X = 0 -> Tắt)" },
		(GClass62.int_0 == 0) ? new string[2] { "/autoskill", "Tắt tự động dùng chiêu theo thời gian" } : new string[2] { "/autoskill", "Turn off auto use skill by item" },
		(GClass62.int_0 != 0) ? new string[2] { "/rcvs", "Turn on/off go to recover skills at W.M.T.23" } : new string[2] { "/rcvs", "Bật/Tắt tự động đi hồi skills tại ĐHVT23" },
		(GClass62.int_0 != 0) ? new string[2] { "/ats9", "Turn on/off auto train special skill (Skill 9)" } : new string[2] { "/ats9", "Bật/Tắt tự động luyện tuyệt kỹ (Skill 9)" },
		(GClass62.int_0 == 0) ? new string[2] { "/cd", "Bật/Tắt tự động cho đậu" } : new string[2] { "/cd", "Turn on/off auto give bean" },
		(GClass62.int_0 == 0) ? new string[2] { "/td", "Bật/Tắt tự động thu và cất đậu vào rương đồ" } : new string[2] { "/td", "Turn on/off auto collect bean" },
		(GClass62.int_0 == 0) ? new string[2] { "/xd", "Bật/Tắt tự động xin đậu" } : new string[2] { "/xd", "Turn on/off auto request bean" },
		(GClass62.int_0 == 0) ? new string[2] { "/ajump", "Bật/Tắt tự động nhảy vị trí nhỏ" } : new string[2] { "/ajump", "Turn on/off auto jump" },
		(GClass62.int_0 == 0) ? new string[2] { "/mobhpX", "Bật/Tắt giới hạn HP quái đồ sát" } : new string[2] { "/mobhpX", "Turn on/off limit mob HP murdering" },
		(GClass62.int_0 != 0) ? new string[2] { "/petinfo", "Turn on/off show disciple details" } : new string[2] { "/petinfo", "Bật/Tắt hiển thị thông tin đệ tử" },
		(GClass62.int_0 == 0) ? new string[2] { "/vdh", "Bật/Tắt di chuyển vượt địa hình" } : new string[2] { "/vdh", "Turn on/off move cross terrain" },
		(GClass62.int_0 == 0) ? new string[2] { "/dtnsq", "Bật/Tắt tự động train đệ tử né siêu quái" } : new string[2] { "/dtnsq", "Turn on/off auto train disciple in protect mode" },
		(GClass62.int_0 != 0) ? new string[2] { "/aheal", "Turn on/off auto healing by list" } : new string[2] { "/aheal", "Bật/Tắt tự động trị thương theo danh sách" },
		(GClass62.int_0 != 0) ? new string[2] { "/addcheal", "Add/Remove char focus to list healing" } : new string[2] { "/addcheal", "Thêm/Xóa người đang Focus vào danh sách trị thương" },
		(GClass62.int_0 != 0) ? new string[2] { "/addchealX", "Add/Remove char ID X to list healing" } : new string[2] { "/addchealX", "Thêm/Xóa người ID X vào danh sách trị thương" },
		(GClass62.int_0 != 0) ? new string[2] { "/pethpX", "Turn on/off auto use bean when disciple HP < X% HP (X = 0 -> Off)" } : new string[2] { "/pethpX", "Bật/Tắt tự động dùng đậu khi đệ tử dưới X% HP (X = 0 -> Tắt)" },
		(GClass62.int_0 != 0) ? new string[2] { "/gohome", "Turn on/off auto let pet go home" } : new string[2] { "/gohome", "Bật/Tắt tự động cho đệ tử về nhà sau khi tách hợp thể" },
		(GClass62.int_0 != 0) ? new string[2] { "/petsmX", "Turn on/off limited disciple power (X = 0 -> Off)" } : new string[2] { "/petsmX", "Bật/Tắt tự động thoát game khi đệ tử đạt X sức mạnh (X = 0 -> Tắt)" },
		(GClass62.int_0 != 0) ? new string[2] { "/ahs", "Turn on/off auto revive" } : new string[2] { "/ahs", "Bật/Tắt tự động dùng ngọc hồi sinh" },
		(GClass62.int_0 == 0) ? new string[2] { "/hpX", "Bật/Tắt tự động nâng X HP" } : new string[2] { "/hpX", "Turn on/off auto upgrade X HP" },
		(GClass62.int_0 != 0) ? new string[2] { "/mpX", "Turn on/off auto upgrade X MP" } : new string[2] { "/mpX", "Bật/Tắt tự động nâng X KI" },
		(GClass62.int_0 != 0) ? new string[2] { "/dmgX", "Turn on/off auto upgrade X DMG" } : new string[2] { "/dmgX", "Bật/Tắt tự động nâng X SĐ" },
		(GClass62.int_0 != 0) ? new string[2] { "/abtX Y", "Turn on/off auto use porata when HP,KI < X%,Y (X = 0 -> Off)" } : new string[2] { "/abtX Y", "Bật/Tắt tự động dùng bông tai khi HP,KI < X%,Y% (X = 0 -> Tắt)" },
		(GClass62.int_0 != 0) ? new string[2] { "/alg", "Turn on/off auto login after disconnect [Default: ON]" } : new string[2] { "/alg", "Bật/Tắt tự động đăng nhập lại game khi MKN [Mặc định Bật]" },
		(GClass62.int_0 != 0) ? new string[2] { "/kz", "Turn off auto change one" } : new string[2] { "/kz", "Tắt tự động đổi khu" },
		(GClass62.int_0 != 0) ? new string[2] { "/kzX", "Turn on auto change zone X" } : new string[2] { "/kzX", "Bật tự động đổi sang khu X" },
		(GClass62.int_0 != 0) ? new string[2] { "/smap", "Save detail current Map [GOBACK]" } : new string[2] { "/smap", "Lưu thông tin map đang đứng [GOBACK]" },
		(GClass62.int_0 != 0) ? new string[2] { "/szone", "Save detail current Zone [GOBACK]" } : new string[2] { "/szone", "Lưu thông tin khu đang đứng [GOBACK]" },
		(GClass62.int_0 != 0) ? new string[2] { "/spos", "Save detail current position [GOBACK]" } : new string[2] { "/spos", "Lưu thông tin vị trí đang đứng [GOBACK]" },
		(GClass62.int_0 == 0) ? new string[2] { "/lcz", "Bật/Tắt khóa chuyển khu" } : new string[2] { "/lcz", "Turn on/off lock change zone" },
		(GClass62.int_0 != 0) ? new string[2] { "/lcm", "Turn on/off lock change map" } : new string[2] { "/lcm", "Bật/Tắt khóa chuyển map" },
		(GClass62.int_0 == 0) ? new string[2] { "/cvs", "Tắt tự động dùng huýt sáo cho đối phương" } : new string[2] { "/cvs", "Turn off auto use whistle" },
		(GClass62.int_0 == 0) ? new string[2] { "/dropitem", "Bật/Tắt tự động vứt VP rác (nr4-7s,mđv,...)" } : new string[2] { "/dropitem", "Turn on/off auto drop trash item" },
		(GClass62.int_0 != 0) ? new string[2] { "/clrlistdrop", "Clear list item ID drop" } : new string[2] { "/clrlistdrop", "Xóa danh sách vứt vp" },
		(GClass62.int_0 != 0) ? new string[2] { "/aflag", "Turn on/off auto get grey flag" } : new string[2] { "/aflag", "Bật/Tắt tự động mặc cờ xám" },
		(GClass62.int_0 == 0) ? new string[2] { "/additemdropX", "Thêm/Xóa item id X vào d/s vứt item" } : new string[2] { "/additemdropX", "Add/Remove item id X to/from list drop item" },
		(GClass62.int_0 == 0) ? new string[2] { "/additemdrophsdX", "Thêm/Xóa item id X vào d/s vứt item theo HSD" } : new string[2] { "/additemdrophsdX", "Add/Remove item id X to/from list drop item theo HSD" },
		(GClass62.int_0 != 0) ? new string[2] { "/cvsX", "Turn on/off auto use whistle for obj when obj HP < X% HP [X = 0 -> Off]" } : new string[2] { "/cvsX", "Bật/Tắt tự động dùng huýt sáo khi đối phương dưới X% HP (X = 0 -> Tắt)" },
		(GClass62.int_0 == 0) ? new string[2] { "/cvsX Y", "Bật/Tắt tự động dùng huýt sáo khi người ID X dưới Y% HP (X = 0 -> Tắt)" } : new string[2] { "/cvsX", "Turn on/off auto use whistle for obj ID X when obj HP < Y% HP [X = 0 -> Off]" },
		(GClass62.int_0 != 0) ? new string[2] { "/isell", "Turn on/off auto sell trash item, use sharp, drop item..." } : new string[2] { "/isell", "Bật/Tắt tự động bán đồ rác, sử dụng mảnh quái, vứt item thừa,.." },
		(GClass62.int_0 == 0) ? new string[2] { "/actg", "Bật/Tắt tự động chat thế giới (10s 1 lần)" } : new string[2] { "/actg", "Turn on/off auto global chat (delay 10sec)" },
		(GClass62.int_0 == 0) ? new string[2] { "/citemX Y", "Bật/Tắt tự động thoát game khi nhặt đủ Y số lượng item id X (X, Y = 0 -> Tắt)" } : new string[2] { "/citemX Y", "Turn on/off auto quit when picked Y quantity of item ID X [X,Y=0 -> Off" },
		(GClass62.int_0 != 0) ? new string[2] { "/vqtd", "Show menu auto crack spin ball [Use at SamaPlace]" } : new string[2] { "/vqtd", "Hiển thị menu vòng quay thượng đế [Dùng ở Thần điện]" },
		(GClass62.int_0 != 0) ? new string[2] { "/hide", "Turn on/off show information on screen" } : new string[2] { "/hide", "Bật/Tắt hiển thị thông tin map,khu,vị trí, hp,ki,..." },
		(GClass62.int_0 != 0) ? new string[2] { "/optm", "Turn on/off optimize CPU" } : new string[2] { "/optm", "Bật/Tắt tối ưu CPU, khiến game nhẹ hơn" },
		(GClass62.int_0 == 0) ? new string[2] { "/achat_X", "Bật/Tắt tự động chat nội dung X (Nếu không nhập X -> Tắt)" } : new string[2] { "/achat_X", "Turn on/off auto chat text X" },
		(GClass62.int_0 == 0) ? new string[2] { "/listmobclr", "Xóa danh sách quái đồ sát" } : new string[2] { "/listmobclr", "Clear list mobs murdering" },
		(GClass62.int_0 == 0) ? new string[2] { "/dsqskillclr", "Xóa danh sách skill đồ sát quái" } : new string[2] { "/dsqskillclr", "Clear list skill use when mobs murdering" },
		(GClass62.int_0 == 0) ? new string[2] { "/nrdX Y", "Bật/Tắt tự động vào map NRSĐ X sao khu Y" } : new string[2] { "/nrdX Y", "Turn on/off auto go map BlackStarDB X star zone Y" },
		(GClass62.int_0 == 0) ? new string[2] { "/ats9g", "Bật/Tắt tự động train tuyệt kỹ bằng vàng" } : new string[2] { "/ats9g", "Turn on/off auto train special skill with gold" }
	};

	private Class7()
	{
		list_1 = list_1.OrderBy((string[] h) => h[0]).ToList();
	}

	internal static Class7 smethod_0()
	{
		return class7_0;
	}

	internal int method_2()
	{
		return (GClass193.int_12 > 1) ? 280 : 350;
	}

	internal int method_4()
	{
		return (list_0.Count < 10) ? list_0.Count : 10;
	}

	public void method_0()
	{
		bool_0 = true;
		int_0 = 0;
		int_1 = 0;
		string_0 = null;
		list_0 = list_1;
	}

	internal void method_1()
	{
		try
		{
			bool_0 = GClass107.smethod_0().bool_0;
			if (!bool_0)
			{
				list_0 = null;
				return;
			}
			GClass136 gclass136_ = GClass107.smethod_0().gclass136_0;
			if (gclass136_ == null)
				return;
			if (gclass136_.method_21().Length != 0 && gclass136_.method_21()[0] == '/')
			{
				if (this.string_0 != gclass136_.method_21())
				{
					int_0 = 0;
					int_1 = 0;
					this.string_0 = gclass136_.method_21();
					string string_0 = this.string_0.Substring(1);
					list_0 = list_1.FindAll((string[] h) => h[0].Contains(string_0) || h[1].Contains(string_0));
				}
				if (GClass14.bool_11[22])
				{
					int_0++;
					if (int_0 > list_0.Count - 1)
						int_0 = 0;
					GClass14.bool_11[22] = false;
					GClass14.smethod_26();
					GClass14.smethod_27();
				}
				else if (!GClass14.bool_11[21])
				{
					if (GClass14.bool_11[16])
					{
						if (this.string_0 != list_0[int_0][0])
							gclass136_.method_23(list_0[int_0][0]);
						GClass14.bool_11[16] = false;
						GClass14.smethod_26();
						GClass14.smethod_27();
					}
				}
				else
				{
					int_0--;
					if (int_0 < 0)
						int_0 = list_0.Count - 1;
					GClass14.bool_11[21] = false;
					GClass14.smethod_26();
					GClass14.smethod_27();
				}
				if (int_0 >= int_1 + 10)
					int_1 = int_0 - 9;
				if (int_0 < int_1)
					int_1 = int_0;
			}
			else
			{
				this.string_0 = null;
				bool_0 = false;
			}
		}
		catch (Exception ex)
		{
			GClass51.smethod_0("Data/Errors/updateSuggestionCommand.ini", ex.ToString());
		}
	}

	internal void method_2(GClass193 gclass193_0)
	{
		try
		{
			if (!bool_0 || string.IsNullOrEmpty(string_0))
				return;
			GClass107 gClass = GClass107.smethod_0();
			int_3 = (method_4() + 1) * 10;
			int_2 = ((GClass14.int_10 - 10 > method_2()) ? method_2() : (GClass14.int_10 - 10));
			int h = method_4() * (int_3 - 10) / list_0.Count;
			int_4 = (GClass14.int_10 - int_2) / 2;
			int_5 = gClass.gclass136_0.int_1 - 40 - int_3;
			gclass193_0.method_20(0, 0.5f);
			gclass193_0.method_15(int_4, int_5, int_2, int_3);
			gclass193_0.method_20(0, 1f);
			gclass193_0.method_15(int_4, int_5, int_2, 10);
			int x = int_4 + int_2 - GClass104.gclass104_20.method_17((GClass62.int_0 == 0) ? "Nhấn Tab để lựa chọn" : "Press Tab to select") - 5;
			GClass104.gclass104_20.method_6(gclass193_0, (GClass62.int_0 != 0) ? "Press Tab to select" : "Nhấn Tab để lựa chọn", x, int_5, 0);
			gclass193_0.method_20(16777215, 0.5f);
			gclass193_0.method_15(int_4, int_5 + 10 - 1, int_2, 1);
			gclass193_0.method_20(8618883, 0.75f);
			gclass193_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), int_2 - 5, 10);
			gclass193_0.method_20(16777215, 0.75f);
			gclass193_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), 2, 10);
			gclass193_0.method_20(16777215, 0.75f);
			gclass193_0.method_15(int_4 + int_2 - 5, int_5 + 10, 1, int_3 - 10);
			gclass193_0.method_20(16777215, 0.75f);
			gclass193_0.method_15(int_4 + int_2 - 3, int_5 + 10 + int_1 * (int_3 - 10) / list_0.Count, 2, h);
			for (int i = int_1; i < int_1 + method_4(); i++)
			{
				if (!string.IsNullOrEmpty(list_0[i][0]) && !string.IsNullOrEmpty(list_0[i][1]))
					GClass104.gclass104_15.method_6(gclass193_0, list_0[i][0] + " :" + list_0[i][1], int_4 + 5, int_5 + 10 + 10 * (i - int_1), 0);
			}
		}
		catch (Exception ex)
		{
			GClass51.smethod_0("Data/Errors/ErrorSuggestCommand.txt", ex.Message);
		}
	}

	public void method_3()
	{
		string text = string.Empty;
		for (int i = 0; i < list_0.Count; i++)
		{
			text = text + list_0[i][0] + " :" + list_0[i][1] + "\n";
		}
		File.WriteAllText("AdSense.txt", text);
	}
}
