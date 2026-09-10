# TEST CASE – CAB SYSTEM

**Dự án:** CAB Ride Booking System

**Tài liệu tham chiếu:** SRS.md

## Danh sách Test Case

| Test Case ID | Test Scenario | Test Case | Tiền điều kiện | Các bước thực hiện | Dữ liệu kiểm thử | Kết quả mong đợi | Độ ưu tiên |
|---|---|---|---|---|---|---|---|
| **TC-AUTH-001** | Đăng nhập | Đăng nhập với tài khoản hợp lệ | Khách hàng đã có tài khoản | 1. Mở màn hình Đăng nhập<br>2. Nhập email và mật khẩu<br>3. Nhấn **Đăng nhập** | Email: customer01@gmail.com<br>MK: 123456 | Đăng nhập thành công và chuyển đến Dashboard | Cao |
| **TC-AUTH-002** | Đăng nhập | Đăng nhập với email không tồn tại | Hệ thống hoạt động bình thường | 1. Nhập email không tồn tại<br>2. Nhập mật khẩu<br>3. Đăng nhập | abc@gmail.com | Hiển thị thông báo thông tin đăng nhập không hợp lệ | Cao |
| **TC-AUTH-003** | Đăng nhập | Đăng nhập với mật khẩu sai | Email đã tồn tại | 1. Nhập email đúng<br>2. Nhập mật khẩu sai<br>3. Đăng nhập | customer01@gmail.com / Wrong123 | Đăng nhập thất bại và không tạo phiên làm việc | Cao |
| **TC-BOOK-001** | Đặt xe | Tạo yêu cầu đặt xe thành công | Khách hàng đã đăng nhập | 1. Nhập điểm đón<br>2. Nhập điểm đến<br>3. Chọn loại xe<br>4. Nhấn **Đặt xe** | Quận 1 → Quận 7 | Hệ thống tạo chuyến và chuyển sang trạng thái **Đang tìm tài xế** | Cao |
| **TC-BOOK-002** | Đặt xe | Đặt xe khi chưa đăng nhập | Người dùng chưa xác thực | 1. Mở màn hình Đặt xe<br>2. Nhấn Đặt xe | Quận 1 → Quận 7 | Hệ thống yêu cầu đăng nhập trước khi đặt xe | Cao |
| **TC-BOOK-003** | Đặt xe | Đặt xe khi thiếu điểm đón | Khách hàng đã đăng nhập | 1. Để trống điểm đón<br>2. Nhấn Đặt xe | Điểm đón: Trống | Hiển thị lỗi bắt buộc nhập điểm đón | Trung bình |
| **TC-DRV-001** | Tìm tài xế | Phân công tài xế Online | Có ít nhất một tài xế Online | 1. Khách hàng tạo chuyến<br>2. Hệ thống tìm tài xế | Driver A (Online) | Driver A nhận được thông báo chuyến mới | Cao |
| **TC-DRV-002** | Tìm tài xế | Tài xế Offline không nhận chuyến | Driver B ở trạng thái Offline | 1. Tạo chuyến mới | Driver B | Driver B không nhận được thông báo | Cao |
| **TC-DRV-003** | Phân công chuyến | Tài xế từ chối chuyến | Driver đã nhận thông báo | 1. Nhấn **Từ chối** | Trip #1001 | Hệ thống tự động tìm tài xế khác | Cao |
| **TC-DRV-004** | Phân công chuyến | Tài xế không phản hồi | Driver không thao tác | 1. Chờ hết thời gian phản hồi | Timeout 20 giây | Hệ thống chuyển yêu cầu sang tài xế tiếp theo | Cao |
| **TC-DRV-005** | Trạng thái tài xế | Tài xế đang bận nhận thêm chuyến | Driver đang thực hiện một chuyến khác | 1. Khách tạo chuyến mới | Driver Status = Busy | Driver không được phân công thêm | Cao |
| **TC-TRIP-001** | Cập nhật chuyến | Tài xế đến điểm đón | Chuyến đã được nhận | 1. Nhấn **Đã đến điểm đón** | Trip #1001 | Khách hàng nhận thông báo tài xế đã đến | Trung bình |
| **TC-TRIP-002** | Cập nhật chuyến | Tài xế đón khách | Driver đã đến điểm đón | 1. Nhấn **Đã đón khách** | Trip #1001 | Trạng thái chuyến chuyển thành **Đang di chuyển** | Cao |
| **TC-TRIP-003** | Hoàn thành chuyến | Kết thúc chuyến đi | Chuyến đang thực hiện | 1. Nhấn **Hoàn thành chuyến** | Quãng đường: 8 km | Hệ thống tính cước và tạo hóa đơn | Cao |
| **TC-PAY-001** | Thanh toán | Thanh toán bằng tiền mặt | Chuyến đã hoàn thành | 1. Chọn **Tiền mặt**<br>2. Xác nhận | 120.000 VNĐ | Giao dịch được lưu thành công | Cao |
| **TC-PAY-002** | Thanh toán | Thanh toán điện tử thành công | Chuyến đã hoàn thành | 1. Chọn Ví điện tử<br>2. Xác nhận thanh toán | MoMo / Visa | Trạng thái thanh toán = **Đã thanh toán** | Cao |
| **TC-PAY-003** | Thanh toán | Thanh toán điện tử thất bại | Cổng thanh toán trả lỗi | 1. Thực hiện thanh toán | Gateway Error | Hiển thị thông báo lỗi và cho phép thanh toán lại | Cao |
| **TC-PAY-004** | Thanh toán | Thanh toán khi chuyến chưa hoàn thành | Chuyến đang thực hiện | 1. Nhấn **Thanh toán** | Trip #1002 | Hệ thống từ chối thanh toán | Cao |
| **TC-SEC-001** | Bảo mật | Kiểm tra lưu thông tin thanh toán | Thanh toán điện tử thành công | 1. Thanh toán bằng Visa<br>2. Kiểm tra dữ liệu lưu | Visa ****1234 | Chỉ lưu mã giao dịch, không lưu số thẻ | Cao |
| **TC-RATE-001** | Đánh giá | Khách hàng đánh giá tài xế | Khách đã hoàn thành chuyến | 1. Chọn 5 sao<br>2. Nhập bình luận<br>3. Gửi | 5 sao | Đánh giá được lưu thành công | Trung bình |
| **TC-RATE-002** | Đánh giá | Người không phải chủ chuyến đánh giá | User không tham gia chuyến | 1. Gửi đánh giá | Trip #1001 | Hiển thị thông báo **Không có quyền đánh giá** | Cao |
| **TC-ADM-001** | Báo cáo | Quản trị viên xem báo cáo doanh thu | Tài khoản Admin | 1. Mở Báo cáo<br>2. Chọn khoảng thời gian | 01/09–30/09 | Hiển thị doanh thu, số chuyến và tỷ lệ hoàn thành | Trung bình |
| **TC-ADM-002** | Phân quyền | Nhân viên thường truy cập báo cáo | Tài khoản Staff | 1. Mở Báo cáo | Staff Account | Từ chối truy cập do không đủ quyền | Trung bình |

---

## Liên kết với Business Rules

| Business Rule | Test Case |
|---|---|
| BR01 – Người dùng phải đăng nhập trước khi sử dụng chức năng yêu cầu tài khoản | TC-AUTH-001, TC-AUTH-002, TC-AUTH-003, TC-BOOK-002 |
| BR02 – Chỉ tài xế Online mới được nhận chuyến | TC-DRV-001, TC-DRV-002 |
| BR03 – Mỗi tài xế chỉ thực hiện một chuyến tại một thời điểm | TC-DRV-003, TC-DRV-004, TC-DRV-005 |
| BR04 – Thanh toán chỉ thực hiện sau khi chuyến hoàn thành | TC-TRIP-003, TC-PAY-001, TC-PAY-002, TC-PAY-003, TC-PAY-004 |
| BR05 – Chỉ khách hàng của chuyến mới được đánh giá tài xế | TC-RATE-001, TC-RATE-002 |
| BR06 – Hệ thống không lưu thông tin nhạy cảm của thẻ thanh toán | TC-SEC-001 |
