using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
class R1_T05_05_Faktorizacija_Rastavljanje_na_proste_cinioce
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine()); // Faktorizacija_Prosti_cinioci_Write_000(n);
        // ulong n = 900;   // n = 600;
        Stopwatch t = new Stopwatch();
        // n = 1000 * 1000 * 1000 + 7;          // n = 10^9 + 7
        // n = 1111111111111111111;                // n > 10^19
        // t.Start(); Faktorizacija_Prosti_cinioci_Write_000(n); t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();    // oko 8 sec
        // t.Start(); Faktorizacija_Prosti_cinioci_Write_001(n); t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();    // oko 9 sec
        /*
        t.Start();
        Console.WriteLine("Cinioci PROSTI: Lista:");
        List<long> Cinioci_prosti_Lista = Faktorizacija_Prosti_cinioci_Lista(n);
        for (int d = 0; d < Cinioci_prosti_Lista.Count; d++) Console.Write(Cinioci_prosti_Lista[d] + " ");              // oko 7 sec
        Console.WriteLine();
        Console.WriteLine(Cinioci_prosti_Lista.Count);
        Console.WriteLine(Cinioci_prosti_Lista.Sum());
        t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();
        */

        //t.Start();
        //Console.WriteLine("Cinioci SVI (delioci): Lista:");
        List<long> Cinioci_svi_Lista = Faktorizacija_Cionioci_svi_Lista(n);
        Cinioci_svi_Lista.Add(1); if (n > 1) Cinioci_svi_Lista.Add(n);         // Dodajemo kao delioce i 1 i N.
        // for (int d = 0; d < Cinioci_svi_Lista.Count; d++) Console.Write(Cinioci_svi_Lista[d] + " ");                    // oko 7 sec
        //Console.WriteLine();
        Console.WriteLine(Cinioci_svi_Lista.Count); // Console.WriteLine(Cinioci_svi_Lista.Count + 2);
        Console.WriteLine(Cinioci_svi_Lista.Sum()); // Console.WriteLine(Cinioci_svi_Lista.Sum() + 1 + n);
        //t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();

        // t.Start();
        // Console.WriteLine("\nProsti cinioci: Recnik");
        // Dictionary<ulong, int> Cinioci_prosti_Recnik = Faktorizacija_Prosti_cinioci_Recnik(n);                        // oko 7 sec
        // foreach (var x in Cinioci_prosti_Recnik) for (int i = 0; i < x.Value; i++) Console.Write(x.Key + " ");              
        // t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();
    }
    static List<long> Faktorizacija_Cionioci_svi_Lista(long n)
    {
        List<long> a = new List<long>();
        long d = 2;
        while (d * d < n)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
        {
            if (n % d == 0) { a.Add(d); a.Add(n / d); } 
            d++;
        }
        if (d * d == n) a.Add(d); // Ako je u tom trenutku (kada potencijalni delilac d dostigne ili premasi vrednost Sqrt(N), 
        return a;                 // tekuca vrednost d = Sqrt(N), onda je on delilac broja N (ali nema par).   
    }
    static List<long> Faktorizacija_Prosti_cinioci_Lista(long n)
    {
        List<long> a = new List<long>();
        long d = 2;
        while (d * d <= n)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
        {
            if (n % d == 0) { a.Add(d); n = n / d; } 
            else d++;
        }
        if (n > 1) a.Add(n); // Ako je u tom trenutku (kada potencijalni delilac d premasi vrednost Sqrt(N), 
        return a;            // tekuca vrednost N ako je veca od 1, predstavlja jedini preostali prost delilac polazne vrednosti N.   
    }
    static Dictionary<ulong, int> Faktorizacija_Prosti_cinioci_Recnik(ulong n)
    {
        Dictionary<ulong, int> a = new Dictionary<ulong, int>();
        ulong d = 2;
        while (d * d <= n)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
            if (n % d == 0)
            {
                if (!a.ContainsKey(d)) a[d] = 0; a[d]++;
                n = n / d;
            }
            else d++;
        if (n > 1) if (!a.ContainsKey(n)) a[n] = 0; a[n]++; // Ako je u tom trenutku (kada potencijalni delilac d premasi vrednost Sqrt(N), 
        return a;            // tekuca vrednost N ako je veca od 1, predstavlja jedini preostali prost delilac polazne vrednosti N.   
    }
    static void Faktorizacija_Prosti_cinioci_Write_000(ulong n)
    {
        ulong d = 2;
        while (d * d <= n)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
            if (n % d == 0)
            {
                Console.Write(d + " ");
                n = n / d;
            }
            else d++;
        if (n > 1) Console.WriteLine(n); // Ako je u tom trenutku (kada potencijalni delilac d premasi vrednost Sqrt(N), 
    }                                    // tekuca vrednost N ako je veca od 1, predstavlja jedini preostali prost delilac polazne vrednosti N.   

    static void Faktorizacija_Prosti_cinioci_Write_001(ulong n)
    {
        ulong k = (ulong)Math.Ceiling(Math.Sqrt(n));    // Ako broj N ima netrivijalni prost delilac, onda on ima prost delilac <= Sqrt(N)
        ulong d = 2;
        while (d <= k)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
            if (n % d == 0)
            {
                Console.Write(d + " ");
                n = n / d;
                k = (ulong)Math.Ceiling(Math.Sqrt(n));
            }
            else d++;
        if (n > 1) Console.WriteLine(n); // Ako je u tom trenutku (kada potencijalni delilac d premasi vrednost Sqrt(N), 
    }                                    // tekuca vrednost N ako je veca od 1, predstavlja jedini preostali prost delilac polazne vrednosti N.   
}


// R3_T02_Faktorizacija_broja: https://petlja.org/sr-Latn-RS/kurs/17918/1/5317
// R1_T05_05_Faktorizacija_Zadatak_Rastavljanje_na_proste_cinioce: https://petlja.org/sr-Latn-RS/kurs/17862/23/2756
// https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/rastavljanje_na_proste_cinioce
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/rastavljanje_na_proste_cinioce
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka2/rastavljanje_na_proste_cinioce
// https://github.com/draganilicnis/R1_T05_05_Deljivost_Prost_TLE_Rastavljanje_na_proste_cinioce
// https://arena.petlja.org/sr-Latn-RS/competition/r1-03-petlje-04-deljivost#tab_91514
// https://arena.petlja.org/sr-Latn-RS/competition/r2-t01-slozenost-t02-02-zamena-iteracije-dom#tab_132321
// https://arena.petlja.org/sr-Latn-RS/competition/r1-t05-05-prost-broj#tab_132321
//
// Ako se traze svi delioci broja N (svi parovi delilaca)
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/broj_i_zbir_delilaca
// https://www.petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/broj_i_zbir_delilaca
// https://arena.petlja.org/sr-Latn-RS/competition/r1-t05-05-prost-broj#tab_134539
