using System;
using Abc.Domain;

namespace Abc.Infra
{
    public class SortedRepository<T> : BaseRepository<T>, ISorting
    {
        public string SortOrder { get; set; }
    }
}
