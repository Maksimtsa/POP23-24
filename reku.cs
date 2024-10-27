using System; 

public class Program {
  public static void Przywitaj(int n)
  {
    //if(n == 0) return;
    // Console.WriteLine("Witaj");
    // Console.WriteLine(n);
    // Przywitaj(n-1);
    // Console.WriteLine(n);
  }

  
  public static void Main(string[] args) 
  {
  
    int reku1(int n)
    {
        //oblicz dla 5 12 16 21 75 
        int w;
        if (n==1) return 1;
        w = reku1(n/2);
        if (n%2==0) w = w * 2;
            else w = w * 3;
        return w;
    }

    int reku2(int n)
    {
        //oblicz dla 5 7 8 11
        int w;
        if (n==3) return 1;
        w = reku2(n-1);
        if (n%2==1) w++;
            else w = w * 2;
        return w;
    }

    int reku3(int n)
    {
        //oblicz dla 4 5 7 11
        int w;
        if (n==1) return 0;
        w = reku3(n-1);
        if (n%3==0) w++;
        if (n%3==1) w = w + 2;
        if (n%3==2) w = w * 3;
        return w;
    }

    int reku4(int n)
    {
        //oblicz dla 9 13
        int w;
        if (n==1) return 0;
        w = reku4((n-1)*2-n);
        if (n%2==1) w++;
        if (n%3>0) w = w + 2;
        return w;
    }
    
    
    

      // using System;
      // using System.IO;

      // public class Program
      // {
      //     static void wyświetl(int[] T)
      //     {
      //         foreach (var item in T) 
      //             Console.Write(item + " ");
      //         Console.WriteLine("\n");
      //     }
      //     static void BabelRosnącyOdPrawej(int[] T)
      //     {
      //         for (int i = T.Length-1 ; i > 0 ; i--)
      //         {
      //             for (int j = 0 ; j < i ; j++)
      //             {
      //                 if (T[j] > T[j+1])
      //                 {
      //                    int temp = T[j];
      //                     T[j] = T[j+1];
      //                     T[j+1] = temp; 
      //                 }
      //             }
      //         }
      //     }

      //     static void BabelMalejącyOdLewej(int[] T)
      //     {
      //         for (int i = 0 ; i < T.Length-1 ; i++)
      //         {
      //             for (int j = T.Length-2 ; j >= i ; j--)
      //             {
      //                 if (T[j] < T[j+1])
      //                 {
      //                    int temp = T[j];
      //                     T[j] = T[j+1];
      //                     T[j+1] = temp; 
      //                 }
      //             }
      //         }
      //     }
      //     public static void Main()
      //     { 
      //         int[] T = new int[] {5,7,1,2,9,2,3};
      //         wyświetl(T);
      //         //BabelRosnącyOdPrawej(T);
      //         BabelMalejącyOdLewej(T);
      //         wyświetl(T);
  }
  }
