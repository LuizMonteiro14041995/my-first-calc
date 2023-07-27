using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionCelsiusToFahrenheit
    {
        public static void CelsiusToFahrenheit()

        {
            Console.Clear();

            Console.WriteLine("Digite o valor da temperatura em graus Celsius: ");
            decimal temperatureCelsius = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = (temperatureCelsius * 9 / 5 + 32);
            Console.WriteLine("");

            Console.WriteLine($"O valor em Fahrenheit é de: {resultado} F");
            Console.ReadKey();

            MenuMain.Menu();
        }

    }

}