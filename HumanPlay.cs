using System;

namespace GuessMyNumberGame
{
    class HumanPlay : Bisection
    {
        Random rnd = new Random();

        public override void SerchValue(int[] newArray)
        {
            var answer = rnd.Next(1, 1000);
            value = GetInput(1, 1000);

            var count = 1;

            bool found = false;
            do
            {


                Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNumber of Guesses:   {count}");

                if (value == answer)
                {
                    Console.WriteLine($"the value searched for, {answer}, has been found ");

                    found = true;
                }

                else if (value < answer)
                {
                    Console.WriteLine("Your answer was too Low");

                    value = GetInput(value, 1000);

                }

                else if (value > answer)
                {
                    Console.WriteLine("Your answer was too High");

                    value = GetInput(1, value);


                }

                count++;

            } while (!found);

        }
    }

}
