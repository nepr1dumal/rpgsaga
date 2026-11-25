abstract class Hero {
    
    public int Hp {get; private set;}
    public int MaxHp {get; private set;}
    public string Name {get; private set;}
    public int Damage{get; private set;}

    public Hero(int maxHp, int hp, string name, int damage)
    {
        MaxHp = maxHp;
        Hp = hp;
        Name = name;
        Damage = damage;
    }

    public bool IsAlive() => Hp > 0;

    public abstract void Attack(Hero targer);

    public void TakeDamage(int damage)
    {
        Hp -= damage;
    }
}