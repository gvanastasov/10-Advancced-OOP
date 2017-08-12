using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.food = 0;
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

    private string group;
    public string Group
    {
        get
        {
            return this.group;
        }
        set
        {
            this.group = value;
        }
    }

    private int food;
    public int Food
    {
        get
        {
            return this.food;
        }
    }

    public void BuyFood()
    {
        this.food += 5;
    }
}
