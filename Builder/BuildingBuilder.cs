namespace Builder
{
    // Абстрактний будівельник
    public abstract class BuildingBuilder
    {
        protected Building building;

        public Building GetBuilding()
        {
            return building;
        }

        public void CreateNewBuilding()
        {
            building = new Building();
        }

        public abstract void SetFloors();
        public abstract void SetConfiguration();
        public abstract void SetArea();
    }
}
