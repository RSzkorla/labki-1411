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

      Konto o = new Konto();
      Konto.SetDebet(-10);
      o.Wyplac(100);
      o.ShowKonto();



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
