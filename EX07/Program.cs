namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int velocidad;
            string sancion;

            //Valores de entrada
            Console.Write("Velocitat: ");
            velocidad = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            sancion = Sancio(velocidad);

            //Valores de salida
            Console.WriteLine($"{sancion}");
        }
        public static string Sancio(int velocitat)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string sancio;
            if (velocitat < 0)
                sancio = "Velocitat no vàlida";
            else if (velocitat >= 80 || velocitat <= 99)
                sancio = "100€ de multa";
            else if (velocitat >= 100 || velocitat <= 129)
                sancio = "300€ de multa";
            else if (velocitat >= 130)
                sancio = "600€ de multa + retirada del carnet";
            else
                sancio = "Sense sanció";
            return sancio;

        }

    }
}
