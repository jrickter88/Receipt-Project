using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt_Project
{
    public class Receipt
    {
        //variables asked to be stored in the receipt
        Random rand2 = new Random();
        string name;
        int r_number = 0;
        DateTime date_of_purchase;
        int cust_num = 1000;
        string cust_address;
        char[] cust_phone = new char[9];
        double unit_price;
        int item_num;
        string item_descrption;
        int quantity_purchased;
        double total_cost;
        string item_name;

        //default constructor, will create a blank receipt
        public Receipt()
        {





        }
        //to populate our receipt. 
        public void purchaseorder(string name2,string cust_address2,char[] cust_phone2,string item_name2, int num_purchased, double unit_price2)
            
            
            {
            // sets item number to random number
            item_num = rand2.Next(0, 1000);
            //setting main storage variables
            name = name2;
            r_number++;
            cust_num++;
            date_of_purchase = DateTime.Now;
            cust_address = cust_address2;
            cust_phone = cust_phone2;
            item_name = item_name2;
           

            quantity_purchased = num_purchased;
            unit_price = unit_price2;

            this.Calculate();


            }

        public override string ToString()
        {
            //string override to print
            Console.Write("Customer Name: " + name + "\nCustomer Phone: " + cust_phone.ToString() + "\n Total Cost: " + total_cost);





            return base.ToString();
        }


        public void Calculate()

        {
            
            //calculates total price of receipt
            total_cost = Convert.ToDouble(quantity_purchased) * unit_price;





        }



    }
}
