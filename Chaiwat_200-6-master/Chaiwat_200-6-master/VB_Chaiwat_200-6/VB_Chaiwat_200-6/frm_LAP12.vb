Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frm_LAP12
    Dim strcn As String = ConfigurationManager.ConnectionStrings("VB_Chaiwat_200_6.My.MySettings.strcn").ConnectionString
    Dim con As New SqlConnection(strcn)
    Dim sql As String
    Dim DA As SqlDataAdapter
    Dim DS As DataSet
    Dim cmd As SqlCommand
    Dim DR As SqlDataReader

    Dim status As String
    Dim memid As String

    Private Sub connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

    End Sub

    Private Function Datatable()

        DA = New SqlDataAdapter(sql, con)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function



    Private Sub frm_LAP12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        sql = "select dep_name from department"
        cmd = New SqlCommand(sql, con)
        DR = cmd.ExecuteReader()

        If DR.HasRows Then
            While DR.Read
                cboDepartment.Items.Add(DR.Item("dep_name"))
            End While
        End If
        DR.Close()


        sql = "select emp_id,emp_name,emp_Lname,IIF(emp_gender=1, 'ชาย', 'หญิง') As Gender ,emp_address,emp_salary,dep_id from employee"
        dtgv.DataSource = Datatable()

        con.Close()
        cboDepartment.SelectedIndex = 0
        Panel1.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        status = "insert"
        Panel1.Enabled = True
        txtId.Select()
        txtAdd.Clear()
        txtId.Clear()
        txtName.Clear()
        txtLastname.Clear()
        txtSalary.Clear()
        cboDepartment.SelectedIndex = 0

        radMale.Checked = True
        dtgv.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnExit.Enabled = False

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtId.Text = txtId.Text.Trim
        txtName.Text = txtName.Text.Trim
        txtLastname.Text = txtLastname.Text.Trim
        txtSalary.Text = txtSalary.Text.Trim
        txtAdd.Text = txtAdd.Text.Trim
        If txtId.Text = "" Or txtName.Text = "" Or txtLastname.Text = "" Or txtAdd.Text = "" Or txtSalary.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครับ")
            Exit Sub
        End If

        If Not IsNumeric(txtSalary.Text) Then
            MessageBox.Show("กรุณากรอกตัวเลข")
            txtSalary.Select()
            Exit Sub
        End If

        Dim gender As Boolean
        If radMale.Checked = True Then
            gender = True
        Else
            gender = False
        End If
        connect()

        If status = "insert" Then


            sql = "select emp_id from employee where emp_id = @eid"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("eid", txtId.Text)
                DR = cmd.ExecuteReader()

            If DR.HasRows Then
                MessageBox.Show("ข้อมูลที่ add เข้ามีอยู่แล้ว")
                DR.Close()
                Exit Sub

            End If
            DR.Close()

            sql = "insert into employee (emp_id ,emp_name ,emp_lname ,emp_gender ,emp_address ,emp_salary ,dep_id) values(@1 ,@2 ,@3 ,@4 ,@5 ,@6  ,(select dep_id from department where dep_name = '" & cboDepartment.SelectedItem & "'))"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("1", txtId.Text)
                .AddWithValue("2", txtName.Text)
                .AddWithValue("3", txtLastname.Text)
                .AddWithValue("4", gender)
                .AddWithValue("5", txtAdd.Text)
                .AddWithValue("6", txtSalary.Text)

            End With

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("ADD Fail")
            Else
                MsgBox("ADD OK")

                txtAdd.Clear()
                txtId.Clear()
                txtName.Clear()
                txtLastname.Clear()
                txtSalary.Clear()
                cboDepartment.SelectedIndex = 0
                radFemale.Checked = False
                radMale.Checked = False
                Panel1.Enabled = False

                sql = "select emp_id,emp_name,emp_Lname,IIF(emp_gender=1, 'ชาย', 'หญิง') As Gender ,emp_address,emp_salary,dep_id from employee "
                DA = New SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dtgv.DataSource = DS.Tables("table")

                dtgv.Enabled = True
                Panel1.Enabled = False
                btnAdd.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnExit.Enabled = True
            End If

        Else

            If memid <> txtId.Text Then
                sql = "select emp_id from employee where emp_id = @eid"
                cmd = New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("eid", txtId.Text)
                DR = cmd.ExecuteReader()

                If DR.HasRows Then
                    MessageBox.Show("ข้อมูลที่แก้ไขเข้ามีอยู่แล้ว")
                    DR.Close()
                    Exit Sub
                End If
            End If
            DR.Close()



            sql = "update employee set emp_id=@1,emp_name=@2 ,emp_Lname=@3 ,emp_gender=@4 ,emp_address=@5 ,emp_salary=@6 ,dep_id = (select dep_id from department where dep_name = '" & cboDepartment.SelectedItem & "') where emp_id = @eid"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.Clear()
            With cmd.Parameters
                .AddWithValue("1", txtId.Text)
                .AddWithValue("2", txtName.Text)
                .AddWithValue("3", txtLastname.Text)
                .AddWithValue("4", gender)
                .AddWithValue("5", txtAdd.Text)
                .AddWithValue("6", txtSalary.Text)
                .AddWithValue("eid", memid)
            End With


            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("Edit Fail")
            Else
                MsgBox("Edit OK")

                txtAdd.Clear()
                txtId.Clear()
                txtName.Clear()
                txtLastname.Clear()
                txtSalary.Clear()
                cboDepartment.SelectedIndex = 0
                radFemale.Checked = False
                radMale.Checked = False
                Panel1.Enabled = False

                sql = "select emp_id,emp_name,emp_Lname,IIF(emp_gender=1, 'ชาย', 'หญิง') As Gender ,emp_address,emp_salary,dep_id from employee"
                DA = New SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dtgv.DataSource = DS.Tables("table")

                dtgv.Enabled = True
                Panel1.Enabled = False
                btnAdd.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnExit.Enabled = True
            End If
        End If

        con.Close()
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Panel1.Enabled = True
        memid = txtId.Text
        status = "update"
        Panel1.Enabled = True
        txtId.Select()

        cboDepartment.SelectedIndex = 0

        radMale.Checked = True
        dtgv.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnExit.Enabled = False
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connect()

        Dim delete_ As DialogResult = MessageBox.Show("คุณต้องการลบข้อมูลพนักงานหรือไม่", "ลบพนักงาน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Dim i As Integer = dtgv.CurrentRow.Index
        Dim delete_id As String = dtgv.Item(0, i).Value

        If delete_ = DialogResult.Yes Then
            sql = "delete from employee where emp_id = @eid"
            cmd = New SqlClient.SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("eid", txtId.Text)

            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("delete fail")
            Else
                MsgBox("delete success")

                sql = "select emp_id,emp_name,emp_Lname,IIF(emp_gender=1, 'ชาย', 'หญิง') As Gender ,emp_address,emp_salary,dep_id from employee"
                DA = New SqlClient.SqlDataAdapter(sql, con)
                DS = New DataSet
                DA.Fill(DS, "table")
                dtgv.DataSource = DS.Tables("table")
            End If

        Else

        End If

        con.Close()

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellEnter
        connect()
        Dim i As Integer = dtgv.CurrentRow.Index
        Dim select_ As String = dtgv.Item(0, i).Value
        sql = "select employee.*,department.dep_id from employee,department where employee.dep_id = department.dep_id and emp_id = @did"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("did", select_)
        DR = cmd.ExecuteReader
        DR.Read()

        txtId.Text = dtgv.Item(0, i).Value
        txtName.Text = dtgv.Item(1, i).Value
        txtLastname.Text = dtgv.Item(2, i).Value

        txtAdd.Text = dtgv.Item(4, i).Value
        txtSalary.Text = dtgv.Item(5, i).Value
        cboDepartment.SelectedItem = dtgv.Item(6, i).Value

        If DR.Item("emp_gender") = True Then
            radMale.Checked = True
        Else
            radFemale.Checked = True
        End If
        DR.Close()
        con.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Panel1.Enabled = False
        txtId.Select()
        txtAdd.Clear()
        txtId.Clear()
        txtName.Clear()
        txtLastname.Clear()
        txtSalary.Clear()
        cboDepartment.SelectedIndex = 0

        radMale.Checked = True
        dtgv.Enabled = True
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnExit.Enabled = True
    End Sub
End Class