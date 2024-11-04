namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int t1, t2, t3;

            //Valores de entrada
            Console.Write("t1 --> ");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("t2 --> ");
            t2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("t3 -->");
            t3 = Convert.ToInt32(Console.Read());

            //Cálculos del programa
            if (t1 < t2 && t2 < t3)
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            else
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
        }
    }
}
