namespace Orchard.Domain
{
    public abstract class AggregateId
    {
        public int Id { get; }

        protected bool Equals(AggregateId other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((AggregateId) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        protected AggregateId(int id)
        {
            Id = id;
        }
    }
}