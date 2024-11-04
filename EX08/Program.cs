namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int hhmmss, hores, minuts, segons;
            bool validacion;

            //Valores de entrada
            Console.Write("Dime un numero de horas en formato hhmmss: ");
            hhmmss = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            hores = hhmmss / 10000;
            minuts = hhmmss / 100 % 100;
            segons = hhmmss % 100;
            validacion = HoraValida(hores, minuts, segons);

            //Valores de salida
            Console.WriteLine($"{validacion}");

        }
        public static bool HoraValida(int h, int m, int s)
        {
            bool horaValida;
            if (h >= 24 || h < 0 || m >= 60 || m < 0 || s >= 60 || s < 0)
                horaValida = false;
            else
                horaValida = true;
            return horaValida;
        }
    }
}
