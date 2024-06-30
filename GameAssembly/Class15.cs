using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ns1;

internal class Class15
{
	private static readonly Class15 class15_0 = new Class15();

	internal int int_0;

	internal bool tCllAfSugy;

	internal int int_1;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	private string string_0 = string.Empty;

	private List<string[]> list_0;

	private List<string[]> list_1 = new List<string[]>
	{
		(GClass192.int_0 != 0) ? new string[2] { "/tbb", "Turn off/on show list boss appear information" } : new string[2] { "/tbb", "Bật/Tắt hiển thị d/s thông báo BOSS" },
		(GClass192.int_0 != 0) ? new string[2] { "/cobj", "Turn off/on auto change object" } : new string[2] { "/cobj", "Bật/Tắt tự động chuyển mục tiêu" },
		(GClass192.int_0 != 0) ? new string[2] { "/dsb", "Turn off/on auto murdering BOSS" } : new string[2] { "/dsb", "Bật/Tắt tự động đồ sát BOSS" },
		(GClass192.int_0 != 0) ? new string[2] { "/abdkbX", "Turn off/on auto open TreasureUnderSea LvlX" } : new string[2] { "/abdkbX", "Bật/Tắt tự động mở BDKB level X" },
		(GClass192.int_0 != 0) ? new string[2] { "/abfX Y", "Turn off/on auto use bean if HP,KI < X%, Y%" } : new string[2] { "/abfX Y", "Bật/Tắt tự động ăn đậu khi HP,KI < X%, Y%" },
		(GClass192.int_0 != 0) ? new string[2] { "/badd", "Add/Remove Boss focus to list BOSS murdering" } : new string[2] { "/badd", "Thêm/Xóa Boss đang Focus vào d/s đồ sát BOSS" },
		(GClass192.int_0 != 0) ? new string[2] { "/bclear", "Clear list BOSS murdering" } : new string[2] { "/bclear", "Xóa sạch danh sách BOSS đồ sát" },
		(GClass192.int_0 != 0) ? new string[2] { "/addskill", "Add/Remove Skill focus to list BOSS Skill murdering" } : new string[2] { "/addskill", "Thêm/Xóa Skill đang Focus vào d/s skill đồ sát" },
		(GClass192.int_0 != 0) ? new string[2] { "/saddX", "Add/Remove Skill ID X to list BOSS Skill murdering" } : new string[2] { "/saddX", "Thêm/Xóa Skill ID X vào d/s skill đồ sát" },
		(GClass192.int_0 != 0) ? new string[2] { "/clearskill", "Clear list BOSS Skill murdering" } : new string[2] { "/clearskill", "Xóa sạch danh sách Skill đồ sát BOSS" },
		(GClass192.int_0 != 0) ? new string[2] { "/bignore", "Add/Remove Boss focus to list BOSS not murdering" } : new string[2] { "/bignore", "Thêm/Xóa Boss đang Focus vào d/s ko đồ sát BOSS" },
		(GClass192.int_0 != 0) ? new string[2] { "/dsn", "Turn on/off auto murdering character" } : new string[2] { "/dsn", "Bật/Tắt tự động đồ sát người" },
		(GClass192.int_0 != 0) ? new string[2] { "/xmpX", "Auto move to map ID X" } : new string[2] { "/xmpX", "Auto nextmap tới map id X" },
		(GClass192.int_0 != 0) ? new string[2] { "/autobuytdlt", "Turn on/off auto buy Auto Train" } : new string[2] { "/autobuytdlt", "Bật/Tắt tự động mua TĐLT" },
		(GClass192.int_0 != 0) ? new string[2] { "/autobuykt", "Turn on/off auto buy mask" } : new string[2] { "/autobuykt", "Bật/Tắt tự động mua khẩu trang" },
		(GClass192.int_0 != 0) ? new string[2] { "/cadd", "Add/Remove char focus to list Char murdering" } : new string[2] { "/cadd", "Thêm/Xóa người đang Focus vào d/s đồ sát người" },
		(GClass192.int_0 != 0) ? new string[2] { "/cignore", "Add/Remove char focus to List Char not-murdering" } : new string[2] { "/cignore", "Thêm/Xóa người đang Focus vào d/s ko đồ sát người" },
		(GClass192.int_0 != 0) ? new string[2] { "/caddX", "Add/Remove char have ID X to list Char murdering" } : new string[2] { "/caddX", "Thêm/Xóa người id X vào d/s đồ sát người" },
		(GClass192.int_0 != 0) ? new string[2] { "/cignoreX", "Add/Remove char have ID X to list Char not-murdering" } : new string[2] { "/cignoreX", "Thêm/Xóa người id X vào d/s ko đồ sát người" },
		(GClass192.int_0 != 0) ? new string[2] { "/clanadd", "Add/Remove clan of char focus to list Clan murdering" } : new string[2] { "/clanadd", "Thêm/Xóa bang của người đang Focus vào d/s đồ sát người theo bang" },
		(GClass192.int_0 != 0) ? new string[2] { "/iblockX", "Add/Remove item id X to list do not pick item by ID" } : new string[2] { "/iblockX", "Thêm/Xóa item id X vào d/s không nhặt vp theo ID" },
		(GClass192.int_0 != 0) ? new string[2] { "/iblocktX", "Add/Remove item type X to list do not pick item by type" } : new string[2] { "/iblocktX", "Thêm/Xóa item type X vào d/s không nhặt vp theo Type" },
		(GClass192.int_0 != 0) ? new string[2] { "/clanaddX", "Add/Remove clan ID X to list Clan murdering" } : new string[2] { "/clanaddX", "Thêm/Xóa bang id X vào d/s đồ sát người theo bang" },
		(GClass192.int_0 != 0) ? new string[2] { "/kmt", "Turn on/off auto lock object [char/mob/boss]" } : new string[2] { "/kmt", "Bật/Tắt tự động khóa mục tiêu người/quái/boss" },
		(GClass192.int_0 != 0) ? new string[2] { "/kmtX", "Turn on/off lock object have id X" } : new string[2] { "/kmtX", "Bật/Tắt khóa mục tiêu người có id là X" },
		(GClass192.int_0 != 0) ? new string[2] { "/pem1hit", "Turn on/off attack mob to 1 HP" } : new string[2] { "/pem1hit", "Bật/Tắt đánh quái 1 hit còn 1 HP" },
		(GClass192.int_0 != 0) ? new string[2] { "/bosshpX", "Only attack boss HP < X HP [X = 0 -> Attack all]" } : new string[2] { "/bosshpX", "Chỉ đánh BOSS dưới X HP [X = 0 -> Đánh tất cả]" },
		(GClass192.int_0 != 0) ? new string[2] { "/charhpX", "Only attack char HP < X HP [X = 0 -> Attack all]" } : new string[2] { "/charhpX", "Chỉ đánh người dưới X HP [X = 0 -> Đánh tất cả]" },
		(GClass192.int_0 != 0) ? new string[2] { "/rspeedX", "Change run speed to X" } : new string[2] { "/rspeedX", "Chỉnh tốc độ chạy thành X" },
		(GClass192.int_0 != 0) ? new string[2] { "/gspeedX", "Change game speed to X" } : new string[2] { "/gspeedX", "Chỉnh tốc độ game thành X" },
		(GClass192.int_0 != 0) ? new string[2] { "/afriend", "Add friend with char focus" } : new string[2] { "/afriend", "Kết bạn với đối tượng đang focus" },
		(GClass192.int_0 != 0) ? new string[2] { "/afriendX", "Add friend with object have ID X" } : new string[2] { "/afriendX", "Kết bạn với đối tượng có ID là X" },
		(GClass192.int_0 != 0) ? new string[2] { "/teleX", "Turn on/off auto teleport to char ID X [X = -1 => Off]" } : new string[2] { "/teleX", "Bật/Tắt tự động teleport dí mục tiêu [X = -1 => Tắt]" },
		(GClass192.int_0 != 0) ? new string[2] { "/psq", "Turn on/off only attack super mob" } : new string[2] { "/psq", "Bật/Tắt chỉ đánh siêu quái" },
		(GClass192.int_0 != 0) ? new string[2] { "/getitem", "Write List item ID in game" } : new string[2] { "/getitem", "Vẽ ra file Danh sách item hiện có trong game" },
		(GClass192.int_0 != 0) ? new string[2] { "/rX", "Move to right X unit" } : new string[2] { "/rX", "Dịch tọa độ sang phải X đơn vị" },
		(GClass192.int_0 != 0) ? new string[2] { "/lX", "Move to left X unit" } : new string[2] { "/lX", "Dịch tọa độ sang trái X đơn vị" },
		(GClass192.int_0 != 0) ? new string[2] { "/uX", "Move up X unit" } : new string[2] { "/uX", "Dịch tọa độ lên trên X đơn vị" },
		(GClass192.int_0 != 0) ? new string[2] { "/dX", "Move down X unit" } : new string[2] { "/dX", "Dịch tọa độ xuống dưới X đơn vị" },
		(GClass192.int_0 != 0) ? new string[2] { "/dsq", "Turn on/off auto murdering mob" } : new string[2] { "/dsq", "Bật/Tắt tự động đồ sát quái" },
		(GClass192.int_0 != 0) ? new string[2] { "/nsq", "Turn on/off not-murdering super mob" } : new string[2] { "/nsq", "Bật/Tắt đồ sát né siêu quái" },
		(GClass192.int_0 != 0) ? new string[2] { "/iadd", "Add/Remove item focus to list pick item by ID" } : new string[2] { "/iadd", "Thêm/Xóa item đang Focus vào d/s nhặt item theo ID" },
		(GClass192.int_0 != 0) ? new string[2] { "/iaddX", "Add/Remove item id X to list pick item by ID" } : new string[2] { "/iaddX", "Thêm/Xóa item ID X vào d/s nhặt item theo ID" },
		(GClass192.int_0 != 0) ? new string[2] { "/madd", "Add/Remove mob at location focus to list murdering by location" } : new string[2] { "/madd", "Thêm/Xóa quái ở vị trí đang Focus vào d/s đánh quái theo vị trí" },
		(GClass192.int_0 != 0) ? new string[2] { "/maddX", "Add/Remove mob at location X to list murdering by location" } : new string[2] { "/maddX", "Thêm/Xóa quái ở vị trí X vào d/s đánh quái theo vị trí" },
		(GClass192.int_0 != 0) ? new string[2] { "/iaddt", "Add/Remove type item focus to list pick item by type" } : new string[2] { "/iaddt", "Thêm/Xóa loại item đang Focuus vào d/s nhặt item theo loại" },
		(GClass192.int_0 != 0) ? new string[2] { "/iaddtX", "Add/Remove type item X to list pick item by type" } : new string[2] { "/iaddtX", "Thêm/Xóa loại item type X vào d/s nhặt item theo loại" },
		(GClass192.int_0 != 0) ? new string[2] { "/maddt", "Add/Remove type mob focus to list murdering mob by type" } : new string[2] { "/maddt", "Thêm/Xóa loại quái đang Focuus vào d/s đánh quái theo loại" },
		(GClass192.int_0 != 0) ? new string[2] { "/maddtX", "Add/Remove type mob X to list murdering mob by type" } : new string[2] { "/maddtX", "Thêm/Xóa loại quái type X vào d/s đánh quái theo loại" },
		(GClass192.int_0 != 0) ? new string[2] { "/anhat", "Turn on/off auto pick item" } : new string[2] { "/anhat", "Bật/Tắt tự động nhặt Item" },
		(GClass192.int_0 != 0) ? new string[2] { "/itemme", "Turn on/off only pick my item" } : new string[2] { "/itemme", "Bật/Tắt chỉ nhặt vật phẩm của bản thân" },
		(GClass192.int_0 != 0) ? new string[2] { "/dsnv", "Turn on/off show list character in map" } : new string[2] { "/dsnv", "Bật/Tắt hiển thị d/s nhân vật trong map" },
		(GClass192.int_0 != 0) ? new string[2] { "/oinf", "Turn on/off show object details" } : new string[2] { "/oinf", "Bật/Tắt hiển thị thông tin đối tượng đang Focus" },
		(GClass192.int_0 != 0) ? new string[2] { "/akX", "Turn on/off auto use skill after X ms (X = 0 -> Off)" } : new string[2] { "/akX", "Bật/Tắt tự động dùng chiêu sau X ms (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/ak", "Turn off auto use skill by item" } : new string[2] { "/ak", "Tắt tự động dùng chiêu theo thời gian" },
		(GClass192.int_0 != 0) ? new string[2] { "/rcvs", "Turn on/off go to recover skills at W.M.T.23" } : new string[2] { "/rcvs", "Bật/Tắt tự động đi hồi skills tại ĐHVT23" },
		(GClass192.int_0 != 0) ? new string[2] { "/ats9", "Turn on/off auto train special skill (Skill 9)" } : new string[2] { "/ats9", "Bật/Tắt tự động luyện tuyệt kỹ (Skill 9)" },
		(GClass192.int_0 != 0) ? new string[2] { "/cd", "Turn on/off auto give bean" } : new string[2] { "/cd", "Bật/Tắt tự động cho đậu" },
		(GClass192.int_0 != 0) ? new string[2] { "/td", "Turn on/off auto collect bean" } : new string[2] { "/td", "Bật/Tắt tự động thu và cất đậu vào rương đồ" },
		(GClass192.int_0 != 0) ? new string[2] { "/xd", "Turn on/off auto request bean" } : new string[2] { "/xd", "Bật/Tắt tự động xin đậu" },
		(GClass192.int_0 != 0) ? new string[2] { "/ajump", "Turn on/off auto jump" } : new string[2] { "/ajump", "Bật/Tắt tự động nhảy vị trí nhỏ" },
		(GClass192.int_0 != 0) ? new string[2] { "/mobhpX", "Turn on/off limit mob HP murdering" } : new string[2] { "/mobhpX", "Bật/Tắt giới hạn HP quái đồ sát" },
		(GClass192.int_0 != 0) ? new string[2] { "/petinfo", "Turn on/off show disciple details" } : new string[2] { "/petinfo", "Bật/Tắt hiển thị thông tin đệ tử" },
		(GClass192.int_0 != 0) ? new string[2] { "/vdh", "Turn on/off move cross terrain" } : new string[2] { "/vdh", "Bật/Tắt di chuyển vượt địa hình" },
		(GClass192.int_0 != 0) ? new string[2] { "/dtnsq", "Turn on/off auto train disciple in protect mode" } : new string[2] { "/dtnsq", "Bật/Tắt tự động train đệ tử né siêu quái" },
		(GClass192.int_0 != 0) ? new string[2] { "/att", "Turn on/off auto healing by list" } : new string[2] { "/att", "Bật/Tắt tự động trị thương theo danh sách" },
		(GClass192.int_0 != 0) ? new string[2] { "/ttadd", "Add/Remove char focus to list healing" } : new string[2] { "/ttadd", "Thêm/Xóa người đang Focus vào danh sách trị thương" },
		(GClass192.int_0 != 0) ? new string[2] { "/ttaddX", "Add/Remove char ID X to list healing" } : new string[2] { "/ttaddX", "Thêm/Xóa người ID X vào danh sách trị thương" },
		(GClass192.int_0 != 0) ? new string[2] { "/pethpX", "Turn on/off auto use bean when disciple HP < X% HP (X = 0 -> Off)" } : new string[2] { "/pethpX", "Bật/Tắt tự động dùng đậu khi đệ tử dưới X% HP (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/gohome", "Turn on/off auto let pet go home" } : new string[2] { "/gohome", "Bật/Tắt tự động cho đệ tử về nhà sau khi tách hợp thể" },
		(GClass192.int_0 != 0) ? new string[2] { "/petsmX", "Turn on/off limited disciple power (X = 0 -> Off)" } : new string[2] { "/petsmX", "Bật/Tắt tự động thoát game khi đệ tử đạt X sức mạnh (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/ahs", "Turn on/off auto revive" } : new string[2] { "/ahs", "Bật/Tắt tự động dùng ngọc hồi sinh" },
		(GClass192.int_0 != 0) ? new string[2] { "/hpX", "Turn on/off auto upgrade X HP" } : new string[2] { "/hpX", "Bật/Tắt tự động nâng X HP" },
		(GClass192.int_0 != 0) ? new string[2] { "/mpX", "Turn on/off auto upgrade X MP" } : new string[2] { "/mpX", "Bật/Tắt tự động nâng X KI" },
		(GClass192.int_0 != 0) ? new string[2] { "/dmgX", "Turn on/off auto upgrade X DMG" } : new string[2] { "/dmgX", "Bật/Tắt tự động nâng X SĐ" },
		(GClass192.int_0 != 0) ? new string[2] { "/abtX", "Turn on/off auto use porata when HP < X% HP (X = 0 -> Off)" } : new string[2] { "/abtX", "Bật/Tắt tự động dùng bông tai khi dưới X% HP (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/alg", "Turn on/off auto login after disconnect [Default: ON]" } : new string[2] { "/alg", "Bật/Tắt tự động đăng nhập lại game khi MKN [Mặc định Bật]" },
		(GClass192.int_0 != 0) ? new string[2] { "/kz", "Turn off auto change one" } : new string[2] { "/kz", "Tắt tự động đổi khu" },
		(GClass192.int_0 != 0) ? new string[2] { "/kzX", "Turn on auto change zone X" } : new string[2] { "/kzX", "Bật tự động đổi sang khu X" },
		(GClass192.int_0 != 0) ? new string[2] { "/smap", "Save detail current Map [GOBACK]" } : new string[2] { "/smap", "Lưu thông tin map đang đứng [GOBACK]" },
		(GClass192.int_0 != 0) ? new string[2] { "/szone", "Save detail current Zone [GOBACK]" } : new string[2] { "/szone", "Lưu thông tin khu đang đứng [GOBACK]" },
		(GClass192.int_0 != 0) ? new string[2] { "/spos", "Save detail current position [GOBACK]" } : new string[2] { "/spos", "Lưu thông tin vị trí đang đứng [GOBACK]" },
		(GClass192.int_0 != 0) ? new string[2] { "/lcz", "Turn on/off lock change zone" } : new string[2] { "/lcz", "Bật/Tắt khóa chuyển khu" },
		(GClass192.int_0 != 0) ? new string[2] { "/lcm", "Turn on/off lock change map" } : new string[2] { "/lcm", "Bật/Tắt khóa chuyển map" },
		(GClass192.int_0 != 0) ? new string[2] { "/cvs", "Turn off auto use whistle" } : new string[2] { "/cvs", "Tắt tự động dùng huýt sáo cho đối phương" },
		(GClass192.int_0 != 0) ? new string[2] { "/dropitem", "Turn on/off auto drop trash item" } : new string[2] { "/dropitem", "Bật/Tắt tự động vứt VP rác (nr4-7s,mđv,...)" },
		(GClass192.int_0 != 0) ? new string[2] { "/clrlistdrop", "Clear list item ID drop" } : new string[2] { "/clrlistdrop", "Xóa danh sách vứt vp" },
		(GClass192.int_0 != 0) ? new string[2] { "/aflag", "Turn on/off auto get grey flag" } : new string[2] { "/aflag", "Bật/Tắt tự động mặc cờ xám" },
		(GClass192.int_0 != 0) ? new string[2] { "/iddropX", "Add/Remove item id X to/from list drop item" } : new string[2] { "/iddropX", "Thêm/Xóa item id X vào d/s vứt item" },
		(GClass192.int_0 != 0) ? new string[2] { "/iddrophsdX", "Add/Remove item id X to/from list drop item theo HSD" } : new string[2] { "/iddrophsdX", "Thêm/Xóa item id X vào d/s vứt item theo HSD" },
		(GClass192.int_0 != 0) ? new string[2] { "/cvsX", "Turn on/off auto use whistle for obj when obj HP < X% HP [X = 0 -> Off]" } : new string[2] { "/cvsX", "Bật/Tắt tự động dùng huýt sáo khi đối phương dưới X% HP (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/cvsX", "Turn on/off auto use whistle for obj ID X when obj HP < Y% HP [X = 0 -> Off]" } : new string[2] { "/cvsX Y", "Bật/Tắt tự động dùng huýt sáo khi người ID X dưới Y% HP (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/isell", "Turn on/off auto sell trash item, use sharp, drop item..." } : new string[2] { "/isell", "Bật/Tắt tự động bán đồ rác, sử dụng mảnh quái, vứt item thừa,.." },
		(GClass192.int_0 != 0) ? new string[2] { "/mvbtX", "Turn on/off auto quit when picked X potara sharp [X = 0 -> Off]" } : new string[2] { "/mvbtX", "Bật/Tắt tự động thoát game khi nhặt đủ X MVBT (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/mhbtX", "Turn on/off auto quit when picked X potara soul sharp [X = 0 -> Off]" } : new string[2] { "/mhbtX", "Bật/Tắt tự động thoát game khi nhặt đủ X MHBT (X = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/actg", "Turn on/off auto global chat (delay 10sec)" } : new string[2] { "/actg", "Bật/Tắt tự động chat thế giới (10s 1 lần)" },
		(GClass192.int_0 != 0) ? new string[2] { "/citemX Y", "Turn on/off auto quit when picked Y quantity of item ID X [X,Y=0 -> Off" } : new string[2] { "/citemX Y", "Bật/Tắt tự động thoát game khi nhặt đủ Y số lượng item id X (X, Y = 0 -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/vqtd", "Show menu auto crack spin ball [Use at SamaPlace]" } : new string[2] { "/vqtd", "Hiển thị menu vòng quay thượng đế [Dùng ở Thần điện]" },
		(GClass192.int_0 != 0) ? new string[2] { "/hide", "Turn on/off show information on screen" } : new string[2] { "/hide", "Bật/Tắt hiển thị thông tin map,khu,vị trí, hp,ki,..." },
		(GClass192.int_0 != 0) ? new string[2] { "/optm", "Turn on/off optimize CPU" } : new string[2] { "/optm", "Bật/Tắt tối ưu CPU, khiến game nhẹ hơn" },
		(GClass192.int_0 != 0) ? new string[2] { "/achat_X", "Turn on/off auto chat text X" } : new string[2] { "/achat_X", "Bật/Tắt tự động chat nội dung X (Nếu không nhập X -> Tắt)" },
		(GClass192.int_0 != 0) ? new string[2] { "/nrdX Y", "Turn on/off auto go map BlackStarDB X star zone Y" } : new string[2] { "/nrdX Y", "Bật/Tắt tự động vào map NRSĐ X sao khu Y" },
		(GClass192.int_0 != 0) ? new string[2] { "/ats9g", "Turn on/off auto train special skill with gold" } : new string[2] { "/ats9g", "Bật/Tắt tự động train tuyệt kỹ bằng vàng" }
	};

	private Class15()
	{
		list_1 = list_1.OrderBy((string[] h) => h[0]).ToList();
	}

	internal static Class15 smethod_0()
	{
		return class15_0;
	}

	internal int method_0()
	{
		return (GClass76.int_12 > 1) ? 280 : 350;
	}

	internal int method_1()
	{
		return (list_0.Count < 10) ? list_0.Count : 10;
	}

	public void method_2()
	{
		tCllAfSugy = true;
		int_0 = 0;
		int_1 = 0;
		string_0 = null;
		list_0 = list_1;
	}

	internal void method_3()
	{
		try
		{
			tCllAfSugy = GClass7.smethod_0().bool_0;
			if (!tCllAfSugy)
			{
				list_0 = null;
				return;
			}
			GClass67 gclass67_ = GClass7.smethod_0().gclass67_0;
			if (gclass67_ == null)
				return;
			if (gclass67_.method_21().Length == 0 || gclass67_.method_21()[0] != '/')
			{
				this.string_0 = null;
				tCllAfSugy = false;
				return;
			}
			if (this.string_0 != gclass67_.method_21())
			{
				int_0 = 0;
				int_1 = 0;
				this.string_0 = gclass67_.method_21();
				string string_0 = this.string_0.Substring(1);
				list_0 = list_1.FindAll((string[] h) => h[0].Contains(string_0) || h[1].Contains(string_0));
			}
			if (GClass39.bool_11[22])
			{
				int_0++;
				if (int_0 > list_0.Count - 1)
					int_0 = 0;
				GClass39.bool_11[22] = false;
				GClass39.smethod_26();
				GClass39.smethod_27();
			}
			else if (GClass39.bool_11[21])
			{
				int_0--;
				if (int_0 < 0)
					int_0 = list_0.Count - 1;
				GClass39.bool_11[21] = false;
				GClass39.smethod_26();
				GClass39.smethod_27();
			}
			else if (GClass39.bool_11[16])
			{
				if (this.string_0 != list_0[int_0][0])
					gclass67_.method_23(list_0[int_0][0]);
				GClass39.bool_11[16] = false;
				GClass39.smethod_26();
				GClass39.smethod_27();
			}
			if (int_0 >= int_1 + 10)
				int_1 = int_0 - 9;
			if (int_0 < int_1)
				int_1 = int_0;
		}
		catch (Exception ex)
		{
			GClass188.smethod_0("Data/Errors/updateSuggestionCommand.ini", ex.ToString());
		}
	}

	internal void method_4(GClass76 gclass76_0)
	{
		try
		{
			if (tCllAfSugy && !string.IsNullOrEmpty(string_0))
			{
				GClass7 gClass = GClass7.smethod_0();
				int_3 = (method_1() + 1) * 10;
				int_2 = ((GClass39.int_10 - 10 > method_0()) ? method_0() : (GClass39.int_10 - 10));
				int h = method_1() * (int_3 - 10) / list_0.Count;
				int_4 = (GClass39.int_10 - int_2) / 2;
				int_5 = gClass.gclass67_0.int_1 - 40 - int_3;
				gclass76_0.method_20(0, 0.5f);
				gclass76_0.method_15(int_4, int_5, int_2, int_3);
				gclass76_0.method_20(0, 1f);
				gclass76_0.method_15(int_4, int_5, int_2, 10);
				int x = int_4 + int_2 - GClass49.gclass49_20.method_17((GClass192.int_0 == 0) ? "Nhấn Tab để lựa chọn" : "Press Tab to select") - 5;
				GClass49.gclass49_20.method_6(gclass76_0, (GClass192.int_0 == 0) ? "Nhấn Tab để lựa chọn" : "Press Tab to select", x, int_5, 0);
				gclass76_0.method_20(16777215, 0.5f);
				gclass76_0.method_15(int_4, int_5 + 10 - 1, int_2, 1);
				gclass76_0.method_20(8618883, 0.75f);
				gclass76_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), int_2 - 5, 10);
				gclass76_0.method_20(16777215, 0.75f);
				gclass76_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), 2, 10);
				gclass76_0.method_20(16777215, 0.75f);
				gclass76_0.method_15(int_4 + int_2 - 5, int_5 + 10, 1, int_3 - 10);
				gclass76_0.method_20(16777215, 0.75f);
				gclass76_0.method_15(int_4 + int_2 - 3, int_5 + 10 + int_1 * (int_3 - 10) / list_0.Count, 2, h);
				for (int i = int_1; i < int_1 + method_1(); i++)
				{
					GClass49.gclass49_15.method_6(gclass76_0, list_0[i][0] + " :" + list_0[i][1], int_4 + 5, int_5 + 10 + 10 * (i - int_1), 0);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_5()
	{
		string text = string.Empty;
		for (int i = 0; i < list_0.Count; i++)
		{
			text = text + list_0[i][0] + " :" + list_0[i][1] + "\n";
		}
		File.WriteAllText("AdSense.txt", text);
	}
}
