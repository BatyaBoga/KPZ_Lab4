namespace Builder
{
    // Конкретний будівельник для будівництва багатоповерхового будинку
    public class MultiStoreyBuildingBuilder : BuildingBuilder
    {
        public override void SetFloors()
        {
            building.Floors = 5;
        }

        public override void SetConfiguration()
        {
            building.Configuration = "rectangular";
        }

        public override void SetArea()
        {
            building.Area = 500;
        }
    }

}
