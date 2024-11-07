
using System.Collections;
using System.Runtime.CompilerServices;

namespace Generic
{
    public class Footballer
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Number { get; set; }
        public Footballer(string name, string position, int number) {
            Name = name;
            Position = position;
            Number = number;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}\nPosition:{Position}\nNumber:{Number}");
        }

    }

    public abstract class FootballTeam : IEnumerable
    {
        private static Footballer[] team = new Footballer[11];
        private static int index;
        public FootballTeam(Footballer[] arr)
        {
            if (arr.Length == 11)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    team[i] = arr[i];
                }
            }
        }


        public IEnumerator GetEnumerator()
        {
            foreach (Footballer item in team)
            {
                yield return item;
            }
        }

    }

    public class Barcelona : FootballTeam
    {
        private static Footballer[] team =
        {
            new Footballer("Lionel Messi", "Forward", 10),
            new Footballer("Sergio Busquets", "Midfielder", 5),
            new Footballer("Gerard Piqué", "Defender", 3),
            new Footballer("Marc-André ter Stegen", "Goalkeeper", 1),
            new Footballer("Ansu Fati", "Forward", 22),
            new Footballer("Jordi Alba", "Left-back", 18),
            new Footballer("Frenkie de Jong", "Midfielder", 21),
            new Footballer("Robert Lewandowski", "Striker", 9),
            new Footballer("Pedri", "Midfielder", 16),
            new Footballer("Sergi Roberto", "Midfielder", 20),
            new Footballer("Clement Lenglet", "Defender", 15)
        };

        public Barcelona() : base(team)
        {
        }
    }


    public class TeamIterator<T> where T : FootballTeam, new()
    {
        public void PrintTeam()
        {
            T teamInstance = new T();  
            foreach (Footballer player in teamInstance)
            {
                player.PrintInfo(); 
            }
        }
    }
}
