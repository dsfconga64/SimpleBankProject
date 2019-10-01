using DataAcess.Crud;
using Entities_POJO;
using System.Collections.Generic;


namespace ConsoleApp1
{
    public class CustomerManagement
    {
        private CustomerCrudFactory crudCustomer;

        public CustomerManagement()
        {
            crudCustomer = new CustomerCrudFactory();
        }

        public void Create(Customer customer)
        {

            crudCustomer.Create(customer);

        }


        public List<Customer> RetrieveAll()
        {
            return crudCustomer.RetrieveAll<Customer>();
        }

        public Customer RetrieveById(Customer customer)
        {
            return crudCustomer.Retrieve<Customer>(customer);
        }

        public void Update(Customer customer)
        {
            crudCustomer.Update(customer);
        }

        public void Delete(Customer customer)
        {
            crudCustomer.Delete(customer);
        }
    }
}

