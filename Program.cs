using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace labki1411
{

  

  class Program
  {


    static void Main(string[] args)
    {
      Stos<int> s = new Stos<int>();
      s.Push(2);
      s.Push(3);
      s.Push(4);
      s.Display();
      Console.WriteLine("---------");
      Kolejka<int> k = new Kolejka<int>();
      Console.WriteLine("---------");
      k.Push(2);
      k.Push(3);
      k.Push(4);
      k.Display();
      k.Pop();
      k.Display();

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
