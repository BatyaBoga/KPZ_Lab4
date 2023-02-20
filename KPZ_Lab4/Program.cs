using Builder;

namespace KPZ_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо будівельника та директора будівництва
            BuildingBuilder buildingBuilder = new MultiStoreyBuildingBuilder();
            BuildingDirector buildingDirector = new BuildingDirector(buildingBuilder);

            // Будуємо будівлю
            buildingDirector.ConstructBuilding();
            Building building = buildingBuilder.GetBuilding();
            building.PrintBuildingInfo();

            Console.ReadLine();
        }
    }
}