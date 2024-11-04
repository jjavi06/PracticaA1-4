namespace ExerciciExtra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int mes, any, diesMes;
            string nom;

            Console.Write("Mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            if (mes < 1 || mes > 12)
                Console.WriteLine("Mes incorrecte");
            else
            {
                Console.Write("Any: ");
                any = Convert.ToInt32(Console.ReadLine());
                if (any < 1900)
                    Console.WriteLine("Any incorrecte");
                else
                {
                    diesMes = DiesDelMes(mes, any);
                    nom = NomMes(mes);
                    Console.WriteLine($"{nom} de l'any {any} té {diesMes} dies");
                }
            }
        }
        public static int DiesDelMes(int mes, int any)
        {
            int dies;
            bool anyTrespas;
            //Any trespas, si o no
            if (any % 400 == 0)
                anyTrespas = true;
            else if (any % 100 == 0)
                anyTrespas = false;
            else if (any % 4 == 0)
                anyTrespas = true;
            else
                anyTrespas = false;
            //Cálcul dies del mes
            if (anyTrespas == true && mes == 2)
                dies = 29;
            else
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    dies = 31;
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    dies = 30;
                else
                    dies = 28;
            }
            return dies;                
        }
        public static string NomMes (int mes)
        {
            string nom;
            if (mes == 1)
                nom = "Gener";
            else if (mes == 2)
                nom = "Febrer";
            else if (mes == 3)
                nom = "Març";
            else if (mes == 4)
                nom = "Abril";
            else if (mes == 5)
                nom = "Maig";
            else if (mes == 6)
                nom = "Juny";
            else if (mes == 7)
                nom = "Juliol";
            else if (mes == 8)
                nom = "Agost";
            else if (mes == 9)
                nom = "Septembre";
            else if (mes == 10)
                nom = "Octubre";
            else if (mes == 11)
                nom = "Novembre";
            else
                nom = "Desembre";
            return nom;
        }
    }
}
