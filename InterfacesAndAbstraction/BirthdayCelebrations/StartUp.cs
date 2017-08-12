using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private static List<IIdentifiable> inhabitants = new List<IIdentifiable>();
    private static List<IBirthable> birthables = new List<IBirthable>();

    static void Main()
    {
        while (true)
        {
            var cmd = Console.ReadLine();

            if (cmd == "End")
            {
                break;
            }

            var tokens = cmd.Split(new string[] { " "}, StringSplitOptions.RemoveEmptyEntries);

            var type = tokens[0];
            if (tokens.Length == 3)
            {
                if(type == "Robot")
                {
                    inhabitants.Add(new Robot(tokens[1], tokens[2]));
                }
                else if(type == "Pet")
                {
                    birthables.Add(new Pet(tokens[1], tokens[2]));
                }
            }
            else
            {
                Citizen c = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                inhabitants.Add(c);
                birthables.Add(c);
            }
        }

        var controlYear = Console.ReadLine();
        foreach (var birthalbe in birthables)
        {
            if (birthalbe.Birthdate.EndsWith(controlYear))
            {
                Console.WriteLine(birthalbe.Birthdate);
            }
        }
    }
}
