using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //class we made
            Receipt new_receipt =  new Receipt();

            //input statements
            Console.WriteLine("Welcome new customer");
            Console.WriteLine("Please enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your phone number in format 123456789");
            string tempphone = Console.ReadLine();
            char[] phone = tempphone.ToCharArray();
            Console.WriteLine("Please enter your address all in one line");
            string address = Console.ReadLine();
            Console.WriteLine("Name of item Purchased?");
            string item_name = Console.ReadLine();
            Console.WriteLine("Number purchased?");
            int num_items = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I guess you get to enter the price of your item");
            double unit_price = Convert.ToDouble(Console.ReadLine());






            //inputs the receipt
            new_receipt.purchaseorder(name, address, phone, item_name, num_items, unit_price);
            //prints the applicable information.
            new_receipt.ToString();
            Console.ReadKey(true);

        }




    }
}
