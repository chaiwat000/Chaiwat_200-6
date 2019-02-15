Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration


Public Class frm_LAP11
    Dim strcon As String = ConfigurationManager.ConnectionStrings("VB_Chaiwat_200_6.My.MySettings.strCon").ConnectionString
    Dim con As New SqlConnection(strcon)
    Dim sql As String
    Dim cmd As SqlCommand
    Dim DA As SqlDataAdapter
    Dim DS As DataSet
    Dim dt As DataTable

    Private Sub _connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub

    Private Function cmd_Datatable()
        DA = New SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from Products where ProductName like 'N%' "
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub frm_LAP11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _connect()
            MessageBox.Show("เชื่อมต่อฐานข้อมูลสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("เชื่อมต่อฐานข้อมูลไม่สำเร็จ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sql = "select UnitPrice , UnitsInStock ,(UnitPrice * UnitsInStock) AS Total from Products  where ProductID = '64' "
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sql = "select count(*) As Total from Customers where Country like '%Brazil%'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sql = "select  ProductName,Quantity,ContactName from Order_Details,Orders,Products,Customers where Orders.CustomerID = Customers.CustomerID AND Order_Details.OrderID = Orders.OrderID AND Order_Details.ProductID = Products.ProductID AND ContactName = 'Yang Wang'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sql = "select ProductName,UnitPrice,UnitsInStock from Products where UnitsInStock < '10'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sql = "select Order_Details .*,ProductName from Order_Details,Products  where Order_Details.ProductID = Products.ProductID AND OrderID = '10255';"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sql = "select Freight from Orders where OrderID = '10255'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        sql = "select ContactName,CompanyName ,ContactTitle ,city,PostalCode,Phone ,Fax  from customers,orders where Customers.CustomerID = Orders.CustomerID AND OrderID = '10347'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        sql = "select ProductName,Quantity,CompanyName from Products,Suppliers,Order_Details where Order_Details.ProductID = Products.ProductID AND Products.SupplierID = Suppliers.supplierID AND CompanyName = 'Exotic Liquids'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        sql = "select count(*) As Total from Orders where ShipCountry like '%Italy%'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnSpe_Click(sender As Object, e As EventArgs) Handles btnSpe.Click
        sql = "select ProductID , ProductName from Products where UnitsOnOrder = '0'"
        datagirdSHOW.DataSource = cmd_Datatable()
    End Sub
End Class