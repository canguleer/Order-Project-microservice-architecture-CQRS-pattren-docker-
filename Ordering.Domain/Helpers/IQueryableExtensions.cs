using System;
using System.Linq;
using System.Linq.Dynamic.Core.Exceptions;
using System.Linq.Dynamic.Core;

namespace OrderProject.Domain.Helpers
{

    public static class IQueryableExtensions
    {
        public static IQueryable<T> Sort<T>(this IQueryable<T> source, string sortBy)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (string.IsNullOrEmpty(sortBy))
                throw new ArgumentNullException("sortBy");

            var sortExpression = string.Empty;

            var listSortBy = sortBy.Trim().Split(',');
            foreach (var item in listSortBy)
            {
                sortExpression += item + ",";
            }

            sortExpression = sortExpression.Substring(0, sortExpression.Length - 1);

            try
            {
                source = source.OrderBy(sortExpression);
            }
            catch (ParseException ex)
            {
               string message =  ex.Message;
            }

            return source;
        }

    }
}

