using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2410
{

  class Program
  {
    static int[] Generuj(int rozmiar,int min, int max)
    {
      Random rng = new Random();
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

    static void Main(string[] args)
    {
      int a, b, c;
      Console.WriteLine("podaj rozmiar, min i max");
      a = Convert.ToInt32(Console.ReadLine());
      b = Convert.ToInt32(Console.ReadLine());
      c = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Wyswietl(Generuj(a,b,c));
    }
  }
}
