class Round
{

    public List<Hero> Heroes {get; private set;} = new();
    public List<Duel> Duels {get; private set;} = new();
    public List<Hero> Winners {get; private set;} = new();
    public bool Finish {get; private set;}

    public Round(List<Hero> heroes)
    {
        Heroes = new List<Hero>(heroes);
        Duels = MakeListOfDuels();
        Finish = false;
    }
    
    private List<Duel> MakeListOfDuels()
    {
        List<Hero> availableHeroes = new(Heroes);
        List<Duel> duels = new();
        while (availableHeroes.Count > 0)
        {
        if (availableHeroes.Count == 1)
        {
            Winners.Add(availableHeroes[0]);
            Console.WriteLine($"Для бойца {availableHeroes[0].Name} не найдено пары, он автоматически проходит дальше.");
            availableHeroes.RemoveAt(0);
            break;
        }    
            int index1 = Random.Shared.Next(availableHeroes.Count);
        Hero first = availableHeroes[index1];
        availableHeroes.RemoveAt(index1);
        
        int index2 = Random.Shared.Next(availableHeroes.Count);
        Hero second = availableHeroes[index2];
        availableHeroes.RemoveAt(index2);

        duels.Add(new Duel(first, second));
        }
        Console.WriteLine($"Создано {duels.Count} дуэлей");
        return duels;
    }

    public List<Hero> Play()
    {
        if (!Finish)
        {
            if (Duels.Count != 0)
            {
                foreach (Duel duel in Duels)
                {
                Hero? winner = duel.Fight();
                if (winner != null)
                {
                Winners.Add(winner);
                } else
                {
                Console.WriteLine("Оба героя мертвы, ошибочная дуэль");
                }
                }
            }
        }
        Finish = true;
        return Winners;
    }
}