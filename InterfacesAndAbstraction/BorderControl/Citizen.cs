using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IIdentifiable
{
    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.id = id;
    }

    private int age;
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    private string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    private string id;
    public string Id
    {
        get
        {
            return this.id;
        }
    }
}
