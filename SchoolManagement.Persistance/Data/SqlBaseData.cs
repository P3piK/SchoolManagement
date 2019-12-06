using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain;

namespace SchoolManagement.Persistance.Data
{
    public class SqlBaseData<T> where T : EntityBase
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