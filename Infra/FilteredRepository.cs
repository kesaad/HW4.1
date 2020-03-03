using Abc.Data.Common;
using Abc.Domain;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, ISearching
        where TData : UniqueEntityData, new() where TDomain : Entity<TData>, new()
    {
        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public string SearchString { get; set; }
    }
}
