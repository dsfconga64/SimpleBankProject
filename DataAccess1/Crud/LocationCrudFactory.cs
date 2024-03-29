﻿using DataAccess1.Dao;
using DataAccess1.Mapper;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Crud
{
    public class LocationCrudFactory: CrudFactory
    {
        LocationMapper mapper;

        public LocationCrudFactory() : base()
        {
            mapper = new LocationMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var location = (Location)entity;
            var sqlOperation = mapper.GetCreateStatement(location);
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
            var lstLocations = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstLocations.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstLocations;
        }

        public override void Update(BaseEntity entity)
        {
            var location = (Location)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(location));
        }

        public override void Delete(BaseEntity entity)
        {
            var location = (Location)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(location));
        }


    }
}
