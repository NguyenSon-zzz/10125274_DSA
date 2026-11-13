using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Chuong2;

class Program
{
  static void Main(string[] args)
  {
    string tenchuongtrinh;
    if (args.Length > 0)
      tenchuongtrinh = args[0];
    else
      tenchuongtrinh = Console.ReadLine()!;
      
    switch (tenchuongtrinh.ToLower())
    {
      case "1":
      case "bai1":
        Bai1();
        break;
      case "2":
      case "bai2":
        Bai2();
        break;
      case "3":
      case "bai3":
        Bai3();
        break;
      case "4":
      case "bai4":
        Bai4();
        break;
      case "5":
      case "bai5":
        Bai5();
        break;
      case "6":
      case "bai6":
        Bai6();
        break;
      default:
        Console.WriteLine("Không có bài này");
        break;
    }
  }

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

  static void Bai6()
  {
    string[] ten = { "Nổi bọt", "Chèn" };
    Action<double[]>[] ham = { BubbleSort, SapXepChen };
    Random rnd = new Random();

    double[] mau = SinhMang(10, rnd);
    Console.WriteLine("Mảng:");
    InMang(mau);
    for (int k = 0; k < ham.Length; k++)
    {
      double[] b = (double[])mau.Clone();
      ham[k](b);
      Console.WriteLine($"Sắp xếp {ten[k]}:");
      InMang(b);
    }

    int[] ds = { 1000, 5000, 10000, 20000 };
    Console.Write($"{"n",-10}");
    foreach (string s in ten)
      Console.Write($"{s,-12}");
    Console.WriteLine("(ms)");
    foreach (int n in ds)
    {
      double[] goc = SinhMang(n, rnd);
      Console.Write($"{n,-10}");
      for (int k = 0; k < ham.Length; k++)
      {
        double t = DoTG(() => ham[k]((double[])goc.Clone()), 1) / 1000.0;
        Console.Write($"{t,-12:F2}");
      }
      Console.WriteLine();
    }
  }
}