using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.id = id;
        this.birthdate = birthdate;
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

    private string birthdate;
    public string Birthdate
    {
        get
        {
            return this.birthdate;
        }
    }
}
