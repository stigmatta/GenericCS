using System;
using System.Collections;

namespace Generic
{
    public abstract class CafeEmployee
    {
        protected int Id { get; set; }
        protected string Position { get; set; }
        protected string Name { get; set; }

        public CafeEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\nName: {Name}\nPosition: {Position}\n");
        }
    }

    public class Waiter : CafeEmployee
    {
        private static string staticPosition = "Waiter";

        public Waiter(int id, string name) : base(id, name)
        {
            Position = staticPosition;
        }
    }

    public class Barista : CafeEmployee
    {
        private static string staticPosition = "Barista";

        public Barista(int id, string name) : base(id, name)
        {
            Position = staticPosition;
        }
    }

    public class Cook : CafeEmployee
    {
        private static string staticPosition = "Cook";

        public Cook(int id, string name) : base(id, name)
        {
            Position = staticPosition;
        }
    }

    public class Cafe : IEnumerable<CafeEmployee>
    {
        private CafeEmployee[] employees;

        public Cafe(CafeEmployee[] arr)
        {
            employees = arr;
        }

        public IEnumerator<CafeEmployee> GetEnumerator()
        {
            foreach (var item in employees)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CafeIterator<T> where T : Cafe
    {
        private readonly T cafe;

        public CafeIterator(T cafe)
        {
            this.cafe = cafe;
        }

        public void PrintCafeInfo()
        {
            foreach (var employee in cafe)
            {
                employee.PrintInfo();
            }
        }
    }

}
