using System;

class Dog2
{
    public Dog2() : this (null, null)
    {

    }
    public Dog2(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public string Name { get; set; }
    public string Breed { get; set; }

    public void Bark()
    {
        Console.WriteLine("{0} ({1}) said: Bauuuuuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
    }
}
