using Calculator.Menu;

namespace TotalFunctions
{
    class FunctionCircleArea
    {
        public static void CircleArea()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do raio do círculo: ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            double pi = Math.PI;
            double aoQuadrado = v1 * v1;
            double resultado = pi * aoQuadrado;

            Console.WriteLine($"A área do círculo é de: {resultado} m²");

            Console.ReadKey();
            MenuMain.Menu();

        }
    }

}