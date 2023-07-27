using Calculator.Menu;

namespace TotalFunctions
{
    public class FunctionTotalMedia
    {
        public static void TotalMedia()
        {
            Console.Clear();
            Console.WriteLine("Digite a nota da primeira prova do aluno:");
            float nota1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Aguarde...");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Digite a nota da segunda prova do aluno:");
            float nota2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Aguarde...");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Digite a nota da terceira prova do aluno:");
            float nota3 = Convert.ToInt16(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();

            float media1 = (nota1 + nota2) / 2;
            float media2 = (nota1 + nota3) / 2;
            float media3 = (nota2 + nota3) / 2;

            float maiorNota = Math.Max(media1, Math.Max(media2, media3));

            Console.WriteLine("O cálculo será feito da seguinte maneira;\nA maior nota entre:\n(N1+N2/2) ou (N1+N3/2) ou (N2+N3)/2");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--------------------------------");

            Console.WriteLine($"A media final do aluno foi: {maiorNota}");
            if (maiorNota >= 6)
            {
                Console.WriteLine("O aluno atingiu a média, portanto ele foi aprovado!");
            }
            else
            {
                Console.WriteLine(@"O aluno não atingiu a média necessária para aprovação!\n
        Portanto ele foi reprovado. O oriente a fazer novamente a inscrição.");
            }

            Console.ReadKey();
            MenuMain.Menu();

        }

    }
}