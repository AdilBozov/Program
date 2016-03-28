using System;
namespace Dogs
{

    class DefineAClassDog
    {
        static void Main()
        {
            Dog d = new Dog();
            d.Bark();

            Dog sharo = new Dog("Шаро", "Улична превъзходна");
            sharo.Bark();

            Console.WriteLine(sharo);
            Console.WriteLine(sharo.GetType().Name);
        }
    }
}