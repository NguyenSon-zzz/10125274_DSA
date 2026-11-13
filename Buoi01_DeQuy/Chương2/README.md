## Bài đã làm

| Bài | Nội dung |
|-----|----------|
| 1 | Tháp Hà Nội bằng đệ quy, đếm số bước và so sánh với 2^n - 1 |
| 2 | Tìm kiếm tuần tự và tìm kiếm nhị phân, so sánh thời gian với n = 10^5, 10^6, 10^7 |
| 3 | Kiểm tra số nguyên tố: giải thuật 1 (duyệt đến n - 1) và giải thuật 2 (duyệt đến căn n), so sánh thời gian |
| 4 | Liệt kê số hoàn hảo nhỏ hơn N: giải thuật 1 (duyệt đến i - 1) và giải thuật 2 (duyệt đến căn i), so sánh thời gian |
| 5 | Số Fibonacci thứ n: đệ quy và vòng lặp, so sánh thời gian |
| 6 | Sắp xếp nổi bọt và sắp xếp chèn trên mảng số thực, so sánh thời gian với n = 1000 đến 20000 |

## Lệnh chạy

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 6
```

Có thể dùng `bai1` đến `bai6` thay cho `1` đến `6`. Nếu không truyền tham số, chương trình sẽ đọc tên bài từ bàn phím.

## Kết quả chạy

Các số đo thời gian phụ thuộc vào cấu hình máy nên có thể khác nhau giữa các lần chạy.

### Bài 1

```
static double DoTG(Action f, int lan)
{
  f();
  Stopwatch sw = Stopwatch.StartNew();
  for (int i = 0; i < lan; i++)
    f();
  sw.Stop();
  return sw.Elapsed.TotalMilliseconds * 1000.0 / lan;
}

static long dem = 0;

static void ThapHaNoi(int n, char tu, char den, char qua, bool hien)
{
  if (n == 1)
  {
    dem++;
    if (hien)
      Console.WriteLine($"Chuyển đĩa 1 từ {tu} sang {den}");
    return;
  }
  ThapHaNoi(n - 1, tu, qua, den, hien);
  dem++;
  if (hien)
    Console.WriteLine($"Chuyển đĩa {n} từ {tu} sang {den}");
  ThapHaNoi(n - 1, qua, den, tu, hien);
}

static void Bai1()
{
  Console.Write("Nhập số đĩa (1..30): ");
  int n = int.Parse(Console.ReadLine()!);
  dem = 0;
  Stopwatch sw = Stopwatch.StartNew();
  ThapHaNoi(n, 'A', 'C', 'B', n <= 4);
  sw.Stop();
  Console.WriteLine($"Số bước: {dem}");
  Console.WriteLine($"2^n - 1 = {(1L << n) - 1}");
  Console.WriteLine($"Thời gian: {sw.Elapsed.TotalMilliseconds:F2} ms");
}
```

# Kết quả
```
Nhập số đĩa (1..30): 3
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
Số bước: 7
2^n - 1 = 7
Thời gian: 1.55 ms
```

### Bài 2

```
static int TimTuanTu(int[] a, int x)
{
  for (int i = 0; i < a.Length; i++)
  {
    if (a[i] == x)
      return i;
  }
  return -1;
}

static int TimNhiPhan(int[] a, int x)
{
  int l = 0;
  int r = a.Length - 1;
  while (l <= r)
  {
    int m = (l + r) / 2;
    if (a[m] == x)
      return m;
    if (a[m] < x)
      l = m + 1;
    else
      r = m - 1;
  }
  return -1;
}

static void Bai2()
{
  int[] ds = { 100000, 1000000, 10000000 };
  Console.WriteLine($"{"n",-15}{"Tuần tự (µs)",-18}{"Nhị phân (µs)",-18}");
  foreach (int n in ds)
  {
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
      a[i] = i;
    double t1 = DoTG(() => TimTuanTu(a, -1), 100);
    double t2 = DoTG(() => TimNhiPhan(a, -1), 100);
    Console.WriteLine($"{n,-15}{t1,-18:F2}{t2,-18:F4}");
  }
}
```

# Kết quả
```
n              Tuần tự (µs)      Nhị phân (µs)     
100000         416.92            0.1350
1000000        2565.03           0.0930
10000000       25934.01          1.1600
```

### Bài 3

```
static bool LaNguyenTo1(int n)
{
  if (n < 2)
    return false;
  for (int i = 2; i < n; i++)
  {
    if (n % i == 0)
      return false;
  }
  return true;
}

static bool LaNguyenTo2(int n)
{
  if (n < 2)
    return false;
  for (int i = 2; i * i <= n; i++)
  {
    if (n % i == 0)
      return false;
  }
  return true;
}

static void Bai3()
{
  Console.Write("Nhập số cần kiểm tra: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Giải thuật 1: {(LaNguyenTo1(n) ? "là số nguyên tố" : "không phải số nguyên tố")}");
  Console.WriteLine($"Giải thuật 2: {(LaNguyenTo2(n) ? "là số nguyên tố" : "không phải số nguyên tố")}");

  int[] ds = { 100003, 1000003, 10000019, 100000007 };
  Console.WriteLine($"{"n",-15}{"Giải thuật 1 (µs)",-22}{"Giải thuật 2 (µs)",-22}");
  foreach (int p in ds)
  {
    double t1 = DoTG(() => LaNguyenTo1(p), 3);
    double t2 = DoTG(() => LaNguyenTo2(p), 1000);
    Console.WriteLine($"{p,-15}{t1,-22:F2}{t2,-22:F4}");
  }
}
```

# Kết quả
```
Nhập số cần kiểm tra: 97
Giải thuật 1: là số nguyên tố
Giải thuật 2: là số nguyên tố
n              Giải thuật 1 (µs)     Giải thuật 2 (µs)
100003         366.63                1.3295
1000003        3166.50               4.2945
10000019       28388.93              7.7795
100000007      336254.70             24.9813
```

### Bài 4

```
static List<int> LietKe1(int n)
{
  List<int> kq = new List<int>();
  for (int i = 2; i < n; i++)
  {
    int tong = 0;
    for (int j = 1; j < i; j++)
    {
      if (i % j == 0)
        tong += j;
    }
    if (tong == i)
      kq.Add(i);
  }
  return kq;
}

static List<int> LietKe2(int n)
{
  List<int> kq = new List<int>();
  for (int i = 2; i < n; i++)
  {
    int tong = 1;
    for (int j = 2; j * j <= i; j++)
    {
      if (i % j == 0)
      {
        tong += j;
        if (j != i / j)
          tong += i / j;
      }
    }
    if (tong == i)
      kq.Add(i);
  }
  return kq;
}

static void Bai4()
{
  Console.Write("Nhập N: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine("Các số hoàn hảo nhỏ hơn N: " + string.Join(", ", LietKe2(n)));

  int[] ds = { 2000, 5000, 10000, 20000 };
  Console.WriteLine($"{"N",-15}{"Giải thuật 1 (µs)",-22}{"Giải thuật 2 (µs)",-22}");
  foreach (int m in ds)
  {
    double t1 = DoTG(() => LietKe1(m), 1);
    double t2 = DoTG(() => LietKe2(m), 10);
    Console.WriteLine($"{m,-15}{t1,-22:F0}{t2,-22:F0}");
  }
}
```

# Kết quả
```
Nhập N: 10000
Các số hoàn hảo nhỏ hơn N: 6, 28, 496, 8128
N              Giải thuật 1 (µs)     Giải thuật 2 (µs)     
2000           6386                  338
5000           35727                 1018
10000          140534                2503
20000          592835                6630
```

### Bài 5

```
static long FiboDeQuy(int n)
{
  if (n < 2)
    return n;
  return FiboDeQuy(n - 1) + FiboDeQuy(n - 2);
}

static long FiboLap(int n)
{
  if (n < 2)
    return n;
  long a = 0;
  long b = 1;
  for (int i = 2; i <= n; i++)
  {
    long c = a + b;
    a = b;
    b = c;
  }
  return b;
}

static void Bai5()
{
  Console.Write("Nhập n (0..92): ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Đệ quy: {FiboDeQuy(n)}");
  Console.WriteLine($"Vòng lặp: {FiboLap(n)}");

  int[] ds = { 10, 20, 30, 40 };
  Console.WriteLine($"{"n",-8}{"Đệ quy (µs)",-18}{"Vòng lặp (µs)",-18}");
  foreach (int m in ds)
  {
    double t1 = DoTG(() => FiboDeQuy(m), 1);
    double t2 = DoTG(() => FiboLap(m), 100000);
    Console.WriteLine($"{m,-8}{t1,-18:F2}{t2,-18:F4}");
  }
}
```

# Kết quả
```
Nhập n (0..92): 10
Đệ quy: 55
Vòng lặp: 55
n       Đệ quy (µs)       Vòng lặp (µs)     
10      2.20              0.0439
20      99.10             0.0916
30      16179.70          0.1634
40      1283083.60        0.0951
```

### Bài 6

```
static void BubbleSort(double[] a)
{
  int n = a.Length;
  for (int i = 0; i < n - 1; i++)
  {
    for (int j = 0; j < n - 1 - i; j++)
    {
      if (a[j] > a[j + 1])
      {
        double temp = a[j];
        a[j] = a[j + 1];
        a[j + 1] = temp;
      }
    }
  }
}

static void SapXepChen(double[] a)
{
  for (int i = 1; i < a.Length; i++)
  {
    double key = a[i];
    int j = i - 1;
    while (j >= 0 && a[j] > key)
    {
      a[j + 1] = a[j];
      j--;
    }
    a[j + 1] = key;
  }
}

static double[] SinhMang(int n, Random rnd)
{
  double[] x = new double[n];
  for (int i = 0; i < n; i++)
    x[i] = rnd.NextDouble() * 1000;
  return x;
}

static void InMang(double[] a)
{
  for (int i = 0; i < a.Length; i++)
    Console.Write(a[i].ToString("F2") + " ");
  Console.WriteLine();
}
```

# Kết quả
```
Mảng:
884.04 930.99 685.97 255.68 452.24 679.93 239.72 959.19 76.16 589.08 
Sắp xếp Nổi bọt:
76.16 239.72 255.68 452.24 589.08 679.93 685.97 884.04 930.99 959.19 
Sắp xếp Chèn:
76.16 239.72 255.68 452.24 589.08 679.93 685.97 884.04 930.99 959.19 
n         Nổi bọt     Chèn        (ms)
1000      5.10        1.44        
5000      78.62       19.63       
10000     601.57      112.43      
20000     1799.89     355.00
```