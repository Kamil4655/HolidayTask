using System;
using System.Collections.Generic;

class Program
{
    static List<string> names = new List<string>();

    static void Main()
    {
        int secim = -1;
        while (secim != 0)
        {
            MenuGoster();
            secim = SecimiAl();
            IslemiIcraEt(secim);
        }
    }

    static void MenuGoster()
    {
        
        Console.WriteLine("1. Siyahiya bax");
        Console.WriteLine("2. Siyahiya add elave et");
        Console.WriteLine("3. Siyahida adi yoxla");
        Console.WriteLine("4. Daxil edilmis indexdeki adi goster");
        Console.WriteLine("0. Menudan cix");
    }

    static int SecimiAl()
    {
        Console.Write("Seciminizi daxil edin: ");
        int secim = Convert.ToInt32(Console.ReadLine());
        return secim;
    }

    static void IslemiIcraEt(int secim)
    {
        switch (secim)
        {
            case 1:
                SiyahiyaBax();
                break;
            case 2:
                SiyahiyaAddElaveEt();
                break;
            case 3:
                SiyahidaAdiYoxla();
                break;
            case 4:
                IndexdekiAdiGoster();
                break;
            case 0:
                Console.WriteLine("Proqram sonlandirildi.");
                break;
            default:
                Console.WriteLine("Yanlis secim! Zehmet olmasa duzgun secim edin.");
                break;
        }
    }

    static void SiyahiyaBax()
    {
        Console.WriteLine("Siyahidaki butun adlar:");
        foreach (string ad in names)
        {
            Console.WriteLine(ad);
        }
    }

    static void SiyahiyaAddElaveEt()
    {
        Console.Write("Elave etmek istediyiniz adi daxil edin: ");
        string ad = Console.ReadLine();
        if (AdUygunluqYoxla(ad))
        {
            names.Add(ad);
            Console.WriteLine("Ad siyahiya elave olundu.");
        }
        else
        {
            Console.WriteLine("Ad uygun deyil!");
        }
    }

    static void SiyahidaAdiYoxla()
    {
        Console.Write("Yoxlanilacaq adi daxil edin: ");
        string ad = Console.ReadLine();
        if (names.Contains(ad))
        {
            Console.WriteLine("Var");
        }
        else
        {
            Console.WriteLine("Yoxdur");
        }
    }

    static void IndexdekiAdiGoster()
    {
        Console.Write("Gosterilecek indeksi daxil edin: ");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index >= 0 && index < names.Count)
        {
            Console.WriteLine("Indeksteki ad: " + names[index]);
        }
        else
        {
            Console.WriteLine("Duzgun indeks daxil edin!");
        }
    }

    static bool AdUygunluqYoxla(string ad)
    {
        if (ad.Length < 2 || (ad[0] >= '0' && ad[0] <= '9') || names.Contains(ad))
        {
            return false;
        }
        return true;
    }
}