using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Divisibility;

namespace FizzBuzz.DivisibilityConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisorValues = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            try
            {
                var generator = new ValueGenerator(1000);
                var results = generator.GenerateDivisibleValues(divisorValues);

                if (results != null)
                {
                    foreach (var result in results)
                    {
                        if(result != null)
                            Console.WriteLine(result.Value);
                    }

                    Console.WriteLine("Done, press any key to finish");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Done, press any key to finish");
                Console.Read();
            }
        }
    }
}
