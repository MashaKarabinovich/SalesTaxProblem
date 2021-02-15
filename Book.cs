using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

  class Book : salesItem
{
    private string bookItem; 
    private string amount; 
    private string price; 
    private string tax;
    public string finalCost;

    public Book(String name, double price, bool imported, int amount, bool imported) //this statements
    {
        this.name = name; 
        this.price =price; 
        this.imported = imported; 
        this.amount = amount;     
    }

    public string getBookItem()
    {
        return bookItem; 
    }
    public string getamount()
    {
        return amount; 
    }
    public string getPrice()
    {
        return price; 
    }
    public string getTax()
    {
        salesTaxPercent(tax)
        return tax; 
    }
    public string finalCost()
    {
        price + tax = finalcost;
        return finalcost;
    }
     public string getimported()
    {
        return false; 
    }

    public override string ToString()
    {
        return( bookItem + " : " + final cost + " " + amount + "@" + price);
    }


}