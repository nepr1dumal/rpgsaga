class Spell
{

    public string Name {get; private set;}
    public int Damage {get; private set;}
    public int Cost {get; private set;}

    public Spell(string name, int damage, int cost)
    {
        Name = name;
        Damage = damage;
        Cost = cost;
    }
}