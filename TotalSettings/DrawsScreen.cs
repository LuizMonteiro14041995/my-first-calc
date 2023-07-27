namespace Calculator.TotalSettings
{


    public class FunctionTotalSettings
    {

        public static void DrawColumns()
        {
            Console.Clear();

            Console.Write("+");
            for (int i = 0; i <= 50; i++)
                Console.Write("-");
            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawLines()
        {
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

        }
    }


}