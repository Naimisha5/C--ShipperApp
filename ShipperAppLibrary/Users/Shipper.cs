﻿using System;
using System.Collections.Generic;
using System.Text;
namespace ShipperAppLibrary.Users
{
    public class Shipper : User
    {
        public int order_id = 0;
        public string usname;
        public string pwd;
        private string Pwd { get; set; }
        public string Usname { get; set; }

        public void Place_order()
        {
            Console.WriteLine("List of Products");
            Console.WriteLine("Product1");
            Console.WriteLine("Product2");
            Console.WriteLine("Product3");
            order_id = Console.Read();
            Console.WriteLine(order_id);
        }


    }
}
