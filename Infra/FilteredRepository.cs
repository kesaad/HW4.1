using System;
using Abc.Domain;

namespace Abc.Infra
{
    public class FilteredRepository<T> : SortedRepository<T>, ISearching
    {
        public string SearchString { get; set; }
    }
}
