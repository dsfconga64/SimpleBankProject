using System;
using Entities_POJO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;

namespace DataAccess1.Mapper
{
    public class CustomerMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_LAST_NAME = "LAST_NAME";
        private const string DB_COL_AGE = "AGE";
        private const string DB_COL_BORN_DATE = "BORN_DATE";
        private const string DB_COL_CIVIL_STATUS = "CIVIL_STATUS";
        private const string DB_COL_GENDER = "GENDER";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddIntParam(DB_COL_AGE, c.Age);
            operation.AddDatetimeParam(DB_COL_BORN_DATE, c.BornDate);
            operation.AddVarcharParam(DB_COL_CIVIL_STATUS, c.CivilStatus);
            operation.AddVarcharParam(DB_COL_GENDER, c.Gender);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CUSTOMER_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LAST_NAME, c.LastName);
            operation.AddIntParam(DB_COL_AGE, c.Age);
            operation.AddDatetimeParam(DB_COL_BORN_DATE, c.BornDate);
            operation.AddVarcharParam(DB_COL_CIVIL_STATUS, c.CivilStatus);
            operation.AddVarcharParam(DB_COL_GENDER, c.Gender);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer
            {
                Id = GetStringValue(row, DB_COL_ID),
                Name = GetStringValue(row, DB_COL_NAME),
                LastName = GetStringValue(row, DB_COL_LAST_NAME),
                Age = GetIntValue(row, DB_COL_AGE),
                BornDate = GetDateValue(row, DB_COL_BORN_DATE),
                CivilStatus = GetStringValue(row, DB_COL_CIVIL_STATUS),
                Gender = GetStringValue(row, DB_COL_GENDER)
            };

            return customer;
        }

    }
}
