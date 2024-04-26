using System;
class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Rate { get; set; }
    public int days { get; set; }
    public void GetSalary(int Rate, int days)
    {
        return Rate * days;
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
        
        double zp = Worker.GetSalary();
        Console.WriteLine($"Зарплата работника {Worker.Name} {Worker.Surname}: {zp}");
    }
}
