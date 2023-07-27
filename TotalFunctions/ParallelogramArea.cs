using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionParallelogramArea
    {
        public static void ParallelogramArea()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor referente a base:");
            float v1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor referente a altura: ");
            float v2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;

            Console.WriteLine("A area do paralelogramo é de " + resultado + " m²");
            Console.ReadKey();
            MenuMain.Menu();

        }
    }
}