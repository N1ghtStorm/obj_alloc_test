using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace MapAllocCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var elems_num = 20000000;
            //var girls = new List<Girl>() { Capacity = elems_num };
            var girls = new List<Girl>();
            //var boys = new List<Boy>() { Capacity = elems_num };
            var boys = new List<Boy>();
            ////var girls = new Girl[elems_num];
            //var boys = new Boy[elems_num];
            //Console.ReadKey();
            var sw1 = new Stopwatch();
            var sw2 = new Stopwatch();

            sw1.Start();
            for (int i = 0; i < elems_num; i++)
            {
                girls.Add(new Girl { Age = i });
            }
            sw1.Stop();

            sw2.Start();
            for (int i = 0; i < elems_num; i++)
            {
                boys.Add(new Boy { Age = i });
            }
            sw2.Stop();

            var girls_ages = new int[elems_num];
            var boys_ages = new int[elems_num];

            var swg = new Stopwatch();
            var swb = new Stopwatch();

            swg.Start();
            for (int i = 0; i < elems_num; i++)
            {
                girls_ages[i] = girls[i].Age;
            }
            swg.Stop();

            swb.Start();
            for (int i = 0; i < elems_num; i++)
            {
                boys_ages[i] = boys[i].Age;
            }
            swb.Stop();

            Console.WriteLine($"Girls Add: {sw1.ElapsedMilliseconds}");
            Console.WriteLine($"Boys Add: {sw2.ElapsedMilliseconds}");
            Console.WriteLine($"Girls: {swg.ElapsedMilliseconds}");
            Console.WriteLine($"Boys: {swb.ElapsedMilliseconds}");
            Console.ReadKey();
        }
    }

    struct Girl
    {
        public int Age;
        public int F1;
        public int F2;
        public int F3;
        public int F4;
    }
    class Boy
    {
        public int Age;
        public int F1;
        public int F2;
        public int F3;
        public int F4;
    }
}
