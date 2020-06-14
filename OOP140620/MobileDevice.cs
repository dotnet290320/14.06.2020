using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140620
{
    [DebuggerDisplay("{vendor} {(size*2)}")]
    public class MobilePhone // Pascal Case
    {
        // Data
        // default value
        // numeric = 0
        // bool = false
        // ... not yet learned
        // string , object = null
        public string vendor;
        public string color;
        public float  size;
        public string os;
        // data with default values
        public bool   isDeviceTurnOn = false; // camel case
        public bool   isWorking = true;

        // pascal case for functions
        public void MakeACall(string number)
        {
            if (isDeviceTurnOn)
            {
                Console.WriteLine($"calling {number} from {vendor} {os}.....");
            }
            else
            {
                Console.WriteLine($"Sorry {vendor} {os} is turned off");
            }
        }

        public void TurnOnPhone()
        {
            Console.WriteLine($"turning on the {vendor} {os} phone");
            isDeviceTurnOn = true;
        }



        public override string ToString()
        {
            return $"[MobilePhone] : vendor:{vendor} color:{color} size:{size} os:{os} isDeviceTurnOn:{isDeviceTurnOn} isWorking:{isWorking}";
        }
    }   
}                                  