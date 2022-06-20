using Core.Application.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Database.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> TakePage<T>(this IQueryable<T> source, PageRequest pageRequest, out PageResponse pageResponse)
        {
            if (pageRequest == null)
            {
                pageRequest = new PageRequest();
            }

            var ResultQuerable = source.Skip((pageRequest.PageNumber - 1) * pageRequest.PageSize)
                                       .Take(pageRequest.PageSize);

            pageResponse = new PageResponse
            {
                CurrentPage = pageRequest.PageNumber,
                PageSize = pageRequest.PageSize,
                TotalCount = source.Count()
            };

            return ResultQuerable;
        }
    }
}
