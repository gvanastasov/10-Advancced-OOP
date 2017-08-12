using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    class StartUp
    {
        static void Main()
        {
            var phone = new Smartphone();

            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                phone.Call(number);
            }

            foreach (var url in urls)
            {
                phone.Browse(url);
            }
        }
    }
}
