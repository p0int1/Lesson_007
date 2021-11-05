using System;
//Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
//В классе Program  создайте два  метода:  
//-  static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра 
//myClass значение «изменено». 
//-  static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра 
//myStruct значение «изменено». 
//Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
//структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы 
//ClassTaker  и  StruktTaker.  Выведите  на  экран  значения  полей  экземпляров.  Проанализируйте 
//полученные результаты. 

namespace Task_3
{
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            ClassTaker(myClass);
            StructTaker(myStruct);

            // Классы ссылочные, поэтому меняется значение поля экземпляра
            // В структуре стековый тип значений, параметр передается по значению
            // и создается копия структуры в области видимости метода
            // Если использовать ref аргумент - будет поведение как у экземпляра класса
            Console.WriteLine("myClass.change = {0}", myClass.change);
            Console.WriteLine("myStruct.change = {0}", myStruct.change);

            Console.ReadKey();
        }
    }
}
