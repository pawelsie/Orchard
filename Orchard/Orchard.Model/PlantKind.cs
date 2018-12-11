namespace Orchard.Domain
{
    public class PlantKind
    {
        public PlantKindId KindId { get; }

        public PlantKind(PlantKindId plantKindId)
        {
            KindId = plantKindId;
        }
    }
}