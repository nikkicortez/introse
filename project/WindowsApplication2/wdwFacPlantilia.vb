﻿Public Class wdwFacPlantilia
    Dim dbAccess As databaseAccessor = New databaseAccessor

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        wdwMainMenu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        wdwDataEntry.Show()
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub wdwFacPlantilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_form()

        Dim Year As New List(Of Object)
        Dim Term As New List(Of Object)
        Dim YearID As Integer


        Year = dbAccess.Get_Multiple_Row_Data("Select concat(yearstart, ' - ', yearend) from academicyear")
        For i As Integer = 0 To Year.Count - 1
            cmbbxAcadYear.Items.Add(Year(i))
        Next

        If (cmbbxAcadYear.Items.Count <> 0) Then
            cmbbxAcadYear.SelectedIndex = 0
        End If

        YearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", "yearid")


        Term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & YearID & "'")
        For i As Integer = 0 To Term.Count - 1
            cmbbxTerm.Items.Add(Term(i))
        Next

        If (cmbbxTerm.Items.Count <> 0) Then
            cmbbxTerm.SelectedIndex = 0
        End If

        If (txtbxSearch.Text = Nothing) Then

            bttnSearch.Enabled = False
            Load_form()

        Else
            bttnSearch.Enabled = True
        End If


    End Sub

    Private Sub Load_form()


        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course', concat(yearstart, ' - ', yearend) 'Academic Year', t.term_no 'Term', concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = courseoffering_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", grid)


    End Sub

    Private Sub cmbbxAcadYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxAcadYear.SelectedIndexChanged
        Dim YearID As Integer
        Dim Term As New List(Of Object)

        YearID = dbAccess.Get_Data("Select yearid from academicyear where concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", "yearid")


        Term = dbAccess.Get_Multiple_Row_Data("Select term_no from term where yearid = '" & YearID & "'")
        For i As Integer = 0 To Term.Count - 1
            cmbbxTerm.Items.Add(Term(i))
        Next
        If (cmbbxTerm.Items.Count <> 0) Then
            cmbbxTerm.SelectedIndex = 0
        End If

        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course',  concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = courseoffering_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", grid)

    End Sub

    Private Sub cmbbxTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxTerm.SelectedIndexChanged
        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course',  concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = courseoffering_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "'", grid)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        popModifyPlantilla.Show()
    End Sub

    Private Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click
        Dim Search As String = Nothing

        Search += "%"
        Search += txtbxSearch.Text
        Search += "%"

        dbAccess.Fill_Data_Grid("Select co.courseoffering_id 'Reference No.', course_cd 'Course', concat(yearstart, ' - ', yearend) 'Academic Year', t.term_no 'Term', concat(f.f_lastname, ', ', f_firstname, ' ', f_middlename) 'Faculty Name', co.section 'Section', co.room 'Room', co.daysched 'Day Sched', co.timestart 'Start Time', co.timeend 'End Time', co.hours 'Hours' 
                                from courseoffering co, course c, term t, academicyear a, faculty f 
                                where c.course_id = courseoffering_id and t.termid = co.termid and t.yearid = a.yearid and f.facref_no = co.facref_no and t.termid = '" & cmbbxTerm.SelectedItem & "' and  concat(yearstart, ' - ', yearend) = '" & cmbbxAcadYear.SelectedItem & "' and ((facultyid LIKE '" + Search.ToString + "') or (f_firstname LIKE '" + Search.ToString + "') or (f_middlename LIKE '" + Search.ToString + "') or (f_lastname LIKE '" + Search.ToString + "')  or (concat(f_firstname,' ', f_middlename, ' ', f_lastname) like '" + Search.ToString + "') or (concat(f_firstname,' ', f_lastname) like '" + Search.ToString + "') or (concat(f_lastname,' ', f_firstname) like '" + Search.ToString + "') or (concat(f_lastname,' ', ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' , ' ',f_firstname) like '" + Search.ToString + "') or (concat(f_lastname, ',' ,f_firstname) like '" + Search.ToString + "'))", grid)


    End Sub

    Private Sub txtbxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtbxSearch.TextChanged
        If (txtbxSearch.Text = Nothing) Then

            bttnSearch.Enabled = False
            Load_form()

        Else
            bttnSearch.Enabled = True
        End If
    End Sub

    Private Sub bttnClear_Click(sender As Object, e As EventArgs) Handles bttnClear.Click
        txtbxSearch.Text = Nothing
    End Sub
End Class