class ProgramMain
    {

        //program will take carts as an array list
        //outputs the reciept from the method named methodReciept
        static void Main(string[] args)
        {

         Arraylist cart1 = new Arraylist();
         cart1.add(b1);
         cart1.add(b2);

           methodReciept(cart1) //to output reciept
        }

       public String reciept(Arraylist cart){

        String reciept = "";
        Double totalTax = 0;
        Double priceTotal = 0;
             for(int i; i < cart.length; i++){
                //return item name, total price, (amount and single price)
                    if(cart1.getType() == typeOf(Book) || cart1.getType() == typeOf(Candy) || cart1.getType() == typeOf(Medicine)){
                     reciept += cart[i].getName() + ": " + cart[i].getAmount()*cart[i].getPrice();
                     if(getAmount > 1){
                     reciept += "(" + cart[i].getAmount() + " @ " + cart[i].getPrice() + ")";
                    }
                    reciept += "\n";
                    priceTotal += cart[i].getPrice();
                 } 
                    else{
                         reciept += cart[i].getName() + ": " + cart[i].getAmount()*(cart[i].getPrice()+cart[i].Calculate()) + " ";
                            if(getAmount > 1){
                            reciept += "(" + cart[i].getAmount() + " @ " + cart[i].getPrice() + ")";
                    }
                         totalTax += cart[i].Calculate();
                         reciept += "\n";
                         priceTotal += cart[i].getAmount()*(cart[i].getPrice()+cart[i].Calculate());
             }
    
                    //sales tax
                    reciept += "Sales Taxes: " + totalTax + "\n";
                    //total
                    reciept += "Total: " + priceTotal;

                    return reciept;
        }
     }