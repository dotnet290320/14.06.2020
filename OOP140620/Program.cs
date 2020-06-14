using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140620
{
   
    class Program
    {

        static void Main(string[] args)
        {

            // code
            Random r = new Random();
            int x = 9;
            // var <name-I-invented> = new [Name-of-class]();
            // [Name-of-class] <name-I-invented> = new [Name-of-class]();
            MobilePhone myNewIphone = new MobilePhone();
            myNewIphone.vendor = "Iphone";
            myNewIphone.color = "white";
            myNewIphone.size = 8.5f;
            myNewIphone.os = "IOS 11";

            // Mofa, instance
            Console.WriteLine($"vendor of myNewIphone : {myNewIphone.vendor}");
            Console.WriteLine($"color of myNewIphone : {myNewIphone.color}");
            Console.WriteLine($"size of myNewIphone : {myNewIphone.size}");
            Console.WriteLine($"os of myNewIphone : {myNewIphone.os}");
            Console.WriteLine($"isWorking of myNewIphone : {myNewIphone.isWorking}");
            Console.WriteLine($"isDeviceTurnOn of myNewIphone : {myNewIphone.isDeviceTurnOn}");

            Console.WriteLine();
            // Object initiazlizer
            MobilePhone mySamsung = new MobilePhone()
            {
                vendor = "Samsung",
                color = "black",
                size = 7.2f,
                os = "KitKat"
            };

            Console.WriteLine($"vendor of mySamsung : {mySamsung.vendor}");
            Console.WriteLine($"color of mySamsung : {mySamsung.color}");
            Console.WriteLine($"size of mySamsung : {mySamsung.size}");
            Console.WriteLine($"os of mySamsung : {mySamsung.os}");
            Console.WriteLine($"isWorking of mySamsung : {mySamsung.isWorking}");
            Console.WriteLine($"isDeviceTurnOn of mySamsung : {mySamsung.isDeviceTurnOn}");

            Console.WriteLine();

            Console.WriteLine(myNewIphone);

            myNewIphone.TurnOnPhone();

            myNewIphone.MakeACall("035555555");
            mySamsung.MakeACall("035555555");

            Console.WriteLine("==============================================");

            string myNewIphone_string = myNewIphone.ToString();

            Console.WriteLine(myNewIphone.ToString());
            Console.WriteLine(mySamsung);

            Console.WriteLine("================= Garage =============================");
            Car honda = new Car()
            {
                brand = "Honda",
                model = "Civic",
                km = 100,
                year = 2020
            };
            Console.WriteLine(honda);
            honda.Start();
            honda.Drive();
            double kmHonda = honda.TellMeYourKm();
            Console.WriteLine(kmHonda);
            // Console.WriteLine(honda.TellMeYourKm());
        }
    }
}
