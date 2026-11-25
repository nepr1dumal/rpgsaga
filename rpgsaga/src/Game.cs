class Game
{

    public List<Hero> HeroesAvailable {get; private set;} = new List<Hero>();
    public void Run()
    {
        Console.WriteLine("RPGSaga succecfully started!");
        Populate();
        int number = 1;
        while (HeroesAvailable.Count > 1)
        {
        Console.WriteLine($"===== Раунд {number} =====\nВошло на ринг: {HeroesAvailable.Count}");
        Round round = new(HeroesAvailable);
        List<Hero> winners = round.Play();
        HeroesAvailable = winners;
        number++;
        if (HeroesAvailable.Count > 1)
            {
                Console.WriteLine($"В следующий раунд прошли: {HeroesAvailable.Count}");
            }
        }
        if (HeroesAvailable.Count == 1)
        {
            Console.WriteLine($"Турнир успешно завершен!\nПобедитель: {HeroesAvailable[0].Name}!");
        }
        else if (HeroesAvailable.Count == 0)
        {
            Console.WriteLine($"Все герои сражались стойко и погибли доказав свою упертость и силу воли. Победителей нет.");
        }
    }

    private void Populate()
    {
        for (int i = 0; i < 15; i++)
        {
            HeroesAvailable.Add(new TestHero(100, 100, "Bot", 20));
        }
        Console.WriteLine($"Успешно создано героев: {HeroesAvailable.Count}");
    }
}