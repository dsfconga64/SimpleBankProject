Imports DataAccess1.Crud
Imports Entities_POJO

Public Class vAccountManagement


    Private crudAccount As AccountCrudFactory

    Public Sub New()
        crudAccount = New AccountCrudFactory()
    End Sub

    Public Sub Create(ByVal account As Account)
        crudAccount.Create(account)
    End Sub

    Public Function RetrieveAll() As List(Of Account)
        Return crudAccount.RetrieveAll(Of Account)()
    End Function

    Public Function RetrieveById(ByVal account As Account) As Account
        Return crudAccount.Retrieve(Of Account)(account)
    End Function

    Public Function RetrieveByCustomerId(ByVal account As Account) As List(Of Account)
        Return crudAccount.RetrieveAccountsByIdCustomer(Of Account)(account)
    End Function

    Public Sub Update(ByVal account As Account)
        crudAccount.Update(account)
    End Sub

    Public Sub Delete(ByVal account As Account)
        crudAccount.Delete(account)
    End Sub


End Class
