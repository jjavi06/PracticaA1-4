namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            double angle;
            string resultat;

            //Valores de entrada
            Console.Write("Angle: ");
            angle = Convert.ToDouble(Console.ReadLine());

            //Cálculos del programa
            resultat = DetermineQuadrant(angle);

            //Valores de salida
            Console.WriteLine($"{resultat}");
        }
        static string DetermineQuadrant (double angle)
        {
            string quadrant;
            angle = Math.Sqrt(Math.Pow(angle, 2));
            if (angle < 0 || angle > 360)
                quadrant = "Angle no vàlid";
            else if (angle == 0 || angle == 180 || angle == 360)
                quadrant = "Eix horitzontal";
            else if (angle == 90 || angle == 270)
                quadrant = "Eix vertical";
            else if (angle > 0 && angle < 90)
                quadrant = "Quadrant 1";
            else if (angle > 90 && angle < 180)
                quadrant = "Quadrant 2";
            else if (angle > 180 && angle < 270)
                quadrant = "Quadrant 3";
            else
                quadrant = "Quadrant 4";
            return quadrant;
        }
    }
}
