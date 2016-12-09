using System;


    public class discover : creditCard
    {
        double interestRate = .01;
        public discover(String name, double balance) :base(name, balance)
        {
            this.interestRate = interestRate;
        }
    }

