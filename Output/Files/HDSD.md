## *Một số chú ý*
- Để mở được mod lên, vui lòng cài đặt .NET Framework 4.8 (Runtime).
<s>
- Vào Windows Security kiểm tra ở các mục sau đã tắt chưa:
    + Virus & threat protection: tại đây ở phần Virus & threat protection settings, ấn vào Manage settings. Tắt tất cả protection bên trong.
    + App & browser control: tại đây ở phần Reputation-based protection, ấn vào Reputation-based protection settings. Tắt tất cả cài đặt ở trong này. 
    + Tắt các phần mềm diệt virus
</s>
- Nếu phần mềm diệt virus của bạn đánh dấu `LicenseBypassInjector.exe`, `LicenseCheckBypass.dll` hoặc `DragonBoyManager.exe` là mối đe dọa, bạn có thể thêm các tệp này vào mục ngoại lệ trong phần mềm diệt virus của bạn. KHÔNG tắt toàn bộ phần mềm diệt virus, nếu không thiết bị của bạn có thể bị virus thật sự tấn công.
- NẾU Game ra mắt sự kiện mới, mà thao tác NPC xuất hiện tùy chọn menu mới làm kẹt nextmap, nhập nội dung của menu muốn ấn để tránh kẹt map trong folder `Data/QLTK`, kiếm file `EventButton.txt` và điền nội dung của nút muốn ấn vào file đó, rồi ấn Lưu.
Có thể thêm nhiều giá trị đằng sau lệnh bằng cách dùng dấu `,`. VD: `100,101,102` đi sau các lệnh chat.

# Lệnh chat
## Lệnh đồ sát Boss
- `/dsb`: Bật/tắt tự động đồ sát Boss.
- `/addboss`: Thêm/xóa Boss đang trỏ vào/khỏi danh sách những Boss đồ sát (Nếu danh sách trống sẽ đồ sát tất cả các boss).
- `/listbossclr`: Xóa sạch danh sách những Boss đồ sát.
- `/dsbskill`: Thêm/xóa skill đang trỏ vào/khỏi danh sách những skill dùng khi đồ sát Boss.
- `/dsbskillclr`: Xóa sạch danh sách những skill dùng khi đồ sát Boss.
- `/dsbig`: Thêm/xóa Boss đang trỏ vào/khỏi danh sách những Boss không đồ sát (Tự động bỏ qua khi check Boss tiếp theo).
- `/bosshp` `X`: Giới hạn HP Boss đồ sát về X (Chỉ đánh những Boss có HP dưới X).

## Lệnh đồ sát Người
Để cài đặt lọc người, ấn phím `M`, chọn menu `Chức năng hỗ trợ NRSĐ/PK`, chọn mục tương ứng, sau đó chọn cài đặt.
- `/dsn`: Bật/tắt tự động đồ sát người.
- `/addchar`: Thêm/xóa `charID` của người đang trỏ vào/khỏi danh sách những người đồ sát theo `charID`.
- `/addchar` `X`: Thêm/xóa `charID` `X` vào/khỏi danh sách những người đồ sát theo `charID`.
- `/addclan`: Thêm/xóa `clanID` của người đang trỏ vào/khỏi danh sách những Clan đồ sát theo `clanID`.
- `/addclan` `X`: Thêm/xóa `clanID` `X` vào/khỏi danh sách những Clan đồ sát theo `clanID`.
- `/dsnskill`: Thêm/xóa skill đang trỏ vào/khỏi danh sách skill dùng khi đồ sát người.
- `/dsnskillclr`: Xóa sạch danh sách skill dùng khi đồ sát người.
- `/dsnig`: Thêm/xóa `charID` của người đang trỏ vào/khỏi danh sách những người không đồ sát (Tự động bỏ qua khi check người tiếp theo).
- `/dsnig` `X`: Thêm/xóa `charID` `X` vào/khỏi danh sách những người không đồ sát (Tự động bỏ qua khi check người tiếp theo).
- `/charhp` `X`: Giới hạn HP Người đồ sát về `X` (Chỉ đánh những Người có HP dưới X). Chức năng này tự động check người nào vừa mới hồi sinh tại chỗ sau 10s mới tự động chuyển qua để đánh.

## Lệnh đồ sát Quái
- `/dsq`: Bật/tắt tự động đồ sát Quái.
- `/psq`: Bật/tắt chỉ đánh siêu quái (Tự động bỏ qua quái thường).
- `/nsq`: Bật/tắt chỉ đánh quái thường (Tự động bỏ qua siêu quái).
- `/addmob`: Thêm/xóa vị trí của quái đang trỏ vào/khỏi danh sách chỉ đánh quái theo vị trí.
- `/addmob` `X`: Thêm/xóa quái ở vị trí `X` vào/khỏi danh sách chỉ đánh quái theo vị trí. 
- `/addmobt`: Thêm/xóa loại quái đang trỏ vào/khỏi danh sách chỉ đánh quái theo loại quái.
- `/addmobt` `X`: Thêm/xóa loại quái `X` vào/khỏi danh sách chỉ đánh quái theo loại quái (Xem số loại quái ở thanh hiển thị HP/KI, ngay cạnh tên hiển thị quái).
- `/mobhp` `X`: Giới hạn HP Quái đồ sát về `X` (Chỉ đánh những quái có HP dưới hoặc bằng X).
- `/pem1hit`: Bật/tắt tự động chỉ đánh quái còn 1HP sau đó ngưng.
- `/listmobclr`: Xóa sạch danh sách đồ sát quái theo vị trí, theo loại.
- `/dsqskill`: Thêm/xóa skill đang trỏ vào/khỏi danh sách skill dùng khi đồ sát quái.
- `/dsqskill` `X`: Thêm/xóa `skillID` `X` vào/khỏi danh sách skill dùng khi đồ sát quái.
- `/dsqskillclr`: Xóa sạch danh sách những skill dùng khi đồ sát quái.
- `/anhat`: Bật/tắt tự động nhặt vật phẩm.
- `/blockitem`: Thêm/xóa `itemID` của vật phẩm đang trỏ vào/khỏi danh sách những item không nhặt theo ID.
- `/blockitem` `X`: Thêm/xóa `itemID` `X` vào/khỏi danh sách những item không nhặt theo ID.
- `/blockitemt`: Thêm/xóa loại item của vật phẩm đang trỏ vào/khỏi danh sách những item không nhặt theo loại.
- `/blockitemt` `X`: Thêm/xóa `itemType` `X` vào/khỏi danh sách những item không nhặt theo loại.
- `/additem`: Thêm/xóa vật phẩm đang trỏ vào/khỏi danh sách những item nhặt theo ID.
- `/additem` `X`: Thêm/xóa `itemID` `X` vào/khỏi danh sách những item nhặt theo ID.
- `/additemt`: Thêm/xóa loại vật phẩm đang trỏ vào/khỏi danh sách những item nhặt theo loại.
- `/additemt` `X`: Thêm/xóa `itemType` `X` vào/khỏi danh sách những item nhặt theo loại.
- `/itemme`: Bật/tắt chỉ nhặt vật phẩm của bản thân.
- `/listitemclr`: Xóa sạch danh sách nhặt vật phẩm theo ID, Type.
- `/abf` `X` `Y`: Tự động dùng đậu thần khi HP dưới `X`%, KI dưới `X`%.
- `/abf` `X`: Tự động dùng đậu thần khi HP dưới `X`%.

## Các chức năng hỗ trợ up đệ tử
- `/cd`: Bật/tắt tự động cho đậu thần (Ấn vào bang, xem thành viên, ấn Thêm vào danh sách nhận đậu: Chỉ những nhân vật nào có trong danh sách đã thêm sẽ nhận được đậu. Nếu danh sách này trống, game sẽ tự động cho tất cả thành viên trong bang).
- `/td`: Bật/tắt tự động thu đậu thần và cất đậu thần vào rương.
- `/xd`: Bật/tắt tự động xin đậu thần.
- `/ajump`: Bật/tắt tự động nhảy.
- `/petinfo`: Bật/tắt hiển thị thông tin đệ tử dưới góc trái màn hình.
- `/dtnsq`: Bật/tắt tự động up đệ tử ở trạng thái bảo vệ (Thêm quái up giống lệnh đồ sát quái).
- `/aheal`: Bật/tắt tự động dùng trị thương cho các nhân vật đã thêm theo danh sách.
- `/addcheal`: Thêm/xóa nhân vật đang trỏ vào/khỏi danh sách nhân vật trị thương theo danh sách.
- `/addcheal` `X`: Thêm/xóa `charID` vào/khỏi danh sách nhân vật trị thương theo danh sách.
- `/pethp` `X`: Bật/tắt tự động sử dụng đậu thần khi HP đệ tử dưới `X`% (`X` = 0 thì TẮT).
- `/gohome`: Bật/tắt tự động cho đệ tử về nhà khi tách hợp thể.
- `/petsm` `X`: Giới hạn sức mạnh của đệ tử thành `X`, nếu đệ tử đạt sức mạnh lớn hơn hoặc bằng `X` sẽ tự động thoát game (`X` = 0 thì TẮT).
- `/ahs`: Bật/tắt tự động dùng ngọc hồi sinh tại chỗ.
- `/aflag`: Bật/tắt tự động bật cờ xám.
- `/xddb`: Bật/tắt tự động xin đậu đặc biệt: Tự động xin đậu rồi thoát game, đợi đăng nhập lại rồi xin đậu, lặp lại liên tục tới chết.

## Các lệnh cộng chỉ số
- `/hp` `X`: Tự động cộng HP lên `X`.
- `/mp` `X`: Tự động cộng KI lên `X`.
- `/dmg` `X`: Tự động cộng SĐ lên `X`.

## Các lệnh hỗ trợ up bí kiếp Yardart
- `/abt` `X` `Y`: Bật/tắt tự động sử dụng bông tai theo `X`%, `Y`% HP,KI (Khi tách tự động cho đệ về nhà).
- `/cobj`: Bật/tắt tự động chuyển focus sang quái yardart gần bản thân.

## Các lệnh liên quan tới map, khu, vị trí (Goback nói chung)
- `/xmp` `X`: Tự động di chuyển tới `mapID` `X`.
- `/k` `X`: Đổi nhanh sang khu `X`.
- `/kz` `X`: Tự động đổi vào khu `X`.
- `/kz`: Tắt tự động đổi khu.
- `/smap`: Lưu map để goback, khi chết sẽ tự động quay lại map.
- `/szone`: Lưu khu để goback, khi chết sẽ tự động quay lại khu.
- `/spos`: Lưu vị trí để goback, khi chết sẽ tự động quay lại vị trí.
- `/lcz`: Bật/tắt tự động khóa chuyển khu.
- `/lcm`: Bật/tắt tự động khóa chuyển map.
- `/vdh`: Bật/tắt di chuyển vượt địa hình (Chỉ tác dụng với đa số map).
- `/abdkb` `X`: Bật tự động mở BĐKB level `X`.

## Các lệnh liên quan tới Ngọc rồng sao đen
- `/nrd` `X` `Y`: Tự động vào map NRSĐ `X` sao khu `Y`.
- `/cvs`: Tắt tự động dùng sáo cho người khác.
- `/cvs` `X`: Bật/tắt tự động dùng sáo cho người đang trỏ khi người đang trỏ dưới `X`%HP
- `/cvs` `X` `Y`: Bật/tắt tự động dùng sáo cho người có `charID` là `X` khi dưới `Y`% HP.

## Các lệnh liên quan tới item 
- `/isell`: Bật/tắt tự động bán đồ rác, nếu đứng ở trạm tàu vũ trụ tương ứng với hành tinh sẽ tự động bán đồ rác, dùng mảnh quái, vứt vật phẩm rác. Nếu bật ở các map khác, khi nào hành trang đầy sẽ tự động đi tới TTVT để làm các thao tác trên.
- `/citem` `X` `Y`: Bật/tắt tự động căn nhặt vật phẩm có `itemID` là `X` với số lượng `Y` (`X`, `Y` = 0 thì TẮT), có thể thêm nhiều item để đếm nhặt, khi nhặt đủ số lượng của các loại item đã thêm sẽ tự out (Nhập lại ID của item đó để số lượng `Y` = 0 thì sẽ xóa không đếm nhặt item đó nữa).
- `/getitem`: In ra danh sách ID Item hiện có trong game (Kiểm tra trong folder Mod).
- `/autobuytdlt`: Bật/tắt tự động mua Tự động luyện tập khi hết.
- `/autobuykt`: Bật/tắt tự động mua khẩu trang khi hết.
- `/dropitem`: Bật/tắt tự động vứt item theo danh sách.
- `/additemdrop` `X`: Thêm/xóa `itemID` `X` vào danh sách vứt item theo ID (Lưu ý danh sách này thêm Item không có dòng hạn sử dụng).
- `/additemdrophsd` `X`: Thêm/xóa `itemID` `X` vào danh sách vứt item theo HSD (Lưu ý danh sách này thêm Item có dòng hạn sử dụng, nếu check thấy item có dòng hạn sử dụng tương ứng với `itemID` đã thêm sẽ tự động vứt).
- `/clrlistdrop`: Xóa sạch danh sách vứt vật phẩm theo ID, theo HSD.

## Các lệnh liên quan tới skill
- `/autoskill` `X`: Bật/tắt tự động dùng chiêu mỗi `X` mili giây.
- `/autoskill`: Tắt tự động dùng chiêu theo thời gian.
- `/rcvs`: Bật/tắt tự động đi hồi chiêu ở đại hội võ thuật 23.
- `/ats9`: Bật/tắt tự động dùng tuyệt kỹ (Super Kamejoko, Ma phong ba, Cadic liên hoàn chưởng).
- `/ats9g`: Bật/tắt tự động dùng tuyệt kỹ hồi bằng vàng tại đại hội võ thuật 23.
- `/frz` `X`: Fake thời gian hồi chiêu của skill đang trỏ thành `X` mili giây (`X` = 0 đồng nghĩa với đóng băng thời gian hồi chiêu).

## Các lệnh chat khác 
- `/dsnv`: Bật/tắt hiển thị danh sách các nhân vật/Boss xuất hiện trong map lên góc phải màn hình. 
- `/oinf`: Bật/tắt hiển thị thông tin về đối tượng đang trỏ (thông tin nhân vật, thông tin quái, thông tin vật phẩm).
- `/actg`: Tự động chat thế giới.
- `/achat_` `X`: Bật/tắt tự động chat nội dung `X` (`X` để trống thì TẮT).
- `/tele` `X`: Bật/tắt tự động dịch chuyển tức thời tới nhân vật có `charID` `X` và di chuyển tới vị trí của nhân vật đó (`X` = -1 thì TẮT).
- `/afriend`: Kết bạn với người đang trỏ.
- `/afriend` `X`: Kết bạn với người có `charID` `X`.
- `/hide`: Bật/tắt hiển thị thông tin map/khu/thời gian/vị trí/HP/KI.
- `/optm`: Bật/tắt tự động tối ưu CPU.
- `/alg`: Bật/tắt tự động đăng nhập lại sau khi mất kết nối (Mặc định: Bật)
- `/vqtd`: Mở menu vòng quay thượng đế (Chỉ dùng tại thần điện).
- `/kmt`: Bật/tắt khóa mục tiêu (khóa người/khóa quái/khóa Boss) đang trỏ vào.
- `/kmt` `X`: Bật/tắt khóa mục tiêu người có `charID` là `X`.
- `/rspeed` `X`: Chỉnh tốc độ chạy thành `X` (Mặc định: 7).
- `/gspeed` `X`: Chỉnh tốc độ game thành `X`.
- `/r` `X`: Dịch tọa độ nhân vật sang bên phải `X` đơn vị.
- `/l` `X`: Dịch tọa độ nhân vật sang bên trái `X` đơn vị.
- `/d` `X`: Dịch tọa độ nhân vật xuống bên dưới `X` đơn vị.
- `/u` `X`: Dịch tọa độ nhân vật lên bên trên `X` đơn vị.
- `/tbb`: Bật/tắt hiển thị thông báo các boss xuất hiện lên góc trên bên phải màn hình.

# Phím bấm
- __Phím `E`__:
    + Trong map NRSĐ: Bật/tắt tự động hồi sinh tại chỗ bằng ngọc.
    + Ngoài map NRSĐ: Focus tới Boss trong khu và dịch chuyển tới vị trí của Boss.
- __Phím `W`__: 
    + Trong map Khí gas hủy diệt: Focus tới siêu quái/cỗ máy hủy diệt và dịch chuyển tới vị trí của chúng.
    + Ngoài map Khí gas hủy diệt: Focus tới NPC trong map và dịch chuyển tới vị trí của NPC.
- __Phím `[`__: Bật tự động chèn vào khu bên dưới (Ấn thêm thì giảm khu 1 số)
- __Phím `]`__: Bật tự động chèn vào khu bên trên (Ấn thêm thì tăng khu 1 số)
- __Phím `I`__: Bật/tắt khóa mục tiêu đang trỏ.
- __Phím `B`__: Mở danh sách nhân vật.
- __Phím `F`__: Dùng bông tai/bông tai cấp 2.
- __Phím `/`__: Mở nhanh thanh chat lệnh.
- __Phím `Z`__: Mở danh sách khu.
- __Phím `V`__: Dịch chuyển đến vị trí của đối tượng đang trỏ.
- __Phím `H`__: Dùng item tự động luyện tập.
- __Phím `G`__: 
    + Trong map NRSĐ: Tắt nhặt và nhả viên NRSĐ ra đất.
    + Ngoài map NRSĐ: Gửi lời mời giao dịch tới người đang trỏ.
- __Phím `Q`__: Bật/tắt liên kết với QLTK.
- __Phím `A`__: Bật/tắt tự động đánh.
- __Phím `O`__: Đóng băng skill đang trỏ/Khôi phục lại thời gian hồi chiêu về mặc định.
- __Phím `U`__: Bật/tắt tự động đi hồi chiêu tại đại hội võ thuật 23.
- __Phím `S`__: Mặc set đồ 1,2 cho sư phụ.
- __Phím `D`__: Mặc set đồ 1,2 cho đệ tử.
- __Phím `-`__: Tự động cắm vệ tinh HP (Cắm spam).
- __Phím `J`__: Dịch sang bên rìa trái map hoặc chuyển map bên trái.
- __Phím `K`__: Dịch sang giữa map hoặc chuyển map ở giữa.
- __Phím `L`__: Dịch sang bên rìa phải map hoặc chuyển map bên phải.
- __Phím `X`__: Mở menu chọn map để Auto nextmap/Tắt tự động nextmap.
- __Phím `C`__: Dùng capsule thường/capsule đặc biệt.
- __Phím `T`__:
    + Trong map NRSĐ: Di chuyển tới người đang ôm NRSĐ/Viên NRSĐ.
    + Ngoài map NRSĐ: Bật/tắt tự động đồ sát quái.
- __Phím `N`__: Bật/tắt tự động nhặt vật phẩm.
- __Phím `,`__: Bật/tắt tối ưu CPU.
- __Phím `.`__: Bật/tắt hiển thị thông tin map/khu/thời gian/vị trí,...
- __Phím `M`__: Mở menu chức năng (Phần lớn lệnh ở trong đây).
- __Phím `=`__: Mở rương đồ (Chức năng chỉ dùng để quan sát).

# Về quản lý tài khoản
## Cách kích hoạt QLTK
__Bước 1__: Mở `License.exe`, copy Mã kích hoạt.
</br>__Bước 2__: Truy cập phần `Lịch sử mua tool` trên web [thanhlc.com](https://thanhlc.com), ấn `EDIT` Mod tương ứng.
</br>__Bước 3__: Nhập mã kích hoạt đã copy bên trên vào ô `EDIT`, rồi ấn `Lưu`. 
</br>__Bước 4__: Mở QLTK.

## Cách chuyển file `dataAccount.json` từ phiên bản cũ sang phiên bản mới
Để tránh việc phải nhập lại tài khoản nhiều lần, vào folder của phiên bản cũ, kiếm folder `Data`, tìm folder `QLTK`, copy file `dataAccount.json` nằm trong folder `QLTK`. Sau đó dán (paste) sang folder `Data/QLTK` của phiên bản mới. Sau đó mở QLTK lên để load lại data.

## Cách thêm lô tài khoản
__Bước 1__: Nhập dạng tài khoản của lô vào ô điền Tài khoản theo dạng số thay đổi. 
</br>*VD*: `taikhoanX@gmail.com` `X` là số thay đổi.
</br>__Bước 2__: Tích vào `Thêm TK theo lô`, điền các thông tin như `mật khẩu`, `máy chủ`, `ghi chú`. Sau đó ấn nút `Thêm`. 
</br>__Bước 3__: Sau khi ấn nút `Thêm`, nhập số thay đổi của `X` từ bao nhiêu tới bao nhiêu, sau đó ấn `Thêm` là xong.

## Cách sửa kích thước/ghi chú cho nhiều tài khoản một lúc
__Bước 1__: Bôi đen những dòng tài khoản trong bảng của QLTK.
</br>__Bước 2__: Ấn chuột phải, chọn `Sửa kích thước`, nhập kích thước mới rồi ấn `Lưu`. 

## Cách thêm Proxy cho nhiều tài khoản và đăng nhập bằng proxy
__Bước 1__: Bôi đen những dòng tài khoản trong bảng của QLTK.
</br>__Bước 2__: Ấn nút `Thêm Proxy`, sau đó điền thông tin Proxy rồi ấn `Lưu`.
</br>__Bước 3__: Tích cột `Proxy` trong bảng của QLTK, tài khoản nào đã tích sẽ login bằng IP của proxy.

## Cách sử dụng phần trang `Điều khiển`
*__Lưu ý__*: Tài khoản nào đã đăng nhập game, đã hiển thị trạng thái `Đã kết nối` trên bảng mới có thể dùng chức năng này. 
</br>Bật/tắt kết nối bằng phím `Q` ở trong game, hoặc để tự động kết nối bằng cách tích `Tự động kết nối QLTK` trong phần trang `CÀI ĐẶT`.

## Giải captcha
*__Lưu ý__*: Chỉ size bé của game mới giải được captcha chính xác. 
</br>Điền Link captcha vào ô `Giải captcha`, sau đó ấn tích `Giải captcha` (Không điền token).

## Đăng nhập nhiều tài khoản
__Bước 1__: Bôi đen những dòng tài khoản trong bảng của QLTK muốn đăng nhập.
</br>__Bước 2__: Ấn chuột phải, chọn `ĐĂNG NHẬP` hoặc ấn vào nút `Đăng nhập`. 
</br>*__Lưu ý__*: ngoài ra có thể nháy chuột 2 lần vào hàng để mở nhanh tài khoản đó.

## Chức năng `Auto mở game`
Chức năng này sẽ tự động mở lại những tab game đã bị đóng. 
</br>QLTK sẽ mở lại những dòng tài khoản của bảng trong QLTK đã tích tại cột `X`. 

## Phần `CÀI ĐẶT` của QLTK
Tất cả cài đặt ở đây sẽ ảnh hưởng tới việc lúc mới đầu vào game, game sẽ bật/tắt/tuân theo chức năng gì. 

# Các chức năng phụ khác
- Thay đổi hình nền
    + Thay đổi ảnh wallpaper.png trong folder Data. Lưu ý phải thay đổi ảnh cùng định dạng.
- Tự động đánh quái khi đệ tử cần
    + Khi đệ tử nói "Sao sư phụ...", game sẽ bật khiên (nếu có gắn) sau đó sẽ đánh quái gần nhất.
- DCTT không cần mặc cải trang Yardart
- Chat tiếng việt (Bật/tắt ở phím `M`, phải tắt Unikey của máy).
- Tự động mở Doanh trại độc nhãn (Bật/tắt ở phím `M`).
- Sắp xếp danh sách nhân vật theo tên bang, màu cờ, mặc định (Chọn ở QLTK `CÀI ĐẶT` hoặc tìm trong phím `M`).
- Tự động dùng nho tím/nho xanh khi hết thể lực (Mặc định: Bật).
- Kết bạn và dịch chuyển tới với kẻ thù/thành viên bang.
- Tự động load lại skill khi đăng nhập.

# Các option của game

| Option            | Mô tả                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     | Giá         | HSD       |   |
|-------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------|-----------|---|
| Proxy             | Cho phép người dùng gắn Proxy cho tài khoản game và đăng nhập bằng IP của proxy                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           | 50.000 VNĐ  | Vĩnh viễn |   |
| Custom Key        | Cho phép người dùng gắn chức năng hiện có vào phím tắt tùy thích.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         | 50.000 VNĐ  | Vĩnh viễn |   |
| Ngọc rồng sao đen | Gồm các chức năng hỗ trợ đi Ngọc rồng sao đen. </br> - Tự động dùng sáo cho đối tượng theo % HP Cài đặt. </br>- Capsule bom: Tự động capsule về map trước đó, đợi 3s sau đó dùng bom.</br>- Teleport bom: Tự động teleport tới nhân vật chỉ định, đợi 3s sau đó đùng bom.</br>- Dùng khiên trước khi capsule bom: Sau khi capsule về map, bật khiên sau đó rồi dùng bom.</br>- Tự động khóa vị trí khi capsule bom: Sau khi capsule về map, tự động di chuyển tới vị trí của người đang cài đặt sau đó dùng bom. </br>- Tự động cắm vệ tinh HP (Spam vệ tinh HP).</br>- Tự động khóa vị trí, khóa focus của người đang ôm NRSĐ/viên NRSĐ. | 250.000 VNĐ | Vĩnh viễn |   |
| Custom Logo       | Cho phép người dùng thay đổi logo trong game theo ý mình.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 | 250.000 VNĐ | Vĩnh viễn |   |

<hr style="border:2px solid green">

Tác giả: Lê Chí Thanh
</br>Website: https://thanhlc.com/
</br>Facebook: https://www.facebook.com/lcthanh172
<!---
</br>Mọi sản phẩm từ các nguồn khác đều là sản phẩm không chính hãng, không chịu trách nhiệm bảo hành, khi xảy ra sự cố mất mát tự chịu trách nhiệm. 
</br>Các sản phẩm crack từ các nguồn khác nhau đều không an toàn.
-->