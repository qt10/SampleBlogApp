using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.CrudWebApi.Utils
{
    public interface IMapper
    {
        T2 Map<T1, T2>(T1 obj1);
        List<T2> MapCollection<T1, T2>(IEnumerable<T1> obj1);
    }
}
