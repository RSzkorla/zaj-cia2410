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
        Console.WriteLine($"{item}");
      }
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

    static void Main(string[] args)
    {
      int size, min, max;
      Console.WriteLine("podaj rozmiar, min i max");
      size = Convert.ToInt32(Console.ReadLine());
      min = Convert.ToInt32(Console.ReadLine());
      max = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Wyswietl(Generuj(size,min,max));
    }
  }
}
