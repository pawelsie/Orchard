using System;

namespace Orchard.Domain
{
    public class PlantInOrchard
    {
        public DateTime PlantingDate { get; }
        public PlantId PlantId { get; }
        public AreaId AreaId { get; }
        public PlantInOrchardId PlantInOrchardId { get; }

        public PlantInOrchard(PlantInOrchardId plantInOrchardId, AreaId areaId, PlantId plantId, DateTime plantingDate)
        {
            PlantingDate = plantingDate;
            PlantInOrchardId = plantInOrchardId;
            AreaId = areaId;
            PlantId = plantId;
        }





    }
}