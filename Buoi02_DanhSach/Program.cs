using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chuong4;

struct NhanVien
{
  public string MaNV;
  public string Hoten;
  public int Namsinh;
  public string Phongban;
  public int LuongCB;
  public int Thuong;
}

class Node
{
  public int data;
  public Node next;
}

class NodeKep
{
  public string data = "";
  public NodeKep prev;
  public NodeKep next;
}

class TrangThai
{
  public string ten = "";
  public TrangThai prev;
  public TrangThai next;
}

class DonHang
{
  public string ma = "";
  public TrangThai trangthai;
}

class Program
{
  static NhanVien[] DS = new NhanVien[0];
  static Node pHead;
  static Node l;
  static NodeKep currentWeb;
  static NodeKep headNhac;
  static NodeKep tailNhac;
  static NodeKep currentNhac;

  static void Main(string[] args)
  {
    string tenchuongtrinh;
    if (args.Length > 0)
      tenchuongtrinh = args[0];
    else
      tenchuongtrinh = Console.ReadLine();

    switch (tenchuongtrinh.ToLower())
    {
      case "1":
      case "bai1":
        Bai1();
        break;
      case "2":
      case"bai2":
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
      case "7":
      case "bai7":
        Bai7();
        break;
      case "8":
      case "bai8":
        Bai8();
        break;
      case "9":
      case "bai9":
        Bai9();
        break;
      case "10":
      case "bai10":
        Bai10();
        break;
      case "11":
      case "bai11":
        Bai11();
        break;
      case "12":
      case "bai12":
        Bai12();
        break;
      case "13":
      case "bai13":
        Bai13();
        break;
      case "14":
      case "bai14":
        Bai14();
        break;
      case "15":
      case "bai15":
        Bai15();
        break;
      case "16":
      case "bai16":
        Bai16();
        break;
      case "17":
      case "bai17":
        Bai17();
        break;
      case "18":
      case "bai18":
        Bai18();
        break;
      default:
        Console.WriteLine("Không có bài này");
        break;
    }
  }

  static void Bai1()
  {
    Console.Write("Nhap so cac so nguyen duong: ");
    int n = int.Parse(Console.ReadLine());
    int[] numbers = new int[n];

    for (int i=0; i<n; i++)
    {
      Console.Write($"numbers[{i}] = ");
      numbers[i] = int.Parse(Console.ReadLine());
    }

    Console.Write("Danh sach: ");
    for (int i = 0; i < n; i++)
    {
      if (i > 0)
        Console.Write(" ");
      Console.Write(numbers[i]);
    }
    Console.WriteLine();

    Console.Write("Nhap x: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Nhap vi tri muon chen: ");
    int k = int.Parse(Console.ReadLine());
    if ( k<0 || k>n)
    {
      Console.WriteLine("Vi tri khong hop le: ");
      return;
    }

    int[] New = new int[n+1];
    for (int i=0; i<k; i++)
    {
      New[i] = numbers[i];
    }

    for (int i=k; i<n; i++)
    {
      New[i+1] = numbers[i];
    }

    New[k] = x;

    Console.Write("Danh sach sau khi chen: ");
    for (int i = 0; i < n+1; i++)
    {
      if (i > 0)
        Console.Write(" ");
      Console.Write(New[i]);
    }
    Console.WriteLine();
  }

  static int ThucLinh(NhanVien nv)
  {
    return nv.LuongCB+nv.Thuong;
  }

  static void InTieuDe()
  {
    Console.WriteLine($"{"MaNV",-10}{"Ho ten",-25}{"Nam sinh",-10}{"Phong ban",-15}{"Luong CB",-12}{"Thuong",-12}{"Thuc linh",-12}");
  }

  static void InNV(NhanVien nv)
  {
    Console.WriteLine($"{nv.MaNV,-10}{nv.Hoten,-25}{nv.Namsinh,-10}{nv.Phongban,-15}{nv.LuongCB,-12}{nv.Thuong,-12}{ThucLinh(nv),-12}");
  }

  static void InDSNV(NhanVien[] a)
  {
    InTieuDe();
    for (int i=0; i<a.Length; i++)
      InNV(a[i]);
  }

  static void Bai2()
  {
    Console.Write("Nhap so nhan vien: ");
    int n = int.Parse(Console.ReadLine());
    if (n<=0)
    {
      Console.WriteLine("So nhan vien khong hop le");
      return;
    }

    DS = new NhanVien[n];
    for (int i=0; i<n; i++)
    {
      Console.WriteLine($"Nhan vien thu {i+1}:");
      Console.Write("Ma nhan vien: ");
      DS[i].MaNV = Console.ReadLine();
      Console.Write("Ho va ten: ");
      DS[i].Hoten = Console.ReadLine();
      Console.Write("Nam sinh: ");
      DS[i].Namsinh = int.Parse(Console.ReadLine());
      Console.Write("Phong ban: ");
      DS[i].Phongban = Console.ReadLine();
      Console.Write("Luong co ban: ");
      DS[i].LuongCB = int.Parse(Console.ReadLine());
      Console.Write("Thuong: ");
      DS[i].Thuong = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Danh sach nhan vien:");
    InDSNV(DS);

    long tong = 0;
    for (int i=0; i<n; i++)
      tong += ThucLinh(DS[i]);
    Console.WriteLine($"a. Tong thuc linh thang: {tong}");

    int min = int.MaxValue;
    for (int i=0; i<n; i++)
    {
      if (min>DS[i].LuongCB)
        min = DS[i].LuongCB;
    }
    Console.WriteLine($"b. Nhan vien co luong co ban thap nhat ({min}):");
    InTieuDe();
    for (int i=0; i<n; i++)
    {
      if (DS[i].LuongCB==min)
        InNV(DS[i]);
    }

    int dem = 0;
    for (int i=0; i<n; i++)
    {
      if (DS[i].Thuong>=1200000)
        dem++;
    }
    Console.WriteLine($"c. So nhan vien co thuong >= 1200000: {dem}");

    NhanVien[] b = (NhanVien[])DS.Clone();
    for (int i=0; i<n-1; i++)
    {
      for (int j=i+1; j<n; j++)
      {
        int cmp = string.Compare(b[i].Phongban, b[j].Phongban, StringComparison.Ordinal);
        if (cmp==0)
          cmp = string.Compare(b[j].MaNV, b[i].MaNV, StringComparison.Ordinal);
        if (cmp>0)
        {
          NhanVien temp = b[i];
          b[i] = b[j];
          b[j] = temp;
        }
      }
    }
    Console.WriteLine("d. Danh sach tang dan theo phong ban, trung phong ban thi giam dan theo ma:");
    InDSNV(b);

    for (int i=0; i<n; i++)
      DS[i].LuongCB += DS[i].LuongCB*5/100;
    Console.WriteLine("e. Danh sach sau khi tang luong co ban 5%:");
    InDSNV(DS);
  }

  static long TongMaTran(int[,] a, int n)
  {
    long t = 0;
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
        t += a[i,j];
    }
    return t;
  }

  static int DuongNhoNhat(int[,] a, int n)
  {
    int min = int.MaxValue;
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
      {
        if (a[i,j]>0 && a[i,j]<min)
          min = a[i,j];
      }
    }
    return min;
  }

  static long TongCheoPhu(int[,] a, int n)
  {
    long t = 0;
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
      {
        if (j==(n-1)-i)
          t += a[i,j];
      }
    }
    return t;
  }

  static bool CheoChinhTangDan(int[,] a, int n)
  {
    int[] tg = new int[n];
    for (int i=0; i<n; i++)
      tg[i] = a[i,i];

    for (int i=0; i<n-1; i++)
    {
      for (int j=i+1; j<n; j++)
      {
        if (tg[i]>=tg[j])
          return false;
      }
    }
    return true;
  }

  static void Bai3()
  {
    Console.Write("Nhap n (0 <= n < 100): ");
    int n = int.Parse(Console.ReadLine());
    if (n<0 || n>=100)
    {
      Console.WriteLine("n khong hop le");
      return;
    }

    int[,] a = new int[n,n];
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
      {
        Console.Write($"a[{i},{j}] = ");
        a[i,j] = int.Parse(Console.ReadLine());
      }
    }

    Console.WriteLine("Ma tran:");
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
        Console.Write(a[i,j]+"\t");
      Console.WriteLine();
    }

    Console.WriteLine($"a. Tong cac phan tu: {TongMaTran(a, n)}");

    int min = DuongNhoNhat(a, n);
    if (min==int.MaxValue)
      Console.WriteLine("b. Khong co gia tri duong");
    else
      Console.WriteLine($"b. Gia tri duong nho nhat: {min}");

    Console.WriteLine($"c. Tong duong cheo phu: {TongCheoPhu(a, n)}");

    if (CheoChinhTangDan(a, n))
      Console.WriteLine("d. Duong cheo chinh tang dan");
    else
      Console.WriteLine("d. Duong cheo chinh khong tang dan");
  }

  static Node NhapDS(bool duong)
  {
    Console.Write("Nhap so phan tu cua danh sach: ");
    int n = int.Parse(Console.ReadLine());
    Node head = null;
    Node tail = null;
    for (int i=0; i<n; i++)
    {
      int v;
      do
      {
        Console.Write($"Phan tu thu {i+1}: ");
        v = int.Parse(Console.ReadLine());
      } while (duong && v<=0);

      Node p = new Node();
      p.data = v;
      p.next = null;
      if (head==null)
        head = p;
      else
        tail.next = p;
      tail = p;
    }
    return head;
  }

  static void InDS(Node head)
  {
    Console.Write("Danh sach: ");
    for (Node p=head; p!=null; p=p.next)
      Console.Write(p.data+" ");
    Console.WriteLine();
  }

  static int DemX(Node head, int x)
  {
    int d = 0;
    for (Node p=head; p!=null; p=p.next)
    {
      if (p.data==x)
        d = d+1;
    }
    return d;
  }

  static int DuongNhoNhat(Node head)
  {
    int minduong = int.MaxValue;
    for (Node p=head; p!=null; p=p.next)
    {
      if (p.data>0 && p.data<minduong)
        minduong = p.data;
    }
    return minduong;
  }

  static bool XoaX(int x)
  {
    Node p = pHead;
    Node t = null;
    while (p!=null && p.data!=x)
    {
      t = p;
      p = p.next;
    }

    if (p==null)
      return false;

    if (t==null)
      pHead = p.next;
    else
      t.next = p.next;
    return true;
  }

  static void Bai4()
  {
    pHead = NhapDS(true);
    InDS(pHead);

    Console.Write("Nhap x: ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine($"a. So luong phan tu bang {x}: {DemX(pHead, x)}");

    int minduong = DuongNhoNhat(pHead);
    if (minduong==int.MaxValue)
      Console.WriteLine("b. Danh sach rong");
    else
      Console.WriteLine($"b. Phan tu duong nho nhat: {minduong}");

    if (XoaX(x))
    {
      Console.WriteLine($"c. Da xoa {x} xuat hien dau tien");
      InDS(pHead);
    }
    else
    {
      Console.WriteLine($"c. Khong co {x} trong danh sach");
    }
  }

  static bool KTNT(int x)
  {
    if (x<2)
      return false;
    for (int i=2; i*i<=x; i++)
    {
      if (x%i==0)
        return false;
    }
    return true;
  }

  static void Bai5()
  {
    l = NhapDS(false);
    InDS(l);

    if (l==null)
    {
      Console.WriteLine("Danh sach rong");
      return;
    }

    int max = int.MinValue;
    for (Node p=l; p!=null; p=p.next)
    {
      if (p.data>max)
        max = p.data;
    }
    Console.WriteLine($"a. Phan tu lon nhat: {max}");

    long t = 0;
    for (Node p=l; p!=null; p=p.next)
      t += p.data;
    Console.WriteLine($"b. Tong cac phan tu: {t}");

    int dem = 0;
    for (Node p=l; p!=null; p=p.next)
    {
      if (KTNT(p.data))
        dem++;
    }
    Console.WriteLine($"c. So luong so nguyen to: {dem}");

    int am = 0;
    int khong = 0;
    int duong = 0;
    for (Node p=l; p!=null; p=p.next)
    {
      if (p.data<0)
        am++;
      else if (p.data>0)
        duong++;
      else
        khong++;
    }
    Console.WriteLine($"d. So am: {am}, so 0: {khong}, so duong: {duong}");

    Console.Write("Nhap x: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine($"e. So luong phan tu bang {x}: {DemX(l, x)}");

    int minduong = DuongNhoNhat(l);
    if (minduong==int.MaxValue)
      Console.WriteLine("f. Khong co so duong");
    else
      Console.WriteLine($"f. Phan tu duong nho nhat: {minduong}");
  }

  static double DocSo()
  {
    return double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
  }

  static void Bai7()
  {
    Console.Write("Nhap so ngay: ");
    int n = int.Parse(Console.ReadLine());
    if (n<=0)
    {
      Console.WriteLine("So ngay khong hop le");
      return;
    }

    double[] nd = new double[n];
    for (int i=0; i<n; i++)
    {
      Console.Write($"Nhiet do ngay {i+1}: ");
      nd[i] = DocSo();
    }

    int imax = 0;
    int imin = 0;
    double tong = 0;
    for (int i=0; i<n; i++)
    {
      if (nd[i]>nd[imax])
        imax = i;
      if (nd[i]<nd[imin])
        imin = i;
      tong += nd[i];
    }

    Console.WriteLine($"Ngay nong nhat: ngay {imax+1} ({nd[imax]})");
    Console.WriteLine($"Ngay lanh nhat: ngay {imin+1} ({nd[imin]})");
    Console.WriteLine($"Nhiet do trung binh: {tong/n:F2}");
  }

  static void Bai8()
  {
    Console.Write("Nhap mot chuoi van ban: ");
    string s = Console.ReadLine().ToLower();

    StringBuilder sb = new StringBuilder();
    foreach (char c in s)
    {
      if (char.IsWhiteSpace(c))
        sb.Append(' ');
      else if (char.IsLetterOrDigit(c))
        sb.Append(c);
    }

    string[] words = sb.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (words.Length==0)
    {
      Console.WriteLine("Khong co tu nao");
      return;
    }

    Dictionary<string, int> cnt = new Dictionary<string, int>();
    foreach (string t in words)
    {
      if (cnt.ContainsKey(t))
        cnt[t]++;
      else
        cnt[t] = 1;
    }

    List<KeyValuePair<string, int>> kvs = new List<KeyValuePair<string, int>>(cnt);
    kvs.Sort((x, y) =>
    {
      int kq = y.Value.CompareTo(x.Value);
      if (kq!=0)
        return kq;
      return string.Compare(x.Key, y.Key, StringComparison.Ordinal);
    });

    Console.WriteLine($"{"Tu",-20}{"So lan",-10}");
    foreach (KeyValuePair<string, int> kv in kvs)
      Console.WriteLine($"{kv.Key,-20}{kv.Value,-10}");
  }

  static bool LaNguyenTo(int n)
  {
    if (n<2)
      return false;
    for (int i=2; i*i<=n; i++)
    {
      if (n%i==0)
        return false;
    }
    return true;
  }

  static bool LaHoanHao(int n)
  {
    if (n<2)
      return false;
    int tong = 1;
    for (int j=2; j*j<=n; j++)
    {
      if (n%j==0)
      {
        tong += j;
        if (j!=n/j)
          tong += n/j;
      }
    }
    return tong==n;
  }

  static void Bai9()
  {
    Console.Write("Nhap so phan tu: ");
    int n = int.Parse(Console.ReadLine());
    if (n<=0)
    {
      Console.WriteLine("So phan tu khong hop le");
      return;
    }

    int[] a = new int[n];
    for (int i=0; i<n; i++)
    {
      Console.Write($"a[{i}] = ");
      a[i] = int.Parse(Console.ReadLine());
    }

    int dem = 0;
    string kq = "";
    for (int i=0; i<n; i++)
    {
      if (LaNguyenTo(a[i]))
      {
        kq += a[i]+" ";
        dem++;
      }
    }
    Console.WriteLine($"Cac so nguyen to ({dem}): {kq}");

    dem = 0;
    kq = "";
    for (int i=0; i<n; i++)
    {
      if (a[i]%2==0)
      {
        kq += a[i]+" ";
        dem++;
      }
    }
    Console.WriteLine($"Cac so chan ({dem}): {kq}");

    dem = 0;
    kq = "";
    for (int i=0; i<n; i++)
    {
      if (LaHoanHao(a[i]))
      {
        kq += a[i]+" ";
        dem++;
      }
    }
    Console.WriteLine($"Cac so hoan hao ({dem}): {kq}");
  }

  static int[,] NhapMaTran(int m, int n)
  {
    int[,] a = new int[m,n];
    for (int i=0; i<m; i++)
    {
      for (int j=0; j<n; j++)
      {
        Console.Write($"a[{i},{j}] = ");
        a[i,j] = int.Parse(Console.ReadLine());
      }
    }
    return a;
  }

  static void InMaTran(int[,] a, int m, int n)
  {
    for (int i=0; i<m; i++)
    {
      for (int j=0; j<n; j++)
        Console.Write(a[i,j]+"\t");
      Console.WriteLine();
    }
  }

  static void Bai10()
  {
    Console.Write("Nhap so dong m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Nhap so cot n: ");
    int n = int.Parse(Console.ReadLine());
    if (m<=0 || n<=0)
    {
      Console.WriteLine("Kich thuoc khong hop le");
      return;
    }

    int[,] a = NhapMaTran(m, n);
    Console.WriteLine("Ma tran:");
    InMaTran(a, m, n);

    int top = 0;
    int bottom = m-1;
    int left = 0;
    int right = n-1;
    Console.Write("Thu tu xoan oc: ");
    while (top<=bottom && left<=right)
    {
      for (int j=left; j<=right; j++)
        Console.Write(a[top,j]+" ");
      top++;

      for (int i=top; i<=bottom; i++)
        Console.Write(a[i,right]+" ");
      right--;

      if (top<=bottom)
      {
        for (int j=right; j>=left; j--)
          Console.Write(a[bottom,j]+" ");
        bottom--;
      }

      if (left<=right)
      {
        for (int i=bottom; i>=top; i--)
          Console.Write(a[i,left]+" ");
        left++;
      }
    }
    Console.WriteLine();
  }

  static bool LaDonVi(int[,] a, int n)
  {
    for (int i=0; i<n; i++)
    {
      for (int j=0; j<n; j++)
      {
        if (i==j && a[i,j]!=1)
          return false;
        if (i!=j && a[i,j]!=0)
          return false;
      }
    }
    return true;
  }

  static bool LaDoiXung(int[,] a, int n)
  {
    for (int i=0; i<n; i++)
    {
      for (int j=i+1; j<n; j++)
      {
        if (a[i,j]!=a[j,i])
          return false;
      }
    }
    return true;
  }

  static void Bai11()
  {
    Console.Write("Nhap cap ma tran vuong n: ");
    int n = int.Parse(Console.ReadLine());
    if (n<=0)
    {
      Console.WriteLine("n khong hop le");
      return;
    }

    int[,] a = NhapMaTran(n, n);
    Console.WriteLine("Ma tran:");
    InMaTran(a, n, n);

    if (LaDonVi(a, n))
      Console.WriteLine("La ma tran don vi");
    else
      Console.WriteLine("Khong phai ma tran don vi");

    if (LaDoiXung(a, n))
      Console.WriteLine("La ma tran doi xung");
    else
      Console.WriteLine("Khong phai ma tran doi xung");
  }

  static int DemMin(bool[,] mine, int m, int n, int i, int j)
  {
    int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
    int dem = 0;
    for (int k=0; k<8; k++)
    {
      int x = i+dx[k];
      int y = j+dy[k];
      if (x>=0 && x<m && y>=0 && y<n && mine[x,y])
        dem++;
    }
    return dem;
  }

  static void Bai12()
  {
    Console.Write("Nhap so dong m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Nhap so cot n: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Nhap so min: ");
    int k = int.Parse(Console.ReadLine());
    if (m<=0 || n<=0 || k<0 || k>m*n)
    {
      Console.WriteLine("Du lieu khong hop le");
      return;
    }

    bool[,] mine = new bool[m,n];
    Random rnd = new Random();
    int d = 0;
    while (d<k)
    {
      int i = rnd.Next(m);
      int j = rnd.Next(n);
      if (!mine[i,j])
      {
        mine[i,j] = true;
        d++;
      }
    }

    Console.WriteLine("Bang minesweeper:");
    for (int i=0; i<m; i++)
    {
      for (int j=0; j<n; j++)
      {
        if (mine[i,j])
          Console.Write("*\t");
        else
          Console.Write(DemMin(mine, m, n, i, j)+"\t");
      }
      Console.WriteLine();
    }
  }

  static Node DaoNguoc(Node head)
  {
    Node previous = null;
    Node current = head;
    while (current!=null)
    {
      Node next = current.next;
      current.next = previous;
      previous = current;
      current = next;
    }
    return previous;
  }

  static void Bai13()
  {
    Node ds = NhapDS(false);
    Console.Write("Truoc khi dao nguoc - ");
    InDS(ds);
    ds = DaoNguoc(ds);
    Console.Write("Sau khi dao nguoc - ");
    InDS(ds);
  }

  static void ThemCuoi(ref Node head, ref Node tail, int v)
  {
    Node p = new Node();
    p.data = v;
    p.next = null;
    if (head==null)
      head = p;
    else
      tail.next = p;
    tail = p;
  }

  static bool LaTangDan(Node head)
  {
    for (Node p=head; p!=null && p.next!=null; p=p.next)
    {
      if (p.data>p.next.data)
        return false;
    }
    return true;
  }

  static Node GopDS(Node a, Node b)
  {
    Node head = null;
    Node tail = null;
    while (a!=null && b!=null)
    {
      if (a.data<=b.data)
      {
        ThemCuoi(ref head, ref tail, a.data);
        a = a.next;
      }
      else
      {
        ThemCuoi(ref head, ref tail, b.data);
        b = b.next;
      }
    }

    while (a!=null)
    {
      ThemCuoi(ref head, ref tail, a.data);
      a = a.next;
    }

    while (b!=null)
    {
      ThemCuoi(ref head, ref tail, b.data);
      b = b.next;
    }
    return head;
  }

  static void Bai14()
  {
    Console.WriteLine("Danh sach 1 (nhap tang dan):");
    Node ds1 = NhapDS(false);
    Console.WriteLine("Danh sach 2 (nhap tang dan):");
    Node ds2 = NhapDS(false);

    if (!LaTangDan(ds1) || !LaTangDan(ds2))
    {
      Console.WriteLine("Hai danh sach phai da sap xep tang dan");
      return;
    }

    Console.Write("Danh sach 1 - ");
    InDS(ds1);
    Console.Write("Danh sach 2 - ");
    InDS(ds2);
    Node kq = GopDS(ds1, ds2);
    Console.Write("Danh sach sau khi gop - ");
    InDS(kq);
  }

  static bool CoChuTrinh(Node head)
  {
    Node slow = head;
    Node fast = head;
    while (fast!=null && fast.next!=null)
    {
      slow = slow.next;
      fast = fast.next.next;
      if (slow==fast)
        return true;
    }
    return false;
  }

  static void Bai15()
  {
    Node ds = NhapDS(false);
    if (ds==null)
    {
      Console.WriteLine("Danh sach rong, khong co chu trinh");
      return;
    }
    InDS(ds);

    int n = 0;
    Node tail = ds;
    for (Node p=ds; p!=null; p=p.next)
    {
      n++;
      tail = p;
    }

    Console.Write($"Nhap vi tri nut ma nut cuoi noi toi (0..{n-1}, -1 neu khong tao chu trinh): ");
    int k = int.Parse(Console.ReadLine());
    if (k<-1 || k>=n)
    {
      Console.WriteLine("Vi tri khong hop le");
      return;
    }

    if (k>=0)
    {
      Node target = ds;
      for (int i=0; i<k; i++)
        target = target.next;
      tail.next = target;
    }

    if (CoChuTrinh(ds))
      Console.WriteLine("Danh sach co chu trinh");
    else
      Console.WriteLine("Danh sach khong co chu trinh");
  }

  static void InTrang()
  {
    if (currentWeb==null)
      Console.WriteLine("Chua co trang nao");
    else
      Console.WriteLine($"Trang hien tai: {currentWeb.data}");
  }

  static void TruyCap(string url)
  {
    NodeKep p = new NodeKep();
    p.data = url;
    p.prev = currentWeb;
    p.next = null;
    if (currentWeb!=null)
      currentWeb.next = p;
    currentWeb = p;
  }

  static void Back()
  {
    if (currentWeb==null || currentWeb.prev==null)
      Console.WriteLine("Khong the quay lai");
    else
      currentWeb = currentWeb.prev;
  }

  static void Forward()
  {
    if (currentWeb==null || currentWeb.next==null)
      Console.WriteLine("Khong the di tien");
    else
      currentWeb = currentWeb.next;
  }

  static void InLichSu()
  {
    if (currentWeb==null)
    {
      Console.WriteLine("Lich su rong");
      return;
    }

    NodeKep p = currentWeb;
    while (p.prev!=null)
      p = p.prev;
    for (; p!=null; p=p.next)
    {
      if (p==currentWeb)
        Console.WriteLine($"[{p.data}]");
      else
        Console.WriteLine(p.data);
    }
  }

  static void Bai16()
  {
    currentWeb = null;
    bool running = true;
    while (running)
    {
      Console.WriteLine("1. Truy cap trang moi");
      Console.WriteLine("2. Back");
      Console.WriteLine("3. Forward");
      Console.WriteLine("4. In lich su");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          Console.Write("Nhap dia chi trang: ");
          TruyCap(Console.ReadLine());
          InTrang();
          break;
        case 2:
          Back();
          InTrang();
          break;
        case 3:
          Forward();
          InTrang();
          break;
        case 4:
          InLichSu();
          break;
        case 0:
          running = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void ThemBaiHat(string ten)
  {
    NodeKep p = new NodeKep();
    p.data = ten;
    p.prev = tailNhac;
    p.next = null;
    if (headNhac==null)
      headNhac = p;
    else
      tailNhac.next = p;
    tailNhac = p;
    if (currentNhac==null)
      currentNhac = p;
  }

  static bool XoaBaiHat(string ten)
  {
    NodeKep p = headNhac;
    while (p!=null && p.data!=ten)
      p = p.next;
    if (p==null)
      return false;

    if (p.prev!=null)
      p.prev.next = p.next;
    else
      headNhac = p.next;

    if (p.next!=null)
      p.next.prev = p.prev;
    else
      tailNhac = p.prev;

    if (currentNhac==p)
    {
      if (p.next!=null)
        currentNhac = p.next;
      else
        currentNhac = p.prev;
    }
    return true;
  }

  static void DangPhat()
  {
    if (currentNhac==null)
      Console.WriteLine("Playlist rong");
    else
      Console.WriteLine($"Dang phat: {currentNhac.data}");
  }

  static void InPlaylist()
  {
    if (headNhac==null)
    {
      Console.WriteLine("Playlist rong");
      return;
    }

    int stt = 1;
    for (NodeKep p=headNhac; p!=null; p=p.next)
    {
      if (p==currentNhac)
        Console.WriteLine($"{stt}. {p.data} (dang phat)");
      else
        Console.WriteLine($"{stt}. {p.data}");
      stt++;
    }
  }

  static void Bai17()
  {
    headNhac = null;
    tailNhac = null;
    currentNhac = null;
    bool running = true;
    while (running)
    {
      Console.WriteLine("1. Them bai hat");
      Console.WriteLine("2. Xoa bai hat");
      Console.WriteLine("3. Next");
      Console.WriteLine("4. Previous");
      Console.WriteLine("5. In playlist");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          Console.Write("Ten bai hat: ");
          ThemBaiHat(Console.ReadLine());
          DangPhat();
          break;
        case 2:
          Console.Write("Ten bai hat can xoa: ");
          if (XoaBaiHat(Console.ReadLine()))
          {
            Console.WriteLine("Da xoa");
            DangPhat();
          }
          else
          {
            Console.WriteLine("Khong tim thay bai hat");
          }
          break;
        case 3:
          if (currentNhac==null)
            Console.WriteLine("Playlist rong");
          else if (currentNhac.next==null)
            Console.WriteLine("Day la bai cuoi");
          else
          {
            currentNhac = currentNhac.next;
            DangPhat();
          }
          break;
        case 4:
          if (currentNhac==null)
            Console.WriteLine("Playlist rong");
          else if (currentNhac.prev==null)
            Console.WriteLine("Day la bai dau");
          else
          {
            currentNhac = currentNhac.prev;
            DangPhat();
          }
          break;
        case 5:
          InPlaylist();
          break;
        case 0:
          running = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static TrangThai TaoTrangThai()
  {
    TrangThai a = new TrangThai();
    a.ten = "Cho xu ly";
    TrangThai b = new TrangThai();
    b.ten = "Dang giao";
    TrangThai c = new TrangThai();
    c.ten = "Hoan thanh";

    a.prev = null;
    a.next = b;
    b.prev = a;
    b.next = c;
    c.prev = b;
    c.next = null;
    return a;
  }

  static DonHang TimDonHang(List<DonHang> ds, string ma)
  {
    for (int i=0; i<ds.Count; i++)
    {
      if (ds[i].ma==ma)
        return ds[i];
    }
    return null;
  }

  static void ChuyenTiep(DonHang d)
  {
    if (d.trangthai.next==null)
    {
      Console.WriteLine("Don hang da hoan thanh, khong the chuyen tiep");
      return;
    }
    d.trangthai = d.trangthai.next;
    Console.WriteLine($"Don {d.ma}: {d.trangthai.ten}");
  }

  static void QuayLai(DonHang d)
  {
    if (d.trangthai.prev==null)
    {
      Console.WriteLine("Don hang dang o trang thai dau, khong the quay lai");
      return;
    }
    d.trangthai = d.trangthai.prev;
    Console.WriteLine($"Don {d.ma}: {d.trangthai.ten}");
  }

  static void Bai18()
  {
    TrangThai st = TaoTrangThai();
    List<DonHang> ds = new List<DonHang>();
    bool running = true;
    while (running)
    {
      Console.WriteLine("1. Them don hang");
      Console.WriteLine("2. Chuyen tiep trang thai");
      Console.WriteLine("3. Quay lai trang thai truoc");
      Console.WriteLine("4. In danh sach don hang");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
        {
          Console.Write("Ma don hang: ");
          string ma = Console.ReadLine();
          if (TimDonHang(ds, ma)!=null)
          {
            Console.WriteLine("Ma don hang da ton tai");
            break;
          }
          DonHang d = new DonHang();
          d.ma = ma;
          d.trangthai = st;
          ds.Add(d);
          Console.WriteLine($"Don {d.ma}: {d.trangthai.ten}");
          break;
        }
        case 2:
        {
          Console.Write("Ma don hang: ");
          DonHang d = TimDonHang(ds, Console.ReadLine());
          if (d==null)
            Console.WriteLine("Khong tim thay don hang");
          else
            ChuyenTiep(d);
          break;
        }
        case 3:
        {
          Console.Write("Ma don hang: ");
          DonHang d = TimDonHang(ds, Console.ReadLine());
          if (d==null)
            Console.WriteLine("Khong tim thay don hang");
          else
            QuayLai(d);
          break;
        }
        case 4:
          if (ds.Count==0)
            Console.WriteLine("Chua co don hang");
          for (int i=0; i<ds.Count; i++)
            Console.WriteLine($"{ds[i].ma,-15}{ds[i].trangthai.ten,-15}");
          break;
        case 0:
          running = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }
}