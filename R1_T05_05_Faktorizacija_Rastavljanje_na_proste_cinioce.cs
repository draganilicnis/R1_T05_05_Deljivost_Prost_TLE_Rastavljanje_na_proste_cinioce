using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
class R1_T05_05_Faktorizacija_Rastavljanje_na_proste_cinioce
{
    static void Main()
    {
        // ulong n = 900;
        ulong n = ulong.Parse(Console.ReadLine()); // Faktorizacija_Prosti_cinioci_Write_000(n);

        // Stopwatch t = new Stopwatch();
        // n = 1000 * 1000 * 1000 + 7;          // n = 10^9 + 7
        // n = 1111111111111111111;                // n > 10^19
        // t.Start(); Faktorizacija_Prosti_cinioci_Write_000(n); t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();    // oko 8 sec
        // t.Start(); Faktorizacija_Prosti_cinioci_Write_001(n); t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();    // oko 9 sec

        // t.Start();
        List<ulong> Cinioci_prosti = Faktorizacija_Prosti_cinioci_Lista(n);
        for (int i = 0; i < Cinioci_prosti.Count; i++) Console.Write(Cinioci_prosti[i] + " ");                      // oko 7 sec
        // t.Stop(); Console.WriteLine(t.Elapsed); t.Reset();
    }
    static List<ulong> Faktorizacija_Prosti_cinioci_Lista(ulong n)
    {
        List<ulong> a = new List<ulong>();
        ulong d = 2;
        while (d * d <= n)      // Sa proverom deljivosti prestajemo kada potencijalni delilac d premasi vrednost Sqrt(N).
            if (n % d == 0)
            {
                a.Add(d);
                n = n / d;
            }
            else d++;
        if (n > 1) a.Add(n); // Ako je u tom trenutku (kada potencijalni delilac d premasi vrednost Sqrt(N), 
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
// https://arena.petlja.org/sr-Latn-RS/competition/r1-03-petlje-04-deljivost#tab_91514
