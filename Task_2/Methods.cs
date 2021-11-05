using System;

namespace Task_2
{
    public static class Methods
    {
        public static int HowMany() // метод выбора количества поездов
        {
            Console.Write("Сколько поездов добавляем?: ");
            string number = Console.ReadLine();
            int how = Convert.ToInt32(number);
            return how;
        }

        public static void InputData(Train[] trains) // ввод данных пользователем
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите пункт назначения: ");
                string destination = Console.ReadLine();

                Console.Write("Введите номер поезда: ");
                string number = Console.ReadLine();
                //int n = Convert.ToInt32(number);
                int.TryParse(number, out int n);

                Console.Write("Введите время отправления: ");
                string time = Console.ReadLine();

                Console.WriteLine(""); // пустая строка между поездами

                trains[i] = new Train(destination, n, time);
            }
        }

        public static void SortTrains(Train[] trains) // сортировка по номеру поезда
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train tmp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = tmp;
                    }
                }
            }
        }

        public static void ShowData(Train[] trains) // вывод данных массива поездов
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Номер поезда: {trains[i].Number}" +
                    $", пункт назначения: {trains[i].Destination}" +
                    $", время отправления: {trains[i].Time}");
            }
        }

        public static void SearchTrain(Train[] trains, string number) // поиск по номеру
        {
            bool isFound = false;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number.ToString() == number)
                {
                    isFound = true;
                    Console.WriteLine($"Номер поезда: {trains[i].Number}" +
                        $", пункт назначения: {trains[i].Destination}" +
                        $", время отправления: {trains[i].Time}");
                }
            }
            if (!isFound)
                Console.WriteLine("Такой поезд не найден");
        }
    }
}
