using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persons
{
    private string name;
    private int age;
    private string email;

    public Persons(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Persons(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public string Name
    {
        get 
        {
            return this.name;
        }
        set
        {
            if(value == null || value.ToString().Trim() == "")
            {
                throw new ArgumentNullException("No name");
            }
            this.name = value;
        }
    }
    public int Age 
    {
        get 
        {
            return this.age;
        }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Of range");
            }
            this.age = value;
        }
    }
    public string Email 
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value != null && !value.Contains("@"))
            {
                throw new Exception("Invalid Email");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Age: {1}, Emil: {2}",
            this.Name, this.Age, this.Email ?? "(empty)");
    }
}