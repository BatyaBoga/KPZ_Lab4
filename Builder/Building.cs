using System;

namespace Builder
{
    // Клас, що описує будівлю
    public class Building
    {
        public int Floors { get; set; }
        public string Configuration { get; set; }
        public double Area { get; set; }

        public void PrintBuildingInfo()
        {
            Console.WriteLine("Будівля з {0} поверхами та конфігурацією {1} має площу {2} кв. м.", Floors, Configuration, Area);
        }
    }
}
