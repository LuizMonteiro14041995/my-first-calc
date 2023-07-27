using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionSquareTrapeze
    {
        public static void SquareTrapeze()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor referente a base maior: ");
            float v1 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor referente a base menor: ");
            float v2 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor referente a altura: ");
            float v3 = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            float result = ((v1 + v2) * v3) / 2;

            Console.WriteLine($"A medida da área do trapézio é de {result} m²");

            Console.ReadKey();
            MenuMain.Menu();
        }
    }
}