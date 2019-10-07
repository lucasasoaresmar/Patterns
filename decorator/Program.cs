using System;
using Animals.Cat;
using Animals.Cat.Decorator;

namespace decorator
{
    class Program
    {
        static void Main(string[] args) 
        {
            Cat NormalRobotCat = new RobotCatDecorator(new NormalCat());
            Cat StrongPoisonedRobotCat = new PoisonedCat(new RobotCatDecorator(new StrongCat()));
            
            Console.WriteLine(NormalRobotCat.CatPawDamage());
            Console.WriteLine(StrongPoisonedRobotCat.CatPawDamage());
        }
    }
}
