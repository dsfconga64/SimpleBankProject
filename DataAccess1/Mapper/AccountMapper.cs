using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;
using Entities_POJO;

namespace DataAccess1.Mapper
{
    public class AccountMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ACCOUNT_ID = "ACCOUNT_ID";
        private const string DB_COL_ACCOUNT_NAME = "ACCOUNT_NAME";
        private const string DB_COL_CURRENCY = "CURRENCY";
        private const string DB_COL_BALANCE = "BALANCE";
        private const string DB_COL_FK_CUSTOMER_ID = "FK_CUSTOMER_ID";



        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ACCOUNT_PR" };

            var c = (Account)entity;
            operation.AddVarcharParam(DB_COL_ACCOUNT_NAME, c.AccountName);
            operation.AddVarcharParam(DB_COL_CURRENCY, c.Currency);
            operation.AddDoubleParam(DB_COL_BALANCE, c.Balance);
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.Fk_Customer_Id);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ACCOUNT_PR" };

            var c = (Account)entity;
            operation.AddIntParam(DB_COL_ACCOUNT_ID, c.AccountId);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_ACCOUNT_PR" };
            return operation;
        }

        public SqlOperation GetRetriveAccountsByCustomerStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ACCOUNTS_BY_CUSTOMER" };
            var c = (Account)entity;
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.Fk_Customer_Id);
            return operation;
        }
        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_ACCOUNT_PR" };

            var c = (Account)entity;
            operation.AddIntParam(DB_COL_ACCOUNT_ID, c.AccountId);
            operation.AddVarcharParam(DB_COL_ACCOUNT_NAME, c.AccountName);
            operation.AddVarcharParam(DB_COL_CURRENCY, c.Currency);
            operation.AddDoubleParam(DB_COL_BALANCE, c.Balance);
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.Fk_Customer_Id);


            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_ACCOUNT_PR" };

            var c = (Account)entity;
            operation.AddIntParam(DB_COL_ACCOUNT_ID, c.AccountId);
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
            var account = new Account
            {
                AccountId = GetIntValue(row, DB_COL_ACCOUNT_ID),
                AccountName = GetStringValue(row, DB_COL_ACCOUNT_NAME),
                Currency = GetStringValue(row, DB_COL_CURRENCY),
                Balance = GetDoubleValue(row, DB_COL_BALANCE),
                Fk_Customer_Id = GetStringValue(row, DB_COL_FK_CUSTOMER_ID)
            };

            return account;
        }
    }
}
