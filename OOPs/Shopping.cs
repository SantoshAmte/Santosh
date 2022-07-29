using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Shopping
    {
        string item;
        int price;
        int qty;
        public void Accept(string car, int tprice, int tqty)
        {
            item = car;
            price = tprice;
            qty = tqty;

        }
        public void Bill()
        {
            int bill = qty * price;
            if (qty > 2)
            {
                Console.WriteLine("total bill is  " + bill);

            }
            else
            {
                Console.WriteLine("error");
            }
        }
        void show()
        {
            Console.WriteLine("item \t price \t qty");
            Console.WriteLine(item + "  " + price + "   " + qty);

        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.Accept("Creata",1857200, 5);
            s.Bill();
            s.show();


        }
    }


}

