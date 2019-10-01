Imports DataAccess1.Crud
Imports Entities_POJO

Public Class vAddressMangement


    Private crudAddress As AddressCrudFactory

    Public Sub New()
        crudAddress = New AddressCrudFactory()
    End Sub

    Public Sub Create(ByVal address As Address)
        crudAddress.Create(address)
    End Sub

    Public Function RetrieveAll() As List(Of Address)
        Return crudAddress.RetrieveAll(Of Address)()
    End Function

    Public Function RetrieveById(ByVal address As Address) As Address
        Return crudAddress.Retrieve(Of Address)(address)
    End Function

    Public Sub Update(ByVal address As Address)
        crudAddress.Update(address)
    End Sub

    Public Sub Delete(ByVal address As Address)
        crudAddress.Delete(address)
    End Sub


End Class
