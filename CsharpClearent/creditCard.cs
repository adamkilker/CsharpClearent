using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClearent
{
    public class creditCard
    {

        private String name { get; set; }
        private double balance { get; set; }
        private double interestRate { get; set; }

        public creditCard(String n, double b, double ir)
        {
            name = n;
            balance = b;
            interestRate = ir;
        }

        public creditCard(String n, double b)
        {
            name = n;
            balance = b;
        }

        public double simpleInterest()
        {
            return this.balance * this.interestRate;
        }
    } //end creditCard class

    public class visa : creditCard
    {
       // double rate = .10;
        public visa(String name, double balance, double rate) : base(name, balance, rate)
        {
        }
    }//end visa class

    public class discover : creditCard
    {
        //double rate = .01;
        public discover(String name, double balance, double rate) : base(name, balance, rate)
        {
        }
    }//end discover class

    public class mastercard : creditCard
    {

        //double rate= .05;
        public mastercard(String name, double balance, double rate) : base(name, balance, rate)
        { 
        }

    }//end mastercard class
}
