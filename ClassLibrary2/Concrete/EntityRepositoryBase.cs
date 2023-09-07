using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DataAccessLayer
{
    public class EntityRepositoryBase<BaseEntity>
    {
        public void Add(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public BaseEntity entity(int Id)
        {
            throw new NotImplementedException();
        }

        public List<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseEntity GetEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
