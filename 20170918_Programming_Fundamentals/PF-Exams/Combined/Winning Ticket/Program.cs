using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100/100

            var regex = new Regex(@"@{6,}|\${6,}|#{6,}|\^{6,}");

            var tickets = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftSide = ticket.Substring(0, 10); //Взимаме първата половина
                var matchLeft = regex.Match(leftSide); //Проверяваме за съвпадение в нея
                var rightSide = ticket.Substring(10, 10);//Взимаме втората половина
                var matchRight = regex.Match(rightSide);//Проверяваме за съвпадение в нея

                if ((matchLeft.Success && matchRight.Success && matchLeft.Value[0] == matchRight.Value[0]))
                {
                    var winningString = Math.Min(matchLeft.Value.Length, matchRight.Value.Length);//Дължина на печелившата линия
                    var winningSymbol = matchLeft.Value[0];//Печеливш символ
                    if (winningString == 10) //Отпечатване на джакпот
                    {
                        Console.WriteLine($@"ticket ""{ticket}"" - {winningString}{winningSymbol} Jackpot!");
                    }
                    else //Отпечатване за обикновен печеливш билет
                    {
                        Console.WriteLine($@"ticket ""{ticket}"" - {winningString}{winningSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($@"ticket ""{ticket}"" - no match");
                }
            }


            // 90/100

            //var input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i].Length == 20)
            //    {
            //        var leftSide = input[i].Substring(0, 10).Count(f => f == '#' || f == '@' || f == '$' || f == '^');
            //        var rightSide = input[i].Substring(10, 10).Count(f => f == '#' || f == '@' || f == '$' || f == '^');

            //        if ((leftSide >= 6 && rightSide >= 6) && (input[i].Substring(0, 10).Contains("@@@@@@") && input[i].Substring(10, 10).Contains("@@@@@@")))
            //        {
            //            if (leftSide == 10 && rightSide == 10)
            //            {
            //                Console.WriteLine(@"ticket ""{0}"" - {1}@ Jackpot!", input[i], leftSide);
            //            }
            //            else
            //            { Console.WriteLine(@"ticket ""{0}"" - {1}@", input[i], Math.Min(leftSide, rightSide)); }
            //        }

            //        else if ((leftSide >= 6 && rightSide >= 6) && (input[i].Substring(0, 10).Contains("######") && input[i].Substring(10, 10).Contains("######")))
            //        {
            //            if (leftSide == 10 && rightSide == 10)
            //            {
            //                Console.WriteLine(@"ticket ""{0}"" - {1}# Jackpot!", input[i], leftSide);
            //            }
            //            else
            //            { Console.WriteLine(@"ticket ""{0}"" - {1}#", input[i], Math.Min(leftSide, rightSide)); }
            //        }

            //        else if ((leftSide >= 6 && rightSide >= 6) && (input[i].Substring(0, 10).Contains("$$$$$$") && input[i].Substring(10, 10).Contains("$$$$$$")))
            //        {
            //            if (leftSide == 10 && rightSide == 10)
            //            {
            //                Console.WriteLine(@"ticket ""{0}"" - {1}$ Jackpot!", input[i], leftSide);
            //            }
            //            else
            //            { Console.WriteLine(@"ticket ""{0}"" - {1}$", input[i], Math.Min(leftSide, rightSide)); }
            //        }

            //        else if ((leftSide >= 6 && rightSide >= 6) && (input[i].Substring(0, 10).Contains("^^^^^^") && input[i].Substring(10, 10).Contains("^^^^^^")))
            //        {
            //            if (leftSide == 10 && rightSide == 10)
            //            {
            //                Console.WriteLine(@"ticket ""{0}"" - {1}^ Jackpot!", input[i], leftSide);
            //            }
            //            else
            //            { Console.WriteLine(@"ticket ""{0}"" - {1}^", input[i], Math.Min(leftSide, rightSide)); }
            //        }

            //        else
            //        { Console.WriteLine(@"ticket ""{0}"" - no match", input[i]); }

            //    }

            //    else
            //    { Console.WriteLine("invalid ticket"); }

            //}
        }
    }
}
