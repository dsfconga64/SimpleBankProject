using DataAccess1.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess1.Mapper
{
    public class LocationMapper: EntityMapper,ISqlStatements, IObjectMapper
    {
        private const string DB_COL_LOCATION_ID = "LOCATION_ID";
        private const string DB_COL_LOCATION_TYPE = "LOCATION_TYPE";
        private const string DB_COL_LOCATION_VALUE = "LOCATION_VALUE";
        private const string DB_COL_CUSTOMER_ID = "FK_CUSTOMER_ID";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_LOCATION_PR" };

            var c = (Location)entity;
            operation.AddVarcharParam(DB_COL_LOCATION_ID, c.IdLocation);
            operation.AddVarcharParam(DB_COL_LOCATION_TYPE, c.LocationType);
            operation.AddVarcharParam(DB_COL_LOCATION_VALUE, c.Value);
            operation.AddVarcharParam(DB_COL_CUSTOMER_ID, c.CustomerId);


            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_LOCATION_PR" };

            var c = (Location)entity;
            operation.AddVarcharParam(DB_COL_LOCATION_ID, c.IdLocation);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_LOCATION_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_LOCATION_PR" };

            var c = (Location)entity;
            operation.AddVarcharParam(DB_COL_LOCATION_TYPE, c.LocationType);
            operation.AddVarcharParam(DB_COL_LOCATION_VALUE, c.Value);
            operation.AddVarcharParam(DB_COL_CUSTOMER_ID, c.CustomerId);


            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_LOCATION_PR" };

            var c = (Location)entity;
            operation.AddVarcharParam(DB_COL_LOCATION_ID, c.IdLocation);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var address = BuildObject(row);
                lstResults.Add(address);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var location = new Location
            {
                IdLocation = GetStringValue(row, DB_COL_LOCATION_ID),
                LocationType = GetStringValue(row, DB_COL_LOCATION_TYPE),
                Value= GetStringValue(row, DB_COL_LOCATION_VALUE),
                CustomerId = GetStringValue(row, DB_COL_CUSTOMER_ID)
            };

            return location;
        }
    }
}
