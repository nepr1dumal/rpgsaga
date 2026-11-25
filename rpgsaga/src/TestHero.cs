class TestHero : Hero
{
    public TestHero(int maxHp, int hp, string name, int damage) : base(maxHp, hp, name, damage)
    {
    }

    public override void Attack(Hero target)
    {
        target.TakeDamage(Damage);
    }
}