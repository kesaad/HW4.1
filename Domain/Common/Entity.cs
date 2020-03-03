using Abc.Data.Common;

namespace Abc.Domain
{
    public abstract class Entity<TData> where TData : PeriodData, new()
    {
        public TData Data { get; internal set; }

        protected internal Entity(TData d = null) => Data = d ?? new TData();
    }
}