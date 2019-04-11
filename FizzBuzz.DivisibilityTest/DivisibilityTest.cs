using FizzBuzz.Divisibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.DivisibilityTest
{
    [TestClass]
    public class DivisibilityTest
    {
        [TestMethod]
        public void TestDivisorValues()
        {
            //Arrange
            const string divisibleBy3 = "Fizz";
            const string divisibleBy5 = "Buzz";
            const string divisibleByBoth = "FizzBuzz";

            var DivisorsAndValues = new Dictionary<int, string>();
            DivisorsAndValues.Add(3, divisibleBy3);
            DivisorsAndValues.Add(5, divisibleBy5);

            //Act 
            var generator = new ValueGenerator(15);
            var results = generator.GenerateDivisibleValues(DivisorsAndValues);

            //Assert
            foreach(var result in results)
            {
                if(result != null)
                {
                    if (result.Number == 3)
                        Assert.AreEqual(divisibleBy3, result.Value, $"{result.Number} is divisible by 3.");

                    if (result.Number == 5)
                        Assert.AreEqual(divisibleBy5, result.Value, $"{result.Number} is divisible by 5");

                    if (result.Number == 15)
                        Assert.AreEqual(divisibleByBoth, result.Value, $"{result.Number} is divisible by 3 and 5");
                }

            }
        }
    }
}
