﻿Public Class wdwNotices
    Dim choice As Integer
    Dim repGen As New reportGenerator
    Dim dbAccess As New databaseAccessor
    Dim index As Integer

    Private Sub wdwNotices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()
    End Sub

    Private Sub Load_form()
        dbAccess.Fill_Data_Grid("Select distinct f.facultyid 'Faculty ID', concat(f.f_lastname, ', ', f.f_firstname, ' ', f.f_middlename) 'Name', a.absent_date 'Absent date', a.report_status 'Report status'
                                from introse.attendance a, introse.faculty f, introse.courseoffering c
                                where a.courseoffering_id = c.courseoffering_id and c.facref_no = f.facref_no and a.status = 'A' and c.status = 'A' and f.status = 'A' and a.enc_date = '" & dtp.Value.Date.ToString("yyyy-MM-dd") & "'
                                order by 3, 2;", grid)
    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Load_form()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        With grid
            Dim selectedRow As DataGridViewRow
            If .SelectedRows.Count = 0 Then
                MsgBox("No row selected!", MsgBoxStyle.Critical, "")

            ElseIf .SelectedRows.Count = 1 Then
                selectedRow = grid.Rows(index)
                If (repGen.Generate_Faculty_Daily_Notice(selectedRow.Cells(0).Value.ToString(), selectedRow.Cells(1).Value.ToString(), dtp.Value)) Then
                    Me.Close()
                End If

            Else
                MsgBox("Too many rows selected!", MsgBoxStyle.Critical, "")

            End If
        End With
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        wdwMainMenu.Show()

    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles bttnClear.Click

    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        index = e.RowIndex
    End Sub
End Class