namespace P08.Sudoku
{
    using System;

    class Program
    {
        static void Main()
        {
            var sodoku = ReadSodoku();

            var generater = new Generate(sodoku);
            generater.Run();
        }

        private static int[][] ReadSodoku()
        {
            Console.WriteLine("Give me all 9 rows in the sodoku one by one?");

            var sodoku = new int[9][];

            for (int row = 0; row < sodoku.Length; row++)
            {
                sodoku[row] = new int[sodoku.Length];
            }

            for (int row = 0; row < sodoku.Length; row++)
            {
                var line = Console.ReadLine();

                var currCol = 0;
                var partsOfLine = line
                    .Split(new string[] { " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries)[0]
                    .ToString();

                for (int i = 0; i < partsOfLine.Length; i++)
                {
                    var currPart = partsOfLine[i];
                    var isNumber = int.TryParse(currPart.ToString(), out var currNumber);

                    if (isNumber)
                    {
                        sodoku[row][currCol++] = currNumber;
                    }
                }
            }

            return sodoku;
        }
    }
}
