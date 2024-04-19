using System;

namespace Number_2._2
{
    class Train
    {
        public string Destination;
        public int TrainNumber;
        public DateTime DepartureTime;
        public void Information(int Input)
        {
            if (Input == TrainNumber)
            {
                Console.WriteLine($"Номер поезда №  {TrainNumber}");
                Console.WriteLine($"Город прибытия: {Destination}");
                Console.WriteLine($"Время отправления: {DepartureTime}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Train train1 = new Train();
            train1.Destination = "Сухум";
            train1.TrainNumber = 306;
            train1.DepartureTime = new DateTime(2024, 6, 15, 02, 0, 0);

            Train train2 = new Train();
            train2.Destination = "Сухум";
            train2.TrainNumber = 479;
            train2.DepartureTime = new DateTime(2024, 7, 9, 08, 30, 0);
        
            Train train3 = new Train();
            train2.Destination = "Гагра";
            train2.TrainNumber = 927;
            train2.DepartureTime = new DateTime(2024, 7, 5, 11, 45, 0);
        
            Console.WriteLine("Информация по вашему поезду:");
            int userInput = int.Parse(Console.ReadLine());
            train1.Information(userInput);
            train2.Information(userInput);
            train3.Information(userInput);
            Console.WriteLine("Хорошей поездки ;)");
        }
    }

}