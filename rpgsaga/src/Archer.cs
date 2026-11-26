class Archer : Hero, IEvasive
{
    public double ChanceOfEvasion {get; private set;}
    public Archer(string name) : base(110, name, 10, 0.1)
    {
        ChanceOfEvasion = 0.15;
    }

    public override void TakeDamage(int damage)
    {
        if (!Dodge())
        {
            base.TakeDamage(damage);
        }
    }

    private int CriticalHit()
    {
        return (int)Math.Round(Damage * 1.4);
    }

    public override void Attack(Hero target)
    {
        for (int i = 0; i < 3 && target.IsAlive(); i++)
        {
            int chance = Random.Shared.Next(3);
            if (chance == 2)
            {
                target.TakeDamage(CriticalHit());
            } else
            {
                base.Attack(target);
            }
        }
    }

    public bool Dodge()
    {
        double chance = Random.Shared.NextDouble();
        if (chance >= ChanceOfEvasion)
        {
            return false;
        }
        return true;
    }
}