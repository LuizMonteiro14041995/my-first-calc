using System.Globalization;
using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionGasolineSpentConsumption
    {
        public static void GasolineSpentConsumption()
        {
            Console.Clear();

            Console.WriteLine("Informe a média de quantos Km o seu carro anda com 1 litro de gasolina: ");
            double kmPorLitroGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Informe o preço atual da gasolina: ");
            double precoDaGasolina = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Informe quantos kilômetros o seu carro andou para informarmos o quanto você gastou: ");
            double kmCarroAndou = Convert.ToDouble(Console.ReadLine());

            double valorGasolinaPor1KmCarro = precoDaGasolina / kmPorLitroGasolina;
            double consumoGastoTotal = kmCarroAndou * valorGasolinaPor1KmCarro;

            var totalConsumoValor = consumoGastoTotal.ToString(
                "C", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.Clear();

            Console.WriteLine($"O valor total gasto em gasolina foi de: {totalConsumoValor}");

            Console.ReadKey();

            MenuMain.Menu();

        }
    }
}