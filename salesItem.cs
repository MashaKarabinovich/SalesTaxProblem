using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

//sales tax
//variety of items for sale
//sales tax to items is 10% except books, food, medical products
//import sales tax  5%
//return recipets with all calculating taxes, and totals

class salesItem
{
    public salesItem(String item string price, double tax)
    {
        this.item = item; 
        this.price = price; 
        this.tax = tax;
    }

    public string getItem()
    {
        return item; 
    }
    public string getPrice()
    {
        return price; 
    }
    public string getTax()
    {
        return tax; 
    }

    public virtual void Display()
    {
        Console.WriteLine("Main class.")
    }
}