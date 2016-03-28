using System;

        //the gravitational field of the moon is approximately 17% of that on the earth. write a program that calculates the weight of a man on the moon by a given weight on the earth. examples:
        //weight	weight on the moon
        //86	14.62
        //74.6	12.682
        //53.7	9.129


class GravitationOnTheMoon_02
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = (weight * 17) / 100;
        Console.WriteLine("Weight Moon "+weightMoon);
    }
}
