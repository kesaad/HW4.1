using System;
using System.Linq;
using Abc.Data.Common;
using Abc.Domain;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class FilteredRepository<TDomain, TData> : SortedRepository<TDomain, TData>, ISearching
        where TData : PeriodData, new() where TDomain : Entity<TData>, new()
    {
        protected FilteredRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public string SearchString { get; set; }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();
            query = addFiltering(query);
            return query;
        }

        protected internal virtual IQueryable<TData> addFiltering(IQueryable<TData> query)
        {
            return query;
        }
    }
}
