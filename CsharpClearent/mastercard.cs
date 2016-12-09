using System;

public class mastercard : creditCard
{

    double interestRate = .05;
    public mastercard(String name, double balance) : base(name, balance)
    {
        this.interestRate = interestRate;
    }

}
