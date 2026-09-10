# TEST CASE – Hệ thống CABSYSTEM


## Danh sách Test Case

| Mã TC | Chức năng | Mục tiêu kiểm thử | Dữ liệu đầu vào | Kết quả mong đợi |
|--------|-----------|-------------------|-----------------|------------------|
| TC001 | Đăng nhập | Đăng nhập đúng tài khoản | Email + mật khẩu hợp lệ | Vào trang Dashboard |
| TC002 | Đăng nhập | Sai mật khẩu | Email đúng + mật khẩu sai | Hiển thị thông báo lỗi |
| TC003 | Đăng ký | Tạo tài khoản khách hàng | Thông tin hợp lệ | Đăng ký thành công |
| TC004 | Đặt xe | Tạo chuyến đi mới | Điểm đón + điểm đến | Chuyến đi được tạo |
| TC005 | Đặt xe | Thiếu điểm đón | Chỉ nhập điểm đến | Báo lỗi dữ liệu |
| TC006 | Tài xế | Chuyển trạng thái Online | Trạng thái = Online | Tài xế sẵn sàng nhận chuyến |
| TC007 | Tài xế | Phân công tài xế tự động | Có chuyến mới | Hệ thống gán tài xế gần nhất |
| TC008 | Chuyến đi | Bắt đầu chuyến | Chuyến đã được nhận | Trạng thái = Đang thực hiện |
| TC009 | Chuyến đi | Hoàn thành chuyến | Chuyến kết thúc | Trạng thái = Hoàn thành |
| TC010 | Thanh toán | Thanh toán tiền mặt | Chuyến hoàn thành | Lưu thông tin thanh toán |
| TC011 | Thanh toán | Thanh toán điện tử | Chuyến hoàn thành | Thanh toán thành công |
| TC012 | Đánh giá | Khách hàng đánh giá | 5 sao + nội dung | Lưu đánh giá thành công |
| TC013 | Phương tiện | Thêm xe mới | Thông tin xe hợp lệ | Xe được thêm vào hệ thống |
| TC014 | Báo cáo | Xem báo cáo chuyến đi | Khoảng thời gian | Hiển thị danh sách báo cáo |
| TC015 | Đăng xuất | Thoát khỏi hệ thống | Nhấn Đăng xuất | Quay về màn hình đăng nhập |

## Tiêu chí đạt

- Tất cả trường bắt buộc phải được kiểm tra.
- Chỉ tài xế Online mới được nhận chuyến.
- Chỉ thanh toán khi chuyến đi đã hoàn thành.
- Chỉ khách hàng của chuyến đi mới được đánh giá.
- Người chưa đăng nhập không được truy cập API được bảo vệ.
