public class Mage : Character
{
    private int _counter = 0;
    public Mage(string name, int hp, int dmg) : base(name, hp, dmg)
    {
    }

    public override void Attack(Character character)
    {
       if (_counter == 2)
        {
            character.TakeDamage(Damage * 3);
            _counter = 0;
        } else
        {
        _counter++;
        character.TakeDamage(Damage);
        }
    }

}