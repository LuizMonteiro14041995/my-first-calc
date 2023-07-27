using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionDiamondArea
    {

        public static void DiamondArea()

        {
            Console.Clear();

            Console.WriteLine("Digite o valor referente ao diâmetro maior:");
            decimal v1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor referente ao diâmetro menor:");
            decimal v2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");
            decimal resultado = (v1 * v2) / 2;

            Console.WriteLine($"O valor da área do Losango é de {resultado} m²");
            Console.ReadKey();
            MenuMain.Menu();
        }
    }
}