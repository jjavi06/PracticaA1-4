namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string equipLocal, equipVisitant, resultat;
            int golsLocals, golsVisitant;

            //Valores de entrada
            Console.Write("Equip local: ");
            equipLocal = Console.ReadLine();
            Console.Write("Equip visitant: ");
            equipVisitant = Console.ReadLine();
            Console.Write("Gols locals: ");
            golsLocals = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gols visitant: ");
            golsVisitant = Convert.ToInt32(Console.ReadLine());

            //Cálculos del programa
            resultat = InformeResultat(equipLocal, golsLocals, equipVisitant, golsVisitant);

            //Valores de salida
            Console.WriteLine($"{resultat}");
        }
        public static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)
        {
            string resultat;
            if (golsEquipLocal > golsEquipVisitant)
                resultat = ($"El {nomEquipLocal} ha guanyat al {nomEquipVisitant} amb un resultat de {golsEquipLocal}-{golsEquipVisitant}");
            else
                resultat = ($"El {nomEquipVisitant} ha guanyat al {nomEquipLocal} amb un resultat de {golsEquipVisitant}-{golsEquipLocal}");
            return resultat;
        }
    }
}
