using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using universesity.Models;
using universesity.Controllers;
using universesity.Services;

namespace universesity.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void Delete(int roomId);
        void Insert(StudentGroup studentGroup);
        void Insert(Room room);
        void Insert(Class @class);
    }

    public interface IClassRepository : IRepository<Class>
    {
    }

    public interface IRoomRepository : IRepository<Room>
    {
    }

    public interface IStudentGroupRepository : IRepository<StudentGroup>
    {
    }

    public interface ISubjectRepository : IRepository<Subject>
    {
    }
}
