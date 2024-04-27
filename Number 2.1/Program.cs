using System;

namespace Number_2._1
{
    class Student
    {
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GroupNumber { get; set; }
        public int Performance { get; set; }

        public void lastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void dateOfBirth(DateTime newDateOfBirth)
        {
            DateOfBirth = newDateOfBirth;
        }

        public void performance(int[] newPerformance)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += newPerformance[i];
            }
            int result = sum / 5;
            Performance = result;
            
        }
        public void groupNumber(string newGroupNumber)
        {
            GroupNumber = newGroupNumber;
        }

        public void Information()
        {
            Console.WriteLine($"Фамилия студента: {LastName}, Дата рождения: {DateOfBirth}, Номер группы: {GroupNumber}, Средний балл студента: {Performance}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student();

            Console.WriteLine("Введите фамилию студента:");
            string newLastName = Console.ReadLine();
            student.lastName(newLastName);
            
            Console.WriteLine("Введите дату рождения студента в формате ГГГГ-ММ-ДД:");
            DateTime newDateOfBirth = DateTime.Parse(Console.ReadLine());
            student.dateOfBirth(newDateOfBirth);
            
            Console.WriteLine("Введите номер группы студента:");
            string newGroupNumber = Console.ReadLine();
            student.groupNumber(newGroupNumber);
            
            Console.WriteLine("Введите оценки студента(кол-во 5):");

            int[] newPerformance = new int [5];
            for (int i = 0; i < 5; i++)
            {
                newPerformance[i] = int.Parse(Console.ReadLine());
            }
            student.performance(newPerformance);

            student.Information();
        }
    }
}
