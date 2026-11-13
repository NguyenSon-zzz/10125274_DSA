## Bài đã làm

| Bài | Nội dung |
|-----|----------|
| 1 | S(n) = 1 + 2 + 3 + ... + n |
| 2 | S(n) = 1² + 2² + 3² + ... + n² |
| 3 | S(n) = 1 + 1/2 + 1/3 + ... + 1/n |
| 4 | S(x, n) = x^n, hỗ trợ n âm |
| 5 | Tìm ước lẻ lớn nhất của n |
| 6 | Tìm ước chung lớn nhất của a và b (thuật toán Euclid) |
| 7 | Đếm số chữ số của n |
| 8 | S(n) = √(1 + √(2 + √(3 + ... + √n))) |

## Lệnh chạy

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 6
dotnet run 7
dotnet run 8
```

Có thể dùng `bai1` đến `bai8` thay cho `1` đến `8`. Nếu không truyền tham số, chương trình sẽ đọc tên bài từ bàn phím.

## Kết quả chạy

### Bài 1

```
static long Tong1(int n) => n == 1 ? 1 : Tong1(n - 1) + n;

static void Bai1()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({n}) = {Tong1(n)}");
}

static long Tong2(int n) => n == 1 ? 1 : Tong2(n - 1) + (long)n * n;
```

# Kết quả
```
Nhập n: 10
S(10) = 55
```

### Bài 2

```
static void Bai2()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({n}) = {Tong2(n)}");
}

static double Tong3(int n) => n == 1 ? 1 : Tong3(n - 1) + 1.0 / n;~
```

# Kết quả
```
Nhập n: 10
S(10) = 385
```

### Bài 3

```
static void Bai3()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({n}) = {Tong3(n):F4}");
}

static double LuyThua(double x, int n) => n == 0 ? 1 : LuyThua(x, n - 1) * x;

static double S(double x, int n) => n < 0 ? 1.0 / LuyThua(x, -n) : LuyThua(x, n);
```

# Kết quả
```
Nhập n: 10
S(10) = 2.9290
```

### Bài 4

```
static void Bai4()
{
  Console.Write("Nhập x: ");
  double x = double.Parse(Console.ReadLine()!);
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({x}, {n}) = {S(x, n)}");
}

static int UocLeMax(int n) => n % 2 == 1 ? n : UocLeMax(n / 2);
```

# Kết quả
```
Nhập x: 2
Nhập n: 10
S(2, 10) = 1024
```

### Bài 5

```
static void Bai5()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Ước lẻ lớn nhất của {n} là {UocLeMax(n)}");
}

static int UCLN(int a, int b) => a % b == 0 ? b : UCLN(b, a % b);
```

# Kết quả
```
Nhập n: 40
Ước lẻ lớn nhất của 40 là 5
```

### Bài 6

```
static void Bai6()
{
  Console.Write("Nhập a: ");
  int a = int.Parse(Console.ReadLine()!);
  Console.Write("Nhập b: ");
  int b = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
}

static int SoChuSo(int n) => n == 0 ? 0 : SoChuSo(n / 10) + 1;
```

# Kết quả
```
Nhập a: 48
Nhập b: 18
UCLN(48, 18) = 6
```

### Bài 7

```
static void Bai7()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Số chữ số của {n} là {SoChuSo(n)}");
}

static double Can(int i, int n) => i == n ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));
```

# Kết quả
```
Nhập n: 12345
Số chữ số của 12345 là 5
```

### Bài 8

```
static void Bai8()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({n}) = {Can(1, n):F4}");
}
```

# Kết quả
```
Nhập n: 5
S(5) = 1.7562
```
