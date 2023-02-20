namespace Builder
{
    // Директор будівельника
    public class BuildingDirector
    {
        private BuildingBuilder buildingBuilder;

        public BuildingDirector(BuildingBuilder buildingBuilder)
        {
            this.buildingBuilder = buildingBuilder;
        }

        public void ConstructBuilding()
        {
            buildingBuilder.CreateNewBuilding();
            buildingBuilder.SetFloors();
            buildingBuilder.SetConfiguration();
            buildingBuilder.SetArea();
        }
    }
}
