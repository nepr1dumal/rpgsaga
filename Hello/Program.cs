class Program {

    static void Main(string[] args) {
        Mage character1 = new("Пистолетов", 100, 23);
        Warrior character2 = new("Чудовище морское", 92, 24);
        int round = 1;
        Random randoms = new();
        while (character1.IsAlive && character2.IsAlive)
        {
            int random = randoms.Next(1,3);
            if (random == 1)
            {
                VersusBattle(character1, character2);
            } else
            {
                VersusBattle(character2, character1);
            }
            Console.WriteLine($"Раунд {round}:\n{character1}\n{character2}");
            round++;
        }
        Console.WriteLine($"Итог:\n{character1}\n{character2}");
    }

    private static void VersusBattle(Character first, Character second)
    {
        second.Attack(first);
        if (first.IsAlive)
        {
            first.Attack(second);
            if (!second.IsAlive) {
                Console.WriteLine($"{second.Name} побежден!");
            }
        } else
        {
            Console.WriteLine($"{first.Name} побежден!");
        }
    }

}