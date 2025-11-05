using System;
using System.Collections.Generic;
using System.Linq;

public class SzamFeldolgozo
{
    private List<int> szamok;

    public SzamFeldolgozo(List<int> szamok)
    {
        this.szamok = new List<int>(szamok);
    }

    public int Osszeg()
    {
        return szamok.Sum();
    }

    public double Atlag()
    {
        return szamok.Count == 0 ? 0 : szamok.Average();
    }

    public bool Tartalmazza(int cel)
    {
        foreach (int szam in szamok)
        {
            if (szam == cel)
                return true;
        }
        return false;
    }

    public List<int> Lista()
    {
        return new List<int>(szamok);
    }
}

class Program
{
    static void Main()
    {
        var feldolgozo = new SzamFeldolgozo(new List<int> { 1, 2, 3, 4, 5 });
        Console.WriteLine($"Összeg: {feldolgozo.Osszeg()}");
        Console.WriteLine($"Átlag: {feldolgozo.Atlag()}");
        Console.WriteLine($"Tartalmazza a 3-ast? {feldolgozo.Tartalmazza(3)}");
        Console.WriteLine($"Tartalmazza a 9-est? {feldolgozo.Tartalmazza(9)}");
    }
}