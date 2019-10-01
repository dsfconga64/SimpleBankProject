using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess1.Dao;
using Entities_POJO;

namespace DataAccess1.Mapper
{
    public class AddressMapper : EntityMapper, ISqlStatements, IObjectMapper
    {
        private const string DB_COL_ADDRESSES_ID = "ADDRESSES_ID";
        private const string DB_COL_PROVINCE = "PROVINCE";
        private const string DB_COL_TOWN = "TOWN";
        private const string DB_COL_DISTRICT = "DISCTRICT";
        private const string DB_COL_FK_CUSTOMER_ID = "FK_CUSTOMER_ID";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ADDRESS_PR" };

            var c = (Address)entity;
            operation.AddVarcharParam(DB_COL_PROVINCE, c.Province);
            operation.AddVarcharParam(DB_COL_TOWN, c.Town);
            operation.AddVarcharParam(DB_COL_DISTRICT, c.District);
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.Fk_Customer_ID);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ADDRESS_PR" };

            var c = (Address)entity;
            operation.AddIntParam(DB_COL_ADDRESSES_ID, c.AddresId);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_ADDRESS_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_ADDRESS_PR" };

            var c = (Address)entity;
            operation.AddIntParam(DB_COL_ADDRESSES_ID, c.AddresId);
            operation.AddVarcharParam(DB_COL_PROVINCE, c.Province);
            operation.AddVarcharParam(DB_COL_TOWN, c.Town);
            operation.AddVarcharParam(DB_COL_DISTRICT, c.District);
            operation.AddVarcharParam(DB_COL_FK_CUSTOMER_ID, c.Fk_Customer_ID);


            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_ADDRESS_PR" };

            var c = (Address)entity;
            operation.AddIntParam(DB_COL_ADDRESSES_ID, c.AddresId);
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
            var address = new Address
            {
                AddresId = GetIntValue(row, DB_COL_ADDRESSES_ID),
                Province = GetStringValue(row, DB_COL_PROVINCE),
                Town = GetStringValue(row, DB_COL_TOWN),
                District = GetStringValue(row, DB_COL_DISTRICT),
                Fk_Customer_ID = GetStringValue(row,DB_COL_FK_CUSTOMER_ID)
            };

            return address;
        }
    }
}
