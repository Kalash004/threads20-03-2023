using System.Collections.Concurrent;

namespace threads20_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1)  
            //Console.WriteLine("Hello, World!");
            //Citac cit1 = new Citac();
            //int AMOUNT_OF_ITERATTIONS = 1000000;

            //Thread threadAdding = new Thread(new ThreadStart(() => AddUp(cit1,AMOUNT_OF_ITERATTIONS)));
            //Thread threadDecreasing = new Thread(new ThreadStart(() => Decrease(cit1, AMOUNT_OF_ITERATTIONS)));
            //threadAdding.Start();
            //threadDecreasing.Start();
            //threadAdding.Join();
            //threadDecreasing.Join();
            //Console.WriteLine(cit1.Hodnota);


            // 2)
            //List<int> list = new List<int>();
            int ITERATION = 1000000;

            //Thread generateMil1 = new Thread(new ThreadStart(() => GenerateNumbers(list,ITERATION)));
            //Thread generateMil2 = new Thread(new ThreadStart(() => GenerateNumbers(list, ITERATION)));
            //generateMil1.Start();
            //generateMil2.Start();
            //generateMil1.Join();
            //generateMil2.Join();
            //Console.WriteLine(list.Count);


            // 3)

            //ConcurrentBag<int> bag = new ConcurrentBag<int>();
            //Thread bagAdding1 = new Thread(new ThreadStart(() => AddToConcurrentBagConcurrently(bag,ITERATION)));
            //Thread bagAdding2 = new Thread(new ThreadStart(() => AddToConcurrentBagConcurrently(bag, ITERATION)));
            //bagAdding1.Start();
            //bagAdding2.Start();
            //bagAdding1.Join();
            //bagAdding2.Join();
            //Console.Write(bag.Count);

            // 4)


        }



        public static void AddUp(Citac cit, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cit.Zvys();
            }
        }

        public static void Decrease(Citac cit, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                cit.Sniz();
            }
        }
   
        public static void AddGeneratedNumbersToList(List<int> list, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                list.Add(new Random().Next());
            }
        }

        public static ConcurrentBag<int> AddToConcurrentBagConcurrently(ConcurrentBag<int> bag ,int iterations)
        {
            Parallel.For(0, iterations, i =>
            {
                bag.Add(new Random().Next());
            });

            return bag;
        }
    }
}