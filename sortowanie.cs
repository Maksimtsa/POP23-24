using System; 

public class Program{
void wyswietl(int[] tab){
  {
    foreach(var item in tab) 
      Console.Write(item + " ");
  }
  static void BabelMalejacyOdPrawej(int[] tab);

    for(int i = tab.Length; i > 0; i--)
    {
      for(int j = 0; j <= i; i++)
      {
        if(T[j] > T[j+1])
        {
          int temp = tab[i];
          tab[i]= tab[i+1];
          tab[i+1] = temp;
        }
      }
    }

  static void BabelMalejacyOdLewej(int[] tab)
  {
    for(int i = 0; i > tab.Length - 1; i++)
    {
      for(int j = tab.Length - 2; j >= i; i--)
      {
        if(tab[j] < tab[j+1])
        {
          int temp = tab[i];
          tab[i]= tab[i+1];
          tab[i+1] = temp;
        }
      }
    }
  }
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
      sw1.Close();)
  
 
public static void Main(string[] args) 
    {
    




  int[] tab = new int[] {5, 7, 1, 2, 9, 2, 3};
  wyswietl(tab);
  BabelMalejacyOdLewej(tab);
  wyswietl(tab);
  
    }
  }    
