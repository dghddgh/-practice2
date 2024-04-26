using System; 
 
public class Numbers 
{ 
    private int number1 { get; set; } 
    private int number2 { get; set; }
 
    public Numbers(int num1, int num2) 
    { 
        number1 = num1; 
        number2 = num2; 
    } 
 
    public void DisplayNumbers() 
    { 
        Console.WriteLine($"Число 1: {number1}"); 
        Console.WriteLine($"Число 2: {number2}"); 
    } 
 
    public int Sum() 
    { 
        return number1 + number2; 
    } 
 
    public int Max() 
    { 
        return Math.Max(number1, number2); 
    } 
} 
 
public class Program 
{ 
    public static void Main(string[] args) 
    {
        Numbers numbers = new Numbers(7868546, 7508787);
        numbers.DisplayNumbers();
        Console.WriteLine($"Сумма чисел: {numbers.Sum()}");
        Console.WriteLine($"Наибольшее значение: {numbers.Max()}"); 
    } 
}
