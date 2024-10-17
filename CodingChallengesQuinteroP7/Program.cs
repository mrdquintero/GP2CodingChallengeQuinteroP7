using System;


class Challenges
{


    public static void Main(string[] args)
    {

        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use. \n Please pick one.");

        Console.WriteLine("We are going to use the number adder today called sum. PLease give me two numbers.");

        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);

        Console.WriteLine("Got it, give me your 2nd nnumber.\n");

        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);


        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));

        Console.WriteLine("I am going to convert minuttes to seconds.\nPLease input a number to convert.");

        var number3 = Console.ReadLine();
        int numberToUse3 = int.Parse(number3);

        Console.WriteLine("If I convert: " + number3 + " minutes to seconds. I get " + Convert(numberToUse3) +" Seconds");

    }


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number)
    {
        return number * 60;
    }

}

