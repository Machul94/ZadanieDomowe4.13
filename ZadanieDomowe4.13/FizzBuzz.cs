using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe4._13
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
      
            return number.ToString();
                
        }
    }
}

