using System;
namespace Number_1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите J через пробел: ");
            string J = Console.ReadLine();
            Console.WriteLine("Введите S через пробел ");
            string S = Console.ReadLine();
            int count = 0;
            string[] subs = J.Split(' ');
            string[] stons = S.Split(' ');
            for (int i = 0; i < stons.Length; i++)
            {
                for (int j = 0; j < subs.Length; j++)
                {
                    if (stons[i] == subs[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Столько драгоценных камушков вышло ");
            Console.WriteLine(count);
            Console.WriteLine("Ну а вообще все камни хороши ");

        }
    }
}