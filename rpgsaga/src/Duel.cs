class Duel
{
    public Hero First { get; private set; }
    public Hero Second { get; private set; }
    public Duel(Hero first, Hero second)
    {
        First = first;
        Second = second;
    }

    public Hero? Fight()
    {
        if (First.IsAlive() && Second.IsAlive())
        {
            while (First.IsAlive() && Second.IsAlive())
            {
                switch (Random.Shared.Next(2))
                {
                    case 0:
                    First.Attack(Second);
                    if (Second.IsAlive())
                        {
                            Second.Attack(First);
                        }
                    break;
                    case 1:
                    Second.Attack(First);
                    if (First.IsAlive())
                        {
                            First.Attack(Second);
                        }
                    break;
                }
            }
            if (First.IsAlive())
            {
                return First;
            }
            else
            {
                return Second;
            }
        } else if (First.IsAlive())
        {
            return First;
        } else if (Second.IsAlive())
        {
            return Second;
        } else
        {
            return null;
        }
    }
}