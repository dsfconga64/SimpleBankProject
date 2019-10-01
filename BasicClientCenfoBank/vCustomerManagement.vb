Imports DataAcess.Crud
Imports Entities_POJO

Public Class vCustomerManagement

    Private crudCustomer As CustomerCrudFactory

    Public Sub New()
        crudCustomer = New CustomerCrudFactory()
    End Sub

    Public Sub Create(ByVal customer As Customer)
        crudCustomer.Create(customer)
    End Sub

    Public Function RetrieveAll() As List(Of Customer)
        Return crudCustomer.RetrieveAll(Of Customer)()
    End Function

    Public Function RetrieveById(ByVal customer As Customer) As Customer
        Return crudCustomer.Retrieve(Of Customer)(customer)
    End Function

    Public Sub Update(ByVal customer As Customer)
        crudCustomer.Update(customer)
    End Sub

    Public Sub Delete(ByVal customer As Customer)
        crudCustomer.Delete(customer)
    End Sub

End Class
