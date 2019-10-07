namespace Animals.Cat.Decorator
{
    public class RobotCatDecorator : CatDecorator
    {
        public RobotCatDecorator(Cat cat) : base(cat){}
        
        public override int CatPawDamage()
        {
            return this.Cat.CatPawDamage() + 5;
        }
    }
}
