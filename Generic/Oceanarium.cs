
namespace Generic
{
    public abstract class OceanLiving
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public OceanLiving(KeyValuePair<string, string>[] array,ref int index)
        {
            if (array != null)
            {
                if (index >= array.Length)
                    index = 0;

                Name = array[index].Key;
                Description = array[index++].Value;
            }
            else
            {
                throw new InvalidOperationException("Array is not initialized.");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The Name of this creature is {Name}");
            Console.WriteLine($"Description: {Description}");
        }
    }

    public class Fish : OceanLiving
    {
        private static int index = 0;
        protected static new KeyValuePair<string, string>[] array = new KeyValuePair<string, string>[]
        {
            new KeyValuePair<string, string>("Goldfish", "Goldfish are small, brightly colored fish commonly kept in aquariums."),
            new KeyValuePair<string, string>("Salmon", "Salmon are anadromous fish known for their migrations from freshwater to saltwater."),
            new KeyValuePair<string, string>("Clownfish", "Clownfish are small, colorful fish known for their symbiotic relationship with sea anemones."),
            new KeyValuePair<string, string>("Tuna", "Tuna are large predatory fish, known for their speed and strength in the open ocean."),
        };

        public Fish() : base(array,ref index) { }
    }

    public class Shark:OceanLiving
    {
        private static int index = 0;
        protected static KeyValuePair<string, string>[] array = new KeyValuePair<string, string>[]
        {
            new KeyValuePair<string, string>("Great White Shark", "The Great White Shark is a large predatory shark found in coastal surface waters. Known for its size and power."),
            new KeyValuePair<string, string>("Hammerhead Shark", "Hammerhead sharks are easily recognized by their wide, flattened heads, which enhance their sensory capabilities."),
            new KeyValuePair<string, string>("Tiger Shark", "Tiger Sharks are large, predatory sharks known for their distinctive tiger-like stripes and diverse diet."),
            new KeyValuePair<string, string>("Whale Shark", "The Whale Shark is the largest known species of fish, known for its gentle nature and filter feeding on plankton."),
            new KeyValuePair<string, string>("Bull Shark", "Bull Sharks are aggressive and can live in both saltwater and freshwater environments, often found in shallow coastal waters.")
        };

        public Shark():base(array,ref index) { }
    }

     public class Oceanarium<T> where T : OceanLiving, new()
     {
        private T[] arr;

        public Oceanarium(int size)
        {
            arr = new T[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new T(); 
            }
        }

        public void PrintCreatures()
        {
            foreach (var creature in arr)
            {
                creature.PrintInfo();
            }
        }
     }



}
