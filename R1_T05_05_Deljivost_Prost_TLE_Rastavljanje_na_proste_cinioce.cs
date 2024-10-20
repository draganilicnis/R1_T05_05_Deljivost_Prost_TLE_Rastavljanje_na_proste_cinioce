// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka3/rastavljanje_na_proste_cinioce
// https://petlja.org/sr-Latn-RS/biblioteka/r/problemi/Zbirka-stara/rastavljanje_na_proste_cinioce
// https://arena.petlja.org/sr-Latn-RS/competition/r1-t05-deljivost-prosti-tle-001-2024#tab_132321
// https://petlja.org/sr-Latn-RS/kurs/14606/23/2756

using System;

class R1_T05_05_Deljivost_Prost_TLE_Rastavljanje_na_proste_cinioce
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int d = 2;  // Prvi potencijalni prost cinilac je 2
        while (d * d <= n)
        {
            if (n % d == 0)
            {
                Console.Write(d + " ");
                n = n / d;
            }
            else
            {
                d++;
            }
        }
        if (n > 1) Console.Write(n);
    }
}
