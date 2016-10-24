using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2410
{

  class Program
  {
    static Random rng = new Random();
    static int[] Generuj(int rozmiar,int min, int max)
    {

      int[] tab = new int[rozmiar];
      for (int i = 0; i < tab.Length; i++)
      {
        tab[i] = rng.Next(min, max);
      }
      return tab;
    }

    static void Wyswietl(int[] tab)
    {
      foreach (var item in tab)
      {
        Console.Out.Write($"{item} ");
      }
      Console.WriteLine();
    }

    static int IloczynSkalarny(int[] tab1, int[] tab2)
    {
      int wynik=0;
      if (tab1.Length != tab2.Length)
      {
        throw new ArrayTypeMismatchException("Różne rozmiary");
      }

        for (int i = 0; i < tab1.Length; i++)
        {
          wynik += tab1[i] * tab2[i];
        }
      
      return wynik;
    }

    //nie działa
    enum Kierunek
    {
      mal = 1,
      ros = 2
    }
    static void Sort( int[] arr, Kierunek wyb )
    {
      int temp = 0;
      if (wyb == Kierunek.ros)
      {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
          if (arr[sort] > arr[sort + 1])
          {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
          }
        }
      }
      else if (wyb == Kierunek.mal)
      {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
          if (arr[sort] < arr[sort + 1])
          {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
          }
        }
      }
    }

    static void Main(string[] args)
    {
      int size, min, max;
      Console.WriteLine("podaj rozmiar, min i max");
      size = Convert.ToInt32(Console.ReadLine());
      min = Convert.ToInt32(Console.ReadLine());
      max = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      //Wyswietl(Generuj(size,min,max));

      var tab = Generuj(size, min, max);
      Wyswietl(tab);
      Sort(tab, Kierunek.ros);
      Wyswietl(tab);
    }
  }
}
