using System;
namespace Abc.Domain
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int TotalPages { get; }
        bool HasNextPage { get; }
        bool HasPreviousPage { get; }
    }
}
