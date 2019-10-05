using System;
using Animals.Strategies;

namespace Animals.Dog
{
    interface IDog
    {
        ITalkStrategy TalkStrategy { get; }
        void Bark();
    }
    
    class Dog : IDog
    {
        public ITalkStrategy TalkStrategy { get; }

        public Dog(ITalkStrategy talkStrategy)
        {
            this.TalkStrategy = talkStrategy;
        }

        public void Bark()
        {
            this.TalkStrategy.Say();
        }
    }

    class Bark : ITalkStrategy
    {
        public void Say()
        {
            Console.WriteLine("Dog says: Bark");
        }
    }
}
