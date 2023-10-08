namespace z3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите шкалу вводимой температуры:\r\n" +
                "1. Цельсий\r\n" +
                "2. Кельвин\r\n" +
                "3. Фаренгейт");
            string tip1 = Console.ReadLine();

            if (tip1 != "1" & tip1 != "2" & tip1 != "3")
            {
                Console.WriteLine("Ошибка, перезапустите программу.");
            }
            else
            {
                Console.WriteLine("Введите показатель температура (градусы):");
                double temp1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите тип шкалы для конвертации:\r\n" +
                    "1. Цельсий\r\n" +
                    "2. Кельвин\r\n" +
                    "3. Фаренгейт");
                string tip2 = Console.ReadLine();
                double temp2 = 0;
                if (tip1 == "1")
                {
                    if (tip2 == "1")
                    {
                        temp2 = temp1;
                        Console.WriteLine("Вы выбрали: Цельсий->Цельсий\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "2")
                    {
                        temp2 = temp1 + 273;
                        Console.WriteLine("Вы выбрали: Цельсий->Кельвин\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "3")
                    {
                        temp2 = temp1 * 1.8 + 32;
                        Console.WriteLine("Вы выбрали: Цельсий->Фаренгейт\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, перезапустите программу.");
                    }
                }
                if (tip1 == "2")
                {
                    if (tip2 == "1")
                    {
                        temp2 = temp1 - 273;
                        Console.WriteLine("Вы выбрали: Кельвин->Цельсий\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "2")
                    {
                        temp2 = temp1;
                        Console.WriteLine("Вы выбрали: Кельвин->Кельвин\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "3")
                    {
                        temp2 = temp1 * 1.8 - 459;
                        Console.WriteLine("Вы выбрали: Кельвин->Фаренгейт\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, перезапустите программу.");
                    }
                }
                if (tip1 == "3")
                {
                    if (tip2 == "1")
                    {
                        temp2 = (temp1 - 32) / 1.8;
                        Console.WriteLine("Вы выбрали: Фаренгейт->Цельсий\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "2")
                    {
                        temp2 = (temp1 + 459) / 1.8;
                        Console.WriteLine("Вы выбрали: Фаренгейт->Кельвин\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else if (tip2 == "3")
                    {
                        temp2 = temp1;
                        Console.WriteLine("Вы выбрали: Фаренгейт->Фаренгейт\r\n" +
                            "Результат конвертации: " + (temp2));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, перезапустите программу.");
                    }
                }
            }
            
        }
    }
}