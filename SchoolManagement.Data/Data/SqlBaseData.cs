using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core;
using SchoolManagement.Data.Interfaces;

namespace SchoolManagement.Data.Data
{
    public class SqlBaseData<T> : ISqlBaseData<T> where T : EntityRecordBase
    {
        public SqlBaseData(SmContext context)
        {
            this.Context = context;
        }

        public SmContext Context { get; }


        public int Commit()
        {
            return Context.SaveChanges();
        }

        public T Insert(T obj)
        {
            obj.SetupSystemFields();
            var entry = Context.Add(obj);
            entry.State = EntityState.Added;

            return obj;
        }

        public T Update(T obj)
        {
            obj.SetupSystemFields();
            var entry = Context.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }
    }
}