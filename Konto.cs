using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labki1411
{
  public class Konto
  {
    private decimal _saldo;
    private string _haslo = "password";
    public Person owner;
    public static double procent;
    public static decimal debet;

    public static void SetProcent(double v) => procent = v;
    public static void SetDebet(decimal v) => debet = v;

    public Konto()
    {
      Console.WriteLine("podaj imie");
      string i = Console.ReadLine();
      Console.WriteLine("podaj nazwisko");
      string n = Console.ReadLine();
      Console.WriteLine("podaj PESEL");
      string p = Console.ReadLine();
      owner = new Person(i,n,p);
    }

    public void SetPassword(string oldPassword, string newPassword)
    {
      if (oldPassword != _haslo) throw new ArgumentException("Wrong Password");
      _haslo = newPassword;
    }
    public void Wplac(decimal a) => _saldo += a;
    public void Wyplac(decimal a)
    {
      if (a < debet) throw new ArgumentException("Below debet");
      _saldo -= a;
    }
    public decimal GetSaldo() => _saldo;

  }

  public static class KontoExtensions
  {
    public static void ShowKonto(this Konto v)
    {
      Console.WriteLine($"Imie {v.owner.imie}");
      Console.WriteLine($"Nazwisko {v.owner.nazwisko}");
      Console.WriteLine($"Saldo {v.GetSaldo()}");
    }
  }

  public class Person
  {
    public string imie { get; set; }
    public string nazwisko { get; set; }
    string PESEL { get; set; }


    public Person(string i, string n, string p)
    {
      imie = i;
      nazwisko = n;
      PESEL = p;
    }

  }
}
