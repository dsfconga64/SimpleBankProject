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
    public class CreditCrudFactory : CrudFactory
    {
        CreditMapper mapper;

        public CreditCrudFactory() : base()
        {
            mapper = new CreditMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var credit = (Credit)entity;
            var sqlOperation = mapper.GetCreateStatement(credit);
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
            var lstCredits = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCredits.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCredits;
        }

        public override void Update(BaseEntity entity)
        {
            var credit = (Credit)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(credit));
        }

        public override void Delete(BaseEntity entity)
        {
            var credit = (Credit)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(credit));
        }
    }
}
