<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WhiteBox
    {
        static void Main(string[] args)
        {
           // Q4_data();
            Console.ReadKey();
            
        }

        public int MyTestObject(int a, int b)
        {
            if (a<=b)
            {
                b = 2 * b;
            }
            else
            {
                if(a>250)
                {
                    a = a - 100;
                }
            }
            int c = a + b;
            if (c > 50)
                c = c * 2;
            return c;
        }

        public static void Q4_data()
        {
            Console.WriteLine("Insert P");
            int p = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insert Q");

            int q =  Int32.Parse(Console.ReadLine());

            if (p+q > 200)
            {
                Console.WriteLine("hello");
            }
            if (p>100)
            {
                Console.WriteLine("P is Large");
            }      
        }

        public  string ProQ4(int p, int q)
        {
            string res="";

            if (p + q > 200)
            {
                res = "Hello";
            }
            if (p > 100)
            {
                res = "P is Large";
            }
            return res;

        }


    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WhiteBox
    {
        static void Main(string[] args)
        {
           // Q4_data();
            Console.ReadKey();
            
        }

        public int MyTestObject(int a, int b)
        {
            if (a<=b)
            {
                b = 2 * b;
            }
            else
            {
                if(a>250)
                {
                    a = a - 100;
                }
            }
            int c = a + b;
            if (c > 50)
                c = c * 2;
            return c;
        }

        public static void Q4_data()
        {
            Console.WriteLine("Insert P");
            int p = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insert Q");

            int q =  Int32.Parse(Console.ReadLine());

            if (p+q > 200)
            {
                Console.WriteLine("hello");
            }
            if (p>100)
            {
                Console.WriteLine("P is Large");
            }      
        }

        public  string ProQ4(int p, int q)
        {
            string res="";

            if (p + q > 200)
            {
                res = "Hello";
            }
            if (p > 100)
            {
                res = "P is Large";
            }
            return res;

        }


    }
}
>>>>>>> 984f4c9b9290616b6d6346ddd2f6c584ce60a113
