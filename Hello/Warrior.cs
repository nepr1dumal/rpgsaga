public class Warrior : Character
{
    private Random random = new();
    public Warrior(string name, int hp, int dmg) : base(name, hp, dmg)
    {
    }

    public override void Attack(Character character)
    {
       int chance = random.Next(1,11);
       if (chance <= 3)
        {
            character.TakeDamage(Damage * 2);
        }
        else
        {
            character.TakeDamage(Damage);
        }
    }

}