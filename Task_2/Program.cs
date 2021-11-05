using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется:  Описать структуру  с  именем  Train, содержащую  следующие  поля:  название пункта 
//назначения, номер поезда, время отправления. 
//Написать программу, выполняющую следующие действия: 
//  ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны 
//быть упорядочены по номерам поездов); 
//  вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет,
//вывести соответствующее сообщение). 


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string underline = new string('-', 50);
            Train [] trains = new Train[Methods.HowMany()];

            Methods.InputData(trains);

            Methods.SortTrains(trains);
            Console.WriteLine("Итоговая информация о поездах: \n" + underline);
            Methods.ShowData(trains);
            Console.WriteLine(underline);

            Console.Write("Введите номер поезда: ");
            Methods.SearchTrain(trains, Console.ReadLine());

            Console.ReadKey();

        }
    }
}
