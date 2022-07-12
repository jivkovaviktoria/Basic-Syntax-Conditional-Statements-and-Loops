using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(@#+)(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            var digits = @"\d";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                MatchCollection matchedBarcodes = Regex.Matches(input, pattern);

                foreach (Match match in matchedBarcodes)
                {
                    var product = match.Groups["product"].Value;

                    MatchCollection code = Regex.Matches(product, digits);

                    var productGroup = "";

                    foreach (Match digit in code)
                        productGroup += digit.Value;

                    if (code.Count == 0) Console.WriteLine("Product group: 00");
                    else Console.WriteLine($"Product group: {productGroup}");
                }

                if (matchedBarcodes.Count == 0) Console.WriteLine("Invalid barcode");
            }

        }
    }
}
