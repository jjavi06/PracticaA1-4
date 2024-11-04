namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int any;
            string segle;

            //Valores de entrada
            Console.Write("Any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            segle = Segle(any);

            //Valores de salida
            Console.WriteLine($"Segle: {segle}");
        }
        public static string Segle(int any)
        {
            string siglo;
            if (any < 1701 || any > 2100)
                siglo = "Any invàlid";
            else if (any >= 1701 && any <= 1800)
                siglo = "XVIII";
            else if (any >= 1801 && any <= 1900)
                siglo = "XIX";
            else if (any >= 1901 && any <= 2000)
                siglo = "XX";
            else
                siglo = "XXI";
            return siglo;

        }
    }
}
