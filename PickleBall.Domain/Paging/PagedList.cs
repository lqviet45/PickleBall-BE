using Microsoft.EntityFrameworkCore;

namespace PickleBall.Domain.Paging;

public class PagedList<T>
{
    private PagedList(List<T> items, int currentPage, int totalPages, int pageSize, int totalCount)
    {
        Items = items;
        CurrentPage = currentPage;
        TotalPages = totalPages;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    public List<T> Items { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }

    public bool HasPrevious => CurrentPage > 1;
    public bool HasNext => CurrentPage < TotalPages;

    public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
    {
        var totalCount = source.Count();

        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        return new(items, pageNumber, totalPages, pageSize, totalCount);
    }
}
