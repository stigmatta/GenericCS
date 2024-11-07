using Generic;

Oceanarium<Fish> aquarium = new Oceanarium<Fish>(5);
aquarium.PrintCreatures();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Oceanarium<Shark> sharkarium = new Oceanarium<Shark>(5);
sharkarium.PrintCreatures();


TeamIterator<Barcelona> teamIterator = new TeamIterator<Barcelona>();
teamIterator.PrintTeam();

Cafe cafe = new Cafe(new CafeEmployee[]
    {
        new Waiter(1, "John Doe"),
        new Barista(2, "Jane Smith"),
        new Cook(3, "Paul Brown")
    }); 

CafeIterator<Cafe> iterator = new CafeIterator<Cafe>(cafe);
iterator.PrintCafeInfo();


