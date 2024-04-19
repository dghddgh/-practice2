using System;

namespace Number_2._4
{
    class Counter
    {
        private int value;
        public Counter()
        {
            value = 0;
        }
        public Counter(int startValue)
        {
            value = startValue;
        }
        public void Increment()
        {
            value++;
        }
        public void Decrement()
        {
            value--;
        }
        public int Value
        {
            get { return value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Counter counter1 = new Counter();
            Console.WriteLine($"Начальное значение: {counter1.Value}");

            counter1.Increment();
            counter1.Increment();
            Console.WriteLine($"Значение первое: {counter1.Value}");

            counter1.Decrement();
            Console.WriteLine($"Значение первое после уменьшения: {counter1.Value}");

            Counter counter2 = new Counter(10);
            Console.WriteLine($"\nНачальное значение второе: {counter2.Value}");

            counter2.Increment();
            Console.WriteLine($"Значение второе: {counter2.Value}");

            counter2.Decrement();
            counter2.Decrement();
            Console.WriteLine($"Значение второе после уменьшения: {counter2.Value}");
            Console.WriteLine("Были рады вам помочь .^_^.  ");

        }
    }

}