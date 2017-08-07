using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Startup
    {
        static void Main()
        {
            Spy spy = new Spy();

            //string result = spy.StealFieldInfo("Hacker", "username", "password");
            //string result = spy.AnalyzeAcessModifiers("Hacker");
            //string result = spy.RevealPrivateMethods("Hacker");
            string result = spy.CollectGettersAndSetters("Hacker");

            Console.WriteLine(result);
        }
    }
}
