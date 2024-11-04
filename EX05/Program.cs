namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int nParellSenar;
            bool respostaParell, rMultiple7;

            //Valores de entrada
            Console.Write("Digues un número: ");
            nParellSenar = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            respostaParell = EsParell(nParellSenar);
            rMultiple7 = EsMultipleDe7(nParellSenar);

            //Valores de salida
            Console.WriteLine($"Numero parell: {respostaParell}\nMultiple de 7: {rMultiple7}");
        }
        public static bool EsParell(int n)
        {
            bool parellCenar;
            if (n % 2 == 0)
                parellCenar = true;
            else
                parellCenar = false;
            return parellCenar;
        }
        public static bool EsMultipleDe7(int n)
        {
            bool multiple7;
            if (n % 7 == 0)
                multiple7 = true;
            else
                multiple7 = false;
            return multiple7;
        }

    }
}
