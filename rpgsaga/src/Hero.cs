abstract class Hero {
    
    public string Name {get; private set;}
    public int Hp {get; private set;}
    public int MaxHp {get; private set;}
    public int Damage {get; private set;}
    public double DefencePoint {get; private set;}
    

    public Hero(int maxHp, string name, int damage, double defencePoint)
    {
        MaxHp = maxHp;
        Hp = maxHp;
        Name = name;
        Damage = damage;
        DefencePoint = defencePoint;
    }

    public bool IsAlive() => Hp > 0;

    public virtual void Attack(Hero target)
    {
        target.TakeDamage(Damage);
    }

    public virtual void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            int finalDamage = Math.Max((int)(damage * (1 - DefencePoint)), 1);
            Hp = Math.Max(Hp - finalDamage, 0);
        }
    }

    public virtual void Refresh()
    {
        Hp = MaxHp;
    }
}