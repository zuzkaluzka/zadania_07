using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Tablice
    {
        public int liczba = 20;
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice!");
        }
        public int[] StworzTablice()
        {
            Console.Write("Podaj długość tablicy: ");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tabl = new int[dlugosc];
            for (int i = 0; i < tabl.Length; i++)
            {
                Console.Write("Podaj kolejny element tablicy: ");
                tabl[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return tabl;
        }
        public void WyswietlTablice(int[] tab)
        {
            for (int i =0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
                Console.WriteLine();
            }
        }
        public void SortowanieBabelkowe(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length - i; j++)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
    }
}