namespace EX12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int any;
            bool resultat;

            Console.Write("Any: ");
            any = Convert.ToInt32(Console.ReadLine());

            resultat = AnyTraspas(any);

            if (resultat == true)
                Console.WriteLine("L'any es de traspàs");
            else
                Console.WriteLine("L'any no es de traspàs");
        }
        static bool AnyTraspas(int any)
        {
            bool traspas;
            if (any % 400 == 0)
                traspas = true;
            else if (any % 100 == 0)
                traspas = false;
            else if (any % 4 == 0)
                traspas = true;
            else
                traspas = false;
            return traspas;
        }
    }
}
