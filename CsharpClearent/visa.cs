using System;

public class visa : creditCard
{
    double interestRate = .10;
    public visa(String name, double balance) : base(name, balance)
    {
        this.interestRate = interestRate;
    }
}
