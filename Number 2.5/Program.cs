using System;

namespace Number_2._5
{
   
        class Class
        {
            private int property1;
            private string property2;

            public Class(int value1, string value2)
            {
                property1 = value1;
                property2 = value2;
            }

            public Class() : this(0, "по умолчанию")
            {
            }

            ~Class()
            {
                Console.WriteLine("Обьект удален.-_-");
            }

            public void DisplayProperties()
            {
                Console.WriteLine($" 1: {property1}");
                Console.WriteLine($" 2: {property2}");
            }
        }

        class Program
        {
            static void Main()
            {
                Class obj1 = new Class(10, "спаать");
                Console.WriteLine("обьект первый:");
                obj1.DisplayProperties();

                Class obj2 = new Class();
                Console.WriteLine("\\n обьект второй:");
                obj2.DisplayProperties();
                Console.WriteLine("Хорошего времени суток ^_^  ");
            }
        }
    
}