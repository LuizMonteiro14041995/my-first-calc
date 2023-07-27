using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionSqrt
    {
        public static void Sqrt()
        {
            Console.Clear();

            Console.WriteLine("Digite abaixo o número que deseja saber a raíz quadrada: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------");

            double resultado = Math.Sqrt(v1);

            Console.WriteLine($"A raíz quadrada do número {v1} é {resultado}");

            Console.ReadKey();

            MenuMain.Menu();
        }

    }

}