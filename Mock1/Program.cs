using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
      
    }
    

    public class CustomerService
    {

        public virtual int GetValue()
        {
            return 11;
        }
    }


    public class Customer
    {
        private readonly CustomerService _cs;

        public Customer(CustomerService cs)
        {
            _cs = cs;
        }

        public int CalcDiscount()
        {
            return _cs.GetValue() * 2;
        }

    }

}
