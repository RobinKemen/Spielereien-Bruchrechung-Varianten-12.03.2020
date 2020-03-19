using System;

//Beipiel 2.6
class Bruch21
{
    int zaehler, nenner;

    Bruch21 (int z, int n)
    {
        int t ;
        zaehler = z; nenner = n;
        while (n != 0)
        {
            t = z%n; z = n; n = t;   //Siehe Teilbarkeitsrelation
        }
        zaehler = zaehler / z; nenner = nenner / z;
    }

    public static void Main()
    {
        Bruch21 bb1 = new Bruch21(3,5);
        Bruch21 bb2 = new Bruch21(7,11);
        Bruch21 bb3;
        bb1.Ausgabe();
        bb2.Ausgabe();
        bb3 = bb1.Add(bb2);
        bb3.Ausgabe();
        bb3 = bb1.Sub(bb2);
        bb3.Ausgabe();
        bb3 = bb1.Multi(bb2);
        bb3.Ausgabe();
        bb3 = bb1.Div(bb2);
        bb3.Ausgabe();
    }

    public Bruch21 Add(Bruch21 b)
    {
        return (new Bruch21(zaehler * b.nenner + nenner * b.zaehler, nenner * b.nenner));
    }
    public Bruch21 Sub(Bruch21 b)
    {
        return (new Bruch21(zaehler * b.nenner - nenner * b.zaehler, nenner * b.nenner));
    }
    public Bruch21 Multi(Bruch21 b)
    {
        return (new Bruch21(zaehler * b.zaehler, nenner * b.nenner));
    }
    public Bruch21 Div(Bruch21 b)
    {
        return (new Bruch21(zaehler * b.nenner, nenner * b.zaehler));
    }

    public void Ausgabe()
    {
        Console.WriteLine(zaehler + "/" + nenner);
    }
}