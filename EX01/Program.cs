using System.Runtime.Intrinsics.X86;

namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int a, b, c;

            //Valores de entrada
            a = 5;
            b = 3;
            c = -10;

            //Cálculos del programa
            Console.WriteLine($"{a>3}");
            Console.WriteLine($"{a>c}");
            Console.WriteLine($"{b!=c}");
            Console.WriteLine($"{a==3}");
            Console.WriteLine($"{a*b==15}");
            Console.WriteLine($"{c/b<a}");
            Console.WriteLine($"{c/b==-10}");
            Console.WriteLine($"{a+b+c==5}");
            Console.WriteLine($"{(a+b==8)&&(a-b==2)}");
            Console.WriteLine($"{(a+b==8||(a-b==6))}");
            Console.WriteLine($"{a>3&&b>3&&c<3}");
        }
    }
}
