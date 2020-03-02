using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;

namespace Abc.Domain
{
    public interface IRepository<T> : ICrudMethods<T>, IPaging, ISorting, ISearching
    {
    }
}