## Bài đã làm

| Bài | Nội dung |
|-----|----------|
| 1 | Kiểm tra tính đúng đắn của biểu thức toán học: dùng Stack kiểm tra các dấu ngoặc tròn `()`, ngoặc vuông `[]`, ngoặc nhọn `{}` có được mở và đóng đúng cách không |
| 2 | Mô phỏng lịch sử trình duyệt web bằng hai Stack (back, forward): truy cập trang mới (xóa sạch Stack forward), quay lại, tiến lên, hiển thị trang hiện tại (dùng lại code của Bài TH4) |
| 3 | Mô phỏng quá trình thực thi chương trình bằng call stack: mỗi khung ngăn xếp chứa tên hàm, tham số, địa chỉ trả về; gọi hàm, trả về từ hàm, hiển thị call stack, mô phỏng đệ quy `GiaiThua(n)` |
| 4 | Mô phỏng hệ thống in ấn bằng Queue theo nguyên tắc FIFO: thêm yêu cầu in, xử lý yêu cầu in, hiển thị hàng đợi (dùng lại code của Bài TH6) |
| 5 | Mô phỏng đường truyền dữ liệu bằng Queue: mỗi gói tin có nội dung, độ trễ và lỗi đường truyền; gửi gói tin, nhận gói tin (gói tin lỗi bị bỏ qua), hiển thị các gói tin trong hàng đợi |
| 6 | Mô phỏng hàng đợi tại Trung tâm Dịch vụ Khách hàng bằng Queue: thêm khách hàng (tên, giờ đến, loại dịch vụ), phục vụ khách hàng đầu hàng đợi, hiển thị trạng thái hàng đợi |
| TH4 | Mô phỏng lịch sử trình duyệt web bằng hai Stack `backStack`, `forwardStack` và biến `currentPage`: `Visit`, `Back`, `Forward`, `ShowCurrentPage` |
| TH5 | Kiểm tra chuỗi chỉ chứa ký tự `(` và `)` có đúng dấu ngoặc không bằng Stack, hiển thị "Xau dung" hoặc "Xau sai" |
| TH6 | Mô phỏng hệ thống in ấn bằng Queue: thêm yêu cầu in, xử lý yêu cầu in, hiển thị danh sách hàng đợi |
| TH7 | Mô phỏng đường truyền dữ liệu bằng Queue: gửi dữ liệu, nhận dữ liệu, hiển thị dữ liệu trong hàng đợi |
| TH8 | Mô phỏng dịch vụ khách hàng bằng Queue: thêm khách hàng (tên hoặc số thứ tự), phục vụ khách hàng, hiển thị danh sách khách hàng đang chờ |
| TH9 | Tính giá trị biểu thức hậu tố (các phần tử cách nhau bởi dấu cách, chỉ có `+`, `-`, `*`, `/`) bằng Stack |
| TH10 | Kiểm tra tính hợp lệ của biểu thức trung tố: ngoặc `()`, `[]`, `{}` mở đóng đúng cách, không có hai toán tử liên tiếp, không bắt đầu hoặc kết thúc bằng toán tử |
| TH11 | Tính giá trị biểu thức trung tố: kiểm tra hợp lệ, chuyển sang hậu tố bằng giải thuật BaLan, rồi dùng Stack tính giá trị biểu thức hậu tố |

Bài 1 đến Bài 6 thuộc phần bài tập áp dụng (mục 5.5.2). Bài TH4 đến Bài TH11 là Bài 4 đến Bài 11 của phần bài tập thực hành nên giữ nguyên số bài, do đó không có TH1 đến TH3. Bài 2 dùng lại code của Bài TH4 và Bài 4 dùng lại code của Bài TH6 nên chạy cho kết quả giống nhau.

## Lệnh chạy

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 6
dotnet run th4
dotnet run th5
dotnet run th6
dotnet run th7
dotnet run th8
dotnet run th9
dotnet run th10
dotnet run th11
```

Có thể dùng `bai1` đến `bai6` và `baith4` đến `baith11` thay cho `1` đến `6` và `th4` đến `th11`. Nếu không truyền tham số, chương trình sẽ đọc tên bài từ bàn phím.

## Kết quả chạy

### Bài 1

```
Nhap bieu thuc: (a+b)*[c-d]
Cac dau ngoac duoc mo va dong dung cach
```

Biểu thức có ngoặc sai:
```
Nhap bieu thuc: (a+b]*c
Cac dau ngoac khong hop le
```

### Bài 2

```
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 1
Nhap URL: google.com
Dang truy cap: google.com
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 1
Nhap URL: youtube.com
Dang truy cap: youtube.com
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 2
Quay lai: google.com
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 3
Tien len: youtube.com
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 4
Trang hien tai: youtube.com
1. Truy cap trang moi
2. Quay lai
3. Tien len
4. Hien thi trang hien tai
0. Thoat
Chon: 0
```

### Bài 3

```
Goi ham Main()
1. Goi ham
2. Tra ve tu ham
3. Hien thi call stack
4. Mo phong de quy GiaiThua(n)
0. Thoat
Chon: 1
Ten ham: A
Tham so: 5
Goi ham A(5)
1. Goi ham
2. Tra ve tu ham
3. Hien thi call stack
4. Mo phong de quy GiaiThua(n)
0. Thoat
Chon: 3
Call stack (tu dinh xuong day):
| A(5) - tro ve Main
| Main() - he dieu hanh
1. Goi ham
2. Tra ve tu ham
3. Hien thi call stack
4. Mo phong de quy GiaiThua(n)
0. Thoat
Chon: 2
Ham A(5) ket thuc, tro ve Main
1. Goi ham
2. Tra ve tu ham
3. Hien thi call stack
4. Mo phong de quy GiaiThua(n)
0. Thoat
Chon: 4
Nhap n (1..20): 3
Goi ham GiaiThua(3)
Goi ham GiaiThua(2)
Goi ham GiaiThua(1)
Call stack (tu dinh xuong day):
| GiaiThua(1) - tro ve GiaiThua
| GiaiThua(2) - tro ve GiaiThua
| GiaiThua(3) - tro ve Main
| Main() - he dieu hanh
GiaiThua(1) tra ve 1
GiaiThua(2) tra ve 2
GiaiThua(3) tra ve 6
1. Goi ham
2. Tra ve tu ham
3. Hien thi call stack
4. Mo phong de quy GiaiThua(n)
0. Thoat
Chon: 0
```

### Bài 4

```
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 1
Nhap ten tai lieu: bao_cao.docx
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 1
Nhap ten tai lieu: bai_tap.pdf
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 3
1. bao_cao.docx
2. bai_tap.pdf
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 2
Dang in: bao_cao.docx
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 2
Dang in: bai_tap.pdf
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 2
Khong co yeu cau in nao!
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 3
Hang doi rong
1. Them yeu cau in
2. Xu ly yeu cau in
3. Hien thi danh sach hang doi
0. Thoat
Chon: 0
```

### Bài 5

```
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 1
Nhap noi dung goi tin: P1
Nhap do tre (ms): 20
Goi tin co bi loi khong? (c/k): k
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 1
Nhap noi dung goi tin: P2
Nhap do tre (ms): 50
Goi tin co bi loi khong? (c/k): c
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 3
1. P1 - do tre 20 ms - binh thuong
2. P2 - do tre 50 ms - loi
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 2
Da nhan P1 (do tre 20 ms)
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 2
Goi tin P2 bi loi duong truyen, bo qua
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 2
Khong co goi tin de nhan!
1. Gui goi tin
2. Nhan goi tin
3. Hien thi cac goi tin trong hang doi
0. Thoat
Chon: 0
```

### Bài 6

```
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 1
Nhap ten khach hang: An
Nhap loai dich vu: Rut tien
Khach An den luc 08:30:15
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 1
Nhap ten khach hang: Binh
Nhap loai dich vu: Gui tien
Khach Binh den luc 08:31:02
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 3
Co 2 khach dang cho
1. An - Rut tien - den luc 08:30:15
2. Binh - Gui tien - den luc 08:31:02
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 2
Dang phuc vu: An - Rut tien (den luc 08:30:15)
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 3
Co 1 khach dang cho
1. Binh - Gui tien - den luc 08:31:02
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi trang thai hang doi
0. Thoat
Chon: 0
```

Giờ đến lấy theo giờ hệ thống nên kết quả thay đổi mỗi lần chạy.

### Bài TH4

Chạy giống Bài 2.

### Bài TH5

```
Nhap chuoi ngoac: (()())
Xau dung
```

Chuỗi sai:
```
Nhap chuoi ngoac: (()
Xau sai
```

```
Nhap chuoi ngoac: )(
Xau sai
```

### Bài TH6

Chạy giống Bài 4.

### Bài TH7

```
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 1
Nhap goi du lieu: A
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 1
Nhap goi du lieu: B
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 3
1. A
2. B
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 2
Da nhan: A
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 2
Da nhan: B
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 2
Khong co du lieu de nhan!
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 3
Hang doi rong
1. Gui du lieu
2. Nhan du lieu
3. Hien thi du lieu trong hang doi
0. Thoat
Chon: 0
```

### Bài TH8

```
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 1
Nhap ten hoac so thu tu khach hang: An
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 1
Nhap ten hoac so thu tu khach hang: Binh
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 3
1. An
2. Binh
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 2
Dang phuc vu: An
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 2
Dang phuc vu: Binh
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 3
Khong co khach hang nao dang cho
1. Them khach hang
2. Phuc vu khach hang
3. Hien thi danh sach khach hang cho
0. Thoat
Chon: 0
```

### Bài TH9

```
Nhap bieu thuc hau to (cach nhau boi dau cach): 3 4 + 2 *
Gia tri bieu thuc: 14
```

### Bài TH10

```
Nhap bieu thuc trung to: (3 + 4) * 2
Bieu thuc hop le
```

Biểu thức sai thứ tự toán tử:
```
Nhap bieu thuc trung to: 3 + * 4
Bieu thuc khong hop le
```

### Bài TH11

```
Nhap bieu thuc trung to: (3 + 4) * 2 - 6 / 3
Bieu thuc hau to: 3 4 + 2 * 6 3 / -
Gia tri bieu thuc: 12
```

Biểu thức có ký tự không hợp lệ:
```
Nhap bieu thuc trung to: 3 + a
Bieu thuc khong hop le
```