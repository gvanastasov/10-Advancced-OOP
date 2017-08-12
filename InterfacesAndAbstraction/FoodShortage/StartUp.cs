using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    private static Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

    static void Main()
    {
        var buyersCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < buyersCount; i++)
        {
            var tokens = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            IBuyer buyer;
            if(tokens.Length == 3)
            {
                buyer = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
            }
            else
            {
                buyer = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
            }

            buyers.Add(tokens[0], buyer);
        }

        while (true)
        {
            var cmd = Console.ReadLine();

            if(cmd == "End")
            {
                break;
            }

            IBuyer buyer;
            if(buyers.TryGetValue(cmd, out buyer))
            {
                buyer.BuyFood();
            }
        }

        Console.WriteLine(buyers.Sum(x => x.Value.Food));
    }
}
