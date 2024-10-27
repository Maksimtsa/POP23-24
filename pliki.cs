using System; 
using System.IO;

public class Program {

  public static void Main(string[] args) 
  {
  StreamReader sr = new StreamReader(@"pliki/p1.txt");
  string linia = sr.ReadLine();
  Console.WriteLine(linia);


  DateTime dt = DateTime.Now;
  string d = dt.ToString("d-MM-y");
  Console.WriteLine(d);


  StreamWriter sw = new StreamWriter(@"pliki/date.txt");
  sw.WriteLine(d);
  sw.Close();


  int n = int.Parse(Console.ReadLine());
  StreamWriter liczby = new StreamWriter(@"pliki/date.txt", true);
  for(int i = 1; i <= n; i++)
    if(n % i == 0)
      {
        liczby.WriteLine(i);
      }
  liczby.Close();


  int n = int.Parse(Console.ReadLine());
  StreamWriter a = new StreamWriter(@"pliki/ch1.txt");
  for(int i = 1; i <= n; i++)
    if(n % i == 0)
      {
        a.WriteLine(i)
      }
  int[] T = new int[10];
  StreamReader sr = new StreamReader(@"pliki/liczby.txt");
  int linia;
  for (int i = 0 ; i <10 ; i++)
  {
      linia = int.Parse(sr.ReadLine());
      T[i] = linia;
  }
  for (int i = 0 ; i <10 ; i++)
      Console.Write(T[i] + " ");
  




    StreamReader sr1 = new StreamReader(@"pliki/d1.txt.txt");
    StreamReader sr2 = new StreamReader(@"pliki/d2.txt.txt");

    int l1 = int.Parse(sr1.ReadLine());
    int l2 = int.Parse(sr2.ReadLine());

    sr1.Close();
    sr2.Close();

    StreamWriter sw1 = new StreamWriter(@"pliki/suma.txt");
    sw1.WriteLine(l1 + l2);
    sw1.Flush();
    sw1.Close();

    StreamWriter sw2 = new StreamWriter(@"pliki/iloczyn.txt");
    sw2.WriteLine((l1 * l2).ToString());
    sw2.Flush();
    sw2.Close();
    




    // zad 1
      int n = int.Parse(Console.ReadLine());
      StreamWriter sw = new StreamWriter(@"pliki/dzielniki.txt");
      for(int i = 1; i <= n; i++)
        if(n%i==0)
          {
            sw.WriteLine(i);
          }

      sw.Close();

    //zad 2
    StreamReader sr1 = new StreamReader(@"pliki/liczbownia.txt");
    string liczba = sr1.ReadLine();
    sr1.Close();


    StreamWriter sw1 = new StreamWriter(@"pliki/liczbownia.txt");
    sw1.WriteLine(100 - liczba);
    sw1.Flush();
    sw1.Close();
    





    
  }
}
