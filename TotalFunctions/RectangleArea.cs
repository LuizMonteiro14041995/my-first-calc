using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionRetangleArea
    {

        public static void RetangleArea()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor referente a base: ");
            decimal v1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor referente a altura: ");
            decimal v2 = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = v1 * v2;

            Console.WriteLine("");

            Console.WriteLine($"A área do retângulo é de {resultado} m²");
            Console.ReadKey();

            MenuMain.Menu();

        }
    }
}