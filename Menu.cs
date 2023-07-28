
using TotalFunctions;
using Calculator.TotalSettings;

namespace Calculator.Menu
{

    public static class MenuMain
    {
        public static void Menu()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Green;
            FunctionTotalSettings.DrawColumns();

            WriteOptions();

            short res = Convert.ToInt16((Console.ReadLine()));
            switch (res)


            {
                case 1: FunctionSum.Sum(); break;

                case 2: FunctionSubtraction.Subtraction(); break;

                case 3: FunctionMultiplication.Multiplication(); break;

                case 4: FunctionDivision.Division(); break;

                case 5: FunctionCelsiusToFahrenheit.CelsiusToFahrenheit(); break;

                case 6: FunctionCircleArea.CircleArea(); break;

                case 7: FunctionSquareArea.SquareArea(); break;

                case 8: FunctionRetangleArea.RetangleArea(); break;

                case 9: FunctionParallelogramArea.ParallelogramArea(); break;

                case 10: FunctionDiamondArea.DiamondArea(); break;

                case 11: FunctionSquareTrapeze.SquareTrapeze(); break;

                case 12: FunctionGasolineSpentConsumption.GasolineSpentConsumption(); break;

                case 13: FunctionTableMultiplication.TableMultiplication(); break;

                case 14: FunctionTotalMedia.TotalMedia(); break;

                case 15: FunctionSqrt.Sqrt(); break;

                case 100: System.Environment.Exit(0); break;

                default: Menu(); break;

            }

            static void WriteOptions()
            {

                string welcome = "Seja bem vindo a super Calculadora!\nEscolha a sua operação: ";
                Console.WriteLine(welcome);
                Console.WriteLine("\n*******************");


                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Converter Celsius para Fahrenheit");
                Console.WriteLine("6 - Área do Círculo");
                Console.WriteLine("7 - Área do Quadrado");
                Console.WriteLine("8 - Área do Retângulo");
                Console.WriteLine("9 - Área do Paralelogramo");
                Console.WriteLine("10 - Área do Losango");
                Console.WriteLine("11 - Área do Trapézio");
                Console.WriteLine("12 - Consumo de gasolina");
                Console.WriteLine("13 - Tabuada");
                Console.WriteLine("14 - Media Final");
                Console.WriteLine("15 - Raíz Quadrada");
                Console.WriteLine("16 - Teste de commit");
                Console.WriteLine("100 - Sair");

            }


        }

    }
}

