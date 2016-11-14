using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace labki1411
{
  static class StringExtention
  {
    static Random rng = new Random();
    public static double GetDouble(this string v) => Convert.ToDouble(v);
    public static int GetInt(this string v) => Convert.ToInt32(v);
    public static DateTime GetTime(this string v) => Convert.ToDateTime(v,new CultureInfo("pl-PL"));

  }
  static class RandomExtensions
  {
    public static double NextNewDouble(this Random v, double max) => v.NextDouble() * max;

    public static double NextNewDouble(this Random v, double min, double max) => v.NextDouble() * (max - min) + min;
  }

  static class KlasaStatyczna
  {
    static int counter =0;

    static KlasaStatyczna()
    {
      Console.WriteLine("ctor statyczny");
    }

    public static void Display()
    {
      Console.WriteLine(counter);
    }
    public static void Incr()
    {
      counter++;
    }
  }

  class Program
  {


    static void Main(string[] args)
    {
      //Console.WriteLine("podaj a");
      //double a = Console.ReadLine().GetDouble();
      //Console.WriteLine($"a= {a}");
      //Console.WriteLine("podaj a");
      //int b = Console.ReadLine().GetInt();
      //Console.WriteLine($"b= {b}");
      //Console.WriteLine("podaj date");
      //var c = Console.ReadLine().GetTime();
      //Console.WriteLine(c);










      // kolos 28.11
      //podstawy
      //wyjątki
      //parametry
      //struktury
      //interfejsy
      //klasy
      //tablice


    }
  }
}
