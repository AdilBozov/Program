using System;

class DefineClassDog2
{
    static void Main()
    {
        Dog2 unnamed = new Dog2();
        Dog2 sharo = new Dog2("Saro", "Melez");

        unnamed.Name = "Reksi";
        unnamed.Breed = "German Shepherd";

        unnamed.Bark();
        sharo.Bark();
    }
}
