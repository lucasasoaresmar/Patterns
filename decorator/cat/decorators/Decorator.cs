namespace Animals.Cat.Decorator
{
    public abstract class CatDecorator : Cat
    {
        public Cat Cat { get; set; }
        
        public CatDecorator(Cat cat)
        {
            this.Cat = cat;
        }
    }
}
