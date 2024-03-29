﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;
using DataAccess1.Mapper;
using Entities_POJO;

namespace DataAccess1.Crud
{
    class AppMessagesCrudFactory : CrudFactory
    {
        AppMessageMapper mapper;

        public AppMessagesCrudFactory() : base()
        {
            mapper = new AppMessageMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstAppMessage = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstAppMessage.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstAppMessage;
        }

        public override void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
