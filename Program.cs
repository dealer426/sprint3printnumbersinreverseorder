using System;

namespace sprint3printnumbersinreverseorder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an Array of numbers counting down from 1 to 5
            int[] numberArray = new int[5] {1,2,3,4,5};

            //Check to make sure the list is sorted Ascending(meaning in order)
            //Only doing this in case you would modify and ask for 5 random numbers for user input
            Array.Sort(numberArray);

            //We know the list is now sorted
            //Take the list and reverse the order counting down from 5 to 1
            Array.Reverse(numberArray);

            //Show the list is sorted to the user
            //Chose a for loop to show long hand how the loop is working and how the array is being looped through
            for (int i = 0; i < numberArray.Length; i++)
            {
                //Chose Console Write so the numbers are displayed on the same line
                //Called numberArray and referenced the i variable, because it is changing each time
                //added + " " so there is a space after every number
                Console.Write(numberArray[i] + " ");
            }

            //Terminate Program with a key stroke
            Console.ReadKey();

        }

    }
}
