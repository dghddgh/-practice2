using System;

namespace Number_3._3
{
    class Calculation
    {
        public string CalculationLine;
        public void SetCalculationLine(string line)//изменяет значение
        {
            CalculationLine = line;
        }
        public void SetLastSymbolCalculationLine(char symbol)//прибавление символа
        {
            CalculationLine += symbol;
        }
        public string GetCalculationLine()//вывод значения 
        {
            return CalculationLine;
        }
        public char GetLastSymbol()//получаем последний символ
        {
            return CalculationLine[CalculationLine.Length - 1];
        }

        public void DeleteLastSymbol()//удаление последенего символа
        {
            if (!string.IsNullOrEmpty(CalculationLine))
            {
                CalculationLine = CalculationLine.Substring(0, CalculationLine.Length - 1);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
        
            calculation.SetCalculationLine("100500 * 8 800 777 35 = ");
            Console.WriteLine("Начальная строка : " + calculation.GetCalculationLine());
            
            calculation.SetLastSymbolCalculationLine('0');
            Console.WriteLine("После добавления последнего символа: " + calculation.GetCalculationLine());
        
            Console.WriteLine("Последний символ: " + calculation.GetLastSymbol());
        
            calculation.DeleteLastSymbol();
            Console.WriteLine("После удаления последнего символа: " + calculation.GetCalculationLine());
        }
    }

}