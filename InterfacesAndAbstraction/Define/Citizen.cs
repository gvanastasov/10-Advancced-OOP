using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
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
        set
        {
            this.id = value;
        }
    }

    public string Birthdate
    {
        get;
        set;
    }
}
