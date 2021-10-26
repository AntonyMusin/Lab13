using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("улица Мира", 20, 15, 10);
            building.Print();
            Console.ReadKey();
            Console.WriteLine();
            MultiBuilding multiBuilding = new MultiBuilding("улица Победы", 20, 10, 30,10);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string address { get; set; }
        double length;
        public double Length// Проверка на положительность и условие !=0.
        {
            set
            {
                if (value>0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное значение длины здания и больше чем 0");
                }
            }
            get
            { return length; }
        }
        public double width;
        public double Width// Проверка на положительность и условие !=0.
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное значение ширины здания и больше чем 0");
                }
            }
            get
            { return width; }
        }
        public double height;
        public double Height// Проверка на положительность и условие !=0.
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное значение высоты здания и больше чем 0");
                }
            }
            get
            { return height; }
        }
        public Building (string a, double b, double c, double d)
        {
            address = a;
            Length= b;
            Width = c;
            Height = d;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Длина здания: {length} м");
            Console.WriteLine($"Ширина здания: {Width} м");
            Console.WriteLine($"Высота здания: {Height} м");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int storey;
        public int Storey
        {
            set
            {
                if (value >= 1)
                {
                    storey = value;
                }
                else
                {
                    Console.WriteLine("Количество этажей здания не может быть отрицательным числом или 0!");
                }
            }
            get
            { return storey; }
        }

        public MultiBuilding(string a, double b, double c, double d, int e)
            : base(a, b, c, d)
        {
            Storey = e;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей: {storey}");
        }

    }
}
