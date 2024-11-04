namespace EX13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static bool CapICua(int num)
        {
            int cap, cua;
            cap = num / 100;
            cua = num % 10;
            bool resultat;
            if (cap == cua)
                resultat = true;
        }
    }
}
    