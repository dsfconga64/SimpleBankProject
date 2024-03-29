﻿using DataAccess1.Crud;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AccountManagement
    {
        private AccountCrudFactory crudAccount;

        public AccountManagement()
        {
            crudAccount = new AccountCrudFactory();
        }

        public void Create(Account account)
        {

            crudAccount.Create(account);

        }

        public List<Account> RetrieveAll()
        {
            return crudAccount.RetrieveAll<Account>();
        }

        public Account RetrieveById(Account account)
        {
            return crudAccount.Retrieve<Account>(account);
        }

        public void Update(Account account)
        {
            crudAccount.Update(account);
        }

        public void Delete(Account account)
        {
            crudAccount.Delete(account);
        }
    }
}
