using Animals.Cat;
using Animals.Dog;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Meow meow = new Meow();
            Cat Ani = new Cat(meow);
            Ani.Meow();

            Bark bark = new Bark();
            Dog Mel = new Dog(bark);
            Mel.Bark();
        }
    }
}
