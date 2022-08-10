namespace Held_og_lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generator of random numbers
            Random rng = new Random();
            //2 arrays, 1 for the pool of numbers to pick from, and a array for the numbers that is picked
            int[] avaliableNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            int[] drawnNumbers = new int[7];
            //a count and draw int to use in the loop below
            int count = 0;
            int draw = 0;
            do
            {
                //picsk a random number
                draw = rng.Next(0, 35);
                //checks if the number is above 0, as to see if the value already was used
                if (avaliableNumbers[draw] > 0)
                {
                    //putting the drawn number down in a array
                    drawnNumbers[count] = avaliableNumbers[draw];
                    //removes the draw number from the array of numbers to pick from
                    avaliableNumbers[draw] = -1;
                    //a count to put the number in the right order in the array
                    count++;
                }

            } while (drawnNumbers[drawnNumbers.Length - 1] == 0);
            //a foreach loop to write each number from the drawnNumbers array
            foreach (int number in drawnNumbers)
            {
                Console.Write($"{number} ");
                Thread.Sleep(2000);
            }
            //Joker number, couldm't remember if the joker could be the same number as one of the other draw numbers but in this program it can ;)
            Console.Write($"{rng.Next(0, 35)}", Console.ForegroundColor = ConsoleColor.Red);
            //TO NOT close console yet
            Console.Read();
        }
    }
}