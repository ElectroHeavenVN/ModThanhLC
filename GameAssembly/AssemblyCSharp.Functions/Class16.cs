using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AssemblyCSharp.Functions
{
	internal class Class16
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class17
		{
			public static readonly Class17 class17_0 = new Class17();

			public static Func<string[], string> func_0;

			internal string method_0(string[] h)
			{
				return h[0];
			}
		}

		[CompilerGenerated]
		private sealed class Class18
		{
			public string string_0;

			internal bool method_0(string[] h)
			{
				return h[0].Contains(string_0) || h[1].Contains(string_0);
			}
		}

		[CompilerGenerated]
		private static readonly Class16 class16_0 = new Class16();

		internal int int_0;

		internal bool bool_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		private string string_0 = "";

		private List<string[]> list_0;

		private List<string[]> list_1 = new List<string[]>
		{
			(GClass151.int_0 == 0) ? new string[2] { "/tbb", "Bật/Tắt hiển thị d/s thông báo BOSS" } : new string[2] { "/tbb", "Turn off/on show list boss appear information" },
			(GClass151.int_0 != 0) ? new string[2] { "/lockskill", "Turn off/on lock current skill" } : new string[2] { "/lockskill", "Bật/Tắt Khóa skill hiện tại" },
			(GClass151.int_0 == 0) ? new string[2] { "/cobj", "Bật/Tắt tự động chuyển mục tiêu" } : new string[2] { "/cobj", "Turn off/on auto change object" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsb", "Turn off/on auto murdering BOSS" } : new string[2] { "/dsb", "Bật/Tắt tự động đồ sát BOSS" },
			(GClass151.int_0 == 0) ? new string[2] { "/abdkbX", "Bật/Tắt tự động mở BDKB level X" } : new string[2] { "/abdkbX", "Turn off/on auto open TreasureUnderSea LvlX" },
			(GClass151.int_0 == 0) ? new string[2] { "/abfX Y", "Bật/Tắt tự động ăn đậu khi HP,KI < X%, Y%" } : new string[2] { "/abfX Y", "Turn off/on auto use bean if HP,KI < X%, Y%" },
			(GClass151.int_0 != 0) ? new string[2] { "/addboss", "Add/Remove Boss focus to list BOSS murdering" } : new string[2] { "/addboss", "Thêm/Xóa Boss đang Focus vào d/s đồ sát BOSS" },
			(GClass151.int_0 != 0) ? new string[2] { "/listbossclr", "Clear list BOSS murdering" } : new string[2] { "/listbossclr", "Xóa sạch danh sách BOSS đồ sát" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsbskill", "Add/Remove Skill focus to list BOSS Skill murdering" } : new string[2] { "/dsbskill", "Thêm/Xóa Skill đang Focus vào d/s skill đồ sát" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsnskill", "Add/Remove Skill focus to list Char Skill murdering" } : new string[2] { "/dsnskill", "Thêm/Xóa Skill đang Focus vào d/s skill đồ sát người" },
			(GClass151.int_0 == 0) ? new string[2] { "/dsqskillX", "Thêm/Xóa Skill ID X vào d/s skill đồ sát quái" } : new string[2] { "/dsqskillX", "Add/Remove Skill ID X to list Mob Skill murdering" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsbskillclr", "Clear list BOSS Skill murdering" } : new string[2] { "/dsbskillclr", "Xóa sạch danh sách Skill đồ sát BOSS" },
			(GClass151.int_0 == 0) ? new string[2] { "/blockboss", "Thêm/Xóa Boss đang Focus vào d/s ko đồ sát BOSS" } : new string[2] { "/blockboss", "Add/Remove Boss focus to list BOSS not murdering" },
			(GClass151.int_0 == 0) ? new string[2] { "/dsn", "Bật/Tắt tự động đồ sát người" } : new string[2] { "/dsn", "Turn on/off auto murdering character" },
			(GClass151.int_0 != 0) ? new string[2] { "/xmpX", "Auto move to map ID X" } : new string[2] { "/xmpX", "Auto nextmap tới map id X" },
			(GClass151.int_0 == 0) ? new string[2] { "/autobuytdlt", "Bật/Tắt tự động mua TĐLT" } : new string[2] { "/autobuytdlt", "Turn on/off auto buy Auto Train" },
			(GClass151.int_0 == 0) ? new string[2] { "/autobuykt", "Bật/Tắt tự động mua khẩu trang" } : new string[2] { "/autobuykt", "Turn on/off auto buy mask" },
			(GClass151.int_0 == 0) ? new string[2] { "/addchar", "Thêm/Xóa người đang Focus vào d/s đồ sát người" } : new string[2] { "/addchar", "Add/Remove char focus to list Char murdering" },
			(GClass151.int_0 == 0) ? new string[2] { "/addcharX", "Thêm/Xóa người id X vào d/s đồ sát người" } : new string[2] { "/addcharX", "Add/Remove char have ID X to list Char murdering" },
			(GClass151.int_0 != 0) ? new string[2] { "/blockcharX", "Add/Remove char have ID X to list Char not-murdering" } : new string[2] { "/blockcharX", "Thêm/Xóa người id X vào d/s ko đồ sát người" },
			(GClass151.int_0 != 0) ? new string[2] { "/addclan", "Add/Remove clan of char focus to list Clan murdering" } : new string[2] { "/addclan", "Thêm/Xóa bang của người đang Focus vào d/s đồ sát người theo bang" },
			(GClass151.int_0 != 0) ? new string[2] { "/blockclan", "Block clan/Unblock clan murdering" } : new string[2] { "/blockclan", "Đồ sát Bỏ qua/Ko bỏ qua bang" },
			(GClass151.int_0 == 0) ? new string[2] { "/blockitemX", "Thêm/Xóa item id X vào d/s không nhặt vp theo ID" } : new string[2] { "/blockitemX", "Add/Remove item id X to list do not pick item by ID" },
			(GClass151.int_0 == 0) ? new string[2] { "/blockitemtX", "Thêm/Xóa item type X vào d/s không nhặt vp theo Type" } : new string[2] { "/blockitemtX", "Add/Remove item type X to list do not pick item by type" },
			(GClass151.int_0 != 0) ? new string[2] { "/addclanX", "Add/Remove clan ID X to list Clan murdering" } : new string[2] { "/addclanX", "Thêm/Xóa bang id X vào d/s đồ sát người theo bang" },
			(GClass151.int_0 == 0) ? new string[2] { "/kmt", "Bật/Tắt tự động khóa mục tiêu người/quái/boss" } : new string[2] { "/kmt", "Turn on/off auto lock object [char/mob/boss]" },
			(GClass151.int_0 == 0) ? new string[2] { "/kmtX", "Bật/Tắt khóa mục tiêu người có id là X" } : new string[2] { "/kmtX", "Turn on/off lock object have id X" },
			(GClass151.int_0 != 0) ? new string[2] { "/pem1hit", "Turn on/off attack mob to 1 HP" } : new string[2] { "/pem1hit", "Bật/Tắt đánh quái 1 hit còn 1 HP" },
			(GClass151.int_0 == 0) ? new string[2] { "/bosshpX", "Chỉ đánh BOSS dưới X HP [X = 0 -> Đánh tất cả]" } : new string[2] { "/bosshpX", "Only attack boss HP < X HP [X = 0 -> Attack all]" },
			(GClass151.int_0 == 0) ? new string[2] { "/charhpX", "Chỉ đánh người dưới X HP [X = 0 -> Đánh tất cả]" } : new string[2] { "/charhpX", "Only attack char HP < X HP [X = 0 -> Attack all]" },
			(GClass151.int_0 != 0) ? new string[2] { "/rspeedX", "Change run speed to X" } : new string[2] { "/rspeedX", "Chỉnh tốc độ chạy thành X" },
			(GClass151.int_0 == 0) ? new string[2] { "/gspeedX", "Chỉnh tốc độ game thành X" } : new string[2] { "/gspeedX", "Change game speed to X" },
			(GClass151.int_0 != 0) ? new string[2] { "/afriend", "Add friend with char focus" } : new string[2] { "/afriend", "Kết bạn với đối tượng đang focus" },
			(GClass151.int_0 == 0) ? new string[2] { "/afriendX", "Kết bạn với đối tượng có ID là X" } : new string[2] { "/afriendX", "Add friend with object have ID X" },
			(GClass151.int_0 == 0) ? new string[2] { "/teleX", "Bật/Tắt tự động teleport dí mục tiêu [X = -1 => Tắt]" } : new string[2] { "/teleX", "Turn on/off auto teleport to char ID X [X = -1 => Off]" },
			(GClass151.int_0 == 0) ? new string[2] { "/psq", "Bật/Tắt chỉ đánh siêu quái" } : new string[2] { "/psq", "Turn on/off only attack super mob" },
			(GClass151.int_0 != 0) ? new string[2] { "/getitem", "Write List item ID in game" } : new string[2] { "/getitem", "Vẽ ra file Danh sách item hiện có trong game" },
			(GClass151.int_0 != 0) ? new string[2] { "/rX", "Move to right X unit" } : new string[2] { "/rX", "Dịch tọa độ sang phải X đơn vị" },
			(GClass151.int_0 == 0) ? new string[2] { "/lX", "Dịch tọa độ sang trái X đơn vị" } : new string[2] { "/lX", "Move to left X unit" },
			(GClass151.int_0 == 0) ? new string[2] { "/uX", "Dịch tọa độ lên trên X đơn vị" } : new string[2] { "/uX", "Move up X unit" },
			(GClass151.int_0 != 0) ? new string[2] { "/dX", "Move down X unit" } : new string[2] { "/dX", "Dịch tọa độ xuống dưới X đơn vị" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsq", "Turn on/off auto murdering mob" } : new string[2] { "/dsq", "Bật/Tắt tự động đồ sát quái" },
			(GClass151.int_0 == 0) ? new string[2] { "/nsq", "Bật/Tắt đồ sát né siêu quái" } : new string[2] { "/nsq", "Turn on/off not-murdering super mob" },
			(GClass151.int_0 == 0) ? new string[2] { "/additem", "Thêm/Xóa item đang Focus vào d/s nhặt item theo ID" } : new string[2] { "/additem", "Add/Remove item focus to list pick item by ID" },
			(GClass151.int_0 != 0) ? new string[2] { "/additemX", "Add/Remove item id X to list pick item by ID" } : new string[2] { "/additemX", "Thêm/Xóa item ID X vào d/s nhặt item theo ID" },
			(GClass151.int_0 == 0) ? new string[2] { "/addmob", "Thêm/Xóa quái ở vị trí đang Focus vào d/s đánh quái theo vị trí" } : new string[2] { "/addmob", "Add/Remove mob at location focus to list murdering by location" },
			(GClass151.int_0 == 0) ? new string[2] { "/addmobX", "Thêm/Xóa quái ở vị trí X vào d/s đánh quái theo vị trí" } : new string[2] { "/addmobX", "Add/Remove mob at location X to list murdering by location" },
			(GClass151.int_0 == 0) ? new string[2] { "/additemt", "Thêm/Xóa loại item đang Focuus vào d/s nhặt item theo loại" } : new string[2] { "/additemt", "Add/Remove type item focus to list pick item by type" },
			(GClass151.int_0 != 0) ? new string[2] { "/additemtX", "Add/Remove type item X to list pick item by type" } : new string[2] { "/additemtX", "Thêm/Xóa loại item type X vào d/s nhặt item theo loại" },
			(GClass151.int_0 != 0) ? new string[2] { "/addmobt", "Add/Remove type mob focus to list murdering mob by type" } : new string[2] { "/addmobt", "Thêm/Xóa loại quái đang Focuus vào d/s đánh quái theo loại" },
			(GClass151.int_0 == 0) ? new string[2] { "/addmobtX", "Thêm/Xóa loại quái type X vào d/s đánh quái theo loại" } : new string[2] { "/addmobtX", "Add/Remove type mob X to list murdering mob by type" },
			(GClass151.int_0 != 0) ? new string[2] { "/anhat", "Turn on/off auto pick item" } : new string[2] { "/anhat", "Bật/Tắt tự động nhặt Item" },
			(GClass151.int_0 != 0) ? new string[2] { "/itemme", "Turn on/off only pick my item" } : new string[2] { "/itemme", "Bật/Tắt chỉ nhặt vật phẩm của bản thân" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsnv", "Turn on/off show list character in map" } : new string[2] { "/dsnv", "Bật/Tắt hiển thị d/s nhân vật trong map" },
			(GClass151.int_0 != 0) ? new string[2] { "/oinf", "Turn on/off show object details" } : new string[2] { "/oinf", "Bật/Tắt hiển thị thông tin đối tượng đang Focus" },
			(GClass151.int_0 != 0) ? new string[2] { "/autoskillX", "Turn on/off auto use skill after X ms (X = 0 -> Off)" } : new string[2] { "/autoskillX", "Bật/Tắt tự động dùng chiêu sau X ms (X = 0 -> Tắt)" },
			(GClass151.int_0 == 0) ? new string[2] { "/autoskill", "Tắt tự động dùng chiêu theo thời gian" } : new string[2] { "/autoskill", "Turn off auto use skill by item" },
			(GClass151.int_0 != 0) ? new string[2] { "/rcvs", "Turn on/off go to recover skills at W.M.T.23" } : new string[2] { "/rcvs", "Bật/Tắt tự động đi hồi skills tại ĐHVT23" },
			(GClass151.int_0 == 0) ? new string[2] { "/ats9", "Bật/Tắt tự động luyện tuyệt kỹ (Skill 9)" } : new string[2] { "/ats9", "Turn on/off auto train special skill (Skill 9)" },
			(GClass151.int_0 != 0) ? new string[2] { "/cd", "Turn on/off auto give bean" } : new string[2] { "/cd", "Bật/Tắt tự động cho đậu" },
			(GClass151.int_0 != 0) ? new string[2] { "/td", "Turn on/off auto collect bean" } : new string[2] { "/td", "Bật/Tắt tự động thu và cất đậu vào rương đồ" },
			(GClass151.int_0 != 0) ? new string[2] { "/xd", "Turn on/off auto request bean" } : new string[2] { "/xd", "Bật/Tắt tự động xin đậu" },
			(GClass151.int_0 != 0) ? new string[2] { "/autowhis", "Turn on/off auto challenge Whis" } : new string[2] { "/autowhis", "Bật/Tắt tự động thách đấu Whis" },
			(GClass151.int_0 != 0) ? new string[2] { "/ajump", "Turn on/off auto jump" } : new string[2] { "/ajump", "Bật/Tắt tự động nhảy vị trí nhỏ" },
			(GClass151.int_0 != 0) ? new string[2] { "/mobhpX", "Turn on/off limit mob HP murdering" } : new string[2] { "/mobhpX", "Bật/Tắt giới hạn HP quái đồ sát" },
			(GClass151.int_0 != 0) ? new string[2] { "/petinfo", "Turn on/off show disciple details" } : new string[2] { "/petinfo", "Bật/Tắt hiển thị thông tin đệ tử" },
			(GClass151.int_0 != 0) ? new string[2] { "/vdh", "Turn on/off move cross terrain" } : new string[2] { "/vdh", "Bật/Tắt di chuyển vượt địa hình" },
			(GClass151.int_0 != 0) ? new string[2] { "/dtnsq", "Turn on/off auto train disciple in protect mode" } : new string[2] { "/dtnsq", "Bật/Tắt tự động train đệ tử né siêu quái" },
			(GClass151.int_0 != 0) ? new string[2] { "/aheal", "Turn on/off auto healing by list" } : new string[2] { "/aheal", "Bật/Tắt tự động trị thương theo danh sách" },
			(GClass151.int_0 == 0) ? new string[2] { "/addcheal", "Thêm/Xóa người đang Focus vào danh sách trị thương" } : new string[2] { "/addcheal", "Add/Remove char focus to list healing" },
			(GClass151.int_0 == 0) ? new string[2] { "/addchealX", "Thêm/Xóa người ID X vào danh sách trị thương" } : new string[2] { "/addchealX", "Add/Remove char ID X to list healing" },
			(GClass151.int_0 == 0) ? new string[2] { "/pethpX", "Bật/Tắt tự động dùng đậu khi đệ tử dưới X% HP (X = 0 -> Tắt)" } : new string[2] { "/pethpX", "Turn on/off auto use bean when disciple HP < X% HP (X = 0 -> Off)" },
			(GClass151.int_0 != 0) ? new string[2] { "/gohome", "Turn on/off auto let pet go home" } : new string[2] { "/gohome", "Bật/Tắt tự động cho đệ tử về nhà sau khi tách hợp thể" },
			(GClass151.int_0 != 0) ? new string[2] { "/petsmX", "Turn on/off limited disciple power (X = 0 -> Off)" } : new string[2] { "/petsmX", "Bật/Tắt tự động thoát game khi đệ tử đạt X sức mạnh (X = 0 -> Tắt)" },
			(GClass151.int_0 != 0) ? new string[2] { "/ahs", "Turn on/off auto revive" } : new string[2] { "/ahs", "Bật/Tắt tự động dùng ngọc hồi sinh" },
			(GClass151.int_0 != 0) ? new string[2] { "/hpX", "Turn on/off auto upgrade X HP" } : new string[2] { "/hpX", "Bật/Tắt tự động nâng X HP" },
			(GClass151.int_0 == 0) ? new string[2] { "/mpX", "Bật/Tắt tự động nâng X KI" } : new string[2] { "/mpX", "Turn on/off auto upgrade X MP" },
			(GClass151.int_0 == 0) ? new string[2] { "/dmgX", "Bật/Tắt tự động nâng X SĐ" } : new string[2] { "/dmgX", "Turn on/off auto upgrade X DMG" },
			(GClass151.int_0 == 0) ? new string[2] { "/abtX Y", "Bật/Tắt tự động dùng bông tai khi HP,KI < X%,Y% (X = 0 -> Tắt)" } : new string[2] { "/abtX Y", "Turn on/off auto use porata when HP,KI < X%,Y (X = 0 -> Off)" },
			(GClass151.int_0 == 0) ? new string[2] { "/alg", "Bật/Tắt tự động đăng nhập lại game khi MKN [Mặc định Bật]" } : new string[2] { "/alg", "Turn on/off auto login after disconnect [Default: ON]" },
			(GClass151.int_0 != 0) ? new string[2] { "/kz", "Turn off auto change one" } : new string[2] { "/kz", "Tắt tự động đổi khu" },
			(GClass151.int_0 != 0) ? new string[2] { "/kzX", "Turn on auto change zone X" } : new string[2] { "/kzX", "Bật tự động đổi sang khu X" },
			(GClass151.int_0 == 0) ? new string[2] { "/smap", "Lưu thông tin map đang đứng [GOBACK]" } : new string[2] { "/smap", "Save detail current Map [GOBACK]" },
			(GClass151.int_0 == 0) ? new string[2] { "/szone", "Lưu thông tin khu đang đứng [GOBACK]" } : new string[2] { "/szone", "Save detail current Zone [GOBACK]" },
			(GClass151.int_0 == 0) ? new string[2] { "/spos", "Lưu thông tin vị trí đang đứng [GOBACK]" } : new string[2] { "/spos", "Save detail current position [GOBACK]" },
			(GClass151.int_0 == 0) ? new string[2] { "/lcz", "Bật/Tắt khóa chuyển khu" } : new string[2] { "/lcz", "Turn on/off lock change zone" },
			(GClass151.int_0 != 0) ? new string[2] { "/lcm", "Turn on/off lock change map" } : new string[2] { "/lcm", "Bật/Tắt khóa chuyển map" },
			(GClass151.int_0 == 0) ? new string[2] { "/cvs", "Tắt tự động dùng huýt sáo cho đối phương" } : new string[2] { "/cvs", "Turn off auto use whistle" },
			(GClass151.int_0 == 0) ? new string[2] { "/dropitem", "Bật/Tắt tự động vứt VP rác (nr4-7s,mđv,...)" } : new string[2] { "/dropitem", "Turn on/off auto drop trash item" },
			(GClass151.int_0 == 0) ? new string[2] { "/clrlistdrop", "Xóa danh sách vứt vp" } : new string[2] { "/clrlistdrop", "Clear list item ID drop" },
			(GClass151.int_0 == 0) ? new string[2] { "/aflag", "Bật/Tắt tự động mặc cờ xám" } : new string[2] { "/aflag", "Turn on/off auto get grey flag" },
			(GClass151.int_0 != 0) ? new string[2] { "/additemdropX", "Add/Remove item id X to/from list drop item" } : new string[2] { "/additemdropX", "Thêm/Xóa item id X vào d/s vứt item" },
			(GClass151.int_0 == 0) ? new string[2] { "/additemdrophsdX", "Thêm/Xóa item id X vào d/s vứt item theo HSD" } : new string[2] { "/additemdrophsdX", "Add/Remove item id X to/from list drop item theo HSD" },
			(GClass151.int_0 == 0) ? new string[2] { "/cvsX", "Bật/Tắt tự động dùng huýt sáo khi đối phương dưới X% HP (X = 0 -> Tắt)" } : new string[2] { "/cvsX", "Turn on/off auto use whistle for obj when obj HP < X% HP [X = 0 -> Off]" },
			(GClass151.int_0 == 0) ? new string[2] { "/cvsX Y", "Bật/Tắt tự động dùng huýt sáo khi người ID X dưới Y% HP (X = 0 -> Tắt)" } : new string[2] { "/cvsX", "Turn on/off auto use whistle for obj ID X when obj HP < Y% HP [X = 0 -> Off]" },
			(GClass151.int_0 != 0) ? new string[2] { "/isell", "Turn on/off auto sell trash item, use sharp, drop item..." } : new string[2] { "/isell", "Bật/Tắt tự động bán đồ rác, sử dụng mảnh quái, vứt item thừa,.." },
			(GClass151.int_0 == 0) ? new string[2] { "/actg", "Bật/Tắt tự động chat thế giới (10s 1 lần)" } : new string[2] { "/actg", "Turn on/off auto global chat (delay 10sec)" },
			(GClass151.int_0 != 0) ? new string[2] { "/citemX Y", "Turn on/off auto quit when picked Y quantity of item ID X [X,Y=0 -> Off" } : new string[2] { "/citemX Y", "Bật/Tắt tự động thoát game khi nhặt đủ Y số lượng item id X (X, Y = 0 -> Tắt)" },
			(GClass151.int_0 == 0) ? new string[2] { "/vqtd", "Hiển thị menu vòng quay thượng đế [Dùng ở Thần điện]" } : new string[2] { "/vqtd", "Show menu auto crack spin ball [Use at SamaPlace]" },
			(GClass151.int_0 == 0) ? new string[2] { "/hide", "Bật/Tắt hiển thị thông tin map,khu,vị trí, hp,ki,..." } : new string[2] { "/hide", "Turn on/off show information on screen" },
			(GClass151.int_0 != 0) ? new string[2] { "/optm", "Turn on/off optimize CPU" } : new string[2] { "/optm", "Bật/Tắt tối ưu CPU, khiến game nhẹ hơn" },
			(GClass151.int_0 == 0) ? new string[2] { "/achat_X", "Bật/Tắt tự động chat nội dung X (Nếu không nhập X -> Tắt)" } : new string[2] { "/achat_X", "Turn on/off auto chat text X" },
			(GClass151.int_0 == 0) ? new string[2] { "/listmobclr", "Xóa danh sách quái đồ sát" } : new string[2] { "/listmobclr", "Clear list mobs murdering" },
			(GClass151.int_0 != 0) ? new string[2] { "/dsqskillclr", "Clear list skill use when mobs murdering" } : new string[2] { "/dsqskillclr", "Xóa danh sách skill đồ sát quái" },
			(GClass151.int_0 != 0) ? new string[2] { "/nrdX Y", "Turn on/off auto go map BlackStarDB X star zone Y" } : new string[2] { "/nrdX Y", "Bật/Tắt tự động vào map NRSĐ X sao khu Y" },
			(GClass151.int_0 != 0) ? new string[2] { "/ats9g", "Turn on/off auto train special skill with gold" } : new string[2] { "/ats9g", "Bật/Tắt tự động train tuyệt kỹ bằng vàng" }
		};

		private Class16()
		{
			list_1 = list_1.OrderBy((string[] h) => h[0]).ToList();
		}

		[SpecialName]
		[CompilerGenerated]
		internal static Class16 k4qKbAJZyI()
		{
			return class16_0;
		}

		[SpecialName]
		internal int IvnKRnItVf()
		{
			return (GClass122.int_12 > 1) ? 280 : 350;
		}

		[SpecialName]
		internal int Wl5KzKFmU8()
		{
			return (list_0.Count >= 10) ? 10 : list_0.Count;
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
				bool_0 = GClass91.smethod_0().bool_0;
				if (bool_0)
				{
					GClass191 gclass191_ = GClass91.smethod_0().gclass191_0;
					if (gclass191_ == null)
						return;
					if (gclass191_.method_21().Length != 0 && gclass191_.method_21()[0] == '/')
					{
						if (this.string_0 != gclass191_.method_21())
						{
							int_0 = 0;
							int_1 = 0;
							this.string_0 = gclass191_.method_21();
							string string_0 = this.string_0.Substring(1);
							list_0 = list_1.FindAll((string[] h) => h[0].Contains(string_0) || h[1].Contains(string_0));
						}
						if (!GClass73.bool_11[22])
						{
							if (!GClass73.bool_11[21])
							{
								if (GClass73.bool_11[16])
								{
									if (this.string_0 != list_0[int_0][0])
										gclass191_.method_23(list_0[int_0][0]);
									GClass73.bool_11[16] = false;
									GClass73.smethod_26();
									GClass73.smethod_27();
								}
							}
							else
							{
								int_0--;
								if (int_0 < 0)
									int_0 = list_0.Count - 1;
								GClass73.bool_11[21] = false;
								GClass73.smethod_26();
								GClass73.smethod_27();
							}
						}
						else
						{
							int_0++;
							if (int_0 > list_0.Count - 1)
								int_0 = 0;
							GClass73.bool_11[22] = false;
							GClass73.smethod_26();
							GClass73.smethod_27();
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
				else
					list_0 = null;
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/updateSuggestionCommand.ini", ex.ToString());
			}
		}

		internal void method_2(GClass122 gclass122_0)
		{
			try
			{
				if (!bool_0 || string.IsNullOrEmpty(string_0))
					return;
				GClass91 gClass = GClass91.smethod_0();
				int_3 = (Wl5KzKFmU8() + 1) * 10;
				int_2 = ((GClass73.int_10 - 10 > IvnKRnItVf()) ? IvnKRnItVf() : (GClass73.int_10 - 10));
				if (list_0.Count == 0)
					return;
				int h = Wl5KzKFmU8() * (int_3 - 10) / list_0.Count;
				int_4 = (GClass73.int_10 - int_2) / 2;
				int_5 = gClass.gclass191_0.int_1 - 40 - int_3;
				gclass122_0.method_20(0, 0.5f);
				gclass122_0.method_15(int_4, int_5, int_2, int_3);
				gclass122_0.method_20(0, 1f);
				gclass122_0.method_15(int_4, int_5, int_2, 10);
				int x = int_4 + int_2 - GClass4.gclass4_20.method_17((GClass151.int_0 != 0) ? "Press Tab to select" : "Nhấn Tab để lựa chọn") - 5;
				GClass4.gclass4_20.method_6(gclass122_0, (GClass151.int_0 == 0) ? "Nhấn Tab để lựa chọn" : "Press Tab to select", x, int_5, 0);
				gclass122_0.method_20(16777215, 0.5f);
				gclass122_0.method_15(int_4, int_5 + 10 - 1, int_2, 1);
				gclass122_0.method_20(8618883, 0.75f);
				gclass122_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), int_2 - 5, 10);
				gclass122_0.method_20(16777215, 0.75f);
				gclass122_0.method_15(int_4, int_5 + 10 + 10 * (int_0 - int_1), 2, 10);
				gclass122_0.method_20(16777215, 0.75f);
				gclass122_0.method_15(int_4 + int_2 - 5, int_5 + 10, 1, int_3 - 10);
				gclass122_0.method_20(16777215, 0.75f);
				gclass122_0.method_15(int_4 + int_2 - 3, int_5 + 10 + int_1 * (int_3 - 10) / list_0.Count, 2, h);
				for (int i = int_1; i < int_1 + Wl5KzKFmU8(); i++)
				{
					if (!string.IsNullOrEmpty(list_0[i][0]) && !string.IsNullOrEmpty(list_0[i][1]))
						GClass4.gclass4_15.method_6(gclass122_0, list_0[i][0] + " :" + list_0[i][1], int_4 + 5, int_5 + 10 + 10 * (i - int_1), 0);
				}
			}
			catch (Exception ex)
			{
				GClass149.smethod_0("Data/Errors/ErrorSuggestCommand.txt", ex.Message);
			}
		}

		public void method_3()
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i][0] + " :" + list_0[i][1] + "\n";
			}
			File.WriteAllText("AdSense.txt", text);
		}
	}
}
