using System.Collections.Generic;

namespace Web_Server_Final.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);
    }
}
