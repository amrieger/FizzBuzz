using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Divisibility
{
    public class ValueGenerator
    {
        private int _upwardNumber;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="upwardNumber">The upward number that will be checked for divisibility</param>
        public ValueGenerator(int upwardNumber)
        {
            if (upwardNumber <= 0)
                throw new ArgumentException("Number cannot be null and must be greater than 0.");

            _upwardNumber = upwardNumber;
        }

        /// <summary>
        /// This method accepts divisors and values to display for numbers that are
        /// divisible by the divisor
        /// </summary>
        /// <param name="divisorValueCollection">Key Value Pair of divisors and associated string value</param>
        /// <returns></returns>
        public IEnumerable<ValueResult> GenerateDivisibleValues(Dictionary<int, string> divisorValueCollection)
        {
            if (divisorValueCollection != null)
            {
                for (int i = 1; i <= _upwardNumber; i++)
                {
                    var values = new List<string>();

                    foreach (var kvp in divisorValueCollection)
                    {
                        if ((i % kvp.Key) == 0)
                        {
                            if (kvp.Value != null)
                                values.Add(kvp.Value);
                        }
                    }

                    if (values.Count() == 0)
                    {
                        values.Add(i.ToString());
                    }

                    var text = new StringBuilder();
                    
                    foreach(var val in values)
                    {
                        text.Append(val);
                    }

                    yield return new ValueResult { Number = i, Value = text.ToString() };

                }
            }

            yield return null;
        }
    }
}
