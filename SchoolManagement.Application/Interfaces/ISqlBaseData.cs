using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Interfaces
{
    public interface ISqlBaseData<T>
    {
        int Insert(T obj);
        int Update(T obj);
    }
}
