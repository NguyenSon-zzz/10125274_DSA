## Bài đã làm

| Bài | Nội dung |
|-----|----------|
| 1 | Nhập n số nguyên dương, in danh sách, nhập x và vị trí k rồi chèn x vào danh sách bằng mảng trung gian |
| 2 | Quản lý nhân viên bằng struct: tổng thực lĩnh, nhân viên có lương cơ bản thấp nhất, đếm thưởng >= 1200000, sắp xếp tăng dần theo phòng ban (trùng thì giảm dần theo mã), tăng lương cơ bản 5% |
| 3 | Ma trận vuông n x n (0 <= n < 100): tổng các phần tử, số dương nhỏ nhất, tổng đường chéo phụ, kiểm tra đường chéo chính có tăng dần không |
| 4 | Danh sách liên kết đơn số nguyên dương: đếm số bằng x, tìm số dương nhỏ nhất, xóa x xuất hiện đầu tiên |
| 5 | Danh sách liên kết đơn số nguyên: phần tử lớn nhất, tổng, đếm số nguyên tố, đếm số âm / bằng 0 / dương, đếm số bằng x, số dương nhỏ nhất |
| 7 | Nhập nhiệt độ n ngày, tìm ngày nóng nhất, ngày lạnh nhất và tính nhiệt độ trung bình |
| 8 | Nhập một chuỗi, chuẩn hóa (chữ thường, xóa ký tự đặc biệt), đếm số lần xuất hiện của mỗi từ bằng Dictionary rồi sắp xếp giảm dần theo số lần |
| 9 | Nhập dãy số nguyên, tìm số nguyên tố, số chẵn, số hoàn hảo |
| 10 | Nhập ma trận m x n, in theo thứ tự xoắn ốc bằng 4 biên top, bottom, left, right |
| 11 | Kiểm tra ma trận vuông có phải ma trận đơn vị, ma trận đối xứng không |
| 12 | Tạo bảng minesweeper m x n, đặt mìn ngẫu nhiên, tính số mìn xung quanh mỗi ô |
| 13 | Đảo ngược danh sách liên kết đơn không dùng đệ quy, dùng 3 con trỏ previous, current, next |
| 14 | Gộp hai danh sách liên kết đã sắp xếp tăng dần thành một danh sách sắp xếp |
| 15 | Phát hiện chu trình trong danh sách liên kết bằng thuật toán Floyd (rùa và thỏ) |
| 16 | Mô phỏng lịch sử duyệt web (back/forward) bằng danh sách liên kết kép và con trỏ current |
| 17 | Quản lý playlist nhạc bằng danh sách liên kết kép: thêm, xóa bài hát, next, previous |
| 18 | Quản lý đơn hàng với trạng thái Chờ xử lý → Đang giao → Hoàn thành bằng danh sách liên kết kép |

Chương trình không có Bài 6: Bài 7 đến Bài 18 thuộc phần bài tập thực hành khác nên giữ nguyên số bài.

## Lệnh chạy

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10
dotnet run 11
dotnet run 12
dotnet run 13
dotnet run 14
dotnet run 15
dotnet run 16
dotnet run 17
dotnet run 18
```

Có thể dùng `bai1` đến `bai18` thay cho `1` đến `18` (trừ `bai6`). Nếu không truyền tham số, chương trình sẽ đọc tên bài từ bàn phím.

## Kết quả chạy

### Bài 1

```
Nhap so cac so nguyen duong: 3
numbers[0] = 1
numbers[1] = 2
numbers[2] = 3
Danh sach: 1 2 3
Nhap x: 9
Nhap vi tri muon chen: 1
Danh sach sau khi chen: 1 9 2 3
```

### Bài 2

```
Nhap so nhan vien: 3
Nhan vien thu 1:
Ma nhan vien: NV01
Ho va ten: An
Nam sinh: 1990
Phong ban: KT
Luong co ban: 5000000
Thuong: 1000000
Nhan vien thu 2:
Ma nhan vien: NV02
Ho va ten: Binh
Nam sinh: 1991
Phong ban: KD
Luong co ban: 5000000
Thuong: 1500000
Nhan vien thu 3:
Ma nhan vien: NV03
Ho va ten: Cuong
Nam sinh: 1992
Phong ban: KT
Luong co ban: 7000000
Thuong: 1200000
Danh sach nhan vien:
MaNV      Ho ten                   Nam sinh  Phong ban      Luong CB    Thuong      Thuc linh   
NV01      An                       1990      KT             5000000     1000000     6000000     
NV02      Binh                     1991      KD             5000000     1500000     6500000     
NV03      Cuong                    1992      KT             7000000     1200000     8200000     
a. Tong thuc linh thang: 20700000
b. Nhan vien co luong co ban thap nhat (5000000):
MaNV      Ho ten                   Nam sinh  Phong ban      Luong CB    Thuong      Thuc linh   
NV01      An                       1990      KT             5000000     1000000     6000000     
NV02      Binh                     1991      KD             5000000     1500000     6500000     
c. So nhan vien co thuong >= 1200000: 2
d. Danh sach tang dan theo phong ban, trung phong ban thi giam dan theo ma:
MaNV      Ho ten                   Nam sinh  Phong ban      Luong CB    Thuong      Thuc linh   
NV02      Binh                     1991      KD             5000000     1500000     6500000     
NV03      Cuong                    1992      KT             7000000     1200000     8200000     
NV01      An                       1990      KT             5000000     1000000     6000000     
e. Danh sach sau khi tang luong co ban 5%:
MaNV      Ho ten                   Nam sinh  Phong ban      Luong CB    Thuong      Thuc linh   
NV01      An                       1990      KT             5250000     1000000     6250000     
NV02      Binh                     1991      KD             5250000     1500000     6750000     
NV03      Cuong                    1992      KT             7350000     1200000     8550000     
```

### Bài 3

```
Nhap n (0 <= n < 100): 2
a[0,0] = 2
a[0,1] = -1
a[1,0] = 3
a[1,1] = 4
Ma tran:
2	-1	
3	4	
a. Tong cac phan tu: 8
b. Gia tri duong nho nhat: 2
c. Tong duong cheo phu: 2
d. Duong cheo chinh tang dan
```

### Bài 4

```
Nhap so phan tu cua danh sach: 3
Phan tu thu 1: 3
Phan tu thu 2: 1
Phan tu thu 3: 3
Danh sach: 3 1 3 
Nhap x: 3
a. So luong phan tu bang 3: 2
b. Phan tu duong nho nhat: 1
c. Da xoa 3 xuat hien dau tien
Danh sach: 1 3 
```

### Bài 5

```
Nhap so phan tu cua danh sach: 5
Phan tu thu 1: 2
Phan tu thu 2: -1
Phan tu thu 3: 0
Phan tu thu 4: 3
Phan tu thu 5: 3
Danh sach: 2 -1 0 3 3 
a. Phan tu lon nhat: 3
b. Tong cac phan tu: 7
c. So luong so nguyen to: 3
d. So am: 1, so 0: 1, so duong: 3
Nhap x: 3
e. So luong phan tu bang 3: 2
f. Phan tu duong nho nhat: 2
```

### Bài 7

```
Nhap so ngay: 3
Nhiet do ngay 1: 30
Nhiet do ngay 2: 35
Nhiet do ngay 3: 28
Ngay nong nhat: ngay 2 (35)
Ngay lanh nhat: ngay 3 (28)
Nhiet do trung binh: 31.00
```

### Bài 8

```
Nhap mot chuoi van ban: Chao ban, chao!
Tu                  So lan    
chao                2         
ban                 1         
```

### Bài 9

```
Nhap so phan tu: 3
a[0] = 6
a[1] = 7
a[2] = 2
Cac so nguyen to (2): 7 2 
Cac so chan (2): 6 2 
Cac so hoan hao (1): 6 
```

### Bài 10

```
Nhap so dong m: 2
Nhap so cot n: 3
a[0,0] = 1
a[0,1] = 2
a[0,2] = 3
a[1,0] = 4
a[1,1] = 5
a[1,2] = 6
Ma tran:
1	2	3	
4	5	6	
Thu tu xoan oc: 1 2 3 6 5 4 
```

### Bài 11

```
Nhap cap ma tran vuong n: 2
a[0,0] = 1
a[0,1] = 0
a[1,0] = 0
a[1,1] = 1
Ma tran:
1	0	
0	1	
La ma tran don vi
La ma tran doi xung
```

### Bài 12

```
Nhap so dong m: 3
Nhap so cot n: 3
Nhap so min: 2
Bang minesweeper:
0	1	*	
1	2	1	
*	1	0	
```

Kết quả thay đổi mỗi lần chạy vì mìn được đặt ngẫu nhiên.

### Bài 13

```
Nhap so phan tu cua danh sach: 3
Phan tu thu 1: 1
Phan tu thu 2: 2
Phan tu thu 3: 3
Truoc khi dao nguoc - Danh sach: 1 2 3 
Sau khi dao nguoc - Danh sach: 3 2 1 
```

### Bài 14

```
Danh sach 1 (nhap tang dan):
Nhap so phan tu cua danh sach: 2
Phan tu thu 1: 1
Phan tu thu 2: 4
Danh sach 2 (nhap tang dan):
Nhap so phan tu cua danh sach: 3
Phan tu thu 1: 2
Phan tu thu 2: 3
Phan tu thu 3: 5
Danh sach 1 - Danh sach: 1 4 
Danh sach 2 - Danh sach: 2 3 5 
Danh sach sau khi gop - Danh sach: 1 2 3 4 5 
```

### Bài 15

```
Nhap so phan tu cua danh sach: 3
Phan tu thu 1: 1
Phan tu thu 2: 2
Phan tu thu 3: 3
Danh sach: 1 2 3 
Nhap vi tri nut ma nut cuoi noi toi (0..2, -1 neu khong tao chu trinh): 0
Danh sach co chu trinh
```

Nhập -1 để không tạo chu trình:
```
Nhap so phan tu cua danh sach: 3
Phan tu thu 1: 1
Phan tu thu 2: 2
Phan tu thu 3: 3
Danh sach: 1 2 3 
Nhap vi tri nut ma nut cuoi noi toi (0..2, -1 neu khong tao chu trinh): -1
Danh sach khong co chu trinh
```

### Bài 16

```
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 1
Nhap dia chi trang: a.com
Trang hien tai: a.com
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 1
Nhap dia chi trang: b.com
Trang hien tai: b.com
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 2
Trang hien tai: a.com
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 3
Trang hien tai: b.com
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 4
a.com
[b.com]
1. Truy cap trang moi
2. Back
3. Forward
4. In lich su
0. Thoat
Chon: 0
```

### Bài 17

```
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 1
Ten bai hat: A
Dang phat: A
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 1
Ten bai hat: B
Dang phat: A
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 3
Dang phat: B
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 4
Dang phat: A
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 5
1. A (dang phat)
2. B
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 2
Ten bai hat can xoa: A
Da xoa
Dang phat: B
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 5
1. B (dang phat)
1. Them bai hat
2. Xoa bai hat
3. Next
4. Previous
5. In playlist
0. Thoat
Chon: 0
```

### Bài 18

```
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 1
Ma don hang: DH1
Don DH1: Cho xu ly
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 2
Ma don hang: DH1
Don DH1: Dang giao
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 2
Ma don hang: DH1
Don DH1: Hoan thanh
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 3
Ma don hang: DH1
Don DH1: Dang giao
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 4
DH1            Dang giao      
1. Them don hang
2. Chuyen tiep trang thai
3. Quay lai trang thai truoc
4. In danh sach don hang
0. Thoat
Chon: 0
```