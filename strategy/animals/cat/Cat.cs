using System;
using Animals.Strategies;

namespace Animals.Cat
{
    interface ICat
    {
        ITalkStrategy TalkStrategy { get; }
        void Meow();
    }
    
    class Cat : ICat
    {
        public ITalkStrategy TalkStrategy { get; }

        public Cat(ITalkStrategy talkStrategy)
        {
            this.TalkStrategy = talkStrategy;
        }

        public void Meow()
        {
            this.TalkStrategy.Say();
        }
    }

    class Meow : ITalkStrategy
    {
        public void Say()
        {
            Console.WriteLine("Cat says: Meow");
        }
    }
}
