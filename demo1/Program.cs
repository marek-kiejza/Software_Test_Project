<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        
        // method to return the sum of two integers
        public int Add(int x, int y)
        {
            return x - y; // on purpose error, should be + 
        }

// method to check if a number is between 1 and 5 inclusive, if greater then 10 an exception is thrown
        public bool CheckRange(int x)
        {
            if (x > 10)
                throw new ArgumentOutOfRangeException("x", "number greater then 10)");

            // note the off by one on purpose error, >= && <=
            if (x > 1 && x < 5)
                return true;
            else
                return false;
        }
            
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        
        // method to return the sum of two integers
        public int Add(int x, int y)
        {
            return x - y; // on purpose error, should be + 
        }

// method to check if a number is between 1 and 5 inclusive, if greater then 10 an exception is thrown
        public bool CheckRange(int x)
        {
            if (x > 10)
                throw new ArgumentOutOfRangeException("x", "number greater then 10)");

            // note the off by one on purpose error, >= && <=
            if (x > 1 && x < 5)
                return true;
            else
                return false;
        }
            
    }
}
>>>>>>> 984f4c9b9290616b6d6346ddd2f6c584ce60a113
