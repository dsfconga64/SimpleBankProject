using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;
using DataAccess1.Mapper;
using Entities_POJO;

namespace DataAccess1.Crud
{
    public class AddressCrudFactory : CrudFactory
    {
        AddressMapper mapper;

        public AddressCrudFactory() : base()
        {
            mapper = new AddressMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entity)
        {
            var address = (Address)entity;
            var sqlOperation = mapper.GetCreateStatement(address);
            dao.ExecuteProcedure(sqlOperation);
        }



        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstAddresses = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstAddresses.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstAddresses;
        }

        public override void Update(BaseEntity entity)
        {
            var address = (Address)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(address));
        }

        public override void Delete(BaseEntity entity)
        {
            var address = (Address)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(address));
        }

    }
}

