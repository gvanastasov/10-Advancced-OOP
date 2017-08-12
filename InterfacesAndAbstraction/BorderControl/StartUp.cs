using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 public class Program
{
    private static List<IIdentifiable> inhabitants = new List<IIdentifiable>();

    static void Main()
    {
        while (true)
        {
            var cmd = Console.ReadLine();

            if(cmd == "End")
            {
                break;
            }

            var tokens = cmd.Split();

            IIdentifiable inhabitant;
            if(tokens.Length == 2)
            {
                inhabitant = new Robot(tokens[0], tokens[1]);
            }
            else
            {
                inhabitant = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
            }
            inhabitants.Add(inhabitant);
        }

        var controlNumber = Console.ReadLine();

        foreach (var inhabitant in inhabitants)
        {
            if(inhabitant.Id.EndsWith(controlNumber))
            {
                Console.WriteLine(inhabitant.Id);
            }
        }
    }
}
