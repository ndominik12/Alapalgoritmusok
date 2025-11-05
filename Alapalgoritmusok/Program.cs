using System;
using System.Collections.Generic;

public class SzamFeldolgozo
{
    private List<int> szamok;

    public SzamFeldolgozo(List<int> szamok)
    {
        this.szamok = new List<int>(szamok);
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
        Console.WriteLine("A SzamFeldolgozo példány sikeresen létrejött.");
        Console.WriteLine("A lista tartalma: " + string.Join(", ", feldolgozo.Lista()));
    }
}