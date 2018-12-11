namespace Orchard.Domain.Helpers
{
    public class Result<T> : Result
    {
        private T _value;

        public T Value
        {
            get
            {
               // Contracts.Require(Success);

                return _value;
            }
           // [param: AllowNull]
            private set { _value = value; }
        }

        protected internal Result(//[AllowNull]
            T value, bool success, string error)
            : base(success, error)
        {
           // Contracts.Require(value != null || !success);

            Value = value;
        }
    }
}