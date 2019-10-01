using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;
using Entities_POJO;

namespace DataAccess1.Mapper
{
    public class CreditMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_CREDIT_ID = "CREDIT_ID";
        private const string DB_COL_AMOUNT = "AMOUNT";
        private const string DB_COL_RATE = "RATE";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_FEE = "FEE";
        private const string DB_COL_START_DATE = "START_DATE";
        private const string DB_COL_STATUS = "STATUS";
        private const string DB_COL_OPERATIONAL_BALANCE = "OPERATIONAL_BALANCE";
        private const string DB_COL_FK_CUSTOMER_ID = "FK_CUSTOMER_ID";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CREDIT_PR" };

            var c = (Credit)entity;
            operation.AddDoubleParam(DB_COL_AMOUNT, c.Amount);
            operation.AddDoubleParam(DB_COL_RATE, c.Rate);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddDoubleParam(DB_COL_FEE, c.Fee);
            operation.AddDatetimeParam(DB_COL_START_DATE, c.StartDate);
            operation.AddVarcharParam(DB_COL_STATUS, c.Status);
            operation.AddDoubleParam(DB_COL_OPERATIONAL_BALANCE, c.OperationalBalance);
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.FK_CUSTOMER_ID);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CREDIT_PR" };

            var c = (Credit)entity;
            operation.AddIntParam(DB_COL_CREDIT_ID, c.CreditId);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CREDIT_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CREDIT_PR" };

            var c = (Credit)entity;
            operation.AddIntParam(DB_COL_CREDIT_ID, c.CreditId);
            operation.AddDoubleParam(DB_COL_AMOUNT, c.Amount);
            operation.AddDoubleParam(DB_COL_RATE, c.Rate);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddDoubleParam(DB_COL_FEE, c.Fee);
            operation.AddDatetimeParam(DB_COL_START_DATE, c.StartDate);
            operation.AddVarcharParam(DB_COL_STATUS, c.Status);
            operation.AddDoubleParam(DB_COL_OPERATIONAL_BALANCE, c.OperationalBalance);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CREDIT_PR" };

            var c = (Credit)entity;
            operation.AddIntParam(DB_COL_CREDIT_ID, c.CreditId);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var credit = BuildObject(row);
                lstResults.Add(credit);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var credit = new Credit
            {
                CreditId = GetIntValue(row, DB_COL_CREDIT_ID),
                Amount = GetDoubleValue(row, DB_COL_AMOUNT),
                Rate = GetDoubleValue(row, DB_COL_RATE),
                Name = GetStringValue(row, DB_COL_NAME),
                Fee = GetDoubleValue(row, DB_COL_FEE),
                StartDate = GetDateValue(row, DB_COL_START_DATE),
                Status = GetStringValue(row, DB_COL_STATUS),
                OperationalBalance = GetDoubleValue(row, DB_COL_OPERATIONAL_BALANCE),
                FK_CUSTOMER_ID = GetStringValue(row, DB_COL_FK_CUSTOMER_ID)
            };

            return credit;
        }
    }
}
