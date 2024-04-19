using System;

namespace Number_3._2
{
    class Worker
    {
        private string Name1;
        private string Surname1;
        private int Rate1;
        private int days1;

        public string Name
        {
            get { return Name1;}
            set { Name1 = value; }
        }
        public string Surname
        {
            get { return Surname1;}
            set { Surname1 = value; }
        }
        public int Rate
        {
            get { return Rate1;}
            set { Rate1 = value; }
        }
        public int days
        {
            get { return days1;}
            set { days1 = value; }
        }
        public void GetSalary()
        {
            int zp = Rate * days;
            Console.WriteLine($" {zp} рублей");
        }
    }
    class Program
    {
        static void Main()
        {
        
            Worker worker1 = new Worker();
            worker1.Name = "Моника";
            worker1.Surname = "Родригес";
            worker1.Rate = 20080;
            worker1.days = 22;
        
            Worker worker2 = new Worker();
            worker2.Name = "Элайджа";
            worker2.Surname = "Фицджеральд";
            worker2.Rate = 19035;
            worker2.days = 18;
        
            Worker worker3 = new Worker();
            worker3.Name = "Логан";
            worker3.Surname = "Ямамото";
            worker3.Rate = 21000;
            worker3.days = 25;
        
            Worker worker4 = new Worker();
            worker4.Name = "Риана";
            worker4.Surname = "Беранже";
            worker4.Rate = 19040;
            worker4.days = 20;
        
            Console.Write($"Зарплата работника {worker1.Name} {worker1.Surname}: ");
            worker1.GetSalary();
            Console.Write($"Зарплата работника {worker2.Name} {worker2.Surname}: ");
            worker2.GetSalary();
            Console.Write($"Зарплата работника {worker3.Name} {worker3.Surname}: ");
            worker3.GetSalary();
            Console.Write($"Зарплата работника {worker4.Name} {worker4.Surname}: ");
            worker4.GetSalary();

        }
    }

}