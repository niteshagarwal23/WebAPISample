using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPITest.Database
{
    public interface IDataTable<T>
    {
        IEnumerable<T> Data { get; }

        T Add(T obj);

        bool Delete(int eId);

        void ResetCollection();
    }
}