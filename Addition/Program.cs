using System;
//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Создайте структуру с именем - Notebook. 
//Поля структуры: модель, производитель, цена.
//В структуре должен быть реализован конструктор для инициализации полей и метод для вывода 
//содержимого полей на экран. 

namespace Addition
{
    struct Notebook
    {
        readonly string model;
        readonly string creator;
        readonly double price;

        public Notebook(string model, string creator, double price)
        {
            this.model = model;
            this.creator = creator;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Модель {model}, производитель {creator}, стоимость {price}");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook_1 = new Notebook("15IMH05", "Lenovo", 23499);
            notebook_1.Show();

            Notebook notebook_2 = new Notebook("A315-56", "Aspire", 15555);
            notebook_2.Show();

            Notebook notebook_3 = new Notebook("X409FA", "Asus", 13999);
            notebook_3.Show();

            Notebook notebook_4 = new Notebook("MK183", "Apple", 87999);
            notebook_4.Show();

            Notebook notebook_5 = new Notebook("2X7V7EA", "HP", 19499);
            notebook_5.Show();


            Console.ReadKey();
        }
    }
}
