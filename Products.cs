using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public abstract class Products
{
    public string Name 
    {
        get; set;
    }

    public double price
    {
        get; set; 
    }

    bool imported
    {
        get; set;
    }

    public int amount 
    {
        get; set;
    }
    
    public int finalCost
    {
        get; set;
    }

    public Products() //constructor
    this.Name = name; 
    this.price = 0.0; 
    this.imported = false; 
    this.amount = 0; 
    this.finalCost = 0.0;

    public Products(String name, double price, bool imported, int amount) //this statements
    {
        this.name = name; 
        this.price =price; 
        this.imported = imported; 
        this.amount = amount;
    }

    public override string ToString()
    {
        return( Quantity + " " + ToString(import) + " " + name + ":" + finalCost); //output string
    }


}