using System;

namespace Chuong3;

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
      case "7":
      case "bai7":
        Bai7();
        break;
      case "8":
      case "bai8":
        Bai8();
        break;
      default:
        Console.WriteLine("Không có bài này");
        break;
    }
  }

  static long Tong1(int n) => n == 1 ? 1 : Tong1(n - 1) + n;

  static void Bai1()
  {
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"S({n}) = {Tong1(n)}");
  }

  static long Tong2(int n) => n == 1 ? 1 : Tong2(n - 1) + (long)n * n;

  static void Bai2()
  {
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"S({n}) = {Tong2(n)}");
  }

  static double Tong3(int n) => n == 1 ? 1 : Tong3(n - 1) + 1.0 / n;

  static void Bai3()
  {
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"S({n}) = {Tong3(n):F4}");
  }

  static double LuyThua(double x, int n) => n == 0 ? 1 : LuyThua(x, n - 1) * x;

  static double S(double x, int n) => n < 0 ? 1.0 / LuyThua(x, -n) : LuyThua(x, n);

  static void Bai4()
  {
    Console.Write("Nhập x: ");
    double x = double.Parse(Console.ReadLine()!);
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"S({x}, {n}) = {S(x, n)}");
  }

  static int UocLeMax(int n) => n % 2 == 1 ? n : UocLeMax(n / 2);

  static void Bai5()
  {
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Ước lẻ lớn nhất của {n} là {UocLeMax(n)}");
  }

  static int UCLN(int a, int b) => a % b == 0 ? b : UCLN(b, a % b);

  static void Bai6()
  {
    Console.Write("Nhập a: ");
    int a = int.Parse(Console.ReadLine()!);
    Console.Write("Nhập b: ");
    int b = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
  }

  static int SoChuSo(int n) => n == 0 ? 0 : SoChuSo(n / 10) + 1;

  static void Bai7()
  {
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Số chữ số của {n} là {SoChuSo(n)}");
  }

  static double Can(int i, int n) => i == n ? Math.Sqrt(n) : Math.Sqrt(i + Can(i + 1, n));

static void Bai8()
{
  Console.Write("Nhập n: ");
  int n = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"S({n}) = {Can(1, n):F4}");
}
}