class Knight : Hero
{
    public Knight(string name) : base(140, name, 25, 0.2)
    {
    }

    public override void Attack(Hero target)
    {
        int chance = Random.Shared.Next(5);
        if (chance == 4)
        {
            target.TakeDamage(HeavyAttack());
        } else
        {
            base.Attack(target);
        }
    }

    private int HeavyAttack()
    {
        return (int)Math.Round(Damage * 1.25);
    }
}