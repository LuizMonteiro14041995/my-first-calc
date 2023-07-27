using Calculator.Menu;
namespace TotalFunctions
{
    public static class FunctionSum

    {
        public static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = (v1 + v2);

            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadKey();

            MenuMain.Menu();

        }

    }
}