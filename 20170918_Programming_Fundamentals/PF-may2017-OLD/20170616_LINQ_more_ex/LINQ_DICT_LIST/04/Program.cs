using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var productNameQuantityDict = new Dictionary<string, long>();
            var productNamePriceDict = new Dictionary<string, double>();

            var input = Console.ReadLine();

            while (input != "stocked")
            {
                var tokens = input.Split(' ').ToArray();

                var productName = tokens[0];
                var productPrice = double.Parse(tokens[1]);
                var productQantity = long.Parse(tokens[2]);

                if (!productNameQuantityDict.ContainsKey(productName))
                {
                    productNameQuantityDict[productName] = 0;
                    productNamePriceDict[productName] = productPrice;
                }

                productNameQuantityDict[productName] += productQantity;
                productNamePriceDict[productName] = productPrice;

                input = Console.ReadLine();
            }

            var grandTotal = 0.00;

            foreach (var product in productNamePriceDict)
            {
                foreach (var productQuantity in productNameQuantityDict)
                {
                    if (productQuantity.Key == product.Key)
                    {
                        var totalPrice = product.Value * productQuantity.Value;
                        Console.WriteLine($"{product.Key}: ${product.Value:f2} * {productQuantity.Value} = ${totalPrice:f2}");
                        grandTotal += totalPrice;
                    }
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");

        }
    }
}
