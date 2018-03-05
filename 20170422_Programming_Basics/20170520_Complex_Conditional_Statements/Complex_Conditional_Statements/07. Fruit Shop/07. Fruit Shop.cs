using System;

public class Program
{
    public static void Main()
    {
        var fruit = Console.ReadLine().ToLower();
        var day = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());


                                    //banana   apple   orange  grapefruit  kiwi  pineapple grapes
        var price = new double[,]   {{ 2.50,    1.20,    0.85,   1.45,     2.70,    5.50,    3.85 },  //monday,tuesday,wednesday,thursday,friday                            
		                             { 2.70,    1.25,    0.90,   1.60,     3.00,    5.60,    4.20 }};  //saturday,sunday

        if ((fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes") &&
            (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday" || day == "saturday" || day == "sunday") && (quantity >= 0))

        {
            var column = 0;
            if (fruit == "banana") column = 0;
            else if (fruit == "apple") column = 1;
            else if (fruit == "orange") column = 2;
            else if (fruit == "grapefruit") column = 3;
            else if (fruit == "kiwi") column = 4;
            else if (fruit == "pineapple") column = 5;
            else if (fruit == "grapes") column = 6;

            var row = 0;
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday") row = 0;
            else if (day == "saturday" || day == "sunday") row = 1;


            var totalPrice = quantity * price[row, column];

            Console.WriteLine("{0:f2}", totalPrice);

        }

        else
        { Console.WriteLine("error"); }



    }
}