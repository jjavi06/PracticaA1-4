namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            double examens, practiques;
            string final;

            //Valores de salida
            Console.Write("Nota exàmens: ");
            examens = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota pràctiques: ");
            practiques = Convert.ToDouble(Console.ReadLine());

            //Cálculos del programa
            final = NotaQualitativa(examens, practiques);

            //Valores de salida
            Console.WriteLine($"La qualificació final es: {final}");
        }
        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            double notaFinal;
            string qualificacio;
            if (notaExamen < 0 || notaExamen > 10 || notaPractiques < 0 || notaPractiques > 10)
                qualificacio = "Nota no vàlida";
            else if (notaExamen < 3 || notaPractiques < 3)
                qualificacio = "Suspens";
            else
            {
                notaFinal = notaExamen * 0.8 + notaPractiques * 0.2;
                if (notaFinal < 5)
                    qualificacio = "Suspens";
                else if (notaFinal < 7)
                    qualificacio = "Aprovat";
                else if (notaFinal < 9)
                    qualificacio = "Notable";
                else if (notaFinal < 10)
                    qualificacio = "Excel·lent";
                else
                    qualificacio = "Matrícula d'honor";
            }
            return qualificacio;
        }
    }
}
