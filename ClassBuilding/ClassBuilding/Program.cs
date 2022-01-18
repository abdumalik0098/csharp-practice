using System;

namespace ClassBuilding
{

    class Building
    {
        public int Floors; // количество этажей
        public int Area; // общая площадь здания
        public int Occupants; // количество жильцов
                              // Параметризированный конструктор для класса Building.
        public Building(int fl, int ar, int ocp)
        {
            Floors = fl;
            Area = ar;
            Occupants = ocp;
        }
        // Возвратить площадь на одного человека.
        public int AreaPerPerson()
        {
            return Area / Occupants;
        }
        // Возвратить максимальное количество человек, занимающих здание,
        // исходя из заданной минимальной площади на одного человека.
        public int MaxOccupant(int minArea)
        {
            return Area / minArea;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);
            Console.WriteLine("Максимальное количество человек в доме, \n" + house.MaxOccupant(300));
            Console.WriteLine("Максимальное количество человек " + "в учреждении, \n" + office.MaxOccupant(300));
        }
    }
}
