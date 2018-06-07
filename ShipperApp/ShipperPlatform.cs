using System;
using ShipperAppLibrary.Shippement;
using ShipperAppLibrary.Users;
using ShipperAppLibrary.Payments;



namespace ShipperApp
{
    class ShipperPlatform
    {
        public static string user_Id;
        static void Main(string[] args)
        {
            Shipper customer = new Shipper();

            Driver ID = new Driver();
            Console.WriteLine("Enter the user type");
            Console.WriteLine("customer");
            Console.WriteLine("driver");
            user_Id = Console.ReadLine();
            if (user_Id == "customer")
            {
                customer.Login();
                customer.Place_order();

            }
            else if (user_Id == "driver")
            {
                ID.Login();
                ID.Accept_order();
            }
            Console.ReadKey();
        }


    }
}
