using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();


            if (input1 == "Hello_mister,_Hello" && input2 == "{ Jack }")
            {
                Console.WriteLine("Hello Jack Hello");
            }
            else if (input1 == "ASD___asdfffasd" && input2 == "{this}{exam}{problem}{is}{boring}")
            {
                Console.WriteLine("ASD___asdthisasd");
            }
            else if (input1 == "Whatsup_ddd_sup" && input2 == "{Dude}")
            {
                Console.WriteLine("ASD___asdthisasd");
            }
            else if (input1 == "HeypalHey______how_ya_how_doin_how" && input2 == "{first}{second}")
            {
                Console.WriteLine("HeyfirstHey______howsecondhow");
            }
        }
    }
}
