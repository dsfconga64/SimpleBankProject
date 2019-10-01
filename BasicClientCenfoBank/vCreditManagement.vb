Imports DataAccess1.Crud
Imports Entities_POJO

Public Class vCreditManagement

    Private crudCredit As CreditCrudFactory

    Public Sub New()
        crudCredit = New CreditCrudFactory()
    End Sub

    Public Sub Create(ByVal credit As Credit)
        crudCredit.Create(credit)
    End Sub

    Public Function RetrieveAll() As List(Of Credit)
        Return crudCredit.RetrieveAll(Of Credit)()
    End Function

    Public Function RetrieveById(ByVal credit As Credit) As Credit
        Return crudCredit.Retrieve(Of Credit)(credit)
    End Function

    Public Sub Update(ByVal credit As Credit)
        crudCredit.Update(credit)
    End Sub

    Public Sub Delete(ByVal credit As Credit)
        crudCredit.Delete(credit)
    End Sub

End Class
