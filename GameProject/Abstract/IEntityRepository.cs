using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IEntityRepository<T>
    {
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
