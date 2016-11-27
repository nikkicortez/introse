﻿Public Class popAddMakeUp
    Dim dbAccess As New DatabaseAccessor
    Private Sub AddFacultyName(facultyid As String, ByVal text As TextBox)
        Dim fname As String
        Dim MI As String
        Dim lname As String
        Dim name As String

        name = ""
        fname = ""
        MI = ""
        lname = ""
        Try
            fname = dbAccess.getStringData("Select f_firstname from faculty where facultyid = '" & facultyid & "';", "f_firstname")
            MI = dbAccess.getStringData("Select f_middlename from faculty where facultyid = '" & facultyid & "';", "f_middlename")
            lname = dbAccess.getStringData("Select f_lastname from faculty where facultyid = '" & facultyid & "';", "f_lastname")

            text.Text = fname + " " + MI + " " + lname

        Catch ex As Exception

        End Try

    End Sub
    Private Sub AddCourse(facultyid As String, ByVal combo As ComboBox)
        Dim coursecode As New List(Of String)()
        Dim fac As String = ""
        Try
            fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            coursecode = dbAccess.getMultipleData("SELECT Distinct(c.course_cd) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.course_id = c.course_id;", "course_cd")

            For j As Integer = 0 To coursecode.Count - 1
                combo.Items.Add(coursecode(j))
            Next


        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddSection(facultyid As String, ByVal combo As ComboBox)
        Dim section As New List(Of String)()
        Dim fac As String = ""
        Try
            fac = dbAccess.getStringData("select facref_no from faculty where facultyid = '" & facultyid & "';", "facref_no")
            section = dbAccess.getMultipleData("SELECT Distinct(co.section) FROM course AS c, courseoffering AS co WHERE co.facref_no = '" & fac & "' AND co.status = 'A' AND co.course_id = c.course_id;", "section")

            For j As Integer = 0 To section.Count - 1

                combo.Items.Add(section(j))
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddRemarks(ByVal combo As ComboBox)
        Dim reason As New List(Of String)
        Try
            reason = dbAccess.getMultipleData("SELECT reason_desc FROM reason", "reason_desc")
            For j As Integer = 0 To reason.Count - 1
                combo.Items.Add(reason(j))
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        txtbxFacID.Clear()
        Me.Close()
    End Sub
    Private Sub Form_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.Closed
        wdwFacultyMakeUp.Enable_Form()
    End Sub

    Private Sub bttnAdd_Click(sender As Object, e As EventArgs) Handles bttnAdd.Click
        Dim makeupdate, curDate As Date
        Dim room, reason_cd, fac, course, section, courseoffering_id, course_id As String
        Dim startTime, endTime As DateTime

        Try
            If String.IsNullOrEmpty(cmbbxSec.SelectedItem) Or String.IsNullOrEmpty(txtRoom.Text) Or String.IsNullOrEmpty(txtStart.Text) Or String.IsNullOrEmpty(txtEnd.Text) Or String.IsNullOrEmpty(txtReason.Text) Or String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(cmbbxCourse.SelectedItem) Then
                MsgBox("Incomplete Field!")
            Else
                makeupdate = dtpMakeUpDate.Value.Date
                room = txtRoom.Text
                startTime = Convert.ToDateTime(txtStart.Text)
                endTime = Convert.ToDateTime(txtEnd.Text)
                'MsgBox("start: " + startTime.ToString())
                'MsgBox("end: " + endTime.ToString("HH:mm:ss"))

                reason_cd = dbAccess.getStringData("SELECT reason_cd FROM reason where reason_desc = '" & txtReason.Text & "'", "reason_cd")
                fac = dbAccess.getStringData("SELECT facref_no FROM faculty where facultyid = '" & txtbxFacID.Text & "'", "facref_no")
                course = cmbbxCourse.SelectedItem.ToString
                course_id = dbAccess.getStringData("select course_id from course where course_cd = '" & course & "';", "course_id")
                section = cmbbxSec.SelectedItem.ToString
                courseoffering_id = dbAccess.getStringData("select courseoffering_id from courseoffering where facref_no = '" & fac & "' and course_id = '" & course_id & "' and section = '" & section & "';", "courseoffering_id")
                curDate = Date.Now.Date

                dbAccess.addData("INSERT INTO `introse`.`makeup` (`courseoffering_id`, `timestart`, `timeend`, `room`, `reason_cd`, `makeup_date`, `enc_date`, `encoder`, `status`) VALUES ('" & courseoffering_id & "', '" & startTime.ToString("HH:mm:ss") & "', '" & endTime.ToString("HH:mm:ss") & "', '" & room & "', '" & reason_cd & "', '" & makeupdate.ToString("yyyy-MM-dd") & "', '" & curDate.ToString("yyyy-MM-dd") & "', 'unknown', 'A');")

                dbAccess.fillDataGrid("Select m.makeupid 'Reference', m.makeup_date 'Make-up date', f.facultyid 'Faculty ID', concat(f_lastname, ', ', f.f_firstname, ' ', f_middlename) 'Name', cl.course_cd 'Course', c.section 'Section', m.timestart 'Start time', m.timeend 'End time', m.room 'Room', r.reason_desc 'Reason', m.enc_date 'Date Encoded', m.encoder 'Encoder' 
                                from introse.makeup m, introse.faculty f, introse.course cl, introse.courseoffering c, introse.reason r 
                                where m.courseoffering_id = c.courseoffering_id and c.course_id = cl.course_id and c.facref_no = f.facref_no and m.reason_cd = r.reason_cd and m.status = 'A' and m.enc_date = '" & wdwFacultyMakeUp.dtp.Value.Date.ToString("yyyy-MM-dd") & "' 
                                order by 4, 12;", wdwFacultyMakeUp.grid)
                Me.Close()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub popAddMakeUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bttnAdd.Enabled = False

    End Sub

    Private Sub txtbxFacID_TextChanged(sender As Object, e As EventArgs) Handles txtbxFacID.TextChanged
        cmbbxCourse.Items.Clear()
        cmbbxSec.Items.Clear()
        cmbbxReason.Items.Clear()
        cmbbxReason.ResetText()
        cmbbxCourse.ResetText()
        cmbbxSec.ResetText()
        txtRoom.Clear()
        txtStart.Clear()
        txtEnd.Clear()
        AddFacultyName(txtbxFacID.Text, txtbxFacName)
        'MsgBox(dtpAbsent.Value.Date.ToString("yyyy-MM-dd"))
        AddCourse(txtbxFacID.Text, cmbbxCourse)
    End Sub

    Private Sub cmbbxReason_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxReason.SelectedIndexChanged
        txtReason.Text = cmbbxReason.SelectedItem.ToString
        If String.IsNullOrEmpty(cmbbxSec.SelectedItem) Or String.IsNullOrEmpty(txtRoom.Text) Or String.IsNullOrEmpty(txtStart.Text) Or String.IsNullOrEmpty(txtEnd.Text) Or String.IsNullOrEmpty(txtReason.Text) Or String.IsNullOrEmpty(txtbxFacID.Text) Or String.IsNullOrEmpty(cmbbxCourse.SelectedItem) Then
            bttnAdd.Enabled = False
        Else
            bttnAdd.Enabled = False
        End If

    End Sub

    Private Sub cmbbxCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxCourse.SelectedIndexChanged
        AddSection(txtbxFacID.Text, cmbbxSec)
    End Sub
    Private Sub validateInput(allowed As String, e As KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            If Not allowed.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtbxFacID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxFacID.KeyPress
        validateInput("0123456789", e)
    End Sub
    Private Sub txtRoom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoom.KeyPress
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", e)
    End Sub

    Private Sub txtStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStart.KeyPress
        validateInput("0123456789:", e)
    End Sub
    Private Sub txtEnd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEnd.KeyPress
        validateInput("0123456789:", e)
    End Sub

    Private Sub txtEncoder_KeyPress(sender As Object, e As KeyPressEventArgs)
        validateInput("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", e)
    End Sub

    Private Sub cmbbxSec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbxSec.SelectedIndexChanged
        AddRemarks(cmbbxReason)
    End Sub
End Class