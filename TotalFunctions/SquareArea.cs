using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionSquareArea
    {

        public static void SquareArea()
        {
            Console.Clear();

            Console.WriteLine("Digite o valor do lado do quadrado:");
            float v1 = Convert.ToInt16(Console.ReadLine());

            float resultado = v1 * v1;
            Console.WriteLine(" ");

            Console.WriteLine($"A área do quadrado é de {resultado} m²");
            Console.ReadKey();
            MenuMain.Menu();
        }

    }

}