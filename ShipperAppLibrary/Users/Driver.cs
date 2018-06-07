using System;
using System.Collections.Generic;
using System.Text;
using ShipperAppLibrary.Users;

namespace ShipperAppLibrary.Users
{
    public class Driver : User
    {

        private string dpwd;
        public string dusrname;
        public string idproof;
        public string vehicletype;
        private string Dpwd { get; set; }
        public string Dusrname { get; set; }

        public void Accept_order()
        {
            Console.Write("Enter source location");
            source = Console.ReadLine();
            if (source == "kakinada" || source == "banglore")
            {
                Console.WriteLine("Order accpeted successfully");
            }
            else
            {
                Console.WriteLine("Not able to accept the order");
            }

        }

    }
}
