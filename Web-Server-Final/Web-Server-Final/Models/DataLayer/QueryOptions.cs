using System;
using System.Linq.Expressions;

namespace Web_Server_Final.Models
{
    public class QueryOptions<T>
    {
        // public properties for sorting and filtering
        public Expression<Func<T, Object>> OrderBy { get; set; }

        // private string array for includes statements
        private string[] includes;

        // public method for include statements - returns private string array or empty string array
        public string[] GetIncludes() => includes ?? new string[0];

        // read-only properties
        public bool HasOrderBy => OrderBy != null;
    }
}
