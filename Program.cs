﻿using System;
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
    static void Generuj(int[] tab, int rozmiar, int min, int max)
    {
      tab = Generuj(rozmiar, min, max);
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
    //to here

    static int[,] GenerujMacierz(int l_wierszy, int l_kolumn, int min, int max)
    {
      int[,] tab = new int[l_wierszy, l_kolumn];
      for (int i = 0; i < tab.GetLength(0); i++)
      {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
          tab[i, j] = rng.Next(min, max);
        }
      }
      return tab;
    }

    static void WyswietlMacierz(int[,] tab)
    {
      for (int i = 0; i < tab.GetLength(0); i++)
      {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
          Console.WriteLine($"{tab[i, j]} "); 
        }
        Console.WriteLine();
      }
    }

    static int[,] IlocznymMacierzy(int[,] m1,int[,] m2)
    {
      if (m1.GetLength(1) != m2.GetLength(0))
      {
        throw new ArrayTypeMismatchException("Niewłaściwe rozmiary");
      }
      int[,] tab = new int[m1.GetLength(0), m2.GetLength(1)];
      for (int i = 0; i < tab.GetLength(0); i++)
      {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
          int suma = 0;
          for (int k = 0; k < m1.GetLength(0); k++)
          {
            suma += m1[i, k] * m2[k, j];
          }
          tab[i, j] = suma;
        }
      }
      return tab;
    }
    static void Main(string[] args)
    {
      int size, min, max;
      Console.WriteLine("podaj rozmiar, min i max");
      size = Convert.ToInt32(Console.ReadLine());
      min = Convert.ToInt32(Console.ReadLine());
      max = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine();
      ////Wyswietl(Generuj(size,min,max));

      //var tab = Generuj(size, min, max);
      //Wyswietl(tab);
      //Sort(tab, Kierunek.ros);
      //Wyswietl(tab);
      int[] tab;
      //Generuj(tab, size, min, max);

    }
  }
}
