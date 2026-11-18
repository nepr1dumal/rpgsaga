public abstract class Character
{
    public string Name {get;}
    public int Hp {get; private set;}
    public int Damage {get;}

    public Character(string name, int hp, int dmg){
        this.Name = name;
        this.Hp = hp;
        this.Damage = dmg;
    }
    public bool IsAlive => (this.Hp != 0);

    public bool TakeDamage(int damage)
    {
        this.Hp -= damage;
        if (this.Hp < 0)
        {
             this.Hp = 0;
        }
        return IsAlive;     
    }

    public override string ToString() => $"Имя: {Name}. Хп: {Hp}. Урон: {Damage}";

    public virtual void Attack(Character character)
    {  
    }

}