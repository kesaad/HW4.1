using System;
using System.Linq;
using Abc.Data.Common;
using Abc.Domain;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra
{
    public abstract class PaginatedRepository<TDomain, TData> : FilteredRepository<TDomain, TData>, IPaging
        where TData : PeriodData, new() where TDomain : Entity<TData>, new()
    {
        protected PaginatedRepository(DbContext c, DbSet<TData> s) : base(c, s) { }

        public int PageIndex { get; set; }
        public bool HasNextPage => PageIndex < TotalPages;
        public bool HasPreviousPage => PageIndex > 1;
        public int PageSize { get; set; } = 5;
        public int TotalPages => getTotalPages(PageSize);

        internal int getTotalPages(in int pageSize)
        {
            var count = getItemsCount();
            var pages = countTotalPages(count, pageSize);
            return pages;
        }

        internal int countTotalPages(int count, in int pageSize)
        {
            return (int)Math.Ceiling(count / (double)pageSize);
        }

        internal int getItemsCount()
        {
            var query = base.createSqlQuery();
            return query.CountAsync().Result;
        }

        protected internal override IQueryable<TData> createSqlQuery()
        {
            var query = base.createSqlQuery();
            query = addSkipAndTake(query);
            return query;
        }

        private IQueryable<TData> addSkipAndTake(IQueryable<TData> query)
        {
            var q = query.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            return q;
        }
    }
}
