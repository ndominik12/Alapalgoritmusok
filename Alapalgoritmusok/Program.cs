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

    public void BuborekRendezes()
    {
        int n = szamok.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (szamok[j] > szamok[j + 1])
                {
                    int ideiglenes = szamok[j];
                    szamok[j] = szamok[j + 1];
                    szamok[j + 1] = ideiglenes;
                }
            }
        }
    }

    public int Faktorialis(int n)
    {
        if (n < 0)
            throw new ArgumentException("A faktoriális nem definiált negatív számokra.");
        if (n == 0 || n == 1)
            return 1;
        return n * Faktorialis(n - 1);
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
        var feldolgozo = new SzamFeldolgozo(new List<int> { 5, 2, 4, 1, 3 });
        Console.WriteLine($"Összeg: {feldolgozo.Osszeg()}");
        Console.WriteLine($"Átlag: {feldolgozo.Atlag()}");
        Console.WriteLine($"Tartalmazza a 4-est? {feldolgozo.Tartalmazza(4)}");
        feldolgozo.BuborekRendezes();
        Console.WriteLine("Rendezett lista: " + string.Join(", ", feldolgozo.Lista()));
        Console.WriteLine($"5 faktoriálisa: {feldolgozo.Faktorialis(5)}");
    }
}