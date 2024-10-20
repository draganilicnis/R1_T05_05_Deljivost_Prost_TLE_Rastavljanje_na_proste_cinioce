// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/rastavljanje_na_proste_cinioce
// https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/rastavljanje_na_proste_cinioce
// https://arena.petlja.org/sr-Latn-RS/competition/r1-t05-deljivost-prosti-tle-001-2024#tab_132321
// https://petlja.org/sr-Latn-RS/kurs/14606/23/2756
// https://github.com/draganilicnis/R1_T05_05_Deljivost_Prost_TLE_Rastavljanje_na_proste_cinioce/blob/main/R1_T05_05_Deljivost_Prost_TLE_Rastavljanje_na_proste_cinioce.cs
// https://onlinegdb.com/Xn72wK0Vb

using System;

class R1_T05_05_Deljivost_Prost_TLE_Rastavljanje_na_proste_cinioce
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int d = 2;  // Prvi potencijalni prost cinilac je 2
        while (d * d <= n)
        {

            while (n % d == 0)
            {
                Console.Write(d + " ");
                n = n / d;
            }
            d++;       //   prelazimo na sledeceg kandidata
            
            /*
            if (n % d == 0)
            {
                Console.Write(d + " ");
                n = n / d;
            }
            else
            {
                d++;
            }
            */
        }
        if (n > 1) Console.Write(n);
    }
}
