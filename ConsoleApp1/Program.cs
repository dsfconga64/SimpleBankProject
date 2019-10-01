using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            DoIt();

        }

        public static void DoIt()
        {
            try
            {
                var mng = new CustomerManagement();
                var mngAddress = new AddressManagement();
                var customer = new Customer();
                var address = new Address();

                Console.WriteLine("Cenfo Bank options");
                Console.WriteLine("1.CREATE CUSTOMER");
                Console.WriteLine("2.RETRIEVE ALL CUSTOMER");
                Console.WriteLine("3.RETRIEVE BY ID CUSTOMER");
                Console.WriteLine("4.UPDATE CUSTOMER");
                Console.WriteLine("5.DELETE CUSTOMER");
                Console.WriteLine("********************");
                Console.WriteLine("ADDRESS MENU");
                Console.WriteLine("********************");
                Console.WriteLine("6.CREATE ADDRESS");
                Console.WriteLine("7.RETRIEVE ALL ADDRESSES");
                Console.WriteLine("8.RETRIEVE BY ID ADDRESS");
                Console.WriteLine("9.UPDATE ADDRESS");
                Console.WriteLine("10.DELETE ADDRESS");

                Console.WriteLine("Choose an option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the id, name, last_name, age, Born Date(yyyy-mm-dd), Civil status and Gender separated by comma");
                        var info = Console.ReadLine();
                        var infoArray = info.Split(',');

                        customer = new Customer(infoArray);
                        mng.Create(customer);

                        Console.WriteLine("Customer was created");

                        break;

                    case "2":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL   *****");
                        Console.WriteLine("***************************");

                        var lstCustomers = mng.RetrieveAll();
                        var count = 0;

                        foreach (var c in lstCustomers)
                        {
                            count++;
                            Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                        }

                        break;
                    case "3":
                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());
                        }

                        break;
                    case "4":
                        Console.WriteLine("***************************");
                        Console.WriteLine("******  UPDATE  **    *****");
                        Console.WriteLine("***************************");

                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());

                            Console.WriteLine("Type a new name, actual value is " + customer.Name);
                            customer.Name = Console.ReadLine();

                            Console.WriteLine("Type a new last name, actual value is " + customer.LastName);
                            customer.LastName = Console.ReadLine();

                            Console.WriteLine("Type a new age, actual value is " + customer.Age);
                            var textAge = Console.ReadLine();
                            customer.Age = Int32.TryParse(textAge, out int age) ? age : customer.Age;

                            Console.WriteLine("Type a new born date(yyyy-mm-dd), actual value is " + customer.BornDate);
                            var textBornDate = Console.ReadLine();
                            customer.BornDate = DateTime.TryParse(textBornDate, out DateTime dateTime) ? dateTime : customer.BornDate;

                            Console.WriteLine("Type a new civil status, actual value is " + customer.CivilStatus);
                            customer.CivilStatus = Console.ReadLine();

                            Console.WriteLine("Type a new gender, actual value is " + customer.Gender);
                            customer.Gender = Console.ReadLine();

                            mng.Update(customer);
                            Console.WriteLine("Customer was updated");
                        }
                        else
                        {
                            throw new Exception("Customer not registered");
                        }

                        break;

                    case "5":
                        Console.WriteLine("Type the customer id:");
                        customer.Id = Console.ReadLine();
                        customer = mng.RetrieveById(customer);

                        if (customer != null)
                        {
                            Console.WriteLine(" ==> " + customer.GetEntityInformation());

                            Console.WriteLine("Delete? Y/N");
                            var delete = Console.ReadLine();

                            if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                mng.Delete(customer);
                                Console.WriteLine("Customer was deleted");
                            }
                        }
                        else
                        {
                            throw new Exception("Customer not registered");
                        }

                        break;

                    case "6":

                        Console.WriteLine("***************************");
                        Console.WriteLine("*****     CREATE    *******");
                        Console.WriteLine("***************************");
                        
                        lstCustomers = mng.RetrieveAll();
                        count = 0;

                        foreach (var c in lstCustomers)
                        {
                            count++;
                            Console.WriteLine(count + " ==> " + c.GetEntityInformation());
                        }

                        Console.WriteLine("***************************");
                        Console.WriteLine("***************************");
                        Console.WriteLine("Type the Province, Town, District and the customer ID separated by comma");
                        var info1 = Console.ReadLine();
                        var infoArray1 = info1.Split(',');

                        address = new Address(infoArray1);
                        mngAddress.Create(address);

                        Console.WriteLine("Address was added");
                        break;

                    case "7":
                        Console.WriteLine("***************************");
                        Console.WriteLine("*****  RETRIEVE ALL ADDRESSES   *****");
                        Console.WriteLine("***************************");

                        var lstAddresses = mngAddress.RetrieveAll();
                        var count1 = 0;

                        foreach (var c in lstAddresses)
                        {
                            count1++;
                            Console.WriteLine(count1 + " ==> " + c.GetEntityInformation());
                        }
                        break;

                    case "8":
                        string addresId;
                        Console.WriteLine("Type the address id:");
                        addresId = Console.ReadLine();
                        address.AddresId = Int32.Parse(addresId);
                        address = mngAddress.RetrieveById(address);

                        if (address != null)
                        {
                            Console.WriteLine(" ==> " + address.GetEntityInformation());
                        }
                        break;

                    case "9":

                        Console.WriteLine("***************************");
                        Console.WriteLine("******  UPDATE  **    *****");
                        Console.WriteLine("***************************");

                        Console.WriteLine("Type the Address id:");
                        addresId = Console.ReadLine();
                        address.AddresId = Int32.Parse(addresId);
                        address = mngAddress.RetrieveById(address);

                        if (address != null)
                        {
                            Console.WriteLine(" ==> " + address.GetEntityInformation());

                            Console.WriteLine("Type a new Province, actual value is " + address.Province);
                            address.Province = Console.ReadLine();

                            Console.WriteLine("Type a new Town, actual value is " + address.Town);
                            address.Town = Console.ReadLine();

                            Console.WriteLine("Type a new disctrict, actual value is " + address.District);
                            address.District = Console.ReadLine();

                            Console.WriteLine("Type a new customer Id, actual value is " + address.Fk_Customer_ID);
                            address.Fk_Customer_ID = Console.ReadLine();

                            mngAddress.Update(address);
                            Console.WriteLine("Address was updated");
                        }
                        else
                        {
                            throw new Exception("Address not registered");
                        }

                        break;

                    case "10":

                        Console.WriteLine("Type the address id:");
                        addresId = Console.ReadLine();
                        address.AddresId = Int32.Parse(addresId);
                        address = mngAddress.RetrieveById(address);

                        if (address != null)
                        {
                            Console.WriteLine(" ==> " + address.GetEntityInformation());

                            Console.WriteLine("Delete? Y/N");
                            var delete = Console.ReadLine();

                            if (delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                            {
                                mngAddress.Delete(address);
                                Console.WriteLine("Address was deleted");
                            }
                        }
                        else
                        {
                            throw new Exception("Address not registered");
                        }
                        break;
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("***************************");
                Console.WriteLine("ERROR: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("***************************");
            }
            finally
            {
                Console.WriteLine("Continue? Y/N");
                var moreActions = Console.ReadLine();

                if (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
                    DoIt();
            }


        }
    }
}
