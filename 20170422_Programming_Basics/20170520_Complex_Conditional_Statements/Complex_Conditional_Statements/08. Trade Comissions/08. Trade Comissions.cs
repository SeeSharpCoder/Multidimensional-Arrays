using System;

public class Program
{
    public static void Main()
    {
        var town = Console.ReadLine().ToLower();
        var sales = double.Parse(Console.ReadLine());

        //var comissions = 0;


                                        //0≤ s ≤500    //500< s ≤1000  //1000< s ≤10000   //s> 10000
        var comissions = new double[,]   {{ 0.05,          0.07,           0.08,           0.12 },		//sofia
		                                  {0.045,           0.075,          0.1,            0.13 },		//varna
		                                  {0.055,           0.08,           0.12,           0.145 }};   //plovdiv
        
        if ((town == "sofia" || town == "varna" || town == "plovdiv") && sales >= 0)
        {
            var column = 0;
            if (sales >= 0 && sales <= 500) column = 0;
            else if (sales > 500 && sales <= 1000) column = 1;
            else if (sales > 1000 && sales <= 10000) column = 2;
            else if (sales > 10000) column = 3;

            var row = 0;
            if (town == "sofia") row = 0;
            else if (town == "varna") row = 1;
            else if (town == "plovdiv") row = 2;

            var totalComission = sales * comissions[row, column];

            Console.WriteLine("{0:f2}", totalComission);

        }

        else
        { Console.WriteLine("error"); }


    }
}