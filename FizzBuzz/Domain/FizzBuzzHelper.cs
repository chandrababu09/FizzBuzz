using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Domain
{
    public static class FizzBuzzHelper
    {
        public static List<string> CalculateFizzBuzz(string[] values)
        {
            List<string> resultedFizzBuzzOutput = new List<string>();

            for(int i=0; i<values.Length; i++)
            {
                values[i] = values[i] == null ? "" : values[i].ToString();

                if (!int.TryParse(values[i].ToString(),out int opvalue))
                {
                    resultedFizzBuzzOutput.Add($"Invalid Item {values[i].ToString()}");
                    continue;
                }

                if (IsDivisbleBy3(Convert.ToInt32(values[i]), resultedFizzBuzzOutput) && (IsDivisbleBy5(Convert.ToInt32(values[i]), resultedFizzBuzzOutput)))
                {
                    resultedFizzBuzzOutput.Add("FizzBuzz");
                }
                if (IsDivisbleBy3(Convert.ToInt32(values[i]), resultedFizzBuzzOutput))
                {
                    resultedFizzBuzzOutput.Add("Fizz");
                }
                if (IsDivisbleBy5(Convert.ToInt32(values[i]), resultedFizzBuzzOutput))
                {
                    resultedFizzBuzzOutput.Add("Buzz");
                }
            }
            return resultedFizzBuzzOutput;
        }

        private static bool IsDivisbleBy3(int value, List<string> resultedFizzBuzzOutput)
        {
            Console.WriteLine($"Divided {value} by 3 {Environment.NewLine}");
            resultedFizzBuzzOutput.Add($"Divided {value} by 3");
            return value % 3 == 0;
        }

        private static bool IsDivisbleBy5(int value, List<string> resultedFizzBuzzOutput)
        {
            Console.WriteLine($"Divided {value} by 5 {Environment.NewLine}");
            resultedFizzBuzzOutput.Add($"Divided {value} by 5");
            return value % 5 == 0;
        }
    }
}
