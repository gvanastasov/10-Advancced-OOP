using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IPerson, IResident
{
    public Citizen(string name, string country, int age)
    {
        this.name = name;
        this.country = country;
        this.age = age;
    }

    private int age;
    public int Age
    {
        get
        {
            return this.age;
        }
    }

    private string country;
    public string Country
    {
        get
        {
            return this.country;
        }
    }

    private string name;
    public string Name
    {
        get
        {
            return this.name;
        }
    }

    string IPerson.GetName()
    {
        return this.Name;
    }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs {this.Name}";
    }
}
