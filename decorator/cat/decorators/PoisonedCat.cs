namespace Animals.Cat.Decorator
{
    public class PoisonedCat : CatDecorator
    {
        public PoisonedCat(Cat cat) : base(cat){}
        
        public override int CatPawDamage()
        {
            return this.Cat.CatPawDamage() - 7;
        }
    }
}
