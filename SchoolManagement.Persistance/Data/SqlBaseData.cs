using Microsoft.EntityFrameworkCore;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Domain;

namespace SchoolManagement.Persistance.Data
{
    public abstract class SqlBaseData<T> : ISqlBaseData<T> 
        where T : EntityBase
    {
        public SqlBaseData(SmContext context)
        {
            this.Context = context;
        }

        public SmContext Context { get; }

        public int Insert(T obj)
        {
            obj.SetupSystemFields();
            var entry = Context.Add(obj);
            entry.State = EntityState.Added;

            return Commit();
        }

        public int Update(T obj)
        {
            obj.SetupSystemFields();
            var entry = Context.Attach(obj);
            entry.State = EntityState.Modified;

            return Commit();
        }

        private int Commit()
        {
            return Context.SaveChanges();
        }
    }
}