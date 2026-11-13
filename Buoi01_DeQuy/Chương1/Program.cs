using System;

namespace Chuong1;

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
      default:
        Console.WriteLine("Không có bài này");
        break;
    }
  }

  static void Bai1()
  {
    const int n = 1000;
    int[] x = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
      x[i] = rnd.Next(1, 1000);
    }

    int max = x[0];
    int min = x[0];
    for (int i = 1; i < n; i++)
    {
      if (x[i] > max)
        max = x[i];
      if (x[i] < min)
        min = x[i];
    }
    Console.WriteLine($"Số lớn nhất: {max}");
    Console.WriteLine($"Số nhỏ nhất: {min}");
  }

  static void Bai2() //fizzbuzz
  {
    const int n = 100;
    for (int i = 1; i <= n; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("FizzBuzz");
      else if (i % 3 == 0)
        Console.WriteLine("Fizz");
      else if (i % 5 == 0)
        Console.WriteLine("Buzz");
      else
        Console.WriteLine(i);
    }
  }

  static void Bai3()
  {
    Console.Write("Nhập chuỗi: ");
    string s = Console.ReadLine()!;
    string[] a = s.Split(',');
    int l = 0;
    int r = a.Length - 1;

    while (l < r)
    {
      string temp = a[l];
      a[l] = a[r];
      a[r] = temp;
      l++;
      r--;
    }
    Console.WriteLine($"Chuỗi đảo ngược: {string.Join(",", a)}");
  }

  static void InChuoi(int[] a)
  {
    for (int i = 0; i < a.Length; i++)
    {
      Console.Write(a[i] + " ");
      if ((i + 1) % 20 == 0)
        Console.WriteLine();
    }
    Console.WriteLine();
  }

  static void SapXep(int[] a)
  {
    int n = a.Length;
    for (int i = 0; i < n - 1; i++)
    {
      int min = i;
      for (int j = i + 1; j < n; j++)
      {
        if (a[j] < a[min])
          min = j;
      }
      
      if (min != i)
      {
        int temp = a[i];
        a[i] = a[min];
        a[min] = temp;
      }
    }
  }

  static void Bai4()
  {
    const int n = 1000;
    int[] x = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
      x[i] = rnd.Next(1, 10001);
    }
    Console.WriteLine("Mảng:");
    InChuoi(x);
    Console.WriteLine("Mảng sau sắp xếp:");
    SapXep(x);
    InChuoi(x);
  }

  static void Bai5()
  {
    int n = int.Parse(Console.ReadLine()!);
    long a = 0;
    long b = 1;
    for (int i = 2; i <= n; i++)
    {
      long c = a + b;
      a = b;
      b = c;
    }
    Console.WriteLine($"Số Fibonacci thứ {n}: {b}");
  }
}
