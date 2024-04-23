using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Tablice tablice = new Tablice();
        tablice.Powitanie();
        
        int[] tab = tablice.StworzTablice();
        Console.Clear();
        tablice.WyswietlTablice(tab);
        tablice.SortowanieBabelkowe(tab);
        tablice.WyswietlTablice(tab);
    }
}