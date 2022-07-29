using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewFunda.OOPs
{
    class Recursionpro
    {
        int num = 1;

        void Counting()
        {
            if(num ==23)
            {
                return;
            }

            Console.WriteLine(num);
            num++;
            Counting();

        }

        //static void Main(string[] args)
       // {
           // Recursionpro obj = new Recursionpro();
           // obj.Counting();
           // Console.ReadLine();
        //}
    }


}
