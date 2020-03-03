using Abc.Data.Quantity;
namespace Abc.Domain.Quantity
{
    public class Measure : Entity<MeasureData>
    {
        public Measure() : this(null) { }
        public Measure(MeasureData data) : base(data) { }
    }
}
