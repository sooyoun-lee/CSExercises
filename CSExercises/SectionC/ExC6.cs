using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write the amount you want to order");
            Console.Write("TV:\t");
            string tvQtyStr = Console.ReadLine();
            Console.Write("DVD:\t");
            string dvdQtyStr = Console.ReadLine();
            Console.Write("MP3:\t");
            string mp3QtyStr = Console.ReadLine();

            int tvQty = Convert.ToInt32(tvQtyStr);
            int dvdQty = Convert.ToInt32(dvdQtyStr);
            int mp3Qty = Convert.ToInt32(mp3QtyStr);

            double totalPrice = CalculateTotalPrice(tvQty, dvdQty, mp3Qty);

            Console.WriteLine(totalPrice);
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            double totalPrice = 0;

            if ((tvQty * 900) + (dvdQty * 500) > 10000)
            {
                totalPrice = totalPrice + ((tvQty * 900 + dvdQty * 500) * 0.85);
            }
            else
            {
                if (tvQty * 900 + dvdQty * 500 > 5000 && tvQty * 900 + dvdQty * 500 <= 10000)
                {
                    totalPrice = totalPrice + ((tvQty * 900 + dvdQty * 500) * 0.9);
                }
                else
                {
                    totalPrice = totalPrice + (tvQty * 900 + dvdQty * 500);
                }
            }
            
            totalPrice = totalPrice + (mp3Qty * 700);

            return totalPrice;



        }
    }
}