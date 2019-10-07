namespace Animals.Cat
{ 
    public abstract class Cat
    {
        public abstract int CatPawDamage();
    }

    class NormalCat : Cat
    {
        public override int CatPawDamage()
        {
            return 10;
        }
    }

    class StrongCat : Cat
    {
        public override int CatPawDamage()
        {
            return 20;
        }
    }
}
