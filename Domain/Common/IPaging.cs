using System;
namespace Abc.Domain
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        bool HasNextPage { get; set; }
        bool HasPreviousPage { get; set; }
    }
}
