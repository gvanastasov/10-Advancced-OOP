using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Smartphone : ICallable, IBrowsable
{
    public void Browse(string url)
    {
        
        var urlReg = new Regex(@"\d+");

        if(urlReg.IsMatch(url))
        {
            Console.WriteLine("Invalid URL!");
        }
        else
        {
            Console.WriteLine($"Browsing: {url}!");
        }

    }

    public void Call(string number)
    {
        var numReg = new Regex("^[0-9]+$");

        if (numReg.IsMatch(number))
        {
            Console.WriteLine($"Calling... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

    }
}
