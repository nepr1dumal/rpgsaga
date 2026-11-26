class Wizard : Hero, ISpellCaster
{

    public int MaxMana {get; private set;}
    public int Mana {get; private set;}
    private List<Spell> Spells { get; } = new();
    public Wizard(string name) : base(100, name, 15, 0.05)
    {
        MaxMana = 100;
        Mana = 100;
        Spells.Add(new Spell("Magic Arrow", 30, 20));
        Spells.Add(new Spell("FireBall", 50, 40));
        Spells.Add(new Spell("Sun Strike", 75, 65));
    }

    public override void Attack(Hero target)
    {
        while (true)
        {
        Mana = Math.Min(Mana + 20, MaxMana);
        Spell? spell = SelectSpell();
        if (spell == null)
        {
            base.Attack(target);
            return;
        }
        else
        {
            if (CastSpell(spell, target))
            {
                return;
            }
        }
        }
    }

    private Spell? SelectSpell()
    {
        List<Spell> availableSpells = new();
        foreach (Spell spell in Spells)
        {
            if (Mana >= spell.Cost)
            {
            availableSpells.Add(spell);
            }
        }
        int chance = Random.Shared.Next(availableSpells.Count + 1);
        if (chance == availableSpells.Count)
        {
            return null;
        }
        else
        {
            return availableSpells[chance];
        }
    }

    public bool CastSpell(Spell spell, Hero target)
    {
        if (Mana >= spell.Cost && Spells.Contains(spell))
        {
            target.TakeDamage(spell.Damage);
            Mana -= spell.Cost;
            return true;
        }
        return false;
    }

    public override void Refresh()
    {
        base.Refresh();
        Mana = MaxMana;
    }
}