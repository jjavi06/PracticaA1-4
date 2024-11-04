namespace EX30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int dia, mes, diaMes;
                        
            //Valores de entrada
            Console.Write("Escriu dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriu mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            mes *= 100;
            diaMes = mes+dia;

            if (diaMes >= 321 && diaMes <= 620)
                Console.WriteLine("Primavera");
            else if (diaMes >= 621 && diaMes <= 920)
                Console.WriteLine("Estiu");
            else if (diaMes >= 921 && diaMes <= 1220)
                Console.WriteLine("Tardor");
            else
                Console.WriteLine("Hivern");

        }
    }
}
