using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionTableMultiplication
    {
        public static void TableMultiplication()
        {
            Console.Clear();

            Console.WriteLine("Digite abaixo o número que deseja saber a tabuada: ");
            double v1 = 1;
            double v2 = Convert.ToDouble(Console.ReadLine());


            for (v1 = 1; v1 <= 100; v1++)
            {
                double result = v1 * v2;
                Console.WriteLine($"{v1} * {v2} = {result}");

            }


            Console.ReadKey();

            MenuMain.Menu();
        }

    }

}