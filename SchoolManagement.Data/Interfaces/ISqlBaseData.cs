using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data.Interfaces
{
    public interface ISqlBaseData<T>
    {
        int Commit();
        T Insert(T obj);
        T Update(T obj);
    }
}
