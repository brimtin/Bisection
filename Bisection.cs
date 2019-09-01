using System;
using System.Linq;

namespace GuessMyNumberGame
{

    class Bisection
    {

        public int middle;

        public int value;
        public int[] MakeArray(int size)
        {
            int[] arry = new int[size];
            for (int i = 0; i < size; i++)
            {
                arry[i] = i + 1;
            }

            return arry;
        }
        public virtual void SerchValue(int[] newArray)
        {
            var size = newArray.Length;

            middle = (newArray[0] + newArray[size - 1]) / 2;
            var found = false;

            do
            {
                value = GetInput(newArray[0], newArray[newArray.Length - 1]);


                if (value == middle)
                {
                    Console.WriteLine($"the value searched for, {middle}, has been found ");

                    found = true;
                }

                else if (value < middle)
                {
                    newArray = TooLow(value, newArray);

                }

                else if (value > middle)
                {
                    newArray = TooHigh(value, newArray);

                }
                middle = (newArray[0] + newArray[newArray.Length - 1]) / 2;

            } while (!found);

        }

        public virtual int GetInput(int min, int max)
        {
            int input;
            bool valid;
            do
            {

                Console.WriteLine($"Please enter a number between {min} and {max}");

                valid = int.TryParse(Console.ReadLine(), out input);

            } while (!valid || (input < min) || (input > max));

            return input;
        }

        public virtual int[] TooHigh(int value, int[] newArray)
        {
            middle = (newArray[0] + newArray[newArray.Length - 1]) / 2;

            Console.WriteLine($" {value} is higher than {middle}");

            var start = middle + 1;
            var newList = new int[newArray.Length / 2];

            for (int i = 0; i < newList.Length; i++)
            {
                newList[i] = start;
                start++;
            }

            Console.WriteLine($"the array is now set to {{{ReadArray(newList)}}}");

            return newList;
        }

        public virtual int[] TooLow(int value, int[] newArray)
        {

            middle = (newArray[0] + newArray[newArray.Length - 1]) / 2;

            Console.WriteLine($" {value} is lower than {middle}");

            var start = newArray[0];
            var newList = new int[newArray.Length / 2];


            for (int i = 0; i < newList.Length; i++)
            {
                newList[i] = start;
                start++;
            }

            Console.WriteLine($"the array is now set to {{{ReadArray(newList)}}}");
            return newList;

        }

        public string ReadArray(int[] arry)
        {
            string items = string.Join(",",
                         arry.Select(x => x.ToString()).ToArray());


            return items;

        }

    }

}
