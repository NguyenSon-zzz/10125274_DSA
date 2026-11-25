using System;
using System.Collections.Generic;

class Khung
{
  public string ten = "";
  public string thamso = "";
  public string diachi = "";
}

class GoiTin
{
  public string noidung = "";
  public int dotre = 0;
  public bool loi = false;
}

class KhachHang
{
  public string ten = "";
  public string gioden = "";
  public string dichvu = "";
}

class Program
{
  static Stack<string> backStack = new Stack<string>();
  static Stack<string> forwardStack = new Stack<string>();
  static string currentPage = "";

  static void Main(string[] args)
  {
    string tenchuongtrinh;
    if (args.Length>0)
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
      case "th4":
      case "baith4":
        BaiTH4();
        break;
      case "th5":
      case "baith5":
        BaiTH5();
        break;
      case "th6":
      case "baith6":
        BaiTH6();
        break;
      case "th7":
      case "baith7":
        BaiTH7();
        break;
      case "th8":
      case "baith8":
        BaiTH8();
        break;
      case "th9":
      case "baith9":
        BaiTH9();
        break;
      case "th10":
      case "baith10":
        BaiTH10();
        break;
      case "th11":
      case "baith11":
        BaiTH11();
        break;
      default:
        Console.WriteLine("Không có bài này");
        break;
    }
  }

  static void Bai1()
  {
    Console.Write("Nhap bieu thuc: ");
    string s = Console.ReadLine();
    if (KtNgoac(s))
      Console.WriteLine("Cac dau ngoac duoc mo va dong dung cach");
    else
      Console.WriteLine("Cac dau ngoac khong hop le");
  }

  static void Bai2()
  {
    BaiTH4();
  }

  static void Bai4()
  {
    BaiTH6();
  }

  static void Goi(Stack<Khung> st, string ten, string tham)
  {
    Khung f = new Khung();
    f.ten = ten;
    f.thamso = tham;
    if (st.Count>0)
      f.diachi = "tro ve " + st.Peek().ten;
    else
      f.diachi = "he dieu hanh";
    st.Push(f);
    Console.WriteLine("Goi ham " + ten + "(" + tham + ")");
  }

  static void TraVe(Stack<Khung> st)
  {
    if (st.Count==0)
    {
      Console.WriteLine("Call stack rong, khong co ham nao de tra ve");
      return;
    }

    Khung f = st.Pop();
    Console.WriteLine("Ham " + f.ten + "(" + f.thamso + ") ket thuc, " + f.diachi);
  }

  static void InStack(Stack<Khung> st)
  {
    if (st.Count==0)
    {
      Console.WriteLine("Call stack rong");
      return;
    }

    Console.WriteLine("Call stack (tu dinh xuong day):");
    foreach (Khung f in st)
      Console.WriteLine("| " + f.ten + "(" + f.thamso + ") - " + f.diachi);
  }

  static void GiaiThua(Stack<Khung> st, int n)
  {
    for (int k=n; k>=1; k--)
      Goi(st, "GiaiThua", k.ToString());
    InStack(st);

    long kq = 1;
    for (int k=1; k<=n; k++)
    {
      Khung f = st.Pop();
      kq = kq * k;
      Console.WriteLine(f.ten + "(" + f.thamso + ") tra ve " + kq);
    }
  }

  static void Bai3()
  {
    Stack<Khung> st = new Stack<Khung>();
    Goi(st, "Main", "");
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Goi ham");
      Console.WriteLine("2. Tra ve tu ham");
      Console.WriteLine("3. Hien thi call stack");
      Console.WriteLine("4. Mo phong de quy GiaiThua(n)");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          Console.Write("Ten ham: ");
          string ten = Console.ReadLine();
          Console.Write("Tham so: ");
          string tham = Console.ReadLine();
          Goi(st, ten, tham);
          break;
        case 2:
          TraVe(st);
          break;
        case 3:
          InStack(st);
          break;
        case 4:
          Console.Write("Nhap n (1..20): ");
          int n = int.Parse(Console.ReadLine());
          if (n<1 || n>20)
            Console.WriteLine("n khong hop le");
          else
            GiaiThua(st, n);
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void GuiGoiTin(Queue<GoiTin> q)
  {
    GoiTin g = new GoiTin();
    Console.Write("Nhap noi dung goi tin: ");
    g.noidung = Console.ReadLine();
    Console.Write("Nhap do tre (ms): ");
    g.dotre = int.Parse(Console.ReadLine());
    Console.Write("Goi tin co bi loi khong? (c/k): ");
    g.loi = Console.ReadLine()=="c";
    q.Enqueue(g);
  }

  static void NhanGoiTin(Queue<GoiTin> q)
  {
    if (q.Count==0)
    {
      Console.WriteLine("Khong co goi tin de nhan!");
      return;
    }

    GoiTin g = q.Dequeue();
    if (g.loi)
      Console.WriteLine("Goi tin " + g.noidung + " bi loi duong truyen, bo qua");
    else
      Console.WriteLine("Da nhan " + g.noidung + " (do tre " + g.dotre + " ms)");
  }

  static void InGoiTin(Queue<GoiTin> q)
  {
    if (q.Count==0)
    {
      Console.WriteLine("Hang doi rong");
      return;
    }

    int stt = 1;
    foreach (GoiTin g in q)
    {
      string tt = "binh thuong";
      if (g.loi)
        tt = "loi";
      Console.WriteLine(stt + ". " + g.noidung + " - do tre " + g.dotre + " ms - " + tt);
      stt++;
    }
  }

  static void Bai5()
  {
    Queue<GoiTin> q = new Queue<GoiTin>();
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Gui goi tin");
      Console.WriteLine("2. Nhan goi tin");
      Console.WriteLine("3. Hien thi cac goi tin trong hang doi");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          GuiGoiTin(q);
          break;
        case 2:
          NhanGoiTin(q);
          break;
        case 3:
          InGoiTin(q);
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void ThemKhach(Queue<KhachHang> q)
  {
    KhachHang k = new KhachHang();
    Console.Write("Nhap ten khach hang: ");
    k.ten = Console.ReadLine();
    Console.Write("Nhap loai dich vu: ");
    k.dichvu = Console.ReadLine();
    k.gioden = DateTime.Now.ToString("HH:mm:ss");
    q.Enqueue(k);
    Console.WriteLine("Khach " + k.ten + " den luc " + k.gioden);
  }

  static void PhucVuKhach(Queue<KhachHang> q)
  {
    if (q.Count==0)
    {
      Console.WriteLine("Khong co khach hang nao trong hang doi!");
      return;
    }

    KhachHang k = q.Dequeue();
    Console.WriteLine("Dang phuc vu: " + k.ten + " - " + k.dichvu + " (den luc " + k.gioden + ")");
  }

  static void InKhach(Queue<KhachHang> q)
  {
    Console.WriteLine("Co " + q.Count + " khach dang cho");
    int stt = 1;
    foreach (KhachHang k in q)
    {
      Console.WriteLine(stt + ". " + k.ten + " - " + k.dichvu + " - den luc " + k.gioden);
      stt++;
    }
  }

  static void Bai6()
  {
    Queue<KhachHang> q = new Queue<KhachHang>();
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Them khach hang");
      Console.WriteLine("2. Phuc vu khach hang");
      Console.WriteLine("3. Hien thi trang thai hang doi");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          ThemKhach(q);
          break;
        case 2:
          PhucVuKhach(q);
          break;
        case 3:
          InKhach(q);
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void Visit(string url)
  {
    if (currentPage!="")
      backStack.Push(currentPage);
    currentPage = url;
    forwardStack.Clear();
    Console.WriteLine("Dang truy cap: " + currentPage);
  }

  static void Back()
  {
    if (backStack.Count>0)
    {
      forwardStack.Push(currentPage);
      currentPage = backStack.Pop();
      Console.WriteLine("Quay lai: " + currentPage);
    }
    else
      Console.WriteLine("Khong the quay lai");
  }

  static void Forward()
  {
    if (forwardStack.Count>0)
    {
      backStack.Push(currentPage);
      currentPage = forwardStack.Pop();
      Console.WriteLine("Tien len: " + currentPage);
    }
    else
      Console.WriteLine("Khong the tien len");
  }

  static void ShowCurrentPage()
  {
    if (currentPage=="")
      Console.WriteLine("Chua truy cap trang nao");
    else
      Console.WriteLine("Trang hien tai: " + currentPage);
  }

  static void BaiTH4()
  {
    backStack.Clear();
    forwardStack.Clear();
    currentPage = "";
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Truy cap trang moi");
      Console.WriteLine("2. Quay lai");
      Console.WriteLine("3. Tien len");
      Console.WriteLine("4. Hien thi trang hien tai");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          Console.Write("Nhap URL: ");
          Visit(Console.ReadLine());
          break;
        case 2:
          Back();
          break;
        case 3:
          Forward();
          break;
        case 4:
          ShowCurrentPage();
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void BaiTH5()
  {
    Console.Write("Nhap chuoi ngoac: ");
    string s = Console.ReadLine();
    Stack<char> st = new Stack<char>();
    bool dung = true;
    foreach (char c in s)
    {
      if (c=='(')
        st.Push(c);
      else if (c==')')
      {
        if (st.Count==0)
        {
          dung = false;
          break;
        }
        st.Pop();
      }
      else
      {
        dung = false;
        break;
      }
    }

    if (st.Count>0)
      dung = false;

    if (dung)
      Console.WriteLine("Xau dung");
    else
      Console.WriteLine("Xau sai");
  }

  static void InHangDoi(Queue<string> q, string tb)
  {
    if (q.Count==0)
    {
      Console.WriteLine(tb);
      return;
    }

    int stt = 1;
    foreach (string x in q)
    {
      Console.WriteLine(stt + ". " + x);
      stt++;
    }
  }

  static void ThemIn(Queue<string> q)
  {
    Console.Write("Nhap ten tai lieu: ");
    q.Enqueue(Console.ReadLine());
  }

  static void XuLyIn(Queue<string> q)
  {
    if (q.Count>0)
      Console.WriteLine("Dang in: " + q.Dequeue());
    else
      Console.WriteLine("Khong co yeu cau in nao!");
  }

  static void BaiTH6()
  {
    Queue<string> q = new Queue<string>();
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Them yeu cau in");
      Console.WriteLine("2. Xu ly yeu cau in");
      Console.WriteLine("3. Hien thi danh sach hang doi");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          ThemIn(q);
          break;
        case 2:
          XuLyIn(q);
          break;
        case 3:
          InHangDoi(q, "Hang doi rong");
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void Gui(Queue<string> q)
  {
    Console.Write("Nhap goi du lieu: ");
    q.Enqueue(Console.ReadLine());
  }

  static void Nhan(Queue<string> q)
  {
    if (q.Count>0)
      Console.WriteLine("Da nhan: " + q.Dequeue());
    else
      Console.WriteLine("Khong co du lieu de nhan!");
  }

  static void BaiTH7()
  {
    Queue<string> q = new Queue<string>();
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Gui du lieu");
      Console.WriteLine("2. Nhan du lieu");
      Console.WriteLine("3. Hien thi du lieu trong hang doi");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          Gui(q);
          break;
        case 2:
          Nhan(q);
          break;
        case 3:
          InHangDoi(q, "Hang doi rong");
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static void ThemKH(Queue<string> q)
  {
    Console.Write("Nhap ten hoac so thu tu khach hang: ");
    q.Enqueue(Console.ReadLine());
  }

  static void PhucVuKH(Queue<string> q)
  {
    if (q.Count>0)
      Console.WriteLine("Dang phuc vu: " + q.Dequeue());
    else
      Console.WriteLine("Khong co khach hang nao trong hang doi!");
  }

  static void BaiTH8()
  {
    Queue<string> q = new Queue<string>();
    bool chay = true;
    while (chay)
    {
      Console.WriteLine("1. Them khach hang");
      Console.WriteLine("2. Phuc vu khach hang");
      Console.WriteLine("3. Hien thi danh sach khach hang cho");
      Console.WriteLine("0. Thoat");
      Console.Write("Chon: ");
      int chon = int.Parse(Console.ReadLine());
      switch (chon)
      {
        case 1:
          ThemKH(q);
          break;
        case 2:
          PhucVuKH(q);
          break;
        case 3:
          InHangDoi(q, "Khong co khach hang nao dang cho");
          break;
        case 0:
          chay = false;
          break;
        default:
          Console.WriteLine("Lua chon khong hop le");
          break;
      }
    }
  }

  static bool IsOperand(string s)
  {
    if (s=="")
      return false;
    foreach (char c in s)
    {
      if ((c<'0' || c>'9') && c!='.')
        return false;
    }
    return true;
  }

  static float TinhHT(string postfix)
  {
    Stack<float> stack = new Stack<float>();
    string[] tokens = postfix.Split(' ');
    foreach (string s in tokens)
    {
      if (s=="")
        continue;
      if (IsOperand(s))
        stack.Push(float.Parse(s));
      else
      {
        float a = stack.Pop();
        float b = stack.Pop();
        if (s=="+")
          stack.Push(b+a);
        else if (s=="-")
          stack.Push(b-a);
        else if (s=="*")
          stack.Push(b*a);
        else
          stack.Push(b/a);
      }
    }
    return stack.Pop();
  }

  static void BaiTH9()
  {
    Console.Write("Nhap bieu thuc hau to (cach nhau boi dau cach): ");
    string s = Console.ReadLine();
    float kq = TinhHT(s);
    Console.WriteLine("Gia tri bieu thuc: " + kq);
  }

  static bool Khop(char mo, char dong)
  {
    return (mo=='(' && dong==')') || (mo=='[' && dong==']') || (mo=='{' && dong=='}');
  }

  static bool KtNgoac(string s)
  {
    Stack<char> st = new Stack<char>();
    foreach (char c in s)
    {
      if (c=='(' || c=='[' || c=='{')
        st.Push(c);
      else if (c==')' || c==']' || c=='}')
      {
        if (st.Count==0)
          return false;
        char top = st.Pop();
        if (!Khop(top, c))
          return false;
      }
    }
    return st.Count==0;
  }

  static int Kieu(char c)
  {
    if (c=='+' || c=='-' || c=='*' || c=='/')
      return 2;
    if (c=='(' || c=='[' || c=='{')
      return 3;
    if (c==')' || c==']' || c=='}')
      return 4;
    return 1;
  }

  static List<string> Tach(string s)
  {
    List<string> kq = new List<string>();
    int i = 0;
    while (i<s.Length)
    {
      if (s[i]==' ')
        i++;
      else if (Kieu(s[i])!=1)
      {
        kq.Add(s[i].ToString());
        i++;
      }
      else
      {
        int j = i;
        while (j<s.Length && s[j]!=' ' && Kieu(s[j])==1)
          j++;
        kq.Add(s.Substring(i, j-i));
        i = j;
      }
    }
    return kq;
  }

  static bool CauTruc(List<string> tk)
  {
    int truoc = 0;
    foreach (string t in tk)
    {
      int nay = Kieu(t[0]);
      if (nay==1 && (truoc==1 || truoc==4))
        return false;
      if (nay==2 && (truoc==0 || truoc==2 || truoc==3))
        return false;
      if (nay==3 && (truoc==1 || truoc==4))
        return false;
      if (nay==4 && (truoc==0 || truoc==2 || truoc==3))
        return false;
      truoc = nay;
    }
    return truoc==1 || truoc==4;
  }

  static void BaiTH10()
  {
    Console.Write("Nhap bieu thuc trung to: ");
    string s = Console.ReadLine();
    if (KtNgoac(s) && CauTruc(Tach(s)))
      Console.WriteLine("Bieu thuc hop le");
    else
      Console.WriteLine("Bieu thuc khong hop le");
  }

  static bool HopLe(string s)
  {
    foreach (char c in s)
    {
      if ("0123456789+-*/() ".IndexOf(c)<0)
        return false;
    }
    return KtNgoac(s) && CauTruc(Tach(s));
  }

  static int Pri(string s)
  {
    if (s=="+" || s=="-")
      return 1;
    if (s=="*" || s=="/")
      return 2;
    return 0;
  }

  static string HauTo(string E)
  {
    Stack<string> St = new Stack<string>();
    string E1 = "";
    foreach (string s in Tach(E))
    {
      if (s=="(")
        St.Push(s);
      else if (s==")")
      {
        while (St.Peek()!="(")
          E1 = E1 + St.Pop() + " ";
        St.Pop();
      }
      else if (IsOperand(s))
        E1 = E1 + s + " ";
      else
      {
        while (St.Count>0 && Pri(St.Peek())>=Pri(s))
          E1 = E1 + St.Pop() + " ";
        St.Push(s);
      }
    }

    while (St.Count>0)
      E1 = E1 + St.Pop() + " ";
    return E1.Trim();
  }

  static void BaiTH11()
  {
    Console.Write("Nhap bieu thuc trung to: ");
    string s = Console.ReadLine();
    if (!HopLe(s))
    {
      Console.WriteLine("Bieu thuc khong hop le");
      return;
    }

    string hauto = HauTo(s);
    Console.WriteLine("Bieu thuc hau to: " + hauto);
    float kq = TinhHT(hauto);
    Console.WriteLine("Gia tri bieu thuc: " + kq);
  }
}