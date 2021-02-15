using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

//sales tax to get the tax on items.
public class salesTaxPercent  : salesItem
{
    public double Calculate(double price, double tax, bool imported)
    {
        double tax = price * .010; //10% tax
        Math.Round(Decimal, tax) //round the 5 cents
        if(imported == true)
        {
            tax +=(price * 0.5); //for the imported 5%
            Math.Round(Decimal, tax); //actual rounding
            return tax;
        }
    }
}