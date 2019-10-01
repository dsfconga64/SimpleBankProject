Imports ConsoleApp1
Imports Entities_POJO

Module Module1

    Sub Main()

        DoIt()

    End Sub

    Private Sub DoIt()
        Try
            Dim cxMng As New vCustomerManagement
            Dim addMng As New vAddressMangement
            Dim accMng As New vAccountManagement
            Dim credMng As New vCreditManagement


            Console.WriteLine("Cenfo Bank options")
            Console.WriteLine("1.CREATE CUSTOMER")
            Console.WriteLine("2.RETRIEVE ALL CUSTOMER")
            Console.WriteLine("3.RETRIEVE BY ID CUSTOMER")
            Console.WriteLine("4.UPDATE CUSTOMER")
            Console.WriteLine("5.DELETE CUSTOMER")
            Console.WriteLine("********************")
            Console.WriteLine("ADDRESS MENU")
            Console.WriteLine("********************")
            Console.WriteLine("6.CREATE ADDRESS")
            Console.WriteLine("7.RETRIEVE ALL ADDRESSES")
            Console.WriteLine("8.RETRIEVE BY ID ADDRESS")
            Console.WriteLine("9.UPDATE ADDRESS")
            Console.WriteLine("10.DELETE ADDRESS")
            Console.WriteLine("********************")
            Console.WriteLine("Credit MENU")
            Console.WriteLine("********************")
            Console.WriteLine("11.CREATE CREDIT")
            Console.WriteLine("12.RETRIEVE ALL CREDITS")
            Console.WriteLine("13.RETRIEVE BY ID CREDIT")
            Console.WriteLine("14.UPDATE CREDIT")
            Console.WriteLine("15.DELETE CREDIT")
            Console.WriteLine("********************")
            Console.WriteLine("Account MENU")
            Console.WriteLine("********************")
            Console.WriteLine("16.CREATE ACCOUNT")
            Console.WriteLine("17.RETRIEVE ALL ACCOUNTS")
            Console.WriteLine("18.RETRIEVE BY ID ACCOUNT")
            Console.WriteLine("19.UPDATE ACCOUNT")
            Console.WriteLine("20.DELETE ACCOUNT")
            Console.WriteLine("********************")
            Console.WriteLine("SPECIAL RETRIEVES OF CUSTOMER")
            Console.WriteLine("********************")
            Console.WriteLine("21.RETRIEVE ACCOUNTS BY CUSTOMER ID ")


            Console.WriteLine("Choose an option: ")
            Dim choosenOption = Console.ReadLine()

            Select Case (choosenOption)
                Case "1"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****     CREATE    *******")
                    Console.WriteLine("***************************")
                    Console.WriteLine("Type the id, name, last_name, age, Born Date(yyyy-mm-dd), Civil status and Gender separated by comma")
                    Dim info = Console.ReadLine()
                    Dim infoArray = info.Split(",")

                    Dim customer As New Customer(infoArray)
                    cxMng.Create(customer)

                    Console.WriteLine("Customer was added")

                Case "2"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****  RETRIEVE ALL   *****")
                    Console.WriteLine("***************************")

                    Dim lstCustomers = cxMng.RetrieveAll()
                    Dim count = 0

                    For Each c In lstCustomers
                        count = count + 1
                        Console.WriteLine(" ==> " + c.GetEntityInformation())
                    Next

                Case "3"

                    Dim customer1 As New Customer
                    Console.WriteLine("Type the customer id:")
                    customer1.Id = Console.ReadLine()
                    customer1 = cxMng.RetrieveById(customer1)

                    If customer1 IsNot Nothing Then
                        Console.WriteLine(" ==> " + customer1.GetEntityInformation())
                    End If

                Case "4"
                    Dim customer2 As New Customer
                    Console.WriteLine("***************************")
                    Console.WriteLine("******  UPDATE  **    *****")
                    Console.WriteLine("***************************")

                    Console.WriteLine("Type customer Id: ")
                    customer2.Id = Console.ReadLine()
                    customer2 = cxMng.RetrieveById(customer2)

                    If customer2 IsNot Nothing Then

                        Console.WriteLine(" ==> " + customer2.GetEntityInformation())

                        Console.WriteLine("Type a new name, actual value is " + customer2.Name)
                        customer2.Name = Console.ReadLine()

                        Console.WriteLine("Type a new last name, actual value is " + customer2.LastName)
                        customer2.LastName = Console.ReadLine()

                        Console.WriteLine("Type a new age, actual value is ")
                        Dim textAge = Console.ReadLine()
                        customer2.Age = Integer.Parse(textAge)

                        Console.WriteLine("Type a new born date(yyyy-mm-dd), actual value is " + customer2.BornDate)
                        Dim textBornDate = Console.ReadLine()
                        customer2.BornDate = DateTime.Parse(textBornDate)

                        Console.WriteLine("Type a new civil status, actual value is " + customer2.CivilStatus)
                        customer2.CivilStatus = Console.ReadLine()

                        Console.WriteLine("Type a new gender, actual value is " + customer2.Gender)
                        customer2.Gender = Console.ReadLine()

                        cxMng.Update(customer2)
                        Console.WriteLine("Customer was updated")
                    Else
                        Throw New Exception("Customer no registered")
                    End If

                Case "5"

                    Dim customer3 As New Customer
                    Console.WriteLine("Type the customer id:")
                    customer3.Id = Console.ReadLine()
                    customer3 = cxMng.RetrieveById(customer3)

                    If customer3 IsNot Nothing Then
                        Console.WriteLine(" ==> " + customer3.GetEntityInformation())

                        Console.WriteLine("Delete? Y/N")
                        Dim delete = Console.ReadLine()
                        If delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase) Then
                            cxMng.Delete(customer3)
                            Console.WriteLine("Deleted")
                        End If
                    End If

                Case "6"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****     CREATE    *******")
                    Console.WriteLine("***************************")

                    Dim lstCustomers = cxMng.RetrieveAll()
                    Dim count = 0

                    For Each c In lstCustomers
                        count += 1
                        Console.WriteLine(count & " ==> " + c.GetEntityInformation())
                    Next

                    Console.WriteLine("***************************")
                    Console.WriteLine("***************************")
                    Console.WriteLine("Type the Province, Town, District and the customer ID separated by comma")
                    Dim info1 = Console.ReadLine()
                    Dim infoArray1 = info1.Split(",")

                    Dim address = New Address(infoArray1)
                    addMng.Create(address)

                    Console.WriteLine("Created address")

                Case "7"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****  RETRIEVE ALL ADDRESSES   *****")
                    Console.WriteLine("***************************")

                    Dim lstAddresses = addMng.RetrieveAll()
                    Dim count1 = 0

                    For Each c In lstAddresses
                        count1 += 1
                        Console.WriteLine(count1 & " ==> " + c.GetEntityInformation())
                    Next

                Case "8"

                    Dim address As New Address
                    Console.WriteLine("***************************")
                    Console.WriteLine("*****  RETRIEVE BY ID ADDRESSES   *****")
                    Console.WriteLine("***************************")

                    Dim addresId
                    Console.WriteLine("Type the address id:")
                    addresId = Console.ReadLine()
                    address.AddresId = Int32.Parse(addresId)
                    address = addMng.RetrieveById(address)

                    If address IsNot Nothing Then
                        Console.WriteLine(" ==> " & address.GetEntityInformation())
                    End If

                Case "9"
                    Dim address As New Address
                    Console.WriteLine("***************************")
                    Console.WriteLine("******  UPDATE  **    *****")
                    Console.WriteLine("***************************")

                    Console.WriteLine("Type the Address id:")
                    Dim addresId = Console.ReadLine()
                    Address.AddresId = Int32.Parse(addresId)
                    address = addMng.RetrieveById(address)

                    If True Then
                        Console.WriteLine(" ==> " + Address.GetEntityInformation())

                        Console.WriteLine("Type a new Province, actual value is " + address.Province)
                        address.Province = Console.ReadLine()

                        Console.WriteLine("Type a new Town, actual value is " + address.Town)
                        address.Town = Console.ReadLine()

                        Console.WriteLine("Type a new disctrict, actual value is " + address.District)
                        address.District = Console.ReadLine()

                        Console.WriteLine("Type a new customer Id, actual value is " + address.Fk_Customer_ID)
                        address.Fk_Customer_ID = Console.ReadLine()

                        addMng.Update(address)
                        Console.WriteLine("Address was updated")
                    Else

                    End If

                Case "10"

                    Dim address As New Address
                    Console.WriteLine("Type the address id:")
                    address.AddresId = Console.ReadLine()
                    address = addMng.RetrieveById(address)

                    If address IsNot Nothing Then
                        Console.WriteLine(" ==> " + address.GetEntityInformation())

                        Console.WriteLine("Delete? Y/N")
                        Dim delete = Console.ReadLine()
                        If delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase) Then
                            addMng.Delete(address)
                            Console.WriteLine("Deleted")
                        End If
                    End If

                Case "11"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****     CREATE    *******")
                    Console.WriteLine("***************************")
                    Console.WriteLine("Type the credit amount, rate, credit name, fee, start date(yyyy-mm-dd), status,operational balance and customer Id  separated by comma")
                    Dim info = Console.ReadLine()
                    Dim infoArray = info.Split(",")

                    Dim credit As New Credit(infoArray)
                    credMng.Create(credit)

                    Console.WriteLine("Credit was added")

                Case "12"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****  RETRIEVE ALL CREDITS  *****")
                    Console.WriteLine("***************************")

                    Dim lstCredits = credMng.RetrieveAll()
                    Dim count = 0

                    For Each c In lstCredits
                        count = count + 1
                        Console.WriteLine(" ==> " + c.GetEntityInformation())
                    Next

                Case "13"

                    Dim credit As New Credit
                    Console.WriteLine("Type the CREDIT id:")
                    credit.CreditId = Console.ReadLine()
                    credit = credMng.RetrieveById(credit)

                    If credit IsNot Nothing Then
                        Console.WriteLine(" ==> " + credit.GetEntityInformation())
                    End If

                Case "14"

                    Dim credit As New Credit
                    Console.WriteLine("***************************")
                    Console.WriteLine("******  UPDATE  **    *****")
                    Console.WriteLine("***************************")

                    Console.WriteLine("Type the Credit id:")
                    Dim creditId = Console.ReadLine()
                    credit.CreditId = Int32.Parse(creditId)
                    credit = credMng.RetrieveById(credit)

                    If True Then
                        Console.WriteLine(" ==> " + credit.GetEntityInformation())

                        Console.WriteLine("Type a new amount, actual value is " + credit.Amount.ToString())
                        credit.Amount = Console.ReadLine()

                        Console.WriteLine("Type a new rate, actual value is " + credit.Rate.ToString())
                        credit.Rate = Console.ReadLine()

                        Console.WriteLine("Type a new name, actual value is " + credit.Name)
                        credit.Name = Console.ReadLine()

                        Console.WriteLine("Type a new fee, actual value is " + credit.Fee.ToString())
                        credit.Fee = Console.ReadLine()

                        Console.WriteLine("Type a new start date yyyy-mm-dd, actual value is " + credit.StartDate)
                        credit.StartDate = Console.ReadLine()

                        Console.WriteLine("Type a new status, actual value is " + credit.Status)
                        credit.Status = Console.ReadLine()



                        Console.WriteLine("Type a new operation balance, actual value is " + credit.OperationalBalance.ToString())
                        credit.OperationalBalance = Console.ReadLine()



                        credMng.Update(credit)
                        Console.WriteLine("Address was updated")
                    End If

                Case "15"

                    Dim credit As New Credit
                    Console.WriteLine("Type the credit id:")
                    credit.CreditId = Console.ReadLine()
                    credit = credMng.RetrieveById(credit)

                    If credit IsNot Nothing Then
                        Console.WriteLine(" ==> " + credit.GetEntityInformation())

                        Console.WriteLine("Delete? Y/N")
                        Dim delete = Console.ReadLine()
                        If delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase) Then
                            credMng.Delete(credit)
                            Console.WriteLine("Deleted")
                        End If
                    End If

                Case "16"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****     CREATE    *******")
                    Console.WriteLine("***************************")
                    Console.WriteLine("Type the account name, Currency,Balance, Customer Id associated separated by comma")
                    Dim info = Console.ReadLine()
                    Dim infoArray = info.Split(",")

                    Dim account As New Account(infoArray)
                    accMng.Create(account)

                    Console.WriteLine("Credit was added")


                Case "17"

                    Console.WriteLine("***************************")
                    Console.WriteLine("*****  RETRIEVE ALL ACCOUNTS   *****")
                    Console.WriteLine("***************************")

                    Dim lstAccounts = accMng.RetrieveAll()
                    Dim count1 = 0

                    For Each c In lstAccounts
                        count1 += 1
                        Console.WriteLine(count1 & " ==> " + c.GetEntityInformation())
                    Next

                Case "18"

                    Dim account As New Account
                    Console.WriteLine("Type the account id:")
                    account.AccountId = Console.ReadLine()
                    account = accMng.RetrieveById(account)

                    If account IsNot Nothing Then
                        Console.WriteLine(" ==> " + account.GetEntityInformation())
                    End If

                Case "19"

                    Dim account As New Account
                    Console.WriteLine("***************************")
                    Console.WriteLine("******  UPDATE  **    *****")
                    Console.WriteLine("***************************")

                    Console.WriteLine("Type the account id:")
                    Dim accountId = Console.ReadLine()
                    account.AccountId = Int32.Parse(accountId)
                    account = accMng.RetrieveById(account)

                    If True Then
                        Console.WriteLine(" ==> " + account.GetEntityInformation())

                        Console.WriteLine("Type a new name, actual value is " + account.AccountName)
                        account.AccountName = Console.ReadLine()

                        Console.WriteLine("Type a new currency, actual value is " + account.Currency)
                        account.Currency = Console.ReadLine()

                        Console.WriteLine("Type a new balance, actual value is " + account.Balance.ToString())
                        account.Balance = Console.ReadLine()

                        Console.WriteLine("Type a new customer Id, actual value is " + account.Fk_Customer_Id)
                        account.Fk_Customer_Id = Console.ReadLine()

                        accMng.Update(account)
                        Console.WriteLine("Account was updated")
                    Else

                    End If

                Case "20"

                    Dim account As New Account
                    Console.WriteLine("Type the account id:")
                    account.AccountId = Console.ReadLine()
                    account = accMng.RetrieveById(account)

                    If account IsNot Nothing Then
                        Console.WriteLine(" ==> " + account.GetEntityInformation())

                        Console.WriteLine("Delete? Y/N")
                        Dim delete = Console.ReadLine()
                        If delete.Equals("Y", StringComparison.CurrentCultureIgnoreCase) Then
                            accMng.Delete(account)
                            Console.WriteLine("Deleted")
                        End If
                    End If

                Case "21"

                    Dim customer As New Customer
                    Dim accounts As New Account
                    Dim lstCustomers = cxMng.RetrieveAll()
                    Dim count = 0

                    For Each c In lstCustomers
                        count = count + 1
                        Console.WriteLine(" ==> " + c.GetEntityInformation())
                    Next

                    Console.WriteLine("Type the customer id:")
                    accounts.Fk_Customer_Id = Console.ReadLine()
                    Dim lstAccounts = accMng.RetrieveByCustomerId(accounts)

                    For Each c In lstAccounts
                        count += 1
                        Console.WriteLine(count & " ==> " + c.GetEntityInformation())
                    Next

            End Select



        Catch ex As Exception
            Console.WriteLine("***************************")
            Console.WriteLine("ERROR: " + ex.Message)
            Console.WriteLine(ex.StackTrace)
            Console.WriteLine("***************************")
        Finally
            Console.WriteLine("Continue? Y/N")
            Dim moreActions = Console.ReadLine()

            If (moreActions.Equals("Y", StringComparison.CurrentCultureIgnoreCase)) Then
                DoIt()
            End If

        End Try

    End Sub
End Module
