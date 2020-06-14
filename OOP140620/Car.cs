using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140620
{
    [DebuggerDisplay("{brand} {model}")]
    public class Car
    {

        public int year;
        public double km = 0;
        public string brand;
        public string model;

        public string TellMeYourModel()
        {
            return model;
        }
        public void Drive()
        {
            Console.WriteLine($"{brand} {model} is driving ...");
        }
        public void Start()
        {
            Console.WriteLine($"{brand} {model} is strting the engine ...");
        }
        public double TellMeYourKm()
        {
            return km;
        }

        public override string ToString()
        {
            return $"[Car] : year:{year} km:{km} brand:{brand} model:{model}";
        }

    }
}
