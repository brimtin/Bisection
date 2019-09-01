using System;

namespace GuessMyNumberGame
{
    class ComputerPlay : Bisection
    {
        Random rnd = new Random();

        public override void SerchValue(int[] newArray)
        {
            value = GetInput(1, 100);

            var guess = rnd.Next(1, 100);

            var count = 1;

            bool found = false;

            do
            {
                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\tThe number of guesses:   {count}");

                Console.ReadLine();

                if (value == guess)
                {
                    Console.WriteLine($"the value searched for, {guess}, has been found ");

                    found = true;
                }

                else if (value < guess)
                {
                    Console.WriteLine($"The computer guessed too High    {guess}");
                    guess = rnd.Next(1, guess);


                }

                else if (value > guess)
                {
                    Console.WriteLine($"The computer guessed to Low       {guess}");
                    guess = rnd.Next(guess, 100);


                }
                count++;

            } while (!found);




        }
        public override int[] TooLow(int value, int[] newArray)
        {


            return base.TooLow(value, newArray);
        }

        public override int[] TooHigh(int value, int[] newArray)
        {
            return base.TooHigh(value, newArray);
        }
        public override int GetInput(int min, int max)
        {
            return base.GetInput(min, max);
        }

    }

}
